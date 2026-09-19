## Fixes

- **Qualified (dotted) property paths now resolve in late-bound property access.**
  `ICqlOperators.LateBoundProperty<T>` treated its `propertyName` argument as a single element name.
  The scoped form of an ELM `Property` node emits its `path` verbatim, so a qualified path such as
  `medication.reference.value` was looked up as one literal element name, found nothing, and returned
  `null`. `LateBoundProperty<T>` now splits the path and resolves each segment against the runtime type
  of the value the preceding segment produced, which is what the logical specification requires and what
  the unscoped form of `Property` already did.

  Walking the runtime type is what makes these paths resolvable at all: `MedicationRequest.medication`
  is declared as `DataType`, so `reference` exists only on the concrete `ResourceReference` the element
  holds at run time, never on the declared type.

  **This changes CQL evaluation results.** The affected paths are the CQL translator's standard expansion
  of `[MedicationRequest: "<valueset>"]` into a medication-by-reference join, so any medication retrieve
  resolved through `MedicationRequest.medicationReference` previously returned no rows and now matches.
  Expressions that silently evaluated to `false` or an empty list can now evaluate to `true` or a
  populated list, and measure populations computed from them change accordingly. Per
  [versioning.md](../../versioning.md) this forces a **MESO** bump: consumers should re-check any
  measure results that involve reference-based medication retrieves, even though no public API,
  generated C# output, or `GeneratorToolVersion` changes. (#1638)
