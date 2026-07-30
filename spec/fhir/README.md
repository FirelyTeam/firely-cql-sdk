# FHIR Specification (Condensed)

- **Baseline version:** R4 (see `Cql/Cql.Model/Models/fhir-modelinfo-4.0.1.xml`)
- **Condensed by:** `tools/condense_spec/fetch_fhir_page.py`

Unlike the CQL spec, this isn't vendored wholesale — only specific pages needed for
development are fetched on demand. Individual pages can belong to different FHIR versions
or implementation guides; this table is per-page ground truth.

## Pages

| URL | Last fetched | File |
|---|---|---|
| https://build.fhir.org/ig/HL7/cqf-measures/measure-conformance.html | 2026-07-21 | `ig-hl7-cqf-measures-measure-conformance.md` |
| https://hl7.org/fhir/R4/library-definitions.html | 2026-07-21 | `fhir-r4-library-definitions.md` |
| https://hl7.org/fhir/R4/measure-definitions.html | 2026-07-21 | `fhir-r4-measure-definitions.md` |
| https://hl7.org/fhir/uv/cql/conformance.html | 2026-07-24 | `fhir-uv-cql-conformance.md` |

## Adding or refreshing a page

```bash
python3 tools/condense_spec/fetch_fhir_page.py <url> [<url> ...]
```

Re-running against an already-tracked URL refreshes its row and file in place.
