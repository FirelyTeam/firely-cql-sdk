## Fixes

- **CQL to ELM translation** — Libraries whose includes form a cycle, directly, through other libraries or by a library
  including itself, no longer make `CqlToolkit.TranslateToElm()` recurse until the stack overflows and the process ends.
  The include that closes the cycle is recorded in the ELM as an error naming the libraries along it, from the library that
  sorts first, so the error reads the same whatever order the libraries are translated in; the other libraries translate.
  A library that is translated also keeps its builder, so a library translated later that includes it resolves it without
  parsing its CQL again. (#1874)
