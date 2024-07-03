﻿using System;
using Tuples;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.0.0")]
[CqlLibrary("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR", "1.3.000")]
public class IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_3_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Active_Tuberculosis_for_Urology_Care;
    internal Lazy<CqlValueSet> __BCG_Bacillus_Calmette_Guerin_for_Urology_Care;
    internal Lazy<CqlValueSet> __Bladder_Cancer_for_Urology_Care;
    internal Lazy<CqlValueSet> __Chemotherapy_Agents_for_Advanced_Cancer;
    internal Lazy<CqlValueSet> __Cystectomy_for_Urology_Care;
    internal Lazy<CqlValueSet> __HIV;
    internal Lazy<CqlValueSet> __Immunocompromised_Conditions;
    internal Lazy<CqlValueSet> __Immunosuppressive_Drugs_for_Urology_Care;
    internal Lazy<CqlValueSet> __Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care;
    internal Lazy<CqlCode> __Carcinoma_in_situ_of_bladder;
    internal Lazy<CqlCode> __Combined_radiotherapy__procedure_;
    internal Lazy<CqlCode> __T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding_;
    internal Lazy<CqlCode> __Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding_;
    internal Lazy<CqlCode> __Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding_;
    internal Lazy<CqlCode> __Tumor_staging__tumor_staging_;
    internal Lazy<CqlCode> __Dead__finding_;
    internal Lazy<CqlCode> __virtual;
    internal Lazy<CqlCode> __Stage_group_pathology_Cancer;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlCode[]> __ICD10CM;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __ActCode;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Condition>> __Bladder_Cancer_Diagnosis;
    internal Lazy<Procedure> __First_Bladder_Cancer_Staging_Procedure;
    internal Lazy<CqlDateTime> __July_1_of_Year_Prior_to_the_Measurement_Period;
    internal Lazy<CqlDateTime> __June_30_of_the_Measurement_Period;
    internal Lazy<Procedure> __First_Qualifying_Bladder_Cancer_Staging_Procedure;
    internal Lazy<Procedure> __First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period;
    internal Lazy<bool?> __Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1;
    internal Lazy<bool?> __Has_Qualifying_Encounter;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<MedicationAdministration>> __BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging;
    internal Lazy<bool?> __Denominator_Exception;
    internal Lazy<MedicationAdministration> __First_BCG_Administered;
    internal Lazy<bool?> __Numerator;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Condition>> __Acute_Tuberculosis_Diagnosis;
    internal Lazy<IEnumerable<MedicationRequest>> __Immunosuppressive_Drugs;
    internal Lazy<IEnumerable<Procedure>> __Cystectomy_Done;
    internal Lazy<bool?> __Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging;
    internal Lazy<bool?> __Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging;
    internal Lazy<bool?> __Denominator_Exclusion;

    #endregion
    public IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR_1_3_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);

        __Active_Tuberculosis_for_Urology_Care = new Lazy<CqlValueSet>(this.Active_Tuberculosis_for_Urology_Care_Value);
        __BCG_Bacillus_Calmette_Guerin_for_Urology_Care = new Lazy<CqlValueSet>(this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care_Value);
        __Bladder_Cancer_for_Urology_Care = new Lazy<CqlValueSet>(this.Bladder_Cancer_for_Urology_Care_Value);
        __Chemotherapy_Agents_for_Advanced_Cancer = new Lazy<CqlValueSet>(this.Chemotherapy_Agents_for_Advanced_Cancer_Value);
        __Cystectomy_for_Urology_Care = new Lazy<CqlValueSet>(this.Cystectomy_for_Urology_Care_Value);
        __HIV = new Lazy<CqlValueSet>(this.HIV_Value);
        __Immunocompromised_Conditions = new Lazy<CqlValueSet>(this.Immunocompromised_Conditions_Value);
        __Immunosuppressive_Drugs_for_Urology_Care = new Lazy<CqlValueSet>(this.Immunosuppressive_Drugs_for_Urology_Care_Value);
        __Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care = new Lazy<CqlValueSet>(this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care = new Lazy<CqlValueSet>(this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care_Value);
        __Carcinoma_in_situ_of_bladder = new Lazy<CqlCode>(this.Carcinoma_in_situ_of_bladder_Value);
        __Combined_radiotherapy__procedure_ = new Lazy<CqlCode>(this.Combined_radiotherapy__procedure__Value);
        __T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding_ = new Lazy<CqlCode>(this.T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding__Value);
        __Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding_ = new Lazy<CqlCode>(this.Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding__Value);
        __Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding_ = new Lazy<CqlCode>(this.Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding__Value);
        __Tumor_staging__tumor_staging_ = new Lazy<CqlCode>(this.Tumor_staging__tumor_staging__Value);
        __Dead__finding_ = new Lazy<CqlCode>(this.Dead__finding__Value);
        __virtual = new Lazy<CqlCode>(this.@virtual_Value);
        __Stage_group_pathology_Cancer = new Lazy<CqlCode>(this.Stage_group_pathology_Cancer_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __ICD10CM = new Lazy<CqlCode[]>(this.ICD10CM_Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __ActCode = new Lazy<CqlCode[]>(this.ActCode_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __Bladder_Cancer_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Bladder_Cancer_Diagnosis_Value);
        __First_Bladder_Cancer_Staging_Procedure = new Lazy<Procedure>(this.First_Bladder_Cancer_Staging_Procedure_Value);
        __July_1_of_Year_Prior_to_the_Measurement_Period = new Lazy<CqlDateTime>(this.July_1_of_Year_Prior_to_the_Measurement_Period_Value);
        __June_30_of_the_Measurement_Period = new Lazy<CqlDateTime>(this.June_30_of_the_Measurement_Period_Value);
        __First_Qualifying_Bladder_Cancer_Staging_Procedure = new Lazy<Procedure>(this.First_Qualifying_Bladder_Cancer_Staging_Procedure_Value);
        __First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period = new Lazy<Procedure>(this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period_Value);
        __Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1 = new Lazy<bool?>(this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1_Value);
        __Has_Qualifying_Encounter = new Lazy<bool?>(this.Has_Qualifying_Encounter_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging = new Lazy<IEnumerable<MedicationAdministration>>(this.BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging_Value);
        __Denominator_Exception = new Lazy<bool?>(this.Denominator_Exception_Value);
        __First_BCG_Administered = new Lazy<MedicationAdministration>(this.First_BCG_Administered_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Acute_Tuberculosis_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Acute_Tuberculosis_Diagnosis_Value);
        __Immunosuppressive_Drugs = new Lazy<IEnumerable<MedicationRequest>>(this.Immunosuppressive_Drugs_Value);
        __Cystectomy_Done = new Lazy<IEnumerable<Procedure>>(this.Cystectomy_Done_Value);
        __Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging = new Lazy<bool?>(this.Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging_Value);
        __Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging = new Lazy<bool?>(this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging_Value);
        __Denominator_Exclusion = new Lazy<bool?>(this.Denominator_Exclusion_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }

    #endregion

	private CqlValueSet Active_Tuberculosis_for_Urology_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56", null);

    [CqlDeclaration("Active Tuberculosis for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.56")]
	public CqlValueSet Active_Tuberculosis_for_Urology_Care() => 
		__Active_Tuberculosis_for_Urology_Care.Value;

	private CqlValueSet BCG_Bacillus_Calmette_Guerin_for_Urology_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52", null);

    [CqlDeclaration("BCG Bacillus Calmette Guerin for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.52")]
	public CqlValueSet BCG_Bacillus_Calmette_Guerin_for_Urology_Care() => 
		__BCG_Bacillus_Calmette_Guerin_for_Urology_Care.Value;

	private CqlValueSet Bladder_Cancer_for_Urology_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45", null);

    [CqlDeclaration("Bladder Cancer for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.45")]
	public CqlValueSet Bladder_Cancer_for_Urology_Care() => 
		__Bladder_Cancer_for_Urology_Care.Value;

	private CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60", null);

    [CqlDeclaration("Chemotherapy Agents for Advanced Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.60")]
	public CqlValueSet Chemotherapy_Agents_for_Advanced_Cancer() => 
		__Chemotherapy_Agents_for_Advanced_Cancer.Value;

	private CqlValueSet Cystectomy_for_Urology_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55", null);

    [CqlDeclaration("Cystectomy for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.55")]
	public CqlValueSet Cystectomy_for_Urology_Care() => 
		__Cystectomy_for_Urology_Care.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet Immunocompromised_Conditions_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940", null);

    [CqlDeclaration("Immunocompromised Conditions")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.666.5.1940")]
	public CqlValueSet Immunocompromised_Conditions() => 
		__Immunocompromised_Conditions.Value;

	private CqlValueSet Immunosuppressive_Drugs_for_Urology_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32", null);

    [CqlDeclaration("Immunosuppressive Drugs for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.32")]
	public CqlValueSet Immunosuppressive_Drugs_for_Urology_Care() => 
		__Immunosuppressive_Drugs_for_Urology_Care.Value;

	private CqlValueSet Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39", null);

    [CqlDeclaration("Mixed histology urothelial cell carcinoma for Urology Care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.39")]
	public CqlValueSet Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care() => 
		__Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44", null);

    [CqlDeclaration("Unavailability of Bacillus Calmette Guerin for urology care")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.44")]
	public CqlValueSet Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care() => 
		__Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care.Value;

	private CqlCode Carcinoma_in_situ_of_bladder_Value() => 
		new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", null, null);

    [CqlDeclaration("Carcinoma in situ of bladder")]
	public CqlCode Carcinoma_in_situ_of_bladder() => 
		__Carcinoma_in_situ_of_bladder.Value;

	private CqlCode Combined_radiotherapy__procedure__Value() => 
		new CqlCode("169331000", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Combined radiotherapy (procedure)")]
	public CqlCode Combined_radiotherapy__procedure_() => 
		__Combined_radiotherapy__procedure_.Value;

	private CqlCode T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding__Value() => 
		new CqlCode("369935001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("T1: Urinary tract tumor invades subepithelial connective tissue (finding)")]
	public CqlCode T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding_() => 
		__T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding_.Value;

	private CqlCode Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding__Value() => 
		new CqlCode("369949005", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Ta: Noninvasive papillary carcinoma (urinary tract) (finding)")]
	public CqlCode Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding_() => 
		__Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding_.Value;

	private CqlCode Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding__Value() => 
		new CqlCode("369934002", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Tis: Carcinoma in situ (flat tumor of urinary bladder) (finding)")]
	public CqlCode Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding_() => 
		__Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding_.Value;

	private CqlCode Tumor_staging__tumor_staging__Value() => 
		new CqlCode("254292007", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Tumor staging (tumor staging)")]
	public CqlCode Tumor_staging__tumor_staging_() => 
		__Tumor_staging__tumor_staging_.Value;

	private CqlCode Dead__finding__Value() => 
		new CqlCode("419099009", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Dead (finding)")]
	public CqlCode Dead__finding_() => 
		__Dead__finding_.Value;

	private CqlCode @virtual_Value() => 
		new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null);

    [CqlDeclaration("virtual")]
	public CqlCode @virtual() => 
		__virtual.Value;

	private CqlCode Stage_group_pathology_Cancer_Value() => 
		new CqlCode("21902-2", "http://loinc.org", null, null);

    [CqlDeclaration("Stage group.pathology Cancer")]
	public CqlCode Stage_group_pathology_Cancer() => 
		__Stage_group_pathology_Cancer.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("169331000", "http://snomed.info/sct", null, null),
			new CqlCode("369935001", "http://snomed.info/sct", null, null),
			new CqlCode("369949005", "http://snomed.info/sct", null, null),
			new CqlCode("369934002", "http://snomed.info/sct", null, null),
			new CqlCode("254292007", "http://snomed.info/sct", null, null),
			new CqlCode("419099009", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlCode[] ICD10CM_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("D09.0", "http://hl7.org/fhir/sid/icd-10-cm", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ICD10CM")]
	public CqlCode[] ICD10CM() => 
		__ICD10CM.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("21902-2", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] ActCode_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("VR", "http://terminology.hl7.org/CodeSystem/v3-ActCode", null, null),
		};

		return a_;
	}

    [CqlDeclaration("ActCode")]
	public CqlCode[] ActCode() => 
		__ActCode.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.3.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

    [CqlDeclaration("isConfirmedActiveDiagnosis")]
	public bool? isConfirmedActiveDiagnosis(Condition Condition)
	{
		var a_ = new Condition[]
		{
			Condition,
		};
		bool? b_(Condition Diagnosis)
		{
			var f_ = Diagnosis?.ClinicalStatus;
			var g_ = FHIRHelpers_4_3_000.ToConcept(f_);
			var h_ = QICoreCommon_2_0_000.active();
			var i_ = context.Operators.ConvertCodeToConcept(h_);
			var j_ = context.Operators.Equivalent(g_, i_);
			var k_ = Diagnosis?.VerificationStatus;
			var l_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var m_ = QICoreCommon_2_0_000.unconfirmed();
			var n_ = context.Operators.ConvertCodeToConcept(m_);
			var o_ = context.Operators.Equivalent(l_, n_);
			var q_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var r_ = QICoreCommon_2_0_000.refuted();
			var s_ = context.Operators.ConvertCodeToConcept(r_);
			var t_ = context.Operators.Equivalent(q_, s_);
			var u_ = context.Operators.Or(o_, t_);
			var w_ = FHIRHelpers_4_3_000.ToConcept(k_);
			var x_ = QICoreCommon_2_0_000.entered_in_error();
			var y_ = context.Operators.ConvertCodeToConcept(x_);
			var z_ = context.Operators.Equivalent(w_, y_);
			var aa_ = context.Operators.Or(u_, z_);
			var ab_ = context.Operators.Not(aa_);
			var ac_ = context.Operators.And(j_, ab_);

			return ac_;
		};
		var c_ = context.Operators.Where<Condition>((IEnumerable<Condition>)a_, b_);
		var d_ = context.Operators.SingletonFrom<Condition>(c_);
		var e_ = context.Operators.Not((bool?)(d_ is null));

		return e_;
	}

	private IEnumerable<Condition> Bladder_Cancer_Diagnosis_Value()
	{
		var a_ = this.Bladder_Cancer_for_Urology_Care();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition BladderCancer)
		{
			var e_ = QICoreCommon_2_0_000.prevalenceInterval(BladderCancer);
			var f_ = context.Operators.Start(e_);
			var g_ = this.Measurement_Period();
			var h_ = context.Operators.End(g_);
			var i_ = context.Operators.Before(f_, h_, null);
			var j_ = this.isConfirmedActiveDiagnosis(BladderCancer);
			var k_ = context.Operators.And(i_, j_);

			return k_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bladder Cancer Diagnosis")]
	public IEnumerable<Condition> Bladder_Cancer_Diagnosis() => 
		__Bladder_Cancer_Diagnosis.Value;

	private Procedure First_Bladder_Cancer_Staging_Procedure_Value()
	{
		var a_ = this.Tumor_staging__tumor_staging_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Procedure>(b_, null);
		IEnumerable<Procedure> d_(Procedure BladderCancerStaging)
		{
			var k_ = this.Bladder_Cancer_Diagnosis();
			bool? l_(Condition BladderCancer)
			{
				var p_ = BladderCancerStaging?.Performed;
				var q_ = FHIRHelpers_4_3_000.ToValue(p_);
				var r_ = QICoreCommon_2_0_000.toInterval(q_);
				var s_ = context.Operators.Start(r_);
				var t_ = QICoreCommon_2_0_000.prevalenceInterval(BladderCancer);
				var u_ = context.Operators.Start(t_);
				var v_ = context.Operators.SameOrBefore(s_, u_, "day");
				var x_ = FHIRHelpers_4_3_000.ToValue(p_);
				var y_ = QICoreCommon_2_0_000.toInterval(x_);
				var aa_ = context.Operators.Overlaps(y_, t_, "day");
				var ab_ = context.Operators.And(v_, aa_);

				return ab_;
			};
			var m_ = context.Operators.Where<Condition>(k_, l_);
			Procedure n_(Condition BladderCancer) => 
				BladderCancerStaging;
			var o_ = context.Operators.Select<Condition, Procedure>(m_, n_);

			return o_;
		};
		var e_ = context.Operators.SelectMany<Procedure, Procedure>(c_, d_);
		bool? f_(Procedure BladderCancerStaging)
		{
			var ac_ = BladderCancerStaging?.StatusElement;
			var ad_ = ac_?.Value;
			var ae_ = context.Operators.Convert<string>(ad_);
			var af_ = context.Operators.Equal(ae_, "completed");

			return af_;
		};
		var g_ = context.Operators.Where<Procedure>(e_, f_);
		object h_(Procedure @this)
		{
			var ag_ = @this?.Performed;
			var ah_ = FHIRHelpers_4_3_000.ToValue(ag_);
			var ai_ = QICoreCommon_2_0_000.toInterval(ah_);
			var aj_ = context.Operators.Start(ai_);

			return aj_;
		};
		var i_ = context.Operators.SortBy<Procedure>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
		var j_ = context.Operators.First<Procedure>(i_);

		return j_;
	}

    [CqlDeclaration("First Bladder Cancer Staging Procedure")]
	public Procedure First_Bladder_Cancer_Staging_Procedure() => 
		__First_Bladder_Cancer_Staging_Procedure.Value;

	private CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		var d_ = context.Operators.Subtract(c_, 1);
		var e_ = context.Operators.ConvertIntegerToDecimal(0);
		var f_ = context.Operators.DateTime(d_, 7, 1, 0, 0, 0, 0, e_);

		return f_;
	}

    [CqlDeclaration("July 1 of Year Prior to the Measurement Period")]
	public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period() => 
		__July_1_of_Year_Prior_to_the_Measurement_Period.Value;

	private CqlDateTime June_30_of_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.DateTimeComponentFrom(b_, "year");
		var d_ = context.Operators.ConvertIntegerToDecimal(0);
		var e_ = context.Operators.DateTime(c_, 6, 30, 23, 59, 59, 0, d_);

		return e_;
	}

    [CqlDeclaration("June 30 of the Measurement Period")]
	public CqlDateTime June_30_of_the_Measurement_Period() => 
		__June_30_of_the_Measurement_Period.Value;

	private Procedure First_Qualifying_Bladder_Cancer_Staging_Procedure_Value()
	{
		var a_ = this.First_Bladder_Cancer_Staging_Procedure();
		var b_ = new Procedure[]
		{
			a_,
		};
		bool? c_(Procedure FirstBladderCancerStaging)
		{
			var f_ = this.July_1_of_Year_Prior_to_the_Measurement_Period();
			var g_ = this.June_30_of_the_Measurement_Period();
			var h_ = context.Operators.Interval(f_, g_, true, true);
			var i_ = FirstBladderCancerStaging?.Performed;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = QICoreCommon_2_0_000.toInterval(j_);
			var l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, "day");

			return l_;
		};
		var d_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)b_, c_);
		var e_ = context.Operators.SingletonFrom<Procedure>(d_);

		return e_;
	}

    [CqlDeclaration("First Qualifying Bladder Cancer Staging Procedure")]
	public Procedure First_Qualifying_Bladder_Cancer_Staging_Procedure() => 
		__First_Qualifying_Bladder_Cancer_Staging_Procedure.Value;

	private Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period_Value()
	{
		var a_ = this.First_Bladder_Cancer_Staging_Procedure();
		var b_ = new Procedure[]
		{
			a_,
		};
		bool? c_(Procedure FirstBladderCancerStaging)
		{
			var f_ = this.July_1_of_Year_Prior_to_the_Measurement_Period();
			var g_ = this.June_30_of_the_Measurement_Period();
			var h_ = context.Operators.Interval(f_, g_, true, true);
			var i_ = FirstBladderCancerStaging?.Performed;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = QICoreCommon_2_0_000.toInterval(j_);
			var l_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, k_, "day");

			return l_;
		};
		var d_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)b_, c_);
		var e_ = context.Operators.SingletonFrom<Procedure>(d_);

		return e_;
	}

    [CqlDeclaration("First Bladder Cancer Staging Procedure during 6 Months Prior to Measurement Period through the First 6 Months of Measurement Period")]
	public Procedure First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period() => 
		__First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period.Value;

    [CqlDeclaration("getStagingProcedure")]
	public IEnumerable<Procedure> getStagingProcedure(Observation StagingObservation)
	{
		Procedure a_(ResourceReference StagingReference)
		{
			var c_ = this.First_Bladder_Cancer_Staging_Procedure_during_6_Months_Prior_to_Measurement_Period_through_the_First_6_Months_of_Measurement_Period();
			var d_ = new Procedure[]
			{
				c_,
			};
			bool? e_(Procedure FirstBladderCancerStagingMP)
			{
				var h_ = FirstBladderCancerStagingMP?.IdElement;
				var i_ = h_?.Value;
				var j_ = StagingReference?.ReferenceElement;
				var k_ = j_?.Value;
				var l_ = QICoreCommon_2_0_000.getId(k_);
				var m_ = context.Operators.Equal(i_, l_);

				return m_;
			};
			var f_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)d_, e_);
			var g_ = context.Operators.SingletonFrom<Procedure>(f_);

			return g_;
		};
		var b_ = context.Operators.Select<ResourceReference, Procedure>((IEnumerable<ResourceReference>)StagingObservation?.PartOf, a_);

		return b_;
	}

	private bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1_Value()
	{
		var a_ = this.Stage_group_pathology_Cancer();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		bool? d_(Observation StagingObservation)
		{
			var g_ = this.getStagingProcedure(StagingObservation);
			var h_ = context.Operators.Not((bool?)(g_ is null));
			var i_ = StagingObservation?.Value;
			var j_ = FHIRHelpers_4_3_000.ToValue(i_);
			var k_ = this.T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding_();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent((j_ as CqlConcept), l_);
			var o_ = FHIRHelpers_4_3_000.ToValue(i_);
			var p_ = this.Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding_();
			var q_ = context.Operators.ConvertCodeToConcept(p_);
			var r_ = context.Operators.Equivalent((o_ as CqlConcept), q_);
			var s_ = context.Operators.Or(m_, r_);
			var u_ = FHIRHelpers_4_3_000.ToValue(i_);
			var v_ = this.Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding_();
			var w_ = context.Operators.ConvertCodeToConcept(v_);
			var x_ = context.Operators.Equivalent((u_ as CqlConcept), w_);
			var y_ = context.Operators.Or(s_, x_);
			var aa_ = FHIRHelpers_4_3_000.ToValue(i_);
			var ab_ = this.Carcinoma_in_situ_of_bladder();
			var ac_ = context.Operators.ConvertCodeToConcept(ab_);
			var ad_ = context.Operators.Equivalent((aa_ as CqlConcept), ac_);
			var ae_ = context.Operators.Or(y_, ad_);
			var af_ = context.Operators.And(h_, ae_);
			var ag_ = StagingObservation?.StatusElement;
			var ah_ = ag_?.Value;
			var ai_ = context.Operators.Convert<Code<ObservationStatus>>(ah_);
			var aj_ = context.Operators.Convert<string>(ai_);
			var ak_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var al_ = context.Operators.In<string>(aj_, (ak_ as IEnumerable<string>));
			var am_ = context.Operators.And(af_, al_);

			return am_;
		};
		var e_ = context.Operators.Where<Observation>(c_, d_);
		var f_ = context.Operators.Exists<Observation>(e_);

		return f_;
	}

    [CqlDeclaration("Has Most Recent Bladder Cancer Tumor Staging is Ta HG, Tis, T1")]
	public bool? Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1() => 
		__Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1.Value;

	private bool? Has_Qualifying_Encounter_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		bool? c_(Encounter ValidEncounter)
		{
			var f_ = this.Measurement_Period();
			var g_ = ValidEncounter?.Period;
			var h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, null);
			var j_ = ValidEncounter?.Class;
			var k_ = FHIRHelpers_4_3_000.ToCode(j_);
			var l_ = this.@virtual();
			var m_ = context.Operators.Equivalent(k_, l_);
			var n_ = context.Operators.Not(m_);
			var o_ = context.Operators.And(i_, n_);
			var p_ = ValidEncounter?.StatusElement;
			var q_ = p_?.Value;
			var r_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(q_);
			var s_ = context.Operators.Equal(r_, "finished");
			var t_ = context.Operators.And(o_, s_);

			return t_;
		};
		var d_ = context.Operators.Where<Encounter>(b_, c_);
		var e_ = context.Operators.Exists<Encounter>(d_);

		return e_;
	}

    [CqlDeclaration("Has Qualifying Encounter")]
	public bool? Has_Qualifying_Encounter() => 
		__Has_Qualifying_Encounter.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.First_Qualifying_Bladder_Cancer_Staging_Procedure();
		var b_ = context.Operators.Not((bool?)(a_ is null));
		var c_ = this.Has_Most_Recent_Bladder_Cancer_Tumor_Staging_is_Ta_HG__Tis__T1();
		var d_ = context.Operators.And(b_, c_);
		var e_ = this.Has_Qualifying_Encounter();
		var f_ = context.Operators.And(d_, e_);

		return f_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging_Value()
	{
		var a_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		IEnumerable<MedicationAdministration> f_(MedicationAdministration BCGNotGiven)
		{
			var j_ = this.First_Bladder_Cancer_Staging_Procedure();
			var k_ = new Procedure[]
			{
				j_,
			};
			bool? l_(Procedure FirstBladderCancerStaging)
			{
				bool? p_(Extension @this)
				{
					var aw_ = @this?.Url;
					var ax_ = context.Operators.Convert<FhirUri>(aw_);
					var ay_ = FHIRHelpers_4_3_000.ToString(ax_);
					var az_ = context.Operators.Equal(ay_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return az_;
				};
				var q_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((BCGNotGiven is DomainResource)
						? ((BCGNotGiven as DomainResource).Extension)
						: null), p_);
				DataType r_(Extension @this)
				{
					var ba_ = @this?.Value;

					return ba_;
				};
				var s_ = context.Operators.Select<Extension, DataType>(q_, r_);
				var t_ = context.Operators.SingletonFrom<DataType>(s_);
				var u_ = context.Operators.Convert<CqlDateTime>(t_);
				var v_ = FirstBladderCancerStaging?.Performed;
				var w_ = FHIRHelpers_4_3_000.ToValue(v_);
				var x_ = QICoreCommon_2_0_000.toInterval(w_);
				var y_ = context.Operators.Start(x_);
				var aa_ = FHIRHelpers_4_3_000.ToValue(v_);
				var ab_ = QICoreCommon_2_0_000.toInterval(aa_);
				var ac_ = context.Operators.Start(ab_);
				var ad_ = context.Operators.Quantity(6m, "months");
				var ae_ = context.Operators.Add(ac_, ad_);
				var af_ = context.Operators.Interval(y_, ae_, false, true);
				var ag_ = context.Operators.In<CqlDateTime>(u_, af_, null);
				var ai_ = FHIRHelpers_4_3_000.ToValue(v_);
				var aj_ = QICoreCommon_2_0_000.toInterval(ai_);
				var ak_ = context.Operators.Start(aj_);
				var al_ = context.Operators.Not((bool?)(ak_ is null));
				var am_ = context.Operators.And(ag_, al_);
				bool? an_(Extension @this)
				{
					var bb_ = @this?.Url;
					var bc_ = context.Operators.Convert<FhirUri>(bb_);
					var bd_ = FHIRHelpers_4_3_000.ToString(bc_);
					var be_ = context.Operators.Equal(bd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return be_;
				};
				var ao_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((BCGNotGiven is DomainResource)
						? ((BCGNotGiven as DomainResource).Extension)
						: null), an_);
				DataType ap_(Extension @this)
				{
					var bf_ = @this?.Value;

					return bf_;
				};
				var aq_ = context.Operators.Select<Extension, DataType>(ao_, ap_);
				var ar_ = context.Operators.SingletonFrom<DataType>(aq_);
				var as_ = context.Operators.Convert<CqlDateTime>(ar_);
				var at_ = this.Measurement_Period();
				var au_ = context.Operators.In<CqlDateTime>(as_, at_, null);
				var av_ = context.Operators.And(am_, au_);

				return av_;
			};
			var m_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)k_, l_);
			MedicationAdministration n_(Procedure FirstBladderCancerStaging) => 
				BCGNotGiven;
			var o_ = context.Operators.Select<Procedure, MedicationAdministration>(m_, n_);

			return o_;
		};
		var g_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(e_, f_);
		bool? h_(MedicationAdministration BCGNotGiven)
		{
			var bg_ = BCGNotGiven?.StatusReason;
			CqlConcept bh_(CodeableConcept @this)
			{
				var bl_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return bl_;
			};
			var bi_ = context.Operators.Select<CodeableConcept, CqlConcept>((IEnumerable<CodeableConcept>)bg_, bh_);
			var bj_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care();
			var bk_ = context.Operators.ConceptsInValueSet(bi_, bj_);

			return bk_;
		};
		var i_ = context.Operators.Where<MedicationAdministration>(g_, h_);

		return i_;
	}

    [CqlDeclaration("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
	public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging() => 
		__BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging.Value;

	private bool? Denominator_Exception_Value()
	{
		var a_ = this.BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging();
		var b_ = context.Operators.Exists<MedicationAdministration>(a_);

		return b_;
	}

    [CqlDeclaration("Denominator Exception")]
	public bool? Denominator_Exception() => 
		__Denominator_Exception.Value;

	private MedicationAdministration First_BCG_Administered_Value()
	{
		var a_ = this.BCG_Bacillus_Calmette_Guerin_for_Urology_Care();
		var b_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationAdministration>(a_, null);
		var e_ = context.Operators.Union<MedicationAdministration>(b_, d_);
		IEnumerable<MedicationAdministration> f_(MedicationAdministration BCG)
		{
			var m_ = this.First_Bladder_Cancer_Staging_Procedure();
			var n_ = new Procedure[]
			{
				m_,
			};
			bool? o_(Procedure FirstBladderCancerStaging)
			{
				var s_ = BCG?.Effective;
				var t_ = FHIRHelpers_4_3_000.ToValue(s_);
				var u_ = QICoreCommon_2_0_000.toInterval(t_);
				var v_ = context.Operators.Start(u_);
				var w_ = FirstBladderCancerStaging?.Performed;
				var x_ = FHIRHelpers_4_3_000.ToValue(w_);
				var y_ = QICoreCommon_2_0_000.toInterval(x_);
				var z_ = context.Operators.Start(y_);
				var ab_ = FHIRHelpers_4_3_000.ToValue(w_);
				var ac_ = QICoreCommon_2_0_000.toInterval(ab_);
				var ad_ = context.Operators.Start(ac_);
				var ae_ = context.Operators.Quantity(6m, "months");
				var af_ = context.Operators.Add(ad_, ae_);
				var ag_ = context.Operators.Interval(z_, af_, false, true);
				var ah_ = context.Operators.In<CqlDateTime>(v_, ag_, null);
				var aj_ = FHIRHelpers_4_3_000.ToValue(w_);
				var ak_ = QICoreCommon_2_0_000.toInterval(aj_);
				var al_ = context.Operators.Start(ak_);
				var am_ = context.Operators.Not((bool?)(al_ is null));
				var an_ = context.Operators.And(ah_, am_);
				var ap_ = FHIRHelpers_4_3_000.ToValue(s_);
				var aq_ = QICoreCommon_2_0_000.toInterval(ap_);
				var ar_ = context.Operators.Start(aq_);
				var as_ = this.Measurement_Period();
				var at_ = context.Operators.In<CqlDateTime>(ar_, as_, null);
				var au_ = context.Operators.And(an_, at_);

				return au_;
			};
			var p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
			MedicationAdministration q_(Procedure FirstBladderCancerStaging) => 
				BCG;
			var r_ = context.Operators.Select<Procedure, MedicationAdministration>(p_, q_);

			return r_;
		};
		var g_ = context.Operators.SelectMany<MedicationAdministration, MedicationAdministration>(e_, f_);
		bool? h_(MedicationAdministration BCG)
		{
			var av_ = BCG?.StatusElement;
			var aw_ = av_?.Value;
			var ax_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(aw_);
			var ay_ = context.Operators.Convert<string>(ax_);
			var az_ = new string[]
			{
				"in-progress",
				"completed",
			};
			var ba_ = context.Operators.In<string>(ay_, (az_ as IEnumerable<string>));

			return ba_;
		};
		var i_ = context.Operators.Where<MedicationAdministration>(g_, h_);
		object j_(MedicationAdministration @this)
		{
			var bb_ = @this?.Effective;
			var bc_ = FHIRHelpers_4_3_000.ToValue(bb_);
			var bd_ = QICoreCommon_2_0_000.toInterval(bc_);
			var be_ = context.Operators.Start(bd_);

			return be_;
		};
		var k_ = context.Operators.SortBy<MedicationAdministration>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
		var l_ = context.Operators.First<MedicationAdministration>(k_);

		return l_;
	}

    [CqlDeclaration("First BCG Administered")]
	public MedicationAdministration First_BCG_Administered() => 
		__First_BCG_Administered.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.First_BCG_Administered();
		var b_ = context.Operators.Not((bool?)(a_ is null));

		return b_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Condition> Acute_Tuberculosis_Diagnosis_Value()
	{
		var a_ = this.Active_Tuberculosis_for_Urology_Care();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition ActiveTuberculosis)
		{
			var g_ = this.First_Bladder_Cancer_Staging_Procedure();
			var h_ = new Procedure[]
			{
				g_,
			};
			bool? i_(Procedure FirstBladderCancerStaging)
			{
				var m_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveTuberculosis);
				var n_ = FirstBladderCancerStaging?.Performed;
				var o_ = FHIRHelpers_4_3_000.ToValue(n_);
				var p_ = QICoreCommon_2_0_000.toInterval(o_);
				var q_ = context.Operators.OverlapsAfter(m_, p_, null);

				return q_;
			};
			var j_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)h_, i_);
			Condition k_(Procedure FirstBladderCancerStaging) => 
				ActiveTuberculosis;
			var l_ = context.Operators.Select<Procedure, Condition>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_(Condition ActiveTuberculosis)
		{
			var r_ = this.isConfirmedActiveDiagnosis(ActiveTuberculosis);

			return r_;
		};
		var f_ = context.Operators.Where<Condition>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Acute Tuberculosis Diagnosis")]
	public IEnumerable<Condition> Acute_Tuberculosis_Diagnosis() => 
		__Acute_Tuberculosis_Diagnosis.Value;

	private IEnumerable<MedicationRequest> Immunosuppressive_Drugs_Value()
	{
		var a_ = this.Immunosuppressive_Drugs_for_Urology_Care();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_(MedicationRequest ImmunosuppressiveDrugs)
		{
			var h_ = this.First_Bladder_Cancer_Staging_Procedure();
			var i_ = new Procedure[]
			{
				h_,
			};
			bool? j_(Procedure FirstBladderCancerStaging)
			{
				var n_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ImmunosuppressiveDrugs);
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.ConvertDateToDateTime(o_);
				var q_ = FirstBladderCancerStaging?.Performed;
				var r_ = FHIRHelpers_4_3_000.ToValue(q_);
				var s_ = QICoreCommon_2_0_000.toInterval(r_);
				var t_ = context.Operators.Start(s_);
				var u_ = context.Operators.SameOrBefore(p_, t_, null);

				return u_;
			};
			var k_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)i_, j_);
			MedicationRequest l_(Procedure FirstBladderCancerStaging) => 
				ImmunosuppressiveDrugs;
			var m_ = context.Operators.Select<Procedure, MedicationRequest>(k_, l_);

			return m_;
		};
		var g_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(e_, f_);

		return g_;
	}

    [CqlDeclaration("Immunosuppressive Drugs")]
	public IEnumerable<MedicationRequest> Immunosuppressive_Drugs() => 
		__Immunosuppressive_Drugs.Value;

	private IEnumerable<Procedure> Cystectomy_Done_Value()
	{
		var a_ = this.Cystectomy_for_Urology_Care();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_(Procedure Cystectomy)
		{
			var g_ = this.First_Bladder_Cancer_Staging_Procedure();
			var h_ = new Procedure[]
			{
				g_,
			};
			bool? i_(Procedure FirstBladderCancerStaging)
			{
				var m_ = Cystectomy?.Performed;
				var n_ = FHIRHelpers_4_3_000.ToValue(m_);
				var o_ = QICoreCommon_2_0_000.toInterval(n_);
				var p_ = context.Operators.End(o_);
				var q_ = FirstBladderCancerStaging?.Performed;
				var r_ = FHIRHelpers_4_3_000.ToValue(q_);
				var s_ = QICoreCommon_2_0_000.toInterval(r_);
				var t_ = context.Operators.Start(s_);
				var u_ = context.Operators.Quantity(6m, "months");
				var v_ = context.Operators.Subtract(t_, u_);
				var x_ = FHIRHelpers_4_3_000.ToValue(q_);
				var y_ = QICoreCommon_2_0_000.toInterval(x_);
				var z_ = context.Operators.Start(y_);
				var aa_ = context.Operators.Interval(v_, z_, true, false);
				var ab_ = context.Operators.In<CqlDateTime>(p_, aa_, null);
				var ad_ = FHIRHelpers_4_3_000.ToValue(q_);
				var ae_ = QICoreCommon_2_0_000.toInterval(ad_);
				var af_ = context.Operators.Start(ae_);
				var ag_ = context.Operators.Not((bool?)(af_ is null));
				var ah_ = context.Operators.And(ab_, ag_);

				return ah_;
			};
			var j_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)h_, i_);
			Procedure k_(Procedure FirstBladderCancerStaging) => 
				Cystectomy;
			var l_ = context.Operators.Select<Procedure, Procedure>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure Cystectomy)
		{
			var ai_ = Cystectomy?.StatusElement;
			var aj_ = ai_?.Value;
			var ak_ = context.Operators.Convert<string>(aj_);
			var al_ = context.Operators.Equal(ak_, "completed");

			return al_;
		};
		var f_ = context.Operators.Where<Procedure>(d_, e_);

		return f_;
	}

    [CqlDeclaration("Cystectomy Done")]
	public IEnumerable<Procedure> Cystectomy_Done() => 
		__Cystectomy_Done.Value;

	private bool? Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging_Value()
	{
		var a_ = this.HIV();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		var c_ = this.Immunocompromised_Conditions();
		var d_ = context.Operators.RetrieveByValueSet<Condition>(c_, null);
		var e_ = context.Operators.Union<Condition>(b_, d_);
		var f_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care();
		var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		var h_ = context.Operators.Union<Condition>(e_, g_);
		IEnumerable<Condition> i_(Condition ExclusionDiagnosis)
		{
			var n_ = this.First_Bladder_Cancer_Staging_Procedure();
			var o_ = new Procedure[]
			{
				n_,
			};
			bool? p_(Procedure FirstBladderCancerStaging)
			{
				var t_ = QICoreCommon_2_0_000.prevalenceInterval(ExclusionDiagnosis);
				var u_ = context.Operators.Start(t_);
				var v_ = FirstBladderCancerStaging?.Performed;
				var w_ = FHIRHelpers_4_3_000.ToValue(v_);
				var x_ = QICoreCommon_2_0_000.toInterval(w_);
				var y_ = context.Operators.Start(x_);
				var z_ = context.Operators.SameOrBefore(u_, y_, null);

				return z_;
			};
			var q_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)o_, p_);
			Condition r_(Procedure FirstBladderCancerStaging) => 
				ExclusionDiagnosis;
			var s_ = context.Operators.Select<Procedure, Condition>(q_, r_);

			return s_;
		};
		var j_ = context.Operators.SelectMany<Condition, Condition>(h_, i_);
		bool? k_(Condition ExclusionDiagnosis)
		{
			var aa_ = this.isConfirmedActiveDiagnosis(ExclusionDiagnosis);

			return aa_;
		};
		var l_ = context.Operators.Where<Condition>(j_, k_);
		var m_ = context.Operators.Exists<Condition>(l_);

		return m_;
	}

    [CqlDeclaration("Has Excluding  HIV, Immunocompromised Conditions or Mixed Histology Before Staging")]
	public bool? Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging() => 
		__Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging.Value;

	private bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging_Value()
	{
		var a_ = this.Chemotherapy_Agents_for_Advanced_Cancer();
		var b_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var d_ = context.Operators.RetrieveByValueSet<MedicationRequest>(a_, null);
		var e_ = context.Operators.Union<MedicationRequest>(b_, d_);
		IEnumerable<MedicationRequest> f_(MedicationRequest ExclusionMed)
		{
			var s_ = this.First_Bladder_Cancer_Staging_Procedure();
			var t_ = new Procedure[]
			{
				s_,
			};
			bool? u_(Procedure FirstBladderCancerStaging)
			{
				var y_ = CumulativeMedicationDuration_4_0_000.MedicationRequestPeriod(ExclusionMed);
				var z_ = context.Operators.Start(y_);
				var aa_ = context.Operators.ConvertDateToDateTime(z_);
				var ab_ = FirstBladderCancerStaging?.Performed;
				var ac_ = FHIRHelpers_4_3_000.ToValue(ab_);
				var ad_ = QICoreCommon_2_0_000.toInterval(ac_);
				var ae_ = context.Operators.Start(ad_);
				var af_ = context.Operators.Quantity(6m, "months");
				var ag_ = context.Operators.Subtract(ae_, af_);
				var ai_ = FHIRHelpers_4_3_000.ToValue(ab_);
				var aj_ = QICoreCommon_2_0_000.toInterval(ai_);
				var ak_ = context.Operators.Start(aj_);
				var al_ = context.Operators.Interval(ag_, ak_, true, false);
				var am_ = context.Operators.In<CqlDateTime>(aa_, al_, null);
				var ao_ = FHIRHelpers_4_3_000.ToValue(ab_);
				var ap_ = QICoreCommon_2_0_000.toInterval(ao_);
				var aq_ = context.Operators.Start(ap_);
				var ar_ = context.Operators.Not((bool?)(aq_ is null));
				var as_ = context.Operators.And(am_, ar_);

				return as_;
			};
			var v_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)t_, u_);
			MedicationRequest w_(Procedure FirstBladderCancerStaging) => 
				ExclusionMed;
			var x_ = context.Operators.Select<Procedure, MedicationRequest>(v_, w_);

			return x_;
		};
		var g_ = context.Operators.SelectMany<MedicationRequest, MedicationRequest>(e_, f_);
		bool? h_(MedicationRequest ExclusionMed)
		{
			var at_ = ExclusionMed?.StatusElement;
			var au_ = at_?.Value;
			var av_ = context.Operators.Convert<string>(au_);
			var aw_ = new string[]
			{
				"active",
				"completed",
			};
			var ax_ = context.Operators.In<string>(av_, (aw_ as IEnumerable<string>));
			var ay_ = ExclusionMed?.IntentElement;
			var az_ = ay_?.Value;
			var ba_ = context.Operators.Convert<string>(az_);
			var bb_ = context.Operators.Equal(ba_, "order");
			var bc_ = context.Operators.And(ax_, bb_);
			var bd_ = ExclusionMed?.DoNotPerformElement;
			var be_ = bd_?.Value;
			var bf_ = context.Operators.IsTrue(be_);
			var bg_ = context.Operators.Not(bf_);
			var bh_ = context.Operators.And(bc_, bg_);

			return bh_;
		};
		var i_ = context.Operators.Where<MedicationRequest>(g_, h_);
		var j_ = this.Combined_radiotherapy__procedure_();
		var k_ = context.Operators.ToList<CqlCode>(j_);
		var l_ = context.Operators.RetrieveByCodes<Procedure>(k_, null);
		IEnumerable<Procedure> m_(Procedure ExclusionProcedure)
		{
			var bi_ = this.First_Bladder_Cancer_Staging_Procedure();
			var bj_ = new Procedure[]
			{
				bi_,
			};
			bool? bk_(Procedure FirstBladderCancerStaging)
			{
				var bo_ = ExclusionProcedure?.Performed;
				var bp_ = FHIRHelpers_4_3_000.ToValue(bo_);
				var bq_ = QICoreCommon_2_0_000.toInterval(bp_);
				var br_ = context.Operators.Start(bq_);
				var bs_ = FirstBladderCancerStaging?.Performed;
				var bt_ = FHIRHelpers_4_3_000.ToValue(bs_);
				var bu_ = QICoreCommon_2_0_000.toInterval(bt_);
				var bv_ = context.Operators.Start(bu_);
				var bw_ = context.Operators.Quantity(6m, "months");
				var bx_ = context.Operators.Subtract(bv_, bw_);
				var bz_ = FHIRHelpers_4_3_000.ToValue(bs_);
				var ca_ = QICoreCommon_2_0_000.toInterval(bz_);
				var cb_ = context.Operators.Start(ca_);
				var cc_ = context.Operators.Interval(bx_, cb_, true, false);
				var cd_ = context.Operators.In<CqlDateTime>(br_, cc_, null);
				var cf_ = FHIRHelpers_4_3_000.ToValue(bs_);
				var cg_ = QICoreCommon_2_0_000.toInterval(cf_);
				var ch_ = context.Operators.Start(cg_);
				var ci_ = context.Operators.Not((bool?)(ch_ is null));
				var cj_ = context.Operators.And(cd_, ci_);

				return cj_;
			};
			var bl_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)bj_, bk_);
			Procedure bm_(Procedure FirstBladderCancerStaging) => 
				ExclusionProcedure;
			var bn_ = context.Operators.Select<Procedure, Procedure>(bl_, bm_);

			return bn_;
		};
		var n_ = context.Operators.SelectMany<Procedure, Procedure>(l_, m_);
		bool? o_(Procedure ExclusionProcedure)
		{
			var ck_ = ExclusionProcedure?.StatusElement;
			var cl_ = ck_?.Value;
			var cm_ = context.Operators.Convert<string>(cl_);
			var cn_ = context.Operators.Equal(cm_, "completed");

			return cn_;
		};
		var p_ = context.Operators.Where<Procedure>(n_, o_);
		var q_ = context.Operators.Union<object>((i_ as IEnumerable<object>), (p_ as IEnumerable<object>));
		var r_ = context.Operators.Exists<object>(q_);

		return r_;
	}

    [CqlDeclaration("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
	public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging() => 
		__Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging.Value;

	private bool? Denominator_Exclusion_Value()
	{
		var a_ = this.Acute_Tuberculosis_Diagnosis();
		var b_ = context.Operators.Exists<Condition>(a_);
		var c_ = this.Immunosuppressive_Drugs();
		var d_ = context.Operators.Exists<MedicationRequest>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Cystectomy_Done();
		var g_ = context.Operators.Exists<Procedure>(f_);
		var h_ = context.Operators.Or(e_, g_);
		var i_ = this.Has_Excluding__HIV__Immunocompromised_Conditions_or_Mixed_Histology_Before_Staging();
		var j_ = context.Operators.Or(h_, i_);
		var k_ = this.Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging();
		var l_ = context.Operators.Or(j_, k_);

		return l_;
	}

    [CqlDeclaration("Denominator Exclusion")]
	public bool? Denominator_Exclusion() => 
		__Denominator_Exclusion.Value;

    [CqlDeclaration("NormalizePeriod")]
	public CqlInterval<CqlDateTime> NormalizePeriod(CqlDateTime pointInTime, CqlInterval<CqlDateTime> dateTimeInterval)
	{
		CqlInterval<CqlDateTime> a_()
		{
			if ((context.Operators.Not((bool?)(pointInTime is null)) ?? false))
			{
				var b_ = context.Operators.Interval(pointInTime, pointInTime, true, true);

				return b_;
			}
			else if ((context.Operators.Not((bool?)(dateTimeInterval is null)) ?? false))
			{
				return dateTimeInterval;
			}
			else
			{
				return null;
			}
		};

		return a_();
	}

}