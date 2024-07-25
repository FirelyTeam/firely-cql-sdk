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
[CqlLibrary("SupplementalDataElements", "3.4.000")]
public class SupplementalDataElements_3_4_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Ethnicity;
    internal Lazy<CqlValueSet> __ONC_Administrative_Sex;
    internal Lazy<CqlValueSet> __Payer_Type;
    internal Lazy<CqlValueSet> __Race;
    internal Lazy<Patient> __Patient;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>> __SDE_Payer;
    internal Lazy<(IEnumerable<CqlCode> codes, string display)?> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public SupplementalDataElements_3_4_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_3_000 = new FHIRHelpers_4_3_000(context);

        __Ethnicity = new Lazy<CqlValueSet>(this.Ethnicity_Value);
        __ONC_Administrative_Sex = new Lazy<CqlValueSet>(this.ONC_Administrative_Sex_Value);
        __Payer_Type = new Lazy<CqlValueSet>(this.Payer_Type_Value);
        __Race = new Lazy<CqlValueSet>(this.Race_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<(IEnumerable<CqlCode> codes, string display)?>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_3_000 FHIRHelpers_4_3_000 { get; }

    #endregion

	private CqlValueSet Ethnicity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity?.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex?.Value;

	private CqlValueSet Payer_Type_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer_Type() => 
		__Payer_Type?.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race?.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context?.Operators.RetrieveByValueSet<Patient>(null, null);
		Patient b_ = context?.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient?.Value;

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

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		CqlValueSet a_ = this.Payer_Type();
		IEnumerable<Coverage> b_ = context?.Operators.RetrieveByValueSet<Coverage>(a_, null);
		(CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer)
		{
			CodeableConcept e_ = Payer.Type;
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(e_);
			Period g_ = Payer.Period;
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			(CqlConcept code, CqlInterval<CqlDateTime> period)? i_ = (f_, h_);

			return i_;
		};
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context?.Operators.Select<Coverage, (CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer?.Value;

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
		CqlCode a_()
		{
			bool b_()
			{
				Patient d_ = this.Patient();
				Code<AdministrativeGender> e_ = d_.GenderElement;
				AdministrativeGender? f_ = e_.Value;
				string g_ = context?.Operators.Convert<string>(f_);
				bool? h_ = context?.Operators.Equal(g_, "male");

				return (h_ ?? false);
			};
			bool c_()
			{
				Patient i_ = this.Patient();
				Code<AdministrativeGender> j_ = i_.GenderElement;
				AdministrativeGender? k_ = j_.Value;
				string l_ = context?.Operators.Convert<string>(k_);
				bool? m_ = context?.Operators.Equal(l_, "female");

				return (m_ ?? false);
			};
			if (b_())
			{
				return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
			}
			else if (c_())
			{
				return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
			}
			else
			{
				return null;
			}
		};

		return a_();
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex?.Value;

}
