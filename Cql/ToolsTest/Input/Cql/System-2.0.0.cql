library System version '2.0.0'

context Unfiltered

define public function IsZero(argument System.Decimal) returns System.Boolean:
  external

define public function IsNegative(argument System.Decimal) returns System.Boolean:
  external

define public function ChangeUnit(value System.Decimal, fromUnit System.String, toUnit System.String) returns System.Decimal:
  external
// Computes the resulting unit from dividing the numerator unit by the denominator unit.
// For example, 'cm2' divided by 'cm' produces 'cm'.
define public function DivideUnit(numerator System.String, denominator System.String) returns System.String:
  external
// Computes the resulting unit from multiplying the numerator unit by the denominator unit.
// For example, 'cm2' divided by 'cm' produces 'cm'.  
define public function MultiplyUnit(numerator System.String, denominator System.String) returns System.String:
  external

define public function CompareUnit(left System.String, right System.String) returns System.Integer:
  external


// ----------------------------------------------------------------------------

/* 
 * The Abs operator returns the absolute value of its argument.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#abs
*/ 
define public function Abs(argument System.Integer) returns System.Integer:
  Truncate(Abs(ToDecimal(argument)))

/* 
 * The Abs operator returns the absolute value of its argument.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#abs
*/ 
define public function Abs(argument System.Long) returns System.Long:
  TruncateLong(Abs(ToDecimal(argument)))

/* 
 * The Abs operator returns the absolute value of its argument.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#abs
*/ 
define public function Abs(argument System.Decimal) returns System.Decimal:
  case
    when IsNegative(argument) then 
      Negate(argument)
    else 
      argument
  end

/* 
 * The Abs operator returns the absolute value of its argument.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#abs
*/ 
define public function Abs(argument System.Quantity) returns System.Quantity:
  case 
    when IsNull(argument) then null
    else System.Quantity { value: Abs(argument.value), unit: argument.unit }
  end

// ----------------------------------------------------------------------------

/* 
 * The add (+) operator performs numeric addition of its arguments.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#add
*/
define public function Add(left System.Decimal, right System.Decimal) returns System.Decimal: 
  external

/* 
 * The add (+) operator performs numeric addition of its arguments.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#add
*/
define public function Add(left System.Integer, right System.Integer) returns System.Integer: 
  Truncate(Add(ToDecimal(left), ToDecimal(right)))

/* 
 * The add (+) operator performs numeric addition of its arguments.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#add
*/
define public function Add(left System.Long, right System.Long) returns System.Long: 
  TruncateLong(Add(ToDecimal(left), ToDecimal(right))) 

/*
 * The add (+) operator performs numeric addition of its arguments.
 * When adding quantities, the dimensions of each quantity must be the same, but not necessarily the unit. 
 * For example, units of 'cm' and 'm' can be added, but units of 'cm2' and 'cm' cannot. 
 * The unit of the result will be the most granular unit of either input. 
 * Attempting to operate on quantities with invalid units will result in a null. 
 * When a quantity has no units specified, it is treated as a quantity with the default unit ('1').
 * @see: https://cql.hl7.org/09-b-cqlreference.html#add
*/
define public function Add(left System.Quantity, right System.Quantity) returns System.Quantity:
  case 
    when Or(IsNull(left), IsNull(right)) then 
      null
    when left.unit = right.unit then 
      System.Quantity { value: Add(left.value,right.value), unit: left. unit }
    when LessThan(CompareUnit(left.unit, right.unit), 0) then 
      System.Quantity { value: Add(left.value,ChangeUnit(right.value, right.unit, left.unit)), unit: left.unit }
    else 
      System.Quantity { value: Add(ChangeUnit(left.value, left.unit, right.unit), right.value), unit: right.unit }
  end

// ----------------------------------------------------------------------------

/*
 * The Ceiling operator returns the first integer greater than or equal to the argument.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#ceiling
*/
define public function Ceiling(argument System.Decimal) returns System.Integer:
  case 
      when IsNull(argument) then null
      when IsNegative(argument) then Truncate(argument)
      when Equal(ToDecimal(Truncate(argument)), argument) then Truncate(argument)
      else Truncate(Add(argument,1))
  end

// ----------------------------------------------------------------------------

define public function Coalesce(argument1 System.Any, argument2 System.Any) returns System.Any:
  case
    when IsNull(argument1) then argument2
    else argument1
  end


// ----------------------------------------------------------------------------

define public function Combine(source List<System.String>) returns System.String:
  from (source) s
    aggregate result starting '': Concatenate(result, s)


// ----------------------------------------------------------------------------


/*
 * Helper function for extracting a component from a date.
*/
define private function dateComponent(parts List<System.String>, precision System.String) returns System.Integer:
  case
    when Equal(precision, 'year') then ToInteger(parts[0])
    when Equal(precision, 'month') then ToInteger(parts[1])
    else ToInteger(parts[2])
  end


define public function Component(date System.Date, precision System.String) returns System.Integer:
  dateComponent(Split(ToString(date), '-'), precision)

define private function timeComponent(parts List<System.String>, precision System.String) returns System.Integer:
  case
    when Equal(precision, 'hour') then ToInteger(parts[0])
    when Equal(precision, 'minute') then ToInteger(parts[1])
    when Equal(precision, 'second') then ToInteger(parts[2])
    else ToInteger(parts[3])
  end

define public function Component(time System.Time, precision System.String) returns System.Integer:
  timeComponent(Split(ToString(time), ':'), precision)

// ----------------------------------------------------------------------------

define public function DateFrom(argument System.DateTime) returns System.Date:
  ToDate(Split(ToString(argument), 'T')[0])

// ----------------------------------------------------------------------------

/* 
 * The divide (/) operator performs numeric division of its arguments. 
 * Note that this operator is Decimal division; for Integer division, use the truncated divide (div) operator.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#divide
*/
define public function Divide(left System.Decimal, right System.Decimal) returns System.Decimal: 
  external

/*
 * The divide (/) operator performs numeric division of its arguments. 
 * For division operations involving quantities, the resulting quantity will have the appropriate unit. 
 * For example:
 * 12 'cm2' / 3 'cm'
 * In this example, the result will have a unit of 'cm'. Note that when performing division of quantities with the same units,
 * the result will have the default UCUM unit ('1'). 
 * When a quantity has no units specified, it is treated as a quantity with the default unit ('1').
 * @see: https://cql.hl7.org/09-b-cqlreference.html#divide
*/
define public function Divide(left System.Quantity, right System.Quantity) returns System.Quantity: 
  case 
    when Or(IsNull(left), IsNull(right)) then 
      null
    else 
      System.Quantity { value: Divide(left.value, right.value), unit: DivideUnit(left.unit, right.unit) }
  end



// ----------------------------------------------------------------------------

/*
 * The Exp operator raises e to the power of its argument.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#exp
*/ 
define public function Exp(argument System.Decimal) returns System.Decimal:
  external

// ----------------------------------------------------------------------------

/*
 * Expands the argument into a list containing the points in the interval with the specified quantity between them.
 * For example, expanding the interval [1, 10] per 2 will result in { 1, 3, 5, 7, 9 }.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#exp
*/ 
define public function Expand(argument Interval<System.Decimal>, "per" System.Quantity) returns List<System.Decimal>:
  external

// ----------------------------------------------------------------------------

/*
 * The Floor operator returns the first integer less than or equal to the argument.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#floor
*/ 
define public function Floor(argument System.Decimal) returns System.Integer:
  case
    when IsNull(argument) then null
    when Equal(ToDecimal(Truncate(argument)), argument) then Truncate(argument)
    when IsNegative(argument) then Truncate(Subtract(argument,1))
    else Truncate(argument)
  end

// ----------------------------------------------------------------------------

/*
 * The HighBoundary function returns the greatest possible value of the input to the specified precision.
 * If no precision is null, then the precision will be assumed to be 8.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#highboundary
*/ 
define public function HighBoundary(input System.Decimal, precision Integer) returns System.Decimal:
case
  when IsNegative(precision) then 
    null
  when IsNull(precision) then
    case 
      when Precision(input) < 8 then
        Add(input, Subtract(Power(10.0, Negate(Precision(input))), Power(10.0, Negate(8.0))))
      else input
    end
  else
      case 
      when Precision(input) < precision then
        Add(input, Subtract(Power(10.0, Negate(Precision(input))), Power(10.0, Negate(precision))))
      else input
    end
end

define public function HighBoundary(input System.Date, precision Integer) returns System.Date:
  case
    when Or(IsNull(precision), Equal(precision, 8)) then
      case
        when Equal(Component(input, 'month'), 4) then
          Date(Component(input, 'year'), Coalesce(Component(input, 'month'), 12), 30)
        when Equal(Component(input, 'month'), 6) then
          Date(Component(input, 'year'), Coalesce(Component(input, 'month'), 12), 30)
        when Equal(Component(input, 'month'), 9) then
          Date(Component(input, 'year'), Coalesce(Component(input, 'month'), 12), 30)
        when Equal(Component(input, 'month'), 11) then
          Date(Component(input, 'year'), Coalesce(Component(input, 'month'), 12), 30)
        when Equal(Component(input, 'month'), 2) then
          case
            when Equal(Modulo(Component(input, 'year'), 4), 0) then
              Date(Component(input, 'year'), Coalesce(Component(input, 'month'), 12), 29)
            else
              Date(Component(input, 'year'), Coalesce(Component(input, 'month'), 12), 28)
          end
        else
          Date(Component(input, 'year'), Coalesce(Component(input, 'month'), 12), 31)
      end
    when Equal(precision, 6) then
      Date(Component(input, 'year'), 12)
    else
      Date(9999)
  end


define public function HighBoundary(input System.DateTime, precision Integer) returns System.DateTime:
  null as System.DateTime

define public function HighBoundary(input System.Time, precision Integer) returns System.Time:
  case
    when Or(IsNull(precision), Equal(precision,9)) then
      Time(Component(input, 'hour'), 
        Coalesce(Component(input, 'minute'), 59), 
        Coalesce(Component(input, 'second'), 59), 
        999)
    when Equal(precision, 6) then
      Time(Component(input, 'hour'), Coalesce(Component(input, 'minute'), 59), 59, 999)    
    when Equal(precision, 4) then
      Time(Component(input, 'hour'), 59, 59, 999)    
    else Time(23,59,59,999)
  end

// ----------------------------------------------------------------------------

define public function IsNull(argument System.Any) returns System.Boolean:
  external

// ----------------------------------------------------------------------------

define public function Length(argument System.String) returns System.Integer:
  external

// ----------------------------------------------------------------------------


define public function Multiply(left System.Decimal, right System.Decimal) returns System.Decimal: 
  external

// ----------------------------------------------------------------------------

/*
 * The Precision function returns the number of digits of precision in the input value.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#precision
*/
define public function Precision(argument System.Decimal) returns System.Integer:
  Length(Split(ToString(argument), '\\.')[1])


// ----------------------------------------------------------------------------


define public function Power(argument System.Decimal, exponent System.Decimal) returns System.Decimal:
  case 
    when Or(IsNull(argument), IsNull(exponent)) then null as System.Decimal
    when Equal(exponent, 0) then 1.0
    when IsNegative(exponent) then
      from (from (Expand(Interval[1,Abs(exponent)], 1 '1')) _ return argument) a
        aggregate Result starting 1: Divide(Result,a)
    else 
      from (from (Expand(Interval[1,exponent], 1 '1')) _ return argument) a
        aggregate Result starting 1: Multiply(Result,a)
  end

// ----------------------------------------------------------------------------

define public function Round(argument System.Decimal) returns System.Decimal:
  ToDecimal(Truncate(Add(argument, 0.5)))

define public function Round(argument System.Decimal, precision Integer) returns System.Decimal:
  Divide(Round(Multiply(argument, Power(10, precision))), Power(10, precision))

// ----------------------------------------------------------------------------

define public function Split(stringToSplit System.String, separator System.String) 
  returns List<System.String>:
  SplitOnMatches(stringToSplit, separator)

/* 
 * The SplitOnMatches operator splits a string into a list of strings 
 * using a separator that is defined by a regular expression pattern.
 * If the stringToSplit argument is null, the result is null.
 * If the stringToSplit argument does not contain any matches for the separatorPattern, 
 * the result is a list of strings containing one element 
 * that is the value of the stringToSplit argument.
 * @see: https://cql.hl7.org/09-b-cqlreference.html#splitonmatches
*/ 
define public function SplitOnMatches(stringToSplit System.String, 
  separatorPattern System.String) returns List<System.String>:
  external
    

// ----------------------------------------------------------------------------

define public function Substring(stringToSub System.String, 
  startIndex System.Integer, length System.Integer) returns System.String:
  Combine(from (Expand(Interval[ToDecimal(startIndex), ToDecimal(Add(startIndex,length))], 1 '1')) index
    return stringToSub[Truncate(index)])

define public function Substring(stringToSub System.String, 
  startIndex System.Integer) returns System.String:
  Substring(stringToSub, startIndex, Subtract(Length(stringToSub), startIndex))



// ----------------------------------------------------------------------------

define public function TimeFrom(argument System.DateTime) returns System.Time:
  ToTime(Split(ToString(argument), 'T')[1])

// ----------------------------------------------------------------------------

define private function toDate(parts List<System.String>) returns System.Date:
  Date(ToInteger(parts[0]), ToInteger(parts[1]), ToInteger(parts[2]))

define public function ToDate(argument System.String) returns System.Date:
  toDate(Split(argument, '-'))

// ----------------------------------------------------------------------------


define public function ToDecimal(argument System.Integer) returns System.Decimal:
  external
define public function ToDecimal(argument System.Long) returns System.Decimal:
  external

// ----------------------------------------------------------------------------

define public function ToString(argument System.Decimal) returns System.String:
  external

// ----------------------------------------------------------------------------

define private function toTime(parts List<System.String>) returns System.Time:
  Time(ToInteger(parts[0]), 
    ToInteger(parts[1]), 
    ToInteger(Split(parts[2], '\\.')[0]),
    ToInteger(Split(parts[2], '\\.')[1])
  )

define public function ToTime(argument System.String) returns System.Time:
  case 
    // TODO: add regex validation to handle bad times
    when true then 
      toTime(Split(Substring(argument,1), ':'))
    else null
  end

// ----------------------------------------------------------------------------



define public function Truncate(argument System.Decimal) returns System.Integer:
  external
define public function TruncateLong(argument System.Decimal) returns System.Long:
 external

define public function Equal(left System.Integer, right System.Integer) returns System.Boolean:
  IsZero(Subtract(ToDecimal(left), ToDecimal(right)))     

define public function GreaterThan(left System.Integer, right System.Integer) returns System.Boolean: 
  And(Not(Equal(left,right)), Not(IsNegative(Subtract(left,right))))

define public function LessThan(left System.Integer, right System.Integer) returns System.Boolean: 
 And(Not(Equal(left,right)), Not(IsNegative(Subtract(right,left))))

define public function Negate(argument System.Decimal) returns System.Decimal: 
  argument * -1

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
  case
    when IsZero(Subtract(left,right)) then 0
    when IsNegative(Subtract(left, right)) then Truncate(Subtract(Subtract(left, right), 1))
    else Truncate(Add(Subtract(left,right),1))
  end

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
