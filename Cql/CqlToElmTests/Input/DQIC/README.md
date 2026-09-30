# 1. CQL conformance test inputs

The XML files in this folder drive `XmlTest` in `CqlToElmTests`. It runs every `<test>` that has an `<expression>` without an `invalid` attribute and applies to the specification version the SDK implements (the `version` and `versionTo` attributes of the suite, group or test): the expression is translated, evaluated and compared with its `<output>`. Tests that expect an error, tests that provide a `<library>` instead of an expression, and tests for other specification versions are not run.

## 1.1. Source

All files except the two listed in [1.2](#12-firelys-own-files) are unmodified copies of `tests/cql/*.xml` from the HL7 CQL conformance suite, [cqframework/cql-tests](https://github.com/cqframework/cql-tests), at commit `9e921932877bcf7a92e14a19c36a2b9cff077654`.

A test that does not hold for this SDK is listed in `../../(tests)/SkippedTests.cs` with the reason, not edited here.

## 1.2. Firely's own files

- `CqlAgeTest.xml`: the `CalculateAge…At` operators.
- `FirelyAdditionsTest.xml`: cases the suite does not cover.

## 1.3. Schema

`../../testSchema.xsd` is an unmodified copy of `tests/testSchema.xsd` from the same cql-tests commit, kept as the reference for the suite's file format. `../../testSchema.cs` is a hand-maintained model of the part of that schema `XmlTest` reads: the `version` and `versionTo` attributes of suites, groups and tests, their names, the expression with its `invalid` attribute, and the outputs. The serializer ignores everything else the schema defines, so the model is extended only when `XmlTest` needs more of the schema.

## 1.4. Refreshing

1. Copy `tests/cql/*.xml` from the cql-tests checkout over the files here, leaving the two files above in place, and `tests/testSchema.xsd` over `../../testSchema.xsd`; extend `../../testSchema.cs` if `XmlTest` needs something the schema added (see [1.3](#13-schema)).
2. Run `XmlTest` (`dotnet test Cql/CqlToElmTests/CqlToElmTests.csproj --filter FullyQualifiedName~XmlTest`).
3. For each failure, either fix the SDK or add the test to `SkippedTests.cs` with its reason; remove entries for tests the suite no longer has.
4. Update the commit hash in [1.1](#11-source).
