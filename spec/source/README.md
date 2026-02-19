# Original CQL Specification Files

This directory is **gitignored** and should contain the original HTML specification files downloaded from the official CQL website.

## Purpose

The original spec files (HTML, CSS, JS, images) total ~40MB and are too large to commit to the repository. Instead:

1. **Original files** go here (gitignored)
2. **Condensed markdown** is in `../condensed/` (committed)

## How to Populate

### Option 1: Download Official Spec

Download the CQL specification from:
- https://cql.hl7.org/

Place the extracted files in this directory:
```
spec/source/1.5.3 - Release 1 Errata 2/
├── index.html
└── site/
    ├── 00-executivesummary.html
    ├── 01-introduction.html
    ├── 02-authorsguide.html
    ├── 03-developersguide.html
    ├── 09-b-cqlreference.html
    ├── elm.html
    ├── examples.html
    ├── tests.html
    ├── ... (and many more)
    └── css/, js/, images/ folders
```

### Option 2: Use Condensed Version

If you just need to reference the spec for development, use the condensed markdown version:
```
spec/condensed/*.md
```

This is 97.7% smaller (912KB vs 40MB) and easier for AI agents to parse.

## Regenerating Condensed Spec

If you need to update the condensed markdown files from the original HTML:

1. Place original HTML files in `spec/source/1.5.3 - Release 1 Errata 2/`
2. Run the condensation tool:
   ```bash
   python3 tools/condense_spec/condense_spec.py
   ```
3. The tool will read from `spec/source/` and output to `spec/condensed/`

## Note

The original spec files were removed from git history to reduce repository size. The condensed markdown version provides all necessary information for development and AI analysis.
