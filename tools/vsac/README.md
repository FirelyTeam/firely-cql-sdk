# VSAC Expansion Completer

Replaces partial (paged) `ValueSet` expansions in a vendored corpus with complete ones fetched from
VSAC's FHIR `$expand`, pinned to the version each local file already declares.

**Created in:** [#1562](https://github.com/FirelyTeam/firely-cql-sdk/issues/1562), after 20 value
sets truncated at exactly 1000 concepts — VSAC's default page size — silently disabled 1200
integration-runner test cases across 22 measure classes.

## Why a page is not usable

A paged expansion carries `expansion.total` far above the number of concepts in
`expansion.contains`, and records the page in `expansion.parameter`:

```json
"total": 3608,
"offset": 0,
"parameter": [ { "name": "count", "valueInteger": 1000 }, { "name": "offset", "valueInteger": 0 } ],
"contains": [ /* 1000 of 3608 */ ]
```

Membership cannot be answered from that: a code absent from the page is not absent from the value
set. `ValueSetSource.EnsureCompleteExpansion` therefore rejects it (see
[Cql/Cql.Firely/ValueSetSource.cs](../../Cql/Cql.Firely/ValueSetSource.cs)), which is correct — but
it means a corpus carrying one such file loses every measure that references it.

The truncation originates upstream: `cqframework/dqm-content-qicore-2025`, `dqm-content-cms-2025`
and both 2026 content repositories all ship these files identically truncated, so re-syncing content
does not fix it. VSAC is the only source of the missing concepts, and it requires authentication.

## Prerequisites

A UMLS profile API key from <https://uts.nlm.nih.gov/uts/profile>. The corpus already vendors VSAC
expansions; this tool only completes the ones that arrived as a page.

Supply the key by file (recommended — keep it outside the repository) or by environment variable:

```bash
python3 tools/vsac/complete_expansions.py --api-key-file ~/.vsac-key
UMLS_API_KEY=<key> python3 tools/vsac/complete_expansions.py
```

The key only ever goes into an `Authorization` header; it is not written to the report or to any
output file.

## Usage

Needs Python 3 (standard library only) — see
[Prerequisites in the getting-started guide](../../docs/getting-started.md#repository-tooling).

```bash
# List what is partial, fetch nothing. Needs no key.
python3 tools/vsac/complete_expansions.py --dry-run

# Complete every partial expansion in the integration-runner corpus (the default folder).
python3 tools/vsac/complete_expansions.py --api-key-file <path>

# One value set, or another corpus.
python3 tools/vsac/complete_expansions.py --api-key-file <path> --oid 2.16.840.1.113883.3.117.1.7.1.255
python3 tools/vsac/complete_expansions.py --api-key-file <path> --value-sets-dir <folder>
```

## What it writes

Only the `expansion` element is rewritten. `compose`, `meta`, identifiers, the surrounding
formatting and the file's line endings are left exactly as they were, so the diff shows the concepts
that were added and nothing else. The rewritten element keeps the fetched expansion's `identifier`
and `timestamp`, sets `offset` to 0, and drops the `count`/`offset` parameters, which described a
page the file no longer holds. Any other parameter VSAC reports is kept.

The serializer reproduces VSAC's own pretty-printing (Jackson's defaults: `[ {` … `} ]` for arrays
of objects, inline arrays of scalars), so a rewrite introduces no incidental formatting churn. That
was verified by re-serializing all 662 expansions in the integration-runner corpus and comparing
against the bytes on disk — 662 identical, 0 differing.

An element is omitted rather than written empty: FHIR JSON has no representation for an empty array
and a reader rejects one outright, which is what dropping `count`/`offset` from `parameter` would
otherwise produce.

## Pinning the version does not pin the code systems

`valueSetVersion` pins the *value set*, not the code systems it draws on. A VSAC expansion is
computed when it is requested, against whatever SNOMED CT and ICD-10 releases are current, so
expanding the same value set version a year later legitimately returns a different set of concepts.
Requesting `2.16.840.1.113883.3.117.1.7.1.255` at version `20210220` returns:

| | concepts | code systems |
|---|---|---|
| What the corpus recorded (expanded 2025-08-28) | 3608 | ICD-10 `2025`, SNOMED unversioned |
| What VSAC returned on 2026-08-19 | 3600 | ICD-10 `2026`, SNOMED `20260301` |

Ten SNOMED procedure codes had gone (Nissen fundoplication, extended left hemihepatectomy, …) and
two had appeared. There is no as-of-date parameter that would undo this, so **a completion is also a
refresh** whenever the underlying code systems have moved. That is why the drift checks below exist
and why accepting them is explicit.

## What it refuses to write

A fetch is discarded, with the reason reported and a non-zero exit code, when:

- the concepts fetched do not add up to the server's `total`;
- pages overlap, i.e. the same `(system, code)` arrives twice (content shifting mid-paging);
- VSAC answers with a different `version` than the one requested;
- the server's `total` no longer matches the `total` in the local file;
- any concept present in the local page is missing from the fetch.

The last two are content drift rather than a broken fetch. They refuse by default because a corpus
of frozen expected outputs was computed against the older content, and silently swapping in newer
content can flip a result without anyone deciding to. `--allow-content-drift` accepts them, printing
every delta and listing them again in the summary so the change is on the record — that is the flag
to use when refreshing a corpus deliberately, followed by a full run of whatever tests depend on it.

## Re-run it after a content re-sync

The integration runner's corpus is copied verbatim from the upstream content repository (`CodeGen`
copies `input/vocabulary/valueset/external/ValueSet-*.json` unchanged), so a re-sync reinstates the
truncated files. Run this tool afterwards — see the sync procedure in the
`Firely.Cql.Sdk.Integration.Runner` README.

## The one value set that makes VSAC access unavoidable

Nineteen of the 20 are grouping value sets whose members are themselves published in the content
repository, so their complete expansions can — with effort — be reconstructed offline by following
`compose` down to member value sets that are not truncated.

`2.16.840.1.113883.3.3157.4056` (MajorSurgicalProcedure, 11539 concepts) cannot. One of its members
resolves through a SNOMED CT `filter` and a non-literal `exclude`, which only a terminology server
can evaluate. Paging `$expand` returns it in full because VSAC evaluates the filter server-side —
that is precisely why this tool exists rather than an offline reconstruction. The measure that needs
it is `CMS996FHIRAptTxforSTEMI`, 112 test cases.
