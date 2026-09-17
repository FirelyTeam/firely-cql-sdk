## Fixes

- `Combine` ignores null elements of its source list and returns `null` when no non-null element remains, per the CQL specification, instead of emitting a separator for each null element. (#1622)

This changes CQL evaluation results for lists containing null elements, so the release that ships it needs a MESO bump.
