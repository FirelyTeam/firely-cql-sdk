# 8. CQL Specification Conformance

Parent document: [../copilot-instructions.md](../copilot-instructions.md)

## 8.0. Table of Contents

- [8. CQL Specification Conformance](#8-cql-specification-conformance)
- [8.0. Table of Contents](#80-table-of-contents)
- [8.1. Authoritative Specification Source](#81-authoritative-specification-source)
- [8.2. When to Check Specification](#82-when-to-check-specification)
- [8.3. Specification Location](#83-specification-location)

## 8.1. Authoritative Specification Source

8.1.1 **CRITICAL**: Always use `/spec/condensed/` as the authoritative CQL specification for all development work

8.1.2 The condensed specification is a markdown version of the official CQL 1.5.3 Release 1 Errata 2 specification

8.1.3 **DO NOT** rely on external URLs (cql.hl7.org) as they may be blocked or unavailable

8.1.4 **IMPORTANT**: If external spec URLs (cql.hl7.org) become accessible during your work, clearly notify the user that the external specification is now reachable. This indicates the local spec in the repository may need updating.

8.1.5 The condensed spec contains all specification content without web assets (CSS, JS, images)

## 8.2. When to Check Specification

8.2.1 **Before implementing any CQL operator or function**: Verify behavior against `/spec/condensed/09-b-cqlreference.md`

8.2.2 **During code reviews**: Check that implementation matches specification requirements

8.2.3 **When fixing bugs**: Confirm the expected behavior from the specification before making changes

8.2.4 **When writing tests**: Ensure test expectations align with specification examples and semantics

8.2.5 **When adding new features**: Verify feature requirements and edge cases from the specification

## 8.3. Specification Location

8.3.1 **Main CQL reference**: `/spec/condensed/09-b-cqlreference.md` (operator and function definitions)

8.3.2 **Language semantics**: `/spec/condensed/05-languagesemantics.md`

8.3.3 **Type system**: `/spec/condensed/03-developersguide.md`

8.3.4 **ELM specification**: `/spec/condensed/elm.md`

8.3.5 **Test examples**: `/spec/condensed/tests.md`

8.3.6 **Time interval calculations**: `/spec/condensed/15-h-timeintervalcalculations.md`

8.3.7 **Complete list**: See `/spec/condensed/README.md` for all available specification sections

8.3.8 **Conformance reports**: See `/spec/report/` for known deviations and issue templates