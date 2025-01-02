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

[assembly: Hl7.Cql.Abstractions.CqlLibraryAttribute("SupplementalDataElementsFHIR4", "2.0.000")]
[assembly: AssemblyVersion("2.0.8.0")]

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.8.0")]
[CqlLibrary("SupplementalDataElementsFHIR4", "2.0.000")]
public partial class SupplementalDataElementsFHIR4_2_0_000 : ILibrary, ISingleton<SupplementalDataElementsFHIR4_2_0_000>
{
    private SupplementalDataElementsFHIR4_2_0_000() {}

    public static SupplementalDataElementsFHIR4_2_0_000 Instance { get; } = new();

    #region Library Members
    string ILibrary.Name => "SupplementalDataElementsFHIR4";
    string ILibrary.Version => "2.0.000";
    IReadOnlyList<ILibrary> ILibrary.Dependencies => [FHIRHelpers_4_0_001.Instance];
    #endregion Library Members

    [CqlDeclaration("Ethnicity")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837")]
    public CqlValueSet Ethnicity(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", default);



    [CqlDeclaration("ONC Administrative Sex")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1")]
    public CqlValueSet ONC_Administrative_Sex(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", default);



    [CqlDeclaration("Payer")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591")]
    public CqlValueSet Payer(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", default);



    [CqlDeclaration("Race")]
    [CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836")]
    public CqlValueSet Race(CqlContext context) => 
        new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", default);



    [CqlDeclaration("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);

        return b_;
    }



    [CqlDeclaration("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context)
    {
        IEnumerable<Extension> a_()
        {
            bool m_()
            {
                Patient n_ = this.Patient(context);
                bool o_ = n_ is DomainResource;

                return o_;
            };
            if (m_())
            {
                Patient p_ = this.Patient(context);

                return (IEnumerable<Extension>)((p_ as DomainResource).Extension);
            }
            else
            {
                return default;
            }
        };
        bool? b_(Extension Extension)
        {
            string q_ = Extension?.Url;
            FhirUri r_ = context.Operators.Convert<FhirUri>(q_);
            string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
            bool? t_ = context.Operators.Equal(s_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");

            return t_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);
        IEnumerable<Extension> d_(Extension Extension)
        {
            List<Extension> u_ = Extension?.Extension;

            return (IEnumerable<Extension>)u_;
        };
        IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
        IEnumerable<IEnumerable<Extension>> f_ = context.Operators.Distinct<IEnumerable<Extension>>(e_);
        IEnumerable<Extension> g_ = context.Operators.Flatten<Extension>(f_);
        bool? h_(Extension E)
        {
            string v_ = E?.Url;
            FhirUri w_ = context.Operators.Convert<FhirUri>(v_);
            string x_ = FHIRHelpers_4_0_001.Instance.ToString(context, w_);
            bool? y_ = context.Operators.Equal(x_, "ombCategory");
            FhirUri aa_ = context.Operators.Convert<FhirUri>(v_);
            string ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_);
            bool? ac_ = context.Operators.Equal(ab_, "detailed");
            bool? ad_ = context.Operators.Or(y_, ac_);

            return ad_;
        };
        IEnumerable<Extension> i_ = context.Operators.Where<Extension>(g_, h_);
        Coding j_(Extension E)
        {
            DataType ae_ = E?.Value;

            return ae_ as Coding;
        };
        IEnumerable<Coding> k_ = context.Operators.Select<Extension, Coding>(i_, j_);
        IEnumerable<Coding> l_ = context.Operators.Distinct<Coding>(k_);

        return l_;
    }



    [CqlDeclaration("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context)
    {
        CqlValueSet a_ = this.Payer(context);
        IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/StructureDefinition/Coverage"));
        (CqlTupleMetadata, CodeableConcept code, Period period)? c_(Coverage Payer)
        {
            CodeableConcept f_ = Payer?.Type;
            Period g_ = Payer?.Period;
            (CqlTupleMetadata, CodeableConcept code, Period period)? h_ = (CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO, f_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> d_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CodeableConcept code, Period period)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CodeableConcept code, Period period)?>(d_);

        return e_;
    }



    [CqlDeclaration("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context)
    {
        IEnumerable<Extension> a_()
        {
            bool m_()
            {
                Patient n_ = this.Patient(context);
                bool o_ = n_ is DomainResource;

                return o_;
            };
            if (m_())
            {
                Patient p_ = this.Patient(context);

                return (IEnumerable<Extension>)((p_ as DomainResource).Extension);
            }
            else
            {
                return default;
            }
        };
        bool? b_(Extension Extension)
        {
            string q_ = Extension?.Url;
            FhirUri r_ = context.Operators.Convert<FhirUri>(q_);
            string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
            bool? t_ = context.Operators.Equal(s_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");

            return t_;
        };
        IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);
        IEnumerable<Extension> d_(Extension Extension)
        {
            List<Extension> u_ = Extension?.Extension;

            return (IEnumerable<Extension>)u_;
        };
        IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
        IEnumerable<IEnumerable<Extension>> f_ = context.Operators.Distinct<IEnumerable<Extension>>(e_);
        IEnumerable<Extension> g_ = context.Operators.Flatten<Extension>(f_);
        bool? h_(Extension E)
        {
            string v_ = E?.Url;
            FhirUri w_ = context.Operators.Convert<FhirUri>(v_);
            string x_ = FHIRHelpers_4_0_001.Instance.ToString(context, w_);
            bool? y_ = context.Operators.Equal(x_, "ombCategory");
            FhirUri aa_ = context.Operators.Convert<FhirUri>(v_);
            string ab_ = FHIRHelpers_4_0_001.Instance.ToString(context, aa_);
            bool? ac_ = context.Operators.Equal(ab_, "detailed");
            bool? ad_ = context.Operators.Or(y_, ac_);

            return ad_;
        };
        IEnumerable<Extension> i_ = context.Operators.Where<Extension>(g_, h_);
        Coding j_(Extension E)
        {
            DataType ae_ = E?.Value;

            return ae_ as Coding;
        };
        IEnumerable<Coding> k_ = context.Operators.Select<Extension, Coding>(i_, j_);
        IEnumerable<Coding> l_ = context.Operators.Distinct<Coding>(k_);

        return l_;
    }



    [CqlDeclaration("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode a_()
        {
            bool b_()
            {
                Patient d_ = this.Patient(context);
                Code<AdministrativeGender> e_ = d_?.GenderElement;
                string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
                bool? g_ = context.Operators.Equal(f_, "male");

                return g_ ?? false;
            };
            bool c_()
            {
                Patient h_ = this.Patient(context);
                Code<AdministrativeGender> i_ = h_?.GenderElement;
                string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
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


    private static CqlTupleMetadata CqlTupleMetadata_CaKghTfWMNOTHSWhifjFZOVYO = new(
        [typeof(CodeableConcept), typeof(Period)],
        ["code", "period"]);

}
