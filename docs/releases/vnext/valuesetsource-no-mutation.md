## Fixes

- `ValueSetSource` no longer writes into a resolved `ValueSet`: a valueset that arrives without an
  expansion is expanded on a private copy, so the resolver's instance — which a host cache may be
  serving to every consumer in the process — is left untouched, on success and on failure alike.
  Previously the computed expansion was written into the caller's instance (and a failed expansion
  cleared it), corrupting host-side conformance caches that share instances. A source still expands
  a given canonical at most once through its per-canonical facade layer; hosts that want
  cross-source reuse of computed expansions can serve valuesets with static expansions or seed
  sources via `Add(string, IEnumerable<CqlCode>)`. (#1591)
