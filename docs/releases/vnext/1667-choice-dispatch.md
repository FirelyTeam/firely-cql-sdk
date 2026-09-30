## Fixes

- **Property access on a choice-typed value is dispatched at compile time.** A `Property` whose source
  is a CQL choice type - a FHIR `choice[x]` element, a query alias over a `union` of resource types, a
  choice-typed function operand, the result of `FHIRHelpers.ToValue` - was emitted as an
  `ICqlOperators.LateBoundProperty` call resolved by reflection at run time. The compiler now
  enumerates the alternatives of the choice (from the ELM's `ChoiceTypeSpecifier`, or from the FHIR
  model for a `choice[x]` element without an ELM result type) and emits a dispatch on the value's
  type with one arm per alternative that has the element, `null` for the others. The value is
  evaluated once and narrowed per arm, and prints as a switch expression, a conditional over a
  declaration pattern (`x is Reference r ? r.ReferenceElement : null`), or, when an arm needs
  statements of its own, an `if` chain over declaration patterns. Alternatives that read the element
  through one member, inherited from a common base class or implemented for a common interface,
  share an arm: the string-valued primitives of an open `value[x]` are one `IValue<string>` arm, and
  `Age`, `Count`, `Distance` and `Duration` share the `Quantity` arm. When every alternative that has
  the element agrees on its type, the result has that plain type (`MR.medication.reference.value`
  is a `string`). Emission and type inference share one path resolver, so the inferred type of such
  a property follows the same rule. An alternative whose type cannot be inspected keeps a late-bound
  arm typed like the others, so a list-valued element read off a choice with such an alternative now
  builds and evaluates correctly for every inspectable alternative (#1645). Late binding remains only
  where no alternative can be determined. The type test the compiler emitted for an element declared
  on a base type of the source (`M is Resource`, always true) is no longer emitted.

- **The value of a FHIR primitive has the type the model declares.** The FHIR model info declares
  the `value` of every primitive as a System type (`FHIR.instant.value` is a `System.DateTime`,
  `FHIR.date.value` a `System.Date`), but the compiler read it as the .NET model's own
  representation (a `DateTimeOffset`, a `string`) wherever the ELM did not state the type it
  expected: in a MADiE-translated library, and in an arm of a choice dispatch whose alternatives
  differ in type. For every primitive whose .NET representation differs from the declared System
  type and converts to it (`date`, `dateTime`, `instant`, `time`, `base64Binary`), the value now
  converts to the declared System type there too, so for example
  `Observation.effective.value` is a `DateTime` for both its `dateTime` and its `instant`
  alternative, and `C.onset.value` yields a `DateTime` rather than the `FhirDateTime` itself.
  Accordingly, the QI-Core type `NotDoneRecorded` (the `recorded` element of the not-done profiles,
  read as the value of the `qicore-recorded` extension's value) now resolves to `System.DateTime`,
  as QI-Core declares it, rather than to `FHIR.dateTime`.

- **`FHIR.positiveInt` and `FHIR.unsignedInt` resolve to their own classes.** They resolved to
  `Integer`, but the SDK's `PositiveInt` and `UnsignedInt` are not `Integer`s, so a real value of
  either never passed a test for its type: `x is FHIR.positiveInt` was false for every
  `positiveInt`, `x as FHIR.positiveInt` was `null`, and FHIRHelpers' `ToValue` returned a
  `positiveInt` or `unsignedInt` value's FHIR instance instead of its `Integer` value. They now
  resolve to `PositiveInt` and `UnsignedInt`. A test for `FHIR.integer` still does not match them,
  although the CQL model declares them its subtypes (#1680).

  **This changes generated C#**: `GeneratorToolVersion` moves to `5.3.2.0` (patch: the generated API
  is unchanged), and every checked-in `*.g.cs` with a choice-typed property access is regenerated.

  **This changes CQL evaluation results.** At former late-bound sites, an empty list-valued element
  now evaluates to the empty list rather than to `null`, and a conversion that fails inside an arm
  now surfaces instead of degrading to `null`. A primitive's value read without an ELM result type
  now has its System type rather than the .NET model's. A test for, or cast to, `FHIR.positiveInt` or
  `FHIR.unsignedInt` now matches real values of those types. Per [versioning.md](../../versioning.md) this
  forces a **MESO** bump. (#1647)
