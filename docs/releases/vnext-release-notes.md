# vNext Release Notes

## Breaking Changes

## Features

## Fixes

- `Hasher` no longer shares a single static `MD5` instance across threads, fixing intermittent `CryptographicException: Concurrent operations from multiple threads on this type are not supported` when tuple metadata signature hashes were computed concurrently (e.g. during parallel measure evaluation). It now uses the thread-safe one-shot `MD5.HashData` API (#1372).
- `IndexedBundle.FilterByType<T>` (used by `Retrieve`) no longer yields a candidate resource more than once when several of its codings match the filter, preventing inflated `Retrieve` results / population counts for resources with multiple matching codings (#1365).
- CQL `with`/`without` relationship clauses now compile as an existence filter (semi-join/anti-semi-join) instead of `SelectMany`/`Except`, so a source element with multiple matching related elements is emitted exactly once instead of duplicated (or spuriously deduplicated by `Except` set semantics for `without`) (#1366).
