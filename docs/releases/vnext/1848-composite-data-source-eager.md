## Improvements

- **Runtime** — `CompositeDataSource.Retrieve` returns a fully evaluated list, as `BundleDataSource.Retrieve` does. Each
  source's retrieve is called once per retrieve, and reading the result again, as a cached definition or a cross join
  does, no longer calls the sources again. A failure in a source surfaces from the retrieve itself, in the definition
  that retrieves. A source that returns its results lazily is now read in full on each retrieve. (#1847, #1848)
