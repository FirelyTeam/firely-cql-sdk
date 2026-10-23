## Fixes

- **Runtime** — `years between` counted backwards, from a later date to an earlier one, gave one year too many when
  either date is 29 February. It now gives the negative of the count forwards, as Appendix H of the CQL specification
  does for other dates, with 28 February as the anniversary of 29 February in a year without one (the note on
  Example 4.b). `years between @2012-02-29 and @2012-01-15` is `0` instead of `-1`,
  `years between @2016-02-29 and @2012-03-01` is `-3` instead of `-4`, `years between @2015-03-01 and @2012-02-29` is
  `-3` instead of `-4`, and `years between @2012-02-29 and @2012-02-28` is `0` instead of `-1`. This holds for Dates
  and DateTimes, and for `CalculateAgeInYearsAt` at a date before a birth on 29 February:
  `CalculateAgeInYearsAt(@2012-02-29, @2012-01-15)` is `0` instead of `-1`. Counting forwards, as an age at or after
  birth does, and `months between` are unchanged. (#1867, #1886)

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
