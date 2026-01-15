library CMS90FHIRFSAforHeartFailure version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include QICoreCommon version '4.0.000' called QICoreCommon
include SupplementalDataElements version '5.1.000' called SDE
include Hospice version '6.18.000' called Hospice
include Status version '1.15.000' called Status

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Heart Failure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Virtual Encounter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
valueset "Telephone Visits": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080'

code "Emotional score [MLHFQ]": '85609-6' from "LOINC" display 'Emotional score [MLHFQ]'
code "Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]": '86923-0' from "LOINC" display 'Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]'
code "Overall summary score [KCCQ-12]": '86924-8' from "LOINC" display 'Overall summary score [KCCQ-12]'
code "Overall summary score [KCCQ]": '71940-1' from "LOINC" display 'Overall summary score [KCCQ]'
code "Physical limitation score [KCCQ]": '72195-1' from "LOINC" display 'Physical limitation score [KCCQ]'
code "Physical score [MLHFQ]": '85618-7' from "LOINC" display 'Physical score [MLHFQ]'
code "PROMIS-10 Global Mental Health (GMH) score T-score": '71969-0' from "LOINC" display 'PROMIS-10 Global Mental Health (GMH) score T-score'
code "PROMIS-10 Global Physical Health (GPH) score T-score": '71971-6' from "LOINC" display 'PROMIS-10 Global Physical Health (GPH) score T-score'
code "PROMIS-29 Anxiety score T-score": '71967-4' from "LOINC" display 'PROMIS-29 Anxiety score T-score'
code "PROMIS-29 Depression score T-score": '71965-8' from "LOINC" display 'PROMIS-29 Depression score T-score'
code "PROMIS-29 Fatigue score T-score": '71963-3' from "LOINC" display 'PROMIS-29 Fatigue score T-score'
code "PROMIS-29 Pain interference score T-score": '71961-7' from "LOINC" display 'PROMIS-29 Pain interference score T-score'
code "PROMIS-29 Physical function score T-score": '71959-1' from "LOINC" display 'PROMIS-29 Physical function score T-score'
code "PROMIS-29 Satisfaction with participation in social roles score T-score": '71957-5' from "LOINC" display 'PROMIS-29 Satisfaction with participation in social roles score T-score'
code "PROMIS-29 Sleep disturbance score T-score": '71955-9' from "LOINC" display 'PROMIS-29 Sleep disturbance score T-score'
code "Quality of life score [KCCQ]": '72189-4' from "LOINC" display 'Quality of life score [KCCQ]'
code "Self-efficacy score [KCCQ]": '72190-2' from "LOINC" display 'Self-efficacy score [KCCQ]'
code "Severe cognitive impairment (finding)": '702956004' from "SNOMEDCT" display 'Severe cognitive impairment (finding)'
code "Social limitation score [KCCQ]": '72196-9' from "LOINC" display 'Social limitation score [KCCQ]'
code "Symptom stability score [KCCQ]": '72194-4' from "LOINC" display 'Symptom stability score [KCCQ]'
code "Total symptom score [KCCQ]": '72191-0' from "LOINC" display 'Total symptom score [KCCQ]'
code "VR-12 Mental component summary (MCS) score - oblique method T-score": '72026-8' from "LOINC" display 'VR-12 Mental component summary (MCS) score - oblique method T-score'
code "VR-12 Mental component summary (MCS) score - orthogonal method T-score": '72028-4' from "LOINC" display 'VR-12 Mental component summary (MCS) score - orthogonal method T-score'
code "VR-12 Physical component summary (PCS) score - oblique method T-score": '72025-0' from "LOINC" display 'VR-12 Physical component summary (PCS) score - oblique method T-score'
code "VR-12 Physical component summary (PCS) score - orthogonal method T-score": '72027-6' from "LOINC" display 'VR-12 Physical component summary (PCS) score - orthogonal method T-score'
code "VR-36 Mental component summary (MCS) score - oblique method T-score": '71990-6' from "LOINC" display 'VR-36 Mental component summary (MCS) score - oblique method T-score'
code "VR-36 Mental component summary (MCS) score - orthogonal method T-score": '72008-6' from "LOINC" display 'VR-36 Mental component summary (MCS) score - orthogonal method T-score'
code "VR-36 Physical component summary (PCS) score - oblique method T-score": '71989-8' from "LOINC" display 'VR-36 Physical component summary (PCS) score - oblique method T-score'
code "VR-36 Physical component summary (PCS) score - orthogonal method T-score": '72007-8' from "LOINC" display 'VR-36 Physical component summary (PCS) score - orthogonal method T-score'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") >= 18
    and exists ( ( ( [ConditionProblemsHealthConcerns: "Heart Failure"]
          union [ConditionEncounterDiagnosis: "Heart Failure"]
      ).verified ( ) ) HeartFailure
        where HeartFailure.prevalenceInterval ( ) overlaps before day of "Measurement Period"
    )
    and exists ( "Outpatient Encounters with at least one subsequent Outpatient Encounter during Measurement Period" )

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists ( ( ( [ConditionProblemsHealthConcerns: "Severe cognitive impairment (finding)"]
          union [ConditionEncounterDiagnosis: "Severe cognitive impairment (finding)"]
      ).verified ( ) ) SevereCognitiveImpairment
        where SevereCognitiveImpairment.prevalenceInterval ( ) overlaps day of "Measurement Period"
    )

define "Numerator":
  ( "Has Encounter with Initial and Follow Up PROMIS10 Assessments" )
    or ( "Has Encounter with Initial and Follow Up PROMIS29 Assessments" )
    or ( "Has Encounter with Initial and Follow Up VR12 Oblique Assessments" )
    or ( "Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments" )
    or ( "Has Encounter with Initial and Follow Up VR36 Oblique Assessments" )
    or ( "Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments" )
    or ( "Has Encounter with Initial and Follow Up MLHFQ Assessments" )
    or ( "Has Encounter with Initial and Follow Up KCCQ12 Assessments" )
    or ( "Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments" )
    or ( "Has Encounter with Initial and Follow Up KCCQ Total Score Assessments" )

define "Outpatient Encounters with at least one subsequent Outpatient Encounter during Measurement Period":
  from
    "Qualifying Encounters" OfficeVisit1
    with "Qualifying Encounters" OfficeVisit2
      such that OfficeVisit2.period starts 1 day or more after day of end of OfficeVisit1.period

define "Qualifying Encounters":
  ( ( [Encounter: "Office Visit"]
      union [Encounter: "Telephone Visits"]
      union [Encounter: "Virtual Encounter"]
  ).isEncounterPerformed ( ) ) ValidEncounter
    where ValidEncounter.period during day of "Measurement Period"

define "Has Encounter with Initial and Follow Up PROMIS10 Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date PROMIS10 Total Assessment Completed" InitialPROMIS10Date,
      "Date PROMIS10 Total Assessment Completed" FollowupPROMIS10Date
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialPROMIS10Date 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupPROMIS10Date during day of Interval[date from InitialPROMIS10Date + 30 days, date from InitialPROMIS10Date + 180 days]
      return ValidEncounters
  )

define "Date PROMIS10 Total Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "PROMIS-10 Global Mental Health (GMH) score T-score"] ).isAssessmentPerformed ( ) ) PROMIS10MentalScore,
    ( ( [ObservationScreeningAssessment: "PROMIS-10 Global Physical Health (GPH) score T-score"] ).isAssessmentPerformed ( ) ) PROMIS10PhysicalScore
    let PROMIS10MentalScoreDate: date from start of PROMIS10MentalScore.effective.toInterval ( ),
    PROMIS10PhysicalScoreDate: date from start of PROMIS10PhysicalScore.effective.toInterval ( )
    where PROMIS10MentalScoreDate same day as PROMIS10PhysicalScoreDate
      and ( PROMIS10MentalScore as ObservationScreeningAssessment ).value is not null
      and ( PROMIS10PhysicalScore as ObservationScreeningAssessment ).value is not null
    return PROMIS10MentalScoreDate

define "Has Encounter with Initial and Follow Up PROMIS29 Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date PROMIS29 Total Assessment Completed" InitialPROMIS29Date,
      "Date PROMIS29 Total Assessment Completed" FollowupPROMIS29Date
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialPROMIS29Date 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupPROMIS29Date during day of Interval[date from InitialPROMIS29Date + 30 days, date from InitialPROMIS29Date + 180 days]
      return ValidEncounters
  )

define "Date PROMIS29 Total Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "PROMIS-29 Sleep disturbance score T-score"] ).isAssessmentPerformed ( ) ) Promis29Sleep,
    ( ( [ObservationScreeningAssessment: "PROMIS-29 Satisfaction with participation in social roles score T-score"] ).isAssessmentPerformed ( ) ) Promis29SocialRoles,
    ( ( [ObservationScreeningAssessment: "PROMIS-29 Physical function score T-score"] ).isAssessmentPerformed ( ) ) Promis29Physical,
    ( ( [ObservationScreeningAssessment: "PROMIS-29 Pain interference score T-score"] ).isAssessmentPerformed ( ) ) Promis29Pain,
    ( ( [ObservationScreeningAssessment: "PROMIS-29 Fatigue score T-score"] ).isAssessmentPerformed ( ) ) Promis29Fatigue,
    ( ( [ObservationScreeningAssessment: "PROMIS-29 Depression score T-score"] ).isAssessmentPerformed ( ) ) Promis29Depression,
    ( ( [ObservationScreeningAssessment: "PROMIS-29 Anxiety score T-score"] ).isAssessmentPerformed ( ) ) Promis29Anxiety
    let Promis29SleepDate: date from start of Promis29Sleep.effective.toInterval ( ),
    Promis29SocialRolesDate: date from start of Promis29SocialRoles.effective.toInterval ( ),
    Promis29PhysicalDate: date from start of Promis29Physical.effective.toInterval ( ),
    Promis29PainDate: date from start of Promis29Pain.effective.toInterval ( ),
    Promis29FatigueDate: date from start of Promis29Fatigue.effective.toInterval ( ),
    Promis29DepressionDate: date from start of Promis29Depression.effective.toInterval ( ),
    Promis29AnxietyDate: date from start of Promis29Anxiety.effective.toInterval ( )
    where Promis29SleepDate same day as Promis29SocialRolesDate
      and Promis29SocialRoles.value is not null
      and Promis29SleepDate same day as Promis29PhysicalDate
      and Promis29Physical.value is not null
      and Promis29SleepDate same day as Promis29PainDate
      and Promis29Pain.value is not null
      and Promis29SleepDate same day as Promis29FatigueDate
      and Promis29Fatigue.value is not null
      and Promis29SleepDate same day as Promis29DepressionDate
      and Promis29Depression.value is not null
      and Promis29SleepDate same day as Promis29AnxietyDate
      and Promis29Anxiety.value is not null
      and Promis29Sleep.value is not null
    return Promis29SleepDate

define "Has Encounter with Initial and Follow Up VR12 Oblique Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date VR12 Oblique Total Assessment Completed" InitialVR12ObliqueDate,
      "Date VR12 Oblique Total Assessment Completed" FollowupVR12ObliqueDate
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialVR12ObliqueDate 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupVR12ObliqueDate during day of Interval[date from InitialVR12ObliqueDate + 30 days, date from InitialVR12ObliqueDate + 180 days]
      return ValidEncounters
  )

define "Date VR12 Oblique Total Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "VR-12 Mental component summary (MCS) score - oblique method T-score"] ).isAssessmentPerformed ( ) ) VR12MentalAssessment,
    ( ( [ObservationScreeningAssessment: "VR-12 Physical component summary (PCS) score - oblique method T-score"] ).isAssessmentPerformed ( ) ) VR12PhysicalAssessment
    let VR12MentalAssessmentDate: date from start of VR12MentalAssessment.effective.toInterval ( ),
    VR12PhysicalAssessmentDate: date from start of VR12PhysicalAssessment.effective.toInterval ( )
    where VR12MentalAssessmentDate same day as VR12PhysicalAssessmentDate
      and ( VR12MentalAssessment as ObservationScreeningAssessment ).value is not null
      and ( VR12PhysicalAssessment as ObservationScreeningAssessment ).value is not null
    return VR12MentalAssessmentDate

define "Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date VR12 Orthogonal Total Assessment Completed" InitialVR12OrthogonalDate,
      "Date VR12 Orthogonal Total Assessment Completed" FollowupVR12OrthogonalDate
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialVR12OrthogonalDate 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupVR12OrthogonalDate during day of Interval[date from InitialVR12OrthogonalDate + 30 days, date from InitialVR12OrthogonalDate + 180 days]
      return ValidEncounters
  )

define "Date VR12 Orthogonal Total Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "VR-12 Mental component summary (MCS) score - orthogonal method T-score"] ).isAssessmentPerformed ( ) ) VR12MentalAssessment,
    ( ( [ObservationScreeningAssessment: "VR-12 Physical component summary (PCS) score - orthogonal method T-score"] ).isAssessmentPerformed ( ) ) VR12PhysicalAssessment
    let VR12MentalAssessmentDate: date from start of VR12MentalAssessment.effective.toInterval ( ),
    VR12PhysicalAssessmentDate: date from start of VR12PhysicalAssessment.effective.toInterval ( )
    where VR12MentalAssessmentDate same day as VR12PhysicalAssessmentDate
      and ( VR12MentalAssessment as ObservationScreeningAssessment ).value is not null
      and ( VR12PhysicalAssessment as ObservationScreeningAssessment ).value is not null
    return VR12MentalAssessmentDate

define "Has Encounter with Initial and Follow Up VR36 Oblique Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date VR36 Oblique Total Assessment Completed" InitialVR36ObliqueDate,
      "Date VR36 Oblique Total Assessment Completed" FollowupVR36ObliqueDate
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialVR36ObliqueDate 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupVR36ObliqueDate during day of Interval[date from InitialVR36ObliqueDate + 30 days, date from InitialVR36ObliqueDate + 180 days]
      return ValidEncounters
  )

define "Date VR36 Oblique Total Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "VR-36 Mental component summary (MCS) score - oblique method T-score"] ).isAssessmentPerformed ( ) ) VR36MentalAssessment,
    ( ( [ObservationScreeningAssessment: "VR-36 Physical component summary (PCS) score - oblique method T-score"] ).isAssessmentPerformed ( ) ) VR36PhysicalAssessment
    let VR36MentalAssessmentDate: date from start of VR36MentalAssessment.effective.toInterval ( ),
    VR36PhysicalAssessmentDate: date from start of VR36PhysicalAssessment.effective.toInterval ( )
    where VR36MentalAssessmentDate same day as VR36PhysicalAssessmentDate
      and ( VR36MentalAssessment as ObservationScreeningAssessment ).value is not null
      and ( VR36PhysicalAssessment as ObservationScreeningAssessment ).value is not null
    return VR36MentalAssessmentDate

define "Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date VR36 Orthogonal Total Assessment Completed" InitialVR36OrthogonalDate,
      "Date VR36 Orthogonal Total Assessment Completed" FollowupVR36OrthogonalDate
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialVR36OrthogonalDate 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupVR36OrthogonalDate during day of Interval[date from InitialVR36OrthogonalDate + 30 days, date from InitialVR36OrthogonalDate + 180 days]
      return ValidEncounters
  )

define "Date VR36 Orthogonal Total Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "VR-36 Mental component summary (MCS) score - orthogonal method T-score"] ).isAssessmentPerformed ( ) ) VR36MentalAssessment,
    ( ( [ObservationScreeningAssessment: "VR-36 Physical component summary (PCS) score - orthogonal method T-score"] ).isAssessmentPerformed ( ) ) VR36PhysicalAssessment
    let VR36MentalAssessmentDate: date from start of VR36MentalAssessment.effective.toInterval ( ),
    VR36PhysicalAssessmentDate: date from start of VR36PhysicalAssessment.effective.toInterval ( )
    where VR36MentalAssessmentDate same day as VR36PhysicalAssessmentDate
      and ( VR36MentalAssessment as ObservationScreeningAssessment ).value is not null
      and ( VR36PhysicalAssessment as ObservationScreeningAssessment ).value is not null
    return VR36MentalAssessmentDate

define "Has Encounter with Initial and Follow Up MLHFQ Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date MLHFQ Total Assessment Completed" InitialMLHFQDate,
      "Date MLHFQ Total Assessment Completed" FollowupMLHFQDate
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialMLHFQDate 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupMLHFQDate during day of Interval[date from InitialMLHFQDate + 30 days, date from InitialMLHFQDate + 180 days]
      return ValidEncounters
  )

define "Date MLHFQ Total Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "Physical score [MLHFQ]"] ).isAssessmentPerformed ( ) ) MLHFQPhysical,
    ( ( [ObservationScreeningAssessment: "Emotional score [MLHFQ]"] ).isAssessmentPerformed ( ) ) MLHFQEmotional
    let MLHFQPhysicalDate: date from start of MLHFQPhysical.effective.toInterval ( ),
    MLHFQEmotionalDate: date from start of MLHFQEmotional.effective.toInterval ( )
    where MLHFQPhysicalDate same day as MLHFQEmotionalDate
      and ( MLHFQPhysical as ObservationScreeningAssessment ).value is not null
      and ( MLHFQEmotional as ObservationScreeningAssessment ).value is not null
    return MLHFQPhysicalDate

define "Has Encounter with Initial and Follow Up KCCQ12 Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date KCCQ12 Total Assessment Completed" InitialKCCQ12Date,
      "Date KCCQ12 Total Assessment Completed" FollowupKCCQ12Date
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialKCCQ12Date 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupKCCQ12Date during day of Interval[date from InitialKCCQ12Date + 30 days, date from InitialKCCQ12Date + 180 days]
      return ValidEncounters
  )

define "Date KCCQ12 Total Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]"] ).isAssessmentPerformed ( ) ) KCCQ12Item,
    ( ( [ObservationScreeningAssessment: "Overall summary score [KCCQ-12]"] ).isAssessmentPerformed ( ) ) KCCQ12Summary
    let KCCQ12ItemDate: date from start of KCCQ12Item.effective.toInterval ( ),
    KCCQ12SummaryDate: date from start of KCCQ12Summary.effective.toInterval ( )
    where KCCQ12ItemDate same day as KCCQ12SummaryDate
      and ( KCCQ12Item as ObservationScreeningAssessment ).value is not null
      and ( KCCQ12Summary as ObservationScreeningAssessment ).value is not null
    return KCCQ12ItemDate

define "Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date KCCQ Domain Assessment Completed" InitialKCCQAssessmentDate,
      "Date KCCQ Domain Assessment Completed" FollowupKCCQAssessmentDate
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialKCCQAssessmentDate 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupKCCQAssessmentDate during day of Interval[date from InitialKCCQAssessmentDate + 30 days, date from InitialKCCQAssessmentDate + 180 days]
      return ValidEncounters
  )

define "Date KCCQ Domain Assessment Completed":
  from
    ( ( [ObservationScreeningAssessment: "Quality of life score [KCCQ]"] ).isAssessmentPerformed ( ) ) KCCQLifeQuality,
    ( ( [ObservationScreeningAssessment: "Symptom stability score [KCCQ]"] ).isAssessmentPerformed ( ) ) KCCQSymptomStability,
    ( ( [ObservationScreeningAssessment: "Self-efficacy score [KCCQ]"] ).isAssessmentPerformed ( ) ) KCCQSelfEfficacy,
    ( ( [ObservationScreeningAssessment: "Total symptom score [KCCQ]"] ).isAssessmentPerformed ( ) ) KCCQSymptoms,
    ( ( [ObservationScreeningAssessment: "Physical limitation score [KCCQ]"] ).isAssessmentPerformed ( ) ) KCCQPhysicalLimits,
    ( ( [ObservationScreeningAssessment: "Social limitation score [KCCQ]"] ).isAssessmentPerformed ( ) ) KCCQSocialLimits
    let KCCQLifeQualityDate: date from start of KCCQLifeQuality.effective.toInterval ( ),
    KCCQSymptomStabilityDate: date from start of KCCQSymptomStability.effective.toInterval ( ),
    KCCQSelfEfficacyDate: date from start of KCCQSelfEfficacy.effective.toInterval ( ),
    KCCQSymptomsDate: date from start of KCCQSymptoms.effective.toInterval ( ),
    KCCQPhysicalLimitsDate: date from start of KCCQPhysicalLimits.effective.toInterval ( ),
    KCCQSocialLimitsDate: date from start of KCCQSocialLimits.effective.toInterval ( )
    where KCCQLifeQualityDate same day as KCCQSymptomStabilityDate
      and ( KCCQSymptomStability as ObservationScreeningAssessment ).value is not null
      and KCCQLifeQualityDate same day as KCCQSelfEfficacyDate
      and ( KCCQSelfEfficacy as ObservationScreeningAssessment ).value is not null
      and KCCQLifeQualityDate same day as KCCQSymptomsDate
      and ( KCCQSymptoms as ObservationScreeningAssessment ).value is not null
      and KCCQLifeQualityDate same day as KCCQPhysicalLimitsDate
      and ( KCCQPhysicalLimits as ObservationScreeningAssessment ).value is not null
      and KCCQLifeQualityDate same day as KCCQSocialLimitsDate
      and ( KCCQSocialLimits as ObservationScreeningAssessment ).value is not null
      and ( KCCQLifeQuality as ObservationScreeningAssessment ).value is not null
    return KCCQLifeQualityDate

define "Date KCCQ Total Assessment Completed":
  ( ( [ObservationScreeningAssessment: "Overall summary score [KCCQ]"] ).isAssessmentPerformed ( ) ) KCCQSummaryScore
    where ( KCCQSummaryScore as ObservationScreeningAssessment ).value is not null
    return date from start of KCCQSummaryScore.effective.toInterval ( )

define "Has Encounter with Initial and Follow Up KCCQ Total Score Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date KCCQ Total Assessment Completed" InitialKCCQTotalScore,
      "Date KCCQ Total Assessment Completed" FollowupKCCQTotalScore
      where ValidEncounters.period ends 180 days or more before day of end of "Measurement Period"
        and InitialKCCQTotalScore 14 days or less on or before day of end of ValidEncounters.period
        and date from FollowupKCCQTotalScore during day of Interval[date from InitialKCCQTotalScore + 30 days, date from InitialKCCQTotalScore + 180 days]
      return ValidEncounters
  )