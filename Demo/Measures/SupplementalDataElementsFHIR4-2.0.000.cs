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
    public CqlValueSet Ethnicity() => __Ethnicity.Value;

    private CqlValueSet ONC_Administrative_Sex_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex() => __ONC_Administrative_Sex.Value;

    private CqlValueSet Payer_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer() => __Payer.Value;

    private CqlValueSet Race_Value() =>
		new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race() => __Race.Value;

    private Patient Patient_Value()
	{
		var a_ = context.DataRetriever;
		var b_ = a_.RetrieveByValueSet<Patient>(null, null);
		var c_ = context.Operators;
		var d_ = c_.SingleOrNull<Patient>(b_);

		return d_;
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		bool? a_(Extension Extension)
		{
			var o_ = Extension?.Url;
			var p_ = context.Operators;
			var q_ = p_.TypeConverter;
			var r_ = q_.Convert<FhirUri>(o_);
			var s_ = new CallStackEntry("ToString", null, null);
			var t_ = context.Deeper(s_);
			var u_ = t_.Operators;
			var v_ = u_.TypeConverter;
			var w_ = v_.Convert<string>(r_);
			var y_ = p_.Equal(w_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

			return y_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Extension>(((this.Patient() is DomainResource)
				? (((this.Patient() as DomainResource).Extension as IEnumerable<Extension>))
				: ((null as IEnumerable<Extension>))), a_);
		IEnumerable<Extension> d_(Extension Extension)
		{
			var z_ = Extension?.Extension;

			return (z_ as IEnumerable<Extension>);
		};
		var f_ = b_.SelectOrNull<Extension, IEnumerable<Extension>>(c_, d_);
		var h_ = b_.FlattenList<Extension>(f_);
		bool? i_(Extension E)
		{
			var aa_ = E?.Url;
			var ab_ = context.Operators;
			var ac_ = ab_.TypeConverter;
			var ad_ = ac_.Convert<FhirUri>(aa_);
			var ae_ = new CallStackEntry("ToString", null, null);
			var af_ = context.Deeper(ae_);
			var ag_ = af_.Operators;
			var ah_ = ag_.TypeConverter;
			var ai_ = ah_.Convert<string>(ad_);
			var ak_ = ab_.Equal(ai_, "ombCategory");
			var an_ = ab_.TypeConverter;
			var ao_ = an_.Convert<FhirUri>(aa_);
			var aq_ = context.Deeper(ae_);
			var ar_ = aq_.Operators;
			var as_ = ar_.TypeConverter;
			var at_ = as_.Convert<string>(ao_);
			var av_ = ab_.Equal(at_, "detailed");
			var ax_ = ab_.Or(ak_, av_);

			return ax_;
		};
		var k_ = b_.WhereOrNull<Extension>(h_, i_);
		Coding l_(Extension E)
		{
			var ay_ = E?.Value;

			return (ay_ as Coding);
		};
		var n_ = b_.SelectOrNull<Extension, Coding>(k_, l_);

		return n_;
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var a_ = this.Payer();
		var b_ = context.DataRetriever;
		var c_ = b_.RetrieveByValueSet<Coverage>(a_, null);
		Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG d_(Coverage Payer)
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
		var e_ = context.Operators;
		var f_ = e_.SelectOrNull<Coverage, Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>(c_, d_);

		return f_;
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		bool? a_(Extension Extension)
		{
			var o_ = Extension?.Url;
			var p_ = context.Operators;
			var q_ = p_.TypeConverter;
			var r_ = q_.Convert<FhirUri>(o_);
			var s_ = new CallStackEntry("ToString", null, null);
			var t_ = context.Deeper(s_);
			var u_ = t_.Operators;
			var v_ = u_.TypeConverter;
			var w_ = v_.Convert<string>(r_);
			var y_ = p_.Equal(w_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

			return y_;
		};
		var b_ = context.Operators;
		var c_ = b_.WhereOrNull<Extension>(((this.Patient() is DomainResource)
				? (((this.Patient() as DomainResource).Extension as IEnumerable<Extension>))
				: ((null as IEnumerable<Extension>))), a_);
		IEnumerable<Extension> d_(Extension Extension)
		{
			var z_ = Extension?.Extension;

			return (z_ as IEnumerable<Extension>);
		};
		var f_ = b_.SelectOrNull<Extension, IEnumerable<Extension>>(c_, d_);
		var h_ = b_.FlattenList<Extension>(f_);
		bool? i_(Extension E)
		{
			var aa_ = E?.Url;
			var ab_ = context.Operators;
			var ac_ = ab_.TypeConverter;
			var ad_ = ac_.Convert<FhirUri>(aa_);
			var ae_ = new CallStackEntry("ToString", null, null);
			var af_ = context.Deeper(ae_);
			var ag_ = af_.Operators;
			var ah_ = ag_.TypeConverter;
			var ai_ = ah_.Convert<string>(ad_);
			var ak_ = ab_.Equal(ai_, "ombCategory");
			var an_ = ab_.TypeConverter;
			var ao_ = an_.Convert<FhirUri>(aa_);
			var aq_ = context.Deeper(ae_);
			var ar_ = aq_.Operators;
			var as_ = ar_.TypeConverter;
			var at_ = as_.Convert<string>(ao_);
			var av_ = ab_.Equal(at_, "detailed");
			var ax_ = ab_.Or(ak_, av_);

			return ax_;
		};
		var k_ = b_.WhereOrNull<Extension>(h_, i_);
		Coding l_(Extension E)
		{
			var ay_ = E?.Value;

			return (ay_ as Coding);
		};
		var n_ = b_.SelectOrNull<Extension, Coding>(k_, l_);

		return n_;
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
	{
		CqlCode a_()
		{
			if ((context.Operators.Equal((context.Deeper(new CallStackEntry("ToString", null, null)).Operators.TypeConverter).Convert<string>(this.Patient()?.GenderElement), "male") ?? false))
			{
				var b_ = new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Male");

				return b_;
			}
			else if ((context.Operators.Equal((context.Deeper(new CallStackEntry("ToString", null, null)).Operators.TypeConverter).Convert<string>(this.Patient()?.GenderElement), "female") ?? false))
			{
				var c_ = new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", null, "Female");

				return c_;
			}
			else
				return null;

;
		};

		return a_();
	}

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

}