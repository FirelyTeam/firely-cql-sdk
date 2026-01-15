library CMS0334FHIRPCCesareanBirth version '1.0.000'

using QICore version '6.0.0'

include CQMCommon version '4.1.000' called CQMCommon
include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include PCMaternal version '5.25.000' called PCMaternal
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'

valueset "Abnormal Presentation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.105'
valueset "Cesarean Birth": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.282'
valueset "Delivery of Singleton": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.99'
valueset "Genital Herpes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.110.12.1049'
valueset "Placenta Accreta Spectrum Previa or Vasa Previa": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.37'
valueset "37 to 42 Plus Weeks Gestation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.68'

code "[#] Births.preterm": '11637-6' from "LOINC" display '[#] Births.preterm'
code "[#] Births.term": '11639-2' from "LOINC" display '[#] Births.term'
code "[#] Parity": '11977-6' from "LOINC" display '[#] Parity'
code "[#] Pregnancies": '11996-6' from "LOINC" display '[#] Pregnancies'
//code "Date and time of obstetric delivery": '93857-1' from "LOINC" display 'Date and time of obstetric delivery'


parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Delivery Encounter With Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum":
  "Encounter With Abnormal Presentation"
    union "Encounter With Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum"

define "Delivery Encounter With Calculated Gestational Age Greater Than Or Equal To 37 Weeks":
  PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
    where DeliveryEncounter.calculatedGestationalAge ( ) >= 37

define "Delivery Encounter With Estimated Gestational Age Greater Than Or Equal To 37 Weeks":
  PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
    where DeliveryEncounter.calculatedGestationalAge ( ) is null
      and DeliveryEncounter.lastEstimatedGestationalAge ( ) >= 37 weeks

define "Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks":
  "Delivery Encounter With Calculated Gestational Age Greater Than Or Equal To 37 Weeks"
    union "Delivery Encounter With Estimated Gestational Age Greater Than Or Equal To 37 Weeks"
    union "Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks Based On Coding"

define "Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks Based On Coding":
  PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
    let CGA: DeliveryEncounter.calculatedGestationalAge ( ),
    EGA: DeliveryEncounter.lastEstimatedGestationalAge ( )
    where CGA is null
      and EGA is null
      and ( DeliveryEncounter.reasonCode in "37 to 42 Plus Weeks Gestation"
          or DeliveryEncounter.encounterDiagnosis ( ).code in "37 to 42 Plus Weeks Gestation"
      )

define "Denominator":
  "Singleton Delivery Encounters At 37 Plus Weeks Gravida 1 Parity 0, No Previous Births"

define "Denominator Exclusions":
  "Delivery Encounter With Abnormal Presentation, Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum"

define "Initial Population":
  PCMaternal."Delivery Encounter With Age Range"

define "Numerator":
  "Delivery Encounter With Cesarean Birth"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "SDE Variable Calculated Gestational Age":
  PCMaternal."Variable Calculated Gestational Age"

define "Delivery Encounter With Cesarean Birth":
  "Singleton Delivery Encounters At 37 Plus Weeks Gravida 1 Parity 0, No Previous Births" ThirtySevenWeeksPlusEncounter
    with ["Procedure": "Cesarean Birth"] CSection
      such that CSection.performed.toInterval ( ) during ThirtySevenWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation ( )
        and CSection.status = 'completed'

define "Encounter With Genital Herpes, Placenta Previa, Vasa Previa Or Placenta Accreta Spectrum":
  "Singleton Delivery Encounters At 37 Plus Weeks Gravida 1 Parity 0, No Previous Births" ThirtySevenWeeksPlusEncounter
    where ( ThirtySevenWeeksPlusEncounter.encounterDiagnosis ( ).code in "Placenta Accreta Spectrum Previa or Vasa Previa"
        or ThirtySevenWeeksPlusEncounter.encounterDiagnosis ( ).code in "Genital Herpes"
        or ThirtySevenWeeksPlusEncounter.reasonCode in "Genital Herpes"
        or ThirtySevenWeeksPlusEncounter.reasonCode in "Placenta Accreta Spectrum Previa or Vasa Previa"
    )

define "Singleton Delivery Encounters At 37 Plus Weeks Gravida 1 Parity 0, No Previous Births":
  ( "Delivery Encounter With Gestational Age Greater Than Or Equal To 37 Weeks"
    intersect "Encounter With Singleton Delivery" ) SingletonEncounterGE37Weeks
    where ( ( SingletonEncounterGE37Weeks.lastGravida ( ) = 1 )
        or ( SingletonEncounterGE37Weeks.lastParity ( ) = 0 )
        or ( ( SingletonEncounterGE37Weeks.lastHistoryPretermBirth ( ) = 0 )
            and ( SingletonEncounterGE37Weeks.lastHistoryTermBirth ( ) = 0 )
        )
    )

define "Encounter With Abnormal Presentation":
  "Singleton Delivery Encounters At 37 Plus Weeks Gravida 1 Parity 0, No Previous Births" ThirtySevenWeeksPlusEncounter
    let LastAbnormalPresentation: Last(["SimpleObservation": "Abnormal Presentation"] AbnormalPresentation
        where AbnormalPresentation.effective.earliest() before or on ThirtySevenWeeksPlusEncounter.lastTimeOfDelivery()
          and AbnormalPresentation.status in { 'final', 'amended', 'corrected' }
        sort by effective.earliest()
    )
    where LastAbnormalPresentation.effective.earliest ( ) during ThirtySevenWeeksPlusEncounter.hospitalizationWithEDOBTriageObservation ( )
      or ThirtySevenWeeksPlusEncounter.encounterDiagnosis ( ).code in "Abnormal Presentation"
      or ThirtySevenWeeksPlusEncounter.reasonCode in "Abnormal Presentation"

define "Encounter With Singleton Delivery":
  PCMaternal."Delivery Encounter With Age Range" DeliveryEncounter
    where DeliveryEncounter.reasonCode in "Delivery of Singleton"
      or DeliveryEncounter.encounterDiagnosis ( ).code in "Delivery of Singleton"

define fluent function lastGravida(TheEncounter Encounter):
  Last(["SimpleObservation": "[#] Pregnancies"] Gravida
      where Gravida.value is not null
        and Gravida.status in { 'final', 'amended', 'corrected' }
        and Gravida.effective.earliest() 42 weeks or less before TheEncounter.lastTimeOfDelivery()
      sort by effective.earliest()
  ).value as Integer

define fluent function lastHistoryPretermBirth(TheEncounter Encounter):
  Last(["SimpleObservation": "[#] Births.preterm"] PretermBirth
      where PretermBirth.effective.earliest() 42 weeks or less before TheEncounter.lastTimeOfDelivery()
        and PretermBirth.status in { 'final', 'amended', 'corrected' }
        and PretermBirth.value is not null
      sort by effective.earliest()
  ).value as Integer

define fluent function lastHistoryTermBirth(TheEncounter Encounter):
  Last(["SimpleObservation": "[#] Births.term"] TermBirth
      where TermBirth.effective.earliest() 42 weeks or less before TheEncounter.lastTimeOfDelivery()
        and TermBirth.status in { 'final', 'amended', 'corrected' }
        and TermBirth.value is not null
      sort by effective.earliest()
  ).value as Integer

define fluent function lastParity(TheEncounter Encounter):
  Last(["SimpleObservation": "[#] Parity"] Parity
      where Parity.effective.earliest() 42 weeks or less before TheEncounter.lastTimeOfDelivery()
        and Parity.status in { 'final', 'amended', 'corrected' }
        and Parity.value is not null
      sort by effective.earliest()
  ).value as Integer