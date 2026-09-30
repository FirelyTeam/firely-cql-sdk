# 1. CQL conformance test inputs

The XML files in this folder drive `XmlTest` in `CqlToElmTests`: every `<test>` is translated, evaluated and compared with its `<output>`.

## 1.1. Source

All files except the two listed in [1.2](#12-firelys-own-files) are unmodified copies of `tests/cql/*.xml` from the HL7 CQL conformance suite, [cqframework/cql-tests](https://github.com/cqframework/cql-tests), at commit `9e921932877bcf7a92e14a19c36a2b9cff077654`.

A test that does not hold for this SDK is listed in `../../(tests)/SkippedTests.cs` with the reason, not edited here. `XmlTest` runs only the tests that apply to the specification version the SDK implements (the `version` and `versionTo` attributes of the suite).

## 1.2. Firely's own files

- `CqlAgeTest.xml`: the `CalculateAge…At` operators.
- `FirelyAdditionsTest.xml`: cases the suite does not cover.

## 1.3. Refreshing

1. Copy `tests/cql/*.xml` from the cql-tests checkout over the files here, leaving the two files above in place.
2. Run `XmlTest` (`dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --filter FullyQualifiedName~XmlTest`).
3. For each failure, either fix the SDK or add the test to `SkippedTests.cs` with its reason; remove entries for tests the suite no longer has.
4. Update the commit hash in [1.1](#11-source).
