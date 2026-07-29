"""
Shared HTML-to-Markdown condensing logic used by both the CQL spec condenser
(condense_spec.py) and the FHIR spec page fetcher (fetch_fhir_page.py).
"""

import re
import sys
from html.parser import HTMLParser


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


# Patterns tried in order to isolate the main content region of a page,
# skipping navigation/header/footer chrome. Falls back to <body>, then the
# whole document, since different HL7 publishing templates vary.
CONTENT_PATTERNS = [
    (r'<div id="segment-content"[^>]*>(.*?)</div>\s*<!--\s*/segment-content', re.DOTALL),
    (r'<main[^>]*>(.*?)</main>', re.DOTALL),
    (r'<article[^>]*>(.*?)</article>', re.DOTALL),
    (r'<div[^>]*class="[^"]*content[^"]*"[^>]*>(.*?)</div>', re.DOTALL),
]


def extract_main_content(html: str) -> str:
    """Isolate the main content region of a page, stripping nav/header/footer chrome."""
    for pattern, flags in CONTENT_PATTERNS:
        match = re.search(pattern, html, flags)
        if match:
            return match.group(1)

    body_match = re.search(r'<body[^>]*>(.*?)</body>', html, re.DOTALL)
    if body_match:
        return body_match.group(1)
    return html


def convert_html_to_markdown(html: str, *, label: str = 'input') -> str:
    """Convert raw HTML content to condensed markdown."""
    content_html = extract_main_content(html)

    parser = SimpleHTMLExtractor()
    try:
        parser.feed(content_html)
        return parser.get_text()
    except Exception as e:
        print(f"Error parsing {label}: {e}", file=sys.stderr)
        return f"# {label}\n\nError extracting content: {e}"
