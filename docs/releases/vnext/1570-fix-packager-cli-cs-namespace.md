## Breaking

- Fixed Packager CLI `--cs-namespace` binding for both `cql` and `elm` commands. The option now correctly populates `Elm:CSharp:Namespace`, so generated `*.g.cs` files are wrapped in the requested namespace. Users already passing `--cs-namespace` will see generated type identities change from global-namespace types to namespaced types. (#1569)
