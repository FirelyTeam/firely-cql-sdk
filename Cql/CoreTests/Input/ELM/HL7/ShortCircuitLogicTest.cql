library ShortCircuitLogicTest version '1.0.0'

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

// Skip evidence: the right operand raises a CQL Message, observable through the context's
// MessageReceived event. A deciding left operand must suppress it; a null left operand must
// not (null and false is false — the right operand still matters).

define "MessageTrue": Message(true, true, 'ShortCircuitLogicTest.RightEvaluated', 'Trace', 'right operand was evaluated')

define "FalseAndMessage": "FalseDef" and "MessageTrue"
define "NullAndMessage": "NullDef" and "MessageTrue"
define "TrueOrMessage": "TrueDef" or "MessageTrue"
define "NullOrMessage": "NullDef" or "MessageTrue"

// Allocation probe target: a function whose right operand needs evaluation, so the guarded
// form is emitted. Called directly with left = false/true from the test; the skipped path
// must not allocate. (A function, not a define, so memoization does not cache it away.)

define function "GuardedAnd"(leftOperand Boolean): leftOperand and "MessageTrue"

// A guarded 'and' inside the TEST of a conditional whose branches are simple: without the
// statement-shape veto in the emitter's inline classification, the conditional prints as an
// inline ternary and the guard's let-binding reaches PrintFullyInline, which cannot print it
// (found via the HEDIS 2025 corpus compile guard).

define "GuardInConditionalTest": if "TrueDef" and "MessageTrue" then 1 else 2
