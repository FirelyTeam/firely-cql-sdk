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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "2.0.10.0")]
[CqlLibrary("NCQAClaims", "1.0.0")]
public partial class NCQAClaims_1_0_0 : ILibrary, ISingleton<NCQAClaims_1_0_0>
{
    private NCQAClaims_1_0_0() {}

    public static NCQAClaims_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQAClaims";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance, NCQAFHIRBase_1_0_0.Instance, NCQATerminology_1_0_0.Instance];

    #endregion ILibrary Implementation

    #region Definition Methods

    [CqlDeclaration("Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395")]
    public CqlValueSet Inpatient_Stay(CqlContext context) =>
        new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", default);


    [CqlDeclaration("Nonacute Inpatient Stay")]
    [CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398")]
    public CqlValueSet Nonacute_Inpatient_Stay(CqlContext context) =>
        new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", default);


    public IEnumerable<Claim> Professional_or_Institutional_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? a_(Claim MedicalClaim)
        {
            CodeableConcept c_ = MedicalClaim?.Type;
            CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            CqlCode[] e_ = d_?.codes;
            CqlCode f_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
            CqlConcept i_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            CqlCode[] j_ = i_?.codes;
            CqlCode k_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? l_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)j_, k_);
            bool? m_ = context.Operators.Or(g_, l_);

            return m_;
        };
        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

        return b_;
    }


    public IEnumerable<Claim> Pharmacy_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? a_(Claim PharmacyClaim)
        {
            CodeableConcept c_ = PharmacyClaim?.Type;
            CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            CqlCode[] e_ = d_?.codes;
            CqlCode f_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

            return g_;
        };
        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);

        return b_;
    }


    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? a_(ClaimResponse MedicalResponse)
        {
            CodeableConcept c_ = MedicalResponse?.Type;
            CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            CqlCode[] e_ = d_?.codes;
            CqlCode f_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
            CqlConcept i_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            CqlCode[] j_ = i_?.codes;
            CqlCode k_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? l_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)j_, k_);
            bool? m_ = context.Operators.Or(g_, l_);

            return m_;
        };
        IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

        return b_;
    }


    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? a_(ClaimResponse PharmacyResponse)
        {
            CodeableConcept c_ = PharmacyResponse?.Type;
            CqlConcept d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            CqlCode[] e_ = d_?.codes;
            CqlCode f_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

            return g_;
        };
        IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);

        return b_;
    }


    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);
        string b_(CqlCode p)
        {
            string n_ = p?.code;

            return n_;
        };
        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        string e_(CqlCode pos)
        {
            string o_ = pos?.code;

            return o_;
        };
        IEnumerable<string> f_ = context.Operators.Select<CqlCode, string>(posCodes, e_);
        IEnumerable<string> g_ = context.Operators.Distinct<string>(f_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? h_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, a_, d_, g_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] i_ = [
            h_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode)
        {
            IEnumerable<Claim> p_ = ClaimWithPosCode?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? q_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> v_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> ac_ = ClaimofInterest?.Item;
                        bool? ad_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept af_ = ItemOnLine?.ProductOrService;
                            CqlConcept ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, af_);
                            CqlCode[] ah_ = ag_?.codes;
                            bool? ai_(CqlCode LineCode)
                            {
                                string as_ = LineCode?.code;
                                IEnumerable<string> at_ = ClaimWithPosCode?.ProceduresAsStrings;
                                bool? au_ = context.Operators.In<string>(as_, at_);

                                return au_;
                            };
                            IEnumerable<CqlCode> aj_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ah_, ai_);
                            bool? ak_ = context.Operators.Exists<CqlCode>(aj_);
                            DataType al_ = ItemOnLine?.Location;
                            CqlConcept am_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, al_ as CodeableConcept);
                            CqlCode[] an_ = am_?.codes;
                            bool? ao_(CqlCode PosCode)
                            {
                                string av_ = PosCode?.code;
                                IEnumerable<string> aw_ = ClaimWithPosCode?.POSAsString;
                                bool? ax_ = context.Operators.In<string>(av_, aw_);

                                return ax_;
                            };
                            IEnumerable<CqlCode> ap_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)an_, ao_);
                            bool? aq_ = context.Operators.Exists<CqlCode>(ap_);
                            bool? ar_ = context.Operators.And(ak_, aq_);

                            return ar_;
                        };
                        IEnumerable<Claim.ItemComponent> ae_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ac_, ad_);

                        return ae_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? w_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, v_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] x_ = [
                    w_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? y_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ay_()
                    {
                        bool az_()
                        {
                            IEnumerable<Claim.ItemComponent> ba_ = LineItemDefinition?.LineItems;
                            bool? bb_ = context.Operators.Exists<Claim.ItemComponent>(ba_);

                            return bb_ ?? false;
                        };
                        if (az_())
                        {
                            Claim bc_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> bd_ = LineItemDefinition?.LineItems;
                            bool? be_(Claim.ItemComponent @this)
                            {
                                DataType bm_ = @this?.Serviced;
                                bool? bn_ = context.Operators.Not((bool?)(bm_ is null));

                                return bn_;
                            };
                            IEnumerable<Claim.ItemComponent> bf_ = context.Operators.Where<Claim.ItemComponent>(bd_, be_);
                            object bg_(Claim.ItemComponent @this)
                            {
                                DataType bo_ = @this?.Serviced;

                                return bo_;
                            };
                            IEnumerable<object> bh_ = context.Operators.Select<Claim.ItemComponent, object>(bf_, bg_);
                            CqlInterval<CqlDateTime> bi_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> bp_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return bp_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> bj_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bh_, bi_);
                            IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bj_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bl_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, bc_, bk_);

                            return bl_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return ay_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> z_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)x_, y_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> aa_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(z_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ab_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(aa_);

                return ab_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> r_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_, q_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> s_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(r_);
            bool? t_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? bq_ = context.Operators.Not((bool?)(FinalList is null));

                return bq_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> u_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(s_, t_);

            return u_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)i_, j_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> l_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(k_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(l_);

        return m_;
    }


    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);
        string b_(CqlCode p)
        {
            string k_ = p?.code;

            return k_;
        };
        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? e_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, a_, d_, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] f_ = [
            e_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithProcedure)
        {
            IEnumerable<Claim> l_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> r_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> y_ = ClaimofInterest?.Item;
                        bool? z_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept ab_ = ItemOnLine?.ProductOrService;
                            CqlConcept ac_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ab_);
                            CqlCode[] ad_ = ac_?.codes;
                            bool? ae_(CqlCode LineCode)
                            {
                                string ax_ = LineCode?.code;
                                IEnumerable<string> ay_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? az_ = context.Operators.In<string>(ax_, ay_);

                                return az_;
                            };
                            IEnumerable<CqlCode> af_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ad_, ae_);
                            bool? ag_ = context.Operators.Exists<CqlCode>(af_);
                            List<Claim.ProcedureComponent> ah_ = ClaimofInterest?.Procedure;
                            bool? ai_(Claim.ProcedureComponent @this)
                            {
                                DataType ba_ = @this?.Procedure;
                                bool? bb_ = context.Operators.Not((bool?)(ba_ is null));

                                return bb_;
                            };
                            IEnumerable<Claim.ProcedureComponent> aj_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ah_, ai_);
                            object ak_(Claim.ProcedureComponent @this)
                            {
                                DataType bc_ = @this?.Procedure;

                                return bc_;
                            };
                            IEnumerable<object> al_ = context.Operators.Select<Claim.ProcedureComponent, object>(aj_, ak_);
                            bool? am_(object @this)
                            {
                                object bd_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? be_ = context.Operators.Not((bool?)(bd_ is null));

                                return be_;
                            };
                            IEnumerable<object> an_ = context.Operators.Where<object>(al_, am_);
                            object ao_(object @this)
                            {
                                object bf_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return bf_;
                            };
                            IEnumerable<object> ap_ = context.Operators.Select<object, object>(an_, ao_);
                            IEnumerable<object> aq_ = context.Operators.FlattenLateBoundList(ap_);
                            Coding ar_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> as_ = context.Operators.Select<object, Coding>(aq_, ar_);
                            bool? at_(Coding HeaderCode)
                            {
                                Code bg_ = HeaderCode?.CodeElement;
                                string bh_ = bg_?.Value;
                                IEnumerable<string> bi_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? bj_ = context.Operators.In<string>(bh_, bi_);

                                return bj_;
                            };
                            IEnumerable<Coding> au_ = context.Operators.Where<Coding>(as_, at_);
                            bool? av_ = context.Operators.Exists<Coding>(au_);
                            bool? aw_ = context.Operators.Or(ag_, av_);

                            return aw_;
                        };
                        IEnumerable<Claim.ItemComponent> aa_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)y_, z_);

                        return aa_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? s_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, r_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] t_ = [
                    s_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bk_()
                    {
                        bool bl_()
                        {
                            IEnumerable<Claim.ItemComponent> bm_ = LineItemDefinition?.LineItems;
                            bool? bn_ = context.Operators.Exists<Claim.ItemComponent>(bm_);

                            return bn_ ?? false;
                        };
                        if (bl_())
                        {
                            Claim bo_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> bp_ = LineItemDefinition?.LineItems;
                            bool? bq_(Claim.ItemComponent @this)
                            {
                                DataType by_ = @this?.Serviced;
                                bool? bz_ = context.Operators.Not((bool?)(by_ is null));

                                return bz_;
                            };
                            IEnumerable<Claim.ItemComponent> br_ = context.Operators.Where<Claim.ItemComponent>(bp_, bq_);
                            object bs_(Claim.ItemComponent @this)
                            {
                                DataType ca_ = @this?.Serviced;

                                return ca_;
                            };
                            IEnumerable<object> bt_ = context.Operators.Select<Claim.ItemComponent, object>(br_, bs_);
                            CqlInterval<CqlDateTime> bu_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> cb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return cb_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> bv_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bt_, bu_);
                            IEnumerable<CqlInterval<CqlDateTime>> bw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bv_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bx_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, bo_, bw_);

                            return bx_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return bk_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> v_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)t_, u_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> w_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(v_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? x_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(w_);

                return x_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(l_, m_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);
            bool? p_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? cc_ = context.Operators.Not((bool?)(FinalList is null));

                return cc_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(o_, p_);

            return q_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> h_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)f_, g_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(h_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);

        return j_;
    }


    public (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);
        string b_(CqlCode d)
        {
            string k_ = d?.code;

            return k_;
        };
        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? e_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, a_, d_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] f_ = [
            e_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> l_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> s_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? t_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> v_ = DiagnosisLine?.Diagnosis;
                        bool? w_(Claim.DiagnosisComponent @this)
                        {
                            DataType ak_ = @this?.Diagnosis;
                            bool? al_ = context.Operators.Not((bool?)(ak_ is null));

                            return al_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> x_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)v_, w_);
                        object y_(Claim.DiagnosisComponent @this)
                        {
                            DataType am_ = @this?.Diagnosis;

                            return am_;
                        };
                        IEnumerable<object> z_ = context.Operators.Select<Claim.DiagnosisComponent, object>(x_, y_);
                        bool? aa_(object @this)
                        {
                            object an_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? ao_ = context.Operators.Not((bool?)(an_ is null));

                            return ao_;
                        };
                        IEnumerable<object> ab_ = context.Operators.Where<object>(z_, aa_);
                        object ac_(object @this)
                        {
                            object ap_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return ap_;
                        };
                        IEnumerable<object> ad_ = context.Operators.Select<object, object>(ab_, ac_);
                        IEnumerable<object> ae_ = context.Operators.FlattenLateBoundList(ad_);
                        Coding af_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> ag_ = context.Operators.Select<object, Coding>(ae_, af_);
                        bool? ah_(Coding HeaderCode)
                        {
                            Code aq_ = HeaderCode?.CodeElement;
                            string ar_ = aq_?.Value;
                            IEnumerable<string> as_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? at_ = context.Operators.In<string>(ar_, as_);

                            return at_;
                        };
                        IEnumerable<Coding> ai_ = context.Operators.Where<Coding>(ag_, ah_);
                        bool? aj_ = context.Operators.Exists<Coding>(ai_);

                        return aj_;
                    };
                    IEnumerable<Claim> u_ = context.Operators.Where<Claim>(s_, t_);

                    return u_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? m_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, l_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] n_ = [
                m_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? HeaderDefinition)
            {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_()
                {
                    bool az_()
                    {
                        IEnumerable<Claim> ba_ = HeaderDefinition?.DiagnosisItems;
                        bool? bb_ = context.Operators.Exists<Claim>(ba_);

                        return bb_ ?? false;
                    };
                    if (az_())
                    {
                        IEnumerable<Claim> bc_ = HeaderDefinition?.DiagnosisItems;
                        bool? be_(Claim @this)
                        {
                            List<Claim.ItemComponent> bn_ = @this?.Item;
                            bool? bo_ = context.Operators.Not((bool?)(bn_ is null));

                            return bo_;
                        };
                        IEnumerable<Claim> bf_ = context.Operators.Where<Claim>(bc_, be_);
                        List<Claim.ItemComponent> bg_(Claim @this)
                        {
                            List<Claim.ItemComponent> bp_ = @this?.Item;

                            return bp_;
                        };
                        IEnumerable<List<Claim.ItemComponent>> bh_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(bf_, bg_);
                        IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)bh_);
                        CqlInterval<CqlDateTime> bj_(Claim.ItemComponent NormalDate)
                        {
                            DataType bq_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> br_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bq_);

                            return br_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bi_, bj_);
                        IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bk_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bm_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, bc_, bl_);

                        return bm_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] av_ = [
                    au_(),
                ];
                bool? aw_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? bs_ = context.Operators.Not((bool?)(FinalList is null));

                    return bs_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ax_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)av_, aw_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ay_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ax_);

                return ay_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_);
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(q_);

            return r_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)f_, g_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> i_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(h_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? j_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(i_);

        return j_;
    }


    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        IEnumerable<Claim> a_ = this.Pharmacy_Claims(context, claim);
        string b_(CqlCode p)
        {
            string j_ = p?.code;

            return j_;
        };
        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(MedicationCodes, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? e_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, a_, d_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] f_ = [
            e_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> g_((CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication)
        {
            IEnumerable<Claim> k_ = ClaimWithMedication?.PharmacyClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? l_(Claim Pharmacy)
            {
                List<Claim.ItemComponent> p_ = Pharmacy?.Item;
                bool? q_(Claim.ItemComponent ItemOnLine)
                {
                    CodeableConcept x_ = ItemOnLine?.ProductOrService;
                    CqlConcept y_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, x_);
                    CqlCode[] z_ = y_?.codes;
                    bool? aa_(CqlCode LineCode)
                    {
                        string ad_ = LineCode?.code;
                        IEnumerable<string> ae_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? af_ = context.Operators.In<string>(ad_, ae_);

                        return af_;
                    };
                    IEnumerable<CqlCode> ab_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)z_, aa_);
                    bool? ac_ = context.Operators.Exists<CqlCode>(ab_);

                    return ac_;
                };
                IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)p_, q_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? s_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, r_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] t_ = [
                    s_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? u_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    Claim ag_ = LineItemDefinition?.Claim;
                    Claim[] ah_ = [
                        ag_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ai_(Claim ClaimLines)
                    {
                        List<Claim.ItemComponent> al_ = ClaimLines?.Item;
                        bool? am_(Claim.ItemComponent i)
                        {
                            CodeableConcept av_ = i?.ProductOrService;
                            CqlConcept aw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, av_);
                            CqlCode[] ax_ = aw_?.codes;
                            bool? ay_(CqlCode LineCode)
                            {
                                string bb_ = LineCode?.code;
                                IEnumerable<string> bc_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? bd_ = context.Operators.In<string>(bb_, bc_);

                                return bd_;
                            };
                            IEnumerable<CqlCode> az_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ax_, ay_);
                            bool? ba_ = context.Operators.Exists<CqlCode>(az_);

                            return ba_;
                        };
                        IEnumerable<Claim.ItemComponent> an_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)al_, am_);
                        (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? ao_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDateTime> be_()
                            {
                                bool bg_()
                                {
                                    Quantity bh_ = i?.Quantity;
                                    bool? bi_ = context.Operators.Not((bool?)(bh_ is null));

                                    return bi_ ?? false;
                                };
                                if (bg_())
                                {
                                    CqlInterval<CqlDateTime> bj_()
                                    {
                                        bool bk_()
                                        {
                                            DataType bl_ = i?.Serviced;
                                            bool bm_ = bl_ is Period;

                                            return bm_;
                                        };
                                        if (bk_())
                                        {
                                            DataType bn_ = i?.Serviced;
                                            CqlInterval<CqlDateTime> bo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bn_);
                                            CqlDateTime bp_ = context.Operators.Start(bo_);
                                            CqlInterval<CqlDateTime> br_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bn_);
                                            CqlDateTime bs_ = context.Operators.Start(br_);
                                            Quantity bt_ = i?.Quantity;
                                            FhirDecimal bu_ = bt_?.ValueElement;
                                            decimal? bv_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bu_);
                                            CqlDateTime bw_ = context.Operators.Add(bs_, new CqlQuantity(bv_, "day"));
                                            CqlQuantity bx_ = context.Operators.Quantity(1m, "day");
                                            CqlDateTime by_ = context.Operators.Subtract(bw_, bx_);
                                            CqlInterval<CqlDateTime> bz_ = context.Operators.Interval(bp_, by_, true, true);

                                            return bz_;
                                        }
                                        else
                                        {
                                            DataType ca_ = i?.Serviced;
                                            CqlDate cb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_ as Date);
                                            CqlDate cd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_ as Date);
                                            Quantity ce_ = i?.Quantity;
                                            FhirDecimal cf_ = ce_?.ValueElement;
                                            decimal? cg_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, cf_);
                                            CqlDate ch_ = context.Operators.Add(cd_, new CqlQuantity(cg_, "day"));
                                            CqlQuantity ci_ = context.Operators.Quantity(1m, "day");
                                            CqlDate cj_ = context.Operators.Subtract(ch_, ci_);
                                            CqlInterval<CqlDate> ck_ = context.Operators.Interval(cb_, cj_, true, true);
                                            CqlDate cl_ = ck_?.low;
                                            CqlDateTime cm_ = context.Operators.ConvertDateToDateTime(cl_);
                                            CqlDate co_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_ as Date);
                                            CqlDate cq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_ as Date);
                                            FhirDecimal cs_ = ce_?.ValueElement;
                                            decimal? ct_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, cs_);
                                            CqlDate cu_ = context.Operators.Add(cq_, new CqlQuantity(ct_, "day"));
                                            CqlDate cw_ = context.Operators.Subtract(cu_, ci_);
                                            CqlInterval<CqlDate> cx_ = context.Operators.Interval(co_, cw_, true, true);
                                            CqlDate cy_ = cx_?.high;
                                            CqlDateTime cz_ = context.Operators.ConvertDateToDateTime(cy_);
                                            CqlDate db_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_ as Date);
                                            CqlDate dd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_ as Date);
                                            FhirDecimal df_ = ce_?.ValueElement;
                                            decimal? dg_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, df_);
                                            CqlDate dh_ = context.Operators.Add(dd_, new CqlQuantity(dg_, "day"));
                                            CqlDate dj_ = context.Operators.Subtract(dh_, ci_);
                                            CqlInterval<CqlDate> dk_ = context.Operators.Interval(db_, dj_, true, true);
                                            bool? dl_ = dk_?.lowClosed;
                                            CqlDate dn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_ as Date);
                                            CqlDate dp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ca_ as Date);
                                            FhirDecimal dr_ = ce_?.ValueElement;
                                            decimal? ds_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, dr_);
                                            CqlDate dt_ = context.Operators.Add(dp_, new CqlQuantity(ds_, "day"));
                                            CqlDate dv_ = context.Operators.Subtract(dt_, ci_);
                                            CqlInterval<CqlDate> dw_ = context.Operators.Interval(dn_, dv_, true, true);
                                            bool? dx_ = dw_?.highClosed;
                                            CqlInterval<CqlDateTime> dy_ = context.Operators.Interval(cm_, cz_, dl_, dx_);

                                            return dy_;
                                        }
                                    };

                                    return bj_();
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDateTime>;
                                }
                            };
                            (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? bf_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, be_());

                            return bf_;
                        };
                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> ap_ = context.Operators.Select<Claim.ItemComponent, (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>(an_, ao_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? aq_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, ap_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?[] ar_ = [
                            aq_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? as_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? ItemCalculation)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? dz_()
                            {
                                bool ea_()
                                {
                                    IEnumerable<Claim.ItemComponent> eb_ = LineItemDefinition?.LineItems;
                                    bool? ec_ = context.Operators.Exists<Claim.ItemComponent>(eb_);

                                    return ec_ ?? false;
                                };
                                if (ea_())
                                {
                                    Claim ed_ = LineItemDefinition?.Claim;
                                    IEnumerable<Claim.ItemComponent> ee_ = LineItemDefinition?.LineItems;
                                    bool? eg_(Claim.ItemComponent @this)
                                    {
                                        DataType er_ = @this?.Serviced;
                                        bool? es_ = context.Operators.Not((bool?)(er_ is null));

                                        return es_;
                                    };
                                    IEnumerable<Claim.ItemComponent> eh_ = context.Operators.Where<Claim.ItemComponent>(ee_, eg_);
                                    object ei_(Claim.ItemComponent @this)
                                    {
                                        DataType et_ = @this?.Serviced;

                                        return et_;
                                    };
                                    IEnumerable<object> ej_ = context.Operators.Select<Claim.ItemComponent, object>(eh_, ei_);
                                    CqlInterval<CqlDateTime> ek_(object NormalDate)
                                    {
                                        CqlInterval<CqlDateTime> eu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                        return eu_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> el_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ej_, ek_);
                                    IEnumerable<CqlInterval<CqlDateTime>> em_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(el_);
                                    IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> en_ = ItemCalculation?.CoveredDays;
                                    CqlInterval<CqlDateTime> eo_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d)
                                    {
                                        CqlInterval<CqlDateTime> ev_ = d?.DaysSupplyInterval;

                                        return ev_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> ep_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(en_, eo_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? eq_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, ed_, ee_, em_, ep_);

                                    return eq_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
                                }
                            };

                            return dz_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> at_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?>)ar_, as_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? au_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(at_);

                        return au_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> aj_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)ah_, ai_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ak_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(aj_);

                    return ak_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> v_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)t_, u_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? w_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(v_);

                return w_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> m_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(k_, l_);
            bool? n_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList)
            {
                bool? ew_ = context.Operators.Not((bool?)(FinalList is null));

                return ew_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> o_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(m_, n_);

            return o_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> h_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)f_, g_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> i_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(h_);

        return i_;
    }


    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);
        string b_(CqlCode d)
        {
            string n_ = d?.code;

            return n_;
        };
        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        string e_(CqlCode p)
        {
            string o_ = p?.code;

            return o_;
        };
        IEnumerable<string> f_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, e_);
        IEnumerable<string> g_ = context.Operators.Distinct<string>(f_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? h_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, a_, d_, g_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] i_ = [
            h_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> p_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> w_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? x_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> z_ = DiagnosisLine?.Diagnosis;
                        bool? aa_(Claim.DiagnosisComponent @this)
                        {
                            DataType ao_ = @this?.Diagnosis;
                            bool? ap_ = context.Operators.Not((bool?)(ao_ is null));

                            return ap_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> ab_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)z_, aa_);
                        object ac_(Claim.DiagnosisComponent @this)
                        {
                            DataType aq_ = @this?.Diagnosis;

                            return aq_;
                        };
                        IEnumerable<object> ad_ = context.Operators.Select<Claim.DiagnosisComponent, object>(ab_, ac_);
                        bool? ae_(object @this)
                        {
                            object ar_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? as_ = context.Operators.Not((bool?)(ar_ is null));

                            return as_;
                        };
                        IEnumerable<object> af_ = context.Operators.Where<object>(ad_, ae_);
                        object ag_(object @this)
                        {
                            object at_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return at_;
                        };
                        IEnumerable<object> ah_ = context.Operators.Select<object, object>(af_, ag_);
                        IEnumerable<object> ai_ = context.Operators.FlattenLateBoundList(ah_);
                        Coding aj_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> ak_ = context.Operators.Select<object, Coding>(ai_, aj_);
                        bool? al_(Coding HeaderCode)
                        {
                            Code au_ = HeaderCode?.CodeElement;
                            string av_ = au_?.Value;
                            IEnumerable<string> aw_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? ax_ = context.Operators.In<string>(av_, aw_);

                            return ax_;
                        };
                        IEnumerable<Coding> am_ = context.Operators.Where<Coding>(ak_, al_);
                        bool? an_ = context.Operators.Exists<Coding>(am_);

                        return an_;
                    };
                    IEnumerable<Claim> y_ = context.Operators.Where<Claim>(w_, x_);

                    return y_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? q_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, p_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] r_ = [
                q_,
            ];
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> s_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ClaimWithProcedure)
            {
                IEnumerable<Claim> ay_ = ClaimWithProcedure?.DiagnosisItems;
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_(Claim ClaimofInterest)
                {
                    Claim be_()
                    {
                        if (ClaimofInterest is null)
                        {
                            return default;
                        }
                        else
                        {
                            Claim[] bl_ = [
                                ClaimofInterest,
                            ];
                            bool? bm_(Claim ItemOnLine)
                            {
                                List<Claim.ProcedureComponent> bp_ = ItemOnLine?.Procedure;
                                bool? bq_(Claim.ProcedureComponent @this)
                                {
                                    DataType cs_ = @this?.Procedure;
                                    bool? ct_ = context.Operators.Not((bool?)(cs_ is null));

                                    return ct_;
                                };
                                IEnumerable<Claim.ProcedureComponent> br_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)bp_, bq_);
                                object bs_(Claim.ProcedureComponent @this)
                                {
                                    DataType cu_ = @this?.Procedure;

                                    return cu_;
                                };
                                IEnumerable<object> bt_ = context.Operators.Select<Claim.ProcedureComponent, object>(br_, bs_);
                                bool? bu_(object @this)
                                {
                                    object cv_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                    bool? cw_ = context.Operators.Not((bool?)(cv_ is null));

                                    return cw_;
                                };
                                IEnumerable<object> bv_ = context.Operators.Where<object>(bt_, bu_);
                                object bw_(object @this)
                                {
                                    object cx_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                    return cx_;
                                };
                                IEnumerable<object> bx_ = context.Operators.Select<object, object>(bv_, bw_);
                                IEnumerable<object> by_ = context.Operators.FlattenLateBoundList(bx_);
                                Coding bz_(object @object) =>
                                    (Coding)@object;
                                IEnumerable<Coding> ca_ = context.Operators.Select<object, Coding>(by_, bz_);
                                bool? cb_(Coding ProcedureHeaderCode)
                                {
                                    Code cy_ = ProcedureHeaderCode?.CodeElement;
                                    string cz_ = cy_?.Value;
                                    IEnumerable<string> da_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? db_ = context.Operators.In<string>(cz_, da_);

                                    return db_;
                                };
                                IEnumerable<Coding> cc_ = context.Operators.Where<Coding>(ca_, cb_);
                                bool? cd_ = context.Operators.Exists<Coding>(cc_);
                                List<Claim.ItemComponent> ce_ = ItemOnLine?.Item;
                                bool? cf_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept dc_ = @this?.ProductOrService;
                                    bool? dd_ = context.Operators.Not((bool?)(dc_ is null));

                                    return dd_;
                                };
                                IEnumerable<Claim.ItemComponent> cg_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ce_, cf_);
                                CodeableConcept ch_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept de_ = @this?.ProductOrService;

                                    return de_;
                                };
                                IEnumerable<CodeableConcept> ci_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(cg_, ch_);
                                bool? cj_(CodeableConcept @this)
                                {
                                    List<Coding> df_ = @this?.Coding;
                                    bool? dg_ = context.Operators.Not((bool?)(df_ is null));

                                    return dg_;
                                };
                                IEnumerable<CodeableConcept> ck_ = context.Operators.Where<CodeableConcept>(ci_, cj_);
                                List<Coding> cl_(CodeableConcept @this)
                                {
                                    List<Coding> dh_ = @this?.Coding;

                                    return dh_;
                                };
                                IEnumerable<List<Coding>> cm_ = context.Operators.Select<CodeableConcept, List<Coding>>(ck_, cl_);
                                IEnumerable<Coding> cn_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)cm_);
                                bool? co_(Coding LineCode)
                                {
                                    Code di_ = LineCode?.CodeElement;
                                    string dj_ = di_?.Value;
                                    IEnumerable<string> dk_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? dl_ = context.Operators.In<string>(dj_, dk_);

                                    return dl_;
                                };
                                IEnumerable<Coding> cp_ = context.Operators.Where<Coding>(cn_, co_);
                                bool? cq_ = context.Operators.Exists<Coding>(cp_);
                                bool? cr_ = context.Operators.Or(cd_, cq_);

                                return cr_;
                            };
                            IEnumerable<Claim> bn_ = context.Operators.Where<Claim>((IEnumerable<Claim>)bl_, bm_);
                            Claim bo_ = context.Operators.SingletonFrom<Claim>(bn_);

                            return bo_;
                        }
                    };
                    (CqlTupleMetadata, Claim ProcedureItems)? bf_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, be_());
                    (CqlTupleMetadata, Claim ProcedureItems)?[] bg_ = [
                        bf_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bh_((CqlTupleMetadata, Claim ProcedureItems)? HeaderDefinition)
                    {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dm_()
                        {
                            bool dn_()
                            {
                                Claim do_ = HeaderDefinition?.ProcedureItems;
                                bool? dp_ = context.Operators.Not((bool?)(do_ is null));

                                return dp_ ?? false;
                            };
                            if (dn_())
                            {
                                Claim dq_ = HeaderDefinition?.ProcedureItems;
                                List<Claim.ItemComponent> ds_ = dq_?.Item;
                                CqlInterval<CqlDateTime> dt_(Claim.ItemComponent NormalDate)
                                {
                                    DataType dx_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> dy_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dx_);

                                    return dy_;
                                };
                                IEnumerable<CqlInterval<CqlDateTime>> du_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)ds_, dt_);
                                IEnumerable<CqlInterval<CqlDateTime>> dv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(du_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dw_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, dq_, dv_);

                                return dw_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        };

                        return dm_();
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bi_ = context.Operators.Select<(CqlTupleMetadata, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim ProcedureItems)?>)bg_, bh_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bj_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bi_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bj_);

                    return bk_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ba_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ay_, az_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bb_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ba_);
                bool? bc_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? dz_ = context.Operators.Not((bool?)(FinalList is null));

                    return dz_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bd_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bb_, bc_);

                return bd_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> t_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)r_, s_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> u_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(t_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> v_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(u_);

            return v_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)i_, j_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> l_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(k_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(l_);

        return m_;
    }


    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);
        string b_(CqlCode d)
        {
            string n_ = d?.code;

            return n_;
        };
        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        string e_(CqlCode p)
        {
            string o_ = p?.code;

            return o_;
        };
        IEnumerable<string> f_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, e_);
        IEnumerable<string> g_ = context.Operators.Distinct<string>(f_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? h_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, a_, d_, g_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] i_ = [
            h_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure)
        {
            IEnumerable<Claim> p_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? q_(Claim ClaimofInterest)
            {
                Claim v_()
                {
                    if (ClaimofInterest is null)
                    {
                        return default;
                    }
                    else
                    {
                        Claim[] ac_ = [
                            ClaimofInterest,
                        ];
                        bool? ad_(Claim ItemOnLine)
                        {
                            List<Claim.ItemComponent> ag_ = ItemOnLine?.Item;
                            bool? ah_(Claim.ItemComponent @this)
                            {
                                CodeableConcept bj_ = @this?.ProductOrService;
                                bool? bk_ = context.Operators.Not((bool?)(bj_ is null));

                                return bk_;
                            };
                            IEnumerable<Claim.ItemComponent> ai_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ag_, ah_);
                            CodeableConcept aj_(Claim.ItemComponent @this)
                            {
                                CodeableConcept bl_ = @this?.ProductOrService;

                                return bl_;
                            };
                            IEnumerable<CodeableConcept> ak_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ai_, aj_);
                            bool? al_(CodeableConcept @this)
                            {
                                List<Coding> bm_ = @this?.Coding;
                                bool? bn_ = context.Operators.Not((bool?)(bm_ is null));

                                return bn_;
                            };
                            IEnumerable<CodeableConcept> am_ = context.Operators.Where<CodeableConcept>(ak_, al_);
                            List<Coding> an_(CodeableConcept @this)
                            {
                                List<Coding> bo_ = @this?.Coding;

                                return bo_;
                            };
                            IEnumerable<List<Coding>> ao_ = context.Operators.Select<CodeableConcept, List<Coding>>(am_, an_);
                            IEnumerable<Coding> ap_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ao_);
                            bool? aq_(Coding LineCode)
                            {
                                Code bp_ = LineCode?.CodeElement;
                                string bq_ = bp_?.Value;
                                IEnumerable<string> br_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? bs_ = context.Operators.In<string>(bq_, br_);

                                return bs_;
                            };
                            IEnumerable<Coding> ar_ = context.Operators.Where<Coding>(ap_, aq_);
                            bool? as_ = context.Operators.Exists<Coding>(ar_);
                            List<Claim.ProcedureComponent> at_ = ItemOnLine?.Procedure;
                            bool? au_(Claim.ProcedureComponent @this)
                            {
                                DataType bt_ = @this?.Procedure;
                                bool? bu_ = context.Operators.Not((bool?)(bt_ is null));

                                return bu_;
                            };
                            IEnumerable<Claim.ProcedureComponent> av_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)at_, au_);
                            object aw_(Claim.ProcedureComponent @this)
                            {
                                DataType bv_ = @this?.Procedure;

                                return bv_;
                            };
                            IEnumerable<object> ax_ = context.Operators.Select<Claim.ProcedureComponent, object>(av_, aw_);
                            bool? ay_(object @this)
                            {
                                object bw_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? bx_ = context.Operators.Not((bool?)(bw_ is null));

                                return bx_;
                            };
                            IEnumerable<object> az_ = context.Operators.Where<object>(ax_, ay_);
                            object ba_(object @this)
                            {
                                object by_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return by_;
                            };
                            IEnumerable<object> bb_ = context.Operators.Select<object, object>(az_, ba_);
                            IEnumerable<object> bc_ = context.Operators.FlattenLateBoundList(bb_);
                            Coding bd_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> be_ = context.Operators.Select<object, Coding>(bc_, bd_);
                            bool? bf_(Coding HeaderCode)
                            {
                                Code bz_ = HeaderCode?.CodeElement;
                                string ca_ = bz_?.Value;
                                IEnumerable<string> cb_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? cc_ = context.Operators.In<string>(ca_, cb_);

                                return cc_;
                            };
                            IEnumerable<Coding> bg_ = context.Operators.Where<Coding>(be_, bf_);
                            bool? bh_ = context.Operators.Exists<Coding>(bg_);
                            bool? bi_ = context.Operators.Or(as_, bh_);

                            return bi_;
                        };
                        IEnumerable<Claim> ae_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ac_, ad_);
                        Claim af_ = context.Operators.SingletonFrom<Claim>(ae_);

                        return af_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? w_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, v_());
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?[] x_ = [
                    w_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? y_((CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? DiagnosisCheck)
                {
                    Claim cd_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] ce_ = [
                        cd_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cf_(Claim ClaimforDiagnosis)
                    {
                        List<Claim.ItemComponent> cj_ = ClaimforDiagnosis?.Item;
                        Claim ck_()
                        {
                            if (ClaimforDiagnosis is null)
                            {
                                return default;
                            }
                            else
                            {
                                Claim[] cr_ = [
                                    ClaimforDiagnosis,
                                ];
                                bool? cs_(Claim RightClaim)
                                {
                                    List<Claim.DiagnosisComponent> cv_ = RightClaim?.Diagnosis;
                                    bool? cw_(Claim.DiagnosisComponent RightDiagnosis)
                                    {
                                        PositiveInt cz_ = RightDiagnosis?.SequenceElement;
                                        Integer da_ = context.Operators.Convert<Integer>(cz_);
                                        int? db_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, da_);
                                        bool? dc_ = context.Operators.Equal(db_, 1);
                                        DataType dd_ = RightDiagnosis?.Diagnosis;
                                        IEnumerable<Coding> de_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(dd_, "coding");
                                        bool? df_(Coding DiagnosisCode)
                                        {
                                            Code dj_ = DiagnosisCode?.CodeElement;
                                            string dk_ = dj_?.Value;
                                            IEnumerable<string> dl_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                            bool? dm_ = context.Operators.In<string>(dk_, dl_);

                                            return dm_;
                                        };
                                        IEnumerable<Coding> dg_ = context.Operators.Where<Coding>(de_, df_);
                                        bool? dh_ = context.Operators.Exists<Coding>(dg_);
                                        bool? di_ = context.Operators.And(dc_, dh_);

                                        return di_;
                                    };
                                    IEnumerable<Claim.DiagnosisComponent> cx_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)cv_, cw_);
                                    bool? cy_ = context.Operators.Exists<Claim.DiagnosisComponent>(cx_);

                                    return cy_;
                                };
                                IEnumerable<Claim> ct_ = context.Operators.Where<Claim>((IEnumerable<Claim>)cr_, cs_);
                                Claim cu_ = context.Operators.SingletonFrom<Claim>(ct_);

                                return cu_;
                            }
                        };
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? cl_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)cj_, ck_());
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] cm_ = [
                            cl_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cn_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dn_()
                            {
                                bool do_()
                                {
                                    bool? dp_ = context.Operators.Not((bool?)(LineItemDefinition is null));
                                    Claim dq_ = LineItemDefinition?.LineItems;
                                    bool? dr_ = context.Operators.Not((bool?)(dq_ is null));
                                    bool? ds_ = context.Operators.And(dp_, dr_);

                                    return ds_ ?? false;
                                };
                                if (do_())
                                {
                                    Claim dt_ = LineItemDefinition?.LineItems;
                                    List<Claim.ItemComponent> dv_ = dt_?.Item;
                                    CqlInterval<CqlDateTime> dw_(Claim.ItemComponent NormalDate)
                                    {
                                        DataType dz_ = NormalDate?.Serviced;
                                        CqlInterval<CqlDateTime> ea_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dz_);

                                        return ea_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> dx_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)dv_, dw_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dy_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, dt_, dx_);

                                    return dy_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                                }
                            };

                            return dn_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> co_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)cm_, cn_);
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> cp_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(co_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(cp_);

                        return cq_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> cg_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)ce_, cf_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ch_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(cg_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ci_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ch_);

                    return ci_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> z_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?>)x_, y_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> aa_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(z_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ab_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(aa_);

                return ab_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> r_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_, q_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> s_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(r_);
            bool? t_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? eb_ = context.Operators.Not((bool?)(FinalList is null));

                return eb_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> u_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(s_, t_);

            return u_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> k_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)i_, j_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> l_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(k_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(l_);

        return m_;
    }


    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);
        string b_(CqlCode d)
        {
            string k_ = d?.code;

            return k_;
        };
        IEnumerable<string> c_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, b_);
        IEnumerable<string> d_ = context.Operators.Distinct<string>(c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? e_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, a_, d_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] f_ = [
            e_,
        ];
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> l_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> s_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? t_(Claim RightClaim)
                    {
                        List<Claim.DiagnosisComponent> v_ = RightClaim?.Diagnosis;
                        bool? w_(Claim.DiagnosisComponent RightDiagnosis)
                        {
                            PositiveInt z_ = RightDiagnosis?.SequenceElement;
                            Integer aa_ = context.Operators.Convert<Integer>(z_);
                            int? ab_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, aa_);
                            bool? ac_ = context.Operators.Equal(ab_, 1);
                            DataType ad_ = RightDiagnosis?.Diagnosis;
                            IEnumerable<Coding> ae_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(ad_, "coding");
                            bool? af_(Coding DiagnosisCode)
                            {
                                Code aj_ = DiagnosisCode?.CodeElement;
                                string ak_ = aj_?.Value;
                                IEnumerable<string> al_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                                bool? am_ = context.Operators.In<string>(ak_, al_);

                                return am_;
                            };
                            IEnumerable<Coding> ag_ = context.Operators.Where<Coding>(ae_, af_);
                            bool? ah_ = context.Operators.Exists<Coding>(ag_);
                            bool? ai_ = context.Operators.And(ac_, ah_);

                            return ai_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> x_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)v_, w_);
                        bool? y_ = context.Operators.Exists<Claim.DiagnosisComponent>(x_);

                        return y_;
                    };
                    IEnumerable<Claim> u_ = context.Operators.Where<Claim>(s_, t_);

                    return u_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)? m_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, l_());
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)?[] n_ = [
                m_,
            ];
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_((CqlTupleMetadata, IEnumerable<Claim> LineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> an_ = LineItemDefinition?.LineItems;
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ao_(Claim ClaimWithDiagnosis)
                {
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? at_()
                    {
                        if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
                        {
                            IEnumerable<Claim> au_ = LineItemDefinition?.LineItems;
                            bool? aw_(Claim @this)
                            {
                                List<Claim.ItemComponent> bf_ = @this?.Item;
                                bool? bg_ = context.Operators.Not((bool?)(bf_ is null));

                                return bg_;
                            };
                            IEnumerable<Claim> ax_ = context.Operators.Where<Claim>(au_, aw_);
                            List<Claim.ItemComponent> ay_(Claim @this)
                            {
                                List<Claim.ItemComponent> bh_ = @this?.Item;

                                return bh_;
                            };
                            IEnumerable<List<Claim.ItemComponent>> az_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(ax_, ay_);
                            IEnumerable<Claim.ItemComponent> ba_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)az_);
                            CqlInterval<CqlDateTime> bb_(Claim.ItemComponent NormalDate)
                            {
                                DataType bi_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> bj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bi_);

                                return bj_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> bc_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(ba_, bb_);
                            IEnumerable<CqlInterval<CqlDateTime>> bd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bc_);
                            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? be_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, au_, bd_);

                            return be_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return at_();
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ap_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(an_, ao_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> aq_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ap_);
                bool? ar_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? bk_ = context.Operators.Not((bool?)(FinalList is null));

                    return bk_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> as_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(aq_, ar_);

                return as_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?>)n_, o_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> q_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(p_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> r_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(q_);

            return r_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> h_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)f_, g_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(h_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);

        return j_;
    }


    public (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> a_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
        IEnumerable<Claim> b_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? c_ = (CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE, a_, b_);

        return c_;
    }


    public IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? a_(ClaimResponse ResponseItem)
        {
            Code<ClaimProcessingCodes> i_ = ResponseItem?.OutcomeElement;
            string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
            string[] k_ = [
                "complete",
                "partial",
            ];
            bool? l_ = context.Operators.In<string>(j_, k_ as IEnumerable<string>);

            return l_;
        };
        IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? c_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, b_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?[] d_ = [
            c_,
        ];
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> e_((CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ClaimResponse)
        {
            IEnumerable<ClaimResponse> m_ = ClaimResponse?.PaidResponse;
            (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? n_(ClaimResponse ClmResp)
            {
                ResourceReference q_ = ClmResp?.Request;
                FhirString r_ = q_?.ReferenceElement;
                string s_ = FHIRHelpers_4_0_001.Instance.ToString(context, r_);
                string t_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, s_);
                List<ClaimResponse.ItemComponent> u_ = ClmResp?.Item;
                bool? v_(ClaimResponse.ItemComponent ResponseItem)
                {
                    List<ClaimResponse.AdjudicationComponent> y_ = ResponseItem?.Adjudication;
                    bool? z_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept au_ = @this?.Category;
                        bool? av_ = context.Operators.Not((bool?)(au_ is null));

                        return av_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> aa_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)y_, z_);
                    CodeableConcept ab_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept aw_ = @this?.Category;

                        return aw_;
                    };
                    IEnumerable<CodeableConcept> ac_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(aa_, ab_);
                    bool? ad_(CodeableConcept @this)
                    {
                        List<Coding> ax_ = @this?.Coding;
                        bool? ay_ = context.Operators.Not((bool?)(ax_ is null));

                        return ay_;
                    };
                    IEnumerable<CodeableConcept> ae_ = context.Operators.Where<CodeableConcept>(ac_, ad_);
                    List<Coding> af_(CodeableConcept @this)
                    {
                        List<Coding> az_ = @this?.Coding;

                        return az_;
                    };
                    IEnumerable<List<Coding>> ag_ = context.Operators.Select<CodeableConcept, List<Coding>>(ae_, af_);
                    IEnumerable<Coding> ah_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ag_);
                    bool? ai_(Coding CategoryItem)
                    {
                        Code ba_ = CategoryItem?.CodeElement;
                        string bb_ = ba_?.Value;
                        bool? bc_ = context.Operators.Equal(bb_, "benefit");

                        return bc_;
                    };
                    IEnumerable<Coding> aj_ = context.Operators.Where<Coding>(ah_, ai_);
                    bool? ak_ = context.Operators.Exists<Coding>(aj_);
                    bool? am_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money bd_ = @this?.Amount;
                        bool? be_ = context.Operators.Not((bool?)(bd_ is null));

                        return be_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> an_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)y_, am_);
                    Money ao_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money bf_ = @this?.Amount;

                        return bf_;
                    };
                    IEnumerable<Money> ap_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(an_, ao_);
                    bool? aq_(Money DollarAmount)
                    {
                        FhirDecimal bg_ = DollarAmount?.ValueElement;
                        decimal? bh_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bg_);
                        decimal? bi_ = context.Operators.ConvertIntegerToDecimal(0);
                        bool? bj_ = context.Operators.Greater(bh_, bi_);

                        return bj_;
                    };
                    IEnumerable<Money> ar_ = context.Operators.Where<Money>(ap_, aq_);
                    bool? as_ = context.Operators.Exists<Money>(ar_);
                    bool? at_ = context.Operators.And(ak_, as_);

                    return at_;
                };
                IEnumerable<ClaimResponse.ItemComponent> w_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)u_, v_);
                (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? x_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, t_, w_);

                return x_;
            };
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> o_ = context.Operators.Select<ClaimResponse, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(m_, n_);
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> p_ = context.Operators.Distinct<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(o_);

            return p_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?>)d_, e_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> g_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(f_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> h_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(g_);

        return h_;
    }


    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? a_(Claim AllClaims)
        {
            List<Claim.ItemComponent> f_ = AllClaims?.Item;
            bool? g_(Claim.ItemComponent @this)
            {
                CodeableConcept ai_ = @this?.ProductOrService;
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));

                return aj_;
            };
            IEnumerable<Claim.ItemComponent> h_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)f_, g_);
            CodeableConcept i_(Claim.ItemComponent @this)
            {
                CodeableConcept ak_ = @this?.ProductOrService;

                return ak_;
            };
            IEnumerable<CodeableConcept> j_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(h_, i_);
            bool? k_(CodeableConcept @this)
            {
                List<Coding> al_ = @this?.Coding;
                bool? am_ = context.Operators.Not((bool?)(al_ is null));

                return am_;
            };
            IEnumerable<CodeableConcept> l_ = context.Operators.Where<CodeableConcept>(j_, k_);
            List<Coding> m_(CodeableConcept @this)
            {
                List<Coding> an_ = @this?.Coding;

                return an_;
            };
            IEnumerable<List<Coding>> n_ = context.Operators.Select<CodeableConcept, List<Coding>>(l_, m_);
            IEnumerable<Coding> o_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)n_);
            bool? p_(Coding ProductOrServiceCode)
            {
                CqlCode ao_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? ap_ = context.Operators.In<CqlCode>(ao_, ProductOrServiceValueSet);

                return ap_;
            };
            IEnumerable<Coding> q_ = context.Operators.Where<Coding>(o_, p_);
            bool? r_ = context.Operators.Exists<Coding>(q_);
            List<Claim.DiagnosisComponent> s_ = AllClaims?.Diagnosis;
            bool? t_(Claim.DiagnosisComponent @this)
            {
                DataType aq_ = @this?.Diagnosis;
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));

                return ar_;
            };
            IEnumerable<Claim.DiagnosisComponent> u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
            object v_(Claim.DiagnosisComponent @this)
            {
                DataType as_ = @this?.Diagnosis;

                return as_;
            };
            IEnumerable<object> w_ = context.Operators.Select<Claim.DiagnosisComponent, object>(u_, v_);
            bool? x_(object @this)
            {
                object at_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? au_ = context.Operators.Not((bool?)(at_ is null));

                return au_;
            };
            IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
            object z_(object @this)
            {
                object av_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return av_;
            };
            IEnumerable<object> aa_ = context.Operators.Select<object, object>(y_, z_);
            IEnumerable<object> ab_ = context.Operators.FlattenLateBoundList(aa_);
            Coding ac_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> ad_ = context.Operators.Select<object, Coding>(ab_, ac_);
            bool? ae_(Coding DiagnosisCode)
            {
                CqlCode aw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? ax_ = context.Operators.In<CqlCode>(aw_, DiagnosisValueSet);

                return ax_;
            };
            IEnumerable<Coding> af_ = context.Operators.Where<Coding>(ad_, ae_);
            bool? ag_ = context.Operators.Exists<Coding>(af_);
            bool? ah_ = context.Operators.And(r_, ag_);

            return ah_;
        };
        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim ProcedureClaims)
        {
            Id ay_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> az_ = ProcedureClaims?.Item;
            bool? ba_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept bd_ = ResponseItem?.ProductOrService;
                List<Coding> be_ = bd_?.Coding;
                bool? bf_(Coding ProductOrServiceCode)
                {
                    CqlCode bi_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? bj_ = context.Operators.In<CqlCode>(bi_, ProductOrServiceValueSet);

                    return bj_;
                };
                IEnumerable<Coding> bg_ = context.Operators.Where<Coding>((IEnumerable<Coding>)be_, bf_);
                bool? bh_ = context.Operators.Exists<Coding>(bg_);

                return bh_;
            };
            IEnumerable<Claim.ItemComponent> bb_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)az_, ba_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bc_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, ay_, bb_);

            return bc_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(d_);

        return e_;
    }


    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
            c_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> i_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? j_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> s_ = medClaim?.LineItems;
                bool? t_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> w_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> x_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> aa_ = pClaim?.LineItems;
                        bool? ab_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id af_()
                            {
                                bool at_()
                                {
                                    Claim au_ = medClaim?.ClaimofInterest;
                                    bool av_ = au_ is Resource;

                                    return av_;
                                };
                                if (at_())
                                {
                                    Claim aw_ = medClaim?.ClaimofInterest;

                                    return (aw_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_());
                            ClaimResponse ah_ = pClaim?.Response;
                            ResourceReference ai_ = ah_?.Request;
                            FhirString aj_ = ai_?.ReferenceElement;
                            string ak_ = FHIRHelpers_4_0_001.Instance.ToString(context, aj_);
                            string al_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ak_);
                            bool? am_ = context.Operators.Equal(ag_, al_);
                            PositiveInt an_ = medClaimLineItem?.SequenceElement;
                            Integer ao_ = context.Operators.Convert<Integer>(an_);
                            PositiveInt ap_ = pClaimLineItem?.ItemSequenceElement;
                            Integer aq_ = context.Operators.Convert<Integer>(ap_);
                            bool? ar_ = context.Operators.Equal(ao_, aq_);
                            bool? as_ = context.Operators.And(am_, ar_);

                            return as_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> ac_ = context.Operators.Where<ClaimResponse.ItemComponent>(aa_, ab_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? ad_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ae_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ac_, ad_);

                        return ae_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> y_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(w_, x_);
                    bool? z_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(y_);

                    return z_;
                };
                IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>(s_, t_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? v_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, u_);

                return v_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> k_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(k_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? m_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, l_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] n_ = [
                m_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ax_()
                {
                    bool bc_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bd_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? be_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> bk_ = @this?.ClaimItem;
                            bool? bl_ = context.Operators.Not((bool?)(bk_ is null));

                            return bl_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bd_, be_);
                        IEnumerable<Claim.ItemComponent> bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> bm_ = @this?.ClaimItem;

                            return bm_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bf_, bg_);
                        IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);
                        bool? bj_ = context.Operators.Exists<Claim.ItemComponent>(bi_);

                        return bj_ ?? false;
                    };
                    if (bc_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bn_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? bo_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? cc_ = @this?.PaidClaim;
                            bool? cd_ = context.Operators.Not((bool?)(cc_ is null));

                            return cd_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bp_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, bo_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bq_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ce_ = @this?.PaidClaim;

                            return ce_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> br_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bp_, bq_);
                        bool? bt_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> cf_ = @this?.ClaimItem;
                            bool? cg_ = context.Operators.Not((bool?)(cf_ is null));

                            return cg_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bu_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, bt_);
                        IEnumerable<Claim.ItemComponent> bv_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ch_ = @this?.ClaimItem;

                            return ch_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> bw_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bu_, bv_);
                        IEnumerable<Claim.ItemComponent> bx_ = context.Operators.Flatten<Claim.ItemComponent>(bw_);
                        CqlInterval<CqlDateTime> by_(Claim.ItemComponent PaidItem)
                        {
                            DataType ci_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> cj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ci_);

                            return cj_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> bz_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bx_, by_);
                        IEnumerable<CqlInterval<CqlDateTime>> ca_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bz_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cb_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, br_, ca_);

                        return cb_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] ay_ = [
                    ax_(),
                ];
                bool? az_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? ck_ = context.Operators.Not((bool?)(FinalList is null));

                    return ck_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ba_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)ay_, az_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ba_);

                return bb_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(q_);

            return r_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);

        return h_;
    }


    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? k_()
            {
                bool l_()
                {
                    IEnumerable<ClaimResponse> m_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> n_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? o_ = context.Operators.And((bool?)(m_ is null), (bool?)(n_ is null));

                    return o_ ?? false;
                };
                if (l_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> p_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> q_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, p_, q_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return r_;
                }
            };

            return k_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] g_ = [
            f_,
        ];
        bool? h_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
        {
            bool? s_ = context.Operators.Not((bool?)(FinalList is null));

            return s_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> i_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)g_, h_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? j_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(i_);

        return j_;
    }


    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? a_(Claim AllClaims)
        {
            List<Claim.ItemComponent> f_ = AllClaims?.Item;
            bool? g_(Claim.ItemComponent @this)
            {
                CodeableConcept ai_ = @this?.ProductOrService;
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));

                return aj_;
            };
            IEnumerable<Claim.ItemComponent> h_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)f_, g_);
            CodeableConcept i_(Claim.ItemComponent @this)
            {
                CodeableConcept ak_ = @this?.ProductOrService;

                return ak_;
            };
            IEnumerable<CodeableConcept> j_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(h_, i_);
            bool? k_(CodeableConcept @this)
            {
                List<Coding> al_ = @this?.Coding;
                bool? am_ = context.Operators.Not((bool?)(al_ is null));

                return am_;
            };
            IEnumerable<CodeableConcept> l_ = context.Operators.Where<CodeableConcept>(j_, k_);
            List<Coding> m_(CodeableConcept @this)
            {
                List<Coding> an_ = @this?.Coding;

                return an_;
            };
            IEnumerable<List<Coding>> n_ = context.Operators.Select<CodeableConcept, List<Coding>>(l_, m_);
            IEnumerable<Coding> o_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)n_);
            bool? p_(Coding ProductOrServiceCode)
            {
                CqlCode ao_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? ap_ = context.Operators.In<CqlCode>(ao_, ProductOrServiceValueSet);

                return ap_;
            };
            IEnumerable<Coding> q_ = context.Operators.Where<Coding>(o_, p_);
            bool? r_ = context.Operators.Exists<Coding>(q_);
            List<Claim.DiagnosisComponent> s_ = AllClaims?.Diagnosis;
            bool? t_(Claim.DiagnosisComponent @this)
            {
                DataType aq_ = @this?.Diagnosis;
                bool? ar_ = context.Operators.Not((bool?)(aq_ is null));

                return ar_;
            };
            IEnumerable<Claim.DiagnosisComponent> u_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
            object v_(Claim.DiagnosisComponent @this)
            {
                DataType as_ = @this?.Diagnosis;

                return as_;
            };
            IEnumerable<object> w_ = context.Operators.Select<Claim.DiagnosisComponent, object>(u_, v_);
            bool? x_(object @this)
            {
                object at_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? au_ = context.Operators.Not((bool?)(at_ is null));

                return au_;
            };
            IEnumerable<object> y_ = context.Operators.Where<object>(w_, x_);
            object z_(object @this)
            {
                object av_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return av_;
            };
            IEnumerable<object> aa_ = context.Operators.Select<object, object>(y_, z_);
            IEnumerable<object> ab_ = context.Operators.FlattenLateBoundList(aa_);
            Coding ac_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> ad_ = context.Operators.Select<object, Coding>(ab_, ac_);
            bool? ae_(Coding DiagnosisCode)
            {
                CqlCode aw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? ax_ = context.Operators.In<CqlCode>(aw_, DiagnosisValueSet);

                return ax_;
            };
            IEnumerable<Coding> af_ = context.Operators.Where<Coding>(ad_, ae_);
            bool? ag_ = context.Operators.Exists<Coding>(af_);
            bool? ah_ = context.Operators.Or(r_, ag_);

            return ah_;
        };
        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim ProcedureClaims)
        {
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ay_()
            {
                bool az_()
                {
                    List<Claim.ItemComponent> ba_ = ProcedureClaims?.Item;
                    bool? bb_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept be_ = ResponseItem?.ProductOrService;
                        List<Coding> bf_ = be_?.Coding;
                        bool? bg_(Coding ProductOrServiceCode)
                        {
                            CqlCode bj_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? bk_ = context.Operators.In<CqlCode>(bj_, ProductOrServiceValueSet);

                            return bk_;
                        };
                        IEnumerable<Coding> bh_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bf_, bg_);
                        bool? bi_ = context.Operators.Exists<Coding>(bh_);

                        return bi_;
                    };
                    IEnumerable<Claim.ItemComponent> bc_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ba_, bb_);
                    bool? bd_ = context.Operators.Exists<Claim.ItemComponent>(bc_);

                    return bd_ ?? false;
                };
                if (az_())
                {
                    Id bl_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> bm_ = ProcedureClaims?.Item;
                    bool? bn_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept bq_ = ResponseItem?.ProductOrService;
                        List<Coding> br_ = bq_?.Coding;
                        bool? bs_(Coding ProductOrServiceCode)
                        {
                            CqlCode bv_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? bw_ = context.Operators.In<CqlCode>(bv_, ProductOrServiceValueSet);

                            return bw_;
                        };
                        IEnumerable<Coding> bt_ = context.Operators.Where<Coding>((IEnumerable<Coding>)br_, bs_);
                        bool? bu_ = context.Operators.Exists<Coding>(bt_);

                        return bu_;
                    };
                    IEnumerable<Claim.ItemComponent> bo_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bm_, bn_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bp_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, bl_, bo_);

                    return bp_;
                }
                else
                {
                    Id bx_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> by_ = ProcedureClaims?.Item;
                    bool? bz_(Claim.ItemComponent ResponseItem)
                    {
                        PositiveInt cc_ = ResponseItem?.SequenceElement;
                        Integer cd_ = context.Operators.Convert<Integer>(cc_);
                        int? ce_ = cd_?.Value;
                        bool? cf_ = context.Operators.Equal(ce_, 1);

                        return cf_;
                    };
                    IEnumerable<Claim.ItemComponent> ca_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)by_, bz_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? cb_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, bx_, ca_);

                    return cb_;
                }
            };

            return ay_();
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(d_);

        return e_;
    }


    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
            c_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> i_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? j_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> s_ = medClaim?.LineItems;
                bool? t_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> w_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> x_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> aa_ = pClaim?.LineItems;
                        bool? ab_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id af_()
                            {
                                bool at_()
                                {
                                    Claim au_ = medClaim?.ClaimofInterest;
                                    bool av_ = au_ is Resource;

                                    return av_;
                                };
                                if (at_())
                                {
                                    Claim aw_ = medClaim?.ClaimofInterest;

                                    return (aw_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_());
                            ClaimResponse ah_ = pClaim?.Response;
                            ResourceReference ai_ = ah_?.Request;
                            FhirString aj_ = ai_?.ReferenceElement;
                            string ak_ = FHIRHelpers_4_0_001.Instance.ToString(context, aj_);
                            string al_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ak_);
                            bool? am_ = context.Operators.Equal(ag_, al_);
                            PositiveInt an_ = medClaimLineItem?.SequenceElement;
                            Integer ao_ = context.Operators.Convert<Integer>(an_);
                            PositiveInt ap_ = pClaimLineItem?.ItemSequenceElement;
                            Integer aq_ = context.Operators.Convert<Integer>(ap_);
                            bool? ar_ = context.Operators.Equal(ao_, aq_);
                            bool? as_ = context.Operators.And(am_, ar_);

                            return as_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> ac_ = context.Operators.Where<ClaimResponse.ItemComponent>(aa_, ab_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? ad_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ae_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ac_, ad_);

                        return ae_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> y_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(w_, x_);
                    bool? z_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(y_);

                    return z_;
                };
                IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>(s_, t_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? v_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, u_);

                return v_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> k_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(k_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? m_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, l_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] n_ = [
                m_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ax_()
                {
                    bool bc_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bd_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? be_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> bk_ = @this?.ClaimItem;
                            bool? bl_ = context.Operators.Not((bool?)(bk_ is null));

                            return bl_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bd_, be_);
                        IEnumerable<Claim.ItemComponent> bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> bm_ = @this?.ClaimItem;

                            return bm_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bf_, bg_);
                        IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);
                        bool? bj_ = context.Operators.Exists<Claim.ItemComponent>(bi_);

                        return bj_ ?? false;
                    };
                    if (bc_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bn_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? bo_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? cc_ = @this?.PaidClaim;
                            bool? cd_ = context.Operators.Not((bool?)(cc_ is null));

                            return cd_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bp_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, bo_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bq_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ce_ = @this?.PaidClaim;

                            return ce_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> br_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bp_, bq_);
                        bool? bt_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> cf_ = @this?.ClaimItem;
                            bool? cg_ = context.Operators.Not((bool?)(cf_ is null));

                            return cg_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bu_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, bt_);
                        IEnumerable<Claim.ItemComponent> bv_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ch_ = @this?.ClaimItem;

                            return ch_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> bw_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bu_, bv_);
                        IEnumerable<Claim.ItemComponent> bx_ = context.Operators.Flatten<Claim.ItemComponent>(bw_);
                        CqlInterval<CqlDateTime> by_(Claim.ItemComponent PaidItem)
                        {
                            DataType ci_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> cj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ci_);

                            return cj_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> bz_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bx_, by_);
                        IEnumerable<CqlInterval<CqlDateTime>> ca_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bz_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cb_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, br_, ca_);

                        return cb_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] ay_ = [
                    ax_(),
                ];
                bool? az_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? ck_ = context.Operators.Not((bool?)(FinalList is null));

                    return ck_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ba_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)ay_, az_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ba_);

                return bb_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(q_);

            return r_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);

        return h_;
    }


    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_()
            {
                bool h_()
                {
                    IEnumerable<ClaimResponse> i_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> j_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? k_ = context.Operators.And((bool?)(i_ is null), (bool?)(j_ is null));

                    return k_ ?? false;
                };
                if (h_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> l_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> m_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? n_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, l_, m_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return n_;
                }
            };

            return g_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(e_);

        return f_;
    }


    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        bool? a_(Claim AllClaims)
        {
            List<Claim.ItemComponent> f_ = AllClaims?.Item;
            bool? g_(Claim.ItemComponent @this)
            {
                CodeableConcept s_ = @this?.ProductOrService;
                bool? t_ = context.Operators.Not((bool?)(s_ is null));

                return t_;
            };
            IEnumerable<Claim.ItemComponent> h_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)f_, g_);
            CodeableConcept i_(Claim.ItemComponent @this)
            {
                CodeableConcept u_ = @this?.ProductOrService;

                return u_;
            };
            IEnumerable<CodeableConcept> j_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(h_, i_);
            bool? k_(CodeableConcept @this)
            {
                List<Coding> v_ = @this?.Coding;
                bool? w_ = context.Operators.Not((bool?)(v_ is null));

                return w_;
            };
            IEnumerable<CodeableConcept> l_ = context.Operators.Where<CodeableConcept>(j_, k_);
            List<Coding> m_(CodeableConcept @this)
            {
                List<Coding> x_ = @this?.Coding;

                return x_;
            };
            IEnumerable<List<Coding>> n_ = context.Operators.Select<CodeableConcept, List<Coding>>(l_, m_);
            IEnumerable<Coding> o_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)n_);
            bool? p_(Coding ProductOrServiceCode)
            {
                CqlCode y_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? z_ = context.Operators.In<CqlCode>(y_, ProductOrServiceValueSet);

                return z_;
            };
            IEnumerable<Coding> q_ = context.Operators.Where<Coding>(o_, p_);
            bool? r_ = context.Operators.Exists<Coding>(q_);

            return r_;
        };
        IEnumerable<Claim> b_ = context.Operators.Where<Claim>(claim, a_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? c_(Claim AllClaims)
        {
            Id aa_ = AllClaims?.IdElement;
            List<Claim.ItemComponent> ab_ = AllClaims?.Item;
            bool? ac_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept af_ = ResponseItem?.ProductOrService;
                List<Coding> ag_ = af_?.Coding;
                bool? ah_(Coding ProductOrServiceCode)
                {
                    CqlCode ak_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? al_ = context.Operators.In<CqlCode>(ak_, ProductOrServiceValueSet);

                    return al_;
                };
                IEnumerable<Coding> ai_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ag_, ah_);
                bool? aj_ = context.Operators.Exists<Coding>(ai_);

                return aj_;
            };
            IEnumerable<Claim.ItemComponent> ad_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ab_, ac_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ae_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, aa_, ad_);

            return ae_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(b_, c_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(d_);

        return e_;
    }


    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> b_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] d_ = [
            c_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> i_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? j_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> s_ = medClaim?.LineItems;
                bool? t_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> w_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> x_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> aa_ = pClaim?.LineItems;
                        bool? ab_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id af_()
                            {
                                bool at_()
                                {
                                    Claim au_ = medClaim?.ClaimofInterest;
                                    bool av_ = au_ is Resource;

                                    return av_;
                                };
                                if (at_())
                                {
                                    Claim aw_ = medClaim?.ClaimofInterest;

                                    return (aw_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_());
                            ClaimResponse ah_ = pClaim?.Response;
                            ResourceReference ai_ = ah_?.Request;
                            FhirString aj_ = ai_?.ReferenceElement;
                            string ak_ = FHIRHelpers_4_0_001.Instance.ToString(context, aj_);
                            string al_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ak_);
                            bool? am_ = context.Operators.Equal(ag_, al_);
                            PositiveInt an_ = medClaimLineItem?.SequenceElement;
                            Integer ao_ = context.Operators.Convert<Integer>(an_);
                            PositiveInt ap_ = pClaimLineItem?.ItemSequenceElement;
                            Integer aq_ = context.Operators.Convert<Integer>(ap_);
                            bool? ar_ = context.Operators.Equal(ao_, aq_);
                            bool? as_ = context.Operators.And(am_, ar_);

                            return as_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> ac_ = context.Operators.Where<ClaimResponse.ItemComponent>(aa_, ab_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? ad_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ae_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ac_, ad_);

                        return ae_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> y_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(w_, x_);
                    bool? z_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(y_);

                    return z_;
                };
                IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>(s_, t_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? v_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, u_);

                return v_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> k_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(k_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? m_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, l_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] n_ = [
                m_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ax_()
                {
                    bool bc_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bd_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? be_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> bk_ = @this?.ClaimItem;
                            bool? bl_ = context.Operators.Not((bool?)(bk_ is null));

                            return bl_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bd_, be_);
                        IEnumerable<Claim.ItemComponent> bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> bm_ = @this?.ClaimItem;

                            return bm_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bf_, bg_);
                        IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);
                        bool? bj_ = context.Operators.Exists<Claim.ItemComponent>(bi_);

                        return bj_ ?? false;
                    };
                    if (bc_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bn_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? bo_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? cc_ = @this?.PaidClaim;
                            bool? cd_ = context.Operators.Not((bool?)(cc_ is null));

                            return cd_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bp_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, bo_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bq_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ce_ = @this?.PaidClaim;

                            return ce_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> br_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bp_, bq_);
                        bool? bt_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> cf_ = @this?.ClaimItem;
                            bool? cg_ = context.Operators.Not((bool?)(cf_ is null));

                            return cg_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bu_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, bt_);
                        IEnumerable<Claim.ItemComponent> bv_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ch_ = @this?.ClaimItem;

                            return ch_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> bw_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bu_, bv_);
                        IEnumerable<Claim.ItemComponent> bx_ = context.Operators.Flatten<Claim.ItemComponent>(bw_);
                        CqlInterval<CqlDateTime> by_(Claim.ItemComponent PaidItem)
                        {
                            DataType ci_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> cj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ci_);

                            return cj_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> bz_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bx_, by_);
                        IEnumerable<CqlInterval<CqlDateTime>> ca_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bz_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cb_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, br_, ca_);

                        return cb_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] ay_ = [
                    ax_(),
                ];
                bool? az_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? ck_ = context.Operators.Not((bool?)(FinalList is null));

                    return ck_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ba_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)ay_, az_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ba_);

                return bb_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(p_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(q_);

            return r_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);

        return h_;
    }


    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_()
            {
                bool h_()
                {
                    IEnumerable<ClaimResponse> i_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> j_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? k_ = context.Operators.And((bool?)(i_ is null), (bool?)(j_ is null));

                    return k_ ?? false;
                };
                if (h_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> l_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> m_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? n_ = this.Get_Corresponding_Claim_for_Services_Only(context, l_, m_, ProductOrServiceValueSet);

                    return n_;
                }
            };

            return g_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(e_);

        return f_;
    }


    public (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> a_ = this.Pharmacy_Claims_Response(context, claimResponse);
        IEnumerable<Claim> b_ = this.Pharmacy_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? c_ = (CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV, a_, b_);

        return c_;
    }


    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> b_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? c_ = (CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[] d_ = [
            c_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> i_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? j_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> s_ = medClaim?.LineItem;
                bool? t_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> w_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> x_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> aa_ = pClaim?.LineItems;
                        bool? ab_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id af_()
                            {
                                bool at_()
                                {
                                    Claim au_ = medClaim?.Claim;
                                    bool av_ = au_ is Resource;

                                    return av_;
                                };
                                if (at_())
                                {
                                    Claim aw_ = medClaim?.Claim;

                                    return (aw_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_());
                            ClaimResponse ah_ = pClaim?.Response;
                            ResourceReference ai_ = ah_?.Request;
                            FhirString aj_ = ai_?.ReferenceElement;
                            string ak_ = FHIRHelpers_4_0_001.Instance.ToString(context, aj_);
                            string al_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ak_);
                            bool? am_ = context.Operators.Equal(ag_, al_);
                            PositiveInt an_ = medClaimLineItem?.SequenceElement;
                            Integer ao_ = context.Operators.Convert<Integer>(an_);
                            PositiveInt ap_ = pClaimLineItem?.ItemSequenceElement;
                            Integer aq_ = context.Operators.Convert<Integer>(ap_);
                            bool? ar_ = context.Operators.Equal(ao_, aq_);
                            bool? as_ = context.Operators.And(am_, ar_);

                            return as_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> ac_ = context.Operators.Where<ClaimResponse.ItemComponent>(aa_, ab_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? ad_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ae_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ac_, ad_);

                        return ae_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> y_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(w_, x_);
                    bool? z_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(y_);

                    return z_;
                };
                IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>(s_, t_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? v_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, u_);

                return v_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> k_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(i_, j_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> l_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(k_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? m_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, l_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] n_ = [
                m_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? o_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ax_()
                {
                    bool bc_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bd_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? be_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> bk_ = @this?.ClaimItem;
                            bool? bl_ = context.Operators.Not((bool?)(bk_ is null));

                            return bl_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bd_, be_);
                        IEnumerable<Claim.ItemComponent> bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> bm_ = @this?.ClaimItem;

                            return bm_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bf_, bg_);
                        IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);
                        bool? bj_ = context.Operators.Exists<Claim.ItemComponent>(bi_);

                        return bj_ ?? false;
                    };
                    if (bc_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bn_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? bo_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? cl_ = @this?.PaidClaim;
                            bool? cm_ = context.Operators.Not((bool?)(cl_ is null));

                            return cm_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bp_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, bo_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bq_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? cn_ = @this?.PaidClaim;

                            return cn_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> br_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(bp_, bq_);
                        bool? bt_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> co_ = @this?.ClaimItem;
                            bool? cp_ = context.Operators.Not((bool?)(co_ is null));

                            return cp_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bu_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, bt_);
                        IEnumerable<Claim.ItemComponent> bv_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> cq_ = @this?.ClaimItem;

                            return cq_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> bw_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bu_, bv_);
                        IEnumerable<Claim.ItemComponent> bx_ = context.Operators.Flatten<Claim.ItemComponent>(bw_);
                        CqlInterval<CqlDateTime> by_(Claim.ItemComponent PaidItem)
                        {
                            DataType cr_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> cs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, cr_);

                            return cs_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> bz_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bx_, by_);
                        IEnumerable<CqlInterval<CqlDateTime>> ca_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bz_);
                        bool? cc_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ct_ = @this?.ClaimItem;
                            bool? cu_ = context.Operators.Not((bool?)(ct_ is null));

                            return cu_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> cd_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bn_, cc_);
                        IEnumerable<Claim.ItemComponent> ce_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> cv_ = @this?.ClaimItem;

                            return cv_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> cf_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(cd_, ce_);
                        IEnumerable<Claim.ItemComponent> cg_ = context.Operators.Flatten<Claim.ItemComponent>(cf_);
                        CqlInterval<CqlDate> ch_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDate> cw_()
                            {
                                bool cx_()
                                {
                                    Quantity cy_ = i?.Quantity;
                                    bool? cz_ = context.Operators.Not((bool?)(cy_ is null));

                                    return cz_ ?? false;
                                };
                                if (cx_())
                                {
                                    DataType da_ = i?.Serviced;
                                    CqlInterval<CqlDateTime> db_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, da_);
                                    CqlDateTime dc_ = context.Operators.Start(db_);
                                    CqlDate dd_ = context.Operators.ConvertDateTimeToDate(dc_);
                                    CqlInterval<CqlDateTime> df_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, da_);
                                    CqlDateTime dg_ = context.Operators.Start(df_);
                                    Quantity dh_ = i?.Quantity;
                                    FhirDecimal di_ = dh_?.ValueElement;
                                    decimal? dj_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, di_);
                                    CqlDateTime dk_ = context.Operators.Add(dg_, new CqlQuantity(dj_, "day"));
                                    CqlQuantity dl_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime dm_ = context.Operators.Subtract(dk_, dl_);
                                    CqlDate dn_ = context.Operators.ConvertDateTimeToDate(dm_);
                                    CqlInterval<CqlDate> do_ = context.Operators.Interval(dd_, dn_, true, true);

                                    return do_;
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDate>;
                                }
                            };

                            return cw_();
                        };
                        IEnumerable<CqlInterval<CqlDate>> ci_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(cg_, ch_);
                        IEnumerable<CqlInterval<CqlDate>> cj_ = context.Operators.Distinct<CqlInterval<CqlDate>>(ci_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ck_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, br_, ca_, cj_);

                        return ck_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] ay_ = [
                    ax_(),
                ];
                bool? az_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList)
                {
                    bool? dp_ = context.Operators.Not((bool?)(FinalList is null));

                    return dp_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ba_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)ay_, az_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? bb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ba_);

                return bb_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> p_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)n_, o_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> q_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(p_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? r_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(q_);

            return r_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> f_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> g_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(f_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(g_);

        return h_;
    }


    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] b_ = [
            a_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? g_()
            {
                bool h_()
                {
                    IEnumerable<ClaimResponse> i_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> j_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    bool? k_ = context.Operators.And((bool?)(i_ is null), (bool?)(j_ is null));

                    return k_ ?? false;
                };
                if (h_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> l_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> m_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? n_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, l_, m_, ProductOrServiceValueSet);

                    return n_;
                }
            };

            return g_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> d_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)b_, c_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> e_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(e_);

        return f_;
    }


    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? a_(Claim Claim)
        {
            bool? d_(ClaimResponse CR)
            {
                Id i_ = Claim?.IdElement;
                string j_ = FHIRHelpers_4_0_001.Instance.ToString(context, i_);
                ResourceReference k_ = CR?.Request;
                FhirString l_ = k_?.ReferenceElement;
                string m_ = FHIRHelpers_4_0_001.Instance.ToString(context, l_);
                string n_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, m_);
                bool? o_ = context.Operators.Equal(j_, n_);

                return o_;
            };
            IEnumerable<ClaimResponse> e_ = context.Operators.Where<ClaimResponse>(claimResponse, d_);
            bool? f_(Claim C)
            {
                Id p_ = Claim?.IdElement;
                string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
                bool? r_(ClaimResponse CR)
                {
                    Id af_ = Claim?.IdElement;
                    string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_);
                    ResourceReference ah_ = CR?.Request;
                    FhirString ai_ = ah_?.ReferenceElement;
                    string aj_ = FHIRHelpers_4_0_001.Instance.ToString(context, ai_);
                    string ak_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, aj_);
                    bool? al_ = context.Operators.Equal(ag_, ak_);

                    return al_;
                };
                IEnumerable<ClaimResponse> s_ = context.Operators.Where<ClaimResponse>(claimResponse, r_);
                bool? t_(ClaimResponse @this)
                {
                    ResourceReference am_ = @this?.Request;
                    bool? an_ = context.Operators.Not((bool?)(am_ is null));

                    return an_;
                };
                IEnumerable<ClaimResponse> u_ = context.Operators.Where<ClaimResponse>(s_, t_);
                ResourceReference v_(ClaimResponse @this)
                {
                    ResourceReference ao_ = @this?.Request;

                    return ao_;
                };
                IEnumerable<ResourceReference> w_ = context.Operators.Select<ClaimResponse, ResourceReference>(u_, v_);
                bool? x_(ResourceReference @this)
                {
                    FhirString ap_ = @this?.ReferenceElement;
                    bool? aq_ = context.Operators.Not((bool?)(ap_ is null));

                    return aq_;
                };
                IEnumerable<ResourceReference> y_ = context.Operators.Where<ResourceReference>(w_, x_);
                FhirString z_(ResourceReference @this)
                {
                    FhirString ar_ = @this?.ReferenceElement;

                    return ar_;
                };
                IEnumerable<FhirString> aa_ = context.Operators.Select<ResourceReference, FhirString>(y_, z_);
                FhirString ab_ = context.Operators.SingletonFrom<FhirString>(aa_);
                string ac_ = FHIRHelpers_4_0_001.Instance.ToString(context, ab_);
                string ad_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ac_);
                bool? ae_ = context.Operators.Equal(q_, ad_);

                return ae_;
            };
            IEnumerable<Claim> g_ = context.Operators.Where<Claim>(claim, f_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? h_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, e_, g_);

            return h_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> b_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, a_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> c_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(b_);

        return c_;
    }


    public (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim> claim)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? b_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, a_, default, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] c_ = [
            b_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? d_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithInpatientStay)
        {
            IEnumerable<Claim> h_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> p_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? q_(Claim c)
                    {
                        List<Claim.ItemComponent> s_ = c?.Item;
                        bool? t_(Claim.ItemComponent i)
                        {
                            CodeableConcept w_ = i?.Revenue;
                            CqlConcept x_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, w_);
                            CqlCode[] y_ = x_?.codes;
                            bool? z_(CqlCode rev)
                            {
                                string ac_ = rev?.code;
                                CqlValueSet ad_ = this.Inpatient_Stay(context);
                                bool? ae_ = context.Operators.StringInValueSet(ac_, ad_);

                                return ae_;
                            };
                            IEnumerable<CqlCode> aa_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)y_, z_);
                            bool? ab_ = context.Operators.Exists<CqlCode>(aa_);

                            return ab_;
                        };
                        IEnumerable<Claim.ItemComponent> u_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)s_, t_);
                        bool? v_ = context.Operators.Exists<Claim.ItemComponent>(u_);

                        return v_;
                    };
                    IEnumerable<Claim> r_ = context.Operators.Where<Claim>(p_, q_);

                    return r_;
                }
            };
            IEnumerable<Claim> i_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> af_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? ag_(Claim c)
                    {
                        List<Claim.ItemComponent> ai_ = c?.Item;
                        bool? aj_(Claim.ItemComponent i)
                        {
                            CodeableConcept as_ = i?.Revenue;
                            CqlConcept at_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, as_);
                            CqlCode[] au_ = at_?.codes;
                            bool? av_(CqlCode rev)
                            {
                                string ay_ = rev?.code;
                                CqlValueSet az_ = this.Nonacute_Inpatient_Stay(context);
                                bool? ba_ = context.Operators.StringInValueSet(ay_, az_);

                                return ba_;
                            };
                            IEnumerable<CqlCode> aw_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)au_, av_);
                            bool? ax_ = context.Operators.Exists<CqlCode>(aw_);

                            return ax_;
                        };
                        IEnumerable<Claim.ItemComponent> ak_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ai_, aj_);
                        bool? al_ = context.Operators.Exists<Claim.ItemComponent>(ak_);
                        CodeableConcept am_ = c?.SubType;
                        List<Coding> an_ = am_?.Coding;
                        bool? ao_(Coding tob)
                        {
                            Code bb_ = tob?.CodeElement;
                            string bc_ = bb_?.Value;
                            CqlValueSet bd_ = this.Nonacute_Inpatient_Stay(context);
                            bool? be_ = context.Operators.StringInValueSet(bc_, bd_);

                            return be_;
                        };
                        IEnumerable<Coding> ap_ = context.Operators.Where<Coding>((IEnumerable<Coding>)an_, ao_);
                        bool? aq_ = context.Operators.Exists<Coding>(ap_);
                        bool? ar_ = context.Operators.Or(al_, aq_);

                        return ar_;
                    };
                    IEnumerable<Claim> ah_ = context.Operators.Where<Claim>(af_, ag_);

                    return ah_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? j_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, h_(), i_());
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] k_ = [
                j_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? l_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> bf_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> bg_ = LineItemDefinition?.NonacuteInpatientLineItems;
                IEnumerable<Claim> bh_(Claim nonAcuteInpatientStay)
                {
                    IEnumerable<Claim> bp_ = LineItemDefinition?.InpatientStayLineItems;
                    bool? bq_(Claim inpatientStay)
                    {
                        Id bu_ = nonAcuteInpatientStay?.IdElement;
                        Id bv_ = inpatientStay?.IdElement;
                        bool? bw_ = context.Operators.Equal(bu_, bv_);

                        return bw_;
                    };
                    IEnumerable<Claim> br_ = context.Operators.Where<Claim>(bp_, bq_);
                    Claim bs_(Claim inpatientStay) =>
                        nonAcuteInpatientStay;
                    IEnumerable<Claim> bt_ = context.Operators.Select<Claim, Claim>(br_, bs_);

                    return bt_;
                };
                IEnumerable<Claim> bi_ = context.Operators.SelectMany<Claim, Claim>(bg_, bh_);
                IEnumerable<Claim> bl_(Claim inpatientStay)
                {
                    IEnumerable<Claim> bx_ = LineItemDefinition?.NonacuteInpatientLineItems;
                    bool? by_(Claim nonAcuteInpatientStay)
                    {
                        Id cc_ = inpatientStay?.IdElement;
                        Id cd_ = nonAcuteInpatientStay?.IdElement;
                        bool? ce_ = context.Operators.Equal(cc_, cd_);

                        return ce_;
                    };
                    IEnumerable<Claim> bz_ = context.Operators.Where<Claim>(bx_, by_);
                    Claim ca_(Claim nonAcuteInpatientStay) =>
                        inpatientStay;
                    IEnumerable<Claim> cb_ = context.Operators.Select<Claim, Claim>(bz_, ca_);

                    return cb_;
                };
                IEnumerable<Claim> bm_ = context.Operators.SelectMany<Claim, Claim>(bf_, bl_);
                IEnumerable<Claim> bn_ = context.Operators.Except<Claim>(bf_, bm_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bo_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, bf_, bi_, bn_);

                return bo_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> m_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)k_, l_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> n_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(m_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(n_);

            return o_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> e_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)c_, d_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> f_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(e_);
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(f_);

        return g_;
    }


    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? a_(Claim C)
        {
            List<Claim.CareTeamComponent> j_ = C?.CareTeam;
            bool? k_(Claim.CareTeamComponent ct)
            {
                PositiveInt aa_ = ct?.SequenceElement;
                Integer ab_ = context.Operators.Convert<Integer>(aa_);
                int? ac_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ab_);
                bool? ad_ = context.Operators.Equal(ac_, 1);

                return ad_;
            };
            IEnumerable<Claim.CareTeamComponent> l_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)j_, k_);
            bool? m_(Claim.CareTeamComponent @this)
            {
                ResourceReference ae_ = @this?.Provider;
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));

                return af_;
            };
            IEnumerable<Claim.CareTeamComponent> n_ = context.Operators.Where<Claim.CareTeamComponent>(l_, m_);
            ResourceReference o_(Claim.CareTeamComponent @this)
            {
                ResourceReference ag_ = @this?.Provider;

                return ag_;
            };
            IEnumerable<ResourceReference> p_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(n_, o_);
            bool? r_(Claim.CareTeamComponent ct)
            {
                PositiveInt ah_ = ct?.SequenceElement;
                Integer ai_ = context.Operators.Convert<Integer>(ah_);
                int? aj_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ai_);
                bool? ak_ = context.Operators.Equal(aj_, 1);

                return ak_;
            };
            IEnumerable<Claim.CareTeamComponent> s_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)j_, r_);
            bool? t_(Claim.CareTeamComponent @this)
            {
                ResourceReference al_ = @this?.Provider;
                bool? am_ = context.Operators.Not((bool?)(al_ is null));

                return am_;
            };
            IEnumerable<Claim.CareTeamComponent> u_ = context.Operators.Where<Claim.CareTeamComponent>(s_, t_);
            ResourceReference v_(Claim.CareTeamComponent @this)
            {
                ResourceReference an_ = @this?.Provider;

                return an_;
            };
            IEnumerable<ResourceReference> w_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(u_, v_);
            string x_(ResourceReference p)
            {
                FhirString ao_ = p?.ReferenceElement;
                FhirString[] ap_ = [
                    ao_,
                ];
                string aq_(FhirString r)
                {
                    string at_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string au_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, at_);

                    return au_;
                };
                IEnumerable<string> ar_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)ap_, aq_);
                string as_ = context.Operators.SingletonFrom<string>(ar_);

                return as_;
            };
            IEnumerable<string> y_ = context.Operators.Select<ResourceReference, string>(w_, x_);
            (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? z_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, p_, y_);

            return z_;
        };
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> b_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, a_);
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> c_ = context.Operators.Distinct<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? d_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?[] e_ = [
            d_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? f_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ClaimProperties)
        {
            IEnumerable<Practitioner> av_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));
            bool? aw_(Practitioner p)
            {
                Id be_ = p?.IdElement;
                string bf_ = FHIRHelpers_4_0_001.Instance.ToString(context, be_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> bg_ = ClaimProperties?.CareTeams;
                bool? bh_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> bn_ = @this?.CareTeamsProviderID;
                    bool? bo_ = context.Operators.Not((bool?)(bn_ is null));

                    return bo_;
                };
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> bi_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(bg_, bh_);
                IEnumerable<string> bj_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> bp_ = @this?.CareTeamsProviderID;

                    return bp_;
                };
                IEnumerable<IEnumerable<string>> bk_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(bi_, bj_);
                IEnumerable<string> bl_ = context.Operators.Flatten<string>(bk_);
                bool? bm_ = context.Operators.In<string>(bf_, bl_);

                return bm_;
            };
            IEnumerable<Practitioner> ax_ = context.Operators.Where<Practitioner>(av_, aw_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? ay_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, ax_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?[] az_ = [
                ay_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? ba_((CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? PractitionerMatch)
            {
                IEnumerable<Practitioner> bq_ = PractitionerMatch?.Practitioners;
                bool? br_(Practitioner P)
                {
                    bool? cb_ = context.Operators.Not((bool?)(P is null));

                    return cb_;
                };
                IEnumerable<Practitioner> bs_ = context.Operators.Where<Practitioner>(bq_, br_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bt_(Practitioner P)
                {
                    List<Identifier> cc_ = P?.Identifier;
                    bool? cd_(Identifier l)
                    {
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
                    };
                    IEnumerable<Identifier> ce_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cc_, cd_);
                    FhirString cf_(Identifier l)
                    {
                        FhirString db_ = l?.ValueElement;

                        return db_;
                    };
                    IEnumerable<FhirString> cg_ = context.Operators.Select<Identifier, FhirString>(ce_, cf_);
                    IEnumerable<FhirString> ch_ = context.Operators.Distinct<FhirString>(cg_);
                    bool? cj_(Identifier l)
                    {
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
                    };
                    IEnumerable<Identifier> ck_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cc_, cj_);
                    Identifier cl_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> cm_ = context.Operators.Select<Identifier, Identifier>(ck_, cl_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? cn_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, ch_, cm_);

                    return cn_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> bu_ = context.Operators.Select<Practitioner, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bs_, bt_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? bv_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, bu_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] bw_ = [
                    bv_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? bx_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? do_()
                    {
                        bool dq_()
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> dr_ = ClaimProperties?.CareTeams;
                            bool? ds_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim dx_ = @this?.SingleCareTeam;
                                bool? dy_ = context.Operators.Not((bool?)(dx_ is null));

                                return dy_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> dt_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(dr_, ds_);
                            Claim du_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim dz_ = @this?.SingleCareTeam;

                                return dz_;
                            };
                            IEnumerable<Claim> dv_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(dt_, du_);
                            bool? dw_ = context.Operators.Exists<Claim>(dv_);

                            return dw_ ?? false;
                        };
                        if (dq_())
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ea_ = ClaimProperties?.CareTeams;
                            bool? eb_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim ex_ = @this?.SingleCareTeam;
                                bool? ey_ = context.Operators.Not((bool?)(ex_ is null));

                                return ey_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ec_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(ea_, eb_);
                            Claim ed_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim ez_ = @this?.SingleCareTeam;

                                return ez_;
                            };
                            IEnumerable<Claim> ee_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(ec_, ed_);
                            bool? ef_(Claim X)
                            {
                                List<Claim.CareTeamComponent> fa_ = X?.CareTeam;

                                return (bool?)(((IEnumerable<Claim.CareTeamComponent>)fa_) is null);
                            };
                            IEnumerable<Claim> eg_ = context.Operators.Where<Claim>(ee_, ef_);
                            int? eh_ = context.Operators.Count<Claim>(eg_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> ei_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> ej_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> fb_ = X?.AllIdentifiers;

                                return fb_;
                            };
                            IEnumerable<IEnumerable<FhirString>> ek_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(ei_, ej_);
                            IEnumerable<FhirString> el_ = context.Operators.Flatten<FhirString>(ek_);
                            FhirString em_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> en_ = context.Operators.Select<FhirString, FhirString>(el_, em_);
                            IEnumerable<FhirString> eo_ = context.Operators.Distinct<FhirString>(en_);
                            int? ep_ = context.Operators.Count<FhirString>(eo_);
                            int? eq_ = context.Operators.Add(eh_, ep_);
                            IEnumerable<Identifier> es_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> fc_ = X?.NullIdentifiers;

                                return fc_;
                            };
                            IEnumerable<IEnumerable<Identifier>> et_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(ei_, es_);
                            IEnumerable<Identifier> eu_ = context.Operators.Flatten<Identifier>(et_);
                            int? ev_ = context.Operators.Count<Identifier>(eu_);
                            int? ew_ = context.Operators.Add(eq_, ev_);

                            return ew_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? dp_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, do_());

                    return dp_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> by_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)bw_, bx_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bz_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(by_);
                (CqlTupleMetadata, int? IdentifierCount)? ca_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bz_);

                return ca_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?>)az_, ba_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bc_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(bb_);
            (CqlTupleMetadata, int? IdentifierCount)? bd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bc_);

            return bd_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> g_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?>)e_, f_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(g_);
        (CqlTupleMetadata, int? IdentifierCount)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(h_);

        return i_;
    }


    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? a_(Claim C)
        {
            List<Claim.ItemComponent> j_ = C?.Item;
            bool? l_(Claim.ItemComponent i)
            {
                PositiveInt ad_ = i?.SequenceElement;
                Integer ae_ = context.Operators.Convert<Integer>(ad_);
                int? af_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ae_);
                bool? ag_ = context.Operators.Equal(af_, 1);

                return ag_;
            };
            IEnumerable<Claim.ItemComponent> m_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)j_, l_);
            bool? n_(Claim.ItemComponent @this)
            {
                DataType ah_ = @this?.Location;
                bool? ai_ = context.Operators.Not((bool?)(ah_ is null));

                return ai_;
            };
            IEnumerable<Claim.ItemComponent> o_ = context.Operators.Where<Claim.ItemComponent>(m_, n_);
            object p_(Claim.ItemComponent @this)
            {
                DataType aj_ = @this?.Location;

                return aj_;
            };
            IEnumerable<object> q_ = context.Operators.Select<Claim.ItemComponent, object>(o_, p_);
            ResourceReference r_(object l) =>
                l as ResourceReference;
            IEnumerable<ResourceReference> s_ = context.Operators.Select<object, ResourceReference>(q_, r_);
            bool? u_(Claim.ItemComponent i)
            {
                PositiveInt ak_ = i?.SequenceElement;
                Integer al_ = context.Operators.Convert<Integer>(ak_);
                int? am_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, al_);
                bool? an_ = context.Operators.Equal(am_, 1);

                return an_;
            };
            IEnumerable<Claim.ItemComponent> v_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)j_, u_);
            bool? w_(Claim.ItemComponent @this)
            {
                DataType ao_ = @this?.Location;
                bool? ap_ = context.Operators.Not((bool?)(ao_ is null));

                return ap_;
            };
            IEnumerable<Claim.ItemComponent> x_ = context.Operators.Where<Claim.ItemComponent>(v_, w_);
            object y_(Claim.ItemComponent @this)
            {
                DataType aq_ = @this?.Location;

                return aq_;
            };
            IEnumerable<object> z_ = context.Operators.Select<Claim.ItemComponent, object>(x_, y_);
            string aa_(object l)
            {
                FhirString ar_ = (l as ResourceReference)?.ReferenceElement;
                FhirString[] as_ = [
                    ar_,
                ];
                string at_(FhirString r)
                {
                    string aw_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string ax_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, aw_);

                    return ax_;
                };
                IEnumerable<string> au_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)as_, at_);
                string av_ = context.Operators.SingletonFrom<string>(au_);

                return av_;
            };
            IEnumerable<string> ab_ = context.Operators.Select<object, string>(z_, aa_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? ac_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent>)j_, s_, ab_);

            return ac_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> b_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, a_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> c_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? d_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?[] e_ = [
            d_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? f_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? ClaimProperties)
        {
            IEnumerable<Location> ay_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
            bool? az_(Location l)
            {
                Id bh_ = l?.IdElement;
                string bi_ = FHIRHelpers_4_0_001.Instance.ToString(context, bh_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> bj_ = ClaimProperties?.ItemsLocationReferences;
                bool? bk_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> bq_ = @this?.ItemLocationID;
                    bool? br_ = context.Operators.Not((bool?)(bq_ is null));

                    return br_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> bl_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(bj_, bk_);
                IEnumerable<string> bm_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> bs_ = @this?.ItemLocationID;

                    return bs_;
                };
                IEnumerable<IEnumerable<string>> bn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(bl_, bm_);
                IEnumerable<string> bo_ = context.Operators.Flatten<string>(bn_);
                bool? bp_ = context.Operators.In<string>(bi_, bo_);

                return bp_;
            };
            IEnumerable<Location> ba_ = context.Operators.Where<Location>(ay_, az_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? bb_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, ba_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?[] bc_ = [
                bb_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? bd_((CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? GetLocation)
            {
                IEnumerable<Location> bt_ = GetLocation?.CorrespondingLocations;
                bool? bu_(Location C)
                {
                    bool? ce_ = context.Operators.Not((bool?)(C is null));

                    return ce_;
                };
                IEnumerable<Location> bv_ = context.Operators.Where<Location>(bt_, bu_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bw_(Location C)
                {
                    List<Identifier> cf_ = C?.Identifier;
                    bool? cg_(Identifier l)
                    {
                        FhirUri cr_ = l?.SystemElement;
                        string cs_ = cr_?.Value;
                        bool? ct_ = context.Operators.Equal(cs_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept cu_ = l?.Type;
                        CqlConcept cv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cu_);
                        CqlCode cw_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept cx_ = context.Operators.ConvertCodeToConcept(cw_);
                        bool? cy_ = context.Operators.Equivalent(cv_, cx_);
                        bool? cz_ = context.Operators.And(ct_, cy_);
                        FhirString da_ = l?.ValueElement;
                        string db_ = da_?.Value;
                        bool? dc_ = context.Operators.Not((bool?)(db_ is null));
                        bool? dd_ = context.Operators.And(cz_, dc_);

                        return dd_;
                    };
                    IEnumerable<Identifier> ch_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cf_, cg_);
                    FhirString ci_(Identifier l)
                    {
                        FhirString de_ = l?.ValueElement;

                        return de_;
                    };
                    IEnumerable<FhirString> cj_ = context.Operators.Select<Identifier, FhirString>(ch_, ci_);
                    IEnumerable<FhirString> ck_ = context.Operators.Distinct<FhirString>(cj_);
                    bool? cm_(Identifier l)
                    {
                        FhirUri df_ = l?.SystemElement;
                        string dg_ = df_?.Value;
                        bool? dh_ = context.Operators.Equal(dg_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept di_ = l?.Type;
                        CqlConcept dj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, di_);
                        CqlCode dk_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept dl_ = context.Operators.ConvertCodeToConcept(dk_);
                        bool? dm_ = context.Operators.Equivalent(dj_, dl_);
                        bool? dn_ = context.Operators.And(dh_, dm_);
                        FhirString do_ = l?.ValueElement;
                        string dp_ = do_?.Value;
                        bool? dq_ = context.Operators.And(dn_, (bool?)(dp_ is null));

                        return dq_;
                    };
                    IEnumerable<Identifier> cn_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)cf_, cm_);
                    Identifier co_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> cp_ = context.Operators.Select<Identifier, Identifier>(cn_, co_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? cq_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, ck_, cp_);

                    return cq_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> bx_ = context.Operators.Select<Location, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bv_, bw_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? by_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, bx_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] bz_ = [
                    by_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? ca_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? dr_()
                    {
                        bool dt_()
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> du_ = ClaimProperties?.ItemsLocationReferences;
                            bool? dv_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> eb_ = @this?.SingleItem;
                                bool? ec_ = context.Operators.Not((bool?)(eb_ is null));

                                return ec_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> dw_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(du_, dv_);
                            IEnumerable<Claim.ItemComponent> dx_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> ed_ = @this?.SingleItem;

                                return ed_;
                            };
                            IEnumerable<IEnumerable<Claim.ItemComponent>> dy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(dw_, dx_);
                            IEnumerable<Claim.ItemComponent> dz_ = context.Operators.Flatten<Claim.ItemComponent>(dy_);
                            bool? ea_ = context.Operators.Exists<Claim.ItemComponent>(dz_);

                            return ea_ ?? false;
                        };
                        if (dt_())
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ee_ = ClaimProperties?.ItemsLocationReferences;
                            bool? ef_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> fc_ = @this?.ItemLocation;
                                bool? fd_ = context.Operators.Not((bool?)(fc_ is null));

                                return fd_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> eg_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(ee_, ef_);
                            IEnumerable<ResourceReference> eh_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> fe_ = @this?.ItemLocation;

                                return fe_;
                            };
                            IEnumerable<IEnumerable<ResourceReference>> ei_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(eg_, eh_);
                            IEnumerable<ResourceReference> ej_ = context.Operators.Flatten<ResourceReference>(ei_);
                            bool? ek_(ResourceReference X)
                            {
                                FhirString ff_ = X?.ReferenceElement;
                                string fg_ = ff_?.Value;

                                return (bool?)(fg_ is null);
                            };
                            IEnumerable<ResourceReference> el_ = context.Operators.Where<ResourceReference>(ej_, ek_);
                            int? em_ = context.Operators.Count<ResourceReference>(el_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> en_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> eo_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> fh_ = X?.AllIdentifiers;

                                return fh_;
                            };
                            IEnumerable<IEnumerable<FhirString>> ep_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(en_, eo_);
                            IEnumerable<FhirString> eq_ = context.Operators.Flatten<FhirString>(ep_);
                            FhirString er_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> es_ = context.Operators.Select<FhirString, FhirString>(eq_, er_);
                            IEnumerable<FhirString> et_ = context.Operators.Distinct<FhirString>(es_);
                            int? eu_ = context.Operators.Count<FhirString>(et_);
                            int? ev_ = context.Operators.Add(em_, eu_);
                            IEnumerable<Identifier> ex_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> fi_ = X?.NullIdentifiers;

                                return fi_;
                            };
                            IEnumerable<IEnumerable<Identifier>> ey_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(en_, ex_);
                            IEnumerable<Identifier> ez_ = context.Operators.Flatten<Identifier>(ey_);
                            int? fa_ = context.Operators.Count<Identifier>(ez_);
                            int? fb_ = context.Operators.Add(ev_, fa_);

                            return fb_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? ds_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, dr_());

                    return ds_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> cb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)bz_, ca_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> cc_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(cb_);
                (CqlTupleMetadata, int? IdentifierCount)? cd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(cc_);

                return cd_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> be_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?>)bc_, bd_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bf_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(be_);
            (CqlTupleMetadata, int? IdentifierCount)? bg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bf_);

            return bg_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> g_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?>)e_, f_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> h_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(g_);
        (CqlTupleMetadata, int? IdentifierCount)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(h_);

        return i_;
    }


    #endregion Definition Methods

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
