library Cataracts2040BCVAwithin90DaysFHIR version '0.1.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.3.000' called FHIRHelpers
include SupplementalDataElements version '3.4.000' called SDE
include QICoreCommon version '2.0.000' called QICoreCommon

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
  default Interval[@2025-01-01T00:00:00.0, @2026-01-01T00:00:00.0)

context Patient

define "Denominator":
  "Initial Population"

define "Initial Population":
  "Cataract Surgery Between January and September of Measurement Period" CataractSurgeryPerformed
    where AgeInYearsAt(date from start of "Measurement Period") >= 18

define "Cataract Surgery Between January and September of Measurement Period":
  [Procedure: "Cataract Surgery"] CataractSurgery
    where CataractSurgery.performed.toInterval ( ) during "Measurement Period"
      and CataractSurgery.performed.toInterval ( ) starts 92 days or more before end of "Measurement Period"
      and CataractSurgery.status = 'completed'

define "Denominator Exclusions":
  "Cataract Surgery Between January and September of Measurement Period" CataractSurgeryPerformed
    with ( [Condition: "Acute and Subacute Iridocyclitis"]
      union [Condition: "Amblyopia"]
      union [Condition: "Burn Confined to Eye and Adnexa"]
      union [Condition: "Cataract Secondary to Ocular Disorders"]
      union [Condition: "Cataract Congenital"]
      union [Condition: "Cataract Mature or Hypermature"]
      union [Condition: "Cataract Posterior Polar"]
      union [Condition: "Central Corneal Ulcer"]
      union [Condition: "Certain Types of Iridocyclitis"]
      union [Condition: "Choroidal Degenerations"]
      union [Condition: "Choroidal Detachment"]
      union [Condition: "Choroidal Hemorrhage and Rupture"]
      union [Condition: "Chronic Iridocyclitis"]
      union [Condition: "Cloudy Cornea"]
      union [Condition: "Corneal Edema"]
      union [Condition: "Disorders of Cornea Including Corneal Opacity"]
      union [Condition: "Degeneration of Macula and Posterior Pole"]
      union [Condition: "Degenerative Disorders of Globe"]
      union [Condition: "Diabetic Macular Edema"]
      union [Condition: "Diabetic Retinopathy"]
      union [Condition: "Disorders of Optic Chiasm"]
      union [Condition: "Disorders of Visual Cortex"]
      union [Condition: "Disseminated Chorioretinitis and Disseminated Retinochoroiditis"]
      union [Condition: "Focal Chorioretinitis and Focal Retinochoroiditis"]
      union [Condition: "Glaucoma"]
      union [Condition: "Glaucoma Associated with Congenital Anomalies and Dystrophies and Systemic Syndromes"]
      union [Condition: "Hereditary Choroidal Dystrophies"]
      union [Condition: "Hereditary Corneal Dystrophies"]
      union [Condition: "Hereditary Retinal Dystrophies"]
      union [Condition: "Hypotony of Eye"]
      union [Condition: "Injury to Optic Nerve and Pathways"]
      union [Condition: "Macular Scar of Posterior Polar"]
      union [Condition: "Morgagnian Cataract"]
      union [Condition: "Nystagmus and Other Irregular Eye Movements"]
      union [Condition: "Open Wound of Eyeball"]
      union [Condition: "Optic Atrophy"]
      union [Condition: "Optic Neuritis"]
      union [Condition: "Other and Unspecified Forms of Chorioretinitis and Retinochoroiditis"]
      union [Condition: "Other Background Retinopathy and Retinal Vascular Changes"]
      union [Condition: "Other Disorders of Optic Nerve"]
      union [Condition: "Other Endophthalmitis"]
      union [Condition: "Other Proliferative Retinopathy"]
      union [Condition: "Pathologic Myopia"]
      union [Condition: "Posterior Lenticonus"]
      union [Condition: "Prior Penetrating Keratoplasty"]
      union [Condition: "Purulent Endophthalmitis"]
      union [Condition: "Retinal Detachment with Retinal Defect"]
      union [Condition: "Retinal Vascular Occlusion"]
      union [Condition: "Retrolental Fibroplasias"]
      union [Condition: "Scleritis"]
      union [Condition: "Separation of Retinal Layers"]
      union [Condition: "Traumatic Cataract"]
      union [Condition: "Uveitis"]
      union [Condition: "Vascular Disorders of Iris and Ciliary Body"]
      union [Condition: "Visual Field Defects"] ) ComorbidDiagnosis
      such that ComorbidDiagnosis.prevalenceInterval ( ) overlaps before CataractSurgeryPerformed.performed.toInterval ( )
        and ComorbidDiagnosis.isActive ( )

define "Numerator":
  "Cataract Surgery Between January and September of Measurement Period" CataractSurgeryPerformed
    with ( [Observation: "Best corrected visual acuity (observable entity)"]
      union [Observation: "Best Corrected Visual Acuity Exam Using Snellen Chart"] ) VisualAcuityExamPerformed
      such that VisualAcuityExamPerformed.effective.toInterval ( ) 90 days or less after day of end of CataractSurgeryPerformed.performed.toInterval ( )
        and VisualAcuityExamPerformed.status in { 'final', 'amended', 'corrected', 'preliminary' }
        and VisualAcuityExamPerformed.value as Concept in "Visual Acuity 20/40 or Better"

define "SDE Ethnicity":
  SDE."SDE Ethnicity"

define "SDE Payer":
  SDE."SDE Payer"

define "SDE Race":
  SDE."SDE Race"

define "SDE Sex":
  SDE."SDE Sex"
