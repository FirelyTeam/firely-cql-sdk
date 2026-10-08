## Features

- **CQL-to-ELM** — the QICore 4.1.1 and 6.0.0 and US Core 3.1.1 and 6.1.0 model infos now ship with the
  SDK, embedded in `Hl7.Cql.Model`, so libraries declaring `using QICore version '6.0.0'` (or one of the
  other three) translate without supplying the model info yourself. They are opt-in: select them through
  the new `CqlModel` members `QICore411`, `USCore311`, `QICore600` and `USCore610` in
  `CqlToolkitConfig.Models`, or by name in the Packager's `Cql:Models` setting. The default model set is
  unchanged. A bundled model info is only deserialized when selected, but the `Hl7.Cql.Model` package
  grows by the size of the four XML files (about 3 MB uncompressed). Because a type is identified by its
  model's url and name without a version, a `CqlToolkit` refuses, at construction and with a message
  naming the model and versions, a configuration that selects two versions of the same model; such a
  configuration failed on the first type lookup before. Translate libraries written against another
  version with a separate toolkit. (#1740)
