# vNext Release Notes

## Breaking Changes

## Features

## Fixes

- An instance selector whose element value cannot be converted to that element's declared type (e.g. `Concept { codes: Code { code: '8480-6' } }` with list promotion disabled) now reports a normal translation error naming the element and both types, instead of crashing the translator with a `NotImplementedException` (#1416).
