library CMS22FHIRPCSBPScreeningFollowUp version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "ActCode": 'http://terminology.hl7.org/CodeSystem/v3-ActCode'
codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Diagnosis of Hypertension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.263'
valueset "Dietary Recommendations": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1515'
valueset "Encounter to Screen for Blood Pressure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1920'
valueset "Finding of Elevated Blood Pressure or Hypertension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1047.514'
valueset "Follow Up Within 4 Weeks": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1578'
valueset "Follow Up Within 6 Months": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1108.125'
valueset "Laboratory Tests for Hypertension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1482'
valueset "Lifestyle Recommendation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1581'
valueset "Medical Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007'
valueset "Patient Declined": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582'
valueset "Pharmacologic Therapy for Hypertension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.1577'
valueset "Recommendation to Increase Physical Activity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1518'
valueset "Referral or Counseling for Alcohol Consumption": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1583'
valueset "Referral to Primary Care or Alternate Provider": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1580'
valueset "Weight Reduction Recommended": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.600.1510'

code "Blood pressure panel with all children optional": '85354-9' from "LOINC" display 'Blood pressure panel with all children optional'
code "Diastolic blood pressure": '8462-4' from "LOINC" display 'Diastolic blood pressure'
code "12 lead EKG panel": '34534-8' from "LOINC" display 'EKG 12 channel panel'
code "EKG study": '11524-6' from "LOINC" display 'EKG study'
code "Systolic blood pressure": '8480-6' from "LOINC" display 'Systolic blood pressure'
code "virtual": 'VR' from "ActCode" display 'virtual'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  "Qualifying Encounter during Measurement Period" QualifyingEncounter
    where AgeInYearsAt(date from start of "Measurement Period") >= 18

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  "Qualifying Encounter during Measurement Period" QualifyingEncounter
    with [ConditionProblemsHealthConcerns: "Diagnosis of Hypertension"] Hypertension
      such that Hypertension.prevalenceInterval ( ) starts before or on day of QualifyingEncounter.period
        and Hypertension.isVerified ( )

define "Numerator":
  "Encounter with Normal Blood Pressure Reading"
    union ( "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions" )
    union ( "Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions" )
    union ( "Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions" )
    union ( "Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions" )

define "Denominator Exceptions":
  "Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement"
    union "Encounter with Order for Hypertension Follow Up Declined by Patient"

define "Follow up with Rescreen Within 6 Months":
  [ServiceRequest: "Follow Up Within 6 Months"] FollowUp
    where FollowUp.intent ~ 'order'

define "Laboratory Test or ECG for Hypertension":
  ( [ServiceRequest: "12 lead EKG panel"]
    union [ServiceRequest: "EKG study"]
    union [ServiceRequest: "Laboratory Tests for Hypertension"] ) EKGLab
    where EKGLab.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }

define "NonPharmacological Interventions":
  ( [ServiceRequest: "Lifestyle Recommendation"]
    union [ServiceRequest: "Weight Reduction Recommended"]
    union [ServiceRequest: "Dietary Recommendations"]
    union [ServiceRequest: "Recommendation to Increase Physical Activity"]
    union [ServiceRequest: "Referral or Counseling for Alcohol Consumption"] ) NonPharmaInterventions
    where NonPharmaInterventions.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }

define "Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80 and Interventions":
  "Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80" FirstHTNEncounter
    with "First Hypertensive Reading Interventions or Referral to Alternate Professional" FirstHTNIntervention
      such that FirstHTNIntervention.authoredOn during day of FirstHTNEncounter.period

define "Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions":
  ( "Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89" SecondHTNEncounterReading
      with "Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions" EncounterInterventions
        such that EncounterInterventions.authoredOn during day of SecondHTNEncounterReading.period
  )
    union ( "Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89" SecondHTNEncounterReading
        with "Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading" ReferralForHTN
          such that ReferralForHTN.authoredOn during day of SecondHTNEncounterReading.period
    )

define "Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 and Interventions":
  ( "Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90" SecondHTNEncounterReading140Over90
      with "Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions" SecondHTN140Over90Interventions
        such that SecondHTN140Over90Interventions.authoredOn during day of SecondHTNEncounterReading140Over90.period
  )
    union "Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90" SecondHTNEncounterReading140Over90
      with "Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading" ReferralToProfessional
        such that ReferralToProfessional.authoredOn during day of SecondHTNEncounterReading140Over90.period

define "First Hypertensive Reading Interventions or Referral to Alternate Professional":
  ( [ServiceRequest: "Follow Up Within 4 Weeks"] FourWeekRescreen
      with "NonPharmacological Interventions" NonPharmInterventionsHTN
        such that FourWeekRescreen.authoredOn during day of "Measurement Period"
          and NonPharmInterventionsHTN.authoredOn during day of "Measurement Period"
          and FourWeekRescreen.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
  )
    union ( "Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading" )

define "Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading":
  [ServiceRequest: "Referral to Primary Care or Alternate Provider"] Referral
    where Referral.reasonCode in "Finding of Elevated Blood Pressure or Hypertension"
      and Referral.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }

define "Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions":
  ( [ServiceRequest: "Follow Up Within 4 Weeks"] WeeksRescreen
      with "Laboratory Test or ECG for Hypertension" ECGLabTest
        such that WeeksRescreen.authoredOn during day of "Measurement Period"
          and ECGLabTest.authoredOn during day of "Measurement Period"
          and WeeksRescreen.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
          and ECGLabTest.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
      with "NonPharmacological Interventions" HTNInterventions
        such that HTNInterventions.authoredOn during day of "Measurement Period"
      with ["MedicationRequest": "Pharmacologic Therapy for Hypertension"] Medications
        such that Medications.authoredOn during day of "Measurement Period"
          and Medications.status in { 'active', 'completed' }
  )

define "Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 and Interventions":
  "Follow up with Rescreen Within 6 Months" Rescreen2to6
    with "Laboratory Test or ECG for Hypertension" LabECGIntervention
      such that Rescreen2to6.authoredOn during day of "Measurement Period"
        and LabECGIntervention.authoredOn during day of "Measurement Period"
    with "NonPharmacological Interventions" NonPharmSecondIntervention
      such that NonPharmSecondIntervention.authoredOn during day of "Measurement Period"

define "Qualifying Encounter during Measurement Period":
  [Encounter: "Encounter to Screen for Blood Pressure"] ValidEncounter
    where ValidEncounter.period ends during day of "Measurement Period"
      and ValidEncounter.status ~ 'finished'
      and ValidEncounter.class !~ "virtual"

define "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80 and Interventions":
  ( "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80" ElevatedEncounter
      with "Follow up with Rescreen Within 6 Months" Twoto6MonthRescreen
        such that Twoto6MonthRescreen.authoredOn during day of ElevatedEncounter.period
      with "NonPharmacological Interventions" NonPharmInterventions
        such that NonPharmInterventions.authoredOn during day of ElevatedEncounter.period
  )
    union ( "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80" ElevatedEncounter
        with "Referral to Alternate or Primary Healthcare Professional for Hypertensive Reading" Referral
          such that Referral.authoredOn during day of ElevatedEncounter.period
    )

define "Encounter with Normal Blood Pressure Reading":
  "Qualifying Encounter during Measurement Period" QualifyingEncounter
    let EncounterLastBP: Last([USCoreBloodPressureProfile] BloodPressure
        where BloodPressure.effective.toInterval() ends during day of QualifyingEncounter.period
          and BloodPressure.status in { 'final', 'amended', 'corrected' }
        sort by start of effective.toInterval()
    )
    where ( singleton from ( EncounterLastBP.component C
          where C.code ~ "Systolic blood pressure"
      )
    ).value in Interval[1 'mm[Hg]', 120 'mm[Hg]' )
      and ( singleton from ( EncounterLastBP.component C
            where C.code ~ "Diastolic blood pressure"
        )
      ).value in Interval[1 'mm[Hg]', 80 'mm[Hg]' )

define "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80":
  "Qualifying Encounter during Measurement Period" QualifyingEncounter
    let EncounterLastBP: Last([USCoreBloodPressureProfile] BloodPressure
        where BloodPressure.effective.toInterval() ends during day of QualifyingEncounter.period
          and BloodPressure.status in { 'final', 'amended', 'corrected' }
        sort by start of effective.toInterval()
    )
    where ( ( singleton from ( EncounterLastBP.component C
            where C.code ~ "Systolic blood pressure"
        )
      ).value in Interval[120 'mm[Hg]', 129 'mm[Hg]']
        and ( singleton from ( EncounterLastBP.component C
              where C.code ~ "Diastolic blood pressure"
          )
        ).value in Interval[1 'mm[Hg]', 80 'mm[Hg]' )
    )

define "Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90":
  ( ( "Qualifying Encounter during Measurement Period" QualifyingEncounter
        let EncounterLastBP: Last([USCoreBloodPressureProfile] BloodPressure
            where BloodPressure.effective.toInterval() ends during day of QualifyingEncounter.period
              and BloodPressure.status in { 'final', 'amended', 'corrected' }
            sort by start of effective.toInterval()
        )
        where ( ( singleton from ( EncounterLastBP.component C
                where C.code ~ "Systolic blood pressure"
            )
          ).value > 0 'mm[Hg]'
            and ( singleton from ( EncounterLastBP.component C
                  where C.code ~ "Diastolic blood pressure"
              )
            ).value > 0 'mm[Hg]'
            and ( ( singleton from ( EncounterLastBP.component C
                    where C.code ~ "Systolic blood pressure"
                )
              ).value >= 140 'mm[Hg]'
                or ( singleton from ( EncounterLastBP.component C
                      where C.code ~ "Diastolic blood pressure"
                  )
                ).value >= 90 'mm[Hg]'
            )
        )
    )
      intersect "Encounter with Hypertensive Reading Within Year Prior"
  )

define "Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89":
  ( ( "Qualifying Encounter during Measurement Period" QualifyingEncounter
        let EncounterLastBP: Last([USCoreBloodPressureProfile] BloodPressure
            where BloodPressure.effective.toInterval() ends during day of QualifyingEncounter.period
              and BloodPressure.status in { 'final', 'amended', 'corrected' }
            sort by start of effective.toInterval()
        )
        where ( ( ( singleton from ( EncounterLastBP.component C
                  where C.code ~ "Systolic blood pressure"
              )
            ).value in Interval[130 'mm[Hg]', 139 'mm[Hg]']
              or ( singleton from ( EncounterLastBP.component C
                    where C.code ~ "Diastolic blood pressure"
                )
              ).value in Interval[80 'mm[Hg]', 89 'mm[Hg]']
          )
            and not ( ( singleton from ( EncounterLastBP.component C
                    where C.code ~ "Systolic blood pressure"
                )
              ).value >= 140 'mm[Hg]'
                or ( singleton from ( EncounterLastBP.component C
                      where C.code ~ "Diastolic blood pressure"
                  )
                ).value >= 90 'mm[Hg]'
            )
        )
    )
      intersect "Encounter with Hypertensive Reading Within Year Prior"
  )

define "Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80":
  ( "Qualifying Encounter during Measurement Period" QualifyingEncounter
      let EncounterLastBP: Last([USCoreBloodPressureProfile] BloodPressure
          where BloodPressure.effective.toInterval() ends during day of QualifyingEncounter.period
            and BloodPressure.status in { 'final', 'amended', 'corrected' }
          sort by start of effective.toInterval()
      )
      where ( ( ( singleton from ( EncounterLastBP.component C
                where C.code ~ "Systolic blood pressure"
            )
          ).value > 0 'mm[Hg]'
            and ( singleton from ( EncounterLastBP.component C
                  where C.code ~ "Diastolic blood pressure"
              )
            ).value > 0 'mm[Hg]'
        )
          and ( ( singleton from ( EncounterLastBP.component C
                  where C.code ~ "Systolic blood pressure"
              )
            ).value >= 130 'mm[Hg]'
              or ( singleton from ( EncounterLastBP.component C
                    where C.code ~ "Diastolic blood pressure"
                )
              ).value >= 80 'mm[Hg]'
          )
      )
  )
    except "Encounter with Hypertensive Reading Within Year Prior"

define "Encounter with Hypertensive Reading Within Year Prior":
  ( "Qualifying Encounter during Measurement Period" QualifyingEncounter
      let EncounterLastBP: Last([USCoreBloodPressureProfile] BloodPressure
          where BloodPressure.effective.toInterval() ends 1 year or less before or on start of QualifyingEncounter.period
            and BloodPressure.status in { 'final', 'amended', 'corrected' }
          sort by start of effective.toInterval()
      )
      where ( ( singleton from ( EncounterLastBP.component C
              where C.code ~ "Systolic blood pressure"
          )
        ).value > 0 'mm[Hg]'
          and ( singleton from ( EncounterLastBP.component C
                where C.code ~ "Diastolic blood pressure"
            )
          ).value > 0 'mm[Hg]'
          and ( ( singleton from ( EncounterLastBP.component C
                  where C.code ~ "Systolic blood pressure"
              )
            ).value >= 130 'mm[Hg]'
              or ( singleton from ( EncounterLastBP.component C
                    where C.code ~ "Diastolic blood pressure"
                )
              ).value >= 80 'mm[Hg]'
          )
      )
  )

define "NonPharmacological Intervention Not Ordered":
  ( [ServiceNotRequested: "Lifestyle Recommendation"]
    union [ServiceNotRequested: "Weight Reduction Recommended"]
    union [ServiceNotRequested: "Dietary Recommendations"]
    union [ServiceNotRequested: "Recommendation to Increase Physical Activity"]
    union [ServiceNotRequested: "Referral or Counseling for Alcohol Consumption"] ) NonPharmIntervention
    where NonPharmIntervention.status in { 'active', 'completed', 'on-hold' }
      and NonPharmIntervention.reasonRefused in "Patient Declined"

define "Encounter with Medical Reason for Not Obtaining or Patient Declined Blood Pressure Measurement":
  "Qualifying Encounter during Measurement Period" QualifyingEncounter
    with ( [ObservationCancelled: code ~ "Blood pressure panel with all children optional"]
      union [ObservationCancelled: code ~ "Systolic blood pressure"]
      union [ObservationCancelled: code ~ "Diastolic blood pressure"] ) NoBPScreen
      such that NoBPScreen.issued during day of QualifyingEncounter.period
        and ( NoBPScreen.notDoneReason in "Patient Declined"
            or NoBPScreen.notDoneReason in "Medical Reason"
        )

define "Encounter with Order for Hypertension Follow Up Declined by Patient":
  ( ( "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80" ElevatedBPEncounter
        with ( [ServiceNotRequested: "Referral to Primary Care or Alternate Provider"]
          union [ServiceNotRequested: "Follow Up Within 6 Months"] ) ElevatedBPDeclinedInterventions
          such that ElevatedBPDeclinedInterventions.authoredOn during day of ElevatedBPEncounter.period
            and ElevatedBPDeclinedInterventions.status in { 'active', 'completed', 'on-hold' }
            and ElevatedBPDeclinedInterventions.reasonRefused in "Patient Declined"
    )
      union ( "Encounter with Elevated Blood Pressure Reading SBP 120 to 129 AND DBP less than 80" ElevatedBPEncounter
          with "NonPharmacological Intervention Not Ordered" NotOrdered
            such that NotOrdered.authoredOn during day of ElevatedBPEncounter.period
      )
      union ( "Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80" FirstHTNEncounter
          with ( [ServiceNotRequested: "Follow Up Within 4 Weeks"]
            union [ServiceNotRequested: "Referral to Primary Care or Alternate Provider"] ) FirstHTNDeclinedInterventions
            such that FirstHTNDeclinedInterventions.authoredOn during day of FirstHTNEncounter.period
              and FirstHTNDeclinedInterventions.status in { 'active', 'completed', 'on-hold' }
              and FirstHTNDeclinedInterventions.reasonRefused in "Patient Declined"
      )
      union ( "Encounter with First Hypertensive Reading SBP Greater than or Equal to 130 OR DBP Greater than or Equal to 80" FirstHTNEncounter
          with "NonPharmacological Intervention Not Ordered" NoNonPharm
            such that NoNonPharm.authoredOn during day of FirstHTNEncounter.period
      )
      union ( "Encounter with Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89" SecondHTNEncounter
          with "Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined" SecondHTNDeclinedInterventions
            such that SecondHTNDeclinedInterventions.authoredOn during day of SecondHTNEncounter.period
      )
      union ( "Encounter with Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90" SecondHTN140Over90Encounter
          with "Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined" SecondHTN140Over90DeclinedInterventions
            such that SecondHTN140Over90DeclinedInterventions.authoredOn during day of SecondHTN140Over90Encounter.period
      )
  )

define "Second Hypertensive Reading SBP 130 to 139 OR DBP 80 to 89 Interventions Declined":
  ( ( [ServiceNotRequested: "Referral to Primary Care or Alternate Provider"]
      union [ServiceNotRequested: "Follow Up Within 6 Months"] ) SecondHTNDeclinedReferralAndFollowUp
      where SecondHTNDeclinedReferralAndFollowUp.status in { 'active', 'completed', 'on-hold' }
        and SecondHTNDeclinedReferralAndFollowUp.reasonRefused in "Patient Declined"
  )
    union "Laboratory Test or ECG for Hypertension Not Ordered"
    union "NonPharmacological Intervention Not Ordered"

define "Second Hypertensive Reading SBP Greater than or Equal to 140 OR DBP Greater than or Equal to 90 Interventions Declined":
  ( ( ( [ServiceNotRequested: "Referral to Primary Care or Alternate Provider"]
        union [ServiceNotRequested: "Follow Up Within 4 Weeks"] ) SecondHTN140Over90ReferralFollowUpNotDone
        where SecondHTN140Over90ReferralFollowUpNotDone.status in { 'active', 'completed', 'on-hold' }
          and SecondHTN140Over90ReferralFollowUpNotDone.reasonRefused in "Patient Declined"
    )
      union ( [MedicationNotRequested: "Pharmacologic Therapy for Hypertension"] MedicationRequestNotOrdered
          where MedicationRequestNotOrdered.status in { 'active', 'completed' }
      )
      union "Laboratory Test or ECG for Hypertension Not Ordered"
      union "NonPharmacological Intervention Not Ordered"
  )

define "Laboratory Test or ECG for Hypertension Not Ordered":
  ( [ServiceNotRequested: code = "12 lead EKG panel"]
    union [ServiceNotRequested: code = "EKG study"]
    union [ServiceNotRequested: "Laboratory Tests for Hypertension"] ) LabECGNotDone
    where LabECGNotDone.status in { 'active', 'completed', 'on-hold' }
      and LabECGNotDone.reasonRefused in "Patient Declined"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

/*
@description: Returns true if the given condition either has no verification status or has a verification status of confirmed, unconfirmed, provisional, or differential
*/


define fluent function isVerified(condition Choice<QICore.ConditionProblemsHealthConcerns, QICore.ConditionEncounterDiagnosis>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )