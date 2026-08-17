## Performance

- `ValueSetSource` no longer rebuilds the in-memory facade for an expansion it has already seen as an
  object. Building that facade — turning every `expansion.contains` entry into a `CqlCode`, interning
  it, and hashing the lot — is a pure function of the `ValueSet.expansion` it reads, so it is now
  memoized process-wide against that `ExpansionComponent` under a weak key. A host whose resolver hands
  back stable instances (Firely Server's conformance cache, for example) therefore pays the
  materialization once for the lifetime of the expansion rather than once per `ValueSetSource`, which in
  a server is once per request (#1567).

  The memo only ever hits when the resolver returns the same expansion object again; a host without an
  instance-stable resolver loses nothing, because a fresh value set carries a fresh expansion and simply
  builds the way it always did. Entries are held under weak keys, so they live exactly as long as the
  host keeps the expansion alive — there are no bounds to tune and no invalidation to perform. Each
  `ValueSetSource` still keeps its own canonical-to-facade dictionary, which remains the only thing its
  query methods consult; the memo spares the build, not the lookup. Sources racing on the same expansion
  converge on a single build and await it rather than blocking a thread each on it, which matters on a
  request path where a cold value set would otherwise park every racer but one.

  The memoized facade is a snapshot of the expansion as it looked when the facade was built from it.
  *Replacing* a value set's `expansion` is honored, because the replacement is a different key: the next
  `Add` builds a facade from it, as does handing out a copy of the whole value set (`DeepCopy`). Editing
  an expansion *in place* after a facade was successfully built from it — appending to `contains`, moving
  `total` — is not observed, which is the same constraint a resolver that shares instances already
  imposes: every consumer, cache or no cache, would be looking at whatever the last writer left behind.
  Editing an expansion after a build *failed* on it (completing a partial expansion after the fact) is
  honored, because a failed build retains nothing.

  A value set that arrives *without* an expansion is expanded by the source itself, and what that
  yields depends on the CodeSystems and value sets that source's resolver can reach, so its facade
  stays private to that source and never enters the memo. What the expander computed is written into
  the caller's instance, so a later `Add` of that same instance does take the memo path, keyed on the
  expansion just written. A partial expansion is not memoized either: it throws, as before, on every
  attempt.

  Building a facade is now eager: the expansion's codes are materialized when the value set is added,
  rather than on first query. For a value set that is resolved because something needs it this is a
  small win (the code list is walked once instead of up to three times), but a caller that bulk-loads
  value sets it never queries (`Add(IEnumerable<ValueSet>)`, `ToValueSetDictionary`) now pays for those
  up front.

  There is no public API change.
