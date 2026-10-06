## Fixes

- The CQL-to-ELM translator no longer terminates translation of a library with an
  `ArgumentException` when a generic system function such as `Coalesce` is called with arguments
  typed `Any`, or a list or interval of `Any`, that leave its type parameter unbound. The
  parameter is bound to `Any`, the call is typed `Any`, and translation continues, reporting the
  errors upstream of the call that made the arguments `Any` in the first place. (#1798)
