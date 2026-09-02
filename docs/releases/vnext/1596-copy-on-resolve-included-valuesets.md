## Potentially Breaking

- After an expansion, a valueset that was pulled in through another valueset's `compose.include`
  no longer carries the computed expansion on the resolver-owned instance: a host that read
  `ValueSet.Expansion` back from such an included instance after expanding the outer valueset no
  longer finds one there and must expand for itself. This mirrors the entry #1592 records for the
  instance handed to `Add` or resolved by `Load`, extended to transitively included instances.

## Fixes

- Expanding a valueset no longer writes a computed expansion into — or clears one from — the
  valuesets its `compose.include` pulls in through the resolver. Those included valuesets are now
  expanded on private copies as well, closing the gap left by #1591/#1592: a host cache serving an
  expansion-less included valueset to every consumer in the process is no longer corrupted by the
  underlying `ValueSetExpander`'s in-place writes (adjacent defect B of
  [firely-net-sdk#3582](https://github.com/FirelyTeam/firely-net-sdk/issues/3582)). As with the
  top-level copy, another source (or another valueset that includes the same canonical) now expands
  its own copy rather than finding an expansion already written; hosts that want cross-source reuse
  of computed expansions can serve valuesets with static expansions or seed sources via
  `Add(string, IEnumerable<CqlCode>)`.
