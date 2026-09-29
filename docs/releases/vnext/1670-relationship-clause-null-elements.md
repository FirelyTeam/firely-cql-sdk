## Fixes

- **`with` / `without` evaluate `such that` for null elements of the related list.** A query relationship
  clause was compiled to `exists (R where c)`, and `exists` ignores null elements, so a null element of the
  related list could never satisfy the clause: `with` dropped the source element and `without` kept it, even
  when the author's `such that` explicitly accepted the null case (for example
  `with { "Event for episode"(D) } E such that E.eventDate is null or ...`). A relationship clause over a list
  now keeps (`with`) or drops (`without`) the source element as soon as `such that` is `true` for any element of
  the related list, null elements included, as the CQL reference engine does. A related source that is a null
  singleton (not a list), and a null related list, still relate to nothing. An author's own `exists (X where c)`
  is unchanged and keeps ignoring null elements. (#1669, #1670)

  **This changes CQL evaluation results** for relationship clauses whose related list can hold a null element
  that satisfies the `such that` condition.

## Potentially Breaking

- `ICqlOperators` gained the abstract member `bool? AnyRelated<T>(IEnumerable<T>? related, Func<T, bool?> suchThat)`,
  which the generated C# for a relationship clause over a list source now calls in place of `WhereAny`. It has
  no default interface implementation, so a custom `ICqlOperators` implementation fails to compile until it
  implements it: `true` when `suchThat` is `true` for at least one element of `related` (null elements
  included), otherwise `false`, and `false` for a null `related`. (#1669, #1670)
- `LibrarySetCSharpCodeGenerator.GeneratorToolVersion` moves `5.2.2.0` → `5.3.0.0`, and
  `LibraryInstanceInvoker_5_0` now accepts `[5.1.0.0, 5.4.0.0)`. Generated code at `5.3.0.0` calls
  `AnyRelated`, which older runtimes do not have; an older invocation toolkit skips such libraries at load
  instead of running them. Libraries generated at an earlier version still load, but keep the old
  null-dropping behaviour until regenerated: regenerate checked-in generated C# and packaged FHIR `Library`
  resources with embedded C#/assemblies, and upgrade runtime and generated content together. (#1669, #1670)
