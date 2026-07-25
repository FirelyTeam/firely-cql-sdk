# vNext Release Notes

## Breaking Changes

- The C# generated for CQL libraries has changed shape (generator tool version 5.1.3.0 →
  5.1.5.0); regenerate any checked-in generated C# when upgrading. Multi-branch
  conditionals (`if`/`case … when`) now emit native `if`/`else` statements instead of
  invoked zero-parameter local functions, redundant casts to `object` no longer print,
  duplicate pure subexpressions within a definition are computed once, and local-variable
  naming is contiguous. The generated code is substantially shorter (−4% across the HEDIS
  2025 corpus) and reads like hand-written C#; no public API, method signature, or
  generated-code attribute shape changed, so existing invokers keep working.

## Features

## Fixes
