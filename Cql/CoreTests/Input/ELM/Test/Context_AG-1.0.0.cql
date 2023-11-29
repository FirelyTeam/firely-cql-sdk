library Context_AG version '1.0.0'
    
using FHIR version '4.0.1'

context Patient

define "In Initial Population":
  AgeInYearsAt(@2013-01-01) >= 16

define "In Initial Population List":
  { "In Initial Population" }

define "Count from Context 1":
  "Initial Population Count 1"

define "Count from Context 2":
  "Initial Population Count 2"

context Unfiltered

define "Initial Population Count 1":
  Count("In Initial Population" IP where IP is true)

define "Initial Population Count 2":
  Count("In Initial Population List" IP where IP is true)