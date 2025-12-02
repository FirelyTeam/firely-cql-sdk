library CMS69PCSBMIScreenAndFollowUpQDM version '14.0.000'

using QDM version '5.6'

include CQMCommonQDM  version '9.0.000' called Global
include HospiceQDM version '7.0.000' called Hospice
include PalliativeCareQDM version '5.0.000' called PalliativeCare

codesystem "LOINC": 'urn:oid:2.16.840.1.113883.6.1'
codesystem "ActCode": 'urn:oid:2.16.840.1.113883.5.4'

valueset "Federal Administrative Sex": 'urn:oid:2.16.840.1.113762.1.4.1021.121'
valueset "Encounter to Evaluate BMI": 'urn:oid:2.16.840.1.113883.3.600.1.1751'
valueset "Ethnicity": 'urn:oid:2.16.840.1.114222.4.11.837'
valueset "Follow Up for Above Normal BMI": 'urn:oid:2.16.840.1.113883.3.600.1.1525'
valueset "Follow Up for Below Normal BMI": 'urn:oid:2.16.840.1.113883.3.600.1.1528'
valueset "Medical Reason": 'urn:oid:2.16.840.1.113883.3.526.3.1007'
valueset "Medications for Above Normal BMI": 'urn:oid:2.16.840.1.113883.3.526.3.1561'
valueset "Medications for Below Normal BMI": 'urn:oid:2.16.840.1.113883.3.526.3.1562'
valueset "Overweight or Obese": 'urn:oid:2.16.840.1.113762.1.4.1047.502'
valueset "Patient Declined": 'urn:oid:2.16.840.1.113883.3.526.3.1582'
valueset "Payer Type": 'urn:oid:2.16.840.1.114222.4.11.3591'
valueset "Pregnancy": 'urn:oid:2.16.840.1.113883.3.526.3.378'
valueset "Race": 'urn:oid:2.16.840.1.114222.4.11.836'
valueset "Referrals Where Weight Assessment May Occur": 'urn:oid:2.16.840.1.113883.3.600.1.1527'
valueset "Underweight": 'urn:oid:2.16.840.1.113883.3.526.3.1563'

code "Body mass index (BMI) [Ratio]": '39156-5' from "LOINC" display 'Body mass index (BMI) [Ratio]'
code "virtual": 'VR' from "ActCode" display 'virtual'

parameter "Measurement Period" Interval<DateTime>

context Patient

define "Denominator":
  "Initial Population"

define "Denominator Exceptions":
  exists "Medical Reason For Not Documenting A Follow Up Plan For Low Or High BMI"
    or exists "Medical Reason Or Patient Reason For Not Performing BMI Exam"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or PalliativeCare."Has Palliative Care in the Measurement Period"
    or "Is Pregnant During Day Of Measurement Period"

define "Documented High BMI During Measurement Period":
  "BMI During Measurement Period" BMI
    where Global."NormalizeInterval" ( BMI.relevantDatetime, BMI.relevantPeriod ) during day of "Measurement Period"
      and BMI.result >= 25 'kg/m2'

define "Documented Low BMI During Measurement Period":
  "BMI During Measurement Period" BMI
    where Global."NormalizeInterval" ( BMI.relevantDatetime, BMI.relevantPeriod ) during day of "Measurement Period"
      and BMI.result < 18.5 'kg/m2'

define "Has Normal BMI":
  exists ( "BMI During Measurement Period" BMI
      where BMI.result >= 18.5 'kg/m2'
        and BMI.result < 25 'kg/m2'
  )
    and not ( exists "Documented High BMI During Measurement Period"
        or exists "Documented Low BMI During Measurement Period"
    )

define "High BMI And Follow Up Provided":
  ( "Documented High BMI During Measurement Period" HighBMI
      with ( "High BMI Interventions Ordered"
        union "High BMI Interventions Performed" ) HighBMIInterventions
        such that ( Coalesce(start of Global."NormalizeInterval"(HighBMIInterventions.relevantDatetime, HighBMIInterventions.relevantPeriod), HighBMIInterventions.authorDatetime) during day of "Measurement Period" )
  )

define "High BMI Interventions Ordered":
  ( ( ["Intervention, Order": "Follow Up for Above Normal BMI"]
      union ["Intervention, Order": "Referrals Where Weight Assessment May Occur"]
      union ["Medication, Order": "Medications for Above Normal BMI"] ) HighInterventionsOrdered
      where HighInterventionsOrdered.reason in "Overweight or Obese"
        or ( exists ["Diagnosis": "Overweight or Obese"] OverweightObese
            where OverweightObese.prevalencePeriod starts before or on day of HighInterventionsOrdered.authorDatetime
              and not ( OverweightObese.prevalencePeriod ends before day of HighInterventionsOrdered.authorDatetime )
        )
  )

define "High BMI Interventions Performed":
  ( ["Intervention, Performed": "Follow Up for Above Normal BMI"] HighInterventionsPerformed
      where HighInterventionsPerformed.reason in "Overweight or Obese"
        or ( exists ["Diagnosis": "Overweight or Obese"] OverweightObese
            where OverweightObese.prevalencePeriod starts before or on day of start of Global."NormalizeInterval" ( HighInterventionsPerformed.relevantDatetime, HighInterventionsPerformed.relevantPeriod )
              and not ( OverweightObese.prevalencePeriod ends before day of start of Global."NormalizeInterval" ( HighInterventionsPerformed.relevantDatetime, HighInterventionsPerformed.relevantPeriod ) )
        )
  )

define "Initial Population":
  exists "Qualifying Encounter During Day Of Measurement Period" QualifyingEncounter
    where "AgeInYearsAt"(date from start of QualifyingEncounter.relevantPeriod) >= 18

define "Is Pregnant During Day Of Measurement Period":
  exists ( ["Diagnosis": "Pregnancy"] PregnancyDiagnosis
      with "Qualifying Encounter During Day Of Measurement Period" QualifyingEncounter
        such that PregnancyDiagnosis.prevalencePeriod overlaps day of "Measurement Period"
  )

define "Low BMI And Follow Up Provided":
  ( "Documented Low BMI During Measurement Period" LowBMI
      with ( "Low BMI Interventions Ordered"
        union "Low BMI Interventions Performed" ) LowBMIInterventions
        such that ( Coalesce(start of Global."NormalizeInterval"(LowBMIInterventions.relevantDatetime, LowBMIInterventions.relevantPeriod), LowBMIInterventions.authorDatetime) during day of "Measurement Period" )
  )

define "Low BMI Interventions Ordered":
  ( ( ["Intervention, Order": "Follow Up for Below Normal BMI"]
      union ["Intervention, Order": "Referrals Where Weight Assessment May Occur"]
      union ["Medication, Order": "Medications for Below Normal BMI"] ) LowInterventionsOrdered
      where LowInterventionsOrdered.reason in "Underweight"
        or ( exists ["Diagnosis": "Underweight"] UnderweightDiagnosis
            where UnderweightDiagnosis.prevalencePeriod starts before or on day of LowInterventionsOrdered.authorDatetime
              and not ( UnderweightDiagnosis.prevalencePeriod ends before day of LowInterventionsOrdered.authorDatetime )
        )
  )

define "Low BMI Interventions Performed":
  ( ["Intervention, Performed": "Follow Up for Below Normal BMI"] LowInterventionsPerformed
      where LowInterventionsPerformed.reason in "Underweight"
        or ( exists ["Diagnosis": "Underweight"] UnderweightDiagnosis
            where UnderweightDiagnosis.prevalencePeriod starts before or on day of start of Global."NormalizeInterval" ( LowInterventionsPerformed.relevantDatetime, LowInterventionsPerformed.relevantPeriod )
              and not ( UnderweightDiagnosis.prevalencePeriod ends before day of start of Global."NormalizeInterval" ( LowInterventionsPerformed.relevantDatetime, LowInterventionsPerformed.relevantPeriod ) )
        )
  )

define "Medical Reason For Not Documenting A Follow Up Plan For Low Or High BMI":
  ( ["Intervention, Not Ordered": "Referrals Where Weight Assessment May Occur"]
    union ["Intervention, Not Ordered": "Follow Up for Above Normal BMI"]
    union ["Intervention, Not Performed": "Follow Up for Above Normal BMI"]
    union ["Intervention, Not Ordered": "Follow Up for Below Normal BMI"]
    union ["Intervention, Not Performed": "Follow Up for Below Normal BMI"]
    union ["Medication, Not Ordered": "Medications for Above Normal BMI"]
    union ["Medication, Not Ordered": "Medications for Below Normal BMI"] ) NoBMIFollowUp
    with "Qualifying Encounter During Day Of Measurement Period" QualifyingEncounter
      such that NoBMIFollowUp.authorDatetime same day as start of QualifyingEncounter.relevantPeriod
    where NoBMIFollowUp.negationRationale in "Medical Reason"

define "Medical Reason Or Patient Reason For Not Performing BMI Exam":
  ["Physical Exam, Not Performed": "Body mass index (BMI) [Ratio]"] NoBMI
    with "Qualifying Encounter During Day Of Measurement Period" QualifyingEncounter
      such that NoBMI.authorDatetime same day as start of QualifyingEncounter.relevantPeriod
    where ( NoBMI.negationRationale in "Medical Reason"
        or NoBMI.negationRationale in "Patient Declined"
    )

define "Numerator":
  exists "High BMI And Follow Up Provided"
    or exists "Low BMI And Follow Up Provided"
    or "Has Normal BMI"

define "Qualifying Encounter During Day Of Measurement Period":
  ["Encounter, Performed": "Encounter to Evaluate BMI"] BMIEncounter
    where BMIEncounter.relevantPeriod during day of "Measurement Period"
      and BMIEncounter.class !~ "virtual"

define "SDE Ethnicity":
  ["Patient Characteristic Ethnicity": "Ethnicity"]

define "SDE Payer":
  ["Patient Characteristic Payer": "Payer Type"]

define "SDE Race":
  ["Patient Characteristic Race": "Race"]

define "SDE Sex":
  ["Patient Characteristic Sex": "Federal Administrative Sex"]

define "BMI During Measurement Period":
  ( ["Physical Exam, Performed": "Body mass index (BMI) [Ratio]"] BMI
      where Global."NormalizeInterval" ( BMI.relevantDatetime, BMI.relevantPeriod ) during day of "Measurement Period"
        and BMI.result > 0 'kg/m2'
  )