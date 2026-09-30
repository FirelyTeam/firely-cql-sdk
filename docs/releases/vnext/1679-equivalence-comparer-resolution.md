## Fixes

- Equivalence (`~`) resolves the comparer for its operands the same way equality (`=`) does, including through a base type's registration. It no longer throws `ArgumentException` for a value whose type has a comparer only through its base type, such as a FHIR resource subclass defined outside the FHIR model assembly when resources are compared by id. (#1679)

This changes CQL evaluation results for the affected expressions.
