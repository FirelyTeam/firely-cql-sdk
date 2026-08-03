## Breaking Changes

- Using a `LibrarySetInvoker` after it has been disposed now throws `ObjectDisposedException` from
  `LibrarySetInvoker.LibraryInvokers` instead of returning a populated dictionary. `Dispose()` now
  releases both the invoker graph and the invoker's own reference to its `AssemblyLoadContext`, which is
  what allows that context — and the memory mappings for its JIT-compiled code — to actually be
  reclaimed while something still references the invoker. Returning an empty dictionary instead of
  throwing would have turned that release into silently wrong results, so post-dispose access fails
  loudly. Code that only used an invoker within its `using` scope is unaffected. (#1440)

## Features

- Added `Hl7.Cql.Invocation.Toolkit.LibrarySetInvokerPool`, an opt-in pool that reuses
  `LibrarySetInvoker` instances across evaluations of the same library set so its assemblies are
  loaded and JIT-compiled once instead of once per evaluation. `InvocationToolkit.CreateLibrarySetInvoker`
  is unchanged and still creates a fresh `AssemblyLoadContext` per call, so existing consumers see no
  difference unless they opt in.

  Pool entries are keyed on the **content** of the assembly binaries — a sorted SHA-256 hash over the
  assembly and debug-symbol bytes, plus the library set name and exception-continuation policy — so
  rebuilding an equivalent `InvocationToolkit` from freshly read bytes still hits the pool.
  `AssemblyBinary`'s own record equality compares its `byte[]` members by reference and could not
  serve as a key.

  This addresses a production failure mode: collectible load contexts never use ReadyToRun, so every
  generated method is JIT-compiled per context, and unloading them is asynchronous. A host evaluating
  the same library set once per subject accumulated contexts faster than they were reclaimed, and with
  W^X enabled each JIT-compiled region costs two memory mappings, so the process eventually exceeded
  the kernel's `vm.max_map_count` and aborted. (#1440)
- Added `LibrarySetInvokerPoolOptions` (`Capacity`, `MaxPendingUnloads`) and
  `LibrarySetInvokerPoolStatistics` (`Hits`, `Misses`, `Entries`, `PendingUnloads`). `PendingUnloads`
  counts evicted load contexts that have not been reclaimed; a value that keeps climbing means
  something is holding an evicted library set alive, most often a retained `LibraryInvoker` or
  `DefinitionInvoker`, each of which reaches its whole library set through a back-reference. (#1440)

## Fixes

- `LibrarySetInvoker.Dispose()` is now idempotent. Previously it called
  `AssemblyLoadContext.Unload()` unconditionally on every call; unloading twice was an access
  violation before .NET 8.0.0 ([dotnet/runtime#91283](https://github.com/dotnet/runtime/pull/91283))
  and pointless afterwards. (#1440)
- `LibrarySetInvoker.Dispose()` and `SetBatchProcessExceptionContinuation` are inert on an instance
  owned by a `LibrarySetInvokerPool`, and log that they were ignored. A pooled instance is shared, so
  either operation would otherwise reconfigure — or unload the assemblies out from under — every other
  consumer of that pool entry. (#1440)
- `InvocationToolkit.CreateLibrarySetInvoker` no longer leaks the `AssemblyLoadContext` it created when
  loading the library set fails. With the default `Throw` continuation an unloadable assembly binary — or
  the reflection walk over the loaded types — escaped before a `LibrarySetInvoker` took ownership of the
  context, and unloading a collectible context is cooperative, so nothing ever started it: the context and
  whatever assemblies had already loaded into it stayed resident for the lifetime of the process. The
  failure path now unloads the context before rethrowing. (#1440)

## Documentation

- Added an `InvocationToolkit Services Dependency Diagram` to
  [docs/dependency-diagrams.md](../../dependency-diagrams.md), covering `InvocationToolkit`,
  `LibrarySetInvoker`, the invoker graph and the new pool types. `InvocationToolkit` was the only
  toolkit without a dependency diagram. (#1440)
