library System version '2.0.0'


define public function IsZero(argument System.Decimal) returns System.Boolean:
  external
define public function IsNegative(argument System.Decimal) returns System.Boolean:
  external
define public function Add(left System.Decimal, right System.Decimal) returns System.Decimal: 
  external
define public function Negate(argument System.Decimal) returns System.Decimal: 
  external
define public function ToDecimal(argument System.Integer) returns System.Decimal:
  external
define public function Truncate(argument System.Decimal) returns System.Integer:
  external

define public function Equal(left System.Integer, right System.Integer) returns System.Boolean:
  IsZero(Subtract(ToDecimal(left), ToDecimal(right)))     

define public function GreaterThan(left System.Integer, right System.Integer) returns System.Boolean: 
  And(Not(Equal(left,right)), Not(IsNegative(Subtract(left,right))))

define public function LessThan(left System.Integer, right System.Integer) returns System.Boolean: 
 And(Not(Equal(left,right)), Not(IsNegative(Subtract(right,left))))

define public function Add(left System.Integer, right System.Integer) returns System.Integer: 
  Truncate(Add(ToDecimal(Truncate(left)), ToDecimal(Truncate(right))))

define public function Negate(argument System.Integer) returns System.Integer: 
  Truncate(Negate(ToDecimal(argument)))

define public function ToInteger(argument System.Decimal) returns System.Integer:
  Truncate(argument)


define public function Subtract(left System.Integer, right System.Integer) returns System.Integer:
  Add(left, Negate(right))

define public function Subtract(left System.Decimal, right System.Decimal) returns System.Decimal:
  Add(left, Negate(right))

// The compare function returns less than zero if left is smaller than right, 
// zero if the values are equal, and greater than zero if right is larger than right.
// For boolean values, false is less than true.
define public function Compare(left System.Boolean, right System.Boolean) returns System.Integer:
  Subtract(ToInteger(left), ToInteger(right))

// The compare function returns less than zero if left is smaller than right, 
// zero if the values are equal, and greater than zero if left is larger than right.
define public function Compare(left System.Decimal, right System.Decimal) returns System.Integer:
  ToInteger(Subtract(left, right))

// The equal (=) operator returns true if the arguments are equal; 
// false if the arguments are known unequal, and null otherwise
define public function Equal(left System.Boolean, right System.Boolean) returns System.Boolean:
  Equal(Compare(left,right), 0)

// The equal (=) operator returns true if the arguments are equal; 
// false if the arguments are known unequal, and null otherwise
define public function Equal(left System.Decimal, right System.Decimal) returns System.Boolean:
  Equal(Compare(left,right), 0)


// The and operator returns true if both its arguments are true.
// If either argument is false, the result is false. Otherwise, the result is null. 
define public function And(left System.Boolean, right System.Boolean):
  case
    when Equal(left, true) then right
    when Equal(left, false) then false
    when Equal(right, false) then false 
    else null 
  end

// The implies operator returns the logical implication of its arguments.
// This means that if the left operand evaluates to true,
// this operator returns the boolean evaluation of the right operand.
// If the left operand evaluates to false, this operator returns true.
// Otherwise, this operator returns true if the right operand evaluates to true, and null otherwise.
//
// Note that implies may use short-circuit evaluation in the case that the first operand evaluates to false.     
define public function Implies(left System.Boolean, right System.Boolean):
  case
    when Equal(left, true) then true
    when Equal(left, false) then Not(right)
    when Equal(right, false) then true 
    else null 
  end

// The not operator returns true if the argument is false and false if the argument is true.
// Otherwise, the result is null. 
define public function Not(argument System.Boolean):
  case
    when Equal(argument, true) then false
    when Equal(argument, false) then true 
    else null 
  end

// The or operator returns true if either of its arguments are true.
// If both arguments are false, the result is false. Otherwise, the result is null. 
define public function Or(left System.Boolean, right System.Boolean):
  case
    when Equal(left, true) then true
    when Equal(right, true) then true
    when And(Equal(left, false), Equal(right, false)) then false 
    else null 
  end

// The xor (exclusive or) operator returns true if one argument is true and the other is false. 
// If both arguments are true or both arguments are false, the result is false. 
// Otherwise, the result is null.
define public function Xor(left System.Boolean, right System.Boolean):
  case
    when Equal(left, true) then Not(right)
    when Equal(left, false) then right
    else null 
  end    

// The ToBoolean operator converts the value of its argument to a Boolean value.
// If the input is a Decimal, the result is true if the decimal is 1.0, false if the decimal is 0.0.
define public function ToBoolean(argument Decimal):
  case
    when Equal(argument, 1.0) then true
    when Equal(argument, 0.0) then false
    else null
  end
