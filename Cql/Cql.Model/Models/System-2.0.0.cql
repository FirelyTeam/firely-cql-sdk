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

 
 // Type operators


 define public function ToInteger(argument Boolean) returns Integer: if argument = true then 1 else 0
 define public explicit conversion from Boolean b to Integer: ToInteger(b)
 
 define public function Add(left Decimal, right Decimal) returns Integer: external
 define public operator+(left Decimal, right Decimal) returns Integer: Add(left,right)
