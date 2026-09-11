## Fixes

- **Runtime:** the `Interval` selector keeps an exclusive date, dateTime or time boundary exclusive
  instead of normalizing it to a closed boundary one unit of the value's own precision inward. That
  normalization was lossless only for comparisons at the value's own precision; a timing phrase that
  compares at a coarser precision, such as `6 months or less before day of start of X` (an interval
  with an exclusive high compared with `in ... day`), silently became inclusive, so an event on the
  same day as the boundary counted where the CQL excludes it. `in` now applies the exclusive
  comparison the specification requires ("For open interval boundaries, exclusive comparison
  operators are used", CQL 1.5.3 Appendix B, section "In"), and `contains` shares that
  implementation, so it no longer disagrees with `in` and `includes` at a coarser precision.
  **CQL evaluation results change** for same-day boundary cases; the three CMS646 intravesical BCG
  therapy test cases of the MADiE corpus that exercise this pattern pass. (#1602)

- **Runtime:** the interval operators the specification defines "using the semantics described in
  the Start and End operators" now compare the effective boundaries rather than the raw endpoints:
  `starts`, `ends`, `includes`/`included in`, `properly includes`/`properly included in` (both the
  interval-interval and the point-interval overloads), `intersect` and `point from`, plus the
  ordering `collapse` merges intervals in. The selector's own normalization used to hand these
  operators pre-closed intervals, so an exclusive boundary reaching them read one unit of its own
  precision too wide - `Interval(@2026-01-01, @2026-01-02] starts Interval[@2026-01-01, @2026-01-03]`
  was true although its effective start is `@2026-01-02`, and `Interval[@2026-01-01, @2026-01-05)
  intersect Interval[@2026-01-05, @2026-01-08]` produced an empty interval instead of null. The
  operators that already normalized their operands (`after`, `before`, `meets`, `overlaps`,
  `same as`, `same or after`/`same or before`, `except`, `union`, `expand`, `width`, `size`) and
  interval equality, equivalence and hashing are unaffected. (#1602)

- **FHIR conversion:** because a CQL interval can now carry an exclusive boundary into the FHIR
  conversion, the conversion to a `Period` steps an exclusive date/time boundary inward by one unit
  of its precision, as the `Range` conversion already did, so emitted Periods are unchanged for the
  intervals that were previously representable. An exclusive boundary at the end of the point type's
  range - where `successor`/`predecessor` is not representable and `CqlDate`/`CqlDateTime` return
  null while `CqlTime` wraps around midnight - is emitted unstepped instead of throwing a
  `NullReferenceException` or emitting an invalid FHIR value such as `T00:00:00.-001`. (#1602)
