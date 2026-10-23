## Potentially Breaking

- **Runtime** — Testing a code without a code system for membership in a value set that holds codes from more than
  one code system signals an error. The String overload of `in (Valueset)`, such as `'1234' in "Some Value Set"`,
  matched the string against the codes of every system and answered `true` when any of them had it; it throws
  `CqlException<CqlAmbiguousStringInValueSetError>` instead. The specification requires the error in §9.B, section
  "In (Valueset)": "if the resolved value set contains codes from multiple code systems, a run-time error is thrown
  because the operation is ambiguous." The runtime tests a `Code` without a system the same way as a string, so
  `Code { code: '1234' } in "Some Value Set"`, and a `Concept` or list holding such a code, signal the error too. Every
  value set dictionary of the SDK behaves the same: `HashValueSetDictionary`, `ValueSetSource`, and an
  `InMemoryValueSet` tested on its own. `ValueSetSource` cannot tell for a value set that only its terminology service
  knows, and leaves that test to the service. Code systems are told apart ignoring case, and a code of the value set
  that has no system does not count as a code system of its own. A value set of one code system answers as before, and
  a `Code` that names its system is not affected. (#1866)
  - **Who sees a difference:** a library that tests a string, or a code without a system, against a value set whose
    codes come from more than one code system, such as one that mixes SNOMED CT and ICD-10-CM codes. The test answered
    `true` or `false`; the evaluation now ends with the error.
  - **What to do:** test a `Code` that names its system, or use a value set of one code system. The error is an
    `ICqlEvaluationError` that names the value set in `ValueSetUri` and the code in `Code`, so
    `catch (CqlException e) when (e.Error is ICqlEvaluationError)` recognizes it.

## New Public API

- **Runtime** — `Hl7.Cql.ValueSets.Errors.CqlAmbiguousStringInValueSetError`, in `Hl7.Cql.Runtime`, the
  `ICqlEvaluationError` carried by the exception above, with the value set in `ValueSetUri` and the code tested in
  `Code`. `ValueSetUri` is `null` only for an `InMemoryValueSet` tested on its own, which does not know its canonical
  URI. (#1866)

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
