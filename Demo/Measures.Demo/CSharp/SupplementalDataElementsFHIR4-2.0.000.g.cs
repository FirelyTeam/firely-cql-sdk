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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.5.0")]
[CqlLibrary("SupplementalDataElementsFHIR4", "2.0.000")]
public partial class SupplementalDataElementsFHIR4_2_0_000 : ILibrary, ISingleton<SupplementalDataElementsFHIR4_2_0_000>
{
    #region ValueSets (4)

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer(CqlContext _) => _Payer;
    private static readonly CqlValueSet _Payer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    #endregion ValueSets

    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = -795627643300423179L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -4520261593046211730L;

    private IEnumerable<Coding> SDE_Ethnicity_Compute(CqlContext context)
    {
        IEnumerable<Extension> a_;
        Patient m_ = this.Patient(context);
        bool n_ = m_ is DomainResource;
        if (n_)
        {
            Patient o_ = this.Patient(context);
            a_ = (IEnumerable<Extension>)((o_ as DomainResource).Extension);
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension Extension) {
            FhirUri p_ = Extension?.UrlElement;
            string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
            bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
            return r_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_, b_);

        IEnumerable<Extension> d_(Extension Extension) {
            List<Extension> s_ = Extension?.Extension;
            return (IEnumerable<Extension>)s_;
        }

        IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
        IEnumerable<IEnumerable<Extension>> f_ = context.Operators.Distinct<IEnumerable<Extension>>(e_);
        IEnumerable<Extension> g_ = context.Operators.Flatten<Extension>(f_);

        bool? h_(Extension E) {
            FhirUri t_ = E?.UrlElement;
            string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
            bool? v_ = context.Operators.Equal(u_, "ombCategory");
            bool? w_ = context.Operators.Equal(u_, "detailed");
            bool? x_ = context.Operators.Or(v_, w_);
            return x_;
        }

        IEnumerable<Extension> i_ = context.Operators.Where<Extension>(g_, h_);

        Coding j_(Extension E) {
            DataType y_ = E?.Value;
            return y_ as Coding;
        }

        IEnumerable<Coding> k_ = context.Operators.Select<Extension, Coding>(i_, j_);
        IEnumerable<Coding> l_ = context.Operators.Distinct<Coding>(k_);
        return l_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 4904475433496785684L;

    private IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Payer(context);
        IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));

        (CqlTupleMetadata, CodeableConcept code, Period period)? c_(Coverage Payer) {
            CodeableConcept f_ = Payer?.Type;
            Period g_ = Payer?.Period;
            (CqlTupleMetadata, CodeableConcept code, Period period)? h_ = (CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO, f_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> d_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CodeableConcept code, Period period)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CodeableConcept code, Period period)?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = -3244725327672300567L;

    private IEnumerable<Coding> SDE_Race_Compute(CqlContext context)
    {
        IEnumerable<Extension> a_;
        Patient m_ = this.Patient(context);
        bool n_ = m_ is DomainResource;
        if (n_)
        {
            Patient o_ = this.Patient(context);
            a_ = (IEnumerable<Extension>)((o_ as DomainResource).Extension);
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension Extension) {
            FhirUri p_ = Extension?.UrlElement;
            string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
            bool? r_ = context.Operators.Equal(q_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
            return r_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_, b_);

        IEnumerable<Extension> d_(Extension Extension) {
            List<Extension> s_ = Extension?.Extension;
            return (IEnumerable<Extension>)s_;
        }

        IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
        IEnumerable<IEnumerable<Extension>> f_ = context.Operators.Distinct<IEnumerable<Extension>>(e_);
        IEnumerable<Extension> g_ = context.Operators.Flatten<Extension>(f_);

        bool? h_(Extension E) {
            FhirUri t_ = E?.UrlElement;
            string u_ = FHIRHelpers_4_0_001.Instance.ToString(context, t_);
            bool? v_ = context.Operators.Equal(u_, "ombCategory");
            bool? w_ = context.Operators.Equal(u_, "detailed");
            bool? x_ = context.Operators.Or(v_, w_);
            return x_;
        }

        IEnumerable<Extension> i_ = context.Operators.Where<Extension>(g_, h_);

        Coding j_(Extension E) {
            DataType y_ = E?.Value;
            return y_ as Coding;
        }

        IEnumerable<Coding> k_ = context.Operators.Select<Extension, Coding>(i_, j_);
        IEnumerable<Coding> l_ = context.Operators.Distinct<Coding>(k_);
        return l_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -2169573021106346265L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Code<AdministrativeGender> b_ = a_?.GenderElement;
        string c_ = FHIRHelpers_4_0_001.Instance.ToString(context, b_);
        bool? d_ = context.Operators.Equal(c_, "male");
        if (d_ ?? false)
        {
            return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Male");
        }
        else
        {
            Patient e_ = this.Patient(context);
            Code<AdministrativeGender> f_ = e_?.GenderElement;
            string g_ = FHIRHelpers_4_0_001.Instance.ToString(context, f_);
            bool? h_ = context.Operators.Equal(g_, "female");
            if (h_ ?? false)
            {
                return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Female");
            }
            else
            {
                return default;
            }
        }
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private SupplementalDataElementsFHIR4_2_0_000() {}

    public static SupplementalDataElementsFHIR4_2_0_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "SupplementalDataElementsFHIR4";
    public string Version => "2.0.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO = new(
       [typeof(CodeableConcept), typeof(Period)],
       ["code", "period"]);

    #endregion CqlTupleMetadata Properties

}
