## Potentially Breaking

- `ValueSetSource` no longer writes a computed expansion into the valueset handed to `Add` or
  resolved by `Load`. Two consequences for hosts: a host that read `ValueSet.Expansion` back after
  `Add`/`Load` no longer finds one there and must expand for itself; and two sources with
  *different* resolvers handed the same expansion-less instance no longer share the first source's
  expansion — each now answers from its own resolver's world, so membership answers can move (to
  the correct ones). (#1591)

## Fixes

- `ValueSetSource` no longer writes into the valueset handed to `Add` or resolved by `Load`: a
  valueset that arrives without an expansion is expanded on a private copy, so that instance — which
  a host cache may be serving to every consumer in the process — is left untouched, on success and
  on failure alike. Previously the computed expansion was written into the caller's instance (and a
  failed expansion cleared it), corrupting host-side conformance caches that share instances. Note
  that the underlying `ValueSetExpander` still expands an expansion-less *included* valueset
  (`compose.include`) from the resolver in place — that is the expander's own behavior, tracked at
  [firely-net-sdk#3582 (adjacent defect B)](https://github.com/FirelyTeam/firely-net-sdk/issues/3582).
  A host cache serving an expansion-less valueset that another valueset includes is therefore still
  written to through that path, including having its expansion cleared if the expansion fails. A
  source still expands a given canonical at most once through its per-canonical facade layer; hosts
  that want cross-source reuse of computed expansions can serve valuesets with static expansions or
  seed sources via `Add(string, IEnumerable<CqlCode>)`. (#1591)
