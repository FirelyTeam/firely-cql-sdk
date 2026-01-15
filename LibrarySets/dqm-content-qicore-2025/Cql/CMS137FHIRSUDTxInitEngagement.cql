library CMS137FHIRSUDTxInitEngagement version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include Hospice version '6.18.000' called Hospice
include Status version '1.15.000' called Status

valueset "Detoxification Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1059'
valueset "Discharge Services Hospital Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1007'
valueset "Discharge Services Hospital Inpatient Same Day Discharge": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1006'
valueset "Emergency Department Evaluation and Management Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1010'
valueset "Initial Hospital Inpatient Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1004'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Psych Visit Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496'
valueset "Substance Use Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1001'
valueset "Substance Use Disorder Long Acting Medication": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1149'
valueset "Substance Use Disorder Long Acting Medication Administration": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1156'
valueset "Substance Use Disorder Short Acting Medication": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1150'
valueset "Substance Use Disorder Short Acting Medication Administration": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1157'
valueset "Substance Use Disorder Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.106.12.1005'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") >= 13
    and "First SUD Episode During Measurement Period" is not null
    and not exists "History of SUD Diagnosis or Treatment"

define "First SUD Episode During Measurement Period":
  First(("Qualifying Encounters") ValidEncounters
      with(([ConditionEncounterDiagnosis: "Substance Use Disorder"]).verified()) SUDDiagnosis
        such that ValidEncounters.period during "Measurement Period"
          and SUDDiagnosis.prevalenceInterval() starts during ValidEncounters.period
          and SUDDiagnosis.prevalenceInterval() starts 47 days or more before day of 
          end of "Measurement Period"
      return {
        ValidEncounterDate: date from start of ValidEncounters.period,
        ValidEncounter: ValidEncounters
      }
      sort by ValidEncounterDate
  ).ValidEncounter

define "Qualifying Encounters":
  ( [Encounter: "Office Visit"]
      union [Encounter: "Emergency Department Evaluation and Management Visit"]
      union [Encounter: "Detoxification Visit"]
      union [Encounter: "Initial Hospital Inpatient Visit"]
      union [Encounter: "Discharge Services Hospital Inpatient Same Day Discharge"]
      union [Encounter: "Discharge Services Hospital Inpatient"]
      union [Encounter: "Telephone Visits"]
      union [Encounter: "Virtual Encounter"]
  ).isEncounterPerformed ( )

define "History of SUD Diagnosis or Treatment":
  ( ( ( [Procedure: "Substance Use Disorder Treatment"]
        union [Procedure: "Psych Visit Psychotherapy"]
        union [Procedure: "Substance Use Disorder Long Acting Medication Administration"]
        union [Procedure: "Substance Use Disorder Short Acting Medication Administration"]
    ).isInterventionPerformed ( ) ) Interventions
      with "First SUD Episode During Measurement Period" FirstSUDEpisode
        such that Interventions.performed.toInterval ( ) starts 60 days or less before day of date from start of FirstSUDEpisode.period
  )
    union ( ( ( "Qualifying Encounters"
        except "Emergency Department or Detoxification Visit" ) QualifyingEncounter
        where QualifyingEncounter.encounterDiagnosis ( ).code in "Substance Use Disorder" ) SUDEncounterDx
        with "First SUD Episode During Measurement Period" FirstSUDEpisode
          such that SUDEncounterDx.period starts 60 days or less before day of date from start of FirstSUDEpisode.period
    )
    union ( ( ( [MedicationRequest: "Substance Use Disorder Long Acting Medication"]
          union [MedicationRequest: "Substance Use Disorder Short Acting Medication"]
      ).isMedicationOrder ( ) ) SUDMedication
        with "First SUD Episode During Measurement Period" FirstSUDEpisode
          such that SUDMedication.authoredOn 60 days or less before day of date from start of FirstSUDEpisode.period
    )

define "Emergency Department or Detoxification Visit":
  ( [Encounter: "Emergency Department Evaluation and Management Visit"]
      union [Encounter: "Detoxification Visit"]
  ).isEncounterPerformed ( )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"

define "Numerator 1":
  exists "Treatment Initiation With Non Medication Intervention Dates"
    or exists "Treatment Initiation With Medication Order Dates"

define "Treatment Initiation With Non Medication Intervention Dates":
  ( "Psychosocial Visit" PsychosocialVisitProcedure
      let treatmentDate: date from start of PsychosocialVisitProcedure.performed.toInterval ( )
      with "First SUD Episode During Measurement Period" FirstSUDEpisode
        such that treatmentDate during Interval[date from start of FirstSUDEpisode.period, date from start of FirstSUDEpisode.period + 14 days )
          and PsychosocialVisitProcedure.id !~ FirstSUDEpisode.id
      return all treatmentDate
  )
    union ( "Psychosocial Visit" PsychosocialVisitEncounter
        let treatmentDate: date from start of PsychosocialVisitEncounter.period
        with "First SUD Episode During Measurement Period" FirstSUDEpisode
          such that treatmentDate during Interval[date from start of FirstSUDEpisode.period, date from start of FirstSUDEpisode.period + 14 days )
            and PsychosocialVisitEncounter.id !~ FirstSUDEpisode.id
        return all treatmentDate
    )

define "Psychosocial Visit":
  ( ( [Procedure: "Substance Use Disorder Treatment"]
        union [Procedure: "Psych Visit Psychotherapy"]
    ).isInterventionPerformed ( )
  )
    union ( ( [Encounter: "Telephone Visits"]
        union [Encounter: "Virtual Encounter"]
    ).isEncounterPerformed ( ) ) TelehealthEncounter
      where TelehealthEncounter.encounterDiagnosis ( ).code in "Substance Use Disorder"

define "Treatment Initiation With Medication Order Dates":
  ( ( ( [MedicationRequest: "Substance Use Disorder Short Acting Medication"]
        union [MedicationRequest: "Substance Use Disorder Long Acting Medication"]
    ).isMedicationOrder ( ) ) SUDMedication
      let treatmentDate: date from start of SUDMedication.authoredOn.toInterval ( )
      with "First SUD Episode During Measurement Period" FirstSUDEpisode
        such that treatmentDate during Interval[date from start of FirstSUDEpisode.period, date from start of FirstSUDEpisode.period + 14 days )
      return all treatmentDate
  )
    union ( ( ( [Procedure: "Substance Use Disorder Short Acting Medication Administration"]
          union [Procedure: "Substance Use Disorder Long Acting Medication Administration"]
      ).isProcedurePerformed ( ) ) SUDMedAdministration
        let treatmentDate: date from start of SUDMedAdministration.performed.toInterval ( )
        with "First SUD Episode During Measurement Period" FirstSUDEpisode
          such that treatmentDate during Interval[date from start of FirstSUDEpisode.period, date from start of FirstSUDEpisode.period + 14 days )
        return all treatmentDate
    )

define "Has Two or More Treatment Engagements With Short Acting Medication or Non Medication Intervention":
  Count((("Psychosocial Visit"
        union(([Procedure: "Substance Use Disorder Short Acting Medication Administration"]).isProcedurePerformed())) ShortActingTreatment
        with(Min("Treatment Initiation With Non Medication Intervention Dates"
            union "Treatment Initiation With Medication Order Dates"
        )) InitiationTreatmentDate
          such that date from start of ShortActingTreatment.performed.toInterval() 34 days or less after InitiationTreatmentDate
            or date from start of ShortActingTreatment.period 34 days or less after InitiationTreatmentDate
        return all ShortActingTreatment
    )
      union((([MedicationRequest: "Substance Use Disorder Short Acting Medication"]).isMedicationOrder()) ShortActingMedOrder
          with(Min("Treatment Initiation With Non Medication Intervention Dates"
              union "Treatment Initiation With Medication Order Dates"
          )) InitiationTreatmentDate
            such that date from start of ShortActingMedOrder.authoredOn.toInterval() 34 days or less after InitiationTreatmentDate
          return all ShortActingMedOrder
      )
  ) >= 2

define "Numerator 2":
  "Has Treatment Engagement With Long Acting Medication"
    or "Has Two or More Treatment Engagements With Short Acting Medication or Non Medication Intervention"

define "Has Treatment Engagement With Long Acting Medication":
  exists ( ( ( ( [MedicationRequest: "Substance Use Disorder Long Acting Medication"] ).isMedicationOrder ( ) ) LongActingMedOrder
        with ( Min("Treatment Initiation With Non Medication Intervention Dates"
            union "Treatment Initiation With Medication Order Dates"
        ) ) InitiationTreatmentDate
          such that date from start of LongActingMedOrder.authoredOn.toInterval ( ) 34 days or less after InitiationTreatmentDate
    )
      union ( ( ( [Procedure: "Substance Use Disorder Long Acting Medication Administration"] ).isProcedurePerformed ( ) ) LongActingTreatment
          with ( Min("Treatment Initiation With Non Medication Intervention Dates"
              union "Treatment Initiation With Medication Order Dates"
          ) ) InitiationTreatmentDate
            such that date from start of LongActingTreatment.performed.toInterval ( ) 34 days or less after InitiationTreatmentDate
      )
  )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Stratification 1":
  AgeInYearsAt(date from start of "Measurement Period") in Interval[13, 17]

define "Stratification 2":
  AgeInYearsAt(date from start of "Measurement Period") in Interval[18, 64]

define "Stratification 3":
  AgeInYearsAt(date from start of "Measurement Period") >= 65