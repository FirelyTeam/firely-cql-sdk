library TestRetrieve version '1.0.1'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.1' called FHIRHelpers

valueset "Female Administrative Sex": '2.16.840.1.113883.3.560.100.2'
valueset "Other Female Reproductive Conditions": '2.16.840.1.113883.3.464.1003.111.12.1006'
valueset "Genital Herpes": '2.16.840.1.113883.3.464.1003.110.12.1049'
valueset "Genococcal Infections and Venereal Diseases": '2.16.840.1.113883.3.464.1003.112.12.1001'
valueset "Inflammatory Diseases of Female Reproductive Organs": '2.16.840.1.113883.3.464.1003.112.12.1004'
valueset "Chlamydia": '2.16.840.1.113883.3.464.1003.112.12.1003'
valueset "HIV": '2.16.840.1.113883.3.464.1003.120.12.1003'
valueset "Syphilis": '2.16.840.1.113883.3.464.1003.112.12.1002'
valueset "Complications of Pregnancy, Childbirth and the Puerperium": '2.16.840.1.113883.3.464.1003.111.12.1012'
valueset "Pregnancy Test": '2.16.840.1.113883.3.464.1003.111.12.1011'
valueset "Pap Test": '2.16.840.1.113883.3.464.1003.108.12.1017'
valueset "Lab Tests During Pregnancy": '2.16.840.1.113883.3.464.1003.111.12.1007'
valueset "Lab Tests for Sexually Transmitted Infections": '2.16.840.1.113883.3.464.1003.110.12.1051'
valueset "Chlamydia Screening": '2.16.840.1.113883.3.464.1003.110.12.1052'

parameter MeasurementPeriod default Interval[DateTime(2013, 1, 1, 0, 0, 0, 0), DateTime(2014, 1, 1, 0, 0, 0, 0))

context Patient

define "InDemographic":
	AgeInYearsAt(start of MeasurementPeriod) >= 16 and AgeInYearsAt(start of MeasurementPeriod) < 24
		and "Patient"."gender" in "Female Administrative Sex"

define "SexuallyActive":
    exists (["Condition": "Other Female Reproductive Conditions"] C where Interval[C.onset, C.abatement] overlaps MeasurementPeriod)
		or exists (["Condition": "Genital Herpes"] C where Interval[C.onset, C.abatement] overlaps MeasurementPeriod)
		or exists (["Condition": "Genococcal Infections and Venereal Diseases"] C where Interval[C.onset, C.abatement] overlaps MeasurementPeriod)
		or exists (["ServiceRequest": "Pregnancy Test"] O where O.authoredOn  during MeasurementPeriod)

define "InInitialPopulation":
	"InDemographic" and "SexuallyActive"

define "InDenominator":
	true

define "InNumerator":
    exists (["DiagnosticReport": "Chlamydia Screening"] R where R.effective during MeasurementPeriod and R."result" is not null)
