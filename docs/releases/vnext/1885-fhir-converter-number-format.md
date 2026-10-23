## Potentially Breaking

- **Runtime (`Hl7.Cql.Fhir`)** — `FhirTypeConverter` converts a string to an Integer, Long or Decimal only in the format
  that `ToInteger`, `ToLong` and `ToDecimal` accept, `(+|-)?#0` and `(+|-)?#0(.0#)?`, and gives null for any other
  string, as those operators do. It parsed with .NET's `NumberStyles.Integer` and `NumberStyles.Number` under the
  invariant culture, so it accepted whitespace around the number (`Convert<int?>(" 1 ")` gave `1`), group separators
  (`Convert<decimal?>("1,000.25")` gave `1000.25`, and `Convert<decimal?>("12,34")` gave `1234`), a trailing sign
  (`"1.5-"`), a decimal point without a digit on both sides (`".5"`, `"1."`) and trailing NUL characters. Each of these
  now gives null. A FHIR primitive such as an `Integer`, `FhirDecimal` or `Quantity` converts from the value it holds,
  as before, so FHIR data is unaffected. (#1868, #1885)
  - **Who sees a difference:** a host that converts its own strings to numbers through `FhirTypeConverter.Default`, a
    converter from `FhirTypeConverter.Create`, or `ICqlOperators.Convert<T>`. The signatures are unchanged, so nothing
    fails to compile or load, but a string in one of the forms above gives null where it gave a number.
  - **What to do:** hand these conversions numbers in the CQL format: trim surrounding whitespace and leave out group
    separators. Parse a number written for a particular culture, such as `12,34`, in the host before handing it over.

## Fixes

- **Runtime (`Hl7.Cql.Fhir`)** — `FhirTypeConverter` converts a date-time string to a Date as `ToDate` does, ignoring
  the time portion: `Convert<CqlDate>("2014-01-01T12:30:00")` is `2014-01-01` instead of null. A time portion with a
  component out of range still gives null. (#1868, #1885)

This does not change CQL evaluation results: a CQL expression converts a String with the `To*` operators themselves,
never through the converter. Generated C# and `GeneratorToolVersion` are unchanged.
