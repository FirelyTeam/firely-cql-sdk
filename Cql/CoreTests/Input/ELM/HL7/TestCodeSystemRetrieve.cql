library TestCodeSystemRetrieve version '1.0.0'

using FHIR version '4.0.1'

include TestCodeSystemInclude version '1.0.0' called Common

context Patient

define "FulfillTasks":
    ["Task": code in Common."Fulfill Task"]
