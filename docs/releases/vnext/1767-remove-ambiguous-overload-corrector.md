## Fixes

- **Compiler** — The `AmbiguousOverloadCorrector` preprocessing step is removed; the Java translator
  never emits the shape it corrected. Observable only for hand-edited ELM in which one library
  defines the same expression twice, or the same function twice with identical operand types: such
  ELM is no longer reduced to a single definition silently and now fails with an error when the
  library's definitions are indexed, or, for a function that also has other overloads, where the
  duplicated function is called. None of the reference ELM corpora contains such definitions. (#1746)
