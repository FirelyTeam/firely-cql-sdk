## Fixes

- **Runtime** — `=` on Concepts compares the display as well as the codes, by the tuple equality semantics the
  specification gives it: its `EqualIsFalse` example, two concepts with the same codes and the displays `'Concepts'`
  and `'More Concepts'`, is `false` instead of `true`. The codes compare as a list does, in order, so concepts with the
  same codes in a different order are not equal. When the two specify different components, such as codes or a display
  on one side only, the result is null instead of `true` or `false`; it stays null when either concept is null. A
  concept without codes is a concept rather than null, so two concepts without codes are equal exactly when their
  displays are, instead of always. (#1876)
- **Runtime** — `~` on Concepts is `true` only when the two share an equivalent code, so concepts without codes, or
  with an empty list of codes, are not equivalent to each other, nor to themselves. The display is still ignored,
  `null ~ null` is still `true`, and a concept is still not equivalent to null. (#1876)
- **Runtime** — The operations that match list elements by equality follow `=` on Concepts: `distinct`, `union`,
  `except`, `intersect`, `in`, `contains`, `IndexOf`, `includes`, `Mode` and `=` on lists of Concepts no longer treat
  concepts as the same when they differ in their display or in the order of their codes, or when they have no codes and
  different displays. A Concept element of a tuple compares as a Concept, and a tuple is no longer equivalent to another
  merely because their elements are equal as .NET values: a tuple with a Concept element without codes, or with a
  ratio element whose denominator is zero, is not equivalent to an equal tuple, as the element itself is not. (#1876)

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
