library CqlNullologicalOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "CoalesceANull":
  Coalesce('a', null)= 'a'

define "CoalesceNullA":
  Coalesce(null, 'a')= 'a'

define "CoalesceEmptyList":
  Coalesce({ } as List<Integer>)= ( null as Integer )

define "CoalesceListFirstA":
  Coalesce({ 'a', null, null })= 'a'

define "CoalesceListLastA":
  Coalesce({ null, null, 'a' })= 'a'

define "CoalesceFirstList":
  Coalesce({ 'a' }, null, null)= { 'a' }

define "CoalesceLastList":
  Coalesce(null as List<String>, null as List<String>, { 'a' })= { 'a' }

define "DateTimeCoalesce":
  Coalesce(null as DateTime, null as DateTime, DateTime(2012, 5, 18))= DateTime(2012, 5, 18)

define "DateTimeListCoalesce":
  Coalesce({ null as DateTime, null as DateTime, DateTime(2012, 5, 18)})= DateTime(2012, 5, 18)

define "TimeCoalesce":
  Coalesce(null as Time, null as Time, @T05:15:33.556)= @T05:15:33.556

define "TimeListCoalesce":
  Coalesce({ null as Time, null as Time, @T05:15:33.556 })= @T05:15:33.556

define "IsNullTrue":
  IsNull(null)= true

define "IsNullFalseEmptyString":
  IsNull('')= false

define "IsNullAlsoFalseAbcString":
  IsNull('abc')= false

define "IsNullAlsoFalseNumber1":
  IsNull(1)= false

define "IsNullAlsoFalseNumberZero":
  IsNull(0)= false

define "IsFalseFalse":
  IsFalse(false)= true

define "IsFalseTrue":
  IsFalse(true)= false

define "IsFalseNull":
  IsFalse(null)= false

define "IsTrueTrue":
  IsTrue(true)= true

define "IsTrueFalse":
  IsTrue(false)= false

define "IsTrueNull":
  IsTrue(null)= false