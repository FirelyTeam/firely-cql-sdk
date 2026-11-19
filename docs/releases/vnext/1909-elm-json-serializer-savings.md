## Performance

- **Runtime (`Hl7.Cql.Elm`)** — A process that writes ELM JSON both compact and indented, as the Packager CLI does when
  it saves compact ELM files and packages indented attachments, builds the serializer's metadata once instead of twice.
  Its first indented write allocates 0.8 to 2.7 MB instead of 84 to 87 MB, and a one-library process of that shape
  finishes about 90 ms (20%) sooner.
- **Runtime (`Hl7.Cql.Elm`)** — The ELM attachment of a packaged FHIR `Library` is written straight into UTF-8, and a
  library's kept source is re-formatted by copying tokens instead of building a `JsonDocument`. Indented, the
  attachment takes 0.41 to 0.50 of the time with 11 to 12% of the allocation when the source is re-formatted, and 0.28
  to 0.56 of the time with 20 to 26% of the allocation when the library is serialized. Compact, it takes 0.67 to 0.86
  of the time.
- **CQL to ELM translation** — Saving translated ELM files serializes each library into a pooled
  buffer and writes the file once: one save allocates 54 to 135 KB instead of 0.5 to 4 MB, and takes 0.50 to 0.81 of
  the time.
- **Runtime (`Hl7.Cql.Elm`)** — Loading an ELM file with CR LF line endings normalizes them in one vectorized pass:
  CMS133 loads in 0.78 of the time and allocates 16% less.
- **Packager CLI** — `replace-library-attachments` reads ELM bytes through a stream instead of a decoded string, which
  allocates 21 to 38% less once warm.
- **Runtime (`Hl7.Cql.Elm`)** — Release builds no longer run the serializer's debug check, which boxed a default value
  for every property not marked as specified: 12.7 KB less per write of FHIRHelpers.

## Fixes

- **Runtime (`Hl7.Cql.Elm`)** — Packaging a library loaded from ELM nested more than 1,000 levels deep with
  `ElmAttachmentFormatting.Indented` or `ElmAttachmentFormatting.Compact` no longer fails while writing its ELM
  attachment. The attachment writer now takes the serializer's maximum depth of 4,096.
- **Packager CLI** — `replace-library-attachments` updates the CQL options parameter and extension from an ELM file that
  starts with a UTF-8 byte order mark, where it used to log a warning and leave them unchanged. Packaging ELM bytes on
  their own, without a parsed library, accepts such a file instead of throwing `JsonException`.
- **Packaging** — An ELM attachment no longer starts with a byte order mark when the ELM file had one. JSON must not begin
  with one, and a consumer that parses the attachment as UTF-8 bytes rejected it.
- **Runtime (`Hl7.Cql.Elm`)** — `Library.LoadFromJson(FileInfo)` reads an ELM file that starts with a UTF-8 byte order
  mark instead of throwing `JsonException`, as `Library.LoadFromJson(Stream)` already did.
