## Breaking changes

- `ValueSetSource` no longer consults the external terminology service when the value set itself
  resolved. A resolved value set carries a complete expansion, so a code that is not in it is not a
  member — previously every such miss was re-asked as a `$validate-code` call. The terminology
  service is now consulted only for a value set that can be neither found in the cache nor loaded
  through the resource resolver.

  This changes behavior for a setup that pairs a deliberately partial local value set with a
  terminology service and relies on the service to fill the gaps: those codes now come back as
  non-members. Supply complete expansions, or leave the value set out of the cache and resolver so
  it routes to the service as before.

- `ValueSetSource.Add` now rejects a value set whose expansion is only a page of a larger result —
  a non-zero `expansion.offset`, or an `expansion.total` greater than the number of concepts
  actually present — with an `InvalidOperationException`. Caching a partial expansion would turn
  "this page does not contain the code" into "this value set does not contain the code". An
  expansion the SDK builds itself is unaffected; the expander already fails on a value set it
  cannot expand completely.

## Fixes

- `IsCodeInValueSet(valueSetUri, code)` — the code-only overload, reached from CQL's
  `code in valueset` on a bare code — no longer throws
  `FhirOperationException: If 'code' is provided, either 'system' must be provided, or 'inferSystem'
  must be true` when a terminology service is attached. The request could not be expressed as a
  `$validate-code` call because it carries no system; a resolved value set now answers it directly
  and never reaches the service.

## Performance

- Removing the fallthrough takes the per-negative cost of a membership test from an external
  `$validate-code` round-trip to an in-memory lookup. Measured on an NCQA AIS-E patient deck, a
  measure evaluation performs ~89 negative membership tests per patient; against an in-process
  `LocalTerminologyService` those cost ~0.095 ms each, or ~8.5 ms per patient — more than double the
  ~3.8 ms the rest of the evaluation takes. Evaluation against a *remote* terminology server was not
  practical at all at that call volume. A run with no terminology service attached is unaffected: it
  already short-circuited before the round-trip.
