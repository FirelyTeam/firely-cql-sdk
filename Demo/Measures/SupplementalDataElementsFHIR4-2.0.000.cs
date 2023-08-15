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

    private CqlValueSet Ethnicity_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", 
			null);
    }

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity() => __Ethnicity.Value;

    private CqlValueSet ONC_Administrative_Sex_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", 
			null);
    }

    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex() => __ONC_Administrative_Sex.Value;

    private CqlValueSet Payer_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", 
			null);
    }

    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer() => __Payer.Value;

    private CqlValueSet Race_Value()
    {
        return new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", 
			null);
    }

    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race() => __Race.Value;

    private Patient Patient_Value()
    {
        var a_ = context?.DataRetriever.RetrieveByValueSet<Patient>(null, 
			null);
        return context?.Operators.SingleOrNull<Patient>(a_);
    }
    [CqlDeclaration("Patient")]
    public Patient Patient() => __Patient.Value;

    private IEnumerable<Coding> SDE_Ethnicity_Value()
    {
        var a_ = ((this.Patient() is DomainResource)
			? (((this.Patient() as DomainResource)?.Extension as IEnumerable<Extension>))
			: ((null as IEnumerable<Extension>)))
;
        Func<Extension,bool?> f_ = (Extension) => 
        {
            var d_ = (Extension?.Url as object);
            var c_ = (context?.Operators?.TypeConverter.Convert<FhirUri>(d_) as object);
            var b_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(c_) as object);
            var e_ = ("http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity" as object);
            return context?.Operators.Equal(b_, 
				e_);
        };
        var g_ = context?.Operators.WhereOrNull<Extension>(a_, 
			f_);
        Func<Extension,IEnumerable<Extension>> h_ = (Extension) => (Extension?.Extension as IEnumerable<Extension>);
        var i_ = context?.Operators.SelectOrNull<Extension, IEnumerable<Extension>>(g_, 
			h_);
        var j_ = context?.Operators.FlattenList<Extension>(i_);
        Func<Extension,bool?> u_ = (E) => 
        {
            var m_ = (E?.Url as object);
            var l_ = (context?.Operators?.TypeConverter.Convert<FhirUri>(m_) as object);
            var k_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(l_) as object);
            var n_ = ("ombCategory" as object);
            var o_ = context?.Operators.Equal(k_, 
				n_);
            var s_ = ("detailed" as object);
            var t_ = context?.Operators.Equal(k_, 
				s_);
            return context?.Operators.Or(o_, 
				t_);
        };
        var v_ = context?.Operators.WhereOrNull<Extension>(j_, 
			u_);
        Func<Extension,Coding> w_ = (E) => ((E?.Value as object) as Coding);
        return context?.Operators.SelectOrNull<Extension, Coding>(v_, 
			w_);
    }
    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity() => __SDE_Ethnicity.Value;

    private IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer_Value()
    {
        var a_ = this.Payer();
        var b_ = context?.DataRetriever.RetrieveByValueSet<Coverage>(a_, 
			typeof(Coverage).GetProperty("Type"));
        Func<Coverage,Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> e_ = (Payer) => 
        {
            var c_ = Payer?.Type;
            var d_ = Payer?.Period;
            return new Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG
			{
				code = c_,
				period = d_,
			};
        };
        return context?.Operators.SelectOrNull<Coverage, Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG>(b_, 
			e_);
    }
    [CqlDeclaration("SDE Payer")]
    public IEnumerable<Tuples.Tuple_CFQHSgYJOXjAOCKdWLdZNNHDG> SDE_Payer() => __SDE_Payer.Value;

    private IEnumerable<Coding> SDE_Race_Value()
    {
        var a_ = ((this.Patient() is DomainResource)
			? (((this.Patient() as DomainResource)?.Extension as IEnumerable<Extension>))
			: ((null as IEnumerable<Extension>)))
;
        Func<Extension,bool?> f_ = (Extension) => 
        {
            var d_ = (Extension?.Url as object);
            var c_ = (context?.Operators?.TypeConverter.Convert<FhirUri>(d_) as object);
            var b_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(c_) as object);
            var e_ = ("http://hl7.org/fhir/us/core/StructureDefinition/us-core-race" as object);
            return context?.Operators.Equal(b_, 
				e_);
        };
        var g_ = context?.Operators.WhereOrNull<Extension>(a_, 
			f_);
        Func<Extension,IEnumerable<Extension>> h_ = (Extension) => (Extension?.Extension as IEnumerable<Extension>);
        var i_ = context?.Operators.SelectOrNull<Extension, IEnumerable<Extension>>(g_, 
			h_);
        var j_ = context?.Operators.FlattenList<Extension>(i_);
        Func<Extension,bool?> u_ = (E) => 
        {
            var m_ = (E?.Url as object);
            var l_ = (context?.Operators?.TypeConverter.Convert<FhirUri>(m_) as object);
            var k_ = ((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>(l_) as object);
            var n_ = ("ombCategory" as object);
            var o_ = context?.Operators.Equal(k_, 
				n_);
            var s_ = ("detailed" as object);
            var t_ = context?.Operators.Equal(k_, 
				s_);
            return context?.Operators.Or(o_, 
				t_);
        };
        var v_ = context?.Operators.WhereOrNull<Extension>(j_, 
			u_);
        Func<Extension,Coding> w_ = (E) => ((E?.Value as object) as Coding);
        return context?.Operators.SelectOrNull<Extension, Coding>(v_, 
			w_);
    }
    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race() => __SDE_Race.Value;

    private CqlCode SDE_Sex_Value()
    {
        if ((context?.Operators.Equal(((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>((this.Patient()?.GenderElement as object)) as object), 
				("male" as object)) ?? false))
            return new CqlCode("M", 
				"http://hl7.org/fhir/v3/AdministrativeGender", 
				null, 
				"Male");

        else if ((context?.Operators.Equal(((context.Deeper(new CallStackEntry("ToString", 
		null, 
		null))?.Operators?.TypeConverter).Convert<string>((this.Patient()?.GenderElement as object)) as object), 
				("female" as object)) ?? false))
            return new CqlCode("F", 
				"http://hl7.org/fhir/v3/AdministrativeGender", 
				null, 
				"Female");

        else 
            return null;

    }

    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex() => __SDE_Sex.Value;

}