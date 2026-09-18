## Potentially Breaking

- **CQL-to-ELM translator:** calling `"Interval"(low, high, lowClosed, highClosed)` through the quoted
  identifier with non-literal closed arguments is now a translation error, as it is in the reference
  translator. CQL defines no `Interval` function; the `Interval[...]` selector carries closedness in its
  bracket characters and always emits Boolean literals, so it is unaffected. Libraries using the quoted
  form with non-literal closed arguments were silently getting the wrong interval: both closed
  expressions were populated from the third argument, so the upper bound's closedness was governed by
  the lower bound's expression. That index is corrected as well, but the call no longer translates, so
  the fix is not observable. (#1616)
