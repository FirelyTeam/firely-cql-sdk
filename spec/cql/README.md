# CQL Specification (Condensed)

- **Source:** https://cql.hl7.org/
- **Spec version:** 1.5.3 - Release 1 Errata 2
- **Condensed by:** `tools/condense_spec/condense_spec.py`
- **Files converted:** 23
- **Size reduction:** 2,055,180 -> 873,655 bytes (57.5% smaller); 40MB -> 912KB (97.7%) counting the
  original site's CSS/JS/images

`source/` (gitignored) holds the original HTML site export, only needed to regenerate `condensed/`
after a new CQL spec errata/version is published — day-to-day, just read the files below directly.

## Files

- `condensed/00-executivesummary.md` — Executive Summary
- `condensed/01-introduction.md` — Introduction
- `condensed/02-authorsguide.md` — CQL Author's Guide
- `condensed/03-developersguide.md` — CQL Developer's Guide
- `condensed/04-logicalspecification.md` — Logical Specification
- `condensed/05-languagesemantics.md` — Language Semantics
- `condensed/06-translationsemantics.md` — Translation Semantics
- `condensed/07-physicalrepresentation.md` — Physical Representation
- `condensed/08-a-cqlsyntax.md` — Appendix A: CQL Syntax Formal Specification
- `condensed/09-b-cqlreference.md` — Appendix B: CQL Reference
- `condensed/10-c-referenceimplementations.md` — Appendix C: Reference Implementations
- `condensed/11-d-references.md` — Appendix D: References
- `condensed/12-e-acronyms.md` — Appendix E: Acronyms
- `condensed/13-f-glossary.md` — Appendix F: Glossary
- `condensed/14-g-formattingconventions.md` — Appendix G: Formatting Conventions
- `condensed/15-h-timeintervalcalculations.md` — Appendix H: Time Interval Calculation Examples
- `condensed/16-i-fhirpathtranslation.md` — Appendix I: FHIRPath Function Translation
- `condensed/17-j-listoftables.md` — Appendix J: List of Tables
- `condensed/18-k-listoffigures.md` — Appendix K: List of Figures
- `condensed/19-l-cqlsyntaxdiagrams.md` — Appendix L: CQL Syntax Diagrams
- `condensed/elm.md` — ELM (Expression Logical Model)
- `condensed/examples.md` — Examples
- `condensed/tests.md` — Tests

## Regenerating after a spec update

1. Download the new spec site export from https://cql.hl7.org/ and place it at
   `spec/cql/source/<version>/site/` (e.g. `spec/cql/source/1.5.4/site/`).
2. Update `CQL_SPEC_VERSION` in `tools/condense_spec/condense_spec.py` to match.
3. Run:
   ```bash
   python3 tools/condense_spec/condense_spec.py
   ```
4. Diff `spec/cql/condensed/` to review what changed, and this file will be rewritten with the
   new version/stats/file list automatically.
