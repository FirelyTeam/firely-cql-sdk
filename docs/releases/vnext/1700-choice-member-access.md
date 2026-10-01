## Fixes

- **CQL-to-ELM translator:** member access on a value of a choice type, such as `C.onset.value` on a
  FHIR `Condition`, now translates instead of reporting `Type Choice<…> has no members.` The member is
  looked up on every alternative that has it; the result is that member's type when only one type
  remains, and a choice of the distinct types otherwise. This is the ELM the Java translator
  produces, so the compiler emits the same dispatch for it. A library that reaches this never
  translated before, so no evaluation result moves and there is no `GeneratorToolVersion` change.
  (#1648, #1700)
