library LogicTest version '1.0.0'

// The full Kleene truth tables for and/or/not (CQL spec §9.B), evaluated through generated
// C# rather than through ICqlOperators directly. The operand definitions below are
// expression refs, so the compiler's short-circuit lowering (issue #1514) emits its guarded
// form for every combination — including the null rows, which must NOT short-circuit.

define "TrueDef": true
define "FalseDef": false
define "NullDef": null as Boolean

// and

define "TrueAndTrue": "TrueDef" and "TrueDef"
define "TrueAndFalse": "TrueDef" and "FalseDef"
define "TrueAndNull": "TrueDef" and "NullDef"
define "FalseAndTrue": "FalseDef" and "TrueDef"
define "FalseAndFalse": "FalseDef" and "FalseDef"
define "FalseAndNull": "FalseDef" and "NullDef"
define "NullAndTrue": "NullDef" and "TrueDef"
define "NullAndFalse": "NullDef" and "FalseDef"
define "NullAndNull": "NullDef" and "NullDef"

// or

define "TrueOrTrue": "TrueDef" or "TrueDef"
define "TrueOrFalse": "TrueDef" or "FalseDef"
define "TrueOrNull": "TrueDef" or "NullDef"
define "FalseOrTrue": "FalseDef" or "TrueDef"
define "FalseOrFalse": "FalseDef" or "FalseDef"
define "FalseOrNull": "FalseDef" or "NullDef"
define "NullOrTrue": "NullDef" or "TrueDef"
define "NullOrFalse": "NullDef" or "FalseDef"
define "NullOrNull": "NullDef" or "NullDef"

// not

define "NotTrue": not "TrueDef"
define "NotFalse": not "FalseDef"
define "NotNull": not "NullDef"

// implies — the spec permits short-circuiting this one EXPLICITLY ("implies may use
// short-circuit evaluation in the case that the first operand evaluates to false"). Note the
// deciding left value (false) and the deciding result (true) differ, unlike and/or, and that
// the merge is `not left or right`: null implies true is true, but null implies false is null.

define "TrueImpliesTrue": "TrueDef" implies "TrueDef"
define "TrueImpliesFalse": "TrueDef" implies "FalseDef"
define "TrueImpliesNull": "TrueDef" implies "NullDef"
define "FalseImpliesTrue": "FalseDef" implies "TrueDef"
define "FalseImpliesFalse": "FalseDef" implies "FalseDef"
define "FalseImpliesNull": "FalseDef" implies "NullDef"
define "NullImpliesTrue": "NullDef" implies "TrueDef"
define "NullImpliesFalse": "NullDef" implies "FalseDef"
define "NullImpliesNull": "NullDef" implies "NullDef"

// xor — the odd one out: its NULL row is constant ("if either or both arguments are null, the
// result is null"), so null is xor's deciding value where and/or/implies all decide on a bool.
// Neither true nor false decides: they reduce (false xor X is X, true xor X is not X).

define "TrueXorTrue": "TrueDef" xor "TrueDef"
define "TrueXorFalse": "TrueDef" xor "FalseDef"
define "TrueXorNull": "TrueDef" xor "NullDef"
define "FalseXorTrue": "FalseDef" xor "TrueDef"
define "FalseXorFalse": "FalseDef" xor "FalseDef"
define "FalseXorNull": "FalseDef" xor "NullDef"
define "NullXorTrue": "NullDef" xor "TrueDef"
define "NullXorFalse": "NullDef" xor "FalseDef"
define "NullXorNull": "NullDef" xor "NullDef"

// IsTrue/IsFalse are total predicates - never null, since a null argument yields false - so they
// lower to the `is true`/`is false` constant patterns the guards already print.

define "IsTrueOfTrue": "TrueDef" is true
define "IsTrueOfFalse": "FalseDef" is true
define "IsTrueOfNull": "NullDef" is true
define "IsFalseOfTrue": "TrueDef" is false
define "IsFalseOfFalse": "FalseDef" is false
define "IsFalseOfNull": "NullDef" is false

// Skip evidence: the right operand raises a CQL Message, observable through the context's
// MessageReceived event. A deciding left operand must suppress it; a null left operand must
// not (null and false is false — the right operand still matters).

define "MessageTrue": Message(true, true, 'LogicTest.RightEvaluated', 'Trace', 'right operand was evaluated')

define "FalseAndMessage": "FalseDef" and "MessageTrue"
define "NullAndMessage": "NullDef" and "MessageTrue"
define "TrueOrMessage": "TrueDef" or "MessageTrue"
define "NullOrMessage": "NullDef" or "MessageTrue"

// implies skips on a FALSE left operand (false implies X is true for every X); true and null
// left operands must still evaluate the right — null implies true is true, so null decides
// nothing here either.

define "FalseImpliesMessage": "FalseDef" implies "MessageTrue"
define "TrueImpliesMessage": "TrueDef" implies "MessageTrue"
define "NullImpliesMessage": "NullDef" implies "MessageTrue"

// xor skips only on a NULL left operand; true and false both still need the right operand.

define "NullXorMessage": "NullDef" xor "MessageTrue"
define "TrueXorMessage": "TrueDef" xor "MessageTrue"
define "FalseXorMessage": "FalseDef" xor "MessageTrue"

// A null CONSTANT on either side of xor erases the other operand at build time.

define "XorNullConstCollapses": "MessageTrue" xor (null as Boolean)

// Allocation probe target: a function whose right operand needs evaluation, so the guarded
// form is emitted. Called directly with left = false/true from the test; the skipped path
// must not allocate. (A function, not a define, so memoization does not cache it away.)

define function "GuardedAnd"(leftOperand Boolean): leftOperand and "MessageTrue"

// A guarded 'and' inside the TEST of a conditional whose branches are simple: without the
// statement-shape veto in the emitter's inline classification, the conditional prints as an
// inline ternary and the guard's let-binding reaches PrintFullyInline, which cannot print it
// (found via the HEDIS 2025 corpus compile guard).

define "GuardInConditionalTest": if "TrueDef" and "MessageTrue" then 1 else 2

// Deciding CONSTANT operands fold at build time, on either side, cascading: an `or true`
// (or `and false`) erases the whole chain including left operands and their side effects
// (spec-permitted; disclosed in the release note). These must compile to constants with
// no Message ever raised.

define "OrTrueCollapses": "MessageTrue" or true
define "AndFalseCollapses": "MessageTrue" and false
define "NestedOrTrueCollapses": "FalseDef" or ("NullDef" or ("MessageTrue" or true))

// Unguarded merge path: function parameters are already-evaluated values, so these compile
// to plain lifted operators (x & y / x | y) with no guard - the merge itself needs its own
// truth-table coverage. AndNotY additionally forces the inline-ternary guard form
// (right operand is non-trivial but its combine is inline-only).

define function "MergeAnd"(x Boolean, y Boolean): x and y
define function "MergeOr"(x Boolean, y Boolean): x or y
define function "AndNotY"(x Boolean, y Boolean): x and (not y)

// Fold matrix beyond the right-deciding collapse: left-deciding constants skip the right
// operand at build time; neutral constants reduce to the other operand, which still
// evaluates; a null CONSTANT left merges without a guard (the right operand always runs)
// and prints legally (`null as bool?` - the CS8310 regression shape); not of a null
// constant folds to null.

define "FalseConstAndMessage": false and "MessageTrue"
define "TrueConstOrMessage": true or "MessageTrue"
define "AndTrueKeepsLeft": "MessageTrue" and true
define "OrFalseKeepsLeft": "MessageTrue" or false
define "NullConstAndMessage": (null as Boolean) and "MessageTrue"
define "NotNullConst": not (null as Boolean)

// The without query clause lowers through the same not-lowering (lifted !), per the
// operator ledger.

define "WithoutClause": exists (({ 1, 2 }) A without ({ 2 }) B such that A = B)
