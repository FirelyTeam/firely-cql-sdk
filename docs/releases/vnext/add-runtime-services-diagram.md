## Documentation

- Added a `RuntimeServices` dependency diagram to [`docs/dependency-diagrams.md`](../../dependency-diagrams.md) showing the construction and dependency graph of the CQL runtime evaluation layer: `FhirCqlContext` / `FhirCqlContextOptions`, `CqlContext`, `CqlOperators`, `TypeConverter`, `CqlComparers`, `FhirTypeResolver`, `UnitConverter`, `IMetricService` / `DefaultUcumMetricService`, and the supporting interfaces (`IDataSource`, `IValueSetDictionary`, `IUnitConverter`, `IRetrieveProfileFilter`). Closes [#1436](https://github.com/FirelyTeam/firely-cql-sdk/issues/1436).
