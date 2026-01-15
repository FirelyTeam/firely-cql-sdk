library CMS136FHIRChildADHDMedFollowUp version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon
include CQMCommon version '4.1.000' called CQMCommon
include Hospice version '6.18.000' called Hospice
include CumulativeMedicationDuration version '6.0.000' called CMD
include Status version '1.15.000' called Status

codesystem "RXNORM": 'http://www.nlm.nih.gov/research/umls/rxnorm'

valueset "Ambulatory": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.122.12.1003'
valueset "Atomoxetine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1170'
valueset "Behavioral Health Follow up Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1054'
valueset "Clonidine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1171'
valueset "Dexmethylphenidate": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1172'
valueset "Dextroamphetamine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1173'
valueset "Encounter Inpatient": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.307'
valueset "Guanfacine Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Lisdexamfetamine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1174'
valueset "Mental Behavioral and Neurodevelopmental Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1203'
valueset "Methylphenidate": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1176'
valueset "Narcolepsy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.114.12.1011'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Outpatient Consultation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008'
valueset "Preventive Care Services Group Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1027'
valueset "Preventive Care Services Individual Counseling": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1026'
valueset "Preventive Care Services, Initial Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022'
valueset "Preventive Care, Established Office Visit, 0 to 17": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024'
valueset "Psych Visit Diagnostic Evaluation": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1492'
valueset "Psych Visit Psychotherapy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1496'
valueset "Psychotherapy and Pharmacologic Management": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1055'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Viloxazine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1260'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'

code "methamphetamine hydrochloride 5 MG Oral Tablet": '977860' from "RXNORM" display 'methamphetamine hydrochloride 5 MG Oral Tablet'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population 1":
  AgeInYearsAt(date from start of "Intake Period") >= 6
    and AgeInYearsAt(date from 
      end of "Intake Period"
    ) <= 12
    and exists "Qualifying Encounter"
    and "First ADHD Medication Prescribed During Intake Period" is not null
    and not exists "Inpatient Stay with Qualifying Diagnosis During Initiation Phase"

define "Intake Period":
  Interval["March 1 of Year Prior to Measurement Period", "Last Calendar Day of February of Measurement Period"]

define "Last Calendar Day of February of Measurement Period":
  ( DateTime(year from start of "Measurement Period", 3, 1, 23, 59, 59, 0, 0) ) - 1 day

define "March 1 of Year Prior to Measurement Period":
  DateTime((year from start of "Measurement Period" - 1), 3, 1, 0, 0, 0, 0, 0)

define "Qualifying Encounter":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
      union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
  ).isEncounterPerformed ( ) ) ValidEncounters
    where CQMCommon."ToDateInterval" ( ValidEncounters.period ) during day of Interval["IPSD" - 6 months, "IPSD"]

    /*Index Prescription Start Date (IPSD)*/


define "IPSD":
  "First ADHD Medication Prescribed During Intake Period"

define "First ADHD Medication Prescribed During Intake Period":
  First("ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication".startDate)

define "ADHD Medication Prescribed During Intake Period and Not Previously on ADHD Medication":
  ( ( ( ( [MedicationRequest: "Atomoxetine"]
      union [MedicationRequest: "Clonidine"]
      union [MedicationRequest: "Dexmethylphenidate"]
      union [MedicationRequest: "Dextroamphetamine"]
      union [MedicationRequest: "Lisdexamfetamine"]
      union [MedicationRequest: "methamphetamine hydrochloride 5 MG Oral Tablet"]
      union [MedicationRequest: "Methylphenidate"]
      union [MedicationRequest: "Guanfacine Medications"]
      union [MedicationRequest: "Viloxazine"]
  ).isMedicationOrder ( ) ) ADHDMedications
    where ADHDMedications.medicationRequestPeriod ( ) starts during "Intake Period" ) ADHDMedicationOrder
    without ( ( [MedicationRequest: "Atomoxetine"]
        union [MedicationRequest: "Clonidine"]
        union [MedicationRequest: "Dexmethylphenidate"]
        union [MedicationRequest: "Dextroamphetamine"]
        union [MedicationRequest: "Lisdexamfetamine"]
        union [MedicationRequest: "methamphetamine hydrochloride 5 MG Oral Tablet"]
        union [MedicationRequest: "Methylphenidate"]
        union [MedicationRequest: "Guanfacine Medications"]
        union [MedicationRequest: "Viloxazine"]
    ).isMedicationActive ( ) ) ActiveADHDMedication
      such that ActiveADHDMedication.medicationRequestPeriod ( ) overlaps Interval[date from start of ADHDMedicationOrder.medicationRequestPeriod ( ) - 120 days, date from start of ADHDMedicationOrder.medicationRequestPeriod ( ) ) ) QualifyingMed
    return all {
      startDate: start of QualifyingMed.medicationRequestPeriod ( )
    }
    sort by startDate asc

define "Inpatient Stay with Qualifying Diagnosis During Initiation Phase":
  "Inpatient Stay with Qualifying Diagnosis" InpatientStay
    where CQMCommon."ToDateInterval" ( InpatientStay.period ) starts 30 days or less after day of "IPSD"

define "Inpatient Stay with Qualifying Diagnosis":
  ( ( [Encounter: "Encounter Inpatient"] ).isEncounterPerformed ( ) ) InpatientStay
    where InpatientStay.hasPrincipalDiagnosisOf ( "Mental Behavioral and Neurodevelopmental Disorders" )

define "Denominator 1":
  "Initial Population 1"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists "Narcolepsy Exclusion"

define "Narcolepsy Exclusion":
  ( ( [ConditionProblemsHealthConcerns: "Narcolepsy"]
      union [ConditionEncounterDiagnosis: "Narcolepsy"]
  ).verified ( ) ) NarcolepsyDx
    where NarcolepsyDx.prevalenceInterval ( ) starts on or before end of "Measurement Period"

define "Numerator 1":
  exists "Encounter During Initiation Phase"

define "Encounter During Initiation Phase":
  ( "Qualifying Numerator Encounter".isEncounterPerformed ( ) ) ValidNumeratorEncounter
    where CQMCommon."ToDateInterval" ( ValidNumeratorEncounter.period ) starts 30 days or less after day of "IPSD"

define "Qualifying Numerator Encounter":
  [Encounter: "Office Visit"]
    union [Encounter: "Preventive Care Services Group Counseling"]
    union [Encounter: "Behavioral Health Follow up Visit"]
    union [Encounter: "Preventive Care Services Individual Counseling"]
    union ( [Encounter: "Psychotherapy and Pharmacologic Management"] PsychPharmManagement
        where exists ( PsychPharmManagement.location Location
            where CQMCommon."GetLocation" ( Location.location ).type in "Ambulatory"
        )
    )
    union [Encounter: "Outpatient Consultation"]
    union [Encounter: "Home Healthcare Services"]
    union [Encounter: "Preventive Care Services, Initial Office Visit, 0 to 17"]
    union [Encounter: "Preventive Care, Established Office Visit, 0 to 17"]
    union [Encounter: "Psych Visit Diagnostic Evaluation"]
    union [Encounter: "Psych Visit Psychotherapy"]
    union [Encounter: "Telephone Visits"]

define "Initial Population 2":
  AgeInYearsAt(date from start of "Intake Period") >= 6
    and AgeInYearsAt(date from 
      end of "Intake Period"
    ) <= 12
    and exists "Qualifying Encounter"
    and "First ADHD Medication Prescribed During Intake Period" is not null
    and "Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days"
    and not exists "Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase"

define "Has ADHD Cumulative Medication Duration Greater Than or Equal to 210 Days":
  "ADHD Cumulative Medication Duration" >= 210

define "ADHD Cumulative Medication Duration":
  ( "ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase" ).cumulativeDuration ( )

define "Inpatient Stay with Qualifying Diagnosis During Continuation and Maintenance Phase":
  "Inpatient Stay with Qualifying Diagnosis" InpatientStay
    where CQMCommon."ToDateInterval" ( InpatientStay.period ) starts 300 days or less after day of "IPSD"

define "ADHD Medications Taken on IPSD or During Continuation and Maintenance Phase":
  ( ( ( ( ( ( [MedicationRequest: "Atomoxetine"] ).isMedicationOrder ( ) ) AtomoxetineMed
          return all {
            period: AtomoxetineMed.medicationRequestPeriod ( ),
            periodStart: start of AtomoxetineMed.medicationRequestPeriod ( )
          }
          sort by periodStart
      ).period
    ).rolloutIntervals ( )
  )
    union ( ( ( ( ( [MedicationRequest: "Clonidine"] ).isMedicationOrder ( ) ) ClonidineMed
            return all {
              period: ClonidineMed.medicationRequestPeriod ( ),
              periodStart: start of ClonidineMed.medicationRequestPeriod ( )
            }
            sort by periodStart
        ).period
      ).rolloutIntervals ( )
    )
    union ( ( ( ( ( [MedicationRequest: "Dexmethylphenidate"] ).isMedicationOrder ( ) ) DexmethylphenidateMed
            return all {
              period: DexmethylphenidateMed.medicationRequestPeriod ( ),
              periodStart: start of DexmethylphenidateMed.medicationRequestPeriod ( )
            }
            sort by periodStart
        ).period
      ).rolloutIntervals ( )
    )
    union ( ( ( ( ( [MedicationRequest: "Dextroamphetamine"] ).isMedicationOrder ( ) ) DextroamphetamineMed
            return all {
              period: DextroamphetamineMed.medicationRequestPeriod ( ),
              periodStart: start of DextroamphetamineMed.medicationRequestPeriod ( )
            }
            sort by periodStart
        ).period
      ).rolloutIntervals ( )
    )
    union ( ( ( ( ( [MedicationRequest: "Lisdexamfetamine"] ).isMedicationOrder ( ) ) LisdexamfetamineMed
            return all {
              period: LisdexamfetamineMed.medicationRequestPeriod ( ),
              periodStart: start of LisdexamfetamineMed.medicationRequestPeriod ( )
            }
            sort by periodStart
        ).period
      ).rolloutIntervals ( )
    )
    union ( ( ( ( ( [MedicationRequest: "Methylphenidate"] ).isMedicationOrder ( ) ) MethylphenidateMed
            return all {
              period: MethylphenidateMed.medicationRequestPeriod ( ),
              periodStart: start of MethylphenidateMed.medicationRequestPeriod ( )
            }
            sort by periodStart
        ).period
      ).rolloutIntervals ( )
    )
    union ( ( ( ( ( [MedicationRequest: "Guanfacine Medications"] ).isMedicationOrder ( ) ) GuanfacineMed
            return all {
              period: GuanfacineMed.medicationRequestPeriod ( ),
              periodStart: start of GuanfacineMed.medicationRequestPeriod ( )
            }
            sort by periodStart
        ).period
      ).rolloutIntervals ( )
    )
    union ( ( ( ( ( [MedicationRequest: "methamphetamine hydrochloride 5 MG Oral Tablet"] ).isMedicationOrder ( ) ) MethamphetamineMed
            return all {
              period: MethamphetamineMed.medicationRequestPeriod ( ),
              periodStart: start of MethamphetamineMed.medicationRequestPeriod ( )
            }
            sort by periodStart
        ).period
      ).rolloutIntervals ( )
    )
    union ( ( ( ( ( [MedicationRequest: "Viloxazine"] ).isMedicationOrder ( ) ) ViloxazineMed
            return all {
              period: ViloxazineMed.medicationRequestPeriod ( ),
              periodStart: start of ViloxazineMed.medicationRequestPeriod ( )
            }
            sort by periodStart
        ).period
      ).rolloutIntervals ( )
    ) ) ADHDMedication
    let IPSDAndContinuationMaintenancePhase: Interval["IPSD", "IPSD" + 300 days]
    return all ADHDMedication
      intersect IPSDAndContinuationMaintenancePhase

define "Denominator 2":
  "Initial Population 2"

define "Numerator 2":
  exists "Encounter During Initiation Phase"
    and ( "Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase"
        or ( exists "Encounter 31 to 300 Days into Continuation and Maintenance Phase" Encounter1
            with "Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase" Encounter2
              such that Encounter1 is not null
                and Encounter2 is not null
                and Encounter1 !~ Encounter2
        )
    )

define "Two or More Encounters 31 to 300 Days into Continuation and Maintenance Phase":
  Count("Encounter 31 to 300 Days into Continuation and Maintenance Phase") >= 2

define "Encounter 31 to 300 Days into Continuation and Maintenance Phase":
  ( "Qualifying Numerator Encounter".isEncounterPerformed ( ) ) ValidNumeratorEncounter
    where CQMCommon."ToDateInterval" ( ValidNumeratorEncounter.period ) starts during day of Interval["IPSD" + 31 days, "IPSD" + 300 days]
    return date from start of ValidNumeratorEncounter.period

define "Virtual Encounter 31 to 300 Days into Continuation and Maintenance Phase":
  ( ( [Encounter: "Virtual Encounter"] ).isEncounterPerformed ( ) ) VirtualEnc
    where CQMCommon."ToDateInterval" ( VirtualEnc.period ) starts during day of Interval["IPSD" + 31 days, "IPSD" + 300 days]
    return date from start of VirtualEnc.period

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"