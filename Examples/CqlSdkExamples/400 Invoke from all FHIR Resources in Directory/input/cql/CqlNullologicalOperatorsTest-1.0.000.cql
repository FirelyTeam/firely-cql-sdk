library CqlNullologicalOperatorsTest version '1.0.000'

define "Coalesce.CoalesceANull": Coalesce('a', null)

define "Coalesce.CoalesceNullA": Coalesce(null, 'a')

define "Coalesce.CoalesceEmptyList": Coalesce({})

define "Coalesce.CoalesceListFirstA": Coalesce({'a', null, null})

define "Coalesce.CoalesceListLastA": Coalesce({null, null, 'a'})

define "Coalesce.CoalesceFirstList": Coalesce({'a'},null, null)

define "Coalesce.CoalesceLastList": Coalesce(null, null, {'a'})

define "Coalesce.DateTimeCoalesce": Coalesce(null, null, DateTime(2012, 5, 18))

define "Coalesce.DateTimeListCoalesce": Coalesce({ null, null, DateTime(2012, 5, 18) })

define "Coalesce.TimeCoalesce": Coalesce(null, null, @T05:15:33.556)

define "Coalesce.TimeListCoalesce": Coalesce({ null, null, @T05:15:33.556 })

define "IsNull.IsNullTrue": IsNull(null)

define "IsNull.IsNullFalseEmptyString": IsNull('')

define "IsNull.IsNullAlsoFalseAbcString": IsNull('abc')

define "IsNull.IsNullAlsoFalseNumber1": IsNull(1)

define "IsNull.IsNullAlsoFalseNumberZero": IsNull(0)

define "IsFalse.IsFalseFalse": IsFalse(false)

define "IsFalse.IsFalseTrue": IsFalse(true)

define "IsFalse.IsFalseNull": IsFalse(null)

define "IsTrue.IsTrueTrue": IsTrue(true)

define "IsTrue.IsTrueFalse": IsTrue(false)

define "IsTrue.IsTrueNull": IsTrue(null)

