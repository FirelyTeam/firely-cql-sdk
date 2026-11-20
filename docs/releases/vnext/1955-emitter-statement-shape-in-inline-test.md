## Fixes

- **Code generator** — A conditional whose two branches are simple values and whose test holds a `case` expression or an
  `is` type test now generates C#, also when the `case` or the type test sits inside a query in that test. The C# emitter
  threw `NotSupportedException` for it ("An if-chain cannot print as an inline expression", or "A type switch binds
  variables and cannot print as an inline expression"), for example for
  `if (case when A then 1 else 2 end) = 1 then 'x' else 'y'`, and the library and every library that includes it produced
  no assembly. Such a conditional now prints as `if`/`else` statements. The C# of every library that generated before is
  unchanged, so `GeneratorToolVersion` stays as it is and nothing needs regenerating. (#1955)
