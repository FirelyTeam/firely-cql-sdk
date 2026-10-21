## Fixes

- **CQL-to-ELM translator** — a library-qualified identifier now resolves as a query source, as retrieve
  terminology and as a retrieve context, as it already did in an expression. `A."Encs" E`, `[Condition: A."VS"]` and
  `[A."Mother" -> Observation]` translate to an `ExpressionRef` or `ValueSetRef` with `libraryName` set, instead of
  reporting `Type  has no members`. This also holds when the include resolves from a reference library. A retrieve
  context is resolved as an identifier, so `["Mother" -> Observation]` references the expression `Mother`, and an
  unknown name there is reported. A model or library name on its own in these positions is now reported as it is in
  an expression. Before, it made translation throw, or went unreported. (#1733)
