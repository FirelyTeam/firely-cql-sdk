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
  clear it. Valuesets resolved transitively through `compose.include` are protected the same way —
  see the accompanying fix note on included valuesets. A valueset added or loaded directly is
  expanded at most once per source through the per-canonical facade layer; a canonical reached only
  as another valueset's include is expanded anew for every resolver lookup that pulls it in. Hosts that
  want reuse across sources or across includes can serve valuesets with static expansions or seed
  sources via `Add(string, IEnumerable<CqlCode>)`. (#1591)
