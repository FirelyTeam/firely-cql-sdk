library TestCodeSystemConceptRetrieve version '1.0.0'

using FHIR version '4.0.1'

include TestCodeSystemInclude version '1.0.0' called Common

concept "Fulfill Task Concept": { Common."Fulfill Task" } display 'Fulfill Task Concept'

context Patient

define "FulfillTasksViaConcept":
    ["Task": code in "Fulfill Task Concept"]
