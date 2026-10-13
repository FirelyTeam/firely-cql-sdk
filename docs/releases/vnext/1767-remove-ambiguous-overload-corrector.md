## Breaking changes

- **Compiler** — The `AmbiguousOverloadCorrector` preprocessing step is removed; the Java translator
  never emits the shape it corrected. Observable only for hand-edited ELM in which one library
  defines the same expression twice, or the same function twice with identical operand types: such
  ELM is no longer reduced to a single definition silently. A duplicated expression now fails to
  compile. A duplicated function fails where it is called, if that call has no result type and the
  compiler has to resolve it: as an ambiguous call when the function has other overloads, otherwise
  when the library's definitions are indexed. A call that already carries its result type still
  compiles, with the second definition skipped and a warning logged. None of the reference ELM
  corpora contains such definitions. (#1746)
