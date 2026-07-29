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
        List<Extension> a_;
        Patient j_ = this.Patient(context);
        bool k_ = j_ is DomainResource;
        if (k_)
        {
            Patient l_ = this.Patient(context);
            a_ = (l_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri m_ = @this?.UrlElement;
            string n_ = FHIRHelpers_4_4_000.Instance.ToString(context, m_);
            bool? o_ = context.Operators.Equal(n_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
            return o_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension E) {

            bool? p_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                bool? am_ = context.Operators.Equal(al_, "ombCategory");
                return am_;
            }

            IEnumerable<Extension> q_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), p_);

            object r_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> s_ = context.Operators.Select<Extension, object>(q_, r_);
            object t_ = context.Operators.SingletonFrom<object>(s_);
            CqlCode u_ = FHIRHelpers_4_4_000.Instance.ToCode(context, t_ as Coding);
            CqlCode[] v_ = [
                u_,
            ];

            bool? w_(Extension @this) {
                FhirUri ao_ = @this?.UrlElement;
                string ap_ = FHIRHelpers_4_4_000.Instance.ToString(context, ao_);
                bool? aq_ = context.Operators.Equal(ap_, "detailed");
                return aq_;
            }

            IEnumerable<Extension> x_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), w_);

            object y_(Extension @this) {
                DataType ar_ = @this?.Value;
                return ar_;
            }

            IEnumerable<object> z_ = context.Operators.Select<Extension, object>(x_, y_);

            CqlCode aa_(object @this) {
                CqlCode as_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return as_;
            }

            IEnumerable<CqlCode> ab_ = context.Operators.Select<object, CqlCode>(z_, aa_);
            IEnumerable<CqlCode> ac_ = context.Operators.ValueSetUnion((IEnumerable<CqlCode>)v_, ab_);

            bool? ad_(Extension @this) {
                FhirUri at_ = @this?.UrlElement;
                string au_ = FHIRHelpers_4_4_000.Instance.ToString(context, at_);
                bool? av_ = context.Operators.Equal(au_, "text");
                return av_;
            }

            IEnumerable<Extension> ae_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), ad_);

            DataType af_(Extension @this) {
                DataType aw_ = @this?.Value;
                return aw_;
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
        List<Extension> a_;
        Patient j_ = this.Patient(context);
        bool k_ = j_ is DomainResource;
        if (k_)
        {
            Patient l_ = this.Patient(context);
            a_ = (l_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri m_ = @this?.UrlElement;
            string n_ = FHIRHelpers_4_4_000.Instance.ToString(context, m_);
            bool? o_ = context.Operators.Equal(n_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
            return o_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension R) {

            bool? p_(Extension @this) {
                FhirUri aj_ = @this?.UrlElement;
                string ak_ = FHIRHelpers_4_4_000.Instance.ToString(context, aj_);
                bool? al_ = context.Operators.Equal(ak_, "ombCategory");
                return al_;
            }

            IEnumerable<Extension> q_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), p_);

            object r_(Extension @this) {
                DataType am_ = @this?.Value;
                return am_;
            }

            IEnumerable<object> s_ = context.Operators.Select<Extension, object>(q_, r_);

            CqlCode t_(object @this) {
                CqlCode an_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return an_;
            }

            IEnumerable<CqlCode> u_ = context.Operators.Select<object, CqlCode>(s_, t_);

            bool? v_(Extension @this) {
                FhirUri ao_ = @this?.UrlElement;
                string ap_ = FHIRHelpers_4_4_000.Instance.ToString(context, ao_);
                bool? aq_ = context.Operators.Equal(ap_, "detailed");
                return aq_;
            }

            IEnumerable<Extension> w_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), v_);

            object x_(Extension @this) {
                DataType ar_ = @this?.Value;
                return ar_;
            }

            IEnumerable<object> y_ = context.Operators.Select<Extension, object>(w_, x_);

            CqlCode z_(object @this) {
                CqlCode as_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return as_;
            }

            IEnumerable<CqlCode> aa_ = context.Operators.Select<object, CqlCode>(y_, z_);
            IEnumerable<CqlCode> ab_ = context.Operators.ValueSetUnion(u_, aa_);

            bool? ac_(Extension @this) {
                FhirUri at_ = @this?.UrlElement;
                string au_ = FHIRHelpers_4_4_000.Instance.ToString(context, at_);
                bool? av_ = context.Operators.Equal(au_, "text");
                return av_;
            }

            IEnumerable<Extension> ad_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), ac_);

            DataType ae_(Extension @this) {
                DataType aw_ = @this?.Value;
                return aw_;
            }

            IEnumerable<DataType> af_ = context.Operators.Select<Extension, DataType>(ad_, ae_);
            DataType ag_ = context.Operators.SingletonFrom<DataType>(af_);
            string ah_ = context.Operators.Convert<string>(ag_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ai_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, ab_, ah_);
            return ai_;
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
        List<Extension> a_;
        Patient h_ = this.Patient(context);
        bool i_ = h_ is DomainResource;
        if (i_)
        {
            Patient j_ = this.Patient(context);
            a_ = (j_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri k_ = @this?.UrlElement;
            string l_ = FHIRHelpers_4_4_000.Instance.ToString(context, k_);
            bool? m_ = context.Operators.Equal(l_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return m_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);

        DataType d_(Extension @this) {
            DataType n_ = @this?.Value;
            return n_;
        }

        IEnumerable<DataType> e_ = context.Operators.Select<Extension, DataType>(c_, d_);
        DataType f_ = context.Operators.SingletonFrom<DataType>(e_);
        bool? g_ = context.Operators.Equal(f_, "248153007");
        if (g_ ?? false)
        {
            CqlCode o_ = this.Male__finding_(context);
            return o_;
        }
        else
        {
            List<Extension> p_;
            Patient w_ = this.Patient(context);
            bool x_ = w_ is DomainResource;
            if (x_)
            {
                Patient y_ = this.Patient(context);
                p_ = (y_ as DomainResource).Extension;
            }
            else
            {
                p_ = default;
            }

            bool? q_(Extension @this) {
                FhirUri z_ = @this?.UrlElement;
                string aa_ = FHIRHelpers_4_4_000.Instance.ToString(context, z_);
                bool? ab_ = context.Operators.Equal(aa_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return ab_;
            }

            IEnumerable<Extension> r_ = context.Operators.Where<Extension>((IEnumerable<Extension>)p_, q_);

            DataType s_(Extension @this) {
                DataType ac_ = @this?.Value;
                return ac_;
            }

            IEnumerable<DataType> t_ = context.Operators.Select<Extension, DataType>(r_, s_);
            DataType u_ = context.Operators.SingletonFrom<DataType>(t_);
            bool? v_ = context.Operators.Equal(u_, "248152002");
            if (v_ ?? false)
            {
                CqlCode ad_ = this.Female__finding_(context);
                return ad_;
            }
            else
            {
                return default;
            }
        }
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
