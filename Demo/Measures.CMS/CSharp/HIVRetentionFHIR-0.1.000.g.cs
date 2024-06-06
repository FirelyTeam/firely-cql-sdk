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
    internal Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>> __SDE_Payer;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Ethnicity;
    internal Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR> __SDE_Race;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ>>(this.SDE_Payer_Value);
        __SDE_Ethnicity = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Ethnicity_Value);
        __SDE_Race = new Lazy<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(this.SDE_Race_Value);
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
		var a_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, default);
		var b_ = context.Operators.DateTime(2026, 1, 1, 0, 0, 0, 0, default);
		var c_ = context.Operators.Interval(a_, b_, true, false);
		var d_ = context.ResolveParameter("HIVRetentionFHIR-0.1.000", "Measurement Period", c_);

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

	private IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer_Value()
	{
		var a_ = SupplementalDataElements_3_4_000.SDE_Payer();

		return a_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_GPRWMPNAYaJRiGDFSTLJOPeIJ> SDE_Payer() => 
		__SDE_Payer.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity_Value()
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
			}
		};
		bool? b_(Extension @this)
		{
			var m_ = @this?.Url;
			var n_ = context.Operators.Convert<FhirUri>(m_);
			var o_ = FHIRHelpers_4_3_000.ToString(n_);
			var p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return p_;
		};
		var c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_(), b_);
		var d_ = context.Operators.SingletonFrom<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR f_(Extension E)
		{
			bool? q_(Extension @this)
			{
				var am_ = @this?.Url;
				var an_ = context.Operators.Convert<FhirUri>(am_);
				var ao_ = FHIRHelpers_4_3_000.ToString(an_);
				var ap_ = context.Operators.Equal(ao_, "ombCategory");

				return ap_;
			};
			var r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element).Extension)
					: null), q_);
			DataType s_(Extension @this)
			{
				var aq_ = @this?.Value;

				return aq_;
			};
			var t_ = context.Operators.Select<Extension, DataType>(r_, s_);
			var u_ = context.Operators.SingletonFrom<DataType>(t_);
			var v_ = context.Operators.Convert<Coding>(u_);
			var w_ = FHIRHelpers_4_3_000.ToCode(v_);
			var x_ = new CqlCode[]
			{
				w_,
			};
			bool? y_(Extension @this)
			{
				var ar_ = @this?.Url;
				var as_ = context.Operators.Convert<FhirUri>(ar_);
				var at_ = FHIRHelpers_4_3_000.ToString(as_);
				var au_ = context.Operators.Equal(at_, "detailed");

				return au_;
			};
			var z_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element).Extension)
					: null), y_);
			DataType aa_(Extension @this)
			{
				var av_ = @this?.Value;

				return av_;
			};
			var ab_ = context.Operators.Select<Extension, DataType>(z_, aa_);
			CqlCode ac_(DataType @this)
			{
				var aw_ = context.Operators.Convert<Coding>(@this);
				var ax_ = FHIRHelpers_4_3_000.ToCode(aw_);

				return ax_;
			};
			var ad_ = context.Operators.Select<DataType, CqlCode>(ab_, ac_);
			var ae_ = context.Operators.Union<CqlCode>((x_ as IEnumerable<CqlCode>), ad_);
			bool? af_(Extension @this)
			{
				var ay_ = @this?.Url;
				var az_ = context.Operators.Convert<FhirUri>(ay_);
				var ba_ = FHIRHelpers_4_3_000.ToString(az_);
				var bb_ = context.Operators.Equal(ba_, "text");

				return bb_;
			};
			var ag_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((E is Element)
					? ((E as Element).Extension)
					: null), af_);
			DataType ah_(Extension @this)
			{
				var bc_ = @this?.Value;

				return bc_;
			};
			var ai_ = context.Operators.Select<Extension, DataType>(ag_, ah_);
			var aj_ = context.Operators.SingletonFrom<DataType>(ai_);
			var ak_ = context.Operators.Convert<string>(aj_);
			var al_ = new Tuple_HPcCiDPXQfZTXIORThMLfTQDR
			{
				codes = ae_,
				display = ak_,
			};

			return al_;
		};
		var g_ = context.Operators.Select<Extension, Tuple_HPcCiDPXQfZTXIORThMLfTQDR>((IEnumerable<Extension>)e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private Tuple_HPcCiDPXQfZTXIORThMLfTQDR SDE_Race_Value()
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
			}
		};
		bool? b_(Extension @this)
		{
			var m_ = @this?.Url;
			var n_ = context.Operators.Convert<FhirUri>(m_);
			var o_ = FHIRHelpers_4_3_000.ToString(n_);
			var p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return p_;
		};
		var c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_(), b_);
		var d_ = context.Operators.SingletonFrom<Extension>(c_);
		var e_ = new Extension[]
		{
			d_,
		};
		Tuple_HPcCiDPXQfZTXIORThMLfTQDR f_(Extension R)
		{
			bool? q_(Extension @this)
			{
				var ak_ = @this?.Url;
				var al_ = context.Operators.Convert<FhirUri>(ak_);
				var am_ = FHIRHelpers_4_3_000.ToString(al_);
				var an_ = context.Operators.Equal(am_, "ombCategory");

				return an_;
			};
			var r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element).Extension)
					: null), q_);
			DataType s_(Extension @this)
			{
				var ao_ = @this?.Value;

				return ao_;
			};
			var t_ = context.Operators.Select<Extension, DataType>(r_, s_);
			CqlCode u_(DataType @this)
			{
				var ap_ = context.Operators.Convert<Coding>(@this);
				var aq_ = FHIRHelpers_4_3_000.ToCode(ap_);

				return aq_;
			};
			var v_ = context.Operators.Select<DataType, CqlCode>(t_, u_);
			bool? w_(Extension @this)
			{
				var ar_ = @this?.Url;
				var as_ = context.Operators.Convert<FhirUri>(ar_);
				var at_ = FHIRHelpers_4_3_000.ToString(as_);
				var au_ = context.Operators.Equal(at_, "detailed");

				return au_;
			};
			var x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element).Extension)
					: null), w_);
			DataType y_(Extension @this)
			{
				var av_ = @this?.Value;

				return av_;
			};
			var z_ = context.Operators.Select<Extension, DataType>(x_, y_);
			CqlCode aa_(DataType @this)
			{
				var aw_ = context.Operators.Convert<Coding>(@this);
				var ax_ = FHIRHelpers_4_3_000.ToCode(aw_);

				return ax_;
			};
			var ab_ = context.Operators.Select<DataType, CqlCode>(z_, aa_);
			var ac_ = context.Operators.Union<CqlCode>(v_, ab_);
			bool? ad_(Extension @this)
			{
				var ay_ = @this?.Url;
				var az_ = context.Operators.Convert<FhirUri>(ay_);
				var ba_ = FHIRHelpers_4_3_000.ToString(az_);
				var bb_ = context.Operators.Equal(ba_, "text");

				return bb_;
			};
			var ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)((R is Element)
					? ((R as Element).Extension)
					: null), ad_);
			DataType af_(Extension @this)
			{
				var bc_ = @this?.Value;

				return bc_;
			};
			var ag_ = context.Operators.Select<Extension, DataType>(ae_, af_);
			var ah_ = context.Operators.SingletonFrom<DataType>(ag_);
			var ai_ = context.Operators.Convert<string>(ah_);
			var aj_ = new Tuple_HPcCiDPXQfZTXIORThMLfTQDR
			{
				codes = ac_,
				display = ai_,
			};

			return aj_;
		};
		var g_ = context.Operators.Select<Extension, Tuple_HPcCiDPXQfZTXIORThMLfTQDR>((IEnumerable<Extension>)e_, f_);
		var h_ = context.Operators.SingletonFrom<Tuple_HPcCiDPXQfZTXIORThMLfTQDR>(g_);

		return h_;
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
		var d_ = context.Operators.Where<Condition>(b_, c_);
		var e_ = context.Operators.Exists<Condition>(d_);

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
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Annual_Wellness_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Face_to_Face_Interaction();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Home_Healthcare_Services();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.Union<Encounter>(m_, o_);
		var q_ = context.Operators.Union<Encounter>(k_, p_);
		var r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.Union<Encounter>(s_, u_);
		var w_ = context.Operators.Union<Encounter>(q_, v_);
		var x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = this.Telephone_Visits();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = context.Operators.Union<Encounter>(y_, aa_);
		var ac_ = context.Operators.Union<Encounter>(w_, ab_);
		var ad_ = this.Preventive_Care_Services_Other();
		var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = context.Operators.Union<Encounter>(ac_, ae_);
		bool? ag_(Encounter QualifyingEncounter)
		{
			var aj_ = this.Measurement_Period();
			var ak_ = context.Operators.Start(aj_);
			var am_ = context.Operators.Start(aj_);
			var an_ = context.Operators.Quantity(240m, "days");
			var ao_ = context.Operators.Add(am_, an_);
			var ap_ = context.Operators.Interval(ak_, ao_, true, true);
			var aq_ = QualifyingEncounter?.Period;
			var ar_ = FHIRHelpers_4_3_000.ToInterval(aq_);
			var as_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ap_, ar_, "day");

			return as_;
		};
		var ah_ = context.Operators.Where<Encounter>(af_, ag_);
		var ai_ = context.Operators.Exists<Encounter>(ah_);

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
		var e_ = context.Operators.Union<Encounter>(b_, d_);
		var f_ = this.Annual_Wellness_Visit();
		var g_ = context.Operators.RetrieveByValueSet<Encounter>(f_, null);
		var h_ = this.Face_to_Face_Interaction();
		var i_ = context.Operators.RetrieveByValueSet<Encounter>(h_, null);
		var j_ = context.Operators.Union<Encounter>(g_, i_);
		var k_ = context.Operators.Union<Encounter>(e_, j_);
		var l_ = this.Home_Healthcare_Services();
		var m_ = context.Operators.RetrieveByValueSet<Encounter>(l_, null);
		var n_ = this.Preventive_Care_Services_Established_Office_Visit__18_and_Up();
		var o_ = context.Operators.RetrieveByValueSet<Encounter>(n_, null);
		var p_ = context.Operators.Union<Encounter>(m_, o_);
		var q_ = context.Operators.Union<Encounter>(k_, p_);
		var r_ = this.Preventive_Care_Services_Initial_Office_Visit__18_and_Up();
		var s_ = context.Operators.RetrieveByValueSet<Encounter>(r_, null);
		var t_ = this.Preventive_Care_Services__Initial_Office_Visit__0_to_17();
		var u_ = context.Operators.RetrieveByValueSet<Encounter>(t_, null);
		var v_ = context.Operators.Union<Encounter>(s_, u_);
		var w_ = context.Operators.Union<Encounter>(q_, v_);
		var x_ = this.Preventive_Care__Established_Office_Visit__0_to_17();
		var y_ = context.Operators.RetrieveByValueSet<Encounter>(x_, null);
		var z_ = this.Telephone_Visits();
		var aa_ = context.Operators.RetrieveByValueSet<Encounter>(z_, null);
		var ab_ = context.Operators.Union<Encounter>(y_, aa_);
		var ac_ = context.Operators.Union<Encounter>(w_, ab_);
		var ad_ = this.Preventive_Care_Services_Other();
		var ae_ = context.Operators.RetrieveByValueSet<Encounter>(ad_, null);
		var af_ = context.Operators.Union<Encounter>(ac_, ae_);
		IEnumerable<Encounter> ag_(Encounter ValidEncounter)
		{
			var ai_ = this.HIV();
			var aj_ = context.Operators.RetrieveByValueSet<Condition>(ai_, null);
			bool? ak_(Condition HIVDiagnosis)
			{
				var ao_ = this.Measurement_Period();
				var ap_ = ValidEncounter?.Period;
				var aq_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				var ar_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(ao_, aq_, null);
				CqlInterval<CqlDateTime> as_()
				{
					bool az_()
					{
						var ba_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDiagnosis);
						var bb_ = context.Operators.Start(ba_);

						return (bb_ is null);
					};
					if (az_())
					{
						return null;
					}
					else
					{
						var bc_ = QICoreCommon_2_0_000.prevalenceInterval(HIVDiagnosis);
						var bd_ = context.Operators.Start(bc_);
						var bf_ = context.Operators.Start(bc_);
						var bg_ = context.Operators.Interval(bd_, bf_, true, true);

						return bg_;
					}
				};
				var au_ = FHIRHelpers_4_3_000.ToInterval(ap_);
				var av_ = context.Operators.SameOrBefore(as_(), au_, "day");
				var aw_ = context.Operators.And(ar_, av_);
				var ax_ = QICoreCommon_2_0_000.isActive(HIVDiagnosis);
				var ay_ = context.Operators.And(aw_, ax_);

				return ay_;
			};
			var al_ = context.Operators.Where<Condition>(aj_, ak_);
			Encounter am_(Condition HIVDiagnosis) => 
				ValidEncounter;
			var an_ = context.Operators.Select<Condition, Encounter>(al_, am_);

			return an_;
		};
		var ah_ = context.Operators.SelectMany<Encounter, Encounter>(af_, ag_);

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
			var g_ = ViralLoadTest?.Effective;
			var h_ = FHIRHelpers_4_3_000.ToValue(g_);
			var i_ = QICoreCommon_2_0_000.ToInterval(h_);
			var j_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(f_, i_, "day");

			return j_;
		};
		var d_ = context.Operators.Where<Observation>(b_, c_);
		var e_ = context.Operators.Exists<Observation>(d_);

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
				var l_ = ViralLoadTest?.Effective;
				var m_ = FHIRHelpers_4_3_000.ToValue(l_);
				var n_ = QICoreCommon_2_0_000.ToInterval(m_);
				var o_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(k_, n_, null);
				var q_ = FHIRHelpers_4_3_000.ToValue(l_);
				var r_ = QICoreCommon_2_0_000.ToInterval(q_);
				var s_ = context.Operators.Start(r_);
				var t_ = EncounterWithHIV?.Period;
				var u_ = FHIRHelpers_4_3_000.ToInterval(t_);
				var v_ = context.Operators.End(u_);
				var w_ = context.Operators.Quantity(90m, "days");
				var x_ = context.Operators.Add(v_, w_);
				var y_ = context.Operators.SameOrAfter(s_, x_, "day");
				var aa_ = FHIRHelpers_4_3_000.ToInterval(t_);
				var ab_ = context.Operators.Start(aa_);
				var ad_ = FHIRHelpers_4_3_000.ToValue(l_);
				var ae_ = QICoreCommon_2_0_000.ToInterval(ad_);
				var af_ = context.Operators.End(ae_);
				var ah_ = context.Operators.Add(af_, w_);
				var ai_ = context.Operators.SameOrAfter(ab_, ah_, "day");
				var aj_ = context.Operators.Or(y_, ai_);
				var ak_ = context.Operators.And(o_, aj_);

				return ak_;
			};
			var h_ = context.Operators.Where<Observation>(f_, g_);
			Encounter i_(Observation ViralLoadTest) => 
				EncounterWithHIV;
			var j_ = context.Operators.Select<Observation, Encounter>(h_, i_);

			return j_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		var d_ = context.Operators.Exists<Encounter>(c_);

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
				var l_ = AnotherEncounterWithHIV?.Period;
				var m_ = FHIRHelpers_4_3_000.ToInterval(l_);
				var n_ = context.Operators.Start(m_);
				var o_ = EncounterWithHIV?.Period;
				var p_ = FHIRHelpers_4_3_000.ToInterval(o_);
				var q_ = context.Operators.End(p_);
				var r_ = context.Operators.Quantity(90m, "days");
				var s_ = context.Operators.Add(q_, r_);
				var t_ = context.Operators.SameOrAfter(n_, s_, "day");
				var u_ = context.Operators.And(k_, t_);

				return u_;
			};
			var g_ = context.Operators.Where<Encounter>(e_, f_);
			Encounter h_(Encounter AnotherEncounterWithHIV) => 
				EncounterWithHIV;
			var i_ = context.Operators.Select<Encounter, Encounter>(g_, h_);

			return i_;
		};
		var c_ = context.Operators.SelectMany<Encounter, Encounter>(a_, b_);
		var d_ = context.Operators.Exists<Encounter>(c_);

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