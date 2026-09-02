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
