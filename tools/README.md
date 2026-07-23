# Tools

Utility scripts for the Firely CQL SDK.

## Directory Structure

- **condense_spec/** - CQL Specification HTML to Markdown converter
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

---

For detailed information about each tool, see the README file in its respective subdirectory.
