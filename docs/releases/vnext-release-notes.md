# vNext Release Notes

## Breaking Changes

## Features

## Fixes

- `Expand` no longer hangs in an infinite loop with unbounded memory growth when the `per` quantity cannot advance the expansion. A `per` value of zero or less (e.g. `expand { Interval[1, 10] } per 0`, `per -1`, `per 0 days`) now returns `null` from every `Expand` overload — numeric and Date/DateTime/Time, both the list and single-interval forms — instead of looping forever. A fractional `per` over an interval of `Integer` or `Long` (e.g. `expand { Interval[10, 10] } per 0.1`) previously truncated the step to an integer, hanging for values below 1 and silently producing wrong interval widths otherwise; it now throws `NotSupportedException`, because per the CQL specification the result would have to be a list of `Decimal` intervals, which the `Integer`/`Long`-typed overload cannot represent (#1412).
