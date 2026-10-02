# 1. Completing the .NET CQL-to-ELM translator

Status: **proposal, not started.** This document defines what "complete" means for
[`Hl7.Cql.CqlToElm`](../Cql/Cql.CqlToElm/README.md), measures where the translator stands
today against the CQL corpora in this repository, and lays out a phased plan that keeps the
Java translator's ELM as a permanent oracle while the .NET translator catches up. Tracking
epic: [#874](https://github.com/FirelyTeam/firely-cql-sdk/issues/874), with one sub-issue per
work item below.

## 1.1. Where we stand

### 1.1.1. Corpus census

Every CQL corpus in the repository was translated with the .NET translator (default
`CqlToolkitConfig`, `AmbiguousTypeBehavior.PreferModel`, each library built on its own so one
crash does not hide the others). A library is *clean* when its ELM carries no error-severity
`CqlToElmError`; *errors* when it does; *crash* when translation throws instead of reporting.

| Corpus | Model | Libraries | Clean | Errors | Crash |
|---|---|---:|---:|---:|---:|
| `LibrarySets/Demo/Cql` | FHIR 4.0.1 | 38 | 14 | 14 | 10 |
| `LibrarySets/RR23/Cql` | FHIR 4.0.1 | 2 | 2 | 0 | 0 |
| `Cql/CoreTests/Input/ELM/HL7` | FHIR 4.0.1 | 14 | 12 | 1 | 1 |
| `Demo/Measures.Authoring/Input/cql` | QICore 4.1.1 + FHIR | 7 | 3 | 2 | 2 |
| same, with QICore 4.1.1 / US Core 3.1.1 model info injected | | 7 | 5 | 2 | 0 |
| `LibrarySets/dqm-content-qicore-2025/Cql` | QICore 6.0.0 | 91 | 2 | 82 | 7 |
| same, with QICore 6.0.0 / US Core 6.1.0 model info injected | | 91 | 10 | 77 | 4 |
| HEDIS 2025 (`Firely.Cql.Sdk.Integration.Runner` submodule) | FHIR 4.0.1 | 382 | 328 | 42 | 12 |

Two readings matter more than the raw numbers:

- On unprofiled FHIR 4.0.1 content the translator is already far along: roughly six of every
  seven HEDIS libraries translate cleanly, and the remaining failures cluster into a handful of
  root causes (next section).
- On QICore content the dominant failure is simply that no QICore or US Core model info ships
  with the SDK. Injecting the model info files from the Java `quick` jar (they are plain
  `ModelInfo` XML and deserialize with the existing serializer) removes the "model not
  available" cascade entirely; what remains is the same FHIR-level root-cause list plus a
  small number of genuinely profile-specific constructs.

### 1.1.2. Root causes behind the census, ranked by libraries affected

Each item names the construct, the evidence, and the code that owns it. Cascades are collapsed:
once an expression types as `Any` every operator over it reports an ambiguity, so the
histogram over-counts downstream symptoms. The ranking below is by the *first* error in each
chain.

1. **Conditional results are typed as a choice instead of being unified.** A `case`/`if` whose
   branches yield `Interval<DateTime>` and `Interval<Date>` (QICoreCommon's `toInterval`,
   MATGlobalCommonFunctions' `Normalize Interval`, and every library that calls them) gets the
   result type `Choice<Interval<DateTime>, Interval<Date>>`, after which `start of`, `end of`,
   `in`, `during`, `overlaps`, `collapse` and `before` all fail to resolve. The reference
   translator unifies branches through implicit conversion (`Date` to `DateTime`, and intervals
   through their point type): the checked-in reference ELM types both functions as
   `Interval<DateTime>`. Evidence: 42 of 91 QICore libraries, 8 of 38 Demo libraries, and
   the two Authoring libraries that still fail with model info loaded. Owner:
   [`ConditionalExpressionVisitor`](../Cql/Cql.CqlToElm/Visitors/ConditionalExpressionVisitor.cs)
   (the type-join at the end of the `case` visitor, which also has an off-by-one: zero
   non-`Any` branch types fall through into an empty `ChoiceTypeSpecifier`). Related:
   [#1594](https://github.com/FirelyTeam/firely-cql-sdk/issues/1594),
   [#1607](https://github.com/FirelyTeam/firely-cql-sdk/issues/1607).
2. **Operators over genuinely choice-typed operands do not resolve.** Distinct from the
   previous item: `start of` a `Choice<FHIR.dateTime, FHIR.Period>` element (Demo
   CumulativeMedicationDuration) is correct CQL; the reference ELM resolves it through the
   model's implicit conversion, emitting `Start` over a `FunctionRef` to
   `FHIRHelpers.ToInterval`. Tracked as
   [#1541](https://github.com/FirelyTeam/firely-cql-sdk/issues/1541).
3. **`union` of lists with different element types.** `[ConditionProblemsHealthConcerns] union
   [ConditionEncounterDiagnosis]` must yield `List<Choice<…>>`
   ([#1295](https://github.com/FirelyTeam/firely-cql-sdk/issues/1295)). Today the call is
   reported ambiguous, and an ambiguous resolution in
   [`InvocationBuilder`](../Cql/Cql.CqlToElm/InvocationBuilder.cs) proceeds with the first of
   the tied candidates, so the expression takes that candidate's result type
   (`Interval<Integer>`), which is why the QICore histogram shows `Exists`, `verified`,
   `prevalenceInterval` and "Invalid interval property name" over `Interval<Integer>`. Evidence:
   24 QICore libraries, 3 Demo libraries, plus everything downstream of them.
4. **Library-qualified identifiers in query sources and retrieve terminology.**
   `Common."Encounters" E …` and `[Condition: Common."VS"]` report "Type  has no members" (empty
   type name) because `VisitQualifiedIdentifierExpression` navigates into the `IncludeRef`
   instead of resolving the member in the included library. Confirmed with a two-library probe
   during this analysis; the same spelling in expression position works. Evidence: 17 QICore
   libraries, 2 Demo libraries. Owner:
   [`InvocationTermVisitor`](../Cql/Cql.CqlToElm/Visitors/InvocationTermVisitor.cs).
5. **Crashes instead of diagnostics.** Four distinct exceptions terminate translation:
   - combining three fluent function definitions into one overload set, consistent with the
     cross-library fluent collision in
     [#453](https://github.com/FirelyTeam/firely-cql-sdk/issues/453): 11 HEDIS libraries;
   - two overloads that erase to the same signature in one library
     ([#438](https://github.com/FirelyTeam/firely-cql-sdk/issues/438),
     [#877](https://github.com/FirelyTeam/firely-cql-sdk/issues/877)): QICoreCommon and its
     callers; disappears once the QICore model info is loaded, but the profiled-overload case
     behind #438 stays;
   - a model element whose type is a nested `typeSpecifier` child (`System.Concept.codes` in
     the ELM model info) throws in
     [`ModelProvider.GetTypeSpecifierForElement`](../Cql/Cql.CqlToElm/ModelProvider.cs):
     10 Demo libraries (same family as
     [#1674](https://github.com/FirelyTeam/firely-cql-sdk/issues/1674));
   - a null type name in `IModelProviderExtensions.splitTypeName`: 2 libraries.
6. **Model info loading.** Only the System and FHIR 4.0.1 model infos ship; `CqlModel` has two
   members; nothing lets a `CqlToolkit` or the Packager CLI load a model info from a file.
   `using QICore` therefore types every retrieve as `Any`
   ([#407](https://github.com/FirelyTeam/firely-cql-sdk/issues/407) covers the full
   profile-informed semantics; plain loading is the much smaller first step).
7. **Type-name resolution searches every loaded model rather than the library's `using`s.**
   With QICore and US Core both loaded, an unqualified `AllergyIntolerance` is reported
   ambiguous although the library declares only `using QICore` (4 libraries). Same family as
   [#1675](https://github.com/FirelyTeam/firely-cql-sdk/issues/1675).
8. **Smaller, well-defined gaps:** `Coalesce` over list or interval arguments
   ([#1673](https://github.com/FirelyTeam/firely-cql-sdk/issues/1673), 6 HEDIS libraries);
   `ToDate(String)` missing (2); `AgeInYearsAt` over an `Any` argument (2); a decimal literal
   whose mantissa exceeds the limit the translator enforces (1).
9. **Not yet de-cascaded:** 35 HEDIS libraries report an NCQA fluent function receiving an
   `Any`-typed argument. The upstream expression that first lost its type has not been
   identified; finding it is part of Phase 0.
10. **Error nodes carry no locators.** Every `CqlToElmError` in the census reports line 0, so
    a failing library cannot be triaged from its diagnostics alone. The reference translator
    emits locators on every error.

### 1.1.3. Grammar coverage

A rule-by-rule audit of [`cql.g4`](../Cql/Cql.Grammar/cql.g4) against the visitors shows the
grammar is largely covered. Dispatch for unhandled rules falls through ANTLR's default
`VisitChildren`, which returns the last child or `null`; `null` is turned into an error node
only in `VisitTermExpression` and `VisitExpressionDefinition`, and crashes anywhere else. The
constructs with no visitor or a known defect:

| Construct | Status |
|---|---|
| `Code '…' from cs display '…'` and `Concept { … } display '…'` selectors | missing (only the `Code { code: … }` instance-selector spelling works) |
| external constants `%x` | missing |
| library-qualified query source / retrieve terminology / retrieve context | defect (root cause 4) |
| `… occurs within …` timing phrase | throws `NotImplementedException` |
| `aggregate … starting <quantity>` | throws (`simpleLiteral` and parenthesized forms work) |
| `contains` with a precision specifier | precision dropped |
| `convert x to Integer` | emits a generic `Convert` instead of `ToInteger` |
| `case` with no non-`Any` branch | empty `ChoiceTypeSpecifier` (root cause 1) |
| `$index`, `$total` | visitors exist but nothing puts them in scope |
| retrieve `codePath` | taken as raw text, not validated against the model |
| retrieve context `[Ctx -> Type]` | emits an unresolved, untyped `ExpressionRef` |
| `@tag` annotations in comments | missing ([#420](https://github.com/FirelyTeam/firely-cql-sdk/issues/420); the packager reads these) |
| `same as`, `includes`, `meets`, list indexer, unary minus | built directly rather than through overload resolution, so operands are not type-checked or coerced |
| string escapes | unescaped with `Regex.Unescape`, not the CQL escape set |

### 1.1.4. System library coverage

Against [Appendix B of the spec mirror](../spec/cql/condensed/09-b-cqlreference.md), the
[`SystemLibrary`](../Cql/Cql.CqlToElm/Builtin/SystemLibrary.cs) covers the large majority of
operators. Missing or partial:

| Area | Missing | Partial |
|---|---|---|
| Type operators | `CanConvertQuantity`, function-form `ConvertQuantity`, `Children`, `Descendants` under its spec name, all ten `ConvertsTo…`, `ToDate`, `ToRatio`, `ToList`, `ToChars` | `ToLong` (Integer only), `ToQuantity` (no Long) |
| Arithmetic | | `Power` always `Decimal`; `Predecessor`/`Successor` accept any type; `Multiply`/`Divide`/`TruncatedDivide` over `Quantity` fail at run time |
| String / aggregate | `SplitOnMatches`, `GeometricMean`, `Repeat` | |
| Interval | `Size` | `Between` has no interval form; `Contains` on intervals ignores precision |
| Clinical | `InCodeSystem`, `AnyInCodeSystem`, `ExpandValueSet` | `AgeIn{Hours,Minutes,Seconds}At` declared binary; `AgeIn…` reads a hard-coded `Patient.birthDate` instead of the model's `patientBirthDatePropertyName` |
| Nullological | | `Coalesce` only binds scalar `T` ([#1673](https://github.com/FirelyTeam/firely-cql-sdk/issues/1673)) |
| Uncertainty | duration/difference results are plain `Integer`; nine conformance cases skipped | [#132](https://github.com/FirelyTeam/firely-cql-sdk/issues/132), spans the runtime too |

### 1.1.5. Model info semantics

The model provider reads type names, base types, elements and their type specifiers,
`conversionInfo` and `primaryCodePath`. It ignores `contextInfo` (including
`patientClassName` and `patientBirthDatePropertyName`), `retrievable`, `label`, `identifier`,
class-level `target`, `contextRelationship`, `targetContextRelationship` and element-level
`target`. The retrieve `templateId` is hard-coded to `http://hl7.org/fhir/StructureDefinition/{name}`
for the FHIR model and null for any other, so a QICore profile retrieve would carry no
`templateId` at all. The checked-in QICore ELM shows the shape to match: `dataType` in the
FHIR namespace (`{http://hl7.org/fhir}Observation`) with the QICore profile URL as
`templateId`. The ELM-to-C# side already consumes that shape, so for retrieves the target is
"emit what the reference translator emits", not a new design.

### 1.1.6. The oracle we have today

- The HL7 conformance suite ([`Cql/CqlToElmTests/Input/DQIC`](../Cql/CqlToElmTests/Input/DQIC/README.md))
  runs through `XmlTest`: each expression is translated, evaluated through the real
  ELM → C# → assembly pipeline, and compared with its expected value. Roughly thirty cases are
  skipped because they do not translate and forty-five because the result differs; both lists
  live in [`SkippedTests.cs`](../Cql/CqlToElmTests/%28tests%29/SkippedTests.cs) with a reason
  each.
- Every corpus above has reference-translator ELM checked in next to its CQL (generated by the
  Java CLI pinned in [`Demo/Cql/Build/pom.xml`](../Demo/Cql/Build/pom.xml) with
  `-locators true -result-types true -signatures All`). CI compiles and, for the CMS and demo
  corpora, evaluates that ELM; it does not run Java and does not run the .NET translator over
  the corpora.
- Nothing compares .NET-translated ELM with reference ELM, and nothing evaluates a measure
  from .NET-translated ELM.

## 1.2. What "complete" means

Four tiers. The plan commits to the first two, defines the third so its cost is visible, and
treats the fourth as a separate track.

| Tier | Scope | Done when |
|---|---|---|
| **A. Language** | Full CQL 1.5.3 grammar and Appendix B system library per the [spec mirror](../spec/cql/README.md), with diagnostics (locators, no crashes) matching the reference translator's quality | every construct in 1.1.3 and 1.1.4 implemented; `SkippedTests.DoesNotCompile` empty except cases the spec itself leaves implementation-defined; all FHIR 4.0.1 corpora translate clean and evaluate to the same results as their reference ELM |
| **B. Unprofiled models** | Any `ModelInfo` XML loadable (bundled QICore and US Core versions, plus file-based loading in the toolkit and Packager CLI), with class-level `target`/`identifier`, `contextInfo`, `retrievable` and `primaryCodePath` honoured so retrieves and `context Patient` match reference ELM | the QICore corpus translates clean except libraries that depend on tier C constructs, and those are enumerated |
| **C. Profile-informed semantics** | Element-level `target` mappings (extensions, slices, primitive narrowing), `contextRelationship`, profiled overloads ([#407](https://github.com/FirelyTeam/firely-cql-sdk/issues/407), [#438](https://github.com/FirelyTeam/firely-cql-sdk/issues/438)) | **explicitly deferred**; the tier B census says how many libraries it blocks |
| **D. Uncertainty** | Uncertain durations and comparisons ([#132](https://github.com/FirelyTeam/firely-cql-sdk/issues/132)) | separate track: it changes the runtime's value model, not only the translator |

Completeness is measured, not declared: each tier's "done when" is a test that CI runs.

## 1.3. Oracle strategy: the Java translator stays, permanently

The reference ELM is the Java leg of a differential test; the .NET translator is the other. The
repository keeps the checked-in Java ELM as the authoritative input for everything that ships
(generated `*.g.cs`, vendored library resources, demo library sets) for the whole duration of
this plan, so the `GeneratorToolVersion` rules are untouched and no `*.g.cs` churns. Replacing
the Java ELM as the shipped source is a decision for after tier B, not part of it.

### 1.3.1. Parity levels

For every corpus library, from cheap to strong:

| Level | Check | Role |
|---|---|---|
| L0 | .NET translation produces ELM with no error-severity diagnostics and no exception | gate, ratcheted |
| L1 | that ELM compiles through `ElmToolkit` to C# and to an assembly | gate, ratcheted |
| L2 | the measure evaluates on the existing test decks to the same results as the reference ELM | gate, ratcheted; the strongest oracle |
| L3 | normalized structural diff between .NET ELM and reference ELM | report only |

L2 reuses what exists: the Integration Runner's CMS decks and `passed.jsonl`-style known-pass
ratchet, `Test.Measures.Demo`, the `RR23` test data, and the conformance suite. L3 stays a
report because two translators can legitimately differ in shape (placement of implicit
conversions, `As` versus `ToList` wrapping, choice flattening) while evaluating identically; a
strict tree diff would drown the signal. The normalizer strips `localId`, `locator`,
annotations and `resultTypeName`/`resultTypeSpecifier` spelling, and the diff is published as a
CI artifact so a change in divergence count is visible per PR.

Where the emitted format has an independent checker, assert against it as well: validate
.NET-emitted ELM JSON against the ELM schema, and round-trip it through the `Hl7.Cql.Elm`
reader. Reading it with the Java ELM library from the cached jars is a cheap optional extra.

### 1.3.2. CI design

- Existing jobs keep running against reference ELM unchanged.
- A new job (or a matrix dimension `ElmOrigin = Java | DotNet`) runs the same L1/L2 suites over
  .NET-translated ELM, gated by a per-corpus known-pass file so it is green from day one and
  tightens as libraries graduate. A library that regresses from clean to failing fails the
  build; a library that newly passes but is not in the file is a warning until the file is
  updated.
- The census of 1.1.1 becomes a permanent test with the same ratchet, so the table above is
  recomputed on every PR.
- Java is still not executed in CI. Regenerating reference ELM stays a local, deliberate step
  (the `generate-elm-from-cql` skill), because the reference must not drift silently underneath
  the comparison.

### 1.3.3. The backend is a second place parity can break

[`Cql.Compiler/Preprocessing`](../Cql/Cql.Compiler/Preprocessing) holds correctors
(`AmbiguousOverloadCorrector`, `ProfiledValueSetPropertyCorrector`,
`MissingResultTypeSpecifierCorrector`, `PowerResultTypeCorrector`, `ExpressionRefCorrector`)
that normalize reference-translator ELM before it reaches the IR. .NET ELM with a different
shape may bypass them or trip them. "Our engine works against both" therefore needs an explicit
test: for each corrector, a case over .NET ELM that shows it is either a no-op or still
correct. Where a corrector exists only to compensate for something the .NET translator gets
right at the source, the plan prefers to emit the right shape and leave the corrector for Java
ELM rather than add a .NET-specific branch.

### 1.3.4. Translator option parity

One reference configuration has to be chosen and written down, because the two sides disagree
today:

- The checked-in reference ELM records its translator options in the library-level
  `CqlToElmInfo` annotation as `EnableLocators,EnableResultTypes` with signature level `All`:
  no `DisableListPromotion` or `DisableListDemotion`, so the oracle was produced with list
  promotion and demotion **enabled**. `CqlToolkitConfig` disables both by default. The
  conformance suite also assumes promotion (the `CodeToConcept1` skip). Either the .NET default
  changes, or the Java invocation gains the two disable flags and the reference ELM is
  regenerated; the plan recommends the former.
- `CqlToolkitConfig.AmbiguousTypeBehavior` defaults to `Error`; `CqlToElmOptions` defaults to
  `PreferModel` while its doc comment says `Error`. The census above used `PreferModel`.
- `-signatures All` and `-result-types true` are already matched; locator fidelity is not
  (literal locators are approximate, error locators absent).

## 1.4. Phases

Phases are ordered by what unblocks the most, and each is measurable through the Phase 0
harness. Every item is a sub-issue of
[#874](https://github.com/FirelyTeam/firely-cql-sdk/issues/874).

### 1.4.1. Phase 0: harness and baseline

- Permanent census test over every corpus with a known-pass ratchet file
  ([#1722](https://github.com/FirelyTeam/firely-cql-sdk/issues/1722)).
- L1/L2 runs over .NET ELM for the corpora that have decks, same ratchet
  ([#1723](https://github.com/FirelyTeam/firely-cql-sdk/issues/1723); the HEDIS side stays
  L0/L1 until [#1538](https://github.com/FirelyTeam/firely-cql-sdk/issues/1538) gives it
  decks).
- ELM normalizer and L3 diff report
  ([#1724](https://github.com/FirelyTeam/firely-cql-sdk/issues/1724)).
- Locators on every `CqlToElmError`
  ([#1725](https://github.com/FirelyTeam/firely-cql-sdk/issues/1725)), so the next phases can
  be triaged from diagnostics.
- De-cascade the remaining histogram entries (the HEDIS `Any`-argument pattern in 1.1.2 item 9)
  and file one issue per root cause
  ([#1726](https://github.com/FirelyTeam/firely-cql-sdk/issues/1726)).
- Resolve the option-parity questions of 1.3.4 and record the reference configuration in
  [`Cql.CqlToElm/README.md`](../Cql/Cql.CqlToElm/README.md)
  ([#1727](https://github.com/FirelyTeam/firely-cql-sdk/issues/1727)).
- Settle [#1608](https://github.com/FirelyTeam/firely-cql-sdk/issues/1608) so translator PRs
  do not argue about `GeneratorToolVersion`.

### 1.4.2. Phase 1: no crashes

Every exception in the census becomes a diagnostic on the ELM node that caused it:

- default dispatch: an unhandled grammar rule yields an error node, never `null`
  ([#1728](https://github.com/FirelyTeam/firely-cql-sdk/issues/1728));
- fluent collision across libraries
  ([#453](https://github.com/FirelyTeam/firely-cql-sdk/issues/453));
- duplicate erased overloads reported, not thrown
  ([#877](https://github.com/FirelyTeam/firely-cql-sdk/issues/877));
- nested `typeSpecifier` on model elements
  ([#1674](https://github.com/FirelyTeam/firely-cql-sdk/issues/1674) family);
- `splitTypeName` on a null name
  ([#1729](https://github.com/FirelyTeam/firely-cql-sdk/issues/1729));
- `occurs within` and `starting <quantity>` implemented rather than thrown
  ([#1730](https://github.com/FirelyTeam/firely-cql-sdk/issues/1730)).

Exit: crash column is zero on every corpus.

### 1.4.3. Phase 2: type system core

The items that dominate the census:

- branch unification for `if`/`case` through implicit conversion, including interval point
  types ([#1731](https://github.com/FirelyTeam/firely-cql-sdk/issues/1731); closes the
  remainder of [#1594](https://github.com/FirelyTeam/firely-cql-sdk/issues/1594));
- operator resolution over choice-typed operands
  ([#1541](https://github.com/FirelyTeam/firely-cql-sdk/issues/1541));
- `union`/`intersect`/`except` over heterogeneous lists yields `List<Choice<…>>`
  ([#1295](https://github.com/FirelyTeam/firely-cql-sdk/issues/1295));
- an ambiguous or failed resolution types as `Any`, never as the first candidate's type
  ([#1732](https://github.com/FirelyTeam/firely-cql-sdk/issues/1732); stops the
  `Interval<Integer>` cascade);
- library-qualified identifiers in query sources, terminology and context
  ([#1733](https://github.com/FirelyTeam/firely-cql-sdk/issues/1733));
- `Coalesce` over lists and intervals
  ([#1673](https://github.com/FirelyTeam/firely-cql-sdk/issues/1673));
- `returns Any` functions keep their declared type at call sites
  ([#1607](https://github.com/FirelyTeam/firely-cql-sdk/issues/1607));
- type-name resolution scoped to the library's `using`s
  ([#1675](https://github.com/FirelyTeam/firely-cql-sdk/issues/1675)).

Exit: all FHIR 4.0.1 corpora at L0 except libraries blocked by Phase 3 or 4 items, each
named in the ratchet file with its reason.

### 1.4.4. Phase 3: grammar completion

Everything in 1.1.3 not already taken by Phases 1 and 2: code and concept selectors and
external constants ([#1734](https://github.com/FirelyTeam/firely-cql-sdk/issues/1734));
`contains` precision, `convert … to Integer`, `$index`/`$total` and CQL string escapes
([#1735](https://github.com/FirelyTeam/firely-cql-sdk/issues/1735)); retrieve `codePath`
validation and context resolution
([#112](https://github.com/FirelyTeam/firely-cql-sdk/issues/112)); routing `same as`,
`includes`, `meets`, indexer and unary minus through overload resolution
([#1736](https://github.com/FirelyTeam/firely-cql-sdk/issues/1736)); and `@tag` annotations
([#420](https://github.com/FirelyTeam/firely-cql-sdk/issues/420)).
`context` semantics beyond `Patient`
([#85](https://github.com/FirelyTeam/firely-cql-sdk/issues/85)) belong here too, since
`Unfiltered` and model-defined contexts are grammar-visible.

Exit: every grammar rule and labeled alternative has a visitor and a test;
`SkippedTests.DoesNotCompile` holds only spec-ambiguous cases.

### 1.4.5. Phase 4: system library completion

Everything in 1.1.4 except uncertainty: the missing type operators, `InCodeSystem` and
`AnyInCodeSystem`, `ExpandValueSet`, `SplitOnMatches`, `GeometricMean`, `Repeat`, `Size`
([#1737](https://github.com/FirelyTeam/firely-cql-sdk/issues/1737)); the partial overload
sets, `Power` result typing, point-type constraints on `Predecessor`/`Successor`, the
`AgeIn…At` signatures, and quantity unit arithmetic
([#1738](https://github.com/FirelyTeam/firely-cql-sdk/issues/1738); the latter is partly a
runtime item and is coordinated with the operators owner).

Exit: an automated cross-check of `SystemLibrary` against the operator list extracted from
the spec mirror passes ([#1739](https://github.com/FirelyTeam/firely-cql-sdk/issues/1739):
parse Appendix B headings, assert each name resolves).

### 1.4.6. Phase 5: models (tier B)

- Bundle the QICore and US Core model info versions the corpora use, sourced from the Java
  `quick` jar that the Java dependency download fetches, widen `CqlModel` accordingly, and
  load any model info from a file or stream in `CqlToolkit` and the Packager CLI's `cql`
  command ([#1740](https://github.com/FirelyTeam/firely-cql-sdk/issues/1740)).
- Honour `contextInfo` for `context Patient` and for the `AgeIn…` operators, `retrievable`,
  class-level `target`/`identifier` so retrieves erase to the FHIR type and carry the profile
  `templateId` exactly as reference ELM does
  ([#1741](https://github.com/FirelyTeam/firely-cql-sdk/issues/1741); the backend's existing
  QICore handling and [#1641](https://github.com/FirelyTeam/firely-cql-sdk/issues/1641) depend
  on that shape).
- Re-run the census; publish the list of QICore libraries blocked by tier C constructs.

Exit: QICore corpus at L0/L1 except the published tier C list; CMS decks at L2 for every
library not on that list.

### 1.4.7. Phase 6: promotion

Remove the "not production ready" disclaimers from
[`Cql.CqlToElm/README.md`](../Cql/Cql.CqlToElm/README.md),
[`docs/cql-packager.md`](cql-packager.md) and the Packager CLI help; record the reference
configuration and the supported tiers in the README; add a release-note fragment
([#1742](https://github.com/FirelyTeam/firely-cql-sdk/issues/1742)). The Java ELM remains the
shipped source for generated artifacts until a separate decision changes that.

### 1.4.8. Effort

Coarse buckets, assuming one engineer familiar with the translator. S is days, M is one to two
weeks, L is a month or more.

| Phase | Size | Mostly |
|---|---|---|
| 0 harness | M | test infrastructure, CI yaml, normalizer |
| 1 no crashes | S | error handling |
| 2 type system | L | coercion and overload resolution |
| 3 grammar | M | visitors and tests |
| 4 system library | M | declarations plus runtime pairing for unit arithmetic |
| 5 models | M | model provider, toolkit API, CLI option |
| 6 promotion | S | docs |
| tier C (deferred) | L | element `target` interpretation |
| tier D (separate) | L | runtime value model |

## 1.5. Decisions needed before Phase 0 starts

1. **QICore scope line.** Confirm tier B (load and erase like the reference translator) is in
   scope and tier C (element-level `target`, slices, extensions) is out. The Phase 5 census
   will say how many QICore libraries tier C blocks; if that number is small the line can move.
2. **L3 strictness.** Keep the structural ELM diff as a report, or promote it to a gate with
   an allowlist of accepted divergence classes once the count stabilizes. The plan recommends
   report-only until Phase 5.
3. **Option defaults.** Whether `CqlToolkitConfig` switches to list promotion and demotion
   enabled, matching what the checked-in reference ELM and the conformance suite encode
   (1.3.4), and which `AmbiguousTypeBehavior` is the default. Changing the toolkit default is a
   behaviour change for existing callers and needs a release-note fragment.
4. **Uncertainty.** Whether tier D starts in parallel (it touches the runtime and the IR) or
   after tier B.

## 1.6. How the census was measured

So Phase 0 can reproduce it: a `CqlToolkit` with `AmbiguousTypeBehavior.PreferModel` and
`BatchProcessExceptionContinuation.Continue` loads a corpus directory; each library is then
resolved through the toolkit's `ILibraryProvider` and built individually inside a try/catch so
exceptions are attributed to one library; errors are `GetErrors()` filtered to severities above
warning. The QICore and US Core runs additionally pass the model info XML files from the
`quick` jar in `Demo/Cql/Build/target/dependency` through `CqlToolkitConfig.ModelInfos`. The
HEDIS corpus is internal content; its tallies are reported here, its CQL is not.
