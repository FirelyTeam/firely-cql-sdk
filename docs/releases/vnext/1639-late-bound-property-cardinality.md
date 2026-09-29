## Fixes

- **Late-bound property access keeps list cardinality.** A `union` of different resource types is a CQL
  choice type, which the generator erases to `object`, so a property of such a source can only be
  late-bound. The late-bound read carried the property's value but not its cardinality: a list-valued
  element was emitted as a scalar, wrapped in a one-element array and cast to the element type, which
  yields `null`. Filters over such an element therefore evaluated against `null` instead of the element's
  actual codes and produced wrong results, in both directions, without signalling an error. The path is now
  resolved against the choice's member types and, when they agree it is list-valued, read as a list, so the
  emitted code takes the same shape as when the source type is known. Scalar late-bound paths are
  unaffected. (#1639)

  **This changes CQL evaluation results.** In the `dqm-content-qicore-2025` corpus,
  `CMS69FHIRPCSBMIScreenAndFollowUp` is the only measure whose generated C# changes, and three of its
  integration cases go from a wrong Numerator to the expected one.

- The compile-time warning raised at both late-binding sites described only a performance cost. It now also
  states that the property's type and cardinality go unchecked. (#1639)

## Other

- `LibrarySetCSharpCodeGenerator.GeneratorToolVersion` moves `5.2.1.0` → `5.2.2.0`. The generated API is
  unchanged, so the existing `LibraryInstanceInvoker_5_0` still applies; only the C# emitted for a
  late-bound list-valued property differs. (#1639)
