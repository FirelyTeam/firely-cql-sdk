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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.2.4.0")]
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
    public Patient Patient(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_Patient, Patient_Compute);

    private const long _cacheIndex_Patient = 4263348478441094468L;

    private Patient Patient_Compute(CqlContext context)
    {
        IEnumerable<Patient> a_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient b_ = context.Operators.SingletonFrom<Patient>(a_);
        return b_;
    }


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Ethnicity, SDE_Ethnicity_Compute);

    private const long _cacheIndex_SDE_Ethnicity = -5377255478558118731L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_3_000.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-ethnicity");
            return l_;
        }

        IEnumerable<Extension> d_ = context.Operators.Where<Extension>((IEnumerable<Extension>)b_, c_);
        Extension e_ = context.Operators.SingletonFrom<Extension>(d_);
        Extension[] f_ = [
            e_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? g_(Extension E) {
            List<Extension> m_ = E?.Extension;

            bool? n_(Extension @this) {
                FhirUri ae_ = @this?.UrlElement;
                string af_ = FHIRHelpers_4_3_000.Instance.ToString(context, ae_);
                bool? ag_ = context.Operators.Equal(af_, "ombCategory");
                return ag_;
            }


            object o_(Extension @this) {
                DataType ah_ = @this?.Value;
                return ah_;
            }

            IEnumerable<object> p_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, n_, o_);
            object q_ = context.Operators.SingletonFrom<object>(p_);
            CqlCode r_ = FHIRHelpers_4_3_000.Instance.ToCode(context, q_ as Coding);
            CqlCode[] s_ = [
                r_,
            ];

            bool? t_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_3_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "detailed");
                return ak_;
            }


            object u_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, t_, u_);

            CqlCode w_(object @this) {
                CqlCode am_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return am_;
            }

            IEnumerable<CqlCode> x_ = context.Operators.Select<object, CqlCode>(v_, w_);
            IEnumerable<CqlCode> y_ = context.Operators.ValueSetUnion((IEnumerable<CqlCode>)s_, x_);

            bool? z_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_3_000.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "text");
                return ap_;
            }


            object aa_(Extension @this) {
                DataType aq_ = @this?.Value;
                bool ar_ = aq_ is Uuid;
                if (ar_)
                {
                    string as_ = (aq_ as Uuid)?.Value;
                    return as_;
                }
                else
                {
                    bool at_ = aq_ is Oid;
                    if (at_)
                    {
                        string au_ = (aq_ as Oid)?.Value;
                        return au_;
                    }
                    else
                    {
                        bool av_ = aq_ is Markdown;
                        if (av_)
                        {
                            string aw_ = (aq_ as Markdown)?.Value;
                            return aw_;
                        }
                        else
                        {
                            bool ax_ = aq_ is Integer;
                            if (ax_)
                            {
                                int? ay_ = (aq_ as Integer)?.Value;
                                return ay_;
                            }
                            else
                            {
                                bool az_ = aq_ is Instant;
                                if (az_)
                                {
                                    DateTimeOffset? ba_ = (aq_ as Instant)?.Value;
                                    return ba_;
                                }
                                else
                                {
                                    bool bb_ = aq_ is Id;
                                    if (bb_)
                                    {
                                        string bc_ = (aq_ as Id)?.Value;
                                        return bc_;
                                    }
                                    else
                                    {
                                        bool bd_ = aq_ is Duration;
                                        if (bd_)
                                        {
                                            FhirDecimal be_ = (aq_ as Duration)?.ValueElement;
                                            return be_;
                                        }
                                        else
                                        {
                                            bool bf_ = aq_ is Distance;
                                            if (bf_)
                                            {
                                                FhirDecimal bg_ = (aq_ as Distance)?.ValueElement;
                                                return bg_;
                                            }
                                            else
                                            {
                                                bool bh_ = aq_ is FhirDecimal;
                                                if (bh_)
                                                {
                                                    decimal? bi_ = (aq_ as FhirDecimal)?.Value;
                                                    return bi_;
                                                }
                                                else
                                                {
                                                    bool bj_ = aq_ is Date;
                                                    if (bj_)
                                                    {
                                                        string bk_ = (aq_ as Date)?.Value;
                                                        return bk_;
                                                    }
                                                    else
                                                    {
                                                        bool bl_ = aq_ is Count;
                                                        if (bl_)
                                                        {
                                                            FhirDecimal bm_ = (aq_ as Count)?.ValueElement;
                                                            return bm_;
                                                        }
                                                        else
                                                        {
                                                            bool bn_ = aq_ is FhirDateTime;
                                                            if (bn_)
                                                            {
                                                                string bo_ = context.Operators.Convert<string>(aq_ as FhirDateTime);
                                                                return bo_;
                                                            }
                                                            else
                                                            {
                                                                bool bp_ = aq_ is Time;
                                                                if (bp_)
                                                                {
                                                                    string bq_ = (aq_ as Time)?.Value;
                                                                    return bq_;
                                                                }
                                                                else
                                                                {
                                                                    bool br_ = aq_ is Age;
                                                                    if (br_)
                                                                    {
                                                                        FhirDecimal bs_ = (aq_ as Age)?.ValueElement;
                                                                        return bs_;
                                                                    }
                                                                    else
                                                                    {
                                                                        bool bt_ = aq_ is FhirUrl;
                                                                        if (bt_)
                                                                        {
                                                                            string bu_ = (aq_ as FhirUrl)?.Value;
                                                                            return bu_;
                                                                        }
                                                                        else
                                                                        {
                                                                            bool bv_ = aq_ is FhirUri;
                                                                            if (bv_)
                                                                            {
                                                                                string bw_ = (aq_ as FhirUri)?.Value;
                                                                                return bw_;
                                                                            }
                                                                            else
                                                                            {
                                                                                bool bx_ = aq_ is Base64Binary;
                                                                                if (bx_)
                                                                                {
                                                                                    byte[] by_ = (aq_ as Base64Binary)?.Value;
                                                                                    return by_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    bool bz_ = aq_ is FhirBoolean;
                                                                                    if (bz_)
                                                                                    {
                                                                                        bool? ca_ = (aq_ as FhirBoolean)?.Value;
                                                                                        return ca_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        bool cb_ = aq_ is FhirString;
                                                                                        if (cb_)
                                                                                        {
                                                                                            string cc_ = (aq_ as FhirString)?.Value;
                                                                                            return cc_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            bool cd_ = aq_ is PositiveInt;
                                                                                            if (cd_)
                                                                                            {
                                                                                                int? ce_ = (aq_ as PositiveInt)?.Value;
                                                                                                return ce_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool cf_ = aq_ is Code;
                                                                                                if (cf_)
                                                                                                {
                                                                                                    string cg_ = (aq_ as Code)?.Value;
                                                                                                    return cg_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    bool ch_ = aq_ is UnsignedInt;
                                                                                                    if (ch_)
                                                                                                    {
                                                                                                        int? ci_ = (aq_ as UnsignedInt)?.Value;
                                                                                                        return ci_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        bool cj_ = aq_ is Canonical;
                                                                                                        if (cj_)
                                                                                                        {
                                                                                                            string ck_ = (aq_ as Canonical)?.Value;
                                                                                                            return ck_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            bool cl_ = aq_ is Quantity;
                                                                                                            if (cl_)
                                                                                                            {
                                                                                                                FhirDecimal cm_ = (aq_ as Quantity)?.ValueElement;
                                                                                                                return cm_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                bool cn_ = aq_ is Identifier;
                                                                                                                if (cn_)
                                                                                                                {
                                                                                                                    FhirString co_ = (aq_ as Identifier)?.ValueElement;
                                                                                                                    return co_;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    bool cp_ = aq_ is Money;
                                                                                                                    if (cp_)
                                                                                                                    {
                                                                                                                        FhirDecimal cq_ = (aq_ as Money)?.ValueElement;
                                                                                                                        return cq_;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        bool cr_ = aq_ is UsageContext;
                                                                                                                        if (cr_)
                                                                                                                        {
                                                                                                                            DataType cs_ = (aq_ as UsageContext)?.Value;
                                                                                                                            return cs_;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            bool ct_ = aq_ is ContactPoint;
                                                                                                                            if (ct_)
                                                                                                                            {
                                                                                                                                FhirString cu_ = (aq_ as ContactPoint)?.ValueElement;
                                                                                                                                return cu_;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                return null;
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            IEnumerable<object> ab_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, z_, aa_);
            object ac_ = context.Operators.SingletonFrom<object>(ab_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ad_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, y_, (string)ac_);
            return ad_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.SelectDistinct<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)f_, g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Payer, SDE_Payer_Compute);

    private const long _cacheIndex_SDE_Payer = 441587053582915267L;

    private IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer_Compute(CqlContext context)
    {
        CqlValueSet a_ = this.Payer_Type(context);
        IEnumerable<Coverage> b_ = context.Operators.Retrieve<Coverage>(new RetrieveParameters(default, a_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-coverage"));

        (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? c_(Coverage Payer) {
            CodeableConcept e_ = Payer?.Type;
            CqlConcept f_ = FHIRHelpers_4_3_000.Instance.ToConcept(context, e_);
            Period g_ = Payer?.Period;
            CqlInterval<CqlDateTime> h_ = FHIRHelpers_4_3_000.Instance.ToInterval(context, g_);
            (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)? i_ = (CqlTupleMetadata_GPRWMPNAYaJRiGDFSTLJOPeIJ, f_, h_);
            return i_;
        }

        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> d_ = context.Operators.SelectDistinct<Coverage, (CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?>(b_, c_);
        return d_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Race, SDE_Race_Compute);

    private const long _cacheIndex_SDE_Race = 611400612990559444L;

    private (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_3_000.Instance.ToString(context, j_);
            bool? l_ = context.Operators.Equal(k_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-race");
            return l_;
        }

        IEnumerable<Extension> d_ = context.Operators.Where<Extension>((IEnumerable<Extension>)b_, c_);
        Extension e_ = context.Operators.SingletonFrom<Extension>(d_);
        Extension[] f_ = [
            e_,
        ];

        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? g_(Extension R) {
            List<Extension> m_ = R?.Extension;

            bool? n_(Extension @this) {
                FhirUri ad_ = @this?.UrlElement;
                string ae_ = FHIRHelpers_4_3_000.Instance.ToString(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, "ombCategory");
                return af_;
            }


            object o_(Extension @this) {
                DataType ag_ = @this?.Value;
                return ag_;
            }

            IEnumerable<object> p_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, n_, o_);

            CqlCode q_(object @this) {
                CqlCode ah_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return ah_;
            }

            IEnumerable<CqlCode> r_ = context.Operators.Select<object, CqlCode>(p_, q_);

            bool? s_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_3_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "detailed");
                return ak_;
            }


            object t_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> u_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, s_, t_);

            CqlCode v_(object @this) {
                CqlCode am_ = FHIRHelpers_4_3_000.Instance.ToCode(context, @this as Coding);
                return am_;
            }

            IEnumerable<CqlCode> w_ = context.Operators.Select<object, CqlCode>(u_, v_);
            IEnumerable<CqlCode> x_ = context.Operators.ValueSetUnion(r_, w_);

            bool? y_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_3_000.Instance.ToString(context, an_);
                bool? ap_ = context.Operators.Equal(ao_, "text");
                return ap_;
            }


            object z_(Extension @this) {
                DataType aq_ = @this?.Value;
                bool ar_ = aq_ is Uuid;
                if (ar_)
                {
                    string as_ = (aq_ as Uuid)?.Value;
                    return as_;
                }
                else
                {
                    bool at_ = aq_ is Oid;
                    if (at_)
                    {
                        string au_ = (aq_ as Oid)?.Value;
                        return au_;
                    }
                    else
                    {
                        bool av_ = aq_ is Markdown;
                        if (av_)
                        {
                            string aw_ = (aq_ as Markdown)?.Value;
                            return aw_;
                        }
                        else
                        {
                            bool ax_ = aq_ is Integer;
                            if (ax_)
                            {
                                int? ay_ = (aq_ as Integer)?.Value;
                                return ay_;
                            }
                            else
                            {
                                bool az_ = aq_ is Instant;
                                if (az_)
                                {
                                    DateTimeOffset? ba_ = (aq_ as Instant)?.Value;
                                    return ba_;
                                }
                                else
                                {
                                    bool bb_ = aq_ is Id;
                                    if (bb_)
                                    {
                                        string bc_ = (aq_ as Id)?.Value;
                                        return bc_;
                                    }
                                    else
                                    {
                                        bool bd_ = aq_ is Duration;
                                        if (bd_)
                                        {
                                            FhirDecimal be_ = (aq_ as Duration)?.ValueElement;
                                            return be_;
                                        }
                                        else
                                        {
                                            bool bf_ = aq_ is Distance;
                                            if (bf_)
                                            {
                                                FhirDecimal bg_ = (aq_ as Distance)?.ValueElement;
                                                return bg_;
                                            }
                                            else
                                            {
                                                bool bh_ = aq_ is FhirDecimal;
                                                if (bh_)
                                                {
                                                    decimal? bi_ = (aq_ as FhirDecimal)?.Value;
                                                    return bi_;
                                                }
                                                else
                                                {
                                                    bool bj_ = aq_ is Date;
                                                    if (bj_)
                                                    {
                                                        string bk_ = (aq_ as Date)?.Value;
                                                        return bk_;
                                                    }
                                                    else
                                                    {
                                                        bool bl_ = aq_ is Count;
                                                        if (bl_)
                                                        {
                                                            FhirDecimal bm_ = (aq_ as Count)?.ValueElement;
                                                            return bm_;
                                                        }
                                                        else
                                                        {
                                                            bool bn_ = aq_ is FhirDateTime;
                                                            if (bn_)
                                                            {
                                                                string bo_ = context.Operators.Convert<string>(aq_ as FhirDateTime);
                                                                return bo_;
                                                            }
                                                            else
                                                            {
                                                                bool bp_ = aq_ is Time;
                                                                if (bp_)
                                                                {
                                                                    string bq_ = (aq_ as Time)?.Value;
                                                                    return bq_;
                                                                }
                                                                else
                                                                {
                                                                    bool br_ = aq_ is Age;
                                                                    if (br_)
                                                                    {
                                                                        FhirDecimal bs_ = (aq_ as Age)?.ValueElement;
                                                                        return bs_;
                                                                    }
                                                                    else
                                                                    {
                                                                        bool bt_ = aq_ is FhirUrl;
                                                                        if (bt_)
                                                                        {
                                                                            string bu_ = (aq_ as FhirUrl)?.Value;
                                                                            return bu_;
                                                                        }
                                                                        else
                                                                        {
                                                                            bool bv_ = aq_ is FhirUri;
                                                                            if (bv_)
                                                                            {
                                                                                string bw_ = (aq_ as FhirUri)?.Value;
                                                                                return bw_;
                                                                            }
                                                                            else
                                                                            {
                                                                                bool bx_ = aq_ is Base64Binary;
                                                                                if (bx_)
                                                                                {
                                                                                    byte[] by_ = (aq_ as Base64Binary)?.Value;
                                                                                    return by_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    bool bz_ = aq_ is FhirBoolean;
                                                                                    if (bz_)
                                                                                    {
                                                                                        bool? ca_ = (aq_ as FhirBoolean)?.Value;
                                                                                        return ca_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        bool cb_ = aq_ is FhirString;
                                                                                        if (cb_)
                                                                                        {
                                                                                            string cc_ = (aq_ as FhirString)?.Value;
                                                                                            return cc_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            bool cd_ = aq_ is PositiveInt;
                                                                                            if (cd_)
                                                                                            {
                                                                                                int? ce_ = (aq_ as PositiveInt)?.Value;
                                                                                                return ce_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool cf_ = aq_ is Code;
                                                                                                if (cf_)
                                                                                                {
                                                                                                    string cg_ = (aq_ as Code)?.Value;
                                                                                                    return cg_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    bool ch_ = aq_ is UnsignedInt;
                                                                                                    if (ch_)
                                                                                                    {
                                                                                                        int? ci_ = (aq_ as UnsignedInt)?.Value;
                                                                                                        return ci_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        bool cj_ = aq_ is Canonical;
                                                                                                        if (cj_)
                                                                                                        {
                                                                                                            string ck_ = (aq_ as Canonical)?.Value;
                                                                                                            return ck_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            bool cl_ = aq_ is Quantity;
                                                                                                            if (cl_)
                                                                                                            {
                                                                                                                FhirDecimal cm_ = (aq_ as Quantity)?.ValueElement;
                                                                                                                return cm_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                bool cn_ = aq_ is Identifier;
                                                                                                                if (cn_)
                                                                                                                {
                                                                                                                    FhirString co_ = (aq_ as Identifier)?.ValueElement;
                                                                                                                    return co_;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    bool cp_ = aq_ is Money;
                                                                                                                    if (cp_)
                                                                                                                    {
                                                                                                                        FhirDecimal cq_ = (aq_ as Money)?.ValueElement;
                                                                                                                        return cq_;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        bool cr_ = aq_ is UsageContext;
                                                                                                                        if (cr_)
                                                                                                                        {
                                                                                                                            DataType cs_ = (aq_ as UsageContext)?.Value;
                                                                                                                            return cs_;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            bool ct_ = aq_ is ContactPoint;
                                                                                                                            if (ct_)
                                                                                                                            {
                                                                                                                                FhirString cu_ = (aq_ as ContactPoint)?.ValueElement;
                                                                                                                                return cu_;
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                return null;
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            IEnumerable<object> aa_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, y_, z_);
            object ab_ = context.Operators.SingletonFrom<object>(aa_);
            (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? ac_ = (CqlTupleMetadata_HPcCiDPXQfZTXIORThMLfTQDR, x_, (string)ab_);
            return ac_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?> h_ = context.Operators.SelectDistinct<Extension, (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>((IEnumerable<Extension>)f_, g_);
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)?>(h_);
        return i_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context) =>
        context.GetOrCompute(_cacheIndex_SDE_Sex, SDE_Sex_Compute);

    private const long _cacheIndex_SDE_Sex = -4862447719526612531L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        Code<AdministrativeGender> b_ = a_?.GenderElement;
        AdministrativeGender? c_ = b_?.Value;
        string d_ = context.Operators.Convert<string>(c_);
        bool? e_ = context.Operators.Equal(d_, "male");
        if (e_ ?? false)
        {
            return new CqlCode("M", "http://hl7.org/fhir/v3/AdministrativeGender", default, "Male");
        }
        else
        {
            bool? f_ = context.Operators.Equal(d_, "female");
            if (f_ ?? false)
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
