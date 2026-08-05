## Breaking Changes

- The Packager's generated `Measure` JSON changed shape: `Measure.group.stratifier` entries no
  longer carry `code` or `description`. Both previously duplicated the container's element id
  (`<group>-Stratifier`) and made the resource invalid (see the fix below). Anyone diffing or
  asserting on generated `Measure` resources from re-packaged libraries will see this difference;
  the human-readable labels remain on `stratifier.component.code`/`.description`, which is where
  consumers should read them. (#1499)

## Fixes

- Generated `Measure` resources no longer set `code` and `description` on the container
  stratifier that holds `@stratifier` components. A stratifier with components must not
  also carry `code`, `description`, or `criteria`, per the FHIR invariant on
  `Measure.group.stratifier`
  (`(code | description | criteria).exists() xor component.exists()`), so the previous
  output failed validation. The container now carries only its element id
  (`<group>-Stratifier`); the components are unchanged. A container also can no longer be
  emitted without at least one component (which would equally violate the invariant). (#1499)
- CQL-to-ELM generation (`CqlToolingEnabled`) now works on Linux/macOS: the Java classpath
  wildcard in `Demo/Cql/Build/CqlTooling.Targets.xml` is quoted so Unix shells no longer
  expand it before `java` sees it, which misread the first dependency jar as the main
  class. (#1499)
