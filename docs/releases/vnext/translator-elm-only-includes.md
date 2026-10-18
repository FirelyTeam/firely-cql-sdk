## Features

- **CQL to ELM translation (`CqlToolkit`)** — `AddReferenceLibraries` takes ELM libraries that the translated CQL
  libraries include, such as FHIRHelpers loaded from its published ELM. The translator resolves an include from such a
  reference library when the toolkit holds no CQL for it, reading the names, access levels and result types of its
  definitions and the operand types of its functions from the ELM. A library whose include is available only as ELM
  then translates without an "Unable to resolve library" error for it, so the errors left in its ELM are its own. A
  reference library is not translated itself, a CQL library with the same identifier takes precedence over it, and a
  statement whose ELM declares no result type cannot be referenced. Translation without reference libraries is
  unchanged.
