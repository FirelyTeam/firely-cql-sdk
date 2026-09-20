## Fixes

- **Property access on a choice-typed value is dispatched at compile time.** A `Property` whose source
  is a CQL choice type - a FHIR `choice[x]` element, a query alias over a `union` of resource types, a
  choice-typed function operand, the result of `FHIRHelpers.ToValue` - was emitted as an
  `ICqlOperators.LateBoundProperty` call resolved by reflection at run time. The compiler now
  enumerates the alternatives of the choice (from the ELM's `ChoiceTypeSpecifier`, or from the FHIR
  model for a `choice[x]` element without an ELM result type) and emits one typed branch per
  alternative that has the element, `null` for the others; when only one alternative has the element
  the result is that element's plain type (`MR.medication.reference.value` is a `string`). Emission and
  type inference share one path resolver, so the inferred type of such a property follows the same
  rule. An alternative whose type cannot be inspected keeps a late-bound branch typed like the others,
  so a list-valued element read off a choice with such an alternative now builds and evaluates
  correctly for every inspectable alternative (#1645). Late binding remains only where no alternative
  can be determined. The type test the compiler emits for an element declared on a base type of the
  source (`M is Resource`, always true) is no longer emitted.

- **Branches of an emitted `if`/`else` chain reuse the locals of their enclosing block.** A
  subexpression already computed before the chain (the value a type test switches on, typically a
  function call such as `FHIRHelpers.ToValue`) was evaluated again inside every branch that used it.
  Branches now reference the enclosing local instead, so such a value is computed once.

  **This changes generated C#**: `GeneratorToolVersion` moves to `5.2.4.0` (patch: the generated API
  is unchanged), and every checked-in `*.g.cs` with a choice-typed property access is regenerated.

  **This changes CQL evaluation results.** At former late-bound sites, an empty list-valued element
  now evaluates to the empty list rather than to `null`, and a conversion that fails inside a branch
  now surfaces instead of degrading to `null`. Per [versioning.md](../../versioning.md) this forces a
  **MESO** bump. (#1647)
