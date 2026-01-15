library CMS156FHIRHighRiskMedsElderly version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include CQMCommon version '4.1.000' called CQMCommon
include Hospice version '6.18.000' called Hospice
include PalliativeCare version '1.18.000' called PalliativeCare
include CumulativeMedicationDuration version '6.0.000' called CMD
include QICoreCommon version '4.0.000' called QICoreCommon
include Status version '1.15.000' called Status

codesystem "RXNORM": 'http://www.nlm.nih.gov/research/umls/rxnorm'
codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Alcohol Withdrawal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209'
valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Benzodiazepine Withdrawal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208'
valueset "Bipolar Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.67.1.101.1.128'
valueset "Care Services in Long Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014'
valueset "Desiccated Thyroid Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060'
valueset "Digoxin Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065'
valueset "Dipyridamole Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051'
valueset "Discharge Services Nursing Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013'
valueset "Doxepin Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067'
valueset "Generalized Anxiety Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210'
valueset "Guanfacine Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.11.1252'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Megestrol Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1247'
valueset "Meperidine Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1248'
valueset "Meprobamate Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057'
valueset "Nifedipine Medications": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Ophthalmological Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1285'
valueset "Potentially Harmful Antidepressants for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054'
valueset "Potentially Harmful Antihistamines for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043'
valueset "Potentially Harmful Antiinfectives for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481'
valueset "Potentially Harmful Antiparkinsonian Agents for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049'
valueset "Potentially Harmful Antipsychotics for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523'
valueset "Potentially Harmful Barbiturates for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055'
valueset "Potentially Harmful Benzodiazepines for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522'
valueset "Potentially Harmful Estrogens for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058'
valueset "Potentially Harmful Gastrointestinal Antispasmodics for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050'
valueset "Potentially Harmful Nonbenzodiazepine Hypnotics for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480'
valueset "Potentially Harmful Pain Medications for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063'
valueset "Potentially Harmful Skeletal Muscle Relaxants for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062'
valueset "Potentially Harmful Sulfonylureas for Older Adults": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "REM Sleep Behavior Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207'
valueset "Schizophrenia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205'
valueset "Seizure Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'

code "1 ML digoxin 0.1 MG/ML Injection": '204504' from "RXNORM" display '1 ML digoxin 0.1 MG/ML Injection'
code "2 ML digoxin 0.25 MG/ML Injection": '104208' from "RXNORM" display '2 ML digoxin 0.25 MG/ML Injection'
code "digoxin 0.05 MG/ML Oral Solution": '393245' from "RXNORM" display 'digoxin 0.05 MG/ML Oral Solution'
code "digoxin 0.0625 MG Oral Tablet": '245273' from "RXNORM" display 'digoxin 0.0625 MG Oral Tablet'
code "digoxin 0.125 MG Oral Tablet": '197604' from "RXNORM" display 'digoxin 0.125 MG Oral Tablet'
code "digoxin 0.25 MG Oral Tablet": '197606' from "RXNORM" display 'digoxin 0.25 MG Oral Tablet'
code "doxepin 10 MG Oral Capsule": '1000048' from "RXNORM" display 'doxepin 10 MG Oral Capsule'
code "doxepin 10 MG/ML Oral Solution": '1000054' from "RXNORM" display 'doxepin 10 MG/ML Oral Solution'
code "doxepin 100 MG Oral Capsule": '1000058' from "RXNORM" display 'doxepin 100 MG Oral Capsule'
code "doxepin 150 MG Oral Capsule": '1000064' from "RXNORM" display 'doxepin 150 MG Oral Capsule'
code "doxepin 25 MG Oral Capsule": '1000070' from "RXNORM" display 'doxepin 25 MG Oral Capsule'
code "doxepin 3 MG Oral Tablet": '966787' from "RXNORM" display 'doxepin 3 MG Oral Tablet'
code "doxepin 50 MG Oral Capsule": '1000076' from "RXNORM" display 'doxepin 50 MG Oral Capsule'
code "doxepin 6 MG Oral Tablet": '966793' from "RXNORM" display 'doxepin 6 MG Oral Tablet'
code "doxepin 75 MG Oral Capsule": '1000097' from "RXNORM" display 'doxepin 75 MG Oral Capsule'
code "ergoloid mesylates, USP 1 MG Oral Tablet": '318179' from "RXNORM" display 'ergoloid mesylates, USP 1 MG Oral Tablet'
code "Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional": '99211' from "CPT" display 'Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Initial Population":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) >= 65
    and exists "Qualifying Encounters"

define "Qualifying Encounters":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Ophthalmological Services"]
      union [Encounter: "Preventive Care Services Established Office Visit, 18 and Up"]
      union [Encounter: "Discharge Services Nursing Facility"]
      union [Encounter: "Nursing Facility Visit"]
      union [Encounter: "Care Services in Long Term Residential Facility"]
      union [Encounter: "Preventive Care Services Initial Office Visit, 18 and Up"]
      union [Encounter: "Annual Wellness Visit"]
      union [Encounter: "Home Healthcare Services"]
      union [Encounter: "Telephone Visits"]
      union [Encounter: "Virtual Encounter"]
      union ( [Encounter] E
          where exists ( ( E.type ) T
              where T ~ "Office or other outpatient visit for the evaluation and management of an established patient that may not require the presence of a physician or other qualified health care professional"
          )
      )
  ).isEncounterPerformed ( ) ) ValidEncounters
    where ValidEncounters.period during "Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator 1":
  exists "Same High Risk Medications Ordered on Different Days"
    or "Two High Risk Medications with Prolonged Duration"
    or "High Risk Medications with Average Daily Dose Criteria"

define "Same High Risk Medications Ordered on Different Days":
  ( [MedicationRequest: "Potentially Harmful Antihistamines for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Antiparkinsonian Agents for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Gastrointestinal Antispasmodics for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Dipyridamole Medications"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Guanfacine Medications"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Nifedipine Medications"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Antidepressants for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Barbiturates for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "ergoloid mesylates, USP 1 MG Oral Tablet"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Meprobamate Medications"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Estrogens for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Sulfonylureas for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Desiccated Thyroid Medications"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Nonbenzodiazepine Hypnotics for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Skeletal Muscle Relaxants for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Potentially Harmful Pain Medications for Older Adults"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Megestrol Medications"] ).moreThanOneOrder ( )
    union ( [MedicationRequest: "Meperidine Medications"] ).moreThanOneOrder ( )

define "Two High Risk Medications with Prolonged Duration":
  Sum((([MedicationRequest: "Potentially Harmful Antiinfectives for Older Adults"]).moreThanOneOrder()) AntiInfectives
      let DaysSupply: AntiInfectives.medicationRequestPeriodInDays()
      return all DaysSupply
  ) > 90

define "High Risk Medications with Average Daily Dose Criteria":
  exists ( ( [MedicationRequest: "Digoxin Medications"] DigoxinOrdered
        where DigoxinOrdered.averageDailyDose ( ) > 0.125 'mg/d'
    ).moreThanOneOrder ( )
  )
    or exists ( ( [MedicationRequest: "Doxepin Medications"] DoxepinOrdered
          where DoxepinOrdered.averageDailyDose ( ) > 6 'mg/d'
      ).moreThanOneOrder ( )
    )

define "Numerator 2":
  ( "More than One Antipsychotic Order"
      and ( not exists ( ( "Schizophrenia Diagnosis"
            union "Bipolar Disorder Diagnosis" ) AntipsychoticTreatedDiagnoses
            where AntipsychoticTreatedDiagnoses.prevalenceInterval ( ) overlaps Interval[start of "Measurement Period" - 1 year, "Antipsychotic Index Prescription Start Date"]
        )
      )
  )
    or ( "More than One Benzodiazepine Order"
        and ( not exists ( ( "Seizure Disorder Diagnosis"
              union "REM Sleep Behavior Disorder Diagnosis"
              union "Benzodiazepine Withdrawal Diagnosis"
              union "Alcohol Withdrawal Diagnosis"
              union "Generalized Anxiety Disorder Diagnosis" ) BenzodiazepineTreatedDiagnoses
              where BenzodiazepineTreatedDiagnoses.prevalenceInterval ( ) overlaps Interval[start of "Measurement Period" - 1 year, "Benzodiazepine Index Prescription Start Date"]
          )
        )
    )

define "More than One Antipsychotic Order":
  exists ( [MedicationRequest: "Potentially Harmful Antipsychotics for Older Adults"] ).moreThanOneOrder ( )

define "More than One Benzodiazepine Order":
  exists ( [MedicationRequest: "Potentially Harmful Benzodiazepines for Older Adults"] ).moreThanOneOrder ( )

define "Bipolar Disorder Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Bipolar Disorder"]
      union [ConditionEncounterDiagnosis: "Bipolar Disorder"]
  ).verified ( )

define "Schizophrenia Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Schizophrenia"]
      union [ConditionEncounterDiagnosis: "Schizophrenia"]
  ).verified ( )

define "Seizure Disorder Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Seizure Disorder"]
      union [ConditionEncounterDiagnosis: "Seizure Disorder"]
  ).verified ( )

define "REM Sleep Behavior Disorder Diagnosis":
  ( [ConditionProblemsHealthConcerns: "REM Sleep Behavior Disorder"]
      union [ConditionEncounterDiagnosis: "REM Sleep Behavior Disorder"]
  ).verified ( )

define "Benzodiazepine Withdrawal Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Benzodiazepine Withdrawal"]
      union [ConditionEncounterDiagnosis: "Benzodiazepine Withdrawal"]
  ).verified ( )

define "Alcohol Withdrawal Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Alcohol Withdrawal"]
      union [ConditionEncounterDiagnosis: "Alcohol Withdrawal"]
  ).verified ( )

define "Generalized Anxiety Disorder Diagnosis":
  ( [ConditionProblemsHealthConcerns: "Generalized Anxiety Disorder"]
      union [ConditionEncounterDiagnosis: "Generalized Anxiety Disorder"]
  ).verified ( )

define "Antipsychotic Index Prescription Start Date":
  First((([MedicationRequest: "Potentially Harmful Antipsychotics for Older Adults"]).isMedicationOrder()) AntipsychoticMedication
      where AntipsychoticMedication.authoredOn during "Measurement Period"
      return AntipsychoticMedication.authoredOn
      sort asc
  )

define "Benzodiazepine Index Prescription Start Date":
  First((([MedicationRequest: "Potentially Harmful Benzodiazepines for Older Adults"]).isMedicationOrder()) BenzodiazepineMedication
      where BenzodiazepineMedication.authoredOn during "Measurement Period"
      return BenzodiazepineMedication.authoredOn
      sort asc
  )

define "Numerator 3":
  "Numerator 2"
    or ( "Numerator 1"
        and not "Numerator 2"
    )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define fluent function moreThanOneOrder(Medication List<MedicationRequest>):
  ( Medication.isMedicationOrder ( ) ) OrderMedication1
    with ( Medication.isMedicationOrder ( ) ) OrderMedication2
      such that ( OrderMedication1.authoredOn during "Measurement Period"
          and OrderMedication1.dispenseRequest.numberOfRepeatsAllowed >= 1
      )
        or ( date from OrderMedication1.authoredOn !~ date from OrderMedication2.authoredOn
            and OrderMedication1.authoredOn during "Measurement Period"
            and OrderMedication2.authoredOn during "Measurement Period"
        )
        or ( date from OrderMedication1.authoredOn ~ date from OrderMedication2.authoredOn
            and OrderMedication1.authoredOn during "Measurement Period"
            and date from start of OrderMedication1.medicationRequestPeriod ( ) !~ date from start of OrderMedication2.medicationRequestPeriod ( )
            and start of OrderMedication1.medicationRequestPeriod ( ) during "Measurement Period"
            and start of OrderMedication2.medicationRequestPeriod ( ) during "Measurement Period"
        )
    return OrderMedication1

define fluent function medicationStrengthPerUnit(Strength Concept):
  case
    when Strength ~ "digoxin 0.05 MG/ML Oral Solution" then 0.05 'mg/mL'
    when Strength ~ "digoxin 0.0625 MG Oral Tablet" then 0.0625 'mg'
    when Strength ~ "1 ML digoxin 0.1 MG/ML Injection" then 0.1 'mg/mL'
    when Strength ~ "digoxin 0.125 MG Oral Tablet" then 0.125 'mg'
    when Strength ~ "digoxin 0.25 MG Oral Tablet" then 0.25 'mg'
    when Strength ~ "2 ML digoxin 0.25 MG/ML Injection" then 0.25 'mg/mL'
    when Strength ~ "doxepin 3 MG Oral Tablet" then 3 'mg'
    when Strength ~ "doxepin 6 MG Oral Tablet" then 6 'mg'
    when Strength ~ "doxepin 10 MG Oral Capsule" then 10 'mg'
    when Strength ~ "doxepin 10 MG/ML Oral Solution" then 10 'mg/mL'
    when Strength ~ "doxepin 25 MG Oral Capsule" then 25 'mg'
    when Strength ~ "doxepin 50 MG Oral Capsule" then 50 'mg'
    when Strength ~ "doxepin 75 MG Oral Capsule" then 75 'mg'
    when Strength ~ "doxepin 100 MG Oral Capsule" then 100 'mg'
    when Strength ~ "doxepin 150 MG Oral Capsule" then 150 'mg' 
    else null end

define fluent function medicationRequestPeriodInDays(Request MedicationRequest):
  Request R
    let dosage: singleton from R.dosageInstruction,
    doseAndRate: singleton from dosage.doseAndRate,
    timing: dosage.timing,
    frequency: Coalesce(timing.repeat.frequencyMax, timing.repeat.frequency),
    period: CMD."Quantity" ( timing.repeat.period, timing.repeat.periodUnit ),
    doseRange: doseAndRate.dose,
    doseQuantity: doseAndRate.dose,
    dose: Coalesce(
      end of doseRange, doseQuantity
    ),
    dosesPerDay: Coalesce((CMD."ToDaily"(frequency, period)), Count(timing.repeat.timeOfDay), 1.0),
    boundsPeriod: timing.repeat.bounds as Interval<DateTime>,
    daysSupply: ( convert R.dispenseRequest.expectedSupplyDuration to days ).value,
    quantity: R.dispenseRequest.quantity,
    refills: Coalesce(R.dispenseRequest.numberOfRepeatsAllowed, 0),
    startDate: Coalesce(date from start of boundsPeriod, date from R.authoredOn, date from start of R.dispenseRequest.validityPeriod),
    totalDaysSupplied: Coalesce(daysSupply, quantity.value /(dose.value * dosesPerDay)) * ( 1 + refills )
    return totalDaysSupplied

define fluent function averageDailyDose(MedicationRequest MedicationRequest):
  MedicationRequest Order
    let MedicationStrength: Order.getMedicationCode ( ).medicationStrengthPerUnit ( ),
    DaysSupplied: Order.medicationRequestPeriodInDays ( )
    return if DaysSupplied is not null
      and ( MedicationStrength.unit = 'mg'
          or ( MedicationStrength.unit = 'mg/mL'
              and Order.dispenseRequest.quantity.unit = 'mL'
          )
      ) then ( ( Order.dispenseRequest.quantity * MedicationStrength ) / Quantity { value: DaysSupplied, unit: 'd' } ) 
      else null