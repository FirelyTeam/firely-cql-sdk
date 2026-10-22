## Potentially Breaking

- **Runtime (`Hl7.Cql.Fhir`)** — `ValueSetSource` signals an error for a membership test against a value set it cannot
  resolve: one that was not added to it, that its resource resolver does not find, while no terminology service is
  attached. It throws `CqlException<CqlUnresolvedValueSetError>` where it returned `false`, an answer that could not be
  told apart from a code that is not in the value set. The specification requires the error in §9.B, section
  "In (Valueset)": "If the value set reference cannot be resolved, a run-time error is thrown." This reaches every
  membership test made through a `ValueSetSource`: the `in` operators on a code, string, concept or list of them, and a
  retrieve filtered by a value set, such as `[Condition: "Diabetes"]`, as soon as a resource with a code is tested
  against it. A value set the source holds or resolves answers as before, and so does an attached terminology service.
  (#1521)
  - **Who sees a difference:** a host that evaluates CQL referencing a value set it did not give its `ValueSetSource`,
    for example one built with `ToValueSetDictionary` from only some of the value sets its libraries use. A membership
    test against such a value set was `false`; the evaluation now ends with the error.
  - **What to do:** give the `ValueSetSource` every value set the libraries reference, through `Add` or its resource
    resolver, or attach a terminology service. The error is an `ICqlEvaluationError` and names the value set in
    `ValueSetUri`, so `catch (CqlException e) when (e.Error is ICqlEvaluationError)` recognizes it.

## New Public API

- **Runtime (`Hl7.Cql.Fhir`)** — `Hl7.Cql.Fhir.Errors.CqlUnresolvedValueSetError`, the `ICqlEvaluationError` carried
  by the exception above, with the canonical of the value set that could not be resolved in `ValueSetUri`. (#1521)

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
