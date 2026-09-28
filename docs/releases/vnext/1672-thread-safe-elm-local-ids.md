## Fixes

- **CQL-to-ELM translator and compiler:** translating CQL to ELM, and compiling ELM to assemblies, are safe to run
  on several threads at once in one process, each with its own `CqlToolkit` and `ElmToolkit`. Both number the ELM
  elements they create (`localId`) through one process-wide id generator, which was not thread-safe: two
  translations or compilations at the same time could fail with an `IndexOutOfRangeException` from
  `ObjectIDGenerator.FindElement`, or never return. The generator also held every element it had numbered for the
  life of the process, so a long-running host that keeps translating CQL kept all of those elements in memory; the
  ids are now kept without keeping their elements alive. (#1671)

  No change to CQL evaluation results, to the emitted ELM or C#, or to `GeneratorToolVersion`: ids are assigned as
  before, one per element, counting up across the process in the order elements are first seen.
