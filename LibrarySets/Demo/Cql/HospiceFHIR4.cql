library HospiceFHIR4 version '2.3.000'

using FHIR version '4.0.1'

include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global
include FHIRHelpers version '4.0.001' called FHIRHelpers

codesystem "SNOMEDCT:2017-09": 'http://snomed.info/sct' version 'http://snomed.info/sct/version/201709'

valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307' 
valueset "Hospice care ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.15' 

code "Discharge to healthcare facility for hospice care (procedure)": '428371000124100' from "SNOMEDCT:2017-09" display 'Discharge to healthcare facility for hospice care (procedure)'
code "Discharge to home for hospice care (procedure)": '428361000124107' from "SNOMEDCT:2017-09" display 'Discharge to home for hospice care (procedure)'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Has Hospice":
  exists (
                [Encounter: "Encounter Inpatient"] DischargeHospice
            			where DischargeHospice.status = 'finished'
            		    and (
            	        DischargeHospice.hospitalization.dischargeDisposition ~ "Discharge to home for hospice care (procedure)"
            				    or DischargeHospice.hospitalization.dischargeDisposition ~ "Discharge to healthcare facility for hospice care (procedure)"
            	    	)
            				and Global."Normalize Interval"(DischargeHospice.period) ends during "Measurement Period"
            	)
                or exists (
                  [ServiceRequest: "Hospice care ambulatory"] HospiceOrder
                    where HospiceOrder.status in {'active', 'completed'} 
                    and HospiceOrder.intent = 'order'
                        and Global."Normalize Interval"(HospiceOrder.authoredOn) during "Measurement Period"
                )
                or exists (
                  [Procedure: "Hospice care ambulatory"] HospicePerformed
                    where HospicePerformed.status = 'completed'
                      and Global."Normalize Interval"(HospicePerformed.performed) overlaps "Measurement Period"
                )

