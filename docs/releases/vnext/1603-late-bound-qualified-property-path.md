## Fixes

- **Runtime:** `LateBoundProperty` now walks a qualified property path segment by segment instead of
  handing the whole dotted string to reflection. An ELM `Property` element's `path` may be qualified —
  `medication.reference.value` — and the code generator passes it to the operator verbatim; reflection
  resolves one property name at a time, so the qualified path matched nothing and every late-bound
  access through one silently evaluated to `null`. Only paths that fall through to late binding were
  affected, which is where an element reached through a choice or union type surfaced as `object` ends
  up: `CodeBuilderContext` already walked the segments the same way whenever the types were known at
  design time. Only the final segment is converted to the requested type; a null or unresolvable
  intermediate segment short-circuits to `null` as before, so an unresolvable path still degrades
  rather than throwing. **CQL evaluation results change** wherever a qualified path was late-bound —
  in particular for `MedicationRequest.medication` given as a `Reference`, where the measure content
  resolves the reference itself by comparing a `Medication`'s id against the last segment of
  `medication.reference.value`. The CMS165 controlling-high-blood-pressure test case of the MADiE
  corpus that orders a dementia medication through such a reference passes.
