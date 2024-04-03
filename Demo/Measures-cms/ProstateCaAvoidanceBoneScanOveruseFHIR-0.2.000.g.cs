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
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("ProstateCaAvoidanceBoneScanOveruseFHIR-0.2.000", "Measurement Period", e_);

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
		var d_ = context.Operators.WhereOrNull<Condition>(b_, c_);

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
			var h_ = context.Operators.WhereOrNull<Condition>(f_, g_);
			Condition i_(Condition ActiveProstateCancer) => 
				ProstateCancerPain;
			var j_ = context.Operators.SelectOrNull<Condition, Condition>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectManyOrNull<Condition, Condition>(b_, c_);
		var e_ = context.Operators.ExistsInList<Condition>(d_);

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
				var k_ = FHIRHelpers_4_3_000.ToValue(SalvageTherapy?.Performed);
				var l_ = QICoreCommon_2_0_000.toInterval(k_);
				var m_ = context.Operators.Start(l_);
				var n_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveProstateCancer);
				var o_ = context.Operators.Start(n_);
				var p_ = context.Operators.After(m_, o_, null);
				var q_ = context.Operators.EnumEqualsString(SalvageTherapy?.StatusElement?.Value, "completed");
				var r_ = context.Operators.And(p_, q_);

				return r_;
			};
			var h_ = context.Operators.WhereOrNull<Condition>(f_, g_);
			Procedure i_(Condition ActiveProstateCancer) => 
				SalvageTherapy;
			var j_ = context.Operators.SelectOrNull<Condition, Procedure>(h_, i_);

			return j_;
		};
		var d_ = context.Operators.SelectManyOrNull<Procedure, Procedure>(b_, c_);
		var e_ = context.Operators.ExistsInList<Procedure>(d_);

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
				var j_ = FHIRHelpers_4_3_000.ToValue(BoneScan?.Effective);
				var k_ = QICoreCommon_2_0_000.toInterval(j_);
				var l_ = context.Operators.Start(k_);
				var m_ = QICoreCommon_2_0_000.prevalenceInterval(ActiveProstateCancer);
				var n_ = context.Operators.Start(m_);
				var o_ = context.Operators.After(l_, n_, null);

				return o_;
			};
			var g_ = context.Operators.WhereOrNull<Condition>(e_, f_);
			Observation h_(Condition ActiveProstateCancer) => 
				BoneScan;
			var i_ = context.Operators.SelectOrNull<Condition, Observation>(g_, h_);

			return i_;
		};
		var d_ = context.Operators.SelectManyOrNull<Observation, Observation>(b_, c_);

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
			var e_ = FHIRHelpers_4_3_000.ToValue(BoneScanAfterDiagnosis?.Value);
			var f_ = this.Procedure_reason_record__record_artifact_();
			var g_ = context.Operators.ConvertCodeToConcept(f_);
			var h_ = context.Operators.Equivalent((e_ as CqlConcept), g_);

			return h_;
		};
		var c_ = context.Operators.WhereOrNull<Observation>(a_, b_);
		var d_ = context.Operators.ExistsInList<Observation>(c_);

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
			var h_ = FHIRHelpers_4_3_000.ToValue(ProstateCancerTreatment?.Performed);
			var i_ = QICoreCommon_2_0_000.toInterval(h_);
			var j_ = context.Operators.End(i_);
			var k_ = this.Measurement_Period();
			var l_ = context.Operators.ElementInInterval<CqlDateTime>(j_, k_, "day");
			var m_ = context.Operators.EnumEqualsString(ProstateCancerTreatment?.StatusElement?.Value, "completed");
			var n_ = context.Operators.And(l_, m_);

			return n_;
		};
		var d_ = context.Operators.WhereOrNull<Procedure>(b_, c_);
		object e_(Procedure @this)
		{
			var o_ = FHIRHelpers_4_3_000.ToValue(@this?.Performed);
			var p_ = QICoreCommon_2_0_000.toInterval(o_);
			var q_ = context.Operators.Start(p_);

			return q_;
		};
		var f_ = context.Operators.ListSortBy<Procedure>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.FirstOfList<Procedure>(f_);

		return g_;
	}

    [CqlDeclaration("First Prostate Cancer Treatment during day of Measurement Period")]
	public Procedure First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period() => 
		__First_Prostate_Cancer_Treatment_during_day_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Prostate_Cancer_Diagnosis();
		var b_ = context.Operators.ExistsInList<Condition>(a_);

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
				var s_ = FHIRHelpers_4_3_000.ToValue(GleasonScore?.Effective);
				var t_ = QICoreCommon_2_0_000.toInterval(s_);
				var u_ = context.Operators.Start(t_);
				var v_ = FHIRHelpers_4_3_000.ToValue(FirstProstateCancerTreatment?.Performed);
				var w_ = QICoreCommon_2_0_000.toInterval(v_);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Before(u_, x_, null);
				var z_ = context.Operators.Convert<Code<ObservationStatus>>(GleasonScore?.StatusElement?.Value);
				var aa_ = context.Operators.Convert<string>(z_);
				var ab_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ac_ = context.Operators.InList<string>(aa_, (ab_ as IEnumerable<string>));
				var ad_ = context.Operators.And(y_, ac_);

				return ad_;
			};
			var p_ = context.Operators.WhereOrNull<Procedure>(n_, o_);
			Observation q_(Procedure FirstProstateCancerTreatment) => 
				GleasonScore;
			var r_ = context.Operators.SelectOrNull<Procedure, Observation>(p_, q_);

			return r_;
		};
		var e_ = context.Operators.SelectManyOrNull<Observation, Observation>(c_, d_);
		object f_(Observation @this)
		{
			var ae_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var af_ = QICoreCommon_2_0_000.toInterval(ae_);
			var ag_ = context.Operators.Start(af_);

			return ag_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = new Observation[]
		{
			h_,
		};
		bool? j_(Observation LastGleasonScore)
		{
			var ah_ = FHIRHelpers_4_3_000.ToValue(LastGleasonScore?.Value);
			var ai_ = context.Operators.LessOrEqual((int?)ah_, (int?)6);

			return ai_;
		};
		var k_ = context.Operators.SelectOrNull<Observation, bool?>(i_, j_);
		var l_ = context.Operators.SingleOrNull<bool?>(k_);

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
				var s_ = FHIRHelpers_4_3_000.ToValue(ProstateCancerStaging?.Effective);
				var t_ = QICoreCommon_2_0_000.toInterval(s_);
				var u_ = context.Operators.Start(t_);
				var v_ = FHIRHelpers_4_3_000.ToValue(FirstProstateCancerTreatment?.Performed);
				var w_ = QICoreCommon_2_0_000.toInterval(v_);
				var x_ = context.Operators.Start(w_);
				var y_ = context.Operators.Before(u_, x_, null);
				var z_ = context.Operators.Convert<Code<ObservationStatus>>(ProstateCancerStaging?.StatusElement?.Value);
				var aa_ = context.Operators.Convert<string>(z_);
				var ab_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var ac_ = context.Operators.InList<string>(aa_, (ab_ as IEnumerable<string>));
				var ad_ = context.Operators.And(y_, ac_);

				return ad_;
			};
			var p_ = context.Operators.WhereOrNull<Procedure>(n_, o_);
			Observation q_(Procedure FirstProstateCancerTreatment) => 
				ProstateCancerStaging;
			var r_ = context.Operators.SelectOrNull<Procedure, Observation>(p_, q_);

			return r_;
		};
		var e_ = context.Operators.SelectManyOrNull<Observation, Observation>(c_, d_);
		object f_(Observation @this)
		{
			var ae_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var af_ = QICoreCommon_2_0_000.toInterval(ae_);
			var ag_ = context.Operators.Start(af_);

			return ag_;
		};
		var g_ = context.Operators.ListSortBy<Observation>(e_, f_, System.ComponentModel.ListSortDirection.Ascending);
		var h_ = context.Operators.LastOfList<Observation>(g_);
		var i_ = new Observation[]
		{
			h_,
		};
		bool? j_(Observation LastProstateCancerStaging)
		{
			var ah_ = FHIRHelpers_4_3_000.ToValue(LastProstateCancerStaging?.Value);
			var ai_ = this.T1a__Prostate_tumor_incidental_histologic_finding_in_5_percent_or_less_of_tissue_resected__finding_();
			var aj_ = context.Operators.ConvertCodeToConcept(ai_);
			var ak_ = context.Operators.Equivalent((ah_ as CqlConcept), aj_);
			var am_ = this.T1b__Prostate_tumor_incidental_histologic_finding_in_greater_than_5_percent_of_tissue_resected__finding_();
			var an_ = context.Operators.ConvertCodeToConcept(am_);
			var ao_ = context.Operators.Equivalent((ah_ as CqlConcept), an_);
			var ap_ = context.Operators.Or(ak_, ao_);
			var ar_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T1c__Tumor_identified_by_needle_biopsy__finding_();
			var as_ = context.Operators.ConvertCodeToConcept(ar_);
			var at_ = context.Operators.Equivalent((ah_ as CqlConcept), as_);
			var au_ = context.Operators.Or(ap_, at_);
			var aw_ = this.Neoplasm_of_prostate_primary_tumor_staging_category_T2a__Involves_one_half_of_one_lobe_or_less__finding_();
			var ax_ = context.Operators.ConvertCodeToConcept(aw_);
			var ay_ = context.Operators.Equivalent((ah_ as CqlConcept), ax_);
			var az_ = context.Operators.Or(au_, ay_);

			return az_;
		};
		var k_ = context.Operators.WhereOrNull<Observation>(i_, j_);
		var l_ = context.Operators.SingleOrNull<Observation>(k_);

		return l_;
	}

    [CqlDeclaration("Most Recent Prostate Cancer Staging Tumor Size T1a to T2a")]
	public Observation Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a() => 
		__Most_Recent_Prostate_Cancer_Staging_Tumor_Size_T1a_to_T2a.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Bone_Scan_Study_Performed();
		var b_ = context.Operators.ExistsInList<Observation>(a_);
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
					if ((context.Operators.Start(QICoreCommon_2_0_000.toInterval(FHIRHelpers_4_3_000.ToValue(PSATest?.Effective))) is null))
					{
						return null;
					}
					else
					{
						var aa_ = FHIRHelpers_4_3_000.ToValue(PSATest?.Effective);
						var ab_ = QICoreCommon_2_0_000.toInterval(aa_);
						var ac_ = context.Operators.Start(ab_);
						var ae_ = QICoreCommon_2_0_000.toInterval(aa_);
						var af_ = context.Operators.Start(ae_);
						var ag_ = context.Operators.Interval(ac_, af_, true, true);

						return ag_;
					};
				};
				var s_ = FHIRHelpers_4_3_000.ToValue(MostRecentProstateCancerStaging?.Effective);
				var t_ = QICoreCommon_2_0_000.toInterval(s_);
				var u_ = context.Operators.IntervalBeforeInterval(r_(), t_, null);
				var v_ = context.Operators.Convert<Code<ObservationStatus>>(PSATest?.StatusElement?.Value);
				var w_ = context.Operators.Convert<string>(v_);
				var x_ = new string[]
				{
					"final",
					"amended",
					"corrected",
				};
				var y_ = context.Operators.InList<string>(w_, (x_ as IEnumerable<string>));
				var z_ = context.Operators.And(u_, y_);

				return z_;
			};
			var o_ = context.Operators.WhereOrNull<Observation>(m_, n_);
			Observation p_(Observation MostRecentProstateCancerStaging) => 
				PSATest;
			var q_ = context.Operators.SelectOrNull<Observation, Observation>(o_, p_);

			return q_;
		};
		var d_ = context.Operators.SelectManyOrNull<Observation, Observation>(b_, c_);
		object e_(Observation @this)
		{
			var ah_ = FHIRHelpers_4_3_000.ToValue(@this?.Effective);
			var ai_ = QICoreCommon_2_0_000.toInterval(ah_);
			var aj_ = context.Operators.Start(ai_);

			return aj_;
		};
		var f_ = context.Operators.ListSortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		var g_ = context.Operators.LastOfList<Observation>(f_);
		var h_ = new Observation[]
		{
			g_,
		};
		bool? i_(Observation LastPSATest)
		{
			var ak_ = FHIRHelpers_4_3_000.ToValue(LastPSATest?.Value);
			var al_ = context.Operators.Quantity(10m, "ng/mL");
			var am_ = context.Operators.Less((ak_ as CqlQuantity), al_);

			return am_;
		};
		var j_ = context.Operators.SelectOrNull<Observation, bool?>(h_, i_);
		var k_ = context.Operators.SingleOrNull<bool?>(j_);

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
