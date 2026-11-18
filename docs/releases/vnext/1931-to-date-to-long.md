## Fixes

- **CQL to ELM translation** — `ToDate(DateTime)`, `ToDate(String)`, `ToLong(Boolean)` and `ToLong(String)`, which CQL
  §9.B *Type Operators* defines, now translate. They used to fail with "Could not resolve call to operator". With the
  new overloads, `ToLong(null)` is an ambiguous call, because an untyped null matches the `Boolean`, `Integer` and
  `String` overloads equally. It used to translate, binding to the `Integer` overload, which was the only one. The Java
  reference translator reports the same error, as the Developer's Guide, *Function Resolution*, requires. Write
  `ToLong(null as Integer)` instead. Generated C# for a given ELM is unchanged. (#1931)
