# Solutions and Projects Overview

This document provides a comprehensive overview of all solutions in the Firely CQL SDK repository and the projects they contain, along with their target framework(s).

## Solutions Summary

The repository contains the following solution files:

1. **Cql-Sdk-All.sln** - Complete solution including all projects (requires submodule access)
2. **Cql-Sdk.slnf** - Solution filter for core SDK projects (recommended for building)
3. **Cql-Sdk-Demos-Examples.slnf** - Solution filter including SDK, demos, and examples
4. **IntegrationRunner.slnf** - Integration test runner (submodule)
5. **IntegrationRunner-All.sln** - Complete integration runner solution (submodule)

## All Projects by Solution

| Solution | Project Name | Project Path | Target Framework(s) | Type |
|----------|-------------|--------------|---------------------|------|
| **Cql-Sdk.slnf** | CodeGeneration.NET | Cql/CodeGeneration.NET/CodeGeneration.NET.csproj | net8.0;net10.0 | Library |
| | CoreTests | Cql/CoreTests/CoreTests.csproj | net8.0;net10.0 | Test |
| | Cql.Abstractions | Cql/Cql.Abstractions/Cql.Abstractions.csproj | net8.0;net10.0 | Library |
| | Cql.Compiler | Cql/Cql.Compiler/Cql.Compiler.csproj | net8.0;net10.0 | Library |
| | Cql.CqlToElm | Cql/Cql.CqlToElm/Cql.CqlToElm.csproj | net8.0;net10.0 | Library |
| | Cql.Firely | Cql/Cql.Firely/Cql.Firely.csproj | net8.0;net10.0 | Library |
| | Cql.Grammar | Cql/Cql.Grammar/Cql.Grammar.csproj | net8.0;net10.0 | Library |
| | Cql.Invocation | Cql/Cql.Invocation/Cql.Invocation.csproj | net8.0;net10.0 | Library |
| | Cql.Model | Cql/Cql.Model/Cql.Model.csproj | net8.0;net10.0 | Library |
| | Cql.Packaging | Cql/Cql.Packaging/Cql.Packaging.csproj | net8.0;net10.0 | Library |
| | Cql.Runtime | Cql/Cql.Runtime/Cql.Runtime.csproj | net8.0;net10.0 | Library |
| | CqlToElmTests | Cql/CqlToElmTests/CqlToElmTests.csproj | net8.0;net10.0 | Test |
| | Cql | Cql/Cql/Cql.csproj | net8.0;net10.0 | Library |
| | Elm | Cql/Elm/Elm.csproj | net8.0;net10.0 | Library |
| | Iso8601 | Cql/Iso8601/Iso8601.csproj | net8.0;net10.0 | Library |
| | PackagerCLI | Cql/PackagerCLI/PackagerCLI.csproj | net8.0;net10.0 | Executable |
| **Cql-Sdk-Demos-Examples.slnf** | *(includes all Cql-Sdk.slnf projects above, plus:)* | | | |
| | Benchmarks | Cql/Benchmarks/Benchmarks.csproj | net10.0 | Executable |
| | CLI | Demo/CLI/CLI.csproj | net10.0 | Executable |
| | Cql (Demo) | Demo/Cql/Cql.csproj | net10.0 | Library |
| | Measures.Authoring | Demo/Measures.Authoring/Measures.Authoring.csproj | net10.0 | Library |
| | Measures.Demo | Demo/Measures.Demo/Measures.Demo.csproj | net10.0 | Library |
| | Measures.ecqm-content-cms-2025 | Demo/Measures.ecqm-content-cms-2025/Measures.ecqm-content-cms-2025.csproj | net10.0 | Library |
| | Measures.ecqm-content-qicore-2024 | Demo/Measures.ecqm-content-qicore-2024/Measures.ecqm-content-qicore-2024.csproj | net10.0 | Library |
| | Measures.ecqm-content-qicore-2025 | Demo/Measures.ecqm-content-qicore-2025/Measures.ecqm-content-qicore-2025.csproj | net10.0 | Library |
| | Test.Measures.Demo | Demo/Test.Measures.Demo/Test.Measures.Demo.csproj | net10.0 | Test |
| | CqlSdkExamplesPreview | Examples/CqlSdkExamplesPreview/CqlSdkExamplesPreview.csproj | net8.0;net10.0 | Executable |
| | CqlSdkExamples | Examples/CqlSdkExamples/CqlSdkExamples.csproj | net8.0;net10.0 | Executable |
| **IntegrationRunner.slnf** | IntegrationRunner | submodules/Firely.Cql.Sdk.Integration.Runner/IntegrationRunner/IntegrationRunner.csproj | net10.0 | Test |
| | CodeGen | submodules/Firely.Cql.Sdk.Integration.Runner/CodeGen/CodeGen.csproj | net10.0 | Executable |
| **Cql-Sdk-All.sln** | *(includes all above projects, plus NCQA submodule projects:)* | | | |
| | BuildArtifacts | submodules/Ncqa.DQIC/BuildArtifacts/BuildArtifacts.csproj | net10.0 | Library |
| | Ncqa.HT.DeckTests | submodules/Ncqa.DQIC/Ncqa.HT.DeckTests/Ncqa.HT.DeckTests.csproj | net10.0 | Test |
| | Ncqa.HT.Infrastructure | submodules/Ncqa.DQIC/Ncqa.HT.Infrastructure/Ncqa.HT.Infrastructure.csproj | net10.0 | Library |
| | Ncqa.HT.MeasuresTests | submodules/Ncqa.DQIC/Ncqa.HT.MeasuresTests/Ncqa.HT.MeasuresTests.csproj | net10.0 | Test |
| **Tools** (not in solution filters) | XsdToCSharpConverter | tools/XsdToCSharpConverter/XsdToCSharpConverter.csproj | net10.0 | Executable |
| | XsdToCSharpConverterTests | tools/XsdToCSharpConverterTests/XsdToCSharpConverterTests.csproj | net10.0 | Test |

## Framework Target Summary

### Multi-Targeting (net8.0;net10.0)
The following projects target both .NET 8 and .NET 10:
- All core SDK library projects (Cql.Abstractions, Cql.Runtime, Cql.Invocation, etc.)
- Core test projects (CoreTests, CqlToElmTests)
- Example projects (CqlSdkExamples, CqlSdkExamplesPreview)
- PackagerCLI executable

### .NET 10 Only
The following projects target .NET 10 only:
- All Demo projects (CLI, Measures.*, etc.)
- Benchmarks
- Tools (XsdToCSharpConverter, XsdToCSharpConverterTests)
- Integration test projects (IntegrationRunner, CodeGen)
- NCQA submodule projects (BuildArtifacts, Ncqa.HT.*)

## Build Recommendations

1. **For SDK development**: Use `Cql-Sdk.slnf` - includes core SDK projects only
2. **For demos and examples**: Use `Cql-Sdk-Demos-Examples.slnf` - includes SDK + demos + examples
3. **For integration testing**: Use `IntegrationRunner.slnf` in the submodules/Firely.Cql.Sdk.Integration.Runner directory
4. **Complete build**: Use `Cql-Sdk-All.sln` (requires submodule access)

## Notes

- **Submodules**: The complete solution includes git submodules that may require separate access
- **Build Command**: Always use `dotnet build Cql-Sdk.slnf` for SDK-only builds
- **Multi-targeting**: Projects targeting both frameworks allow the SDK to be used in both .NET 8 and .NET 10 applications
- **Demo Projects**: Demo projects are .NET 10-only to showcase the latest features
