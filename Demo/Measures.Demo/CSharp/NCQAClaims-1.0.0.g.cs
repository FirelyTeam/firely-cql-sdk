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
    public IEnumerable<Claim?>? Professional_or_Institutional_Claims(CqlContext context, IEnumerable<Claim?>? claim)
    {

        bool? a_(Claim? MedicalClaim) {
            CodeableConcept? c_ = MedicalClaim?.Type;
            CqlConcept? d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            IReadOnlyList<CqlCode>? e_ = d_?.codes;
            CqlCode? f_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? g_ = context.Operators.Contains<CqlCode?>((IEnumerable<CqlCode?>?)e_, f_);
            CqlCode? h_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? i_ = context.Operators.Contains<CqlCode?>((IEnumerable<CqlCode?>?)e_, h_);
            bool? j_ = context.Operators.Or(g_, i_);
            return j_;
        }

        IEnumerable<Claim?>? b_ = context.Operators.Where<Claim?>(claim, a_);
        return b_;
    }


    [CqlFunctionDefinition("Pharmacy Claims")]
    public IEnumerable<Claim?>? Pharmacy_Claims(CqlContext context, IEnumerable<Claim?>? claim)
    {

        bool? a_(Claim? PharmacyClaim) {
            CodeableConcept? c_ = PharmacyClaim?.Type;
            CqlConcept? d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            IReadOnlyList<CqlCode>? e_ = d_?.codes;
            CqlCode? f_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? g_ = context.Operators.Contains<CqlCode?>((IEnumerable<CqlCode?>?)e_, f_);
            return g_;
        }

        IEnumerable<Claim?>? b_ = context.Operators.Where<Claim?>(claim, a_);
        return b_;
    }


    [CqlFunctionDefinition("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse?>? Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse)
    {

        bool? a_(ClaimResponse? MedicalResponse) {
            CodeableConcept? c_ = MedicalResponse?.Type;
            CqlConcept? d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            IReadOnlyList<CqlCode>? e_ = d_?.codes;
            CqlCode? f_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? g_ = context.Operators.Contains<CqlCode?>((IEnumerable<CqlCode?>?)e_, f_);
            CqlCode? h_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? i_ = context.Operators.Contains<CqlCode?>((IEnumerable<CqlCode?>?)e_, h_);
            bool? j_ = context.Operators.Or(g_, i_);
            return j_;
        }

        IEnumerable<ClaimResponse?>? b_ = context.Operators.Where<ClaimResponse?>(claimResponse, a_);
        return b_;
    }


    [CqlFunctionDefinition("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse?>? Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse)
    {

        bool? a_(ClaimResponse? PharmacyResponse) {
            CodeableConcept? c_ = PharmacyResponse?.Type;
            CqlConcept? d_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, c_);
            IReadOnlyList<CqlCode>? e_ = d_?.codes;
            CqlCode? f_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? g_ = context.Operators.Contains<CqlCode?>((IEnumerable<CqlCode?>?)e_, f_);
            return g_;
        }

        IEnumerable<ClaimResponse?>? b_ = context.Operators.Where<ClaimResponse?>(claimResponse, a_);
        return b_;
    }


    [CqlFunctionDefinition("Medical Claims With Procedure and POS")]
    public IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? posCodes, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {
        IEnumerable<Claim?>? a_ = this.Professional_or_Institutional_Claims(context, claim);

        string? b_(CqlCode? p) {
            string? k_ = p?.code;
            return k_;
        }

        IEnumerable<string?>? c_ = context.Operators.SelectDistinct<CqlCode?, string?>(ProductOrServiceValueSet, b_);

        string? d_(CqlCode? pos) {
            string? l_ = pos?.code;
            return l_;
        }

        IEnumerable<string?>? e_ = context.Operators.SelectDistinct<CqlCode?, string?>(posCodes, d_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings, IEnumerable<string?>? POSAsString)? f_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, a_, c_, e_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings, IEnumerable<string?>? POSAsString)?[]? g_ = [
            f_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? h_((CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings, IEnumerable<string?>? POSAsString)? ClaimWithPosCode) {
            IEnumerable<Claim>? m_ = ClaimWithPosCode?.MedicalClaim;

            (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? n_(Claim? ClaimofInterest) {
                IEnumerable<Claim.ItemComponent>? r_;
                if (ClaimofInterest is null)
                {
                    r_ = null as IEnumerable<Claim.ItemComponent?>;
                }
                else
                {
                    List<Claim.ItemComponent>? x_ = ClaimofInterest?.Item;

                    bool? y_(Claim.ItemComponent? ItemOnLine) {
                        CodeableConcept? aa_ = ItemOnLine?.ProductOrService;
                        CqlConcept? ab_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, aa_);
                        IReadOnlyList<CqlCode>? ac_ = ab_?.codes;

                        bool? ad_(CqlCode? LineCode) {
                            string? al_ = LineCode?.code;
                            IEnumerable<string>? am_ = ClaimWithPosCode?.ProceduresAsStrings;
                            bool? an_ = context.Operators.In<string?>(al_, am_);
                            return an_;
                        }

                        bool? ae_ = context.Operators.WhereAny<CqlCode?>((IEnumerable<CqlCode?>?)ac_, ad_);
                        DataType? af_ = ItemOnLine?.Location;
                        CqlConcept? ag_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, af_ as CodeableConcept);
                        IReadOnlyList<CqlCode>? ah_ = ag_?.codes;

                        bool? ai_(CqlCode? PosCode) {
                            string? ao_ = PosCode?.code;
                            IEnumerable<string>? ap_ = ClaimWithPosCode?.POSAsString;
                            bool? aq_ = context.Operators.In<string?>(ao_, ap_);
                            return aq_;
                        }

                        bool? aj_ = context.Operators.WhereAny<CqlCode?>((IEnumerable<CqlCode?>?)ah_, ai_);
                        bool? ak_ = context.Operators.And(ae_, aj_);
                        return ak_;
                    }

                    IEnumerable<Claim.ItemComponent?>? z_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)x_, y_);
                    r_ = z_;
                }
                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)? s_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, r_);
                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?[]? t_ = [
                    s_,
                ];

                (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? u_((CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)? LineItemDefinition) {
                    IEnumerable<Claim.ItemComponent>? ar_ = LineItemDefinition?.LineItems;
                    bool? as_ = context.Operators.Exists<Claim.ItemComponent?>(ar_!);
                    if (as_ ?? false)
                    {
                        Claim? at_ = LineItemDefinition?.Claim;
                        IEnumerable<Claim.ItemComponent>? au_ = LineItemDefinition?.LineItems;

                        bool? av_(Claim.ItemComponent? @this) {
                            DataType? bb_ = @this?.Serviced;
                            bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                            return bc_;
                        }


                        object aw_(Claim.ItemComponent? @this) {
                            DataType? bd_ = @this?.Serviced;
                            return bd_!;
                        }

                        IEnumerable<object?>? ax_ = context.Operators.WhereSelect<Claim.ItemComponent?, object?>(au_, av_, aw_);

                        CqlInterval<CqlDateTime?>? ay_(object? NormalDate) {
                            CqlInterval<CqlDateTime?>? be_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                            return be_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime?>?>? az_ = context.Operators.SelectDistinct<object?, CqlInterval<CqlDateTime?>?>(ax_, ay_);
                        (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? ba_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, at_, az_);
                        return ba_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? v_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?>?)t_, u_);
                (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? w_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(v_);
                return w_;
            }

            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? o_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(m_, n_);

            bool? p_((CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                bool? bf_ = context.Operators.Not((bool?)(FinalList is null));
                return bf_;
            }

            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? q_ = context.Operators.Where<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(o_, p_);
            return q_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>? i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings, IEnumerable<string?>? POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings, IEnumerable<string?>? POSAsString)?>?)g_, h_);
        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {
        IEnumerable<Claim?>? a_ = this.Professional_or_Institutional_Claims(context, claim);

        string? b_(CqlCode? p) {
            string? i_ = p?.code;
            return i_;
        }

        IEnumerable<string?>? c_ = context.Operators.SelectDistinct<CqlCode?, string?>(ProductOrServiceValueSet, b_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings)? d_ = (CqlTupleMetadata_FOGIeViDYfJOhRYAGIOCbEeNO, a_, c_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings)?[]? e_ = [
            d_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? f_((CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings)? ClaimWithProcedure) {
            IEnumerable<Claim>? j_ = ClaimWithProcedure?.MedicalClaim;

            (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? k_(Claim? ClaimofInterest) {
                IEnumerable<Claim.ItemComponent>? o_;
                if (ClaimofInterest is null)
                {
                    o_ = null as IEnumerable<Claim.ItemComponent?>;
                }
                else
                {
                    List<Claim.ItemComponent>? u_ = ClaimofInterest?.Item;

                    bool? v_(Claim.ItemComponent? ItemOnLine) {
                        CodeableConcept? x_ = ItemOnLine?.ProductOrService;
                        CqlConcept? y_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, x_);
                        IReadOnlyList<CqlCode>? z_ = y_?.codes;

                        bool? aa_(CqlCode? LineCode) {
                            string? ap_ = LineCode?.code;
                            IEnumerable<string>? aq_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? ar_ = context.Operators.In<string?>(ap_, aq_);
                            return ar_;
                        }

                        bool? ab_ = context.Operators.WhereAny<CqlCode?>((IEnumerable<CqlCode?>?)z_, aa_);
                        List<Claim.ProcedureComponent>? ac_ = ClaimofInterest?.Procedure;

                        bool? ad_(Claim.ProcedureComponent? @this) {
                            DataType? as_ = @this?.Procedure;
                            bool? at_ = context.Operators.Not((bool?)(as_ is null));
                            return at_;
                        }


                        object ae_(Claim.ProcedureComponent? @this) {
                            DataType? au_ = @this?.Procedure;
                            return au_!;
                        }

                        IEnumerable<object?>? af_ = context.Operators.WhereSelect<Claim.ProcedureComponent?, object?>((IEnumerable<Claim.ProcedureComponent?>?)ac_, ad_, ae_);

                        bool? ag_(object? @this) {
                            object? av_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                            bool? aw_ = context.Operators.Not((bool?)(av_ is null));
                            return aw_;
                        }


                        object ah_(object? @this) {
                            object? ax_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                            return ax_!;
                        }

                        IEnumerable<object?>? ai_ = context.Operators.WhereSelect<object?, object?>(af_, ag_, ah_);
                        IEnumerable<object?>? aj_ = context.Operators.FlattenLateBoundList(((IEnumerable<object>)ai_)!);
                        Coding? ak_(object? @object) => (Coding?)@object;

                        bool? al_(Coding? HeaderCode) {
                            Code? ay_ = HeaderCode?.CodeElement;
                            string? az_ = ay_?.Value;
                            IEnumerable<string>? ba_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? bb_ = context.Operators.In<string?>(az_, ba_);
                            return bb_;
                        }

                        IEnumerable<Coding?>? am_ = context.Operators.SelectWhere<object?, Coding?>(aj_, ak_, al_);
                        bool? an_ = context.Operators.Exists<Coding?>(am_!);
                        bool? ao_ = context.Operators.Or(ab_, an_);
                        return ao_;
                    }

                    IEnumerable<Claim.ItemComponent?>? w_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)u_, v_);
                    o_ = w_;
                }
                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)? p_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, o_);
                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?[]? q_ = [
                    p_,
                ];

                (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? r_((CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)? LineItemDefinition) {
                    IEnumerable<Claim.ItemComponent>? bc_ = LineItemDefinition?.LineItems;
                    bool? bd_ = context.Operators.Exists<Claim.ItemComponent?>(bc_!);
                    if (bd_ ?? false)
                    {
                        Claim? be_ = LineItemDefinition?.Claim;
                        IEnumerable<Claim.ItemComponent>? bf_ = LineItemDefinition?.LineItems;

                        bool? bg_(Claim.ItemComponent? @this) {
                            DataType? bm_ = @this?.Serviced;
                            bool? bn_ = context.Operators.Not((bool?)(bm_ is null));
                            return bn_;
                        }


                        object bh_(Claim.ItemComponent? @this) {
                            DataType? bo_ = @this?.Serviced;
                            return bo_!;
                        }

                        IEnumerable<object?>? bi_ = context.Operators.WhereSelect<Claim.ItemComponent?, object?>(bf_, bg_, bh_);

                        CqlInterval<CqlDateTime?>? bj_(object? NormalDate) {
                            CqlInterval<CqlDateTime?>? bp_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                            return bp_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime?>?>? bk_ = context.Operators.SelectDistinct<object?, CqlInterval<CqlDateTime?>?>(bi_, bj_);
                        (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? bl_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, be_, bk_);
                        return bl_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? s_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?>?)q_, r_);
                (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? t_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(s_);
                return t_;
            }

            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? l_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(j_, k_);

            bool? m_((CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                bool? bq_ = context.Operators.Not((bool?)(FinalList is null));
                return bq_;
            }

            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? n_ = context.Operators.Where<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(l_, m_);
            return n_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>? g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? ProceduresAsStrings)?>?)e_, f_);
        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? h_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Medical Claims With Diagnosis")]
    public (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? DiagnosisValueSet)
    {
        IEnumerable<Claim?>? a_ = this.Professional_or_Institutional_Claims(context, claim);

        string? b_(CqlCode? d) {
            string? i_ = d?.code;
            return i_;
        }

        IEnumerable<string?>? c_ = context.Operators.SelectDistinct<CqlCode?, string?>(DiagnosisValueSet, b_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)? d_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, a_, c_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)?[]? e_ = [
            d_,
        ];

        (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? f_((CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim>? j_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                j_ = null as IEnumerable<Claim?>;
            }
            else
            {
                IEnumerable<Claim>? p_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? q_(Claim? DiagnosisLine) {
                    List<Claim.DiagnosisComponent>? s_ = DiagnosisLine?.Diagnosis;

                    bool? t_(Claim.DiagnosisComponent? @this) {
                        DataType? ae_ = @this?.Diagnosis;
                        bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                        return af_;
                    }


                    object u_(Claim.DiagnosisComponent? @this) {
                        DataType? ag_ = @this?.Diagnosis;
                        return ag_!;
                    }

                    IEnumerable<object?>? v_ = context.Operators.WhereSelect<Claim.DiagnosisComponent?, object?>((IEnumerable<Claim.DiagnosisComponent?>?)s_, t_, u_);

                    bool? w_(object? @this) {
                        object? ah_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                        bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                        return ai_;
                    }


                    object x_(object? @this) {
                        object? aj_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                        return aj_!;
                    }

                    IEnumerable<object?>? y_ = context.Operators.WhereSelect<object?, object?>(v_, w_, x_);
                    IEnumerable<object?>? z_ = context.Operators.FlattenLateBoundList(((IEnumerable<object>)y_)!);
                    Coding? aa_(object? @object) => (Coding?)@object;

                    bool? ab_(Coding? HeaderCode) {
                        Code? ak_ = HeaderCode?.CodeElement;
                        string? al_ = ak_?.Value;
                        IEnumerable<string>? am_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                        bool? an_ = context.Operators.In<string?>(al_, am_);
                        return an_;
                    }

                    IEnumerable<Coding?>? ac_ = context.Operators.SelectWhere<object?, Coding?>(z_, aa_, ab_);
                    bool? ad_ = context.Operators.Exists<Coding?>(ac_!);
                    return ad_;
                }

                IEnumerable<Claim?>? r_ = context.Operators.Where<Claim?>(p_, q_);
                j_ = r_;
            }
            (CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)? k_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, j_);
            (CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)?[]? l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? m_((CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)? HeaderDefinition) {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ao_;
                IEnumerable<Claim>? at_ = HeaderDefinition?.DiagnosisItems;
                bool? au_ = context.Operators.Exists<Claim?>(at_!);
                if (au_ ?? false)
                {
                    IEnumerable<Claim>? av_ = HeaderDefinition?.DiagnosisItems;

                    bool? aw_(Claim? @this) {
                        List<Claim.ItemComponent>? bd_ = @this?.Item;
                        bool? be_ = context.Operators.Not((bool?)(bd_ is null));
                        return be_;
                    }


                    List<Claim.ItemComponent?>? ax_(Claim? @this) {
                        List<Claim.ItemComponent>? bf_ = @this?.Item;
                        return bf_;
                    }

                    IEnumerable<List<Claim.ItemComponent?>?>? ay_ = context.Operators.WhereSelect<Claim?, List<Claim.ItemComponent?>?>(av_, aw_, ax_);
                    IEnumerable<Claim.ItemComponent?>? az_ = context.Operators.Flatten<Claim.ItemComponent?>((IEnumerable<IEnumerable<Claim.ItemComponent>>)((IEnumerable<IEnumerable<Claim.ItemComponent?>?>?)ay_)!);

                    CqlInterval<CqlDateTime?>? ba_(Claim.ItemComponent? NormalDate) {
                        DataType? bg_ = NormalDate?.Serviced;
                        CqlInterval<CqlDateTime?>? bh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bg_);
                        return bh_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime?>?>? bb_ = context.Operators.SelectDistinct<Claim.ItemComponent?, CqlInterval<CqlDateTime?>?>(az_, ba_);
                    (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? bc_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, av_, bb_);
                    ao_ = bc_;
                }
                else
                {
                    ao_ = null as (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?[]? ap_ = [
                    ao_,
                ];

                bool? aq_((CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                    bool? bi_ = context.Operators.Not((bool?)(FinalList is null));
                    return bi_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? ar_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?)ap_, aq_);
                (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? as_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(ar_);
                return as_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)?>?)l_, m_);
            (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)?>?)e_, f_);
        (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? h_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Pharmacy Claim With Medication")]
    public IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? MedicationCodes)
    {
        IEnumerable<Claim?>? a_ = this.Pharmacy_Claims(context, claim);

        string? b_(CqlCode? p) {
            string? i_ = p?.code;
            return i_;
        }

        IEnumerable<string?>? c_ = context.Operators.SelectDistinct<CqlCode?, string?>(MedicationCodes, b_);
        (CqlTupleMetadata, IEnumerable<Claim?>? PharmacyClaim, IEnumerable<string?>? MedicationsAsStrings)? d_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, a_, c_);
        (CqlTupleMetadata, IEnumerable<Claim?>? PharmacyClaim, IEnumerable<string?>? MedicationsAsStrings)?[]? e_ = [
            d_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? f_((CqlTupleMetadata, IEnumerable<Claim?>? PharmacyClaim, IEnumerable<string?>? MedicationsAsStrings)? ClaimWithMedication) {
            IEnumerable<Claim>? j_ = ClaimWithMedication?.PharmacyClaim;

            (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? k_(Claim? Pharmacy) {
                List<Claim.ItemComponent>? n_ = Pharmacy?.Item;

                bool? o_(Claim.ItemComponent? ItemOnLine) {
                    CodeableConcept? v_ = ItemOnLine?.ProductOrService;
                    CqlConcept? w_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, v_);
                    IReadOnlyList<CqlCode>? x_ = w_?.codes;

                    bool? y_(CqlCode? LineCode) {
                        string? aa_ = LineCode?.code;
                        IEnumerable<string>? ab_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? ac_ = context.Operators.In<string?>(aa_, ab_);
                        return ac_;
                    }

                    bool? z_ = context.Operators.WhereAny<CqlCode?>((IEnumerable<CqlCode?>?)x_, y_);
                    return z_;
                }

                IEnumerable<Claim.ItemComponent?>? p_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)n_, o_);
                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)? q_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, p_);
                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?[]? r_ = [
                    q_,
                ];

                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? s_((CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)? LineItemDefinition) {
                    Claim? ad_ = LineItemDefinition?.Claim;
                    Claim?[]? ae_ = [
                        ad_,
                    ];

                    (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? af_(Claim? ClaimLines) {
                        List<Claim.ItemComponent>? ai_ = ClaimLines?.Item;

                        bool? aj_(Claim.ItemComponent? i) {
                            CodeableConcept? ar_ = i?.ProductOrService;
                            CqlConcept? as_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ar_);
                            IReadOnlyList<CqlCode>? at_ = as_?.codes;

                            bool? au_(CqlCode? LineCode) {
                                string? aw_ = LineCode?.code;
                                IEnumerable<string>? ax_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? ay_ = context.Operators.In<string?>(aw_, ax_);
                                return ay_;
                            }

                            bool? av_ = context.Operators.WhereAny<CqlCode?>((IEnumerable<CqlCode?>?)at_, au_);
                            return av_;
                        }


                        (CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)? ak_(Claim.ItemComponent? i) {
                            CqlInterval<CqlDateTime>? az_;
                            Quantity? bb_ = i?.Quantity;
                            bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                            if (bc_ ?? false)
                            {
                                CqlInterval<CqlDateTime>? bd_;
                                DataType? be_ = i?.Serviced;
                                bool bf_ = be_ is Period;
                                if (bf_)
                                {
                                    DataType? bg_ = i?.Serviced;
                                    CqlInterval<CqlDateTime?>? bh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bg_);
                                    CqlDateTime? bi_ = context.Operators.Start(bh_);
                                    Quantity? bj_ = i?.Quantity;
                                    FhirDecimal? bk_ = bj_?.ValueElement;
                                    decimal? bl_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bk_);
                                    CqlDateTime? bm_ = context.Operators.Add(bi_, new CqlQuantity(bl_, "day"));
                                    CqlQuantity? bn_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime? bo_ = context.Operators.Subtract(bm_, bn_);
                                    CqlInterval<CqlDateTime?>? bp_ = context.Operators.Interval(bi_, bo_, true, true);
                                    bd_ = bp_;
                                }
                                else
                                {
                                    DataType? bq_ = i?.Serviced;
                                    CqlDate? br_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bq_ as Date);
                                    CqlDateTime? bs_ = context.Operators.ConvertDateToDateTime(br_);
                                    Quantity? bt_ = i?.Quantity;
                                    FhirDecimal? bu_ = bt_?.ValueElement;
                                    decimal? bv_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, bu_);
                                    CqlDate? bw_ = context.Operators.Add(br_, new CqlQuantity(bv_, "day"));
                                    CqlQuantity? bx_ = context.Operators.Quantity(1m, "day");
                                    CqlDate? by_ = context.Operators.Subtract(bw_, bx_);
                                    CqlDateTime? bz_ = context.Operators.ConvertDateToDateTime(by_);
                                    CqlInterval<CqlDateTime?>? ca_ = context.Operators.Interval(bs_, bz_, true, true);
                                    bd_ = ca_;
                                }
                                az_ = bd_;
                            }
                            else
                            {
                                az_ = null as CqlInterval<CqlDateTime?>;
                            }
                            (CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)? ba_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, az_);
                            return ba_;
                        }

                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)?>? al_ = context.Operators.WhereSelect<Claim.ItemComponent?, (CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)?>((IEnumerable<Claim.ItemComponent?>?)ai_, aj_, ak_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)?>? CoveredDays)? am_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, al_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)?>? CoveredDays)?[]? an_ = [
                            am_,
                        ];

                        (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? ao_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)?>? CoveredDays)? ItemCalculation) {
                            IEnumerable<Claim.ItemComponent>? cb_ = LineItemDefinition?.LineItems;
                            bool? cc_ = context.Operators.Exists<Claim.ItemComponent?>(cb_!);
                            if (cc_ ?? false)
                            {
                                Claim? cd_ = LineItemDefinition?.Claim;
                                IEnumerable<Claim.ItemComponent>? ce_ = LineItemDefinition?.LineItems;

                                bool? cf_(Claim.ItemComponent? @this) {
                                    DataType? co_ = @this?.Serviced;
                                    bool? cp_ = context.Operators.Not((bool?)(co_ is null));
                                    return cp_;
                                }


                                object cg_(Claim.ItemComponent? @this) {
                                    DataType? cq_ = @this?.Serviced;
                                    return cq_!;
                                }

                                IEnumerable<object?>? ch_ = context.Operators.WhereSelect<Claim.ItemComponent?, object?>(ce_, cf_, cg_);

                                CqlInterval<CqlDateTime?>? ci_(object? NormalDate) {
                                    CqlInterval<CqlDateTime?>? cr_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);
                                    return cr_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime?>?>? cj_ = context.Operators.SelectDistinct<object?, CqlInterval<CqlDateTime?>?>(ch_, ci_);
                                IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>? ck_ = ItemCalculation?.CoveredDays;

                                CqlInterval<CqlDateTime?>? cl_((CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)? d) {
                                    CqlInterval<CqlDateTime>? cs_ = d?.DaysSupplyInterval;
                                    return cs_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime?>?>? cm_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)?, CqlInterval<CqlDateTime?>?>(ck_, cl_);
                                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? cn_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, cd_, ce_, cj_, cm_);
                                return cn_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? ap_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)?>? CoveredDays)?, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime?>? DaysSupplyInterval)?>? CoveredDays)?>?)an_, ao_);
                        (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? aq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>(ap_);
                        return aq_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? ag_ = context.Operators.Select<Claim?, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>((IEnumerable<Claim?>?)ae_, af_);
                    (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? ah_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>(ag_);
                    return ah_;
                }

                IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? t_ = context.Operators.Select<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItems)?>?)r_, s_);
                (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? u_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>(t_);
                return u_;
            }


            bool? l_((CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? FinalList) {
                bool? ct_ = context.Operators.Not((bool?)(FinalList is null));
                return ct_;
            }

            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? m_ = context.Operators.SelectWhere<Claim?, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>(j_, k_, l_);
            return m_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>?>? g_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim?>? PharmacyClaim, IEnumerable<string?>? MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? PharmacyClaim, IEnumerable<string?>? MedicationsAsStrings)?>?)e_, f_);
        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? h_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? DiagnosisValueSet, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {
        IEnumerable<Claim?>? a_ = this.Professional_or_Institutional_Claims(context, claim);

        string? b_(CqlCode? d) {
            string? k_ = d?.code;
            return k_;
        }

        IEnumerable<string?>? c_ = context.Operators.SelectDistinct<CqlCode?, string?>(DiagnosisValueSet, b_);

        string? d_(CqlCode? p) {
            string? l_ = p?.code;
            return l_;
        }

        IEnumerable<string?>? e_ = context.Operators.SelectDistinct<CqlCode?, string?>(ProductOrServiceValueSet, d_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)? f_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, a_, c_, e_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)?[]? g_ = [
            f_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? h_((CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim>? m_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                m_ = null as IEnumerable<Claim?>;
            }
            else
            {
                IEnumerable<Claim>? s_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? t_(Claim? DiagnosisLine) {
                    List<Claim.DiagnosisComponent>? v_ = DiagnosisLine?.Diagnosis;

                    bool? w_(Claim.DiagnosisComponent? @this) {
                        DataType? ah_ = @this?.Diagnosis;
                        bool? ai_ = context.Operators.Not((bool?)(ah_ is null));
                        return ai_;
                    }


                    object x_(Claim.DiagnosisComponent? @this) {
                        DataType? aj_ = @this?.Diagnosis;
                        return aj_!;
                    }

                    IEnumerable<object?>? y_ = context.Operators.WhereSelect<Claim.DiagnosisComponent?, object?>((IEnumerable<Claim.DiagnosisComponent?>?)v_, w_, x_);

                    bool? z_(object? @this) {
                        object? ak_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                        bool? al_ = context.Operators.Not((bool?)(ak_ is null));
                        return al_;
                    }


                    object aa_(object? @this) {
                        object? am_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                        return am_!;
                    }

                    IEnumerable<object?>? ab_ = context.Operators.WhereSelect<object?, object?>(y_, z_, aa_);
                    IEnumerable<object?>? ac_ = context.Operators.FlattenLateBoundList(((IEnumerable<object>)ab_)!);
                    Coding? ad_(object? @object) => (Coding?)@object;

                    bool? ae_(Coding? HeaderCode) {
                        Code? an_ = HeaderCode?.CodeElement;
                        string? ao_ = an_?.Value;
                        IEnumerable<string>? ap_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                        bool? aq_ = context.Operators.In<string?>(ao_, ap_);
                        return aq_;
                    }

                    IEnumerable<Coding?>? af_ = context.Operators.SelectWhere<object?, Coding?>(ac_, ad_, ae_);
                    bool? ag_ = context.Operators.Exists<Coding?>(af_!);
                    return ag_;
                }

                IEnumerable<Claim?>? u_ = context.Operators.Where<Claim?>(s_, t_);
                m_ = u_;
            }
            (CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)? n_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, m_);
            (CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)?[]? o_ = [
                n_,
            ];

            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? p_((CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)? ClaimWithProcedure) {
                IEnumerable<Claim>? ar_ = ClaimWithProcedure?.DiagnosisItems;

                (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? as_(Claim? ClaimofInterest) {
                    Claim? aw_;
                    if (ClaimofInterest is null)
                    {
                        aw_ = default;
                    }
                    else
                    {
                        Claim?[]? bc_ = [
                            ClaimofInterest,
                        ];

                        bool? bd_(Claim? ItemOnLine) {
                            List<Claim.ProcedureComponent>? bg_ = ItemOnLine?.Procedure;

                            bool? bh_(Claim.ProcedureComponent? @this) {
                                DataType? cd_ = @this?.Procedure;
                                bool? ce_ = context.Operators.Not((bool?)(cd_ is null));
                                return ce_;
                            }


                            object bi_(Claim.ProcedureComponent? @this) {
                                DataType? cf_ = @this?.Procedure;
                                return cf_!;
                            }

                            IEnumerable<object?>? bj_ = context.Operators.WhereSelect<Claim.ProcedureComponent?, object?>((IEnumerable<Claim.ProcedureComponent?>?)bg_, bh_, bi_);

                            bool? bk_(object? @this) {
                                object? cg_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                                bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
                                return ch_;
                            }


                            object bl_(object? @this) {
                                object? ci_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                                return ci_!;
                            }

                            IEnumerable<object?>? bm_ = context.Operators.WhereSelect<object?, object?>(bj_, bk_, bl_);
                            IEnumerable<object?>? bn_ = context.Operators.FlattenLateBoundList(((IEnumerable<object>)bm_)!);
                            Coding? bo_(object? @object) => (Coding?)@object;

                            bool? bp_(Coding? ProcedureHeaderCode) {
                                Code? cj_ = ProcedureHeaderCode?.CodeElement;
                                string? ck_ = cj_?.Value;
                                IEnumerable<string>? cl_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                bool? cm_ = context.Operators.In<string?>(ck_, cl_);
                                return cm_;
                            }

                            IEnumerable<Coding?>? bq_ = context.Operators.SelectWhere<object?, Coding?>(bn_, bo_, bp_);
                            bool? br_ = context.Operators.Exists<Coding?>(bq_!);
                            List<Claim.ItemComponent>? bs_ = ItemOnLine?.Item;

                            bool? bt_(Claim.ItemComponent? @this) {
                                CodeableConcept? cn_ = @this?.ProductOrService;
                                bool? co_ = context.Operators.Not((bool?)(cn_ is null));
                                return co_;
                            }


                            CodeableConcept? bu_(Claim.ItemComponent? @this) {
                                CodeableConcept? cp_ = @this?.ProductOrService;
                                return cp_;
                            }

                            IEnumerable<CodeableConcept?>? bv_ = context.Operators.WhereSelect<Claim.ItemComponent?, CodeableConcept?>((IEnumerable<Claim.ItemComponent?>?)bs_, bt_, bu_);

                            bool? bw_(CodeableConcept? @this) {
                                List<Coding>? cq_ = @this?.Coding;
                                bool? cr_ = context.Operators.Not((bool?)(cq_ is null));
                                return cr_;
                            }


                            List<Coding?>? bx_(CodeableConcept? @this) {
                                List<Coding>? cs_ = @this?.Coding;
                                return cs_;
                            }

                            IEnumerable<List<Coding?>?>? by_ = context.Operators.WhereSelect<CodeableConcept?, List<Coding?>?>(bv_, bw_, bx_);
                            IEnumerable<Coding?>? bz_ = context.Operators.Flatten<Coding?>((IEnumerable<IEnumerable<Coding>>)((IEnumerable<IEnumerable<Coding?>?>?)by_)!);

                            bool? ca_(Coding? LineCode) {
                                Code? ct_ = LineCode?.CodeElement;
                                string? cu_ = ct_?.Value;
                                IEnumerable<string>? cv_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                bool? cw_ = context.Operators.In<string?>(cu_, cv_);
                                return cw_;
                            }

                            bool? cb_ = context.Operators.WhereAny<Coding?>(bz_, ca_);
                            bool? cc_ = context.Operators.Or(br_, cb_);
                            return cc_;
                        }

                        IEnumerable<Claim?>? be_ = context.Operators.Where<Claim?>((IEnumerable<Claim?>?)bc_, bd_);
                        Claim? bf_ = context.Operators.SingletonFrom<Claim?>(be_);
                        aw_ = bf_;
                    }
                    (CqlTupleMetadata, Claim? ProcedureItems)? ax_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, aw_);
                    (CqlTupleMetadata, Claim? ProcedureItems)?[]? ay_ = [
                        ax_,
                    ];

                    (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? az_((CqlTupleMetadata, Claim? ProcedureItems)? HeaderDefinition) {
                        Claim? cx_ = HeaderDefinition?.ProcedureItems;
                        bool? cy_ = context.Operators.Not((bool?)(cx_ is null));
                        if (cy_ ?? false)
                        {
                            Claim? cz_ = HeaderDefinition?.ProcedureItems;
                            List<Claim.ItemComponent>? da_ = cz_?.Item;

                            CqlInterval<CqlDateTime?>? db_(Claim.ItemComponent? NormalDate) {
                                DataType? de_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime?>? df_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, de_);
                                return df_;
                            }

                            IEnumerable<CqlInterval<CqlDateTime?>?>? dc_ = context.Operators.SelectDistinct<Claim.ItemComponent?, CqlInterval<CqlDateTime?>?>((IEnumerable<Claim.ItemComponent?>?)da_, db_);
                            (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? dd_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, cz_, dc_);
                            return dd_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                        }
                    }

                    IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? ba_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim? ProcedureItems)?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim? ProcedureItems)?>?)ay_, az_);
                    (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? bb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(ba_);
                    return bb_;
                }

                IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? at_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(ar_, as_);

                bool? au_((CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                    bool? dg_ = context.Operators.Not((bool?)(FinalList is null));
                    return dg_;
                }

                IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? av_ = context.Operators.Where<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(at_, au_);
                return av_;
            }

            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>? q_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? DiagnosisItems)?>?)o_, p_);
            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? r_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>(q_);
            return r_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>? i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)?>?)g_, h_);
        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? DiagnosisValueSet, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {
        IEnumerable<Claim?>? a_ = this.Professional_or_Institutional_Claims(context, claim);

        string? b_(CqlCode? d) {
            string? k_ = d?.code;
            return k_;
        }

        IEnumerable<string?>? c_ = context.Operators.SelectDistinct<CqlCode?, string?>(DiagnosisValueSet, b_);

        string? d_(CqlCode? p) {
            string? l_ = p?.code;
            return l_;
        }

        IEnumerable<string?>? e_ = context.Operators.SelectDistinct<CqlCode?, string?>(ProductOrServiceValueSet, d_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)? f_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, a_, c_, e_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)?[]? g_ = [
            f_,
        ];

        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? h_((CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)? ClaimWithProcedure) {
            IEnumerable<Claim>? m_ = ClaimWithProcedure?.MedicalClaim;

            (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? n_(Claim? ClaimofInterest) {
                Claim? r_;
                if (ClaimofInterest is null)
                {
                    r_ = default;
                }
                else
                {
                    Claim?[]? x_ = [
                        ClaimofInterest,
                    ];

                    bool? y_(Claim? ItemOnLine) {
                        List<Claim.ItemComponent>? ab_ = ItemOnLine?.Item;

                        bool? ac_(Claim.ItemComponent? @this) {
                            CodeableConcept? ay_ = @this?.ProductOrService;
                            bool? az_ = context.Operators.Not((bool?)(ay_ is null));
                            return az_;
                        }


                        CodeableConcept? ad_(Claim.ItemComponent? @this) {
                            CodeableConcept? ba_ = @this?.ProductOrService;
                            return ba_;
                        }

                        IEnumerable<CodeableConcept?>? ae_ = context.Operators.WhereSelect<Claim.ItemComponent?, CodeableConcept?>((IEnumerable<Claim.ItemComponent?>?)ab_, ac_, ad_);

                        bool? af_(CodeableConcept? @this) {
                            List<Coding>? bb_ = @this?.Coding;
                            bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                            return bc_;
                        }


                        List<Coding?>? ag_(CodeableConcept? @this) {
                            List<Coding>? bd_ = @this?.Coding;
                            return bd_;
                        }

                        IEnumerable<List<Coding?>?>? ah_ = context.Operators.WhereSelect<CodeableConcept?, List<Coding?>?>(ae_, af_, ag_);
                        IEnumerable<Coding?>? ai_ = context.Operators.Flatten<Coding?>((IEnumerable<IEnumerable<Coding>>)((IEnumerable<IEnumerable<Coding?>?>?)ah_)!);

                        bool? aj_(Coding? LineCode) {
                            Code? be_ = LineCode?.CodeElement;
                            string? bf_ = be_?.Value;
                            IEnumerable<string>? bg_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? bh_ = context.Operators.In<string?>(bf_, bg_);
                            return bh_;
                        }

                        bool? ak_ = context.Operators.WhereAny<Coding?>(ai_, aj_);
                        List<Claim.ProcedureComponent>? al_ = ItemOnLine?.Procedure;

                        bool? am_(Claim.ProcedureComponent? @this) {
                            DataType? bi_ = @this?.Procedure;
                            bool? bj_ = context.Operators.Not((bool?)(bi_ is null));
                            return bj_;
                        }


                        object an_(Claim.ProcedureComponent? @this) {
                            DataType? bk_ = @this?.Procedure;
                            return bk_!;
                        }

                        IEnumerable<object?>? ao_ = context.Operators.WhereSelect<Claim.ProcedureComponent?, object?>((IEnumerable<Claim.ProcedureComponent?>?)al_, am_, an_);

                        bool? ap_(object? @this) {
                            object? bl_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                            bool? bm_ = context.Operators.Not((bool?)(bl_ is null));
                            return bm_;
                        }


                        object aq_(object? @this) {
                            object? bn_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                            return bn_!;
                        }

                        IEnumerable<object?>? ar_ = context.Operators.WhereSelect<object?, object?>(ao_, ap_, aq_);
                        IEnumerable<object?>? as_ = context.Operators.FlattenLateBoundList(((IEnumerable<object>)ar_)!);
                        Coding? at_(object? @object) => (Coding?)@object;

                        bool? au_(Coding? HeaderCode) {
                            Code? bo_ = HeaderCode?.CodeElement;
                            string? bp_ = bo_?.Value;
                            IEnumerable<string>? bq_ = ClaimWithProcedure?.ProceduresAsStrings;
                            bool? br_ = context.Operators.In<string?>(bp_, bq_);
                            return br_;
                        }

                        IEnumerable<Coding?>? av_ = context.Operators.SelectWhere<object?, Coding?>(as_, at_, au_);
                        bool? aw_ = context.Operators.Exists<Coding?>(av_!);
                        bool? ax_ = context.Operators.Or(ak_, aw_);
                        return ax_;
                    }

                    IEnumerable<Claim?>? z_ = context.Operators.Where<Claim?>((IEnumerable<Claim?>?)x_, y_);
                    Claim? aa_ = context.Operators.SingletonFrom<Claim?>(z_);
                    r_ = aa_;
                }
                (CqlTupleMetadata, Claim? Claim, Claim? ProcedureItems)? s_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, r_);
                (CqlTupleMetadata, Claim? Claim, Claim? ProcedureItems)?[]? t_ = [
                    s_,
                ];

                (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? u_((CqlTupleMetadata, Claim? Claim, Claim? ProcedureItems)? DiagnosisCheck) {
                    Claim? bs_ = DiagnosisCheck?.ProcedureItems;
                    Claim?[]? bt_ = [
                        bs_,
                    ];

                    (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? bu_(Claim? ClaimforDiagnosis) {
                        List<Claim.ItemComponent>? bx_ = ClaimforDiagnosis?.Item;
                        Claim? by_;
                        if (ClaimforDiagnosis is null)
                        {
                            by_ = default;
                        }
                        else
                        {
                            Claim?[]? ce_ = [
                                ClaimforDiagnosis,
                            ];

                            bool? cf_(Claim? RightClaim) {
                                List<Claim.DiagnosisComponent>? ci_ = RightClaim?.Diagnosis;

                                bool? cj_(Claim.DiagnosisComponent? RightDiagnosis) {
                                    PositiveInt? cl_ = RightDiagnosis?.SequenceElement;
                                    Integer? cm_ = context.Operators.Convert<Integer?>(cl_);
                                    int? cn_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, cm_);
                                    bool? co_ = context.Operators.Equal(cn_, 1);
                                    DataType? cp_ = RightDiagnosis?.Diagnosis;
                                    IEnumerable<Coding?>? cq_ = context.Operators.LateBoundProperty<IEnumerable<Coding?>?>(cp_, "coding");

                                    bool? cr_(Coding? DiagnosisCode) {
                                        Code? cu_ = DiagnosisCode?.CodeElement;
                                        string? cv_ = cu_?.Value;
                                        IEnumerable<string>? cw_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                        bool? cx_ = context.Operators.In<string?>(cv_, cw_);
                                        return cx_;
                                    }

                                    bool? cs_ = context.Operators.WhereAny<Coding?>(cq_, cr_);
                                    bool? ct_ = context.Operators.And(co_, cs_);
                                    return ct_;
                                }

                                bool? ck_ = context.Operators.WhereAny<Claim.DiagnosisComponent?>((IEnumerable<Claim.DiagnosisComponent?>?)ci_, cj_);
                                return ck_;
                            }

                            IEnumerable<Claim?>? cg_ = context.Operators.Where<Claim?>((IEnumerable<Claim?>?)ce_, cf_);
                            Claim? ch_ = context.Operators.SingletonFrom<Claim?>(cg_);
                            by_ = ch_;
                        }
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? Procedure, Claim? LineItems)? bz_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent?>?)bx_, by_);
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? Procedure, Claim? LineItems)?[]? ca_ = [
                            bz_,
                        ];

                        (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? cb_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? Procedure, Claim? LineItems)? LineItemDefinition) {
                            bool? cy_ = context.Operators.Not((bool?)(LineItemDefinition is null));
                            Claim? cz_ = LineItemDefinition?.LineItems;
                            bool? da_ = context.Operators.Not((bool?)(cz_ is null));
                            bool? db_ = context.Operators.And(cy_, da_);
                            if (db_ ?? false)
                            {
                                Claim? dc_ = LineItemDefinition?.LineItems;
                                List<Claim.ItemComponent>? dd_ = dc_?.Item;

                                CqlInterval<CqlDateTime?>? de_(Claim.ItemComponent? NormalDate) {
                                    DataType? dh_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime?>? di_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dh_);
                                    return di_;
                                }

                                IEnumerable<CqlInterval<CqlDateTime?>?>? df_ = context.Operators.Select<Claim.ItemComponent?, CqlInterval<CqlDateTime?>?>((IEnumerable<Claim.ItemComponent?>?)dd_, de_);
                                (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? dg_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, dc_, df_);
                                return dg_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                            }
                        }

                        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? cc_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? Procedure, Claim? LineItems)?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? Procedure, Claim? LineItems)?>?)ca_, cb_);
                        (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? cd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(cc_);
                        return cd_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? bv_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<Claim?>?)bt_, bu_);
                    (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? bw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(bv_);
                    return bw_;
                }

                IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? v_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim? Claim, Claim? ProcedureItems)?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim? Claim, Claim? ProcedureItems)?>?)t_, u_);
                (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? w_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(v_);
                return w_;
            }

            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? o_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(m_, n_);

            bool? p_((CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                bool? dj_ = context.Operators.Not((bool?)(FinalList is null));
                return dj_;
            }

            IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? q_ = context.Operators.Where<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(o_, p_);
            return q_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>? i_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings, IEnumerable<string?>? ProceduresAsStrings)?>?)g_, h_);
        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? j_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>(i_);
        return j_;
    }


    [CqlFunctionDefinition("Medical Claims With Principal Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? DiagnosisValueSet)
    {
        IEnumerable<Claim?>? a_ = this.Professional_or_Institutional_Claims(context, claim);

        string? b_(CqlCode? d) {
            string? i_ = d?.code;
            return i_;
        }

        IEnumerable<string?>? c_ = context.Operators.SelectDistinct<CqlCode?, string?>(DiagnosisValueSet, b_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)? d_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, a_, c_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)?[]? e_ = [
            d_,
        ];

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? f_((CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)? ClaimWithDiagnosis) {
            IEnumerable<Claim>? j_;
            if (ClaimWithDiagnosis?.MedicalClaim is null)
            {
                j_ = null as IEnumerable<Claim?>;
            }
            else
            {
                IEnumerable<Claim>? p_ = ClaimWithDiagnosis?.MedicalClaim;

                bool? q_(Claim? RightClaim) {
                    List<Claim.DiagnosisComponent>? s_ = RightClaim?.Diagnosis;

                    bool? t_(Claim.DiagnosisComponent? RightDiagnosis) {
                        PositiveInt? v_ = RightDiagnosis?.SequenceElement;
                        Integer? w_ = context.Operators.Convert<Integer?>(v_);
                        int? x_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, w_);
                        bool? y_ = context.Operators.Equal(x_, 1);
                        DataType? z_ = RightDiagnosis?.Diagnosis;
                        IEnumerable<Coding?>? aa_ = context.Operators.LateBoundProperty<IEnumerable<Coding?>?>(z_, "coding");

                        bool? ab_(Coding? DiagnosisCode) {
                            Code? ae_ = DiagnosisCode?.CodeElement;
                            string? af_ = ae_?.Value;
                            IEnumerable<string>? ag_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? ah_ = context.Operators.In<string?>(af_, ag_);
                            return ah_;
                        }

                        bool? ac_ = context.Operators.WhereAny<Coding?>(aa_, ab_);
                        bool? ad_ = context.Operators.And(y_, ac_);
                        return ad_;
                    }

                    bool? u_ = context.Operators.WhereAny<Claim.DiagnosisComponent?>((IEnumerable<Claim.DiagnosisComponent?>?)s_, t_);
                    return u_;
                }

                IEnumerable<Claim?>? r_ = context.Operators.Where<Claim?>(p_, q_);
                j_ = r_;
            }
            (CqlTupleMetadata, IEnumerable<Claim?>? LineItems)? k_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, j_);
            (CqlTupleMetadata, IEnumerable<Claim?>? LineItems)?[]? l_ = [
                k_,
            ];

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? m_((CqlTupleMetadata, IEnumerable<Claim?>? LineItems)? LineItemDefinition) {
                IEnumerable<Claim>? ai_ = LineItemDefinition?.LineItems;

                (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? aj_(Claim? ClaimWithDiagnosis) {
                    if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
                    {
                        IEnumerable<Claim>? an_ = LineItemDefinition?.LineItems;

                        bool? ao_(Claim? @this) {
                            List<Claim.ItemComponent>? av_ = @this?.Item;
                            bool? aw_ = context.Operators.Not((bool?)(av_ is null));
                            return aw_;
                        }


                        List<Claim.ItemComponent?>? ap_(Claim? @this) {
                            List<Claim.ItemComponent>? ax_ = @this?.Item;
                            return ax_;
                        }

                        IEnumerable<List<Claim.ItemComponent?>?>? aq_ = context.Operators.WhereSelect<Claim?, List<Claim.ItemComponent?>?>(an_, ao_, ap_);
                        IEnumerable<Claim.ItemComponent?>? ar_ = context.Operators.Flatten<Claim.ItemComponent?>((IEnumerable<IEnumerable<Claim.ItemComponent>>)((IEnumerable<IEnumerable<Claim.ItemComponent?>?>?)aq_)!);

                        CqlInterval<CqlDateTime?>? as_(Claim.ItemComponent? NormalDate) {
                            DataType? ay_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime?>? az_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ay_);
                            return az_;
                        }

                        IEnumerable<CqlInterval<CqlDateTime?>?>? at_ = context.Operators.SelectDistinct<Claim.ItemComponent?, CqlInterval<CqlDateTime?>?>(ar_, as_);
                        (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? au_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, an_, at_);
                        return au_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                    }
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? ak_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(ai_, aj_);

                bool? al_((CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                    bool? ba_ = context.Operators.Not((bool?)(FinalList is null));
                    return ba_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? am_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(ak_, al_);
                return am_;
            }

            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? LineItems)?>?)l_, m_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? o_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>(n_);
            return o_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>? g_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim, IEnumerable<string?>? DiagnosesAsStrings)?>?)e_, f_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? h_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? Claim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?>(g_);
        return h_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Service and Condition")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet, IEnumerable<CqlCode?>? DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?[]? b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)? MedicalClaimAndResponse) {
            IEnumerable<ClaimResponse>? j_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            IEnumerable<Claim>? k_ = MedicalClaimAndResponse?.MedicalClaim;
            bool? l_ = context.Operators.And((bool?)(j_ is null), (bool?)(k_ is null));
            if (l_ ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse>? m_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim>? n_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? o_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, m_, n_, ProductOrServiceValueSet, DiagnosisValueSet);
                return o_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? d_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?>?)b_, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? e_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(d_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?[]? f_ = [
            e_,
        ];

        bool? g_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
            bool? p_ = context.Operators.Not((bool?)(FinalList is null));
            return p_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? h_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?)f_, g_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? i_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(h_);
        return i_;
    }


    [CqlFunctionDefinition("Get All Professional and Institutional Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim)
    {
        IEnumerable<ClaimResponse?>? a_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
        IEnumerable<Claim?>? b_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)? c_ = (CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE, a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Get Corresponding Claim for Services and Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet, IEnumerable<CqlCode?>? DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? b_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?[]? d_ = [
            c_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)? ClaimAndResponse) {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>? h_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? i_((CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent>? p_ = medClaim?.LineItems;

                bool? q_(Claim.ItemComponent? medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>? t_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? u_((CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent>? w_ = pClaim?.LineItems;

                        bool? x_(ClaimResponse.ItemComponent? pClaimLineItem) {
                            Id? z_;
                            Claim? an_ = medClaim?.ClaimofInterest;
                            bool ao_ = an_ is Resource;
                            if (ao_)
                            {
                                Claim? ap_ = medClaim?.ClaimofInterest;
                                z_ = (ap_ as Resource)!.IdElement;
                            }
                            else
                            {
                                z_ = default;
                            }
                            string? aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                            ClaimResponse? ab_ = pClaim?.Response;
                            ResourceReference? ac_ = ab_?.Request;
                            FhirString? ad_ = ac_?.ReferenceElement;
                            string? ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                            string? af_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ae_);
                            bool? ag_ = context.Operators.Equal(aa_, af_);
                            PositiveInt? ah_ = medClaimLineItem?.SequenceElement;
                            Integer? ai_ = context.Operators.Convert<Integer?>(ah_);
                            PositiveInt? aj_ = pClaimLineItem?.ItemSequenceElement;
                            Integer? ak_ = context.Operators.Convert<Integer?>(aj_);
                            bool? al_ = context.Operators.Equal(ai_, ak_);
                            bool? am_ = context.Operators.And(ag_, al_);
                            return am_;
                        }

                        bool? y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent?>(w_, x_);
                        return y_;
                    }

                    bool? v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>(t_, u_);
                    return v_;
                }

                IEnumerable<Claim.ItemComponent?>? r_ = context.Operators.Where<Claim.ItemComponent?>(p_, q_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? s_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, r_);
                return s_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>(h_, i_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)? k_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, j_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?[]? l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? m_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? aq_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>? av_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? aw_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent>? bb_ = @this?.ClaimItem;
                    bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                    return bc_;
                }


                IEnumerable<Claim.ItemComponent?>? ax_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent>? bd_ = @this?.ClaimItem;
                    return bd_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent?>?>? ay_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(av_, aw_, ax_);
                IEnumerable<Claim.ItemComponent?>? az_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)ay_)!);
                bool? ba_ = context.Operators.Exists<Claim.ItemComponent?>(az_!);
                if (ba_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>? be_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bf_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? bp_ = @this?.PaidClaim;
                        bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                        return bq_;
                    }


                    (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? br_ = @this?.PaidClaim;
                        return br_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? bh_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(be_, bf_, bg_);

                    bool? bi_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? bs_ = @this?.ClaimItem;
                        bool? bt_ = context.Operators.Not((bool?)(bs_ is null));
                        return bt_;
                    }


                    IEnumerable<Claim.ItemComponent?>? bj_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? bu_ = @this?.ClaimItem;
                        return bu_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent?>?>? bk_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(be_, bi_, bj_);
                    IEnumerable<Claim.ItemComponent?>? bl_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)bk_)!);

                    CqlInterval<CqlDateTime?>? bm_(Claim.ItemComponent? PaidItem) {
                        DataType? bv_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime?>? bw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bv_);
                        return bw_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime?>?>? bn_ = context.Operators.SelectDistinct<Claim.ItemComponent?, CqlInterval<CqlDateTime?>?>(bl_, bm_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? bo_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bh_, bn_);
                    aq_ = bo_;
                }
                else
                {
                    aq_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?[]? ar_ = [
                    aq_,
                ];

                bool? as_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                    bool? bx_ = context.Operators.Not((bool?)(FinalList is null));
                    return bx_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? at_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?)ar_, as_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? au_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(at_);
                return au_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?>?)l_, m_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?>?)d_, e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get All Paid Claim Reponses")]
    public IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse)
    {

        bool? a_(ClaimResponse? ResponseItem) {
            Code<ClaimProcessingCodes>? h_ = ResponseItem?.OutcomeElement;
            string? i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
            string?[]? j_ = [
                "complete",
                "partial",
            ];
            bool? k_ = context.Operators.In<string?>(i_, (IEnumerable<string?>?)j_);
            return k_;
        }

        IEnumerable<ClaimResponse?>? b_ = context.Operators.Where<ClaimResponse?>(claimResponse, a_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? PaidResponse)? c_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, b_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? PaidResponse)?[]? d_ = [
            c_,
        ];

        IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? e_((CqlTupleMetadata, IEnumerable<ClaimResponse?>? PaidResponse)? ClaimResponse) {
            IEnumerable<ClaimResponse>? l_ = ClaimResponse?.PaidResponse;

            (CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)? m_(ClaimResponse? ClmResp) {
                ResourceReference? o_ = ClmResp?.Request;
                FhirString? p_ = o_?.ReferenceElement;
                string? q_ = FHIRHelpers_4_0_001.Instance.ToString(context, p_);
                string? r_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, q_);
                List<ClaimResponse.ItemComponent>? s_ = ClmResp?.Item;

                bool? t_(ClaimResponse.ItemComponent? ResponseItem) {
                    List<ClaimResponse.AdjudicationComponent>? w_ = ResponseItem?.Adjudication;

                    bool? x_(ClaimResponse.AdjudicationComponent? @this) {
                        CodeableConcept? am_ = @this?.Category;
                        bool? an_ = context.Operators.Not((bool?)(am_ is null));
                        return an_;
                    }


                    CodeableConcept? y_(ClaimResponse.AdjudicationComponent? @this) {
                        CodeableConcept? ao_ = @this?.Category;
                        return ao_;
                    }

                    IEnumerable<CodeableConcept?>? z_ = context.Operators.WhereSelect<ClaimResponse.AdjudicationComponent?, CodeableConcept?>((IEnumerable<ClaimResponse.AdjudicationComponent?>?)w_, x_, y_);

                    bool? aa_(CodeableConcept? @this) {
                        List<Coding>? ap_ = @this?.Coding;
                        bool? aq_ = context.Operators.Not((bool?)(ap_ is null));
                        return aq_;
                    }


                    List<Coding?>? ab_(CodeableConcept? @this) {
                        List<Coding>? ar_ = @this?.Coding;
                        return ar_;
                    }

                    IEnumerable<List<Coding?>?>? ac_ = context.Operators.WhereSelect<CodeableConcept?, List<Coding?>?>(z_, aa_, ab_);
                    IEnumerable<Coding?>? ad_ = context.Operators.Flatten<Coding?>((IEnumerable<IEnumerable<Coding>>)((IEnumerable<IEnumerable<Coding?>?>?)ac_)!);

                    bool? ae_(Coding? CategoryItem) {
                        Code? as_ = CategoryItem?.CodeElement;
                        string? at_ = as_?.Value;
                        bool? au_ = context.Operators.Equal(at_, "benefit");
                        return au_;
                    }

                    bool? af_ = context.Operators.WhereAny<Coding?>(ad_, ae_);

                    bool? ag_(ClaimResponse.AdjudicationComponent? @this) {
                        Money? av_ = @this?.Amount;
                        bool? aw_ = context.Operators.Not((bool?)(av_ is null));
                        return aw_;
                    }


                    Money? ah_(ClaimResponse.AdjudicationComponent? @this) {
                        Money? ax_ = @this?.Amount;
                        return ax_;
                    }

                    IEnumerable<Money?>? ai_ = context.Operators.WhereSelect<ClaimResponse.AdjudicationComponent?, Money?>((IEnumerable<ClaimResponse.AdjudicationComponent?>?)w_, ag_, ah_);

                    bool? aj_(Money? DollarAmount) {
                        FhirDecimal? ay_ = DollarAmount?.ValueElement;
                        decimal? az_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, ay_);
                        decimal? ba_ = context.Operators.ConvertIntegerToDecimal(0);
                        bool? bb_ = context.Operators.Greater(az_, ba_);
                        return bb_;
                    }

                    bool? ak_ = context.Operators.WhereAny<Money?>(ai_, aj_);
                    bool? al_ = context.Operators.And(af_, ak_);
                    return al_;
                }

                IEnumerable<ClaimResponse.ItemComponent?>? u_ = context.Operators.Where<ClaimResponse.ItemComponent?>((IEnumerable<ClaimResponse.ItemComponent?>?)s_, t_);
                (CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)? v_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, r_, u_);
                return v_;
            }

            IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? n_ = context.Operators.SelectDistinct<ClaimResponse?, (CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>(l_, m_);
            return n_;
        }

        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>?>? f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? PaidResponse)?>?)d_, e_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? g_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet, IEnumerable<CqlCode?>? DiagnosisValueSet)
    {

        bool? a_(Claim? AllClaims) {
            List<Claim.ItemComponent>? e_ = AllClaims?.Item;

            bool? f_(Claim.ItemComponent? @this) {
                CodeableConcept? ab_ = @this?.ProductOrService;
                bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                return ac_;
            }


            CodeableConcept? g_(Claim.ItemComponent? @this) {
                CodeableConcept? ad_ = @this?.ProductOrService;
                return ad_;
            }

            IEnumerable<CodeableConcept?>? h_ = context.Operators.WhereSelect<Claim.ItemComponent?, CodeableConcept?>((IEnumerable<Claim.ItemComponent?>?)e_, f_, g_);

            bool? i_(CodeableConcept? @this) {
                List<Coding>? ae_ = @this?.Coding;
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                return af_;
            }


            List<Coding?>? j_(CodeableConcept? @this) {
                List<Coding>? ag_ = @this?.Coding;
                return ag_;
            }

            IEnumerable<List<Coding?>?>? k_ = context.Operators.WhereSelect<CodeableConcept?, List<Coding?>?>(h_, i_, j_);
            IEnumerable<Coding?>? l_ = context.Operators.Flatten<Coding?>((IEnumerable<IEnumerable<Coding>>)((IEnumerable<IEnumerable<Coding?>?>?)k_)!);

            bool? m_(Coding? ProductOrServiceCode) {
                CqlCode? ah_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? ai_ = context.Operators.In<CqlCode?>(ah_, ProductOrServiceValueSet);
                return ai_;
            }

            bool? n_ = context.Operators.WhereAny<Coding?>(l_, m_);
            List<Claim.DiagnosisComponent>? o_ = AllClaims?.Diagnosis;

            bool? p_(Claim.DiagnosisComponent? @this) {
                DataType? aj_ = @this?.Diagnosis;
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                return ak_;
            }


            object q_(Claim.DiagnosisComponent? @this) {
                DataType? al_ = @this?.Diagnosis;
                return al_!;
            }

            IEnumerable<object?>? r_ = context.Operators.WhereSelect<Claim.DiagnosisComponent?, object?>((IEnumerable<Claim.DiagnosisComponent?>?)o_, p_, q_);

            bool? s_(object? @this) {
                object? am_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                return an_;
            }


            object t_(object? @this) {
                object? ao_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                return ao_!;
            }

            IEnumerable<object?>? u_ = context.Operators.WhereSelect<object?, object?>(r_, s_, t_);
            IEnumerable<object?>? v_ = context.Operators.FlattenLateBoundList(((IEnumerable<object>)u_)!);
            Coding? w_(object? @object) => (Coding?)@object;

            bool? x_(Coding? DiagnosisCode) {
                CqlCode? ap_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? aq_ = context.Operators.In<CqlCode?>(ap_, DiagnosisValueSet);
                return aq_;
            }

            IEnumerable<Coding?>? y_ = context.Operators.SelectWhere<object?, Coding?>(v_, w_, x_);
            bool? z_ = context.Operators.Exists<Coding?>(y_!);
            bool? aa_ = context.Operators.And(n_, z_);
            return aa_;
        }


        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? b_(Claim? ProcedureClaims) {
            Id? ar_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent>? as_ = ProcedureClaims?.Item;

            bool? at_(Claim.ItemComponent? ResponseItem) {
                CodeableConcept? aw_ = ResponseItem?.ProductOrService;
                List<Coding>? ax_ = aw_?.Coding;

                bool? ay_(Coding? ProductOrServiceCode) {
                    CqlCode? ba_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? bb_ = context.Operators.In<CqlCode?>(ba_, ProductOrServiceValueSet);
                    return bb_;
                }

                bool? az_ = context.Operators.WhereAny<Coding?>((IEnumerable<Coding?>?)ax_, ay_);
                return az_;
            }

            IEnumerable<Claim.ItemComponent?>? au_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)as_, at_);
            (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? av_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, ar_, au_);
            return av_;
        }

        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? c_ = context.Operators.WhereSelect<Claim?, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(claim, a_, b_);
        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? d_ = context.Operators.Distinct<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(c_!);
        return d_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet, IEnumerable<CqlCode?>? DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?[]? b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)? MedicalClaimAndResponse) {
            IEnumerable<ClaimResponse>? f_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            IEnumerable<Claim>? g_ = MedicalClaimAndResponse?.MedicalClaim;
            bool? h_ = context.Operators.And((bool?)(f_ is null), (bool?)(g_ is null));
            if (h_ ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse>? i_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim>? j_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? k_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, i_, j_, ProductOrServiceValueSet, DiagnosisValueSet);
                return k_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? d_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?>?)b_, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? e_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Get Corresponding Claim for Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet, IEnumerable<CqlCode?>? DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? b_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?[]? d_ = [
            c_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)? ClaimAndResponse) {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>? h_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? i_((CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent>? p_ = medClaim?.LineItems;

                bool? q_(Claim.ItemComponent? medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>? t_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? u_((CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent>? w_ = pClaim?.LineItems;

                        bool? x_(ClaimResponse.ItemComponent? pClaimLineItem) {
                            Id? z_;
                            Claim? an_ = medClaim?.ClaimofInterest;
                            bool ao_ = an_ is Resource;
                            if (ao_)
                            {
                                Claim? ap_ = medClaim?.ClaimofInterest;
                                z_ = (ap_ as Resource)!.IdElement;
                            }
                            else
                            {
                                z_ = default;
                            }
                            string? aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                            ClaimResponse? ab_ = pClaim?.Response;
                            ResourceReference? ac_ = ab_?.Request;
                            FhirString? ad_ = ac_?.ReferenceElement;
                            string? ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                            string? af_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ae_);
                            bool? ag_ = context.Operators.Equal(aa_, af_);
                            PositiveInt? ah_ = medClaimLineItem?.SequenceElement;
                            Integer? ai_ = context.Operators.Convert<Integer?>(ah_);
                            PositiveInt? aj_ = pClaimLineItem?.ItemSequenceElement;
                            Integer? ak_ = context.Operators.Convert<Integer?>(aj_);
                            bool? al_ = context.Operators.Equal(ai_, ak_);
                            bool? am_ = context.Operators.And(ag_, al_);
                            return am_;
                        }

                        bool? y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent?>(w_, x_);
                        return y_;
                    }

                    bool? v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>(t_, u_);
                    return v_;
                }

                IEnumerable<Claim.ItemComponent?>? r_ = context.Operators.Where<Claim.ItemComponent?>(p_, q_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? s_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, r_);
                return s_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>(h_, i_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)? k_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, j_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?[]? l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? m_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? aq_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>? av_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? aw_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent>? bb_ = @this?.ClaimItem;
                    bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                    return bc_;
                }


                IEnumerable<Claim.ItemComponent?>? ax_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent>? bd_ = @this?.ClaimItem;
                    return bd_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent?>?>? ay_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(av_, aw_, ax_);
                IEnumerable<Claim.ItemComponent?>? az_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)ay_)!);
                bool? ba_ = context.Operators.Exists<Claim.ItemComponent?>(az_!);
                if (ba_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>? be_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bf_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? bp_ = @this?.PaidClaim;
                        bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                        return bq_;
                    }


                    (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? br_ = @this?.PaidClaim;
                        return br_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? bh_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(be_, bf_, bg_);

                    bool? bi_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? bs_ = @this?.ClaimItem;
                        bool? bt_ = context.Operators.Not((bool?)(bs_ is null));
                        return bt_;
                    }


                    IEnumerable<Claim.ItemComponent?>? bj_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? bu_ = @this?.ClaimItem;
                        return bu_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent?>?>? bk_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(be_, bi_, bj_);
                    IEnumerable<Claim.ItemComponent?>? bl_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)bk_)!);

                    CqlInterval<CqlDateTime?>? bm_(Claim.ItemComponent? PaidItem) {
                        DataType? bv_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime?>? bw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bv_);
                        return bw_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime?>?>? bn_ = context.Operators.SelectDistinct<Claim.ItemComponent?, CqlInterval<CqlDateTime?>?>(bl_, bm_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? bo_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bh_, bn_);
                    aq_ = bo_;
                }
                else
                {
                    aq_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?[]? ar_ = [
                    aq_,
                ];

                bool? as_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                    bool? bx_ = context.Operators.Not((bool?)(FinalList is null));
                    return bx_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? at_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?)ar_, as_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? au_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(at_);
                return au_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?>?)l_, m_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?>?)d_, e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet, IEnumerable<CqlCode?>? DiagnosisValueSet)
    {

        bool? a_(Claim? AllClaims) {
            List<Claim.ItemComponent>? e_ = AllClaims?.Item;

            bool? f_(Claim.ItemComponent? @this) {
                CodeableConcept? ab_ = @this?.ProductOrService;
                bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                return ac_;
            }


            CodeableConcept? g_(Claim.ItemComponent? @this) {
                CodeableConcept? ad_ = @this?.ProductOrService;
                return ad_;
            }

            IEnumerable<CodeableConcept?>? h_ = context.Operators.WhereSelect<Claim.ItemComponent?, CodeableConcept?>((IEnumerable<Claim.ItemComponent?>?)e_, f_, g_);

            bool? i_(CodeableConcept? @this) {
                List<Coding>? ae_ = @this?.Coding;
                bool? af_ = context.Operators.Not((bool?)(ae_ is null));
                return af_;
            }


            List<Coding?>? j_(CodeableConcept? @this) {
                List<Coding>? ag_ = @this?.Coding;
                return ag_;
            }

            IEnumerable<List<Coding?>?>? k_ = context.Operators.WhereSelect<CodeableConcept?, List<Coding?>?>(h_, i_, j_);
            IEnumerable<Coding?>? l_ = context.Operators.Flatten<Coding?>((IEnumerable<IEnumerable<Coding>>)((IEnumerable<IEnumerable<Coding?>?>?)k_)!);

            bool? m_(Coding? ProductOrServiceCode) {
                CqlCode? ah_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? ai_ = context.Operators.In<CqlCode?>(ah_, ProductOrServiceValueSet);
                return ai_;
            }

            bool? n_ = context.Operators.WhereAny<Coding?>(l_, m_);
            List<Claim.DiagnosisComponent>? o_ = AllClaims?.Diagnosis;

            bool? p_(Claim.DiagnosisComponent? @this) {
                DataType? aj_ = @this?.Diagnosis;
                bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                return ak_;
            }


            object q_(Claim.DiagnosisComponent? @this) {
                DataType? al_ = @this?.Diagnosis;
                return al_!;
            }

            IEnumerable<object?>? r_ = context.Operators.WhereSelect<Claim.DiagnosisComponent?, object?>((IEnumerable<Claim.DiagnosisComponent?>?)o_, p_, q_);

            bool? s_(object? @this) {
                object? am_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                bool? an_ = context.Operators.Not((bool?)(am_ is null));
                return an_;
            }


            object t_(object? @this) {
                object? ao_ = context.Operators.LateBoundProperty<object?>(@this, "coding");
                return ao_!;
            }

            IEnumerable<object?>? u_ = context.Operators.WhereSelect<object?, object?>(r_, s_, t_);
            IEnumerable<object?>? v_ = context.Operators.FlattenLateBoundList(((IEnumerable<object>)u_)!);
            Coding? w_(object? @object) => (Coding?)@object;

            bool? x_(Coding? DiagnosisCode) {
                CqlCode? ap_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? aq_ = context.Operators.In<CqlCode?>(ap_, DiagnosisValueSet);
                return aq_;
            }

            IEnumerable<Coding?>? y_ = context.Operators.SelectWhere<object?, Coding?>(v_, w_, x_);
            bool? z_ = context.Operators.Exists<Coding?>(y_!);
            bool? aa_ = context.Operators.Or(n_, z_);
            return aa_;
        }


        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? b_(Claim? ProcedureClaims) {
            List<Claim.ItemComponent>? ar_ = ProcedureClaims?.Item;

            bool? as_(Claim.ItemComponent? ResponseItem) {
                CodeableConcept? au_ = ResponseItem?.ProductOrService;
                List<Coding>? av_ = au_?.Coding;

                bool? aw_(Coding? ProductOrServiceCode) {
                    CqlCode? ay_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? az_ = context.Operators.In<CqlCode?>(ay_, ProductOrServiceValueSet);
                    return az_;
                }

                bool? ax_ = context.Operators.WhereAny<Coding?>((IEnumerable<Coding?>?)av_, aw_);
                return ax_;
            }

            bool? at_ = context.Operators.WhereAny<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)ar_, as_);
            if (at_ ?? false)
            {
                Id? ba_ = ProcedureClaims?.IdElement;
                List<Claim.ItemComponent>? bb_ = ProcedureClaims?.Item;

                bool? bc_(Claim.ItemComponent? ResponseItem) {
                    CodeableConcept? bf_ = ResponseItem?.ProductOrService;
                    List<Coding>? bg_ = bf_?.Coding;

                    bool? bh_(Coding? ProductOrServiceCode) {
                        CqlCode? bj_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                        bool? bk_ = context.Operators.In<CqlCode?>(bj_, ProductOrServiceValueSet);
                        return bk_;
                    }

                    bool? bi_ = context.Operators.WhereAny<Coding?>((IEnumerable<Coding?>?)bg_, bh_);
                    return bi_;
                }

                IEnumerable<Claim.ItemComponent?>? bd_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)bb_, bc_);
                (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? be_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, ba_, bd_);
                return be_;
            }
            else
            {
                Id? bl_ = ProcedureClaims?.IdElement;
                List<Claim.ItemComponent>? bm_ = ProcedureClaims?.Item;

                bool? bn_(Claim.ItemComponent? ResponseItem) {
                    PositiveInt? bq_ = ResponseItem?.SequenceElement;
                    Integer? br_ = context.Operators.Convert<Integer?>(bq_);
                    int? bs_ = br_?.Value;
                    bool? bt_ = context.Operators.Equal(bs_, 1);
                    return bt_;
                }

                IEnumerable<Claim.ItemComponent?>? bo_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)bm_, bn_);
                (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? bp_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, bl_, bo_);
                return bp_;
            }
        }

        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? c_ = context.Operators.WhereSelect<Claim?, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(claim, a_, b_);
        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? d_ = context.Operators.Distinct<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(c_!);
        return d_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Provided Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)? a_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?[]? b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)? MedicalClaimAndResponse) {
            IEnumerable<ClaimResponse>? f_ = MedicalClaimAndResponse?.MedicalClaimResponse;
            IEnumerable<Claim>? g_ = MedicalClaimAndResponse?.MedicalClaim;
            bool? h_ = context.Operators.And((bool?)(f_ is null), (bool?)(g_ is null));
            if (h_ ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
            }
            else
            {
                IEnumerable<ClaimResponse>? i_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                IEnumerable<Claim>? j_ = MedicalClaimAndResponse?.MedicalClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? k_ = this.Get_Corresponding_Claim_for_Services_Only(context, i_, j_, ProductOrServiceValueSet);
                return k_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? d_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? MedicalClaimResponse, IEnumerable<Claim?>? MedicalClaim)?>?)b_, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? e_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Get Corresponding Claim for Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? b_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)? c_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?[]? d_ = [
            c_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)? ClaimAndResponse) {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>? h_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? i_((CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? medClaim) {
                IEnumerable<Claim.ItemComponent>? p_ = medClaim?.LineItems;

                bool? q_(Claim.ItemComponent? medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>? t_ = ClaimAndResponse?.PaidMedicalClaimResponse;

                    bool? u_((CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent>? w_ = pClaim?.LineItems;

                        bool? x_(ClaimResponse.ItemComponent? pClaimLineItem) {
                            Id? z_;
                            Claim? an_ = medClaim?.ClaimofInterest;
                            bool ao_ = an_ is Resource;
                            if (ao_)
                            {
                                Claim? ap_ = medClaim?.ClaimofInterest;
                                z_ = (ap_ as Resource)!.IdElement;
                            }
                            else
                            {
                                z_ = default;
                            }
                            string? aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                            ClaimResponse? ab_ = pClaim?.Response;
                            ResourceReference? ac_ = ab_?.Request;
                            FhirString? ad_ = ac_?.ReferenceElement;
                            string? ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                            string? af_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ae_);
                            bool? ag_ = context.Operators.Equal(aa_, af_);
                            PositiveInt? ah_ = medClaimLineItem?.SequenceElement;
                            Integer? ai_ = context.Operators.Convert<Integer?>(ah_);
                            PositiveInt? aj_ = pClaimLineItem?.ItemSequenceElement;
                            Integer? ak_ = context.Operators.Convert<Integer?>(aj_);
                            bool? al_ = context.Operators.Equal(ai_, ak_);
                            bool? am_ = context.Operators.And(ag_, al_);
                            return am_;
                        }

                        bool? y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent?>(w_, x_);
                        return y_;
                    }

                    bool? v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>(t_, u_);
                    return v_;
                }

                IEnumerable<Claim.ItemComponent?>? r_ = context.Operators.Where<Claim.ItemComponent?>(p_, q_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? s_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, r_);
                return s_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>(h_, i_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)? k_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, j_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?[]? l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? m_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? aq_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>? av_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? aw_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent>? bb_ = @this?.ClaimItem;
                    bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                    return bc_;
                }


                IEnumerable<Claim.ItemComponent?>? ax_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent>? bd_ = @this?.ClaimItem;
                    return bd_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent?>?>? ay_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(av_, aw_, ax_);
                IEnumerable<Claim.ItemComponent?>? az_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)ay_)!);
                bool? ba_ = context.Operators.Exists<Claim.ItemComponent?>(az_!);
                if (ba_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>? be_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bf_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? bp_ = @this?.PaidClaim;
                        bool? bq_ = context.Operators.Not((bool?)(bp_ is null));
                        return bq_;
                    }


                    (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? br_ = @this?.PaidClaim;
                        return br_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? bh_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(be_, bf_, bg_);

                    bool? bi_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? bs_ = @this?.ClaimItem;
                        bool? bt_ = context.Operators.Not((bool?)(bs_ is null));
                        return bt_;
                    }


                    IEnumerable<Claim.ItemComponent?>? bj_((CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? bu_ = @this?.ClaimItem;
                        return bu_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent?>?>? bk_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(be_, bi_, bj_);
                    IEnumerable<Claim.ItemComponent?>? bl_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)bk_)!);

                    CqlInterval<CqlDateTime?>? bm_(Claim.ItemComponent? PaidItem) {
                        DataType? bv_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime?>? bw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bv_);
                        return bw_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime?>?>? bn_ = context.Operators.SelectDistinct<Claim.ItemComponent?, CqlInterval<CqlDateTime?>?>(bl_, bm_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? bo_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, bh_, bn_);
                    aq_ = bo_;
                }
                else
                {
                    aq_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?[]? ar_ = [
                    aq_,
                ];

                bool? as_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? FinalList) {
                    bool? bx_ = context.Operators.Not((bool?)(FinalList is null));
                    return bx_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? at_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>?)ar_, as_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? au_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(at_);
                return au_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?>?)l_, m_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>? f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? MedicalClaim)?>?)d_, e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get All Claims With Procedure Only")]
    public IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {

        bool? a_(Claim? AllClaims) {
            List<Claim.ItemComponent>? e_ = AllClaims?.Item;

            bool? f_(Claim.ItemComponent? @this) {
                CodeableConcept? o_ = @this?.ProductOrService;
                bool? p_ = context.Operators.Not((bool?)(o_ is null));
                return p_;
            }


            CodeableConcept? g_(Claim.ItemComponent? @this) {
                CodeableConcept? q_ = @this?.ProductOrService;
                return q_;
            }

            IEnumerable<CodeableConcept?>? h_ = context.Operators.WhereSelect<Claim.ItemComponent?, CodeableConcept?>((IEnumerable<Claim.ItemComponent?>?)e_, f_, g_);

            bool? i_(CodeableConcept? @this) {
                List<Coding>? r_ = @this?.Coding;
                bool? s_ = context.Operators.Not((bool?)(r_ is null));
                return s_;
            }


            List<Coding?>? j_(CodeableConcept? @this) {
                List<Coding>? t_ = @this?.Coding;
                return t_;
            }

            IEnumerable<List<Coding?>?>? k_ = context.Operators.WhereSelect<CodeableConcept?, List<Coding?>?>(h_, i_, j_);
            IEnumerable<Coding?>? l_ = context.Operators.Flatten<Coding?>((IEnumerable<IEnumerable<Coding>>)((IEnumerable<IEnumerable<Coding?>?>?)k_)!);

            bool? m_(Coding? ProductOrServiceCode) {
                CqlCode? u_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? v_ = context.Operators.In<CqlCode?>(u_, ProductOrServiceValueSet);
                return v_;
            }

            bool? n_ = context.Operators.WhereAny<Coding?>(l_, m_);
            return n_;
        }


        (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? b_(Claim? AllClaims) {
            Id? w_ = AllClaims?.IdElement;
            List<Claim.ItemComponent>? x_ = AllClaims?.Item;

            bool? y_(Claim.ItemComponent? ResponseItem) {
                CodeableConcept? ab_ = ResponseItem?.ProductOrService;
                List<Coding>? ac_ = ab_?.Coding;

                bool? ad_(Coding? ProductOrServiceCode) {
                    CqlCode? af_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? ag_ = context.Operators.In<CqlCode?>(af_, ProductOrServiceValueSet);
                    return ag_;
                }

                bool? ae_ = context.Operators.WhereAny<Coding?>((IEnumerable<Coding?>?)ac_, ad_);
                return ae_;
            }

            IEnumerable<Claim.ItemComponent?>? z_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)x_, y_);
            (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)? aa_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, w_, z_);
            return aa_;
        }

        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? c_ = context.Operators.WhereSelect<Claim?, (CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(claim, a_, b_);
        IEnumerable<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>? d_ = context.Operators.Distinct<(CqlTupleMetadata, Claim? ClaimofInterest, Id? ClaimID, IEnumerable<Claim.ItemComponent?>? LineItems)?>(c_!);
        return d_;
    }


    [CqlFunctionDefinition("Get Paid Claims for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? PharmacyClaimResponse, IEnumerable<Claim?>? PharmacyClaim)? a_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? PharmacyClaimResponse, IEnumerable<Claim?>? PharmacyClaim)?[]? b_ = [
            a_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? c_((CqlTupleMetadata, IEnumerable<ClaimResponse?>? PharmacyClaimResponse, IEnumerable<Claim?>? PharmacyClaim)? PharmacyClaimAndResponse) {
            IEnumerable<ClaimResponse>? f_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
            IEnumerable<Claim>? g_ = PharmacyClaimAndResponse?.PharmacyClaim;
            bool? h_ = context.Operators.And((bool?)(f_ is null), (bool?)(g_ is null));
            if (h_ ?? false)
            {
                return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?;
            }
            else
            {
                IEnumerable<ClaimResponse>? i_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                IEnumerable<Claim>? j_ = PharmacyClaimAndResponse?.PharmacyClaim;
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? k_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, i_, j_, ProductOrServiceValueSet);
                return k_;
            }
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>? d_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? PharmacyClaimResponse, IEnumerable<Claim?>? PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? PharmacyClaimResponse, IEnumerable<Claim?>? PharmacyClaim)?>?)b_, c_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? e_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>(d_);
        return e_;
    }


    [CqlFunctionDefinition("Get All Pharmacy Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse?>? PharmacyClaimResponse, IEnumerable<Claim?>? PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim)
    {
        IEnumerable<ClaimResponse?>? a_ = this.Pharmacy_Claims_Response(context, claimResponse);
        IEnumerable<Claim?>? b_ = this.Pharmacy_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? PharmacyClaimResponse, IEnumerable<Claim?>? PharmacyClaim)? c_ = (CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV, a_, b_);
        return c_;
    }


    [CqlFunctionDefinition("Get Corresponding Claim for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim, IEnumerable<CqlCode?>? ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? a_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? b_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? MedicalClaim)? c_ = (CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF, a_, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? MedicalClaim)?[]? d_ = [
            c_,
        ];

        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? MedicalClaim)? ClaimAndResponse) {
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>? h_ = ClaimAndResponse?.MedicalClaim;

            (CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? i_((CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? medClaim) {
                IEnumerable<Claim.ItemComponent>? p_ = medClaim?.LineItem;

                bool? q_(Claim.ItemComponent? medClaimLineItem) {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>? t_ = ClaimAndResponse?.PaidPharmacyClaimResponse;

                    bool? u_((CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)? pClaim) {
                        IEnumerable<ClaimResponse.ItemComponent>? w_ = pClaim?.LineItems;

                        bool? x_(ClaimResponse.ItemComponent? pClaimLineItem) {
                            Id? z_;
                            Claim? an_ = medClaim?.Claim;
                            bool ao_ = an_ is Resource;
                            if (ao_)
                            {
                                Claim? ap_ = medClaim?.Claim;
                                z_ = (ap_ as Resource)!.IdElement;
                            }
                            else
                            {
                                z_ = default;
                            }
                            string? aa_ = FHIRHelpers_4_0_001.Instance.ToString(context, z_);
                            ClaimResponse? ab_ = pClaim?.Response;
                            ResourceReference? ac_ = ab_?.Request;
                            FhirString? ad_ = ac_?.ReferenceElement;
                            string? ae_ = FHIRHelpers_4_0_001.Instance.ToString(context, ad_);
                            string? af_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ae_);
                            bool? ag_ = context.Operators.Equal(aa_, af_);
                            PositiveInt? ah_ = medClaimLineItem?.SequenceElement;
                            Integer? ai_ = context.Operators.Convert<Integer?>(ah_);
                            PositiveInt? aj_ = pClaimLineItem?.ItemSequenceElement;
                            Integer? ak_ = context.Operators.Convert<Integer?>(aj_);
                            bool? al_ = context.Operators.Equal(ai_, ak_);
                            bool? am_ = context.Operators.And(ag_, al_);
                            return am_;
                        }

                        bool? y_ = context.Operators.WhereAny<ClaimResponse.ItemComponent?>(w_, x_);
                        return y_;
                    }

                    bool? v_ = context.Operators.WhereAny<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>(t_, u_);
                    return v_;
                }

                IEnumerable<Claim.ItemComponent?>? r_ = context.Operators.Where<Claim.ItemComponent?>(p_, q_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? s_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, r_);
                return s_;
            }

            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? j_ = context.Operators.SelectDistinct<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>(h_, i_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)? k_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, j_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?[]? l_ = [
                k_,
            ];

            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? m_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)? ClaimWithPaidResponse) {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? aq_;
                IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>? av_ = ClaimWithPaidResponse?.AggregateClaim;

                bool? aw_((CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent>? bb_ = @this?.ClaimItem;
                    bool? bc_ = context.Operators.Not((bool?)(bb_ is null));
                    return bc_;
                }


                IEnumerable<Claim.ItemComponent?>? ax_((CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                    IEnumerable<Claim.ItemComponent>? bd_ = @this?.ClaimItem;
                    return bd_;
                }

                IEnumerable<IEnumerable<Claim.ItemComponent?>?>? ay_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(av_, aw_, ax_);
                IEnumerable<Claim.ItemComponent?>? az_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)ay_)!);
                bool? ba_ = context.Operators.Exists<Claim.ItemComponent?>(az_!);
                if (ba_ ?? false)
                {
                    IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>? be_ = ClaimWithPaidResponse?.AggregateClaim;

                    bool? bf_((CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? bv_ = @this?.PaidClaim;
                        bool? bw_ = context.Operators.Not((bool?)(bv_ is null));
                        return bw_;
                    }


                    (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? bg_((CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? bx_ = @this?.PaidClaim;
                        return bx_;
                    }

                    IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? bh_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>(be_, bf_, bg_);

                    bool? bi_((CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? by_ = @this?.ClaimItem;
                        bool? bz_ = context.Operators.Not((bool?)(by_ is null));
                        return bz_;
                    }


                    IEnumerable<Claim.ItemComponent?>? bj_((CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? ca_ = @this?.ClaimItem;
                        return ca_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent?>?>? bk_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(be_, bi_, bj_);
                    IEnumerable<Claim.ItemComponent?>? bl_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)bk_)!);

                    CqlInterval<CqlDateTime?>? bm_(Claim.ItemComponent? PaidItem) {
                        DataType? cb_ = PaidItem?.Serviced;
                        CqlInterval<CqlDateTime?>? cc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, cb_);
                        return cc_;
                    }

                    IEnumerable<CqlInterval<CqlDateTime?>?>? bn_ = context.Operators.SelectDistinct<Claim.ItemComponent?, CqlInterval<CqlDateTime?>?>(bl_, bm_);

                    bool? bo_((CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? cd_ = @this?.ClaimItem;
                        bool? ce_ = context.Operators.Not((bool?)(cd_ is null));
                        return ce_;
                    }


                    IEnumerable<Claim.ItemComponent?>? bp_((CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)? @this) {
                        IEnumerable<Claim.ItemComponent>? cf_ = @this?.ClaimItem;
                        return cf_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent?>?>? bq_ = context.Operators.WhereSelect<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?, IEnumerable<Claim.ItemComponent?>?>(be_, bo_, bp_);
                    IEnumerable<Claim.ItemComponent?>? br_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)bq_)!);

                    CqlInterval<CqlDate?>? bs_(Claim.ItemComponent? i) {
                        Quantity? cg_ = i?.Quantity;
                        bool? ch_ = context.Operators.Not((bool?)(cg_ is null));
                        if (ch_ ?? false)
                        {
                            DataType? ci_ = i?.Serviced;
                            CqlInterval<CqlDateTime?>? cj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ci_);
                            CqlDateTime? ck_ = context.Operators.Start(cj_);
                            CqlDate? cl_ = context.Operators.ConvertDateTimeToDate(ck_);
                            Quantity? cm_ = i?.Quantity;
                            FhirDecimal? cn_ = cm_?.ValueElement;
                            decimal? co_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, cn_);
                            CqlDateTime? cp_ = context.Operators.Add(ck_, new CqlQuantity(co_, "day"));
                            CqlQuantity? cq_ = context.Operators.Quantity(1m, "day");
                            CqlDateTime? cr_ = context.Operators.Subtract(cp_, cq_);
                            CqlDate? cs_ = context.Operators.ConvertDateTimeToDate(cr_);
                            CqlInterval<CqlDate?>? ct_ = context.Operators.Interval(cl_, cs_, true, true);
                            return ct_;
                        }
                        else
                        {
                            return null as CqlInterval<CqlDate?>;
                        }
                    }

                    IEnumerable<CqlInterval<CqlDate?>?>? bt_ = context.Operators.SelectDistinct<Claim.ItemComponent?, CqlInterval<CqlDate?>?>(br_, bs_);
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? bu_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, bh_, bn_, bt_);
                    aq_ = bu_;
                }
                else
                {
                    aq_ = null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?;
                }
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?[]? ar_ = [
                    aq_,
                ];

                bool? as_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? FinalList) {
                    bool? cu_ = context.Operators.Not((bool?)(FinalList is null));
                    return cu_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>? at_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>?)ar_, as_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? au_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>(at_);
                return au_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>? n_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent?>? ClaimItem)?>? AggregateClaim)?>?)l_, m_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? o_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>(n_);
            return o_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>? f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse? Response, string? ResponseID, IEnumerable<ClaimResponse.ItemComponent?>? LineItems)?>? PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? MedicalClaim)?>?)d_, e_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? Claim, IEnumerable<Claim.ItemComponent?>? LineItem, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDateTime?>?>? CoveredDays)?>? originalClaim, IEnumerable<CqlInterval<CqlDateTime?>?>? ServicePeriod, IEnumerable<CqlInterval<CqlDate?>?>? CoveredDays)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get Claim With Corresponding Claim Response")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? ClaimResponse, IEnumerable<Claim?>? OriginalClaim)?>? Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse?>? claimResponse, IEnumerable<Claim?>? claim)
    {

        (CqlTupleMetadata, IEnumerable<ClaimResponse?>? ClaimResponse, IEnumerable<Claim?>? OriginalClaim)? a_(Claim? Claim) {

            bool? c_(ClaimResponse? CR) {
                Id? h_ = Claim?.IdElement;
                string? i_ = FHIRHelpers_4_0_001.Instance.ToString(context, h_);
                ResourceReference? j_ = CR?.Request;
                FhirString? k_ = j_?.ReferenceElement;
                string? l_ = FHIRHelpers_4_0_001.Instance.ToString(context, k_);
                string? m_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, l_);
                bool? n_ = context.Operators.Equal(i_, m_);
                return n_;
            }

            IEnumerable<ClaimResponse?>? d_ = context.Operators.Where<ClaimResponse?>(claimResponse, c_);

            bool? e_(Claim? C) {
                Id? o_ = Claim?.IdElement;
                string? p_ = FHIRHelpers_4_0_001.Instance.ToString(context, o_);

                bool? q_(ClaimResponse? CR) {
                    Id? ac_ = Claim?.IdElement;
                    string? ad_ = FHIRHelpers_4_0_001.Instance.ToString(context, ac_);
                    ResourceReference? ae_ = CR?.Request;
                    FhirString? af_ = ae_?.ReferenceElement;
                    string? ag_ = FHIRHelpers_4_0_001.Instance.ToString(context, af_);
                    string? ah_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ag_);
                    bool? ai_ = context.Operators.Equal(ad_, ah_);
                    return ai_;
                }

                IEnumerable<ClaimResponse?>? r_ = context.Operators.Where<ClaimResponse?>(claimResponse, q_);

                bool? s_(ClaimResponse? @this) {
                    ResourceReference? aj_ = @this?.Request;
                    bool? ak_ = context.Operators.Not((bool?)(aj_ is null));
                    return ak_;
                }


                ResourceReference? t_(ClaimResponse? @this) {
                    ResourceReference? al_ = @this?.Request;
                    return al_;
                }

                IEnumerable<ResourceReference?>? u_ = context.Operators.WhereSelect<ClaimResponse?, ResourceReference?>(r_, s_, t_);

                bool? v_(ResourceReference? @this) {
                    FhirString? am_ = @this?.ReferenceElement;
                    bool? an_ = context.Operators.Not((bool?)(am_ is null));
                    return an_;
                }


                FhirString? w_(ResourceReference? @this) {
                    FhirString? ao_ = @this?.ReferenceElement;
                    return ao_;
                }

                IEnumerable<FhirString?>? x_ = context.Operators.WhereSelect<ResourceReference?, FhirString?>(u_, v_, w_);
                FhirString? y_ = context.Operators.SingletonFrom<FhirString?>(x_);
                string? z_ = FHIRHelpers_4_0_001.Instance.ToString(context, y_);
                string? aa_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, z_);
                bool? ab_ = context.Operators.Equal(p_, aa_);
                return ab_;
            }

            IEnumerable<Claim?>? f_ = context.Operators.Where<Claim?>(claim, e_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse?>? ClaimResponse, IEnumerable<Claim?>? OriginalClaim)? g_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, d_, f_);
            return g_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse?>? ClaimResponse, IEnumerable<Claim?>? OriginalClaim)?>? b_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, IEnumerable<ClaimResponse?>? ClaimResponse, IEnumerable<Claim?>? OriginalClaim)?>(claim, a_);
        return b_;
    }


    [CqlFunctionDefinition("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public (CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim?>? claim)
    {
        IEnumerable<Claim?>? a_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim)? b_ = (CqlTupleMetadata_ETQMCTGZaBMKcJbAjKZCAIRDW, a_);
        (CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim)?[]? c_ = [
            b_,
        ];

        (CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)? d_((CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim)? ClaimWithInpatientStay) {
            IEnumerable<Claim>? g_;
            if (ClaimWithInpatientStay?.MedicalClaim is null)
            {
                g_ = null as IEnumerable<Claim?>;
            }
            else
            {
                IEnumerable<Claim>? n_ = ClaimWithInpatientStay?.MedicalClaim;

                bool? o_(Claim? c) {
                    List<Claim.ItemComponent>? q_ = c?.Item;

                    bool? r_(Claim.ItemComponent? i) {
                        CodeableConcept? t_ = i?.Revenue;
                        CqlConcept? u_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, t_);
                        IReadOnlyList<CqlCode>? v_ = u_?.codes;

                        bool? w_(CqlCode? rev) {
                            string? y_ = rev?.code;
                            CqlValueSet? z_ = this.Inpatient_Stay(context);
                            bool? aa_ = context.Operators.StringInValueSet(y_, z_);
                            return aa_;
                        }

                        bool? x_ = context.Operators.WhereAny<CqlCode?>((IEnumerable<CqlCode?>?)v_, w_);
                        return x_;
                    }

                    bool? s_ = context.Operators.WhereAny<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)q_, r_);
                    return s_;
                }

                IEnumerable<Claim?>? p_ = context.Operators.Where<Claim?>(n_, o_);
                g_ = p_;
            }
            IEnumerable<Claim>? h_;
            if (ClaimWithInpatientStay?.MedicalClaim is null)
            {
                h_ = null as IEnumerable<Claim?>;
            }
            else
            {
                IEnumerable<Claim>? ab_ = ClaimWithInpatientStay?.MedicalClaim;

                bool? ac_(Claim? c) {
                    List<Claim.ItemComponent>? ae_ = c?.Item;

                    bool? af_(Claim.ItemComponent? i) {
                        CodeableConcept? am_ = i?.Revenue;
                        CqlConcept? an_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, am_);
                        IReadOnlyList<CqlCode>? ao_ = an_?.codes;

                        bool? ap_(CqlCode? rev) {
                            string? ar_ = rev?.code;
                            CqlValueSet? as_ = this.Nonacute_Inpatient_Stay(context);
                            bool? at_ = context.Operators.StringInValueSet(ar_, as_);
                            return at_;
                        }

                        bool? aq_ = context.Operators.WhereAny<CqlCode?>((IEnumerable<CqlCode?>?)ao_, ap_);
                        return aq_;
                    }

                    bool? ag_ = context.Operators.WhereAny<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)ae_, af_);
                    CodeableConcept? ah_ = c?.SubType;
                    List<Coding>? ai_ = ah_?.Coding;

                    bool? aj_(Coding? tob) {
                        Code? au_ = tob?.CodeElement;
                        string? av_ = au_?.Value;
                        CqlValueSet? aw_ = this.Nonacute_Inpatient_Stay(context);
                        bool? ax_ = context.Operators.StringInValueSet(av_, aw_);
                        return ax_;
                    }

                    bool? ak_ = context.Operators.WhereAny<Coding?>((IEnumerable<Coding?>?)ai_, aj_);
                    bool? al_ = context.Operators.Or(ag_, ak_);
                    return al_;
                }

                IEnumerable<Claim?>? ad_ = context.Operators.Where<Claim?>(ab_, ac_);
                h_ = ad_;
            }
            (CqlTupleMetadata, IEnumerable<Claim?>? InpatientStayLineItems, IEnumerable<Claim?>? NonacuteInpatientLineItems)? i_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, g_, h_);
            (CqlTupleMetadata, IEnumerable<Claim?>? InpatientStayLineItems, IEnumerable<Claim?>? NonacuteInpatientLineItems)?[]? j_ = [
                i_,
            ];

            (CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)? k_((CqlTupleMetadata, IEnumerable<Claim?>? InpatientStayLineItems, IEnumerable<Claim?>? NonacuteInpatientLineItems)? LineItemDefinition) {
                IEnumerable<Claim>? ay_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim>? az_ = LineItemDefinition?.NonacuteInpatientLineItems;

                bool? ba_(Claim? nonAcuteInpatientStay) {
                    IEnumerable<Claim>? bf_ = LineItemDefinition?.InpatientStayLineItems;

                    bool? bg_(Claim? inpatientStay) {
                        Id? bi_ = nonAcuteInpatientStay?.IdElement;
                        Id? bj_ = inpatientStay?.IdElement;
                        bool? bk_ = context.Operators.Equal(bi_, bj_);
                        return bk_;
                    }

                    bool? bh_ = context.Operators.WhereAny<Claim?>(bf_, bg_);
                    return bh_;
                }

                IEnumerable<Claim?>? bb_ = context.Operators.Where<Claim?>(az_, ba_);

                bool? bc_(Claim? inpatientStay) {
                    IEnumerable<Claim>? bl_ = LineItemDefinition?.NonacuteInpatientLineItems;

                    bool? bm_(Claim? nonAcuteInpatientStay) {
                        Id? bp_ = inpatientStay?.IdElement;
                        Id? bq_ = nonAcuteInpatientStay?.IdElement;
                        bool? br_ = context.Operators.Equal(bp_, bq_);
                        return br_;
                    }

                    bool? bn_ = context.Operators.WhereAny<Claim?>(bl_, bm_);
                    bool? bo_ = context.Operators.Not(bn_);
                    return bo_;
                }

                IEnumerable<Claim?>? bd_ = context.Operators.Where<Claim?>(ay_, bc_);
                (CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)? be_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, ay_, bb_, bd_);
                return be_;
            }

            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)?>? l_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? InpatientStayLineItems, IEnumerable<Claim?>? NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? InpatientStayLineItems, IEnumerable<Claim?>? NonacuteInpatientLineItems)?>?)j_, k_);
            (CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)? m_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)?>(l_);
            return m_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)?>? e_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim)?, (CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim?>? MedicalClaim)?>?)c_, d_);
        (CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)? f_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim?>? InpatientDischarge, IEnumerable<Claim?>? NonacuteInpatientDischarge, IEnumerable<Claim?>? AcuteInpatientDischarge)?>(e_);
        return f_;
    }


    [CqlFunctionDefinition("Get Prescriber NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim?>? claim)
    {

        (CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)? a_(Claim? C) {
            List<Claim.CareTeamComponent>? h_ = C?.CareTeam;

            bool? i_(Claim.CareTeamComponent? ct) {
                PositiveInt? v_ = ct?.SequenceElement;
                Integer? w_ = context.Operators.Convert<Integer?>(v_);
                int? x_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, w_);
                bool? y_ = context.Operators.Equal(x_, 1);
                return y_;
            }

            IEnumerable<Claim.CareTeamComponent?>? j_ = context.Operators.Where<Claim.CareTeamComponent?>((IEnumerable<Claim.CareTeamComponent?>?)h_, i_);

            bool? k_(Claim.CareTeamComponent? @this) {
                ResourceReference? z_ = @this?.Provider;
                bool? aa_ = context.Operators.Not((bool?)(z_ is null));
                return aa_;
            }


            ResourceReference? l_(Claim.CareTeamComponent? @this) {
                ResourceReference? ab_ = @this?.Provider;
                return ab_;
            }

            IEnumerable<ResourceReference?>? m_ = context.Operators.WhereSelect<Claim.CareTeamComponent?, ResourceReference?>(j_, k_, l_);

            bool? n_(Claim.CareTeamComponent? ct) {
                PositiveInt? ac_ = ct?.SequenceElement;
                Integer? ad_ = context.Operators.Convert<Integer?>(ac_);
                int? ae_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ad_);
                bool? af_ = context.Operators.Equal(ae_, 1);
                return af_;
            }

            IEnumerable<Claim.CareTeamComponent?>? o_ = context.Operators.Where<Claim.CareTeamComponent?>((IEnumerable<Claim.CareTeamComponent?>?)h_, n_);

            bool? p_(Claim.CareTeamComponent? @this) {
                ResourceReference? ag_ = @this?.Provider;
                bool? ah_ = context.Operators.Not((bool?)(ag_ is null));
                return ah_;
            }


            ResourceReference? q_(Claim.CareTeamComponent? @this) {
                ResourceReference? ai_ = @this?.Provider;
                return ai_;
            }

            IEnumerable<ResourceReference?>? r_ = context.Operators.WhereSelect<Claim.CareTeamComponent?, ResourceReference?>(o_, p_, q_);

            string? s_(ResourceReference? p) {
                FhirString? aj_ = p?.ReferenceElement;
                FhirString?[]? ak_ = [
                    aj_,
                ];

                string? al_(FhirString? r) {
                    string? ao_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string? ap_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ao_);
                    return ap_;
                }

                IEnumerable<string?>? am_ = context.Operators.Select<FhirString?, string?>((IEnumerable<FhirString?>?)ak_, al_);
                string? an_ = context.Operators.SingletonFrom<string?>(am_);
                return an_;
            }

            IEnumerable<string?>? t_ = context.Operators.Select<ResourceReference?, string?>(r_, s_);
            (CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)? u_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, m_, t_);
            return u_;
        }

        IEnumerable<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?>? b_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?>(claim, a_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?>? CareTeams)? c_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?>? CareTeams)?[]? d_ = [
            c_,
        ];

        (CqlTupleMetadata, int? IdentifierCount)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?>? CareTeams)? ClaimProperties) {
            IEnumerable<Practitioner?>? aq_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));

            bool? ar_(Practitioner? p) {
                Id? ay_ = p?.IdElement;
                string? az_ = FHIRHelpers_4_0_001.Instance.ToString(context, ay_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>? ba_ = ClaimProperties?.CareTeams;

                bool? bb_((CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)? @this) {
                    IEnumerable<string>? bg_ = @this?.CareTeamsProviderID;
                    bool? bh_ = context.Operators.Not((bool?)(bg_ is null));
                    return bh_;
                }


                IEnumerable<string?>? bc_((CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)? @this) {
                    IEnumerable<string>? bi_ = @this?.CareTeamsProviderID;
                    return bi_;
                }

                IEnumerable<IEnumerable<string?>?>? bd_ = context.Operators.WhereSelect<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?, IEnumerable<string?>?>(ba_, bb_, bc_);
                IEnumerable<string?>? be_ = context.Operators.Flatten<string?>(((IEnumerable<IEnumerable<string>>)bd_)!);
                bool? bf_ = context.Operators.In<string?>(az_, be_);
                return bf_;
            }

            IEnumerable<Practitioner?>? as_ = context.Operators.Where<Practitioner?>(aq_, ar_);
            (CqlTupleMetadata, IEnumerable<Practitioner?>? Practitioners)? at_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, as_);
            (CqlTupleMetadata, IEnumerable<Practitioner?>? Practitioners)?[]? au_ = [
                at_,
            ];

            (CqlTupleMetadata, int? IdentifierCount)? av_((CqlTupleMetadata, IEnumerable<Practitioner?>? Practitioners)? PractitionerMatch) {
                IEnumerable<Practitioner>? bj_ = PractitionerMatch?.Practitioners;

                bool? bk_(Practitioner? P) {
                    bool? bs_ = context.Operators.Not((bool?)(P is null));
                    return bs_;
                }


                (CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)? bl_(Practitioner? P) {
                    List<Identifier>? bt_ = P?.Identifier;

                    bool? bu_(Identifier? l) {
                        FhirUri? cc_ = l?.SystemElement;
                        string? cd_ = cc_?.Value;
                        bool? ce_ = context.Operators.Equal(cd_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept? cf_ = l?.Type;
                        CqlConcept? cg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cf_);
                        CqlCode? ch_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept? ci_ = context.Operators.ConvertCodeToConcept(ch_);
                        bool? cj_ = context.Operators.Equivalent(cg_, ci_);
                        bool? ck_ = context.Operators.And(ce_, cj_);
                        FhirString? cl_ = l?.ValueElement;
                        string? cm_ = cl_?.Value;
                        bool? cn_ = context.Operators.Not((bool?)(cm_ is null));
                        bool? co_ = context.Operators.And(ck_, cn_);
                        return co_;
                    }


                    FhirString? bv_(Identifier? l) {
                        FhirString? cp_ = l?.ValueElement;
                        return cp_;
                    }

                    IEnumerable<FhirString?>? bw_ = context.Operators.WhereSelect<Identifier?, FhirString?>((IEnumerable<Identifier?>?)bt_, bu_, bv_);
                    IEnumerable<FhirString?>? bx_ = context.Operators.Distinct<FhirString?>(bw_!);

                    bool? by_(Identifier? l) {
                        FhirUri? cq_ = l?.SystemElement;
                        string? cr_ = cq_?.Value;
                        bool? cs_ = context.Operators.Equal(cr_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept? ct_ = l?.Type;
                        CqlConcept? cu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ct_);
                        CqlCode? cv_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept? cw_ = context.Operators.ConvertCodeToConcept(cv_);
                        bool? cx_ = context.Operators.Equivalent(cu_, cw_);
                        bool? cy_ = context.Operators.And(cs_, cx_);
                        FhirString? cz_ = l?.ValueElement;
                        string? da_ = cz_?.Value;
                        bool? db_ = context.Operators.And(cy_, (bool?)(da_ is null));
                        return db_;
                    }

                    Identifier? bz_(Identifier? l) => l;
                    IEnumerable<Identifier?>? ca_ = context.Operators.WhereSelect<Identifier?, Identifier?>((IEnumerable<Identifier?>?)bt_, by_, bz_);
                    (CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)? cb_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, bx_, ca_);
                    return cb_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? bm_ = context.Operators.WhereSelect<Practitioner?, (CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>(bj_, bk_, bl_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)? bn_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, bm_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)?[]? bo_ = [
                    bn_,
                ];

                (CqlTupleMetadata, int? IdentifierCount)? bp_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)? GetIdentifiers) {
                    int? dc_;
                    IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>? de_ = ClaimProperties?.CareTeams;

                    bool? df_((CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)? @this) {
                        Claim? dj_ = @this?.SingleCareTeam;
                        bool? dk_ = context.Operators.Not((bool?)(dj_ is null));
                        return dk_;
                    }


                    Claim? dg_((CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)? @this) {
                        Claim? dl_ = @this?.SingleCareTeam;
                        return dl_;
                    }

                    IEnumerable<Claim?>? dh_ = context.Operators.WhereSelect<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?, Claim?>(de_, df_, dg_);
                    bool? di_ = context.Operators.Exists<Claim?>(dh_!);
                    if (di_ ?? false)
                    {
                        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>? dm_ = ClaimProperties?.CareTeams;

                        bool? dn_((CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)? @this) {
                            Claim? eg_ = @this?.SingleCareTeam;
                            bool? eh_ = context.Operators.Not((bool?)(eg_ is null));
                            return eh_;
                        }


                        Claim? do_((CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)? @this) {
                            Claim? ei_ = @this?.SingleCareTeam;
                            return ei_;
                        }

                        IEnumerable<Claim?>? dp_ = context.Operators.WhereSelect<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?, Claim?>(dm_, dn_, do_);

                        bool? dq_(Claim? X) {
                            List<Claim.CareTeamComponent>? ej_ = X?.CareTeam;
                            return (bool?)(((IEnumerable<Claim.CareTeamComponent?>?)ej_) is null);
                        }

                        IEnumerable<Claim?>? dr_ = context.Operators.Where<Claim?>(dp_, dq_);
                        int? ds_ = context.Operators.Count<Claim?>(dr_);
                        IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>? dt_ = GetIdentifiers?.IdentifierTuple;

                        IEnumerable<FhirString?>? du_((CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)? X) {
                            IEnumerable<FhirString>? ek_ = X?.AllIdentifiers;
                            return ek_;
                        }

                        IEnumerable<IEnumerable<FhirString?>?>? dv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?, IEnumerable<FhirString?>?>(dt_, du_);
                        IEnumerable<FhirString?>? dw_ = context.Operators.Flatten<FhirString?>(((IEnumerable<IEnumerable<FhirString>>)dv_)!);
                        FhirString? dx_(FhirString? X) => X;
                        IEnumerable<FhirString?>? dy_ = context.Operators.SelectDistinct<FhirString?, FhirString?>(dw_, dx_);
                        int? dz_ = context.Operators.Count<FhirString?>(dy_);
                        int? ea_ = context.Operators.Add(ds_, dz_);

                        IEnumerable<Identifier?>? eb_((CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)? X) {
                            IEnumerable<Identifier>? el_ = X?.NullIdentifiers;
                            return el_;
                        }

                        IEnumerable<IEnumerable<Identifier?>?>? ec_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?, IEnumerable<Identifier?>?>(dt_, eb_);
                        IEnumerable<Identifier?>? ed_ = context.Operators.Flatten<Identifier?>(((IEnumerable<IEnumerable<Identifier>>)ec_)!);
                        int? ee_ = context.Operators.Count<Identifier?>(ed_);
                        int? ef_ = context.Operators.Add(ea_, ee_);
                        dc_ = ef_;
                    }
                    else
                    {
                        dc_ = 0;
                    }
                    (CqlTupleMetadata, int? IdentifierCount)? dd_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, dc_);
                    return dd_;
                }

                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?>? bq_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)?>?)bo_, bp_);
                (CqlTupleMetadata, int? IdentifierCount)? br_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bq_);
                return br_;
            }

            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?>? aw_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Practitioner?>? Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner?>? Practitioners)?>?)au_, av_);
            (CqlTupleMetadata, int? IdentifierCount)? ax_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(aw_);
            return ax_;
        }

        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?>? f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?>? CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim? SingleCareTeam, IEnumerable<ResourceReference?>? CareTeamsProvider, IEnumerable<string?>? CareTeamsProviderID)?>? CareTeams)?>?)d_, e_);
        (CqlTupleMetadata, int? IdentifierCount)? g_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(f_);
        return g_;
    }


    [CqlFunctionDefinition("Get Pharmacy NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim?>? claim)
    {

        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)? a_(Claim? C) {
            List<Claim.ItemComponent>? h_ = C?.Item;

            bool? i_(Claim.ItemComponent? i) {
                PositiveInt? x_ = i?.SequenceElement;
                Integer? y_ = context.Operators.Convert<Integer?>(x_);
                int? z_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, y_);
                bool? aa_ = context.Operators.Equal(z_, 1);
                return aa_;
            }

            IEnumerable<Claim.ItemComponent?>? j_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)h_, i_);

            bool? k_(Claim.ItemComponent? @this) {
                DataType? ab_ = @this?.Location;
                bool? ac_ = context.Operators.Not((bool?)(ab_ is null));
                return ac_;
            }


            object l_(Claim.ItemComponent? @this) {
                DataType? ad_ = @this?.Location;
                return ad_!;
            }

            IEnumerable<object?>? m_ = context.Operators.WhereSelect<Claim.ItemComponent?, object?>(j_, k_, l_);
            ResourceReference? n_(object? l) => l as ResourceReference;
            IEnumerable<ResourceReference?>? o_ = context.Operators.Select<object?, ResourceReference?>(m_, n_);

            bool? p_(Claim.ItemComponent? i) {
                PositiveInt? ae_ = i?.SequenceElement;
                Integer? af_ = context.Operators.Convert<Integer?>(ae_);
                int? ag_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, af_);
                bool? ah_ = context.Operators.Equal(ag_, 1);
                return ah_;
            }

            IEnumerable<Claim.ItemComponent?>? q_ = context.Operators.Where<Claim.ItemComponent?>((IEnumerable<Claim.ItemComponent?>?)h_, p_);

            bool? r_(Claim.ItemComponent? @this) {
                DataType? ai_ = @this?.Location;
                bool? aj_ = context.Operators.Not((bool?)(ai_ is null));
                return aj_;
            }


            object s_(Claim.ItemComponent? @this) {
                DataType? ak_ = @this?.Location;
                return ak_!;
            }

            IEnumerable<object?>? t_ = context.Operators.WhereSelect<Claim.ItemComponent?, object?>(q_, r_, s_);

            string? u_(object? l) {
                FhirString? al_ = (l as ResourceReference)?.ReferenceElement;
                FhirString?[]? am_ = [
                    al_,
                ];

                string? an_(FhirString? r) {
                    string? aq_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string? ar_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, aq_);
                    return ar_;
                }

                IEnumerable<string?>? ao_ = context.Operators.Select<FhirString?, string?>((IEnumerable<FhirString?>?)am_, an_);
                string? ap_ = context.Operators.SingletonFrom<string?>(ao_);
                return ap_;
            }

            IEnumerable<string?>? v_ = context.Operators.Select<object?, string?>(t_, u_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)? w_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent?>?)h_, o_, v_);
            return w_;
        }

        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?>? b_ = context.Operators.SelectDistinct<Claim?, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?>(claim, a_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?>? ItemsLocationReferences)? c_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, b_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?>? ItemsLocationReferences)?[]? d_ = [
            c_,
        ];

        (CqlTupleMetadata, int? IdentifierCount)? e_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?>? ItemsLocationReferences)? ClaimProperties) {
            IEnumerable<Location?>? as_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));

            bool? at_(Location? l) {
                Id? ba_ = l?.IdElement;
                string? bb_ = FHIRHelpers_4_0_001.Instance.ToString(context, ba_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>? bc_ = ClaimProperties?.ItemsLocationReferences;

                bool? bd_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)? @this) {
                    IEnumerable<string>? bi_ = @this?.ItemLocationID;
                    bool? bj_ = context.Operators.Not((bool?)(bi_ is null));
                    return bj_;
                }


                IEnumerable<string?>? be_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)? @this) {
                    IEnumerable<string>? bk_ = @this?.ItemLocationID;
                    return bk_;
                }

                IEnumerable<IEnumerable<string?>?>? bf_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?, IEnumerable<string?>?>(bc_, bd_, be_);
                IEnumerable<string?>? bg_ = context.Operators.Flatten<string?>(((IEnumerable<IEnumerable<string>>)bf_)!);
                bool? bh_ = context.Operators.In<string?>(bb_, bg_);
                return bh_;
            }

            IEnumerable<Location?>? au_ = context.Operators.Where<Location?>(as_, at_);
            (CqlTupleMetadata, IEnumerable<Location?>? CorrespondingLocations)? av_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, au_);
            (CqlTupleMetadata, IEnumerable<Location?>? CorrespondingLocations)?[]? aw_ = [
                av_,
            ];

            (CqlTupleMetadata, int? IdentifierCount)? ax_((CqlTupleMetadata, IEnumerable<Location?>? CorrespondingLocations)? GetLocation) {
                IEnumerable<Location>? bl_ = GetLocation?.CorrespondingLocations;

                bool? bm_(Location? C) {
                    bool? bu_ = context.Operators.Not((bool?)(C is null));
                    return bu_;
                }


                (CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)? bn_(Location? C) {
                    List<Identifier>? bv_ = C?.Identifier;

                    bool? bw_(Identifier? l) {
                        FhirUri? ce_ = l?.SystemElement;
                        string? cf_ = ce_?.Value;
                        bool? cg_ = context.Operators.Equal(cf_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept? ch_ = l?.Type;
                        CqlConcept? ci_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ch_);
                        CqlCode? cj_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept? ck_ = context.Operators.ConvertCodeToConcept(cj_);
                        bool? cl_ = context.Operators.Equivalent(ci_, ck_);
                        bool? cm_ = context.Operators.And(cg_, cl_);
                        FhirString? cn_ = l?.ValueElement;
                        string? co_ = cn_?.Value;
                        bool? cp_ = context.Operators.Not((bool?)(co_ is null));
                        bool? cq_ = context.Operators.And(cm_, cp_);
                        return cq_;
                    }


                    FhirString? bx_(Identifier? l) {
                        FhirString? cr_ = l?.ValueElement;
                        return cr_;
                    }

                    IEnumerable<FhirString?>? by_ = context.Operators.WhereSelect<Identifier?, FhirString?>((IEnumerable<Identifier?>?)bv_, bw_, bx_);
                    IEnumerable<FhirString?>? bz_ = context.Operators.Distinct<FhirString?>(by_!);

                    bool? ca_(Identifier? l) {
                        FhirUri? cs_ = l?.SystemElement;
                        string? ct_ = cs_?.Value;
                        bool? cu_ = context.Operators.Equal(ct_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept? cv_ = l?.Type;
                        CqlConcept? cw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, cv_);
                        CqlCode? cx_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept? cy_ = context.Operators.ConvertCodeToConcept(cx_);
                        bool? cz_ = context.Operators.Equivalent(cw_, cy_);
                        bool? da_ = context.Operators.And(cu_, cz_);
                        FhirString? db_ = l?.ValueElement;
                        string? dc_ = db_?.Value;
                        bool? dd_ = context.Operators.And(da_, (bool?)(dc_ is null));
                        return dd_;
                    }

                    Identifier? cb_(Identifier? l) => l;
                    IEnumerable<Identifier?>? cc_ = context.Operators.WhereSelect<Identifier?, Identifier?>((IEnumerable<Identifier?>?)bv_, ca_, cb_);
                    (CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)? cd_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, bz_, cc_);
                    return cd_;
                }

                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? bo_ = context.Operators.WhereSelect<Location?, (CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>(bl_, bm_, bn_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)? bp_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, bo_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)?[]? bq_ = [
                    bp_,
                ];

                (CqlTupleMetadata, int? IdentifierCount)? br_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)? GetIdentifiers) {
                    int? de_;
                    IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>? dg_ = ClaimProperties?.ItemsLocationReferences;

                    bool? dh_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)? @this) {
                        IEnumerable<Claim.ItemComponent>? dm_ = @this?.SingleItem;
                        bool? dn_ = context.Operators.Not((bool?)(dm_ is null));
                        return dn_;
                    }


                    IEnumerable<Claim.ItemComponent?>? di_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)? @this) {
                        IEnumerable<Claim.ItemComponent>? do_ = @this?.SingleItem;
                        return do_;
                    }

                    IEnumerable<IEnumerable<Claim.ItemComponent?>?>? dj_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?, IEnumerable<Claim.ItemComponent?>?>(dg_, dh_, di_);
                    IEnumerable<Claim.ItemComponent?>? dk_ = context.Operators.Flatten<Claim.ItemComponent?>(((IEnumerable<IEnumerable<Claim.ItemComponent>>)dj_)!);
                    bool? dl_ = context.Operators.Exists<Claim.ItemComponent?>(dk_!);
                    if (dl_ ?? false)
                    {
                        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>? dp_ = ClaimProperties?.ItemsLocationReferences;

                        bool? dq_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)? @this) {
                            IEnumerable<ResourceReference>? ek_ = @this?.ItemLocation;
                            bool? el_ = context.Operators.Not((bool?)(ek_ is null));
                            return el_;
                        }


                        IEnumerable<ResourceReference?>? dr_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)? @this) {
                            IEnumerable<ResourceReference>? em_ = @this?.ItemLocation;
                            return em_;
                        }

                        IEnumerable<IEnumerable<ResourceReference?>?>? ds_ = context.Operators.WhereSelect<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?, IEnumerable<ResourceReference?>?>(dp_, dq_, dr_);
                        IEnumerable<ResourceReference?>? dt_ = context.Operators.Flatten<ResourceReference?>(((IEnumerable<IEnumerable<ResourceReference>>)ds_)!);

                        bool? du_(ResourceReference? X) {
                            FhirString? en_ = X?.ReferenceElement;
                            string? eo_ = en_?.Value;
                            return (bool?)(eo_ is null);
                        }

                        IEnumerable<ResourceReference?>? dv_ = context.Operators.Where<ResourceReference?>(dt_, du_);
                        int? dw_ = context.Operators.Count<ResourceReference?>(dv_);
                        IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>? dx_ = GetIdentifiers?.IdentifierTuple;

                        IEnumerable<FhirString?>? dy_((CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)? X) {
                            IEnumerable<FhirString>? ep_ = X?.AllIdentifiers;
                            return ep_;
                        }

                        IEnumerable<IEnumerable<FhirString?>?>? dz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?, IEnumerable<FhirString?>?>(dx_, dy_);
                        IEnumerable<FhirString?>? ea_ = context.Operators.Flatten<FhirString?>(((IEnumerable<IEnumerable<FhirString>>)dz_)!);
                        FhirString? eb_(FhirString? X) => X;
                        IEnumerable<FhirString?>? ec_ = context.Operators.SelectDistinct<FhirString?, FhirString?>(ea_, eb_);
                        int? ed_ = context.Operators.Count<FhirString?>(ec_);
                        int? ee_ = context.Operators.Add(dw_, ed_);

                        IEnumerable<Identifier?>? ef_((CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)? X) {
                            IEnumerable<Identifier>? eq_ = X?.NullIdentifiers;
                            return eq_;
                        }

                        IEnumerable<IEnumerable<Identifier?>?>? eg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?, IEnumerable<Identifier?>?>(dx_, ef_);
                        IEnumerable<Identifier?>? eh_ = context.Operators.Flatten<Identifier?>(((IEnumerable<IEnumerable<Identifier>>)eg_)!);
                        int? ei_ = context.Operators.Count<Identifier?>(eh_);
                        int? ej_ = context.Operators.Add(ee_, ei_);
                        de_ = ej_;
                    }
                    else
                    {
                        de_ = 0;
                    }
                    (CqlTupleMetadata, int? IdentifierCount)? df_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, de_);
                    return df_;
                }

                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?>? bs_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString?>? AllIdentifiers, IEnumerable<Identifier?>? NullIdentifiers)?>? IdentifierTuple)?>?)bq_, br_);
                (CqlTupleMetadata, int? IdentifierCount)? bt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bs_);
                return bt_;
            }

            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?>? ay_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<Location?>? CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location?>? CorrespondingLocations)?>?)aw_, ax_);
            (CqlTupleMetadata, int? IdentifierCount)? az_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(ay_);
            return az_;
        }

        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?>? f_ = context.Operators.SelectDistinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?>? ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent?>? SingleItem, IEnumerable<ResourceReference?>? ItemLocation, IEnumerable<string?>? ItemLocationID)?>? ItemsLocationReferences)?>?)d_, e_);
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
