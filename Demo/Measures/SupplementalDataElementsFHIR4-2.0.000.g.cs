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
    internal Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
        __SDE_Race = new Lazy<IEnumerable<Coding>>(this.SDE_Race_Value);
        __SDE_Sex = new Lazy<CqlCode>(this.SDE_Sex_Value);
    }
    #region Dependencies

    public FHIRHelpers_4_0_001 FHIRHelpers_4_0_001 { get; }

    #endregion

	private CqlValueSet Ethnicity_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
	public CqlValueSet Ethnicity() => 
		__Ethnicity.Value;

	private CqlValueSet ONC_Administrative_Sex_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
	public CqlValueSet ONC_Administrative_Sex() => 
		__ONC_Administrative_Sex.Value;

	private CqlValueSet Payer_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
	public CqlValueSet Payer() => 
		__Payer.Value;

	private CqlValueSet Race_Value() => 
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
	public CqlValueSet Race() => 
		__Race.Value;

	private Patient Patient_Value()
	{
		var a_ = context.Operators.RetrieveByValueSet<Patient>(null, null);
		var b_ = context.Operators.SingletonFrom<Patient>(a_);

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
				var l_ = this.Patient();
				var m_ = l_ is DomainResource;

				return m_;
			};
			if (k_())
			{
				var n_ = this.Patient();

				return ((n_ as DomainResource).Extension as IEnumerable<Extension>);
			}
			else
			{
				return (null as IEnumerable<Extension>);
			};
		};
		bool? b_(Extension Extension)
		{
			var o_ = context.Operators.Convert<FhirUri>(Extension?.Url);
			var p_ = FHIRHelpers_4_0_001.ToString(o_);
			var q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return q_;
		};
		var c_ = context.Operators.Where<Extension>(a_(), b_);
		IEnumerable<Extension> d_(Extension Extension) => 
			(Extension?.Extension as IEnumerable<Extension>);
		var e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
		var f_ = context.Operators.Flatten<Extension>(e_);
		bool? g_(Extension E)
		{
			var r_ = context.Operators.Convert<FhirUri>(E?.Url);
			var s_ = FHIRHelpers_4_0_001.ToString(r_);
			var t_ = context.Operators.Equal(s_, "ombCategory");
			var v_ = FHIRHelpers_4_0_001.ToString(r_);
			var w_ = context.Operators.Equal(v_, "detailed");
			var x_ = context.Operators.Or(t_, w_);

			return x_;
		};
		var h_ = context.Operators.Where<Extension>(f_, g_);
		Coding i_(Extension E) => 
			(E?.Value as Coding);
		var j_ = context.Operators.Select<Extension, Coding>(h_, i_);

		return j_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = this.Payer();
		var b_ = context.Operators.RetrieveByValueSet<Coverage>(a_, null);
		Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG c_(Coverage Payer)
		{
			var e_ = new Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG
			{
				code = Payer?.Type,
				period = Payer?.Period,
			};

			return e_;
		};
		var d_ = context.Operators.Select<Coverage, Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>(b_, c_);

		return d_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		IEnumerable<Extension> a_()
		{
			bool k_()
			{
				var l_ = this.Patient();
				var m_ = l_ is DomainResource;

				return m_;
			};
			if (k_())
			{
				var n_ = this.Patient();

				return ((n_ as DomainResource).Extension as IEnumerable<Extension>);
			}
			else
			{
				return (null as IEnumerable<Extension>);
			};
		};
		bool? b_(Extension Extension)
		{
			var o_ = context.Operators.Convert<FhirUri>(Extension?.Url);
			var p_ = FHIRHelpers_4_0_001.ToString(o_);
			var q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return q_;
		};
		var c_ = context.Operators.Where<Extension>(a_(), b_);
		IEnumerable<Extension> d_(Extension Extension) => 
			(Extension?.Extension as IEnumerable<Extension>);
		var e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
		var f_ = context.Operators.Flatten<Extension>(e_);
		bool? g_(Extension E)
		{
			var r_ = context.Operators.Convert<FhirUri>(E?.Url);
			var s_ = FHIRHelpers_4_0_001.ToString(r_);
			var t_ = context.Operators.Equal(s_, "ombCategory");
			var v_ = FHIRHelpers_4_0_001.ToString(r_);
			var w_ = context.Operators.Equal(v_, "detailed");
			var x_ = context.Operators.Or(t_, w_);

			return x_;
		};
		var h_ = context.Operators.Where<Extension>(f_, g_);
		Coding i_(Extension E) => 
			(E?.Value as Coding);
		var j_ = context.Operators.Select<Extension, Coding>(h_, i_);

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
				var d_ = this.Patient();
				var e_ = FHIRHelpers_4_0_001.ToString(d_?.GenderElement);
				var f_ = context.Operators.Equal(e_, "male");

				return (f_ ?? false);
			};
			bool c_()
			{
				var g_ = this.Patient();
				var h_ = FHIRHelpers_4_0_001.ToString(g_?.GenderElement);
				var i_ = context.Operators.Equal(h_, "female");

				return (i_ ?? false);
			};
			if (b_())
			{
				string j_ = null;

				return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", j_, "Male");
			}
			else if (c_())
			{
				string k_ = null;

				return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", k_, "Female");
			}
			else
			{
				return null;
			};
		};

		return a_();
	}

    [CqlDeclaration("SDE Sex")]
	public CqlCode SDE_Sex() => 
		__SDE_Sex.Value;

}
