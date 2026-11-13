## Performance

- **Runtime (`Hl7.Cql.Elm`)** — Parsing and writing ELM JSON (`Library.ParseFromJson`, `Library.LoadFromJson`,
  `Library.SerializeToJson`, `Library.WriteJson`) now uses System.Text.Json's native polymorphism instead of a
  converter that built serializer options for every node. Parsing CMS133 drops from 786 ms to 10.9 ms and
  FHIRHelpers-4.0.1 from 480 ms to 3.3 ms; serializing CMS133 drops from 480 ms to 1.9 ms and FHIRHelpers-4.0.1 from
  206 ms to 1.0 ms. Parsing FHIRHelpers-4.0.1 allocates about 3 MB instead of about 417 MB.

## Fixes

- **Runtime (`Hl7.Cql.Elm`)** — Reading ELM JSON whose `"type"` names an abstract class now gives a `JsonException`
  instead of a `NotSupportedException`.
- **Runtime (`Hl7.Cql.Elm`)** — `"type": null` now gives a `JsonException` naming the path instead of a
  `NullReferenceException`.
- **Runtime (`Hl7.Cql.Elm`)** — Reading or writing ELM nested deeper than the thread's stack allows now gives a
  `JsonException` instead of ending the process with a stack overflow. How deep that is depends on the stack: about
  800 levels of nested expressions on a 1 MB stack, where previously about 450 were read before the process crashed,
  and about 4,000 on an 8 MB stack. `MaxDepth` stays 4,096.
- **CQL to ELM translation** — A model or an included library used as a value, including as an operand such as
  `FH + 1`, `FH[0]`, `-FH` or `start of FH`, is reported with an error reference instead of an internal `IncludeRef`
  or `UsingRef` node, so the ELM of that library can be serialized. `Floor(FH)` now reports one error instead of two.

## Potentially Breaking

- **Runtime (`Hl7.Cql.Elm`)** — Writing a subclass that is not part of the ELM model now throws
  `NotSupportedException` instead of writing a `"type"` that nothing can read.
- **Runtime (`Hl7.Cql.Elm`)** — The messages for malformed ELM JSON are now System.Text.Json's and include the JSON
  path, for example `Read unrecognized type discriminator id 'Bogus'. Path: $.expression` instead of
  `Unknown type discriminator 'Bogus' for base type Expression`, and the same wording replaces
  `type property should be 'Library' but was 'Wrong'` for a library, a `VersionedIdentifier` and a tuple element. The
  exception type stays `JsonException`. Code that matches on the old message text needs to change.
- **Runtime (`Hl7.Cql.Elm`)** — The `"type"` of an element of a `TupleTypeSpecifier` is now validated: an unrecognized
  name, which was accepted before, now throws a `JsonException`.
