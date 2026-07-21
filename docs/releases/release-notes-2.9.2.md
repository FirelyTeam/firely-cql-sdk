## Firely CQL SDK 2.9.2

### tl;dr

> **Upgrading?** Here is the short version:
>
> - **Breaking changes:** None.
> - **Required migrations:** None.
> - **Highlights:** Upgraded the Demo build pipeline's CQL-to-ELM tooling to the new Kotlin-based translator release, and bumped the Firely .NET SDK dependency to 6.3.0. No CQL-observable behavior changes.

---

### CQL SDK

#### New Public API

- None.

#### Improvements

- None.

#### Dependency Updates

- Bumped the Firely .NET SDK (`Hl7.Fhir.Base`/`Hl7.Fhir.R4`) dependency from 6.2.1 to 6.3.0 (#1336).

#### Potentially Breaking

- None.

---

### CQL Packager

#### Breaking

- None.

#### Improvements

- None.

---

### Demo Projects and Build Tooling

#### Breaking

- None.

#### Improvements

- Upgraded the Maven-fetched CQL-to-ELM tooling used by the Demo build pipeline (`Demo/Cql/Build/pom.xml`, `Java-Dependencies-Vars.ps1`/`.sh`, `Hl7.Cql.Packager.Program.JavaToolVersion`) from `info.cqframework:cql-to-elm-cli`/`elm-fhir` `3.29.0` to `org.cqframework:cql-to-elm-cli`/`elm-fhir` `4.0.0`. The Maven groupId changed because upstream ([cqframework/clinical_quality_language](https://github.com/cqframework/clinical_quality_language)) rewrote its CQL-to-ELM translator from Java to Kotlin internally and renamed the groupId as part of that migration; the CLI is still a JVM application invoked the same way (`java -classpath ...`), so this is a version/groupId bump only. The generated ELM output is unchanged: regenerating every checked-in ELM fixture in this repo with the new tooling and diffing against the pre-upgrade output showed no differences beyond the `translatorVersion` annotation field and a couple of inconsequential JSON key reorderings. `CqlTooling.Targets.xml` also gained a small inline MSBuild task to re-indent the ELM JSON the new tooling produces, since the Kotlin-based CLI only emits compact (non-indented) JSON with no pretty-print option (#1333, #1335).

---

### Upgrade Checklist

- No action required. This release is fully backward compatible with 2.9.1.

---

### Pull Requests

| PR                                                              | Title                                                                    |
| ---------------------------------------------------------------- | --------------------------------------------------------------------- |
| [#1335](https://github.com/FirelyTeam/firely-cql-sdk/pull/1335) | Upgrade cql-to-elm tooling: Java 3.29.0 -> Kotlin-based org.cqframework 4.0.0 |
| [#1336](https://github.com/FirelyTeam/firely-cql-sdk/pull/1336) | Update Firely .NET SDK to 6.3.0                                        |
| [#1338](https://github.com/FirelyTeam/firely-cql-sdk/pull/1338) | Set next release version to 2.9.2 (#1337)                              |
