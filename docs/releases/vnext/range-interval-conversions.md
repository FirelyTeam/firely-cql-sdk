## Features

- `FhirTypeConverter` converts a FHIR `Range` to an `Interval<Long>`, closing the round trip for intervals of `Long`,
  which the engine already serializes out to a unit-less `Range`. Bounds are read from the `Quantity` values, are
  inclusive (as FHIR `Range` bounds always are), and a fractional value is truncated towards zero - the same semantics
  as the `Interval<Integer>` reading. A single FHIR `Quantity` can be read as a CQL `Long` for the same reason. (#1454)
- Added `Hl7.Cql.Fhir.FhirTypeConverter.ConvertRangeToCqlInterval(this TypeConverter, Range?, string?)`, which picks the
  CQL interval type for a FHIR `Range` from a CQL point type name (typically taken from the cqf-cqlType extension on a
  Library parameter): `Integer`, `Decimal` and `Long` yield an interval of that type, anything else - including an
  absent hint - the widest reading, an `Interval<Quantity>`. It is the `Range` counterpart of
  `ConvertPeriodToCqlInterval`, so hosts no longer need to hand-roll this dispatch. (#1454)
