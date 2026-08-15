## Performance

- `ValueSetSource` no longer rebuilds the in-memory facade for a `ValueSet` it has already seen as an
  object. Building that facade from an expansion — turning every `expansion.contains` entry into a
  `CqlCode`, interning it, and hashing the lot — is a pure function of the instance, so it is now
  memoized process-wide against that instance under a weak key. A host whose resolver hands back
  stable instances (Firely Server's conformance cache, for example) therefore pays the materialization
  once for the lifetime of the instance rather than once per `ValueSetSource`, which in a server is
  once per request (#1567).

  The memo only ever hits when the resolver returns the same object again; a host without an
  instance-stable resolver loses nothing, because a fresh instance simply builds the way it always did.
  Entries are held under weak keys, so they live exactly as long as the host keeps the instance alive —
  there are no bounds to tune and no invalidation to perform. Each `ValueSetSource` still keeps its own
  canonical-to-facade dictionary, which remains the only thing its query methods consult; the memo
  spares the build, not the lookup.

  A value set that arrives *without* an expansion is expanded by the source itself, and what that
  yields depends on the CodeSystems and value sets that source's resolver can reach, so its facade
  stays private to that source and never enters the memo. A partial expansion is not memoized either:
  it throws, as before, on every attempt.

  There is no public API change.
