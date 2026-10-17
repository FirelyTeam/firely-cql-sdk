# 3. Project Structure

Parent document: [../copilot-instructions.md](../copilot-instructions.md)

## 3.0. Table of Contents

- [3. Project Structure](#3-project-structure)
- [3.0. Table of Contents](#30-table-of-contents)
- [3.1. SDK Projects](#31-sdk-projects)
- [3.2. Where an operator lives](#32-where-an-operator-lives)
- [3.3. Test projects](#33-test-projects)
- [3.4. Everything else](#34-everything-else)

Read this before searching the repository. Build `Cql-Sdk.slnf`; SDK and test projects target `net8.0;net10.0` (set in `cql-sdk.props`), so run tests on both.

## 3.1. SDK Projects

3.1.1 The SDK projects live under `Cql/`. In pipeline order, with the assembly name in parentheses where it differs from the folder name:

| Project | Role | Start at |
|---|---|---|
| `Cql.Grammar` (`Hl7.Cql.CqlToElm.Grammar`) | ANTLR grammar `cql.g4` and its generated parser | `cqlParser.cs` |
| `Cql.CqlToElm` | CQL text to ELM: visitors, overload resolution, system library, translation messages | `Visitors/ExpressionVisitor.cs`, `InvocationBuilder.cs`, `Builtin/SystemLibrary.cs`, `MessageProvider.cs` |
| `Elm` | ELM object model (generated from the XSD) and its JSON/XML serialization | `Elm.g.cs`, `Library.cs` |
| `Cql.Model` | Model info (FHIR and System types) and `ModelTypeResolver` | `Models/`, `ModelTypeResolver.cs` |
| `Cql.Compiler` | ELM to a typed intermediate representation; binds each ELM node to an `ICqlOperators` method | `CodeBuilder.cs`, `CqlOperatorsBinder.*.cs`, `CodeModel/`, `Preprocessing/` |
| `CodeGeneration.NET` | Prints the IR as C# and compiles it; holds `GeneratorToolVersion` | `LibrarySetCSharpCodeGenerator.*.cs`, `CSharpEmitter.*.cs`, `AssemblyCompiler.cs`, `_CODE GENERATOR VERSION_.cs` |
| `Cql.Invocation` | Loads generated assemblies and invokes definitions; one `LibraryInvoker.<major>.<minor>.cs` per supported generator version | `Toolkit/InvocationToolkit.cs`, `Toolkit/LibrarySetInvoker.cs`, `Toolkit/Internal/` |
| `Cql.Runtime` | Everything generated code calls at run time: `ICqlOperators` and its `CqlOperators` implementation, `CqlContext`, comparers, type and unit conversion, value sets | `Operators/`, `Runtime/CqlContext.cs`, `Comparers/`, `Conversion/`, `ValueSets/` |
| `Cql.Abstractions` (`HL7.Cql.Abstractions`) | CQL primitive types, `CqlException<TError>` and the `ICqlError` structs, `ReflectionUtility`, definition attributes | `Primitives/`, `Exceptions/`, `Abstractions/Infrastructure/` (see [its CLAUDE.md](../../Cql/Cql.Abstractions/CLAUDE.md)) |
| `Iso8601` | `DateIso8601`, `DateTimeIso8601`, `TimeIso8601` and `DateTimePrecision`, the values inside `CqlDate`, `CqlDateTime` and `CqlTime` | the three `*Iso8601.cs` files |
| `Cql.Firely` (`Hl7.Cql.Fhir`) | FHIR bindings on the Firely .NET SDK: `FhirCqlContext`, `FhirTypeConverter`, `FhirTypeResolver`, `BundleDataSource` | the files of those names |
| `Cql.Packaging`, `PackagerCLI` (`Hl7.Cql.Packager`) | Packaging CQL/ELM/assemblies into FHIR `Library` resources; the `dotnet` tool that drives it | `ResourcePackager.cs`; `PackagerCLI/Commands.*` |
| `Cql` (`Hl7.Cql`) | Meta-package, no code | |

## 3.2. Where an operator lives

3.2.1 `ICqlOperators` is one interface in `Cql/Cql.Runtime/Operators/ICqlOperators.cs`. Its implementation is split over `CqlOperators.<Family>.cs` in the same folder: `ArithmeticOperators`, `AggregateFunctions`, `ComparisonOperators`, `DateTimeOperators`, `EqualityAndEquivalence`, `IntervalOperators` plus `IntervalBoundaries`, `ListOperators`, `LogicalOperators`, `NullologicalOperators`, `StringOperators`, `TypeOperators` (conversions, `ConvertQuantity`), `ClinicalOperators2` (age, codes, value sets), `FusedOperators` and `CrossJoin` (query fusion).

3.2.2 Date, time and quantity arithmetic itself is on the primitives (`CqlDate.Add`, `CqlQuantity`, in `Cql/Cql.Abstractions/Primitives/`).

3.2.3 Unit conversion is `UnitConverter` and `UcumConversionExtensions` in `Cql/Cql.Runtime/Conversion/`.

3.2.4 Overload resolution at translation time is `InvocationBuilder` in `Cql/Cql.CqlToElm/`.

## 3.3. Test projects

3.3.1 `Cql-Sdk.slnf` builds two test projects, both MSTest, under `Cql/`: `CoreTests` and `CqlToElmTests`. Other suites live beside what they test (`tools/XsdToCSharpConverterTests`, `Demo/Test.Measures.Demo`).

3.3.2 `CoreTests`: unit tests for runtime, compiler, primitives and FHIR binding, one file per concern (`CqlDateTests.cs`, `AggregateOperatorTests.cs`, …). `CSharp/*.g.cs` are golden files checked by `CSharpGenerationGoldenTests`; `Input/ELM/` holds the ELM they are generated from.

3.3.3 `CqlToElmTests`: translator tests, one `(tests)/<Operator>Test.cs` per operator. `(tests)/XmlTest.cs` is the CQL conformance suite: it translates, evaluates and checks every case in `Input/DQIC/*.xml`. Those files are unmodified copies of cqframework/cql-tests and are never edited, except `CqlAgeTest.xml` and `FirelyAdditionsTest.xml`, which are Firely's own and where SDK-only cases go (see the [README](../../Cql/CqlToElmTests/Input/DQIC/README.md) there). A case that does not hold for this SDK is listed with its reason in `(tests)/SkippedTests.cs` (`DoesNotCompile`, `DoesNotMatchExpectation`).

3.3.4 `Benchmarks`: BenchmarkDotNet micro-benchmarks.

## 3.4. Everything else

3.4.1 `Demo/` is the measure pipeline (CQL to ELM to C# to FHIR), described in [docs/demo-projects.md](../../docs/demo-projects.md).

3.4.2 `submodules/Firely.Cql.Sdk.Integration.Runner` is the private MADiE integration suite.

3.4.3 `spec/` is the CQL and FHIR specification mirror, see [08-cql-specification-conformance.md](08-cql-specification-conformance.md).

3.4.4 `tools/` holds the spec condenser, the XSD-to-C# converter and the Mermaid renderer; `build/` holds the Azure pipeline.

3.4.5 `docs/` holds the design documents, starting with [docs/cql-engine-architecture.md](../../docs/cql-engine-architecture.md).

3.4.6 `Examples/CqlSdkExamples/` holds public examples using stable APIs; `Examples/CqlSdkExamplesPreview/` holds preview examples with access to internal or experimental APIs.
