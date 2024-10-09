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
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex.Value;

	private CqlValueSet Payer_Type_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);

    [CqlDeclaration("Payer Type")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer_Type() => 
		__Payer_Type.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

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
				return default;
			}
		};
		bool? b_(Extension @this)
		{
			string m_ = @this?.Url;
			FhirString n_ = context.Operators.Convert<FhirString>(m_);
			string o_ = FHIRHelpers_4_3_000.ToString(n_);
			bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return p_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
		Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = [
			d_,
		];
		(IEnumerable<CqlCode> codes, string display)? f_(Extension E)
		{
			bool? q_(Extension @this)
			{
				string al_ = @this?.Url;
				FhirString am_ = context.Operators.Convert<FhirString>(al_);
				string an_ = FHIRHelpers_4_3_000.ToString(am_);
				bool? ao_ = context.Operators.Equal(an_, "ombCategory");

				return ao_;
			};
			IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), q_);
			object s_(Extension @this)
			{
				DataType ap_ = @this?.Value;

				return ap_;
			};
			IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);
			object u_ = context.Operators.SingletonFrom<object>(t_);
			CqlCode v_ = FHIRHelpers_4_3_000.ToCode(u_ as Coding);
			CqlCode[] w_ = [
				v_,
			];
			bool? x_(Extension @this)
			{
				string aq_ = @this?.Url;
				FhirString ar_ = context.Operators.Convert<FhirString>(aq_);
				string as_ = FHIRHelpers_4_3_000.ToString(ar_);
				bool? at_ = context.Operators.Equal(as_, "detailed");

				return at_;
			};
			IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), x_);
			object z_(Extension @this)
			{
				DataType au_ = @this?.Value;

				return au_;
			};
			IEnumerable<object> aa_ = context.Operators.Select<Extension, object>(y_, z_);
			CqlCode ab_(object @this)
			{
				CqlCode av_ = FHIRHelpers_4_3_000.ToCode(@this as Coding);

				return av_;
			};
			IEnumerable<CqlCode> ac_ = context.Operators.Select<object, CqlCode>(aa_, ab_);
			IEnumerable<CqlCode> ad_ = context.Operators.Union<CqlCode>(w_ as IEnumerable<CqlCode>, ac_);
			bool? ae_(Extension @this)
			{
				string aw_ = @this?.Url;
				FhirString ax_ = context.Operators.Convert<FhirString>(aw_);
				string ay_ = FHIRHelpers_4_3_000.ToString(ax_);
				bool? az_ = context.Operators.Equal(ay_, "text");

				return az_;
			};
			IEnumerable<Extension> af_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
					? (E as Element).Extension
					: default), ae_);
			DataType ag_(Extension @this)
			{
				DataType ba_ = @this?.Value;

				return ba_;
			};
			IEnumerable<DataType> ah_ = context.Operators.Select<Extension, DataType>(af_, ag_);
			DataType ai_ = context.Operators.SingletonFrom<DataType>(ah_);
			string aj_ = context.Operators.Convert<string>(ai_);
			(IEnumerable<CqlCode> codes, string display)? ak_ = (ad_, aj_);

			return ak_;
		};
		IEnumerable<(IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
		(IEnumerable<CqlCode> codes, string display)? h_ = context.Operators.SingletonFrom<(IEnumerable<CqlCode> codes, string display)?>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Value()
	{
		CqlValueSet a_ = this.Payer_Type();
		IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));
		(CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer)
		{
			CodeableConcept e_ = Payer?.Type;
			CqlConcept f_ = FHIRHelpers_4_3_000.ToConcept(e_);
			Period g_ = Payer?.Period;
			CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.ToInterval(g_);
			(CqlConcept code, CqlInterval<CqlDateTime> period)? i_ = (f_, h_);

			return i_;
		};
		IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.Select<Coverage, (CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer() => 
		__SDE_Payer.Value;

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

				return (l_ as DomainResource).Extension;
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension @this)
		{
			string m_ = @this?.Url;
			FhirString n_ = context.Operators.Convert<FhirString>(m_);
			string o_ = FHIRHelpers_4_3_000.ToString(n_);
			bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return p_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
		Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
		Extension[] e_ = [
			d_,
		];
		(IEnumerable<CqlCode> codes, string display)? f_(Extension R)
		{
			bool? q_(Extension @this)
			{
				string ak_ = @this?.Url;
				FhirString al_ = context.Operators.Convert<FhirString>(ak_);
				string am_ = FHIRHelpers_4_3_000.ToString(al_);
				bool? an_ = context.Operators.Equal(am_, "ombCategory");

				return an_;
			};
			IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), q_);
			object s_(Extension @this)
			{
				DataType ao_ = @this?.Value;

				return ao_;
			};
			IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);
			CqlCode u_(object @this)
			{
				CqlCode ap_ = FHIRHelpers_4_3_000.ToCode(@this as Coding);

				return ap_;
			};
			IEnumerable<CqlCode> v_ = context.Operators.Select<object, CqlCode>(t_, u_);
			bool? w_(Extension @this)
			{
				string aq_ = @this?.Url;
				FhirString ar_ = context.Operators.Convert<FhirString>(aq_);
				string as_ = FHIRHelpers_4_3_000.ToString(ar_);
				bool? at_ = context.Operators.Equal(as_, "detailed");

				return at_;
			};
			IEnumerable<Extension> x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), w_);
			object y_(Extension @this)
			{
				DataType au_ = @this?.Value;

				return au_;
			};
			IEnumerable<object> z_ = context.Operators.Select<Extension, object>(x_, y_);
			CqlCode aa_(object @this)
			{
				CqlCode av_ = FHIRHelpers_4_3_000.ToCode(@this as Coding);

				return av_;
			};
			IEnumerable<CqlCode> ab_ = context.Operators.Select<object, CqlCode>(z_, aa_);
			IEnumerable<CqlCode> ac_ = context.Operators.Union<CqlCode>(v_, ab_);
			bool? ad_(Extension @this)
			{
				string aw_ = @this?.Url;
				FhirString ax_ = context.Operators.Convert<FhirString>(aw_);
				string ay_ = FHIRHelpers_4_3_000.ToString(ax_);
				bool? az_ = context.Operators.Equal(ay_, "text");

				return az_;
			};
			IEnumerable<Extension> ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
					? (R as Element).Extension
					: default), ad_);
			DataType af_(Extension @this)
			{
				DataType ba_ = @this?.Value;

				return ba_;
			};
			IEnumerable<DataType> ag_ = context.Operators.Select<Extension, DataType>(ae_, af_);
			DataType ah_ = context.Operators.SingletonFrom<DataType>(ag_);
			string ai_ = context.Operators.Convert<string>(ah_);
			(IEnumerable<CqlCode> codes, string display)? aj_ = (ac_, ai_);

			return aj_;
		};
		IEnumerable<(IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
		(IEnumerable<CqlCode> codes, string display)? h_ = context.Operators.SingletonFrom<(IEnumerable<CqlCode> codes, string display)?>(g_);

		return h_;
	}

    [CqlDeclaration("SDE Race")]
	public (IEnumerable<CqlCode> codes, string display)? SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_()
		{
			bool b_()
			{
				Patient d_ = this.Patient();
				Code<AdministrativeGender> e_ = d_?.GenderElement;
				AdministrativeGender? f_ = e_?.Value;
				string g_ = context.Operators.Convert<string>(f_);
				bool? h_ = context.Operators.Equal(g_, "male");

				return h_ ?? false;
			};
			bool c_()
			{
				Patient i_ = this.Patient();
				Code<AdministrativeGender> j_ = i_?.GenderElement;
				AdministrativeGender? k_ = j_?.Value;
				string l_ = context.Operators.Convert<string>(k_);
				bool? m_ = context.Operators.Equal(l_, "female");

				return m_ ?? false;
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
				return default;
			}
		};

		return a_();
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
