## Fixes

- **CQL translation:** a query's `return all` clause is now honoured. The CQL-to-ELM front end never read the
  `all` / `distinct` modifier on a return clause, and `ReturnClause.distinct` defaults to `true`, so
  `return all` was translated as `return distinct` and the query silently dropped duplicate results.
  `({ 1, 1, 2, 2, 3 }) N return all N` now evaluates to `{ 1, 1, 2, 2, 3 }` instead of `{ 1, 2, 3 }`.

  **This moves CQL evaluation results**, for libraries compiled from CQL by the SDK's own front end
  (`CqlToolkit` / `Hl7.Cql.CqlToElm`). A library whose logic uses `return all` was getting a de-duplicated
  list, so results that count or aggregate over such a query can change. Libraries packaged from ELM produced
  by the Java cql-to-elm translator are unaffected — that translator already emitted `distinct="false"`, and
  the ELM-to-C# code generator already honoured it, so `GeneratorToolVersion` and the checked-in generated
  code do not change.

  Queries with no return modifier, and queries written `return distinct`, are unaffected: both still
  de-duplicate, which is the specified default. `aggregate all` / `aggregate distinct` were already handled
  correctly and do not change.
