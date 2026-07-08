# vNext Release Notes

## Breaking Changes

## Features

- Upgraded the Maven-fetched CQL-to-ELM tooling used by the Demo build pipeline (`Demo/Cql/Build/pom.xml`, `Java-Dependencies-Vars.ps1`/`.sh`, `Hl7.Cql.Packager.Program.JavaToolVersion`) from `info.cqframework:cql-to-elm-cli`/`elm-fhir` `3.29.0` to `org.cqframework:cql-to-elm-cli`/`elm-fhir` `4.0.0`. The Maven groupId changed because upstream ([cqframework/clinical_quality_language](https://github.com/cqframework/clinical_quality_language)) rewrote its CQL-to-ELM translator from Java to Kotlin (Kotlin Multiplatform) internally and renamed the groupId as part of that migration; the CLI is still a JVM application invoked the same way (`java -classpath ...`), so this is a version/groupId bump only, not a change to how we invoke it. **The generated ELM output is unchanged**: regenerating every checked-in ELM fixture in this repo with the new tooling and diffing against the pre-upgrade output showed no differences beyond the `translatorVersion` annotation field and a couple of inconsequential JSON key reorderings. `CqlTooling.Targets.xml` also gained a small inline MSBuild task to re-indent the ELM JSON the new tooling produces, since the Kotlin-based CLI only emits compact (non-indented) JSON with no pretty-print option.

## Fixes

- Bumped the Firely .NET SDK (`Hl7.Fhir.Base`/`Hl7.Fhir.R4`) dependency from 6.2.1 to 6.3.0.
