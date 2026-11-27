## Dependency Updates

- **Runtime** — `FhirMetricsVersion`: `1.4.1` → `1.4.2`. The metric service now refuses to add, subtract or convert
  between quantities whose units have different dimensions, such as `'cm'` and `'cm2'`, and equal metrics have equal
  hash codes. The quantity `Add` and `Subtract` operators rely on the service for that check instead of comparing
  the canonical units themselves. Results with the default `FhirMetricService` are unchanged: such an addition or
  subtraction gave null before and gives null now. A service injected through `FhirCqlContextOptions.MetricService`
  decides on its own whether two units can be added or subtracted. (#1988)
