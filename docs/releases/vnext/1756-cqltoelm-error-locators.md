## Fixes

- Every `CqlToElmError` the CQL-to-ELM translator emits now carries `startLine`, `startChar`, `endLine` and
  `endChar`: an error takes the position of the node it is reported on, whether the error or the node's locator is
  set first, and an error on a node that has no locator of its own takes the closest enclosing one. Library-level
  errors (such as a duplicate definition name) take the position of the offending definition. (#1725)
- The translator's `locator` strings now follow the reference translator's convention: characters are 1-based, the
  span runs from the first character of the first token through the last character of the last token, and a
  single-character span is written `line:char`. Previously the start was 0-based and the end was the start of the
  last token. The year, month, day, time and timezone parts of date, date/time and time literals now carry the exact
  span of that part within the literal. (#1725)
