## Fixes

- **Runtime** — Where two intervals that `collapse` merges have a boundary at the same point, one written
  open and one closed, the result now has the closed form, whichever of the two comes first in the list.
  It used to take the form of the first: `collapse { Interval(1, 7], Interval[2, 7] }` gave
  `{ Interval(1, 7] }` and `collapse { Interval[2, 7], Interval(1, 7] }` gave `{ Interval[2, 7] }`; both
  now give `{ Interval[2, 7] }`. This changes CQL evaluation results for such lists: the points covered
  are the same, but `low`, `high`, `lowClosed` and `highClosed` of a result can differ. Lists with a `per`
  argument, with boundaries of mixed precision or with boundaries without a value can still give a result
  that depends on their order. Generated C# is unchanged.
