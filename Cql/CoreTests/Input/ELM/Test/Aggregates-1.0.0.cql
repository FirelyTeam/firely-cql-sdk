library Aggregates version '1.0.0'

using FHIR version '4.0.1'

define FactorialOfFive:
  from ({ 1, 2, 3, 4, 5 }) Num
    aggregate Result starting 1: Result * Num

define "With where":
  from ({1, 2, 3, 4, 5, 6}) Num
    where Num mod 2 = 0
    aggregate Result starting 1: Result * Num

define "With where and let":
  from ({1, 2, 3, 4, 5, 6}) Num
    let i: 1,
    j: 2
    where Num mod 2 = 0
    aggregate Result starting 1: Result * (Num + i + j)

define "With such that":
  from ({1, 2, 3, 4, 5, 6}) Num
    with ({1,2,3,4}) Num2 such that Num = Num2
    aggregate Result starting 1: Result * Num

define "Multisource query":
  from 
    ({1, 2}) Num1,
    ({1, 2}) Num2
    aggregate Result starting 0: Result + Num1 + Num2