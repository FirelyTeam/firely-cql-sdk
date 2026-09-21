## Fixes

- **CQL-to-ELM translator:** a retrieve that filters by terminology now carries the property it
  filters on and how. When the source names no code path, `codeProperty` is the type's primary code
  path from the model (`code` for Condition, `medication` for MedicationRequest, `vaccineCode` for
  Immunization, `type` for Encounter); when it names no comparator, `codeComparator` is `in` for a
  list, a value set or a code system and `~` for a code or a concept, which is the reference
  translator's rule. Authored paths and comparators are kept. Previously a value-set retrieve such
  as `[Condition: "Diabetes"]` carried neither attribute, so a consumer without the model
  information could not tell which property to match, and a single-code retrieve always wrote the
  literal `code` as the path, even over an authored one. A type with no primary code path still
  gets no `codeProperty`, and now gets the comparator, as in the reference.

  **This changes CQL evaluation results** wherever the emitted path changes. A retrieve with an
  authored path and a single code, such as `[Observation: category ~ "Metformin"]`, filtered on
  `code` and now filters on `category`. A single-code retrieve on a type that has a `code` element
  but a different primary code path (in FHIR 4.0.1: ActivityDefinition `topic`, Questionnaire
  `name`, SearchParameter `target`) filtered on `code` and now filters on the primary code path.
  A single code reached through an expression reference (`[Observation: "One"]` with
  `define "One": "Metformin"`) failed to compile and now evaluates, since it is wrapped in
  `ToList`. Every other retrieve evaluates as before: a `codeProperty` equal to the primary code
  path compiles the same as none, and the runtime resolves that path itself.

  **Packaging:** the data requirements analyzer now sees a path on every terminology retrieve. A
  single-code retrieve's code filter names the primary code path where it named `code`. A
  value-set, list or concept retrieve gains a code filter and the path as must-support where it
  had neither. A terminology the analyzer cannot enumerate statically (an expression reference, a
  code system, a list with an element it cannot resolve) contributes no code filter, where the
  analyzer previously threw; the path still counts as must-support.
