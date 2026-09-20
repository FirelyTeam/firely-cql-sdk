## New Functionality

- **CQL translation:** `GeometricMean(List<Decimal>)` and `SplitOnMatches(String, String)` can now be
  called from CQL. Both were already implemented on `ICqlOperators`, but neither was registered in the
  system library, so translation failed to resolve the call. `SplitOnMatches` additionally needed its
  operands wired up in the ELM factory and the code builder, which previously left it with no arguments.

## Fixes

- **CQL evaluation:** `Count` returns `0` for a null source rather than `null`, as the Count operator in
  the CQL reference specifies.
- **CQL evaluation:** `Combine` returns `null` for an empty source list rather than the empty string, and
  ignores null elements in the source list. Ignoring nulls was previously only correct when no separator
  was supplied — `Combine({'a', 'b', 'c', null}, '-')` yielded `'a-b-c-'`.

**These two fixes move CQL evaluation results** for already-generated libraries, with no regeneration
needed, so the release cut should weigh them when picking the version level. `GeneratorToolVersion` is
unchanged: no existing library's generated C# differs, and the library shape the invocation toolkit binds
to is untouched.
