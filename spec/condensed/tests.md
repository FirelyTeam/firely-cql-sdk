Publication Build: This will be filled in by the publication tooling

## Tests
*Page standards status: *Informative Maturity Level : N/A

The following contains a zip file that contains a set of unit tests for Clinical Quality Language functionality.

The tests are expressed in a simple XML format describing the expression and its expected outcome.

Some tests cover functionality related to calculation and string representation of times, and are built to be run with an *evaluation request timestamp *in UTC, to avoid introducing any location dependence to the tests.

The XML Schema for these tests is included in the zip.

This is the same test format used by the FHIRPath specification.

Test Source

The tests cover the following sections of the specification:
- Aggregate Functions
- Aggregate Operator
- Arithmetic Functions
- Comparison Operators
- Conditional Operators
- Date/Time Operators
- Errors And Messaging Operators
- Interval Operators
- List Operators
- Logical Operators
- Nullological Operators
- String Operators
- Type Operators
- Types
- Value Literals and Selectors
>

The tests defined here are informative, not normative aspects of the specification. If there is a discrepancy between the behavior of a test and the specification, the specification should be considered the source of truth.