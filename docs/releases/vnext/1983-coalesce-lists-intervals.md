## Potentially Breaking

- **CQL to ELM translation** — `Coalesce` over lists and intervals translates as the Java translator translates it.
  `Coalesce({1, 2}, {3})` and `Coalesce(Interval[1, 2], Interval[3, 4])` resolve to the binary overload, typed
  `List<Integer>` and `Interval<Integer>`, where they were reported as unresolved before. A single list argument,
  `Coalesce({ null, 1 })`, still takes the element type. When one overload binds a generic parameter only to `Any`
  because some arguments are the `null` literal, and another binds it to an actual type, the actual type now wins:
  `Coalesce({1}, null, {2})` is typed `List<Integer>` where it was `Any`, and `Coalesce` of two lists or intervals
  of `Any` is typed `List<Any>` or `Interval<Any>`. An argument typed `Any` that may hold a value keeps the call
  typed `Any`, as before. ELM for libraries using these forms changes accordingly. (#1673, #1983)

## Fixes

- **CQL to ELM translation** — Converting an interval to another point type, such as `Interval<Integer>` to
  `Interval<Decimal>`, now keeps a null interval null. Before, it produced an interval with null boundaries, so
  `Coalesce(null as Interval<Integer>, Interval[3.0, 4.0])` returned that interval instead of `Interval[3.0, 4.0]`.
  The converted expression is wrapped in a null check unless it is an interval selector. The Java translator emits
  the conversion without that check. (#1983)
