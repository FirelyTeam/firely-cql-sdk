using System;
using System.Linq;
using System.Collections.Generic;
using Hl7.Cql.Runtime;
using Hl7.Cql.Primitives;
using Hl7.Cql;
using Hl7.Cql.ValueSets;
using Hl7.Cql.Iso8601;
using Hl7.Fhir.Model;
using Range = Hl7.Fhir.Model.Range;
using Task = Hl7.Fhir.Model.Task;
[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "0.0.1.0")]
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
    internal Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>> __SDE_Payer;
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
        __SDE_Payer = new Lazy<IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>>(this.SDE_Payer_Value);
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
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Patient>(null, null);
		var d_ = a_.SingleOrNull<Patient>(c_);

		return d_;
	}

    [CqlDeclaration("Patient")]
	public Patient Patient() => 
		__Patient.Value;

	private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var a_ = context.Operators;
		IEnumerable<Extension> f_()
		{
			if (this.Patient() is DomainResource)
			{
				var p_ = this.Patient();
				var q_ = (p_ as DomainResource).Extension;

				return (q_ as IEnumerable<Extension>);
			}
			else
			{
				return (null as IEnumerable<Extension>);
			};
		};
		bool? g_(Extension Extension)
		{
			var r_ = context.Operators;
			var s_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var t_ = s_.Operators;
			var u_ = t_.TypeConverter;
			var w_ = r_.TypeConverter;
			var x_ = Extension?.Url;
			var y_ = w_.Convert<FhirUri>(x_);
			var z_ = u_.Convert<string>(y_);
			var aa_ = r_.Equal(z_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return aa_;
		};
		var h_ = a_.WhereOrNull<Extension>(f_(), g_);
		IEnumerable<Extension> i_(Extension Extension)
		{
			var ab_ = Extension?.Extension;

			return (ab_ as IEnumerable<Extension>);
		};
		var j_ = a_.SelectOrNull<Extension, IEnumerable<Extension>>(h_, i_);
		var k_ = a_.FlattenList<Extension>(j_);
		bool? l_(Extension E)
		{
			var ac_ = context.Operators;
			var ae_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var af_ = ae_.Operators;
			var ag_ = af_.TypeConverter;
			var ai_ = ac_.TypeConverter;
			var aj_ = E?.Url;
			var ak_ = ai_.Convert<FhirUri>(aj_);
			var al_ = ag_.Convert<string>(ak_);
			var am_ = ac_.Equal(al_, "ombCategory");
			var ap_ = ae_.Operators;
			var aq_ = ap_.TypeConverter;
			var as_ = ac_.TypeConverter;
			var au_ = as_.Convert<FhirUri>(aj_);
			var av_ = aq_.Convert<string>(au_);
			var aw_ = ac_.Equal(av_, "detailed");
			var ax_ = ac_.Or(am_, aw_);

			return ax_;
		};
		var m_ = a_.WhereOrNull<Extension>(k_, l_);
		Coding n_(Extension E)
		{
			var ay_ = E?.Value;

			return (ay_ as Coding);
		};
		var o_ = a_.SelectOrNull<Extension, Coding>(m_, n_);

		return o_;
	}

    [CqlDeclaration("SDE Ethnicity")]
	public IEnumerable<Coding> SDE_Ethnicity() => 
		__SDE_Ethnicity.Value;

	private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = context.Operators;
		var b_ = context.DataRetriever;
		var c_ = this.Payer();
		var d_ = b_.RetrieveByValueSet<Coverage>(c_, null);
		Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG e_(Coverage Payer)
		{
			var g_ = Payer?.Type;
			var h_ = Payer?.Period;
			var i_ = new Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG
			{
				code = g_,
				period = h_,
			};

			return i_;
		};
		var f_ = a_.SelectOrNull<Coverage, Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>(d_, e_);

		return f_;
	}

    [CqlDeclaration("SDE Payer")]
	public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => 
		__SDE_Payer.Value;

	private IEnumerable<Coding> SDE_Race_Value()
	{
		var a_ = context.Operators;
		IEnumerable<Extension> f_()
		{
			if (this.Patient() is DomainResource)
			{
				var p_ = this.Patient();
				var q_ = (p_ as DomainResource).Extension;

				return (q_ as IEnumerable<Extension>);
			}
			else
			{
				return (null as IEnumerable<Extension>);
			};
		};
		bool? g_(Extension Extension)
		{
			var r_ = context.Operators;
			var s_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var t_ = s_.Operators;
			var u_ = t_.TypeConverter;
			var w_ = r_.TypeConverter;
			var x_ = Extension?.Url;
			var y_ = w_.Convert<FhirUri>(x_);
			var z_ = u_.Convert<string>(y_);
			var aa_ = r_.Equal(z_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return aa_;
		};
		var h_ = a_.WhereOrNull<Extension>(f_(), g_);
		IEnumerable<Extension> i_(Extension Extension)
		{
			var ab_ = Extension?.Extension;

			return (ab_ as IEnumerable<Extension>);
		};
		var j_ = a_.SelectOrNull<Extension, IEnumerable<Extension>>(h_, i_);
		var k_ = a_.FlattenList<Extension>(j_);
		bool? l_(Extension E)
		{
			var ac_ = context.Operators;
			var ae_ = context.Deeper(new CallStackEntry("ToString", null, null));
			var af_ = ae_.Operators;
			var ag_ = af_.TypeConverter;
			var ai_ = ac_.TypeConverter;
			var aj_ = E?.Url;
			var ak_ = ai_.Convert<FhirUri>(aj_);
			var al_ = ag_.Convert<string>(ak_);
			var am_ = ac_.Equal(al_, "ombCategory");
			var ap_ = ae_.Operators;
			var aq_ = ap_.TypeConverter;
			var as_ = ac_.TypeConverter;
			var au_ = as_.Convert<FhirUri>(aj_);
			var av_ = aq_.Convert<string>(au_);
			var aw_ = ac_.Equal(av_, "detailed");
			var ax_ = ac_.Or(am_, aw_);

			return ax_;
		};
		var m_ = a_.WhereOrNull<Extension>(k_, l_);
		Coding n_(Extension E)
		{
			var ay_ = E?.Value;

			return (ay_ as Coding);
		};
		var o_ = a_.SelectOrNull<Extension, Coding>(m_, n_);

		return o_;
	}

    [CqlDeclaration("SDE Race")]
	public IEnumerable<Coding> SDE_Race() => 
		__SDE_Race.Value;

	private CqlCode SDE_Sex_Value()
	{
		CqlCode a_()
		{
			if ((context.Operators.Equal((context.Deeper(new CallStackEntry("ToString", null, null)).Operators.TypeConverter).Convert<string>(this.Patient()?.GenderElement), "male") ?? false))
			{
				return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");
			}
			else if ((context.Operators.Equal((context.Deeper(new CallStackEntry("ToString", null, null)).Operators.TypeConverter).Convert<string>(this.Patient()?.GenderElement), "female") ?? false))
			{
				return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");
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