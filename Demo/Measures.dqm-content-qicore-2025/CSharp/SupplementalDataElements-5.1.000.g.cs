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
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_4_000.Instance.ToString(context, j_);
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
                string af_ = FHIRHelpers_4_4_000.Instance.ToString(context, ae_);
                bool? ag_ = context.Operators.Equal(af_, "ombCategory");
                return ag_;
            }


            object o_(Extension @this) {
                DataType ah_ = @this?.Value;
                return ah_;
            }

            IEnumerable<object> p_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, n_, o_);
            object q_ = context.Operators.SingletonFrom<object>(p_);
            CqlCode r_ = FHIRHelpers_4_4_000.Instance.ToCode(context, q_ as Coding);
            CqlCode[] s_ = [
                r_,
            ];

            bool? t_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "detailed");
                return ak_;
            }


            object u_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> v_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, t_, u_);

            CqlCode w_(object @this) {
                CqlCode am_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return am_;
            }

            IEnumerable<CqlCode> x_ = context.Operators.Select<object, CqlCode>(v_, w_);
            IEnumerable<CqlCode> y_ = context.Operators.ValueSetUnion((IEnumerable<CqlCode>)s_, x_);

            bool? z_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_4_000.Instance.ToString(context, an_);
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
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri j_ = @this?.UrlElement;
            string k_ = FHIRHelpers_4_4_000.Instance.ToString(context, j_);
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
                string ae_ = FHIRHelpers_4_4_000.Instance.ToString(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, "ombCategory");
                return af_;
            }


            object o_(Extension @this) {
                DataType ag_ = @this?.Value;
                return ag_;
            }

            IEnumerable<object> p_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, n_, o_);

            CqlCode q_(object @this) {
                CqlCode ah_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return ah_;
            }

            IEnumerable<CqlCode> r_ = context.Operators.Select<object, CqlCode>(p_, q_);

            bool? s_(Extension @this) {
                FhirUri ai_ = @this?.UrlElement;
                string aj_ = FHIRHelpers_4_4_000.Instance.ToString(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, "detailed");
                return ak_;
            }


            object t_(Extension @this) {
                DataType al_ = @this?.Value;
                return al_;
            }

            IEnumerable<object> u_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)m_, s_, t_);

            CqlCode v_(object @this) {
                CqlCode am_ = FHIRHelpers_4_4_000.Instance.ToCode(context, @this as Coding);
                return am_;
            }

            IEnumerable<CqlCode> w_ = context.Operators.Select<object, CqlCode>(u_, v_);
            IEnumerable<CqlCode> x_ = context.Operators.ValueSetUnion(r_, w_);

            bool? y_(Extension @this) {
                FhirUri an_ = @this?.UrlElement;
                string ao_ = FHIRHelpers_4_4_000.Instance.ToString(context, an_);
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

    private const long _cacheIndex_SDE_Sex = -9150227342082415267L;

    private CqlCode SDE_Sex_Compute(CqlContext context)
    {
        Patient a_ = this.Patient(context);
        List<Extension> b_ = a_?.Extension;

        bool? c_(Extension @this) {
            FhirUri h_ = @this?.UrlElement;
            string i_ = FHIRHelpers_4_4_000.Instance.ToString(context, h_);
            bool? j_ = context.Operators.Equal(i_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
            return j_;
        }


        object d_(Extension @this) {
            DataType k_ = @this?.Value;
            bool l_ = k_ is Uuid;
            if (l_)
            {
                string m_ = (k_ as Uuid)?.Value;
                return m_;
            }
            else
            {
                bool n_ = k_ is Oid;
                if (n_)
                {
                    string o_ = (k_ as Oid)?.Value;
                    return o_;
                }
                else
                {
                    bool p_ = k_ is Markdown;
                    if (p_)
                    {
                        string q_ = (k_ as Markdown)?.Value;
                        return q_;
                    }
                    else
                    {
                        bool r_ = k_ is Integer;
                        if (r_)
                        {
                            int? s_ = (k_ as Integer)?.Value;
                            return s_;
                        }
                        else
                        {
                            bool t_ = k_ is Instant;
                            if (t_)
                            {
                                DateTimeOffset? u_ = (k_ as Instant)?.Value;
                                return u_;
                            }
                            else
                            {
                                bool v_ = k_ is Id;
                                if (v_)
                                {
                                    string w_ = (k_ as Id)?.Value;
                                    return w_;
                                }
                                else
                                {
                                    bool x_ = k_ is Duration;
                                    if (x_)
                                    {
                                        FhirDecimal y_ = (k_ as Duration)?.ValueElement;
                                        return y_;
                                    }
                                    else
                                    {
                                        bool z_ = k_ is Distance;
                                        if (z_)
                                        {
                                            FhirDecimal aa_ = (k_ as Distance)?.ValueElement;
                                            return aa_;
                                        }
                                        else
                                        {
                                            bool ab_ = k_ is FhirDecimal;
                                            if (ab_)
                                            {
                                                decimal? ac_ = (k_ as FhirDecimal)?.Value;
                                                return ac_;
                                            }
                                            else
                                            {
                                                bool ad_ = k_ is Date;
                                                if (ad_)
                                                {
                                                    string ae_ = (k_ as Date)?.Value;
                                                    return ae_;
                                                }
                                                else
                                                {
                                                    bool af_ = k_ is Count;
                                                    if (af_)
                                                    {
                                                        FhirDecimal ag_ = (k_ as Count)?.ValueElement;
                                                        return ag_;
                                                    }
                                                    else
                                                    {
                                                        bool ah_ = k_ is FhirDateTime;
                                                        if (ah_)
                                                        {
                                                            string ai_ = context.Operators.Convert<string>(k_ as FhirDateTime);
                                                            return ai_;
                                                        }
                                                        else
                                                        {
                                                            bool aj_ = k_ is Time;
                                                            if (aj_)
                                                            {
                                                                string ak_ = (k_ as Time)?.Value;
                                                                return ak_;
                                                            }
                                                            else
                                                            {
                                                                bool al_ = k_ is Age;
                                                                if (al_)
                                                                {
                                                                    FhirDecimal am_ = (k_ as Age)?.ValueElement;
                                                                    return am_;
                                                                }
                                                                else
                                                                {
                                                                    bool an_ = k_ is FhirUrl;
                                                                    if (an_)
                                                                    {
                                                                        string ao_ = (k_ as FhirUrl)?.Value;
                                                                        return ao_;
                                                                    }
                                                                    else
                                                                    {
                                                                        bool ap_ = k_ is FhirUri;
                                                                        if (ap_)
                                                                        {
                                                                            string aq_ = (k_ as FhirUri)?.Value;
                                                                            return aq_;
                                                                        }
                                                                        else
                                                                        {
                                                                            bool ar_ = k_ is Base64Binary;
                                                                            if (ar_)
                                                                            {
                                                                                byte[] as_ = (k_ as Base64Binary)?.Value;
                                                                                return as_;
                                                                            }
                                                                            else
                                                                            {
                                                                                bool at_ = k_ is FhirBoolean;
                                                                                if (at_)
                                                                                {
                                                                                    bool? au_ = (k_ as FhirBoolean)?.Value;
                                                                                    return au_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    bool av_ = k_ is FhirString;
                                                                                    if (av_)
                                                                                    {
                                                                                        string aw_ = (k_ as FhirString)?.Value;
                                                                                        return aw_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        bool ax_ = k_ is PositiveInt;
                                                                                        if (ax_)
                                                                                        {
                                                                                            int? ay_ = (k_ as PositiveInt)?.Value;
                                                                                            return ay_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            bool az_ = k_ is Code;
                                                                                            if (az_)
                                                                                            {
                                                                                                string ba_ = (k_ as Code)?.Value;
                                                                                                return ba_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool bb_ = k_ is UnsignedInt;
                                                                                                if (bb_)
                                                                                                {
                                                                                                    int? bc_ = (k_ as UnsignedInt)?.Value;
                                                                                                    return bc_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    bool bd_ = k_ is Canonical;
                                                                                                    if (bd_)
                                                                                                    {
                                                                                                        string be_ = (k_ as Canonical)?.Value;
                                                                                                        return be_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        bool bf_ = k_ is Quantity;
                                                                                                        if (bf_)
                                                                                                        {
                                                                                                            FhirDecimal bg_ = (k_ as Quantity)?.ValueElement;
                                                                                                            return bg_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            bool bh_ = k_ is Identifier;
                                                                                                            if (bh_)
                                                                                                            {
                                                                                                                FhirString bi_ = (k_ as Identifier)?.ValueElement;
                                                                                                                return bi_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                bool bj_ = k_ is Money;
                                                                                                                if (bj_)
                                                                                                                {
                                                                                                                    FhirDecimal bk_ = (k_ as Money)?.ValueElement;
                                                                                                                    return bk_;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    bool bl_ = k_ is UsageContext;
                                                                                                                    if (bl_)
                                                                                                                    {
                                                                                                                        DataType bm_ = (k_ as UsageContext)?.Value;
                                                                                                                        return bm_;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        bool bn_ = k_ is ContactPoint;
                                                                                                                        if (bn_)
                                                                                                                        {
                                                                                                                            FhirString bo_ = (k_ as ContactPoint)?.ValueElement;
                                                                                                                            return bo_;
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

        IEnumerable<object> e_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)b_, c_, d_);
        object f_ = context.Operators.SingletonFrom<object>(e_);
        bool? g_ = context.Operators.Equal(f_, "248153007");
        if (g_ ?? false)
        {
            CqlCode bp_ = this.Male__finding_(context);
            return bp_;
        }
        else
        {

            bool? bq_(Extension @this) {
                FhirUri bv_ = @this?.UrlElement;
                string bw_ = FHIRHelpers_4_4_000.Instance.ToString(context, bv_);
                bool? bx_ = context.Operators.Equal(bw_, "http://hl7.org/fhir/us/core/StructureDefinition/us-core-sex");
                return bx_;
            }


            object br_(Extension @this) {
                DataType by_ = @this?.Value;
                bool bz_ = by_ is Uuid;
                if (bz_)
                {
                    string ca_ = (by_ as Uuid)?.Value;
                    return ca_;
                }
                else
                {
                    bool cb_ = by_ is Oid;
                    if (cb_)
                    {
                        string cc_ = (by_ as Oid)?.Value;
                        return cc_;
                    }
                    else
                    {
                        bool cd_ = by_ is Markdown;
                        if (cd_)
                        {
                            string ce_ = (by_ as Markdown)?.Value;
                            return ce_;
                        }
                        else
                        {
                            bool cf_ = by_ is Integer;
                            if (cf_)
                            {
                                int? cg_ = (by_ as Integer)?.Value;
                                return cg_;
                            }
                            else
                            {
                                bool ch_ = by_ is Instant;
                                if (ch_)
                                {
                                    DateTimeOffset? ci_ = (by_ as Instant)?.Value;
                                    return ci_;
                                }
                                else
                                {
                                    bool cj_ = by_ is Id;
                                    if (cj_)
                                    {
                                        string ck_ = (by_ as Id)?.Value;
                                        return ck_;
                                    }
                                    else
                                    {
                                        bool cl_ = by_ is Duration;
                                        if (cl_)
                                        {
                                            FhirDecimal cm_ = (by_ as Duration)?.ValueElement;
                                            return cm_;
                                        }
                                        else
                                        {
                                            bool cn_ = by_ is Distance;
                                            if (cn_)
                                            {
                                                FhirDecimal co_ = (by_ as Distance)?.ValueElement;
                                                return co_;
                                            }
                                            else
                                            {
                                                bool cp_ = by_ is FhirDecimal;
                                                if (cp_)
                                                {
                                                    decimal? cq_ = (by_ as FhirDecimal)?.Value;
                                                    return cq_;
                                                }
                                                else
                                                {
                                                    bool cr_ = by_ is Date;
                                                    if (cr_)
                                                    {
                                                        string cs_ = (by_ as Date)?.Value;
                                                        return cs_;
                                                    }
                                                    else
                                                    {
                                                        bool ct_ = by_ is Count;
                                                        if (ct_)
                                                        {
                                                            FhirDecimal cu_ = (by_ as Count)?.ValueElement;
                                                            return cu_;
                                                        }
                                                        else
                                                        {
                                                            bool cv_ = by_ is FhirDateTime;
                                                            if (cv_)
                                                            {
                                                                string cw_ = context.Operators.Convert<string>(by_ as FhirDateTime);
                                                                return cw_;
                                                            }
                                                            else
                                                            {
                                                                bool cx_ = by_ is Time;
                                                                if (cx_)
                                                                {
                                                                    string cy_ = (by_ as Time)?.Value;
                                                                    return cy_;
                                                                }
                                                                else
                                                                {
                                                                    bool cz_ = by_ is Age;
                                                                    if (cz_)
                                                                    {
                                                                        FhirDecimal da_ = (by_ as Age)?.ValueElement;
                                                                        return da_;
                                                                    }
                                                                    else
                                                                    {
                                                                        bool db_ = by_ is FhirUrl;
                                                                        if (db_)
                                                                        {
                                                                            string dc_ = (by_ as FhirUrl)?.Value;
                                                                            return dc_;
                                                                        }
                                                                        else
                                                                        {
                                                                            bool dd_ = by_ is FhirUri;
                                                                            if (dd_)
                                                                            {
                                                                                string de_ = (by_ as FhirUri)?.Value;
                                                                                return de_;
                                                                            }
                                                                            else
                                                                            {
                                                                                bool df_ = by_ is Base64Binary;
                                                                                if (df_)
                                                                                {
                                                                                    byte[] dg_ = (by_ as Base64Binary)?.Value;
                                                                                    return dg_;
                                                                                }
                                                                                else
                                                                                {
                                                                                    bool dh_ = by_ is FhirBoolean;
                                                                                    if (dh_)
                                                                                    {
                                                                                        bool? di_ = (by_ as FhirBoolean)?.Value;
                                                                                        return di_;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        bool dj_ = by_ is FhirString;
                                                                                        if (dj_)
                                                                                        {
                                                                                            string dk_ = (by_ as FhirString)?.Value;
                                                                                            return dk_;
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            bool dl_ = by_ is PositiveInt;
                                                                                            if (dl_)
                                                                                            {
                                                                                                int? dm_ = (by_ as PositiveInt)?.Value;
                                                                                                return dm_;
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                bool dn_ = by_ is Code;
                                                                                                if (dn_)
                                                                                                {
                                                                                                    string do_ = (by_ as Code)?.Value;
                                                                                                    return do_;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    bool dp_ = by_ is UnsignedInt;
                                                                                                    if (dp_)
                                                                                                    {
                                                                                                        int? dq_ = (by_ as UnsignedInt)?.Value;
                                                                                                        return dq_;
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        bool dr_ = by_ is Canonical;
                                                                                                        if (dr_)
                                                                                                        {
                                                                                                            string ds_ = (by_ as Canonical)?.Value;
                                                                                                            return ds_;
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            bool dt_ = by_ is Quantity;
                                                                                                            if (dt_)
                                                                                                            {
                                                                                                                FhirDecimal du_ = (by_ as Quantity)?.ValueElement;
                                                                                                                return du_;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                bool dv_ = by_ is Identifier;
                                                                                                                if (dv_)
                                                                                                                {
                                                                                                                    FhirString dw_ = (by_ as Identifier)?.ValueElement;
                                                                                                                    return dw_;
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    bool dx_ = by_ is Money;
                                                                                                                    if (dx_)
                                                                                                                    {
                                                                                                                        FhirDecimal dy_ = (by_ as Money)?.ValueElement;
                                                                                                                        return dy_;
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        bool dz_ = by_ is UsageContext;
                                                                                                                        if (dz_)
                                                                                                                        {
                                                                                                                            DataType ea_ = (by_ as UsageContext)?.Value;
                                                                                                                            return ea_;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            bool eb_ = by_ is ContactPoint;
                                                                                                                            if (eb_)
                                                                                                                            {
                                                                                                                                FhirString ec_ = (by_ as ContactPoint)?.ValueElement;
                                                                                                                                return ec_;
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

            IEnumerable<object> bs_ = context.Operators.WhereSelect<Extension, object>((IEnumerable<Extension>)b_, bq_, br_);
            object bt_ = context.Operators.SingletonFrom<object>(bs_);
            bool? bu_ = context.Operators.Equal(bt_, "248152002");
            if (bu_ ?? false)
            {
                CqlCode ed_ = this.Female__finding_(context);
                return ed_;
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
