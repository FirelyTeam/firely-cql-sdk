# Tools

Utility scripts for the Firely CQL SDK.

## Directory Structure

- **condense_spec/** - CQL Specification HTML to Markdown converter
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

---

For detailed information about each tool, see the README file in its respective subdirectory.
