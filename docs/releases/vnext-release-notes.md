# vNext Release Notes

## Breaking Changes

## Features

- The packager now maps `@stratifier` ELM annotations onto `Measure.group.stratifier`: all
  stratifier-tagged definitions of a group collapse into a single container stratifier
  (`<group>-Stratifier`) with one `component` per dimension. See
  [docs/cql-packager.md](../cql-packager.md#measure-annotations). Previously these annotations
  were silently ignored.

## Fixes
