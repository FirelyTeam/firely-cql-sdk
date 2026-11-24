## Breaking

- **CQL to ELM translation** — `CqlToolkitConfig` and `CqlToElmOptions` default to the configuration the reference
  ELM is produced with by the Java translator: list promotion and demotion enabled (`DisableListPromotion` and
  `DisableListDemotion` are `false`), interval promotion and demotion disabled (`EnableIntervalPromotion` and
  `EnableIntervalDemotion` are `false`), and `AmbiguousTypeBehavior.PreferModel`. CQL that relied on the old defaults
  can now translate differently: a single value passed where a list is expected, or a list of one where a single
  value is expected, is converted instead of reported, and a point passed where an interval is expected, or the
  other way round, is reported instead of converted, except in `on or before` and `on or after` phrases, which
  compare the point as a point interval as the reference translator does. A type name defined by both System and a model resolves to the
  model's type instead of being reported as ambiguous. One case the reference translator handles regresses:
  `Coalesce` over intervals resolved only through interval promotion and demotion and is now reported unresolved
  (#1673). To
  keep the old behavior, set the five switches explicitly.
  `Cql/Cql.CqlToElm/README.md` records the configuration. (#1727)
- **Packager CLI** — the default settings file uses the same configuration, so the `cql` command translates with
  list promotion and demotion enabled and interval promotion and demotion disabled. A settings file that sets these
  switches itself is unaffected. (#1727)

## Fixes

- **CQL to ELM translation** — with list promotion enabled, a value set passed where a generic list is expected, as
  in `Count("Value Set")`, is expanded to its codes (`ExpandValueSet`) instead of promoted to a list holding the
  value set, as the Java translator does. `Count` of a value set therefore counts its codes, where it returned 1
  before. Generic inference now keeps the cheapest of the argument's own type and its implicit conversion targets.
  (#1727)
