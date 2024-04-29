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
    internal Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>> __SDE_Payer;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Ethnicity;
    internal Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> __SDE_Race;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX>>(this.SDE_Payer_Value);
        __SDE_Ethnicity = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Ethnicity_Value);
        __SDE_Race = new Lazy<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(this.SDE_Race_Value);
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
		CqlCode[] a_ = new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer_Value()
	{
		IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GDKRbfOIHhLGieQSVDEMIaDPX> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity_Value()
	{
		List<Extension> a_()
		{
			bool i_()
			{
				Patient j_ = this.Patient();
				bool k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				Patient l_ = this.Patient();

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return null;
			};
		};
		bool? b_(Extension @this)
		{
			FhirUri m_ = context.Operators.Convert<FhirUri>(@this?.Url);
			string n_ = FHIRHelpers_4_3_000.ToString(m_);
			bool? o_ = context.Operators.Equal(n_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return o_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);
		Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = new Extension[]
		{
			d_,
		};
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB f_(Extension E)
		{
			bool? p_(Extension @this)
			{
				FhirUri al_ = context.Operators.Convert<FhirUri>(@this?.Url);
				string am_ = FHIRHelpers_4_3_000.ToString(al_);
				bool? an_ = context.Operators.Equal(am_, "ombCategory");

				return an_;
			};
			IEnumerable<Extension> q_ = context.Operators.Where<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), p_);
			DataType r_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> s_ = context.Operators.Select<Extension, DataType>(q_, r_);
			DataType t_ = context.Operators.SingletonFrom<DataType>(s_);
			Coding u_ = context.Operators.Convert<Coding>(t_);
			CqlCode v_ = FHIRHelpers_4_3_000.ToCode(u_);
			CqlCode[] w_ = new CqlCode[]
			{
				v_,
			};
			bool? x_(Extension @this)
			{
				FhirUri ao_ = context.Operators.Convert<FhirUri>(@this?.Url);
				string ap_ = FHIRHelpers_4_3_000.ToString(ao_);
				bool? aq_ = context.Operators.Equal(ap_, "detailed");

				return aq_;
			};
			IEnumerable<Extension> y_ = context.Operators.Where<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), x_);
			IEnumerable<DataType> aa_ = context.Operators.Select<Extension, DataType>(y_, r_);
			CqlCode ab_(DataType @this)
			{
				Coding ar_ = context.Operators.Convert<Coding>(@this);
				CqlCode as_ = FHIRHelpers_4_3_000.ToCode(ar_);

				return as_;
			};
			IEnumerable<CqlCode> ac_ = context.Operators.Select<DataType, CqlCode>(aa_, ab_);
			IEnumerable<CqlCode> ad_ = context.Operators.ValueSetUnion((w_ as IEnumerable<CqlCode>), ac_);
			bool? ae_(Extension @this)
			{
				FhirUri at_ = context.Operators.Convert<FhirUri>(@this?.Url);
				string au_ = FHIRHelpers_4_3_000.ToString(at_);
				bool? av_ = context.Operators.Equal(au_, "text");

				return av_;
			};
			IEnumerable<Extension> af_ = context.Operators.Where<Extension>(((E is Element)
					? ((E as Element).Extension)
					: null), ae_);
			IEnumerable<DataType> ah_ = context.Operators.Select<Extension, DataType>(af_, r_);
			DataType ai_ = context.Operators.SingletonFrom<DataType>(ah_);
			string aj_ = context.Operators.Convert<string>(ai_);
			Tuple_DMgHTLENEHBHWJISQgKZGZVMB ak_ = new Tuple_DMgHTLENEHBHWJISQgKZGZVMB
			{
				codes = ad_,
				display = aj_,
			};

			return ak_;
		};
		IEnumerable<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> g_ = context.Operators.Select<Extension, Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(e_, f_);
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB h_ = context.Operators.SingletonFrom<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race_Value()
	{
		List<Extension> a_()
		{
			bool i_()
			{
				Patient j_ = this.Patient();
				bool k_ = j_ is DomainResource;

				return k_;
			};
			if (i_())
			{
				Patient l_ = this.Patient();

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return null;
			};
		};
		bool? b_(Extension @this)
		{
			FhirUri m_ = context.Operators.Convert<FhirUri>(@this?.Url);
			string n_ = FHIRHelpers_4_3_000.ToString(m_);
			bool? o_ = context.Operators.Equal(n_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return o_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);
		Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = new Extension[]
		{
			d_,
		};
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB f_(Extension R)
		{
			bool? p_(Extension @this)
			{
				FhirUri aj_ = context.Operators.Convert<FhirUri>(@this?.Url);
				string ak_ = FHIRHelpers_4_3_000.ToString(aj_);
				bool? al_ = context.Operators.Equal(ak_, "ombCategory");

				return al_;
			};
			IEnumerable<Extension> q_ = context.Operators.Where<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), p_);
			DataType r_(Extension @this) => 
				@this?.Value;
			IEnumerable<DataType> s_ = context.Operators.Select<Extension, DataType>(q_, r_);
			CqlCode t_(DataType @this)
			{
				Coding am_ = context.Operators.Convert<Coding>(@this);
				CqlCode an_ = FHIRHelpers_4_3_000.ToCode(am_);

				return an_;
			};
			IEnumerable<CqlCode> u_ = context.Operators.Select<DataType, CqlCode>(s_, t_);
			bool? v_(Extension @this)
			{
				FhirUri ao_ = context.Operators.Convert<FhirUri>(@this?.Url);
				string ap_ = FHIRHelpers_4_3_000.ToString(ao_);
				bool? aq_ = context.Operators.Equal(ap_, "detailed");

				return aq_;
			};
			IEnumerable<Extension> w_ = context.Operators.Where<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), v_);
			IEnumerable<DataType> y_ = context.Operators.Select<Extension, DataType>(w_, r_);
			CqlCode z_(DataType @this)
			{
				Coding ar_ = context.Operators.Convert<Coding>(@this);
				CqlCode as_ = FHIRHelpers_4_3_000.ToCode(ar_);

				return as_;
			};
			IEnumerable<CqlCode> aa_ = context.Operators.Select<DataType, CqlCode>(y_, z_);
			IEnumerable<CqlCode> ab_ = context.Operators.ValueSetUnion(u_, aa_);
			bool? ac_(Extension @this)
			{
				FhirUri at_ = context.Operators.Convert<FhirUri>(@this?.Url);
				string au_ = FHIRHelpers_4_3_000.ToString(at_);
				bool? av_ = context.Operators.Equal(au_, "text");

				return av_;
			};
			IEnumerable<Extension> ad_ = context.Operators.Where<Extension>(((R is Element)
					? ((R as Element).Extension)
					: null), ac_);
			IEnumerable<DataType> af_ = context.Operators.Select<Extension, DataType>(ad_, r_);
			DataType ag_ = context.Operators.SingletonFrom<DataType>(af_);
			string ah_ = context.Operators.Convert<string>(ag_);
			Tuple_DMgHTLENEHBHWJISQgKZGZVMB ai_ = new Tuple_DMgHTLENEHBHWJISQgKZGZVMB
			{
				codes = ab_,
				display = ah_,
			};

			return ai_;
		};
		IEnumerable<Tuple_DMgHTLENEHBHWJISQgKZGZVMB> g_ = context.Operators.Select<Extension, Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(e_, f_);
		Tuple_DMgHTLENEHBHWJISQgKZGZVMB h_ = context.Operators.SingletonFrom<Tuple_DMgHTLENEHBHWJISQgKZGZVMB>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Race")]
	public Tuple_DMgHTLENEHBHWJISQgKZGZVMB SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

	private bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.HIV();
		IEnumerable<Condition> b_ = context.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition HIVDx)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDx);
			CqlDateTime g_ = context.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context.Operators.Start(h_);
			CqlQuantity j_ = context.Operators.Quantity(240m, "days");
			CqlDateTime k_ = context.Operators.Add(i_, j_);
			CqlDate l_ = context.Operators.DateFrom(k_);
			CqlDateTime m_ = context.Operators.ConvertDateToDateTime(l_);
			bool? n_ = context.Operators.SameOrBefore(g_, m_, null);
			bool? o_ = QICoreCommon_2_0_000.isActive(HIVDx);
			bool? p_ = context.Operators.And(n_, o_);

			return p_;
		};
		IEnumerable<Condition> d_ = context.Operators.Where<Condition>(b_, c_);
		bool? e_ = context.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
	public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period() => 
		__Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period.Value;

	private bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Face_to_Face_Interaction();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		IEnumerable<Encounter> v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		CqlValueSet z_ = this.Telephone_Visits();
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		IEnumerable<Encounter> ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care_Services_Other();
		IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		IEnumerable<Encounter> af_ = context.Operators.ListUnion<Encounter>(ac_, ae_);
		bool? ag_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> aj_ = this.Measurement_Period();
			CqlDateTime ak_ = context.Operators.Start(aj_);
			CqlDateTime am_ = context.Operators.Start(aj_);
			CqlQuantity an_ = context.Operators.Quantity(240m, "days");
			CqlDateTime ao_ = context.Operators.Add(am_, an_);
			CqlInterval<CqlDateTime> ap_ = context.Operators.Interval(ak_, ao_, true, true);
			CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_3_000.ToInterval(QualifyingEncounter?.Period);
			bool? ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, aq_, "day");

			return ar_;
		};
		IEnumerable<Encounter> ah_ = context.Operators.Where<Encounter>(af_, ag_);
		bool? ai_ = context.Operators.Exists<Encounter>(ah_);

		return ai_;
	}

    [CqlDeclaration("Has Qualifying Encounter During First 240 Days of Measurement Period")]
	public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period() => 
		__Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period.Value;

	private bool? Initial_Population_Value()
	{
		bool? a_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period();
		bool? b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period();
		bool? c_ = context.Operators.And(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator.Value;

	private IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> d_ = context.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context.Operators.ListUnion<Encounter>(b_, d_);
		CqlValueSet f_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Face_to_Face_Interaction();
		IEnumerable<Encounter> i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context.Operators.ListUnion<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context.Operators.ListUnion<Encounter>(e_, j_);
		CqlValueSet l_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context.Operators.ListUnion<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context.Operators.ListUnion<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		IEnumerable<Encounter> v_ = context.Operators.ListUnion<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context.Operators.ListUnion<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		CqlValueSet z_ = this.Telephone_Visits();
		IEnumerable<Encounter> aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		IEnumerable<Encounter> ab_ = context.Operators.ListUnion<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context.Operators.ListUnion<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care_Services_Other();
		IEnumerable<Encounter> ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		IEnumerable<Encounter> af_ = context.Operators.ListUnion<Encounter>(ac_, ae_);
		IEnumerable<Encounter> ag_(Encounter ValidEncounter)
		{
			CqlValueSet ai_ = this.HIV();
			IEnumerable<Condition> aj_ = context.Operators.RetrieveByValueSet<Condition>(ai_, null);
			bool? ak_(Condition HIVDiagnosis)
			{
				CqlInterval<CqlDateTime> ao_ = this.Measurement_Period();
				CqlInterval<CqlDateTime> ap_ = FHIRHelpers_4_3_000.ToInterval(ValidEncounter?.Period);
				bool? aq_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, ap_, null);
				CqlInterval<CqlDateTime> ar_()
				{
					bool ax_()
					{
						CqlInterval<CqlDateTime> ay_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDiagnosis);
						CqlDateTime az_ = context.Operators.Start(ay_);

						return (az_ is null);
					};
					if (ax_())
					{
						return null;
					}
					else
					{
						CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDiagnosis);
						CqlDateTime bb_ = context.Operators.Start(ba_);
						CqlDateTime bd_ = context.Operators.Start(ba_);
						CqlInterval<CqlDateTime> be_ = context.Operators.Interval(bb_, bd_, true, true);

						return be_;
					};
				};
				bool? at_ = context.Operators.SameOrBefore(ar_(), ap_, "day");
				bool? au_ = context.Operators.And(aq_, at_);
				bool? av_ = QICoreCommon_2_0_000.isActive(HIVDiagnosis);
				bool? aw_ = context.Operators.And(au_, av_);

				return aw_;
			};
			IEnumerable<Condition> al_ = context.Operators.Where<Condition>(aj_, ak_);
			Encounter am_(Condition HIVDiagnosis) => 
				ValidEncounter;
			IEnumerable<Encounter> an_ = context.Operators.Select<Condition, Encounter>(al_, am_);

			return an_;
		};
		IEnumerable<Encounter> ah_ = context.Operators.SelectMany<Encounter, Encounter>(af_, ag_);

		return ah_;
	}

    [CqlDeclaration("Encounter During Measurement Period With HIV")]
	public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV() => 
		__Encounter_During_Measurement_Period_With_HIV.Value;

	private bool? Has_HIV_Viral_Load_Test_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.HIV_Viral_Load();
		IEnumerable<Observation> b_ = context.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation ViralLoadTest)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			object g_ = FHIRHelpers_4_3_000.ToValue(ViralLoadTest?.Effective);
			CqlInterval<CqlDateTime> h_ = QICoreCommon_2_0_000.ToInterval(g_);
			bool? i_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, h_, "day");

			return i_;
		};
		IEnumerable<Observation> d_ = context.Operators.Where<Observation>(b_, c_);
		bool? e_ = context.Operators.Exists<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Has HIV Viral Load Test During Measurement Period")]
	public bool? Has_HIV_Viral_Load_Test_During_Measurement_Period() => 
		__Has_HIV_Viral_Load_Test_During_Measurement_Period.Value;

	private bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV();
		IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
		{
			CqlValueSet e_ = this.HIV_Viral_Load();
			IEnumerable<Observation> f_ = context.Operators.RetrieveByValueSet<Observation>(e_, null);
			bool? g_(Observation ViralLoadTest)
			{
				CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
				object l_ = FHIRHelpers_4_3_000.ToValue(ViralLoadTest?.Effective);
				CqlInterval<CqlDateTime> m_ = QICoreCommon_2_0_000.ToInterval(l_);
				bool? n_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, m_, null);
				CqlInterval<CqlDateTime> p_ = QICoreCommon_2_0_000.ToInterval(l_);
				CqlDateTime q_ = context.Operators.Start(p_);
				CqlInterval<CqlDateTime> r_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithHIV?.Period);
				CqlDateTime s_ = context.Operators.End(r_);
				CqlQuantity t_ = context.Operators.Quantity(90m, "days");
				CqlDateTime u_ = context.Operators.Add(s_, t_);
				bool? v_ = context.Operators.SameOrAfter(q_, u_, "day");
				CqlDateTime x_ = context.Operators.Start(r_);
				CqlInterval<CqlDateTime> z_ = QICoreCommon_2_0_000.ToInterval(l_);
				CqlDateTime aa_ = context.Operators.End(z_);
				CqlDateTime ac_ = context.Operators.Add(aa_, t_);
				bool? ad_ = context.Operators.SameOrAfter(x_, ac_, "day");
				bool? ae_ = context.Operators.Or(v_, ad_);
				bool? af_ = context.Operators.And(n_, ae_);

				return af_;
			};
			IEnumerable<Observation> h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation ViralLoadTest) => 
				EncounterWithHIV;
			IEnumerable<Encounter> j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
	public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart() => 
		__Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart.Value;

	private bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV();
		IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
		{
			IEnumerable<Encounter> e_ = this.Encounter_During_Measurement_Period_With_HIV();
			bool? f_(Encounter AnotherEncounterWithHIV)
			{
				bool? j_ = context.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
				bool? k_ = context.Operators.Not(j_);
				CqlInterval<CqlDateTime> l_ = FHIRHelpers_4_3_000.ToInterval(AnotherEncounterWithHIV?.Period);
				CqlDateTime m_ = context.Operators.Start(l_);
				CqlInterval<CqlDateTime> n_ = FHIRHelpers_4_3_000.ToInterval(EncounterWithHIV?.Period);
				CqlDateTime o_ = context.Operators.End(n_);
				CqlQuantity p_ = context.Operators.Quantity(90m, "days");
				CqlDateTime q_ = context.Operators.Add(o_, p_);
				bool? r_ = context.Operators.SameOrAfter(m_, q_, "day");
				bool? s_ = context.Operators.And(k_, r_);

				return s_;
			};
			IEnumerable<Encounter> g_ = context.Operators.Where<Encounter>(e_, f_);
			Encounter h_(Encounter AnotherEncounterWithHIV) => 
				EncounterWithHIV;
			IEnumerable<Encounter> i_ = context.Operators.Select<Encounter, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		bool? d_ = context.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Has Two Encounters With HIV At Least 90 Days Apart")]
	public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart() => 
		__Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart();
		bool? b_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart();
		bool? c_ = context.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator.Value;

}
