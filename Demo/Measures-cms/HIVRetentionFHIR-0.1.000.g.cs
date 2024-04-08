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
[CqlLibrary("HIVRetentionFHIR", "0.1.000")]
public class HIVRetentionFHIR_0_1_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Annual_Wellness_Visit;
    internal Lazy<CqlValueSet> __Face_to_Face_Interaction;
    internal Lazy<CqlValueSet> __HIV;
    internal Lazy<CqlValueSet> __HIV_Viral_Load;
    internal Lazy<CqlValueSet> __Home_Healthcare_Services;
    internal Lazy<CqlValueSet> __Office_Visit;
    internal Lazy<CqlValueSet> __Outpatient_Consultation;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Established_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Initial_Office_Visit__18_and_Up;
    internal Lazy<CqlValueSet> __Preventive_Care_Services__Initial_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Preventive_Care__Established_Office_Visit__0_to_17;
    internal Lazy<CqlValueSet> __Telephone_Visits;
    internal Lazy<CqlValueSet> __Preventive_Care_Services_Other;
    internal Lazy<CqlCode[]> __CPT;
    internal Lazy<CqlInterval<CqlDateTime>> __Measurement_Period;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;
    internal Lazy<bool?> __Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period;
    internal Lazy<bool?> __Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period;
    internal Lazy<bool?> __Initial_Population;
    internal Lazy<bool?> __Denominator;
    internal Lazy<IEnumerable<Encounter>> __Encounter_During_Measurement_Period_With_HIV;
    internal Lazy<bool?> __Has_HIV_Viral_Load_Test_During_Measurement_Period;
    internal Lazy<bool?> __Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart;
    internal Lazy<bool?> __Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart;
    internal Lazy<bool?> __Numerator;

    #endregion
    public HIVRetentionFHIR_0_1_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        CQMCommon_2_0_000 = new CQMCommon_2_0_000(context);
        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);
        QICoreCommon_2_0_000 = new QICoreCommon_2_0_000(context);
        SupplementalDataElements_3_4_000 = new SupplementalDataElements_3_4_000(context);
        CumulativeMedicationDuration_4_0_000 = new CumulativeMedicationDuration_4_0_000(context);

        __Annual_Wellness_Visit = new Lazy<CqlValueSet>(this.Annual_Wellness_Visit_Value);
        __Face_to_Face_Interaction = new Lazy<CqlValueSet>(this.Face_to_Face_Interaction_Value);
        __HIV = new Lazy<CqlValueSet>(this.HIV_Value);
        __HIV_Viral_Load = new Lazy<CqlValueSet>(this.HIV_Viral_Load_Value);
        __Home_Healthcare_Services = new Lazy<CqlValueSet>(this.Home_Healthcare_Services_Value);
        __Office_Visit = new Lazy<CqlValueSet>(this.Office_Visit_Value);
        __Outpatient_Consultation = new Lazy<CqlValueSet>(this.Outpatient_Consultation_Value);
        __Preventive_Care_Services_Established_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services_Initial_Office_Visit__18_and_Up = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value);
        __Preventive_Care_Services__Initial_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value);
        __Preventive_Care__Established_Office_Visit__0_to_17 = new Lazy<CqlValueSet>(this.Preventive_Care__Established_Office_Visit__0_to_17_Value);
        __Telephone_Visits = new Lazy<CqlValueSet>(this.Telephone_Visits_Value);
        __Preventive_Care_Services_Other = new Lazy<CqlValueSet>(this.Preventive_Care_Services_Other_Value);
        __CPT = new Lazy<CqlCode[]>(this.CPT_Value);
        __Measurement_Period = new Lazy<CqlInterval<CqlDateTime>>(this.Measurement_Period_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Ethnicity = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Race = new Lazy<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
        __Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period = new Lazy<bool?>(this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period_Value);
        __Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period = new Lazy<bool?>(this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Value);
        __Initial_Population = new Lazy<bool?>(this.Initial_Population_Value);
        __Denominator = new Lazy<bool?>(this.Denominator_Value);
        __Encounter_During_Measurement_Period_With_HIV = new Lazy<IEnumerable<Encounter>>(this.Encounter_During_Measurement_Period_With_HIV_Value);
        __Has_HIV_Viral_Load_Test_During_Measurement_Period = new Lazy<bool?>(this.Has_HIV_Viral_Load_Test_During_Measurement_Period_Value);
        __Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart = new Lazy<bool?>(this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart_Value);
        __Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart = new Lazy<bool?>(this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart_Value);
        __Numerator = new Lazy<bool?>(this.Numerator_Value);
    }
    #region Dependencies

    public CQMCommon_2_0_000 CQMCommon_2_0_000 { get; }
    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }
    public QICoreCommon_2_0_000 QICoreCommon_2_0_000 { get; }
    public SupplementalDataElements_3_4_000 SupplementalDataElements_3_4_000 { get; }
    public CumulativeMedicationDuration_4_0_000 CumulativeMedicationDuration_4_0_000 { get; }

    #endregion

	private CqlValueSet Annual_Wellness_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240", null);

    [CqlDeclaration("Annual Wellness Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1240")]
	public CqlValueSet Annual_Wellness_Visit() => 
		__Annual_Wellness_Visit.Value;

	private CqlValueSet Face_to_Face_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public CqlValueSet Face_to_Face_Interaction() => 
		__Face_to_Face_Interaction.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV.Value;

	private CqlValueSet HIV_Viral_Load_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", null);

    [CqlDeclaration("HIV Viral Load")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002")]
	public CqlValueSet HIV_Viral_Load() => 
		__HIV_Viral_Load.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits.Value;

	private CqlValueSet Preventive_Care_Services_Other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);

    [CqlDeclaration("Preventive Care Services Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150")]
	public CqlValueSet Preventive_Care_Services_Other() => 
		__Preventive_Care_Services_Other.Value;

	private CqlCode[] CPT_Value()
	{
		var a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		var a_ = context.Operators.ConvertIntegerToDecimal(default);
		var b_ = context.Operators.DateTime((int?)2025, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var d_ = context.Operators.DateTime((int?)2026, (int?)1, (int?)1, (int?)0, (int?)0, (int?)0, (int?)0, a_);
		var e_ = context.Operators.Interval(b_, d_, true, false);
		var f_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", e_);

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

	private IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		List<Extension> a_()
		{
			bool i_()
			{
				var j_ = this.Patient();
				var k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				var l_ = this.Patient();

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return null;
			};
		};
		bool? b_(Extension @this)
		{
			var m_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return m_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>(a_(), b_);
		var d_ = context.Operators.SingleOrNull<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB f_(Extension E)
		{
			bool? n_(Extension @this)
			{
				var aj_ = context.Operators.Equal(@this?.Url, "ombCategory");

				return aj_;
			};
			var o_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), n_);
			DataType p_(Extension @this) => 
				@this?.Value;
			var q_ = context.Operators.SelectOrNull<Extension, DataType>(o_, p_);
			var r_ = context.Operators.SingleOrNull<DataType>(q_);
			var s_ = context.Operators.Convert<Coding>(r_);
			var t_ = FHIRHelpers_4_3_000.ToCode(s_);
			var u_ = new CqlCode[]
			{
				t_,
			};
			bool? v_(Extension @this)
			{
				var ak_ = context.Operators.Equal(@this?.Url, "detailed");

				return ak_;
			};
			var w_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), v_);
			var y_ = context.Operators.SelectOrNull<Extension, DataType>(w_, p_);
			CqlCode z_(DataType @this)
			{
				var al_ = context.Operators.Convert<Coding>(@this);
				var am_ = FHIRHelpers_4_3_000.ToCode(al_);

				return am_;
			};
			var aa_ = context.Operators.SelectOrNull<DataType, CqlCode>(y_, z_);
			var ab_ = context.Operators.ValueSetUnion((u_ as IEnumerable<CqlCode>), aa_);
			bool? ac_(Extension @this)
			{
				var an_ = context.Operators.Equal(@this?.Url, "text");

				return an_;
			};
			var ad_ = context.Operators.WhereOrNull<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), ac_);
			var af_ = context.Operators.SelectOrNull<Extension, DataType>(ad_, p_);
			var ag_ = context.Operators.SingleOrNull<DataType>(af_);
			var ah_ = context.Operators.Convert<string>(ag_);
			var ai_ = new Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB
			{
				codes = ab_,
				display = ah_,
			};

			return ai_;
		};
		var g_ = context.Operators.SelectOrNull<Extension, Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(e_, f_);
		var h_ = context.Operators.SingleOrNull<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		List<Extension> a_()
		{
			bool i_()
			{
				var j_ = this.Patient();
				var k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				var l_ = this.Patient();

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return null;
			};
		};
		bool? b_(Extension @this)
		{
			var m_ = context.Operators.Equal(@this?.Url, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return m_;
		};
		var c_ = context.Operators.WhereOrNull<Extension>(a_(), b_);
		var d_ = context.Operators.SingleOrNull<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB f_(Extension R)
		{
			bool? n_(Extension @this)
			{
				var ah_ = context.Operators.Equal(@this?.Url, "ombCategory");

				return ah_;
			};
			var o_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), n_);
			DataType p_(Extension @this) => 
				@this?.Value;
			var q_ = context.Operators.SelectOrNull<Extension, DataType>(o_, p_);
			CqlCode r_(DataType @this)
			{
				var ai_ = context.Operators.Convert<Coding>(@this);
				var aj_ = FHIRHelpers_4_3_000.ToCode(ai_);

				return aj_;
			};
			var s_ = context.Operators.SelectOrNull<DataType, CqlCode>(q_, r_);
			bool? t_(Extension @this)
			{
				var ak_ = context.Operators.Equal(@this?.Url, "detailed");

				return ak_;
			};
			var u_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), t_);
			var w_ = context.Operators.SelectOrNull<Extension, DataType>(u_, p_);
			CqlCode x_(DataType @this)
			{
				var al_ = context.Operators.Convert<Coding>(@this);
				var am_ = FHIRHelpers_4_3_000.ToCode(al_);

				return am_;
			};
			var y_ = context.Operators.SelectOrNull<DataType, CqlCode>(w_, x_);
			var z_ = context.Operators.ValueSetUnion(s_, y_);
			bool? aa_(Extension @this)
			{
				var an_ = context.Operators.Equal(@this?.Url, "text");

				return an_;
			};
			var ab_ = context.Operators.WhereOrNull<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), aa_);
			var ad_ = context.Operators.SelectOrNull<Extension, DataType>(ab_, p_);
			var ae_ = context.Operators.SingleOrNull<DataType>(ad_);
			var af_ = context.Operators.Convert<string>(ae_);
			var ag_ = new Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB
			{
				codes = z_,
				display = af_,
			};

			return ag_;
		};
		var g_ = context.Operators.SelectOrNull<Extension, Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(e_, f_);
		var h_ = context.Operators.SingleOrNull<Tuples.Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(g_);

		return h_;
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

	private bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period_Value()
	{
		var a_ = this.HIV();
		var b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition HIVDx)
		{
			var f_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDx);
			var g_ = context.Operators.Start(f_);
			var h_ = this.Measurement_Period();
			var i_ = context.Operators.Start(h_);
			var j_ = context.Operators.Quantity(240m, "days");
			var k_ = context.Operators.Add(i_, j_);
			var l_ = context.Operators.DateFrom(k_);
			var m_ = context.Operators.ConvertDateToDateTime(l_);
			var n_ = context.Operators.SameOrBefore(g_, m_, null);
			var o_ = QICoreCommon_2_0_000.isActive(HIVDx);
			var p_ = context.Operators.And(n_, o_);

			return p_;
		};
		var d_ = context.Operators.WhereOrNull<Condition>(b_, c_);
		var e_ = context.Operators.ExistsInList<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
	public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period() => 
		__Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period.Value;

	private bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Outpatient_Consultation();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Annual_Wellness_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Face_to_Face_Interaction();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Home_Healthcare_Services();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		var x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = this.Telephone_Visits();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		var ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		var ad_ = this.Preventive_Care_Services_Other();
		var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = context.Operators.ListUnion<Encounter>(ac_, ae_);
		bool? ag_(Encounter QualifyingEncounter)
		{
			var aj_ = this.Measurement_Period();
			var ak_ = context.Operators.Start(aj_);
			var am_ = context.Operators.Start(aj_);
			var an_ = context.Operators.Quantity(240m, "days");
			var ao_ = context.Operators.Add(am_, an_);
			var ap_ = context.Operators.Interval(ak_, ao_, true, true);
			var aq_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
			var ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, aq_, "day");

			return ar_;
		};
		var ah_ = context.Operators.WhereOrNull<Encounter>(af_, ag_);
		var ai_ = context.Operators.ExistsInList<Encounter>(ah_);

		return ai_;
	}

    [CqlDeclaration("Has Qualifying Encounter During First 240 Days of Measurement Period")]
	public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period() => 
		__Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		var a_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period();
		var b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period();
		var c_ = context.Operators.And(a_, b_);

		return c_;
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

	private IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV_Value()
	{
		var a_ = this.Office_Visit();
		var b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		var c_ = this.Outpatient_Consultation();
		var d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		var e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		var f_ = this.Annual_Wellness_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Face_to_Face_Interaction();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		var k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		var l_ = this.Home_Healthcare_Services();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		var q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		var r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		var w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		var x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = this.Telephone_Visits();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		var ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		var ad_ = this.Preventive_Care_Services_Other();
		var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = context.Operators.ListUnion<Encounter>(ac_, ae_);
		IEnumerable<Encounter> ag_(Encounter ValidEncounter)
		{
			var ai_ = this.HIV();
			var aj_ = context.Operators.RetrieveByValueSet<Condition>(ai_, null);
			bool? ak_(Condition HIVDiagnosis)
			{
				var ao_ = this.Measurement_Period();
				var ap_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
				var aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ap_, null);
				CqlInterval<CqlDateTime> ar_()
				{
					bool ax_()
					{
						var ay_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDiagnosis);
						var az_ = context.Operators.Start(ay_);

						return (az_ is null);
					};
					if (ax_())
					{
						return null;
					}
					else
					{
						var ba_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDiagnosis);
						var bb_ = context.Operators.Start(ba_);
						var bd_ = context.Operators.Start(ba_);
						var be_ = context.Operators.Interval(bb_, bd_, true, true);

						return be_;
					};
				};
				var at_ = context.Operators.IntervalSameOrBefore(ar_(), ap_, "day");
				var au_ = context.Operators.And(aq_, at_);
				var av_ = QICoreCommon_2_0_000.isActive(HIVDiagnosis);
				var aw_ = context.Operators.And(au_, av_);

				return aw_;
			};
			var al_ = context.Operators.WhereOrNull<Condition>(aj_, ak_);
			Encounter am_(Condition HIVDiagnosis) => 
				ValidEncounter;
			var an_ = context.Operators.SelectOrNull<Condition, Encounter>(al_, am_);

			return an_;
		};
		var ah_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(af_, ag_);

		return ah_;
	}

    [CqlDeclaration("Encounter During Measurement Period With HIV")]
	public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV() => 
		__Encounter_During_Measurement_Period_With_HIV.Value;

	private bool? Has_HIV_Viral_Load_Test_During_Measurement_Period_Value()
	{
		var a_ = this.HIV_Viral_Load();
		var b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation ViralLoadTest)
		{
			var f_ = this.Measurement_Period();
			var g_ = FHIRHelpers_4_3_000.ToValue(ViralLoadTest?.Effective);
			var h_ = QICoreCommon_2_0_000.ToInterval(g_);
			var i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");

			return i_;
		};
		var d_ = context.Operators.WhereOrNull<Observation>(b_, c_);
		var e_ = context.Operators.ExistsInList<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Has HIV Viral Load Test During Measurement Period")]
	public bool? Has_HIV_Viral_Load_Test_During_Measurement_Period() => 
		__Has_HIV_Viral_Load_Test_During_Measurement_Period.Value;

	private bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart_Value()
	{
		var a_ = this.Encounter_During_Measurement_Period_With_HIV();
		IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
		{
			var e_ = this.HIV_Viral_Load();
			var f_ = context.Operators.RetrieveByValueSet<Observation>(e_, null);
			bool? g_(Observation ViralLoadTest)
			{
				var k_ = this.Measurement_Period();
				var l_ = FHIRHelpers_4_3_000.ToValue(ViralLoadTest?.Effective);
				var m_ = QICoreCommon_2_0_000.ToInterval(l_);
				var n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, null);
				var p_ = QICoreCommon_2_0_000.ToInterval(l_);
				var q_ = context.Operators.Start(p_);
				var r_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithHIV?.Period);
				var s_ = context.Operators.End(r_);
				var t_ = context.Operators.Quantity(90m, "days");
				var u_ = context.Operators.Add(s_, t_);
				var v_ = context.Operators.SameOrAfter(q_, u_, "day");
				var x_ = context.Operators.Start(r_);
				var z_ = QICoreCommon_2_0_000.ToInterval(l_);
				var aa_ = context.Operators.End(z_);
				var ac_ = context.Operators.Add(aa_, t_);
				var ad_ = context.Operators.SameOrAfter(x_, ac_, "day");
				var ae_ = context.Operators.Or(v_, ad_);
				var af_ = context.Operators.And(n_, ae_);

				return af_;
			};
			var h_ = context.Operators.WhereOrNull<Observation>(f_, g_);
			Encounter i_(Observation ViralLoadTest) => 
				EncounterWithHIV;
			var j_ = context.Operators.SelectOrNull<Observation, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);
		var d_ = context.Operators.ExistsInList<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
	public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart() => 
		__Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart.Value;

	private bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart_Value()
	{
		var a_ = this.Encounter_During_Measurement_Period_With_HIV();
		IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
		{
			var e_ = this.Encounter_During_Measurement_Period_With_HIV();
			bool? f_(Encounter AnotherEncounterWithHIV)
			{
				var j_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
				var k_ = context.Operators.Not(j_);
				var l_ = FHIRHelpers_4_3_000.ToInterval(AnotherEncounterWithHIV?.Period);
				var m_ = context.Operators.Start(l_);
				var n_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithHIV?.Period);
				var o_ = context.Operators.End(n_);
				var p_ = context.Operators.Quantity(90m, "days");
				var q_ = context.Operators.Add(o_, p_);
				var r_ = context.Operators.SameOrAfter(m_, q_, "day");
				var s_ = context.Operators.And(k_, r_);

				return s_;
			};
			var g_ = context.Operators.WhereOrNull<Encounter>(e_, f_);
			Encounter h_(Encounter AnotherEncounterWithHIV) => 
				EncounterWithHIV;
			var i_ = context.Operators.SelectOrNull<Encounter, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectManyOrNull<Encounter, Encounter>(a_, b_);
		var d_ = context.Operators.ExistsInList<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Has Two Encounters With HIV At Least 90 Days Apart")]
	public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart() => 
		__Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart.Value;

	private bool? Numerator_Value()
	{
		var a_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart();
		var b_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart();
		var c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
