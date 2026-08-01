## Improvements

- Opting into comparing FHIR resources by id no longer enumerates the model assembly's types on every
  call: `CompareResourcesById` now takes its list of `Resource` descendants from a process-wide lazy
  value, so the `Assembly.GetTypes()` sweep runs once per process instead of on every call — which ran
  per `CqlContext`, i.e. per patient in batch evaluations. In thread-time profiles of a 900-measure CMS
  evaluation run this sweep accounted for roughly 5% of steady-state CPU. Registration behavior is
  unchanged (#1479).
