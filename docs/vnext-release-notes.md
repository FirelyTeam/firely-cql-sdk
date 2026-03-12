# vNext Release Notes

## Breaking Changes

### CQL Packager: File logging is no longer enabled by default

Previously, the CQL Packager always wrote log output to a file named `build.log` in the current working directory.

**New behavior:** File logging is disabled by default. To enable file logging, specify the log file path using the new `--log-file` CLI argument.

#### Migration

Before:
```shell
cql-package elm --elm input/elm --fhir output/fhir
# Previously, this would always write logs to ./build.log
```

After:
```shell
# No file logging (new default behavior):
cql-package elm --elm input/elm --fhir output/fhir

# To log to a file, specify --log-file:
cql-package elm --elm input/elm --fhir output/fhir --log-file build.log
```

#### New `--log-file` CLI Argument

A new `--log-file <path>` argument has been added to all commands. It specifies the path of the log file. If this argument is not provided, no file logging is performed.

The existing `--log-append` and `--file-log-level` arguments continue to work as before, but are only relevant when `--log-file` is specified.
