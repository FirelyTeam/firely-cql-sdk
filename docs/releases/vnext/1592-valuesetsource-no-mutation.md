## Potentially Breaking

- `ValueSetSource` no longer writes a computed expansion into the valueset handed to `Add` or
  resolved by `Load`. Two consequences for hosts: a host that read `ValueSet.Expansion` back after
  `Add`/`Load` no longer finds one there and must expand for itself; and two sources with
  *different* resolvers handed the same expansion-less instance no longer share the first source's
  expansion — each now answers from its own resolver's world, so membership answers can move (to
  the correct ones). (#1591)

## Fixes

- A valueset that arrives without an expansion is now expanded on a private copy, so a host cache
  serving that instance to every consumer in the process is no longer corrupted by the SDK: the
  computed expansion used to be written into the caller's instance, and a failed expansion used to
  clear it. What is protected is the instance handed to `Add` or resolved by `Load`, and only that:
  the underlying `ValueSetExpander` still expands an expansion-less *included* valueset
  (`compose.include`) resolved from this source's resolver in place — the expander's own behavior,
  tracked as
  [firely-net-sdk#3582 (adjacent defect B)](https://github.com/FirelyTeam/firely-net-sdk/issues/3582)
  — so a cache serving such an included valueset is still written to, and still loses its expansion
  if that expansion fails. A source still expands a given canonical at most once through its
  per-canonical facade layer; hosts that want cross-source reuse of computed expansions can serve
  valuesets with static expansions or seed sources via `Add(string, IEnumerable<CqlCode>)`. (#1591)
