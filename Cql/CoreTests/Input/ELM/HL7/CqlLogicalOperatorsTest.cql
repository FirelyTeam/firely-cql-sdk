library CqlLogicalOperatorsTest version '1.0.0'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "TrueAndTrue":
  ( true
      and true
  ) = true

define "TrueAndFalse":
  ( true
      and false
  ) = false

define "TrueAndNull":
  ( true
      and null
  ) = null

define "FalseAndTrue":
  ( false
      and true
  ) = false

define "FalseAndFalse":
  ( false
      and false
  ) = false

define "FalseAndNull":
  ( false
      and null
  ) = false

define "NullAndTrue":
  ( null
      and true
  ) = null

define "NullAndFalse":
  ( null
      and false
  ) = false

define "NullAndNull":
  ( null
      and null
  ) = null

define "NotTrue":
  ( not true ) = false

define "NotFalse":
  ( not false ) = true

define "NotNull":
  ( not null ) = null

define "TrueOrTrue":
  ( true
      or true
  ) = true

define "TrueOrFalse":
  ( true
      or false
  ) = true

define "TrueOrNull":
  ( true
      or null
  ) = true

define "FalseOrTrue":
  ( false
      or true
  ) = true

define "FalseOrFalse":
  ( false
      or false
  ) = false

define "FalseOrNull":
  ( false
      or null
  ) = null

define "NullOrTrue":
  ( null
      or true
  ) = true

define "NullOrFalse":
  ( null
      or false
  ) = null

define "NullOrNull":
  ( null
      or null
  ) = null

define "TrueXorTrue":
  ( true
      xor true
  ) = false

define "TrueXorFalse":
  ( true
      xor false
  ) = true

define "TrueXorNull":
  ( true
      xor null
  ) = null

define "FalseXorTrue":
  ( false
      xor true
  ) = true

define "FalseXorFalse":
  ( false
      xor false
  ) = false

define "FalseXorNull":
  ( false
      xor null
  ) = null

define "NullXorTrue":
  ( null
      xor true
  ) = null

define "NullXorFalse":
  ( null
      xor false
  ) = null

define "NullXorNull":
  ( null
      xor null
  ) = null