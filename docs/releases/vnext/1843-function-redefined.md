## Fixes

- **CQL to ELM translation** — a library that defines a function twice with the same operand types translates
  with the error `A function named Twice with the same type of arguments is already defined in this library.` on the
  second definition, which is dropped, instead of failing the whole library with an `ArgumentException`. Overloads
  with different operand types are unaffected.
