# Cql.Abstractions

See the root [CLAUDE.md](../../CLAUDE.md) for when to use `CqlException<TError>` vs plain .NET exceptions.

`ICqlError`, `ICqlArithmeticError`, `CqlException`, `CqlException<TError>`, and `CqlErrorExtensions` live under `Exceptions/`, namespace `Hl7.Cql.Exceptions`.

This project uses **one `Errors.cs` file per direct folder**, holding every `ICqlError` struct thrown by code in that folder. The namespace matches the folder's namespace:

- `Exceptions/Errors.cs` → `Hl7.Cql.Exceptions` (internal infrastructure errors)
- `Primitives/Errors.cs` → `Hl7.Cql.Primitives` (errors thrown by `CqlDate`, `CqlDateTime`, etc.)

When adding a new folder that needs its own errors, add a `FolderName/Errors.cs` matching that pattern rather than putting the struct in an existing folder's file or a shared catch-all.

New `ICqlError` structs go in the `Errors.cs` of the folder containing their throw site. If the struct is part of the public API (not `internal`, like the existing structs in `Exceptions/Errors.cs`), it must also be registered in `PublicAPI.Unshipped.txt`.
