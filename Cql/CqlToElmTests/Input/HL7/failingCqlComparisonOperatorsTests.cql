library failingCqlComparisonOperatorsTests

context Unfiltered


define "QuantityEqCM1M01 Input":
	(1'cm' = 0.01'm')
define "QuantityEqCM1M01 Output":
	true

define "GreaterM1CM1 Input":
	(1'm' > 1'cm')
define "GreaterM1CM1 Output":
	true

define "GreaterM1CM10 Input":
	(1'm' > 10'cm')
define "GreaterM1CM10 Output":
	true

define "GreaterOrEqualM1CM1 Input":
	1'm' >= 1'cm'
define "GreaterOrEqualM1CM1 Output":
	true

define "GreaterOrEqualM1CM10 Input":
	(1'm' >= 10'cm')
define "GreaterOrEqualM1CM10 Output":
	true

define "LessM1CM1 Input":
	(1'm' < 1'cm')
define "LessM1CM1 Output":
	false

define "LessM1CM10 Input":
	(1'm' < 10'cm')
define "LessM1CM10 Output":
	false

define "LessOrEqualM1CM1 Input":
	1'm' <= 1'cm'
define "LessOrEqualM1CM1 Output":
	false

define "LessOrEqualM1CM10 Input":
	(1'm' <= 10'cm')
define "LessOrEqualM1CM10 Output":
	false

define "EquivEqCM1M01 Input":
	1'cm' ~ 0.01'm'
define "EquivEqCM1M01 Output":
	true

define "QuantityNotEqCM1M01 Input":
	(1'cm' != 0.01'm')
define "QuantityNotEqCM1M01 Output":
	false
