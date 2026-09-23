## Fixes

- **CQL-to-ELM translator:** a query whose source cannot be resolved, such as
  `NoSuchDefine E where E is not null`, reports `Could not resolve identifier NoSuchDefine in the
  current library.` instead of throwing `InvalidOperationException` out of translation. A library
  that reaches this never translated, so no evaluation result moves and there is no
  `GeneratorToolVersion` change.
