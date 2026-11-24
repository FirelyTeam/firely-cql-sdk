## Fixes

- **Code generator** — A query `sort by` with more than one item now sorts by every item, in order, each with its own
  direction and null placement. The generated C# sorted by the first item only, so elements that tied on it kept
  their input order, and `First`, `Last` or an index into such a list could return a different element depending on
  the order of the data. Evaluation results can change for libraries that sort by more than one item; regenerate
  their C#. `GeneratorToolVersion` `6.4.0.0` → `6.4.1.0`. (#1978, #1979)
