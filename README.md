[![Build Status](https://dev.azure.com/firely/firely-net-sdk/_apis/build/status%2FFirelyTeam.firely-cql-sdk?repoName=FirelyTeam%2Ffirely-cql-sdk&branchName=develop)](https://dev.azure.com/firely/firely-net-sdk/_build/latest?definitionId=143&repoName=FirelyTeam%2Ffirely-cql-sdk&branchName=develop)


## Introduction
This is NCQA's and Firely's official support SDK for working with [CQL][cql-spec] on the Microsoft .NET (dotnet) platform. It contains an engine for executing ELM,
and/or turning the contents of an ELM file into a .NET assembly so it can be called statically.

The engine has been tested by running it against the current NCQA HEDIS measures and CMS measures.
There is quite some variation in how CQL is written and interpreted, 
so it is likely at this early stage that there will be deviations from other engines currently available.

## Release Notes
This is release version 2.4.0 of the engine.

The releases notes 
at [firely-cql-sdk/releases](https://github.com/FirelyTeam/firely-cql-sdk/releases) for each major version will document these changes and (major) issues we have encountered.

1.* Releases will be maintained with hotfixes, but will not receive new features.

## Getting Started

* Read how to [get started with the Demo solution](docs/getting-started.md) included in the repository.
* There is a great presentation on the engine from [DevDays 2023](https://youtu.be/CkTbgfbttJc).
* [The CQL section](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html) in the .NET SDK documentation
* The [CQL Engine Architecture](docs/CQL-Engine-Architecture.md) document with background documentation on the design.
* The [Toolkit Services Dependency Diagrams](docs/dependency-diagrams.md) showing the internal dependencies of the CQL SDK toolkit services.


The presentation is a good place to start, but note that we have made some minor changes to the public surface, so the names of the classes in the presentation will differ from the examples in the Demo project itself.

## SDK Packages

This SDK consists of the following packages:

### Core Packages
- **Hl7.Cql**: The main package providing complete CQL engine functionality
- **Hl7.Cql.Abstractions**: Core interfaces and abstractions used throughout the SDK
- **Hl7.Cql.Runtime**: Runtime execution engine for CQL expressions
- **Hl7.Cql.Compiler**: ELM to .NET compilation
- **Hl7.Cql.Invocation**: High-level APIs for invoking CQL libraries and expressions

### Integration & Data Packages
- **Hl7.Cql.Firely**: FHIR integration layer
- **Hl7.Cql.Model**: Model definitions and metadata
- **Hl7.Cql.Packaging**: CQL packaging functionality

### Conversion & Code Generation
- **Hl7.Cql.CqlToElm**: CQL to ELM conversion (early development, not production-ready)
- **CodeGeneration.NET**: .NET code generation utilities
- **Elm**: ELM abstractions and utilities

### Support Packages
- **Hl7.Cql.Grammar**: CQL grammar definitions using ANTLR4
- **Iso8601**: ISO 8601 date/time handling

### Tools
- **PackagerCLI** (cql-package): Command-line tool for packaging CQL/ELM into FHIR resources and .NET assemblies

## External Dependencies

The SDK depends on the following key external packages:

### FHIR Support
- **Hl7.Fhir.Base**: Version 6.0.1 - Base classes and utilities for FHIR support
- **Hl7.Fhir.R4**: Firely SDK version - FHIR R4 POCOs and serialization support
- **Fhir.Metrics**: Version 1.3.0 - FHIR units and metrics support

### Parsing & Compilation
- **Antlr4.Runtime.Standard**: Version 4.13.1 - ANTLR4 runtime for CQL grammar parsing
- **Microsoft.CodeAnalysis.CSharp**: Version 4.12.0 - Roslyn C# compiler APIs

### Configuration & Logging
- **Microsoft.Extensions.Configuration**: Version 9.0.3 - Configuration framework
- **Microsoft.Extensions.DependencyInjection**: Version 8.0.0 - Dependency injection container
- **Microsoft.Extensions.Logging**: Version 8.0.0 - Logging abstractions
- **Microsoft.Extensions.Hosting**: Version 8.0.0 - Generic host for .NET applications

### Command-line Tool Dependencies
- **Serilog.Extensions.Logging**: Version 9.0.1 - Serilog integration with Microsoft.Extensions.Logging
- **Serilog.Sinks.File**: Version 7.0.0 - Serilog file logging sink
- **System.CommandLine**: Version 2.0.0-beta4.22272.1 - Command-line argument parsing

### Serialization
- **System.Text.Json**: Version 8.0.5 - High-performance JSON serialization

## Dev Start
During development, pre-releases will appear on Firely's GitHub Package feed. To use these packages you must add ```https://nuget.pkg.github.com/FirelyTeam/index.json``` to your NuGet sources:

 - Get a Personal Access token (PAT) from [github.com][github-pat] with scope ```read:packages```

- Next open a console on your machine and run ```dotnet nuget add source --name github --username <USERNAME> --password <PAT> https://nuget.pkg.github.com/FirelyTeam/index.json```

```USERNAME```: your username on GitHub
```PAT```: your Personal access token with at least the scope ```read:packages```

Further information can be found in [docs/getting-started.md](docs/getting-started.md).
## Support 
We actively monitor the issues coming in through the GitHub repository at [https://github.com/FirelyTeam/firely-cql-sdk/issues](https://github.com/FirelyTeam/firely-cql-sdk/issues). You are welcome to register your bugs and feature suggestions there. For questions and broader discussions, we use the [.NET FHIR Implementers chat][netsdk-zulip] and [CQL chat][cql-spec] on Zulip.

## Contributing
We are welcoming contributions!

If you want to participate in this project, we're using [Git Flow][nvie] for our branch management. Please submit PRs with changes against the `develop` branch.

Current 2.x development is done against the `develop` branch, while hotfixes are done under the `support/1.x` branch. Please refer to our [Git Branching and Workflow Guidelines](https://github.com/FirelyTeam/firely-cql-sdk/wiki/Git-Branching-and-Workflow-Guidelines) on the wiki for detailed guidelines on git branching and naming conventions.

[cql-spec]: https://cql.hl7.org/
[netsdk-zulip]: https://chat.fhir.org/#narrow/stream/dotnet
[cql-zulip]: https://chat.fhir.org/#narrow/stream/179220-cql
[nvie]: http://nvie.com/posts/a-successful-git-branching-model/
[github-pat]: https://github.com/settings/apps