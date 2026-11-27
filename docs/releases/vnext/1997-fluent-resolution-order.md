## Fixes

- **CQL to ELM translation** — a fluent call resolves as the Java translator resolves it: the functions of the
  calling library are searched first, then the system operators, then the included libraries in the order the
  includes are declared, and the first with an applicable overload wins, even when a later one matches better. A
  candidate on which the call is ambiguous is skipped. Translation no longer throws when two included libraries
  define a fluent function with the same signature, and a call into an included library, fluent or implicitly on the
  element of a `sort by`, now names that library (`libraryName`) in the `FunctionRef`, so the ELM-to-C# compiler
  finds the function. In a `sort by`, a fluent call or a call qualified by a library name is no longer tried as a
  call on the sorted element. CQL whose fluent calls were resolved to the best match across all of these can now
  resolve to a different function, and so evaluate differently. (#453)
