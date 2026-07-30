## Breaking Changes

- FHIR serialization of `Interval<Integer>` and `Interval<Decimal>` results changed, per [FHIR-56226](https://jira.hl7.org/browse/FHIR-56226): every `Range` bound now carries the [`quantity-precision`](http://hl7.org/fhir/StructureDefinition/quantity-precision) extension (`valueInteger` = number of digits after the decimal point), and because FHIR `Range` bounds are always inclusive, an open endpoint is now emitted as its closed equivalent instead of as-is (successor/predecessor at the engine's minimum precision, so `Interval[1.0, 4.0)` becomes `[1.0, 3.99999999]`). Consumers comparing exact `Range` output need to account for both (#1402).

## Features

- `Interval<Long>` results now map to a FHIR `Range` of unit-less Quantities (UCUM `1`), per [FHIR-56226](https://jira.hl7.org/browse/FHIR-56226). Previously `CqlTypeToFhirTypeMapper` had no mapping for an interval with a `Long` point type and no `CqlInterval<long?>` → `Range` conversion was registered, so such results could not be serialized at all (#1402).
