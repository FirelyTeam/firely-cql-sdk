[![Build Status](https://dev.azure.com/firely/firely-net-sdk/_apis/build/status%2FFirelyTeam.firely-cql-sdk?repoName=FirelyTeam%2Ffirely-cql-sdk&branchName=develop)](https://dev.azure.com/firely/firely-net-sdk/_build/latest?definitionId=143&repoName=FirelyTeam%2Ffirely-cql-sdk&branchName=develop)


## Introduction ##
This is NCQA's and Firely's official support SDK for working with [CQL][cql-spec] on the Microsoft .NET (dotnet) platform. It contains an engine for executing ELM,
and/or turning the contents of an ELM file into a .NET assembly so it can be called statically.

## Release notes ##
This is release version 2.0 of the engine.
We expect parts of the public interface can to change. 
The engine has been tested by running it against the current NCQA HEDIS measures and CMS measures.
There is quite some variation in how CQL is written and interpreted, 
so it is likely at this early stage that there will be deviations from other engines currently available.

The releases notes 
at [firely-cql-sdk/releases](https://github.com/FirelyTeam/firely-cql-sdk/releases) for each major version will document these changes and (major) issues we have encountered.


## Getting Started ##

* Read how to [get started with the Demo solution](docs/getting-started.md) included in the repository.
* There is a great presentation on the engine from [DevDays 2023](https://youtu.be/CkTbgfbttJc).
* [The CQL section](https://docs.fire.ly/projects/Firely-NET-SDK/en/latest/cql.html) in the .NET SDK documentation
* The [CQL Engine Architecture](docs/CQL-Engine-Architecture.md) document with background documentation on the design.
* The [Toolkit Services Dependency Diagrams](docs/dependency-diagrams.md) showing the internal dependencies of the CQL SDK toolkit services.


The presentation is a good place to start, but note that we have made some minor changes to the public surface, so the names of the classes in the presentation will differ from the examples in the Demo project itself.

## Dependencies ##

The SDK has dependencies on the following key external packages:

### Cql.Firely
- **Hl7.Fhir.Base**: Version 5.12.0 - Base classes and utilities for FHIR support
- **Hl7.Fhir.R4**: Firely SDK version - FHIR R4 POCOs and serialization support

## Dev Start
During development, pre-releases will appear on Firely's GitHub Package feed. To use these packages you must add ```https://nuget.pkg.github.com/FirelyTeam/index.json``` to your NuGet sources:

 - Get a Personal Access token (PAT) from [github.com][github-pat] with scope ```read:packages```

- Next open a console on your machine and run ```dotnet nuget add source --name github --username <USERNAME> --password <PAT> https://nuget.pkg.github.com/FirelyTeam/index.json```

```USERNAME```: your username on GitHub
```PAT```: your Personal access token with at least the scope ```read:packages```

Further information can be found in [docs/getting-started.md](docs/getting-started.md).
## Support 
We actively monitor the issues coming in through the GitHub repository at [https://github.com/FirelyTeam/firely-cql-sdk/issues](https://github.com/FirelyTeam/firely-cql-sdk/issues). You are welcome to register your bugs and feature suggestions there. For questions and broader discussions, we use the [.NET FHIR Implementers chat][netsdk-zulip] and [CQL chat][cql-spec] on Zulip.

## Contributing ##
We are welcoming contributions!

If you want to participate in this project, we're using [Git Flow][nvie] for our branch management. Please submit PRs with changes against the `develop` branch.

[cql-spec]: https://cql.hl7.org/
[netsdk-zulip]: https://chat.fhir.org/#narrow/stream/dotnet
[cql-zulip]: https://chat.fhir.org/#narrow/stream/179220-cql
[nvie]: http://nvie.com/posts/a-successful-git-branching-model/
[github-pat]: https://github.com/settings/apps