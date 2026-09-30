## Fixes

- `overlaps`, `overlaps before`, `overlaps after`, `meets`, `meets before` and `meets after` return `null` when the result depends on a boundary comparison that is uncertain, that is, between Date, DateTime or Time boundaries of different precision that agree at the coarser one. They returned `false` for such a comparison. A comparison the other boundary settles is still decided: `Interval[@2012, @2013-03] overlaps Interval[@2012-02, @2013-02]` stays `true`, and intervals that are definitely apart stay `false`. For example, `Interval[@2012-01-25, @2012-02-26] overlaps Interval[@2012-02, @2012-03-28]` is `null`. (#1689)

This changes CQL evaluation results for the affected expressions.
