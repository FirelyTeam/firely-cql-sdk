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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.1.2.0")]
[CqlLibrary("SupplementalDataElements", "5.1.000")]
public partial class SupplementalDataElements_5_1_000 : ILibrary, ISingleton<SupplementalDataElements_5_1_000>
{
    #region ValueSets (4)

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("Federal Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.121", valueSetVersion: null)]
    public CqlValueSet Federal_Administrative_Sex(CqlContext _) => _Federal_Administrative_Sex;
    private static readonly CqlValueSet _Federal_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1021.121", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    #endregion ValueSets

    #region Codes (2)

    [CqlCodeDefinition("Male (finding)", codeId: "248153007", codeSystem: "http://snomed.info/sct")]
    public CqlCode Male__finding_(CqlContext _) => _Male__finding_;
    private static readonly CqlCode _Male__finding_ = new CqlCode("248153007", "http://snomed.info/sct");

    [CqlCodeDefinition("Female (finding)", codeId: "248152002", codeSystem: "http://snomed.info/sct")]
    public CqlCode Female__finding_(CqlContext _) => _Female__finding_;
    private static readonly CqlCode _Female__finding_ = new CqlCode("248152002", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems (1)

    [CqlCodeSystemDefinition("SNOMEDCT", codeSystemId: "http://snomed.info/sct", codeSystemVersion: null)]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Male__finding_,
          _Female__finding_]);

    #endregion CodeSystems

    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 641761058615526661L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = 5036509334694701448L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {

        List<Extension> a_() {

            bool j_() {
                Patient k_ = this.Patient(context);
                bool l_ = k_ is DomainResource;
                return l_;
            }

            if (j_())
            {
                Patient m_ = this.Patient(context);
                return (m_ as DomainResource).Extension;
            }
            else
            {
                return default;
            };
        }


        bool? b_(Extension @this) {
            FhirUri n_ = @this?.UrlElement;
            string o_ = FHIRHelpers_4_4_000.Instance.ToString(context, n_);
            bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
            return p_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension E) {

            bool? q_(Extension @this) {
                FhirUri al_ = @this?.UrlElement;
                string am_ = FHIRHelpers_4_4_000.Instance.ToString(context, al_);
                bool? an_ = context.Operators.Equal(am_, "ombCategory");
                return an_;
            }

            IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), q_);

            object s_(Extension @this) {
                DataType ao_ = @this?.Value;
                return ao_;
            }

            IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);
            object u_ = context.Operators.SingletonFrom<object>(t_);
            CqlCode v_ = FHIRHelpers_4_4_000.Instance.ToCode(context, u_ as Coding);
            CqlCode[] w_ = [
                v_,
            ];

            bool? x_(Extension @this) {
                FhirUri ap_ = @this?.UrlElement;
                string aq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ap_);
                bool? ar_ = context.Operators.Equal(aq_, "detailed");
                return ar_;
            }

            IEnumerable<Extension> y_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), x_);

            object z_(Extension @this) {
                DataType as_ = @this?.Value;
                return as_;
            }

            IEnumerable<object> aa_ = context.Operators.Select<Extension, object>(y_, z_);

            CqlCode ab_(object @this) {
                CqlCode at_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return at_;
            }

            IEnumerable<CqlCode> ac_ = context.Operators.Select<object, CqlCode>(aa_, ab_);
            IEnumerable<CqlCode> ad_ = context.Operators.ValueSetUnion((IEnumerable<CqlCode>)w_, ac_);

            bool? ae_(Extension @this) {
                FhirUri au_ = @this?.UrlElement;
                string av_ = FHIRHelpers_4_4_000.Instance.ToString(context, au_);
                bool? aw_ = context.Operators.Equal(av_, "text");
                return aw_;
            }

            IEnumerable<Extension> af_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), ae_);

            DataType ag_(Extension @this) {
                DataType ax_ = @this?.Value;
                return ax_;
            }

            IEnumerable<DataType> ah_ = context.Operators.Select<Extension, DataType>(af_, ag_);
            DataType ai_ = context.Operators.SingletonFrom<DataType>(ah_);
            string aj_ = context.Operators.Convert<string>(ai_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ak_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ad_, aj_);
            return ak_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 3374191463006709211L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Payer_Type(context);
        IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));

        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer) {
            CodeableConcept f_ = Payer?.Type;
            CqlConcept g_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, f_);
            Period h_ = Payer?.Period;
            CqlInterval<CqlDateTime> i_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, h_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? j_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, g_, i_);
            return j_;
        }

        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.Select<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(d_);
        return e_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 8821701969343059556L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {

        List<Extension> a_() {

            bool j_() {
                Patient k_ = this.Patient(context);
                bool l_ = k_ is DomainResource;
                return l_;
            }

            if (j_())
            {
                Patient m_ = this.Patient(context);
                return (m_ as DomainResource).Extension;
            }
            else
            {
                return default;
            };
        }


        bool? b_(Extension @this) {
            FhirUri n_ = @this?.UrlElement;
            string o_ = FHIRHelpers_4_4_000.Instance.ToString(context, n_);
            bool? p_ = context.Operators.Equal(o_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
            return p_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(a_()), b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension R) {

            bool? q_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                bool? am_ = context.Operators.Equal(al_, "ombCategory");
                return am_;
            }

            IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), q_);

            object s_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> t_ = context.Operators.Select<Extension, object>(r_, s_);

            CqlCode u_(object @this) {
                CqlCode ao_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return ao_;
            }

            IEnumerable<CqlCode> v_ = context.Operators.Select<object, CqlCode>(t_, u_);

            bool? w_(Extension @this) {
                FhirUri ap_ = @this?.UrlElement;
                string aq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ap_);
                bool? ar_ = context.Operators.Equal(aq_, "detailed");
                return ar_;
            }

            IEnumerable<Extension> x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), w_);

            object y_(Extension @this) {
                DataType as_ = @this?.Value;
                return as_;
            }

            IEnumerable<object> z_ = context.Operators.Select<Extension, object>(x_, y_);

            CqlCode aa_(object @this) {
                CqlCode at_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return at_;
            }

            IEnumerable<CqlCode> ab_ = context.Operators.Select<object, CqlCode>(z_, aa_);
            IEnumerable<CqlCode> ac_ = context.Operators.ValueSetUnion(v_, ab_);

            bool? ad_(Extension @this) {
                FhirUri au_ = @this?.UrlElement;
                string av_ = FHIRHelpers_4_4_000.Instance.ToString(context, au_);
                bool? aw_ = context.Operators.Equal(av_, "text");
                return aw_;
            }

            IEnumerable<Extension> ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), ad_);

            DataType af_(Extension @this) {
                DataType ax_ = @this?.Value;
                return ax_;
            }

            IEnumerable<DataType> ag_ = context.Operators.Select<Extension, DataType>(ae_, af_);
            DataType ah_ = context.Operators.SingletonFrom<DataType>(ag_);
            string ai_ = context.Operators.Convert<string>(ah_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? aj_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ac_, ai_);
            return aj_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.Select<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -9150227342082415267L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {

        CqlCode a_() {

            bool b_() {

                List<Extension> d_() {

                    bool k_() {
                        Patient l_ = this.Patient(context);
                        bool m_ = l_ is DomainResource;
                        return m_;
                    }

                    if (k_())
                    {
                        Patient n_ = this.Patient(context);
                        return (n_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    };
                }


                bool? e_(Extension @this) {
                    FhirUri o_ = @this?.UrlElement;
                    string p_ = FHIRHelpers_4_4_000.Instance.ToString(context, o_);
                    bool? q_ = context.Operators.Equal(p_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                    return q_;
                }

                IEnumerable<Extension> f_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(d_()), e_);

                DataType g_(Extension @this) {
                    DataType r_ = @this?.Value;
                    return r_;
                }

                IEnumerable<DataType> h_ = context.Operators.Select<Extension, DataType>(f_, g_);
                DataType i_ = context.Operators.SingletonFrom<DataType>(h_);
                bool? j_ = context.Operators.Equal(i_, "248153007");
                return j_ ?? false;
            }


            bool c_() {

                List<Extension> s_() {

                    bool z_() {
                        Patient aa_ = this.Patient(context);
                        bool ab_ = aa_ is DomainResource;
                        return ab_;
                    }

                    if (z_())
                    {
                        Patient ac_ = this.Patient(context);
                        return (ac_ as DomainResource).Extension;
                    }
                    else
                    {
                        return default;
                    };
                }


                bool? t_(Extension @this) {
                    FhirUri ad_ = @this?.UrlElement;
                    string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                    bool? af_ = context.Operators.Equal(ae_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                    return af_;
                }

                IEnumerable<Extension> u_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(s_()), t_);

                DataType v_(Extension @this) {
                    DataType ag_ = @this?.Value;
                    return ag_;
                }

                IEnumerable<DataType> w_ = context.Operators.Select<Extension, DataType>(u_, v_);
                DataType x_ = context.Operators.SingletonFrom<DataType>(w_);
                bool? y_ = context.Operators.Equal(x_, "248152002");
                return y_ ?? false;
            }

            if (b_())
            {
                CqlCode ah_ = this.Male__finding_(context);
                return ah_;
            }
            else if (c_())
            {
                CqlCode ai_ = this.Female__finding_(context);
                return ai_;
            }
            else
            {
                return default;
            };
        }

        return a_();
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private SupplementalDataElements_5_1_000() {}

    public static SupplementalDataElements_5_1_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "SupplementalDataElements";
    public string Version => "5.1.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ = new(
       [typeof(CqlConcept), typeof(CqlInterval<CqlDateTime>)],
       ["code", "period"]);

    private static CqlTupleMetadata CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR = new(
       [typeof(IEnumerable<CqlCode>), typeof(string)],
       ["codes", "display"]);

    #endregion CqlTupleMetadata Properties

}
