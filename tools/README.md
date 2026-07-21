# Tools

Utility scripts for the Firely CQL SDK.

## Directory Structure

- **condense_spec/** - CQL Specification HTML to Markdown converter
- **dqic_sync/** - Compares the vendored CQL conformance test suite against the official upstream suite
- **XsdToCSharpConverter/** - XSD to C# code generation tool
- **XsdToCSharpConverterTests/** - Tests for XSD converter

## Tools

### condense_spec

Converts the CQL specification from HTML to Markdown format for AI parsing.

**Location:** `tools/condense_spec/`

**Purpose:** Condenses the 40MB CQL spec (1,752 files) into 912KB of clean Markdown (24 files) for easier AI analysis.

**Usage:**
```bash
python3 tools/condense_spec/condense_spec.py
```

**Results:**
- Reduces spec from 40MB → 912KB (97.7% reduction)
- Converts 23 HTML files to clean Markdown
- Removes CSS, JavaScript, images, navigation
- Output: `spec/condensed/` directory

**Documentation:** See [tools/condense_spec/README.md](condense_spec/README.md) for complete details.

**Created in:** PR for "Experimental - Using AI to verify codebase conformance with CQL spec"

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

---

For detailed information about each tool, see the README file in its respective subdirectory.
