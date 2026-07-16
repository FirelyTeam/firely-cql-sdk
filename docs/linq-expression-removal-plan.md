# Replacing System.Linq.Expressions with a typed IR

Status: **phases 0–1 merged** ([#1311](https://github.com/FirelyTeam/firely-cql-sdk/pull/1311)); phase 2 in progress.

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
ELM → ExpressionBuilderContext (~2,460 lines, switch over ELM nodes)
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
ELM → ExpressionBuilderContext (ported, same dispatch shape) → typed IR (nodes carry System.Type)
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
| 2 | Typed IR nodes + validating factories; `CSharpEmitter` reproducing current output | in progress |
| 3 | Port `CqlOperatorsBinder` + partials onto the IR (algorithm unchanged) | |
| 4 | Port `ExpressionBuilderContext` + partials (FHIRHelpers workarounds, choice types, query machinery) | |
| 5 | Dual-pipeline flag, golden diffs across all corpora + full suites, flip default | |
| 6 | Delete the Expression-based builder/binder/visitors/custom expressions; bump generator version | |

Post-parity cleanups (once the old pipeline is gone and byte-identical output no longer
constrains the emitter): multi-branch conditionals whose branches are all simple can print as
C# `switch` expressions instead of `if`/`else if` chains (statement form stays as the general
fallback for branches that hoist locals), and the printing backend itself is swappable — e.g.
emitting Roslyn syntax trees from the IR for normalized formatting.

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

- Phases 2–5: golden-file byte comparison of generated C# (old vs. new pipeline) across
  `LibrarySets\RR23`, `dqm-content-qicore-2025`, and demo measures; full `CqlToElmTests` +
  `CoreTests` suites against the new pipeline behind the flag before flipping.
- End-to-end: `Examples\CqlSdkExamples` and `Demo` measure runs must produce identical
  results under both pipelines.

## What gets deleted / rewritten / kept

- **Deleted** (~1,800 lines): `Cql.Compiler\Expressions\*`, `CodeGeneration.NET\Visitors\*`,
  `CqlExpressions.cs`.
- **Rewritten onto the IR** (~4,200 lines, mostly mechanical): `ExpressionBuilderContext.cs`
  + partials, `CqlOperatorsBinder.*`, `CqlContextBinder.cs`, `LambdaDefinitionWriter`
  (becomes the emitter; much print logic ports verbatim), `CqlDefinition`/`CqlLambdaDefinition`.
- **Kept unchanged**: `TypeResolver`/`TypeConverter`, `TupleBuilderCache`,
  `TypeToCSharpConverter`, `IndentedStringBuilder`, `VariableNameGenerator`,
  `CacheKeyGenerator`, `AssemblyCompiler`, `LibraryWriter`/`LibrarySetWriter`/
  `DefinitionWriter` scaffolding, all of Cql.Runtime/`ICqlOperators`, the ELM model, the
  CqlToElm front-end.
