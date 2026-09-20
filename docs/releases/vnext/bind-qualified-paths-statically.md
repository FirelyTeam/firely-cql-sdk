## Fixes

- **Qualified (dotted) property paths are bound at compile time.** A scoped ELM `Property` whose
  `path` is qualified (`M.id.value`, `MR.medication.reference.value`) was emitted as a single
  `LateBoundProperty` call carrying the whole dotted string, even when the alias is strongly typed.
  The compiler now walks the path one segment at a time: every segment known on the static type is
  bound as a typed member access (`M?.IdElement?.Value`), and from the first segment that is not
  (an element of a choice type, such as `MR.medication`) the remainder is late-bound one segment per
  call. No emitted `LateBoundProperty` call carries a dotted name any more. The source-based form of
  `Property` walked qualified paths already, but silently skipped a segment it could not resolve and
  returned the partially walked value; it now late-binds the remainder the same way. The type
  inferred for such a property follows the same walk, so consumers of the value are typed
  (`string` instead of `object`) where every segment is known.

  **This changes generated C#**: `GeneratorToolVersion` moves to `5.2.3.0` (patch: the generated
  API is unchanged) and every checked-in `*.g.cs` with a qualified late-bound path is regenerated.
  For the scoped form, evaluation results do not change relative to a runtime that already walks
  qualified paths in `LateBoundProperty`. **The source-based form changes evaluation results**: it
  previously returned the partially walked value for a path it could not fully bind (for
  `E.value.value` on an `Extension`, the `Code` element instead of its string value), so comparisons
  against such a path silently failed and now match. Per [versioning.md](../../versioning.md) this
  forces a **MESO** bump. (#1644)
