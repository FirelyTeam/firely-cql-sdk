library IntensiveCareUnitVenousThromboembolismProphylaxisFHIR version '0.0.012'

using FHIR version '4.0.1'

include FHIRHelpers version '4.0.001' called FHIRHelpers
include SupplementalDataElementsFHIR4 version '2.0.000' called SDE
include VTEFHIR4 version '4.8.000' called VTE
include MATGlobalCommonFunctionsFHIR4 version '6.1.000' called Global

codesystem "LOINC": 'http://loinc.org' 

valueset "Atrial Fibrillation/Flutter": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.202' 
valueset "Comfort Measures": 'http://cts.nlm.nih.gov/fhir/ValueSet/1.3.6.1.4.1.33895.1.3.0.45' 
valueset "Device Application": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.48' 
valueset "Direct Thrombin Inhibitor": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.205' 
valueset "Emergency Department Visit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.292' 
valueset "General or Neuraxial Anesthesia": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1743' 
valueset "General Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.255' 
valueset "Glycoprotein IIb/IIIa Inhibitors": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.41' 
valueset "Graduated compression stockings (GCS)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.256' 
valueset "Gynecological Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.257' 
valueset "Hemorrhagic Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.212' 
valueset "Hip Fracture Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.258' 
valueset "Hip Replacement Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.259' 
valueset "Injectable Factor Xa Inhibitor for VTE Prophylaxis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.211' 
valueset "INR": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.213' 
valueset "Intensive Care Unit": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1029.206' 
valueset "Intermittent pneumatic compression devices (IPC)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.214' 
valueset "Intracranial Neurosurgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.260' 
valueset "Intravenous route": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.222' 
valueset "Ischemic Stroke": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.247' 
valueset "Knee Replacement Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.261' 
valueset "Low Dose Unfractionated Heparin for VTE Prophylaxis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1045.39' 
valueset "Low Molecular Weight Heparin for VTE Prophylaxis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.219' 
valueset "Low Risk": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.400' 
valueset "Medical Reason": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.473' 
valueset "Mental Health Diagnoses": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.105.12.1004' 
valueset "Obstetrics": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.263' 
valueset "Obstetrics VTE": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.264' 
valueset "Oral Factor Xa Inhibitor for VTE Prophylaxis or VTE Treatment": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.134' 
valueset "Patient Refusal": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.93' 
valueset "Rivaroxaban for VTE Prophylaxis": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1110.50' 
valueset "Subcutaneous route": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.223' 
valueset "Unfractionated Heparin": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.218' 
valueset "Urological Surgery": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.272' 
valueset "Venous foot pumps (VFP)": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.230' 
valueset "Venous Thromboembolism": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.279' 
valueset "Warfarin": 'http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.117.1.7.1.232' 

code "Risk for venous thromboembolism": '72136-5' from "LOINC" display 'Risk for venous thromboembolism'

parameter "Measurement Period" Interval<DateTime>

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
  "Encounter With Age Range and Without VTE Diagnosis or Obstetrical Conditions"

define "Encounter With Age Range and Without VTE Diagnosis or Obstetrical Conditions":
  ( Global."Inpatient Encounter" InpatientEncounter
              where "AgeInYearsAt"(start of InpatientEncounter.period) >= 18
              )
              intersect "Admission Without VTE or Obstetrical Conditions"

define "Admission Without VTE or Obstetrical Conditions":
  Global."Inpatient Encounter" InpatientEncounter
          		    where not (exists (Global.EncounterDiagnosis(InpatientEncounter)) EncounterDiagnosis
                        where (EncounterDiagnosis.code in "Obstetrics"
          								or EncounterDiagnosis.code in "Venous Thromboembolism"
          								or EncounterDiagnosis.code in "Obstetrics VTE"
          			         )
                  )

define "Denominator":
  "Encounter With ICU Location"

define "Encounter With ICU Location":
  "Encounter With Age Range and Without VTE Diagnosis or Obstetrical Conditions" QualifyingEncounter
          	where exists (QualifyingEncounter.location Location
        				where Global.GetLocation(Location.location).type in "Intensive Care Unit"
          			and Location.period during QualifyingEncounter.period
          	)

define "Denominator Exclusions":
  "Encounter With ICU Location And Encounter Less Than 2 Days"
          union "Encounter With First ICU Stay With Principal Procedure of SCIP VTE Selected Surgery"
        	union "Encounter With Intervention Comfort Measures From Day Of Start of Hospitalization To Day After First ICU Stay"
        	union "Encounter With Intervention Comfort Measures on Day of or Day After Procedure"

define "Encounter With ICU Location And Encounter Less Than 2 Days":
  "Encounter With ICU Location"QualifyingEncounterICU
          	where Global."LengthInDays"(QualifyingEncounterICU.period)< 2

define "Numerator":
  "Encounter With VTE Prophylaxis Received on Day of or Day After First ICU Stay or Procedure"
        	union ( "Encounter With Medication Oral Factor Xa Inhibitor Administered on Day of or Day After First ICU Stay or Procedure"
        			intersect ( "Encounter With Prior or Present Diagnosis of Atrial Fibrillation or VTE"
        					union "Encounter With Prior or Present Procedure of Hip or Knee Replacement Surgery"
        			)
        	)
        	union "Encounter With Low Risk for VTE or Anticoagulant Administered"
        	union "Encounter With No VTE Prophylaxis Due to Medical Reason"
        	union "Encounter With No VTE Prophylaxis Due to Patient Refusal"

define "Encounter With Low Risk for VTE or Anticoagulant Administered":
  "Low Risk for VTE or Anticoagulant Administered From Day of Start of Hospitalization To Day After First ICU Stay"
          union "Low Risk for VTE or Anticoagulant Administered on Day of or Day After Procedure"

define "Encounter With No VTE Prophylaxis Due to Medical Reason":
  ( "No VTE Prophylaxis Medication Due to Medical Reason From Day Of Start of Hospitalization To Day After First ICU Stay"
            intersect "No VTE Prophylaxis Device Due to Medical Reason From Day of Start of Hospitalization To Day After First ICU Stay"
          )
          union ( "No VTE Prophylaxis Medication Due to Medical Reason on Day of or Day After Procedure"
              intersect "No VTE Prophylaxis Device Due to Medical Reason on Day of or Day After Procedure"
          )

define "Encounter With No VTE Prophylaxis Due to Patient Refusal":
  "No VTE Prophylaxis Due to Patient Refusal From Day of Start of Hospitalization To Day After First ICU Stay"
        	union "No VTE Prophylaxis Due to Patient Refusal on Day of or Day After Procedure"

define "Denominator Exceptions":
  "Encounter With First ICU Location Stay Less Than 1 day"

define "Encounter With First ICU Location Stay Less Than 1 day":
  "Encounter With ICU Location" QualifyingEncounterICU
        	 where Global."LengthInDays"(VTE."FirstICULocationPeriod"(QualifyingEncounterICU)) < 1

define "SCIP VTE Selected Surgery":
  (	["Procedure": "General Surgery"]
          		union ["Procedure": "Gynecological Surgery"]
          		union ["Procedure": "Hip Fracture Surgery"]
          		union ["Procedure": "Hip Replacement Surgery"]
          		union ["Procedure": "Intracranial Neurosurgery"]
          		union ["Procedure": "Knee Replacement Surgery"]
          		union ["Procedure": "Urological Surgery"] ) Procedure
          		where Procedure.status = 'completed'

define "Encounter With Intervention Comfort Measures on Day of or Day After Procedure":
  from
            "Encounter With ICU Location" QualifyingEncounterICU,
            ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
            "Intervention Comfort Measures" ComfortMeasure
            where  AnesthesiaProcedure.status = 'completed'
              	and Global."Normalize Interval"(AnesthesiaProcedure.performed ) ends 1 day after day of VTE."StartOfFirstICU"(QualifyingEncounterICU)
                and date from (Coalesce(start of Global."Normalize Interval"(ComfortMeasure.performed), ComfortMeasure.authoredOn)) during VTE."CalendarDayOfOrDayAfter"(
            			end of Global."Normalize Interval"(AnesthesiaProcedure.performed))
            	return QualifyingEncounterICU

define "VTE Prophylaxis by Medication Administered or Device Applied":
  ( ["MedicationAdministration":"Low Dose Unfractionated Heparin for VTE Prophylaxis"] VTEMedication
              where VTEMedication.status ='completed'
                   and VTEMedication.dosage.route in "Subcutaneous route"
          )
           union (["MedicationAdministration": "Low Molecular Weight Heparin for VTE Prophylaxis"] LMWH where LMWH.status = 'completed')
            union (["MedicationAdministration":  "Injectable Factor Xa Inhibitor for VTE Prophylaxis"] FactorXa where FactorXa.status = 'completed')
             union (["MedicationAdministration":  "Warfarin"] Warfarin where Warfarin.status = 'completed')
              union (
                  ["Procedure": "Device Application"] DeviceApplied
                  where DeviceApplied.status = 'completed'
                        and (DeviceApplied.usedCode in "Intermittent pneumatic compression devices (IPC)"
                            or DeviceApplied.usedCode in"Venous foot pumps (VFP)"
                            or DeviceApplied.usedCode in "Graduated compression stockings (GCS)"
                            )
                  )

define "Encounter With VTE Prophylaxis Received on Day of or Day After First ICU Stay or Procedure":
  ( from
        			"Encounter With ICU Location" QualifyingEncounterICU,
        			"VTE Prophylaxis by Medication Administered or Device Applied" VTEProphylaxis
        			where date from(start of Coalesce(Global."Normalize Interval"(VTEProphylaxis.effective), Global."Normalize Interval"(VTEProphylaxis.performed))) during VTE."CalendarDayOfOrDayAfter"(VTE."StartOfFirstICU"(QualifyingEncounterICU))
        			return QualifyingEncounterICU
        	)
        	union ( from
        				"Encounter With ICU Location" QualifyingEncounterICU,
        				["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
        				"VTE Prophylaxis by Medication Administered or Device Applied" VTEProphylaxis
        				where Global."Normalize Interval"(AnesthesiaProcedure.performed) ends 1 day after day of VTE."StartOfFirstICU"(QualifyingEncounterICU)
        					and date from(start of Coalesce(Global."Normalize Interval"(VTEProphylaxis.effective), Global."Normalize Interval"(VTEProphylaxis.performed))) during VTE."CalendarDayOfOrDayAfter"(
          				end of Global."Normalize Interval"(AnesthesiaProcedure.performed))
                    return QualifyingEncounterICU
                )

define "Encounter With Medication Oral Factor Xa Inhibitor Administered on Day of or Day After First ICU Stay or Procedure":
  ( from
            "Encounter With ICU Location" QualifyingEncounterICU,
             ["MedicationAdministration":  "Oral Factor Xa Inhibitor for VTE Prophylaxis or VTE Treatment"] FactorXaMedication
              where FactorXaMedication.status = 'completed'
                  and date from(start of Global."Normalize Interval"(FactorXaMedication.effective)) during VTE."CalendarDayOfOrDayAfter"(VTE."StartOfFirstICU"(QualifyingEncounterICU))
              return QualifyingEncounterICU
           )
          union ( from
            			 "Encounter With ICU Location" QualifyingEncounterICU,
            			["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
            			["MedicationAdministration":  "Oral Factor Xa Inhibitor for VTE Prophylaxis or VTE Treatment"] FactorXaMedication
            			where FactorXaMedication.status = 'completed'
                    and AnesthesiaProcedure.status = 'completed'
            				and Global."Normalize Interval"(AnesthesiaProcedure.performed) ends 1 day after day of VTE."StartOfFirstICU"(QualifyingEncounterICU)
            					and date from(start of Global."Normalize Interval"(FactorXaMedication.effective)) during VTE."CalendarDayOfOrDayAfter"(
              				end of Global."Normalize Interval"(AnesthesiaProcedure.performed))
            			return QualifyingEncounterICU
                	)

define "Encounter With Prior or Present Procedure of Hip or Knee Replacement Surgery":
  "Encounter With ICU Location" QualifyingEncounterICU
        	with ( ["Procedure": "Hip Replacement Surgery"]
          			union ["Procedure": "Knee Replacement Surgery"] ) HipKneeProcedure
        	such that HipKneeProcedure.status = 'completed'
        			and Global."Normalize Interval"(HipKneeProcedure.performed)  starts on or before end of QualifyingEncounterICU.period

define "Low Risk for VTE or Anticoagulant Administered From Day of Start of Hospitalization To Day After First ICU Stay":
  "Encounter With ICU Location" QualifyingEncounterICU
          with "In Low Risk for VTE or On Anticoagulant" VTERiskAssessment
          such that Global."Normalize Interval"(VTERiskAssessment.effective) during VTE."FromDayOfStartOfHospitalizationToDayAfterFirstICU"(QualifyingEncounterICU)

define "Low Risk for VTE or Anticoagulant Administered on Day of or Day After Procedure":
  from
          	"Encounter With ICU Location" QualifyingEncounterICU,
          	["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
          	"In Low Risk for VTE or On Anticoagulant" LowRiskForVTE
          where Global."Normalize Interval"(AnesthesiaProcedure.performed) ends 1 day after day of VTE."StartOfFirstICU"(QualifyingEncounterICU)
          	and Global."Normalize Interval"(LowRiskForVTE.effective) during VTE."CalendarDayOfOrDayAfter"(end of Global."Normalize Interval"(AnesthesiaProcedure.performed))
          return QualifyingEncounterICU

define "No VTE Prophylaxis Device Due to Medical Reason From Day of Start of Hospitalization To Day After First ICU Stay":
  "Encounter With ICU Location" QualifyingEncounterICU
            with "No VTE Prophylaxis Device Applied or Ordered" NoVTEDevice
            such that NoVTEDevice.requestStatusReason in "Medical Reason"
                and date from(NoVTEDevice.authoredOn) during VTE."FromDayOfStartOfHospitalizationToDayAfterFirstICU"(QualifyingEncounterICU)

define "No VTE Prophylaxis Device Due to Medical Reason on Day of or Day After Procedure":
  from
        		"Encounter With ICU Location" QualifyingEncounterICU,
        		["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
        		"No VTE Prophylaxis Device Applied or Ordered" NoVTEDevice
        		where  NoVTEDevice.requestStatusReason in "Medical Reason"
                and AnesthesiaProcedure.status = 'completed'
                and Global."Normalize Interval"(AnesthesiaProcedure.performed ) ends 1 day after day of VTE."StartOfFirstICU"(QualifyingEncounterICU)
                and date from (NoVTEDevice.authoredOn) during VTE."CalendarDayOfOrDayAfter"(
        			         end of Global."Normalize Interval"(AnesthesiaProcedure.performed))
        		return QualifyingEncounterICU

define "Encounter With Intervention Comfort Measures From Day Of Start of Hospitalization To Day After First ICU Stay":
  "Encounter With ICU Location" QualifyingEncounterICU
              with "Intervention Comfort Measures" ComfortMeasure
            such that date from(Coalesce(start of Global."Normalize Interval"(ComfortMeasure.performed), ComfortMeasure.authoredOn)) during VTE."FromDayOfStartOfHospitalizationToDayAfterFirstICU"(QualifyingEncounterICU)

define "Encounter With First ICU Stay With Principal Procedure of SCIP VTE Selected Surgery":
  from
      "Encounter With ICU Location" QualifyingEncounterICU,
      "SCIP VTE Selected Surgery" SelectedProcedure
      let EncounterProcedure: Global.GetExtension ( QualifyingEncounterICU, 'qicore-encounter-procedure' )
      where FHIRHelpers.ToInteger ( Global.GetExtension ( EncounterProcedure, 'rank' ).value as FHIR.positiveInt ) = 1
        and Global.GetId ( FHIRHelpers.ToString ( ( Global.GetExtension ( EncounterProcedure, 'procedure' ).value as FHIR.Reference ).reference ) ) = SelectedProcedure.id
        and date from ( 
          end of Global."Normalize Interval" ( SelectedProcedure.performed )
        ) during VTE."CalendarDayOfOrDayAfter" ( VTE."StartOfFirstICU" ( QualifyingEncounterICU ) )
      return QualifyingEncounterICU

define "Intervention Comfort Measures":
  ( ["ServiceRequest": "Comfort Measures"] P
        where P.intent = 'order'
          and P.status in { 'active', 'on-hold', 'completed' }
    )
      union ( ["Procedure": "Comfort Measures"] InterventionPerformed
          where InterventionPerformed.status in { 'completed', 'in-progress' }
      )

define "No VTE Prophylaxis Medication Administered or Ordered":
  ( ( ["MedicationAdministration": "Low Dose Unfractionated Heparin for VTE Prophylaxis"]
        union ["MedicationAdministration": "Low Molecular Weight Heparin for VTE Prophylaxis"]
        union ["MedicationAdministration": "Injectable Factor Xa Inhibitor for VTE Prophylaxis"]
        union ["MedicationAdministration": "Warfarin"]
        union ["MedicationAdministration": "Rivaroxaban for VTE Prophylaxis"] ) MedicationAdm
        let MedicationNotDoneTiming: Global.GetExtension ( MedicationAdm, 'qicore-recorded' ).value
        where MedicationAdm.status = 'not-done'
        return {
          id: MedicationAdm.id,
          MedicationStatusReason: MedicationAdm.statusReason,
          authoredOn: MedicationNotDoneTiming
        }
    )
      union ( ( ["MedicationRequest": "Low Dose Unfractionated Heparin for VTE Prophylaxis"]
          union ["MedicationRequest": "Low Molecular Weight Heparin for VTE Prophylaxis"]
          union ["MedicationRequest": "Injectable Factor Xa Inhibitor for VTE Prophylaxis"]
          union ["MedicationRequest": "Warfarin"]
          union ["MedicationRequest": "Rivaroxaban for VTE Prophylaxis"] ) MedicationOrder
          where MedicationOrder.doNotPerform is true
            and MedicationOrder.status in { 'completed', 'cancelled' }
          return {
            id: MedicationOrder.id,
            MedicationStatusReason: MedicationOrder.reasonCode,
            authoredOn: MedicationOrder.authoredOn
          }
      )

define "No VTE Prophylaxis Medication Due to Medical Reason From Day Of Start of Hospitalization To Day After First ICU Stay":
  "Encounter With ICU Location" QualifyingEncounterICU
      with "No VTE Prophylaxis Medication Administered or Ordered" NoVTEMedication
        such that NoVTEMedication.MedicationStatusReason in "Medical Reason"
          and date from ( NoVTEMedication.authoredOn ) during VTE."FromDayOfStartOfHospitalizationToDayAfterFirstICU" ( QualifyingEncounterICU )
      return QualifyingEncounterICU

define "No VTE Prophylaxis Medication Due to Medical Reason on Day of or Day After Procedure":
  from
      "Encounter With ICU Location" QualifyingEncounterICU,
      ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
      "No VTE Prophylaxis Medication Administered or Ordered" NoVTEMedication
      where NoVTEMedication.MedicationStatusReason in "Medical Reason"
        and AnesthesiaProcedure.status = 'completed'
        and Global."Normalize Interval" ( AnesthesiaProcedure.performed ) ends 1 day after day of VTE."StartOfFirstICU" ( QualifyingEncounterICU )
        and date from ( NoVTEMedication.authoredOn ) during VTE."CalendarDayOfOrDayAfter" ( 
        end of Global."Normalize Interval" ( AnesthesiaProcedure.performed as Period ) )
      return QualifyingEncounterICU

define "No VTE Prophylaxis Due to Patient Refusal From Day of Start of Hospitalization To Day After First ICU Stay":
  "Encounter With ICU Location" QualifyingEncounterICU
      with "No VTE Prophylaxis Medication or Device Due to Patient Refusal" PatientRefusal
        such that date from ( PatientRefusal.authoredOn ) during VTE.FromDayOfStartOfHospitalizationToDayAfterFirstICU ( QualifyingEncounterICU )

define "No VTE Prophylaxis Due to Patient Refusal on Day of or Day After Procedure":
  from
      "Encounter With ICU Location" QualifyingEncounterICU,
      ["Procedure": "General or Neuraxial Anesthesia"] AnesthesiaProcedure,
      "No VTE Prophylaxis Medication or Device Due to Patient Refusal" PatientRefusal
      where Global."Normalize Interval" ( AnesthesiaProcedure.performed ) ends 1 day after day of VTE."StartOfFirstICU" ( QualifyingEncounterICU )
        and date from ( PatientRefusal.authoredOn ) during VTE."CalendarDayOfOrDayAfter" ( 
        end of Global."Normalize Interval" ( AnesthesiaProcedure.performed ) )
      return QualifyingEncounterICU

define "No VTE Prophylaxis Medication or Device Due to Patient Refusal":
  ( "No VTE Prophylaxis Medication Administered or Ordered" NoVTEMedication
        where NoVTEMedication.MedicationStatusReason in "Patient Refusal"
    )
      union ( "No VTE Prophylaxis Device Applied or Ordered" NoVTEDevice
          where NoVTEDevice.requestStatusReason in "Patient Refusal"
      )

define "No VTE Prophylaxis Device Applied or Ordered":
  ( ( ["ServiceRequest": "Venous foot pumps (VFP)"]
      union ["ServiceRequest": "Intermittent pneumatic compression devices (IPC)"]
      union ["ServiceRequest": "Graduated compression stockings (GCS)"] ) DeviceOrder
      where DeviceOrder.status = 'completed'
        and DeviceOrder.doNotPerform is true
      return {
        id: DeviceOrder.id,
        requestStatusReason: GetStatusReason(DeviceOrder),
        authoredOn: DeviceOrder.authoredOn
      }
  )
    union ( ["Procedure": "Device Application"] DeviceApplied
        let DeviceNotDoneTiming: Global.GetExtension ( DeviceApplied, 'qicore-recorded' ).value
        where ( DeviceApplied.usedCode in "Intermittent pneumatic compression devices (IPC)"
            or DeviceApplied.usedCode in "Venous foot pumps (VFP)"
            or DeviceApplied.usedCode in "Graduated compression stockings (GCS)"
        )
          and DeviceApplied.status = 'not-done'
        return {
          id: DeviceApplied.id,
          requestStatusReason: DeviceApplied.statusReason,
          authoredOn: DeviceNotDoneTiming
        }
    )

define "In Low Risk for VTE or On Anticoagulant":
  ( ["Observation": "Risk for venous thromboembolism"] VTERiskAssessment
      where FHIRHelpers.ToConcept ( VTERiskAssessment.value ) in "Low Risk"
        and VTERiskAssessment.status in { 'final', 'amended', 'corrected' }
  )
    union ( ["Observation": "INR"] INRLabTest
        where INRLabTest.value as Quantity > 3.0
          and INRLabTest.status in { 'final', 'amended', 'corrected' }
        return "Observation" { id: INRLabTest.id, effective: INRLabTest.issued }
    )
    union ( ( ( ["MedicationAdministration": "Unfractionated Heparin"] UnfractionatedHeparin
          where UnfractionatedHeparin.dosage.route in "Intravenous route"
      )
        union ["MedicationAdministration": "Direct Thrombin Inhibitor"]
        union ["MedicationAdministration": "Glycoprotein IIb/IIIa Inhibitors"] ) AnticoagulantMedication
        where AnticoagulantMedication.status = 'completed'
        return "Observation" { id: AnticoagulantMedication.id, effective: AnticoagulantMedication.effective }
    )

define "Encounter With Prior or Present Diagnosis of Atrial Fibrillation or VTE":
  ( "Encounter With ICU Location" QualifyingEncounterICU
      with ["Condition": "Atrial Fibrillation/Flutter"] AtrialFibrillation
        such that ( FHIRHelpers.ToConcept ( AtrialFibrillation.clinicalStatus ) ~ Global."active"
            or FHIRHelpers.ToConcept ( AtrialFibrillation.clinicalStatus ) ~ Global."recurrence"
            or FHIRHelpers.ToConcept ( AtrialFibrillation.clinicalStatus ) ~ Global."relapse"
        )
          and FHIRHelpers.ToConcept ( AtrialFibrillation.verificationStatus ) ~ Global."confirmed"
          and Global."Normalize Interval" ( AtrialFibrillation.onset ) starts on or before 
          end of QualifyingEncounterICU.period
  )
    union ( "Encounter With ICU Location" QualifyingEncounterICU
        where Global.EncounterDiagnosis ( QualifyingEncounterICU ).code in "Atrial Fibrillation/Flutter"
    )
    union ( "Encounter With ICU Location" QualifyingEncounterICU
        with ["Condition": "Venous Thromboembolism"] VTEDiagnosis
          such that ( FHIRHelpers.ToConcept ( VTEDiagnosis.clinicalStatus ) ~ Global."inactive"
              or FHIRHelpers.ToConcept ( VTEDiagnosis.clinicalStatus ) ~ Global."remission"
              or FHIRHelpers.ToConcept ( VTEDiagnosis.clinicalStatus ) ~ Global."resolved"
          )
            and VTEDiagnosis.verificationStatus ~ Global."confirmed"
            and Global."Normalize Interval" ( VTEDiagnosis.onset ) before start of QualifyingEncounterICU.period
    )

define function "GetStatusReason"(requestReason ServiceRequest ):
  Global.GetBaseExtension ( requestReason, 'request-statusReason' )

