#nullable enable

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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.0.0")]
[CqlLibrary("SupplementalDataElements", "3.4.000")]
public partial class SupplementalDataElements_3_4_000 : ILibrary, ISingleton<SupplementalDataElements_3_4_000>
{
    #region ValueSets (4)

    [CqlValueSetDefinition("Ethnicity", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", valueSetVersion: null)]
    public CqlValueSet Ethnicity(CqlContext _) => _Ethnicity;
    private static readonly CqlValueSet _Ethnicity = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.837", null);

    [CqlValueSetDefinition("ONC Administrative Sex", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", valueSetVersion: null)]
    public CqlValueSet ONC_Administrative_Sex(CqlContext _) => _ONC_Administrative_Sex;
    private static readonly CqlValueSet _ONC_Administrative_Sex = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1", null);

    [CqlValueSetDefinition("Payer Type", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", valueSetVersion: null)]
    public CqlValueSet Payer_Type(CqlContext _) => _Payer_Type;
    private static readonly CqlValueSet _Payer_Type = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.3591", null);

    [CqlValueSetDefinition("Race", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", valueSetVersion: null)]
    public CqlValueSet Race(CqlContext _) => _Race;
    private static readonly CqlValueSet _Race = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.114222.4.11.836", null);

    #endregion ValueSets

    #region Functions and Expressions (5)

    [CqlExpressionDefinition("Patient")]
    public Patient? Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4263348478441094468L;

    private Patient? Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient?>? a_ = context!.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient? b_ = context!.Operators.SingletonFrom<Patient?>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -5377255478558118731L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        List<Extension?>? a_;
        Patient? i_ = this.Patient(context);
        bool j_ = i_ is DomainResource;
        if (j_)
        {
            Patient? k_ = this.Patient(context);
            a_ = ((k_ as DomainResource)!.Extension)!;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension? @this) {
            FhirUri? l_ = @this?.UrlElement!;
            string? m_ = FHIRHelpers_4_3_000.Instance.ToString(context, l_);
            bool? n_ = context!.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
            return n_;
        }

        IEnumerable<Extension?>? c_ = context!.Operators.Where<Extension?>((IEnumerable<Extension?>?)a_, b_);
        Extension? d_ = context!.Operators.SingletonFrom<Extension?>(c_);
        Extension?[]? e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? f_(Extension? E) {

            bool? o_(Extension? @this) {
                FhirUri? ag_ = @this?.UrlElement!;
                string? ah_ = FHIRHelpers_4_3_000.Instance.ToString(context, ag_);
                bool? ai_ = context!.Operators.Equal(ah_, "ombCategory");
                return ai_;
            }


            object p_(Extension? @this) {
                DataType? aj_ = @this?.Value!;
                return aj_!;
            }

            IEnumerable<object?>? q_ = context!.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(E is Element
                ? (E as Element)!.Extension
                : default), o_, p_);
            object? r_ = context!.Operators.SingletonFrom<object?>(q_);
            CqlCode? s_ = FHIRHelpers_4_3_000.Instance.ToCode(context, r_ as Coding);
            CqlCode?[]? t_ = [
                s_,
            ];

            bool? u_(Extension? @this) {
                FhirUri? ak_ = @this?.UrlElement!;
                string? al_ = FHIRHelpers_4_3_000.Instance.ToString(context, ak_);
                bool? am_ = context!.Operators.Equal(al_, "detailed");
                return am_;
            }


            object v_(Extension? @this) {
                DataType? an_ = @this?.Value!;
                return an_!;
            }

            IEnumerable<object?>? w_ = context!.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(E is Element
                ? (E as Element)!.Extension
                : default), u_, v_);

            CqlCode? x_(object? @this) {
                CqlCode? ao_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return ao_;
            }

            IEnumerable<CqlCode?>? y_ = context!.Operators.Select<object?, CqlCode?>(w_, x_);
            IEnumerable<CqlCode?>? z_ = context!.Operators.ValueSetUnion(((IEnumerable<CqlCode?>?)t_)!, y_!);

            bool? aa_(Extension? @this) {
                FhirUri? ap_ = @this?.UrlElement!;
                string? aq_ = FHIRHelpers_4_3_000.Instance.ToString(context, ap_);
                bool? ar_ = context!.Operators.Equal(aq_, "text");
                return ar_;
            }


            DataType? ab_(Extension? @this) {
                DataType? as_ = @this?.Value!;
                return as_;
            }

            IEnumerable<DataType?>? ac_ = context!.Operators.WhereSelect<Extension?, DataType?>((IEnumerable<Extension?>?)(E is Element
                ? (E as Element)!.Extension
                : default), aa_, ab_);
            DataType? ad_ = context!.Operators.SingletonFrom<DataType?>(ac_);
            string? ae_ = context!.Operators.Convert<string?>(ad_);
            (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? af_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, z_, ae_);
            return af_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)?>? g_ = context!.Operators.SelectDistinct<Extension?, (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)?>((IEnumerable<Extension?>?)e_, f_);
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? h_ = context!.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)?>(g_);
        return h_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 441587053582915267L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? SDE_Payer_Compute(CqlContext context)
    {
        CqlValueSet? a_ = this.Payer_Type(context);
        IEnumerable<Coverage?>? b_ = context!.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));

        (CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)? c_(Coverage? Payer) {
            CodeableConcept? e_ = Payer?.Type!;
            CqlConcept? f_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, e_);
            Period? g_ = Payer?.Period!;
            CqlInterval<CqlDateTime?>? h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, g_);
            (CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)? i_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, f_, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>? d_ = context!.Operators.SelectDistinct<Coverage?, (CqlTupleMetadata, CqlConcept? code, CqlInterval<CqlDateTime?>? period)?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 611400612990559444L;

    private (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? SDE_Race_Compute(CqlContext context)
    {
        List<Extension?>? a_;
        Patient? i_ = this.Patient(context);
        bool j_ = i_ is DomainResource;
        if (j_)
        {
            Patient? k_ = this.Patient(context);
            a_ = ((k_ as DomainResource)!.Extension)!;
        }
        else
        {
            a_ = default;
        }

        bool? b_(Extension? @this) {
            FhirUri? l_ = @this?.UrlElement!;
            string? m_ = FHIRHelpers_4_3_000.Instance.ToString(context, l_);
            bool? n_ = context!.Operators.Equal(m_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
            return n_;
        }

        IEnumerable<Extension?>? c_ = context!.Operators.Where<Extension?>((IEnumerable<Extension?>?)a_, b_);
        Extension? d_ = context!.Operators.SingletonFrom<Extension?>(c_);
        Extension?[]? e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? f_(Extension? R) {

            bool? o_(Extension? @this) {
                FhirUri? af_ = @this?.UrlElement!;
                string? ag_ = FHIRHelpers_4_3_000.Instance.ToString(context, af_);
                bool? ah_ = context!.Operators.Equal(ag_, "ombCategory");
                return ah_;
            }


            object p_(Extension? @this) {
                DataType? ai_ = @this?.Value!;
                return ai_!;
            }

            IEnumerable<object?>? q_ = context!.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(R is Element
                ? (R as Element)!.Extension
                : default), o_, p_);

            CqlCode? r_(object? @this) {
                CqlCode? aj_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return aj_;
            }

            IEnumerable<CqlCode?>? s_ = context!.Operators.Select<object?, CqlCode?>(q_, r_);

            bool? t_(Extension? @this) {
                FhirUri? ak_ = @this?.UrlElement!;
                string? al_ = FHIRHelpers_4_3_000.Instance.ToString(context, ak_);
                bool? am_ = context!.Operators.Equal(al_, "detailed");
                return am_;
            }


            object u_(Extension? @this) {
                DataType? an_ = @this?.Value!;
                return an_!;
            }

            IEnumerable<object?>? v_ = context!.Operators.WhereSelect<Extension?, object?>((IEnumerable<Extension?>?)(R is Element
                ? (R as Element)!.Extension
                : default), t_, u_);

            CqlCode? w_(object? @this) {
                CqlCode? ao_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return ao_;
            }

            IEnumerable<CqlCode?>? x_ = context!.Operators.Select<object?, CqlCode?>(v_, w_);
            IEnumerable<CqlCode?>? y_ = context!.Operators.ValueSetUnion(s_!, x_!);

            bool? z_(Extension? @this) {
                FhirUri? ap_ = @this?.UrlElement!;
                string? aq_ = FHIRHelpers_4_3_000.Instance.ToString(context, ap_);
                bool? ar_ = context!.Operators.Equal(aq_, "text");
                return ar_;
            }


            DataType? aa_(Extension? @this) {
                DataType? as_ = @this?.Value!;
                return as_;
            }

            IEnumerable<DataType?>? ab_ = context!.Operators.WhereSelect<Extension?, DataType?>((IEnumerable<Extension?>?)(R is Element
                ? (R as Element)!.Extension
                : default), z_, aa_);
            DataType? ac_ = context!.Operators.SingletonFrom<DataType?>(ab_);
            string? ad_ = context!.Operators.Convert<string?>(ac_);
            (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? ae_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, y_, ad_);
            return ae_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)?>? g_ = context!.Operators.SelectDistinct<Extension?, (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)?>((IEnumerable<Extension?>?)e_, f_);
        (CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)? h_ = context!.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode?>? codes, string? display)?>(g_);
        return h_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode? SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4862447719526612531L;

    private CqlCode? SDE_Sex_Compute(CqlContext context)
    {
        Patient? a_ = this.Patient(context);
        Code<AdministrativeGender>? b_ = a_?.GenderElement!;
        AdministrativeGender? c_ = b_?.Value!;
        string? d_ = context!.Operators.Convert<string?>(c_);
        bool? e_ = context!.Operators.Equal(d_, "male");
        if (e_ ?? false)
        {
            return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Male");
        }
        else
        {
            Patient? f_ = this.Patient(context);
            Code<AdministrativeGender>? g_ = f_?.GenderElement!;
            AdministrativeGender? h_ = g_?.Value!;
            string? i_ = context!.Operators.Convert<string?>(h_);
            bool? j_ = context!.Operators.Equal(i_, "female");
            if (j_ ?? false)
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

    private SupplementalDataElements_3_4_000() {}

    public static SupplementalDataElements_3_4_000 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "SupplementalDataElements";
    public string Version => "3.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_3_000.Instance];

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
