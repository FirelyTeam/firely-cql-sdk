library CMS133FHIRCataracts2040BCVA90Days version '1.0.000'

using QICore version '6.0.0'

include FHIRHelpers version '4.4.000' called FHIRHelpers
include SupplementalDataElements version '5.1.000' called SDE
include QICoreCommon version '4.0.000' called QICoreCommon

codesystem "SNOMEDCT": 'http://snomed.info/sct'

valueset "Acute and Subacute Iridocyclitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1241'
valueset "Amblyopia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1448'
valueset "Best Corrected Visual Acuity Exam Using Snellen Chart": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1560'
valueset "Burn Confined to Eye and Adnexa": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1409'
valueset "Cataract Congenital": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1412'
valueset "Cataract Mature or Hypermature": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1413'
valueset "Cataract Posterior Polar": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1414'
valueset "Cataract Secondary to Ocular Disorders": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1410'
valueset "Cataract Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1411'
valueset "Central Corneal Ulcer": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1428'
valueset "Certain Types of Iridocyclitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1415'
valueset "Choroidal Degenerations": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1450'
valueset "Choroidal Detachment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1451'
valueset "Choroidal Hemorrhage and Rupture": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1452'
valueset "Chronic Iridocyclitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1416'
valueset "Cloudy Cornea": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1417'
valueset "Corneal Edema": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1418'
valueset "Degeneration of Macula and Posterior Pole": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1453'
valueset "Degenerative Disorders of Globe": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1454'
valueset "Diabetic Macular Edema": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1455'
valueset "Diabetic Retinopathy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.327'
valueset "Disorders of Cornea Including Corneal Opacity": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1419'
valueset "Disorders of Optic Chiasm": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1457'
valueset "Disorders of Visual Cortex": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1458'
valueset "Disseminated Chorioretinitis and Disseminated Retinochoroiditis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1459'
valueset "Focal Chorioretinitis and Focal Retinochoroiditis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1460'
valueset "Glaucoma": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1423'
valueset "Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1461'
valueset "Hereditary Choroidal Dystrophies": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1462'
valueset "Hereditary Corneal Dystrophies": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1424'
valueset "Hereditary Retinal Dystrophies": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1463'
valueset "Hypotony of Eye": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1426'
valueset "Injury to Optic Nerve and Pathways": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1427'
valueset "Macular Scar of Posterior Polar": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1559'
valueset "Morgagnian Cataract": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1558'
valueset "Nystagmus and Other Irregular Eye Movements": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1465'
valueset "Open Wound of Eyeball": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1430'
valueset "Optic Atrophy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1466'
valueset "Optic Neuritis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1467'
valueset "Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1468'
valueset "Other Background Retinopathy and Retinal Vascular Changes": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1469'
valueset "Other Disorders of Optic Nerve": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1471'
valueset "Other Endophthalmitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1473'
valueset "Other Proliferative Retinopathy": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1480'
valueset "Pathologic Myopia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1432'
valueset "Posterior Lenticonus": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1433'
valueset "Prior Penetrating Keratoplasty": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1475'
valueset "Purulent Endophthalmitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1477'
valueset "Retinal Detachment with Retinal Defect": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1478'
valueset "Retinal Vascular Occlusion": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1479'
valueset "Retrolental Fibroplasias": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1438'
valueset "Scleritis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1226.1'
valueset "Separation of Retinal Layers": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1482'
valueset "Traumatic Cataract": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1443'
valueset "Uveitis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1444'
valueset "Vascular Disorders of Iris and Ciliary Body": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1445'
valueset "Visual Acuity 20/40 or Better": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1483'
valueset "Visual Field Defects": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1446'

code "Best corrected visual acuity (observable entity)": '419775003' from "SNOMEDCT" display 'Best corrected visual acuity (observable entity)'

parameter "Measurement Period" Interval<DateTime>
  default Interval[@2026-01-01T00:00:00.000Z, @2027-01-01T00:00:00.000Z)

context Patient

define "Denominator":
  "Initial Population"

define "Initial Population":
  "Cataract Surgery Between January and September of Measurement Period" CataractSurgeryPerformed
    where AgeInYearsAt(date from start of "Measurement Period") >= 18

define "Cataract Surgery Between January and September of Measurement Period":
  [Procedure: "Cataract Surgery"] CataractSurgery
    where CataractSurgery.performed.toInterval ( ) during day of "Measurement Period"
      and CataractSurgery.performed.toInterval ( ) starts 92 days or more before day of end of "Measurement Period"
      and CataractSurgery.status = 'completed'

define "Denominator Exclusions":
  "Cataract Surgeries in Patients with Significant Ocular Conditions Impacting the Visual Outcome of Surgery"

define "Cataract Surgeries in Patients with Significant Ocular Conditions Impacting the Visual Outcome of Surgery":
  "Cataract Surgery Between January and September of Measurement Period" CataractSurgeryPerformed
    with ( ( ["ConditionProblemsHealthConcerns": "Acute and Subacute Iridocyclitis"]
        union ["ConditionEncounterDiagnosis": "Acute and Subacute Iridocyclitis"]
    )
      union ( ["ConditionProblemsHealthConcerns": "Amblyopia"]
          union ["ConditionEncounterDiagnosis": "Amblyopia"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Burn Confined to Eye and Adnexa"]
          union ["ConditionEncounterDiagnosis": "Burn Confined to Eye and Adnexa"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Cataract Secondary to Ocular Disorders"]
          union ["ConditionEncounterDiagnosis": "Cataract Secondary to Ocular Disorders"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Cataract Congenital"]
          union ["ConditionEncounterDiagnosis": "Cataract Congenital"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Cataract Mature or Hypermature"]
          union ["ConditionEncounterDiagnosis": "Cataract Mature or Hypermature"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Cataract Posterior Polar"]
          union ["ConditionEncounterDiagnosis": "Cataract Posterior Polar"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Central Corneal Ulcer"]
          union ["ConditionEncounterDiagnosis": "Central Corneal Ulcer"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Certain Types of Iridocyclitis"]
          union ["ConditionEncounterDiagnosis": "Certain Types of Iridocyclitis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Choroidal Degenerations"]
          union ["ConditionEncounterDiagnosis": "Choroidal Degenerations"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Choroidal Detachment"]
          union ["ConditionEncounterDiagnosis": "Choroidal Detachment"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Choroidal Hemorrhage and Rupture"]
          union ["ConditionEncounterDiagnosis": "Choroidal Hemorrhage and Rupture"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Chronic Iridocyclitis"]
          union ["ConditionEncounterDiagnosis": "Chronic Iridocyclitis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Cloudy Cornea"]
          union ["ConditionEncounterDiagnosis": "Cloudy Cornea"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Corneal Edema"]
          union ["ConditionEncounterDiagnosis": "Corneal Edema"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Disorders of Cornea Including Corneal Opacity"]
          union ["ConditionEncounterDiagnosis": "Disorders of Cornea Including Corneal Opacity"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Degeneration of Macula and Posterior Pole"]
          union ["ConditionEncounterDiagnosis": "Degeneration of Macula and Posterior Pole"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Degenerative Disorders of Globe"]
          union ["ConditionEncounterDiagnosis": "Degenerative Disorders of Globe"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Diabetic Macular Edema"]
          union ["ConditionEncounterDiagnosis": "Diabetic Macular Edema"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Diabetic Retinopathy"]
          union ["ConditionEncounterDiagnosis": "Diabetic Retinopathy"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Disorders of Optic Chiasm"]
          union ["ConditionEncounterDiagnosis": "Disorders of Optic Chiasm"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Disorders of Visual Cortex"]
          union ["ConditionEncounterDiagnosis": "Disorders of Visual Cortex"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Disseminated Chorioretinitis and Disseminated Retinochoroiditis"]
          union ["ConditionEncounterDiagnosis": "Disseminated Chorioretinitis and Disseminated Retinochoroiditis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Focal Chorioretinitis and Focal Retinochoroiditis"]
          union ["ConditionEncounterDiagnosis": "Focal Chorioretinitis and Focal Retinochoroiditis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Glaucoma"]
          union ["ConditionEncounterDiagnosis": "Glaucoma"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes"]
          union ["ConditionEncounterDiagnosis": "Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Hereditary Choroidal Dystrophies"]
          union ["ConditionEncounterDiagnosis": "Hereditary Choroidal Dystrophies"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Hereditary Corneal Dystrophies"]
          union ["ConditionEncounterDiagnosis": "Hereditary Corneal Dystrophies"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Hereditary Retinal Dystrophies"]
          union ["ConditionEncounterDiagnosis": "Hereditary Retinal Dystrophies"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Hypotony of Eye"]
          union ["ConditionEncounterDiagnosis": "Hypotony of Eye"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Injury to Optic Nerve and Pathways"]
          union ["ConditionEncounterDiagnosis": "Injury to Optic Nerve and Pathways"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Macular Scar of Posterior Polar"]
          union ["ConditionEncounterDiagnosis": "Macular Scar of Posterior Polar"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Morgagnian Cataract"]
          union ["ConditionEncounterDiagnosis": "Morgagnian Cataract"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Nystagmus and Other Irregular Eye Movements"]
          union ["ConditionEncounterDiagnosis": "Nystagmus and Other Irregular Eye Movements"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Open Wound of Eyeball"]
          union ["ConditionEncounterDiagnosis": "Open Wound of Eyeball"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Optic Atrophy"]
          union ["ConditionEncounterDiagnosis": "Optic Atrophy"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Optic Neuritis"]
          union ["ConditionEncounterDiagnosis": "Optic Neuritis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis"]
          union ["ConditionEncounterDiagnosis": "Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Other Background Retinopathy and Retinal Vascular Changes"]
          union ["ConditionEncounterDiagnosis": "Other Background Retinopathy and Retinal Vascular Changes"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Other Disorders of Optic Nerve"]
          union ["ConditionEncounterDiagnosis": "Other Disorders of Optic Nerve"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Other Endophthalmitis"]
          union ["ConditionEncounterDiagnosis": "Other Endophthalmitis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Other Proliferative Retinopathy"]
          union ["ConditionEncounterDiagnosis": "Other Proliferative Retinopathy"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Pathologic Myopia"]
          union ["ConditionEncounterDiagnosis": "Pathologic Myopia"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Posterior Lenticonus"]
          union ["ConditionEncounterDiagnosis": "Posterior Lenticonus"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Prior Penetrating Keratoplasty"]
          union ["ConditionEncounterDiagnosis": "Prior Penetrating Keratoplasty"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Purulent Endophthalmitis"]
          union ["ConditionEncounterDiagnosis": "Purulent Endophthalmitis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Retinal Detachment with Retinal Defect"]
          union ["ConditionEncounterDiagnosis": "Retinal Detachment with Retinal Defect"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Retinal Vascular Occlusion"]
          union ["ConditionEncounterDiagnosis": "Retinal Vascular Occlusion"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Retrolental Fibroplasias"]
          union ["ConditionEncounterDiagnosis": "Retrolental Fibroplasias"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Scleritis"]
          union ["ConditionEncounterDiagnosis": "Scleritis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Separation of Retinal Layers"]
          union ["ConditionEncounterDiagnosis": "Separation of Retinal Layers"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Traumatic Cataract"]
          union ["ConditionEncounterDiagnosis": "Traumatic Cataract"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Uveitis"]
          union ["ConditionEncounterDiagnosis": "Uveitis"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Vascular Disorders of Iris and Ciliary Body"]
          union ["ConditionEncounterDiagnosis": "Vascular Disorders of Iris and Ciliary Body"]
      )
      union ( ["ConditionProblemsHealthConcerns": "Visual Field Defects"]
          union ["ConditionEncounterDiagnosis": "Visual Field Defects"]
      ) ) ComorbidDiagnosis
      such that ComorbidDiagnosis.prevalenceInterval ( ) overlaps before day of CataractSurgeryPerformed.performed.toInterval ( )
        and ComorbidDiagnosis.isVerified ( )

define "Numerator":
  "Cataract Surgery Between January and September of Measurement Period" CataractSurgeryPerformed
    with ( [ObservationClinicalResult: "Best corrected visual acuity (observable entity)"]
      union [ObservationClinicalResult: "Best Corrected Visual Acuity Exam Using Snellen Chart"] ) VisualAcuityExamPerformed
      such that VisualAcuityExamPerformed.effective.toInterval ( ) 90 days or less after day of end of CataractSurgeryPerformed.performed.toInterval ( )
        and VisualAcuityExamPerformed.status in { 'final', 'amended', 'corrected' }
        and VisualAcuityExamPerformed.value as Concept in "Visual Acuity 20/40 or Better"
        
/*
@description: Returns true if the given Condition has a verification status of "confirmed", "unconfirmed", "provisional", or "differential"
*/


define fluent function isVerified(condition Choice<ConditionEncounterDiagnosis, ConditionProblemsHealthConcerns>):
  condition.verificationStatus is not null implies ( condition.verificationStatus ~ QICoreCommon."confirmed"
      or condition.verificationStatus ~ QICoreCommon."unconfirmed"
      or condition.verificationStatus ~ QICoreCommon."provisional"
      or condition.verificationStatus ~ QICoreCommon."differential"
  )

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"