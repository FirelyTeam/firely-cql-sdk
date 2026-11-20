## Performance

- **Runtime** — The result of `sort by` (`SortBy`) and `sort` (`ListSort`) reads its source once and sorts once, on its
  first enumeration, and returns the same list on every later one. `SortBy` built a deferred query that read the source
  twice, called the sort key three times per element and sorted again on every enumeration. `collapse` reads its input
  once; it read a deferred input three times. For `collapse (X i sort by low)` that read `X` six times, called the sort
  key eight times per element and sorted twice; each now happens once. CQL results are unchanged. Two things a host can
  observe: `ListSort` sorted the elements that are not null when it was called and does so on the first enumeration, as
  `SortBy` already did, so an error in a comparison surfaces there; and a change made to the source list after the first
  enumeration does not show in later ones. (#1893)
