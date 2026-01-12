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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.0.0.0")]
[CqlLibrary("SupplementalDataElementsFHIR4", "2.0.000")]
public partial class SupplementalDataElementsFHIR4_2_0_000 : ILibrary, ISingleton<SupplementalDataElementsFHIR4_2_0_000>
{
    #region ValueSets

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

    #region Functions and Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<Patient>(3271385348303762692L, () => {
            IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
            Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
            return b_;
        });


    [CqlExpressionDefinition("SDE Ethnicity")]
    public IEnumerable<Coding> SDE_Ethnicity(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Coding>>(3271385362562834092L, () => {

            IEnumerable<Extension> a_() {

                bool m_() {
                    Patient n_ = this.Patient(context);
                    bool o_ = n_ is DomainResource;
                    return o_;
                }

                if (m_())
                {
                    Patient p_ = this.Patient(context);
                    return (IEnumerable<Extension>)((p_ as DomainResource).Extension);
                }
                else
                {
                    return default;
                };
            }


            bool? b_(Extension Extension) {
                FhirUri q_ = Extension?.UrlElement;
                string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
                bool? s_ = context.Operators.Equal(r_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
                return s_;
            }

            IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);

            IEnumerable<Extension> d_(Extension Extension) {
                List<Extension> t_ = Extension?.Extension;
                return (IEnumerable<Extension>)t_;
            }

            IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
            IEnumerable<IEnumerable<Extension>> f_ = context.Operators.Distinct<IEnumerable<Extension>>(e_);
            IEnumerable<Extension> g_ = context.Operators.Flatten<Extension>(f_);

            bool? h_(Extension E) {
                FhirUri u_ = E?.UrlElement;
                string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
                bool? w_ = context.Operators.Equal(v_, "ombCategory");
                string y_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
                bool? z_ = context.Operators.Equal(y_, "detailed");
                bool? aa_ = context.Operators.Or(w_, z_);
                return aa_;
            }

            IEnumerable<Extension> i_ = context.Operators.Where<Extension>(g_, h_);

            Coding j_(Extension E) {
                DataType ab_ = E?.Value;
                return ab_ as Coding;
            }

            IEnumerable<Coding> k_ = context.Operators.Select<Extension, Coding>(i_, j_);
            IEnumerable<Coding> l_ = context.Operators.Distinct<Coding>(k_);
            return l_;
        });


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?> SDE_Payer(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<(CqlTupleMetadata, CodeableConcept code, Period period)?>>(3271385363327756204L, () => {
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
        });


    [CqlExpressionDefinition("SDE Race")]
    public IEnumerable<Coding> SDE_Race(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<IEnumerable<Coding>>(3271385356105001052L, () => {

            IEnumerable<Extension> a_() {

                bool m_() {
                    Patient n_ = this.Patient(context);
                    bool o_ = n_ is DomainResource;
                    return o_;
                }

                if (m_())
                {
                    Patient p_ = this.Patient(context);
                    return (IEnumerable<Extension>)((p_ as DomainResource).Extension);
                }
                else
                {
                    return default;
                };
            }


            bool? b_(Extension Extension) {
                FhirUri q_ = Extension?.UrlElement;
                string r_ = FHIRHelpers_4_0_001.Instance.ToString(context, q_);
                bool? s_ = context.Operators.Equal(r_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
                return s_;
            }

            IEnumerable<Extension> c_ = context.Operators.Where<Extension>(a_(), b_);

            IEnumerable<Extension> d_(Extension Extension) {
                List<Extension> t_ = Extension?.Extension;
                return (IEnumerable<Extension>)t_;
            }

            IEnumerable<IEnumerable<Extension>> e_ = context.Operators.Select<Extension, IEnumerable<Extension>>(c_, d_);
            IEnumerable<IEnumerable<Extension>> f_ = context.Operators.Distinct<IEnumerable<Extension>>(e_);
            IEnumerable<Extension> g_ = context.Operators.Flatten<Extension>(f_);

            bool? h_(Extension E) {
                FhirUri u_ = E?.UrlElement;
                string v_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
                bool? w_ = context.Operators.Equal(v_, "ombCategory");
                string y_ = FHIRHelpers_4_0_001.Instance.ToString(context, u_);
                bool? z_ = context.Operators.Equal(y_, "detailed");
                bool? aa_ = context.Operators.Or(w_, z_);
                return aa_;
            }

            IEnumerable<Extension> i_ = context.Operators.Where<Extension>(g_, h_);

            Coding j_(Extension E) {
                DataType ab_ = E?.Value;
                return ab_ as Coding;
            }

            IEnumerable<Coding> k_ = context.Operators.Select<Extension, Coding>(i_, j_);
            IEnumerable<Coding> l_ = context.Operators.Distinct<Coding>(k_);
            return l_;
        });


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        ((ICqlContextInternals)context).GetOrCompute<CqlCode>(3271385348692995544L, () => {

            CqlCode a_() {

                bool b_() {
                    Patient d_ = this.Patient(context);
                    Code<AdministrativeGender> e_ = d_?.GenderElement;
                    string f_ = FHIRHelpers_4_0_001.Instance.ToString(context, e_);
                    bool? g_ = context.Operators.Equal(f_, "male");
                    return g_ ?? false;
                }


                bool c_() {
                    Patient h_ = this.Patient(context);
                    Code<AdministrativeGender> i_ = h_?.GenderElement;
                    string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
                    bool? k_ = context.Operators.Equal(j_, "female");
                    return k_ ?? false;
                }

                if (b_())
                {
                    return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Male");
                }
                else if (c_())
                {
                    return new CqlCode("F", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Female");
                }
                else
                {
                    return default;
                };
            }

            return a_();
        });


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
