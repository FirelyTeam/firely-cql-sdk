## Breaking changes

- **Packager** — the ELM embedded as the `application/elm+json` attachment of a packaged FHIR `Library`
  is now taken from the JSON the library was read from, instead of being rebuilt from the ELM object
  graph. The attachment therefore keeps empty collections such as `annotation` and `signature`, and no
  longer gains the normalizations serialization applied — `accessLevel` written out explicitly, and
  `resultTypeSpecifier` derived from a legacy `type` discriminator. Parsing either form through this SDK
  yields an equivalent library, since those corrections are applied on load. The new
  `Packaging:ElmAttachmentFormatting` setting controls the attachment's whitespace — `Passthrough` (the
  default, byte-identical to the source file), `Indented` or `Compact`. (#1715)

## Fixes

- **Packager** — packaging no longer re-serializes every ELM library purely to embed it as an attachment.
  That rebuild walked every ELM node through the polymorphic type resolver and accounted for almost all of
  the FHIR packaging stage. (#1715)

- **Packager** — packaging no longer compiles the whole library set three times. `CompileToAssemblies`
  only short-circuited when *every* library had produced an assembly, so a single library that
  legitimately produced none made each subsequent call redo the entire set and discard the result. It is
  now a true no-op while the artifact set is unchanged. (#1715)
