using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
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
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("IntravesicalBacillusCalmetteGuerinForBladderCancerFHIR-1.3.000", "Measurement Period", e_);

		return (CqlInterval<CqlDateTime>)f_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingleOrNull<Patient>(a_);

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
			var f_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.ClinicalStatus);
			var g_ = QICoreCommon_2_0_000.active();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent(f_, h_);
			var j_ = FHIRHelpers_4_3_000.ToConcept(Diagnosis?.VerificationStatus);
			var k_ = QICoreCommon_2_0_000.unconfirmed();
			var l_ = context.Operators.ConvertCodeToConcept(k_);
			var m_ = context.Operators.Equivalent(j_, l_);
			var o_ = QICoreCommon_2_0_000.refuted();
			var p_ = context.Operators.ConvertCodeToConcept(o_);
			var q_ = context.Operators.Equivalent(j_, p_);
			var r_ = context.Operators.Or(m_, q_);
			var t_ = QICoreCommon_2_0_000.entered_in_error();
			var u_ = context.Operators.ConvertCodeToConcept(t_);
			var v_ = context.Operators.Equivalent(j_, u_);
			var w_ = context.Operators.Or(r_, v_);
			var x_ = context.Operators.Not(w_);
			var y_ = context.Operators.And(i_, x_);

			return y_;
		};
		var c_ = context.Operators.WhereOrNull<Condition>(a_, b_);
		var d_ = context.Operators.SingleOrNull<Condition>(c_);
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
		var d_ = context.Operators.WhereOrNull<Condition>(b_, c_);

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
				var p_ = FHIRHelpers_4_3_000.ToValue(BladderCancerStaging?.Performed);
				var q_ = QICoreCommon_2_0_000.toInterval(p_);
				var r_ = context.Operators.Start(q_);
				var s_ = QICoreCommon_2_0_000.prevalenceInterval(BladderCancer);
				var t_ = context.Operators.Start(s_);
				var u_ = context.Operators.SameOrBefore(r_, t_, "day");
				var w_ = QICoreCommon_2_0_000.toInterval(p_);
				var y_ = context.Operators.Overlaps(w_, s_, "day");
				var z_ = context.Operators.And(u_, y_);

				return z_;
			};
			var m_ = context.Operators.WhereOrNull<Condition>(k_, l_);
			Procedure n_(Condition BladderCancer) => 
				BladderCancerStaging;
			var o_ = context.Operators.SelectOrNull<Condition, Procedure>(m_, n_);

			return o_;
		};
		var e_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(c_, d_);
		bool? f_(Procedure BladderCancerStaging)
		{
			var aa_ = context.Operators.EnumEqualsString(BladderCancerStaging?.StatusElement?.Value, "completed");

			return aa_;
		};
		var g_ = context.Operators.WhereOrNull<Procedure>(e_, f_);
		object h_(Procedure @this)
		{
			var ab_ = FHIRHelpers_4_3_000.ToValue(@this?.Performed);
			var ac_ = QICoreCommon_2_0_000.toInterval(ab_);
			var ad_ = context.Operators.Start(ac_);

			return ad_;
		};
		var i_ = context.Operators.ListSortBy<Procedure>(g_, h_, System.ComponentModel.ListSortDirection.Ascending);
		var j_ = context.Operators.FirstOfList<Procedure>(i_);

		return j_;
	}

    [CqlDeclaration("First Bladder Cancer Staging Procedure")]
	public Procedure First_Bladder_Cancer_Staging_Procedure() => 
		__First_Bladder_Cancer_Staging_Procedure.Value;

	private CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.ComponentFrom(b_, "year");
		var d_ = context.Operators.Subtract(c_, (int?)1);
		var e_ = context.Operators.ConvertIntegerToDecimal((int?)0);
		var f_ = context.Operators.DateTime(d_, (int?)7, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, e_);

		return f_;
	}

    [CqlDeclaration("July 1 of Year Prior to the Measurement Period")]
	public CqlDateTime July_1_of_Year_Prior_to_the_Measurement_Period() => 
		__July_1_of_Year_Prior_to_the_Measurement_Period.Value;

	private CqlDateTime June_30_of_the_Measurement_Period_Value()
	{
		var a_ = this.Measurement_Period();
		var b_ = context.Operators.Start(a_);
		var c_ = context.Operators.ComponentFrom(b_, "year");
		var d_ = context.Operators.ConvertIntegerToDecimal((int?)0);
		var e_ = context.Operators.DateTime(c_, (int?)6, (int?)30, (int?)23, (int?)59, (int?)59, (int?)0, d_);

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
			var i_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
			var j_ = QICoreCommon_2_0_000.toInterval(i_);
			var k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, "day");

			return k_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Procedure>(d_);

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
			var i_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
			var j_ = QICoreCommon_2_0_000.toInterval(i_);
			var k_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(h_, j_, "day");

			return k_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);
		var e_ = context.Operators.SingleOrNull<Procedure>(d_);

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
				var h_ = QICoreCommon_2_0_000.getId(StagingReference?.ReferenceElement?.Value);
				var i_ = context.Operators.Equal(FirstBladderCancerStagingMP?.IdElement?.Value, h_);

				return i_;
			};
			var f_ = context.Operators.WhereOrNull<Procedure>(d_, e_);
			var g_ = context.Operators.SingleOrNull<Procedure>(f_);

			return g_;
		};
		var b_ = context.Operators.SelectOrNull<ResourceReference, Procedure>((StagingObservation?.PartOf as IEnumerable<ResourceReference>), a_);

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
			var i_ = FHIRHelpers_4_3_000.ToValue(StagingObservation?.Value);
			var j_ = this.T1__Urinary_tract_tumor_invades_subepithelial_connective_tissue__finding_();
			var k_ = context.Operators.ConvertCodeToConcept(j_);
			var l_ = context.Operators.Equivalent((i_ as CqlConcept), k_);
			var n_ = this.Ta__Noninvasive_papillary_carcinoma__urinary_tract___finding_();
			var o_ = context.Operators.ConvertCodeToConcept(n_);
			var p_ = context.Operators.Equivalent((i_ as CqlConcept), o_);
			var q_ = context.Operators.Or(l_, p_);
			var s_ = this.Tis__Carcinoma_in_situ__flat_tumor_of_urinary_bladder___finding_();
			var t_ = context.Operators.ConvertCodeToConcept(s_);
			var u_ = context.Operators.Equivalent((i_ as CqlConcept), t_);
			var v_ = context.Operators.Or(q_, u_);
			var x_ = this.Carcinoma_in_situ_of_bladder();
			var y_ = context.Operators.ConvertCodeToConcept(x_);
			var z_ = context.Operators.Equivalent((i_ as CqlConcept), y_);
			var aa_ = context.Operators.Or(v_, z_);
			var ab_ = context.Operators.And(h_, aa_);
			var ac_ = context.Operators.Convert<Code<ObservationStatus>>(StagingObservation?.StatusElement?.Value);
			var ad_ = context.Operators.Convert<string>(ac_);
			var ae_ = new string[]
			{
				"final",
				"amended",
				"corrected",
			};
			var af_ = context.Operators.InList<string>(ad_, (ae_ as IEnumerable<string>));
			var ag_ = context.Operators.And(ab_, af_);

			return ag_;
		};
		var e_ = context.Operators.WhereOrNull<Observation>(c_, d_);
		var f_ = context.Operators.ExistsInList<Observation>(e_);

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
			var g_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
			var h_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, g_, null);
			var i_ = FHIRHelpers_4_3_000.ToCode(ValidEncounter?.Class);
			var j_ = this.@virtual();
			var k_ = context.Operators.Equivalent(i_, j_);
			var l_ = context.Operators.Not(k_);
			var m_ = context.Operators.And(h_, l_);
			var n_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(ValidEncounter?.StatusElement?.Value);
			var o_ = context.Operators.Equal(n_, "finished");
			var p_ = context.Operators.And(m_, o_);

			return p_;
		};
		var d_ = context.Operators.WhereOrNull<Encounter>(b_, c_);
		var e_ = context.Operators.ExistsInList<Encounter>(d_);

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
		var e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
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
					var at_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return at_;
				};
				var q_ = context.Operators.WhereOrNull<Extension>(((BCGNotGiven is DomainResource)
						? ((BCGNotGiven as DomainResource).Extension)
						: null), p_);
				DataType r_(Extension @this) => 
					@this?.Value;
				var s_ = context.Operators.SelectOrNull<Extension, DataType>(q_, r_);
				var t_ = context.Operators.SingleOrNull<DataType>(s_);
				var u_ = context.Operators.Convert<CqlDateTime>(t_);
				var v_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
				var w_ = QICoreCommon_2_0_000.toInterval(v_);
				var x_ = context.Operators.Start(w_);
				var z_ = QICoreCommon_2_0_000.toInterval(v_);
				var aa_ = context.Operators.Start(z_);
				var ab_ = context.Operators.Quantity(6m, "months");
				var ac_ = context.Operators.Add(aa_, ab_);
				var ad_ = context.Operators.Interval(x_, ac_, false, true);
				var ae_ = context.Operators.ElementInInterval<CqlDateTime>(u_, ad_, null);
				var ag_ = QICoreCommon_2_0_000.toInterval(v_);
				var ah_ = context.Operators.Start(ag_);
				var ai_ = context.Operators.Not((bool?)(ah_ is null));
				var aj_ = context.Operators.And(ae_, ai_);
				bool? ak_(Extension @this)
				{
					var au_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-recorded");

					return au_;
				};
				var al_ = context.Operators.WhereOrNull<Extension>(((BCGNotGiven is DomainResource)
						? ((BCGNotGiven as DomainResource).Extension)
						: null), ak_);
				var an_ = context.Operators.SelectOrNull<Extension, DataType>(al_, r_);
				var ao_ = context.Operators.SingleOrNull<DataType>(an_);
				var ap_ = context.Operators.Convert<CqlDateTime>(ao_);
				var aq_ = this.Measurement_Period();
				var ar_ = context.Operators.ElementInInterval<CqlDateTime>(ap_, aq_, null);
				var as_ = context.Operators.And(aj_, ar_);

				return as_;
			};
			var m_ = context.Operators.WhereOrNull<Procedure>(k_, l_);
			MedicationAdministration n_(Procedure FirstBladderCancerStaging) => 
				BCGNotGiven;
			var o_ = context.Operators.SelectOrNull<Procedure, MedicationAdministration>(m_, n_);

			return o_;
		};
		var g_ = context.Operators.SelectManyOrNull<MedicationAdministration, MedicationAdministration>(e_, f_);
		bool? h_(MedicationAdministration BCGNotGiven)
		{
			CqlConcept av_(CodeableConcept @this)
			{
				var az_ = FHIRHelpers_4_3_000.ToConcept(@this);

				return az_;
			};
			var aw_ = context.Operators.SelectOrNull<CodeableConcept, CqlConcept>(BCGNotGiven?.StatusReason, av_);
			var ax_ = this.Unavailability_of_Bacillus_Calmette_Guerin_for_urology_care();
			var ay_ = context.Operators.ConceptsInValueSet(aw_, ax_);

			return ay_;
		};
		var i_ = context.Operators.WhereOrNull<MedicationAdministration>(g_, h_);

		return i_;
	}

    [CqlDeclaration("BCG Not Available Within 6 Months After Bladder Cancer Staging")]
	public IEnumerable<MedicationAdministration> BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging() => 
		__BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging.Value;

	private bool? Denominator_Exception_Value()
	{
		var a_ = this.BCG_Not_Available_Within_6_Months_After_Bladder_Cancer_Staging();
		var b_ = context.Operators.ExistsInList<MedicationAdministration>(a_);

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
		var e_ = context.Operators.ListUnion<MedicationAdministration>(b_, d_);
		IEnumerable<MedicationAdministration> f_(MedicationAdministration BCG)
		{
			var m_ = this.First_Bladder_Cancer_Staging_Procedure();
			var n_ = new Procedure[]
			{
				m_,
			};
			bool? o_(Procedure FirstBladderCancerStaging)
			{
				var s_ = FHIRHelpers_4_3_000.ToValue(BCG?.Effective);
				var t_ = QICoreCommon_2_0_000.toInterval(s_);
				var u_ = context.Operators.Start(t_);
				var v_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
				var w_ = QICoreCommon_2_0_000.toInterval(v_);
				var x_ = context.Operators.Start(w_);
				var z_ = QICoreCommon_2_0_000.toInterval(v_);
				var aa_ = context.Operators.Start(z_);
				var ab_ = context.Operators.Quantity(6m, "months");
				var ac_ = context.Operators.Add(aa_, ab_);
				var ad_ = context.Operators.Interval(x_, ac_, false, true);
				var ae_ = context.Operators.ElementInInterval<CqlDateTime>(u_, ad_, null);
				var ag_ = QICoreCommon_2_0_000.toInterval(v_);
				var ah_ = context.Operators.Start(ag_);
				var ai_ = context.Operators.Not((bool?)(ah_ is null));
				var aj_ = context.Operators.And(ae_, ai_);
				var al_ = QICoreCommon_2_0_000.toInterval(s_);
				var am_ = context.Operators.Start(al_);
				var an_ = this.Measurement_Period();
				var ao_ = context.Operators.ElementInInterval<CqlDateTime>(am_, an_, null);
				var ap_ = context.Operators.And(aj_, ao_);

				return ap_;
			};
			var p_ = context.Operators.WhereOrNull<Procedure>(n_, o_);
			MedicationAdministration q_(Procedure FirstBladderCancerStaging) => 
				BCG;
			var r_ = context.Operators.SelectOrNull<Procedure, MedicationAdministration>(p_, q_);

			return r_;
		};
		var g_ = context.Operators.SelectManyOrNull<MedicationAdministration, MedicationAdministration>(e_, f_);
		bool? h_(MedicationAdministration BCG)
		{
			var aq_ = context.Operators.Convert<Code<MedicationAdministration.MedicationAdministrationStatusCodes>>(BCG?.StatusElement?.Value);
			var ar_ = context.Operators.Convert<string>(aq_);
			var as_ = new string[]
			{
				"in-progress",
				"completed",
			};
			var at_ = context.Operators.InList<string>(ar_, (as_ as IEnumerable<string>));

			return at_;
		};
		var i_ = context.Operators.WhereOrNull<MedicationAdministration>(g_, h_);
		object j_(MedicationAdministration @this)
		{
			var au_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var av_ = QICoreCommon_2_0_000.toInterval(au_);
			var aw_ = context.Operators.Start(av_);

			return aw_;
		};
		var k_ = context.Operators.ListSortBy<MedicationAdministration>(i_, j_, System.ComponentModel.ListSortDirection.Ascending);
		var l_ = context.Operators.FirstOfList<MedicationAdministration>(k_);

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

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
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
				var n_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
				var o_ = QICoreCommon_2_0_000.toInterval(n_);
				var p_ = context.Operators.OverlapsAfter(m_, o_, null);

				return p_;
			};
			var j_ = context.Operators.WhereOrNull<Procedure>(h_, i_);
			Condition k_(Procedure FirstBladderCancerStaging) => 
				ActiveTuberculosis;
			var l_ = context.Operators.SelectOrNull<Procedure, Condition>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectManyOrNull<Condition, Condition>(b_, c_);
		bool? e_(Condition ActiveTuberculosis)
		{
			var q_ = this.isConfirmedActiveDiagnosis(ActiveTuberculosis);

			return q_;
		};
		var f_ = context.Operators.WhereOrNull<Condition>(d_, e_);

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
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
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
				var q_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
				var r_ = QICoreCommon_2_0_000.toInterval(q_);
				var s_ = context.Operators.Start(r_);
				var t_ = context.Operators.SameOrBefore(p_, s_, null);

				return t_;
			};
			var k_ = context.Operators.WhereOrNull<Procedure>(i_, j_);
			MedicationRequest l_(Procedure FirstBladderCancerStaging) => 
				ImmunosuppressiveDrugs;
			var m_ = context.Operators.SelectOrNull<Procedure, MedicationRequest>(k_, l_);

			return m_;
		};
		var g_ = context.Operators.SelectManyOrNull<MedicationRequest, MedicationRequest>(e_, f_);

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
				var m_ = FHIRHelpers_4_3_000.ToValue(Cystectomy?.Performed);
				var n_ = QICoreCommon_2_0_000.toInterval(m_);
				var o_ = context.Operators.End(n_);
				var p_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
				var q_ = QICoreCommon_2_0_000.toInterval(p_);
				var r_ = context.Operators.Start(q_);
				var s_ = context.Operators.Quantity(6m, "months");
				var t_ = context.Operators.Subtract(r_, s_);
				var v_ = QICoreCommon_2_0_000.toInterval(p_);
				var w_ = context.Operators.Start(v_);
				var x_ = context.Operators.Interval(t_, w_, true, false);
				var y_ = context.Operators.ElementInInterval<CqlDateTime>(o_, x_, null);
				var aa_ = QICoreCommon_2_0_000.toInterval(p_);
				var ab_ = context.Operators.Start(aa_);
				var ac_ = context.Operators.Not((bool?)(ab_ is null));
				var ad_ = context.Operators.And(y_, ac_);

				return ad_;
			};
			var j_ = context.Operators.WhereOrNull<Procedure>(h_, i_);
			Procedure k_(Procedure FirstBladderCancerStaging) => 
				Cystectomy;
			var l_ = context.Operators.SelectOrNull<Procedure, Procedure>(j_, k_);

			return l_;
		};
		var d_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(b_, c_);
		bool? e_(Procedure Cystectomy)
		{
			var ae_ = context.Operators.EnumEqualsString(Cystectomy?.StatusElement?.Value, "completed");

			return ae_;
		};
		var f_ = context.Operators.WhereOrNull<Procedure>(d_, e_);

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
		var e_ = context.Operators.ListUnion<Condition>(b_, d_);
		var f_ = this.Mixed_histology_urothelial_cell_carcinoma_for_Urology_Care();
		var g_ = context.Operators.RetrieveByValueSet<Condition>(f_, null);
		var h_ = context.Operators.ListUnion<Condition>(e_, g_);
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
				var v_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
				var w_ = QICoreCommon_2_0_000.toInterval(v_);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.SameOrBefore(u_, x_, null);

				return y_;
			};
			var q_ = context.Operators.WhereOrNull<Procedure>(o_, p_);
			Condition r_(Procedure FirstBladderCancerStaging) => 
				ExclusionDiagnosis;
			var s_ = context.Operators.SelectOrNull<Procedure, Condition>(q_, r_);

			return s_;
		};
		var j_ = context.Operators.SelectManyOrNull<Condition, Condition>(h_, i_);
		bool? k_(Condition ExclusionDiagnosis)
		{
			var z_ = this.isConfirmedActiveDiagnosis(ExclusionDiagnosis);

			return z_;
		};
		var l_ = context.Operators.WhereOrNull<Condition>(j_, k_);
		var m_ = context.Operators.ExistsInList<Condition>(l_);

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
		var e_ = context.Operators.ListUnion<MedicationRequest>(b_, d_);
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
				var ab_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
				var ac_ = QICoreCommon_2_0_000.toInterval(ab_);
				var ad_ = context.Operators.Start(ac_);
				var ae_ = context.Operators.Quantity(6m, "months");
				var af_ = context.Operators.Subtract(ad_, ae_);
				var ah_ = QICoreCommon_2_0_000.toInterval(ab_);
				var ai_ = context.Operators.Start(ah_);
				var aj_ = context.Operators.Interval(af_, ai_, true, false);
				var ak_ = context.Operators.ElementInInterval<CqlDateTime>(aa_, aj_, null);
				var am_ = QICoreCommon_2_0_000.toInterval(ab_);
				var an_ = context.Operators.Start(am_);
				var ao_ = context.Operators.Not((bool?)(an_ is null));
				var ap_ = context.Operators.And(ak_, ao_);

				return ap_;
			};
			var v_ = context.Operators.WhereOrNull<Procedure>(t_, u_);
			MedicationRequest w_(Procedure FirstBladderCancerStaging) => 
				ExclusionMed;
			var x_ = context.Operators.SelectOrNull<Procedure, MedicationRequest>(v_, w_);

			return x_;
		};
		var g_ = context.Operators.SelectManyOrNull<MedicationRequest, MedicationRequest>(e_, f_);
		bool? h_(MedicationRequest ExclusionMed)
		{
			var aq_ = context.Operators.Convert<string>(ExclusionMed?.StatusElement?.Value);
			var ar_ = new string[]
			{
				"active",
				"completed",
			};
			var as_ = context.Operators.InList<string>(aq_, (ar_ as IEnumerable<string>));
			var at_ = context.Operators.EnumEqualsString(ExclusionMed?.IntentElement?.Value, "order");
			var au_ = context.Operators.And(as_, at_);
			var av_ = context.Operators.IsTrue(ExclusionMed?.DoNotPerformElement?.Value);
			var aw_ = context.Operators.Not(av_);
			var ax_ = context.Operators.And(au_, aw_);

			return ax_;
		};
		var i_ = context.Operators.WhereOrNull<MedicationRequest>(g_, h_);
		var j_ = this.Combined_radiotherapy__procedure_();
		var k_ = context.Operators.ToList<CqlCode>(j_);
		var l_ = context.Operators.RetrieveByCodes<Procedure>(k_, null);
		IEnumerable<Procedure> m_(Procedure ExclusionProcedure)
		{
			var ay_ = this.First_Bladder_Cancer_Staging_Procedure();
			var az_ = new Procedure[]
			{
				ay_,
			};
			bool? ba_(Procedure FirstBladderCancerStaging)
			{
				var be_ = FHIRHelpers_4_3_000.ToValue(ExclusionProcedure?.Performed);
				var bf_ = QICoreCommon_2_0_000.toInterval(be_);
				var bg_ = context.Operators.Start(bf_);
				var bh_ = FHIRHelpers_4_3_000.ToValue(FirstBladderCancerStaging?.Performed);
				var bi_ = QICoreCommon_2_0_000.toInterval(bh_);
				var bj_ = context.Operators.Start(bi_);
				var bk_ = context.Operators.Quantity(6m, "months");
				var bl_ = context.Operators.Subtract(bj_, bk_);
				var bn_ = QICoreCommon_2_0_000.toInterval(bh_);
				var bo_ = context.Operators.Start(bn_);
				var bp_ = context.Operators.Interval(bl_, bo_, true, false);
				var bq_ = context.Operators.ElementInInterval<CqlDateTime>(bg_, bp_, null);
				var bs_ = QICoreCommon_2_0_000.toInterval(bh_);
				var bt_ = context.Operators.Start(bs_);
				var bu_ = context.Operators.Not((bool?)(bt_ is null));
				var bv_ = context.Operators.And(bq_, bu_);

				return bv_;
			};
			var bb_ = context.Operators.WhereOrNull<Procedure>(az_, ba_);
			Procedure bc_(Procedure FirstBladderCancerStaging) => 
				ExclusionProcedure;
			var bd_ = context.Operators.SelectOrNull<Procedure, Procedure>(bb_, bc_);

			return bd_;
		};
		var n_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(l_, m_);
		bool? o_(Procedure ExclusionProcedure)
		{
			var bw_ = context.Operators.EnumEqualsString(ExclusionProcedure?.StatusElement?.Value, "completed");

			return bw_;
		};
		var p_ = context.Operators.WhereOrNull<Procedure>(n_, o_);
		var q_ = context.Operators.ListUnion<object>((i_ as IEnumerable<object>), (p_ as IEnumerable<object>));
		var r_ = context.Operators.ExistsInList<object>(q_);

		return r_;
	}

    [CqlDeclaration("Has Excluding Chemotherapy or Radiotherapy Procedure Before Staging")]
	public bool? Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging() => 
		__Has_Excluding_Chemotherapy_or_Radiotherapy_Procedure_Before_Staging.Value;

	private bool? Denominator_Exclusion_Value()
	{
		var a_ = this.Acute_Tuberculosis_Diagnosis();
		var b_ = context.Operators.ExistsInList<Condition>(a_);
		var c_ = this.Immunosuppressive_Drugs();
		var d_ = context.Operators.ExistsInList<MedicationRequest>(c_);
		var e_ = context.Operators.Or(b_, d_);
		var f_ = this.Cystectomy_Done();
		var g_ = context.Operators.ExistsInList<Procedure>(f_);
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
				CqlInterval<CqlDateTime> c_ = null;

				return (c_ as CqlInterval<CqlDateTime>);
			};
		};

		return a_();
	}

}
