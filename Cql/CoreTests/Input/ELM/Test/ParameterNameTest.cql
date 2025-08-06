library ParameterNameTest version '1.0.0'

// Function with parameter name containing spaces (single-quoted)
define function "Test Function"('param with spaces' Integer, normalParam String):
  'param with spaces' + 10

// Function with parameter name containing special characters
define function "Another Test"('param-with-dashes' Decimal):
  'param-with-dashes' * 2.0