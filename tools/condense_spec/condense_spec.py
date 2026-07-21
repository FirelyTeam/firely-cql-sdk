#!/usr/bin/env python3
"""
Condense CQL Specification HTML files to Markdown for AI parsing.
Removes CSS, JS, images, and navigation while preserving content.
"""

import sys
from pathlib import Path

from html_to_markdown import convert_html_to_markdown

CQL_SPEC_VERSION = "1.5.3 - Release 1 Errata 2"
CQL_SPEC_SOURCE_URL = "https://cql.hl7.org/"

# filename stem -> description, in the order they should be listed in README.md
SPEC_FILE_DESCRIPTIONS = [
    ('00-executivesummary', 'Executive Summary'),
    ('01-introduction', 'Introduction'),
    ('02-authorsguide', "CQL Author's Guide"),
    ('03-developersguide', "CQL Developer's Guide"),
    ('04-logicalspecification', 'Logical Specification'),
    ('05-languagesemantics', 'Language Semantics'),
    ('06-translationsemantics', 'Translation Semantics'),
    ('07-physicalrepresentation', 'Physical Representation'),
    ('08-a-cqlsyntax', 'Appendix A: CQL Syntax Formal Specification'),
    ('09-b-cqlreference', 'Appendix B: CQL Reference'),
    ('10-c-referenceimplementations', 'Appendix C: Reference Implementations'),
    ('11-d-references', 'Appendix D: References'),
    ('12-e-acronyms', 'Appendix E: Acronyms'),
    ('13-f-glossary', 'Appendix F: Glossary'),
    ('14-g-formattingconventions', 'Appendix G: Formatting Conventions'),
    ('15-h-timeintervalcalculations', 'Appendix H: Time Interval Calculation Examples'),
    ('16-i-fhirpathtranslation', 'Appendix I: FHIRPath Function Translation'),
    ('17-j-listoftables', 'Appendix J: List of Tables'),
    ('18-k-listoffigures', 'Appendix K: List of Figures'),
    ('19-l-cqlsyntaxdiagrams', 'Appendix L: CQL Syntax Diagrams'),
    ('elm', 'ELM (Expression Logical Model)'),
    ('examples', 'Examples'),
    ('tests', 'Tests'),
]


def convert_html_file_to_markdown(html_file: Path) -> str:
    """Extract main content from an HTML file and convert to markdown."""
    with open(html_file, 'r', encoding='utf-8', errors='ignore') as f:
        html = f.read()
    return convert_html_to_markdown(html, label=html_file.name)


def main():
    """Main entry point."""
    script_dir = Path(__file__).parent.parent.parent
    spec_dir = script_dir / 'spec' / 'cql' / 'source' / CQL_SPEC_VERSION / 'site'
    output_dir = script_dir / 'spec' / 'cql' / 'condensed'

    if not spec_dir.exists():
        print(f"Error: Spec directory not found: {spec_dir}")
        return 1

    # Create output directory
    output_dir.mkdir(parents=True, exist_ok=True)

    # Main specification files to convert
    spec_files = [
        '00-executivesummary.html',
        '01-introduction.html',
        '02-authorsguide.html',
        '03-developersguide.html',
        '04-logicalspecification.html',
        '05-languagesemantics.html',
        '06-translationsemantics.html',
        '07-physicalrepresentation.html',
        '08-a-cqlsyntax.html',
        '09-b-cqlreference.html',
        '10-c-referenceimplementations.html',
        '11-d-references.html',
        '12-e-acronyms.html',
        '13-f-glossary.html',
        '14-g-formattingconventions.html',
        '15-h-timeintervalcalculations.html',
        '16-i-fhirpathtranslation.html',
        '17-j-listoftables.html',
        '18-k-listoffigures.html',
        '19-l-cqlsyntaxdiagrams.html',
        'elm.html',
        'examples.html',
        'tests.html',
    ]

    total_html_size = 0
    total_md_size = 0
    converted_count = 0
    converted_stems = []

    print("Converting CQL Specification HTML to Markdown...")
    print(f"Source: {spec_dir}")
    print(f"Output: {output_dir}\n")

    for filename in spec_files:
        html_file = spec_dir / filename

        if not html_file.exists():
            print(f"Skipping {filename} (not found)")
            continue

        # Convert to markdown
        markdown_content = convert_html_file_to_markdown(html_file)

        # Write to output file
        md_filename = html_file.stem + '.md'
        output_file = output_dir / md_filename

        with open(output_file, 'w', encoding='utf-8') as f:
            f.write(markdown_content)

        # Stats
        html_size = html_file.stat().st_size
        md_size = len(markdown_content.encode('utf-8'))
        total_html_size += html_size
        total_md_size += md_size
        converted_count += 1
        converted_stems.append(html_file.stem)

        reduction = 100 - (md_size / html_size * 100) if html_size > 0 else 0
        print(f"{filename:45s} {html_size:>10,} -> {md_size:>10,} bytes ({reduction:>5.1f}% reduction)")

    if converted_count == 0:
        print("No files converted; leaving existing output and README.md untouched.")
        return 1

    # Create/update spec/cql/README.md: the version and source of truth for this cache lives here
    # (not in the folder name), alongside the file index and instructions for regenerating it.
    # Mirrors the single-README-per-technology layout used by spec/fhir/README.md.
    files_lines = []
    for stem, description in SPEC_FILE_DESCRIPTIONS:
        if stem in converted_stems:
            files_lines.append(f"- `condensed/{stem}.md` — {description}")

    readme_file = output_dir.parent / 'README.md'
    readme_content = f"""# CQL Specification (Condensed)

- **Source:** {CQL_SPEC_SOURCE_URL}
- **Spec version:** {CQL_SPEC_VERSION}
- **Condensed by:** `tools/condense_spec/condense_spec.py`
- **Files converted:** {converted_count}
- **Size reduction:** {total_html_size:,} -> {total_md_size:,} bytes ({100 - (total_md_size/total_html_size*100):.1f}% smaller)

`source/` (gitignored) holds the original HTML site export, only needed to regenerate `condensed/`
after a new CQL spec errata/version is published — day-to-day, just read the files below directly.

## Files

{chr(10).join(files_lines)}

## Regenerating after a spec update

1. Download the new spec site export from {CQL_SPEC_SOURCE_URL} and place it at
   `spec/cql/source/<version>/site/` (e.g. `spec/cql/source/1.5.4/site/`).
2. Update `CQL_SPEC_VERSION` in `tools/condense_spec/condense_spec.py` to match.
3. Run:
   ```bash
   python3 tools/condense_spec/condense_spec.py
   ```
4. Diff `spec/cql/condensed/` to review what changed, and this file will be rewritten with the
   new version/stats/file list automatically.
"""
    with open(readme_file, 'w', encoding='utf-8') as f:
        f.write(readme_content)

    print(f"\nWrote {readme_file}")
    print(f"\n{'='*80}")
    print("Summary:")
    print(f"  Files converted: {converted_count}")
    print(f"  Total reduction: {total_html_size:,} -> {total_md_size:,} bytes ({100 - (total_md_size/total_html_size*100):.1f}% reduction)")
    print(f"  Output directory: {output_dir}")
    print(f"{'='*80}")

    return 0


if __name__ == '__main__':
    sys.exit(main())
