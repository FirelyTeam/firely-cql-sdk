## Fixes

- **Code generator:** a query whose source is a *late-bound* list-valued property — one reached
  through a choice or union type, which the ELM leaves untyped and the code generator surfaces as
  `object` — now iterates that list's elements instead of treating the list itself as the query's
  single element. The generator decided list-vs-singleton from the source expression's static type;
  for a late-bound source that type is `object`, so the value was wrapped in a one-element array and
  every element access inside the query body saw a `List<T>` where a `T` was expected, yielding
  `null` with no error. The promotion is now made on the runtime value
  (`ICqlOperators.PromoteLateBoundToList`), and the paired `singleton from` demotion is skipped when
  the ELM declares the query result to be a list, so a property holding more than one element is no
  longer truncated. CMS69 `reasonCode in "Overweight or Obese"` over
  `[ServiceRequest] union [MedicationRequest]` is the pattern this affects. **CQL evaluation results
  change:** a define containing this pattern previously scored as if the property were empty and now
  returns its values, so measure output can move; `GeneratorToolVersion` is bumped to `5.2.2.0` and
  packaged artifacts need regenerating.
