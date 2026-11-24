## Features

- **CQL to ELM translation (`Hl7.Cql.Model`)** — a model that does not ship with the SDK can be read from its model
  info XML with the new `ModelInfo.LoadFromFile` and `ModelInfo.LoadFromStream`, and translated against by passing
  it through `CqlToolkitConfig.ModelInfos`. The toolkit adds models after the models they require, whatever order
  `ModelInfos` enumerates them in, and refuses a model configured twice in the same version with a message naming
  it. (#1740, #1970)
- **Packager CLI** — the `Cql:ModelInfoFiles` setting lists model info XML files, relative to the current
  directory, that the `cql` and `elm` commands translate against next to the models selected in `Cql:Models`. A file
  that cannot be read, or that is not a usable model info, stops the command before any library is translated, with
  a message naming the file. (#1740, #1970)
