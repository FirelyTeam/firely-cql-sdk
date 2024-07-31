library TestRetrieve version '1.0.1'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers
include TestRetrieveInclude version '1.0.1' called test

codesystem "ICD-10": 'http://hl7.org/fhir/sid/icd-10-cm'

valueset "HIV": '2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Syphilis": '2.16.840.1.113883.3.464.1003.112.12.1002'
valueset "Complications of Pregnancy, Childbirth and the Puerperium": '2.16.840.1.113883.3.464.1003.111.12.1012'
valueset "Pregnancy Test": '2.16.840.1.113883.3.464.1003.111.12.1011'
valueset "Pap Test": '2.16.840.1.113883.3.464.1003.108.12.1017'
valueset "Lab Tests During Pregnancy": '2.16.840.1.113883.3.464.1003.111.12.1007'
valueset "Lab Tests for Sexually Transmitted Infections": '2.16.840.1.113883.3.464.1003.110.12.1051'
valueset "Chlamydia Screening": '2.16.840.1.113883.3.464.1003.110.12.1052'

valueset "Palliative Care Assessment": 'https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2225'
valueset "Palliative Care Encounter": 'https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1450'
valueset "Palliative Care Intervention": 'https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.2224'

code "Encounter for palliative care": 'Z51.5' from "ICD-10" display 'Encounter for palliative care'


parameter MeasurementPeriod default Interval[DateTime(2013, 1, 1, 0, 0, 0, 0), DateTime(2014, 1, 1, 0, 0, 0, 0))

context Patient

define "InDemographic":
	AgeInYearsAt(start of MeasurementPeriod) >= 16 and AgeInYearsAt(start of MeasurementPeriod) < 24
		and "Patient"."gender" in test."Female Administrative Sex"

define "SexuallyActive":
exists (["Condition": test."Other Female Reproductive Conditions"] C where Interval[C.onset, C.abatement] overlaps MeasurementPeriod)
		or exists (["Condition": test."Genital Herpes"] C where Interval[C.onset, C.abatement] overlaps MeasurementPeriod)
		or exists (["Condition": onset = 'HIV'] C where Interval[C.onset, C.abatement] overlaps MeasurementPeriod)
		or exists (["ServiceRequest": status in {'a','b'}] O where O.authoredOn  during MeasurementPeriod)

define "InInitialPopulation":
	"InDemographic" and "SexuallyActive"

define "InDenominator":
	true

define "InNumerator":
exists (["DiagnosticReport": "Chlamydia Screening"] R where R.effective during MeasurementPeriod and R."result" is not null)
