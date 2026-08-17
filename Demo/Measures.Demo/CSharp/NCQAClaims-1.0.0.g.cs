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
            // CQL 'or' (14:5-16:5): right operand skipped when left is true
            if (g_ is true)
            {
                return true;
            }
            else
            {
                CqlCode h_ = NCQATerminology_1_0_0.Instance.Institutional(context);
                bool? i_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, h_);
                return g_ | i_;
            }
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
            // CQL 'or' (24:5-26:5): right operand skipped when left is true
            if (g_ is true)
            {
                return true;
            }
            else
            {
                CqlCode h_ = NCQATerminology_1_0_0.Instance.Institutional(context);
                bool? i_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, h_);
                return g_ | i_;
            }
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
            string k_ = p?.code;
            return k_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<CqlCode, string>(ProductOrServiceValueSet, b_);

        string d_(CqlCode pos) {
            string l_ = pos?.code;
            return l_;
        }

        IEnumerable<string> e_ = context.Operators.SelectDistinct<CqlCode, string>(posCodes, d_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? f_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, a_, c_, e_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] g_ = [
            f_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode) {
            IEnumerable<Claim> m_ = ClaimWithPosCode?.MedicalClaim;

            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? n_(Claim ClaimofInterest) {
                IEnumerable<Claim.ItemComponent> r_;
                if (ClaimofInterest is null)
                {
                    r_ = null as IEnumerable<Claim.ItemComponent>;
                }
                else
                {
                    List<Claim.ItemComponent> x_ = ClaimofInterest?.Item;

                    bool? y_(Claim.ItemComponent ItemOnLine) {
                        CodeableConcept aa_ = ItemOnLine?.ProductOrService;
                        CqlConcept ab_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aa_);
                        IReadOnlyList<CqlCode> ac_ = ab_?.codes;

                        bool? ad_(CqlCode LineCode) {
                            string af_ = LineCode?.code;
                            IEnumerable<string> ag_ = ClaimWithPosCode?.ProceduresAsStrings;
                            bool? ah_ = context.Operators.In<string>(af_, ag_);
                            return ah_;
                        }

                        bool? ae_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)ac_, ad_);
                        // CQL 'and' (45:11-51:11): right operand skipped when left is false
                        if (ae_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            DataType ai_ = ItemOnLine?.Location;
                            CqlConcept aj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ai_ as CodeableConcept);
                            IReadOnlyList<CqlCode> ak_ = aj_?.codes;

                            bool? al_(CqlCode PosCode) {
                                string an_ = PosCode?.code;
                                IEnumerable<string> ao_ = ClaimWithPosCode?.POSAsString;
                                bool? ap_ = context.Operators.In<string>(an_, ao_);
                                return ap_;
                            }

                            bool? am_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)ak_, al_);
                            return ae_ & am_;
                        }
                    }

                    IEnumerable<Claim.ItemComponent> z_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);
                    r_ = z_;
                }
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? s_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, r_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] t_ = [
                    s_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition) {
                    IEnumerable<Claim.ItemComponent> aq_ = LineItemDefinition?.LineItems;
                    bool? ar_ = context.Operators.Exists<Claim.ItemComponent>(aq_);
                    if (ar_ ?? false)
                    {
                        Claim as_ = LineItemDefinition?.Claim;
                        IEnumerable<Claim.ItemComponent> at_ = LineItemDefinition?.LineItems;

                        bool? au_(Claim.ItemComponent @this) {
                            DataType ba_ = @this?.Serviced;
                            return !((bool?)(ba_ is null));
                        }


                        object av_(Claim.ItemComponent @this) {
                            DataType bb_ = @this?.Serviced;
                            return bb_;
                        }

                        IEnumerable<object> aw_ = context.Operators.WhereSelect<Claim.ItemComponent, object>(at_, au_, av_);

                        CqlInterval<CqlDateTime> ax_(object NormalDate) {
                            CqlInterval<CqlDateTime> bc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                            return bc_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(aw_, ax_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, as_, ay_);
                        return az_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> v_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)t_, u_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? w_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(v_);
                return w_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(m_, n_);
            bool? p_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(o_, p_);
            return q_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)g_, h_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode p) {
            string i_ = p?.code;
            return i_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<CqlCode, string>(ProductOrServiceValueSet, b_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)? d_ = (CqlTupleMetadata_FOGIeViDYfJOhRYAGIOCbEeNO, a_, c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)?[] e_ = [
            d_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure) {
            IEnumerable<Claim> j_ = ClaimWithProcedure?.MedicalClaim;

            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? k_(Claim ClaimofInterest) {
                IEnumerable<Claim.ItemComponent> o_;
                if (ClaimofInterest is null)
                {
                    o_ = null as IEnumerable<Claim.ItemComponent>;
                }
                else
                {
                    List<Claim.ItemComponent> u_ = ClaimofInterest?.Item;

                    bool? v_(Claim.ItemComponent ItemOnLine) {
                        CodeableConcept x_ = ItemOnLine?.ProductOrService;
                        CqlConcept y_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, x_);
                        IReadOnlyList<CqlCode> z_ = y_?.codes;

                        bool? aa_(CqlCode LineCode) {
                            string ac_ = LineCode?.code;
                            IEnumerable<string> ad_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? ae_ = context.Operators.In<string>(ac_, ad_);
                            return ae_;
                        }

                        bool? ab_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)z_, aa_);
                        // CQL 'or' (74:11-79:13): right operand skipped when left is true
                        if (ab_ is true)
                        {
                            return true;
                        }
                        else
                        {
                            List<Claim.ProcedureComponent> af_ = ClaimofInterest?.Procedure;

                            bool? ag_(Claim.ProcedureComponent @this) {
                                DataType ar_ = @this?.Procedure;
                                return !((bool?)(ar_ is null));
                            }


                            object ah_(Claim.ProcedureComponent @this) {
                                DataType as_ = @this?.Procedure;
                                return as_;
                            }

                            IEnumerable<object> ai_ = context.Operators.WhereSelect<Claim.ProcedureComponent, object>((IEnumerable<Claim.ProcedureComponent>)af_, ag_, ah_);

                            bool? aj_(object @this) {
                                object at_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return !((bool?)(at_ is null));
                            }


                            object ak_(object @this) {
                                object au_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return au_;
                            }

                            IEnumerable<object> al_ = context.Operators.WhereSelect<object, object>(ai_, aj_, ak_);
                            IEnumerable<object> am_ = context.Operators.FlattenLateBoundList(al_);
                            Coding an_(object @object) => (Coding)@object;

                            bool? ao_(Coding HeaderCode) {
                                Code av_ = HeaderCode?.CodeElement;
                                string aw_ = av_?.Value;
                                IEnumerable<string> ax_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? ay_ = context.Operators.In<string>(aw_, ax_);
                                return ay_;
                            }

                            IEnumerable<Coding> ap_ = context.Operators.SelectWhere<object, Coding>(am_, an_, ao_);
                            bool? aq_ = context.Operators.Exists<Coding>(ap_);
                            return ab_ | aq_;
                        }
                    }

                    IEnumerable<Claim.ItemComponent> w_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)u_, v_);
                    o_ = w_;
                }
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? p_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, o_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] q_ = [
                    p_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition) {
                    IEnumerable<Claim.ItemComponent> az_ = LineItemDefinition?.LineItems;
                    bool? ba_ = context.Operators.Exists<Claim.ItemComponent>(az_);
                    if (ba_ ?? false)
                    {
                        Claim bb_ = LineItemDefinition?.Claim;
                        IEnumerable<Claim.ItemComponent> bc_ = LineItemDefinition?.LineItems;

                        bool? bd_(Claim.ItemComponent @this) {
                            DataType bj_ = @this?.Serviced;
                            return !((bool?)(bj_ is null));
                        }


                        object be_(Claim.ItemComponent @this) {
                            DataType bk_ = @this?.Serviced;
                            return bk_;
                        }

                        IEnumerable<object> bf_ = context.Operators.WhereSelect<Claim.ItemComponent, object>(bc_, bd_, be_);

                        CqlInterval<CqlDateTime> bg_(object NormalDate) {
                            CqlInterval<CqlDateTime> bl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                            return bl_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> bh_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(bf_, bg_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bi_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, bb_, bh_);
                        return bi_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> s_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)q_, r_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? t_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(s_);
                return t_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> l_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(j_, k_);
            bool? m_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(l_, m_);
            return n_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings)?>)e_, f_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Medical Claims With Diagnosis")]
    public (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode d) {
            string i_ = d?.code;
            return i_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<CqlCode, string>(DiagnosisValueSet, b_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? d_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, a_, c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? f_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim> j_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                j_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> p_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? q_(Claim DiagnosisLine) {
                    List<Claim.DiagnosisComponent> s_ = DiagnosisLine?.Diagnosis;

                    bool? t_(Claim.DiagnosisComponent @this) {
                        DataType ae_ = @this?.Diagnosis;
                        return !((bool?)(ae_ is null));
                    }


                    object u_(Claim.DiagnosisComponent @this) {
                        DataType af_ = @this?.Diagnosis;
                        return af_;
                    }

                    IEnumerable<object> v_ = context.Operators.WhereSelect<Claim.DiagnosisComponent, object>((IEnumerable<Claim.DiagnosisComponent>)s_, t_, u_);

                    bool? w_(object @this) {
                        object ag_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                        return !((bool?)(ag_ is null));
                    }


                    object x_(object @this) {
                        object ah_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                        return ah_;
                    }

                    IEnumerable<object> y_ = context.Operators.WhereSelect<object, object>(v_, w_, x_);
                    IEnumerable<object> z_ = context.Operators.FlattenLateBoundList(y_);
                    Coding aa_(object @object) => (Coding)@object;

                    bool? ab_(Coding HeaderCode) {
                        Code ai_ = HeaderCode?.CodeElement;
                        string aj_ = ai_?.Value;
                        IEnumerable<string> ak_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                        bool? al_ = context.Operators.In<string>(aj_, ak_);
                        return al_;
                    }

                    IEnumerable<Coding> ac_ = context.Operators.SelectWhere<object, Coding>(z_, aa_, ab_);
                    bool? ad_ = context.Operators.Exists<Coding>(ac_);
                    return ad_;
                }

                IEnumerable<Claim> r_ = context.Operators.Where<Claim>(p_, q_);
                j_ = r_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? k_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, j_);
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? HeaderDefinition) {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? am_;
                IEnumerable<Claim> ar_ = HeaderDefinition?.DiagnosisItems;
                bool? as_ = context.Operators.Exists<Claim>(ar_);
                if (as_ ?? false)
                {
                    IEnumerable<Claim> at_ = HeaderDefinition?.DiagnosisItems;

                    bool? au_(Claim @this) {
                        List<Claim.ItemComponent> bb_ = @this?.Item;
                        return !((bool?)(bb_ is null));
                    }


                    List<Claim.ItemComponent> av_(Claim @this) {
                        List<Claim.ItemComponent> bc_ = @this?.Item;
                        return bc_;
                    }

                    IEnumerable<List<Claim.ItemComponent>> aw_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(at_, au_, av_);
                    IEnumerable<Claim.ItemComponent> ax_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)aw_);

                    CqlInterval<CqlDateTime> ay_(Claim.ItemComponent NormalDate) {
                        DataType bd_ = NormalDate?.Serviced;
                        CqlInterval<CqlDateTime> be_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bd_);
                        return be_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> az_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(ax_, ay_);
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ba_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, at_, az_);
                    am_ = ba_;
                }
                else
                {
                    am_ = null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] an_ = [
                    am_,
                ];
                bool? ao_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ap_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)an_, ao_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? aq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ap_);
                return aq_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)l_, m_);
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)e_, f_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Pharmacy Claim With Medication")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        IEnumerable<Claim> a_ = this.Pharmacy_Claims(context, claim);

        string b_(CqlCode p) {
            string i_ = p?.code;
            return i_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<CqlCode, string>(MedicationCodes, b_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? d_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, a_, c_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] e_ = [
            d_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> f_((CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication) {
            IEnumerable<Claim> j_ = ClaimWithMedication?.PharmacyClaim;

            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? k_(Claim Pharmacy) {
                List<Claim.ItemComponent> n_ = Pharmacy?.Item;

                bool? o_(Claim.ItemComponent ItemOnLine) {
                    CodeableConcept v_ = ItemOnLine?.ProductOrService;
                    CqlConcept w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, v_);
                    IReadOnlyList<CqlCode> x_ = w_?.codes;

                    bool? y_(CqlCode LineCode) {
                        string aa_ = LineCode?.code;
                        IEnumerable<string> ab_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? ac_ = context.Operators.In<string>(aa_, ab_);
                        return ac_;
                    }

                    bool? z_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)x_, y_);
                    return z_;
                }

                IEnumerable<Claim.ItemComponent> p_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)n_, o_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? q_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, p_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] r_ = [
                    q_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? s_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition) {
                    Claim ad_ = LineItemDefinition?.Claim;
                    Claim[] ae_ = [
                        ad_,
                    ];

                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? af_(Claim ClaimLines) {
                        List<Claim.ItemComponent> ai_ = ClaimLines?.Item;

                        bool? aj_(Claim.ItemComponent i) {
                            CodeableConcept ar_ = i?.ProductOrService;
                            CqlConcept as_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ar_);
                            IReadOnlyList<CqlCode> at_ = as_?.codes;

                            bool? au_(CqlCode LineCode) {
                                string aw_ = LineCode?.code;
                                IEnumerable<string> ax_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? ay_ = context.Operators.In<string>(aw_, ax_);
                                return ay_;
                            }

                            bool? av_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)at_, au_);
                            return av_;
                        }


                        (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? ak_(Claim.ItemComponent i) {
                            CqlInterval<CqlDateTime> az_;
                            if ((!((bool?)(i?.Quantity is null))) ?? false)
                            {
                                CqlInterval<CqlDateTime> bb_;
                                DataType bc_ = i?.Serviced;
                                bool bd_ = bc_ is Period;
                                if (bd_)
                                {
                                    DataType be_ = i?.Serviced;
                                    CqlInterval<CqlDateTime> bf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, be_);
                                    CqlDateTime bg_ = context.Operators.Start(bf_);
                                    Quantity bh_ = i?.Quantity;
                                    FhirDecimal bi_ = bh_?.ValueElement;
                                    decimal? bj_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bi_);
                                    CqlDateTime bk_ = context.Operators.Add(bg_, new CqlQuantity(bj_, "day"));
                                    CqlQuantity bl_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime bm_ = context.Operators.Subtract(bk_, bl_);
                                    CqlInterval<CqlDateTime> bn_ = context.Operators.Interval(bg_, bm_, true, true);
                                    bb_ = bn_;
                                }
                                else
                                {
                                    DataType bo_ = i?.Serviced;
                                    CqlDate bp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bo_ as Date);
                                    CqlDateTime bq_ = context.Operators.ConvertDateToDateTime(bp_);
                                    Quantity br_ = i?.Quantity;
                                    FhirDecimal bs_ = br_?.ValueElement;
                                    decimal? bt_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bs_);
                                    CqlDate bu_ = context.Operators.Add(bp_, new CqlQuantity(bt_, "day"));
                                    CqlQuantity bv_ = context.Operators.Quantity(1m, "day");
                                    CqlDate bw_ = context.Operators.Subtract(bu_, bv_);
                                    CqlDateTime bx_ = context.Operators.ConvertDateToDateTime(bw_);
                                    CqlInterval<CqlDateTime> by_ = context.Operators.Interval(bq_, bx_, true, true);
                                    bb_ = by_;
                                }
                                az_ = bb_;
                            }
                            else
                            {
                                az_ = null as CqlInterval<CqlDateTime>;
                            }
                            (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? ba_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, az_);
                            return ba_;
                        }

                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> al_ = context.Operators.WhereSelect<Claim.ItemComponent, (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>((IEnumerable<Claim.ItemComponent>)ai_, aj_, ak_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? am_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, al_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?[] an_ = [
                            am_,
                        ];

                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ao_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? ItemCalculation) {
                            IEnumerable<Claim.ItemComponent> bz_ = LineItemDefinition?.LineItems;
                            bool? ca_ = context.Operators.Exists<Claim.ItemComponent>(bz_);
                            if (ca_ ?? false)
                            {
                                Claim cb_ = LineItemDefinition?.Claim;
                                IEnumerable<Claim.ItemComponent> cc_ = LineItemDefinition?.LineItems;

                                bool? cd_(Claim.ItemComponent @this) {
                                    DataType cm_ = @this?.Serviced;
                                    return !((bool?)(cm_ is null));
                                }


                                object ce_(Claim.ItemComponent @this) {
                                    DataType cn_ = @this?.Serviced;
                                    return cn_;
                                }

                                IEnumerable<object> cf_ = context.Operators.WhereSelect<Claim.ItemComponent, object>(cc_, cd_, ce_);

                                CqlInterval<CqlDateTime> cg_(object NormalDate) {
                                    CqlInterval<CqlDateTime> co_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                                    return co_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> ch_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(cf_, cg_);
                                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> ci_ = ItemCalculation?.CoveredDays;

                                CqlInterval<CqlDateTime> cj_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d) {
                                    CqlInterval<CqlDateTime> cp_ = d?.DaysSupplyInterval;
                                    return cp_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> ck_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(ci_, cj_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? cl_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, cb_, cc_, ch_, ck_);
                                return cl_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ap_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?>)an_, ao_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? aq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(ap_);
                        return aq_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ag_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)ae_, af_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ah_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(ag_);
                    return ah_;
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> t_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)r_, s_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? u_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(t_);
                return u_;
            }

            bool? l_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList) => !((bool?)(FinalList is null));
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> m_ = context.Operators.SelectWhere<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(j_, k_, l_);
            return m_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> g_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)e_, f_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> h_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode d) {
            string k_ = d?.code;
            return k_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<CqlCode, string>(DiagnosisValueSet, b_);

        string d_(CqlCode p) {
            string l_ = p?.code;
            return l_;
        }

        IEnumerable<string> e_ = context.Operators.SelectDistinct<CqlCode, string>(ProductOrServiceValueSet, d_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? f_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, a_, c_, e_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] g_ = [
            f_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim> m_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                m_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> s_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? t_(Claim DiagnosisLine) {
                    List<Claim.DiagnosisComponent> v_ = DiagnosisLine?.Diagnosis;

                    bool? w_(Claim.DiagnosisComponent @this) {
                        DataType ah_ = @this?.Diagnosis;
                        return !((bool?)(ah_ is null));
                    }


                    object x_(Claim.DiagnosisComponent @this) {
                        DataType ai_ = @this?.Diagnosis;
                        return ai_;
                    }

                    IEnumerable<object> y_ = context.Operators.WhereSelect<Claim.DiagnosisComponent, object>((IEnumerable<Claim.DiagnosisComponent>)v_, w_, x_);

                    bool? z_(object @this) {
                        object aj_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                        return !((bool?)(aj_ is null));
                    }


                    object aa_(object @this) {
                        object ak_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                        return ak_;
                    }

                    IEnumerable<object> ab_ = context.Operators.WhereSelect<object, object>(y_, z_, aa_);
                    IEnumerable<object> ac_ = context.Operators.FlattenLateBoundList(ab_);
                    Coding ad_(object @object) => (Coding)@object;

                    bool? ae_(Coding HeaderCode) {
                        Code al_ = HeaderCode?.CodeElement;
                        string am_ = al_?.Value;
                        IEnumerable<string> an_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                        bool? ao_ = context.Operators.In<string>(am_, an_);
                        return ao_;
                    }

                    IEnumerable<Coding> af_ = context.Operators.SelectWhere<object, Coding>(ac_, ad_, ae_);
                    bool? ag_ = context.Operators.Exists<Coding>(af_);
                    return ag_;
                }

                IEnumerable<Claim> u_ = context.Operators.Where<Claim>(s_, t_);
                m_ = u_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? n_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, m_);
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] o_ = [
                n_,
            ];

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> p_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ClaimWithProcedure) {
                IEnumerable<Claim> ap_ = ClaimWithProcedure?.DiagnosisItems;

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? aq_(Claim ClaimofInterest) {
                    Claim au_;
                    if (ClaimofInterest is null)
                    {
                        au_ = default;
                    }
                    else
                    {
                        Claim[] ba_ = [
                            ClaimofInterest,
                        ];

                        bool? bb_(Claim ItemOnLine) {
                            List<Claim.ProcedureComponent> be_ = ItemOnLine?.Procedure;

                            bool? bf_(Claim.ProcedureComponent @this) {
                                DataType bq_ = @this?.Procedure;
                                return !((bool?)(bq_ is null));
                            }


                            object bg_(Claim.ProcedureComponent @this) {
                                DataType br_ = @this?.Procedure;
                                return br_;
                            }

                            IEnumerable<object> bh_ = context.Operators.WhereSelect<Claim.ProcedureComponent, object>((IEnumerable<Claim.ProcedureComponent>)be_, bf_, bg_);

                            bool? bi_(object @this) {
                                object bs_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return !((bool?)(bs_ is null));
                            }


                            object bj_(object @this) {
                                object bt_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return bt_;
                            }

                            IEnumerable<object> bk_ = context.Operators.WhereSelect<object, object>(bh_, bi_, bj_);
                            IEnumerable<object> bl_ = context.Operators.FlattenLateBoundList(bk_);
                            Coding bm_(object @object) => (Coding)@object;

                            bool? bn_(Coding ProcedureHeaderCode) {
                                Code bu_ = ProcedureHeaderCode?.CodeElement;
                                string bv_ = bu_?.Value;
                                IEnumerable<string> bw_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                bool? bx_ = context.Operators.In<string>(bv_, bw_);
                                return bx_;
                            }

                            IEnumerable<Coding> bo_ = context.Operators.SelectWhere<object, Coding>(bl_, bm_, bn_);
                            bool? bp_ = context.Operators.Exists<Coding>(bo_);
                            // CQL 'or' (173:13-179:13): right operand skipped when left is true
                            if (bp_ is true)
                            {
                                return true;
                            }
                            else
                            {
                                List<Claim.ItemComponent> by_ = ItemOnLine?.Item;

                                bool? bz_(Claim.ItemComponent @this) {
                                    CodeableConcept ci_ = @this?.ProductOrService;
                                    return !((bool?)(ci_ is null));
                                }


                                CodeableConcept ca_(Claim.ItemComponent @this) {
                                    CodeableConcept cj_ = @this?.ProductOrService;
                                    return cj_;
                                }

                                IEnumerable<CodeableConcept> cb_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)by_, bz_, ca_);

                                bool? cc_(CodeableConcept @this) {
                                    List<Coding> ck_ = @this?.Coding;
                                    return !((bool?)(ck_ is null));
                                }


                                List<Coding> cd_(CodeableConcept @this) {
                                    List<Coding> cl_ = @this?.Coding;
                                    return cl_;
                                }

                                IEnumerable<List<Coding>> ce_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(cb_, cc_, cd_);
                                IEnumerable<Coding> cf_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ce_);

                                bool? cg_(Coding LineCode) {
                                    Code cm_ = LineCode?.CodeElement;
                                    string cn_ = cm_?.Value;
                                    IEnumerable<string> co_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? cp_ = context.Operators.In<string>(cn_, co_);
                                    return cp_;
                                }

                                bool? ch_ = context.Operators.WhereAny<Coding>(cf_, cg_);
                                return bp_ | ch_;
                            }
                        }

                        IEnumerable<Claim> bc_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ba_, bb_);
                        Claim bd_ = context.Operators.SingletonFrom<Claim>(bc_);
                        au_ = bd_;
                    }
                    (CqlTupleMetadata, Claim ProcedureItems)? av_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, au_);
                    (CqlTupleMetadata, Claim ProcedureItems)?[] aw_ = [
                        av_,
                    ];

                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ax_((CqlTupleMetadata, Claim ProcedureItems)? HeaderDefinition) {
                        if ((!((bool?)(HeaderDefinition?.ProcedureItems is null))) ?? false)
                        {
                            Claim cq_ = HeaderDefinition?.ProcedureItems;
                            List<Claim.ItemComponent> cr_ = cq_?.Item;

                            CqlInterval<CqlDateTime> cs_(Claim.ItemComponent NormalDate) {
                                DataType cv_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> cw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, cv_);
                                return cw_;
                            }

                            IEnumerable<CqlInterval<CqlDateTime>> ct_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)cr_, cs_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cu_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, cq_, ct_);
                            return cu_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ay_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim ProcedureItems)?>)aw_, ax_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ay_);
                    return az_;
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ar_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ap_, aq_);
                bool? as_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> at_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ar_, as_);
                return at_;
            }

            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> q_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)o_, p_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> r_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(q_);
            return r_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)g_, h_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode d) {
            string k_ = d?.code;
            return k_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<CqlCode, string>(DiagnosisValueSet, b_);

        string d_(CqlCode p) {
            string l_ = p?.code;
            return l_;
        }

        IEnumerable<string> e_ = context.Operators.SelectDistinct<CqlCode, string>(ProductOrServiceValueSet, d_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? f_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, a_, c_, e_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] g_ = [
            f_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure) {
            IEnumerable<Claim> m_ = ClaimWithProcedure?.MedicalClaim;

            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? n_(Claim ClaimofInterest) {
                Claim r_;
                if (ClaimofInterest is null)
                {
                    r_ = default;
                }
                else
                {
                    Claim[] x_ = [
                        ClaimofInterest,
                    ];

                    bool? y_(Claim ItemOnLine) {
                        List<Claim.ItemComponent> ab_ = ItemOnLine?.Item;

                        bool? ac_(Claim.ItemComponent @this) {
                            CodeableConcept al_ = @this?.ProductOrService;
                            return !((bool?)(al_ is null));
                        }


                        CodeableConcept ad_(Claim.ItemComponent @this) {
                            CodeableConcept am_ = @this?.ProductOrService;
                            return am_;
                        }

                        IEnumerable<CodeableConcept> ae_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)ab_, ac_, ad_);

                        bool? af_(CodeableConcept @this) {
                            List<Coding> an_ = @this?.Coding;
                            return !((bool?)(an_ is null));
                        }


                        List<Coding> ag_(CodeableConcept @this) {
                            List<Coding> ao_ = @this?.Coding;
                            return ao_;
                        }

                        IEnumerable<List<Coding>> ah_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(ae_, af_, ag_);
                        IEnumerable<Coding> ai_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ah_);

                        bool? aj_(Coding LineCode) {
                            Code ap_ = LineCode?.CodeElement;
                            string aq_ = ap_?.Value;
                            IEnumerable<string> ar_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? as_ = context.Operators.In<string>(aq_, ar_);
                            return as_;
                        }

                        bool? ak_ = context.Operators.WhereAny<Coding>(ai_, aj_);
                        // CQL 'or' (204:11-209:13): right operand skipped when left is true
                        if (ak_ is true)
                        {
                            return true;
                        }
                        else
                        {
                            List<Claim.ProcedureComponent> at_ = ItemOnLine?.Procedure;

                            bool? au_(Claim.ProcedureComponent @this) {
                                DataType bf_ = @this?.Procedure;
                                return !((bool?)(bf_ is null));
                            }


                            object av_(Claim.ProcedureComponent @this) {
                                DataType bg_ = @this?.Procedure;
                                return bg_;
                            }

                            IEnumerable<object> aw_ = context.Operators.WhereSelect<Claim.ProcedureComponent, object>((IEnumerable<Claim.ProcedureComponent>)at_, au_, av_);

                            bool? ax_(object @this) {
                                object bh_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return !((bool?)(bh_ is null));
                            }


                            object ay_(object @this) {
                                object bi_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return bi_;
                            }

                            IEnumerable<object> az_ = context.Operators.WhereSelect<object, object>(aw_, ax_, ay_);
                            IEnumerable<object> ba_ = context.Operators.FlattenLateBoundList(az_);
                            Coding bb_(object @object) => (Coding)@object;

                            bool? bc_(Coding HeaderCode) {
                                Code bj_ = HeaderCode?.CodeElement;
                                string bk_ = bj_?.Value;
                                IEnumerable<string> bl_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? bm_ = context.Operators.In<string>(bk_, bl_);
                                return bm_;
                            }

                            IEnumerable<Coding> bd_ = context.Operators.SelectWhere<object, Coding>(ba_, bb_, bc_);
                            bool? be_ = context.Operators.Exists<Coding>(bd_);
                            return ak_ | be_;
                        }
                    }

                    IEnumerable<Claim> z_ = context.Operators.Where<Claim>((IEnumerable<Claim>)x_, y_);
                    Claim aa_ = context.Operators.SingletonFrom<Claim>(z_);
                    r_ = aa_;
                }
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? s_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, r_);
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?[] t_ = [
                    s_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? DiagnosisCheck) {
                    Claim bn_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] bo_ = [
                        bn_,
                    ];

                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bp_(Claim ClaimforDiagnosis) {
                        List<Claim.ItemComponent> bs_ = ClaimforDiagnosis?.Item;
                        Claim bt_;
                        if (ClaimforDiagnosis is null)
                        {
                            bt_ = default;
                        }
                        else
                        {
                            Claim[] bz_ = [
                                ClaimforDiagnosis,
                            ];

                            bool? ca_(Claim RightClaim) {
                                List<Claim.DiagnosisComponent> cd_ = RightClaim?.Diagnosis;

                                bool? ce_(Claim.DiagnosisComponent RightDiagnosis) {
                                    PositiveInt cg_ = RightDiagnosis?.SequenceElement;
                                    Integer ch_ = context.Operators.Convert<Integer>(cg_);
                                    int? ci_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ch_);
                                    bool? cj_ = context.Operators.Equal(ci_, 1);
                                    // CQL 'and' (217:19-220:21): right operand skipped when left is false
                                    if (cj_ is false)
                                    {
                                        return false;
                                    }
                                    else
                                    {
                                        DataType ck_ = RightDiagnosis?.Diagnosis;
                                        IEnumerable<Coding> cl_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(ck_, "coding");

                                        bool? cm_(Coding DiagnosisCode) {
                                            Code co_ = DiagnosisCode?.CodeElement;
                                            string cp_ = co_?.Value;
                                            IEnumerable<string> cq_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                            bool? cr_ = context.Operators.In<string>(cp_, cq_);
                                            return cr_;
                                        }

                                        bool? cn_ = context.Operators.WhereAny<Coding>(cl_, cm_);
                                        return cj_ & cn_;
                                    }
                                }

                                bool? cf_ = context.Operators.WhereAny<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)cd_, ce_);
                                return cf_;
                            }

                            IEnumerable<Claim> cb_ = context.Operators.Where<Claim>((IEnumerable<Claim>)bz_, ca_);
                            Claim cc_ = context.Operators.SingletonFrom<Claim>(cb_);
                            bt_ = cc_;
                        }
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? bu_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)bs_, bt_);
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] bv_ = [
                            bu_,
                        ];

                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bw_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition) {
                            bool? cs_ = !((bool?)(LineItemDefinition is null));
                            bool? ct_;
                            // CQL 'and' (223:25-224:62): right operand skipped when left is false
                            if (cs_ is false)
                            {
                                ct_ = false;
                            }
                            else
                            {
                                Claim cu_ = LineItemDefinition?.LineItems;
                                ct_ = cs_ & (!((bool?)(cu_ is null)));
                            }
                            if (ct_ ?? false)
                            {
                                Claim cv_ = LineItemDefinition?.LineItems;
                                List<Claim.ItemComponent> cw_ = cv_?.Item;

                                CqlInterval<CqlDateTime> cx_(Claim.ItemComponent NormalDate) {
                                    DataType da_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> db_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, da_);
                                    return db_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> cy_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)cw_, cx_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cz_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, cv_, cy_);
                                return cz_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bx_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)bv_, bw_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? by_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bx_);
                        return by_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bq_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)bo_, bp_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? br_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bq_);
                    return br_;
                }

                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> v_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?>)t_, u_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? w_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(v_);
                return w_;
            }

            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(m_, n_);
            bool? p_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> q_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(o_, p_);
            return q_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)g_, h_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Medical Claims With Principal Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> a_ = this.Professional_or_Institutional_Claims(context, claim);

        string b_(CqlCode d) {
            string i_ = d?.code;
            return i_;
        }

        IEnumerable<string> c_ = context.Operators.SelectDistinct<CqlCode, string>(DiagnosisValueSet, b_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? d_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, a_, c_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] e_ = [
            d_,
        ];

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim> j_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                j_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> p_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? q_(Claim RightClaim) {
                    List<Claim.DiagnosisComponent> s_ = RightClaim?.Diagnosis;

                    bool? t_(Claim.DiagnosisComponent RightDiagnosis) {
                        PositiveInt v_ = RightDiagnosis?.SequenceElement;
                        Integer w_ = context.Operators.Convert<Integer>(v_);
                        int? x_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, w_);
                        bool? y_ = context.Operators.Equal(x_, 1);
                        // CQL 'and' (244:13-247:15): right operand skipped when left is false
                        if (y_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            DataType z_ = RightDiagnosis?.Diagnosis;
                            IEnumerable<Coding> aa_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(z_, "coding");

                            bool? ab_(Coding DiagnosisCode) {
                                Code ad_ = DiagnosisCode?.CodeElement;
                                string ae_ = ad_?.Value;
                                IEnumerable<string> af_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                                bool? ag_ = context.Operators.In<string>(ae_, af_);
                                return ag_;
                            }

                            bool? ac_ = context.Operators.WhereAny<Coding>(aa_, ab_);
                            return y_ & ac_;
                        }
                    }

                    bool? u_ = context.Operators.WhereAny<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
                    return u_;
                }

                IEnumerable<Claim> r_ = context.Operators.Where<Claim>(p_, q_);
                j_ = r_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)? k_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, j_);
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)?[] l_ = [
                k_,
            ];

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> m_((CqlTupleMetadata, IEnumerable<Claim> LineItems)? LineItemDefinition) {
                IEnumerable<Claim> ah_ = LineItemDefinition?.LineItems;

                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ai_(Claim ClaimWithDiagnosis) {
                    if ((!((bool?)(ClaimWithDiagnosis is null))) ?? false)
                    {
                        IEnumerable<Claim> am_ = LineItemDefinition?.LineItems;

                        bool? an_(Claim @this) {
                            List<Claim.ItemComponent> au_ = @this?.Item;
                            return !((bool?)(au_ is null));
                        }


                        List<Claim.ItemComponent> ao_(Claim @this) {
                            List<Claim.ItemComponent> av_ = @this?.Item;
                            return av_;
                        }

                        IEnumerable<List<Claim.ItemComponent>> ap_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(am_, an_, ao_);
                        IEnumerable<Claim.ItemComponent> aq_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)ap_);

                        CqlInterval<CqlDateTime> ar_(Claim.ItemComponent NormalDate) {
                            DataType aw_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> ax_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, aw_);
                            return ax_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> as_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(aq_, ar_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? at_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, am_, as_);
                        return at_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> aj_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ah_, ai_);
                bool? ak_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> al_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(aj_, ak_);
                return al_;
            }

            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?>)l_, m_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> o_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(n_);
            return o_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)e_, f_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Service and Condition")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse) {
            if ((/* CQL 'and' (262:15-264:5) */ (!(MedicalClaimAndResponse?.MedicalClaimResponse is null)
                ? false
                : (bool?)(MedicalClaimAndResponse?.MedicalClaim is null))) ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse> j_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim> k_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? l_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, j_, k_, ProductOrServiceValueSet, DiagnosisValueSet);
                return l_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] f_ = [
            e_,
        ];
        bool? g_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> h_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)f_, g_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(h_);
        return i_;
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
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> h_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent> p_ = medClaim?.LineItems;

                bool? q_(Claim.ItemComponent medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> t_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? u_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent> w_ = pClaim?.LineItems;

                        bool? x_(ClaimResponse.ItemComponent pClaimLineItem) {
                            Id z_;
                            Claim ah_ = medClaim?.ClaimofInterest;
                            bool ai_ = ah_ is Resource;
                            if (ai_)
                            {
                                Claim aj_ = medClaim?.ClaimofInterest;
                                z_ = (aj_ as Resource).IdElement;
                            }
                            else
                            {
                                z_ = default;
                            }
                            string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                            ClaimResponse ab_ = pClaim?.Response;
                            ResourceReference ac_ = ab_?.Request;
                            FhirString ad_ = ac_?.ReferenceElement;
                            string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                            string af_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ae_);
                            bool? ag_ = context.Operators.Equal(aa_, af_);
                            // CQL 'and' (313:29-314:79): right operand skipped when left is false
                            if (ag_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                PositiveInt ak_ = medClaimLineItem?.SequenceElement;
                                Integer al_ = context.Operators.Convert<Integer>(ak_);
                                PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
                                Integer an_ = context.Operators.Convert<Integer>(am_);
                                bool? ao_ = context.Operators.Equal(al_, an_);
                                return ag_ & ao_;
                            }
                        }

                        bool? y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent>(w_, x_);
                        return y_;
                    }

                    bool? v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
                    return v_;
                }

                IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? s_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, r_);
                return s_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? k_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, j_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ap_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> au_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? av_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> ba_ = @this?.ClaimItem;
                    return !((bool?)(ba_ is null));
                }


                IEnumerable<Claim.ItemComponent> aw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bb_ = @this?.ClaimItem;
                    return bb_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent>> ax_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, av_, aw_);
                IEnumerable<Claim.ItemComponent> ay_ = context.Operators.Flatten<Claim.ItemComponent>(ax_);
                bool? az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                if (az_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_ = @this?.PaidClaim;
                        return !((bool?)(bn_ is null));
                    }


                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? be_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bo_ = @this?.PaidClaim;
                        return bo_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bf_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bc_, bd_, be_);

                    bool? bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bp_ = @this?.ClaimItem;
                        return !((bool?)(bp_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bh_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bq_ = @this?.ClaimItem;
                        return bq_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bi_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bg_, bh_);
                    IEnumerable<Claim.ItemComponent> bj_ = context.Operators.Flatten<Claim.ItemComponent>(bi_);

                    CqlInterval<CqlDateTime> bk_(Claim.ItemComponent PaidItem) {
                        DataType br_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> bs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, br_);
                        return bs_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bj_, bk_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bm_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bf_, bl_);
                    ap_ = bm_;
                }
                else
                {
                    ap_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] aq_ = [
                    ap_,
                ];
                bool? ar_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> as_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)aq_, ar_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? at_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(as_);
                return at_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)l_, m_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get All Paid Claim Reponses")]
    public IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {

        bool? a_(ClaimResponse ResponseItem) {
            Code<ClaimProcessingCodes> h_ = ResponseItem?.OutcomeElement;
            string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            string[] j_ = [
                "complete",
                "partial",
            ];
            bool? k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
            return k_;
        }

        IEnumerable<ClaimResponse> b_ = context.Operators.Where<ClaimResponse>(claimResponse, a_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? c_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, b_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?[] d_ = [
            c_,
        ];

        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> e_((CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ClaimResponse) {
            IEnumerable<ClaimResponse> l_ = ClaimResponse?.PaidResponse;

            (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? m_(ClaimResponse ClmResp) {
                ResourceReference o_ = ClmResp?.Request;
                FhirString p_ = o_?.ReferenceElement;
                string q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
                string r_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, q_);
                List<ClaimResponse.ItemComponent> s_ = ClmResp?.Item;

                bool? t_(ClaimResponse.ItemComponent ResponseItem) {
                    List<ClaimResponse.AdjudicationComponent> w_ = ResponseItem?.Adjudication;

                    bool? x_(ClaimResponse.AdjudicationComponent @this) {
                        CodeableConcept ag_ = @this?.Category;
                        return !((bool?)(ag_ is null));
                    }


                    CodeableConcept y_(ClaimResponse.AdjudicationComponent @this) {
                        CodeableConcept ah_ = @this?.Category;
                        return ah_;
                    }

                    IEnumerable<CodeableConcept> z_ = context.Operators.WhereSelect<ClaimResponse.AdjudicationComponent, CodeableConcept>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, x_, y_);

                    bool? aa_(CodeableConcept @this) {
                        List<Coding> ai_ = @this?.Coding;
                        return !((bool?)(ai_ is null));
                    }


                    List<Coding> ab_(CodeableConcept @this) {
                        List<Coding> aj_ = @this?.Coding;
                        return aj_;
                    }

                    IEnumerable<List<Coding>> ac_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(z_, aa_, ab_);
                    IEnumerable<Coding> ad_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ac_);

                    bool? ae_(Coding CategoryItem) {
                        Code ak_ = CategoryItem?.CodeElement;
                        string al_ = ak_?.Value;
                        bool? am_ = context.Operators.Equal(al_, "benefit");
                        return am_;
                    }

                    bool? af_ = context.Operators.WhereAny<Coding>(ad_, ae_);
                    // CQL 'and' (434:13-440:13): right operand skipped when left is false
                    if (af_ is false)
                    {
                        return false;
                    }
                    else
                    {

                        bool? an_(ClaimResponse.AdjudicationComponent @this) {
                            Money as_ = @this?.Amount;
                            return !((bool?)(as_ is null));
                        }


                        Money ao_(ClaimResponse.AdjudicationComponent @this) {
                            Money at_ = @this?.Amount;
                            return at_;
                        }

                        IEnumerable<Money> ap_ = context.Operators.WhereSelect<ClaimResponse.AdjudicationComponent, Money>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, an_, ao_);

                        bool? aq_(Money DollarAmount) {
                            FhirDecimal au_ = DollarAmount?.ValueElement;
                            decimal? av_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, au_);
                            decimal? aw_ = context.Operators.ConvertIntegerToDecimal(0);
                            bool? ax_ = context.Operators.Greater(av_, aw_);
                            return ax_;
                        }

                        bool? ar_ = context.Operators.WhereAny<Money>(ap_, aq_);
                        return af_ & ar_;
                    }
                }

                IEnumerable<ClaimResponse.ItemComponent> u_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)s_, t_);
                (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? v_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, r_, u_);
                return v_;
            }

            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> n_ = context.Operators.SelectDistinct<ClaimResponse, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(l_, m_);
            return n_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?>)d_, e_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> g_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {

        bool? a_(Claim AllClaims) {
            List<Claim.ItemComponent> e_ = AllClaims?.Item;

            bool? f_(Claim.ItemComponent @this) {
                CodeableConcept o_ = @this?.ProductOrService;
                return !((bool?)(o_ is null));
            }


            CodeableConcept g_(Claim.ItemComponent @this) {
                CodeableConcept p_ = @this?.ProductOrService;
                return p_;
            }

            IEnumerable<CodeableConcept> h_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)e_, f_, g_);

            bool? i_(CodeableConcept @this) {
                List<Coding> q_ = @this?.Coding;
                return !((bool?)(q_ is null));
            }


            List<Coding> j_(CodeableConcept @this) {
                List<Coding> r_ = @this?.Coding;
                return r_;
            }

            IEnumerable<List<Coding>> k_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(h_, i_, j_);
            IEnumerable<Coding> l_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)k_);

            bool? m_(Coding ProductOrServiceCode) {
                CqlCode s_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? t_ = context.Operators.In<CqlCode>(s_, ProductOrServiceValueSet);
                return t_;
            }

            bool? n_ = context.Operators.WhereAny<Coding>(l_, m_);
            // CQL 'and' (446:5-451:7): right operand skipped when left is false
            if (n_ is false)
            {
                return false;
            }
            else
            {
                List<Claim.DiagnosisComponent> u_ = AllClaims?.Diagnosis;

                bool? v_(Claim.DiagnosisComponent @this) {
                    DataType ag_ = @this?.Diagnosis;
                    return !((bool?)(ag_ is null));
                }


                object w_(Claim.DiagnosisComponent @this) {
                    DataType ah_ = @this?.Diagnosis;
                    return ah_;
                }

                IEnumerable<object> x_ = context.Operators.WhereSelect<Claim.DiagnosisComponent, object>((IEnumerable<Claim.DiagnosisComponent>)u_, v_, w_);

                bool? y_(object @this) {
                    object ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                    return !((bool?)(ai_ is null));
                }


                object z_(object @this) {
                    object aj_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                    return aj_;
                }

                IEnumerable<object> aa_ = context.Operators.WhereSelect<object, object>(x_, y_, z_);
                IEnumerable<object> ab_ = context.Operators.FlattenLateBoundList(aa_);
                Coding ac_(object @object) => (Coding)@object;

                bool? ad_(Coding DiagnosisCode) {
                    CqlCode ak_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                    bool? al_ = context.Operators.In<CqlCode>(ak_, DiagnosisValueSet);
                    return al_;
                }

                IEnumerable<Coding> ae_ = context.Operators.SelectWhere<object, Coding>(ab_, ac_, ad_);
                bool? af_ = context.Operators.Exists<Coding>(ae_);
                return n_ & af_;
            }
        }


        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? b_(Claim ProcedureClaims) {
            Id am_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> an_ = ProcedureClaims?.Item;

            bool? ao_(Claim.ItemComponent ResponseItem) {
                CodeableConcept ar_ = ResponseItem?.ProductOrService;
                List<Coding> as_ = ar_?.Coding;

                bool? at_(Coding ProductOrServiceCode) {
                    CqlCode av_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? aw_ = context.Operators.In<CqlCode>(av_, ProductOrServiceValueSet);
                    return aw_;
                }

                bool? au_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)as_, at_);
                return au_;
            }

            IEnumerable<Claim.ItemComponent> ap_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)an_, ao_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? aq_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, am_, ap_);
            return aq_;
        }

        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> c_ = context.Operators.WhereSelect<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(claim, a_, b_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse) {
            if ((/* CQL 'and' (270:15-272:5) */ (!(MedicalClaimAndResponse?.MedicalClaimResponse is null)
                ? false
                : (bool?)(MedicalClaimAndResponse?.MedicalClaim is null))) ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse> f_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim> g_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, f_, g_, ProductOrServiceValueSet, DiagnosisValueSet);
                return h_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        return e_;
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
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> h_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent> p_ = medClaim?.LineItems;

                bool? q_(Claim.ItemComponent medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> t_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? u_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent> w_ = pClaim?.LineItems;

                        bool? x_(ClaimResponse.ItemComponent pClaimLineItem) {
                            Id z_;
                            Claim ah_ = medClaim?.ClaimofInterest;
                            bool ai_ = ah_ is Resource;
                            if (ai_)
                            {
                                Claim aj_ = medClaim?.ClaimofInterest;
                                z_ = (aj_ as Resource).IdElement;
                            }
                            else
                            {
                                z_ = default;
                            }
                            string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                            ClaimResponse ab_ = pClaim?.Response;
                            ResourceReference ac_ = ab_?.Request;
                            FhirString ad_ = ac_?.ReferenceElement;
                            string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                            string af_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ae_);
                            bool? ag_ = context.Operators.Equal(aa_, af_);
                            // CQL 'and' (342:29-343:79): right operand skipped when left is false
                            if (ag_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                PositiveInt ak_ = medClaimLineItem?.SequenceElement;
                                Integer al_ = context.Operators.Convert<Integer>(ak_);
                                PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
                                Integer an_ = context.Operators.Convert<Integer>(am_);
                                bool? ao_ = context.Operators.Equal(al_, an_);
                                return ag_ & ao_;
                            }
                        }

                        bool? y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent>(w_, x_);
                        return y_;
                    }

                    bool? v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
                    return v_;
                }

                IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? s_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, r_);
                return s_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? k_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, j_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ap_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> au_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? av_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> ba_ = @this?.ClaimItem;
                    return !((bool?)(ba_ is null));
                }


                IEnumerable<Claim.ItemComponent> aw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bb_ = @this?.ClaimItem;
                    return bb_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent>> ax_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, av_, aw_);
                IEnumerable<Claim.ItemComponent> ay_ = context.Operators.Flatten<Claim.ItemComponent>(ax_);
                bool? az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                if (az_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_ = @this?.PaidClaim;
                        return !((bool?)(bn_ is null));
                    }


                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? be_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bo_ = @this?.PaidClaim;
                        return bo_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bf_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bc_, bd_, be_);

                    bool? bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bp_ = @this?.ClaimItem;
                        return !((bool?)(bp_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bh_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bq_ = @this?.ClaimItem;
                        return bq_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bi_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bg_, bh_);
                    IEnumerable<Claim.ItemComponent> bj_ = context.Operators.Flatten<Claim.ItemComponent>(bi_);

                    CqlInterval<CqlDateTime> bk_(Claim.ItemComponent PaidItem) {
                        DataType br_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> bs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, br_);
                        return bs_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bj_, bk_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bm_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bf_, bl_);
                    ap_ = bm_;
                }
                else
                {
                    ap_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] aq_ = [
                    ap_,
                ];
                bool? ar_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> as_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)aq_, ar_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? at_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(as_);
                return at_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)l_, m_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {

        bool? a_(Claim AllClaims) {
            List<Claim.ItemComponent> e_ = AllClaims?.Item;

            bool? f_(Claim.ItemComponent @this) {
                CodeableConcept o_ = @this?.ProductOrService;
                return !((bool?)(o_ is null));
            }


            CodeableConcept g_(Claim.ItemComponent @this) {
                CodeableConcept p_ = @this?.ProductOrService;
                return p_;
            }

            IEnumerable<CodeableConcept> h_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)e_, f_, g_);

            bool? i_(CodeableConcept @this) {
                List<Coding> q_ = @this?.Coding;
                return !((bool?)(q_ is null));
            }


            List<Coding> j_(CodeableConcept @this) {
                List<Coding> r_ = @this?.Coding;
                return r_;
            }

            IEnumerable<List<Coding>> k_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(h_, i_, j_);
            IEnumerable<Coding> l_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)k_);

            bool? m_(Coding ProductOrServiceCode) {
                CqlCode s_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? t_ = context.Operators.In<CqlCode>(s_, ProductOrServiceValueSet);
                return t_;
            }

            bool? n_ = context.Operators.WhereAny<Coding>(l_, m_);
            // CQL 'or' (464:5-469:7): right operand skipped when left is true
            if (n_ is true)
            {
                return true;
            }
            else
            {
                List<Claim.DiagnosisComponent> u_ = AllClaims?.Diagnosis;

                bool? v_(Claim.DiagnosisComponent @this) {
                    DataType ag_ = @this?.Diagnosis;
                    return !((bool?)(ag_ is null));
                }


                object w_(Claim.DiagnosisComponent @this) {
                    DataType ah_ = @this?.Diagnosis;
                    return ah_;
                }

                IEnumerable<object> x_ = context.Operators.WhereSelect<Claim.DiagnosisComponent, object>((IEnumerable<Claim.DiagnosisComponent>)u_, v_, w_);

                bool? y_(object @this) {
                    object ai_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                    return !((bool?)(ai_ is null));
                }


                object z_(object @this) {
                    object aj_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                    return aj_;
                }

                IEnumerable<object> aa_ = context.Operators.WhereSelect<object, object>(x_, y_, z_);
                IEnumerable<object> ab_ = context.Operators.FlattenLateBoundList(aa_);
                Coding ac_(object @object) => (Coding)@object;

                bool? ad_(Coding DiagnosisCode) {
                    CqlCode ak_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                    bool? al_ = context.Operators.In<CqlCode>(ak_, DiagnosisValueSet);
                    return al_;
                }

                IEnumerable<Coding> ae_ = context.Operators.SelectWhere<object, Coding>(ab_, ac_, ad_);
                bool? af_ = context.Operators.Exists<Coding>(ae_);
                return n_ | af_;
            }
        }


        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? b_(Claim ProcedureClaims) {
            List<Claim.ItemComponent> am_ = ProcedureClaims?.Item;

            bool? an_(Claim.ItemComponent ResponseItem) {
                CodeableConcept ap_ = ResponseItem?.ProductOrService;
                List<Coding> aq_ = ap_?.Coding;

                bool? ar_(Coding ProductOrServiceCode) {
                    CqlCode at_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? au_ = context.Operators.In<CqlCode>(at_, ProductOrServiceValueSet);
                    return au_;
                }

                bool? as_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)aq_, ar_);
                return as_;
            }

            bool? ao_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)am_, an_);
            if (ao_ ?? false)
            {
                Id av_ = ProcedureClaims?.IdElement;
                List<Claim.ItemComponent> aw_ = ProcedureClaims?.Item;

                bool? ax_(Claim.ItemComponent ResponseItem) {
                    CodeableConcept ba_ = ResponseItem?.ProductOrService;
                    List<Coding> bb_ = ba_?.Coding;

                    bool? bc_(Coding ProductOrServiceCode) {
                        CqlCode be_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                        bool? bf_ = context.Operators.In<CqlCode>(be_, ProductOrServiceValueSet);
                        return bf_;
                    }

                    bool? bd_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)bb_, bc_);
                    return bd_;
                }

                IEnumerable<Claim.ItemComponent> ay_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)aw_, ax_);
                (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? az_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, av_, ay_);
                return az_;
            }
            else
            {
                Id bg_ = ProcedureClaims?.IdElement;
                List<Claim.ItemComponent> bh_ = ProcedureClaims?.Item;

                bool? bi_(Claim.ItemComponent ResponseItem) {
                    PositiveInt bl_ = ResponseItem?.SequenceElement;
                    Integer bm_ = context.Operators.Convert<Integer>(bl_);
                    int? bn_ = bm_?.Value;
                    bool? bo_ = context.Operators.Equal(bn_, 1);
                    return bo_;
                }

                IEnumerable<Claim.ItemComponent> bj_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bh_, bi_);
                (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bk_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, bg_, bj_);
                return bk_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> c_ = context.Operators.WhereSelect<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(claim, a_, b_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse) {
            if ((/* CQL 'and' (277:15-279:5) */ (!(MedicalClaimAndResponse?.MedicalClaimResponse is null)
                ? false
                : (bool?)(MedicalClaimAndResponse?.MedicalClaim is null))) ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse> f_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim> g_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? h_ = this.Get_Corresponding_Claim_for_Services_Only(context, f_, g_, ProductOrServiceValueSet);
                return h_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> d_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)b_, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? e_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(d_);
        return e_;
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
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> h_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent> p_ = medClaim?.LineItems;

                bool? q_(Claim.ItemComponent medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> t_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? u_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent> w_ = pClaim?.LineItems;

                        bool? x_(ClaimResponse.ItemComponent pClaimLineItem) {
                            Id z_;
                            Claim ah_ = medClaim?.ClaimofInterest;
                            bool ai_ = ah_ is Resource;
                            if (ai_)
                            {
                                Claim aj_ = medClaim?.ClaimofInterest;
                                z_ = (aj_ as Resource).IdElement;
                            }
                            else
                            {
                                z_ = default;
                            }
                            string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                            ClaimResponse ab_ = pClaim?.Response;
                            ResourceReference ac_ = ab_?.Request;
                            FhirString ad_ = ac_?.ReferenceElement;
                            string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                            string af_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ae_);
                            bool? ag_ = context.Operators.Equal(aa_, af_);
                            // CQL 'and' (371:29-372:79): right operand skipped when left is false
                            if (ag_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                PositiveInt ak_ = medClaimLineItem?.SequenceElement;
                                Integer al_ = context.Operators.Convert<Integer>(ak_);
                                PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
                                Integer an_ = context.Operators.Convert<Integer>(am_);
                                bool? ao_ = context.Operators.Equal(al_, an_);
                                return ag_ & ao_;
                            }
                        }

                        bool? y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent>(w_, x_);
                        return y_;
                    }

                    bool? v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
                    return v_;
                }

                IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? s_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, r_);
                return s_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? k_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, j_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? m_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ap_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> au_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? av_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> ba_ = @this?.ClaimItem;
                    return !((bool?)(ba_ is null));
                }


                IEnumerable<Claim.ItemComponent> aw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bb_ = @this?.ClaimItem;
                    return bb_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent>> ax_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, av_, aw_);
                IEnumerable<Claim.ItemComponent> ay_ = context.Operators.Flatten<Claim.ItemComponent>(ax_);
                bool? az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                if (az_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_ = @this?.PaidClaim;
                        return !((bool?)(bn_ is null));
                    }


                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? be_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bo_ = @this?.PaidClaim;
                        return bo_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bf_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bc_, bd_, be_);

                    bool? bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bp_ = @this?.ClaimItem;
                        return !((bool?)(bp_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bh_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bq_ = @this?.ClaimItem;
                        return bq_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bi_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bg_, bh_);
                    IEnumerable<Claim.ItemComponent> bj_ = context.Operators.Flatten<Claim.ItemComponent>(bi_);

                    CqlInterval<CqlDateTime> bk_(Claim.ItemComponent PaidItem) {
                        DataType br_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> bs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, br_);
                        return bs_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bj_, bk_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bm_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bf_, bl_);
                    ap_ = bm_;
                }
                else
                {
                    ap_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] aq_ = [
                    ap_,
                ];
                bool? ar_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> as_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)aq_, ar_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? at_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(as_);
                return at_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)l_, m_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)d_, e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure Only")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {

        bool? a_(Claim AllClaims) {
            List<Claim.ItemComponent> e_ = AllClaims?.Item;

            bool? f_(Claim.ItemComponent @this) {
                CodeableConcept o_ = @this?.ProductOrService;
                return !((bool?)(o_ is null));
            }


            CodeableConcept g_(Claim.ItemComponent @this) {
                CodeableConcept p_ = @this?.ProductOrService;
                return p_;
            }

            IEnumerable<CodeableConcept> h_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)e_, f_, g_);

            bool? i_(CodeableConcept @this) {
                List<Coding> q_ = @this?.Coding;
                return !((bool?)(q_ is null));
            }


            List<Coding> j_(CodeableConcept @this) {
                List<Coding> r_ = @this?.Coding;
                return r_;
            }

            IEnumerable<List<Coding>> k_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(h_, i_, j_);
            IEnumerable<Coding> l_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)k_);

            bool? m_(Coding ProductOrServiceCode) {
                CqlCode s_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? t_ = context.Operators.In<CqlCode>(s_, ProductOrServiceValueSet);
                return t_;
            }

            bool? n_ = context.Operators.WhereAny<Coding>(l_, m_);
            return n_;
        }


        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? b_(Claim AllClaims) {
            Id u_ = AllClaims?.IdElement;
            List<Claim.ItemComponent> v_ = AllClaims?.Item;

            bool? w_(Claim.ItemComponent ResponseItem) {
                CodeableConcept z_ = ResponseItem?.ProductOrService;
                List<Coding> aa_ = z_?.Coding;

                bool? ab_(Coding ProductOrServiceCode) {
                    CqlCode ad_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? ae_ = context.Operators.In<CqlCode>(ad_, ProductOrServiceValueSet);
                    return ae_;
                }

                bool? ac_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)aa_, ab_);
                return ac_;
            }

            IEnumerable<Claim.ItemComponent> x_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)v_, w_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? y_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, u_, x_);
            return y_;
        }

        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> c_ = context.Operators.WhereSelect<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(claim, a_, b_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> d_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(c_);
        return d_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse) {
            if ((/* CQL 'and' (284:15-286:5) */ (!(PharmacyClaimAndResponse?.PharmacyClaimResponse is null)
                ? false
                : (bool?)(PharmacyClaimAndResponse?.PharmacyClaim is null))) ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
            }
            else
            {
                IEnumerable<ClaimResponse> f_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                IEnumerable<Claim> g_ = PharmacyClaimAndResponse?.PharmacyClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? h_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, f_, g_, ProductOrServiceValueSet);
                return h_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> d_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)b_, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? e_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(d_);
        return e_;
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
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> h_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? i_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim) {
                IEnumerable<Claim.ItemComponent> p_ = medClaim?.LineItem;

                bool? q_(Claim.ItemComponent medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> t_ = ClaimAndResponse?.PaidPharmacyClaimResponse;

                    bool? u_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent> w_ = pClaim?.LineItems;

                        bool? x_(ClaimResponse.ItemComponent pClaimLineItem) {
                            Id z_;
                            Claim ah_ = medClaim?.Claim;
                            bool ai_ = ah_ is Resource;
                            if (ai_)
                            {
                                Claim aj_ = medClaim?.Claim;
                                z_ = (aj_ as Resource).IdElement;
                            }
                            else
                            {
                                z_ = default;
                            }
                            string aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                            ClaimResponse ab_ = pClaim?.Response;
                            ResourceReference ac_ = ab_?.Request;
                            FhirString ad_ = ac_?.ReferenceElement;
                            string ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                            string af_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ae_);
                            bool? ag_ = context.Operators.Equal(aa_, af_);
                            // CQL 'and' (400:29-401:79): right operand skipped when left is false
                            if (ag_ is false)
                            {
                                return false;
                            }
                            else
                            {
                                PositiveInt ak_ = medClaimLineItem?.SequenceElement;
                                Integer al_ = context.Operators.Convert<Integer>(ak_);
                                PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
                                Integer an_ = context.Operators.Convert<Integer>(am_);
                                bool? ao_ = context.Operators.Equal(al_, an_);
                                return ag_ & ao_;
                            }
                        }

                        bool? y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent>(w_, x_);
                        return y_;
                    }

                    bool? v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
                    return v_;
                }

                IEnumerable<Claim.ItemComponent> r_ = context.Operators.Where<Claim.ItemComponent>(p_, q_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? s_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, r_);
                return s_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(h_, i_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? k_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, j_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? m_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ap_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> au_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? av_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> ba_ = @this?.ClaimItem;
                    return !((bool?)(ba_ is null));
                }


                IEnumerable<Claim.ItemComponent> aw_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent> bb_ = @this?.ClaimItem;
                    return bb_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent>> ax_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, av_, aw_);
                IEnumerable<Claim.ItemComponent> ay_ = context.Operators.Flatten<Claim.ItemComponent>(ax_);
                bool? az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                if (az_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bc_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bt_ = @this?.PaidClaim;
                        return !((bool?)(bt_ is null));
                    }


                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? be_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bu_ = @this?.PaidClaim;
                        return bu_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> bf_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(bc_, bd_, be_);

                    bool? bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bv_ = @this?.ClaimItem;
                        return !((bool?)(bv_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bh_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bw_ = @this?.ClaimItem;
                        return bw_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bi_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bg_, bh_);
                    IEnumerable<Claim.ItemComponent> bj_ = context.Operators.Flatten<Claim.ItemComponent>(bi_);

                    CqlInterval<CqlDateTime> bk_(Claim.ItemComponent PaidItem) {
                        DataType bx_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> by_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bx_);
                        return by_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bl_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bj_, bk_);

                    bool? bm_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bz_ = @this?.ClaimItem;
                        return !((bool?)(bz_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bn_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> ca_ = @this?.ClaimItem;
                        return ca_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bo_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(bc_, bm_, bn_);
                    IEnumerable<Claim.ItemComponent> bp_ = context.Operators.Flatten<Claim.ItemComponent>(bo_);

                    CqlInterval<CqlDate> bq_(Claim.ItemComponent i) {
                        if ((!((bool?)(i?.Quantity is null))) ?? false)
                        {
                            DataType cb_ = i?.Serviced;
                            CqlInterval<CqlDateTime> cc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, cb_);
                            CqlDateTime cd_ = context.Operators.Start(cc_);
                            CqlDate ce_ = context.Operators.ConvertDateTimeToDate(cd_);
                            Quantity cf_ = i?.Quantity;
                            FhirDecimal cg_ = cf_?.ValueElement;
                            decimal? ch_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, cg_);
                            CqlDateTime ci_ = context.Operators.Add(cd_, new CqlQuantity(ch_, "day"));
                            CqlQuantity cj_ = context.Operators.Quantity(1m, "day");
                            CqlDateTime ck_ = context.Operators.Subtract(ci_, cj_);
                            CqlDate cl_ = context.Operators.ConvertDateTimeToDate(ck_);
                            CqlInterval<CqlDate> cm_ = context.Operators.Interval(ce_, cl_, true, true);
                            return cm_;
                        }
                        else
                        {
                            return null as CqlInterval<CqlDate>;
                        }
                    }

                    IEnumerable<CqlInterval<CqlDate>> br_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDate>>(bp_, bq_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? bs_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, bf_, bl_, br_);
                    ap_ = bs_;
                }
                else
                {
                    ap_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] aq_ = [
                    ap_,
                ];
                bool? ar_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList) => !((bool?)(FinalList is null));
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> as_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)aq_, ar_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? at_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(as_);
                return at_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)l_, m_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)d_, e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get Claim With Corresponding Claim Response")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {

        (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? a_(Claim Claim) {

            bool? c_(ClaimResponse CR) {
                Id h_ = Claim?.IdElement;
                string i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
                ResourceReference j_ = CR?.Request;
                FhirString k_ = j_?.ReferenceElement;
                string l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
                string m_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, l_);
                bool? n_ = context.Operators.Equal(i_, m_);
                return n_;
            }

            IEnumerable<ClaimResponse> d_ = context.Operators.Where<ClaimResponse>(claimResponse, c_);

            bool? e_(Claim C) {
                Id o_ = Claim?.IdElement;
                string p_ = FHIRHelpers_4_0_001.Instance.ToString(context, o_);

                bool? q_(ClaimResponse CR) {
                    Id ac_ = Claim?.IdElement;
                    string ad_ = FHIRHelpers_4_0_001.Instance.ToString(context, ac_);
                    ResourceReference ae_ = CR?.Request;
                    FhirString af_ = ae_?.ReferenceElement;
                    string ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_);
                    string ah_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ag_);
                    bool? ai_ = context.Operators.Equal(ad_, ah_);
                    return ai_;
                }

                IEnumerable<ClaimResponse> r_ = context.Operators.Where<ClaimResponse>(claimResponse, q_);

                bool? s_(ClaimResponse @this) {
                    ResourceReference aj_ = @this?.Request;
                    return !((bool?)(aj_ is null));
                }


                ResourceReference t_(ClaimResponse @this) {
                    ResourceReference ak_ = @this?.Request;
                    return ak_;
                }

                IEnumerable<ResourceReference> u_ = context.Operators.WhereSelect<ClaimResponse, ResourceReference>(r_, s_, t_);

                bool? v_(ResourceReference @this) {
                    FhirString al_ = @this?.ReferenceElement;
                    return !((bool?)(al_ is null));
                }


                FhirString w_(ResourceReference @this) {
                    FhirString am_ = @this?.ReferenceElement;
                    return am_;
                }

                IEnumerable<FhirString> x_ = context.Operators.WhereSelect<ResourceReference, FhirString>(u_, v_, w_);
                FhirString y_ = context.Operators.SingletonFrom<FhirString>(x_);
                string z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_);
                string aa_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, z_);
                bool? ab_ = context.Operators.Equal(p_, aa_);
                return ab_;
            }

            IEnumerable<Claim> f_ = context.Operators.Where<Claim>(claim, e_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? g_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, d_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> b_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, a_);
        return b_;
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
            IEnumerable<Claim> g_;
            if (ClaimWithInpatientStay?.MedicalClaim is null)
            {
                g_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> n_ = ClaimWithInpatientStay?.MedicalClaim;

                bool? o_(Claim c) {
                    List<Claim.ItemComponent> q_ = c?.Item;

                    bool? r_(Claim.ItemComponent i) {
                        CodeableConcept t_ = i?.Revenue;
                        CqlConcept u_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, t_);
                        IReadOnlyList<CqlCode> v_ = u_?.codes;

                        bool? w_(CqlCode rev) {
                            string y_ = rev?.code;
                            CqlValueSet z_ = this.Inpatient_Stay(context);
                            bool? aa_ = context.Operators.StringInValueSet(y_, z_);
                            return aa_;
                        }

                        bool? x_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)v_, w_);
                        return x_;
                    }

                    bool? s_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)q_, r_);
                    return s_;
                }

                IEnumerable<Claim> p_ = context.Operators.Where<Claim>(n_, o_);
                g_ = p_;
            }
            IEnumerable<Claim> h_;
            if (ClaimWithInpatientStay?.MedicalClaim is null)
            {
                h_ = null as IEnumerable<Claim>;
            }
            else
            {
                IEnumerable<Claim> ab_ = ClaimWithInpatientStay?.MedicalClaim;

                bool? ac_(Claim c) {
                    List<Claim.ItemComponent> ae_ = c?.Item;

                    bool? af_(Claim.ItemComponent i) {
                        CodeableConcept ah_ = i?.Revenue;
                        CqlConcept ai_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ah_);
                        IReadOnlyList<CqlCode> aj_ = ai_?.codes;

                        bool? ak_(CqlCode rev) {
                            string am_ = rev?.code;
                            CqlValueSet an_ = this.Nonacute_Inpatient_Stay(context);
                            bool? ao_ = context.Operators.StringInValueSet(am_, an_);
                            return ao_;
                        }

                        bool? al_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)aj_, ak_);
                        return al_;
                    }

                    bool? ag_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ae_, af_);
                    // CQL 'or' (535:11-541:13): right operand skipped when left is true
                    if (ag_ is true)
                    {
                        return true;
                    }
                    else
                    {
                        CodeableConcept ap_ = c?.SubType;
                        List<Coding> aq_ = ap_?.Coding;

                        bool? ar_(Coding tob) {
                            Code at_ = tob?.CodeElement;
                            string au_ = at_?.Value;
                            CqlValueSet av_ = this.Nonacute_Inpatient_Stay(context);
                            bool? aw_ = context.Operators.StringInValueSet(au_, av_);
                            return aw_;
                        }

                        bool? as_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)aq_, ar_);
                        return ag_ | as_;
                    }
                }

                IEnumerable<Claim> ad_ = context.Operators.Where<Claim>(ab_, ac_);
                h_ = ad_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? i_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, g_, h_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] j_ = [
                i_,
            ];

            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? k_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition) {
                IEnumerable<Claim> ax_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> ay_ = LineItemDefinition?.NonacuteInpatientLineItems;

                bool? az_(Claim nonAcuteInpatientStay) {
                    IEnumerable<Claim> be_ = LineItemDefinition?.InpatientStayLineItems;

                    bool? bf_(Claim inpatientStay) {
                        Id bh_ = nonAcuteInpatientStay?.IdElement;
                        Id bi_ = inpatientStay?.IdElement;
                        bool? bj_ = context.Operators.Equal(bh_, bi_);
                        return bj_;
                    }

                    bool? bg_ = context.Operators.WhereAny<Claim>(be_, bf_);
                    return bg_;
                }

                IEnumerable<Claim> ba_ = context.Operators.Where<Claim>(ay_, az_);

                bool? bb_(Claim inpatientStay) {
                    IEnumerable<Claim> bk_ = LineItemDefinition?.NonacuteInpatientLineItems;

                    bool? bl_(Claim nonAcuteInpatientStay) {
                        Id bn_ = inpatientStay?.IdElement;
                        Id bo_ = nonAcuteInpatientStay?.IdElement;
                        bool? bp_ = context.Operators.Equal(bn_, bo_);
                        return bp_;
                    }

                    bool? bm_ = context.Operators.WhereAny<Claim>(bk_, bl_);
                    return !bm_;
                }

                IEnumerable<Claim> bc_ = context.Operators.Where<Claim>(ax_, bb_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bd_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, ax_, ba_, bc_);
                return bd_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> l_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)j_, k_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? m_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(l_);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> e_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim)?>)c_, d_);
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Get Prescriber NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {

        (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? a_(Claim C) {
            List<Claim.CareTeamComponent> h_ = C?.CareTeam;

            bool? i_(Claim.CareTeamComponent ct) {
                PositiveInt v_ = ct?.SequenceElement;
                Integer w_ = context.Operators.Convert<Integer>(v_);
                int? x_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, w_);
                bool? y_ = context.Operators.Equal(x_, 1);
                return y_;
            }

            IEnumerable<Claim.CareTeamComponent> j_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)h_, i_);

            bool? k_(Claim.CareTeamComponent @this) {
                ResourceReference z_ = @this?.Provider;
                return !((bool?)(z_ is null));
            }


            ResourceReference l_(Claim.CareTeamComponent @this) {
                ResourceReference aa_ = @this?.Provider;
                return aa_;
            }

            IEnumerable<ResourceReference> m_ = context.Operators.WhereSelect<Claim.CareTeamComponent, ResourceReference>(j_, k_, l_);

            bool? n_(Claim.CareTeamComponent ct) {
                PositiveInt ab_ = ct?.SequenceElement;
                Integer ac_ = context.Operators.Convert<Integer>(ab_);
                int? ad_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ac_);
                bool? ae_ = context.Operators.Equal(ad_, 1);
                return ae_;
            }

            IEnumerable<Claim.CareTeamComponent> o_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)h_, n_);

            bool? p_(Claim.CareTeamComponent @this) {
                ResourceReference af_ = @this?.Provider;
                return !((bool?)(af_ is null));
            }


            ResourceReference q_(Claim.CareTeamComponent @this) {
                ResourceReference ag_ = @this?.Provider;
                return ag_;
            }

            IEnumerable<ResourceReference> r_ = context.Operators.WhereSelect<Claim.CareTeamComponent, ResourceReference>(o_, p_, q_);

            string s_(ResourceReference p) {
                FhirString ah_ = p?.ReferenceElement;
                FhirString[] ai_ = [
                    ah_,
                ];

                string aj_(FhirString r) {
                    string am_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string an_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, am_);
                    return an_;
                }

                IEnumerable<string> ak_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)ai_, aj_);
                string al_ = context.Operators.SingletonFrom<string>(ak_);
                return al_;
            }

            IEnumerable<string> t_ = context.Operators.Select<ResourceReference, string>(r_, s_);
            (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? u_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, m_, t_);
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> b_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, a_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? c_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?[] d_ = [
            c_,
        ];

        (CqlTupleMetadata, int? IdentifierCount)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ClaimProperties) {
            IEnumerable<Practitioner> ao_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));

            bool? ap_(Practitioner p) {
                Id aw_ = p?.IdElement;
                string ax_ = FHIRHelpers_4_0_001.Instance.ToString(context, aw_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ay_ = ClaimProperties?.CareTeams;

                bool? az_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                    IEnumerable<string> be_ = @this?.CareTeamsProviderID;
                    return !((bool?)(be_ is null));
                }


                IEnumerable<string> ba_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                    IEnumerable<string> bf_ = @this?.CareTeamsProviderID;
                    return bf_;
                }

                IEnumerable<IEnumerable<string>> bb_ = context.Operators.WhereSelect<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(ay_, az_, ba_);
                IEnumerable<string> bc_ = context.Operators.Flatten<string>(bb_);
                bool? bd_ = context.Operators.In<string>(ax_, bc_);
                return bd_;
            }

            IEnumerable<Practitioner> aq_ = context.Operators.Where<Practitioner>(ao_, ap_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? ar_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, aq_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?[] as_ = [
                ar_,
            ];

            (CqlTupleMetadata, int? IdentifierCount)? at_((CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? PractitionerMatch) {
                IEnumerable<Practitioner> bg_ = PractitionerMatch?.Practitioners;
                bool? bh_(Practitioner P) => !((bool?)(P is null));

                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bi_(Practitioner P) {
                    List<Identifier> bp_ = P?.Identifier;

                    bool? bq_(Identifier l) {
                        FhirUri by_ = l?.SystemElement;
                        string bz_ = by_?.Value;
                        bool? ca_ = context.Operators.Equal(bz_, "http://hl7.org/fhir/sid/us-npi");
                        bool? cb_;
                        // CQL 'and' (579:25-580:73): right operand skipped when left is false
                        if (ca_ is false)
                        {
                            cb_ = false;
                        }
                        else
                        {
                            CodeableConcept cc_ = l?.Type;
                            CqlConcept cd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cc_);
                            CqlCode ce_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                            CqlConcept cf_ = context.Operators.ConvertCodeToConcept(ce_);
                            bool? cg_ = context.Operators.Equivalent(cd_, cf_);
                            cb_ = ca_ & cg_;
                        }
                        // CQL 'and' (579:19-581:49): right operand skipped when left is false
                        if (cb_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            FhirString ch_ = l?.ValueElement;
                            string ci_ = ch_?.Value;
                            return cb_ & (!((bool?)(ci_ is null)));
                        }
                    }


                    FhirString br_(Identifier l) {
                        FhirString cj_ = l?.ValueElement;
                        return cj_;
                    }

                    IEnumerable<FhirString> bs_ = context.Operators.WhereSelect<Identifier, FhirString>((IEnumerable<Identifier>)bp_, bq_, br_);
                    IEnumerable<FhirString> bt_ = context.Operators.Distinct<FhirString>(bs_);

                    bool? bu_(Identifier l) {
                        FhirUri ck_ = l?.SystemElement;
                        string cl_ = ck_?.Value;
                        bool? cm_ = context.Operators.Equal(cl_, "http://hl7.org/fhir/sid/us-npi");
                        bool? cn_;
                        // CQL 'and' (585:25-586:73): right operand skipped when left is false
                        if (cm_ is false)
                        {
                            cn_ = false;
                        }
                        else
                        {
                            CodeableConcept co_ = l?.Type;
                            CqlConcept cp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, co_);
                            CqlCode cq_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                            CqlConcept cr_ = context.Operators.ConvertCodeToConcept(cq_);
                            bool? cs_ = context.Operators.Equivalent(cp_, cr_);
                            cn_ = cm_ & cs_;
                        }
                        // CQL 'and' (585:19-587:45): right operand skipped when left is false
                        if (cn_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            FhirString ct_ = l?.ValueElement;
                            string cu_ = ct_?.Value;
                            return cn_ & ((bool?)(cu_ is null));
                        }
                    }

                    Identifier bv_(Identifier l) => l;
                    IEnumerable<Identifier> bw_ = context.Operators.WhereSelect<Identifier, Identifier>((IEnumerable<Identifier>)bp_, bu_, bv_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bx_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, bt_, bw_);
                    return bx_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> bj_ = context.Operators.WhereSelect<Practitioner, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bg_, bh_, bi_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? bk_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, bj_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] bl_ = [
                    bk_,
                ];

                (CqlTupleMetadata, int? IdentifierCount)? bm_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers) {
                    int? cv_;
                    IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> cx_ = ClaimProperties?.CareTeams;

                    bool? cy_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                        Claim dc_ = @this?.SingleCareTeam;
                        return !((bool?)(dc_ is null));
                    }


                    Claim cz_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                        Claim dd_ = @this?.SingleCareTeam;
                        return dd_;
                    }

                    IEnumerable<Claim> da_ = context.Operators.WhereSelect<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(cx_, cy_, cz_);
                    bool? db_ = context.Operators.Exists<Claim>(da_);
                    if (db_ ?? false)
                    {
                        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> de_ = ClaimProperties?.CareTeams;

                        bool? df_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                            Claim dy_ = @this?.SingleCareTeam;
                            return !((bool?)(dy_ is null));
                        }


                        Claim dg_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                            Claim dz_ = @this?.SingleCareTeam;
                            return dz_;
                        }

                        IEnumerable<Claim> dh_ = context.Operators.WhereSelect<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(de_, df_, dg_);

                        bool? di_(Claim X) {
                            List<Claim.CareTeamComponent> ea_ = X?.CareTeam;
                            return (bool?)(((IEnumerable<Claim.CareTeamComponent>)ea_) is null);
                        }

                        IEnumerable<Claim> dj_ = context.Operators.Where<Claim>(dh_, di_);
                        int? dk_ = context.Operators.Count<Claim>(dj_);
                        IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> dl_ = GetIdentifiers?.IdentifierTuple;

                        IEnumerable<FhirString> dm_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<FhirString> eb_ = X?.AllIdentifiers;
                            return eb_;
                        }

                        IEnumerable<IEnumerable<FhirString>> dn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(dl_, dm_);
                        IEnumerable<FhirString> do_ = context.Operators.Flatten<FhirString>(dn_);
                        FhirString dp_(FhirString X) => X;
                        IEnumerable<FhirString> dq_ = context.Operators.SelectDistinct<FhirString, FhirString>(do_, dp_);
                        int? dr_ = context.Operators.Count<FhirString>(dq_);
                        int? ds_ = context.Operators.Add(dk_, dr_);

                        IEnumerable<Identifier> dt_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<Identifier> ec_ = X?.NullIdentifiers;
                            return ec_;
                        }

                        IEnumerable<IEnumerable<Identifier>> du_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(dl_, dt_);
                        IEnumerable<Identifier> dv_ = context.Operators.Flatten<Identifier>(du_);
                        int? dw_ = context.Operators.Count<Identifier>(dv_);
                        int? dx_ = context.Operators.Add(ds_, dw_);
                        cv_ = dx_;
                    }
                    else
                    {
                        cv_ = 0;
                    }
                    (CqlTupleMetadata, int? IdentifierCount)? cw_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, cv_);
                    return cw_;
                }

                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bn_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)bl_, bm_);
                (CqlTupleMetadata, int? IdentifierCount)? bo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bn_);
                return bo_;
            }

            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> au_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?>)as_, at_);
            (CqlTupleMetadata, int? IdentifierCount)? av_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(au_);
            return av_;
        }

        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?>)d_, e_);
        (CqlTupleMetadata, int? IdentifierCount)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get Pharmacy NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {

        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? a_(Claim C) {
            List<Claim.ItemComponent> h_ = C?.Item;

            bool? i_(Claim.ItemComponent i) {
                PositiveInt x_ = i?.SequenceElement;
                Integer y_ = context.Operators.Convert<Integer>(x_);
                int? z_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, y_);
                bool? aa_ = context.Operators.Equal(z_, 1);
                return aa_;
            }

            IEnumerable<Claim.ItemComponent> j_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)h_, i_);

            bool? k_(Claim.ItemComponent @this) {
                DataType ab_ = @this?.Location;
                return !((bool?)(ab_ is null));
            }


            object l_(Claim.ItemComponent @this) {
                DataType ac_ = @this?.Location;
                return ac_;
            }

            IEnumerable<object> m_ = context.Operators.WhereSelect<Claim.ItemComponent, object>(j_, k_, l_);
            ResourceReference n_(object l) => l as ResourceReference;
            IEnumerable<ResourceReference> o_ = context.Operators.Select<object, ResourceReference>(m_, n_);

            bool? p_(Claim.ItemComponent i) {
                PositiveInt ad_ = i?.SequenceElement;
                Integer ae_ = context.Operators.Convert<Integer>(ad_);
                int? af_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ae_);
                bool? ag_ = context.Operators.Equal(af_, 1);
                return ag_;
            }

            IEnumerable<Claim.ItemComponent> q_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)h_, p_);

            bool? r_(Claim.ItemComponent @this) {
                DataType ah_ = @this?.Location;
                return !((bool?)(ah_ is null));
            }


            object s_(Claim.ItemComponent @this) {
                DataType ai_ = @this?.Location;
                return ai_;
            }

            IEnumerable<object> t_ = context.Operators.WhereSelect<Claim.ItemComponent, object>(q_, r_, s_);

            string u_(object l) {
                FhirString aj_ = (l as ResourceReference)?.ReferenceElement;
                FhirString[] ak_ = [
                    aj_,
                ];

                string al_(FhirString r) {
                    string ao_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string ap_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ao_);
                    return ap_;
                }

                IEnumerable<string> am_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)ak_, al_);
                string an_ = context.Operators.SingletonFrom<string>(am_);
                return an_;
            }

            IEnumerable<string> v_ = context.Operators.Select<object, string>(t_, u_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? w_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent>)h_, o_, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> b_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, a_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? c_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?[] d_ = [
            c_,
        ];

        (CqlTupleMetadata, int? IdentifierCount)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? ClaimProperties) {
            IEnumerable<Location> aq_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));

            bool? ar_(Location l) {
                Id ay_ = l?.IdElement;
                string az_ = FHIRHelpers_4_0_001.Instance.ToString(context, ay_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ba_ = ClaimProperties?.ItemsLocationReferences;

                bool? bb_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                    IEnumerable<string> bg_ = @this?.ItemLocationID;
                    return !((bool?)(bg_ is null));
                }


                IEnumerable<string> bc_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                    IEnumerable<string> bh_ = @this?.ItemLocationID;
                    return bh_;
                }

                IEnumerable<IEnumerable<string>> bd_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(ba_, bb_, bc_);
                IEnumerable<string> be_ = context.Operators.Flatten<string>(bd_);
                bool? bf_ = context.Operators.In<string>(az_, be_);
                return bf_;
            }

            IEnumerable<Location> as_ = context.Operators.Where<Location>(aq_, ar_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? at_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, as_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?[] au_ = [
                at_,
            ];

            (CqlTupleMetadata, int? IdentifierCount)? av_((CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? GetLocation) {
                IEnumerable<Location> bi_ = GetLocation?.CorrespondingLocations;
                bool? bj_(Location C) => !((bool?)(C is null));

                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bk_(Location C) {
                    List<Identifier> br_ = C?.Identifier;

                    bool? bs_(Identifier l) {
                        FhirUri ca_ = l?.SystemElement;
                        string cb_ = ca_?.Value;
                        bool? cc_ = context.Operators.Equal(cb_, "http://hl7.org/fhir/sid/us-npi");
                        bool? cd_;
                        // CQL 'and' (635:25-636:73): right operand skipped when left is false
                        if (cc_ is false)
                        {
                            cd_ = false;
                        }
                        else
                        {
                            CodeableConcept ce_ = l?.Type;
                            CqlConcept cf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ce_);
                            CqlCode cg_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                            CqlConcept ch_ = context.Operators.ConvertCodeToConcept(cg_);
                            bool? ci_ = context.Operators.Equivalent(cf_, ch_);
                            cd_ = cc_ & ci_;
                        }
                        // CQL 'and' (635:19-637:49): right operand skipped when left is false
                        if (cd_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            FhirString cj_ = l?.ValueElement;
                            string ck_ = cj_?.Value;
                            return cd_ & (!((bool?)(ck_ is null)));
                        }
                    }


                    FhirString bt_(Identifier l) {
                        FhirString cl_ = l?.ValueElement;
                        return cl_;
                    }

                    IEnumerable<FhirString> bu_ = context.Operators.WhereSelect<Identifier, FhirString>((IEnumerable<Identifier>)br_, bs_, bt_);
                    IEnumerable<FhirString> bv_ = context.Operators.Distinct<FhirString>(bu_);

                    bool? bw_(Identifier l) {
                        FhirUri cm_ = l?.SystemElement;
                        string cn_ = cm_?.Value;
                        bool? co_ = context.Operators.Equal(cn_, "http://hl7.org/fhir/sid/us-npi");
                        bool? cp_;
                        // CQL 'and' (641:25-642:73): right operand skipped when left is false
                        if (co_ is false)
                        {
                            cp_ = false;
                        }
                        else
                        {
                            CodeableConcept cq_ = l?.Type;
                            CqlConcept cr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cq_);
                            CqlCode cs_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                            CqlConcept ct_ = context.Operators.ConvertCodeToConcept(cs_);
                            bool? cu_ = context.Operators.Equivalent(cr_, ct_);
                            cp_ = co_ & cu_;
                        }
                        // CQL 'and' (641:19-643:45): right operand skipped when left is false
                        if (cp_ is false)
                        {
                            return false;
                        }
                        else
                        {
                            FhirString cv_ = l?.ValueElement;
                            string cw_ = cv_?.Value;
                            return cp_ & ((bool?)(cw_ is null));
                        }
                    }

                    Identifier bx_(Identifier l) => l;
                    IEnumerable<Identifier> by_ = context.Operators.WhereSelect<Identifier, Identifier>((IEnumerable<Identifier>)br_, bw_, bx_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? bz_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, bv_, by_);
                    return bz_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> bl_ = context.Operators.WhereSelect<Location, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(bi_, bj_, bk_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? bm_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, bl_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] bn_ = [
                    bm_,
                ];

                (CqlTupleMetadata, int? IdentifierCount)? bo_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers) {
                    int? cx_;
                    IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> cz_ = ClaimProperties?.ItemsLocationReferences;

                    bool? da_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                        IEnumerable<Claim.ItemComponent> df_ = @this?.SingleItem;
                        return !((bool?)(df_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> db_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                        IEnumerable<Claim.ItemComponent> dg_ = @this?.SingleItem;
                        return dg_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> dc_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(cz_, da_, db_);
                    IEnumerable<Claim.ItemComponent> dd_ = context.Operators.Flatten<Claim.ItemComponent>(dc_);
                    bool? de_ = context.Operators.Exists<Claim.ItemComponent>(dd_);
                    if (de_ ?? false)
                    {
                        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> dh_ = ClaimProperties?.ItemsLocationReferences;

                        bool? di_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                            IEnumerable<ResourceReference> ec_ = @this?.ItemLocation;
                            return !((bool?)(ec_ is null));
                        }


                        IEnumerable<ResourceReference> dj_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                            IEnumerable<ResourceReference> ed_ = @this?.ItemLocation;
                            return ed_;
                        }

                        IEnumerable<IEnumerable<ResourceReference>> dk_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(dh_, di_, dj_);
                        IEnumerable<ResourceReference> dl_ = context.Operators.Flatten<ResourceReference>(dk_);

                        bool? dm_(ResourceReference X) {
                            FhirString ee_ = X?.ReferenceElement;
                            string ef_ = ee_?.Value;
                            return (bool?)(ef_ is null);
                        }

                        IEnumerable<ResourceReference> dn_ = context.Operators.Where<ResourceReference>(dl_, dm_);
                        int? do_ = context.Operators.Count<ResourceReference>(dn_);
                        IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> dp_ = GetIdentifiers?.IdentifierTuple;

                        IEnumerable<FhirString> dq_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<FhirString> eg_ = X?.AllIdentifiers;
                            return eg_;
                        }

                        IEnumerable<IEnumerable<FhirString>> dr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(dp_, dq_);
                        IEnumerable<FhirString> ds_ = context.Operators.Flatten<FhirString>(dr_);
                        FhirString dt_(FhirString X) => X;
                        IEnumerable<FhirString> du_ = context.Operators.SelectDistinct<FhirString, FhirString>(ds_, dt_);
                        int? dv_ = context.Operators.Count<FhirString>(du_);
                        int? dw_ = context.Operators.Add(do_, dv_);

                        IEnumerable<Identifier> dx_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<Identifier> eh_ = X?.NullIdentifiers;
                            return eh_;
                        }

                        IEnumerable<IEnumerable<Identifier>> dy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(dp_, dx_);
                        IEnumerable<Identifier> dz_ = context.Operators.Flatten<Identifier>(dy_);
                        int? ea_ = context.Operators.Count<Identifier>(dz_);
                        int? eb_ = context.Operators.Add(dw_, ea_);
                        cx_ = eb_;
                    }
                    else
                    {
                        cx_ = 0;
                    }
                    (CqlTupleMetadata, int? IdentifierCount)? cy_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, cx_);
                    return cy_;
                }

                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bp_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)bn_, bo_);
                (CqlTupleMetadata, int? IdentifierCount)? bq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bp_);
                return bq_;
            }

            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> aw_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?>)au_, av_);
            (CqlTupleMetadata, int? IdentifierCount)? ax_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(aw_);
            return ax_;
        }

        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?>)d_, e_);
        (CqlTupleMetadata, int? IdentifierCount)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(f_);
        return g_;
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
