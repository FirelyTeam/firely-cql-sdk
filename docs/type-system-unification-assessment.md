# Unifying the CQL type systems: Cql.Primitives vs. Hl7.Fhir.ElementModel.Types

Companion to `generated-csharp-optimization-opportunities.md` (§3, conversion
specialization). Assessment of whether this repo should migrate its CQL primitives
(`Hl7.Cql.Primitives` + `Hl7.Cql.Iso8601`) onto the Firely .NET SDK's System types
(`Hl7.Fhir.ElementModel.Types`, "P.*"), reachable from POCOs via `IToSystemPrimitive`
(SDK ≥ 5.13.1/6.0.0; this repo references 6.3.0).

## Why this is a semantics question, not just deduplication

FhirPath and CQL do not merely happen to have similar primitive types: **FhirPath's type
system was deliberately aligned with CQL's when it was added** (the then-separate FhirPath
and CQL specification efforts unified on it), and **FhirPath is specified as a subset of
CQL** — FhirPath expressions are translatable to ELM. The two engines in this product
family therefore implement the *same specified type system* twice. That changes the stakes
of every difference catalogued below:

- a divergence between P.* and Cql.Primitives is not a "local variation" — one side (or
  both) is wrong against the shared spec, and FhirPath evaluation (validator invariants,
  search, server) can disagree with CQL logic over the same data;
- the SDK-side gap list at the end of this document is not a favor to the cql-sdk — each
  item is arguably a FhirPath spec-compliance improvement in its own right;
- the bridge proposed below doubles as a **conformance instrument**: differential tests
  across the two implementations expose exactly where they disagree on shared semantics,
  and every disagreement found is a bug report for one side.

## The two systems, honestly compared

**Where they overlap** — the scalar/temporal core — both are serious implementations:
both have partial-precision dates/times with genuinely ternary comparison (`int?`/null =
incomparable), offset handling, and calendar-duration arithmetic. This is real duplication:
two partial-precision datetime engines, two ternary comparers, two quantity models, in one
product family.

**Where they differ** decides the question:

| Capability | Cql.Primitives (here) | ElementModel.Types (SDK 6.3) |
|---|---|---|
| `Interval<T>` with open/closed bounds | first-class; **186 signature references in ICqlOperators** | **absent entirely** |
| UCUM canonicalization/conversion | yes (Fhir.Metrics 1.3), incl. the CQL calendar-unit shim | none — Quantity comparison requires exact unit equality (doc-comment overstates) |
| Code/Concept CQL semantics | records with defined equality | explicitly none; `Parse` throws `NotImplementedException` |
| Ratio ordering/equivalence | present | absent (structural `==` only) |
| Sub-second comparison | spec-shaped | deliberately simplified (second+ms collapsed; documented) |
| Decimal equality | comparer-based | scale-based, self-described "sloppy" vs. spec precision |
| Calendar-vs-UCUM year/month arithmetic rules | explicit (`CqlUcumYearArithmeticError` etc.) | throws `ArgumentException` on unknown units, no such distinction |
| Tuple metadata (structural typing) | `CqlTupleMetadata` | no analogue |
| POCO conversions | runtime converter dictionary (~30 in, ~14 out) + generated FHIRHelpers | **compile-time-known `IToSystemPrimitive` on the POCOs** + `Any.TryConvertTo` table |
| Battle-tested by | this repo's corpus + spec tests | the FhirPath engine (equality/ordering/conversion are load-bearing there) |

Today the repo's only contact with P.* is incidental: `FhirTypeConverter` borrows the SDK's
`TryToSystemDate/Time/DateTime` to parse FHIR primitives, then immediately re-wraps into
`CqlDate/CqlDateTime/CqlTime`, discarding the P.* value. There is no other wiring.

## Verdict

**Do not migrate now; build a first-class bridge now; treat unification as an SDK-side
roadmap item gated on a concrete gap list (below).**

1. **Migration is not viable against SDK 6.3 as-is.** The absent pieces (Interval — the
   single largest coupling in `ICqlOperators` — UCUM math, Code/Concept semantics, tuple
   metadata) mean this repo would keep roughly half its types anyway, while paying the full
   blast radius for the other half: `ICqlOperators` + every operator/comparer
   implementation, `FhirTypeConverter`, both code generators, the shipped public API, full
   golden-corpus regeneration, and — the expensive part — re-verifying three-valued
   comparison semantics everywhere, against a P.* layer that has documented spec
   simplifications (sub-second, decimal scale) this repo does not share.
2. **The reverse (SDK adopts Cql.Primitives) is a non-starter**: the SDK cannot depend on
   this repo, and P.* semantics are load-bearing for FhirPath evaluation across the whole
   product line — changing them ripples into the validator and server.
3. **The bridge is cheap, immediately valuable, and is the prerequisite work for any later
   merge.** Concretely, in `Cql.Firely`:
   - use `IToSystemPrimitive` as the POCO→System entry point and add System↔Cql adapters
     (`P.DateTime ↔ CqlDateTime`, `P.Date ↔ CqlDate`, `P.Time ↔ CqlTime`,
     `P.Quantity ↔ CqlQuantity`, `P.Code ↔ CqlCode`, `P.Concept ↔ CqlConcept`) — roughly a
     dozen small, allocation-conscious functions;
   - let the post-phase-6 conversion specialization (optimization doc §3) target these
     compile-time-known paths instead of the runtime converter dictionary — the two ideas
     compose: the binder already knows the types statically, and `IToSystemPrimitive` gives
     it a hard-coded method to call;
   - expose the adapters publicly for consumers mixing FhirPath and CQL evaluation.
   Writing the bridge also *forces* precise enumeration of the semantic diffs (sub-second,
   decimal scale, tz-normalization-by-precision, calendar-unit shim) — with tests — which is
   exactly the artifact a future unification needs.
4. **The realistic unification path runs through the SDK**, over its own release cadence:
   add a generic `Interval<T>`, UCUM canonicalization (Fhir.Metrics), CQL-grade
   Code/Concept/Ratio semantics, and the spec-shaped sub-second/decimal rules to
   ElementModel.Types. Because FhirPath is specified as a subset of CQL, each of these is
   a FhirPath spec-compliance improvement independently of this repo — the gap list is an
   SDK backlog on its own merits. Re-evaluate the cql-sdk migration when that list closes;
   the golden corpus built for the Linq.Expressions removal is then exactly the safety net
   a type swap would need.
5. **Start the bridge with differential tests.** Before (and while) writing adapters, run
   both implementations over a shared table of comparison/arithmetic cases (partial
   precisions, offsets, sub-second values, decimal scales, calendar vs UCUM durations).
   Where they disagree, the shared spec decides which side has the bug — file it there.
   This turns the alignment intent behind the specifications into something enforced by CI
   rather than remembered by people.

## The gap list (what ElementModel.Types would need to be CQL-grade)

1. Generic `Interval<T>` with `bool?` open/closed bounds and the interval operator algebra.
2. UCUM canonicalization/conversion (Fhir.Metrics) + the CQL calendar-unit 1:1 shim
   (year↔a, month↔mo, …) that deliberately bypasses metric conversion.
3. `Code`/`Concept`: CQL equality/equivalence; working `Parse`.
4. `Ratio`: `ICqlEquatable`/`ICqlOrderable`.
5. Sub-second (second+millisecond as decimal) comparison semantics; decimal
   precision-vs-scale reconciliation.
6. The tz-normalization-by-precision comparison rule (normalize at hour+ precision; skip
   when exactly one operand has an offset).
7. Calendar-vs-UCUM arithmetic distinction with the year/month UCUM prohibition.
8. Consistency fixes: `P.DateTime.Equals` throws where `Date`/`Time` return false; FhirPath
   ordering throws for non-orderable types (open TODO in EqualityOperators).
