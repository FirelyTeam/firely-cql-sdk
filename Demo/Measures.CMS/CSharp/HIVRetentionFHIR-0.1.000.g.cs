using System;
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
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
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
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
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
		__Annual_Wellness_Visit?.Value;

	private CqlValueSet Face_to_Face_Interaction_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048", null);

    [CqlDeclaration("Face-to-Face Interaction")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1048")]
	public CqlValueSet Face_to_Face_Interaction() => 
		__Face_to_Face_Interaction?.Value;

	private CqlValueSet HIV_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003", null);

    [CqlDeclaration("HIV")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1003")]
	public CqlValueSet HIV() => 
		__HIV?.Value;

	private CqlValueSet HIV_Viral_Load_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002", null);

    [CqlDeclaration("HIV Viral Load")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.120.12.1002")]
	public CqlValueSet HIV_Viral_Load() => 
		__HIV_Viral_Load?.Value;

	private CqlValueSet Home_Healthcare_Services_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016", null);

    [CqlDeclaration("Home Healthcare Services")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1016")]
	public CqlValueSet Home_Healthcare_Services() => 
		__Home_Healthcare_Services?.Value;

	private CqlValueSet Office_Visit_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlDeclaration("Office Visit")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001")]
	public CqlValueSet Office_Visit() => 
		__Office_Visit?.Value;

	private CqlValueSet Outpatient_Consultation_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008", null);

    [CqlDeclaration("Outpatient Consultation")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1008")]
	public CqlValueSet Outpatient_Consultation() => 
		__Outpatient_Consultation?.Value;

	private CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025", null);

    [CqlDeclaration("Preventive Care Services Established Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1025")]
	public CqlValueSet Preventive_Care_Services_Established_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Established_Office_Visit__18_and_Up?.Value;

	private CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023", null);

    [CqlDeclaration("Preventive Care Services Initial Office Visit, 18 and Up")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1023")]
	public CqlValueSet Preventive_Care_Services_Initial_Office_Visit__18_and_Up() => 
		__Preventive_Care_Services_Initial_Office_Visit__18_and_Up?.Value;

	private CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022", null);

    [CqlDeclaration("Preventive Care Services, Initial Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1022")]
	public CqlValueSet Preventive_Care_Services__Initial_Office_Visit__0_to_17() => 
		__Preventive_Care_Services__Initial_Office_Visit__0_to_17?.Value;

	private CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024", null);

    [CqlDeclaration("Preventive Care, Established Office Visit, 0 to 17")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1024")]
	public CqlValueSet Preventive_Care__Established_Office_Visit__0_to_17() => 
		__Preventive_Care__Established_Office_Visit__0_to_17?.Value;

	private CqlValueSet Telephone_Visits_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080", null);

    [CqlDeclaration("Telephone Visits")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1080")]
	public CqlValueSet Telephone_Visits() => 
		__Telephone_Visits?.Value;

	private CqlValueSet Preventive_Care_Services_Other_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150", null);

    [CqlDeclaration("Preventive Care Services Other")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.11.1150")]
	public CqlValueSet Preventive_Care_Services_Other() => 
		__Preventive_Care_Services_Other?.Value;

	private CqlCode[] CPT_Value()
	{
		CqlCode[] a_ = /* ARR2 */ new CqlCode[0]
;

		return a_;
	}

    [CqlDeclaration("CPT")]
	public CqlCode[] CPT() => 
		__CPT?.Value;

	private CqlInterval<CqlDateTime> Measurement_Period_Value()
	{
		CqlDateTime a_ = context?.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		CqlDateTime b_ = context?.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		CqlInterval<CqlDateTime> c_ = context?.Operators.Interval(a_, b_, true, false);
		object d_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", c_);

		return (CqlInterval<CqlDateTime>)d_;
	}

    [CqlDeclaration("Measurement Period")]
	public CqlInterval<CqlDateTime> Measurement_Period() => 
		__Measurement_Period?.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context?.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context?.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient?.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer?.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Value()
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

				return (l_ as DomainResource)?.Extension;
			}
			else
			{
				return null;
			}
		};
		bool? b_(Extension @this)
		{
			string m_ = @this.Url;
			FhirUri n_ = context?.Operators.Convert<FhirUri>(m_);
			string o_ = FHIRHelpers_4_3_000.ToString(n_);
			bool? p_ = context?.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return p_;
		};
		IEnumerable<Extension> c_ = context?.Operators.Where<Extension>((IEnumerable<Extension>)a_(), b_);
		Extension d_ = context?.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = /* ARR1 */ [
			d_,
		];
		(IEnumerable<CqlCode> codes, string display)? f_(Extension E)
		{
			bool? q_(Extension @this)
			{
				string am_ = @this.Url;
				FhirUri an_ = context?.Operators.Convert<FhirUri>(am_);
				string ao_ = FHIRHelpers_4_3_000.ToString(an_);
				bool? ap_ = context?.Operators.Equal(ao_, "ombCategory");

				return ap_;
			};
			IEnumerable<Extension> r_ = context?.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element)?.Extension)
					: null), q_);
			DataType s_(Extension @this)
			{
				DataType aq_ = @this.Value;

				return aq_;
			};
			IEnumerable<DataType> t_ = context?.Operators.Select<Extension, DataType>(r_, s_);
			DataType u_ = context?.Operators.SingletonFrom<DataType>(t_);
			Coding v_ = context?.Operators.Convert<Coding>(u_);
			CqlCode w_ = FHIRHelpers_4_3_000.ToCode(v_);
			CqlCode[] x_ = /* ARR1 */ [
				w_,
			];
			bool? y_(Extension @this)
			{
				string ar_ = @this.Url;
				FhirUri as_ = context?.Operators.Convert<FhirUri>(ar_);
				string at_ = FHIRHelpers_4_3_000.ToString(as_);
				bool? au_ = context?.Operators.Equal(at_, "detailed");

				return au_;
			};
			IEnumerable<Extension> z_ = context?.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element)?.Extension)
					: null), y_);
			DataType aa_(Extension @this)
			{
				DataType av_ = @this.Value;

				return av_;
			};
			IEnumerable<DataType> ab_ = context?.Operators.Select<Extension, DataType>(z_, aa_);
			CqlCode ac_(DataType @this)
			{
				Coding aw_ = context?.Operators.Convert<Coding>(@this);
				CqlCode ax_ = FHIRHelpers_4_3_000.ToCode(aw_);

				return ax_;
			};
			IEnumerable<CqlCode> ad_ = context?.Operators.Select<DataType, CqlCode>(ab_, ac_);
			IEnumerable<CqlCode> ae_ = context?.Operators.Union<CqlCode>((x_ as IEnumerable<CqlCode>), ad_);
			bool? af_(Extension @this)
			{
				string ay_ = @this.Url;
				FhirUri az_ = context?.Operators.Convert<FhirUri>(ay_);
				string ba_ = FHIRHelpers_4_3_000.ToString(az_);
				bool? bb_ = context?.Operators.Equal(ba_, "text");

				return bb_;
			};
			IEnumerable<Extension> ag_ = context?.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element)?.Extension)
					: null), af_);
			DataType ah_(Extension @this)
			{
				DataType bc_ = @this.Value;

				return bc_;
			};
			IEnumerable<DataType> ai_ = context?.Operators.Select<Extension, DataType>(ag_, ah_);
			DataType aj_ = context?.Operators.SingletonFrom<DataType>(ai_);
			string ak_ = context?.Operators.Convert<string>(aj_);
			(IEnumerable<CqlCode> codes, string display)? al_ = (ae_, ak_);

			return al_;
		};
		IEnumerable<(IEnumerable<CqlCode> codes, string display)?> g_ = context?.Operators.Select<Extension, (IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
		(IEnumerable<CqlCode> codes, string display)? h_ = context?.Operators.SingletonFrom<(IEnumerable<CqlCode> codes, string display)?>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity?.Value;

	private (IEnumerable<CqlCode> codes, string display)? SDE_Race_Value()
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

				return (l_ as DomainResource)?.Extension;
			}
			else
			{
				return null;
			}
		};
		bool? b_(Extension @this)
		{
			string m_ = @this.Url;
			FhirUri n_ = context?.Operators.Convert<FhirUri>(m_);
			string o_ = FHIRHelpers_4_3_000.ToString(n_);
			bool? p_ = context?.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return p_;
		};
		IEnumerable<Extension> c_ = context?.Operators.Where<Extension>((IEnumerable<Extension>)a_(), b_);
		Extension d_ = context?.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = /* ARR1 */ [
			d_,
		];
		(IEnumerable<CqlCode> codes, string display)? f_(Extension R)
		{
			bool? q_(Extension @this)
			{
				string ak_ = @this.Url;
				FhirUri al_ = context?.Operators.Convert<FhirUri>(ak_);
				string am_ = FHIRHelpers_4_3_000.ToString(al_);
				bool? an_ = context?.Operators.Equal(am_, "ombCategory");

				return an_;
			};
			IEnumerable<Extension> r_ = context?.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element)?.Extension)
					: null), q_);
			DataType s_(Extension @this)
			{
				DataType ao_ = @this.Value;

				return ao_;
			};
			IEnumerable<DataType> t_ = context?.Operators.Select<Extension, DataType>(r_, s_);
			CqlCode u_(DataType @this)
			{
				Coding ap_ = context?.Operators.Convert<Coding>(@this);
				CqlCode aq_ = FHIRHelpers_4_3_000.ToCode(ap_);

				return aq_;
			};
			IEnumerable<CqlCode> v_ = context?.Operators.Select<DataType, CqlCode>(t_, u_);
			bool? w_(Extension @this)
			{
				string ar_ = @this.Url;
				FhirUri as_ = context?.Operators.Convert<FhirUri>(ar_);
				string at_ = FHIRHelpers_4_3_000.ToString(as_);
				bool? au_ = context?.Operators.Equal(at_, "detailed");

				return au_;
			};
			IEnumerable<Extension> x_ = context?.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element)?.Extension)
					: null), w_);
			DataType y_(Extension @this)
			{
				DataType av_ = @this.Value;

				return av_;
			};
			IEnumerable<DataType> z_ = context?.Operators.Select<Extension, DataType>(x_, y_);
			CqlCode aa_(DataType @this)
			{
				Coding aw_ = context?.Operators.Convert<Coding>(@this);
				CqlCode ax_ = FHIRHelpers_4_3_000.ToCode(aw_);

				return ax_;
			};
			IEnumerable<CqlCode> ab_ = context?.Operators.Select<DataType, CqlCode>(z_, aa_);
			IEnumerable<CqlCode> ac_ = context?.Operators.Union<CqlCode>(v_, ab_);
			bool? ad_(Extension @this)
			{
				string ay_ = @this.Url;
				FhirUri az_ = context?.Operators.Convert<FhirUri>(ay_);
				string ba_ = FHIRHelpers_4_3_000.ToString(az_);
				bool? bb_ = context?.Operators.Equal(ba_, "text");

				return bb_;
			};
			IEnumerable<Extension> ae_ = context?.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element)?.Extension)
					: null), ad_);
			DataType af_(Extension @this)
			{
				DataType bc_ = @this.Value;

				return bc_;
			};
			IEnumerable<DataType> ag_ = context?.Operators.Select<Extension, DataType>(ae_, af_);
			DataType ah_ = context?.Operators.SingletonFrom<DataType>(ag_);
			string ai_ = context?.Operators.Convert<string>(ah_);
			(IEnumerable<CqlCode> codes, string display)? aj_ = (ac_, ai_);

			return aj_;
		};
		IEnumerable<(IEnumerable<CqlCode> codes, string display)?> g_ = context?.Operators.Select<Extension, (IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
		(IEnumerable<CqlCode> codes, string display)? h_ = context?.Operators.SingletonFrom<(IEnumerable<CqlCode> codes, string display)?>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race?.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_ = SupplementalDataElements_3_4_000.SDE_Sex();

		return a_;
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex?.Value;

	private bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.HIV();
		IEnumerable<Condition> b_ = context?.Operators.RetrieveByValueSet<Condition>(a_, null);
		bool? c_(Condition HIVDx)
		{
			CqlInterval<CqlDateTime> f_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDx);
			CqlDateTime g_ = context?.Operators.Start(f_);
			CqlInterval<CqlDateTime> h_ = this.Measurement_Period();
			CqlDateTime i_ = context?.Operators.Start(h_);
			CqlQuantity j_ = context?.Operators.Quantity(240m, "days");
			CqlDateTime k_ = context?.Operators.Add(i_, j_);
			CqlDate l_ = context?.Operators.DateFrom(k_);
			CqlDateTime m_ = context?.Operators.ConvertDateToDateTime(l_);
			bool? n_ = context?.Operators.SameOrBefore(g_, m_, null);
			bool? o_ = QICoreCommon_2_0_000.isActive(HIVDx);
			bool? p_ = context?.Operators.And(n_, o_);

			return p_;
		};
		IEnumerable<Condition> d_ = context?.Operators.Where<Condition>(b_, c_);
		bool? e_ = context?.Operators.Exists<Condition>(d_);

		return e_;
	}

    [CqlDeclaration("Has Active HIV Diagnosis Starts On or Before First 240 Days of Measurement Period")]
	public bool? Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period() => 
		__Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period?.Value;

	private bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> d_ = context?.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context?.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> g_ = context?.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Face_to_Face_Interaction();
		IEnumerable<Encounter> i_ = context?.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context?.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context?.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> m_ = context?.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> o_ = context?.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context?.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context?.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> s_ = context?.Operators.RetrieveByValueSet<Encounter>(r_, null);
		CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> u_ = context?.Operators.RetrieveByValueSet<Encounter>(t_, null);
		IEnumerable<Encounter> v_ = context?.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context?.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> y_ = context?.Operators.RetrieveByValueSet<Encounter>(x_, null);
		CqlValueSet z_ = this.Telephone_Visits();
		IEnumerable<Encounter> aa_ = context?.Operators.RetrieveByValueSet<Encounter>(z_, null);
		IEnumerable<Encounter> ab_ = context?.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context?.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care_Services_Other();
		IEnumerable<Encounter> ae_ = context?.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		IEnumerable<Encounter> af_ = context?.Operators.Union<Encounter>(ac_, ae_);
		bool? ag_(Encounter QualifyingEncounter)
		{
			CqlInterval<CqlDateTime> aj_ = this.Measurement_Period();
			CqlDateTime ak_ = context?.Operators.Start(aj_);
			CqlDateTime am_ = context?.Operators.Start(aj_);
			CqlQuantity an_ = context?.Operators.Quantity(240m, "days");
			CqlDateTime ao_ = context?.Operators.Add(am_, an_);
			CqlInterval<CqlDateTime> ap_ = context?.Operators.Interval(ak_, ao_, true, true);
			Period aq_ = QualifyingEncounter.Period;
			CqlInterval<CqlDateTime> ar_ = FHIRHelpers_4_3_000.ToInterval(aq_);
			bool? as_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, "day");

			return as_;
		};
		IEnumerable<Encounter> ah_ = context?.Operators.Where<Encounter>(af_, ag_);
		bool? ai_ = context?.Operators.Exists<Encounter>(ah_);

		return ai_;
	}

    [CqlDeclaration("Has Qualifying Encounter During First 240 Days of Measurement Period")]
	public bool? Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period() => 
		__Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period?.Value;

	private bool? Initial_Population_Value()
	{
		bool? a_ = this.Has_Active_HIV_Diagnosis_Starts_On_or_Before_First_240_Days_of_Measurement_Period();
		bool? b_ = this.Has_Qualifying_Encounter_During_First_240_Days_of_Measurement_Period();
		bool? c_ = context?.Operators.And(a_, b_);

		return c_;
	}

    [CqlDeclaration("Initial Population")]
	public bool? Initial_Population() => 
		__Initial_Population?.Value;

	private bool? Denominator_Value()
	{
		bool? a_ = this.Initial_Population();

		return a_;
	}

    [CqlDeclaration("Denominator")]
	public bool? Denominator() => 
		__Denominator?.Value;

	private IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV_Value()
	{
		CqlValueSet a_ = this.Office_Visit();
		IEnumerable<Encounter> b_ = context?.Operators.RetrieveByValueSet<Encounter>(a_, null);
		CqlValueSet c_ = this.Outpatient_Consultation();
		IEnumerable<Encounter> d_ = context?.Operators.RetrieveByValueSet<Encounter>(c_, null);
		IEnumerable<Encounter> e_ = context?.Operators.Union<Encounter>(b_, d_);
		CqlValueSet f_ = this.Annual_Wellness_Visit();
		IEnumerable<Encounter> g_ = context?.Operators.RetrieveByValueSet<Encounter>(f_, null);
		CqlValueSet h_ = this.Face_to_Face_Interaction();
		IEnumerable<Encounter> i_ = context?.Operators.RetrieveByValueSet<Encounter>(h_, null);
		IEnumerable<Encounter> j_ = context?.Operators.Union<Encounter>(g_, i_);
		IEnumerable<Encounter> k_ = context?.Operators.Union<Encounter>(e_, j_);
		CqlValueSet l_ = this.Home_Healthcare_Services();
		IEnumerable<Encounter> m_ = context?.Operators.RetrieveByValueSet<Encounter>(l_, null);
		CqlValueSet n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		IEnumerable<Encounter> o_ = context?.Operators.RetrieveByValueSet<Encounter>(n_, null);
		IEnumerable<Encounter> p_ = context?.Operators.Union<Encounter>(m_, o_);
		IEnumerable<Encounter> q_ = context?.Operators.Union<Encounter>(k_, p_);
		CqlValueSet r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		IEnumerable<Encounter> s_ = context?.Operators.RetrieveByValueSet<Encounter>(r_, null);
		CqlValueSet t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		IEnumerable<Encounter> u_ = context?.Operators.RetrieveByValueSet<Encounter>(t_, null);
		IEnumerable<Encounter> v_ = context?.Operators.Union<Encounter>(s_, u_);
		IEnumerable<Encounter> w_ = context?.Operators.Union<Encounter>(q_, v_);
		CqlValueSet x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		IEnumerable<Encounter> y_ = context?.Operators.RetrieveByValueSet<Encounter>(x_, null);
		CqlValueSet z_ = this.Telephone_Visits();
		IEnumerable<Encounter> aa_ = context?.Operators.RetrieveByValueSet<Encounter>(z_, null);
		IEnumerable<Encounter> ab_ = context?.Operators.Union<Encounter>(y_, aa_);
		IEnumerable<Encounter> ac_ = context?.Operators.Union<Encounter>(w_, ab_);
		CqlValueSet ad_ = this.Preventive_Care_Services_Other();
		IEnumerable<Encounter> ae_ = context?.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		IEnumerable<Encounter> af_ = context?.Operators.Union<Encounter>(ac_, ae_);
		IEnumerable<Encounter> ag_(Encounter ValidEncounter)
		{
			CqlValueSet ai_ = this.HIV();
			IEnumerable<Condition> aj_ = context?.Operators.RetrieveByValueSet<Condition>(ai_, null);
			bool? ak_(Condition HIVDiagnosis)
			{
				CqlInterval<CqlDateTime> ao_ = this.Measurement_Period();
				Period ap_ = ValidEncounter.Period;
				CqlInterval<CqlDateTime> aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				bool? ar_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, null);
				CqlInterval<CqlDateTime> as_()
				{
					bool az_()
					{
						CqlInterval<CqlDateTime> ba_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDiagnosis);
						CqlDateTime bb_ = context?.Operators.Start(ba_);

						return (bb_ is null);
					};
					if (az_())
					{
						return null;
					}
					else
					{
						CqlInterval<CqlDateTime> bc_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDiagnosis);
						CqlDateTime bd_ = context?.Operators.Start(bc_);
						CqlDateTime bf_ = context?.Operators.Start(bc_);
						CqlInterval<CqlDateTime> bg_ = context?.Operators.Interval(bd_, bf_, true, true);

						return bg_;
					}
				};
				CqlInterval<CqlDateTime> au_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				bool? av_ = context?.Operators.SameOrBefore(as_(), au_, "day");
				bool? aw_ = context?.Operators.And(ar_, av_);
				bool? ax_ = QICoreCommon_2_0_000.isActive(HIVDiagnosis);
				bool? ay_ = context?.Operators.And(aw_, ax_);

				return ay_;
			};
			IEnumerable<Condition> al_ = context?.Operators.Where<Condition>(aj_, ak_);
			Encounter am_(Condition HIVDiagnosis) => 
				ValidEncounter;
			IEnumerable<Encounter> an_ = context?.Operators.Select<Condition, Encounter>(al_, am_);

			return an_;
		};
		IEnumerable<Encounter> ah_ = context?.Operators.SelectMany<Encounter, Encounter>(af_, ag_);

		return ah_;
	}

    [CqlDeclaration("Encounter During Measurement Period With HIV")]
	public IEnumerable<Encounter> Encounter_During_Measurement_Period_With_HIV() => 
		__Encounter_During_Measurement_Period_With_HIV?.Value;

	private bool? Has_HIV_Viral_Load_Test_During_Measurement_Period_Value()
	{
		CqlValueSet a_ = this.HIV_Viral_Load();
		IEnumerable<Observation> b_ = context?.Operators.RetrieveByValueSet<Observation>(a_, null);
		bool? c_(Observation ViralLoadTest)
		{
			CqlInterval<CqlDateTime> f_ = this.Measurement_Period();
			DataType g_ = ViralLoadTest.Effective;
			object h_ = FHIRHelpers_4_3_000.ToValue(g_);
			CqlInterval<CqlDateTime> i_ = QICoreCommon_2_0_000.ToInterval(h_);
			bool? j_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");

			return j_;
		};
		IEnumerable<Observation> d_ = context?.Operators.Where<Observation>(b_, c_);
		bool? e_ = context?.Operators.Exists<Observation>(d_);

		return e_;
	}

    [CqlDeclaration("Has HIV Viral Load Test During Measurement Period")]
	public bool? Has_HIV_Viral_Load_Test_During_Measurement_Period() => 
		__Has_HIV_Viral_Load_Test_During_Measurement_Period?.Value;

	private bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV();
		IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
		{
			CqlValueSet e_ = this.HIV_Viral_Load();
			IEnumerable<Observation> f_ = context?.Operators.RetrieveByValueSet<Observation>(e_, null);
			bool? g_(Observation ViralLoadTest)
			{
				CqlInterval<CqlDateTime> k_ = this.Measurement_Period();
				DataType l_ = ViralLoadTest.Effective;
				object m_ = FHIRHelpers_4_3_000.ToValue(l_);
				CqlInterval<CqlDateTime> n_ = QICoreCommon_2_0_000.ToInterval(m_);
				bool? o_ = context?.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, null);
				object q_ = FHIRHelpers_4_3_000.ToValue(l_);
				CqlInterval<CqlDateTime> r_ = QICoreCommon_2_0_000.ToInterval(q_);
				CqlDateTime s_ = context?.Operators.Start(r_);
				Period t_ = EncounterWithHIV.Period;
				CqlInterval<CqlDateTime> u_ = FHIRHelpers_4_3_000.ToInterval(t_);
				CqlDateTime v_ = context?.Operators.End(u_);
				CqlQuantity w_ = context?.Operators.Quantity(90m, "days");
				CqlDateTime x_ = context?.Operators.Add(v_, w_);
				bool? y_ = context?.Operators.SameOrAfter(s_, x_, "day");
				CqlInterval<CqlDateTime> aa_ = FHIRHelpers_4_3_000.ToInterval(t_);
				CqlDateTime ab_ = context?.Operators.Start(aa_);
				object ad_ = FHIRHelpers_4_3_000.ToValue(l_);
				CqlInterval<CqlDateTime> ae_ = QICoreCommon_2_0_000.ToInterval(ad_);
				CqlDateTime af_ = context?.Operators.End(ae_);
				CqlDateTime ah_ = context?.Operators.Add(af_, w_);
				bool? ai_ = context?.Operators.SameOrAfter(ab_, ah_, "day");
				bool? aj_ = context?.Operators.Or(y_, ai_);
				bool? ak_ = context?.Operators.And(o_, aj_);

				return ak_;
			};
			IEnumerable<Observation> h_ = context?.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation ViralLoadTest) => 
				EncounterWithHIV;
			IEnumerable<Encounter> j_ = context?.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		IEnumerable<Encounter> c_ = context?.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		bool? d_ = context?.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Has One Encounter With HIV and One Viral Load Test At Least 90 Days Apart")]
	public bool? Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart() => 
		__Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart?.Value;

	private bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart_Value()
	{
		IEnumerable<Encounter> a_ = this.Encounter_During_Measurement_Period_With_HIV();
		IEnumerable<Encounter> b_(Encounter EncounterWithHIV)
		{
			IEnumerable<Encounter> e_ = this.Encounter_During_Measurement_Period_With_HIV();
			bool? f_(Encounter AnotherEncounterWithHIV)
			{
				bool? j_ = context?.Operators.Equivalent(EncounterWithHIV, AnotherEncounterWithHIV);
				bool? k_ = context?.Operators.Not(j_);
				Period l_ = AnotherEncounterWithHIV.Period;
				CqlInterval<CqlDateTime> m_ = FHIRHelpers_4_3_000.ToInterval(l_);
				CqlDateTime n_ = context?.Operators.Start(m_);
				Period o_ = EncounterWithHIV.Period;
				CqlInterval<CqlDateTime> p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				CqlDateTime q_ = context?.Operators.End(p_);
				CqlQuantity r_ = context?.Operators.Quantity(90m, "days");
				CqlDateTime s_ = context?.Operators.Add(q_, r_);
				bool? t_ = context?.Operators.SameOrAfter(n_, s_, "day");
				bool? u_ = context?.Operators.And(k_, t_);

				return u_;
			};
			IEnumerable<Encounter> g_ = context?.Operators.Where<Encounter>(e_, f_);
			Encounter h_(Encounter AnotherEncounterWithHIV) => 
				EncounterWithHIV;
			IEnumerable<Encounter> i_ = context?.Operators.Select<Encounter, Encounter>(g_, h_);

			return i_;
		};
		IEnumerable<Encounter> c_ = context?.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		bool? d_ = context?.Operators.Exists<Encounter>(c_);

		return d_;
	}

    [CqlDeclaration("Has Two Encounters With HIV At Least 90 Days Apart")]
	public bool? Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart() => 
		__Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart?.Value;

	private bool? Numerator_Value()
	{
		bool? a_ = this.Has_One_Encounter_With_HIV_and_One_Viral_Load_Test_At_Least_90_Days_Apart();
		bool? b_ = this.Has_Two_Encounters_With_HIV_At_Least_90_Days_Apart();
		bool? c_ = context?.Operators.Or(a_, b_);

		return c_;
	}

    [CqlDeclaration("Numerator")]
	public bool? Numerator() => 
		__Numerator?.Value;

}
