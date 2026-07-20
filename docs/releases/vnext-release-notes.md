# vNext Release Notes

## Breaking Changes

- `Hl7.Cql.Elm.VersionedIdentifier` equality and ordering semantics changed to be spec-conformant (#1376). Library `id` comparison is now **case-sensitive** (CQL is a case-sensitive language) and `version` is now matched as an **exact opaque string** rather than being normalized. This means `VersionedIdentifier` instances that previously compared equal may now compare unequal — for example, ids differing only by case (`"FoO"` vs `"fOo"`) or versions in different but formerly-equivalent formats (`"1.0"` vs `"1.0.0"`) are now considered distinct. This affects all identity checks built on `VersionedIdentifier` comparison, including library dependency graphs and per-library dependency sets in `LibrarySet`.
- `VersionedIdentifierDictionary` (backing `MemoryLibraryProvider`'s `include` resolution on the active `TryResolveLibrary` path) now resolves library identifiers using the same spec-conformant semantics: `id` lookup is **case-sensitive** (was `OrdinalIgnoreCase`) and `version` must match **exactly** (was numeric-segment normalization that silently equated `"1.0"` with `"1.0.0"`). Code that previously resolved an `include` by a differently-cased id or by a semantically-but-not-textually-equal version specifier will no longer find a match.

## Features

## Fixes

- `Hasher` no longer shares a single static `MD5` instance across threads, fixing intermittent `CryptographicException: Concurrent operations from multiple threads on this type are not supported` when tuple metadata signature hashes were computed concurrently (e.g. during parallel measure evaluation). It now uses the thread-safe one-shot `MD5.HashData` API (#1372).
- `IndexedBundle.FilterByType<T>` (used by `Retrieve`) no longer yields a candidate resource more than once when several of its codings match the filter, preventing inflated `Retrieve` results / population counts for resources with multiple matching codings (#1365).
- CQL `with`/`without` relationship clauses now compile as an existence filter (semi-join/anti-semi-join) instead of `SelectMany`/`Except`, so a source element with multiple matching related elements is emitted exactly once instead of duplicated (or spuriously deduplicated by `Except` set semantics for `without`) (#1366).
- `VersionedIdentifier.GetHashCode()` is now consistent with `Equals()`, and both now conform to the CQL specification: `id` comparison is case-sensitive (CQL is a case-sensitive language per §3.4.1 of the Developer's Guide) and `version` is matched as an exact opaque string (per §3.2 of the Developer's Guide and §2.1.5 of the Logical Specification), preventing missed matches/duplicate entries in hash-based dependency sets (#1375).
