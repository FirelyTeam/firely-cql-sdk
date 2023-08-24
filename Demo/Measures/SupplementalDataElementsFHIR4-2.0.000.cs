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
		var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, null);

		return context?.Operators.SingleOrNull<Patient>(a_);
	}

    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
	{
		var x_ = (Extension Extension) =>
		{
			var a_ = Extension?.Url;
			var b_ = (a_ as object);
			var c_ = context?.Operators?.TypeConverter.Convert<FhirUri>(b_);
			var d_ = (c_ as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = (e_ as object);

			return context?.Operators.Equal(f_, ("http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity" as object));
		};
		var y_ = context?.Operators.WhereOrNull<Extension>(((this.Patient() is DomainResource)
				? (((this.Patient() as DomainResource)?.Extension as IEnumerable<Extension>))
				: ((null as IEnumerable<Extension>)))
, x_);
		var z_ = (Extension Extension) =>
		{
			var g_ = Extension?.Extension;

			return (g_ as IEnumerable<Extension>);
		};
		var aa_ = context?.Operators.SelectOrNull<Extension, IEnumerable<Extension>>(y_, z_);
		var ab_ = context?.Operators.FlattenList<Extension>(aa_);
		var ac_ = (Extension E) =>
		{
			var h_ = E?.Url;
			var i_ = (h_ as object);
			var j_ = context?.Operators?.TypeConverter.Convert<FhirUri>(i_);
			var k_ = (j_ as object);
			var l_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(k_);
			var m_ = (l_ as object);
			var n_ = context?.Operators.Equal(m_, ("ombCategory" as object));
			var o_ = E?.Url;
			var p_ = (o_ as object);
			var q_ = context?.Operators?.TypeConverter.Convert<FhirUri>(p_);
			var r_ = (q_ as object);
			var s_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(r_);
			var t_ = (s_ as object);
			var u_ = context?.Operators.Equal(t_, ("detailed" as object));

			return context?.Operators.Or(n_, u_);
		};
		var ad_ = context?.Operators.WhereOrNull<Extension>(ab_, ac_);
		var ae_ = (Extension E) =>
		{
			var v_ = E?.Value;
			var w_ = (v_ as object);

			return (w_ as Coding);
		};

		return context?.Operators.SelectOrNull<Extension, Coding>(ad_, ae_);
	}

    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
	{
		var c_ = this.Payer();
		var d_ = context?.DataRetriever.RetrieveByValueSet<Coverage>(c_, null);
		var e_ = (Coverage Payer) =>
		{
			var a_ = Payer?.Type;
			var b_ = Payer?.Period;

			return new Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG
			{
				code = a_,
				period = b_,
			};
		};

		return context?.Operators.SelectOrNull<Coverage, Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>(d_, e_);
	}

    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
	{
		var x_ = (Extension Extension) =>
		{
			var a_ = Extension?.Url;
			var b_ = (a_ as object);
			var c_ = context?.Operators?.TypeConverter.Convert<FhirUri>(b_);
			var d_ = (c_ as object);
			var e_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(d_);
			var f_ = (e_ as object);

			return context?.Operators.Equal(f_, ("http://hl7.org/fhir/us/core/StructureDefinition/us-core-race" as object));
		};
		var y_ = context?.Operators.WhereOrNull<Extension>(((this.Patient() is DomainResource)
				? (((this.Patient() as DomainResource)?.Extension as IEnumerable<Extension>))
				: ((null as IEnumerable<Extension>)))
, x_);
		var z_ = (Extension Extension) =>
		{
			var g_ = Extension?.Extension;

			return (g_ as IEnumerable<Extension>);
		};
		var aa_ = context?.Operators.SelectOrNull<Extension, IEnumerable<Extension>>(y_, z_);
		var ab_ = context?.Operators.FlattenList<Extension>(aa_);
		var ac_ = (Extension E) =>
		{
			var h_ = E?.Url;
			var i_ = (h_ as object);
			var j_ = context?.Operators?.TypeConverter.Convert<FhirUri>(i_);
			var k_ = (j_ as object);
			var l_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(k_);
			var m_ = (l_ as object);
			var n_ = context?.Operators.Equal(m_, ("ombCategory" as object));
			var o_ = E?.Url;
			var p_ = (o_ as object);
			var q_ = context?.Operators?.TypeConverter.Convert<FhirUri>(p_);
			var r_ = (q_ as object);
			var s_ = (context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>(r_);
			var t_ = (s_ as object);
			var u_ = context?.Operators.Equal(t_, ("detailed" as object));

			return context?.Operators.Or(n_, u_);
		};
		var ad_ = context?.Operators.WhereOrNull<Extension>(ab_, ac_);
		var ae_ = (Extension E) =>
		{
			var v_ = E?.Value;
			var w_ = (v_ as object);

			return (w_ as Coding);
		};

		return context?.Operators.SelectOrNull<Extension, Coding>(ad_, ae_);
	}

    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        if ((context?.Operators.Equal(((context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>((this.Patient()?.GenderElement as object)) as object), ("male" as object)) ?? false))
		{
			string a__ = null;

			return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", a__, "Male");
		}
        else if ((context?.Operators.Equal(((context.Deeper(new CallStackEntry("ToString", null, null))?.Operators?.TypeConverter).Convert<string>((this.Patient()?.GenderElement as object)) as object), ("female" as object)) ?? false))
		{
			string a__ = null;

			return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", a__, "Female");
		}
        else
            return null;
    }

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

}