library CesareanBirthFHIR version '0.2.000'

using QICore version '4.1.1'

include CQMCommon version '2.0.000' called CQMCommon
include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include PCMaternal version '5.16.000' called PCMaternal
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'

valueset "Abnormal Presentation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105'
valueset "Cesarean Birth": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282'
valueset "Delivery of Singleton": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99'
valueset "Delivery Procedures": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.59'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Genital Herpes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049'
valueset "Placenta Previa Accreta Increta Percreta or Vasa Previa": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37'
valueset "37 to 42 Plus Weeks Gestation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68'

code "[#] Births.preterm": '11637-6' from "LOINC" display '[#] Births.preterm'
code "[#] Births.term": '11639-2' from "LOINC" display '[#] Births.term'
code "[#] Parity": '11977-6' from "LOINC" display '[#] Parity'
code "[#] Pregnancies": '11996-6' from "LOINC" display '[#] Pregnancies'
code "Date and time of obstetric delivery": '93857-1' from "LOINC" display 'Date and time of obstetric delivery'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum":
  "Encounter with Abnormal Presentation"
    union "Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum"

define "Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks":
  PCMaternal."Delivery Encounter with Age Range" DeliveryEncounter
    where DeliveryEncounter.calculatedGestationalAge ( ) >= 37

define "Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks":
  PCMaternal."Delivery Encounter with Age Range" DeliveryEncounter
    where DeliveryEncounter.calculatedGestationalAge ( ) is null
      and DeliveryEncounter.lastEstimatedGestationalAge ( ) >= 37 weeks

define "Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks":
  "Delivery Encounter with Calculated Gestational Age Greater than or Equal to 37 Weeks"
    union "Delivery Encounter with Estimated Gestational Age Greater than or Equal to 37 Weeks"
    union "Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding"

define "Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks Based on Coding":
  PCMaternal."Delivery Encounter with Age Range" DeliveryEncounter
    let CGA: DeliveryEncounter.calculatedGestationalAge ( ),
    EGA: DeliveryEncounter.lastEstimatedGestationalAge ( )
    where CGA is null
      and EGA is null
      and exists ( ( DeliveryEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
          where EncounterDiagnosis.code in "37 to 42 Plus Weeks Gestation"
      )

define "Denominator":
  "Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births"

define "Denominator Exclusions":
  "Delivery Encounter with Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum"

define "Initial Population":
  PCMaternal."Delivery Encounter with Age Range"

define "Numerator":
  "Delivery Encounter with Cesarean Birth"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Variable Calculated Gestational Age":
  PCMaternal."Variable Calculated Gestational Age"

define "Delivery Encounter with Cesarean Birth":
  "Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births" ThirtysevenWeeksPlusEncounter
    with ["Procedure": "Cesarean Birth"] CSection
      such that CSection.performed.toInterval ( ) during ThirtysevenWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation ( )
        and CSection.status = 'completed'

define "Encounter with Genital Herpes, Placenta Previa, Vasa Previa or Placenta Accreta Spectrum":
  "Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births" ThirtysevenWeeksPlusEncounter
    where exists ( ( ThirtysevenWeeksPlusEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
        where EncounterDiagnosis.code in "Placenta Previa Accreta Increta Percreta or Vasa Previa"
          or EncounterDiagnosis.code in "Genital Herpes"
    )

define "Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births":
  ( "Delivery Encounter with Gestational Age Greater than or Equal to 37 Weeks"
    intersect "Encounter with Singleton Delivery" ) SingletonEncounterGE37Weeks
    where ( ( SingletonEncounterGE37Weeks.lastGravida ( ) = 1 )
        or ( SingletonEncounterGE37Weeks.lastParity ( ) = 0 )
        or ( ( SingletonEncounterGE37Weeks.lastHistoryPretermBirth ( ) = 0 )
            and ( SingletonEncounterGE37Weeks.lastHistoryTermBirth ( ) = 0 )
        )
    )

define "Encounter with Abnormal Presentation":
  "Singleton Delivery Encounters at 37 Plus Weeks Gravida 1 Parity 0, No Previous Births" ThirtysevenWeeksPlusEncounter
    let LastAbnormalPresentation: Last(["Observation": "Abnormal Presentation"] AbnormalPresentation
        where AbnormalPresentation.effective.earliest() before or on ThirtysevenWeeksPlusEncounter.lastTimeOfDelivery()
          and AbnormalPresentation.status in { 'final', 'amended', 'corrected' }
        sort by effective.earliest()
    )
    where LastAbnormalPresentation.effective.earliest ( ) during ThirtysevenWeeksPlusEncounter.period
      or exists ( ( ThirtysevenWeeksPlusEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
          where EncounterDiagnosis.code in "Abnormal Presentation"
      )

define "Encounter with Singleton Delivery":
  PCMaternal."Delivery Encounter with Age Range" DeliveryEncounter
    where exists ( ( DeliveryEncounter.encounterDiagnosis ( ) ) EncounterDiagnosis
        where EncounterDiagnosis.code in "Delivery of Singleton"
    )
   //       and EncounterDiagnoses.verificationStatus  ~ FHIRCommon."confirmed"


define fluent function lastGravida(TheEncounter Encounter):
  Last(["Observation": "[#] Pregnancies"] Gravida
      where Gravida.value is not null
        and Gravida.status in { 'final', 'amended', 'corrected' }
        and Gravida.effective.earliest() 42 weeks or less before TheEncounter.lastTimeOfDelivery()
      sort by effective.earliest()
  ).value as Integer

define fluent function lastHistoryPretermBirth(TheEncounter Encounter):
  Last(["Observation": "[#] Births.preterm"] PretermBirth
      where PretermBirth.effective.earliest() 42 weeks or less before TheEncounter.lastTimeOfDelivery()
        and PretermBirth.status in { 'final', 'amended', 'corrected' }
        and PretermBirth.value is not null
      sort by effective.earliest()
  ).value as Integer

define fluent function lastHistoryTermBirth(TheEncounter Encounter):
  Last(["Observation": "[#] Births.term"] TermBirth
      where TermBirth.effective.earliest() 42 weeks or less before TheEncounter.lastTimeOfDelivery()
        and TermBirth.status in { 'final', 'amended', 'corrected' }
        and TermBirth.value is not null
      sort by effective.earliest()
  ).value as Integer

define fluent function lastParity(TheEncounter Encounter):
  Last(["Observation": "[#] Parity"] Parity
      where Parity.effective.earliest() 42 weeks or less before TheEncounter.lastTimeOfDelivery()
        and Parity.status in { 'final', 'amended', 'corrected' }
        and Parity.value is not null
      sort by effective.earliest()
  ).value as Integer