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
[CqlLibrary("NCQAClaims", "1.0.0")]
public partial class NCQAClaims_1_0_0 : ILibrary, ISingleton<NCQAClaims_1_0_0>
{
    #region ValueSets (2)

    [CqlValueSetDefinition("Inpatient Stay", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", valueSetVersion: null)]
    public CqlValueSet Inpatient_Stay(CqlContext _) => _Inpatient_Stay;
    private static readonly CqlValueSet _Inpatient_Stay = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", null);

    [CqlValueSetDefinition("Nonacute Inpatient Stay", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient_Stay(CqlContext _) => _Nonacute_Inpatient_Stay;
    private static readonly CqlValueSet _Nonacute_Inpatient_Stay = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", null);

    #endregion ValueSets

    #region Functions and Expressions (29)

    [CqlFunctionDefinition("Professional or Institutional Claims")]
    public IEnumerable<Claim> Professional_or_Institutional_Claims(CqlContext context, IEnumerable<Claim> claim)
    {

        bool? a_(Claim MedicalClaim) {
            CodeableConcept c_ = MedicalClaim?.Type;
            CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            IReadOnlyList<CqlCode> e_ = d_?.codes;
            CqlCode f_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
            CqlCode h_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? i_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, h_);
            bool? j_ = context.Operators.Or(g_, i_);
            return j_;
        }

        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
        return b_;
    }


    [CqlFunctionDefinition("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(CqlContext context, IEnumerable<Claim> claim)
    {

        bool? a_(Claim PharmacyClaim) {
            CodeableConcept c_ = PharmacyClaim?.Type;
            CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            IReadOnlyList<CqlCode> e_ = d_?.codes;
            CqlCode f_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
            return g_;
        }

        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
        return b_;
    }


    [CqlFunctionDefinition("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {

        bool? a_(ClaimResponse MedicalResponse) {
            CodeableConcept c_ = MedicalResponse?.Type;
            CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            IReadOnlyList<CqlCode> e_ = d_?.codes;
            CqlCode f_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
            CqlCode h_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? i_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, h_);
            bool? j_ = context.Operators.Or(g_, i_);
            return j_;
        }

        IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);
        return b_;
    }


    [CqlFunctionDefinition("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {

        bool? a_(ClaimResponse PharmacyResponse) {
            CodeableConcept c_ = PharmacyResponse?.Type;
            CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            IReadOnlyList<CqlCode> e_ = d_?.codes;
            CqlCode f_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
            return g_;
        }

        IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);
        return b_;
    }


    [CqlFunctionDefinition("Medical Claims With Procedure and POS")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode p) {
            string n_ = p?.code;
            return n_;
        }

        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);

        string e_(CqlCode pos) {
            string o_ = pos?.code;
            return o_;
        }

        IEnumerable<string> f_ = context.Operators.Select<CqlCode, string>(posCodes, e_);
        IEnumerable<string> g_ = context.Operators.Distinct<string>(f_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? h_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, a_, d_, g_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] i_ = [
            h_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode) {
            IEnumerable<Claim> p_ = ClaimWithPosCode?.MedicalClaim;

            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? q_(Claim ClaimofInterest) {
                IEnumerable<Claim.ItemComponent> v_;
                if (ClaimofInterest is null)
                {
                    v_ = null as IEnumerable<Claim.ItemComponent>;
                }
                else
                {
                    List<Claim.ItemComponent> ac_ = ClaimofInterest?.Item;

                    bool? ad_(Claim.ItemComponent ItemOnLine) {
                        CodeableConcept af_ = ItemOnLine?.ProductOrService;
                        CqlConcept ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, af_);
                        IReadOnlyList<CqlCode> ah_ = ag_?.codes;

                        bool? ai_(CqlCode LineCode) {
                            string as_ = LineCode?.code;
                            IEnumerable<string> at_ = ClaimWithPosCode?.ProceduresAsStrings;
                            bool? au_ = context.Operators.In<string>(as_, at_);
                            return au_;
                        }

                        IEnumerable<CqlCode> aj_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ah_, ai_);
                        bool? ak_ = context.Operators.Exists<CqlCode>(aj_);
                        DataType al_ = ItemOnLine?.Location;
                        CqlConcept am_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, al_ as CodeableConcept);
                        IReadOnlyList<CqlCode> an_ = am_?.codes;

                        bool? ao_(CqlCode PosCode) {
                            string av_ = PosCode?.code;
                            IEnumerable<string> aw_ = ClaimWithPosCode?.POSAsString;
                            bool? ax_ = context.Operators.In<string>(av_, aw_);
                            return ax_;
                        }

                        IEnumerable<CqlCode> ap_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)an_, ao_);
                        bool? aq_ = context.Operators.Exists<CqlCode>(ap_);
                        bool? ar_ = context.Operators.And(ak_, aq_);
                        return ar_;
                    }

                    IEnumerable<Claim.ItemComponent> ae_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ac_, ad_);
                    v_ = ae_;
                }
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? w_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, v_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] x_ = [
                    w_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? y_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition) {
                    IEnumerable<Claim.ItemComponent> ay_ = LineItemDefinition?.LineItems;
                    bool? az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                    if (az_ ?? false)
                    {
                        Claim ba_ = LineItemDefinition?.Claim;
                        IEnumerable<Claim.ItemComponent> bb_ = LineItemDefinition?.LineItems;

                        bool? bc_(Claim.ItemComponent @this) {
                            DataType bk_ = @this?.Serviced;
                            bool? bl_ = context.Operators.Not((bool?)(bk_ is null));
                            return bl_;
                        }

                        IEnumerable<Claim.ItemComponent> bd_ = context.Operators.Where<Claim.ItemComponent>(bb_, bc_);

                        object be_(Claim.ItemComponent @this) {
                            DataType bm_ = @this?.Serviced;
                            return bm_;
                        }

                        IEnumerable<object> bf_ = context.Operators.Select<Claim.ItemComponent, object>(bd_, be_);

                        CqlInterval<CqlDateTime> bg_(object NormalDate) {
                            CqlInterval<CqlDateTime> bn_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                            return bn_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> bh_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bf_, bg_);
                        IEnumerable<CqlInterval<CqlDateTime>> bi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bh_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bj_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, ba_, bi_);
                        return bj_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> z_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)x_, y_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> aa_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(z_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ab_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(aa_);
                return ab_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> r_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_, q_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> s_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(r_);

            bool? t_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                bool? bo_ = context.Operators.Not((bool?)(FinalList is null));
                return bo_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> u_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(s_, t_);
            return u_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)i_, j_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> l_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(k_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(l_);
        return m_;
    }


    [CqlFunctionDefinition("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode p) {
            string k_ = p?.code;
            return k_;
        }

        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)? e_ = (CqlTupleMetadata_FOGIeViDYfJOhRYAGIOCbEeNO, a_, d_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)?[] f_ = [
            e_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure) {
            IEnumerable<Claim> l_ = ClaimWithProcedure?.MedicalClaim;

            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_(Claim ClaimofInterest) {
                IEnumerable<Claim.ItemComponent> r_;
                if (ClaimofInterest is null)
                {
                    r_ = null as IEnumerable<Claim.ItemComponent>;
                }
                else
                {
                    List<Claim.ItemComponent> y_ = ClaimofInterest?.Item;

                    bool? z_(Claim.ItemComponent ItemOnLine) {
                        CodeableConcept ab_ = ItemOnLine?.ProductOrService;
                        CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ab_);
                        IReadOnlyList<CqlCode> ad_ = ac_?.codes;

                        bool? ae_(CqlCode LineCode) {
                            string ax_ = LineCode?.code;
                            IEnumerable<string> ay_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? az_ = context.Operators.In<string>(ax_, ay_);
                            return az_;
                        }

                        IEnumerable<CqlCode> af_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ad_, ae_);
                        bool? ag_ = context.Operators.Exists<CqlCode>(af_);
                        List<Claim.ProcedureComponent> ah_ = ClaimofInterest?.Procedure;

                        bool? ai_(Claim.ProcedureComponent @this) {
                            DataType ba_ = @this?.Procedure;
                            bool? bb_ = context.Operators.Not((bool?)(ba_ is null));
                            return bb_;
                        }

                        IEnumerable<Claim.ProcedureComponent> aj_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ah_, ai_);

                        object ak_(Claim.ProcedureComponent @this) {
                            DataType bc_ = @this?.Procedure;
                            return bc_;
                        }

                        IEnumerable<object> al_ = context.Operators.Select<Claim.ProcedureComponent, object>(aj_, ak_);

                        bool? am_(object @this) {
                            object bd_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                            return be_;
                        }

                        IEnumerable<object> an_ = context.Operators.Where<object>(al_, am_);

                        object ao_(object @this) {
                            object bf_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            return bf_;
                        }

                        IEnumerable<object> ap_ = context.Operators.Select<object, object>(an_, ao_);
                        IEnumerable<object> aq_ = context.Operators.FlattenLateBoundList(ap_);
                        Coding ar_(object @object) => (Coding)@object;
                        IEnumerable<Coding> as_ = context.Operators.Select<object, Coding>(aq_, ar_);

                        bool? at_(Coding HeaderCode) {
                            Code bg_ = HeaderCode?.CodeElement;
                            string bh_ = bg_?.Value;
                            IEnumerable<string> bi_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? bj_ = context.Operators.In<string>(bh_, bi_);
                            return bj_;
                        }

                        IEnumerable<Coding> au_ = context.Operators.Where<Coding>(as_, at_);
                        bool? av_ = context.Operators.Exists<Coding>(au_);
                        bool? aw_ = context.Operators.Or(ag_, av_);
                        return aw_;
                    }

                    IEnumerable<Claim.ItemComponent> aa_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);
                    r_ = aa_;
                }
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? s_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, r_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] t_ = [
                    s_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition) {
                    IEnumerable<Claim.ItemComponent> bk_ = LineItemDefinition?.LineItems;
                    bool? bl_ = context.Operators.Exists<Claim.ItemComponent>(bk_);
                    if (bl_ ?? false)
                    {
                        Claim bm_ = LineItemDefinition?.Claim;
                        IEnumerable<Claim.ItemComponent> bn_ = LineItemDefinition?.LineItems;

                        bool? bo_(Claim.ItemComponent @this) {
                            DataType bw_ = @this?.Serviced;
                            bool? bx_ = context.Operators.Not((bool?)(bw_ is null));
                            return bx_;
                        }

                        IEnumerable<Claim.ItemComponent> bp_ = context.Operators.Where<Claim.ItemComponent>(bn_, bo_);

                        object bq_(Claim.ItemComponent @this) {
                            DataType by_ = @this?.Serviced;
                            return by_;
                        }

                        IEnumerable<object> br_ = context.Operators.Select<Claim.ItemComponent, object>(bp_, bq_);

                        CqlInterval<CqlDateTime> bs_(object NormalDate) {
                            CqlInterval<CqlDateTime> bz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                            return bz_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> bt_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(br_, bs_);
                        IEnumerable<CqlInterval<CqlDateTime>> bu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bt_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bv_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, bm_, bu_);
                        return bv_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> v_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)t_, u_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> w_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(v_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? x_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(w_);
                return x_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(l_, m_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);

            bool? p_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                bool? ca_ = context.Operators.Not((bool?)(FinalList is null));
                return ca_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(o_, p_);
            return q_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> h_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)?>)f_, g_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(h_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Medical Claims With Diagnosis")]
    public (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode d) {
            string k_ = d?.code;
            return k_;
        }

        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? e_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, a_, d_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] f_ = [
            e_,
        ];

        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim> l_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                l_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> s_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? t_(Claim DiagnosisLine) {
                    List<Claim.DiagnosisComponent> v_ = DiagnosisLine?.Diagnosis;

                    bool? w_(Claim.DiagnosisComponent @this) {
                        DataType ak_ = @this?.Diagnosis;
                        bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                        return al_;
                    }

                    IEnumerable<Claim.DiagnosisComponent> x_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)v_, w_);

                    object y_(Claim.DiagnosisComponent @this) {
                        DataType am_ = @this?.Diagnosis;
                        return am_;
                    }

                    IEnumerable<object> z_ = context.Operators.Select<Claim.DiagnosisComponent, object>(x_, y_);

                    bool? aa_(object @this) {
                        object an_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                        bool? ao_ = context.Operators.Not((bool?)(an_ is null));
                        return ao_;
                    }

                    IEnumerable<object> ab_ = context.Operators.Where<object>(z_, aa_);

                    object ac_(object @this) {
                        object ap_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                        return ap_;
                    }

                    IEnumerable<object> ad_ = context.Operators.Select<object, object>(ab_, ac_);
                    IEnumerable<object> ae_ = context.Operators.FlattenLateBoundList(ad_);
                    Coding af_(object @object) => (Coding)@object;
                    IEnumerable<Coding> ag_ = context.Operators.Select<object, Coding>(ae_, af_);

                    bool? ah_(Coding HeaderCode) {
                        Code aq_ = HeaderCode?.CodeElement;
                        string ar_ = aq_?.Value;
                        IEnumerable<string> as_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                        bool? at_ = context.Operators.In<string>(ar_, as_);
                        return at_;
                    }

                    IEnumerable<Coding> ai_ = context.Operators.Where<Coding>(ag_, ah_);
                    bool? aj_ = context.Operators.Exists<Coding>(ai_);
                    return aj_;
                }

                IEnumerable<Claim> u_ = context.Operators.Where<Claim>(s_, t_);
                l_ = u_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? m_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, l_);
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] n_ = [
                m_,
            ];

            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? HeaderDefinition) {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_;
                IEnumerable<Claim> az_ = HeaderDefinition?.DiagnosisItems;
                bool? ba_ = context.Operators.Exists<Claim>(az_);
                if (ba_ ?? false)
                {
                    IEnumerable<Claim> bb_ = HeaderDefinition?.DiagnosisItems;

                    bool? bc_(Claim @this) {
                        List<Claim.ItemComponent> bl_ = @this?.Item;
                        bool? bm_ = context.Operators.Not((bool?)(bl_ is null));
                        return bm_;
                    }

                    IEnumerable<Claim> bd_ = context.Operators.Where<Claim>(bb_, bc_);

                    List<Claim.ItemComponent> be_(Claim @this) {
                        List<Claim.ItemComponent> bn_ = @this?.Item;
                        return bn_;
                    }

                    IEnumerable<List<Claim.ItemComponent>> bf_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(bd_, be_);
                    IEnumerable<Claim.ItemComponent> bg_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)bf_);

                    CqlInterval<CqlDateTime> bh_(Claim.ItemComponent NormalDate) {
                        DataType bo_ = NormalDate?.Serviced;
                        CqlInterval<CqlDateTime> bp_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bo_);
                        return bp_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bi_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bg_, bh_);
                    IEnumerable<CqlInterval<CqlDateTime>> bj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bi_);
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bk_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, bb_, bj_);
                    au_ = bk_;
                }
                else
                {
                    au_ = null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] av_ = [
                    au_,
                ];

                bool? aw_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                    bool? bq_ = context.Operators.Not((bool?)(FinalList is null));
                    return bq_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ax_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)av_, aw_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ay_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ax_);
                return ay_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_);
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(q_);
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)f_, g_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> i_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(h_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? j_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Pharmacy Claim With Medication")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        IEnumerable<Claim> a_ = this.Pharmacy_Claims(context, claim);

        string b_(CqlCode p) {
            string j_ = p?.code;
            return j_;
        }

        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(MedicationCodes, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? e_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, a_, d_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] f_ = [
            e_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> g_((CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication) {
            IEnumerable<Claim> k_ = ClaimWithMedication?.PharmacyClaim;

            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? l_(Claim Pharmacy) {
                List<Claim.ItemComponent> p_ = Pharmacy?.Item;

                bool? q_(Claim.ItemComponent ItemOnLine) {
                    CodeableConcept x_ = ItemOnLine?.ProductOrService;
                    CqlConcept y_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, x_);
                    IReadOnlyList<CqlCode> z_ = y_?.codes;

                    bool? aa_(CqlCode LineCode) {
                        string ad_ = LineCode?.code;
                        IEnumerable<string> ae_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? af_ = context.Operators.In<string>(ad_, ae_);
                        return af_;
                    }

                    IEnumerable<CqlCode> ab_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)z_, aa_);
                    bool? ac_ = context.Operators.Exists<CqlCode>(ab_);
                    return ac_;
                }

                IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)p_, q_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? s_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, r_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] t_ = [
                    s_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? u_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition) {
                    Claim ag_ = LineItemDefinition?.Claim;
                    Claim[] ah_ = [
                        ag_,
                    ];

                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ai_(Claim ClaimLines) {
                        List<Claim.ItemComponent> al_ = ClaimLines?.Item;

                        bool? am_(Claim.ItemComponent i) {
                            CodeableConcept av_ = i?.ProductOrService;
                            CqlConcept aw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, av_);
                            IReadOnlyList<CqlCode> ax_ = aw_?.codes;

                            bool? ay_(CqlCode LineCode) {
                                string bb_ = LineCode?.code;
                                IEnumerable<string> bc_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? bd_ = context.Operators.In<string>(bb_, bc_);
                                return bd_;
                            }

                            IEnumerable<CqlCode> az_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ax_, ay_);
                            bool? ba_ = context.Operators.Exists<CqlCode>(az_);
                            return ba_;
                        }

                        IEnumerable<Claim.ItemComponent> an_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)al_, am_);

                        (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? ao_(Claim.ItemComponent i) {
                            CqlInterval<CqlDateTime> be_;
                            Quantity bg_ = i?.Quantity;
                            bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
                            if (bh_ ?? false)
                            {
                                CqlInterval<CqlDateTime> bi_;
                                DataType bj_ = i?.Serviced;
                                bool bk_ = bj_ is Period;
                                if (bk_)
                                {
                                    DataType bl_ = i?.Serviced;
                                    CqlInterval<CqlDateTime> bm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bl_);
                                    CqlDateTime bn_ = context.Operators.Start(bm_);
                                    Quantity bo_ = i?.Quantity;
                                    FhirDecimal bp_ = bo_?.ValueElement;
                                    decimal? bq_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bp_);
                                    CqlDateTime br_ = context.Operators.Add(bn_, new CqlQuantity(bq_, "day"));
                                    CqlQuantity bs_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime bt_ = context.Operators.Subtract(br_, bs_);
                                    CqlInterval<CqlDateTime> bu_ = context.Operators.Interval(bn_, bt_, true, true);
                                    bi_ = bu_;
                                }
                                else
                                {
                                    DataType bv_ = i?.Serviced;
                                    CqlDate bw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bv_ as Date);
                                    Quantity bx_ = i?.Quantity;
                                    FhirDecimal by_ = bx_?.ValueElement;
                                    decimal? bz_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, by_);
                                    CqlDate ca_ = context.Operators.Add(bw_, new CqlQuantity(bz_, "day"));
                                    CqlQuantity cb_ = context.Operators.Quantity(1m, "day");
                                    CqlDate cc_ = context.Operators.Subtract(ca_, cb_);
                                    CqlInterval<CqlDate> cd_ = context.Operators.Interval(bw_, cc_, true, true);
                                    CqlDate ce_ = cd_?.low;
                                    CqlDateTime cf_ = context.Operators.ConvertDateToDateTime(ce_);
                                    CqlDate cg_ = cd_?.high;
                                    CqlDateTime ch_ = context.Operators.ConvertDateToDateTime(cg_);
                                    bool? ci_ = cd_?.lowClosed;
                                    bool? cj_ = cd_?.highClosed;
                                    CqlInterval<CqlDateTime> ck_ = context.Operators.Interval(cf_, ch_, ci_, cj_);
                                    bi_ = ck_;
                                }
                                be_ = bi_;
                            }
                            else
                            {
                                be_ = null as CqlInterval<CqlDateTime>;
                            }
                            (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? bf_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, be_);
                            return bf_;
                        }

                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> ap_ = context.Operators.Select<Claim.ItemComponent, (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>(an_, ao_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? aq_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, ap_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?[] ar_ = [
                            aq_,
                        ];

                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? as_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? ItemCalculation) {
                            IEnumerable<Claim.ItemComponent> cl_ = LineItemDefinition?.LineItems;
                            bool? cm_ = context.Operators.Exists<Claim.ItemComponent>(cl_);
                            if (cm_ ?? false)
                            {
                                Claim cn_ = LineItemDefinition?.Claim;
                                IEnumerable<Claim.ItemComponent> co_ = LineItemDefinition?.LineItems;

                                bool? cp_(Claim.ItemComponent @this) {
                                    DataType da_ = @this?.Serviced;
                                    bool? db_ = context.Operators.Not((bool?)(da_ is null));
                                    return db_;
                                }

                                IEnumerable<Claim.ItemComponent> cq_ = context.Operators.Where<Claim.ItemComponent>(co_, cp_);

                                object cr_(Claim.ItemComponent @this) {
                                    DataType dc_ = @this?.Serviced;
                                    return dc_;
                                }

                                IEnumerable<object> cs_ = context.Operators.Select<Claim.ItemComponent, object>(cq_, cr_);

                                CqlInterval<CqlDateTime> ct_(object NormalDate) {
                                    CqlInterval<CqlDateTime> dd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                                    return dd_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> cu_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(cs_, ct_);
                                IEnumerable<CqlInterval<CqlDateTime>> cv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(cu_);
                                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> cw_ = ItemCalculation?.CoveredDays;

                                CqlInterval<CqlDateTime> cx_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d) {
                                    CqlInterval<CqlDateTime> de_ = d?.DaysSupplyInterval;
                                    return de_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> cy_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(cw_, cx_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? cz_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, cn_, co_, cv_, cy_);
                                return cz_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> at_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?>)ar_, as_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? au_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(at_);
                        return au_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> aj_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)ah_, ai_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ak_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(aj_);
                    return ak_;
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> v_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)t_, u_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? w_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(v_);
                return w_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> m_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(k_, l_);

            bool? n_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList) {
                bool? df_ = context.Operators.Not((bool?)(FinalList is null));
                return df_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> o_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(m_, n_);
            return o_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> h_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)f_, g_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> i_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(h_);
        return i_;
    }


    [CqlFunctionDefinition("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode d) {
            string n_ = d?.code;
            return n_;
        }

        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);

        string e_(CqlCode p) {
            string o_ = p?.code;
            return o_;
        }

        IEnumerable<string> f_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, e_);
        IEnumerable<string> g_ = context.Operators.Distinct<string>(f_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? h_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, a_, d_, g_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] i_ = [
            h_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim> p_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                p_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> w_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? x_(Claim DiagnosisLine) {
                    List<Claim.DiagnosisComponent> z_ = DiagnosisLine?.Diagnosis;

                    bool? aa_(Claim.DiagnosisComponent @this) {
                        DataType ao_ = @this?.Diagnosis;
                        bool? ap_ = context.Operators.Not((bool?)(ao_ is null));
                        return ap_;
                    }

                    IEnumerable<Claim.DiagnosisComponent> ab_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)z_, aa_);

                    object ac_(Claim.DiagnosisComponent @this) {
                        DataType aq_ = @this?.Diagnosis;
                        return aq_;
                    }

                    IEnumerable<object> ad_ = context.Operators.Select<Claim.DiagnosisComponent, object>(ab_, ac_);

                    bool? ae_(object @this) {
                        object ar_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                        bool? as_ = context.Operators.Not((bool?)(ar_ is null));
                        return as_;
                    }

                    IEnumerable<object> af_ = context.Operators.Where<object>(ad_, ae_);

                    object ag_(object @this) {
                        object at_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                        return at_;
                    }

                    IEnumerable<object> ah_ = context.Operators.Select<object, object>(af_, ag_);
                    IEnumerable<object> ai_ = context.Operators.FlattenLateBoundList(ah_);
                    Coding aj_(object @object) => (Coding)@object;
                    IEnumerable<Coding> ak_ = context.Operators.Select<object, Coding>(ai_, aj_);

                    bool? al_(Coding HeaderCode) {
                        Code au_ = HeaderCode?.CodeElement;
                        string av_ = au_?.Value;
                        IEnumerable<string> aw_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                        bool? ax_ = context.Operators.In<string>(av_, aw_);
                        return ax_;
                    }

                    IEnumerable<Coding> am_ = context.Operators.Where<Coding>(ak_, al_);
                    bool? an_ = context.Operators.Exists<Coding>(am_);
                    return an_;
                }

                IEnumerable<Claim> y_ = context.Operators.Where<Claim>(w_, x_);
                p_ = y_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? q_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, p_);
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] r_ = [
                q_,
            ];

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> s_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ClaimWithProcedure) {
                IEnumerable<Claim> ay_ = ClaimWithProcedure?.DiagnosisItems;

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_(Claim ClaimofInterest) {
                    Claim be_;
                    if (ClaimofInterest is null)
                    {
                        be_ = default;
                    }
                    else
                    {
                        Claim[] bl_ = [
                            ClaimofInterest,
                        ];

                        bool? bm_(Claim ItemOnLine) {
                            List<Claim.ProcedureComponent> bp_ = ItemOnLine?.Procedure;

                            bool? bq_(Claim.ProcedureComponent @this) {
                                DataType cs_ = @this?.Procedure;
                                bool? ct_ = context.Operators.Not((bool?)(cs_ is null));
                                return ct_;
                            }

                            IEnumerable<Claim.ProcedureComponent> br_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)bp_, bq_);

                            object bs_(Claim.ProcedureComponent @this) {
                                DataType cu_ = @this?.Procedure;
                                return cu_;
                            }

                            IEnumerable<object> bt_ = context.Operators.Select<Claim.ProcedureComponent, object>(br_, bs_);

                            bool? bu_(object @this) {
                                object cv_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? cw_ = context.Operators.Not((bool?)(cv_ is null));
                                return cw_;
                            }

                            IEnumerable<object> bv_ = context.Operators.Where<object>(bt_, bu_);

                            object bw_(object @this) {
                                object cx_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return cx_;
                            }

                            IEnumerable<object> bx_ = context.Operators.Select<object, object>(bv_, bw_);
                            IEnumerable<object> by_ = context.Operators.FlattenLateBoundList(bx_);
                            Coding bz_(object @object) => (Coding)@object;
                            IEnumerable<Coding> ca_ = context.Operators.Select<object, Coding>(by_, bz_);

                            bool? cb_(Coding ProcedureHeaderCode) {
                                Code cy_ = ProcedureHeaderCode?.CodeElement;
                                string cz_ = cy_?.Value;
                                IEnumerable<string> da_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                bool? db_ = context.Operators.In<string>(cz_, da_);
                                return db_;
                            }

                            IEnumerable<Coding> cc_ = context.Operators.Where<Coding>(ca_, cb_);
                            bool? cd_ = context.Operators.Exists<Coding>(cc_);
                            List<Claim.ItemComponent> ce_ = ItemOnLine?.Item;

                            bool? cf_(Claim.ItemComponent @this) {
                                CodeableConcept dc_ = @this?.ProductOrService;
                                bool? dd_ = context.Operators.Not((bool?)(dc_ is null));
                                return dd_;
                            }

                            IEnumerable<Claim.ItemComponent> cg_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ce_, cf_);

                            CodeableConcept ch_(Claim.ItemComponent @this) {
                                CodeableConcept de_ = @this?.ProductOrService;
                                return de_;
                            }

                            IEnumerable<CodeableConcept> ci_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(cg_, ch_);

                            bool? cj_(CodeableConcept @this) {
                                List<Coding> df_ = @this?.Coding;
                                bool? dg_ = context.Operators.Not((bool?)(df_ is null));
                                return dg_;
                            }

                            IEnumerable<CodeableConcept> ck_ = context.Operators.Where<CodeableConcept>(ci_, cj_);

                            List<Coding> cl_(CodeableConcept @this) {
                                List<Coding> dh_ = @this?.Coding;
                                return dh_;
                            }

                            IEnumerable<List<Coding>> cm_ = context.Operators.Select<CodeableConcept, List<Coding>>(ck_, cl_);
                            IEnumerable<Coding> cn_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)cm_);

                            bool? co_(Coding LineCode) {
                                Code di_ = LineCode?.CodeElement;
                                string dj_ = di_?.Value;
                                IEnumerable<string> dk_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                bool? dl_ = context.Operators.In<string>(dj_, dk_);
                                return dl_;
                            }

                            IEnumerable<Coding> cp_ = context.Operators.Where<Coding>(cn_, co_);
                            bool? cq_ = context.Operators.Exists<Coding>(cp_);
                            bool? cr_ = context.Operators.Or(cd_, cq_);
                            return cr_;
                        }

                        IEnumerable<Claim> bn_ = context.Operators.Where<Claim>((IEnumerable<Claim>)bl_, bm_);
                        Claim bo_ = context.Operators.SingletonFrom<Claim>(bn_);
                        be_ = bo_;
                    }
                    (CqlTupleMetadata, Claim ProcedureItems)? bf_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, be_);
                    (CqlTupleMetadata, Claim ProcedureItems)?[] bg_ = [
                        bf_,
                    ];

                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bh_((CqlTupleMetadata, Claim ProcedureItems)? HeaderDefinition) {
                        Claim dm_ = HeaderDefinition?.ProcedureItems;
                        bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
                        if (dn_ ?? false)
                        {
                            Claim do_ = HeaderDefinition?.ProcedureItems;
                            List<Claim.ItemComponent> dp_ = do_?.Item;

                            CqlInterval<CqlDateTime> dq_(Claim.ItemComponent NormalDate) {
                                DataType du_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> dv_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, du_);
                                return dv_;
                            }

                            IEnumerable<CqlInterval<CqlDateTime>> dr_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)dp_, dq_);
                            IEnumerable<CqlInterval<CqlDateTime>> ds_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dr_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dt_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, do_, ds_);
                            return dt_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bi_ = context.Operators.Select<(CqlTupleMetadata, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim ProcedureItems)?>)bg_, bh_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bj_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bi_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bj_);
                    return bk_;
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ba_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ay_, az_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bb_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ba_);

                bool? bc_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                    bool? dw_ = context.Operators.Not((bool?)(FinalList is null));
                    return dw_;
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bd_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bb_, bc_);
                return bd_;
            }

            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> t_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)r_, s_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> u_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(t_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> v_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(u_);
            return v_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)i_, j_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> l_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(k_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(l_);
        return m_;
    }


    [CqlFunctionDefinition("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode d) {
            string n_ = d?.code;
            return n_;
        }

        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);

        string e_(CqlCode p) {
            string o_ = p?.code;
            return o_;
        }

        IEnumerable<string> f_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, e_);
        IEnumerable<string> g_ = context.Operators.Distinct<string>(f_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? h_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, a_, d_, g_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] i_ = [
            h_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure) {
            IEnumerable<Claim> p_ = ClaimWithProcedure?.MedicalClaim;

            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? q_(Claim ClaimofInterest) {
                Claim v_;
                if (ClaimofInterest is null)
                {
                    v_ = default;
                }
                else
                {
                    Claim[] ac_ = [
                        ClaimofInterest,
                    ];

                    bool? ad_(Claim ItemOnLine) {
                        List<Claim.ItemComponent> ag_ = ItemOnLine?.Item;

                        bool? ah_(Claim.ItemComponent @this) {
                            CodeableConcept bj_ = @this?.ProductOrService;
                            bool? bk_ = context.Operators.Not((bool?)(bj_ is null));
                            return bk_;
                        }

                        IEnumerable<Claim.ItemComponent> ai_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ag_, ah_);

                        CodeableConcept aj_(Claim.ItemComponent @this) {
                            CodeableConcept bl_ = @this?.ProductOrService;
                            return bl_;
                        }

                        IEnumerable<CodeableConcept> ak_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ai_, aj_);

                        bool? al_(CodeableConcept @this) {
                            List<Coding> bm_ = @this?.Coding;
                            bool? bn_ = context.Operators.Not((bool?)(bm_ is null));
                            return bn_;
                        }

                        IEnumerable<CodeableConcept> am_ = context.Operators.Where<CodeableConcept>(ak_, al_);

                        List<Coding> an_(CodeableConcept @this) {
                            List<Coding> bo_ = @this?.Coding;
                            return bo_;
                        }

                        IEnumerable<List<Coding>> ao_ = context.Operators.Select<CodeableConcept, List<Coding>>(am_, an_);
                        IEnumerable<Coding> ap_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ao_);

                        bool? aq_(Coding LineCode) {
                            Code bp_ = LineCode?.CodeElement;
                            string bq_ = bp_?.Value;
                            IEnumerable<string> br_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? bs_ = context.Operators.In<string>(bq_, br_);
                            return bs_;
                        }

                        IEnumerable<Coding> ar_ = context.Operators.Where<Coding>(ap_, aq_);
                        bool? as_ = context.Operators.Exists<Coding>(ar_);
                        List<Claim.ProcedureComponent> at_ = ItemOnLine?.Procedure;

                        bool? au_(Claim.ProcedureComponent @this) {
                            DataType bt_ = @this?.Procedure;
                            bool? bu_ = context.Operators.Not((bool?)(bt_ is null));
                            return bu_;
                        }

                        IEnumerable<Claim.ProcedureComponent> av_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)at_, au_);

                        object aw_(Claim.ProcedureComponent @this) {
                            DataType bv_ = @this?.Procedure;
                            return bv_;
                        }

                        IEnumerable<object> ax_ = context.Operators.Select<Claim.ProcedureComponent, object>(av_, aw_);

                        bool? ay_(object @this) {
                            object bw_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? bx_ = context.Operators.Not((bool?)(bw_ is null));
                            return bx_;
                        }

                        IEnumerable<object> az_ = context.Operators.Where<object>(ax_, ay_);

                        object ba_(object @this) {
                            object by_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            return by_;
                        }

                        IEnumerable<object> bb_ = context.Operators.Select<object, object>(az_, ba_);
                        IEnumerable<object> bc_ = context.Operators.FlattenLateBoundList(bb_);
                        Coding bd_(object @object) => (Coding)@object;
                        IEnumerable<Coding> be_ = context.Operators.Select<object, Coding>(bc_, bd_);

                        bool? bf_(Coding HeaderCode) {
                            Code bz_ = HeaderCode?.CodeElement;
                            string ca_ = bz_?.Value;
                            IEnumerable<string> cb_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? cc_ = context.Operators.In<string>(ca_, cb_);
                            return cc_;
                        }

                        IEnumerable<Coding> bg_ = context.Operators.Where<Coding>(be_, bf_);
                        bool? bh_ = context.Operators.Exists<Coding>(bg_);
                        bool? bi_ = context.Operators.Or(as_, bh_);
                        return bi_;
                    }

                    IEnumerable<Claim> ae_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ac_, ad_);
                    Claim af_ = context.Operators.SingletonFrom<Claim>(ae_);
                    v_ = af_;
                }
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? w_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, v_);
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?[] x_ = [
                    w_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? y_((CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? DiagnosisCheck) {
                    Claim cd_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] ce_ = [
                        cd_,
                    ];

                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cf_(Claim ClaimforDiagnosis) {
                        List<Claim.ItemComponent> cj_ = ClaimforDiagnosis?.Item;
                        Claim ck_;
                        if (ClaimforDiagnosis is null)
                        {
                            ck_ = default;
                        }
                        else
                        {
                            Claim[] cr_ = [
                                ClaimforDiagnosis,
                            ];

                            bool? cs_(Claim RightClaim) {
                                List<Claim.DiagnosisComponent> cv_ = RightClaim?.Diagnosis;

                                bool? cw_(Claim.DiagnosisComponent RightDiagnosis) {
                                    PositiveInt cz_ = RightDiagnosis?.SequenceElement;
                                    Integer da_ = context.Operators.Convert<Integer>(cz_);
                                    int? db_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, da_);
                                    bool? dc_ = context.Operators.Equal(db_, 1);
                                    DataType dd_ = RightDiagnosis?.Diagnosis;
                                    IEnumerable<Coding> de_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(dd_, "coding");

                                    bool? df_(Coding DiagnosisCode) {
                                        Code dj_ = DiagnosisCode?.CodeElement;
                                        string dk_ = dj_?.Value;
                                        IEnumerable<string> dl_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                        bool? dm_ = context.Operators.In<string>(dk_, dl_);
                                        return dm_;
                                    }

                                    IEnumerable<Coding> dg_ = context.Operators.Where<Coding>(de_, df_);
                                    bool? dh_ = context.Operators.Exists<Coding>(dg_);
                                    bool? di_ = context.Operators.And(dc_, dh_);
                                    return di_;
                                }

                                IEnumerable<Claim.DiagnosisComponent> cx_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)cv_, cw_);
                                bool? cy_ = context.Operators.Exists<Claim.DiagnosisComponent>(cx_);
                                return cy_;
                            }

                            IEnumerable<Claim> ct_ = context.Operators.Where<Claim>((IEnumerable<Claim>)cr_, cs_);
                            Claim cu_ = context.Operators.SingletonFrom<Claim>(ct_);
                            ck_ = cu_;
                        }
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? cl_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)cj_, ck_);
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] cm_ = [
                            cl_,
                        ];

                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cn_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition) {
                            bool? dn_ = context.Operators.Not((bool?)(LineItemDefinition is null));
                            Claim do_ = LineItemDefinition?.LineItems;
                            bool? dp_ = context.Operators.Not((bool?)(do_ is null));
                            bool? dq_ = context.Operators.And(dn_, dp_);
                            if (dq_ ?? false)
                            {
                                Claim dr_ = LineItemDefinition?.LineItems;
                                List<Claim.ItemComponent> ds_ = dr_?.Item;

                                CqlInterval<CqlDateTime> dt_(Claim.ItemComponent NormalDate) {
                                    DataType dw_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> dx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dw_);
                                    return dx_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> du_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)ds_, dt_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dv_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, dr_, du_);
                                return dv_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> co_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)cm_, cn_);
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> cp_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(co_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(cp_);
                        return cq_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> cg_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)ce_, cf_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ch_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(cg_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ci_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ch_);
                    return ci_;
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> z_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?>)x_, y_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> aa_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(z_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ab_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(aa_);
                return ab_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> r_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_, q_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> s_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(r_);

            bool? t_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                bool? dy_ = context.Operators.Not((bool?)(FinalList is null));
                return dy_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> u_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(s_, t_);
            return u_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)i_, j_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> l_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(k_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(l_);
        return m_;
    }


    [CqlFunctionDefinition("Medical Claims With Principal Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode d) {
            string k_ = d?.code;
            return k_;
        }

        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? e_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, a_, d_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] f_ = [
            e_,
        ];

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim> l_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                l_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> s_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? t_(Claim RightClaim) {
                    List<Claim.DiagnosisComponent> v_ = RightClaim?.Diagnosis;

                    bool? w_(Claim.DiagnosisComponent RightDiagnosis) {
                        PositiveInt z_ = RightDiagnosis?.SequenceElement;
                        Integer aa_ = context.Operators.Convert<Integer>(z_);
                        int? ab_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, aa_);
                        bool? ac_ = context.Operators.Equal(ab_, 1);
                        DataType ad_ = RightDiagnosis?.Diagnosis;
                        IEnumerable<Coding> ae_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(ad_, "coding");

                        bool? af_(Coding DiagnosisCode) {
                            Code aj_ = DiagnosisCode?.CodeElement;
                            string ak_ = aj_?.Value;
                            IEnumerable<string> al_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? am_ = context.Operators.In<string>(ak_, al_);
                            return am_;
                        }

                        IEnumerable<Coding> ag_ = context.Operators.Where<Coding>(ae_, af_);
                        bool? ah_ = context.Operators.Exists<Coding>(ag_);
                        bool? ai_ = context.Operators.And(ac_, ah_);
                        return ai_;
                    }

                    IEnumerable<Claim.DiagnosisComponent> x_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)v_, w_);
                    bool? y_ = context.Operators.Exists<Claim.DiagnosisComponent>(x_);
                    return y_;
                }

                IEnumerable<Claim> u_ = context.Operators.Where<Claim>(s_, t_);
                l_ = u_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)? m_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, l_);
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)?[] n_ = [
                m_,
            ];

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_((CqlTupleMetadata, IEnumerable<Claim> LineItems)? LineItemDefinition) {
                IEnumerable<Claim> an_ = LineItemDefinition?.LineItems;

                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ao_(Claim ClaimWithDiagnosis) {
                    if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
                    {
                        IEnumerable<Claim> at_ = LineItemDefinition?.LineItems;

                        bool? au_(Claim @this) {
                            List<Claim.ItemComponent> bd_ = @this?.Item;
                            bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                            return be_;
                        }

                        IEnumerable<Claim> av_ = context.Operators.Where<Claim>(at_, au_);

                        List<Claim.ItemComponent> aw_(Claim @this) {
                            List<Claim.ItemComponent> bf_ = @this?.Item;
                            return bf_;
                        }

                        IEnumerable<List<Claim.ItemComponent>> ax_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(av_, aw_);
                        IEnumerable<Claim.ItemComponent> ay_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ax_);

                        CqlInterval<CqlDateTime> az_(Claim.ItemComponent NormalDate) {
                            DataType bg_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> bh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bg_);
                            return bh_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> ba_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(ay_, az_);
                        IEnumerable<CqlInterval<CqlDateTime>> bb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ba_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bc_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, at_, bb_);
                        return bc_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ap_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(an_, ao_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> aq_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ap_);

                bool? ar_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                    bool? bi_ = context.Operators.Not((bool?)(FinalList is null));
                    return bi_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> as_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(aq_, ar_);
                return as_;
            }

            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?>)n_, o_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> q_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(p_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> r_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(q_);
            return r_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> h_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)f_, g_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(h_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Service and Condition")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse) {
            IEnumerable<ClaimResponse> k_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            IEnumerable<Claim> l_ = MedicalClaimAndResponse?.MedicalClaim;
            bool? m_ = context.Operators.And((bool?)(k_ is null), (bool?)(l_ is null));
            if (m_ ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse> n_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim> o_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? p_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, n_, o_, ProductOrServiceValueSet, DiagnosisValueSet);
                return p_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] g_ = [
            f_,
        ];

        bool? h_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
            bool? q_ = context.Operators.Not((bool?)(FinalList is null));
            return q_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> i_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)g_, h_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? j_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Get All Professional and Institutional Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> a_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
        IEnumerable<Claim> b_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? c_ = (CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE, a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Get Corresponding Claim for Services and Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
            c_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse) {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> i_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? j_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent> s_ = medClaim?.LineItems;

                bool? t_(Claim.ItemComponent medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> w_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? x_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent> aa_ = pClaim?.LineItems;

                        bool? ab_(ClaimResponse.ItemComponent pClaimLineItem) {
                            Id ae_;
                            Claim as_ = medClaim?.ClaimofInterest;
                            bool at_ = as_ is Resource;
                            if (at_)
                            {
                                Claim au_ = medClaim?.ClaimofInterest;
                                ae_ = (au_ as Resource).IdElement;
                            }
                            else
                            {
                                ae_ = default;
                            }
                            string af_ = FHIRHelpers_4_0_001.Instance.ToString(context, ae_);
                            ClaimResponse ag_ = pClaim?.Response;
                            ResourceReference ah_ = ag_?.Request;
                            FhirString ai_ = ah_?.ReferenceElement;
                            string aj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ai_);
                            string ak_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, aj_);
                            bool? al_ = context.Operators.Equal(af_, ak_);
                            PositiveInt am_ = medClaimLineItem?.SequenceElement;
                            Integer an_ = context.Operators.Convert<Integer>(am_);
                            PositiveInt ao_ = pClaimLineItem?.ItemSequenceElement;
                            Integer ap_ = context.Operators.Convert<Integer>(ao_);
                            bool? aq_ = context.Operators.Equal(an_, ap_);
                            bool? ar_ = context.Operators.And(al_, aq_);
                            return ar_;
                        }

                        IEnumerable<ClaimResponse.ItemComponent> ac_ = context.Operators.Where<ClaimResponse.ItemComponent>(aa_, ab_);
                        bool? ad_ = context.Operators.Exists<ClaimResponse.ItemComponent>(ac_);
                        return ad_;
                    }

                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> y_ = context.Operators.Where<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(w_, x_);
                    bool? z_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(y_);
                    return z_;
                }

                IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>(s_, t_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? v_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, u_);
                return v_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> k_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(k_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? m_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, l_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] n_ = [
                m_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? av_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ba_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? bb_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bh_ = @this?.ClaimItem;
                    bool? bi_ = context.Operators.Not((bool?)(bh_ is null));
                    return bi_;
                }

                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);

                IEnumerable<Claim.ItemComponent> bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bj_ = @this?.ClaimItem;
                    return bj_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent>> be_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
                IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
                bool? bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);
                if (bg_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bk_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bl_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? by_ = @this?.PaidClaim;
                        bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                        return bz_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bm_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);

                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ca_ = @this?.PaidClaim;
                        return ca_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bo_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);

                    bool? bp_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cb_ = @this?.ClaimItem;
                        bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                        return cc_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bp_);

                    IEnumerable<Claim.ItemComponent> br_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cd_ = @this?.ClaimItem;
                        return cd_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bq_, br_);
                    IEnumerable<Claim.ItemComponent> bt_ = context.Operators.Flatten<Claim.ItemComponent>(bs_);

                    CqlInterval<CqlDateTime> bu_(Claim.ItemComponent PaidItem) {
                        DataType ce_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> cf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ce_);
                        return cf_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bv_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bt_, bu_);
                    IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bv_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bx_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bo_, bw_);
                    av_ = bx_;
                }
                else
                {
                    av_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] aw_ = [
                    av_,
                ];

                bool? ax_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                    bool? cg_ = context.Operators.Not((bool?)(FinalList is null));
                    return cg_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ay_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)aw_, ax_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ay_);
                return az_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(q_);
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Get All Paid Claim Reponses")]
    public IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {

        bool? a_(ClaimResponse ResponseItem) {
            Code<ClaimProcessingCodes> i_ = ResponseItem?.OutcomeElement;
            string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
            string[] k_ = [
                "complete",
                "partial",
            ];
            bool? l_ = context.Operators.In<string>(j_, (IEnumerable<string>)k_);
            return l_;
        }

        IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? c_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, b_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?[] d_ = [
            c_,
        ];

        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> e_((CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ClaimResponse) {
            IEnumerable<ClaimResponse> m_ = ClaimResponse?.PaidResponse;

            (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? n_(ClaimResponse ClmResp) {
                ResourceReference q_ = ClmResp?.Request;
                FhirString r_ = q_?.ReferenceElement;
                string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
                string t_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, s_);
                List<ClaimResponse.ItemComponent> u_ = ClmResp?.Item;

                bool? v_(ClaimResponse.ItemComponent ResponseItem) {
                    List<ClaimResponse.AdjudicationComponent> y_ = ResponseItem?.Adjudication;

                    bool? z_(ClaimResponse.AdjudicationComponent @this) {
                        CodeableConcept at_ = @this?.Category;
                        bool? au_ = context.Operators.Not((bool?)(at_ is null));
                        return au_;
                    }

                    IEnumerable<ClaimResponse.AdjudicationComponent> aa_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)y_, z_);

                    CodeableConcept ab_(ClaimResponse.AdjudicationComponent @this) {
                        CodeableConcept av_ = @this?.Category;
                        return av_;
                    }

                    IEnumerable<CodeableConcept> ac_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(aa_, ab_);

                    bool? ad_(CodeableConcept @this) {
                        List<Coding> aw_ = @this?.Coding;
                        bool? ax_ = context.Operators.Not((bool?)(aw_ is null));
                        return ax_;
                    }

                    IEnumerable<CodeableConcept> ae_ = context.Operators.Where<CodeableConcept>(ac_, ad_);

                    List<Coding> af_(CodeableConcept @this) {
                        List<Coding> ay_ = @this?.Coding;
                        return ay_;
                    }

                    IEnumerable<List<Coding>> ag_ = context.Operators.Select<CodeableConcept, List<Coding>>(ae_, af_);
                    IEnumerable<Coding> ah_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ag_);

                    bool? ai_(Coding CategoryItem) {
                        Code az_ = CategoryItem?.CodeElement;
                        string ba_ = az_?.Value;
                        bool? bb_ = context.Operators.Equal(ba_, "benefit");
                        return bb_;
                    }

                    IEnumerable<Coding> aj_ = context.Operators.Where<Coding>(ah_, ai_);
                    bool? ak_ = context.Operators.Exists<Coding>(aj_);

                    bool? al_(ClaimResponse.AdjudicationComponent @this) {
                        Money bc_ = @this?.Amount;
                        bool? bd_ = context.Operators.Not((bool?)(bc_ is null));
                        return bd_;
                    }

                    IEnumerable<ClaimResponse.AdjudicationComponent> am_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)y_, al_);

                    Money an_(ClaimResponse.AdjudicationComponent @this) {
                        Money be_ = @this?.Amount;
                        return be_;
                    }

                    IEnumerable<Money> ao_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(am_, an_);

                    bool? ap_(Money DollarAmount) {
                        FhirDecimal bf_ = DollarAmount?.ValueElement;
                        decimal? bg_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bf_);
                        decimal? bh_ = context.Operators.ConvertIntegerToDecimal(0);
                        bool? bi_ = context.Operators.Greater(bg_, bh_);
                        return bi_;
                    }

                    IEnumerable<Money> aq_ = context.Operators.Where<Money>(ao_, ap_);
                    bool? ar_ = context.Operators.Exists<Money>(aq_);
                    bool? as_ = context.Operators.And(ak_, ar_);
                    return as_;
                }

                IEnumerable<ClaimResponse.ItemComponent> w_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)u_, v_);
                (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? x_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, t_, w_);
                return x_;
            }

            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> o_ = context.Operators.Select<ClaimResponse, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(m_, n_);
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> p_ = context.Operators.Distinct<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(o_);
            return p_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?>)d_, e_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> g_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(f_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> h_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {

        bool? a_(Claim AllClaims) {
            List<Claim.ItemComponent> f_ = AllClaims?.Item;

            bool? g_(Claim.ItemComponent @this) {
                CodeableConcept ai_ = @this?.ProductOrService;
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                return aj_;
            }

            IEnumerable<Claim.ItemComponent> h_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)f_, g_);

            CodeableConcept i_(Claim.ItemComponent @this) {
                CodeableConcept ak_ = @this?.ProductOrService;
                return ak_;
            }

            IEnumerable<CodeableConcept> j_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(h_, i_);

            bool? k_(CodeableConcept @this) {
                List<Coding> al_ = @this?.Coding;
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                return am_;
            }

            IEnumerable<CodeableConcept> l_ = context.Operators.Where<CodeableConcept>(j_, k_);

            List<Coding> m_(CodeableConcept @this) {
                List<Coding> an_ = @this?.Coding;
                return an_;
            }

            IEnumerable<List<Coding>> n_ = context.Operators.Select<CodeableConcept, List<Coding>>(l_, m_);
            IEnumerable<Coding> o_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)n_);

            bool? p_(Coding ProductOrServiceCode) {
                CqlCode ao_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? ap_ = context.Operators.In<CqlCode>(ao_, ProductOrServiceValueSet);
                return ap_;
            }

            IEnumerable<Coding> q_ = context.Operators.Where<Coding>(o_, p_);
            bool? r_ = context.Operators.Exists<Coding>(q_);
            List<Claim.DiagnosisComponent> s_ = AllClaims?.Diagnosis;

            bool? t_(Claim.DiagnosisComponent @this) {
                DataType aq_ = @this?.Diagnosis;
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                return ar_;
            }

            IEnumerable<Claim.DiagnosisComponent> u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);

            object v_(Claim.DiagnosisComponent @this) {
                DataType as_ = @this?.Diagnosis;
                return as_;
            }

            IEnumerable<object> w_ = context.Operators.Select<Claim.DiagnosisComponent, object>(u_, v_);

            bool? x_(object @this) {
                object at_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? au_ = context.Operators.Not((bool?)(at_ is null));
                return au_;
            }

            IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);

            object z_(object @this) {
                object av_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                return av_;
            }

            IEnumerable<object> aa_ = context.Operators.Select<object, object>(y_, z_);
            IEnumerable<object> ab_ = context.Operators.FlattenLateBoundList(aa_);
            Coding ac_(object @object) => (Coding)@object;
            IEnumerable<Coding> ad_ = context.Operators.Select<object, Coding>(ab_, ac_);

            bool? ae_(Coding DiagnosisCode) {
                CqlCode aw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? ax_ = context.Operators.In<CqlCode>(aw_, DiagnosisValueSet);
                return ax_;
            }

            IEnumerable<Coding> af_ = context.Operators.Where<Coding>(ad_, ae_);
            bool? ag_ = context.Operators.Exists<Coding>(af_);
            bool? ah_ = context.Operators.And(r_, ag_);
            return ah_;
        }

        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim ProcedureClaims) {
            Id ay_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> az_ = ProcedureClaims?.Item;

            bool? ba_(Claim.ItemComponent ResponseItem) {
                CodeableConcept bd_ = ResponseItem?.ProductOrService;
                List<Coding> be_ = bd_?.Coding;

                bool? bf_(Coding ProductOrServiceCode) {
                    CqlCode bi_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? bj_ = context.Operators.In<CqlCode>(bi_, ProductOrServiceValueSet);
                    return bj_;
                }

                IEnumerable<Coding> bg_ = context.Operators.Where<Coding>((IEnumerable<Coding>)be_, bf_);
                bool? bh_ = context.Operators.Exists<Coding>(bg_);
                return bh_;
            }

            IEnumerable<Claim.ItemComponent> bb_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)az_, ba_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bc_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, ay_, bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse) {
            IEnumerable<ClaimResponse> g_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            IEnumerable<Claim> h_ = MedicalClaimAndResponse?.MedicalClaim;
            bool? i_ = context.Operators.And((bool?)(g_ is null), (bool?)(h_ is null));
            if (i_ ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse> j_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim> k_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? l_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, j_, k_, ProductOrServiceValueSet, DiagnosisValueSet);
                return l_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Get Corresponding Claim for Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
            c_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse) {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> i_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? j_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent> s_ = medClaim?.LineItems;

                bool? t_(Claim.ItemComponent medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> w_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? x_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent> aa_ = pClaim?.LineItems;

                        bool? ab_(ClaimResponse.ItemComponent pClaimLineItem) {
                            Id ae_;
                            Claim as_ = medClaim?.ClaimofInterest;
                            bool at_ = as_ is Resource;
                            if (at_)
                            {
                                Claim au_ = medClaim?.ClaimofInterest;
                                ae_ = (au_ as Resource).IdElement;
                            }
                            else
                            {
                                ae_ = default;
                            }
                            string af_ = FHIRHelpers_4_0_001.Instance.ToString(context, ae_);
                            ClaimResponse ag_ = pClaim?.Response;
                            ResourceReference ah_ = ag_?.Request;
                            FhirString ai_ = ah_?.ReferenceElement;
                            string aj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ai_);
                            string ak_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, aj_);
                            bool? al_ = context.Operators.Equal(af_, ak_);
                            PositiveInt am_ = medClaimLineItem?.SequenceElement;
                            Integer an_ = context.Operators.Convert<Integer>(am_);
                            PositiveInt ao_ = pClaimLineItem?.ItemSequenceElement;
                            Integer ap_ = context.Operators.Convert<Integer>(ao_);
                            bool? aq_ = context.Operators.Equal(an_, ap_);
                            bool? ar_ = context.Operators.And(al_, aq_);
                            return ar_;
                        }

                        IEnumerable<ClaimResponse.ItemComponent> ac_ = context.Operators.Where<ClaimResponse.ItemComponent>(aa_, ab_);
                        bool? ad_ = context.Operators.Exists<ClaimResponse.ItemComponent>(ac_);
                        return ad_;
                    }

                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> y_ = context.Operators.Where<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(w_, x_);
                    bool? z_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(y_);
                    return z_;
                }

                IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>(s_, t_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? v_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, u_);
                return v_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> k_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(k_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? m_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, l_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] n_ = [
                m_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? av_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ba_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? bb_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bh_ = @this?.ClaimItem;
                    bool? bi_ = context.Operators.Not((bool?)(bh_ is null));
                    return bi_;
                }

                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);

                IEnumerable<Claim.ItemComponent> bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bj_ = @this?.ClaimItem;
                    return bj_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent>> be_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
                IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
                bool? bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);
                if (bg_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bk_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bl_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? by_ = @this?.PaidClaim;
                        bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                        return bz_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bm_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);

                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ca_ = @this?.PaidClaim;
                        return ca_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bo_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);

                    bool? bp_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cb_ = @this?.ClaimItem;
                        bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                        return cc_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bp_);

                    IEnumerable<Claim.ItemComponent> br_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cd_ = @this?.ClaimItem;
                        return cd_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bq_, br_);
                    IEnumerable<Claim.ItemComponent> bt_ = context.Operators.Flatten<Claim.ItemComponent>(bs_);

                    CqlInterval<CqlDateTime> bu_(Claim.ItemComponent PaidItem) {
                        DataType ce_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> cf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ce_);
                        return cf_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bv_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bt_, bu_);
                    IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bv_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bx_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bo_, bw_);
                    av_ = bx_;
                }
                else
                {
                    av_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] aw_ = [
                    av_,
                ];

                bool? ax_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                    bool? cg_ = context.Operators.Not((bool?)(FinalList is null));
                    return cg_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ay_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)aw_, ax_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ay_);
                return az_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(q_);
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {

        bool? a_(Claim AllClaims) {
            List<Claim.ItemComponent> f_ = AllClaims?.Item;

            bool? g_(Claim.ItemComponent @this) {
                CodeableConcept ai_ = @this?.ProductOrService;
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                return aj_;
            }

            IEnumerable<Claim.ItemComponent> h_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)f_, g_);

            CodeableConcept i_(Claim.ItemComponent @this) {
                CodeableConcept ak_ = @this?.ProductOrService;
                return ak_;
            }

            IEnumerable<CodeableConcept> j_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(h_, i_);

            bool? k_(CodeableConcept @this) {
                List<Coding> al_ = @this?.Coding;
                bool? am_ = context.Operators.Not((bool?)(al_ is null));
                return am_;
            }

            IEnumerable<CodeableConcept> l_ = context.Operators.Where<CodeableConcept>(j_, k_);

            List<Coding> m_(CodeableConcept @this) {
                List<Coding> an_ = @this?.Coding;
                return an_;
            }

            IEnumerable<List<Coding>> n_ = context.Operators.Select<CodeableConcept, List<Coding>>(l_, m_);
            IEnumerable<Coding> o_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)n_);

            bool? p_(Coding ProductOrServiceCode) {
                CqlCode ao_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? ap_ = context.Operators.In<CqlCode>(ao_, ProductOrServiceValueSet);
                return ap_;
            }

            IEnumerable<Coding> q_ = context.Operators.Where<Coding>(o_, p_);
            bool? r_ = context.Operators.Exists<Coding>(q_);
            List<Claim.DiagnosisComponent> s_ = AllClaims?.Diagnosis;

            bool? t_(Claim.DiagnosisComponent @this) {
                DataType aq_ = @this?.Diagnosis;
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));
                return ar_;
            }

            IEnumerable<Claim.DiagnosisComponent> u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);

            object v_(Claim.DiagnosisComponent @this) {
                DataType as_ = @this?.Diagnosis;
                return as_;
            }

            IEnumerable<object> w_ = context.Operators.Select<Claim.DiagnosisComponent, object>(u_, v_);

            bool? x_(object @this) {
                object at_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? au_ = context.Operators.Not((bool?)(at_ is null));
                return au_;
            }

            IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);

            object z_(object @this) {
                object av_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                return av_;
            }

            IEnumerable<object> aa_ = context.Operators.Select<object, object>(y_, z_);
            IEnumerable<object> ab_ = context.Operators.FlattenLateBoundList(aa_);
            Coding ac_(object @object) => (Coding)@object;
            IEnumerable<Coding> ad_ = context.Operators.Select<object, Coding>(ab_, ac_);

            bool? ae_(Coding DiagnosisCode) {
                CqlCode aw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? ax_ = context.Operators.In<CqlCode>(aw_, DiagnosisValueSet);
                return ax_;
            }

            IEnumerable<Coding> af_ = context.Operators.Where<Coding>(ad_, ae_);
            bool? ag_ = context.Operators.Exists<Coding>(af_);
            bool? ah_ = context.Operators.Or(r_, ag_);
            return ah_;
        }

        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim ProcedureClaims) {
            List<Claim.ItemComponent> ay_ = ProcedureClaims?.Item;

            bool? az_(Claim.ItemComponent ResponseItem) {
                CodeableConcept bc_ = ResponseItem?.ProductOrService;
                List<Coding> bd_ = bc_?.Coding;

                bool? be_(Coding ProductOrServiceCode) {
                    CqlCode bh_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? bi_ = context.Operators.In<CqlCode>(bh_, ProductOrServiceValueSet);
                    return bi_;
                }

                IEnumerable<Coding> bf_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bd_, be_);
                bool? bg_ = context.Operators.Exists<Coding>(bf_);
                return bg_;
            }

            IEnumerable<Claim.ItemComponent> ba_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ay_, az_);
            bool? bb_ = context.Operators.Exists<Claim.ItemComponent>(ba_);
            if (bb_ ?? false)
            {
                Id bj_ = ProcedureClaims?.IdElement;
                List<Claim.ItemComponent> bk_ = ProcedureClaims?.Item;

                bool? bl_(Claim.ItemComponent ResponseItem) {
                    CodeableConcept bo_ = ResponseItem?.ProductOrService;
                    List<Coding> bp_ = bo_?.Coding;

                    bool? bq_(Coding ProductOrServiceCode) {
                        CqlCode bt_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                        bool? bu_ = context.Operators.In<CqlCode>(bt_, ProductOrServiceValueSet);
                        return bu_;
                    }

                    IEnumerable<Coding> br_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bp_, bq_);
                    bool? bs_ = context.Operators.Exists<Coding>(br_);
                    return bs_;
                }

                IEnumerable<Claim.ItemComponent> bm_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bk_, bl_);
                (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, bj_, bm_);
                return bn_;
            }
            else
            {
                Id bv_ = ProcedureClaims?.IdElement;
                List<Claim.ItemComponent> bw_ = ProcedureClaims?.Item;

                bool? bx_(Claim.ItemComponent ResponseItem) {
                    PositiveInt ca_ = ResponseItem?.SequenceElement;
                    Integer cb_ = context.Operators.Convert<Integer>(ca_);
                    int? cc_ = cb_?.Value;
                    bool? cd_ = context.Operators.Equal(cc_, 1);
                    return cd_;
                }

                IEnumerable<Claim.ItemComponent> by_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bw_, bx_);
                (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bz_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, bv_, by_);
                return bz_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse) {
            IEnumerable<ClaimResponse> g_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            IEnumerable<Claim> h_ = MedicalClaimAndResponse?.MedicalClaim;
            bool? i_ = context.Operators.And((bool?)(g_ is null), (bool?)(h_ is null));
            if (i_ ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse> j_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim> k_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? l_ = this.Get_Corresponding_Claim_for_Services_Only(context, j_, k_, ProductOrServiceValueSet);
                return l_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Get Corresponding Claim for Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
            c_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse) {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> i_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? j_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent> s_ = medClaim?.LineItems;

                bool? t_(Claim.ItemComponent medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> w_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? x_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent> aa_ = pClaim?.LineItems;

                        bool? ab_(ClaimResponse.ItemComponent pClaimLineItem) {
                            Id ae_;
                            Claim as_ = medClaim?.ClaimofInterest;
                            bool at_ = as_ is Resource;
                            if (at_)
                            {
                                Claim au_ = medClaim?.ClaimofInterest;
                                ae_ = (au_ as Resource).IdElement;
                            }
                            else
                            {
                                ae_ = default;
                            }
                            string af_ = FHIRHelpers_4_0_001.Instance.ToString(context, ae_);
                            ClaimResponse ag_ = pClaim?.Response;
                            ResourceReference ah_ = ag_?.Request;
                            FhirString ai_ = ah_?.ReferenceElement;
                            string aj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ai_);
                            string ak_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, aj_);
                            bool? al_ = context.Operators.Equal(af_, ak_);
                            PositiveInt am_ = medClaimLineItem?.SequenceElement;
                            Integer an_ = context.Operators.Convert<Integer>(am_);
                            PositiveInt ao_ = pClaimLineItem?.ItemSequenceElement;
                            Integer ap_ = context.Operators.Convert<Integer>(ao_);
                            bool? aq_ = context.Operators.Equal(an_, ap_);
                            bool? ar_ = context.Operators.And(al_, aq_);
                            return ar_;
                        }

                        IEnumerable<ClaimResponse.ItemComponent> ac_ = context.Operators.Where<ClaimResponse.ItemComponent>(aa_, ab_);
                        bool? ad_ = context.Operators.Exists<ClaimResponse.ItemComponent>(ac_);
                        return ad_;
                    }

                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> y_ = context.Operators.Where<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(w_, x_);
                    bool? z_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(y_);
                    return z_;
                }

                IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>(s_, t_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? v_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, u_);
                return v_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> k_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(k_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? m_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, l_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] n_ = [
                m_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? av_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ba_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? bb_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bh_ = @this?.ClaimItem;
                    bool? bi_ = context.Operators.Not((bool?)(bh_ is null));
                    return bi_;
                }

                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);

                IEnumerable<Claim.ItemComponent> bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bj_ = @this?.ClaimItem;
                    return bj_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent>> be_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
                IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
                bool? bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);
                if (bg_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bk_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bl_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? by_ = @this?.PaidClaim;
                        bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                        return bz_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bm_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);

                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ca_ = @this?.PaidClaim;
                        return ca_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bo_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bm_, bn_);

                    bool? bp_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cb_ = @this?.ClaimItem;
                        bool? cc_ = context.Operators.Not((bool?)(cb_ is null));
                        return cc_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bp_);

                    IEnumerable<Claim.ItemComponent> br_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cd_ = @this?.ClaimItem;
                        return cd_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bq_, br_);
                    IEnumerable<Claim.ItemComponent> bt_ = context.Operators.Flatten<Claim.ItemComponent>(bs_);

                    CqlInterval<CqlDateTime> bu_(Claim.ItemComponent PaidItem) {
                        DataType ce_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> cf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ce_);
                        return cf_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bv_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bt_, bu_);
                    IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bv_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bx_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bo_, bw_);
                    av_ = bx_;
                }
                else
                {
                    av_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] aw_ = [
                    av_,
                ];

                bool? ax_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) {
                    bool? cg_ = context.Operators.Not((bool?)(FinalList is null));
                    return cg_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ay_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)aw_, ax_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ay_);
                return az_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(q_);
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure Only")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {

        bool? a_(Claim AllClaims) {
            List<Claim.ItemComponent> f_ = AllClaims?.Item;

            bool? g_(Claim.ItemComponent @this) {
                CodeableConcept s_ = @this?.ProductOrService;
                bool? t_ = context.Operators.Not((bool?)(s_ is null));
                return t_;
            }

            IEnumerable<Claim.ItemComponent> h_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)f_, g_);

            CodeableConcept i_(Claim.ItemComponent @this) {
                CodeableConcept u_ = @this?.ProductOrService;
                return u_;
            }

            IEnumerable<CodeableConcept> j_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(h_, i_);

            bool? k_(CodeableConcept @this) {
                List<Coding> v_ = @this?.Coding;
                bool? w_ = context.Operators.Not((bool?)(v_ is null));
                return w_;
            }

            IEnumerable<CodeableConcept> l_ = context.Operators.Where<CodeableConcept>(j_, k_);

            List<Coding> m_(CodeableConcept @this) {
                List<Coding> x_ = @this?.Coding;
                return x_;
            }

            IEnumerable<List<Coding>> n_ = context.Operators.Select<CodeableConcept, List<Coding>>(l_, m_);
            IEnumerable<Coding> o_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)n_);

            bool? p_(Coding ProductOrServiceCode) {
                CqlCode y_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? z_ = context.Operators.In<CqlCode>(y_, ProductOrServiceValueSet);
                return z_;
            }

            IEnumerable<Coding> q_ = context.Operators.Where<Coding>(o_, p_);
            bool? r_ = context.Operators.Exists<Coding>(q_);
            return r_;
        }

        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim AllClaims) {
            Id aa_ = AllClaims?.IdElement;
            List<Claim.ItemComponent> ab_ = AllClaims?.Item;

            bool? ac_(Claim.ItemComponent ResponseItem) {
                CodeableConcept af_ = ResponseItem?.ProductOrService;
                List<Coding> ag_ = af_?.Coding;

                bool? ah_(Coding ProductOrServiceCode) {
                    CqlCode ak_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? al_ = context.Operators.In<CqlCode>(ak_, ProductOrServiceValueSet);
                    return al_;
                }

                IEnumerable<Coding> ai_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ag_, ah_);
                bool? aj_ = context.Operators.Exists<Coding>(ai_);
                return aj_;
            }

            IEnumerable<Claim.ItemComponent> ad_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ab_, ac_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ae_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, aa_, ad_);
            return ae_;
        }

        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse) {
            IEnumerable<ClaimResponse> g_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
            IEnumerable<Claim> h_ = PharmacyClaimAndResponse?.PharmacyClaim;
            bool? i_ = context.Operators.And((bool?)(g_ is null), (bool?)(h_ is null));
            if (i_ ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
            }
            else
            {
                IEnumerable<ClaimResponse> j_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                IEnumerable<Claim> k_ = PharmacyClaimAndResponse?.PharmacyClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? l_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, j_, k_, ProductOrServiceValueSet);
                return l_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> d_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)b_, c_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Get All Pharmacy Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> a_ = this.Pharmacy_Claims_Response(context, claimResponse);
        IEnumerable<Claim> b_ = this.Pharmacy_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? c_ = (CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV, a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Get Corresponding Claim for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> b_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? c_ = (CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[] d_ = [
            c_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse) {
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> i_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? j_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim) {
                IEnumerable<Claim.ItemComponent> s_ = medClaim?.LineItem;

                bool? t_(Claim.ItemComponent medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> w_ = ClaimAndResponse?.PaidPharmacyClaimResponse;

                    bool? x_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent> aa_ = pClaim?.LineItems;

                        bool? ab_(ClaimResponse.ItemComponent pClaimLineItem) {
                            Id ae_;
                            Claim as_ = medClaim?.Claim;
                            bool at_ = as_ is Resource;
                            if (at_)
                            {
                                Claim au_ = medClaim?.Claim;
                                ae_ = (au_ as Resource).IdElement;
                            }
                            else
                            {
                                ae_ = default;
                            }
                            string af_ = FHIRHelpers_4_0_001.Instance.ToString(context, ae_);
                            ClaimResponse ag_ = pClaim?.Response;
                            ResourceReference ah_ = ag_?.Request;
                            FhirString ai_ = ah_?.ReferenceElement;
                            string aj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ai_);
                            string ak_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, aj_);
                            bool? al_ = context.Operators.Equal(af_, ak_);
                            PositiveInt am_ = medClaimLineItem?.SequenceElement;
                            Integer an_ = context.Operators.Convert<Integer>(am_);
                            PositiveInt ao_ = pClaimLineItem?.ItemSequenceElement;
                            Integer ap_ = context.Operators.Convert<Integer>(ao_);
                            bool? aq_ = context.Operators.Equal(an_, ap_);
                            bool? ar_ = context.Operators.And(al_, aq_);
                            return ar_;
                        }

                        IEnumerable<ClaimResponse.ItemComponent> ac_ = context.Operators.Where<ClaimResponse.ItemComponent>(aa_, ab_);
                        bool? ad_ = context.Operators.Exists<ClaimResponse.ItemComponent>(ac_);
                        return ad_;
                    }

                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> y_ = context.Operators.Where<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(w_, x_);
                    bool? z_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(y_);
                    return z_;
                }

                IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>(s_, t_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? v_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, u_);
                return v_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> k_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(k_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? m_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, l_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] n_ = [
                m_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? o_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? av_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ba_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? bb_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bh_ = @this?.ClaimItem;
                    bool? bi_ = context.Operators.Not((bool?)(bh_ is null));
                    return bi_;
                }

                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ba_, bb_);

                IEnumerable<Claim.ItemComponent> bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bj_ = @this?.ClaimItem;
                    return bj_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent>> be_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bd_);
                IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Flatten<Claim.ItemComponent>(be_);
                bool? bg_ = context.Operators.Exists<Claim.ItemComponent>(bf_);
                if (bg_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bk_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bl_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? cg_ = @this?.PaidClaim;
                        bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
                        return ch_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bm_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bl_);

                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bn_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ci_ = @this?.PaidClaim;
                        return ci_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> bo_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(bm_, bn_);

                    bool? bp_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cj_ = @this?.ClaimItem;
                        bool? ck_ = context.Operators.Not((bool?)(cj_ is null));
                        return ck_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bp_);

                    IEnumerable<Claim.ItemComponent> br_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cl_ = @this?.ClaimItem;
                        return cl_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bq_, br_);
                    IEnumerable<Claim.ItemComponent> bt_ = context.Operators.Flatten<Claim.ItemComponent>(bs_);

                    CqlInterval<CqlDateTime> bu_(Claim.ItemComponent PaidItem) {
                        DataType cm_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> cn_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, cm_);
                        return cn_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bv_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bt_, bu_);
                    IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bv_);

                    bool? bx_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> co_ = @this?.ClaimItem;
                        bool? cp_ = context.Operators.Not((bool?)(co_ is null));
                        return cp_;
                    }

                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> by_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bk_, bx_);

                    IEnumerable<Claim.ItemComponent> bz_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> cq_ = @this?.ClaimItem;
                        return cq_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> ca_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(by_, bz_);
                    IEnumerable<Claim.ItemComponent> cb_ = context.Operators.Flatten<Claim.ItemComponent>(ca_);

                    CqlInterval<CqlDate> cc_(Claim.ItemComponent i) {
                        Quantity cr_ = i?.Quantity;
                        bool? cs_ = context.Operators.Not((bool?)(cr_ is null));
                        if (cs_ ?? false)
                        {
                            DataType ct_ = i?.Serviced;
                            CqlInterval<CqlDateTime> cu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ct_);
                            CqlDateTime cv_ = context.Operators.Start(cu_);
                            CqlDate cw_ = context.Operators.ConvertDateTimeToDate(cv_);
                            Quantity cx_ = i?.Quantity;
                            FhirDecimal cy_ = cx_?.ValueElement;
                            decimal? cz_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, cy_);
                            CqlDateTime da_ = context.Operators.Add(cv_, new CqlQuantity(cz_, "day"));
                            CqlQuantity db_ = context.Operators.Quantity(1m, "day");
                            CqlDateTime dc_ = context.Operators.Subtract(da_, db_);
                            CqlDate dd_ = context.Operators.ConvertDateTimeToDate(dc_);
                            CqlInterval<CqlDate> de_ = context.Operators.Interval(cw_, dd_, true, true);
                            return de_;
                        }
                        else
                        {
                            return null as CqlInterval<CqlDate>;
                        }
                    }

                    IEnumerable<CqlInterval<CqlDate>> cd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(cb_, cc_);
                    IEnumerable<CqlInterval<CqlDate>> ce_ = context.Operators.Distinct<CqlInterval<CqlDate>>(cd_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? cf_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, bo_, bw_, ce_);
                    av_ = cf_;
                }
                else
                {
                    av_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] aw_ = [
                    av_,
                ];

                bool? ax_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList) {
                    bool? df_ = context.Operators.Not((bool?)(FinalList is null));
                    return df_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ay_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)aw_, ax_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? az_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ay_);
                return az_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(p_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(q_);
            return r_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(f_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Get Claim With Corresponding Claim Response")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {

        (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? a_(Claim Claim) {

            bool? d_(ClaimResponse CR) {
                Id i_ = Claim?.IdElement;
                string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
                ResourceReference k_ = CR?.Request;
                FhirString l_ = k_?.ReferenceElement;
                string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
                string n_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, m_);
                bool? o_ = context.Operators.Equal(j_, n_);
                return o_;
            }

            IEnumerable<ClaimResponse> e_ = context.Operators.Where<ClaimResponse>(claimResponse, d_);

            bool? f_(Claim C) {
                Id p_ = Claim?.IdElement;
                string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);

                bool? r_(ClaimResponse CR) {
                    Id af_ = Claim?.IdElement;
                    string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_);
                    ResourceReference ah_ = CR?.Request;
                    FhirString ai_ = ah_?.ReferenceElement;
                    string aj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ai_);
                    string ak_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, aj_);
                    bool? al_ = context.Operators.Equal(ag_, ak_);
                    return al_;
                }

                IEnumerable<ClaimResponse> s_ = context.Operators.Where<ClaimResponse>(claimResponse, r_);

                bool? t_(ClaimResponse @this) {
                    ResourceReference am_ = @this?.Request;
                    bool? an_ = context.Operators.Not((bool?)(am_ is null));
                    return an_;
                }

                IEnumerable<ClaimResponse> u_ = context.Operators.Where<ClaimResponse>(s_, t_);

                ResourceReference v_(ClaimResponse @this) {
                    ResourceReference ao_ = @this?.Request;
                    return ao_;
                }

                IEnumerable<ResourceReference> w_ = context.Operators.Select<ClaimResponse, ResourceReference>(u_, v_);

                bool? x_(ResourceReference @this) {
                    FhirString ap_ = @this?.ReferenceElement;
                    bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
                    return aq_;
                }

                IEnumerable<ResourceReference> y_ = context.Operators.Where<ResourceReference>(w_, x_);

                FhirString z_(ResourceReference @this) {
                    FhirString ar_ = @this?.ReferenceElement;
                    return ar_;
                }

                IEnumerable<FhirString> aa_ = context.Operators.Select<ResourceReference, FhirString>(y_, z_);
                FhirString ab_ = context.Operators.SingletonFrom<FhirString>(aa_);
                string ac_ = FHIRHelpers_4_0_001.Instance.ToString(context, ab_);
                string ad_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ac_);
                bool? ae_ = context.Operators.Equal(q_, ad_);
                return ae_;
            }

            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(claim, f_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? h_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, e_, g_);
            return h_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> b_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, a_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> c_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(b_);
        return c_;
    }


    [CqlFunctionDefinition("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim> claim)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim)? b_ = (CqlTupleMetadata_ETQMCTGZaBMKcJbAjKZCAIRDW, a_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim)?[] c_ = [
            b_,
        ];

        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? d_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim)? ClaimWithInpatientStay) {
            IEnumerable<Claim> h_;
            if (ClaimWithInpatientStay?.MedicalClaim is null)
            {
                h_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> p_ = ClaimWithInpatientStay?.MedicalClaim;

                bool? q_(Claim c) {
                    List<Claim.ItemComponent> s_ = c?.Item;

                    bool? t_(Claim.ItemComponent i) {
                        CodeableConcept w_ = i?.Revenue;
                        CqlConcept x_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, w_);
                        IReadOnlyList<CqlCode> y_ = x_?.codes;

                        bool? z_(CqlCode rev) {
                            string ac_ = rev?.code;
                            CqlValueSet ad_ = this.Inpatient_Stay(context);
                            bool? ae_ = context.Operators.StringInValueSet(ac_, ad_);
                            return ae_;
                        }

                        IEnumerable<CqlCode> aa_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)y_, z_);
                        bool? ab_ = context.Operators.Exists<CqlCode>(aa_);
                        return ab_;
                    }

                    IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)s_, t_);
                    bool? v_ = context.Operators.Exists<Claim.ItemComponent>(u_);
                    return v_;
                }

                IEnumerable<Claim> r_ = context.Operators.Where<Claim>(p_, q_);
                h_ = r_;
            }
            IEnumerable<Claim> i_;
            if (ClaimWithInpatientStay?.MedicalClaim is null)
            {
                i_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> af_ = ClaimWithInpatientStay?.MedicalClaim;

                bool? ag_(Claim c) {
                    List<Claim.ItemComponent> ai_ = c?.Item;

                    bool? aj_(Claim.ItemComponent i) {
                        CodeableConcept as_ = i?.Revenue;
                        CqlConcept at_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, as_);
                        IReadOnlyList<CqlCode> au_ = at_?.codes;

                        bool? av_(CqlCode rev) {
                            string ay_ = rev?.code;
                            CqlValueSet az_ = this.Nonacute_Inpatient_Stay(context);
                            bool? ba_ = context.Operators.StringInValueSet(ay_, az_);
                            return ba_;
                        }

                        IEnumerable<CqlCode> aw_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)au_, av_);
                        bool? ax_ = context.Operators.Exists<CqlCode>(aw_);
                        return ax_;
                    }

                    IEnumerable<Claim.ItemComponent> ak_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ai_, aj_);
                    bool? al_ = context.Operators.Exists<Claim.ItemComponent>(ak_);
                    CodeableConcept am_ = c?.SubType;
                    List<Coding> an_ = am_?.Coding;

                    bool? ao_(Coding tob) {
                        Code bb_ = tob?.CodeElement;
                        string bc_ = bb_?.Value;
                        CqlValueSet bd_ = this.Nonacute_Inpatient_Stay(context);
                        bool? be_ = context.Operators.StringInValueSet(bc_, bd_);
                        return be_;
                    }

                    IEnumerable<Coding> ap_ = context.Operators.Where<Coding>((IEnumerable<Coding>)an_, ao_);
                    bool? aq_ = context.Operators.Exists<Coding>(ap_);
                    bool? ar_ = context.Operators.Or(al_, aq_);
                    return ar_;
                }

                IEnumerable<Claim> ah_ = context.Operators.Where<Claim>(af_, ag_);
                i_ = ah_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? j_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, h_, i_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] k_ = [
                j_,
            ];

            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? l_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition) {
                IEnumerable<Claim> bf_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> bg_ = LineItemDefinition?.NonacuteInpatientLineItems;

                bool? bh_(Claim nonAcuteInpatientStay) {
                    IEnumerable<Claim> bm_ = LineItemDefinition?.InpatientStayLineItems;

                    bool? bn_(Claim inpatientStay) {
                        Id bq_ = nonAcuteInpatientStay?.IdElement;
                        Id br_ = inpatientStay?.IdElement;
                        bool? bs_ = context.Operators.Equal(bq_, br_);
                        return bs_;
                    }

                    IEnumerable<Claim> bo_ = context.Operators.Where<Claim>(bm_, bn_);
                    bool? bp_ = context.Operators.Exists<Claim>(bo_);
                    return bp_;
                }

                IEnumerable<Claim> bi_ = context.Operators.Where<Claim>(bg_, bh_);

                bool? bj_(Claim inpatientStay) {
                    IEnumerable<Claim> bt_ = LineItemDefinition?.NonacuteInpatientLineItems;

                    bool? bu_(Claim nonAcuteInpatientStay) {
                        Id by_ = inpatientStay?.IdElement;
                        Id bz_ = nonAcuteInpatientStay?.IdElement;
                        bool? ca_ = context.Operators.Equal(by_, bz_);
                        return ca_;
                    }

                    IEnumerable<Claim> bv_ = context.Operators.Where<Claim>(bt_, bu_);
                    bool? bw_ = context.Operators.Exists<Claim>(bv_);
                    bool? bx_ = context.Operators.Not(bw_);
                    return bx_;
                }

                IEnumerable<Claim> bk_ = context.Operators.Where<Claim>(bf_, bj_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bl_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, bf_, bi_, bk_);
                return bl_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> m_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)k_, l_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> n_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(m_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(e_);
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get Prescriber NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {

        (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? a_(Claim C) {
            List<Claim.CareTeamComponent> j_ = C?.CareTeam;

            bool? k_(Claim.CareTeamComponent ct) {
                PositiveInt z_ = ct?.SequenceElement;
                Integer aa_ = context.Operators.Convert<Integer>(z_);
                int? ab_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, aa_);
                bool? ac_ = context.Operators.Equal(ab_, 1);
                return ac_;
            }

            IEnumerable<Claim.CareTeamComponent> l_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)j_, k_);

            bool? m_(Claim.CareTeamComponent @this) {
                ResourceReference ad_ = @this?.Provider;
                bool? ae_ = context.Operators.Not((bool?)(ad_ is null));
                return ae_;
            }

            IEnumerable<Claim.CareTeamComponent> n_ = context.Operators.Where<Claim.CareTeamComponent>(l_, m_);

            ResourceReference o_(Claim.CareTeamComponent @this) {
                ResourceReference af_ = @this?.Provider;
                return af_;
            }

            IEnumerable<ResourceReference> p_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(n_, o_);

            bool? q_(Claim.CareTeamComponent ct) {
                PositiveInt ag_ = ct?.SequenceElement;
                Integer ah_ = context.Operators.Convert<Integer>(ag_);
                int? ai_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ah_);
                bool? aj_ = context.Operators.Equal(ai_, 1);
                return aj_;
            }

            IEnumerable<Claim.CareTeamComponent> r_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)j_, q_);

            bool? s_(Claim.CareTeamComponent @this) {
                ResourceReference ak_ = @this?.Provider;
                bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                return al_;
            }

            IEnumerable<Claim.CareTeamComponent> t_ = context.Operators.Where<Claim.CareTeamComponent>(r_, s_);

            ResourceReference u_(Claim.CareTeamComponent @this) {
                ResourceReference am_ = @this?.Provider;
                return am_;
            }

            IEnumerable<ResourceReference> v_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(t_, u_);

            string w_(ResourceReference p) {
                FhirString an_ = p?.ReferenceElement;
                FhirString[] ao_ = [
                    an_,
                ];

                string ap_(FhirString r) {
                    string as_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string at_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, as_);
                    return at_;
                }

                IEnumerable<string> aq_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)ao_, ap_);
                string ar_ = context.Operators.SingletonFrom<string>(aq_);
                return ar_;
            }

            IEnumerable<string> x_ = context.Operators.Select<ResourceReference, string>(v_, w_);
            (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? y_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, p_, x_);
            return y_;
        }

        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> b_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, a_);
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> c_ = context.Operators.Distinct<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? d_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, int? IdentifierCount)? f_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ClaimProperties) {
            IEnumerable<Practitioner> au_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));

            bool? av_(Practitioner p) {
                Id bd_ = p?.IdElement;
                string be_ = FHIRHelpers_4_0_001.Instance.ToString(context, bd_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> bf_ = ClaimProperties?.CareTeams;

                bool? bg_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                    IEnumerable<string> bm_ = @this?.CareTeamsProviderID;
                    bool? bn_ = context.Operators.Not((bool?)(bm_ is null));
                    return bn_;
                }

                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> bh_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(bf_, bg_);

                IEnumerable<string> bi_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                    IEnumerable<string> bo_ = @this?.CareTeamsProviderID;
                    return bo_;
                }

                IEnumerable<IEnumerable<string>> bj_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(bh_, bi_);
                IEnumerable<string> bk_ = context.Operators.Flatten<string>(bj_);
                bool? bl_ = context.Operators.In<string>(be_, bk_);
                return bl_;
            }

            IEnumerable<Practitioner> aw_ = context.Operators.Where<Practitioner>(au_, av_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? ax_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, aw_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?[] ay_ = [
                ax_,
            ];

            (CqlTupleMetadata, int? IdentifierCount)? az_((CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? PractitionerMatch) {
                IEnumerable<Practitioner> bp_ = PractitionerMatch?.Practitioners;

                bool? bq_(Practitioner P) {
                    bool? ca_ = context.Operators.Not((bool?)(P is null));
                    return ca_;
                }

                IEnumerable<Practitioner> br_ = context.Operators.Where<Practitioner>(bp_, bq_);

                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bs_(Practitioner P) {
                    List<Identifier> cb_ = P?.Identifier;

                    bool? cc_(Identifier l) {
                        FhirUri cm_ = l?.SystemElement;
                        string cn_ = cm_?.Value;
                        bool? co_ = context.Operators.Equal(cn_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept cp_ = l?.Type;
                        CqlConcept cq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cp_);
                        CqlCode cr_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept cs_ = context.Operators.ConvertCodeToConcept(cr_);
                        bool? ct_ = context.Operators.Equivalent(cq_, cs_);
                        bool? cu_ = context.Operators.And(co_, ct_);
                        FhirString cv_ = l?.ValueElement;
                        string cw_ = cv_?.Value;
                        bool? cx_ = context.Operators.Not((bool?)(cw_ is null));
                        bool? cy_ = context.Operators.And(cu_, cx_);
                        return cy_;
                    }

                    IEnumerable<Identifier> cd_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cb_, cc_);

                    FhirString ce_(Identifier l) {
                        FhirString cz_ = l?.ValueElement;
                        return cz_;
                    }

                    IEnumerable<FhirString> cf_ = context.Operators.Select<Identifier, FhirString>(cd_, ce_);
                    IEnumerable<FhirString> cg_ = context.Operators.Distinct<FhirString>(cf_);

                    bool? ch_(Identifier l) {
                        FhirUri da_ = l?.SystemElement;
                        string db_ = da_?.Value;
                        bool? dc_ = context.Operators.Equal(db_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept dd_ = l?.Type;
                        CqlConcept de_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dd_);
                        CqlCode df_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept dg_ = context.Operators.ConvertCodeToConcept(df_);
                        bool? dh_ = context.Operators.Equivalent(de_, dg_);
                        bool? di_ = context.Operators.And(dc_, dh_);
                        FhirString dj_ = l?.ValueElement;
                        string dk_ = dj_?.Value;
                        bool? dl_ = context.Operators.And(di_, (bool?)(dk_ is null));
                        return dl_;
                    }

                    IEnumerable<Identifier> ci_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cb_, ch_);
                    Identifier cj_(Identifier l) => l;
                    IEnumerable<Identifier> ck_ = context.Operators.Select<Identifier, Identifier>(ci_, cj_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? cl_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, cg_, ck_);
                    return cl_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> bt_ = context.Operators.Select<Practitioner, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(br_, bs_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? bu_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, bt_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] bv_ = [
                    bu_,
                ];

                (CqlTupleMetadata, int? IdentifierCount)? bw_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers) {
                    int? dm_;
                    IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> do_ = ClaimProperties?.CareTeams;

                    bool? dp_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                        Claim du_ = @this?.SingleCareTeam;
                        bool? dv_ = context.Operators.Not((bool?)(du_ is null));
                        return dv_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> dq_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(do_, dp_);

                    Claim dr_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                        Claim dw_ = @this?.SingleCareTeam;
                        return dw_;
                    }

                    IEnumerable<Claim> ds_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(dq_, dr_);
                    bool? dt_ = context.Operators.Exists<Claim>(ds_);
                    if (dt_ ?? false)
                    {
                        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> dx_ = ClaimProperties?.CareTeams;

                        bool? dy_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                            Claim et_ = @this?.SingleCareTeam;
                            bool? eu_ = context.Operators.Not((bool?)(et_ is null));
                            return eu_;
                        }

                        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> dz_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(dx_, dy_);

                        Claim ea_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                            Claim ev_ = @this?.SingleCareTeam;
                            return ev_;
                        }

                        IEnumerable<Claim> eb_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(dz_, ea_);

                        bool? ec_(Claim X) {
                            List<Claim.CareTeamComponent> ew_ = X?.CareTeam;
                            return (bool?)(((IEnumerable<Claim.CareTeamComponent>)ew_) is null);
                        }

                        IEnumerable<Claim> ed_ = context.Operators.Where<Claim>(eb_, ec_);
                        int? ee_ = context.Operators.Count<Claim>(ed_);
                        IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> ef_ = GetIdentifiers?.IdentifierTuple;

                        IEnumerable<FhirString> eg_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<FhirString> ex_ = X?.AllIdentifiers;
                            return ex_;
                        }

                        IEnumerable<IEnumerable<FhirString>> eh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(ef_, eg_);
                        IEnumerable<FhirString> ei_ = context.Operators.Flatten<FhirString>(eh_);
                        FhirString ej_(FhirString X) => X;
                        IEnumerable<FhirString> ek_ = context.Operators.Select<FhirString, FhirString>(ei_, ej_);
                        IEnumerable<FhirString> el_ = context.Operators.Distinct<FhirString>(ek_);
                        int? em_ = context.Operators.Count<FhirString>(el_);
                        int? en_ = context.Operators.Add(ee_, em_);

                        IEnumerable<Identifier> eo_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<Identifier> ey_ = X?.NullIdentifiers;
                            return ey_;
                        }

                        IEnumerable<IEnumerable<Identifier>> ep_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(ef_, eo_);
                        IEnumerable<Identifier> eq_ = context.Operators.Flatten<Identifier>(ep_);
                        int? er_ = context.Operators.Count<Identifier>(eq_);
                        int? es_ = context.Operators.Add(en_, er_);
                        dm_ = es_;
                    }
                    else
                    {
                        dm_ = 0;
                    }
                    (CqlTupleMetadata, int? IdentifierCount)? dn_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, dm_);
                    return dn_;
                }

                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)bv_, bw_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> by_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(bx_);
                (CqlTupleMetadata, int? IdentifierCount)? bz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(by_);
                return bz_;
            }

            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> ba_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?>)ay_, az_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bb_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(ba_);
            (CqlTupleMetadata, int? IdentifierCount)? bc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bb_);
            return bc_;
        }

        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> g_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?>)e_, f_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(g_);
        (CqlTupleMetadata, int? IdentifierCount)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(h_);
        return i_;
    }


    [CqlFunctionDefinition("Get Pharmacy NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {

        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? a_(Claim C) {
            List<Claim.ItemComponent> j_ = C?.Item;

            bool? k_(Claim.ItemComponent i) {
                PositiveInt ab_ = i?.SequenceElement;
                Integer ac_ = context.Operators.Convert<Integer>(ab_);
                int? ad_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ac_);
                bool? ae_ = context.Operators.Equal(ad_, 1);
                return ae_;
            }

            IEnumerable<Claim.ItemComponent> l_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)j_, k_);

            bool? m_(Claim.ItemComponent @this) {
                DataType af_ = @this?.Location;
                bool? ag_ = context.Operators.Not((bool?)(af_ is null));
                return ag_;
            }

            IEnumerable<Claim.ItemComponent> n_ = context.Operators.Where<Claim.ItemComponent>(l_, m_);

            object o_(Claim.ItemComponent @this) {
                DataType ah_ = @this?.Location;
                return ah_;
            }

            IEnumerable<object> p_ = context.Operators.Select<Claim.ItemComponent, object>(n_, o_);
            ResourceReference q_(object l) => l as ResourceReference;
            IEnumerable<ResourceReference> r_ = context.Operators.Select<object, ResourceReference>(p_, q_);

            bool? s_(Claim.ItemComponent i) {
                PositiveInt ai_ = i?.SequenceElement;
                Integer aj_ = context.Operators.Convert<Integer>(ai_);
                int? ak_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, aj_);
                bool? al_ = context.Operators.Equal(ak_, 1);
                return al_;
            }

            IEnumerable<Claim.ItemComponent> t_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)j_, s_);

            bool? u_(Claim.ItemComponent @this) {
                DataType am_ = @this?.Location;
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                return an_;
            }

            IEnumerable<Claim.ItemComponent> v_ = context.Operators.Where<Claim.ItemComponent>(t_, u_);

            object w_(Claim.ItemComponent @this) {
                DataType ao_ = @this?.Location;
                return ao_;
            }

            IEnumerable<object> x_ = context.Operators.Select<Claim.ItemComponent, object>(v_, w_);

            string y_(object l) {
                FhirString ap_ = (l as ResourceReference)?.ReferenceElement;
                FhirString[] aq_ = [
                    ap_,
                ];

                string ar_(FhirString r) {
                    string au_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string av_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, au_);
                    return av_;
                }

                IEnumerable<string> as_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)aq_, ar_);
                string at_ = context.Operators.SingletonFrom<string>(as_);
                return at_;
            }

            IEnumerable<string> z_ = context.Operators.Select<object, string>(x_, y_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? aa_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent>)j_, r_, z_);
            return aa_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> b_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, a_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> c_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? d_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, int? IdentifierCount)? f_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? ClaimProperties) {
            IEnumerable<Location> aw_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));

            bool? ax_(Location l) {
                Id bf_ = l?.IdElement;
                string bg_ = FHIRHelpers_4_0_001.Instance.ToString(context, bf_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> bh_ = ClaimProperties?.ItemsLocationReferences;

                bool? bi_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                    IEnumerable<string> bo_ = @this?.ItemLocationID;
                    bool? bp_ = context.Operators.Not((bool?)(bo_ is null));
                    return bp_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> bj_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(bh_, bi_);

                IEnumerable<string> bk_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                    IEnumerable<string> bq_ = @this?.ItemLocationID;
                    return bq_;
                }

                IEnumerable<IEnumerable<string>> bl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(bj_, bk_);
                IEnumerable<string> bm_ = context.Operators.Flatten<string>(bl_);
                bool? bn_ = context.Operators.In<string>(bg_, bm_);
                return bn_;
            }

            IEnumerable<Location> ay_ = context.Operators.Where<Location>(aw_, ax_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? az_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, ay_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?[] ba_ = [
                az_,
            ];

            (CqlTupleMetadata, int? IdentifierCount)? bb_((CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? GetLocation) {
                IEnumerable<Location> br_ = GetLocation?.CorrespondingLocations;

                bool? bs_(Location C) {
                    bool? cc_ = context.Operators.Not((bool?)(C is null));
                    return cc_;
                }

                IEnumerable<Location> bt_ = context.Operators.Where<Location>(br_, bs_);

                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bu_(Location C) {
                    List<Identifier> cd_ = C?.Identifier;

                    bool? ce_(Identifier l) {
                        FhirUri co_ = l?.SystemElement;
                        string cp_ = co_?.Value;
                        bool? cq_ = context.Operators.Equal(cp_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept cr_ = l?.Type;
                        CqlConcept cs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cr_);
                        CqlCode ct_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept cu_ = context.Operators.ConvertCodeToConcept(ct_);
                        bool? cv_ = context.Operators.Equivalent(cs_, cu_);
                        bool? cw_ = context.Operators.And(cq_, cv_);
                        FhirString cx_ = l?.ValueElement;
                        string cy_ = cx_?.Value;
                        bool? cz_ = context.Operators.Not((bool?)(cy_ is null));
                        bool? da_ = context.Operators.And(cw_, cz_);
                        return da_;
                    }

                    IEnumerable<Identifier> cf_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cd_, ce_);

                    FhirString cg_(Identifier l) {
                        FhirString db_ = l?.ValueElement;
                        return db_;
                    }

                    IEnumerable<FhirString> ch_ = context.Operators.Select<Identifier, FhirString>(cf_, cg_);
                    IEnumerable<FhirString> ci_ = context.Operators.Distinct<FhirString>(ch_);

                    bool? cj_(Identifier l) {
                        FhirUri dc_ = l?.SystemElement;
                        string dd_ = dc_?.Value;
                        bool? de_ = context.Operators.Equal(dd_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept df_ = l?.Type;
                        CqlConcept dg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, df_);
                        CqlCode dh_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept di_ = context.Operators.ConvertCodeToConcept(dh_);
                        bool? dj_ = context.Operators.Equivalent(dg_, di_);
                        bool? dk_ = context.Operators.And(de_, dj_);
                        FhirString dl_ = l?.ValueElement;
                        string dm_ = dl_?.Value;
                        bool? dn_ = context.Operators.And(dk_, (bool?)(dm_ is null));
                        return dn_;
                    }

                    IEnumerable<Identifier> ck_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cd_, cj_);
                    Identifier cl_(Identifier l) => l;
                    IEnumerable<Identifier> cm_ = context.Operators.Select<Identifier, Identifier>(ck_, cl_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? cn_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, ci_, cm_);
                    return cn_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> bv_ = context.Operators.Select<Location, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bt_, bu_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? bw_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, bv_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] bx_ = [
                    bw_,
                ];

                (CqlTupleMetadata, int? IdentifierCount)? by_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers) {
                    int? do_;
                    IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> dq_ = ClaimProperties?.ItemsLocationReferences;

                    bool? dr_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                        IEnumerable<Claim.ItemComponent> dx_ = @this?.SingleItem;
                        bool? dy_ = context.Operators.Not((bool?)(dx_ is null));
                        return dy_;
                    }

                    IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ds_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(dq_, dr_);

                    IEnumerable<Claim.ItemComponent> dt_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                        IEnumerable<Claim.ItemComponent> dz_ = @this?.SingleItem;
                        return dz_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> du_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(ds_, dt_);
                    IEnumerable<Claim.ItemComponent> dv_ = context.Operators.Flatten<Claim.ItemComponent>(du_);
                    bool? dw_ = context.Operators.Exists<Claim.ItemComponent>(dv_);
                    if (dw_ ?? false)
                    {
                        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ea_ = ClaimProperties?.ItemsLocationReferences;

                        bool? eb_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                            IEnumerable<ResourceReference> ex_ = @this?.ItemLocation;
                            bool? ey_ = context.Operators.Not((bool?)(ex_ is null));
                            return ey_;
                        }

                        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ec_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(ea_, eb_);

                        IEnumerable<ResourceReference> ed_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                            IEnumerable<ResourceReference> ez_ = @this?.ItemLocation;
                            return ez_;
                        }

                        IEnumerable<IEnumerable<ResourceReference>> ee_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(ec_, ed_);
                        IEnumerable<ResourceReference> ef_ = context.Operators.Flatten<ResourceReference>(ee_);

                        bool? eg_(ResourceReference X) {
                            FhirString fa_ = X?.ReferenceElement;
                            string fb_ = fa_?.Value;
                            return (bool?)(fb_ is null);
                        }

                        IEnumerable<ResourceReference> eh_ = context.Operators.Where<ResourceReference>(ef_, eg_);
                        int? ei_ = context.Operators.Count<ResourceReference>(eh_);
                        IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> ej_ = GetIdentifiers?.IdentifierTuple;

                        IEnumerable<FhirString> ek_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<FhirString> fc_ = X?.AllIdentifiers;
                            return fc_;
                        }

                        IEnumerable<IEnumerable<FhirString>> el_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(ej_, ek_);
                        IEnumerable<FhirString> em_ = context.Operators.Flatten<FhirString>(el_);
                        FhirString en_(FhirString X) => X;
                        IEnumerable<FhirString> eo_ = context.Operators.Select<FhirString, FhirString>(em_, en_);
                        IEnumerable<FhirString> ep_ = context.Operators.Distinct<FhirString>(eo_);
                        int? eq_ = context.Operators.Count<FhirString>(ep_);
                        int? er_ = context.Operators.Add(ei_, eq_);

                        IEnumerable<Identifier> es_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<Identifier> fd_ = X?.NullIdentifiers;
                            return fd_;
                        }

                        IEnumerable<IEnumerable<Identifier>> et_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(ej_, es_);
                        IEnumerable<Identifier> eu_ = context.Operators.Flatten<Identifier>(et_);
                        int? ev_ = context.Operators.Count<Identifier>(eu_);
                        int? ew_ = context.Operators.Add(er_, ev_);
                        do_ = ew_;
                    }
                    else
                    {
                        do_ = 0;
                    }
                    (CqlTupleMetadata, int? IdentifierCount)? dp_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, do_);
                    return dp_;
                }

                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)bx_, by_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> ca_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(bz_);
                (CqlTupleMetadata, int? IdentifierCount)? cb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(ca_);
                return cb_;
            }

            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?>)ba_, bb_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bd_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(bc_);
            (CqlTupleMetadata, int? IdentifierCount)? be_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bd_);
            return be_;
        }

        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> g_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?>)e_, f_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(g_);
        (CqlTupleMetadata, int? IdentifierCount)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(h_);
        return i_;
    }


    #endregion Functions and Expressions

    #region Singleton Lifetime Members

    private NCQAClaims_1_0_0() {}

    public static NCQAClaims_1_0_0 Instance { get; } = new();

    #endregion

    #region ILibrary Implementation

    public string Name => "NCQAClaims";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQATerminology_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK = new(
       [typeof((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?), typeof(IEnumerable<Claim.ItemComponent>)],
       ["PaidClaim", "ClaimItem"]);

    private static CqlTupleMetadata CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO = new(
       [typeof(Claim), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<string>)],
       ["SingleCareTeam", "CareTeamsProvider", "CareTeamsProviderID"]);

    private static CqlTupleMetadata CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg = new(
       [typeof(IEnumerable<Claim>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
       ["Claim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG = new(
       [typeof(Claim)],
       ["ProcedureItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK = new(
       [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>)],
       ["PharmacyClaim", "MedicationsAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK = new(
       [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
       ["ClaimResponse", "OriginalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR = new(
       [typeof(IEnumerable<ClaimResponse>)],
       ["PaidResponse"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL = new(
       [typeof(IEnumerable<Claim>)],
       ["LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB = new(
       [typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>)],
       ["InpatientDischarge", "NonacuteInpatientDischarge", "AcuteInpatientDischarge"]);

    private static CqlTupleMetadata CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV = new(
       [typeof(IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>), typeof(IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>)],
       ["PaidMedicalClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW = new(
       [typeof(IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>), typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDate>>)],
       ["originalClaim", "ServicePeriod", "CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV = new(
       [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
       ["PharmacyClaimResponse", "PharmacyClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF = new(
       [typeof(IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>), typeof(IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>)],
       ["PaidPharmacyClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj = new(
       [typeof(IEnumerable<FhirString>), typeof(IEnumerable<Identifier>)],
       ["AllIdentifiers", "NullIdentifiers"]);

    private static CqlTupleMetadata CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON = new(
       [typeof(IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>)],
       ["AggregateClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE = new(
       [typeof(IEnumerable<ClaimResponse>), typeof(IEnumerable<Claim>)],
       ["MedicalClaimResponse", "MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX = new(
       [typeof(IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>)],
       ["ItemsLocationReferences"]);

    private static CqlTupleMetadata CqlTupleMetadata_ETQMCTGZaBMKcJbAjKZCAIRDW = new(
       [typeof(IEnumerable<Claim>)],
       ["MedicalClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE = new(
       [typeof(IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>)],
       ["IdentifierTuple"]);

    private static CqlTupleMetadata CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS = new(
       [typeof(int?)],
       ["IdentifierCount"]);

    private static CqlTupleMetadata CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf = new(
       [typeof(Claim), typeof(IEnumerable<Claim.ItemComponent>), typeof(IEnumerable<CqlInterval<CqlDateTime>>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
       ["Claim", "LineItem", "ServicePeriod", "CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR = new(
       [typeof(IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
       ["originalClaim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO = new(
       [typeof(ClaimResponse), typeof(string), typeof(IEnumerable<ClaimResponse.ItemComponent>)],
       ["Response", "ResponseID", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_FOGIeViDYfJOhRYAGIOCbEeNO = new(
       [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>)],
       ["MedicalClaim", "ProceduresAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO = new(
       [typeof(IEnumerable<Practitioner>)],
       ["Practitioners"]);

    private static CqlTupleMetadata CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE = new(
       [typeof(IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>)],
       ["CoveredDays"]);

    private static CqlTupleMetadata CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX = new(
       [typeof(Claim), typeof(Claim)],
       ["Claim", "ProcedureItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd = new(
       [typeof(Claim), typeof(IEnumerable<CqlInterval<CqlDateTime>>)],
       ["Claim", "ServicePeriod"]);

    private static CqlTupleMetadata CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV = new(
       [typeof(IEnumerable<Claim>)],
       ["DiagnosisItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB = new(
       [typeof(IEnumerable<Claim.ItemComponent>), typeof(IEnumerable<ResourceReference>), typeof(IEnumerable<string>)],
       ["SingleItem", "ItemLocation", "ItemLocationID"]);

    private static CqlTupleMetadata CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP = new(
       [typeof(IEnumerable<Claim>), typeof(IEnumerable<Claim>)],
       ["InpatientStayLineItems", "NonacuteInpatientLineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi = new(
       [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>), typeof(IEnumerable<string>)],
       ["MedicalClaim", "ProceduresAsStrings", "POSAsString"]);

    private static CqlTupleMetadata CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf = new(
       [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>)],
       ["MedicalClaim", "DiagnosesAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb = new(
       [typeof(IEnumerable<Claim>), typeof(IEnumerable<string>), typeof(IEnumerable<string>)],
       ["MedicalClaim", "DiagnosesAsStrings", "ProceduresAsStrings"]);

    private static CqlTupleMetadata CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi = new(
       [typeof(Claim), typeof(Id), typeof(IEnumerable<Claim.ItemComponent>)],
       ["ClaimofInterest", "ClaimID", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC = new(
       [typeof(IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>)],
       ["AggregateClaim"]);

    private static CqlTupleMetadata CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf = new(
       [typeof(IEnumerable<Location>)],
       ["CorrespondingLocations"]);

    private static CqlTupleMetadata CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ = new(
       [typeof((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?), typeof(IEnumerable<Claim.ItemComponent>)],
       ["PaidClaim", "ClaimItem"]);

    private static CqlTupleMetadata CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN = new(
       [typeof(CqlInterval<CqlDateTime>)],
       ["DaysSupplyInterval"]);

    private static CqlTupleMetadata CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH = new(
       [typeof(IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>)],
       ["CareTeams"]);

    private static CqlTupleMetadata CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP = new(
       [typeof(Claim), typeof(IEnumerable<Claim.ItemComponent>)],
       ["Claim", "LineItems"]);

    private static CqlTupleMetadata CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe = new(
       [typeof(IEnumerable<Claim.ItemComponent>), typeof(Claim)],
       ["Procedure", "LineItems"]);

    #endregion CqlTupleMetadata Properties

}
