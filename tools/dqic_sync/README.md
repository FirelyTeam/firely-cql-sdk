# DQIC Test Suite Comparator

Compares the vendored CQL conformance test suite (`Cql/CqlToElmTests/Input/DQIC/*.xml`) against the
current official suite published at https://cql.hl7.org/tests.zip, and produces a markdown report
for manual review.

**Created in:** [#1389](https://github.com/FirelyTeam/firely-cql-sdk/issues/1389), after finding the
vendored suite (first imported 2023-06-09) had already drifted from upstream — a file (`CqlAggregateTest.xml`)
and two individual tests missing entirely, plus several hundred tests with locally-modified
expectations.

## Usage

```bash
# Downloads tests.zip fresh
python3 tools/dqic_sync/compare_dqic_tests.py --report-path /tmp/dqic-report.md

# Or against an already-downloaded copy
python3 tools/dqic_sync/compare_dqic_tests.py --zip-path tests.zip --report-path /tmp/dqic-report.md
```

## What it does

For every `<test name="...">` in each file, matched by name, classifies it as:

- **Missing locally** — official has it, we don't (candidate to import)
- **Firely addition** — we have it, official doesn't (presumably intentional — keep)
- **Differs from upstream** — same test name in both, but expression/output/attributes differ
- *(identical tests aren't listed — nothing to review)*

For every difference, looks up `git log -S<test name>` on the local file so a reviewer can see
which commit last touched that specific test, without the tool itself guessing at intent.

## This is a review artifact, not an auto-fixer

It does not modify any XML files. Many "differs from upstream" cases are **intentional
spec-conformance fixes** (see the epic tracking this work,
[#1193](https://github.com/FirelyTeam/firely-cql-sdk/issues/1193)) where the *local* expectation is
the spec-correct one and upstream is wrong — the official suite's own `tests.html` page states the
tests are "informative, not normative," so upstream should never be treated as automatically
authoritative. Use judgment (and the linked git history) per finding.

## Known upstream data quality issue

While building this tool, `CqlArithmeticFunctionsTest.xml` in the *official* zip was found to have a
malformed stray `</group>` closing tag that breaks strict XML parsing — not a local issue. The tool
catches this per-file and reports it separately rather than crashing; that file needs a manual diff
until/unless HL7 fixes their zip.
