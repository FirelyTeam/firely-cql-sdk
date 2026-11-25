## Fixes

- **CQL to ELM translation, code generation and runtime** — `SplitOnMatches(stringToSplit, separatorPattern)`, which
  reported "could not resolve function", now translates and evaluates per CQL §9.B: the string is split on each match
  of the regular expression, a null string gives null, and a string with no match gives a one-element list holding it.
  A null pattern gives a one-element list holding the string, as a null separator does in `Split`. Captured groups in
  the pattern are not added to the result, and empty parts are kept, as in the CQL reference engine. ELM
  with a `SplitOnMatches` node from another translator, which failed to compile with "Cannot get arguments for
  element", now compiles. This changes CQL evaluation results for those expressions, and `GeneratorToolVersion` is
  now 6.4.1.0; generated code calls the existing `ICqlOperators.SplitOnMatches`, and the output for every checked-in
  library is the same (#1975).
