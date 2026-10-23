# 1. Model infos for translator tests

These are unmodified copies of the QICore and US Core model info files shipped in the `quick` jar of the Java CQL-to-ELM tooling, at the version pinned in [`Demo/Cql/Build/pom.xml`](../../../../Demo/Cql/Build/pom.xml):

| File | Model |
|---|---|
| `qicore-modelinfo-4.1.1.xml` | QICore 4.1.1 |
| `uscore-modelinfo-3.1.1.xml` | US Core 3.1.1, required by QICore 4.1.1 |
| `qicore-modelinfo-6.0.0.xml` | QICore 6.0.0 |
| `uscore-modelinfo-6.1.0.xml` | US Core 6.1.0, required by QICore 6.0.0 |

The [translator census](../Census/README.md) supplies them to the translator for the corpora written against QICore. They are test inputs only; [#1740](https://github.com/FirelyTeam/firely-cql-sdk/issues/1740) moves them into `Cql.Model`.
