# Replacing System.Linq.Expressions with a typed IR

Status: **all phases complete.** Phases 0–1 merged to develop
([#1311](https://github.com/FirelyTeam/firely-cql-sdk/pull/1311)); phases 2–5 merged to
`feature/linq-expr-removal` as a stacked PR chain
([#1331](https://github.com/FirelyTeam/firely-cql-sdk/pull/1331) →
[#1340](https://github.com/FirelyTeam/firely-cql-sdk/pull/1340) →
[#1344](https://github.com/FirelyTeam/firely-cql-sdk/pull/1344) →
[#1346](https://github.com/FirelyTeam/firely-cql-sdk/pull/1346) →
[#1378](https://github.com/FirelyTeam/firely-cql-sdk/pull/1378) →
[#1392](https://github.com/FirelyTeam/firely-cql-sdk/pull/1392) →
[#1394](https://github.com/FirelyTeam/firely-cql-sdk/pull/1394)) with golden parity proven
byte-identical between pipelines on all three corpora: RR23, dqm-content-qicore-2025
(CMS56), and the complete HEDIS 2025 corpus (382 libraries; the two HEDIS-surfaced blocking
bugs [#1361](https://github.com/FirelyTeam/firely-cql-sdk/issues/1361) /
[#1362](https://github.com/FirelyTeam/firely-cql-sdk/issues/1362) fixed, six cosmetic
divergence classes aligned — see the post-parity ledger). Phase 6 then deleted the
Expression-based pipeline outright (−8,097 lines): the `UseIrPipeline` flag is gone (never
released, so removed rather than deprecated), the typed IR is the only pipeline, and every
test suite plus the HEDIS compile-all guard runs through it. `GeneratedCodeAttribute`'s
tool version was **not** bumped — a deliberate deviation from the plan below, since the
IR pipeline's output is byte-identical to the old writer's. The old pipeline's parity
reference is its final commit,
[`85207efd5`](https://github.com/FirelyTeam/firely-cql-sdk/commit/85207efd5). What remains
is merging `feature/linq-expr-removal` to develop and the deferred post-parity cleanups
(checklist below).

## Context

The SDK compiles ELM to C# by first building `System.Linq.Expressions` trees. That layer
originally bought us in-memory execution (`Expression.Compile()`) without going through C#,
but nothing uses that anymore: since #1311, tests and production share the same
ELM → C# → assembly path. Meanwhile the Expression layer costs us:

- 5 custom `Expression` subclasses for things Linq.Expressions can't represent
  (`?.`, case/when chains, definition-dictionary calls), each with `Reduce()` bodies that
  existed only to keep the now-removed `Compile()` path working;
- 4 `ExpressionVisitor` rewrite passes between building and printing
  (`RedundantCastsTransformer`, `SimplifyExpressionsVisitor`, `RenameVariablesVisitor`,
  `LocalVariableDeduper` — the last dedups via the expensive internal `DebugView` string);
- a structural mismatch: expression trees are expression-only, while the generated C# is
  statement-shaped (`var a_ = ...;` sequences), forcing the lambda-wrap + `Invoke` tricks in
  `SimplifyExpressionsVisitor`.

**Current pipeline:**

```
ELM → CodeBuilderContext (~2,460 lines, switch over ELM nodes)
    → Linq Expression tree (+ 5 custom Expression subclasses)
    → 4 visitor passes
    → LambdaDefinitionWriter (~770 lines) → C# text
    → AssemblyCompiler (Roslyn parse + emit) → assembly
```

## Decision

Replace Linq.Expressions with a **small custom typed IR that prints C# text** — not a Roslyn
`SyntaxNode` tree.

Why not Roslyn syntax trees: the builder's reliance on per-node `System.Type` is total
(~196 `.Type` usages in Cql.Compiler; the entire `CqlOperatorsBinder` overload resolution
scores candidates from ~490 `ICqlOperators` signatures by attempting per-argument conversions
against the argument expressions' types, including generic inference and the trailing-null
precision retry). The .NET type of a subexpression is not recoverable from ELM alone:
`TypeFor` falls back to the built expression's type for scopes/aliases, property types come
from reflection over model assemblies, and tuple types are reflection-emitted by
`TupleBuilderCache`. Roslyn nodes are untyped, so choosing them means rebuilding
Linq.Expressions' type propagation by hand *and* fighting Roslyn's verbosity and
trivia/formatting to keep the current readable output. The only thing Roslyn trees guarantee —
syntactic well-formedness — a small IR printer also provides, and `AssemblyCompiler` already
round-trips through text.

A typed IR keeps exactly what we use from Linq.Expressions (a typed tree with
construction-time validation) and drops what we fight (expression-only nesting, `Reduce()`
contortions, `ParameterExpression` identity quirks, the visitor pipeline).

## Target architecture

```
ELM → CodeBuilderContext (ported, same dispatch shape) → typed IR (nodes carry System.Type)
    → DefinitionDictionary<CqlDefinition> (decoupled from Expression)
    → CSharpEmitter (statement-aware printer; replaces 4 visitors + LambdaDefinitionWriter)
    → C# text → AssemblyCompiler (unchanged)
```

**The IR:** ~20 sealed record node kinds — `Constant`, `Null(Type)`,
`OperatorCall(MethodInfo, args)`, `DefinitionCall`, `FunctionCall`,
`Property(receiver, MemberInfo, nullConditional)`, `Cast`/`As`/`Is`, `Conditional`, `IfChain`,
`New`/`MemberInit`, `NewArray`, `Lambda`, `Local(name, Type)`, `Coalesce`, `Binary(op)`,
`Default`, `Block`, `LocalFunction`. Every node exposes `Type`; factory methods validate
(parameter assignability, cast legality) and throw `ExpressionBuildingException` with the ELM
element-stack context — preserving today's early type errors with ELM traceability instead of
late Roslyn diagnostics against generated code.

**Key simplification:** the IR is statement-aware. The emitter linearizes nested expressions
into `var a_ = ...;` sequences at print time (reusing `VariableNameGenerator`), dedups locals
by structural equality, and strips redundant casts as a print-time peephole. `IfChain` prints
as native `if`/`else`.

## Complications and their resolutions

1. **Type tracking**: keep `System.Type` on every IR node; `TypeResolver`, `TypeConverter`,
   the `TypeFor` logic and `TupleBuilderCache` stay as-is. Tuple types remain
   reflection-emitted purely as type identities for overload resolution and printing.
2. **What `Expression.Call`/`Expression.Convert` did silently** must move into IR factories:
   explicit `MethodInfo` resolution via `CqlOperatorsMethodsCache`, construction-time argument
   validation, cast-legality checks. Without these, type bugs would surface only as C# compile
   errors with no ELM context.
3. **Variable identity and scoping**: today `ParameterExpression` *reference identity* scopes
   query aliases, with names fixed late by `RenameVariablesVisitor`. IR `Local` nodes keep
   reference identity, with name allocation deferred to the emitter. This is the most
   bug-prone area of the port — design it deliberately, review it first.
4. **The custom Expressions all become trivial**: `?.`, `if/else` chains and plain calls
   exist natively in the IR/C#; their `Reduce()` bodies had no other consumers.
5. **Visitor passes**: `SimplifyExpressionsVisitor` and `RenameVariablesVisitor` become the
   emitter's linearizer/name allocator; `RedundantCastsTransformer` becomes a print-time
   peephole; `LocalVariableDeduper` becomes structural equality on IR (fixing its documented
   perf problem).
6. **Output stability**: the golden-file tests added in #1311
   (`CoreTests\CSharpGenerationGoldenTests.cs`, over `LibrarySets\RR23` and the
   dqm-content-qicore-2025 CMS56 closure) define parity. Target byte-identical output; keep an
   explicitly reviewed whitelist for unavoidable diffs. Bump the `GeneratedCode` version only
   at flip-over.
7. **Public API**: no blocker — `Cql.Compiler`'s shipped public API is empty and
   `LambdaExpression` doesn't leak publicly.
8. **Migration shape**: per-ELM-node incremental migration inside one builder is impractical
   (subtrees compose; Expression and IR nodes can't interleave without throwaway adapters).
   Instead: big-bang within the builder, incremental at the repo level — the new pipeline
   lives in parallel namespaces behind an `ElmToolkitConfig` flag, is golden-diffed against
   the old pipeline until parity, then flipped and the old one deleted. The seam is clean:
   both pipelines produce a `DefinitionDictionary` consumed by
   `LibrarySetCSharpCodeGenerator`; only the `LambdaDefinitionWriter` partial is
   Expression-aware.

## Phases

Phase branches are reviewed via PRs against the aggregation branch
`feature/linq-expr-removal` (cut from develop), not against develop directly; the feature
branch merges to develop once the migration is complete (or at a reviewed intermediate
milestone). Phases 0–1 predate this and were merged to develop directly — they were
standalone fixes.

| Phase | Work | Status |
|---|---|---|
| 0 | Delete dead visitors; golden regeneration tests over `LibrarySets\` corpora | ✅ merged (#1311) |
| 1 | Decouple tests from `Expression.Compile()`; cache metadata references in `AssemblyCompiler` | ✅ merged (#1311) |
| 2 | Typed IR nodes + validating factories; `CSharpEmitter` reproducing current output | ✅ merged into feature branch ([#1331](https://github.com/FirelyTeam/firely-cql-sdk/pull/1331)) |
| 3 | Port `CqlOperatorsBinder` + partials onto the IR (algorithm unchanged) | ✅ merged into feature branch ([#1340](https://github.com/FirelyTeam/firely-cql-sdk/pull/1340)) |
| 4 | Port `CodeBuilderContext` + partials (FHIRHelpers workarounds, choice types, query machinery) | ✅ merged into feature branch ([#1344](https://github.com/FirelyTeam/firely-cql-sdk/pull/1344)) |
| 5 | Dual-pipeline flag, golden diffs across all corpora + full suites, flip default | ✅ merged into feature branch; parity proven on RR23 + CMS56 + HEDIS 2025 ([#1346](https://github.com/FirelyTeam/firely-cql-sdk/pull/1346), [#1378](https://github.com/FirelyTeam/firely-cql-sdk/pull/1378)) |
| 6 | Delete the Expression-based builder/binder/visitors/custom expressions; cleanup | ✅ merged into feature branch ([#1392](https://github.com/FirelyTeam/firely-cql-sdk/pull/1392), [#1394](https://github.com/FirelyTeam/firely-cql-sdk/pull/1394)); generator version intentionally unchanged because output stayed byte-identical |

Post-parity cleanups (once the old pipeline is gone and byte-identical output no longer
constrains the emitter): multi-branch conditionals whose branches are all simple can print as
C# `switch` expressions instead of `if`/`else if` chains (statement form stays as the general
fallback for branches that hoist locals), and the printing backend itself is swappable — e.g.
emitting Roslyn syntax trees from the IR for normalized formatting. The phase-5 grind added
several faithfully-replicated old quirks worth revisiting (all documented at their emitter
sites): duplicate eliminations burn a letter from the naming sequence (visible gaps);
the multi-branch conditional form carries a stray `;` after its final else block;
redundant `as object` casts survive exactly when they were built from the ELM
`as`/`cast` operator (tracked via `CodeCast.FromCqlAsOperator`) — an accident of the old
visitor ordering (`ElmAsExpression` reduced only at print time, after
`RedundantCastsTransformer`'s single pass), not a design choice; a binary expression's
RIGHT operand is never parenthesized (`g_ ?? h_ as IEnumerable<...>`) — the old
`BuildBinaryExpression` only guarded the left side, a latent precedence hazard replicated
for parity; lambda-parameter alias names print verbatim with NO collision handling — the
old pipeline never renamed parameters, so a repeated alias prints repeated (#1343) and a
nested lambda's alias shadows an ancestor's (HEDIS PCR_Details' nested `stay` lambdas),
legal C# only because local functions may shadow; a when-condition that is itself a
non-simple conditional prints fully inline, branches and all (the old trial visit counted
the whole hoisted case-lambda as a single assignment). One deliberate DEVIATION from the
old pipeline (no corpus exercises it): a CQL alias that is a C# keyword falls back to a
generated name, where the old writer printed a non-compiling `@keyword`-escaped
declaration with unescaped references.

### Findings from phases 2–4

- **The IR node set held.** The full builder port (all ELM constructs: queries, tuples,
  retrieves, FHIR property null-propagation, definition/function calls) required **zero new
  node kinds** and left no unresolved `FIXME(phase4-review)` markers — the ~18 kinds designed
  in phase 2 from the `Expression.*` usage survey were sufficient. The first end-to-end
  execution of the new pipeline (ten CQL constructs, `CodeModelPipelineTests`) passed without a
  single builder fix.
- **Complication #3 (variable identity) was cheaper than predicted.** `CodeLocal` reference
  identity slotted in mechanically for `ParameterExpression` identity; the only subtlety
  found was pre-existing (`WithToSelectManyBody` creates two same-alias parameters, #1343).
- **More reuse than planned**: the exception-context machinery
  (`IBuilderContext`/`ExpressionBuildingError`), the generic `DefinitionDictionary<T>`, and
  `CqlOperatorsMethodsCache` are all Expression-free and shared by both pipelines instead of
  duplicated.
- **One deliberate shape change**: definition lambdas no longer carry an explicit
  `CqlContext` parameter — the well-known `CodeContextParameter.Instance` is referenced
  directly, and `CodeDefinitionCall` carries it as `arguments[0]`. Phase 5's
  `DefinitionWriter` integration must account for this.
- **Preserve-vs-fix policy, refined by practice**: anything that could change a *binding
  outcome* is preserved bug-for-bug and tracked (#1341 generic-inference indexing, #1342
  dead `Includes`/`IncludedIn` mismatch check, #1343); crash-path and diagnostics-only
  defects may be fixed in the IR copy with a `NOTE` + issue (#1345 lists them for the old
  binder, should it ever need the fixes before deletion).
- **Phase-5 wiring landmine** (flagged during the LibraryDefs port): external-function
  stubs register a `DefinitionSignature` with a synthetic leading context type inherited
  from the old lambda shape — inert today, but whoever wires definition emission must not
  key lookups off it.

### Findings from phase 5

The RR23 and dqm-content-qicore-2025 (CMS56) golden corpora are small enough that both
pipelines have produced byte-identical output through phases 2–4. As a broader real-world
check before trusting that parity, we regenerated the full HEDIS 2025 CQL corpus (382
libraries, NCQA's `HEDIS-2025-Staging` ELM) through the IR pipeline
(`ElmToolkitConfig.UseIrPipeline = true`) via `PackagerCLI` and diffed it against the same
corpus generated by the Expression-based pipeline. This is a materially bigger and more
varied corpus than either existing golden set and it caught two IR-pipeline bugs neither
one exercises:

- **[#1361](https://github.com/FirelyTeam/firely-cql-sdk/issues/1361)** — the IR emitter's
  `Coalesce` printer is missing the "left operand is already a non-null constant" peephole
  that `RedundantCastsTransformer` has, so CQL's `Message(source, true, ...)` idiom prints
  as the invalid `true ?? false` (CS0019). `FHIRHelpers-4.0.1` and `CQL_Common-2025.2.1`
  both hit this, and because most HEDIS libraries depend on one of the two, the failure
  cascades into 286 of 382 libraries failing to compile to assemblies.
- **[#1362](https://github.com/FirelyTeam/firely-cql-sdk/issues/1362)** — tuple-literal
  construction in the IR pipeline positionally emits values in the ELM-authored element
  order instead of the tuple type's canonical declared property order (the old pipeline's
  `Expression.MemberInit` is name-keyed and re-sorted by name at print time, so it never
  had this bug). Four libraries fail to compile because the transposed fields have
  different .NET types; two — `W30_Elements` and `WCV_Elements` — compile *silently* with
  `procedureCodes` and `diagnosisCodes` swapped, because both fields share the same
  .NET type. That silent case is the more serious of the two: it produces no compiler
  error and no exception, only wrong data, and would only be caught by an exact output
  comparison like this one.

Unlike RR23 and dqm-content-qicore-2025 (whose sources are public and openly licensed),
the full HEDIS 2025 corpus is NCQA-licensed commercial content, so it cannot live in this
(public) repo's `LibrarySets/` the way those two do. It's vendored instead in the private
`Firely.Cql.Sdk.Integration.Runner` repo (`Hedis2025/`), with a permanent guard alongside
it, `Hedis2025.GoldenTests`. During phases 2–5 that guard asserted byte-identical generated
C# between the two pipelines across the whole corpus (both #1361 and #1362 — new defects
introduced by the IR port itself, not old-pipeline bugs being faithfully replicated — were
fixed to make it pass). Phase 6 deleted the Expression-based pipeline, so the comparison
target no longer exists; the guard is now `HEDIS_2025_CompilesToAssemblies`, which
exercises the IR pipeline end to end over all 382 libraries.

### Phase 6 checklist (accumulated `FIXME(phase6)` markers)

Done in phase 6 itself:

- ~~Unify the IR binder's `InvalidOperationException` + `FormatCannotBindMessage` with
  `CannotBindToCqlOperatorError` (generalize the error type off `Expression[]`).~~
  Done — the error type now carries `Type[]`.
- ~~Relocate `CqlOperatorsMethodsCache` out of the deleted `CqlOperatorsBinder`.~~
  Done — now `Cql.Compiler\CqlOperatorsMethodsCache.cs`.
- ~~Consolidate the duplicated assign-to-type helpers (`CodeExpressionExtensions` vs. the
  binder's private phase-3 copies).~~ Done — consolidated onto `CodeExpressionExtensions`.
- ~~Review #1343.~~ Retired — develop's semi-join compilation of `with`/`without`
  (#1366) replaced `WithToSelectManyBody`, and the IR side ports it as
  `WithToExistenceCheck`.

Output-neutral cleanups, done on the feature branch before the develop merge (all proven
byte-identical against the golden corpora):

- ~~Drop the now-redundant `Ir` prefix from the IR-side type names (e.g.
  `IrLibrarySetCSharpCodeGenerator`) now that there is no Expression-side counterpart
  to disambiguate from.~~ Done — the pipeline orchestration classes took back the names
  their deleted counterparts held (`CqlOperatorsBinder`, `CodeBuilderContext`, the
  `CqlDefinition` family, `LibrarySetCSharpCodeGenerator`, …). The IR node vocabulary
  (`CodeExpression`, `CodeConstant`, …, plus `CSharpEmitter`/`CodeTypeRules`/
  `CodeExpressionExtensions`) keeps the prefix: there it is descriptive, not a
  disambiguator.
- ~~Scrub the migration narrative from doc comments: the "IR counterpart of the old X" /
  "phase N of the Linq.Expressions removal" framing made sense while both pipelines
  coexisted, but reads as noise once this is simply *the* pipeline.~~ Done — doc comments
  now describe what each type does; the history lives in this document and at commit
  `85207efd5`. Inline `//` comments that cite old-writer mechanisms by name are kept
  deliberately: they document the bug-for-bug quirks and point into `85207efd5`.

Deferred to post-merge cleanup — output-changing, so each lands as a develop PR with
regenerated goldens as the review artifact (the first one also bumps the
`GeneratedCodeAttribute` version deferred in phase 6):

- Revisit `CqlCodeDefinition.ReturnType` (parity-preserved `typeof(CqlCodeDefinition)`).
- Fix the tracked upstream bugs in one place: #1341, #1342; close #1345.
- Replace the hoisted zero-parameter local functions for conditional chains with native
  `if`/`else` statements (an old-writer shape kept for golden parity).
- The quirk ledger above (burned-letter naming gaps, the stray `};`, the as-object
  ordering accident).
- Remove the remaining `NOTE(phase3)`/`NOTE(phase4)` markers as each is resolved.

### Findings from phases 0–1

- Routing tests through the C# path immediately exposed two real generator bugs that
  production was carrying (illegal `is` patterns for nullable/tuple types; non-compiling
  casts when the printed operand type is narrower than the expression type) — evidence that
  unifying the execution paths was worth doing regardless of the migration.
- The conversion was CI-timing-neutral (suite ~9m before and after): per-test CQL parsing
  dominates, and metadata-reference caching absorbs the added Roslyn compilations.
- Runtime CQL errors now surface unwrapped (the invoker uses
  `BindingFlags.DoNotWrapExceptions`); anything relying on `TargetInvocationException`
  wrapping should not.

## Verification

- The dual-pipeline parity proof was completed before the Expression-based pipeline was
  deleted: generated C# was byte-compared across all three golden corpora — `LibrarySets\RR23`,
  `dqm-content-qicore-2025`, and the full NCQA HEDIS 2025 corpus (382 libraries) — and found
  identical in every case.
- Post-deletion, correctness is pinned by the golden corpora themselves: `CoreTests` (incl. RR23
  + CMS56 golden-regeneration tests) and `CqlToElmTests` must pass, and the HEDIS 2025
  end-to-end test (`HEDIS_2025_CompilesToAssemblies`) must compile all 382 libraries to
  assemblies without error.

## What gets deleted / rewritten / kept

- **Deleted** (~1,800 lines): `Cql.Compiler\Expressions\*`, `CodeGeneration.NET\Visitors\*`,
  `CqlExpressions.cs`.
- **Rewritten onto the IR** (~4,200 lines, mostly mechanical): `CodeBuilderContext.cs`
  + partials, `CqlOperatorsBinder.*`, `CqlContextBinder.cs`, `LambdaDefinitionWriter`
  (becomes the emitter; much print logic ports verbatim), `CqlDefinition`/`CqlLambdaDefinition`.
- **Kept unchanged**: `TypeResolver`/`TypeConverter`, `TupleBuilderCache`,
  `TypeToCSharpConverter`, `IndentedStringBuilder`, `VariableNameGenerator`,
  `CacheKeyGenerator`, `AssemblyCompiler`, `LibraryWriter`/`LibrarySetWriter`/
  `DefinitionWriter` scaffolding, all of Cql.Runtime/`ICqlOperators`, the ELM model, the
  CqlToElm front-end.
