model System version '2.0.0' : 'urn:hl7-org:elm-types:r2'

define literal type Any

define literal type Boolean extends Any

define type Code extends Any {
	system String,
	code String,
	version String,
	display String
 }

define literal type CodeSystem extends Vocabulary

define type Concept extends Any {
	display String,
	codes List<System.Code>
 }

define literal type Date extends Any

define literal type DateTime extends Any

define literal type Decimal extends Any

define literal type Integer extends Any

define generic type Interval<T> extends Any
	where T is Choice<Integer,Long,Decimal,Quantity,DateTime,Date,Time>
 {
	lowClosed Boolean,
	low T,
	highClosed Boolean,
	high T
 }

define generic type List<T> extends Any
	where T is Any {}

define literal type Long extends Any

define type Quantity extends Any {
	value Decimal,
	unit String
 }

define type Ratio extends Any {
	numerator Quantity,
	denominator Quantity
 }

define literal type String extends Any

define literal type Time extends Any

define literal type ValueSet extends Vocabulary

define type Vocabulary extends Any {
	id String,
	version String
 }

 /*
  * These functions are the basis of several other arithmetic operations and cannot be expressed purely in CQL.
 */

define public function IsZero(argument System.Decimal) returns System.Boolean:
  external

define public function IsNegative(argument System.Decimal) returns System.Boolean:
  external

define public function ChangeUnit(value System.Decimal, fromUnit System.String, toUnit System.String) returns System.Decimal:
  external


/*
* Computes the resulting unit from dividing the numerator unit by the denominator unit.
* For example, 'cm2' divided by 'cm' produces 'cm'.
*/
define public function DivideUnit(numerator System.String, denominator System.String) returns System.String:
  external

/* Computes the resulting unit from multiplying the left unit by the right unit.
 * For example, 'cm' multiplied by 'cm' produces 'cm2'.  Incompatible compuations return null.
 */
define public function MultiplyUnit(left System.String, right System.String) returns System.String:
  external

define public function CompareUnit(left System.String, right System.String) returns System.Integer:
  external

