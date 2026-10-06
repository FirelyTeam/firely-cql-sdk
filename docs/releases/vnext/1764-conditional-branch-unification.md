## Fixes

- The .NET CQL-to-ELM translator now gives the branches of `if` and `case`, and the elements of a
  list selector, the one type they share, the way the reference translator does: an implicit
  conversion where one exists (`Integer` and `Decimal` become `Decimal`, `Date` and `DateTime`
  become `DateTime`, `Interval<Date>` and `Interval<DateTime>` become `Interval<DateTime>`,
  `Code` and `Concept` become `Concept`), and a choice of the branch types only when none does.
  Previously any two different branch types produced a choice type, after which operators such
  as `start of`, `in` and `overlaps` over the conditional failed to resolve. A list selector with
  a declared element type (`List<Decimal>{ 1, 2 }`) now converts its elements to that type, and a
  `case` whose branches are all `null` is typed `Any` rather than an empty choice. The static type
  of such expressions in the emitted ELM changes accordingly. (#1731)
