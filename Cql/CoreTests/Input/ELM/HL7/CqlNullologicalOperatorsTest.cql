library CqlNullologicalOperatorsTest

context Unfiltered


define "CoalesceANull Input":
	Coalesce('a', null)
define "CoalesceANull Output":
	'a'

define "CoalesceNullA Input":
	Coalesce(null, 'a')
define "CoalesceNullA Output":
	'a'

define "CoalesceEmptyList Input":
	Coalesce({})
define "CoalesceEmptyList Output":
	null

define "CoalesceListFirstA Input":
	Coalesce({'a', null, null})
define "CoalesceListFirstA Output":
	'a'

define "CoalesceListLastA Input":
	Coalesce({null, null, 'a'})
define "CoalesceListLastA Output":
	'a'

define "CoalesceFirstList Input":
	Coalesce({'a'},null, null)
define "CoalesceFirstList Output":
	{'a'}

define "CoalesceLastList Input":
	Coalesce(null, null, {'a'})
define "CoalesceLastList Output":
	{'a'}

define "DateTimeCoalesce Input":
	Coalesce(null, null, DateTime(2012, 5, 18))
define "DateTimeCoalesce Output":
	DateTime(2012, 5, 18)

define "DateTimeListCoalesce Input":
	Coalesce({ null, null, DateTime(2012, 5, 18) })
define "DateTimeListCoalesce Output":
	DateTime(2012, 5, 18)

define "TimeCoalesce Input":
	Coalesce(null, null, @T05:15:33.556)
define "TimeCoalesce Output":
	@T05:15:33.556

define "TimeListCoalesce Input":
	Coalesce({ null, null, @T05:15:33.556 })
define "TimeListCoalesce Output":
	@T05:15:33.556

define "IsNullTrue Input":
	IsNull(null)
define "IsNullTrue Output":
	true

define "IsNullFalseEmptyString Input":
	IsNull('')
define "IsNullFalseEmptyString Output":
	false

define "IsNullAlsoFalseAbcString Input":
	IsNull('abc')
define "IsNullAlsoFalseAbcString Output":
	false

define "IsNullAlsoFalseNumber1 Input":
	IsNull(1)
define "IsNullAlsoFalseNumber1 Output":
	false

define "IsNullAlsoFalseNumberZero Input":
	IsNull(0)
define "IsNullAlsoFalseNumberZero Output":
	false

define "IsFalseFalse Input":
	IsFalse(false)
define "IsFalseFalse Output":
	true

define "IsFalseTrue Input":
	IsFalse(true)
define "IsFalseTrue Output":
	false

define "IsFalseNull Input":
	IsFalse(null)
define "IsFalseNull Output":
	false

define "IsTrueTrue Input":
	IsTrue(true)
define "IsTrueTrue Output":
	true

define "IsTrueFalse Input":
	IsTrue(false)
define "IsTrueFalse Output":
	false

define "IsTrueNull Input":
	IsTrue(null)
define "IsTrueNull Output":
	false
