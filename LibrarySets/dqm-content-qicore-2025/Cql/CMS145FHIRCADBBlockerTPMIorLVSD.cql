library CMS145FHIRCADBBlockerTPMIorLVSD version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include AHAOverall version '4.1.000' called AHA

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Allergy to Beta Blocker Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1177'
valueset "Arrhythmia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.366'
valueset "Asthma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.362'
valueset "Atrioventricular Block": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.367'
valueset "Beta Blocker Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1174'
valueset "Beta Blocker Therapy for LVSD": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1184'
valueset "Beta Blocker Therapy Ingredient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1493'
valueset "Bradycardia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.412'
valueset "Cardiac Pacer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1178.53'
valueset "Cardiac Pacer in Situ": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.368'
valueset "Cardiac Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.371'
valueset "Care Services in Long Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014'
valueset "Coronary Artery Disease No MI": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.369'
valueset "Ejection Fraction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1134'
valueset "Face-to-Face Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Hypotension": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.370'
valueset "Intolerance to Beta Blocker Therapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1178'
valueset "Medical Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1007'
valueset "Moderate or Severe": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1092'
valueset "Moderate or Severe LVSD": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1090'
valueset "Myocardial Infarction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.403'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Patient Provider Interaction": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1012'
valueset "Patient Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1008'
valueset "System Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1009'

code "Substance with beta adrenergic receptor antagonist mechanism of action (substance)": '373254001' from "SNOMEDCT" display 'Substance with beta adrenergic receptor antagonist mechanism of action (substance)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Denominator 2":
  "Initial Population"
    and exists "Qualifying CAD Encounter and Prior MI"

define "Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI without Cardiac Pacer":
  "Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI"
    and not "Has Diagnosis of Cardiac Pacer in Situ with Qualifying CAD Encounter and Prior MI"
    and not "Has Cardiac Pacer Device Implanted with Qualifying CAD Encounter and Prior MI"

/*
* @code: Heart rate - 8867-4
* @profile: http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate 
*/


define "Has Consecutive Heart Rates Less than 50 with Qualifying CAD Encounter and Prior MI":
  exists ( from
      ["USCoreHeartRateProfile"] HeartRateExam,
      "Qualifying CAD Encounter and Prior MI" CADEncounterMI
      let PriorHeartRateExam: Last(["USCoreHeartRateProfile"] MostRecentPriorHeartRateExam
          where MostRecentPriorHeartRateExam.effective.toInterval() during CADEncounterMI.period
            and MostRecentPriorHeartRateExam.status in { 'final', 'amended', 'corrected' }
            and MostRecentPriorHeartRateExam.effective.toInterval() before HeartRateExam.effective.toInterval()
          sort by start of effective.toInterval()
      )
      where HeartRateExam.effective.toInterval ( ) during CADEncounterMI.period
        and HeartRateExam.status in { 'final', 'amended', 'corrected' }
        and HeartRateExam.value < 50 '/min'
        and PriorHeartRateExam.value < 50 '/min'
  )

define "Numerator 1":
  "Has Beta Blocker Therapy for LVSD Ordered"
    or "Is Currently Taking Beta Blocker Therapy for LVSD"

define "Numerator 2":
  "Has Beta Blocker Therapy Ordered"
    or "Is Currently Taking Beta Blocker Therapy"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Has Cardiac Pacer Device Implanted with Qualifying CAD Encounter and Prior MI":
  exists ( [Procedure: "Cardiac Pacer"] ImplantedCardiacPacer
      with "Qualifying CAD Encounter and Prior MI" CADEncounterMI
        such that ImplantedCardiacPacer.performed.toInterval ( ) starts before end of CADEncounterMI.period
          and ImplantedCardiacPacer.status = 'completed'
  )

define "Qualifying CAD Encounter and Prior MI":
  "Qualifying CAD Encounter" EncounterWithCADProxy
    with ( [ConditionProblemsHealthConcerns: "Myocardial Infarction"]
      union [ConditionEncounterDiagnosis: "Myocardial Infarction"] ) MyocardialInfarction
      such that MyocardialInfarction.prevalenceInterval ( ) starts 3 years or less before day of start of EncounterWithCADProxy.period
        and not exists AHA."Moderate or Severe LVSD Findings"
        and MyocardialInfarction.isVerified ( )

define "Denominator 1":
  "Initial Population"
    and exists "Qualifying CAD Encounter and History of Moderate or Severe LVSD"

define "Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD without Cardiac Pacer":
  "Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    and not "Has Diagnosis of Cardiac Pacer in Situ with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    and not "Has Cardiac Pacer Device Implanted with Qualifying CAD Encounter and History of Moderate or Severe LVSD"

/*
* @code: Heart rate - 8867-4
* @profile: http://hl7.org/fhir/us/core/StructureDefinition/us-core-heart-rate
*/


define "Has Consecutive Heart Rates Less than 50 with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( from
      ["USCoreHeartRateProfile"] HeartRateExam,
      "Qualifying CAD Encounter and History of Moderate or Severe LVSD" CADEncounterModerateOrSevereLVSD
      let PriorHeartRateExam: Last(["USCoreHeartRateProfile"] MostRecentPriorHeartRateExam
          where MostRecentPriorHeartRateExam.effective.toInterval() during CADEncounterModerateOrSevereLVSD.period
            and MostRecentPriorHeartRateExam.status in { 'final', 'amended', 'corrected' }
            and MostRecentPriorHeartRateExam.effective.toInterval() before HeartRateExam.effective.toInterval()
          sort by start of effective.toInterval()
      )
      where HeartRateExam.effective.toInterval ( ) during CADEncounterModerateOrSevereLVSD.period
        and HeartRateExam.status in { 'final', 'amended', 'corrected' }
        and HeartRateExam.value < 50 '/min'
        and PriorHeartRateExam.value < 50 '/min'
  )

define "Has Cardiac Pacer Device Implanted with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( [Procedure: "Cardiac Pacer"] ImplantedCardiacPacer
      with "Qualifying CAD Encounter and History of Moderate or Severe LVSD" CADEncounterModerateOrSevereLVSD
        such that ImplantedCardiacPacer.performed.toInterval ( ) starts before end of CADEncounterModerateOrSevereLVSD.period
  )

define "Has Diagnosis of Cardiac Pacer in Situ with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( [ConditionProblemsHealthConcerns: "Cardiac Pacer in Situ"] CardiacPacerDiagnosis
      where CardiacPacerDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Diagnosis of Cardiac Pacer in Situ with Qualifying CAD Encounter and Prior MI":
  exists ( [ConditionProblemsHealthConcerns: "Cardiac Pacer in Situ"] CardiacPacerDiagnosis
      where CardiacPacerDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Has Allergy or Intolerance to Beta Blocker Therapy Ingredient with Qualifying CAD Encounter and Prior MI":
  exists ( ( [AllergyIntolerance: "Beta Blocker Therapy Ingredient"]
      union [AllergyIntolerance: "Substance with beta adrenergic receptor antagonist mechanism of action (substance)"] ) BetaBlockerAllergyIntolerance
      where BetaBlockerAllergyIntolerance.overlapsAfterDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Has Beta Blocker Therapy for LVSD Ordered":
  exists ( [MedicationRequest: medication in "Beta Blocker Therapy for LVSD"] BetaBlockerForLVSDOrdered
      where BetaBlockerForLVSDOrdered.authoredDuringDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Beta Blocker Therapy Ordered":
  exists ( [MedicationRequest: medication in "Beta Blocker Therapy"] BetaBlockerOrdered
      where BetaBlockerOrdered.authoredDuringDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Is Currently Taking Beta Blocker Therapy":
  exists ( [MedicationRequest: medication in "Beta Blocker Therapy"] ActiveBetaBlocker
      with "Qualifying CAD Encounter and Prior MI" CADEncounterMI
        such that First((collapse(ActiveBetaBlocker.dosageInstruction.timing.repeat.bounds DoseTime
              return DoseTime.toInterval()
          )) DrugPeriod
            sort by start of $this
        ) overlaps after day of CADEncounterMI.period
      where ActiveBetaBlocker.status in { 'active', 'completed' }
        and ActiveBetaBlocker.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
  )

define "Is Currently Taking Beta Blocker Therapy for LVSD":
  exists ( [MedicationRequest: medication in "Beta Blocker Therapy for LVSD"] ActiveBetaBlockerForLVSD
      with "Qualifying CAD Encounter and History of Moderate or Severe LVSD" CADEncounterModerateOrSevereLVSD
        such that First((collapse(ActiveBetaBlockerForLVSD.dosageInstruction.timing.repeat.bounds DoseTime
              return DoseTime.toInterval()
          )) DrugPeriod
            sort by start of $this
        ) overlaps after day of CADEncounterModerateOrSevereLVSD.period
      where ActiveBetaBlockerForLVSD.status in { 'active', 'completed' }
        and ActiveBetaBlockerForLVSD.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
  )

define "Outpatient Encounter During Measurement Period":
  ( [Encounter: "Office Visit"]
    union [Encounter: "Outpatient Consultation"]
    union [Encounter: "Care Services in Long Term Residential Facility"]
    union [Encounter: "Home Healthcare Services"]
    union [Encounter: "Nursing Facility Visit"] ) QualifyingEncounter
    where QualifyingEncounter.period during day of "Measurement Period"
      and QualifyingEncounter.status = 'finished'

define "Qualifying Encounter During Measurement Period":
  ( [Encounter: "Office Visit"]
    union [Encounter: "Outpatient Consultation"]
    union [Encounter: "Nursing Facility Visit"]
    union [Encounter: "Care Services in Long Term Residential Facility"]
    union [Encounter: "Home Healthcare Services"]
    union [Encounter: "Patient Provider Interaction"] ) ValidEncounter
    where ValidEncounter.period during day of "Measurement Period"
      and ValidEncounter.status = 'finished'

define "Coronary Artery Disease Encounter":
  "Outpatient Encounter During Measurement Period" ValidQualifyingEncounter
    with ( [ConditionProblemsHealthConcerns: "Coronary Artery Disease No MI"]
      union [ConditionEncounterDiagnosis: "Coronary Artery Disease No MI"] ) CoronaryArteryDisease
      such that CoronaryArteryDisease.overlapsDayOfEncounter ( ValidQualifyingEncounter )

define "Has Arrhythmia with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( [ConditionProblemsHealthConcerns: "Arrhythmia"] ArrhythmiaDiagnosis
      where ArrhythmiaDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Arrhythmia with Qualifying CAD Encounter and Prior MI":
  exists ( [ConditionProblemsHealthConcerns: "Arrhythmia"] ArrhythmiaDiagnosis
      where ArrhythmiaDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Has Asthma with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( [ConditionProblemsHealthConcerns: "Asthma"] AsthmaDiagnosis
      where AsthmaDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Asthma with Qualifying CAD Encounter and Prior MI":
  exists ( [ConditionProblemsHealthConcerns: "Asthma"] AsthmaDiagnosis
      where AsthmaDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( [ConditionProblemsHealthConcerns: "Atrioventricular Block"] AtrioventricularBlock
      where AtrioventricularBlock.overlapsDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI":
  exists ( [ConditionProblemsHealthConcerns: "Atrioventricular Block"] AtrioventricularBlockDiagnosis
      where AtrioventricularBlockDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Has Bradycardia with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( [ConditionProblemsHealthConcerns: "Bradycardia"] BradycardiaDiagnosis
      where BradycardiaDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Bradycardia with Qualifying CAD Encounter and Prior MI":
  exists ( [ConditionProblemsHealthConcerns: "Bradycardia"] BradycardiaDiagnosis
      where BradycardiaDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( ( [ConditionProblemsHealthConcerns: "Allergy to Beta Blocker Therapy"]
      union [ConditionProblemsHealthConcerns: "Intolerance to Beta Blocker Therapy"] ) BetaBlockerAllergyOrIntoleranceDiagnosis
      where BetaBlockerAllergyOrIntoleranceDiagnosis.overlapsAfterDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy with Qualifying CAD Encounter and Prior MI":
  exists ( ( [ConditionProblemsHealthConcerns: "Allergy to Beta Blocker Therapy"]
      union [ConditionProblemsHealthConcerns: "Intolerance to Beta Blocker Therapy"] ) BetaBlockerAllergyOrIntoleranceDiagnosis
      where BetaBlockerAllergyOrIntoleranceDiagnosis.overlapsAfterDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Has Hypotension with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( [ConditionProblemsHealthConcerns: "Hypotension"] HypotensionDiagnosis
      where HypotensionDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Hypotension with Qualifying CAD Encounter and Prior MI":
  exists ( ( [ConditionProblemsHealthConcerns: "Hypotension"]
      union [ConditionEncounterDiagnosis: "Hypotension"] ) HypotensionDiagnosis
      where HypotensionDiagnosis.overlapsDayOfEncounter ( "Qualifying CAD Encounter and Prior MI" )
  )

define "Denominator Exceptions 1":
  "Has Arrhythmia with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    or "Has Asthma with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    or "Has Bradycardia with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    or "Has Hypotension with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    or "Has Consecutive Heart Rates Less than 50 with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    or "Has Allergy or Intolerance to Beta Blocker Therapy Ingredient with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    or "Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy with Qualifying CAD Encounter and History of Moderate or Severe LVSD"
    or "Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD"
    or "Has Atrioventricular Block with Qualifying CAD Encounter and History of Moderate or Severe LVSD without Cardiac Pacer"

define "Denominator Exceptions 2":
  "Has Arrhythmia with Qualifying CAD Encounter and Prior MI"
    or "Has Asthma with Qualifying CAD Encounter and Prior MI"
    or "Has Bradycardia with Qualifying CAD Encounter and Prior MI"
    or "Has Hypotension with Qualifying CAD Encounter and Prior MI"
    or "Has Consecutive Heart Rates Less than 50 with Qualifying CAD Encounter and Prior MI"
    or "Has Allergy or Intolerance to Beta Blocker Therapy Ingredient with Qualifying CAD Encounter and Prior MI"
    or "Has Diagnosis of Allergy or Intolerance to Beta Blocker Therapy with Qualifying CAD Encounter and Prior MI"
    or "Has Medical or Patient Reason for Not Ordering Beta Blocker Therapy"
    or "Has Atrioventricular Block with Qualifying CAD Encounter and Prior MI without Cardiac Pacer"

define "Has Allergy or Intolerance to Beta Blocker Therapy Ingredient with Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  exists ( ( [AllergyIntolerance: "Beta Blocker Therapy Ingredient"]
      union [AllergyIntolerance: "Substance with beta adrenergic receptor antagonist mechanism of action (substance)"] ) BetaBlockerAllergyIntolerance
      where BetaBlockerAllergyIntolerance.overlapsAfterDayOfEncounter ( "Qualifying CAD Encounter and History of Moderate or Severe LVSD" )
  )

define "Has Medical or Patient Reason for Not Ordering Beta Blocker for LVSD":
  exists ( [MedicationNotRequested: medication in "Beta Blocker Therapy for LVSD"] NoBetaBlockerForLVSDOrdered
      with "Qualifying CAD Encounter and History of Moderate or Severe LVSD" LVSDVisit
        such that NoBetaBlockerForLVSDOrdered.authoredOn during day of LVSDVisit.period
      where NoBetaBlockerForLVSDOrdered.status in { 'active', 'completed' }
        and NoBetaBlockerForLVSDOrdered.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and ( NoBetaBlockerForLVSDOrdered.reasonCode in "Medical Reason"
            or NoBetaBlockerForLVSDOrdered.reasonCode in "Patient Reason"
        )
  )

define "Has Medical or Patient Reason for Not Ordering Beta Blocker Therapy":
  exists ( [MedicationNotRequested: medication in "Beta Blocker Therapy for LVSD"] NoBetaBlockerForLVSDOrdered
      with "Qualifying CAD Encounter and Prior MI" PriorMIVisit
        such that NoBetaBlockerForLVSDOrdered.authoredOn during day of PriorMIVisit.period
      where NoBetaBlockerForLVSDOrdered.status in { 'active', 'completed' }
        and NoBetaBlockerForLVSDOrdered.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
        and ( NoBetaBlockerForLVSDOrdered.reasonCode in "Medical Reason"
            or NoBetaBlockerForLVSDOrdered.reasonCode in "Patient Reason"
        )
  )

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") >= 18
    and exists ( "Qualifying Encounter During Measurement Period" Encounter1
        with "Qualifying Encounter During Measurement Period" Encounter2
          such that Encounter2.id !~ Encounter1.id
    )
    and exists "Qualifying CAD Encounter"

define "Qualifying CAD Encounter and History of Moderate or Severe LVSD":
  "Qualifying CAD Encounter" EncounterWithCADProxy
    with AHA."Moderate or Severe LVSD Findings" LVSDFindings
      such that Coalesce(LVSDFindings.prevalenceInterval(), LVSDFindings.effective.toInterval()) starts before end of EncounterWithCADProxy.period

define "History of Cardiac Surgery Prior to Encounter":
  "Outpatient Encounter During Measurement Period" ValidQualifyingEncounter
    with [Procedure: "Cardiac Surgery"] CardiacSurgeryProcedure
      such that CardiacSurgeryProcedure.performed.toInterval ( ) starts before end of ValidQualifyingEncounter.period
        and CardiacSurgeryProcedure.status = 'completed'

define "Qualifying CAD Encounter":
  "Coronary Artery Disease Encounter"
    union "History of Cardiac Surgery Prior to Encounter"

define fluent function overlapsDayOfEncounter(Diagnosis ConditionProblemsHealthConcerns, EncounterList List<Encounter>):
  AnyTrue(EncounterList Visit
      return Diagnosis.overlapsDayOfEncounter(Visit)
  )

define fluent function overlapsDayOfEncounter(Diagnosis ConditionProblemsHealthConcerns, TheEncounter Encounter):
  TheEncounter Visit
    where Diagnosis.isVerified ( )
    return Diagnosis.prevalenceInterval ( ) overlaps day of Visit.period

define fluent function overlapsAfterDayOfEncounter(Event Choice<AllergyIntolerance, ConditionProblemsHealthConcerns>, EncounterList List<Encounter>):
  AnyTrue(EncounterList Visit
      return
      case
        when Event is AllergyIntolerance then Interval[start of Event.onset.toInterval(), Event.lastOccurrence]overlaps after day of Visit.period
          and(Event.clinicalStatus is null
              or Event.clinicalStatus ~ QICoreCommon."allergy-active"
          )
          and(Event.verificationStatus is null
              or Event.verificationStatus ~ QICoreCommon."allergy-confirmed"
          )
        when Event is ConditionProblemsHealthConcerns then Event.isVerified()
          and Event.prevalenceInterval() overlaps after day of Visit.period 
        else false 
      end
  )

define fluent function authoredDuringDayOfEncounter(Order Choice<MedicationRequest, MedicationNotRequested>, EncounterList List<Encounter>):
  AnyTrue(EncounterList Visit
      return
      case
        when Order is MedicationRequest then Order.authoredOn during day of Visit.period
          and Order.status in { 'active', 'completed' }
          and Order.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' }
          and Order.doNotPerform is not true
        when Order is MedicationNotRequested then Order.authoredOn during day of Visit.period
          and Order.intent in { 'order', 'original-order', 'reflex-order', 'filler-order', 'instance-order' } 
        else false 
      end
  )