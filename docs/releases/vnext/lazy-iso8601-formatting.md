## Improvements

- `DateTimeIso8601`, `DateIso8601` and `TimeIso8601` no longer build their string representation in
  every constructor: it is now computed lazily on first `ToString()`, and the parse path stores the
  original literal so parse/format round-trips stay byte-identical. Constructing a `CqlDateTime` went
  from 1232 ns / 2864 B to 545 ns / 792 B, and a 900-measure CMS evaluation run allocates roughly
  66 MB (~10%) less in total (#1478).
