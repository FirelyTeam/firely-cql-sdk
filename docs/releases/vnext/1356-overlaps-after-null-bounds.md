## Fixes

- `OverlapsAfter` no longer incorrectly returns `false` when either interval has an unbounded (null) boundary. A null low boundary now substitutes the minimum value and a null high boundary substitutes the maximum, matching what `OverlapsBefore` already did; previously the substitutions were inverted, so an interval with no upper bound (e.g. `Interval[onset, lastOccurrence]` where `lastOccurrence` is absent) never overlapped after anything. This restores the denominator exceptions of CMS135 and CMS144 that rely on `overlaps after` with allergy-intolerance intervals (#1356).
