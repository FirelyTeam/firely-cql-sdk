## Fixes

- `ValueSetSource` no longer writes into the valueset handed to `Add` or resolved by `Load`: a
  valueset that arrives without an expansion is expanded on a private copy, so that instance — which
  a host cache may be serving to every consumer in the process — is left untouched, on success and
  on failure alike. Previously the computed expansion was written into the caller's instance (and a
  failed expansion cleared it), corrupting host-side conformance caches that share instances. Note
  that the underlying `ValueSetExpander` still expands an expansion-less *included* valueset
  (`compose.include`) from the resolver in place — that is the expander's own behavior, tracked at
  [firely-net-sdk#3582](https://github.com/FirelyTeam/firely-net-sdk/issues/3582). A source still
  expands a given canonical at most once through its per-canonical facade layer; hosts that want
  cross-source reuse of computed expansions can serve valuesets with static expansions or seed
  sources via `Add(string, IEnumerable<CqlCode>)`. (#1591)
