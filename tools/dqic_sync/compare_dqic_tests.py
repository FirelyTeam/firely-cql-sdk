#!/usr/bin/env python3
"""
Compare the vendored CQL conformance test suite (Cql/CqlToElmTests/Input/DQIC/*.xml) against the
current official suite published at https://cql.hl7.org/tests.zip.

For every <test> element (matched by name, within its file), classifies it as:
  - upstream_only  : official has it, we don't (candidate to import)
  - local_only     : we have it, official doesn't (our own addition — keep)
  - identical      : same expression/output content in both
  - modified       : same test name in both, but expression/output/attributes differ

For "modified" and files with upstream_only tests, looks up git history (via `git log -S` pickaxe
search) for commits that touched that specific test name in that file, so a human reviewer can see
*why* it likely differs (an intentional spec-conformance fix vs. unexplained drift) without the
script trying to guess intent itself.

Usage:
    python3 tools/dqic_sync/compare_dqic_tests.py [--zip-path <path-to-already-downloaded-zip>]
    python3 tools/dqic_sync/compare_dqic_tests.py --report-path <output.md>

Network access to https://cql.hl7.org/tests.zip is required unless --zip-path is given.
"""

import argparse
import subprocess
import sys
import urllib.request
import xml.etree.ElementTree as ET
import zipfile
from io import BytesIO
from pathlib import Path

TESTS_ZIP_URL = "https://cql.hl7.org/tests.zip"
NS = "{http://hl7.org/fhirpath/tests}"
USER_AGENT = "firely-cql-sdk-dqic-comparator/1.0 (+https://github.com/FirelyTeam/firely-cql-sdk)"


def download_tests_zip() -> bytes:
    request = urllib.request.Request(TESTS_ZIP_URL, headers={"User-Agent": USER_AGENT})
    with urllib.request.urlopen(request, timeout=30) as response:
        return response.read()


def parse_tests_file(xml_bytes: bytes) -> tuple:
    """Parse a DQIC test XML file into ({test_name: canonical_content_string}, [duplicate_names]).

    A dict collapses duplicate <test name="..."> entries within one file down to the last one seen
    — duplicates are rare but real (found in the official suite while building this tool), so they
    are surfaced explicitly rather than silently skewing test counts.
    """
    root = ET.fromstring(xml_bytes)
    tests = {}
    seen_counts = {}
    for test_el in root.iter(f"{NS}test"):
        name = test_el.get("name")
        if name is None:
            continue
        seen_counts[name] = seen_counts.get(name, 0) + 1
        # Canonicalize: attributes + text of expression/output children, in document order.
        # This intentionally ignores whitespace-only formatting differences.
        parts = []
        for child in test_el:
            tag = child.tag.replace(NS, "")
            attrs = " ".join(f'{k}="{v}"' for k, v in sorted(child.attrib.items()))
            text = (child.text or "").strip()
            parts.append(f"<{tag} {attrs}>{text}")
        tests[name] = "\n".join(parts)
    duplicates = sorted(name for name, count in seen_counts.items() if count > 1)
    return tests, duplicates


def load_official_suite(zip_bytes: bytes) -> tuple:
    """Returns ({filename: {test_name: canonical_content}}, {filename: [dup names]}, {filename: parse_error})."""
    suite = {}
    duplicates = {}
    errors = {}
    with zipfile.ZipFile(BytesIO(zip_bytes)) as zf:
        for info in zf.infolist():
            if not info.filename.startswith("cql/") or not info.filename.endswith(".xml"):
                continue
            filename = Path(info.filename).name
            try:
                tests, dups = parse_tests_file(zf.read(info))
                suite[filename] = tests
                if dups:
                    duplicates[filename] = dups
            except ET.ParseError as e:
                # The official suite itself isn't guaranteed well-formed (found a stray closing
                # </group> in CqlArithmeticFunctionsTest.xml while building this tool) — don't let
                # that crash the whole comparison, just flag it for manual review.
                errors[filename] = str(e)
    return suite, duplicates, errors


def load_local_suite(local_dir: Path) -> tuple:
    """Returns ({filename: {test_name: canonical_content}}, {filename: [dup names]}, {filename: parse_error}) for the local suite."""
    suite = {}
    duplicates = {}
    errors = {}
    for xml_file in local_dir.glob("*.xml"):
        try:
            tests, dups = parse_tests_file(xml_file.read_bytes())
            suite[xml_file.name] = tests
            if dups:
                duplicates[xml_file.name] = dups
        except ET.ParseError as e:
            errors[xml_file.name] = str(e)
    return suite, duplicates, errors


def git_log_for_test(repo_root: Path, local_file: Path, test_name: str, max_entries: int = 5) -> list:
    """Find commits that touched a specific test name within a specific file (pickaxe search)."""
    if not local_file.exists():
        return []
    try:
        result = subprocess.run(
            ["git", "log", f"-S{test_name}", "--oneline", "--", str(local_file.relative_to(repo_root))],
            cwd=repo_root, capture_output=True, text=True, timeout=30, check=False,
        )
    except Exception:
        return []
    lines = [line for line in result.stdout.splitlines() if line.strip()]
    return lines[:max_entries]


def build_report(official: dict, official_dups: dict, errors: dict, local: dict, local_dups: dict,
                  local_errors: dict, repo_root: Path, local_dir: Path) -> str:
    lines = [
        "# DQIC Test Suite Comparison Report",
        "",
        f"Comparing `{TESTS_ZIP_URL}` against `{local_dir.relative_to(repo_root)}/`.",
        "",
        "This is a **review artifact, not a source of truth** — for every difference, use judgment",
        "(and the linked git history) before changing anything. Do not auto-apply upstream values;",
        "many local differences are intentional spec-conformance fixes. Comparison is by test name",
        "within each file; a file with duplicate `<test name=\"...\">` entries has its count affected",
        "(see below) since only the last occurrence is compared.",
        "",
    ]

    if errors:
        lines.append("## Upstream files that failed to parse")
        lines.append("")
        lines.append("Not a local issue — the official suite itself isn't guaranteed well-formed:")
        lines.append("")
        for filename, error in sorted(errors.items()):
            lines.append(f"- `{filename}`: {error} (skipped; compare this one by hand)")
        lines.append("")

    if local_errors:
        lines.append("## Local files that failed to parse")
        lines.append("")
        for filename, error in sorted(local_errors.items()):
            lines.append(f"- `{filename}`: {error} (parse error; file excluded from comparison — investigate before syncing)")
        lines.append("")

    if official_dups or local_dups:
        lines.append("## Duplicate test names within a single file")
        lines.append("")
        for filename in sorted(set(official_dups) | set(local_dups)):
            if filename in official_dups:
                lines.append(f"- `{filename}` (upstream): {', '.join(official_dups[filename])}")
            if filename in local_dups:
                lines.append(f"- `{filename}` (local): {', '.join(local_dups[filename])}")
        lines.append("")

    all_files = sorted(set(official) | set(local) | set(errors) | set(local_errors))
    summary_rows = []
    detail_sections = []

    for filename in all_files:
        official_tests = official.get(filename)
        local_tests = local.get(filename)
        local_file = local_dir / filename

        if filename in errors:
            summary_rows.append((filename, "PARSE ERROR (upstream)", str(len(local_tests) if local_tests else 0), "-", "-", "-", "-"))
            continue  # already covered in the "failed to parse" section above

        if filename in local_errors:
            summary_rows.append((filename, str(len(official_tests) if official_tests else 0), "PARSE ERROR (local)", "-", "-", "-", "-"))
            continue  # already covered in the "local files that failed to parse" section above

        if official_tests is None:
            summary_rows.append((filename, "-", "-", "-", "-", "-", "LOCAL-ONLY FILE"))
            detail_sections.append(
                f"## {filename}\n\n**This entire file does not exist upstream** — a Firely-only "
                f"addition ({len(local_tests)} tests). No action needed unless this was meant to "
                f"map to an upstream file under a different name.\n"
            )
            continue

        if local_tests is None:
            summary_rows.append((filename, str(len(official_tests)), "-", "MISSING FILE", "-", "-", "-"))
            detail_sections.append(
                f"## {filename}\n\n**This entire file is missing locally** "
                f"({len(official_tests)} upstream tests never imported):\n\n"
                + "\n".join(f"- `{name}`" for name in sorted(official_tests))
                + "\n"
            )
            continue

        upstream_only = sorted(set(official_tests) - set(local_tests))
        local_only = sorted(set(local_tests) - set(official_tests))
        shared = set(official_tests) & set(local_tests)
        modified = sorted(n for n in shared if official_tests[n] != local_tests[n])
        identical_count = len(shared) - len(modified)

        summary_rows.append((
            filename, str(len(official_tests)), str(len(local_tests)),
            str(len(upstream_only)), str(len(local_only)), str(len(modified)), str(identical_count),
        ))

        if not upstream_only and not local_only and not modified:
            continue  # fully in sync, no detail section needed

        section = [f"## {filename}", ""]

        if upstream_only:
            section.append(f"### Missing locally ({len(upstream_only)})")
            section.append("")
            for name in upstream_only:
                commits = git_log_for_test(repo_root, local_file, name)
                commit_note = f" — git history: {'; '.join(commits)}" if commits else ""
                section.append(f"- `{name}`: `{official_tests[name].replace(chr(10), r'\n')}`{commit_note}")
            section.append("")

        if local_only:
            section.append(f"### Firely additions, not upstream ({len(local_only)})")
            section.append("")
            for name in local_only:
                section.append(f"- `{name}`: `{local_tests[name].replace(chr(10), r'\n')}`")
            section.append("")

        if modified:
            section.append(f"### Differs from upstream ({len(modified)})")
            section.append("")
            for name in modified:
                commits = git_log_for_test(repo_root, local_file, name)
                commit_note = "; ".join(commits) if commits else "(no matching commit found via pickaxe search)"
                section.append(f"- `{name}`")
                section.append(f"  - upstream: `{official_tests[name].replace(chr(10), r'\n')}`")
                section.append(f"  - local: `{local_tests[name].replace(chr(10), r'\n')}`")
                section.append(f"  - git history: {commit_note}")
            section.append("")

        detail_sections.append("\n".join(section))

    summary_lines = [
        "## Summary",
        "",
        "| File | Upstream tests | Local tests | Missing locally | Firely additions | Modified | Identical |",
        "|---|---|---|---|---|---|---|",
    ]
    for row in summary_rows:
        summary_lines.append("| " + " | ".join(row) + " |")

    return "\n".join(lines + summary_lines + [""] + detail_sections)


def main():
    parser = argparse.ArgumentParser(description=__doc__)
    parser.add_argument("--zip-path", type=Path, help="Path to an already-downloaded tests.zip (skip network fetch)")
    parser.add_argument("--report-path", type=Path, help="Where to write the markdown report (default: stdout)")
    args = parser.parse_args()

    repo_root = Path(__file__).parent.parent.parent
    local_dir = repo_root / "Cql" / "CqlToElmTests" / "Input" / "DQIC"

    if args.zip_path:
        zip_bytes = args.zip_path.read_bytes()
    else:
        print(f"Downloading {TESTS_ZIP_URL} ...", file=sys.stderr)
        zip_bytes = download_tests_zip()

    official, official_dups, errors = load_official_suite(zip_bytes)
    local, local_dups, local_errors = load_local_suite(local_dir)

    report = build_report(official, official_dups, errors, local, local_dups, local_errors, repo_root, local_dir)

    if args.report_path:
        args.report_path.write_text(report, encoding="utf-8")
        print(f"Wrote {args.report_path}", file=sys.stderr)
    else:
        print(report)

    return 0


if __name__ == "__main__":
    sys.exit(main())
