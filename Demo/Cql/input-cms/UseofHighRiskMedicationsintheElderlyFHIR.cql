library UseofHighRiskMedicationsintheElderlyFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include Hospice version '6.9.000' called Hospice
include PalliativeCare version '1.9.000' called PalliativeCare
include CumulativeMedicationDuration version '4.0.000' called CMD
include QICoreCommon version '2.0.000' called QICoreCommon
include Status version '1.6.000' called Status

codesystem "RXNORM": 'http://www.nlm.nih.gov/research/umls/rxnorm'
codesystem "CPT": 'http://www.ama-assn.org/go/cpt'

valueset "Alcohol Withdrawal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1209'
valueset "Annual Wellness Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240'
valueset "Anti Infectives, other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1481'
valueset "Anticholinergics, anti Parkinson agents": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1049'
valueset "Anticholinergics, first generation antihistamines": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1043'
valueset "Antipsychotic": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1523'
valueset "Antispasmodics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1050'
valueset "Antithrombotic": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1051'
valueset "Benzodiazepine Withdrawal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1208'
valueset "Benzodiazepine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1522'
valueset "Bipolar Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1157'
valueset "Cardiovascular, alpha agonists, central": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1052'
valueset "Cardiovascular, other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1053'
valueset "Care Services in Long Term Residential Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1014'
valueset "Central nervous system, antidepressants": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1054'
valueset "Central nervous system, barbiturates": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1055'
valueset "Central nervous system, other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1057'
valueset "Central nervous system, vasodilators": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1056'
valueset "Digoxin": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1065'
valueset "Discharge Services Nursing Facility": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1013'
valueset "Doxepin": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1067'
valueset "Endocrine system, estrogens with or without progestins": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1058'
valueset "Endocrine system, other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1060'
valueset "Endocrine system, sulfonylureas, long duration": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1059'
valueset "Generalized Anxiety Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1210'
valueset "Home Healthcare Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016'
valueset "Nonbenzodiazepine hypnotics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.196.12.1480'
valueset "Nursing Facility Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1012'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Ophthalmologic Services": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1206'
valueset "Pain medications, other": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1063'
valueset "Pain medications, skeletal muscle relaxants": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1062'
valueset "Preventive Care Services Established Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025'
valueset "Preventive Care Services Initial Office Visit, 18 and Up": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023'
valueset "REM Sleep Behavior Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1207'
valueset "Reserpine": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.1044'
valueset "Schizophrenia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1205'
valueset "Seizure Disorder": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1206'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

code "1 ML digoxin 0.1 MG/ML Injection": '204504' from "RXNORM" display '1 ML digoxin 0.1 MG/ML Injection'
code "2 ML digoxin 0.25 MG/ML Injection": '104208' from "RXNORM" display '2 ML digoxin 0.25 MG/ML Injection'
code "digoxin 0.05 MG/ML Oral Solution": '393245' from "RXNORM" display 'digoxin 0.05 MG/ML Oral Solution'
code "digoxin 0.0625 MG Oral Tablet": '245273' from "RXNORM" display 'digoxin 0.0625 MG Oral Tablet'
code "digoxin 0.125 MG Oral Tablet": '197604' from "RXNORM" display 'digoxin 0.125 MG Oral Tablet'
code "digoxin 0.1875 MG Oral Tablet": '1441565' from "RXNORM" display 'digoxin 0.1875 MG Oral Tablet'
code "digoxin 0.25 MG Oral Tablet": '197606' from "RXNORM" display 'digoxin 0.25 MG Oral Tablet'
code "doxepin 3 MG Oral Tablet": '966787' from "RXNORM" display 'doxepin 3 MG Oral Tablet'
code "doxepin 6 MG Oral Tablet": '966793' from "RXNORM" display 'doxepin 6 MG Oral Tablet'
code "doxepin hydrochloride 10 MG Oral Capsule": '1000048' from "RXNORM" display 'doxepin hydrochloride 10 MG Oral Capsule'
code "doxepin hydrochloride 10 MG/ML Oral Solution": '1000054' from "RXNORM" display 'doxepin hydrochloride 10 MG/ML Oral Solution'
code "doxepin hydrochloride 100 MG Oral Capsule": '1000058' from "RXNORM" display 'doxepin hydrochloride 100 MG Oral Capsule'
code "doxepin hydrochloride 150 MG Oral Capsule": '1000064' from "RXNORM" display 'doxepin hydrochloride 150 MG Oral Capsule'
code "doxepin hydrochloride 25 MG Oral Capsule": '1000070' from "RXNORM" display 'doxepin hydrochloride 25 MG Oral Capsule'
code "doxepin hydrochloride 50 MG Oral Capsule": '1000076' from "RXNORM" display 'doxepin hydrochloride 50 MG Oral Capsule'
code "doxepin hydrochloride 75 MG Oral Capsule": '1000097' from "RXNORM" display 'doxepin hydrochloride 75 MG Oral Capsule'
code "Office or other outpatient visit for the evaluation and management of an established patient, that may not require the presence of a physician or other qualified health care professional. Usually, the presenting problem(s) are minimal.": '99211' from "CPT" display 'Office or other outpatient visit for the evaluation and management of an established patient, that may not require the presence of a physician or other qualified health care professional. Usually, the presenting problem(s) are minimal.'
code "reserpine 0.1 MG Oral Tablet": '198196' from "RXNORM" display 'reserpine 0.1 MG Oral Tablet'
code "reserpine 0.25 MG Oral Tablet": '198197' from "RXNORM" display 'reserpine 0.25 MG Oral Tablet'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Initial Population":
  AgeInYearsAt(date from 
    end of "Measurement Period"
  ) >= 65
    and exists ( "Qualifying Encounters" )

define "Qualifying Encounters":
  ( ["Encounter": "Office Visit"]
    union ["Encounter": "Ophthalmologic Services"]
    union ["Encounter": "Preventive Care Services Established Office Visit, 18 and Up"]
    union ["Encounter": "Discharge Services Nursing Facility"]
    union ["Encounter": "Nursing Facility Visit"]
    union ["Encounter": "Care Services in Long Term Residential Facility"]
    union ["Encounter": "Preventive Care Services Initial Office Visit, 18 and Up"]
    union ["Encounter": "Annual Wellness Visit"]
    union ["Encounter": "Home Healthcare Services"]
    union ["Encounter": "Telephone Visits"]
    union ["Encounter": "Online Assessments"]
    union ( [Encounter] E
        where exists ( ( E.type ) T
            where T ~ "Office or other outpatient visit for the evaluation and management of an established patient, that may not require the presence of a physician or other qualified health care professional. Usually, the presenting problem(s) are minimal."
        )
    ) ) ValidEncounters
    where ValidEncounters.period during "Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or PalliativeCare."Has Palliative Care in the Measurement Period"

define "Numerator 1":
  exists ( "Same High Risk Medications Ordered on Different Days" )
    or ( "Two High Risk Medications with Prolonged Duration" )
    or ( "High Risk Medications with Average Daily Dose Criteria" )

define "Same High Risk Medications Ordered on Different Days":
  "More Than One Order"(["MedicationRequest": "Anticholinergics, first generation antihistamines"])
    union "More Than One Order"(["MedicationRequest": "Anticholinergics, anti Parkinson agents"])
    union "More Than One Order"(["MedicationRequest": "Antispasmodics"])
    union "More Than One Order"(["MedicationRequest": "Antithrombotic"])
    union "More Than One Order"(["MedicationRequest": "Cardiovascular, alpha agonists, central"])
    union "More Than One Order"(["MedicationRequest": "Cardiovascular, other"])
    union "More Than One Order"(["MedicationRequest": "Central nervous system, antidepressants"])
    union "More Than One Order"(["MedicationRequest": "Central nervous system, barbiturates"])
    union "More Than One Order"(["MedicationRequest": "Central nervous system, vasodilators"])
    union "More Than One Order"(["MedicationRequest": "Central nervous system, other"])
    union "More Than One Order"(["MedicationRequest": "Endocrine system, estrogens with or without progestins"])
    union "More Than One Order"(["MedicationRequest": "Endocrine system, sulfonylureas, long duration"])
    union "More Than One Order"(["MedicationRequest": "Endocrine system, other"])
    union "More Than One Order"(["MedicationRequest": "Nonbenzodiazepine hypnotics"])
    union "More Than One Order"(["MedicationRequest": "Pain medications, skeletal muscle relaxants"])
    union "More Than One Order"(["MedicationRequest": "Pain medications, other"])

define "Two High Risk Medications with Prolonged Duration":
  Sum(("More Than One Order"([MedicationRequest: "Anti Infectives, other"])) AntiInfectives
      let DaysSupply: AntiInfectives.MedicationRequestPeriodInDays()
      return all DaysSupply
  ) > 90

define "High Risk Medications with Average Daily Dose Criteria":
  exists ( "More Than One Order"([MedicationRequest: "Reserpine"] ReserpineOrdered
        where "Average Daily Dose"(ReserpineOrdered) > 0.1 'mg/d'
    )
  )
    or exists ( "More Than One Order"([MedicationRequest: "Digoxin"] DigoxinOrdered
          where "Average Daily Dose"(DigoxinOrdered) > 0.125 'mg/d'
      )
    )
    or exists ( "More Than One Order"([MedicationRequest: "Doxepin"] DoxepinOrdered
          where "Average Daily Dose"(DoxepinOrdered) > 6 'mg/d'
      )
    )

define "Numerator 2":
  ( "More than One Antipsychotic Order"
      and ( not exists ( ( [Condition: "Schizophrenia"]
            union [Condition: "Bipolar Disorder"] ) AntipsychoticTreatedDiagnoses
            where QICoreCommon."ToPrevalenceInterval" ( AntipsychoticTreatedDiagnoses ) overlaps Interval[start of "Measurement Period" - 1 year, "Antipsychotic Index Prescription Start Date"]
        )
      )
  )
    or ( "More than One Benzodiazepine Order"
        and ( not exists ( ( [Condition: "Seizure Disorder"]
              union [Condition: "REM Sleep Behavior Disorder"]
              union [Condition: "Benzodiazepine Withdrawal"]
              union [Condition: "Alcohol Withdrawal"]
              union [Condition: "Generalized Anxiety Disorder"] ) BenzodiazepineTreatedDiagnoses
              where QICoreCommon."ToPrevalenceInterval" ( BenzodiazepineTreatedDiagnoses ) overlaps Interval[start of "Measurement Period" - 1 year, "Benzodiazepine Index Prescription Start Date"]
          )
        )
    )

define "More than One Antipsychotic Order":
  exists ( "More Than One Order"([MedicationRequest: "Antipsychotic"]) )

define "More than One Benzodiazepine Order":
  exists ( "More Than One Order"([MedicationRequest: "Benzodiazepine"]) )

define "Antipsychotic Index Prescription Start Date":
  First((Status."Active or Completed Medication Request"([MedicationRequest: "Antipsychotic"])) AntipsychoticMedication
      where AntipsychoticMedication.authoredOn during "Measurement Period"
      return AntipsychoticMedication.authoredOn
      sort asc
  )

define "Benzodiazepine Index Prescription Start Date":
  First((Status."Active or Completed Medication Request"([MedicationRequest: "Benzodiazepine"])) BenzodiazepineMedication
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
  
//Functions


define function "More Than One Order"(Medication List<"MedicationRequest">):
  ( Status."Active or Completed Medication Request" ( "Medication" ) ) OrderMedication1
    with ( Status."Active or Completed Medication Request" ( "Medication" ) ) OrderMedication2
      such that ( OrderMedication1.authoredOn during "Measurement Period"
          and OrderMedication1.dispenseRequest.numberOfRepeatsAllowed >= 1
      )
        or ( date from OrderMedication1.authoredOn !~ date from OrderMedication2.authoredOn
            and OrderMedication1.authoredOn during "Measurement Period"
            and OrderMedication2.authoredOn during "Measurement Period"
        )
        or ( date from OrderMedication1.authoredOn ~ date from OrderMedication2.authoredOn
            and OrderMedication1.authoredOn during "Measurement Period"
            and date from start of CMD."MedicationRequestPeriod" ( OrderMedication1 ) !~ date from start of CMD."MedicationRequestPeriod" ( OrderMedication2 )
            and start of CMD."MedicationRequestPeriod" ( OrderMedication1 ) during "Measurement Period"
            and start of CMD."MedicationRequestPeriod" ( OrderMedication2 ) during "Measurement Period"
        )
    return OrderMedication1

define fluent function MedicationStrengthPerUnit(Strength Concept):
  case
    when Strength ~ "reserpine 0.1 MG Oral Tablet" then 0.1 'mg'
    when Strength ~ "reserpine 0.25 MG Oral Tablet" then 0.25 'mg'
    when Strength ~ "digoxin 0.05 MG/ML Oral Solution" then 0.05 'mg/mL'
    when Strength ~ "digoxin 0.0625 MG Oral Tablet" then 0.0625 'mg'
    when Strength ~ "1 ML digoxin 0.1 MG/ML Injection" then 0.1 'mg/mL'
    when Strength ~ "digoxin 0.125 MG Oral Tablet" then 0.125 'mg'
    when Strength ~ "digoxin 0.1875 MG Oral Tablet" then 0.1875 'mg'
    when Strength ~ "digoxin 0.25 MG Oral Tablet" then 0.25 'mg'
    when Strength ~ "2 ML digoxin 0.25 MG/ML Injection" then 0.25 'mg/mL'
    when Strength ~ "doxepin 3 MG Oral Tablet" then 3 'mg'
    when Strength ~ "doxepin 6 MG Oral Tablet" then 6 'mg'
    when Strength ~ "doxepin hydrochloride 10 MG Oral Capsule" then 10 'mg'
    when Strength ~ "doxepin hydrochloride 10 MG/ML Oral Solution" then 10 'mg/mL'
    when Strength ~ "doxepin hydrochloride 25 MG Oral Capsule" then 25 'mg'
    when Strength ~ "doxepin hydrochloride 50 MG Oral Capsule" then 50 'mg'
    when Strength ~ "doxepin hydrochloride 75 MG Oral Capsule" then 75 'mg'
    when Strength ~ "doxepin hydrochloride 100 MG Oral Capsule" then 100 'mg'
    when Strength ~ "doxepin hydrochloride 150 MG Oral Capsule" then 150 'mg' 
    else null end

define fluent function MedicationRequestPeriodInDays(Request "MedicationRequest"):
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

define function "Average Daily Dose"(MedicationRequest "MedicationRequest"):
  MedicationRequest Order
    let MedicationStrength: Order.getMedicationCode ( ).MedicationStrengthPerUnit ( ),
    DaysSupplied: Order.MedicationRequestPeriodInDays ( )
    return if DaysSupplied is not null
      and ( MedicationStrength.unit = 'mg'
          or ( MedicationStrength.unit = 'mg/mL'
              and Order.dispenseRequest.quantity.unit = 'mL'
          )
      ) then ( ( Order.dispenseRequest.quantity * MedicationStrength ) / Quantity { value: DaysSupplied, unit: 'd' } ) 
      else null