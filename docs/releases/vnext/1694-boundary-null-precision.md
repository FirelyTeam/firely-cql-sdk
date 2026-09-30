## Fixes

- `HighBoundary` and `LowBoundary` with a null precision use the greatest precision of the input's type (8 for Decimal, day for Date, millisecond for DateTime and Time) instead of returning `null`. At that precision the result keeps every component the input has and fills only the missing ones: `HighBoundary(1.58888, null)` is `1.58888999`, `LowBoundary(1.58888, null)` is `1.58888000`, `HighBoundary(@2014-01-15, null)` is `@2014-01-15` and `HighBoundary(@T10:30, null)` is `@T10:30:59.999`. With an explicit precision at that maximum, a Date keeps its day (`HighBoundary(@2014-01-15, 8)` is `@2014-01-15`, not `@2014-01-31`), a DateTime or Time keeps its milliseconds (`HighBoundary(@T10:30:15.250, 9)` is `@T10:30:15.250`), and `HighBoundary(@2014-02, 17)` is `@2014-02-28T23:59:59.999` instead of throwing `ArgumentException`. (#1694)

This changes CQL evaluation results for the affected expressions.
