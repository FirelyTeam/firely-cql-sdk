# 8. CQL Specification Conformance

Parent document: [../copilot-instructions.md](../copilot-instructions.md)

## 8.0. Table of Contents

- [8. CQL Specification Conformance](#8-cql-specification-conformance)
- [8.0. Table of Contents](#80-table-of-contents)
- [8.1. Authoritative Specification Source](#81-authoritative-specification-source)
- [8.2. When to Check Specification](#82-when-to-check-specification)
- [8.3. Specification Location](#83-specification-location)
- [8.4. Validating Emitted Output](#84-validating-emitted-output)

## 8.1. Authoritative Specification Source

8.1.1 **CRITICAL**: Always use `/spec/cql/condensed/` as the authoritative CQL specification for all development work

8.1.2 The condensed specification is a markdown version of the official CQL specification; see `/spec/cql/README.md` for the exact version mirrored and conversion details

8.1.3 **DO NOT** rely on external URLs (cql.hl7.org) as they may be blocked or unavailable

8.1.4 **IMPORTANT**: If external spec URLs (cql.hl7.org) become accessible during your work, clearly notify the user that the external specification is now reachable. This indicates the local spec in the repository may need updating.

8.1.5 The condensed spec contains all specification content without web assets (CSS, JS, images)

8.1.6 For FHIR spec pages (as opposed to CQL), see `/spec/fhir/condensed/` and `/spec/fhir/README.md` — fetched on demand per-page via `tools/condense_spec/fetch_fhir_page.py <url>` rather than vendored wholesale, since the FHIR spec is far larger than the CQL spec

## 8.2. When to Check Specification

8.2.1 **Before implementing any CQL operator or function**: Verify behavior against `/spec/cql/condensed/09-b-cqlreference.md`

8.2.2 **During code reviews**: Check that implementation matches specification requirements

8.2.3 **When fixing bugs**: Confirm the expected behavior from the specification before making changes

8.2.4 **When writing tests**: Ensure test expectations align with specification examples and semantics

8.2.5 **When adding new features**: Verify feature requirements and edge cases from the specification

## 8.3. Specification Location

8.3.1 **Main CQL reference**: `/spec/cql/condensed/09-b-cqlreference.md` (operator and function definitions)

8.3.2 **Language semantics**: `/spec/cql/condensed/05-languagesemantics.md`

8.3.3 **Type system**: `/spec/cql/condensed/03-developersguide.md`

8.3.4 **ELM specification**: `/spec/cql/condensed/elm.md`

8.3.5 **Test examples**: `/spec/cql/condensed/tests.md`

8.3.6 **Time interval calculations**: `/spec/cql/condensed/15-h-timeintervalcalculations.md`

8.3.7 **Complete list**: See `/spec/cql/README.md` for all available specification sections

8.3.8 **Conformance reports**: See `/spec/report/README.md` — findings are tracked as GitHub issues under epic [#1193](https://github.com/FirelyTeam/firely-cql-sdk/issues/1193), not as markdown reports in this folder

## 8.4. Validating Emitted Output

8.4.1 **CRITICAL**: Where the format of something the SDK emits has an independent checker, a test that pins its exact text must assert against that checker as well as against the string

8.4.2 A string assertion answers "did the output change?", never "is the output correct?"; when the expectation written first is itself wrong, the assertion turns a defect into a defended invariant

8.4.3 The string pins the shape and the checker pins the validity — a validator, a parser, or a round-trip back through the reader all serve; use whichever the format already has

8.4.4 **For FHIR primitives** the checker is `Hl7.Fhir.Model.<Type>.IsValidValue(value)` (`FhirDateTime`, `Time`, `Date`, `Instant`, …), a public static on the already-referenced `Hl7.Fhir.Base`, costing one line per emission point

8.4.5 Two invalid values reached `develop` behind passing string assertions: `Time("10:30:00Z")`, where FHIR `time` forbids a timezone offset, and a time-bearing `dateTime` with no offset, which FHIR requires once hours and minutes are present — see [#1508](https://github.com/FirelyTeam/firely-cql-sdk/issues/1508)

8.4.6 **DO NOT** write a test asserting that invalid output is correct, or a comment claiming an invariant the code does not hold — "pre-existing" and "out of scope" justify not fixing invalid output in the change at hand, never pinning it; quarantine it with a comment pointing at the tracking issue instead
