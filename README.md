
## Introduction ##
This is NCQA's and Firely's official support SDK for working with [CQL][cql-spec] on the Microsoft .NET (dotnet) platform.

## Release notes ##
Read the releases notes on [cql-sdk/releases](https://github.com/FirelyTeam/cql-sdk/releases). 

## Dev Start
During development we sometimes use Firely's Github Package feed, to be able to use pre-release packages within the cql solution. To use theses packages you must add ```https://nuget.pkg.github.com/FirelyTeam/index.json``` to your NuGet sources:

 - Get a Personal Access token (PAT) from [github.com][github-pat] with scope ```read:packages```

- Next open a console on your machine and run ```dotnet nuget add source --name github --username <USERNAME> --password <PAT> https://nuget.pkg.github.com/FirelyTeam/index.json --configfile .\NuGet.config```

```USERNAME```: your username on GitHub
```PAT```: your Personal access token with at least the scope ```read:packages```



## Support 
We actively monitor the issues coming in through the GitHub repository at [https://github.com/FirelyTeam/cql-sdk/issues](https://github.com/FirelyTeam/cql-sdk/issues). You are welcome to register your bugs and feature suggestions there. For questions and broader discussions, we use the [.NET FHIR Implementers chat][netsdk-zulip] and [CQL chat][cql-spec] on Zulip.

## Contributing ##
We are welcoming contributions!

If you want to participate in this project, we're using [Git Flow][nvie] for our branch management. Please submit PRs with changes against the `develop` branche.


[cql-spec]: https://cql.hl7.org/
[netsdk-zulip]: https://chat.fhir.org/#narrow/stream/dotnet
[cql-zulip]: https://chat.fhir.org/#narrow/stream/179220-cql
[github-pat]: https://github.com/settings/apps
