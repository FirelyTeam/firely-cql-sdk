## Fixes

- `years between` a 29 February start and 28 February of a year without a leap day counts that day as the anniversary, so `years between @2012-02-29 and @2014-02-28` is `2` instead of `1`. `AgeInYears()` and `AgeInYearsAt()` follow, so a patient born on a leap day is a year older on 28 February of a non-leap year than before. When the end year has a leap day, 28 February is still short of the anniversary. (#1685)

This changes CQL evaluation results for the affected expressions.
