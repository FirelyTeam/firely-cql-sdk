# vNext Release Notes

## Breaking Changes

## Features

## Fixes

- Updated the Firely .NET SDK dependency (`Hl7.Fhir.*`) from 6.2.0 to 6.2.1.

- The C# compiler now collapses ELM choice types whose alternatives all map to the same .NET type (e.g. `Choice<Condition, Condition>` produced for unions of QiCore Condition profiles) to that single type instead of `object`. Generated code stays strongly typed and no longer falls back to late-bound property access (seen in e.g. CMS125 "Right Mastectomy Diagnosis"). The generator tool version was bumped to 5.1.2.0 and the checked-in generated libraries were regenerated.
