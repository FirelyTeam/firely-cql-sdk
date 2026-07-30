# Generated C#: optimization opportunities (post-phase-6)

Companion to `linq-expression-removal-plan.md`. With the Expression-based pipeline deleted,
byte-parity no longer constrains the output and the typed IR — which carries the static .NET
type of every node — makes a class of optimizations straightforward that the old pipeline
could not attempt. This catalogue is evidence-based: each item points at real generated code
from the golden corpus.

Ground rule: **measure first**. The BenchmarkDotNet integration runner
([FirelyTeam/Firely.Cql.Sdk.Integration.Runner#97](https://github.com/FirelyTeam/Firely.Cql.Sdk.Integration.Runner/issues/97)) should get a
baseline per corpus before and after each class lands, and every class needs semantic tests
(CQL three-valued logic and overflow/precision rules are where "obvious" native lowerings go
wrong).

## The evidence, from one small define

CQL (`RR23`): `AgeInYearsAt(start of "Measurement Period") >= 16 and exists(...)`

Generated:

```csharp
Patient a_ = this.Patient(context);
Date b_ = a_?.BirthDateElement;
CqlDateTime c_ = context.Operators.Convert<CqlDateTime>(b_);
CqlInterval<CqlDateTime> d_ = this.Measurement_Period(context);
CqlDateTime e_ = context.Operators.Start(d_);
int? f_ = context.Operators.CalculateAgeAt(c_, e_, "year");
bool? g_ = context.Operators.GreaterOrEqual(f_, 16);
IEnumerable<Condition> h_ = this.Injury_due_to_falling_rock_within_measurement_period(context);
bool? i_ = context.Operators.Exists<Condition>(h_);
bool? j_ = context.Operators.And(g_, i_);
return j_;
```

Every operation is an interface-dispatched call on `ICqlOperators`, even where C# has an
exact native equivalent.

## Opportunity classes, by expected impact

### 1. Native-operator lowering (highest impact, widest reach)

The binder/emitter know every operand type statically. Where a native C# construct has
*exactly* CQL semantics, emit it instead of the operator call:

- `Operators.And/Or/Not/Xor` on `bool?` → `&`, `|`, `!`, `^`: C#'s lifted `&`/`|` on
  `bool?` **are** Kleene three-valued logic — a zero-risk, zero-cost replacement.
- `Operators.Equal` on primitives → `==` (lifted equality matches CQL for non-null; CQL's
  null-propagating equality needs the `HasValue` guard below).
- Comparisons (`Greater[OrEqual]`, `Less[OrEqual]`) on `int?/long?/decimal?`: NOT a direct
  lifted-operator replacement (C# lifted comparison returns `bool`, false for null; CQL
  returns null) — but a tiny aggressively-inlinable static helper, or inline
  `f_.HasValue ? f_ >= 16 : (bool?)null`, still beats interface dispatch.
- Arithmetic on primitives: candidate, but **semantics first** — CQL overflow behavior vs.
  C# wrap/checked, and decimal precision rules, must be pinned by tests per operator before
  lowering.

### 2. Devirtualization of what remains

`context.Operators` is an interface receiver — virtual dispatch on every call, largely
opaque to JIT inlining. Options: generate calls against the concrete `CqlOperators` type
(it is internal, not sealed, so any devirtualization benefit needs measuring in the real
generated call sites); or make hot operators static. Cheap to try, benchmark decides.

### 3. Conversion specialization

`context.Operators.Convert<CqlDateTime>(b_)` goes generic → boxing → runtime
`TypeConverter` dictionary lookup, **per evaluation**. The binder already knows the specific
conversion at compile time (its `ConversionFunctionName` path); the generic path is the
fallback. Emit the specific conversion call; reserve `Convert<T>` for genuinely dynamic
cases (Choice types).

### 4. Honest deduplication (fixes a replicated runtime cost)

The old deduper is single-pass without fixpoint, so "second-order" duplicates survive — in
`RR23`, `FHIRHelpers...ToDateTime(context, q_ as FhirDateTime)` is **computed twice** at
runtime (`r_` and `v_`), a cost we currently replicate for parity (see the emitter's
dual-text Atom comments). Post-parity, fixpoint dedup is both cleaner output and a real
win wherever conversions/calls repeat. (Also removes the burned-letter naming gaps.)

### 5. Constant folding and static hoisting

- `context.Operators.Quantity(7m, "days")` allocates a `CqlQuantity` on every evaluation of
  its containing lambda — a `private static readonly` field candidate, like codes already
  are. Same for constant intervals (the `Measurement Period` default) and
  `RetrieveParameters` with constant arguments.
- Literal arithmetic (`1 + 2`) can fold at generation time.
- Precision strings (`"year"`, `"days"`, `(string)default`) are parsed at runtime per call;
  an enum overload on the operator surface removes repeated parsing.

### 6. Delegate and closure pressure in queries

Query translation allocates `Func<>` delegates (and display classes, since lambdas capture
`context` and outer aliases) per evaluation, plus enumerator layers per `Where`/`Select`.
Two tiers:
- cheap: cache non-capturing delegates; make the conditional-shape local functions `static`
  where possible.
- ambitious: inline simple query pipelines into generated `foreach` loops, eliminating the
  delegate + enumerator machinery entirely. High effort; benchmark a hot measure first.

### 7. Cosmetic artifacts (readability, negligible perf)

Already in the post-parity ledger: the stray `};`, letter-gap naming, surviving
`as object` casts (visitor-ordering accident), `null as CqlInterval<...>` instead of plain
returns, `(bool?)x ?? false` in conditions, and the invoked-local-function conditional shape
(a native `if/else` or `switch` expression reads better).

## Sequencing suggestion

Phase 6 deleted the old pipeline without bumping the generator version because output stayed
byte-identical. The first deliberate output change will carry the deferred version bump and
golden regeneration. Then: (7) cosmetics + (4) honest dedup land together in that same regeneration; (1)–(3) as
measured, per-operator-class PRs with semantic tests; (5) alongside; (6) last, driven by
benchmarks. Each class changes generated output, so each is one golden regeneration —
batching related classes keeps corpus churn reviewable.
