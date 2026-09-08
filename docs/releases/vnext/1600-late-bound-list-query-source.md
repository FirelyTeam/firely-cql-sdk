## Fixes

- **Code generator:** a query whose source is a *late-bound* list-valued property — one reached
  through a choice or union type, which the ELM leaves untyped and the code generator surfaces as
  `object` — now iterates that list's elements instead of treating the list itself as the query's
  single element. The generator decided list-vs-singleton from the source expression's static type;
  for a late-bound source that type is `object`, so the value was wrapped in a one-element array and
  every element access inside the query body saw a `List<T>` where a `T` was expected, yielding
  `null` with no error. The promotion is now made on the runtime value
  (`ICqlOperators.PromoteLateBoundToList`), and the paired `singleton from` demotion is skipped when
  the ELM declares the query result to be a list, so a property holding more than one element is no
  longer truncated. CMS69 `reasonCode in "Overweight or Obese"` over
  `[ServiceRequest] union [MedicationRequest]` is the pattern this affects. **CQL evaluation results
  change:** a define containing this pattern previously scored as if the property were empty and now
  returns its values, so measure output can move; `GeneratorToolVersion` is bumped to `5.2.2.0` and
  packaged artifacts need regenerating. (#1600)
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
  intravesical BCG therapy test cases of the MADiE corpus that exercise this pattern pass. (#1600)
