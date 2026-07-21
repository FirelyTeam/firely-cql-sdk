# Spec Condenser

Converts HL7 specification HTML into Markdown for AI parsing. Covers two tools sharing the same
HTML→Markdown logic (`html_to_markdown.py`):

- `condense_spec.py` — CQL spec, converted from a full local site export
- `fetch_fhir_page.py` — FHIR spec, fetched page-by-page from a URL you pass in (the FHIR spec is
  too large to vendor wholesale, so this only pulls the pages actually needed)

**Created in:** PR for "Experimental - Using AI to verify codebase conformance with CQL spec"  
**Branch:** `copilot/validate-cql-conformance`  
**Extended in:** [#1389](https://github.com/FirelyTeam/firely-cql-sdk/issues/1389) to add the FHIR
fetch tool and split output by technology (`spec/cql/`, `spec/fhir/`)

## Versioning

Neither tool encodes the spec version in a folder name — that would rename the whole output
directory (and break any cross-references) every time a spec is refreshed. Instead, each
`spec/<tech>/README.md` (`spec/cql/README.md`, `spec/fhir/README.md`) records the current
version/source details in plain text/markdown, and is fully rewritten by its tool on each run, so
it never needs manual upkeep. The two folders' layouts differ slightly because the tools work
differently (one converts a vendored site export, the other fetches pages on demand) — see each
tool's section below.

## CQL spec: `condense_spec.py`

The official CQL specification website contains 1,752 files (40MB) including HTML, CSS, JavaScript, images, and other web assets. This makes it difficult for AI agents to parse and analyze the specification content.

This tool extracts the main content from the specification HTML files and converts them to clean Markdown format, reducing the total size from 40MB to 912KB (97.7% reduction).

### Usage

```bash
# From repository root
python3 tools/condense_spec/condense_spec.py
```

### Input

- Source: `spec/cql/source/1.5.3 - Release 1 Errata 2/site/` (HTML files, gitignored)

### Output

- Destination: `spec/cql/condensed/` (23 Markdown files containing the specification content)
- `spec/cql/README.md` — version, source URL, conversion stats, file index, and instructions for
  regenerating after a spec update (same one-README-per-technology layout as `spec/fhir/README.md`)

## FHIR spec: `fetch_fhir_page.py`

The FHIR spec (hl7.org/fhir) is far larger than the CQL spec and changes per-version; rather than
vendoring it wholesale, this tool fetches and condenses individual pages on demand — pass the URL(s)
of the pages you actually need (e.g. a resource's `-definitions.html` page, or an IG conformance
page).

### Usage

```bash
# From repository root — one or more URLs
python3 tools/condense_spec/fetch_fhir_page.py https://hl7.org/fhir/R4/measure-definitions.html
python3 tools/condense_spec/fetch_fhir_page.py <url1> <url2> ...
```

### Output

- Destination: `spec/fhir/condensed/<slug-derived-from-url>.md`
- `spec/fhir/README.md` — baseline FHIR version plus a table of every page fetched, its source URL,
  and last-fetched date (re-running against an already-tracked URL refreshes its row and file in
  place, not duplicated)

## What Gets Removed

- Navigation menus and breadcrumbs
- CSS stylesheets
- JavaScript code
- Images and icons
- Footer and header elements
- FHIR Binary resources (test files, examples - these are separate from the spec text)

## What Gets Preserved

- All specification text content
- Headings structure
- Code blocks
- Lists and formatting
- Tables (simplified)

## Implementation Details

Both tools share `html_to_markdown.py`:
1. Isolate the main content region (tries `segment-content` div, `<main>`, `<article>`, a
   `class*=content` div, then falls back to `<body>` — different HL7 publishing templates vary)
2. Parse with Python's `HTMLParser`
3. Convert to simple Markdown (headings, code blocks, lists, bold/italic; strips navigation,
   scripts, and styling)

## Requirements

- Python 3.6+
- No additional packages required — `fetch_fhir_page.py` uses `urllib` from the standard library,
  no `requests` dependency

## Background

This tool was created as part of the CQL specification conformance analysis work (issue
"Experimental - Using AI to verify codebase conformance with CQL spec", branch
`copilot/validate-cql-conformance`). The condensed CQL spec enabled an AI-assisted analysis pass
that found several real conformance bugs; those findings are now tracked as GitHub issues under
epic [#1193](https://github.com/FirelyTeam/firely-cql-sdk/issues/1193) rather than as markdown
reports in the repo (see `spec/report/README.md`).

## Future Use

Re-run `condense_spec.py` whenever a newer CQL spec errata is vendored into `spec/cql/source/`, and
run `fetch_fhir_page.py` against the FHIR pages tracked in `spec/fhir/README.md` whenever those
pages might have changed. See [#1389](https://github.com/FirelyTeam/firely-cql-sdk/issues/1389) for
the plan to make this periodic rather than ad hoc.
