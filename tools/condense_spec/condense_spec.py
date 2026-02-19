#!/usr/bin/env python3
"""
Condense CQL Specification HTML files to Markdown for AI parsing.
Removes CSS, JS, images, and navigation while preserving content.
"""

import os
import sys
from pathlib import Path
from html.parser import HTMLParser
import re

class SimpleHTMLExtractor(HTMLParser):
    """Extract text content from HTML with minimal markdown formatting."""
    
    def __init__(self):
        super().__init__()
        self.text_parts = []
        self.in_script = False
        self.in_style = False
        self.in_pre = False
        self.in_code = False
        self.heading_level = 0
        self.list_level = 0
        
    def handle_starttag(self, tag, attrs):
        if tag == 'script':
            self.in_script = True
        elif tag == 'style':
            self.in_style = True
        elif tag == 'pre':
            self.in_pre = True
            self.text_parts.append('\n```\n')
        elif tag == 'code' and not self.in_pre:
            self.in_code = True
            self.text_parts.append('`')
        elif tag in ['h1', 'h2', 'h3', 'h4', 'h5', 'h6']:
            self.heading_level = int(tag[1])
            self.text_parts.append('\n\n' + '#' * self.heading_level + ' ')
        elif tag == 'p':
            self.text_parts.append('\n\n')
        elif tag == 'br':
            self.text_parts.append('\n')
        elif tag in ['ul', 'ol']:
            self.list_level += 1
        elif tag == 'li':
            indent = '  ' * (self.list_level - 1)
            self.text_parts.append(f'\n{indent}- ')
        elif tag == 'blockquote':
            self.text_parts.append('\n> ')
        elif tag == 'strong' or tag == 'b':
            self.text_parts.append('**')
        elif tag == 'em' or tag == 'i':
            self.text_parts.append('*')
            
    def handle_endtag(self, tag):
        if tag == 'script':
            self.in_script = False
        elif tag == 'style':
            self.in_style = False
        elif tag == 'pre':
            self.text_parts.append('\n```\n')
            self.in_pre = False
        elif tag == 'code' and not self.in_pre:
            self.text_parts.append('`')
            self.in_code = False
        elif tag in ['h1', 'h2', 'h3', 'h4', 'h5', 'h6']:
            self.text_parts.append('\n')
            self.heading_level = 0
        elif tag in ['ul', 'ol']:
            self.list_level -= 1
        elif tag == 'strong' or tag == 'b':
            self.text_parts.append('**')
        elif tag == 'em' or tag == 'i':
            self.text_parts.append('*')
            
    def handle_data(self, data):
        if self.in_script or self.in_style:
            return
        if self.in_pre or self.in_code:
            self.text_parts.append(data)
        else:
            # Clean whitespace but keep meaningful text
            cleaned = ' '.join(data.split())
            if cleaned:
                self.text_parts.append(cleaned + ' ')
    
    def get_text(self):
        text = ''.join(self.text_parts)
        # Clean up
        text = re.sub(r'\n{4,}', '\n\n', text)
        text = re.sub(r' +', ' ', text)
        text = re.sub(r' +\n', '\n', text)
        return text.strip()

def convert_html_to_markdown(html_file: Path) -> str:
    """Extract main content from an HTML file and convert to markdown."""
    with open(html_file, 'r', encoding='utf-8', errors='ignore') as f:
        html = f.read()
    
    # Try to extract just the main content section
    # Look for segment-content or main content area
    content_patterns = [
        (r'<div id="segment-content"[^>]*>(.*?)</div>\s*<!--\s*/segment-content', re.DOTALL),
        (r'<main[^>]*>(.*?)</main>', re.DOTALL),
        (r'<article[^>]*>(.*?)</article>', re.DOTALL),
        (r'<div[^>]*class="[^"]*content[^"]*"[^>]*>(.*?)</div>', re.DOTALL),
    ]
    
    content_html = None
    for pattern, flags in content_patterns:
        match = re.search(pattern, html, flags)
        if match:
            content_html = match.group(1)
            break
    
    if not content_html:
        # Fallback: use entire body
        body_match = re.search(r'<body[^>]*>(.*?)</body>', html, re.DOTALL)
        if body_match:
            content_html = body_match.group(1)
        else:
            content_html = html
    
    # Parse the extracted content
    parser = SimpleHTMLExtractor()
    try:
        parser.feed(content_html)
        return parser.get_text()
    except Exception as e:
        print(f"Error parsing {html_file.name}: {e}", file=sys.stderr)
        return f"# {html_file.stem}\n\nError extracting content: {e}"

def main():
    """Main entry point."""
    script_dir = Path(__file__).parent.parent.parent
    spec_dir = script_dir / 'spec' / 'source' / '1.5.3 - Release 1 Errata 2' / 'site'
    output_dir = script_dir / 'spec' / 'condensed'
    
    if not spec_dir.exists():
        print(f"Error: Spec directory not found: {spec_dir}")
        return 1
    
    # Create output directory
    output_dir.mkdir(exist_ok=True)
    
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
    
    print("Converting CQL Specification HTML to Markdown...")
    print(f"Source: {spec_dir}")
    print(f"Output: {output_dir}\n")
    
    for filename in spec_files:
        html_file = spec_dir / filename
        
        if not html_file.exists():
            print(f"⚠️  Skipping {filename} (not found)")
            continue
        
        # Convert to markdown
        markdown_content = convert_html_to_markdown(html_file)
        
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
        
        reduction = 100 - (md_size / html_size * 100) if html_size > 0 else 0
        print(f"✓ {filename:45s} {html_size:>10,} → {md_size:>10,} bytes ({reduction:>5.1f}% reduction)")
    
    # Create README
    readme_content = f"""# CQL Specification - Condensed for AI Parsing

This directory contains the CQL 1.5.3 Release 1 Errata 2 specification converted to Markdown format.

## Purpose

The original specification includes 1,752 files (40MB) with CSS, JavaScript, images, and other web assets.
This condensed version contains only the specification content in Markdown format for easier AI parsing.

## Conversion Details

- **Original:** {total_html_size:,} bytes across {converted_count} HTML files
- **Condensed:** {total_md_size:,} bytes in {converted_count} Markdown files  
- **Reduction:** {100 - (total_md_size/total_html_size*100):.1f}% smaller
- **Generated:** {Path(__file__).name}

## Files

The main specification sections:

1. **00-executivesummary.md** - Executive Summary
2. **01-introduction.md** - Introduction  
3. **02-authorsguide.md** - CQL Author's Guide
4. **03-developersguide.md** - CQL Developer's Guide
5. **04-logicalspecification.md** - Logical Specification
6. **05-languagesemantics.md** - Language Semantics
7. **06-translationsemantics.md** - Translation Semantics
8. **07-physicalrepresentation.md** - Physical Representation
9. **08-a-cqlsyntax.md** - Appendix A: CQL Syntax Formal Specification
10. **09-b-cqlreference.md** - Appendix B: CQL Reference
11. **10-c-referenceimplementations.md** - Appendix C: Reference Implementations
12. **11-d-references.md** - Appendix D: References
13. **12-e-acronyms.md** - Appendix E: Acronyms
14. **13-f-glossary.md** - Appendix F: Glossary
15. **14-g-formattingconventions.md** - Appendix G: Formatting Conventions
16. **15-h-timeintervalcalculations.md** - Appendix H: Time Interval Calculation Examples
17. **16-i-fhirpathtranslation.md** - Appendix I: FHIRPath Function Translation
18. **17-j-listoftables.md** - Appendix J: List of Tables
19. **18-k-listoffigures.md** - Appendix K: List of Figures
20. **19-l-cqlsyntaxdiagrams.md** - Appendix L: CQL Syntax Diagrams
21. **elm.md** - ELM (Expression Logical Model)
22. **examples.md** - Examples
23. **tests.md** - Tests

## Usage

These files can be read directly by AI agents for specification conformance analysis without loading
1,700+ unnecessary web assets.

## Source

Original specification: https://cql.hl7.org/
Local copy: `spec/1.5.3 - Release 1 Errata 2/`
"""
    
    readme_file = output_dir / 'README.md'
    with open(readme_file, 'w', encoding='utf-8') as f:
        f.write(readme_content)
    
    print(f"\n✓ Created {readme_file.name}")
    print(f"\n{'='*80}")
    print(f"Summary:")
    print(f"  Files converted: {converted_count}")
    print(f"  Total reduction: {total_html_size:,} → {total_md_size:,} bytes ({100 - (total_md_size/total_html_size*100):.1f}% reduction)")
    print(f"  Output directory: {output_dir}")
    print(f"{'='*80}")
    
    return 0

if __name__ == '__main__':
    sys.exit(main())
