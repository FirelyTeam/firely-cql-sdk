## Fixes

- **Runtime** — A comparison of two values of different types that have no order between them, such as a Date and a
  DateTime, a Date and a Time, or an Integer and a Decimal, is `null` for `<`, `<=`, `>`, `>=`, `before` and `after`,
  instead of answering as if the left value were the greater: `A after B` and `B after A` were both true for a Date and
  a DateTime. `ICqlComparer.Compare` and `ICqlComparer.CompareValues` return `null` for such a pair instead of an order.
  Equality is unchanged: `=` is `false`, `!=` is `true` and `~` is `false` for such a pair, and lists and tuples whose
  elements differ in type are still unequal. ELM translated by this SDK does not hand these operators values of
  different types: the translator converts a Date compared with a DateTime with `ToDateTime` and an Integer compared
  with a Decimal with `ToDecimal`, and casts a value of a choice type to the operator's type. The change reaches ELM
  from another translator that leaves such a pair unconverted, and code that calls `ICqlOperators` directly. (#1649)

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
