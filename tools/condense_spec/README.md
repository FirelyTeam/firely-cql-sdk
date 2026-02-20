# CQL Specification Condenser

Converts the CQL specification from HTML to Markdown format for AI parsing.

**Created in:** PR for "Experimental - Using AI to verify codebase conformance with CQL spec"  
**Branch:** `copilot/validate-cql-conformance`

## Purpose

The official CQL specification website contains 1,752 files (40MB) including HTML, CSS, JavaScript, images, and other web assets. This makes it difficult for AI agents to parse and analyze the specification content.

This tool extracts the main content from the specification HTML files and converts them to clean Markdown format, reducing the total size from 40MB to 912KB (97.7% reduction).

## Usage

```bash
# From repository root
python3 tools/condense_spec/condense_spec.py
```

## Input

- Source: `spec/source/1.5.3 - Release 1 Errata 2/site/` (HTML files)

## Output

- Destination: `spec/condensed/` (Markdown files)
- 23 Markdown files containing the specification content
- README.md with conversion statistics

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

## Output Files

The script generates these files in `spec/condensed/`:

1. `00-executivesummary.md` - Executive Summary
2. `01-introduction.md` - Introduction  
3. `02-authorsguide.md` - CQL Author's Guide
4. `03-developersguide.md` - CQL Developer's Guide
5. `04-logicalspecification.md` - Logical Specification
6. `05-languagesemantics.md` - Language Semantics
7. `06-translationsemantics.md` - Translation Semantics
8. `07-physicalrepresentation.md` - Physical Representation
9. `08-a-cqlsyntax.md` - Appendix A: CQL Syntax
10. `09-b-cqlreference.md` - Appendix B: CQL Reference
11. `10-c-referenceimplementations.md` - Appendix C: Reference Implementations
12. `11-d-references.md` - Appendix D: References
13. `12-e-acronyms.md` - Appendix E: Acronyms
14. `13-f-glossary.md` - Appendix F: Glossary
15. `14-g-formattingconventions.md` - Appendix G: Formatting Conventions
16. `15-h-timeintervalcalculations.md` - Appendix H: Time Interval Calculations
17. `16-i-fhirpathtranslation.md` - Appendix I: FHIRPath Function Translation
18. `17-j-listoftables.md` - Appendix J: List of Tables
19. `18-k-listoffigures.md` - Appendix K: List of Figures
20. `19-l-cqlsyntaxdiagrams.md` - Appendix L: CQL Syntax Diagrams
21. `elm.md` - ELM (Expression Logical Model)
22. `examples.md` - Examples
23. `tests.md` - Tests
24. `README.md` - Documentation

## Implementation Details

The script:
1. Reads each HTML file
2. Extracts the main content section (using regex to find `segment-content` div)
3. Parses HTML using Python's `HTMLParser`
4. Converts to simple Markdown:
   - Preserves headings with `#` markers
   - Preserves code blocks with triple backticks
   - Preserves lists with `-` markers
   - Preserves bold/italic formatting
   - Removes navigation, scripts, and styling
5. Writes clean Markdown to output files

## Benefits for AI Agents

- **Smaller size:** 97.7% reduction (40MB → 912KB)
- **Cleaner format:** Pure text content without HTML tags
- **Faster parsing:** Markdown is easier to parse than HTML
- **No dependencies:** Just text files, no need to render web assets
- **Focused content:** Only specification text, no navigation or UI elements

## Requirements

- Python 3.6+
- No additional packages required (uses standard library only)

## Results

After running the tool:

- **Original spec:** 40MB (1,752 files including 1,000+ CSS/JS/images)
- **Condensed spec:** 912KB (24 Markdown files)
- **Total size reduction:** 97.7%
- **Content reduction:** 57.5% (from HTML to Markdown)

The condensed specification is available in the `spec/condensed/` directory.

## Background

This tool was created as part of the CQL specification conformance analysis work. The original issue requested using AI to verify codebase conformance with the CQL specification.

During the analysis, it became clear that the full specification folder with 1,752 files (40MB) including CSS, JavaScript, and images was impractical for AI agents to parse. This condensation tool solves that problem by extracting just the text content.

**Related Work:**
- **Issue:** "Experimental - Using AI to verify codebase conformance with CQL spec"
- **Branch:** `copilot/validate-cql-conformance`
- **Analysis Results:** See `spec/report/` directory for detailed conformance findings
- **Condensed Spec:** See `spec/condensed/` directory for the AI-friendly version

The condensed specification enabled efficient analysis that identified 7 spec violations with detailed fix recommendations, all documented in the spec-report directory.

## Future Use

This tool can be reused whenever the CQL specification is updated to generate a new condensed version for AI analysis.
