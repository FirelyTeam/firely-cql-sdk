# Tools

Utility scripts for the Firely CQL SDK.

## Directory Structure

- **condense_spec/** - CQL Specification HTML to Markdown converter
- **mermaid/** - Mermaid diagram-to-SVG export scripts
- **dqic_sync/** - Compares the vendored CQL conformance test suite against the official upstream suite
- **vsac/** - Completes partial (paged) ValueSet expansions in a vendored corpus from VSAC
- **XsdToCSharpConverter/** - XSD to C# code generation tool
- **XsdToCSharpConverterTests/** - Tests for XSD converter

## Tools

### condense_spec

Converts HL7 specification HTML to Markdown format for AI parsing — `condense_spec.py` for the CQL
spec (converted from a full local site export), `fetch_fhir_page.py` for individual FHIR spec pages
(fetched by URL, since the FHIR spec is too large to vendor wholesale).

**Location:** `tools/condense_spec/`

**Purpose:** Condenses the 40MB CQL spec (1,752 files) into 912KB of clean Markdown (24 files) for easier AI analysis; fetches and condenses FHIR spec pages on demand.

**Usage:**
```bash
python3 tools/condense_spec/condense_spec.py
python3 tools/condense_spec/fetch_fhir_page.py <url> [<url> ...]
```

**Results:**
- CQL: reduces spec from 40MB → 912KB (97.7% reduction), converts 23 HTML files to clean Markdown
- Both: removes CSS, JavaScript, images, navigation
- Output: `spec/cql/condensed/` and `spec/fhir/condensed/`, each with a `README.md` one level up (`spec/cql/README.md`, `spec/fhir/README.md`) recording version/source details and a file index

**Documentation:** See [tools/condense_spec/README.md](condense_spec/README.md) for complete details.

**Created in:** PR for "Experimental - Using AI to verify codebase conformance with CQL spec"; extended in [#1389](https://github.com/FirelyTeam/firely-cql-sdk/issues/1389) to add the FHIR fetch tool

### mermaid

Renders Mermaid diagrams (`.mmd` source files, or inline `` ```mermaid `` fences in a markdown file)
to `.svg`, so docs embed a pre-rendered image instead of relying on the host's inline Mermaid
renderer — GitHub's renderer does not reliably support every Mermaid feature used in this repo's
diagrams (`classDiagram` `namespace` blocks, multi-target `style` directives, custom
`<<stereotype>>` annotations).

**Location:** `tools/mermaid/`

**Purpose:** Keeps Mermaid diagram source (`.mmd`) and its rendered `.svg` artifact in sync as a
committed pair, instead of shipping diagrams as raw fenced code blocks that may not render.

**Usage:**
```bash
pwsh tools/mermaid/export-mermaid-svg.ps1 -MarkdownPath <doc.md> -SourcePath <diagram.mmd> -OutputDir <dir>
tools/mermaid/export-mermaid-svg.sh --markdown-path <doc.md> --source-path <diagram.mmd> --output-dir <dir>
```

**Documentation:** See [tools/mermaid/README.md](mermaid/README.md) for complete details, and the
[generate-svg-from-mermaid](../.claude/skills/generate-svg-from-mermaid/SKILL.md) skill for the
authoring workflow.

**Created in:** [#1399](https://github.com/FirelyTeam/firely-cql-sdk/issues/1399); adapted from
[firely-dqm-libraries](https://github.com/FirelyTeam/firely-dqm-libraries/blob/main/devops/export-mermaid-svg.ps1).
### dqic_sync

Compares `Cql/CqlToElmTests/Input/DQIC/*.xml` against the official CQL test suite
(https://cql.hl7.org/tests.zip) and produces a markdown report of missing/added/modified tests, for
manual review — it does not modify any test files itself.

**Location:** `tools/dqic_sync/`

**Usage:**
```bash
python3 tools/dqic_sync/compare_dqic_tests.py --report-path /tmp/dqic-report.md
```

**Documentation:** See [tools/dqic_sync/README.md](dqic_sync/README.md) for complete details.

**Created in:** [#1389](https://github.com/FirelyTeam/firely-cql-sdk/issues/1389)

### vsac

Replaces partial (paged) `ValueSet` expansions in a vendored corpus — `expansion.total` of 3608 with
1000 concepts actually present — with complete ones fetched from VSAC's FHIR `$expand`, pinned to the
version each local file declares. A page cannot answer membership, so the SDK rejects one; the
upstream eCQM content repositories ship 20 such files, which silently disabled 1200
integration-runner cases.

**Location:** `tools/vsac/`

**Usage:**
```bash
python3 tools/vsac/complete_expansions.py --dry-run
python3 tools/vsac/complete_expansions.py --api-key-file <path-to-umls-key>
```

**Documentation:** See [tools/vsac/README.md](vsac/README.md) for complete details, including what
the tool refuses to write and why a content re-sync reinstates the truncation.

**Created in:** [#1562](https://github.com/FirelyTeam/firely-cql-sdk/issues/1562)

---

For detailed information about each tool, see the README file in its respective subdirectory.
