## Fixes

- **CQL-to-ELM translator:** a translation error whose message names the types of a call's arguments
  is reported as an error instead of being replaced by a `NullReferenceException`. Some expressions
  rejected during validation carry no result type: the visitor that rejected the expression returns
  the partially built node with the error attached and assigns none. That untyped node still reaches
  operator resolution, which fails in turn, and `MessageProvider` built the message describing that
  second failure by dereferencing each argument's `resultTypeSpecifier`, so the attempt to describe
  the failure threw and the caller lost both errors along with any others reported beside them. An
  unresolved type now renders as `(missing)`, the rendering `FunctionDef.ToString` already uses for
  an absent result type, so `Floor(FH)` after `include FHIRHelpers called FH` reports `Identifier FH
  is a library and cannot be used as an expression.` together with `Could not resolve call to
  operator Floor with signature ((missing)).` The same guard covers the ambiguous-call message, for
  both the call's arguments and each candidate's operands, and the `TypeSpecifier` overload of
  `CouldNotResolveFunction`, whose callers pass an expression's result type straight through.

  A message built entirely from resolved types is byte-for-byte unchanged. A library that reaches
  this never translated successfully, so no evaluation result moves, and no public API change and no
  `GeneratorToolVersion` change: `MessageProvider` is internal and the emitted C# is untouched. Why
  a result type is missing in the first place is unchanged and is separate work. (#1655)
