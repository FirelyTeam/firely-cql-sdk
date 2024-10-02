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
[CqlLibrary("SupplementalDataElementsFHIR4", "2.0.000")]
public class SupplementalDataElementsFHIR4_2_0_000
{


    internal CqlContext context;

    #region Cached values

    internal Lazy<CqlValueSet> __Ethnicity;
    internal Lazy<CqlValueSet> __ONC_Administrative_Sex;
    internal Lazy<CqlValueSet> __Payer;
    internal Lazy<CqlValueSet> __Race;
    internal Lazy<Patient> __Patient;
    internal Lazy<IEnumerable<Coding>> __SDE_Ethnicity;
    internal Lazy<IEnumerable<(CodeableConcept code, Period period)?>> __SDE_Payer;
    internal Lazy<IEnumerable<Coding>> __SDE_Race;
    internal Lazy<CqlCode> __SDE_Sex;

    #endregion
    public SupplementalDataElementsFHIR4_2_0_000(CqlContext context)
    {
        this.context = context ?? throw new ArgumentNullException("context");

        FHIRHelpers_4_0_001 = new FHIRHelpers_4_0_001(context);

        __Ethnicity = new Lazy<CqlValueSet>(this.Ethnicity_Value);
        __ONC_Administrative_Sex = new Lazy<CqlValueSet>(this.ONC_Administrative_Sex_Value);
        __Payer = new Lazy<CqlValueSet>(this.Payer_Value);
        __Race = new Lazy<CqlValueSet>(this.Race_Value);
        __Patient = new Lazy<Patient>(this.Patient_Value);
        __SDE_Ethnicity = new Lazy<IEnumerable<Coding>>(this.SDE_Ethnicity_Value);
        __SDE_Payer = new Lazy<IEnumerable<(CodeableConcept code, Period period)?>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

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

	private CqlValueSet Payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer() => 
		__Payer.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

	private Patient Patient_Value()
	{
		IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
		Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

		return b_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		IEnumerable<Extension> a_()
		{
			bool k_()
			{
				Patient l_ = this.Patient();
				bool m_ = l_ is DomainResource;

				return m_;
			};
			if (k_())
			{
				Patient n_ = this.Patient();

				return (IEnumerable<Extension>)((n_ as DomainResource).Extension);
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension Extension)
		{
			string o_ = Extension?.Url;
			FhirUri p_ = context.Operators.Convert<FhirUri>(o_);
			string q_ = FHIRHelpers_4_0_001.ToString(p_);
			bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return r_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);
		IEnumerable<Extension> d_(Extension Extension)
		{
			List<Extension> s_ = Extension?.Extension;

			return (IEnumerable<Extension>)s_;
		};
		IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
		IEnumerable<Extension> f_ = context.Operators.Flatten<Extension>(e_);
		bool? g_(Extension E)
		{
			string t_ = E?.Url;
			FhirUri u_ = context.Operators.Convert<FhirUri>(t_);
			string v_ = FHIRHelpers_4_0_001.ToString(u_);
			bool? w_ = context.Operators.Equal(v_, "ombCategory");
			FhirUri y_ = context.Operators.Convert<FhirUri>(t_);
			string z_ = FHIRHelpers_4_0_001.ToString(y_);
			bool? aa_ = context.Operators.Equal(z_, "detailed");
			bool? ab_ = context.Operators.Or(w_, aa_);

			return ab_;
		};
		IEnumerable<Extension> h_ = context.Operators.Where<Extension>(f_, g_);
		Coding i_(Extension E)
		{
			DataType ac_ = E?.Value;

			return ac_ as Coding;
		};
		IEnumerable<Coding> j_ = context.Operators.Select<Extension, Coding>(h_, i_);

		return j_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer_Value()
	{
		CqlValueSet a_ = this.Payer();
		IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
		(CodeableConcept code, Period period)? c_(Coverage Payer)
		{
			CodeableConcept e_ = Payer?.Type;
			Period f_ = Payer?.Period;
			(CodeableConcept code, Period period)? g_ = (e_, f_);

			return g_;
		};
		IEnumerable<(CodeableConcept code, Period period)?> d_ = context.Operators.Select<Coverage, (CodeableConcept code, Period period)?>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<(CodeableConcept code, Period period)?> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Extension> a_()
		{
			bool k_()
			{
				Patient l_ = this.Patient();
				bool m_ = l_ is DomainResource;

				return m_;
			};
			if (k_())
			{
				Patient n_ = this.Patient();

				return (IEnumerable<Extension>)((n_ as DomainResource).Extension);
			}
			else
			{
				return default;
			}
		};
		bool? b_(Extension Extension)
		{
			string o_ = Extension?.Url;
			FhirUri p_ = context.Operators.Convert<FhirUri>(o_);
			string q_ = FHIRHelpers_4_0_001.ToString(p_);
			bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return r_;
		};
		IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);
		IEnumerable<Extension> d_(Extension Extension)
		{
			List<Extension> s_ = Extension?.Extension;

			return (IEnumerable<Extension>)s_;
		};
		IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
		IEnumerable<Extension> f_ = context.Operators.Flatten<Extension>(e_);
		bool? g_(Extension E)
		{
			string t_ = E?.Url;
			FhirUri u_ = context.Operators.Convert<FhirUri>(t_);
			string v_ = FHIRHelpers_4_0_001.ToString(u_);
			bool? w_ = context.Operators.Equal(v_, "ombCategory");
			FhirUri y_ = context.Operators.Convert<FhirUri>(t_);
			string z_ = FHIRHelpers_4_0_001.ToString(y_);
			bool? aa_ = context.Operators.Equal(z_, "detailed");
			bool? ab_ = context.Operators.Or(w_, aa_);

			return ab_;
		};
		IEnumerable<Extension> h_ = context.Operators.Where<Extension>(f_, g_);
		Coding i_(Extension E)
		{
			DataType ac_ = E?.Value;

			return ac_ as Coding;
		};
		IEnumerable<Coding> j_ = context.Operators.Select<Extension, Coding>(h_, i_);

		return j_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_()
		{
			bool b_()
			{
				Patient d_ = this.Patient();
				Code<AdministrativeGender> e_ = d_?.GenderElement;
				string f_ = FHIRHelpers_4_0_001.ToString(e_);
				bool? g_ = context.Operators.Equal(f_, "male");

				return g_ ?? false;
			};
			bool c_()
			{
				Patient h_ = this.Patient();
				Code<AdministrativeGender> i_ = h_?.GenderElement;
				string j_ = FHIRHelpers_4_0_001.ToString(i_);
				bool? k_ = context.Operators.Equal(j_, "female");

				return k_ ?? false;
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
