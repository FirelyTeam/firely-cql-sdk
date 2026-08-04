## Fixes

- Generated `Measure` resources no longer set `code` and `description` on the container
  stratifier that holds `@stratifier` components. A stratifier with components must not
  also carry `code`, `description`, or `criteria`, per the FHIR invariant on
  `Measure.group.stratifier`
  (`(code | description | criteria).exists() xor component.exists()`), so the previous
  output failed validation. The container now carries only its element id
  (`<group>-Stratifier`); the components are unchanged.
