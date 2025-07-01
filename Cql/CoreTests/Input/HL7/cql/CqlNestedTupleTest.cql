library CqlNestedTupleTest version '1.0.0'

define "Result":
  Tuple{
    status: 'success',
    result: Tuple{
        result1: 'some first result',
        result2: 'some second result'
        }
  }