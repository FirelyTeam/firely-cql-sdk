## Potentially Breaking

- **CQL to ELM translation** — `Coalesce` over lists and intervals translates as the Java translator translates it.
  `Coalesce({1, 2}, {3})` and `Coalesce(Interval[1, 2], Interval[3, 4])` resolve to the binary overload, typed
  `List<Integer>` and `Interval<Integer>`, where they were reported as unresolved before. A single list argument,
  `Coalesce({ null, 1 })`, still takes the element type. When one overload binds a generic parameter only to `Any`,
  because the arguments it infers from are null or typed `Any`, and another binds it to an actual type, the actual
  type now wins: `Coalesce({1}, null, {2})` is typed `List<Integer>` where it was `Any`, and `Coalesce` of two
  lists or intervals of `Any` is typed `List<Any>` or `Interval<Any>`. ELM for libraries using these forms changes
  accordingly. (#1673, #1983)
