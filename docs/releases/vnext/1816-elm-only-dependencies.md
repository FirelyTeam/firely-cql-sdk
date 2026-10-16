## Fixes

- `PackagingToolkit` packages a library whose included libraries are available only as ELM, such as FHIRHelpers loaded
  from its published ELM. Before, `AddPackagingInputs(cqlToolkit, elmToolkit)` dropped every ELM library without
  matching CQL, and `ConvertToFhirResources` skipped each library that included one, logging only a warning. An ELM
  library without CQL is now a reference library: it is not packaged itself, but it resolves the includes of the
  packaged libraries, and its Retrieves count towards their data requirements. The packaged library refers to it by
  canonical in a `depends-on` related artifact. The Packager CLI behaves the same way: an ELM file without a matching
  CQL file no longer causes the libraries that include it to be skipped.
