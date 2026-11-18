## Fixes

- **CQL to ELM translation** — `ToDate(DateTime)`, `ToDate(String)`, `ToLong(Boolean)` and `ToLong(String)`, which CQL
  §9.B *Type Operators* defines, now translate. They used to fail with "Could not resolve call to operator". Generated C#
  for a given ELM is unchanged.
