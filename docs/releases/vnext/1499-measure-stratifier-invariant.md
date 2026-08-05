## Breaking Changes

- Generated `Measure` resources no longer set `code` or `description` on the container stratifier
  (`<group>-Stratifier`). Re-packaging an unchanged CQL library now produces different
  `Measure.group.stratifier` JSON than previous versions: any tool or test that diffs or asserts on
  the generated output will observe the removal. The per-component `code`, `description`, and
  `criteria` values are unchanged. (#1499)

## Fixes

- Generated `Measure` resources no longer set `code` and `description` on the container
  stratifier that holds `@stratifier` components. A stratifier with components must not
  also carry `code`, `description`, or `criteria`, per the FHIR invariant on
  `Measure.group.stratifier`
  (`(code | description | criteria).exists() xor component.exists()`), so the previous
  output failed validation. The container now carries only its element id
  (`<group>-Stratifier`); the components are unchanged. (#1499)
