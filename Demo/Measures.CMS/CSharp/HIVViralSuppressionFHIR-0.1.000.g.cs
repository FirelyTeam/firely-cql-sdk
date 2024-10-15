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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.5.0")]
[CqlLibrary("HIVViralSuppressionFHIR", "0.1.000")]
public partial class HIVViralSuppressionFHIR_0_1_000 : ILibrary, ISingleton<HIVViralSuppressionFHIR_0_1_000>
{
    private HIVViralSuppressionFHIR_0_1_000() {}

    public static HIVViralSuppressionFHIR_0_1_000 Instance { get; } = new();

    #region Library Members
    public string Name => "HIVViralSuppressionFHIR";
    public string Version => "0.1.000";
    public ILibrary[] Dependencies => [CQMCommon_2_0_000.Instance, FHIRHelpers_4_3_000.Instance, QICoreCommon_2_0_000.Instance, SupplementalDataElements_3_4_000.Instance];
    #endregion Library Members

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", default);


    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public CqlValueSet Face_to_Face_Interaction(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", default);


    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", default);


    [CqlDeclaration("HIV Viral Load")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002")]
	public CqlValueSet HIV_Viral_Load(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", default);


    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", default);


    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", default);


    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", default);


    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", default);


    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", default);


    [CqlDeclaration("Preventive Care Services Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030")]
	public CqlValueSet Preventive_Care_Services_Other(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1030", default);


    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", default);


    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", default);


    [CqlDeclaration("Telehealth Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031")]
	public CqlValueSet Telehealth_Services(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1031", default);


    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits(CqlContext context) => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", default);


    [CqlDeclaration("Below threshold level (qualifier value)")]
	public CqlCode Below_threshold_level__qualifier_value_(CqlContext context) => 
		new CqlCode("260988000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("Not detected (qualifier value)")]
	public CqlCode Not_detected__qualifier_value_(CqlContext context) => 
		new CqlCode("260415000", "http://snomed.info/sct", default, default);


    [CqlDeclaration("SNOMEDCT")]
	public CqlCode[] SNOMEDCT(CqlContext context)
	{
		CqlCode[] a_ = [
			new CqlCode("260988000", "http://snomed.info/sct", default, default),
			new CqlCode("260415000", "http://snomed.info/sct", default, default),
		];

		return a_;
	}


    [CqlDeclaration("CPT")]
	public CqlCode[] CPT(CqlContext context)
	{
		CqlCode[] a_ = []
;

		return a_;
	}


    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HIVViralSuppressionFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}


    [CqlDeclaration("Patient")]
	public Patient Patient(CqlContext context)
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}


    [CqlDeclaration("Has Active HIV Diagnosis Before or in First 90 Days of Measurement Period")]
	public bool? Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.HIV(context);
		IEnumerable<Condition> b_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
		bool? c_(Condition HIVDx)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.Instance.ToPrevalenceInterval(context, HIVDx);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period(context);
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlQuantity j_ = context.Operators.Quantity(90m, "days");
			CqlDateTime k_ = context.Operators.Add(i_, j_);
			bool? l_ = context.Operators.Before(g_, k_, "day");

			return l_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}


    [CqlDeclaration("Has Qualifying Encounter During First 240 Days of Measurement Period")]
	public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.Office_Visit(context);
		IEnumerable<Encounter> b_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet c_ = this.Outpatient_Consultation(context);
		IEnumerable<Encounter> d_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, c_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> e_ = context.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Annual_Wellness_Visit(context);
		IEnumerable<Encounter> g_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, f_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet h_ = this.Face_to_Face_Interaction(context);
		IEnumerable<Encounter> i_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, h_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> j_ = context.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Home_Healthcare_Services(context);
		IEnumerable<Encounter> m_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, l_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> o_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, n_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> p_ = context.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up(context);
		IEnumerable<Encounter> s_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, r_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> u_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, t_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> v_ = context.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17(context);
		IEnumerable<Encounter> y_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, x_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		CqlValueSet z_ = this.Telephone_Visits(context);
		IEnumerable<Encounter> aa_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, z_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> ab_ = context.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care_Services_Other(context);
		IEnumerable<Encounter> ae_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, ad_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
		IEnumerable<Encounter> af_ = context.Operators.Union<Encounter>(ac_, ae_);
		bool? ag_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> aj_ = this.Measurement_Period(context);
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlDateTime am_ = context.Operators.Start(aj_);
			CqlQuantity an_ = context.Operators.Quantity(240m, "days");
			CqlDateTime ao_ = context.Operators.Add(am_, an_);
			CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, ao_, true, true);
			Period aq_ = QualifyingEncounter?.Period;
			CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, aq_);
			bool? as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, "day");

			return as_;
		};
		IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
		bool? ai_ = context.Operators.Exists<Encounter>(ah_);

		return ai_;
	}


    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population(CqlContext context)
	{
		bool? a_ = this.Has_Active_HIV_Diagnosis_Before_or_in_First_90_Days_of_Measurement_Period(context);
		bool? b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period(context);
		bool? c_ = context.Operators.And(a_, b_);

		return c_;
	}


    [CqlDeclaration("Denominator")]
	public bool? Denominator(CqlContext context)
	{
		bool? a_ = this.Initial_Population(context);

		return a_;
	}


    [CqlDeclaration("SDE Ethnicity")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Ethnicity(context);

		return a_;
	}


    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
	{
		IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.Instance.SDE_Payer(context);

		return a_;
	}


    [CqlDeclaration("SDE Race")]
	public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
	{
		(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? a_ = SupplementalDataElements_3_4_000.Instance.SDE_Race(context);

		return a_;
	}


    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex(CqlContext context)
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.Instance.SDE_Sex(context);

		return a_;
	}


    [CqlDeclaration("Most Recent Viral Load Test During Measurement Period")]
	public Observation Most_Recent_Viral_Load_Test_During_Measurement_Period(CqlContext context)
	{
		CqlValueSet a_ = this.HIV_Viral_Load(context);
		IEnumerable<Observation> b_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
		bool? c_(Observation ViralLoad)
		{
			object h_()
			{
				bool l_()
				{
					DataType o_ = ViralLoad?.Effective;
					object p_ = FHIRHelpers_4_3_000.Instance.ToValue(context, o_);
					bool q_ = p_ is CqlDateTime;

					return q_;
				};
				bool m_()
				{
					DataType r_ = ViralLoad?.Effective;
					object s_ = FHIRHelpers_4_3_000.Instance.ToValue(context, r_);
					bool t_ = s_ is CqlInterval<CqlDateTime>;

					return t_;
				};
				bool n_()
				{
					DataType u_ = ViralLoad?.Effective;
					object v_ = FHIRHelpers_4_3_000.Instance.ToValue(context, u_);
					bool w_ = v_ is CqlDateTime;

					return w_;
				};
				if (l_())
				{
					DataType x_ = ViralLoad?.Effective;
					object y_ = FHIRHelpers_4_3_000.Instance.ToValue(context, x_);

					return (y_ as CqlDateTime) as object;
				}
				else if (m_())
				{
					DataType z_ = ViralLoad?.Effective;
					object aa_ = FHIRHelpers_4_3_000.Instance.ToValue(context, z_);

					return (aa_ as CqlInterval<CqlDateTime>) as object;
				}
				else if (n_())
				{
					DataType ab_ = ViralLoad?.Effective;
					object ac_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ab_);

					return (ac_ as CqlDateTime) as object;
				}
				else
				{
					return null;
				}
			};
			CqlDateTime i_ = QICoreCommon_2_0_000.Instance.Latest(context, h_());
			CqlInterval<CqlDateTime> j_ = this.Measurement_Period(context);
			bool? k_ = context.Operators.In<CqlDateTime>(i_, j_, "day");

			return k_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		object e_(Observation @this)
		{
			DataType ad_ = @this?.Effective;
			object ae_ = FHIRHelpers_4_3_000.Instance.ToValue(context, ad_);
			CqlInterval<CqlDateTime> af_ = QICoreCommon_2_0_000.Instance.ToInterval(context, ae_);
			CqlDateTime ag_ = context.Operators.Start(af_);

			return ag_;
		};
		IEnumerable<Observation> f_ = context.Operators.SortBy<Observation>(d_, e_, System.ComponentModel.ListSortDirection.Ascending);
		Observation g_ = context.Operators.Last<Observation>(f_);

		return g_;
	}


    [CqlDeclaration("Numerator")]
	public bool? Numerator(CqlContext context)
	{
		Observation a_ = this.Most_Recent_Viral_Load_Test_During_Measurement_Period(context);
		DataType b_ = a_?.Value;
		object c_ = FHIRHelpers_4_3_000.Instance.ToValue(context, b_);
		CqlQuantity d_ = context.Operators.Quantity(200m, "{copies}/mL");
		bool? e_ = context.Operators.Less(c_ as CqlQuantity, d_);
		DataType g_ = a_?.Value;
		object h_ = FHIRHelpers_4_3_000.Instance.ToValue(context, g_);
		CqlCode i_ = this.Below_threshold_level__qualifier_value_(context);
		CqlConcept j_ = context.Operators.ConvertCodeToConcept(i_);
		bool? k_ = context.Operators.Equivalent(h_ as CqlConcept, j_);
		bool? l_ = context.Operators.Or(e_, k_);
		DataType n_ = a_?.Value;
		object o_ = FHIRHelpers_4_3_000.Instance.ToValue(context, n_);
		CqlCode p_ = this.Not_detected__qualifier_value_(context);
		CqlConcept q_ = context.Operators.ConvertCodeToConcept(p_);
		bool? r_ = context.Operators.Equivalent(o_ as CqlConcept, q_);
		bool? s_ = context.Operators.Or(l_, r_);

		return s_;
	}

}
