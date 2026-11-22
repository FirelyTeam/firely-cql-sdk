## Fixes

- **Runtime** — The result of `collapse` no longer depends on the order of its input list (CQL §9.B
  *Collapse*: "returns the unique set of intervals that completely covers the ranges present in the given
  list of intervals"). Where two merged intervals have a boundary at the same point, one written open and
  one closed, the result now has the closed form: `collapse { Interval(1, 7], Interval[2, 7] }` and
  `collapse { Interval[2, 7], Interval(1, 7] }` both give `{ Interval[2, 7] }`, where the first used to
  give `{ Interval(1, 7] }`. The ranges covered are unchanged; a result can be written differently for
  such lists. Generated C# is unchanged.
