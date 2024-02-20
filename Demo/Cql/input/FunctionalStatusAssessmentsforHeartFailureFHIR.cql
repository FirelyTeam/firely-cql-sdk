library FunctionalStatusAssessmentsforHeartFailureFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include CQMCommon version '2.0.000' called CQMCommon
include Hospice version '6.9.000' called Hospice
include Status version '1.6.000' called Status
include QICoreCommon version '2.0.000' called QICoreCommon

codesystem "LOINC": 'http://loinc.org'
codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Heart Failure": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.376'
valueset "Office Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001'
valueset "Online Assessments": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1089'
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
code "Total score [MLHFQ]": '71938-5' from "LOINC" display 'Total score [MLHFQ]'
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
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"

define "Qualifying Encounters":
  ( Status."Finished Encounter" ( [Encounter: "Office Visit"]
    union [Encounter: "Telephone Visits"]
    union [Encounter: "Online Assessments"] ) ) ValidEncounter
    where QICoreCommon."ToInterval" ( ValidEncounter.period ) during day of "Measurement Period"

define "Denominator":
  "Initial Population"

define "Denominator Exclusions":
  Hospice."Has Hospice Services"
    or exists ( ( [Condition: "Severe cognitive impairment (finding)"] ) Dementia
        where QICoreCommon."ToPrevalenceInterval" ( Dementia ) overlaps "Measurement Period"
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

define "Has Encounter with Initial and Follow Up PROMIS10 Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date PROMIS10 Total Assessment Completed" InitialPROMIS10Date,
      "Date PROMIS10 Total Assessment Completed" FollowupPROMIS10Date
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialPROMIS10Date 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupPROMIS10Date during day of Interval[date from InitialPROMIS10Date + 30 days, date from InitialPROMIS10Date + 180 days]
      return ValidEncounters
  )

define "Date PROMIS10 Total Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-10 Global Mental Health (GMH) score T-score"] ) ) PROMIS10MentalScore,
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-10 Global Physical Health (GPH) score T-score"] ) ) PROMIS10PhysicalScore
    let PROMIS10MentalScoreDate: date from start of QICoreCommon."ToInterval" ( PROMIS10MentalScore.effective ),
    PROMIS10PhysicalScoreDate: date from start of QICoreCommon."ToInterval" ( PROMIS10PhysicalScore.effective )
    where PROMIS10MentalScoreDate same day as PROMIS10PhysicalScoreDate
      and PROMIS10MentalScore.value is not null
      and PROMIS10PhysicalScore.value is not null
    return Max({ PROMIS10MentalScoreDate, PROMIS10PhysicalScoreDate })

define "Has Encounter with Initial and Follow Up PROMIS29 Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date PROMIS29 Total Assessment Completed" InitialPROMIS29Date,
      "Date PROMIS29 Total Assessment Completed" FollowupPROMIS29Date
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialPROMIS29Date 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupPROMIS29Date during day of Interval[date from InitialPROMIS29Date + 30 days, date from InitialPROMIS29Date + 180 days]
      return ValidEncounters
  )

define "Date PROMIS29 Total Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-29 Sleep disturbance score T-score"] ) ) Promis29Sleep,
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-29 Satisfaction with participation in social roles score T-score"] ) ) Promis29SocialRoles,
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-29 Physical function score T-score"] ) ) Promis29Physical,
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-29 Pain interference score T-score"] ) ) Promis29Pain,
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-29 Fatigue score T-score"] ) ) Promis29Fatigue,
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-29 Depression score T-score"] ) ) Promis29Depression,
    ( Status."Final Survey Observation" ( [Observation: "PROMIS-29 Anxiety score T-score"] ) ) Promis29Anxiety
    let Promis29SleepDate: date from start of QICoreCommon."ToInterval" ( Promis29Sleep.effective ),
    Promis29SocialRolesDate: date from start of QICoreCommon."ToInterval" ( Promis29SocialRoles.effective ),
    Promis29PhysicalDate: date from start of QICoreCommon."ToInterval" ( Promis29Physical.effective ),
    Promis29PainDate: date from start of QICoreCommon."ToInterval" ( Promis29Pain.effective ),
    Promis29FatigueDate: date from start of QICoreCommon."ToInterval" ( Promis29Fatigue.effective ),
    Promis29DepressionDate: date from start of QICoreCommon."ToInterval" ( Promis29Depression.effective ),
    Promis29AnxietyDate: date from start of QICoreCommon."ToInterval" ( Promis29Anxiety.effective )
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
    return Max({ Promis29SleepDate, Promis29SocialRolesDate, Promis29PhysicalDate, Promis29PainDate, Promis29FatigueDate, Promis29DepressionDate, Promis29AnxietyDate })

define "Has Encounter with Initial and Follow Up VR12 Oblique Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date VR12 Oblique Total Assessment Completed" InitialVR12ObliqueDate,
      "Date VR12 Oblique Total Assessment Completed" FollowupVR12ObliqueDate
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialVR12ObliqueDate 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupVR12ObliqueDate during day of Interval[date from InitialVR12ObliqueDate + 30 days, date from InitialVR12ObliqueDate + 180 days]
      return ValidEncounters
  )

define "Date VR12 Oblique Total Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "VR-12 Mental component summary (MCS) score - oblique method T-score"] ) ) VR12MentalAssessment,
    ( Status."Final Survey Observation" ( [Observation: "VR-12 Physical component summary (PCS) score - oblique method T-score"] ) ) VR12PhysicalAssessment
    let VR12MentalAssessmentDate: date from start of QICoreCommon."ToInterval" ( VR12MentalAssessment.effective ),
    VR12PhysicalAssessmentDate: date from start of QICoreCommon."ToInterval" ( VR12PhysicalAssessment.effective )
    where VR12MentalAssessmentDate same day as VR12PhysicalAssessmentDate
      and VR12MentalAssessment.value is not null
      and VR12PhysicalAssessment.value is not null
    return Max({ VR12MentalAssessmentDate, VR12PhysicalAssessmentDate })

define "Has Encounter with Initial and Follow Up VR12 Orthogonal Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date VR12 Orthogonal Total Assessment Completed" InitialVR12OrthogonalDate,
      "Date VR12 Orthogonal Total Assessment Completed" FollowupVR12OrthogonalDate
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialVR12OrthogonalDate 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupVR12OrthogonalDate during day of Interval[date from InitialVR12OrthogonalDate + 30 days, date from InitialVR12OrthogonalDate + 180 days]
      return ValidEncounters
  )

define "Date VR12 Orthogonal Total Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "VR-12 Mental component summary (MCS) score - orthogonal method T-score"] ) ) VR12MentalAssessment,
    ( Status."Final Survey Observation" ( [Observation: "VR-12 Physical component summary (PCS) score - orthogonal method T-score"] ) ) VR12PhysicalAssessment
    let VR12MentalAssessmentDate: date from start of QICoreCommon."ToInterval" ( VR12MentalAssessment.effective ),
    VR12PhysicalAssessmentDate: date from start of QICoreCommon."ToInterval" ( VR12PhysicalAssessment.effective )
    where VR12MentalAssessmentDate same day as VR12PhysicalAssessmentDate
      and VR12MentalAssessment.value is not null
      and VR12PhysicalAssessment.value is not null
    return Max({ VR12MentalAssessmentDate, VR12PhysicalAssessmentDate })

define "Has Encounter with Initial and Follow Up VR36 Oblique Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date VR36 Oblique Total Assessment Completed" InitialVR36ObliqueDate,
      "Date VR36 Oblique Total Assessment Completed" FollowupVR36ObliqueDate
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialVR36ObliqueDate 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupVR36ObliqueDate during day of Interval[date from InitialVR36ObliqueDate + 30 days, date from InitialVR36ObliqueDate + 180 days]
      return ValidEncounters
  )

define "Date VR36 Oblique Total Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "VR-36 Mental component summary (MCS) score - oblique method T-score"] ) ) VR36MentalAssessment,
    ( Status."Final Survey Observation" ( [Observation: "VR-36 Physical component summary (PCS) score - oblique method T-score"] ) ) VR36PhysicalAssessment
    let VR36MentalAssessmentDate: date from start of QICoreCommon."ToInterval" ( VR36MentalAssessment.effective ),
    VR36PhysicalAssessmentDate: date from start of QICoreCommon."ToInterval" ( VR36PhysicalAssessment.effective )
    where VR36MentalAssessmentDate same day as VR36PhysicalAssessmentDate
      and VR36MentalAssessment.value is not null
      and VR36PhysicalAssessment.value is not null
    return Max({ VR36MentalAssessmentDate, VR36PhysicalAssessmentDate })

define "Has Encounter with Initial and Follow Up VR36 Orthogonal Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date VR36 Orthogonal Total Assessment Completed" InitialVR36OrthogonalDate,
      "Date VR36 Orthogonal Total Assessment Completed" FollowupVR36OrthogonalDate
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialVR36OrthogonalDate 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupVR36OrthogonalDate during day of Interval[date from InitialVR36OrthogonalDate + 30 days, date from InitialVR36OrthogonalDate + 180 days]
      return ValidEncounters
  )

define "Date VR36 Orthogonal Total Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "VR-36 Mental component summary (MCS) score - orthogonal method T-score"] ) ) VR36MentalAssessment,
    ( Status."Final Survey Observation" ( [Observation: "VR-36 Physical component summary (PCS) score - orthogonal method T-score"] ) ) VR36PhysicalAssessment
    let VR36MentalAssessmentDate: date from start of QICoreCommon."ToInterval" ( VR36MentalAssessment.effective ),
    VR36PhysicalAssessmentDate: date from start of QICoreCommon."ToInterval" ( VR36PhysicalAssessment.effective )
    where VR36MentalAssessmentDate same day as VR36PhysicalAssessmentDate
      and VR36MentalAssessment.value is not null
      and VR36PhysicalAssessment.value is not null
    return Max({ VR36MentalAssessmentDate, VR36PhysicalAssessmentDate })

define "Has Encounter with Initial and Follow Up MLHFQ Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date MLHFQ Total Assessment Completed" InitialMLHFQDate,
      "Date MLHFQ Total Assessment Completed" FollowupMLHFQDate
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialMLHFQDate 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupMLHFQDate during day of Interval[date from InitialMLHFQDate + 30 days, date from InitialMLHFQDate + 180 days]
      return ValidEncounters
  )

define "Date MLHFQ Total Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "Physical score [MLHFQ]"] ) ) MLHFQPhysical,
    ( Status."Final Survey Observation" ( [Observation: "Emotional score [MLHFQ]"] ) ) MLHFQEmotional
    let MLHFQPhysicalDate: date from start of QICoreCommon."ToInterval" ( MLHFQPhysical.effective ),
    MLHFQEmotionalDate: date from start of QICoreCommon."ToInterval" ( MLHFQEmotional.effective )
    where MLHFQPhysicalDate same day as MLHFQEmotionalDate
      and MLHFQPhysical.value is not null
      and MLHFQEmotional.value is not null
    return Max({ MLHFQPhysicalDate, MLHFQEmotionalDate })

define "Has Encounter with Initial and Follow Up KCCQ12 Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date KCCQ12 Total Assessment Completed" InitialKCCQ12Date,
      "Date KCCQ12 Total Assessment Completed" FollowupKCCQ12Date
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialKCCQ12Date 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupKCCQ12Date during day of Interval[date from InitialKCCQ12Date + 30 days, date from InitialKCCQ12Date + 180 days]
      return ValidEncounters
  )

define "Date KCCQ12 Total Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "Kansas City Cardiomyopathy Questionnaire - 12 item [KCCQ-12]"] ) ) KCCQ12Item,
    ( Status."Final Survey Observation" ( [Observation: "Overall summary score [KCCQ-12]"] ) ) KCCQ12Summary
    let KCCQ12ItemDate: date from start of QICoreCommon."ToInterval" ( KCCQ12Item.effective ),
    KCCQ12SummaryDate: date from start of QICoreCommon."ToInterval" ( KCCQ12Summary.effective )
    where KCCQ12ItemDate same day as KCCQ12SummaryDate
      and KCCQ12Item.value is not null
      and KCCQ12Summary.value is not null
    return Max({ KCCQ12ItemDate, KCCQ12SummaryDate })

define "Has Encounter with Initial and Follow Up KCCQ Domain Score Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date KCCQ Domain Assessment Completed" InitialKCCQAssessmentDate,
      "Date KCCQ Domain Assessment Completed" FollowupKCCQAssessmentDate
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialKCCQAssessmentDate 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupKCCQAssessmentDate during day of Interval[date from InitialKCCQAssessmentDate + 30 days, date from InitialKCCQAssessmentDate + 180 days]
      return ValidEncounters
  )

define "Date KCCQ Domain Assessment Completed":
  from
    ( Status."Final Survey Observation" ( [Observation: "Quality of life score [KCCQ]"] ) ) KCCQLifeQuality,
    ( Status."Final Survey Observation" ( [Observation: "Symptom stability score [KCCQ]"] ) ) KCCQSymptomStability,
    ( Status."Final Survey Observation" ( [Observation: "Self-efficacy score [KCCQ]"] ) ) KCCQSelfEfficacy,
    ( Status."Final Survey Observation" ( [Observation: "Total symptom score [KCCQ]"] ) ) KCCQSymptoms,
    ( Status."Final Survey Observation" ( [Observation: "Physical limitation score [KCCQ]"] ) ) KCCQPhysicalLimits,
    ( Status."Final Survey Observation" ( [Observation: "Social limitation score [KCCQ]"] ) ) KCCQSocialLimits
    let KCCQLifeQualityDate: date from start of QICoreCommon."ToInterval" ( KCCQLifeQuality.effective ),
    KCCQSymptomStabilityDate: date from start of QICoreCommon."ToInterval" ( KCCQSymptomStability.effective ),
    KCCQSelfEfficacyDate: date from start of QICoreCommon."ToInterval" ( KCCQSelfEfficacy.effective ),
    KCCQSymptomsDate: date from start of QICoreCommon."ToInterval" ( KCCQSymptoms.effective ),
    KCCQPhysicalLimitsDate: date from start of QICoreCommon."ToInterval" ( KCCQPhysicalLimits.effective ),
    KCCQSocialLimitsDate: date from start of QICoreCommon."ToInterval" ( KCCQSocialLimits.effective )
    where KCCQLifeQualityDate same day as KCCQSymptomStabilityDate
      and KCCQSymptomStability.value is not null
      and KCCQLifeQualityDate same day as KCCQSelfEfficacyDate
      and KCCQSelfEfficacy.value is not null
      and KCCQLifeQualityDate same day as KCCQSymptomsDate
      and KCCQSymptoms.value is not null
      and KCCQLifeQualityDate same day as KCCQPhysicalLimitsDate
      and KCCQPhysicalLimits.value is not null
      and KCCQLifeQualityDate same day as KCCQSocialLimitsDate
      and KCCQSocialLimits.value is not null
      and KCCQLifeQuality.value is not null
    return Max({ KCCQLifeQualityDate, KCCQSymptomStabilityDate, KCCQSelfEfficacyDate, KCCQSymptomsDate, KCCQPhysicalLimitsDate, KCCQSocialLimitsDate })

define "Date KCCQ Total Assessment Completed":
  ( Status."Final Survey Observation" ( [Observation: "Overall summary score [KCCQ]"] ) ) KCCQSummaryScore
    let KCCQSummaryScoreDate: date from start of QICoreCommon."ToInterval" ( KCCQSummaryScore.effective )
    where KCCQSummaryScore.value is not null
    return Max({ KCCQSummaryScoreDate })

define "Initial Population":
  AgeInYearsAt(date from start of "Measurement Period") >= 18
    and exists ( ( [Condition: "Heart Failure"] ) HeartFailure
        where QICoreCommon."ToPrevalenceInterval" ( HeartFailure ) overlaps before "Measurement Period"
    )
    and exists ( "Two Outpatient Encounters during Measurement Period" )

define "Two Outpatient Encounters during Measurement Period":
  from
    "Qualifying Encounters" OfficeVisit1,
    "Qualifying Encounters" OfficeVisit2
    where QICoreCommon."ToInterval" ( OfficeVisit2.period ) starts 1 day or more after day of end of QICoreCommon."ToInterval" ( OfficeVisit1.period )
    return OfficeVisit1

define "Has Encounter with Initial and Follow Up KCCQ Total Score Assessments":
  exists ( from
      "Qualifying Encounters" ValidEncounters,
      "Date KCCQ Total Assessment Completed" InitialKCCQTotalScore,
      "Date KCCQ Total Assessment Completed" FollowupKCCQTotalScore
      where QICoreCommon."ToInterval" ( ValidEncounters.period ) ends 180 days or more before day of end of "Measurement Period"
        and InitialKCCQTotalScore 14 days or less on or before day of end of QICoreCommon."ToInterval" ( ValidEncounters.period )
        and date from FollowupKCCQTotalScore during day of Interval[date from InitialKCCQTotalScore + 30 days, date from InitialKCCQTotalScore + 180 days]
      return ValidEncounters
  )
