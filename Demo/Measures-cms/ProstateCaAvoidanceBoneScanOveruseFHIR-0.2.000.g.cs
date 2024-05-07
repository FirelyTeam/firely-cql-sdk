using System;
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
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320", null);

    [CqlDeclaration("Bone Scan")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.320")]
	public CqlValueSet Bone_Scan() => 
		__Bone_Scan.Value;

	private CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451", null);

    [CqlDeclaration("Pain Warranting Further Investigation for Prostate Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.451")]
	public CqlValueSet Pain_Warranting_Further_Investigation_for_Prostate_Cancer() => 
		__Pain_Warranting_Further_Investigation_for_Prostate_Cancer.Value;

	private CqlValueSet Prostate_Cancer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);

    [CqlDeclaration("Prostate Cancer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319")]
	public CqlValueSet Prostate_Cancer() => 
		__Prostate_Cancer.Value;

	private CqlValueSet Prostate_Cancer_Treatment_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398", null);

    [CqlDeclaration("Prostate Cancer Treatment")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.398")]
	public CqlValueSet Prostate_Cancer_Treatment() => 
		__Prostate_Cancer_Treatment.Value;

	private CqlValueSet Prostate_Specific_Antigen_Test_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401", null);

    [CqlDeclaration("Prostate Specific Antigen Test")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.401")]
	public CqlValueSet Prostate_Specific_Antigen_Test() => 
		__Prostate_Specific_Antigen_Test.Value;

	private CqlValueSet Salvage_Therapy_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399", null);

    [CqlDeclaration("Salvage Therapy")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.399")]
	public CqlValueSet Salvage_Therapy() => 
		__Salvage_Therapy.Value;

	private CqlCode Gleason_score_in_Specimen_Qualitative_Value() => 
		new CqlCode("35266-6", "http://loinc.org", null, null);

    [CqlDeclaration("Gleason score in Specimen Qualitative")]
	public CqlCode Gleason_score_in_Specimen_Qualitative() => 
		__Gleason_score_in_Specimen_Qualitative.Value;

	private CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding__Value() => 
		new CqlCode("433351000124101", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Neoplasm of prostate primary tumor staging category T1c: Tumor identified by needle biopsy (finding)")]
	public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_() => 
		__Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_.Value;

	private CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding__Value() => 
		new CqlCode("433361000124104", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Neoplasm of prostate primary tumor staging category T2a: Involves one-half of one lobe or less (finding)")]
	public CqlCode Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_() => 
		__Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_.Value;

	private CqlCode Procedure_reason_record__record_artifact__Value() => 
		new CqlCode("433611000124109", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Procedure reason record (record artifact)")]
	public CqlCode Procedure_reason_record__record_artifact_() => 
		__Procedure_reason_record__record_artifact_.Value;

	private CqlCode T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding__Value() => 
		new CqlCode("369833007", "http://snomed.info/sct", null, null);

    [CqlDeclaration("T1a: Prostate tumor incidental histologic finding in 5 percent or less of tissue resected (finding)")]
	public CqlCode T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_() => 
		__T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_.Value;

	private CqlCode T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding__Value() => 
		new CqlCode("369834001", "http://snomed.info/sct", null, null);

    [CqlDeclaration("T1b: Prostate tumor incidental histologic finding in greater than 5 percent of tissue resected (finding)")]
	public CqlCode T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_() => 
		__T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_.Value;

	private CqlCode Tumor_staging__tumor_staging__Value() => 
		new CqlCode("254292007", "http://snomed.info/sct", null, null);

    [CqlDeclaration("Tumor staging (tumor staging)")]
	public CqlCode Tumor_staging__tumor_staging_() => 
		__Tumor_staging__tumor_staging_.Value;

	private CqlCode[] LOINC_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("35266-6", "http://loinc.org", null, null),
		};

		return a_;
	}

    [CqlDeclaration("LOINC")]
	public CqlCode[] LOINC() => 
		__LOINC.Value;

	private CqlCode[] SNOMEDCT_Value()
	{
		var a_ = new CqlCode[]
		{
			new CqlCode("433351000124101", "http://snomed.info/sct", null, null),
			new CqlCode("433361000124104", "http://snomed.info/sct", null, null),
			new CqlCode("433611000124109", "http://snomed.info/sct", null, null),
			new CqlCode("369833007", "http://snomed.info/sct", null, null),
			new CqlCode("369834001", "http://snomed.info/sct", null, null),
			new CqlCode("254292007", "http://snomed.info/sct", null, null),
		};

		return a_;
	}

    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT() => 
		__SNOMEDCT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("ProstateCaAvoidanceBoneScanOveruseFHIR-0.2.000", "Measurement Period", c_);

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

	private IEnumerable<Condition> Prostate_Cancer_Diagnosis_Value()
	{
		var a_ = this.Prostate_Cancer();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition ProstateCancer)
		{
			var e_ = QICoreCommon_2_0_000.prevalenceInterval(ProstateCancer);
			var f_ = this.Measurement_Period();
			var g_ = context.Operators.Overlaps(e_, f_, "day");
			var h_ = QICoreCommon_2_0_000.isProblemListItem(ProstateCancer);
			var i_ = QICoreCommon_2_0_000.isHealthConcern(ProstateCancer);
			var j_ = context.Operators.Or(h_, i_);
			var k_ = context.Operators.And(g_, j_);
			var l_ = QICoreCommon_2_0_000.isActive(ProstateCancer);
			var m_ = context.Operators.And(k_, l_);

			return m_;
		};
		var d_ = context.Operators.Where<Condition>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Prostate Cancer Diagnosis")]
	public IEnumerable<Condition> Prostate_Cancer_Diagnosis() => 
		__Prostate_Cancer_Diagnosis.Value;

	private bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer_Value()
	{
		var a_ = this.Pain_Warranting_Further_Investigation_for_Prostate_Cancer();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		IEnumerable<Condition> c_(Condition ProstateCancerPain)
		{
			var f_ = this.Prostate_Cancer_Diagnosis();
			bool? g_(Condition ActiveProstateCancer)
			{
				var k_ = QICoreCommon_2_0_000.prevalenceInterval(ProstateCancerPain);
				var l_ = context.Operators.Start(k_);
				var m_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveProstateCancer);
				var n_ = context.Operators.Start(m_);
				var o_ = context.Operators.After(l_, n_, null);
				var p_ = QICoreCommon_2_0_000.isProblemListItem(ProstateCancerPain);
				var q_ = QICoreCommon_2_0_000.isHealthConcern(ProstateCancerPain);
				var r_ = context.Operators.Or(p_, q_);
				var s_ = context.Operators.And(o_, r_);
				var t_ = QICoreCommon_2_0_000.isActive(ProstateCancerPain);
				var u_ = context.Operators.And(s_, t_);

				return u_;
			};
			var h_ = context.Operators.Where<Condition>(f_, g_);
			Condition i_(Condition ActiveProstateCancer) => 
				ProstateCancerPain;
			var j_ = context.Operators.Select<Condition, Condition>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectMany<Condition, Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Diagnosis of Pain related to Prostate Cancer")]
	public bool? Has_Diagnosis_of_Pain_related_to_Prostate_Cancer() => 
		__Has_Diagnosis_of_Pain_related_to_Prostate_Cancer.Value;

	private bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis_Value()
	{
		var a_ = this.Salvage_Therapy();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		IEnumerable<Procedure> c_(Procedure SalvageTherapy)
		{
			var f_ = this.Prostate_Cancer_Diagnosis();
			bool? g_(Condition ActiveProstateCancer)
			{
				var k_ = SalvageTherapy?.Performed;
				var l_ = FHIRHelpers_4_3_000.ToValue(k_);
				var m_ = QICoreCommon_2_0_000.toInterval(l_);
				var n_ = context.Operators.Start(m_);
				var o_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveProstateCancer);
				var p_ = context.Operators.Start(o_);
				var q_ = context.Operators.After(n_, p_, null);
				var r_ = SalvageTherapy?.StatusElement;
				var s_ = r_?.Value;
				var t_ = context.Operators.Convert<string>(s_);
				var u_ = context.Operators.Equal(t_, "completed");
				var v_ = context.Operators.And(q_, u_);

				return v_;
			};
			var h_ = context.Operators.Where<Condition>(f_, g_);
			Procedure i_(Condition ActiveProstateCancer) => 
				SalvageTherapy;
			var j_ = context.Operators.Select<Condition, Procedure>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectMany<Procedure, Procedure>(b_, c_);
		var e_ = context.Operators.Exists<Procedure>(d_);

		return e_;
	}

    [CqlDeclaration("Has Salvage Therapy Performed after Prostate Cancer Diagnosis")]
	public bool? Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis() => 
		__Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis.Value;

	private IEnumerable<Observation> Bone_Scan_Study_Performed_Value()
	{
		var a_ = this.Bone_Scan();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> c_(Observation BoneScan)
		{
			var e_ = this.Prostate_Cancer_Diagnosis();
			bool? f_(Condition ActiveProstateCancer)
			{
				var j_ = BoneScan?.Effective;
				var k_ = FHIRHelpers_4_3_000.ToValue(j_);
				var l_ = QICoreCommon_2_0_000.toInterval(k_);
				var m_ = context.Operators.Start(l_);
				var n_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveProstateCancer);
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.After(m_, o_, null);

				return p_;
			};
			var g_ = context.Operators.Where<Condition>(e_, f_);
			Observation h_(Condition ActiveProstateCancer) => 
				BoneScan;
			var i_ = context.Operators.Select<Condition, Observation>(g_, h_);

			return i_;
		};
		var d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);

		return d_;
	}

    [CqlDeclaration("Bone Scan Study Performed")]
	public IEnumerable<Observation> Bone_Scan_Study_Performed() => 
		__Bone_Scan_Study_Performed.Value;

	private bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason_Value()
	{
		var a_ = this.Bone_Scan_Study_Performed();
		bool? b_(Observation BoneScanAfterDiagnosis)
		{
			var e_ = BoneScanAfterDiagnosis?.Value;
			var f_ = FHIRHelpers_4_3_000.ToValue(e_);
			var g_ = this.Procedure_reason_record__record_artifact_();
			var h_ = context.Operators.ConvertCodeToConcept(g_);
			var i_ = context.Operators.Equivalent((f_ as CqlConcept), h_);

			return i_;
		};
		var c_ = context.Operators.Where<Observation>(a_, b_);
		var d_ = context.Operators.Exists<Observation>(c_);

		return d_;
	}

    [CqlDeclaration("Has Bone Scan Study Performed with Documented Reason")]
	public bool? Has_Bone_Scan_Study_Performed_with_Documented_Reason() => 
		__Has_Bone_Scan_Study_Performed_with_Documented_Reason.Value;

	private bool? Denominator_Exceptions_Value()
	{
		var a_ = this.Has_Diagnosis_of_Pain_related_to_Prostate_Cancer();
		var b_ = this.Has_Salvage_Therapy_Performed_after_Prostate_Cancer_Diagnosis();
		var c_ = context.Operators.Or(a_, b_);
		var d_ = this.Has_Bone_Scan_Study_Performed_with_Documented_Reason();
		var e_ = context.Operators.Or(c_, d_);

		return e_;
	}

    [CqlDeclaration("Denominator Exceptions")]
	public bool? Denominator_Exceptions() => 
		__Denominator_Exceptions.Value;

	private Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period_Value()
	{
		var a_ = this.Prostate_Cancer_Treatment();
		var b_ = context.Operators.RetrieveByValueSet<Procedure>(a_, null);
		bool? c_(Procedure ProstateCancerTreatment)
		{
			var h_ = ProstateCancerTreatment?.Performed;
			var i_ = FHIRHelpers_4_3_000.ToValue(h_);
			var j_ = QICoreCommon_2_0_000.toInterval(i_);
			var k_ = context.Operators.End(j_);
			var l_ = this.Measurement_Period();
			var m_ = context.Operators.In<CqlDateTime>(k_, l_, "day");
			var n_ = ProstateCancerTreatment?.StatusElement;
			var o_ = n_?.Value;
			var p_ = context.Operators.Convert<string>(o_);
			var q_ = context.Operators.Equal(p_, "completed");
			var r_ = context.Operators.And(m_, q_);

			return r_;
		};
		var d_ = context.Operators.Where<Procedure>(b_, c_);
		object e_(Procedure @this)
		{
			var s_ = @this?.Performed;
			var t_ = FHIRHelpers_4_3_000.ToValue(s_);
			var u_ = QICoreCommon_2_0_000.toInterval(t_);
			var v_ = context.Operators.Start(u_);

			return v_;
		};
		var f_ = context.Operators.SortBy<Procedure>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.First<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("First Prostate Cancer Treatment during day of Measurement Period")]
	public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period() => 
		__First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Prostate_Cancer_Diagnosis();
		var b_ = context.Operators.Exists<Condition>(a_);

		return b_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Most_Recent_Gleason_Score_is_Low_Value()
	{
		var a_ = this.Gleason_score_in_Specimen_Qualitative();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_(Observation GleasonScore)
		{
			var m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period();
			var n_ = new Procedure[]
			{
				m_,
			};
			bool? o_(Procedure FirstProstateCancerTreatment)
			{
				var s_ = GleasonScore?.Effective;
				var t_ = FHIRHelpers_4_3_000.ToValue(s_);
				var u_ = QICoreCommon_2_0_000.toInterval(t_);
				var v_ = context.Operators.Start(u_);
				var w_ = FirstProstateCancerTreatment?.Performed;
				var x_ = FHIRHelpers_4_3_000.ToValue(w_);
				var y_ = QICoreCommon_2_0_000.toInterval(x_);
				var z_ = context.Operators.Start(y_);
				var aa_ = context.Operators.Before(v_, z_, null);
				var ab_ = GleasonScore?.StatusElement;
				var ac_ = ab_?.Value;
				var ad_ = context.Operators.Convert<Code<ObservationStatus>>(ac_);
				var ae_ = context.Operators.Convert<string>(ad_);
				var af_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ag_ = context.Operators.In<string>(ae_, (af_ as IEnumerable<string>));
				var ah_ = context.Operators.And(aa_, ag_);

				return ah_;
			};
			var p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
			Observation q_(Procedure FirstProstateCancerTreatment) => 
				GleasonScore;
			var r_ = context.Operators.Select<Procedure, Observation>(p_, q_);

			return r_;
		};
		var e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
		object f_(Observation @this)
		{
			var ai_ = @this?.Effective;
			var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			var ak_ = QICoreCommon_2_0_000.toInterval(aj_);
			var al_ = context.Operators.Start(ak_);

			return al_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
		var i_ = new Observation[]
		{
			h_,
		};
		bool? j_(Observation LastGleasonScore)
		{
			var am_ = LastGleasonScore?.Value;
			var an_ = FHIRHelpers_4_3_000.ToValue(am_);
			var ao_ = context.Operators.LessOrEqual((int?)an_, 6);

			return ao_;
		};
		var k_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)i_, j_);
		var l_ = context.Operators.SingletonFrom<bool?>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Gleason Score is Low")]
	public bool? Most_Recent_Gleason_Score_is_Low() => 
		__Most_Recent_Gleason_Score_is_Low.Value;

	private Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a_Value()
	{
		var a_ = this.Tumor_staging__tumor_staging_();
		var b_ = context.Operators.ToList<CqlCode>(a_);
		var c_ = context.Operators.RetrieveByCodes<Observation>(b_, null);
		IEnumerable<Observation> d_(Observation ProstateCancerStaging)
		{
			var m_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period();
			var n_ = new Procedure[]
			{
				m_,
			};
			bool? o_(Procedure FirstProstateCancerTreatment)
			{
				var s_ = ProstateCancerStaging?.Effective;
				var t_ = FHIRHelpers_4_3_000.ToValue(s_);
				var u_ = QICoreCommon_2_0_000.toInterval(t_);
				var v_ = context.Operators.Start(u_);
				var w_ = FirstProstateCancerTreatment?.Performed;
				var x_ = FHIRHelpers_4_3_000.ToValue(w_);
				var y_ = QICoreCommon_2_0_000.toInterval(x_);
				var z_ = context.Operators.Start(y_);
				var aa_ = context.Operators.Before(v_, z_, null);
				var ab_ = ProstateCancerStaging?.StatusElement;
				var ac_ = ab_?.Value;
				var ad_ = context.Operators.Convert<Code<ObservationStatus>>(ac_);
				var ae_ = context.Operators.Convert<string>(ad_);
				var af_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ag_ = context.Operators.In<string>(ae_, (af_ as IEnumerable<string>));
				var ah_ = context.Operators.And(aa_, ag_);

				return ah_;
			};
			var p_ = context.Operators.Where<Procedure>((IEnumerable<Procedure>)n_, o_);
			Observation q_(Procedure FirstProstateCancerTreatment) => 
				ProstateCancerStaging;
			var r_ = context.Operators.Select<Procedure, Observation>(p_, q_);

			return r_;
		};
		var e_ = context.Operators.SelectMany<Observation, Observation>(c_, d_);
		object f_(Observation @this)
		{
			var ai_ = @this?.Effective;
			var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
			var ak_ = QICoreCommon_2_0_000.toInterval(aj_);
			var al_ = context.Operators.Start(ak_);

			return al_;
		};
		var g_ = context.Operators.SortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.Last<Observation>(g_);
		var i_ = new Observation[]
		{
			h_,
		};
		bool? j_(Observation LastProstateCancerStaging)
		{
			var am_ = LastProstateCancerStaging?.Value;
			var an_ = FHIRHelpers_4_3_000.ToValue(am_);
			var ao_ = this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_();
			var ap_ = context.Operators.ConvertCodeToConcept(ao_);
			var aq_ = context.Operators.Equivalent((an_ as CqlConcept), ap_);
			var as_ = FHIRHelpers_4_3_000.ToValue(am_);
			var at_ = this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_();
			var au_ = context.Operators.ConvertCodeToConcept(at_);
			var av_ = context.Operators.Equivalent((as_ as CqlConcept), au_);
			var aw_ = context.Operators.Or(aq_, av_);
			var ay_ = FHIRHelpers_4_3_000.ToValue(am_);
			var az_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_();
			var ba_ = context.Operators.ConvertCodeToConcept(az_);
			var bb_ = context.Operators.Equivalent((ay_ as CqlConcept), ba_);
			var bc_ = context.Operators.Or(aw_, bb_);
			var be_ = FHIRHelpers_4_3_000.ToValue(am_);
			var bf_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_();
			var bg_ = context.Operators.ConvertCodeToConcept(bf_);
			var bh_ = context.Operators.Equivalent((be_ as CqlConcept), bg_);
			var bi_ = context.Operators.Or(bc_, bh_);

			return bi_;
		};
		var k_ = context.Operators.Where<Observation>((IEnumerable<Observation>)i_, j_);
		var l_ = context.Operators.SingletonFrom<Observation>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
	public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a() => 
		__Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Bone_Scan_Study_Performed();
		var b_ = context.Operators.Exists<Observation>(a_);
		var c_ = context.Operators.Not(b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

	private bool? Most_Recent_PSA_Test_Result_is_Low_Value()
	{
		var a_ = this.Prostate_Specific_Antigen_Test();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		IEnumerable<Observation> c_(Observation PSATest)
		{
			var l_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a();
			var m_ = new Observation[]
			{
				l_,
			};
			bool? n_(Observation MostRecentProstateCancerStaging)
			{
				CqlInterval<CqlDateTime> r_()
				{
					bool ad_()
					{
						var ae_ = PSATest?.Effective;
						var af_ = FHIRHelpers_4_3_000.ToValue(ae_);
						var ag_ = QICoreCommon_2_0_000.toInterval(af_);
						var ah_ = context.Operators.Start(ag_);

						return (ah_ is null);
					};
					if (ad_())
					{
						return null;
					}
					else
					{
						var ai_ = PSATest?.Effective;
						var aj_ = FHIRHelpers_4_3_000.ToValue(ai_);
						var ak_ = QICoreCommon_2_0_000.toInterval(aj_);
						var al_ = context.Operators.Start(ak_);
						var an_ = FHIRHelpers_4_3_000.ToValue(ai_);
						var ao_ = QICoreCommon_2_0_000.toInterval(an_);
						var ap_ = context.Operators.Start(ao_);
						var aq_ = context.Operators.Interval(al_, ap_, true, true);

						return aq_;
					}
				};
				var s_ = MostRecentProstateCancerStaging?.Effective;
				var t_ = FHIRHelpers_4_3_000.ToValue(s_);
				var u_ = QICoreCommon_2_0_000.toInterval(t_);
				var v_ = context.Operators.Before(r_(), u_, null);
				var w_ = PSATest?.StatusElement;
				var x_ = w_?.Value;
				var y_ = context.Operators.Convert<Code<ObservationStatus>>(x_);
				var z_ = context.Operators.Convert<string>(y_);
				var aa_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ab_ = context.Operators.In<string>(z_, (aa_ as IEnumerable<string>));
				var ac_ = context.Operators.And(v_, ab_);

				return ac_;
			};
			var o_ = context.Operators.Where<Observation>((IEnumerable<Observation>)m_, n_);
			Observation p_(Observation MostRecentProstateCancerStaging) => 
				PSATest;
			var q_ = context.Operators.Select<Observation, Observation>(o_, p_);

			return q_;
		};
		var d_ = context.Operators.SelectMany<Observation, Observation>(b_, c_);
		object e_(Observation @this)
		{
			var ar_ = @this?.Effective;
			var as_ = FHIRHelpers_4_3_000.ToValue(ar_);
			var at_ = QICoreCommon_2_0_000.toInterval(as_);
			var au_ = context.Operators.Start(at_);

			return au_;
		};
		var f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.Last<Observation>(f_);
		var h_ = new Observation[]
		{
			g_,
		};
		bool? i_(Observation LastPSATest)
		{
			var av_ = LastPSATest?.Value;
			var aw_ = FHIRHelpers_4_3_000.ToValue(av_);
			var ax_ = context.Operators.Quantity(10m, "ng/mL");
			var ay_ = context.Operators.Less((aw_ as CqlQuantity), ax_);

			return ay_;
		};
		var j_ = context.Operators.Select<Observation, bool?>((IEnumerable<Observation>)h_, i_);
		var k_ = context.Operators.SingletonFrom<bool?>(j_);

		return k_;
	}

    [CqlDeclaration("Most Recent PSA Test Result is Low")]
	public bool? Most_Recent_PSA_Test_Result_is_Low() => 
		__Most_Recent_PSA_Test_Result_is_Low.Value;

	private bool? Denominator_Value()
	{
		var a_ = this.Initial_Population();
		var b_ = this.First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period();
		var c_ = context.Operators.Not((bool?)(b_ is null));
		var d_ = context.Operators.And(a_, c_);
		var e_ = this.Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a();
		var f_ = context.Operators.Not((bool?)(e_ is null));
		var g_ = context.Operators.And(d_, f_);
		var h_ = this.Most_Recent_PSA_Test_Result_is_Low();
		var i_ = context.Operators.And(g_, h_);
		var j_ = this.Most_Recent_Gleason_Score_is_Low();
		var k_ = context.Operators.And(i_, j_);

		return k_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

}
