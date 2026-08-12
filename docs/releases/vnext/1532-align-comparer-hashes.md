## Potentially Breaking

- `Distinct`, `Union`, and `Except` now deduplicate values consistently with CQL equality for
  previously inconsistent edge cases where comparers normalized for equality but hashed raw forms:
  Unicode-normalization-equivalent strings, decimals equal after CQL's 8-digit truncation, boundary-
  equivalent intervals, and tuples containing those values. This can change observable grouping
  results by collapsing items that were incorrectly kept separate before. (#1328)
