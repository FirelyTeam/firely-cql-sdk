library TestCodeSystemInclude version '1.0.0'

using FHIR version '4.0.1'

codesystem "TaskCodeSystem": 'http://hl7.org/fhir/CodeSystem/task-code'

code "Fulfill Task": 'fulfill' from "TaskCodeSystem" display 'Fulfill the focal request'
