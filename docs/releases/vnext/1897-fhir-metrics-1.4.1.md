## Dependency Updates

- **Runtime** — `FhirMetricsVersion` was bumped from `1.4.0` to `1.4.1` (#1897). The decimal overloads of
  `MetricServiceExtensions`, which the runtime uses for UCUM arithmetic and conversion, now parse a value an
  `IMetricService` returns in exponential notation, and refuse a value with a non-zero digit beyond the 28th decimal
  place instead of rounding it. Results with the default `FhirMetricService` are unchanged; a service injected through
  `FhirCqlContextOptions.MetricService` that writes exponential notation now works with them.
