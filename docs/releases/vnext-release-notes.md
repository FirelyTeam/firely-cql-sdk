# vNext Release Notes

## Breaking Changes

## Features

- `Hl7.Cql.Fhir.FhirTypeConverter` now covers conversions that CQL-on-FHIR hosts previously had to
  implement themselves:
  - `CqlInterval<CqlTime>` → `Period`, anchoring the times on the minimum FHIR date (`0001-01-01`).
  - `CqlCode` → `Code`, alongside the existing `CqlCode` → `Coding`. The new
    `TypeConverter.ConvertCqlCodeToFhir(CqlCode?)` extension picks between the two: a bare `code`
    when only the code element is populated, a `Coding` otherwise.
  - `long` → `FhirString`, matching the CQL `Long` → FHIR `string` mapping in
    `CqlTypeToFhirTypeMapper` on R4.
  - `Code` → `CqlCode` and `Coding` → `CqlCode` for the inbound direction.
  - `TypeConverter.ConvertPeriodToCqlInterval(Period?, string?)` extension, which resolves the
    ambiguous `Period` mapping to `CqlInterval<CqlDate>` or `CqlInterval<CqlDateTime>` from a CQL
    point type name (typically read from the `cqf-cqlType` extension on a `Library` parameter).

## Fixes

- ISO 8601 timezone offsets are now signed as a whole rather than only on their hour component.
  `TimeIso8601` read an offset of `-05:30` as `-04:30` (`DateTimeIso8601` already handled this), and
  both types rendered an offset with a zero hour component without its sign (`00:30` instead of
  `+00:30`) and could not represent `-00:30` at all. Note that `TimeIso8601.OffsetMinute` is now
  negative for negative offsets, matching `DateTimeIso8601.OffsetMinute`.
