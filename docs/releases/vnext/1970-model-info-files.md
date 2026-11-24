## Features

- **CQL-to-ELM** — a model that does not ship with the SDK can be read from its model info XML with the new
  `ModelInfo.LoadFromFile` and `ModelInfo.LoadFromStream` in `Hl7.Cql.Model`, and translated against by passing it
  through `CqlToolkitConfig.ModelInfos`. (#1740)
- **Packager CLI** — the `Cql:ModelInfos` setting lists model info XML files, relative to the current directory, that
  the `cql` command loads next to the models selected in `Cql:Models`. A file that cannot be read, or that is not a
  model info, stops the command before any library is translated, with a message naming the file. (#1740)
