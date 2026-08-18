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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "5.3.4.0")]
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
            CqlBoolean g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

            CqlBoolean h_() {
                CodeableConcept i_ = MedicalClaim?.Type;
                CqlConcept j_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, i_);
                IReadOnlyList<CqlCode> k_ = j_?.codes;
                CqlCode l_ = NCQATerminology_1_0_0.Instance.Institutional(context);
                CqlBoolean m_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)k_, l_);
                return m_;
            }

            return /* CQL 'or' (14:5-16:5) */ (g_
                || h_());
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
            CqlBoolean g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
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
            CqlBoolean g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);

            CqlBoolean h_() {
                CodeableConcept i_ = MedicalResponse?.Type;
                CqlConcept j_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, i_);
                IReadOnlyList<CqlCode> k_ = j_?.codes;
                CqlCode l_ = NCQATerminology_1_0_0.Instance.Institutional(context);
                CqlBoolean m_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)k_, l_);
                return m_;
            }

            return /* CQL 'or' (24:5-26:5) */ (g_
                || h_());
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
            CqlBoolean g_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)e_, f_);
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
                            string ag_ = LineCode?.code;
                            IEnumerable<string> ah_ = ClaimWithPosCode?.ProceduresAsStrings;
                            CqlBoolean ai_ = context.Operators.In<string>(ag_, ah_);
                            return ai_;
                        }

                        CqlBoolean ae_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)ac_, ad_);

                        CqlBoolean af_() {
                            DataType aj_ = ItemOnLine?.Location;
                            CqlConcept ak_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aj_ as CodeableConcept);
                            IReadOnlyList<CqlCode> al_ = ak_?.codes;

                            bool? am_(CqlCode PosCode) {
                                string ao_ = PosCode?.code;
                                IEnumerable<string> ap_ = ClaimWithPosCode?.POSAsString;
                                CqlBoolean aq_ = context.Operators.In<string>(ao_, ap_);
                                return aq_;
                            }

                            CqlBoolean an_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)al_, am_);
                            return an_;
                        }

                        return /* CQL 'and' (45:11-51:11) */ (ae_
                            && af_());
                    }

                    IEnumerable<Claim.ItemComponent> z_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)x_, y_);
                    r_ = z_;
                }
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? s_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, r_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] t_ = [
                    s_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? u_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition) {
                    IEnumerable<Claim.ItemComponent> ar_ = LineItemDefinition?.LineItems;
                    CqlBoolean as_ = context.Operators.Exists<Claim.ItemComponent>(ar_);
                    if (as_.IsTrue)
                    {
                        Claim at_ = LineItemDefinition?.Claim;

                        bool? au_(Claim.ItemComponent @this) {
                            DataType ba_ = @this?.Serviced;
                            return !((bool?)(ba_ is null));
                        }


                        object av_(Claim.ItemComponent @this) {
                            DataType bb_ = @this?.Serviced;
                            return bb_;
                        }

                        IEnumerable<object> aw_ = context.Operators.WhereSelect<Claim.ItemComponent, object>(ar_, au_, av_);

                        CqlInterval<CqlDateTime> ax_(object NormalDate) {
                            CqlInterval<CqlDateTime> bc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                            return bc_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(aw_, ax_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, at_, ay_);
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
                            string ad_ = LineCode?.code;
                            IEnumerable<string> ae_ = ClaimWithProcedure?.ProceduresAsStrings;
                            CqlBoolean af_ = context.Operators.In<string>(ad_, ae_);
                            return af_;
                        }

                        CqlBoolean ab_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)z_, aa_);

                        CqlBoolean ac_() {
                            List<Claim.ProcedureComponent> ag_ = ClaimofInterest?.Procedure;

                            bool? ah_(Claim.ProcedureComponent @this) {
                                DataType as_ = @this?.Procedure;
                                return !((bool?)(as_ is null));
                            }


                            object ai_(Claim.ProcedureComponent @this) {
                                DataType at_ = @this?.Procedure;
                                return at_;
                            }

                            IEnumerable<object> aj_ = context.Operators.WhereSelect<Claim.ProcedureComponent, object>((IEnumerable<Claim.ProcedureComponent>)ag_, ah_, ai_);

                            bool? ak_(object @this) {
                                object au_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return !((bool?)(au_ is null));
                            }


                            object al_(object @this) {
                                object av_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return av_;
                            }

                            IEnumerable<object> am_ = context.Operators.WhereSelect<object, object>(aj_, ak_, al_);
                            IEnumerable<object> an_ = context.Operators.FlattenLateBoundList(am_);
                            Coding ao_(object @object) => (Coding)@object;

                            bool? ap_(Coding HeaderCode) {
                                Code aw_ = HeaderCode?.CodeElement;
                                string ax_ = aw_?.Value;
                                IEnumerable<string> ay_ = ClaimWithProcedure?.ProceduresAsStrings;
                                CqlBoolean az_ = context.Operators.In<string>(ax_, ay_);
                                return az_;
                            }

                            IEnumerable<Coding> aq_ = context.Operators.SelectWhere<object, Coding>(an_, ao_, ap_);
                            CqlBoolean ar_ = context.Operators.Exists<Coding>(aq_);
                            return ar_;
                        }

                        return /* CQL 'or' (74:11-79:13) */ (ab_
                            || ac_());
                    }

                    IEnumerable<Claim.ItemComponent> w_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)u_, v_);
                    o_ = w_;
                }
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? p_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, o_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] q_ = [
                    p_,
                ];

                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? r_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition) {
                    IEnumerable<Claim.ItemComponent> ba_ = LineItemDefinition?.LineItems;
                    CqlBoolean bb_ = context.Operators.Exists<Claim.ItemComponent>(ba_);
                    if (bb_.IsTrue)
                    {
                        Claim bc_ = LineItemDefinition?.Claim;

                        bool? bd_(Claim.ItemComponent @this) {
                            DataType bj_ = @this?.Serviced;
                            return !((bool?)(bj_ is null));
                        }


                        object be_(Claim.ItemComponent @this) {
                            DataType bk_ = @this?.Serviced;
                            return bk_;
                        }

                        IEnumerable<object> bf_ = context.Operators.WhereSelect<Claim.ItemComponent, object>(ba_, bd_, be_);

                        CqlInterval<CqlDateTime> bg_(object NormalDate) {
                            CqlInterval<CqlDateTime> bl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                            return bl_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> bh_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(bf_, bg_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bi_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, bc_, bh_);
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
                        CqlBoolean al_ = context.Operators.In<string>(aj_, ak_);
                        return al_;
                    }

                    IEnumerable<Coding> ac_ = context.Operators.SelectWhere<object, Coding>(z_, aa_, ab_);
                    CqlBoolean ad_ = context.Operators.Exists<Coding>(ac_);
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
                CqlBoolean as_ = context.Operators.Exists<Claim>(ar_);
                if (as_.IsTrue)
                {

                    bool? at_(Claim @this) {
                        List<Claim.ItemComponent> ba_ = @this?.Item;
                        return !((bool?)(ba_ is null));
                    }


                    List<Claim.ItemComponent> au_(Claim @this) {
                        List<Claim.ItemComponent> bb_ = @this?.Item;
                        return bb_;
                    }

                    IEnumerable<List<Claim.ItemComponent>> av_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(ar_, at_, au_);
                    IEnumerable<Claim.ItemComponent> aw_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)av_);

                    CqlInterval<CqlDateTime> ax_(Claim.ItemComponent NormalDate) {
                        DataType bc_ = NormalDate?.Serviced;
                        CqlInterval<CqlDateTime> bd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bc_);
                        return bd_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> ay_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(aw_, ax_);
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? az_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, ar_, ay_);
                    am_ = az_;
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
                        CqlBoolean ac_ = context.Operators.In<string>(aa_, ab_);
                        return ac_;
                    }

                    CqlBoolean z_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)x_, y_);
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
                                CqlBoolean ay_ = context.Operators.In<string>(aw_, ax_);
                                return ay_;
                            }

                            CqlBoolean av_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)at_, au_);
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
                                    CqlInterval<CqlDateTime> be_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bc_);
                                    CqlDateTime bf_ = context.Operators.Start(be_);
                                    Quantity bg_ = i?.Quantity;
                                    FhirDecimal bh_ = bg_?.ValueElement;
                                    decimal? bi_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bh_);
                                    CqlDateTime bj_ = context.Operators.Add(bf_, new CqlQuantity(bi_, "day"));
                                    CqlQuantity bk_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime bl_ = context.Operators.Subtract(bj_, bk_);
                                    CqlInterval<CqlDateTime> bm_ = context.Operators.Interval(bf_, bl_, true, true);
                                    bb_ = bm_;
                                }
                                else
                                {
                                    CqlDate bn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bc_ as Date);
                                    CqlDateTime bo_ = context.Operators.ConvertDateToDateTime(bn_);
                                    Quantity bp_ = i?.Quantity;
                                    FhirDecimal bq_ = bp_?.ValueElement;
                                    decimal? br_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bq_);
                                    CqlDate bs_ = context.Operators.Add(bn_, new CqlQuantity(br_, "day"));
                                    CqlQuantity bt_ = context.Operators.Quantity(1m, "day");
                                    CqlDate bu_ = context.Operators.Subtract(bs_, bt_);
                                    CqlDateTime bv_ = context.Operators.ConvertDateToDateTime(bu_);
                                    CqlInterval<CqlDateTime> bw_ = context.Operators.Interval(bo_, bv_, true, true);
                                    bb_ = bw_;
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
                            IEnumerable<Claim.ItemComponent> bx_ = LineItemDefinition?.LineItems;
                            CqlBoolean by_ = context.Operators.Exists<Claim.ItemComponent>(bx_);
                            if (by_.IsTrue)
                            {
                                Claim bz_ = LineItemDefinition?.Claim;

                                bool? ca_(Claim.ItemComponent @this) {
                                    DataType cj_ = @this?.Serviced;
                                    return !((bool?)(cj_ is null));
                                }


                                object cb_(Claim.ItemComponent @this) {
                                    DataType ck_ = @this?.Serviced;
                                    return ck_;
                                }

                                IEnumerable<object> cc_ = context.Operators.WhereSelect<Claim.ItemComponent, object>(bx_, ca_, cb_);

                                CqlInterval<CqlDateTime> cd_(object NormalDate) {
                                    CqlInterval<CqlDateTime> cl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                                    return cl_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> ce_ = context.Operators.SelectDistinct<object, CqlInterval<CqlDateTime>>(cc_, cd_);
                                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> cf_ = ItemCalculation?.CoveredDays;

                                CqlInterval<CqlDateTime> cg_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d) {
                                    CqlInterval<CqlDateTime> cm_ = d?.DaysSupplyInterval;
                                    return cm_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> ch_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(cf_, cg_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ci_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, bz_, bx_, ce_, ch_);
                                return ci_;
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
                        CqlBoolean ao_ = context.Operators.In<string>(am_, an_);
                        return ao_;
                    }

                    IEnumerable<Coding> af_ = context.Operators.SelectWhere<object, Coding>(ac_, ad_, ae_);
                    CqlBoolean ag_ = context.Operators.Exists<Coding>(af_);
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
                                DataType br_ = @this?.Procedure;
                                return !((bool?)(br_ is null));
                            }


                            object bg_(Claim.ProcedureComponent @this) {
                                DataType bs_ = @this?.Procedure;
                                return bs_;
                            }

                            IEnumerable<object> bh_ = context.Operators.WhereSelect<Claim.ProcedureComponent, object>((IEnumerable<Claim.ProcedureComponent>)be_, bf_, bg_);

                            bool? bi_(object @this) {
                                object bt_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return !((bool?)(bt_ is null));
                            }


                            object bj_(object @this) {
                                object bu_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return bu_;
                            }

                            IEnumerable<object> bk_ = context.Operators.WhereSelect<object, object>(bh_, bi_, bj_);
                            IEnumerable<object> bl_ = context.Operators.FlattenLateBoundList(bk_);
                            Coding bm_(object @object) => (Coding)@object;

                            bool? bn_(Coding ProcedureHeaderCode) {
                                Code bv_ = ProcedureHeaderCode?.CodeElement;
                                string bw_ = bv_?.Value;
                                IEnumerable<string> bx_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                CqlBoolean by_ = context.Operators.In<string>(bw_, bx_);
                                return by_;
                            }

                            IEnumerable<Coding> bo_ = context.Operators.SelectWhere<object, Coding>(bl_, bm_, bn_);
                            CqlBoolean bp_ = context.Operators.Exists<Coding>(bo_);

                            CqlBoolean bq_() {
                                List<Claim.ItemComponent> bz_ = ItemOnLine?.Item;

                                bool? ca_(Claim.ItemComponent @this) {
                                    CodeableConcept cj_ = @this?.ProductOrService;
                                    return !((bool?)(cj_ is null));
                                }


                                CodeableConcept cb_(Claim.ItemComponent @this) {
                                    CodeableConcept ck_ = @this?.ProductOrService;
                                    return ck_;
                                }

                                IEnumerable<CodeableConcept> cc_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)bz_, ca_, cb_);

                                bool? cd_(CodeableConcept @this) {
                                    List<Coding> cl_ = @this?.Coding;
                                    return !((bool?)(cl_ is null));
                                }


                                List<Coding> ce_(CodeableConcept @this) {
                                    List<Coding> cm_ = @this?.Coding;
                                    return cm_;
                                }

                                IEnumerable<List<Coding>> cf_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(cc_, cd_, ce_);
                                IEnumerable<Coding> cg_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)cf_);

                                bool? ch_(Coding LineCode) {
                                    Code cn_ = LineCode?.CodeElement;
                                    string co_ = cn_?.Value;
                                    IEnumerable<string> cp_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    CqlBoolean cq_ = context.Operators.In<string>(co_, cp_);
                                    return cq_;
                                }

                                CqlBoolean ci_ = context.Operators.WhereAny<Coding>(cg_, ch_);
                                return ci_;
                            }

                            return /* CQL 'or' (173:13-179:13) */ (bp_
                                || bq_());
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
                            Claim cr_ = HeaderDefinition?.ProcedureItems;
                            List<Claim.ItemComponent> cs_ = cr_?.Item;

                            CqlInterval<CqlDateTime> ct_(Claim.ItemComponent NormalDate) {
                                DataType cw_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> cx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, cw_);
                                return cx_;
                            }

                            IEnumerable<CqlInterval<CqlDateTime>> cu_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)cs_, ct_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cv_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, cr_, cu_);
                            return cv_;
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
                            CodeableConcept am_ = @this?.ProductOrService;
                            return !((bool?)(am_ is null));
                        }


                        CodeableConcept ad_(Claim.ItemComponent @this) {
                            CodeableConcept an_ = @this?.ProductOrService;
                            return an_;
                        }

                        IEnumerable<CodeableConcept> ae_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)ab_, ac_, ad_);

                        bool? af_(CodeableConcept @this) {
                            List<Coding> ao_ = @this?.Coding;
                            return !((bool?)(ao_ is null));
                        }


                        List<Coding> ag_(CodeableConcept @this) {
                            List<Coding> ap_ = @this?.Coding;
                            return ap_;
                        }

                        IEnumerable<List<Coding>> ah_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(ae_, af_, ag_);
                        IEnumerable<Coding> ai_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ah_);

                        bool? aj_(Coding LineCode) {
                            Code aq_ = LineCode?.CodeElement;
                            string ar_ = aq_?.Value;
                            IEnumerable<string> as_ = ClaimWithProcedure?.ProceduresAsStrings;
                            CqlBoolean at_ = context.Operators.In<string>(ar_, as_);
                            return at_;
                        }

                        CqlBoolean ak_ = context.Operators.WhereAny<Coding>(ai_, aj_);

                        CqlBoolean al_() {
                            List<Claim.ProcedureComponent> au_ = ItemOnLine?.Procedure;

                            bool? av_(Claim.ProcedureComponent @this) {
                                DataType bg_ = @this?.Procedure;
                                return !((bool?)(bg_ is null));
                            }


                            object aw_(Claim.ProcedureComponent @this) {
                                DataType bh_ = @this?.Procedure;
                                return bh_;
                            }

                            IEnumerable<object> ax_ = context.Operators.WhereSelect<Claim.ProcedureComponent, object>((IEnumerable<Claim.ProcedureComponent>)au_, av_, aw_);

                            bool? ay_(object @this) {
                                object bi_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return !((bool?)(bi_ is null));
                            }


                            object az_(object @this) {
                                object bj_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                return bj_;
                            }

                            IEnumerable<object> ba_ = context.Operators.WhereSelect<object, object>(ax_, ay_, az_);
                            IEnumerable<object> bb_ = context.Operators.FlattenLateBoundList(ba_);
                            Coding bc_(object @object) => (Coding)@object;

                            bool? bd_(Coding HeaderCode) {
                                Code bk_ = HeaderCode?.CodeElement;
                                string bl_ = bk_?.Value;
                                IEnumerable<string> bm_ = ClaimWithProcedure?.ProceduresAsStrings;
                                CqlBoolean bn_ = context.Operators.In<string>(bl_, bm_);
                                return bn_;
                            }

                            IEnumerable<Coding> be_ = context.Operators.SelectWhere<object, Coding>(bb_, bc_, bd_);
                            CqlBoolean bf_ = context.Operators.Exists<Coding>(be_);
                            return bf_;
                        }

                        return /* CQL 'or' (204:11-209:13) */ (ak_
                            || al_());
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
                    Claim bo_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] bp_ = [
                        bo_,
                    ];

                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bq_(Claim ClaimforDiagnosis) {
                        List<Claim.ItemComponent> bt_ = ClaimforDiagnosis?.Item;
                        Claim bu_;
                        if (ClaimforDiagnosis is null)
                        {
                            bu_ = default;
                        }
                        else
                        {
                            Claim[] ca_ = [
                                ClaimforDiagnosis,
                            ];

                            bool? cb_(Claim RightClaim) {
                                List<Claim.DiagnosisComponent> ce_ = RightClaim?.Diagnosis;

                                bool? cf_(Claim.DiagnosisComponent RightDiagnosis) {
                                    PositiveInt ch_ = RightDiagnosis?.SequenceElement;
                                    Integer ci_ = context.Operators.Convert<Integer>(ch_);
                                    int? cj_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ci_);
                                    CqlBoolean ck_ = context.Operators.Equal(cj_, 1);

                                    CqlBoolean cl_() {
                                        DataType cm_ = RightDiagnosis?.Diagnosis;
                                        IEnumerable<Coding> cn_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(cm_, "coding");

                                        bool? co_(Coding DiagnosisCode) {
                                            Code cq_ = DiagnosisCode?.CodeElement;
                                            string cr_ = cq_?.Value;
                                            IEnumerable<string> cs_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                            CqlBoolean ct_ = context.Operators.In<string>(cr_, cs_);
                                            return ct_;
                                        }

                                        CqlBoolean cp_ = context.Operators.WhereAny<Coding>(cn_, co_);
                                        return cp_;
                                    }

                                    return /* CQL 'and' (217:19-220:21) */ (ck_
                                        && cl_());
                                }

                                CqlBoolean cg_ = context.Operators.WhereAny<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)ce_, cf_);
                                return cg_;
                            }

                            IEnumerable<Claim> cc_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ca_, cb_);
                            Claim cd_ = context.Operators.SingletonFrom<Claim>(cc_);
                            bu_ = cd_;
                        }
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? bv_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)bt_, bu_);
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] bw_ = [
                            bv_,
                        ];

                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bx_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition) {
                            if (((bool?)(/* CQL 'and' (223:25-224:62) */ ((CqlBoolean)(!((bool?)(LineItemDefinition is null)))
                                && !((bool?)(LineItemDefinition?.LineItems is null))))) ?? false)
                            {
                                Claim cu_ = LineItemDefinition?.LineItems;
                                List<Claim.ItemComponent> cv_ = cu_?.Item;

                                CqlInterval<CqlDateTime> cw_(Claim.ItemComponent NormalDate) {
                                    DataType cz_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> da_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, cz_);
                                    return da_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime>> cx_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)cv_, cw_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? cy_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, cu_, cx_);
                                return cy_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> by_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)bw_, bx_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(by_);
                        return bz_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> br_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)bp_, bq_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(br_);
                    return bs_;
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
                        CqlBoolean y_ = context.Operators.Equal(x_, 1);

                        CqlBoolean z_() {
                            DataType aa_ = RightDiagnosis?.Diagnosis;
                            IEnumerable<Coding> ab_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(aa_, "coding");

                            bool? ac_(Coding DiagnosisCode) {
                                Code ae_ = DiagnosisCode?.CodeElement;
                                string af_ = ae_?.Value;
                                IEnumerable<string> ag_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                                CqlBoolean ah_ = context.Operators.In<string>(af_, ag_);
                                return ah_;
                            }

                            CqlBoolean ad_ = context.Operators.WhereAny<Coding>(ab_, ac_);
                            return ad_;
                        }

                        return /* CQL 'and' (244:13-247:15) */ (y_
                            && z_());
                    }

                    CqlBoolean u_ = context.Operators.WhereAny<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)s_, t_);
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
                IEnumerable<Claim> ai_ = LineItemDefinition?.LineItems;

                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? aj_(Claim ClaimWithDiagnosis) {
                    if ((!((bool?)(ClaimWithDiagnosis is null))) ?? false)
                    {
                        IEnumerable<Claim> an_ = LineItemDefinition?.LineItems;

                        bool? ao_(Claim @this) {
                            List<Claim.ItemComponent> av_ = @this?.Item;
                            return !((bool?)(av_ is null));
                        }


                        List<Claim.ItemComponent> ap_(Claim @this) {
                            List<Claim.ItemComponent> aw_ = @this?.Item;
                            return aw_;
                        }

                        IEnumerable<List<Claim.ItemComponent>> aq_ = context.Operators.WhereSelect<Claim, List<Claim.ItemComponent>>(an_, ao_, ap_);
                        IEnumerable<Claim.ItemComponent> ar_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)aq_);

                        CqlInterval<CqlDateTime> as_(Claim.ItemComponent NormalDate) {
                            DataType ax_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> ay_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ax_);
                            return ay_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime>> at_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(ar_, as_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? au_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, an_, at_);
                        return au_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ak_ = context.Operators.SelectDistinct<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ai_, aj_);
                bool? al_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList) => !((bool?)(FinalList is null));
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> am_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ak_, al_);
                return am_;
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
            IEnumerable<ClaimResponse> j_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            if (((bool?)(/* CQL 'and' (262:15-264:5) */ ((CqlBoolean)(j_ is null)
                && (MedicalClaimAndResponse?.MedicalClaim is null)))) ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
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
                            Claim ai_ = medClaim?.ClaimofInterest;
                            bool aj_ = ai_ is Resource;
                            if (aj_)
                            {
                                z_ = (ai_ as Resource).IdElement;
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
                            CqlBoolean ag_ = context.Operators.Equal(aa_, af_);

                            CqlBoolean ah_() {
                                PositiveInt ak_ = medClaimLineItem?.SequenceElement;
                                Integer al_ = context.Operators.Convert<Integer>(ak_);
                                PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
                                Integer an_ = context.Operators.Convert<Integer>(am_);
                                CqlBoolean ao_ = context.Operators.Equal(al_, an_);
                                return ao_;
                            }

                            return /* CQL 'and' (313:29-314:79) */ (ag_
                                && ah_());
                        }

                        CqlBoolean y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent>(w_, x_);
                        return y_;
                    }

                    CqlBoolean v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
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
                CqlBoolean az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                if (az_.IsTrue)
                {

                    bool? bc_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bm_ = @this?.PaidClaim;
                        return !((bool?)(bm_ is null));
                    }


                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_ = @this?.PaidClaim;
                        return bn_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> be_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(au_, bc_, bd_);

                    bool? bf_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bo_ = @this?.ClaimItem;
                        return !((bool?)(bo_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bp_ = @this?.ClaimItem;
                        return bp_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, bf_, bg_);
                    IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);

                    CqlInterval<CqlDateTime> bj_(Claim.ItemComponent PaidItem) {
                        DataType bq_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> br_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bq_);
                        return br_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bi_, bj_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bl_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, be_, bk_);
                    ap_ = bl_;
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
            CqlBoolean k_ = context.Operators.In<string>(i_, (IEnumerable<string>)j_);
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
                        CodeableConcept ah_ = @this?.Category;
                        return !((bool?)(ah_ is null));
                    }


                    CodeableConcept y_(ClaimResponse.AdjudicationComponent @this) {
                        CodeableConcept ai_ = @this?.Category;
                        return ai_;
                    }

                    IEnumerable<CodeableConcept> z_ = context.Operators.WhereSelect<ClaimResponse.AdjudicationComponent, CodeableConcept>((IEnumerable<ClaimResponse.AdjudicationComponent>)w_, x_, y_);

                    bool? aa_(CodeableConcept @this) {
                        List<Coding> aj_ = @this?.Coding;
                        return !((bool?)(aj_ is null));
                    }


                    List<Coding> ab_(CodeableConcept @this) {
                        List<Coding> ak_ = @this?.Coding;
                        return ak_;
                    }

                    IEnumerable<List<Coding>> ac_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(z_, aa_, ab_);
                    IEnumerable<Coding> ad_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ac_);

                    bool? ae_(Coding CategoryItem) {
                        Code al_ = CategoryItem?.CodeElement;
                        string am_ = al_?.Value;
                        CqlBoolean an_ = context.Operators.Equal(am_, "benefit");
                        return an_;
                    }

                    CqlBoolean af_ = context.Operators.WhereAny<Coding>(ad_, ae_);

                    CqlBoolean ag_() {
                        List<ClaimResponse.AdjudicationComponent> ao_ = ResponseItem?.Adjudication;

                        bool? ap_(ClaimResponse.AdjudicationComponent @this) {
                            Money au_ = @this?.Amount;
                            return !((bool?)(au_ is null));
                        }


                        Money aq_(ClaimResponse.AdjudicationComponent @this) {
                            Money av_ = @this?.Amount;
                            return av_;
                        }

                        IEnumerable<Money> ar_ = context.Operators.WhereSelect<ClaimResponse.AdjudicationComponent, Money>((IEnumerable<ClaimResponse.AdjudicationComponent>)ao_, ap_, aq_);

                        bool? as_(Money DollarAmount) {
                            FhirDecimal aw_ = DollarAmount?.ValueElement;
                            decimal? ax_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, aw_);
                            decimal? ay_ = context.Operators.ConvertIntegerToDecimal(0);
                            CqlBoolean az_ = context.Operators.Greater(ax_, ay_);
                            return az_;
                        }

                        CqlBoolean at_ = context.Operators.WhereAny<Money>(ar_, as_);
                        return at_;
                    }

                    return /* CQL 'and' (434:13-440:13) */ (af_
                        && ag_());
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
                CodeableConcept p_ = @this?.ProductOrService;
                return !((bool?)(p_ is null));
            }


            CodeableConcept g_(Claim.ItemComponent @this) {
                CodeableConcept q_ = @this?.ProductOrService;
                return q_;
            }

            IEnumerable<CodeableConcept> h_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)e_, f_, g_);

            bool? i_(CodeableConcept @this) {
                List<Coding> r_ = @this?.Coding;
                return !((bool?)(r_ is null));
            }


            List<Coding> j_(CodeableConcept @this) {
                List<Coding> s_ = @this?.Coding;
                return s_;
            }

            IEnumerable<List<Coding>> k_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(h_, i_, j_);
            IEnumerable<Coding> l_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)k_);

            bool? m_(Coding ProductOrServiceCode) {
                CqlCode t_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                CqlBoolean u_ = context.Operators.In<CqlCode>(t_, ProductOrServiceValueSet);
                return u_;
            }

            CqlBoolean n_ = context.Operators.WhereAny<Coding>(l_, m_);

            CqlBoolean o_() {
                List<Claim.DiagnosisComponent> v_ = AllClaims?.Diagnosis;

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

                bool? ae_(Coding DiagnosisCode) {
                    CqlCode al_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                    CqlBoolean am_ = context.Operators.In<CqlCode>(al_, DiagnosisValueSet);
                    return am_;
                }

                IEnumerable<Coding> af_ = context.Operators.SelectWhere<object, Coding>(ac_, ad_, ae_);
                CqlBoolean ag_ = context.Operators.Exists<Coding>(af_);
                return ag_;
            }

            return /* CQL 'and' (446:5-451:7) */ (n_
                && o_());
        }


        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? b_(Claim ProcedureClaims) {
            Id an_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> ao_ = ProcedureClaims?.Item;

            bool? ap_(Claim.ItemComponent ResponseItem) {
                CodeableConcept as_ = ResponseItem?.ProductOrService;
                List<Coding> at_ = as_?.Coding;

                bool? au_(Coding ProductOrServiceCode) {
                    CqlCode aw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    CqlBoolean ax_ = context.Operators.In<CqlCode>(aw_, ProductOrServiceValueSet);
                    return ax_;
                }

                CqlBoolean av_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)at_, au_);
                return av_;
            }

            IEnumerable<Claim.ItemComponent> aq_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ao_, ap_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ar_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, an_, aq_);
            return ar_;
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
            IEnumerable<ClaimResponse> f_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            if (((bool?)(/* CQL 'and' (270:15-272:5) */ ((CqlBoolean)(f_ is null)
                && (MedicalClaimAndResponse?.MedicalClaim is null)))) ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
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
                            Claim ai_ = medClaim?.ClaimofInterest;
                            bool aj_ = ai_ is Resource;
                            if (aj_)
                            {
                                z_ = (ai_ as Resource).IdElement;
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
                            CqlBoolean ag_ = context.Operators.Equal(aa_, af_);

                            CqlBoolean ah_() {
                                PositiveInt ak_ = medClaimLineItem?.SequenceElement;
                                Integer al_ = context.Operators.Convert<Integer>(ak_);
                                PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
                                Integer an_ = context.Operators.Convert<Integer>(am_);
                                CqlBoolean ao_ = context.Operators.Equal(al_, an_);
                                return ao_;
                            }

                            return /* CQL 'and' (342:29-343:79) */ (ag_
                                && ah_());
                        }

                        CqlBoolean y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent>(w_, x_);
                        return y_;
                    }

                    CqlBoolean v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
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
                CqlBoolean az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                if (az_.IsTrue)
                {

                    bool? bc_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bm_ = @this?.PaidClaim;
                        return !((bool?)(bm_ is null));
                    }


                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_ = @this?.PaidClaim;
                        return bn_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> be_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(au_, bc_, bd_);

                    bool? bf_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bo_ = @this?.ClaimItem;
                        return !((bool?)(bo_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bp_ = @this?.ClaimItem;
                        return bp_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, bf_, bg_);
                    IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);

                    CqlInterval<CqlDateTime> bj_(Claim.ItemComponent PaidItem) {
                        DataType bq_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> br_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bq_);
                        return br_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bi_, bj_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bl_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, be_, bk_);
                    ap_ = bl_;
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
                CodeableConcept p_ = @this?.ProductOrService;
                return !((bool?)(p_ is null));
            }


            CodeableConcept g_(Claim.ItemComponent @this) {
                CodeableConcept q_ = @this?.ProductOrService;
                return q_;
            }

            IEnumerable<CodeableConcept> h_ = context.Operators.WhereSelect<Claim.ItemComponent, CodeableConcept>((IEnumerable<Claim.ItemComponent>)e_, f_, g_);

            bool? i_(CodeableConcept @this) {
                List<Coding> r_ = @this?.Coding;
                return !((bool?)(r_ is null));
            }


            List<Coding> j_(CodeableConcept @this) {
                List<Coding> s_ = @this?.Coding;
                return s_;
            }

            IEnumerable<List<Coding>> k_ = context.Operators.WhereSelect<CodeableConcept, List<Coding>>(h_, i_, j_);
            IEnumerable<Coding> l_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)k_);

            bool? m_(Coding ProductOrServiceCode) {
                CqlCode t_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                CqlBoolean u_ = context.Operators.In<CqlCode>(t_, ProductOrServiceValueSet);
                return u_;
            }

            CqlBoolean n_ = context.Operators.WhereAny<Coding>(l_, m_);

            CqlBoolean o_() {
                List<Claim.DiagnosisComponent> v_ = AllClaims?.Diagnosis;

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

                bool? ae_(Coding DiagnosisCode) {
                    CqlCode al_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                    CqlBoolean am_ = context.Operators.In<CqlCode>(al_, DiagnosisValueSet);
                    return am_;
                }

                IEnumerable<Coding> af_ = context.Operators.SelectWhere<object, Coding>(ac_, ad_, ae_);
                CqlBoolean ag_ = context.Operators.Exists<Coding>(af_);
                return ag_;
            }

            return /* CQL 'or' (464:5-469:7) */ (n_
                || o_());
        }


        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? b_(Claim ProcedureClaims) {
            List<Claim.ItemComponent> an_ = ProcedureClaims?.Item;

            bool? ao_(Claim.ItemComponent ResponseItem) {
                CodeableConcept aq_ = ResponseItem?.ProductOrService;
                List<Coding> ar_ = aq_?.Coding;

                bool? as_(Coding ProductOrServiceCode) {
                    CqlCode au_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    CqlBoolean av_ = context.Operators.In<CqlCode>(au_, ProductOrServiceValueSet);
                    return av_;
                }

                CqlBoolean at_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)ar_, as_);
                return at_;
            }

            CqlBoolean ap_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)an_, ao_);
            if (ap_.IsTrue)
            {
                Id aw_ = ProcedureClaims?.IdElement;

                bool? ax_(Claim.ItemComponent ResponseItem) {
                    CodeableConcept ba_ = ResponseItem?.ProductOrService;
                    List<Coding> bb_ = ba_?.Coding;

                    bool? bc_(Coding ProductOrServiceCode) {
                        CqlCode be_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                        CqlBoolean bf_ = context.Operators.In<CqlCode>(be_, ProductOrServiceValueSet);
                        return bf_;
                    }

                    CqlBoolean bd_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)bb_, bc_);
                    return bd_;
                }

                IEnumerable<Claim.ItemComponent> ay_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)an_, ax_);
                (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? az_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, aw_, ay_);
                return az_;
            }
            else
            {
                Id bg_ = ProcedureClaims?.IdElement;

                bool? bh_(Claim.ItemComponent ResponseItem) {
                    PositiveInt bk_ = ResponseItem?.SequenceElement;
                    Integer bl_ = context.Operators.Convert<Integer>(bk_);
                    int? bm_ = bl_?.Value;
                    CqlBoolean bn_ = context.Operators.Equal(bm_, 1);
                    return bn_;
                }

                IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)an_, bh_);
                (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bj_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, bg_, bi_);
                return bj_;
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
            IEnumerable<ClaimResponse> f_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            if (((bool?)(/* CQL 'and' (277:15-279:5) */ ((CqlBoolean)(f_ is null)
                && (MedicalClaimAndResponse?.MedicalClaim is null)))) ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
            }
            else
            {
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
                            Claim ai_ = medClaim?.ClaimofInterest;
                            bool aj_ = ai_ is Resource;
                            if (aj_)
                            {
                                z_ = (ai_ as Resource).IdElement;
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
                            CqlBoolean ag_ = context.Operators.Equal(aa_, af_);

                            CqlBoolean ah_() {
                                PositiveInt ak_ = medClaimLineItem?.SequenceElement;
                                Integer al_ = context.Operators.Convert<Integer>(ak_);
                                PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
                                Integer an_ = context.Operators.Convert<Integer>(am_);
                                CqlBoolean ao_ = context.Operators.Equal(al_, an_);
                                return ao_;
                            }

                            return /* CQL 'and' (371:29-372:79) */ (ag_
                                && ah_());
                        }

                        CqlBoolean y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent>(w_, x_);
                        return y_;
                    }

                    CqlBoolean v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
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
                CqlBoolean az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                if (az_.IsTrue)
                {

                    bool? bc_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bm_ = @this?.PaidClaim;
                        return !((bool?)(bm_ is null));
                    }


                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bn_ = @this?.PaidClaim;
                        return bn_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> be_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(au_, bc_, bd_);

                    bool? bf_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bo_ = @this?.ClaimItem;
                        return !((bool?)(bo_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bp_ = @this?.ClaimItem;
                        return bp_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, bf_, bg_);
                    IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);

                    CqlInterval<CqlDateTime> bj_(Claim.ItemComponent PaidItem) {
                        DataType bq_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> br_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bq_);
                        return br_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bi_, bj_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bl_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, be_, bk_);
                    ap_ = bl_;
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
                CqlBoolean t_ = context.Operators.In<CqlCode>(s_, ProductOrServiceValueSet);
                return t_;
            }

            CqlBoolean n_ = context.Operators.WhereAny<Coding>(l_, m_);
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
                    CqlBoolean ae_ = context.Operators.In<CqlCode>(ad_, ProductOrServiceValueSet);
                    return ae_;
                }

                CqlBoolean ac_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)aa_, ab_);
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
            IEnumerable<ClaimResponse> f_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
            if (((bool?)(/* CQL 'and' (284:15-286:5) */ ((CqlBoolean)(f_ is null)
                && (PharmacyClaimAndResponse?.PharmacyClaim is null)))) ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
            }
            else
            {
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
                            Claim ai_ = medClaim?.Claim;
                            bool aj_ = ai_ is Resource;
                            if (aj_)
                            {
                                z_ = (ai_ as Resource).IdElement;
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
                            CqlBoolean ag_ = context.Operators.Equal(aa_, af_);

                            CqlBoolean ah_() {
                                PositiveInt ak_ = medClaimLineItem?.SequenceElement;
                                Integer al_ = context.Operators.Convert<Integer>(ak_);
                                PositiveInt am_ = pClaimLineItem?.ItemSequenceElement;
                                Integer an_ = context.Operators.Convert<Integer>(am_);
                                CqlBoolean ao_ = context.Operators.Equal(al_, an_);
                                return ao_;
                            }

                            return /* CQL 'and' (400:29-401:79) */ (ag_
                                && ah_());
                        }

                        CqlBoolean y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent>(w_, x_);
                        return y_;
                    }

                    CqlBoolean v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(t_, u_);
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
                CqlBoolean az_ = context.Operators.Exists<Claim.ItemComponent>(ay_);
                if (az_.IsTrue)
                {

                    bool? bc_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bs_ = @this?.PaidClaim;
                        return !((bool?)(bs_ is null));
                    }


                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bd_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bt_ = @this?.PaidClaim;
                        return bt_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> be_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(au_, bc_, bd_);

                    bool? bf_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bu_ = @this?.ClaimItem;
                        return !((bool?)(bu_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bv_ = @this?.ClaimItem;
                        return bv_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bh_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, bf_, bg_);
                    IEnumerable<Claim.ItemComponent> bi_ = context.Operators.Flatten<Claim.ItemComponent>(bh_);

                    CqlInterval<CqlDateTime> bj_(Claim.ItemComponent PaidItem) {
                        DataType bw_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime> bx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bw_);
                        return bx_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime>> bk_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDateTime>>(bi_, bj_);

                    bool? bl_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> by_ = @this?.ClaimItem;
                        return !((bool?)(by_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> bm_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent> bz_ = @this?.ClaimItem;
                        return bz_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> bn_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(au_, bl_, bm_);
                    IEnumerable<Claim.ItemComponent> bo_ = context.Operators.Flatten<Claim.ItemComponent>(bn_);

                    CqlInterval<CqlDate> bp_(Claim.ItemComponent i) {
                        if ((!((bool?)(i?.Quantity is null))) ?? false)
                        {
                            DataType ca_ = i?.Serviced;
                            CqlInterval<CqlDateTime> cb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ca_);
                            CqlDateTime cc_ = context.Operators.Start(cb_);
                            CqlDate cd_ = context.Operators.ConvertDateTimeToDate(cc_);
                            Quantity ce_ = i?.Quantity;
                            FhirDecimal cf_ = ce_?.ValueElement;
                            decimal? cg_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, cf_);
                            CqlDateTime ch_ = context.Operators.Add(cc_, new CqlQuantity(cg_, "day"));
                            CqlQuantity ci_ = context.Operators.Quantity(1m, "day");
                            CqlDateTime cj_ = context.Operators.Subtract(ch_, ci_);
                            CqlDate ck_ = context.Operators.ConvertDateTimeToDate(cj_);
                            CqlInterval<CqlDate> cl_ = context.Operators.Interval(cd_, ck_, true, true);
                            return cl_;
                        }
                        else
                        {
                            return null as CqlInterval<CqlDate>;
                        }
                    }

                    IEnumerable<CqlInterval<CqlDate>> bq_ = context.Operators.SelectDistinct<Claim.ItemComponent, CqlInterval<CqlDate>>(bo_, bp_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? br_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, be_, bk_, bq_);
                    ap_ = br_;
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
                CqlBoolean n_ = context.Operators.Equal(i_, m_);
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
                    CqlBoolean ai_ = context.Operators.Equal(ad_, ah_);
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
                CqlBoolean ab_ = context.Operators.Equal(p_, aa_);
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
                            CqlBoolean aa_ = context.Operators.StringInValueSet(y_, z_);
                            return aa_;
                        }

                        CqlBoolean x_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)v_, w_);
                        return x_;
                    }

                    CqlBoolean s_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)q_, r_);
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
                        CodeableConcept ai_ = i?.Revenue;
                        CqlConcept aj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ai_);
                        IReadOnlyList<CqlCode> ak_ = aj_?.codes;

                        bool? al_(CqlCode rev) {
                            string an_ = rev?.code;
                            CqlValueSet ao_ = this.Nonacute_Inpatient_Stay(context);
                            CqlBoolean ap_ = context.Operators.StringInValueSet(an_, ao_);
                            return ap_;
                        }

                        CqlBoolean am_ = context.Operators.WhereAny<CqlCode>((IEnumerable<CqlCode>)ak_, al_);
                        return am_;
                    }

                    CqlBoolean ag_ = context.Operators.WhereAny<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ae_, af_);

                    CqlBoolean ah_() {
                        CodeableConcept aq_ = c?.SubType;
                        List<Coding> ar_ = aq_?.Coding;

                        bool? as_(Coding tob) {
                            Code au_ = tob?.CodeElement;
                            string av_ = au_?.Value;
                            CqlValueSet aw_ = this.Nonacute_Inpatient_Stay(context);
                            CqlBoolean ax_ = context.Operators.StringInValueSet(av_, aw_);
                            return ax_;
                        }

                        CqlBoolean at_ = context.Operators.WhereAny<Coding>((IEnumerable<Coding>)ar_, as_);
                        return at_;
                    }

                    return /* CQL 'or' (535:11-541:13) */ (ag_
                        || ah_());
                }

                IEnumerable<Claim> ad_ = context.Operators.Where<Claim>(ab_, ac_);
                h_ = ad_;
            }
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? i_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, g_, h_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] j_ = [
                i_,
            ];

            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? k_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition) {
                IEnumerable<Claim> ay_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> az_ = LineItemDefinition?.NonacuteInpatientLineItems;

                bool? ba_(Claim nonAcuteInpatientStay) {
                    IEnumerable<Claim> bf_ = LineItemDefinition?.InpatientStayLineItems;

                    bool? bg_(Claim inpatientStay) {
                        Id bi_ = nonAcuteInpatientStay?.IdElement;
                        Id bj_ = inpatientStay?.IdElement;
                        CqlBoolean bk_ = context.Operators.Equal(bi_, bj_);
                        return bk_;
                    }

                    CqlBoolean bh_ = context.Operators.WhereAny<Claim>(bf_, bg_);
                    return bh_;
                }

                IEnumerable<Claim> bb_ = context.Operators.Where<Claim>(az_, ba_);

                bool? bc_(Claim inpatientStay) {
                    IEnumerable<Claim> bl_ = LineItemDefinition?.NonacuteInpatientLineItems;

                    bool? bm_(Claim nonAcuteInpatientStay) {
                        Id bo_ = inpatientStay?.IdElement;
                        Id bp_ = nonAcuteInpatientStay?.IdElement;
                        CqlBoolean bq_ = context.Operators.Equal(bo_, bp_);
                        return bq_;
                    }

                    CqlBoolean bn_ = context.Operators.WhereAny<Claim>(bl_, bm_);
                    return !bn_;
                }

                IEnumerable<Claim> bd_ = context.Operators.Where<Claim>(ay_, bc_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? be_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, ay_, bb_, bd_);
                return be_;
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
                CqlBoolean y_ = context.Operators.Equal(x_, 1);
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
                CqlBoolean ae_ = context.Operators.Equal(ad_, 1);
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
                CqlBoolean bd_ = context.Operators.In<string>(ax_, bc_);
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
                        CqlBoolean ca_ = context.Operators.Equal(bz_, "http://hl7.org/fhir/sid/us-npi");

                        CqlBoolean cb_() {
                            CodeableConcept cd_ = l?.Type;
                            CqlConcept ce_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cd_);
                            CqlCode cf_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                            CqlConcept cg_ = context.Operators.ConvertCodeToConcept(cf_);
                            CqlBoolean ch_ = context.Operators.Equivalent(ce_, cg_);
                            return ch_;
                        }


                        CqlBoolean cc_() {
                            FhirString ci_ = l?.ValueElement;
                            string cj_ = ci_?.Value;
                            return !((bool?)(cj_ is null));
                        }

                        return /* CQL 'and' (579:19-581:49) */ (/* CQL 'and' (579:25-580:73) */ (ca_
                            && cb_())
                            && cc_());
                    }


                    FhirString br_(Identifier l) {
                        FhirString ck_ = l?.ValueElement;
                        return ck_;
                    }

                    IEnumerable<FhirString> bs_ = context.Operators.WhereSelect<Identifier, FhirString>((IEnumerable<Identifier>)bp_, bq_, br_);
                    IEnumerable<FhirString> bt_ = context.Operators.Distinct<FhirString>(bs_);

                    bool? bu_(Identifier l) {
                        FhirUri cl_ = l?.SystemElement;
                        string cm_ = cl_?.Value;
                        CqlBoolean cn_ = context.Operators.Equal(cm_, "http://hl7.org/fhir/sid/us-npi");

                        CqlBoolean co_() {
                            CodeableConcept cq_ = l?.Type;
                            CqlConcept cr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cq_);
                            CqlCode cs_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                            CqlConcept ct_ = context.Operators.ConvertCodeToConcept(cs_);
                            CqlBoolean cu_ = context.Operators.Equivalent(cr_, ct_);
                            return cu_;
                        }


                        CqlBoolean cp_() {
                            FhirString cv_ = l?.ValueElement;
                            string cw_ = cv_?.Value;
                            return cw_ is null;
                        }

                        return /* CQL 'and' (585:19-587:45) */ (/* CQL 'and' (585:25-586:73) */ (cn_
                            && co_())
                            && cp_());
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
                    int? cx_;
                    IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> cz_ = ClaimProperties?.CareTeams;

                    bool? da_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                        Claim de_ = @this?.SingleCareTeam;
                        return !((bool?)(de_ is null));
                    }


                    Claim db_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                        Claim df_ = @this?.SingleCareTeam;
                        return df_;
                    }

                    IEnumerable<Claim> dc_ = context.Operators.WhereSelect<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(cz_, da_, db_);
                    CqlBoolean dd_ = context.Operators.Exists<Claim>(dc_);
                    if (dd_.IsTrue)
                    {

                        bool? dg_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                            Claim dz_ = @this?.SingleCareTeam;
                            return !((bool?)(dz_ is null));
                        }


                        Claim dh_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this) {
                            Claim ea_ = @this?.SingleCareTeam;
                            return ea_;
                        }

                        IEnumerable<Claim> di_ = context.Operators.WhereSelect<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(cz_, dg_, dh_);

                        bool? dj_(Claim X) {
                            List<Claim.CareTeamComponent> eb_ = X?.CareTeam;
                            return ((IEnumerable<Claim.CareTeamComponent>)eb_) is null;
                        }

                        IEnumerable<Claim> dk_ = context.Operators.Where<Claim>(di_, dj_);
                        int? dl_ = context.Operators.Count<Claim>(dk_);
                        IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> dm_ = GetIdentifiers?.IdentifierTuple;

                        IEnumerable<FhirString> dn_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<FhirString> ec_ = X?.AllIdentifiers;
                            return ec_;
                        }

                        IEnumerable<IEnumerable<FhirString>> do_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(dm_, dn_);
                        IEnumerable<FhirString> dp_ = context.Operators.Flatten<FhirString>(do_);
                        FhirString dq_(FhirString X) => X;
                        IEnumerable<FhirString> dr_ = context.Operators.SelectDistinct<FhirString, FhirString>(dp_, dq_);
                        int? ds_ = context.Operators.Count<FhirString>(dr_);
                        int? dt_ = context.Operators.Add(dl_, ds_);

                        IEnumerable<Identifier> du_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<Identifier> ed_ = X?.NullIdentifiers;
                            return ed_;
                        }

                        IEnumerable<IEnumerable<Identifier>> dv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(dm_, du_);
                        IEnumerable<Identifier> dw_ = context.Operators.Flatten<Identifier>(dv_);
                        int? dx_ = context.Operators.Count<Identifier>(dw_);
                        int? dy_ = context.Operators.Add(dt_, dx_);
                        cx_ = dy_;
                    }
                    else
                    {
                        cx_ = 0;
                    }
                    (CqlTupleMetadata, int? IdentifierCount)? cy_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, cx_);
                    return cy_;
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
                CqlBoolean aa_ = context.Operators.Equal(z_, 1);
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
                CqlBoolean ag_ = context.Operators.Equal(af_, 1);
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
                CqlBoolean bf_ = context.Operators.In<string>(az_, be_);
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
                        CqlBoolean cc_ = context.Operators.Equal(cb_, "http://hl7.org/fhir/sid/us-npi");

                        CqlBoolean cd_() {
                            CodeableConcept cf_ = l?.Type;
                            CqlConcept cg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cf_);
                            CqlCode ch_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                            CqlConcept ci_ = context.Operators.ConvertCodeToConcept(ch_);
                            CqlBoolean cj_ = context.Operators.Equivalent(cg_, ci_);
                            return cj_;
                        }


                        CqlBoolean ce_() {
                            FhirString ck_ = l?.ValueElement;
                            string cl_ = ck_?.Value;
                            return !((bool?)(cl_ is null));
                        }

                        return /* CQL 'and' (635:19-637:49) */ (/* CQL 'and' (635:25-636:73) */ (cc_
                            && cd_())
                            && ce_());
                    }


                    FhirString bt_(Identifier l) {
                        FhirString cm_ = l?.ValueElement;
                        return cm_;
                    }

                    IEnumerable<FhirString> bu_ = context.Operators.WhereSelect<Identifier, FhirString>((IEnumerable<Identifier>)br_, bs_, bt_);
                    IEnumerable<FhirString> bv_ = context.Operators.Distinct<FhirString>(bu_);

                    bool? bw_(Identifier l) {
                        FhirUri cn_ = l?.SystemElement;
                        string co_ = cn_?.Value;
                        CqlBoolean cp_ = context.Operators.Equal(co_, "http://hl7.org/fhir/sid/us-npi");

                        CqlBoolean cq_() {
                            CodeableConcept cs_ = l?.Type;
                            CqlConcept ct_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cs_);
                            CqlCode cu_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                            CqlConcept cv_ = context.Operators.ConvertCodeToConcept(cu_);
                            CqlBoolean cw_ = context.Operators.Equivalent(ct_, cv_);
                            return cw_;
                        }


                        CqlBoolean cr_() {
                            FhirString cx_ = l?.ValueElement;
                            string cy_ = cx_?.Value;
                            return cy_ is null;
                        }

                        return /* CQL 'and' (641:19-643:45) */ (/* CQL 'and' (641:25-642:73) */ (cp_
                            && cq_())
                            && cr_());
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
                    int? cz_;
                    IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> db_ = ClaimProperties?.ItemsLocationReferences;

                    bool? dc_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                        IEnumerable<Claim.ItemComponent> dh_ = @this?.SingleItem;
                        return !((bool?)(dh_ is null));
                    }


                    IEnumerable<Claim.ItemComponent> dd_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                        IEnumerable<Claim.ItemComponent> di_ = @this?.SingleItem;
                        return di_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent>> de_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(db_, dc_, dd_);
                    IEnumerable<Claim.ItemComponent> df_ = context.Operators.Flatten<Claim.ItemComponent>(de_);
                    CqlBoolean dg_ = context.Operators.Exists<Claim.ItemComponent>(df_);
                    if (dg_.IsTrue)
                    {

                        bool? dj_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                            IEnumerable<ResourceReference> ed_ = @this?.ItemLocation;
                            return !((bool?)(ed_ is null));
                        }


                        IEnumerable<ResourceReference> dk_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this) {
                            IEnumerable<ResourceReference> ee_ = @this?.ItemLocation;
                            return ee_;
                        }

                        IEnumerable<IEnumerable<ResourceReference>> dl_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(db_, dj_, dk_);
                        IEnumerable<ResourceReference> dm_ = context.Operators.Flatten<ResourceReference>(dl_);

                        bool? dn_(ResourceReference X) {
                            FhirString ef_ = X?.ReferenceElement;
                            string eg_ = ef_?.Value;
                            return eg_ is null;
                        }

                        IEnumerable<ResourceReference> do_ = context.Operators.Where<ResourceReference>(dm_, dn_);
                        int? dp_ = context.Operators.Count<ResourceReference>(do_);
                        IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> dq_ = GetIdentifiers?.IdentifierTuple;

                        IEnumerable<FhirString> dr_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<FhirString> eh_ = X?.AllIdentifiers;
                            return eh_;
                        }

                        IEnumerable<IEnumerable<FhirString>> ds_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(dq_, dr_);
                        IEnumerable<FhirString> dt_ = context.Operators.Flatten<FhirString>(ds_);
                        FhirString du_(FhirString X) => X;
                        IEnumerable<FhirString> dv_ = context.Operators.SelectDistinct<FhirString, FhirString>(dt_, du_);
                        int? dw_ = context.Operators.Count<FhirString>(dv_);
                        int? dx_ = context.Operators.Add(dp_, dw_);

                        IEnumerable<Identifier> dy_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X) {
                            IEnumerable<Identifier> ei_ = X?.NullIdentifiers;
                            return ei_;
                        }

                        IEnumerable<IEnumerable<Identifier>> dz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(dq_, dy_);
                        IEnumerable<Identifier> ea_ = context.Operators.Flatten<Identifier>(dz_);
                        int? eb_ = context.Operators.Count<Identifier>(ea_);
                        int? ec_ = context.Operators.Add(dx_, eb_);
                        cz_ = ec_;
                    }
                    else
                    {
                        cz_ = 0;
                    }
                    (CqlTupleMetadata, int? IdentifierCount)? da_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, cz_);
                    return da_;
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
