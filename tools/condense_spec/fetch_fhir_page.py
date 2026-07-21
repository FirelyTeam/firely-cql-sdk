#!/usr/bin/env python3
"""
Fetch and condense individual FHIR specification pages to Markdown for AI parsing.

Unlike the CQL spec (vendored once as a full site export, see condense_spec.py), the FHIR spec is
far larger and versioned per-release, so this tool fetches only the pages you actually need,
passed in as URL arguments.

Usage:
    python3 tools/condense_spec/fetch_fhir_page.py https://hl7.org/fhir/R4/measure-definitions.html
    python3 tools/condense_spec/fetch_fhir_page.py <url1> <url2> ...
"""

import re
import sys
import urllib.request
from datetime import date
from pathlib import Path
from urllib.parse import urlparse

from html_to_markdown import convert_html_to_markdown

# The FHIR version this SDK targets by default (see Cql/Cql.Model/Models/fhir-modelinfo-4.0.1.xml).
# Individual fetched pages may belong to a differently-versioned IG (tracked per-URL in README.md);
# this is just the baseline recorded there.
FHIR_BASELINE_VERSION = "R4"

USER_AGENT = "firely-cql-sdk-spec-condenser/1.0 (+https://github.com/FirelyTeam/firely-cql-sdk)"


def slug_from_url(url: str) -> str:
    """Derive a filesystem-safe markdown filename from a page URL."""
    parsed = urlparse(url)
    path = parsed.path.rstrip('/')
    name = path.rsplit('/', 1)[-1] or parsed.netloc
    name = re.sub(r'\.html?$', '', name, flags=re.IGNORECASE)
    # Keep the path context (e.g. ig/HL7/cqf-measures) so pages with the same
    # filename from different sites/IGs don't collide.
    parent = path.rsplit('/', 1)[0].strip('/').replace('/', '-')
    slug = f"{parent}-{name}" if parent else name
    slug = re.sub(r'[^a-zA-Z0-9._-]+', '-', slug).strip('-').lower()
    return slug or "page"


def fetch_html(url: str) -> str:
    request = urllib.request.Request(url, headers={"User-Agent": USER_AGENT})
    with urllib.request.urlopen(request, timeout=30) as response:
        charset = response.headers.get_content_charset() or "utf-8"
        return response.read().decode(charset, errors="ignore")


def load_source_entries(readme_file: Path) -> dict:
    """Parse existing README.md table rows into {url: (fetched_date, filename)}."""
    entries = {}
    if not readme_file.exists():
        return entries
    for line in readme_file.read_text(encoding="utf-8").splitlines():
        match = re.match(r'\|\s*(\S+)\s*\|\s*(\S+)\s*\|\s*(\S+)\s*\|', line)
        if match and match.group(1).startswith(("http://", "https://")):
            url, fetched, filename = match.groups()
            entries[url] = (fetched, filename.strip('`'))
    return entries


def write_readme(readme_file: Path, entries: dict):
    lines = [
        "# FHIR Specification (Condensed)",
        "",
        f"- **Baseline version:** {FHIR_BASELINE_VERSION} (see `Cql/Cql.Model/Models/fhir-modelinfo-4.0.1.xml`)",
        "- **Condensed by:** `tools/condense_spec/fetch_fhir_page.py`",
        "",
        "Unlike the CQL spec, this isn't vendored wholesale — only specific pages needed for",
        "development are fetched on demand. Individual pages can belong to different FHIR versions",
        "or implementation guides; this table is per-page ground truth.",
        "",
        "## Pages",
        "",
        "| URL | Last fetched | File |",
        "|---|---|---|",
    ]
    for url in sorted(entries):
        fetched, filename = entries[url]
        lines.append(f"| {url} | {fetched} | `{filename}` |")
    lines += [
        "",
        "## Adding or refreshing a page",
        "",
        "```bash",
        "python3 tools/condense_spec/fetch_fhir_page.py <url> [<url> ...]",
        "```",
        "",
        "Re-running against an already-tracked URL refreshes its row and file in place.",
    ]
    readme_file.write_text("\n".join(lines) + "\n", encoding="utf-8")


def main(argv):
    if not argv:
        print(__doc__)
        return 1

    script_dir = Path(__file__).parent.parent.parent
    output_dir = script_dir / 'spec' / 'fhir' / 'condensed'
    output_dir.mkdir(parents=True, exist_ok=True)

    readme_file = output_dir.parent / 'README.md'
    entries = load_source_entries(readme_file)

    today = date.today().isoformat()

    for url in argv:
        print(f"Fetching {url} ...")
        try:
            html = fetch_html(url)
        except Exception as e:
            print(f"  Error fetching {url}: {e}", file=sys.stderr)
            continue

        markdown_content = convert_html_to_markdown(html, label=url)
        filename = slug_from_url(url) + '.md'
        output_file = output_dir / filename
        output_file.write_text(markdown_content, encoding='utf-8')

        entries[url] = (today, filename)
        html_size = len(html.encode('utf-8'))
        md_size = len(markdown_content.encode('utf-8'))
        reduction = 100 - (md_size / html_size * 100) if html_size > 0 else 0
        print(f"  -> {output_file} ({html_size:,} -> {md_size:,} bytes, {reduction:.1f}% reduction)")

    write_readme(readme_file, entries)
    print(f"\nWrote {readme_file}")
    return 0


if __name__ == '__main__':
    sys.exit(main(sys.argv[1:]))
