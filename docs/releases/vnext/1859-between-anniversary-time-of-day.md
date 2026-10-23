## Fixes

- **Runtime** — `years between` and `months between` two DateTimes count a year or a month that ends on the anniversary
  date as whole only once the start's time of day has been reached, as Appendix H of the CQL specification defines a
  year and a month. `years between @2012-03-10T22:05:09 and @2013-03-10T19:10:03` is `0` instead of `1`, and
  `months between @2012-03-10T22:05:09 and @2012-04-10T19:10:03` is `0` instead of `1`. The reverse direction
  mirrors the rule: `years between @2013-03-10T19:10:03 and @2012-03-10T22:05:09` is `0` instead of `-1`. This
  holds on 29 February and, for a start on 29 February, on 28 February of a year without a leap day, in both
  directions. `duration in years of` and `duration in months of` a DateTime interval, and `CalculateAgeInYearsAt` and
  `CalculateAgeInMonthsAt` given a birth DateTime with a time of day, follow. The times of day are compared only as
  far as both values specify them, with seconds and milliseconds as one precision. Dates, and DateTimes without a
  time of day such as `ToDateTime(Patient.birthDate)`, give the same results as before, so `AgeInYears`,
  `AgeInYearsAt`, `AgeInMonths` and `AgeInMonthsAt` are unchanged. One such case does change: from a 29 February
  DateTime with a time of day to 28 February without one, `years between @2012-02-29T12:34:56 and DateTime(2014, 2, 28)`
  is `2` instead of `1`, the count it already gave on any other anniversary date. When one value specifies the time of
  day further than the other, as there, the count is taken at the coarser precision, which is one end of the
  uncertainty interval the specification defines for it (Language Semantics, "Determining Difference and Duration"):
  that case gives `[1, 2]`, and `years between @2012-03-10T22:30 and @2013-03-10T22` is `1` where the specification
  gives `[0, 1]`. The same goes for `AgeInYearsAt` and `AgeInMonthsAt` given a DateTime on the birthday, which count
  the year or the month as whole from the first moment of the birthday. Support for uncertainty is tracked in #132.
  (#1702, #1859)

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
