## Potentially Breaking

- **Runtime** — `HashValueSetDictionary` signals an error for a membership test against a value set that was not
  added to it. It throws `CqlException<CqlUnresolvedValueSetError>` where it returned `false`, an answer that could not
  be told apart from a code that is not in the value set. The specification requires the error in §9.B, section
  "In (Valueset)": "If the value set reference cannot be resolved, a run-time error is thrown." `HashValueSetDictionary`
  is also the dictionary a context uses when the host passes none to `FhirCqlContext.ForBundle` or
  `FhirCqlContext.WithDataSource`, so a context created without value sets now signals the error for every value set it
  is asked about. This reaches every membership test made through the dictionary: the `in` operators on a code, string,
  concept or list of them, and a retrieve filtered by a value set, such as `[Condition: "Diabetes"]`, as soon as a
  resource with a code is tested against it. A value set the dictionary holds answers as before. Expanding a value set
  to its codes, as `ExpandValueSet` or a value set used as a `List<Code>` does, still gives no codes for a value set the
  dictionary does not hold, since the specification does not make that an error. (#1865)
  - **Who sees a difference:** a host that evaluates CQL referencing a value set without giving the context a value
    set dictionary, or giving it a `HashValueSetDictionary` that lacks the value set. A membership test against such a
    value set was `false`; the evaluation now ends with the error.
  - **What to do:** give the context a value set dictionary that holds every value set the libraries reference, such
    as a `HashValueSetDictionary` filled through `Add`, or a `ValueSetSource`. The error is the one `ValueSetSource`
    throws for a value set it cannot resolve: an `ICqlEvaluationError` that names the value set in `ValueSetUri`, so
    `catch (CqlException e) when (e.Error is ICqlEvaluationError)` recognizes it.

This changes CQL evaluation results for the affected expressions. Generated C# and `GeneratorToolVersion` are unchanged.
