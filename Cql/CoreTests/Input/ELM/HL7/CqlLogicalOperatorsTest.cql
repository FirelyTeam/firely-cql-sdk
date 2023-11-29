library CqlLogicalOperatorsTest

context Unfiltered


define "TrueAndTrue Input":
	true and true
define "TrueAndTrue Output":
	true

define "TrueAndFalse Input":
	true and false
define "TrueAndFalse Output":
	false

define "TrueAndNull Input":
	true and null
define "TrueAndNull Output":
	null

define "FalseAndTrue Input":
	false and true
define "FalseAndTrue Output":
	false

define "FalseAndFalse Input":
	false and false
define "FalseAndFalse Output":
	false

define "FalseAndNull Input":
	false and null
define "FalseAndNull Output":
	false

define "NullAndTrue Input":
	null and true
define "NullAndTrue Output":
	null

define "NullAndFalse Input":
	null and false
define "NullAndFalse Output":
	false

define "NullAndNull Input":
	null and null
define "NullAndNull Output":
	null

define "TrueImpliesTrue Input":
	true implies true
define "TrueImpliesTrue Output":
	true

define "TrueImpliesFalse Input":
	true implies false
define "TrueImpliesFalse Output":
	false

define "TrueImpliesNull Input":
	true implies null
define "TrueImpliesNull Output":
	null

define "FalseImpliesTrue Input":
	false implies true
define "FalseImpliesTrue Output":
	true

define "FalseImpliesFalse Input":
	false implies false
define "FalseImpliesFalse Output":
	true

define "FalseImpliesNull Input":
	false implies null
define "FalseImpliesNull Output":
	true

define "NullImpliesTrue Input":
	null implies true
define "NullImpliesTrue Output":
	true

define "NullImpliesFalse Input":
	null implies false
define "NullImpliesFalse Output":
	null

define "NullImpliesNull Input":
	null implies null
define "NullImpliesNull Output":
	null

define "NotTrue Input":
	not true
define "NotTrue Output":
	false

define "NotFalse Input":
	not false
define "NotFalse Output":
	true

define "NotNull Input":
	not null
define "NotNull Output":
	null

define "TrueOrTrue Input":
	true or true
define "TrueOrTrue Output":
	true

define "TrueOrFalse Input":
	true or false
define "TrueOrFalse Output":
	true

define "TrueOrNull Input":
	true or null
define "TrueOrNull Output":
	true

define "FalseOrTrue Input":
	false or true
define "FalseOrTrue Output":
	true

define "FalseOrFalse Input":
	false or false
define "FalseOrFalse Output":
	false

define "FalseOrNull Input":
	false or null
define "FalseOrNull Output":
	null

define "NullOrTrue Input":
	null or true
define "NullOrTrue Output":
	true

define "NullOrFalse Input":
	null or false
define "NullOrFalse Output":
	null

define "NullOrNull Input":
	null or null
define "NullOrNull Output":
	null

define "TrueXorTrue Input":
	true xor true
define "TrueXorTrue Output":
	false

define "TrueXorFalse Input":
	true xor false
define "TrueXorFalse Output":
	true

define "TrueXorNull Input":
	true xor null
define "TrueXorNull Output":
	null

define "FalseXorTrue Input":
	false xor true
define "FalseXorTrue Output":
	true

define "FalseXorFalse Input":
	false xor false
define "FalseXorFalse Output":
	false

define "FalseXorNull Input":
	false xor null
define "FalseXorNull Output":
	null

define "NullXorTrue Input":
	null xor true
define "NullXorTrue Output":
	null

define "NullXorFalse Input":
	null xor false
define "NullXorFalse Output":
	null

define "NullXorNull Input":
	null xor null
define "NullXorNull Output":
	null
