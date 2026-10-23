## Potentially Breaking

- **Runtime** — `=` on Concepts compares the display as well as the codes, by the tuple equality semantics the
  specification gives it: its `EqualIsFalse` example, two concepts with the same codes and the displays `'Concepts'`
  and `'More Concepts'`, is `false` instead of `true`. The codes compare as a list does, in order, so concepts with the
  same codes in a different order are not equal. When the two specify different components, such as codes or a display
  on one side only, the result is null instead of `true` or `false`; it stays null when either concept is null. A
  concept without codes is a concept rather than null, so two concepts without codes are equal exactly when their
  displays are, instead of always. (#1876, #1880)
- **Runtime** — `~` on Concepts is `true` only when the two share an equivalent code, so concepts without codes, or
  with an empty list of codes, are not equivalent to each other, nor to themselves. The display is still ignored,
  `null ~ null` is still `true`, and a concept is still not equivalent to null. (#1876, #1880)
- **Runtime** — The operations that match list elements by equality follow `=` on Concepts: `distinct`, `union`,
  `except`, `intersect`, `in`, `contains`, `IndexOf`, `includes`, `Mode` and `=` on lists of Concepts no longer treat
  concepts as the same when they differ in their display or in the order of their codes, or when they have no codes and
  different displays. A Concept element of a tuple compares as a Concept. A tuple, and a list inside a tuple or a list,
  is equivalent to another only when their elements are: no longer merely because the elements are equal as .NET
  values, or because both sides hold the same list. A tuple or list that holds a Concept without codes, or a ratio
  whose denominator is zero, is therefore not equivalent to an equal one, even when both sides hold one shared list,
  such as the result of one definition or of two identical list selectors, which the generated C# evaluates once.
  (#1876, #1880)
  - **Who sees a difference:** a library that compares Concepts, or deduplicates or matches lists of them, notably
    FHIR `CodeableConcept` values. FHIR gives the order of a concept's codings no meaning, but CQL's list equality
    does, so two such concepts with the same codings in a different order are no longer equal, and `distinct`,
    `union` and the other operations above can now keep both.
  - **What to do:** to compare FHIR concepts regardless of the order of their codings, or of their display, use `~`,
    which asks only for a shared equivalent code.

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
