#!/usr/bin/env python3
"""
Replace partial (paged) ValueSet expansions with complete ones fetched from VSAC.

The eCQM content repositories publish some value sets expanded only to VSAC's default page
size of 1000 concepts — `expansion.total` says 3608, `expansion.contains` holds 1000, and
`expansion.parameter` records the `count`/`offset` that produced the page. A page cannot
answer membership: a code absent from it is not absent from the value set. The SDK
therefore refuses to cache one (`ValueSetSource.EnsureCompleteExpansion`), and any corpus
carrying such a file loses every measure that references it.

This tool fetches the missing pages from VSAC's FHIR `$expand`, pinned to the version the
local file already declares, and splices the complete expansion back into the file. Only
the `expansion` element is rewritten; everything else — `compose`, `meta`, identifiers,
formatting, line endings — is left byte-for-byte as it was, so the diff shows exactly what
changed and a later content re-sync can be re-completed the same way.

Usage:
    python tools/vsac/complete_expansions.py --dry-run
    python tools/vsac/complete_expansions.py --api-key-file <path>
    python tools/vsac/complete_expansions.py --oid 2.16.840.1.113883.3.117.1.7.1.255

The API key is a UMLS profile key (https://uts.nlm.nih.gov/uts/profile), read from
`--api-key-file`, `$UMLS_API_KEY` or `$VSAC_API_KEY`. It is never written to the report or
to any output file.
"""

import argparse
import base64
import json
import os
import re
import sys
import time
import urllib.error
import urllib.parse
import urllib.request

VSAC_FHIR_BASE = "https://cts.nlm.nih.gov/fhir"

DEFAULT_VALUE_SETS_DIR = os.path.join(
    "submodules", "Firely.Cql.Sdk.Integration.Runner",
    "IntegrationRunner", "Test Data", "Value Sets")

# Paging parameters describe the page that was fetched, not the value set. A file holding a
# complete expansion must not keep claiming it is a page of one.
PAGING_PARAMETERS = {"count", "offset"}


# ---------------------------------------------------------------------------------------
# Reading the local corpus
# ---------------------------------------------------------------------------------------

def count_concepts(contains):
    """Concepts in an expansion, including nested ones."""
    return sum(1 + count_concepts(c.get("contains")) for c in (contains or []))


def concept_keys(contains):
    """The (system, code) pairs an expansion denotes, including nested ones."""
    keys = set()
    for c in contains or []:
        keys.add((c.get("system"), c.get("code")))
        keys |= concept_keys(c.get("contains"))
    return keys


def read_value_set(path):
    with open(path, "rb") as fh:
        raw = fh.read()
    text = raw.decode("utf-8-sig")
    return text, json.loads(text)


def is_partial(vs):
    """Whether this value set's expansion is only a page of a larger result.

    Mirrors `ValueSetSource.EnsureCompleteExpansion`: a non-zero offset, or a total that
    exceeds the number of concepts actually present.
    """
    expansion = vs.get("expansion")
    if not expansion:
        return False
    if (expansion.get("offset") or 0) > 0:
        return True
    total = expansion.get("total")
    return total is not None and total > count_concepts(expansion.get("contains"))


def find_partial(value_sets_dir, only_oids):
    found = []
    for name in sorted(os.listdir(value_sets_dir)):
        if not name.startswith("ValueSet-") or not name.endswith(".json"):
            continue
        oid = name[len("ValueSet-"):-len(".json")]
        if only_oids and oid not in only_oids:
            continue
        path = os.path.join(value_sets_dir, name)
        _text, vs = read_value_set(path)
        if vs.get("resourceType") != "ValueSet" or not is_partial(vs):
            continue
        expansion = vs["expansion"]
        found.append({
            "path": path,
            "oid": oid,
            "name": vs.get("name"),
            "version": vs.get("version"),
            "total": expansion.get("total"),
            "have": count_concepts(expansion.get("contains")),
        })
    return found


# ---------------------------------------------------------------------------------------
# Fetching from VSAC
# ---------------------------------------------------------------------------------------

def read_api_key(api_key_file):
    if api_key_file:
        with open(api_key_file, "r", encoding="utf-8-sig") as fh:
            key = fh.read().strip()
        if not key:
            raise SystemExit(f"error: {api_key_file} is empty")
        return key
    for var in ("UMLS_API_KEY", "VSAC_API_KEY"):
        key = os.environ.get(var)
        if key:
            return key.strip()
    raise SystemExit(
        "error: no API key. Pass --api-key-file, or set UMLS_API_KEY / VSAC_API_KEY.\n"
        "       A UMLS profile key comes from https://uts.nlm.nih.gov/uts/profile.")


def fetch_page(oid, version, offset, count, key, attempts=4):
    """One page of a VSAC `$expand`, pinned to `version` when the local file declares one."""
    query = {"offset": offset, "count": count}
    if version:
        query["valueSetVersion"] = version
    url = f"{VSAC_FHIR_BASE}/ValueSet/{oid}/$expand?" + urllib.parse.urlencode(query)

    request = urllib.request.Request(url)
    request.add_header("Accept", "application/fhir+json")
    request.add_header(
        "Authorization",
        "Basic " + base64.b64encode(f"apikey:{key}".encode("utf-8")).decode("ascii"))

    for attempt in range(attempts):
        try:
            with urllib.request.urlopen(request, timeout=180) as response:
                return json.loads(response.read().decode("utf-8"))
        except urllib.error.HTTPError as e:
            if e.code == 401:
                raise SystemExit("error: VSAC rejected the API key (401).")
            if e.code in (429, 500, 502, 503, 504) and attempt < attempts - 1:
                time.sleep(2 ** attempt)
                continue
            body = e.read().decode("utf-8", "replace")[:400]
            raise RuntimeError(f"{oid}: HTTP {e.code} from VSAC: {body}") from e
        except urllib.error.URLError as e:
            if attempt < attempts - 1:
                time.sleep(2 ** attempt)
                continue
            raise RuntimeError(f"{oid}: cannot reach VSAC: {e.reason}") from e
    raise RuntimeError(f"{oid}: exhausted retries")


def fetch_complete_expansion(entry, key, page_size, log):
    """Page through `$expand` until the server's own `total` is accounted for."""
    oid, version = entry["oid"], entry["version"]
    contains, parameters = [], None
    identifier = timestamp = None
    total = None
    offset = 0

    while True:
        page = fetch_page(oid, version, offset, page_size, key)
        expansion = page.get("expansion") or {}
        if offset == 0:
            total = expansion.get("total")
            identifier = expansion.get("identifier")
            timestamp = expansion.get("timestamp")
            parameters = [p for p in (expansion.get("parameter") or [])
                          if p.get("name") not in PAGING_PARAMETERS]
            returned_version = page.get("version")
            if version and returned_version and returned_version != version:
                raise RuntimeError(
                    f"{oid}: asked for version {version}, VSAC returned {returned_version}")
            if total is None:
                raise RuntimeError(f"{oid}: VSAC returned an expansion without a total")

        page_contains = expansion.get("contains") or []
        if not page_contains:
            break
        contains.extend(page_contains)
        log(f"    {oid}: {count_concepts(contains)}/{total}")
        if count_concepts(contains) >= total:
            break
        offset += len(page_contains)

    # An element is omitted rather than written empty: FHIR JSON has no representation for an
    # empty array, and a reader rejects one ("An array needs to have at least one element").
    # Dropping `count`/`offset` can empty `parameter` outright, which is how that was found.
    expansion = {"identifier": identifier, "timestamp": timestamp, "total": total, "offset": 0}
    if parameters:
        expansion["parameter"] = parameters
    expansion["contains"] = contains
    return {k: v for k, v in expansion.items() if v is not None}


def validate(entry, expansion, local_vs, allow_drift=False):
    """Reasons this fetch must not be written. Empty list means it may.

    `allow_drift` downgrades the two checks that detect content having moved underneath the
    value set - a changed total, and concepts the local page had that the fetch does not -
    from refusals to reported deltas. Pinning `valueSetVersion` pins the value set, not the
    code systems it draws on, so a value set whose members are SNOMED or ICD-10 expands
    differently after those release: the fetch is then a content refresh rather than a
    completion, and whether that is wanted is a decision for a human, not a default.
    """
    problems = []
    present = count_concepts(expansion["contains"])
    total = expansion["total"]

    if present != total:
        problems.append(f"fetched {present} concepts but total says {total}")

    distinct = len(concept_keys(expansion["contains"]))
    if distinct != present:
        problems.append(f"{present - distinct} duplicate concepts across pages")

    drift = []
    if entry["total"] is not None and total != entry["total"]:
        drift.append(f"total moved from {entry['total']} to {total} since the file was written")

    # The page the file already carries should survive: unless the code systems underneath
    # have moved, a complete expansion of the same version cannot drop a concept the page
    # listed.
    was = concept_keys((local_vs.get("expansion") or {}).get("contains"))
    lost = was - concept_keys(expansion["contains"])
    if lost:
        drift.append(f"{len(lost)} concepts in the existing page are missing from the fetch")

    if drift and not allow_drift:
        problems.extend(drift + ["pass --allow-content-drift to accept a refresh instead of a completion"])
    return problems, drift


# ---------------------------------------------------------------------------------------
# Writing it back
# ---------------------------------------------------------------------------------------

def format_value(value, indent):
    """Serialize the way VSAC does, so a rewritten element matches its neighbours.

    VSAC emits Jackson's default pretty-printing: objects break across lines, arrays keep
    their brackets on the line of the first and last element (`[ {` ... `} ]`), and arrays
    of scalars stay inline.
    """
    pad = " " * indent
    if isinstance(value, dict):
        if not value:
            return "{ }"
        fields = ",\n".join(
            f"{pad}  {json.dumps(k, ensure_ascii=False)}: {format_value(v, indent + 2)}"
            for k, v in value.items())
        return "{\n" + fields + "\n" + pad + "}"
    if isinstance(value, list):
        if not value:
            # FHIR JSON cannot express an empty array; a reader rejects one outright. Refuse to
            # write what cannot be read back rather than emitting "[ ]".
            raise RuntimeError("cannot serialize an empty array: omit the element instead")
        return "[ " + ", ".join(format_value(v, indent) for v in value) + " ]"
    if value is None:
        return "null"
    if isinstance(value, bool):
        return "true" if value else "false"
    if isinstance(value, (int, float)):
        return json.dumps(value)
    return json.dumps(value, ensure_ascii=False)


def span_of_expansion(text):
    """The half-open span of the top-level `expansion` object's value."""
    match = re.search(r'^(\s*)"expansion"\s*:\s*', text, re.MULTILINE)
    if not match:
        raise RuntimeError("no top-level expansion element found")
    start = match.end()
    if text[start] != "{":
        raise RuntimeError("expansion element is not an object")

    depth, i, in_string, escaped = 0, start, False, False
    while i < len(text):
        ch = text[i]
        if in_string:
            if escaped:
                escaped = False
            elif ch == "\\":
                escaped = True
            elif ch == '"':
                in_string = False
        elif ch == '"':
            in_string = True
        elif ch == "{":
            depth += 1
        elif ch == "}":
            depth -= 1
            if depth == 0:
                return start, i + 1, len(match.group(1))
        i += 1
    raise RuntimeError("unterminated expansion element")


def splice(path, text, expansion):
    start, end, indent = span_of_expansion(text)
    rewritten = text[:start] + format_value(expansion, indent) + text[end:]

    # The corpus is checked out with CRLF endings and no BOM; keep it that way rather than
    # leaving one file in the folder different from the other six hundred.
    newline = "\r\n" if "\r\n" in text else "\n"
    body = rewritten.replace("\r\n", "\n").replace("\n", newline)
    with open(path, "wb") as fh:
        fh.write(body.encode("utf-8"))
    return len(body.encode("utf-8"))


# ---------------------------------------------------------------------------------------

def main(argv=None):
    parser = argparse.ArgumentParser(description=__doc__,
                                     formatter_class=argparse.RawDescriptionHelpFormatter)
    parser.add_argument("--value-sets-dir", default=DEFAULT_VALUE_SETS_DIR,
                        help="folder of ValueSet-<oid>.json files (default: the integration runner corpus)")
    parser.add_argument("--api-key-file", help="file holding a UMLS API key, and nothing else")
    parser.add_argument("--oid", action="append", dest="oids",
                        help="complete only this OID (repeatable); default is every partial expansion")
    parser.add_argument("--page-size", type=int, default=1000, help="concepts per request (default 1000)")
    parser.add_argument("--allow-content-drift", action="store_true",
                        help="write even when the code systems have moved since the file was written, "
                             "making this a content refresh rather than a completion; every delta is reported")
    parser.add_argument("--dry-run", action="store_true", help="report what is partial, fetch nothing")
    parser.add_argument("--quiet", action="store_true", help="suppress per-page progress")
    args = parser.parse_args(argv)

    value_sets_dir = os.path.abspath(args.value_sets_dir)
    if not os.path.isdir(value_sets_dir):
        raise SystemExit(f"error: {value_sets_dir} is not a directory")

    partial = find_partial(value_sets_dir, set(args.oids or []))
    print(f"{value_sets_dir}\n{len(partial)} partial expansion(s)\n")
    if not partial:
        return 0

    header = f"{'OID':<42} {'name':<48} {'have':>6} {'total':>6}"
    print(header)
    print("-" * len(header))
    for entry in partial:
        print(f"{entry['oid']:<42} {(entry['name'] or '')[:48]:<48} {entry['have']:>6} {entry['total']:>6}")

    if args.dry_run:
        print("\n--dry-run: nothing fetched")
        return 0

    key = read_api_key(args.api_key_file)
    log = (lambda _m: None) if args.quiet else print

    failures, drifted = [], []
    print()
    for entry in partial:
        label = f"{entry['oid']} ({entry['name']})"
        print(f"  {label}: version {entry['version']}, completing {entry['have']} -> {entry['total']}")
        try:
            expansion = fetch_complete_expansion(entry, key, args.page_size, log)
            text, local_vs = read_value_set(entry["path"])
            problems, drift = validate(entry, expansion, local_vs, args.allow_content_drift)
            if problems:
                failures.append((entry["oid"], "; ".join(problems)))
                print(f"    NOT written: {'; '.join(problems)}")
                continue
            for note in drift:
                print(f"    content drift accepted: {note}")
                drifted.append((entry["oid"], note))
            size = splice(entry["path"], text, expansion)
            print(f"    written: {count_concepts(expansion['contains'])} concepts, {size // 1024} KB")
        except (RuntimeError, OSError) as e:
            failures.append((entry["oid"], str(e)))
            print(f"    failed: {e}")

    print(f"\ncompleted {len(partial) - len(failures)}/{len(partial)}")
    for oid, why in failures:
        print(f"  {oid}: {why}")
    if drifted:
        print(f"\n{len(drifted)} value set(s) refreshed rather than completed:")
        for oid, note in drifted:
            print(f"  {oid}: {note}")
    return 1 if failures else 0


if __name__ == "__main__":
    sys.exit(main())
