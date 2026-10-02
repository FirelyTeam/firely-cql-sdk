## Fixes

- **Code generator** — generated C# is written with LF rather than the host platform's line ending, so the
  same inputs produce the same output on Windows and on Unix. The generated C# is embedded verbatim as a
  base64 attachment on a packaged FHIR `Library`, where it cannot be normalized the way a file on disk is,
  so a packaged resource previously recorded which operating system built it. (#1760)

- **Packager** — the CQL embedded as the `text/cql` attachment has its line endings normalized to LF, so a
  working tree checked out with CRLF and one checked out with LF produce the same attachment. (#1760)
