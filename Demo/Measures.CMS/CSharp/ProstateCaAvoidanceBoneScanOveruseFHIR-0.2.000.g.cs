using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql.Abstractions;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using System.Reflection;
using Hl7.Cql.Operators;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.4.0")]
[CqlLibrary("ProstateCaAvoidanceBoneScanOveruseFHIR", "0.2.000")]
public class ProstateCaAvoidanceBoneScanOveruseFHIR_0_2_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Bone_Scan;
    internal Lazy<CqlValueSet> __Pain_Warranting_Further_Investigation_for_Prostate_Cancer;
    internal Lazy<CqlValueSet> __Prostate_Cancer;
    internal Lazy<CqlValueSet> __Prostate_Cancer_Treatment;
    internal Lazy<CqlValueSet> __Prostate_Specific_Antigen_Test;
    internal Lazy<CqlValueSet> __Salvage_Therapy;
    internal Lazy<CqlCode> __Gleason_score_in_Specimen_Qualitative;
    internal Lazy<CqlCode> __Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_;
    internal Lazy<CqlCode> __Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_;
    internal Lazy<CqlCode> __Procedure_reason_record__record_artifact_;
    internal Lazy<CqlCode> __T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_;
    internal Lazy<CqlCode> __T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_;
    internal Lazy<CqlCode> __Tumor_staging__tumor_staging_;
    internal Lazy<CqlCode[]> __LOINC;
    internal Lazy<CqlCode[]> __SNOMEDCT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<IEnumerable<Condition>> __Prostate_Cancer_Diagnosis;
    internal Lazy<bool?> __Has_Diagnosis_of_Pain_related_to_Prostate_Cancer;
    internal Lazy<bool?> __Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis;
    internal Lazy<IEnumerable<Observation>> __Bone_Scan_Study_Performed;
    internal Lazy<bool?> __Has_Bone_Scan_Study_Performed_with_Documented_Reason;
    internal Lazy<bool?> __Denominator_Exceptions;
    internal Lazy<Procedure> __First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Most_Recent_Gleason_Score_is_Low;
    internal Lazy<Observation> __Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a;
    internal Lazy<bool?> __Numerator;
    internal Lazy<bool?> __Most_Recent_PSA_Test_Result_is_Low;
    internal Lazy<bool?> __Denominator;

    #endregion
    public ProstateCaAvoidanceBoneScanOveruseFHIR_0_2_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);

        __Bone_Scan = new Lazy<CqlValueSet>(this.Bone_Scan_Value);
        __Pain_Warranting_Further_Investigation_for_Prostate_Cancer = new Lazy<CqlValueSet>(this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer_Value);
        __Prostate_Cancer = new Lazy<CqlValueSet>(this.Prostate_Cancer_Value);
        __Prostate_Cancer_Treatment = new Lazy<CqlValueSet>(this.Prostate_Cancer_Treatment_Value);
        __Prostate_Specific_Antigen_Test = new Lazy<CqlValueSet>(this.Prostate_Specific_Antigen_Test_Value);
        __Salvage_Therapy = new Lazy<CqlValueSet>(this.Salvage_Therapy_Value);
        __Gleason_score_in_Specimen_Qualitative = new Lazy<CqlCode>(this.Gleason_score_in_Specimen_Qualitative_Value);
        __Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_ = new Lazy<CqlCode>(this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding__Value);
        __Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_ = new Lazy<CqlCode>(this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding__Value);
        __Procedure_reason_record__record_artifact_ = new Lazy<CqlCode>(this.Procedure_reason_record__record_artifact__Value);
        __T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_ = new Lazy<CqlCode>(this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding__Value);
        __T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_ = new Lazy<CqlCode>(this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding__Value);
        __Tumor_staging__tumor_staging_ = new Lazy<CqlCode>(this.Tumor_staging__tumor_staging__Value);
        __LOINC = new Lazy<CqlCode[]>(this.LOINC_Value);
        __SNOMEDCT = new Lazy<CqlCode[]>(this.SNOMEDCT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Prostate_Cancer_Diagnosis = new Lazy<IEnumerable<Condition>>(this.Prostate_Cancer_Diagnosis_Value);
        __Has_Diagnosis_of_Pain_related_to_Prostate_Cancer = new Lazy<bool?>(this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer_Value);
        __Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis = new Lazy<bool?>(this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Value);
        __Bone_Scan_Study_Performed = new Lazy<IEnumerable<Observation>>(this.Bone_Scan_Study_Performed_Value);
        __Has_Bone_Scan_Study_Performed_with_Documented_Reason = new Lazy<bool?>(this.Has_Bone_Scan_Study_Performed_with_Documented_Reason_Value);
        __Denominator_Exceptions = new Lazy<bool?>(this.Denominator_Exceptions_Value);
        __First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period = new Lazy<Procedure>(this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Most_Recent_Gleason_Score_is_Low = new Lazy<bool?>(this.Most_Recent_Gleason_Score_is_Low_Value);
        __Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a = new Lazy<Observation>(this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
        __Most_Recent_PSA_Test_Result_is_Low = new Lazy<bool?>(this.Most_Recent_PSA_Test_Result_is_Low_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }

    #endregion

	private CqlValueSet Bone_Scan_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", default);

    [CqlDeclaration("Bone Scan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320")]
	public CqlValueSet Bone_Scan() => 
		__Bone_Scan.Value;

	private CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", default);

    [CqlDeclaration("Pain Warranting Further Investigation for Prostate Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451")]
	public CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer() => 
		__Pain_Warranting_Further_Investigation_for_Prostate_Cancer.Value;

	private CqlValueSet Prostate_Cancer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", default);

    [CqlDeclaration("Prostate Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319")]
	public CqlValueSet Prostate_Cancer() => 
		__Prostate_Cancer.Value;

	private CqlValueSet Prostate_Cancer_Treatment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", default);

    [CqlDeclaration("Prostate Cancer Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398")]
	public CqlValueSet Prostate_Cancer_Treatment() => 
		__Prostate_Cancer_Treatment.Value;

	private CqlValueSet Prostate_Specific_Antigen_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", default);

    [CqlDeclaration("Prostate Specific Antigen Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401")]
	public CqlValueSet Prostate_Specific_Antigen_Test() => 
		__Prostate_Specific_Antigen_Test.Value;

	private CqlValueSet Salvage_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", default);

    [CqlDeclaration("Salvage Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399")]
	public CqlValueSet Salvage_Therapy() => 
		__Salvage_Therapy.Value;

	private CqlCode Gleason_score_in_Specimen_Qualitative_Value() => 
		new CqlCode("35266-6", "http://loinc.org", default, default);

    [CqlDeclaration("Gleason score in Specimen Qualitative")]
	public CqlCode Gleason_score_in_Specimen_Qualitative() => 
		__Gleason_score_in_Specimen_Qualitative.Value;

	private CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding__Value() => 
		new CqlCode("433351000124101", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)")]
	public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_() => 
		__Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_.Value;

	private CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding__Value() => 
		new CqlCode("433361000124104", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)")]
	public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_() => 
		__Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_.Value;

	private CqlCode Procedure_reason_record__record_artifact__Value() => 
		new CqlCode("433611000124109", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Procedure reason record (record artifact)")]
	public CqlCode Procedure_reason_record__record_artifact_() => 
		__Procedure_reason_record__record_artifact_.Value;

	private CqlCode T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding__Value() => 
		new CqlCode("369833007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)")]
	public CqlCode T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_() => 
		__T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_.Value;

	private CqlCode T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding__Value() => 
		new CqlCode("369834001", "http://snomed.info/sct", default, default);

    [CqlDeclaration("T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)")]
	public CqlCode T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_() => 
		__T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_.Value;

	private CqlCode Tumor_staging__tumor_staging__Value() => 
		new CqlCode("254292007", "http://snomed.info/sct", default, default);

    [CqlDeclaration("Tumor staging (tumor staging)")]
	public CqlCode Tumor_staging__tumor_staging_() => 
		__Tumor_staging__tumor_staging_.Value;

	private CqlCode[] LOINC_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("35266-6", "http://loinc.org", default, default),
		];

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		CqlCode[] a_ = [
			new CqlCode("433351000124101", "http://snomed.info/sct", default, default),
			new CqlCode("433361000124104", "http://snomed.info/sct", default, default),
			new CqlCode("433611000124109", "http://snomed.info/sct", default, default),
			new CqlCode("369833007", "http://snomed.info/sct", default, default),
			new CqlCode("369834001", "http://snomed.info/sct", default, default),
			new CqlCode("254292007", "http://snomed.info/sct", default, default),
		];

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("ProstateCaAvoidanceBoneScanOveruseFHIR-0.2.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Ethnicity();

		return a_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
	{
		(IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.SDE_Race();

		return a_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private IEnumerable<Condition> Prostate_Cancer_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Prostate_Cancer();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition ProstateCancer)
		{
			CqlInterval<CqlDateTime> e_ = QICoreCommon_2_0_000.prevalenceInterval(ProstateCancer);
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			bool? g_ = context.Operators.Overlaps(e_, f_, "day");
			bool? h_ = QICoreCommon_2_0_000.isProblemListItem(ProstateCancer);
			bool? i_ = QICoreCommon_2_0_000.isHealthConcern(ProstateCancer);
			bool? j_ = context.Operators.Or(h_, i_);
			bool? k_ = context.Operators.And(g_, j_);
			bool? l_ = QICoreCommon_2_0_000.isActive(ProstateCancer);
			bool? m_ = context.Operators.And(k_, l_);

			return m_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Prostate Cancer Diagnosis")]
	public IEnumerable<Condition> Prostate_Cancer_Diagnosis() => 
		__Prostate_Cancer_Diagnosis.Value;

	private bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer_Value()
	{
		CqlValueSet a_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer();
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		IEnumerable<Condition> c_(Condition ProstateCancerPain)
		{
			IEnumerable<Condition> f_ = this.Prostate_Cancer_Diagnosis();
			bool? g_(Condition ActiveProstateCancer)
			{
				CqlInterval<CqlDateTime> k_ = QICoreCommon_2_0_000.prevalenceInterval(ProstateCancerPain);
				CqlDateTime l_ = context.Operators.Start(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveProstateCancer);
				CqlDateTime n_ = context.Operators.Start(m_);
				bool? o_ = context.Operators.After(l_, n_, default);
				bool? p_ = QICoreCommon_2_0_000.isProblemListItem(ProstateCancerPain);
				bool? q_ = QICoreCommon_2_0_000.isHealthConcern(ProstateCancerPain);
				bool? r_ = context.Operators.Or(p_, q_);
				bool? s_ = context.Operators.And(o_, r_);
				bool? t_ = QICoreCommon_2_0_000.isActive(ProstateCancerPain);
				bool? u_ = context.Operators.And(s_, t_);

				return u_;
			};
			IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
			Condition i_(Condition ActiveProstateCancer) => 
				ProstateCancerPain;
			IEnumerable<Condition> j_ = context.Operators.Select<Condition, Condition>(h_, i_);

			return j_;
		};
		IEnumerable<Condition> d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Diagnosis of Pain related to Prostate Cancer")]
	public bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer() => 
		__Has_Diagnosis_of_Pain_related_to_Prostate_Cancer.Value;

	private bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Value()
	{
		CqlValueSet a_ = this.Salvage_Therapy();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		IEnumerable<Procedure> c_(Procedure SalvageTherapy)
		{
			IEnumerable<Condition> f_ = this.Prostate_Cancer_Diagnosis();
			bool? g_(Condition ActiveProstateCancer)
			{
				DataType k_ = SalvageTherapy?.Performed;
				object l_ = FHIRHelpers_4_3_000.ToValue(k_);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.toInterval(l_);
				CqlDateTime n_ = context.Operators.Start(m_);
				CqlInterval<CqlDateTime> o_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveProstateCancer);
				CqlDateTime p_ = context.Operators.Start(o_);
				bool? q_ = context.Operators.After(n_, p_, default);
				Code<EventStatus> r_ = SalvageTherapy?.StatusElement;
				EventStatus? s_ = r_?.Value;
				string t_ = context.Operators.Convert<string>(s_);
				bool? u_ = context.Operators.Equal(t_, "completed");
				bool? v_ = context.Operators.And(q_, u_);

				return v_;
			};
			IEnumerable<Condition> h_ = context.Operators.Where<Condition>(f_, g_);
			Procedure i_(Condition ActiveProstateCancer) => 
				SalvageTherapy;
			IEnumerable<Procedure> j_ = context.Operators.Select<Condition, Procedure>(h_, i_);

			return j_;
		};
		IEnumerable<Procedure> d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		bool? e_ = context.Operators.Exists<Procedure>(d_);

		return e_;
	}

    [CqlDeclaration("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
	public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis() => 
		__Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis.Value;

	private IEnumerable<Observation> Bone_Scan_Study_Performed_Value()
	{
		CqlValueSet a_ = this.Bone_Scan();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_(Observation BoneScan)
		{
			IEnumerable<Condition> e_ = this.Prostate_Cancer_Diagnosis();
			bool? f_(Condition ActiveProstateCancer)
			{
				DataType j_ = BoneScan?.Effective;
				object k_ = FHIRHelpers_4_3_000.ToValue(j_);
				CqlInterval<CqlDateTime> l_ = QICoreCommon_2_0_000.toInterval(k_);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveProstateCancer);
				CqlDateTime o_ = context.Operators.Start(n_);
				bool? p_ = context.Operators.After(m_, o_, default);

				return p_;
			};
			IEnumerable<Condition> g_ = context.Operators.Where<Condition>(e_, f_);
			Observation h_(Condition ActiveProstateCancer) => 
				BoneScan;
			IEnumerable<Observation> i_ = context.Operators.Select<Condition, Observation>(g_, h_);

			return i_;
		};
		IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bone Scan Study Performed")]
	public IEnumerable<Observation> Bone_Scan_Study_Performed() => 
		__Bone_Scan_Study_Performed.Value;

	private bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason_Value()
	{
		IEnumerable<Observation> a_ = this.Bone_Scan_Study_Performed();
		bool? b_(Observation BoneScanAfterDiagnosis)
		{
			DataType e_ = BoneScanAfterDiagnosis?.Value;
			object f_ = FHIRHelpers_4_3_000.ToValue(e_);
			CqlCode g_ = this.Procedure_reason_record__record_artifact_();
			CqlConcept h_ = context.Operators.ConvertCodeToConcept(g_);
			bool? i_ = context.Operators.Equivalent(f_ as CqlConcept, h_);

			return i_;
		};
		IEnumerable<Observation> c_ = context.Operators.Where<Observation>(a_, b_);
		bool? d_ = context.Operators.Exists<Observation>(c_);

		return d_;
	}

    [CqlDeclaration("Has Bone Scan Study Performed with Documented Reason")]
	public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason() => 
		__Has_Bone_Scan_Study_Performed_with_Documented_Reason.Value;

	private bool? Denominator_Exceptions_Value()
	{
		bool? a_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer();
		bool? b_ = this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis();
		bool? c_ = context.Operators.Or(a_, b_);
		bool? d_ = this.Has_Bone_Scan_Study_Performed_with_Documented_Reason();
		bool? e_ = context.Operators.Or(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Prostate_Cancer_Treatment();
		IEnumerable<Procedure> b_ = context.Operators.Retrieve<Procedure>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-procedure"));
		bool? c_(Procedure ProstateCancerTreatment)
		{
			DataType h_ = ProstateCancerTreatment?.Performed;
			object i_ = FHIRHelpers_4_3_000.ToValue(h_);
			CqlInterval<CqlDateTime> j_ = QICoreCommon_2_0_000.toInterval(i_);
			CqlDateTime k_ = context.Operators.End(j_);
			CqlInterval<CqlDateTime> l_ = this.Measurement_Period();
			bool? m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
			Code<EventStatus> n_ = ProstateCancerTreatment?.StatusElement;
			EventStatus? o_ = n_?.Value;
			string p_ = context.Operators.Convert<string>(o_);
			bool? q_ = context.Operators.Equal(p_, "completed");
			bool? r_ = context.Operators.And(m_, q_);

			return r_;
		};
		IEnumerable<Procedure> d_ = context.Operators.Where<Procedure>(b_, c_);
		object e_(Procedure @this)
		{
			DataType s_ = @this?.Performed;
			object t_ = FHIRHelpers_4_3_000.ToValue(s_);
			CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.toInterval(t_);
			CqlDateTime v_ = context.Operators.Start(u_);

			return v_;
		};
		IEnumerable<Procedure> f_ = context.Operators.SortBy<Procedure>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Procedure g_ = context.Operators.First<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("First Prostate Cancer Treatment during day of Measurement Period")]
	public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period() => 
		__First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		IEnumerable<Condition> a_ = this.Prostate_Cancer_Diagnosis();
		bool? b_ = context.Operators.Exists<Condition>(a_);

		return b_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Most_Recent_Gleason_Score_is_Low_Value()
	{
		CqlCode a_ = this.Gleason_score_in_Specimen_Qualitative();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> d_(Observation GleasonScore)
		{
			Procedure m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period();
			Procedure[] n_ = [
				m_,
			];
			bool? o_(Procedure FirstProstateCancerTreatment)
			{
				DataType s_ = GleasonScore?.Effective;
				object t_ = FHIRHelpers_4_3_000.ToValue(s_);
				CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.toInterval(t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				DataType w_ = FirstProstateCancerTreatment?.Performed;
				object x_ = FHIRHelpers_4_3_000.ToValue(w_);
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.toInterval(x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.Before(v_, z_, default);
				Code<ObservationStatus> ab_ = GleasonScore?.StatusElement;
				ObservationStatus? ac_ = ab_?.Value;
				Code<ObservationStatus> ad_ = context.Operators.Convert<Code<ObservationStatus>>(ac_);
				string ae_ = context.Operators.Convert<string>(ad_);
				string[] af_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ag_ = context.Operators.In<string>(ae_, af_ as IEnumerable<string>);
				bool? ah_ = context.Operators.And(aa_, ag_);

				return ah_;
			};
			IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
			Observation q_(Procedure FirstProstateCancerTreatment) => 
				GleasonScore;
			IEnumerable<Observation> r_ = context.Operators.Select<Procedure, Observation>(p_, q_);

			return r_;
		};
		IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType ai_ = @this?.Effective;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.toInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);

			return al_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		Observation[] i_ = [
			h_,
		];
		bool? j_(Observation LastGleasonScore)
		{
			DataType am_ = LastGleasonScore?.Value;
			object an_ = FHIRHelpers_4_3_000.ToValue(am_);
			bool? ao_ = context.Operators.LessOrEqual(an_ as int?, 6);

			return ao_;
		};
		IEnumerable<bool?> k_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)i_, j_);
		bool? l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Gleason Score is Low")]
	public bool? Most_Recent_Gleason_Score_is_Low() => 
		__Most_Recent_Gleason_Score_is_Low.Value;

	private Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Value()
	{
		CqlCode a_ = this.Tumor_staging__tumor_staging_();
		IEnumerable<CqlCode> b_ = context.Operators.ToList<CqlCode>(a_);
		IEnumerable<Observation> c_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, default, b_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> d_(Observation ProstateCancerStaging)
		{
			Procedure m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period();
			Procedure[] n_ = [
				m_,
			];
			bool? o_(Procedure FirstProstateCancerTreatment)
			{
				DataType s_ = ProstateCancerStaging?.Effective;
				object t_ = FHIRHelpers_4_3_000.ToValue(s_);
				CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.toInterval(t_);
				CqlDateTime v_ = context.Operators.Start(u_);
				DataType w_ = FirstProstateCancerTreatment?.Performed;
				object x_ = FHIRHelpers_4_3_000.ToValue(w_);
				CqlInterval<CqlDateTime> y_ = QICoreCommon_2_0_000.toInterval(x_);
				CqlDateTime z_ = context.Operators.Start(y_);
				bool? aa_ = context.Operators.Before(v_, z_, default);
				Code<ObservationStatus> ab_ = ProstateCancerStaging?.StatusElement;
				ObservationStatus? ac_ = ab_?.Value;
				Code<ObservationStatus> ad_ = context.Operators.Convert<Code<ObservationStatus>>(ac_);
				string ae_ = context.Operators.Convert<string>(ad_);
				string[] af_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ag_ = context.Operators.In<string>(ae_, af_ as IEnumerable<string>);
				bool? ah_ = context.Operators.And(aa_, ag_);

				return ah_;
			};
			IEnumerable<Procedure> p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
			Observation q_(Procedure FirstProstateCancerTreatment) => 
				ProstateCancerStaging;
			IEnumerable<Observation> r_ = context.Operators.Select<Procedure, Observation>(p_, q_);

			return r_;
		};
		IEnumerable<Observation> e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
		object f_(Observation @this)
		{
			DataType ai_ = @this?.Effective;
			object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.toInterval(aj_);
			CqlDateTime al_ = context.Operators.Start(ak_);

			return al_;
		};
		IEnumerable<Observation> g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		Observation h_ = context.Operators.Last<Observation>(g_);
		Observation[] i_ = [
			h_,
		];
		bool? j_(Observation LastProstateCancerStaging)
		{
			DataType am_ = LastProstateCancerStaging?.Value;
			object an_ = FHIRHelpers_4_3_000.ToValue(am_);
			CqlCode ao_ = this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_();
			CqlConcept ap_ = context.Operators.ConvertCodeToConcept(ao_);
			bool? aq_ = context.Operators.Equivalent(an_ as CqlConcept, ap_);
			object as_ = FHIRHelpers_4_3_000.ToValue(am_);
			CqlCode at_ = this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_();
			CqlConcept au_ = context.Operators.ConvertCodeToConcept(at_);
			bool? av_ = context.Operators.Equivalent(as_ as CqlConcept, au_);
			bool? aw_ = context.Operators.Or(aq_, av_);
			object ay_ = FHIRHelpers_4_3_000.ToValue(am_);
			CqlCode az_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_();
			CqlConcept ba_ = context.Operators.ConvertCodeToConcept(az_);
			bool? bb_ = context.Operators.Equivalent(ay_ as CqlConcept, ba_);
			bool? bc_ = context.Operators.Or(aw_, bb_);
			object be_ = FHIRHelpers_4_3_000.ToValue(am_);
			CqlCode bf_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_();
			CqlConcept bg_ = context.Operators.ConvertCodeToConcept(bf_);
			bool? bh_ = context.Operators.Equivalent(be_ as CqlConcept, bg_);
			bool? bi_ = context.Operators.Or(bc_, bh_);

			return bi_;
		};
		IEnumerable<Observation> k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
		Observation l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
	public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a() => 
		__Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a.Value;

	private bool? Numerator_Value()
	{
		IEnumerable<Observation> a_ = this.Bone_Scan_Study_Performed();
		bool? b_ = context.Operators.Exists<Observation>(a_);
		bool? c_ = context.Operators.Not(b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Most_Recent_PSA_Test_Result_is_Low_Value()
	{
		CqlValueSet a_ = this.Prostate_Specific_Antigen_Test();
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		IEnumerable<Observation> c_(Observation PSATest)
		{
			Observation l_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a();
			Observation[] m_ = [
				l_,
			];
			bool? n_(Observation MostRecentProstateCancerStaging)
			{
				CqlInterval<CqlDateTime> r_()
				{
					bool ad_()
					{
						DataType ae_ = PSATest?.Effective;
						object af_ = FHIRHelpers_4_3_000.ToValue(ae_);
						CqlInterval<CqlDateTime> ag_ = QICoreCommon_2_0_000.toInterval(af_);
						CqlDateTime ah_ = context.Operators.Start(ag_);

						return ah_ is null;
					};
					if (ad_())
					{
						return default;
					}
					else
					{
						DataType ai_ = PSATest?.Effective;
						object aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
						CqlInterval<CqlDateTime> ak_ = QICoreCommon_2_0_000.toInterval(aj_);
						CqlDateTime al_ = context.Operators.Start(ak_);
						object an_ = FHIRHelpers_4_3_000.ToValue(ai_);
						CqlInterval<CqlDateTime> ao_ = QICoreCommon_2_0_000.toInterval(an_);
						CqlDateTime ap_ = context.Operators.Start(ao_);
						CqlInterval<CqlDateTime> aq_ = context.Operators.Interval(al_, ap_, true, true);

						return aq_;
					}
				};
				DataType s_ = MostRecentProstateCancerStaging?.Effective;
				object t_ = FHIRHelpers_4_3_000.ToValue(s_);
				CqlInterval<CqlDateTime> u_ = QICoreCommon_2_0_000.toInterval(t_);
				bool? v_ = context.Operators.Before(r_(), u_, default);
				Code<ObservationStatus> w_ = PSATest?.StatusElement;
				ObservationStatus? x_ = w_?.Value;
				Code<ObservationStatus> y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				string z_ = context.Operators.Convert<string>(y_);
				string[] aa_ = [
					"final",
					"amended",
					"corrected",
				];
				bool? ab_ = context.Operators.In<string>(z_, aa_ as IEnumerable<string>);
				bool? ac_ = context.Operators.And(v_, ab_);

				return ac_;
			};
			IEnumerable<Observation> o_ = context.Operators.Where<Observation>((IEnumerable<Observation>)m_, n_);
			Observation p_(Observation MostRecentProstateCancerStaging) => 
				PSATest;
			IEnumerable<Observation> q_ = context.Operators.Select<Observation, Observation>(o_, p_);

			return q_;
		};
		IEnumerable<Observation> d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
		object e_(Observation @this)
		{
			DataType ar_ = @this?.Effective;
			object as_ = FHIRHelpers_4_3_000.ToValue(ar_);
			CqlInterval<CqlDateTime> at_ = QICoreCommon_2_0_000.toInterval(as_);
			CqlDateTime au_ = context.Operators.Start(at_);

			return au_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.Last<Observation>(f_);
		Observation[] h_ = [
			g_,
		];
		bool? i_(Observation LastPSATest)
		{
			DataType av_ = LastPSATest?.Value;
			object aw_ = FHIRHelpers_4_3_000.ToValue(av_);
			CqlQuantity ax_ = context.Operators.Quantity(10m, "ng/mL");
			bool? ay_ = context.Operators.Less(aw_ as CqlQuantity, ax_);

			return ay_;
		};
		IEnumerable<bool?> j_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)h_, i_);
		bool? k_ = context.Operators.SingletonFrom<bool?>(j_);

		return k_;
	}

    [CqlDeclaration("Most Recent PSA Test Result is Low")]
	public bool? Most_Recent_PSA_Test_Result_is_Low() => 
		__Most_Recent_PSA_Test_Result_is_Low.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();
		Procedure b_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period();
		bool? c_ = context.Operators.Not((bool?)(b_ is null));
		bool? d_ = context.Operators.And(a_, c_);
		Observation e_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a();
		bool? f_ = context.Operators.Not((bool?)(e_ is null));
		bool? g_ = context.Operators.And(d_, f_);
		bool? h_ = this.Most_Recent_PSA_Test_Result_is_Low();
		bool? i_ = context.Operators.And(g_, h_);
		bool? j_ = this.Most_Recent_Gleason_Score_is_Low();
		bool? k_ = context.Operators.And(i_, j_);

		return k_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

}
