library Context_AG version '1.0.0'
    
using FHIR version '4.0.1'

include cq_core.FHIRHelpers version '4.0.1' called FHIRHelpers

context Patient

define "InInitialPopulation":
  AgeInYearsAt(@2013-01-01) >= 16 and AgeInYearsAt(@2013-01-01) < 24

context Unfiltered

define "InitialPopulationCount":
  Count(InInitialPopulation IP where IP is true)