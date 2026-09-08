## Fixes

- **Runtime:** the `Interval` selector keeps an exclusive date, dateTime or time boundary exclusive
  instead of normalizing it to a closed boundary one unit of the value's own precision inward. That
  normalization was lossless only for comparisons at the value's own precision; a timing phrase that
  compares at a coarser precision, such as `6 months or less before day of start of X` (an interval
  with an exclusive high compared with `in ... day`), silently became inclusive, so an event on the
  same day as the boundary counted where the CQL excludes it. `in` now applies the exclusive
  comparison the specification requires ("For open interval boundaries, exclusive comparison
  operators are used", CQL 1.5.3 Appendix B, 5.3). Because a CQL interval can now carry an exclusive
  boundary into the FHIR conversion, the conversion to a `Period` steps an exclusive date/time boundary
  inward by one unit of its precision, as the `Range` conversion already did, so emitted Periods are
  unchanged. **CQL evaluation results change** for same-day boundary cases; the three CMS646
  intravesical BCG therapy test cases of the MADiE corpus that exercise this pattern pass.
