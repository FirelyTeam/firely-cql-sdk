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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.0.0")]
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
        Patient i_ = this.Patient(context);
        bool j_ = i_ is DomainResource;
        if (j_)
        {
            Patient k_ = this.Patient(context);
            a_ = (k_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri l_ = @this?.UrlElement;
            string m_ = FHIRHelpers_4_4_000.Instance.ToString(context, l_);
            bool? n_ = context.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
            return n_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension E) {

            bool? o_(Extension @this) {
                FhirUri ag_ = @this?.UrlElement;
                string ah_ = FHIRHelpers_4_4_000.Instance.ToString(context, ag_);
                bool? ai_ = context.Operators.Equal(ah_, "ombCategory");
                return ai_;
            }


            object p_(Extension @this) {
                DataType aj_ = @this?.Value;
                return aj_;
            }

            IEnumerable<object> q_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), o_, p_);
            object r_ = context.Operators.SingletonFrom<object>(q_);
            CqlCode s_ = FHIRHelpers_4_4_000.Instance.ToCode(context, r_ as Coding);
            CqlCode[] t_ = [
                s_,
            ];

            bool? u_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                bool? am_ = context.Operators.Equal(al_, "detailed");
                return am_;
            }


            object v_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> w_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), u_, v_);

            CqlCode x_(object @this) {
                CqlCode ao_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return ao_;
            }

            IEnumerable<CqlCode> y_ = context.Operators.Select<object, CqlCode>(w_, x_);
            IEnumerable<CqlCode> z_ = context.Operators.ValueSetUnion((IEnumerable<CqlCode>)t_, y_);

            bool? aa_(Extension @this) {
                FhirUri ap_ = @this?.UrlElement;
                string aq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ap_);
                bool? ar_ = context.Operators.Equal(aq_, "text");
                return ar_;
            }


            DataType ab_(Extension @this) {
                DataType as_ = @this?.Value;
                return as_;
            }

            IEnumerable<DataType> ac_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(E is Element
                ? (E as Element).Extension
                : default), aa_, ab_);
            DataType ad_ = context.Operators.SingletonFrom<DataType>(ac_);
            string ae_ = context.Operators.Convert<string>(ad_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? af_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, z_, ae_);
            return af_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.SelectDistinct<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(g_);
        return h_;
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
            CodeableConcept e_ = Payer?.Type;
            CqlConcept f_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, e_);
            Period g_ = Payer?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, g_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? i_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, f_, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.SelectDistinct<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 8821701969343059556L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        List<Extension> a_;
        Patient i_ = this.Patient(context);
        bool j_ = i_ is DomainResource;
        if (j_)
        {
            Patient k_ = this.Patient(context);
            a_ = (k_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri l_ = @this?.UrlElement;
            string m_ = FHIRHelpers_4_4_000.Instance.ToString(context, l_);
            bool? n_ = context.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
            return n_;
        }

        IEnumerable<Extension> c_ = context.Operators.Where<Extension>((IEnumerable<Extension>)a_, b_);
        Extension d_ = context.Operators.SingletonFrom<Extension>(c_);
        Extension[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? f_(Extension R) {

            bool? o_(Extension @this) {
                FhirUri af_ = @this?.UrlElement;
                string ag_ = FHIRHelpers_4_4_000.Instance.ToString(context, af_);
                bool? ah_ = context.Operators.Equal(ag_, "ombCategory");
                return ah_;
            }


            object p_(Extension @this) {
                DataType ai_ = @this?.Value;
                return ai_;
            }

            IEnumerable<object> q_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), o_, p_);

            CqlCode r_(object @this) {
                CqlCode aj_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return aj_;
            }

            IEnumerable<CqlCode> s_ = context.Operators.Select<object, CqlCode>(q_, r_);

            bool? t_(Extension @this) {
                FhirUri ak_ = @this?.UrlElement;
                string al_ = FHIRHelpers_4_4_000.Instance.ToString(context, ak_);
                bool? am_ = context.Operators.Equal(al_, "detailed");
                return am_;
            }


            object u_(Extension @this) {
                DataType an_ = @this?.Value;
                return an_;
            }

            IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), t_, u_);

            CqlCode w_(object @this) {
                CqlCode ao_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return ao_;
            }

            IEnumerable<CqlCode> x_ = context.Operators.Select<object, CqlCode>(v_, w_);
            IEnumerable<CqlCode> y_ = context.Operators.ValueSetUnion(s_, x_);

            bool? z_(Extension @this) {
                FhirUri ap_ = @this?.UrlElement;
                string aq_ = FHIRHelpers_4_4_000.Instance.ToString(context, ap_);
                bool? ar_ = context.Operators.Equal(aq_, "text");
                return ar_;
            }


            DataType aa_(Extension @this) {
                DataType as_ = @this?.Value;
                return as_;
            }

            IEnumerable<DataType> ab_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)(R is Element
                ? (R as Element).Extension
                : default), z_, aa_);
            DataType ac_ = context.Operators.SingletonFrom<DataType>(ab_);
            string ad_ = context.Operators.Convert<string>(ac_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ae_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, y_, ad_);
            return ae_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> g_ = context.Operators.SelectDistinct<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)e_, f_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(g_);
        return h_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -9150227342082415267L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        List<Extension> a_;
        Patient g_ = this.Patient(context);
        bool h_ = g_ is DomainResource;
        if (h_)
        {
            Patient i_ = this.Patient(context);
            a_ = (i_ as DomainResource).Extension;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_4_000.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return l_;
        }


        DataType c_(Extension @this) {
            DataType m_ = @this?.Value;
            return m_;
        }

        IEnumerable<DataType> d_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)a_, b_, c_);
        DataType e_ = context.Operators.SingletonFrom<DataType>(d_);
        bool? f_ = context.Operators.Equal(e_, "248153007");
        if (f_ ?? false)
        {
            CqlCode n_ = this.Male__finding_(context);
            return n_;
        }
        else
        {
            List<Extension> o_;
            Patient u_ = this.Patient(context);
            bool v_ = u_ is DomainResource;
            if (v_)
            {
                Patient w_ = this.Patient(context);
                o_ = (w_ as DomainResource).Extension;
            }
            else
            {
                o_ = default;
            }

            bool? p_(Extension @this) {
                FhirUri x_ = @this?.UrlElement;
                string y_ = FHIRHelpers_4_4_000.Instance.ToString(context, x_);
                bool? z_ = context.Operators.Equal(y_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return z_;
            }


            DataType q_(Extension @this) {
                DataType aa_ = @this?.Value;
                return aa_;
            }

            IEnumerable<DataType> r_ = context.Operators.WhereSelect<Extension, DataType>((IEnumerable<Extension>)o_, p_, q_);
            DataType s_ = context.Operators.SingletonFrom<DataType>(r_);
            bool? t_ = context.Operators.Equal(s_, "248152002");
            if (t_ ?? false)
            {
                CqlCode ab_ = this.Female__finding_(context);
                return ab_;
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
