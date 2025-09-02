library AlaraCommonFunctions version '1.5.000'

using QICore version '4.1.1'

include FHIRHelpers version '4.4.000' called FHIRHelpers

codesystem "LOINC": 'http://loinc.org'

code "Abdomen and Pelvis High Dose": 'LA31754-7' from "LOINC" display 'Abdomen and Pelvis High Dose'
code "Abdomen and Pelvis Low Dose": 'LA31752-1' from "LOINC" display 'Abdomen and Pelvis Low Dose'
code "Abdomen and Pelvis Routine Dose": 'LA31753-9' from "LOINC" display 'Abdomen and Pelvis Routine Dose'
code "Calculated CT global noise": '96912-1' from "LOINC" display 'Calculated CT global noise'
code "Calculated CT size-adjusted dose": '96913-9' from "LOINC" display 'Calculated CT size-adjusted dose'
code "Cardiac High Dose or Chest High Dose": 'LA31761-2' from "LOINC" display 'Cardiac High Dose or Chest High Dose'
code "Cardiac Low Dose": 'LA31755-4' from "LOINC" display 'Cardiac Low Dose'
code "Cardiac Routine Dose": 'LA31756-2' from "LOINC" display 'Cardiac Routine Dose'
code "Chest Low Dose": 'LA31758-8' from "LOINC" display 'Chest Low Dose'
code "Chest Routine Dose": 'LA31759-6' from "LOINC" display 'Chest Routine Dose'
code "Extremity": 'LA31765-3' from "LOINC" display 'Extremity'
code "Head High Dose": 'LA31764-6' from "LOINC" display 'Head High Dose'
code "Head Low Dose": 'LA31762-0' from "LOINC" display 'Head Low Dose'
code "Head Routine Dose": 'LA31763-8' from "LOINC" display 'Head Routine Dose'
code "Neck or Cervical Spine": 'LA31766-1' from "LOINC" display 'Neck or Cervical Spine'
code "Simultaneous Chest and Abdomen and Pelvis": 'LA31768-7' from "LOINC" display 'Simultaneous Chest and Abdomen and Pelvis'
code "Simultaneous Head and Neck High Dose": 'LA31770-3' from "LOINC" display 'Simultaneous Head and Neck High Dose'
code "Simultaneous Head and Neck Routine Dose": 'LA31769-5' from "LOINC" display 'Simultaneous Head and Neck Routine Dose'
code "Simultaneous Thoracic and Lumbar Spine": 'LA31851-1' from "LOINC" display 'Simultaneous Thoracic and Lumbar Spine'
code "Thoracic or Lumbar Spine": 'LA31767-9' from "LOINC" display 'Thoracic or Lumbar Spine'

context Patient

define function "CT Scan Qualifies"(Obs Observation ):
  "Qualifies"(Obs, "Abdomen and Pelvis Low Dose", 64, 598)
    or "Qualifies"(Obs, "Abdomen and Pelvis Routine Dose", 29, 644)
    or "Qualifies"(Obs, "Abdomen and Pelvis High Dose", 29, 1260)
    or "Qualifies"(Obs, "Cardiac Low Dose", 55, 93)
    or "Qualifies"(Obs, "Cardiac Routine Dose", 32, 576)
    or "Qualifies"(Obs, "Chest Low Dose", 55, 377)
    or "Qualifies"(Obs, "Chest Routine Dose", 49, 377)
    or "Qualifies"(Obs, "Cardiac High Dose or Chest High Dose", 49, 1282)
    or "Qualifies"(Obs, "Head Low Dose", 115, 582)
    or "Qualifies"(Obs, "Head Routine Dose", 115, 1025)
    or "Qualifies"(Obs, "Head High Dose", 115, 1832)
    or "Qualifies"(Obs, "Extremity", 73, 320)
    or "Qualifies"(Obs, "Neck or Cervical Spine", 25, 1260)
    or "Qualifies"(Obs, "Thoracic or Lumbar Spine", 25, 1260)
    or "Qualifies"(Obs, "Simultaneous Chest and Abdomen and Pelvis", 29, 1637)
    or "Qualifies"(Obs, "Simultaneous Thoracic and Lumbar Spine", 25, 2520)
    or "Qualifies"(Obs, "Simultaneous Head and Neck Routine Dose", 25, 2285)
    or "Qualifies"(Obs, "Simultaneous Head and Neck High Dose", 25, 3092)

define function "Qualifies"(Obs Observation, code System.Code, noiseThreshold Decimal, sizeDoseThreshold Decimal ):
  (Obs.value as Concept).codes contains code
    and ( "Global Noise Value"(Obs)>= noiseThreshold
        or "Size Adjusted Value"(Obs)>= sizeDoseThreshold
    )

define function "Global Noise Value"(Obs Observation ):
  singleton from ( Obs.component C
      where C.code ~ "Calculated CT global noise"
        and ( C.value as Quantity ).unit = '[hnsf\'U]'
      return (C.value as Quantity).value
  )

define function "Size Adjusted Value"(Obs Observation ):
  singleton from ( Obs.component C
      where C.code ~ "Calculated CT size-adjusted dose"
        and ( C.value as Quantity ).unit = 'mGy.cm'
      return (C.value as Quantity).value
  )