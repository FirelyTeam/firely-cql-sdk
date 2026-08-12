## Improvements

- Opting into comparing FHIR resources by id no longer enumerates the model assembly's types on every
  call: `CompareResourcesById` now takes its list of `Resource` descendants from a process-wide lazy
  value, so the `Assembly.GetTypes()` sweep runs once per process instead of on every call — which ran
  per `CqlContext`, i.e. per patient in batch evaluations. In thread-time profiles of a 900-measure CMS
  evaluation run this sweep accounted for roughly 5% of steady-state CPU. Registration behavior is
  unchanged: the same types are registered, each with a `ResourceIdCqlComparer` still built per call
  from the caller's `StringComparer`. The one behavioral difference is on the failure path — a model
  assembly that is only partially loadable makes `Assembly.GetTypes()` throw, and the lazy value caches
  that failure and rethrows it on every later call, where the per-call sweep re-attempted it each time
  (#1479, #1481).
