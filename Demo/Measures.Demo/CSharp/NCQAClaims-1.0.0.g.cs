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

[System.CodeDom.Compiler.GeneratedCode(".NET Code Generation", "3.0.0.0")]
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

    #region ValueSets

    [CqlValueSetDefinition("Inpatient Stay", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", valueSetVersion: null)]
    public CqlValueSet Inpatient_Stay(CqlContext _) => _Inpatient_Stay;
    private static readonly CqlValueSet _Inpatient_Stay = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", null);

    [CqlValueSetDefinition("Nonacute Inpatient Stay", valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient_Stay(CqlContext _) => _Nonacute_Inpatient_Stay;
    private static readonly CqlValueSet _Nonacute_Inpatient_Stay = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", null);

    #endregion ValueSets

    #region Expressions

    [CqlExpressionDefinition("Professional or Institutional Claims")]
    public IEnumerable<Claim> Professional_or_Institutional_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? lzzzzzzzk_(Claim MedicalClaim)
        {
            CodeableConcept lzzzzzzzm_ = MedicalClaim?.Type;
            CqlConcept lzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzm_);
            CqlCode[] lzzzzzzzo_ = lzzzzzzzn_?.codes;
            CqlCode lzzzzzzzp_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? lzzzzzzzq_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)lzzzzzzzo_, lzzzzzzzp_);
            CqlConcept lzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzm_);
            CqlCode[] lzzzzzzzt_ = lzzzzzzzs_?.codes;
            CqlCode lzzzzzzzu_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? lzzzzzzzv_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)lzzzzzzzt_, lzzzzzzzu_);
            bool? lzzzzzzzw_ = context.Operators.Or(lzzzzzzzq_, lzzzzzzzv_);

            return lzzzzzzzw_;
        };
        IEnumerable<Claim> lzzzzzzzl_ = context.Operators.Where<Claim>(claim, lzzzzzzzk_);

        return lzzzzzzzl_;
    }


    [CqlExpressionDefinition("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? lzzzzzzzx_(Claim PharmacyClaim)
        {
            CodeableConcept lzzzzzzzz_ = PharmacyClaim?.Type;
            CqlConcept mzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzz_);
            CqlCode[] mzzzzzzzb_ = mzzzzzzza_?.codes;
            CqlCode mzzzzzzzc_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? mzzzzzzzd_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)mzzzzzzzb_, mzzzzzzzc_);

            return mzzzzzzzd_;
        };
        IEnumerable<Claim> lzzzzzzzy_ = context.Operators.Where<Claim>(claim, lzzzzzzzx_);

        return lzzzzzzzy_;
    }


    [CqlExpressionDefinition("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? mzzzzzzze_(ClaimResponse MedicalResponse)
        {
            CodeableConcept mzzzzzzzg_ = MedicalResponse?.Type;
            CqlConcept mzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzg_);
            CqlCode[] mzzzzzzzi_ = mzzzzzzzh_?.codes;
            CqlCode mzzzzzzzj_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? mzzzzzzzk_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)mzzzzzzzi_, mzzzzzzzj_);
            CqlConcept mzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzg_);
            CqlCode[] mzzzzzzzn_ = mzzzzzzzm_?.codes;
            CqlCode mzzzzzzzo_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? mzzzzzzzp_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)mzzzzzzzn_, mzzzzzzzo_);
            bool? mzzzzzzzq_ = context.Operators.Or(mzzzzzzzk_, mzzzzzzzp_);

            return mzzzzzzzq_;
        };
        IEnumerable<ClaimResponse> mzzzzzzzf_ = context.Operators.Where<ClaimResponse>(claimResponse, mzzzzzzze_);

        return mzzzzzzzf_;
    }


    [CqlExpressionDefinition("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? mzzzzzzzr_(ClaimResponse PharmacyResponse)
        {
            CodeableConcept mzzzzzzzt_ = PharmacyResponse?.Type;
            CqlConcept mzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzt_);
            CqlCode[] mzzzzzzzv_ = mzzzzzzzu_?.codes;
            CqlCode mzzzzzzzw_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? mzzzzzzzx_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)mzzzzzzzv_, mzzzzzzzw_);

            return mzzzzzzzx_;
        };
        IEnumerable<ClaimResponse> mzzzzzzzs_ = context.Operators.Where<ClaimResponse>(claimResponse, mzzzzzzzr_);

        return mzzzzzzzs_;
    }


    [CqlExpressionDefinition("Medical Claims With Procedure and POS")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> mzzzzzzzy_ = this.Professional_or_Institutional_Claims(context, claim);
        string mzzzzzzzz_(CqlCode p)
        {
            string nzzzzzzzl_ = p?.code;

            return nzzzzzzzl_;
        };
        IEnumerable<string> nzzzzzzza_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, mzzzzzzzz_);
        IEnumerable<string> nzzzzzzzb_ = context.Operators.Distinct<string>(nzzzzzzza_);
        string nzzzzzzzc_(CqlCode pos)
        {
            string nzzzzzzzm_ = pos?.code;

            return nzzzzzzzm_;
        };
        IEnumerable<string> nzzzzzzzd_ = context.Operators.Select<CqlCode, string>(posCodes, nzzzzzzzc_);
        IEnumerable<string> nzzzzzzze_ = context.Operators.Distinct<string>(nzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? nzzzzzzzf_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, mzzzzzzzy_, nzzzzzzzb_, nzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] nzzzzzzzg_ = [
            nzzzzzzzf_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzh_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode)
        {
            IEnumerable<Claim> nzzzzzzzn_ = ClaimWithPosCode?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzo_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> nzzzzzzzt_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> ozzzzzzza_ = ClaimofInterest?.Item;
                        bool? ozzzzzzzb_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept ozzzzzzzd_ = ItemOnLine?.ProductOrService;
                            CqlConcept ozzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ozzzzzzzd_);
                            CqlCode[] ozzzzzzzf_ = ozzzzzzze_?.codes;
                            bool? ozzzzzzzg_(CqlCode LineCode)
                            {
                                string ozzzzzzzq_ = LineCode?.code;
                                IEnumerable<string> ozzzzzzzr_ = ClaimWithPosCode?.ProceduresAsStrings;
                                bool? ozzzzzzzs_ = context.Operators.In<string>(ozzzzzzzq_, ozzzzzzzr_);

                                return ozzzzzzzs_;
                            };
                            IEnumerable<CqlCode> ozzzzzzzh_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ozzzzzzzf_, ozzzzzzzg_);
                            bool? ozzzzzzzi_ = context.Operators.Exists<CqlCode>(ozzzzzzzh_);
                            DataType ozzzzzzzj_ = ItemOnLine?.Location;
                            CqlConcept ozzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ozzzzzzzj_ as CodeableConcept);
                            CqlCode[] ozzzzzzzl_ = ozzzzzzzk_?.codes;
                            bool? ozzzzzzzm_(CqlCode PosCode)
                            {
                                string ozzzzzzzt_ = PosCode?.code;
                                IEnumerable<string> ozzzzzzzu_ = ClaimWithPosCode?.POSAsString;
                                bool? ozzzzzzzv_ = context.Operators.In<string>(ozzzzzzzt_, ozzzzzzzu_);

                                return ozzzzzzzv_;
                            };
                            IEnumerable<CqlCode> ozzzzzzzn_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)ozzzzzzzl_, ozzzzzzzm_);
                            bool? ozzzzzzzo_ = context.Operators.Exists<CqlCode>(ozzzzzzzn_);
                            bool? ozzzzzzzp_ = context.Operators.And(ozzzzzzzi_, ozzzzzzzo_);

                            return ozzzzzzzp_;
                        };
                        IEnumerable<Claim.ItemComponent> ozzzzzzzc_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ozzzzzzza_, ozzzzzzzb_);

                        return ozzzzzzzc_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? nzzzzzzzu_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, nzzzzzzzt_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] nzzzzzzzv_ = [
                    nzzzzzzzu_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzw_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzw_()
                    {
                        bool ozzzzzzzx_()
                        {
                            IEnumerable<Claim.ItemComponent> ozzzzzzzy_ = LineItemDefinition?.LineItems;
                            bool? ozzzzzzzz_ = context.Operators.Exists<Claim.ItemComponent>(ozzzzzzzy_);

                            return ozzzzzzzz_ ?? false;
                        };
                        if (ozzzzzzzx_())
                        {
                            Claim pzzzzzzza_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> pzzzzzzzb_ = LineItemDefinition?.LineItems;
                            bool? pzzzzzzzc_(Claim.ItemComponent @this)
                            {
                                DataType pzzzzzzzk_ = @this?.Serviced;
                                bool? pzzzzzzzl_ = context.Operators.Not((bool?)(pzzzzzzzk_ is null));

                                return pzzzzzzzl_;
                            };
                            IEnumerable<Claim.ItemComponent> pzzzzzzzd_ = context.Operators.Where<Claim.ItemComponent>(pzzzzzzzb_, pzzzzzzzc_);
                            object pzzzzzzze_(Claim.ItemComponent @this)
                            {
                                DataType pzzzzzzzm_ = @this?.Serviced;

                                return pzzzzzzzm_;
                            };
                            IEnumerable<object> pzzzzzzzf_ = context.Operators.Select<Claim.ItemComponent, object>(pzzzzzzzd_, pzzzzzzze_);
                            CqlInterval<CqlDateTime> pzzzzzzzg_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> pzzzzzzzn_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return pzzzzzzzn_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzh_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(pzzzzzzzf_, pzzzzzzzg_);
                            IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzh_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzj_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, pzzzzzzza_, pzzzzzzzi_);

                            return pzzzzzzzj_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return ozzzzzzzw_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)nzzzzzzzv_, nzzzzzzzw_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzx_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzy_);

                return nzzzzzzzz_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzp_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzn_, nzzzzzzzo_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzp_);
            bool? nzzzzzzzr_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? pzzzzzzzo_ = context.Operators.Not((bool?)(FinalList is null));

                return pzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzq_, nzzzzzzzr_);

            return nzzzzzzzs_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> nzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)nzzzzzzzg_, nzzzzzzzh_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> nzzzzzzzj_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(nzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzk_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(nzzzzzzzj_);

        return nzzzzzzzk_;
    }


    [CqlExpressionDefinition("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> pzzzzzzzp_ = this.Professional_or_Institutional_Claims(context, claim);
        string pzzzzzzzq_(CqlCode p)
        {
            string pzzzzzzzz_ = p?.code;

            return pzzzzzzzz_;
        };
        IEnumerable<string> pzzzzzzzr_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, pzzzzzzzq_);
        IEnumerable<string> pzzzzzzzs_ = context.Operators.Distinct<string>(pzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? pzzzzzzzt_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, pzzzzzzzp_, pzzzzzzzs_, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] pzzzzzzzu_ = [
            pzzzzzzzt_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzv_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithProcedure)
        {
            IEnumerable<Claim> qzzzzzzza_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzb_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> qzzzzzzzg_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> qzzzzzzzn_ = ClaimofInterest?.Item;
                        bool? qzzzzzzzo_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept qzzzzzzzq_ = ItemOnLine?.ProductOrService;
                            CqlConcept qzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, qzzzzzzzq_);
                            CqlCode[] qzzzzzzzs_ = qzzzzzzzr_?.codes;
                            bool? qzzzzzzzt_(CqlCode LineCode)
                            {
                                string rzzzzzzzm_ = LineCode?.code;
                                IEnumerable<string> rzzzzzzzn_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? rzzzzzzzo_ = context.Operators.In<string>(rzzzzzzzm_, rzzzzzzzn_);

                                return rzzzzzzzo_;
                            };
                            IEnumerable<CqlCode> qzzzzzzzu_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)qzzzzzzzs_, qzzzzzzzt_);
                            bool? qzzzzzzzv_ = context.Operators.Exists<CqlCode>(qzzzzzzzu_);
                            List<Claim.ProcedureComponent> qzzzzzzzw_ = ClaimofInterest?.Procedure;
                            bool? qzzzzzzzx_(Claim.ProcedureComponent @this)
                            {
                                DataType rzzzzzzzp_ = @this?.Procedure;
                                bool? rzzzzzzzq_ = context.Operators.Not((bool?)(rzzzzzzzp_ is null));

                                return rzzzzzzzq_;
                            };
                            IEnumerable<Claim.ProcedureComponent> qzzzzzzzy_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)qzzzzzzzw_, qzzzzzzzx_);
                            object qzzzzzzzz_(Claim.ProcedureComponent @this)
                            {
                                DataType rzzzzzzzr_ = @this?.Procedure;

                                return rzzzzzzzr_;
                            };
                            IEnumerable<object> rzzzzzzza_ = context.Operators.Select<Claim.ProcedureComponent, object>(qzzzzzzzy_, qzzzzzzzz_);
                            bool? rzzzzzzzb_(object @this)
                            {
                                object rzzzzzzzs_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? rzzzzzzzt_ = context.Operators.Not((bool?)(rzzzzzzzs_ is null));

                                return rzzzzzzzt_;
                            };
                            IEnumerable<object> rzzzzzzzc_ = context.Operators.Where<object>(rzzzzzzza_, rzzzzzzzb_);
                            object rzzzzzzzd_(object @this)
                            {
                                object rzzzzzzzu_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return rzzzzzzzu_;
                            };
                            IEnumerable<object> rzzzzzzze_ = context.Operators.Select<object, object>(rzzzzzzzc_, rzzzzzzzd_);
                            IEnumerable<object> rzzzzzzzf_ = context.Operators.FlattenLateBoundList(rzzzzzzze_);
                            Coding rzzzzzzzg_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> rzzzzzzzh_ = context.Operators.Select<object, Coding>(rzzzzzzzf_, rzzzzzzzg_);
                            bool? rzzzzzzzi_(Coding HeaderCode)
                            {
                                Code rzzzzzzzv_ = HeaderCode?.CodeElement;
                                string rzzzzzzzw_ = rzzzzzzzv_?.Value;
                                IEnumerable<string> rzzzzzzzx_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? rzzzzzzzy_ = context.Operators.In<string>(rzzzzzzzw_, rzzzzzzzx_);

                                return rzzzzzzzy_;
                            };
                            IEnumerable<Coding> rzzzzzzzj_ = context.Operators.Where<Coding>(rzzzzzzzh_, rzzzzzzzi_);
                            bool? rzzzzzzzk_ = context.Operators.Exists<Coding>(rzzzzzzzj_);
                            bool? rzzzzzzzl_ = context.Operators.Or(qzzzzzzzv_, rzzzzzzzk_);

                            return rzzzzzzzl_;
                        };
                        IEnumerable<Claim.ItemComponent> qzzzzzzzp_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)qzzzzzzzn_, qzzzzzzzo_);

                        return qzzzzzzzp_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? qzzzzzzzh_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, qzzzzzzzg_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] qzzzzzzzi_ = [
                    qzzzzzzzh_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzj_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzz_()
                    {
                        bool szzzzzzza_()
                        {
                            IEnumerable<Claim.ItemComponent> szzzzzzzb_ = LineItemDefinition?.LineItems;
                            bool? szzzzzzzc_ = context.Operators.Exists<Claim.ItemComponent>(szzzzzzzb_);

                            return szzzzzzzc_ ?? false;
                        };
                        if (szzzzzzza_())
                        {
                            Claim szzzzzzzd_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> szzzzzzze_ = LineItemDefinition?.LineItems;
                            bool? szzzzzzzf_(Claim.ItemComponent @this)
                            {
                                DataType szzzzzzzn_ = @this?.Serviced;
                                bool? szzzzzzzo_ = context.Operators.Not((bool?)(szzzzzzzn_ is null));

                                return szzzzzzzo_;
                            };
                            IEnumerable<Claim.ItemComponent> szzzzzzzg_ = context.Operators.Where<Claim.ItemComponent>(szzzzzzze_, szzzzzzzf_);
                            object szzzzzzzh_(Claim.ItemComponent @this)
                            {
                                DataType szzzzzzzp_ = @this?.Serviced;

                                return szzzzzzzp_;
                            };
                            IEnumerable<object> szzzzzzzi_ = context.Operators.Select<Claim.ItemComponent, object>(szzzzzzzg_, szzzzzzzh_);
                            CqlInterval<CqlDateTime> szzzzzzzj_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> szzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return szzzzzzzq_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzk_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(szzzzzzzi_, szzzzzzzj_);
                            IEnumerable<CqlInterval<CqlDateTime>> szzzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(szzzzzzzk_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzm_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, szzzzzzzd_, szzzzzzzl_);

                            return szzzzzzzm_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return rzzzzzzzz_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)qzzzzzzzi_, qzzzzzzzj_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzk_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzl_);

                return qzzzzzzzm_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzc_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzza_, qzzzzzzzb_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzc_);
            bool? qzzzzzzze_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? szzzzzzzr_ = context.Operators.Not((bool?)(FinalList is null));

                return szzzzzzzr_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzd_, qzzzzzzze_);

            return qzzzzzzzf_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> pzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)pzzzzzzzu_, pzzzzzzzv_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> pzzzzzzzx_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(pzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzy_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(pzzzzzzzx_);

        return pzzzzzzzy_;
    }


    [CqlExpressionDefinition("Medical Claims With Diagnosis")]
    public (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> szzzzzzzs_ = this.Professional_or_Institutional_Claims(context, claim);
        string szzzzzzzt_(CqlCode d)
        {
            string tzzzzzzzc_ = d?.code;

            return tzzzzzzzc_;
        };
        IEnumerable<string> szzzzzzzu_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, szzzzzzzt_);
        IEnumerable<string> szzzzzzzv_ = context.Operators.Distinct<string>(szzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? szzzzzzzw_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, szzzzzzzs_, szzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] szzzzzzzx_ = [
            szzzzzzzw_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzy_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> tzzzzzzzd_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> tzzzzzzzk_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? tzzzzzzzl_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> tzzzzzzzn_ = DiagnosisLine?.Diagnosis;
                        bool? tzzzzzzzo_(Claim.DiagnosisComponent @this)
                        {
                            DataType uzzzzzzzc_ = @this?.Diagnosis;
                            bool? uzzzzzzzd_ = context.Operators.Not((bool?)(uzzzzzzzc_ is null));

                            return uzzzzzzzd_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> tzzzzzzzp_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)tzzzzzzzn_, tzzzzzzzo_);
                        object tzzzzzzzq_(Claim.DiagnosisComponent @this)
                        {
                            DataType uzzzzzzze_ = @this?.Diagnosis;

                            return uzzzzzzze_;
                        };
                        IEnumerable<object> tzzzzzzzr_ = context.Operators.Select<Claim.DiagnosisComponent, object>(tzzzzzzzp_, tzzzzzzzq_);
                        bool? tzzzzzzzs_(object @this)
                        {
                            object uzzzzzzzf_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? uzzzzzzzg_ = context.Operators.Not((bool?)(uzzzzzzzf_ is null));

                            return uzzzzzzzg_;
                        };
                        IEnumerable<object> tzzzzzzzt_ = context.Operators.Where<object>(tzzzzzzzr_, tzzzzzzzs_);
                        object tzzzzzzzu_(object @this)
                        {
                            object uzzzzzzzh_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return uzzzzzzzh_;
                        };
                        IEnumerable<object> tzzzzzzzv_ = context.Operators.Select<object, object>(tzzzzzzzt_, tzzzzzzzu_);
                        IEnumerable<object> tzzzzzzzw_ = context.Operators.FlattenLateBoundList(tzzzzzzzv_);
                        Coding tzzzzzzzx_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> tzzzzzzzy_ = context.Operators.Select<object, Coding>(tzzzzzzzw_, tzzzzzzzx_);
                        bool? tzzzzzzzz_(Coding HeaderCode)
                        {
                            Code uzzzzzzzi_ = HeaderCode?.CodeElement;
                            string uzzzzzzzj_ = uzzzzzzzi_?.Value;
                            IEnumerable<string> uzzzzzzzk_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? uzzzzzzzl_ = context.Operators.In<string>(uzzzzzzzj_, uzzzzzzzk_);

                            return uzzzzzzzl_;
                        };
                        IEnumerable<Coding> uzzzzzzza_ = context.Operators.Where<Coding>(tzzzzzzzy_, tzzzzzzzz_);
                        bool? uzzzzzzzb_ = context.Operators.Exists<Coding>(uzzzzzzza_);

                        return uzzzzzzzb_;
                    };
                    IEnumerable<Claim> tzzzzzzzm_ = context.Operators.Where<Claim>(tzzzzzzzk_, tzzzzzzzl_);

                    return tzzzzzzzm_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? tzzzzzzze_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, tzzzzzzzd_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] tzzzzzzzf_ = [
                tzzzzzzze_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzg_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? HeaderDefinition)
            {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzm_()
                {
                    bool uzzzzzzzr_()
                    {
                        IEnumerable<Claim> uzzzzzzzs_ = HeaderDefinition?.DiagnosisItems;
                        bool? uzzzzzzzt_ = context.Operators.Exists<Claim>(uzzzzzzzs_);

                        return uzzzzzzzt_ ?? false;
                    };
                    if (uzzzzzzzr_())
                    {
                        IEnumerable<Claim> uzzzzzzzu_ = HeaderDefinition?.DiagnosisItems;
                        bool? uzzzzzzzw_(Claim @this)
                        {
                            List<Claim.ItemComponent> vzzzzzzzf_ = @this?.Item;
                            bool? vzzzzzzzg_ = context.Operators.Not((bool?)(vzzzzzzzf_ is null));

                            return vzzzzzzzg_;
                        };
                        IEnumerable<Claim> uzzzzzzzx_ = context.Operators.Where<Claim>(uzzzzzzzu_, uzzzzzzzw_);
                        List<Claim.ItemComponent> uzzzzzzzy_(Claim @this)
                        {
                            List<Claim.ItemComponent> vzzzzzzzh_ = @this?.Item;

                            return vzzzzzzzh_;
                        };
                        IEnumerable<List<Claim.ItemComponent>> uzzzzzzzz_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(uzzzzzzzx_, uzzzzzzzy_);
                        IEnumerable<Claim.ItemComponent> vzzzzzzza_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)uzzzzzzzz_);
                        CqlInterval<CqlDateTime> vzzzzzzzb_(Claim.ItemComponent NormalDate)
                        {
                            DataType vzzzzzzzi_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> vzzzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, vzzzzzzzi_);

                            return vzzzzzzzj_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzc_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(vzzzzzzza_, vzzzzzzzb_);
                        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzzzzzzc_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzze_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, uzzzzzzzu_, vzzzzzzzd_);

                        return vzzzzzzze_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] uzzzzzzzn_ = [
                    uzzzzzzzm_(),
                ];
                bool? uzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? vzzzzzzzk_ = context.Operators.Not((bool?)(FinalList is null));

                    return vzzzzzzzk_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)uzzzzzzzn_, uzzzzzzzo_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(uzzzzzzzp_);

                return uzzzzzzzq_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> tzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)tzzzzzzzf_, tzzzzzzzg_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> tzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(tzzzzzzzh_);
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(tzzzzzzzi_);

            return tzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)szzzzzzzx_, szzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> tzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzz_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(tzzzzzzza_);

        return tzzzzzzzb_;
    }


    [CqlExpressionDefinition("Pharmacy Claim With Medication")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        IEnumerable<Claim> vzzzzzzzl_ = this.Pharmacy_Claims(context, claim);
        string vzzzzzzzm_(CqlCode p)
        {
            string vzzzzzzzu_ = p?.code;

            return vzzzzzzzu_;
        };
        IEnumerable<string> vzzzzzzzn_ = context.Operators.Select<CqlCode, string>(MedicationCodes, vzzzzzzzm_);
        IEnumerable<string> vzzzzzzzo_ = context.Operators.Distinct<string>(vzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? vzzzzzzzp_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, vzzzzzzzl_, vzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] vzzzzzzzq_ = [
            vzzzzzzzp_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> vzzzzzzzr_((CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication)
        {
            IEnumerable<Claim> vzzzzzzzv_ = ClaimWithMedication?.PharmacyClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? vzzzzzzzw_(Claim Pharmacy)
            {
                List<Claim.ItemComponent> wzzzzzzza_ = Pharmacy?.Item;
                bool? wzzzzzzzb_(Claim.ItemComponent ItemOnLine)
                {
                    CodeableConcept wzzzzzzzi_ = ItemOnLine?.ProductOrService;
                    CqlConcept wzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, wzzzzzzzi_);
                    CqlCode[] wzzzzzzzk_ = wzzzzzzzj_?.codes;
                    bool? wzzzzzzzl_(CqlCode LineCode)
                    {
                        string wzzzzzzzo_ = LineCode?.code;
                        IEnumerable<string> wzzzzzzzp_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? wzzzzzzzq_ = context.Operators.In<string>(wzzzzzzzo_, wzzzzzzzp_);

                        return wzzzzzzzq_;
                    };
                    IEnumerable<CqlCode> wzzzzzzzm_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)wzzzzzzzk_, wzzzzzzzl_);
                    bool? wzzzzzzzn_ = context.Operators.Exists<CqlCode>(wzzzzzzzm_);

                    return wzzzzzzzn_;
                };
                IEnumerable<Claim.ItemComponent> wzzzzzzzc_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)wzzzzzzza_, wzzzzzzzb_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? wzzzzzzzd_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, wzzzzzzzc_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] wzzzzzzze_ = [
                    wzzzzzzzd_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? wzzzzzzzf_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    Claim wzzzzzzzr_ = LineItemDefinition?.Claim;
                    Claim[] wzzzzzzzs_ = [
                        wzzzzzzzr_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? wzzzzzzzt_(Claim ClaimLines)
                    {
                        List<Claim.ItemComponent> wzzzzzzzw_ = ClaimLines?.Item;
                        bool? wzzzzzzzx_(Claim.ItemComponent i)
                        {
                            CodeableConcept xzzzzzzzg_ = i?.ProductOrService;
                            CqlConcept xzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzzzzzg_);
                            CqlCode[] xzzzzzzzi_ = xzzzzzzzh_?.codes;
                            bool? xzzzzzzzj_(CqlCode LineCode)
                            {
                                string xzzzzzzzm_ = LineCode?.code;
                                IEnumerable<string> xzzzzzzzn_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? xzzzzzzzo_ = context.Operators.In<string>(xzzzzzzzm_, xzzzzzzzn_);

                                return xzzzzzzzo_;
                            };
                            IEnumerable<CqlCode> xzzzzzzzk_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)xzzzzzzzi_, xzzzzzzzj_);
                            bool? xzzzzzzzl_ = context.Operators.Exists<CqlCode>(xzzzzzzzk_);

                            return xzzzzzzzl_;
                        };
                        IEnumerable<Claim.ItemComponent> wzzzzzzzy_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)wzzzzzzzw_, wzzzzzzzx_);
                        (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? wzzzzzzzz_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDateTime> xzzzzzzzp_()
                            {
                                bool xzzzzzzzr_()
                                {
                                    Quantity xzzzzzzzs_ = i?.Quantity;
                                    bool? xzzzzzzzt_ = context.Operators.Not((bool?)(xzzzzzzzs_ is null));

                                    return xzzzzzzzt_ ?? false;
                                };
                                if (xzzzzzzzr_())
                                {
                                    CqlInterval<CqlDateTime> xzzzzzzzu_()
                                    {
                                        bool xzzzzzzzv_()
                                        {
                                            DataType xzzzzzzzw_ = i?.Serviced;
                                            bool xzzzzzzzx_ = xzzzzzzzw_ is Period;

                                            return xzzzzzzzx_;
                                        };
                                        if (xzzzzzzzv_())
                                        {
                                            DataType xzzzzzzzy_ = i?.Serviced;
                                            CqlInterval<CqlDateTime> xzzzzzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzy_);
                                            CqlDateTime yzzzzzzza_ = context.Operators.Start(xzzzzzzzz_);
                                            CqlInterval<CqlDateTime> yzzzzzzzc_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzy_);
                                            CqlDateTime yzzzzzzzd_ = context.Operators.Start(yzzzzzzzc_);
                                            Quantity yzzzzzzze_ = i?.Quantity;
                                            FhirDecimal yzzzzzzzf_ = yzzzzzzze_?.ValueElement;
                                            decimal? yzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, yzzzzzzzf_);
                                            CqlDateTime yzzzzzzzh_ = context.Operators.Add(yzzzzzzzd_, new CqlQuantity(yzzzzzzzg_, "day"));
                                            CqlQuantity yzzzzzzzi_ = context.Operators.Quantity(1m, "day");
                                            CqlDateTime yzzzzzzzj_ = context.Operators.Subtract(yzzzzzzzh_, yzzzzzzzi_);
                                            CqlInterval<CqlDateTime> yzzzzzzzk_ = context.Operators.Interval(yzzzzzzza_, yzzzzzzzj_, true, true);

                                            return yzzzzzzzk_;
                                        }
                                        else
                                        {
                                            DataType yzzzzzzzl_ = i?.Serviced;
                                            CqlDate yzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzzzzl_ as Date);
                                            CqlDate yzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzzzzl_ as Date);
                                            Quantity yzzzzzzzp_ = i?.Quantity;
                                            FhirDecimal yzzzzzzzq_ = yzzzzzzzp_?.ValueElement;
                                            decimal? yzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, yzzzzzzzq_);
                                            CqlDate yzzzzzzzs_ = context.Operators.Add(yzzzzzzzo_, new CqlQuantity(yzzzzzzzr_, "day"));
                                            CqlQuantity yzzzzzzzt_ = context.Operators.Quantity(1m, "day");
                                            CqlDate yzzzzzzzu_ = context.Operators.Subtract(yzzzzzzzs_, yzzzzzzzt_);
                                            CqlInterval<CqlDate> yzzzzzzzv_ = context.Operators.Interval(yzzzzzzzm_, yzzzzzzzu_, true, true);
                                            CqlDate yzzzzzzzw_ = yzzzzzzzv_?.low;
                                            CqlDateTime yzzzzzzzx_ = context.Operators.ConvertDateToDateTime(yzzzzzzzw_);
                                            CqlDate yzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzzzzl_ as Date);
                                            CqlDate zzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzzzzl_ as Date);
                                            FhirDecimal zzzzzzzzd_ = yzzzzzzzp_?.ValueElement;
                                            decimal? zzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, zzzzzzzzd_);
                                            CqlDate zzzzzzzzf_ = context.Operators.Add(zzzzzzzzb_, new CqlQuantity(zzzzzzzze_, "day"));
                                            CqlDate zzzzzzzzh_ = context.Operators.Subtract(zzzzzzzzf_, yzzzzzzzt_);
                                            CqlInterval<CqlDate> zzzzzzzzi_ = context.Operators.Interval(yzzzzzzzz_, zzzzzzzzh_, true, true);
                                            CqlDate zzzzzzzzj_ = zzzzzzzzi_?.high;
                                            CqlDateTime zzzzzzzzk_ = context.Operators.ConvertDateToDateTime(zzzzzzzzj_);
                                            CqlDate zzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzzzzl_ as Date);
                                            CqlDate zzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzzzzl_ as Date);
                                            FhirDecimal zzzzzzzzq_ = yzzzzzzzp_?.ValueElement;
                                            decimal? zzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, zzzzzzzzq_);
                                            CqlDate zzzzzzzzs_ = context.Operators.Add(zzzzzzzzo_, new CqlQuantity(zzzzzzzzr_, "day"));
                                            CqlDate zzzzzzzzu_ = context.Operators.Subtract(zzzzzzzzs_, yzzzzzzzt_);
                                            CqlInterval<CqlDate> zzzzzzzzv_ = context.Operators.Interval(zzzzzzzzm_, zzzzzzzzu_, true, true);
                                            bool? zzzzzzzzw_ = zzzzzzzzv_?.lowClosed;
                                            CqlDate zzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzzzzl_ as Date);
                                            CqlDate azzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzzzzl_ as Date);
                                            FhirDecimal azzzzzzzzc_ = yzzzzzzzp_?.ValueElement;
                                            decimal? azzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, azzzzzzzzc_);
                                            CqlDate azzzzzzzze_ = context.Operators.Add(azzzzzzzza_, new CqlQuantity(azzzzzzzzd_, "day"));
                                            CqlDate azzzzzzzzg_ = context.Operators.Subtract(azzzzzzzze_, yzzzzzzzt_);
                                            CqlInterval<CqlDate> azzzzzzzzh_ = context.Operators.Interval(zzzzzzzzy_, azzzzzzzzg_, true, true);
                                            bool? azzzzzzzzi_ = azzzzzzzzh_?.highClosed;
                                            CqlInterval<CqlDateTime> azzzzzzzzj_ = context.Operators.Interval(yzzzzzzzx_, zzzzzzzzk_, zzzzzzzzw_, azzzzzzzzi_);

                                            return azzzzzzzzj_;
                                        }
                                    };

                                    return xzzzzzzzu_();
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDateTime>;
                                }
                            };
                            (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? xzzzzzzzq_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, xzzzzzzzp_());

                            return xzzzzzzzq_;
                        };
                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> xzzzzzzza_ = context.Operators.Select<Claim.ItemComponent, (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>(wzzzzzzzy_, wzzzzzzzz_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? xzzzzzzzb_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, xzzzzzzza_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?[] xzzzzzzzc_ = [
                            xzzzzzzzb_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? xzzzzzzzd_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? ItemCalculation)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? azzzzzzzzk_()
                            {
                                bool azzzzzzzzl_()
                                {
                                    IEnumerable<Claim.ItemComponent> azzzzzzzzm_ = LineItemDefinition?.LineItems;
                                    bool? azzzzzzzzn_ = context.Operators.Exists<Claim.ItemComponent>(azzzzzzzzm_);

                                    return azzzzzzzzn_ ?? false;
                                };
                                if (azzzzzzzzl_())
                                {
                                    Claim azzzzzzzzo_ = LineItemDefinition?.Claim;
                                    IEnumerable<Claim.ItemComponent> azzzzzzzzp_ = LineItemDefinition?.LineItems;
                                    bool? azzzzzzzzr_(Claim.ItemComponent @this)
                                    {
                                        DataType bzzzzzzzzc_ = @this?.Serviced;
                                        bool? bzzzzzzzzd_ = context.Operators.Not((bool?)(bzzzzzzzzc_ is null));

                                        return bzzzzzzzzd_;
                                    };
                                    IEnumerable<Claim.ItemComponent> azzzzzzzzs_ = context.Operators.Where<Claim.ItemComponent>(azzzzzzzzp_, azzzzzzzzr_);
                                    object azzzzzzzzt_(Claim.ItemComponent @this)
                                    {
                                        DataType bzzzzzzzze_ = @this?.Serviced;

                                        return bzzzzzzzze_;
                                    };
                                    IEnumerable<object> azzzzzzzzu_ = context.Operators.Select<Claim.ItemComponent, object>(azzzzzzzzs_, azzzzzzzzt_);
                                    CqlInterval<CqlDateTime> azzzzzzzzv_(object NormalDate)
                                    {
                                        CqlInterval<CqlDateTime> bzzzzzzzzf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                        return bzzzzzzzzf_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzw_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(azzzzzzzzu_, azzzzzzzzv_);
                                    IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzx_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(azzzzzzzzw_);
                                    IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> azzzzzzzzy_ = ItemCalculation?.CoveredDays;
                                    CqlInterval<CqlDateTime> azzzzzzzzz_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d)
                                    {
                                        CqlInterval<CqlDateTime> bzzzzzzzzg_ = d?.DaysSupplyInterval;

                                        return bzzzzzzzzg_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(azzzzzzzzy_, azzzzzzzzz_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? bzzzzzzzzb_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, azzzzzzzzo_, azzzzzzzzp_, azzzzzzzzx_, bzzzzzzzza_);

                                    return bzzzzzzzzb_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
                                }
                            };

                            return azzzzzzzzk_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> xzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?>)xzzzzzzzc_, xzzzzzzzd_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? xzzzzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(xzzzzzzze_);

                        return xzzzzzzzf_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> wzzzzzzzu_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)wzzzzzzzs_, wzzzzzzzt_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? wzzzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(wzzzzzzzu_);

                    return wzzzzzzzv_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> wzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)wzzzzzzze_, wzzzzzzzf_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? wzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(wzzzzzzzg_);

                return wzzzzzzzh_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> vzzzzzzzx_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(vzzzzzzzv_, vzzzzzzzw_);
            bool? vzzzzzzzy_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList)
            {
                bool? bzzzzzzzzh_ = context.Operators.Not((bool?)(FinalList is null));

                return bzzzzzzzzh_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> vzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(vzzzzzzzx_, vzzzzzzzy_);

            return vzzzzzzzz_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> vzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)vzzzzzzzq_, vzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> vzzzzzzzt_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(vzzzzzzzs_);

        return vzzzzzzzt_;
    }


    [CqlExpressionDefinition("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> bzzzzzzzzi_ = this.Professional_or_Institutional_Claims(context, claim);
        string bzzzzzzzzj_(CqlCode d)
        {
            string bzzzzzzzzv_ = d?.code;

            return bzzzzzzzzv_;
        };
        IEnumerable<string> bzzzzzzzzk_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, bzzzzzzzzj_);
        IEnumerable<string> bzzzzzzzzl_ = context.Operators.Distinct<string>(bzzzzzzzzk_);
        string bzzzzzzzzm_(CqlCode p)
        {
            string bzzzzzzzzw_ = p?.code;

            return bzzzzzzzzw_;
        };
        IEnumerable<string> bzzzzzzzzn_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, bzzzzzzzzm_);
        IEnumerable<string> bzzzzzzzzo_ = context.Operators.Distinct<string>(bzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? bzzzzzzzzp_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, bzzzzzzzzi_, bzzzzzzzzl_, bzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] bzzzzzzzzq_ = [
            bzzzzzzzzp_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzr_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> bzzzzzzzzx_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> czzzzzzzze_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? czzzzzzzzf_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> czzzzzzzzh_ = DiagnosisLine?.Diagnosis;
                        bool? czzzzzzzzi_(Claim.DiagnosisComponent @this)
                        {
                            DataType czzzzzzzzw_ = @this?.Diagnosis;
                            bool? czzzzzzzzx_ = context.Operators.Not((bool?)(czzzzzzzzw_ is null));

                            return czzzzzzzzx_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> czzzzzzzzj_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)czzzzzzzzh_, czzzzzzzzi_);
                        object czzzzzzzzk_(Claim.DiagnosisComponent @this)
                        {
                            DataType czzzzzzzzy_ = @this?.Diagnosis;

                            return czzzzzzzzy_;
                        };
                        IEnumerable<object> czzzzzzzzl_ = context.Operators.Select<Claim.DiagnosisComponent, object>(czzzzzzzzj_, czzzzzzzzk_);
                        bool? czzzzzzzzm_(object @this)
                        {
                            object czzzzzzzzz_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? dzzzzzzzza_ = context.Operators.Not((bool?)(czzzzzzzzz_ is null));

                            return dzzzzzzzza_;
                        };
                        IEnumerable<object> czzzzzzzzn_ = context.Operators.Where<object>(czzzzzzzzl_, czzzzzzzzm_);
                        object czzzzzzzzo_(object @this)
                        {
                            object dzzzzzzzzb_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return dzzzzzzzzb_;
                        };
                        IEnumerable<object> czzzzzzzzp_ = context.Operators.Select<object, object>(czzzzzzzzn_, czzzzzzzzo_);
                        IEnumerable<object> czzzzzzzzq_ = context.Operators.FlattenLateBoundList(czzzzzzzzp_);
                        Coding czzzzzzzzr_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> czzzzzzzzs_ = context.Operators.Select<object, Coding>(czzzzzzzzq_, czzzzzzzzr_);
                        bool? czzzzzzzzt_(Coding HeaderCode)
                        {
                            Code dzzzzzzzzc_ = HeaderCode?.CodeElement;
                            string dzzzzzzzzd_ = dzzzzzzzzc_?.Value;
                            IEnumerable<string> dzzzzzzzze_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? dzzzzzzzzf_ = context.Operators.In<string>(dzzzzzzzzd_, dzzzzzzzze_);

                            return dzzzzzzzzf_;
                        };
                        IEnumerable<Coding> czzzzzzzzu_ = context.Operators.Where<Coding>(czzzzzzzzs_, czzzzzzzzt_);
                        bool? czzzzzzzzv_ = context.Operators.Exists<Coding>(czzzzzzzzu_);

                        return czzzzzzzzv_;
                    };
                    IEnumerable<Claim> czzzzzzzzg_ = context.Operators.Where<Claim>(czzzzzzzze_, czzzzzzzzf_);

                    return czzzzzzzzg_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? bzzzzzzzzy_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, bzzzzzzzzx_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] bzzzzzzzzz_ = [
                bzzzzzzzzy_,
            ];
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzza_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ClaimWithProcedure)
            {
                IEnumerable<Claim> dzzzzzzzzg_ = ClaimWithProcedure?.DiagnosisItems;
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzh_(Claim ClaimofInterest)
                {
                    Claim dzzzzzzzzm_()
                    {
                        if (ClaimofInterest is null)
                        {
                            return default;
                        }
                        else
                        {
                            Claim[] dzzzzzzzzt_ = [
                                ClaimofInterest,
                            ];
                            bool? dzzzzzzzzu_(Claim ItemOnLine)
                            {
                                List<Claim.ProcedureComponent> dzzzzzzzzx_ = ItemOnLine?.Procedure;
                                bool? dzzzzzzzzy_(Claim.ProcedureComponent @this)
                                {
                                    DataType fzzzzzzzza_ = @this?.Procedure;
                                    bool? fzzzzzzzzb_ = context.Operators.Not((bool?)(fzzzzzzzza_ is null));

                                    return fzzzzzzzzb_;
                                };
                                IEnumerable<Claim.ProcedureComponent> dzzzzzzzzz_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)dzzzzzzzzx_, dzzzzzzzzy_);
                                object ezzzzzzzza_(Claim.ProcedureComponent @this)
                                {
                                    DataType fzzzzzzzzc_ = @this?.Procedure;

                                    return fzzzzzzzzc_;
                                };
                                IEnumerable<object> ezzzzzzzzb_ = context.Operators.Select<Claim.ProcedureComponent, object>(dzzzzzzzzz_, ezzzzzzzza_);
                                bool? ezzzzzzzzc_(object @this)
                                {
                                    object fzzzzzzzzd_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                    bool? fzzzzzzzze_ = context.Operators.Not((bool?)(fzzzzzzzzd_ is null));

                                    return fzzzzzzzze_;
                                };
                                IEnumerable<object> ezzzzzzzzd_ = context.Operators.Where<object>(ezzzzzzzzb_, ezzzzzzzzc_);
                                object ezzzzzzzze_(object @this)
                                {
                                    object fzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                    return fzzzzzzzzf_;
                                };
                                IEnumerable<object> ezzzzzzzzf_ = context.Operators.Select<object, object>(ezzzzzzzzd_, ezzzzzzzze_);
                                IEnumerable<object> ezzzzzzzzg_ = context.Operators.FlattenLateBoundList(ezzzzzzzzf_);
                                Coding ezzzzzzzzh_(object @object) =>
                                    (Coding)@object;
                                IEnumerable<Coding> ezzzzzzzzi_ = context.Operators.Select<object, Coding>(ezzzzzzzzg_, ezzzzzzzzh_);
                                bool? ezzzzzzzzj_(Coding ProcedureHeaderCode)
                                {
                                    Code fzzzzzzzzg_ = ProcedureHeaderCode?.CodeElement;
                                    string fzzzzzzzzh_ = fzzzzzzzzg_?.Value;
                                    IEnumerable<string> fzzzzzzzzi_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? fzzzzzzzzj_ = context.Operators.In<string>(fzzzzzzzzh_, fzzzzzzzzi_);

                                    return fzzzzzzzzj_;
                                };
                                IEnumerable<Coding> ezzzzzzzzk_ = context.Operators.Where<Coding>(ezzzzzzzzi_, ezzzzzzzzj_);
                                bool? ezzzzzzzzl_ = context.Operators.Exists<Coding>(ezzzzzzzzk_);
                                List<Claim.ItemComponent> ezzzzzzzzm_ = ItemOnLine?.Item;
                                bool? ezzzzzzzzn_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept fzzzzzzzzk_ = @this?.ProductOrService;
                                    bool? fzzzzzzzzl_ = context.Operators.Not((bool?)(fzzzzzzzzk_ is null));

                                    return fzzzzzzzzl_;
                                };
                                IEnumerable<Claim.ItemComponent> ezzzzzzzzo_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ezzzzzzzzm_, ezzzzzzzzn_);
                                CodeableConcept ezzzzzzzzp_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept fzzzzzzzzm_ = @this?.ProductOrService;

                                    return fzzzzzzzzm_;
                                };
                                IEnumerable<CodeableConcept> ezzzzzzzzq_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ezzzzzzzzo_, ezzzzzzzzp_);
                                bool? ezzzzzzzzr_(CodeableConcept @this)
                                {
                                    List<Coding> fzzzzzzzzn_ = @this?.Coding;
                                    bool? fzzzzzzzzo_ = context.Operators.Not((bool?)(fzzzzzzzzn_ is null));

                                    return fzzzzzzzzo_;
                                };
                                IEnumerable<CodeableConcept> ezzzzzzzzs_ = context.Operators.Where<CodeableConcept>(ezzzzzzzzq_, ezzzzzzzzr_);
                                List<Coding> ezzzzzzzzt_(CodeableConcept @this)
                                {
                                    List<Coding> fzzzzzzzzp_ = @this?.Coding;

                                    return fzzzzzzzzp_;
                                };
                                IEnumerable<List<Coding>> ezzzzzzzzu_ = context.Operators.Select<CodeableConcept, List<Coding>>(ezzzzzzzzs_, ezzzzzzzzt_);
                                IEnumerable<Coding> ezzzzzzzzv_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ezzzzzzzzu_);
                                bool? ezzzzzzzzw_(Coding LineCode)
                                {
                                    Code fzzzzzzzzq_ = LineCode?.CodeElement;
                                    string fzzzzzzzzr_ = fzzzzzzzzq_?.Value;
                                    IEnumerable<string> fzzzzzzzzs_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? fzzzzzzzzt_ = context.Operators.In<string>(fzzzzzzzzr_, fzzzzzzzzs_);

                                    return fzzzzzzzzt_;
                                };
                                IEnumerable<Coding> ezzzzzzzzx_ = context.Operators.Where<Coding>(ezzzzzzzzv_, ezzzzzzzzw_);
                                bool? ezzzzzzzzy_ = context.Operators.Exists<Coding>(ezzzzzzzzx_);
                                bool? ezzzzzzzzz_ = context.Operators.Or(ezzzzzzzzl_, ezzzzzzzzy_);

                                return ezzzzzzzzz_;
                            };
                            IEnumerable<Claim> dzzzzzzzzv_ = context.Operators.Where<Claim>((IEnumerable<Claim>)dzzzzzzzzt_, dzzzzzzzzu_);
                            Claim dzzzzzzzzw_ = context.Operators.SingletonFrom<Claim>(dzzzzzzzzv_);

                            return dzzzzzzzzw_;
                        }
                    };
                    (CqlTupleMetadata, Claim ProcedureItems)? dzzzzzzzzn_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, dzzzzzzzzm_());
                    (CqlTupleMetadata, Claim ProcedureItems)?[] dzzzzzzzzo_ = [
                        dzzzzzzzzn_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzp_((CqlTupleMetadata, Claim ProcedureItems)? HeaderDefinition)
                    {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzu_()
                        {
                            bool fzzzzzzzzv_()
                            {
                                Claim fzzzzzzzzw_ = HeaderDefinition?.ProcedureItems;
                                bool? fzzzzzzzzx_ = context.Operators.Not((bool?)(fzzzzzzzzw_ is null));

                                return fzzzzzzzzx_ ?? false;
                            };
                            if (fzzzzzzzzv_())
                            {
                                Claim fzzzzzzzzy_ = HeaderDefinition?.ProcedureItems;
                                List<Claim.ItemComponent> gzzzzzzzza_ = fzzzzzzzzy_?.Item;
                                CqlInterval<CqlDateTime> gzzzzzzzzb_(Claim.ItemComponent NormalDate)
                                {
                                    DataType gzzzzzzzzf_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> gzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzf_);

                                    return gzzzzzzzzg_;
                                };
                                IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzc_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)gzzzzzzzza_, gzzzzzzzzb_);
                                IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzzzzzc_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzze_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, fzzzzzzzzy_, gzzzzzzzzd_);

                                return gzzzzzzzze_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        };

                        return fzzzzzzzzu_();
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim ProcedureItems)?>)dzzzzzzzzo_, dzzzzzzzzp_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzq_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzr_);

                    return dzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzi_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzg_, dzzzzzzzzh_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzi_);
                bool? dzzzzzzzzk_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? gzzzzzzzzh_ = context.Operators.Not((bool?)(FinalList is null));

                    return gzzzzzzzzh_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzj_, dzzzzzzzzk_);

                return dzzzzzzzzl_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> czzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)bzzzzzzzzz_, czzzzzzzza_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> czzzzzzzzc_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(czzzzzzzzb_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzd_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(czzzzzzzzc_);

            return czzzzzzzzd_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> bzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)bzzzzzzzzq_, bzzzzzzzzr_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> bzzzzzzzzt_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(bzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzu_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(bzzzzzzzzt_);

        return bzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> gzzzzzzzzi_ = this.Professional_or_Institutional_Claims(context, claim);
        string gzzzzzzzzj_(CqlCode d)
        {
            string gzzzzzzzzv_ = d?.code;

            return gzzzzzzzzv_;
        };
        IEnumerable<string> gzzzzzzzzk_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, gzzzzzzzzj_);
        IEnumerable<string> gzzzzzzzzl_ = context.Operators.Distinct<string>(gzzzzzzzzk_);
        string gzzzzzzzzm_(CqlCode p)
        {
            string gzzzzzzzzw_ = p?.code;

            return gzzzzzzzzw_;
        };
        IEnumerable<string> gzzzzzzzzn_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, gzzzzzzzzm_);
        IEnumerable<string> gzzzzzzzzo_ = context.Operators.Distinct<string>(gzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? gzzzzzzzzp_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, gzzzzzzzzi_, gzzzzzzzzl_, gzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] gzzzzzzzzq_ = [
            gzzzzzzzzp_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzzr_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure)
        {
            IEnumerable<Claim> gzzzzzzzzx_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzzy_(Claim ClaimofInterest)
            {
                Claim hzzzzzzzzd_()
                {
                    if (ClaimofInterest is null)
                    {
                        return default;
                    }
                    else
                    {
                        Claim[] hzzzzzzzzk_ = [
                            ClaimofInterest,
                        ];
                        bool? hzzzzzzzzl_(Claim ItemOnLine)
                        {
                            List<Claim.ItemComponent> hzzzzzzzzo_ = ItemOnLine?.Item;
                            bool? hzzzzzzzzp_(Claim.ItemComponent @this)
                            {
                                CodeableConcept izzzzzzzzr_ = @this?.ProductOrService;
                                bool? izzzzzzzzs_ = context.Operators.Not((bool?)(izzzzzzzzr_ is null));

                                return izzzzzzzzs_;
                            };
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzq_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)hzzzzzzzzo_, hzzzzzzzzp_);
                            CodeableConcept hzzzzzzzzr_(Claim.ItemComponent @this)
                            {
                                CodeableConcept izzzzzzzzt_ = @this?.ProductOrService;

                                return izzzzzzzzt_;
                            };
                            IEnumerable<CodeableConcept> hzzzzzzzzs_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(hzzzzzzzzq_, hzzzzzzzzr_);
                            bool? hzzzzzzzzt_(CodeableConcept @this)
                            {
                                List<Coding> izzzzzzzzu_ = @this?.Coding;
                                bool? izzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzu_ is null));

                                return izzzzzzzzv_;
                            };
                            IEnumerable<CodeableConcept> hzzzzzzzzu_ = context.Operators.Where<CodeableConcept>(hzzzzzzzzs_, hzzzzzzzzt_);
                            List<Coding> hzzzzzzzzv_(CodeableConcept @this)
                            {
                                List<Coding> izzzzzzzzw_ = @this?.Coding;

                                return izzzzzzzzw_;
                            };
                            IEnumerable<List<Coding>> hzzzzzzzzw_ = context.Operators.Select<CodeableConcept, List<Coding>>(hzzzzzzzzu_, hzzzzzzzzv_);
                            IEnumerable<Coding> hzzzzzzzzx_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)hzzzzzzzzw_);
                            bool? hzzzzzzzzy_(Coding LineCode)
                            {
                                Code izzzzzzzzx_ = LineCode?.CodeElement;
                                string izzzzzzzzy_ = izzzzzzzzx_?.Value;
                                IEnumerable<string> izzzzzzzzz_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? jzzzzzzzza_ = context.Operators.In<string>(izzzzzzzzy_, izzzzzzzzz_);

                                return jzzzzzzzza_;
                            };
                            IEnumerable<Coding> hzzzzzzzzz_ = context.Operators.Where<Coding>(hzzzzzzzzx_, hzzzzzzzzy_);
                            bool? izzzzzzzza_ = context.Operators.Exists<Coding>(hzzzzzzzzz_);
                            List<Claim.ProcedureComponent> izzzzzzzzb_ = ItemOnLine?.Procedure;
                            bool? izzzzzzzzc_(Claim.ProcedureComponent @this)
                            {
                                DataType jzzzzzzzzb_ = @this?.Procedure;
                                bool? jzzzzzzzzc_ = context.Operators.Not((bool?)(jzzzzzzzzb_ is null));

                                return jzzzzzzzzc_;
                            };
                            IEnumerable<Claim.ProcedureComponent> izzzzzzzzd_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)izzzzzzzzb_, izzzzzzzzc_);
                            object izzzzzzzze_(Claim.ProcedureComponent @this)
                            {
                                DataType jzzzzzzzzd_ = @this?.Procedure;

                                return jzzzzzzzzd_;
                            };
                            IEnumerable<object> izzzzzzzzf_ = context.Operators.Select<Claim.ProcedureComponent, object>(izzzzzzzzd_, izzzzzzzze_);
                            bool? izzzzzzzzg_(object @this)
                            {
                                object jzzzzzzzze_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? jzzzzzzzzf_ = context.Operators.Not((bool?)(jzzzzzzzze_ is null));

                                return jzzzzzzzzf_;
                            };
                            IEnumerable<object> izzzzzzzzh_ = context.Operators.Where<object>(izzzzzzzzf_, izzzzzzzzg_);
                            object izzzzzzzzi_(object @this)
                            {
                                object jzzzzzzzzg_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return jzzzzzzzzg_;
                            };
                            IEnumerable<object> izzzzzzzzj_ = context.Operators.Select<object, object>(izzzzzzzzh_, izzzzzzzzi_);
                            IEnumerable<object> izzzzzzzzk_ = context.Operators.FlattenLateBoundList(izzzzzzzzj_);
                            Coding izzzzzzzzl_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> izzzzzzzzm_ = context.Operators.Select<object, Coding>(izzzzzzzzk_, izzzzzzzzl_);
                            bool? izzzzzzzzn_(Coding HeaderCode)
                            {
                                Code jzzzzzzzzh_ = HeaderCode?.CodeElement;
                                string jzzzzzzzzi_ = jzzzzzzzzh_?.Value;
                                IEnumerable<string> jzzzzzzzzj_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? jzzzzzzzzk_ = context.Operators.In<string>(jzzzzzzzzi_, jzzzzzzzzj_);

                                return jzzzzzzzzk_;
                            };
                            IEnumerable<Coding> izzzzzzzzo_ = context.Operators.Where<Coding>(izzzzzzzzm_, izzzzzzzzn_);
                            bool? izzzzzzzzp_ = context.Operators.Exists<Coding>(izzzzzzzzo_);
                            bool? izzzzzzzzq_ = context.Operators.Or(izzzzzzzza_, izzzzzzzzp_);

                            return izzzzzzzzq_;
                        };
                        IEnumerable<Claim> hzzzzzzzzm_ = context.Operators.Where<Claim>((IEnumerable<Claim>)hzzzzzzzzk_, hzzzzzzzzl_);
                        Claim hzzzzzzzzn_ = context.Operators.SingletonFrom<Claim>(hzzzzzzzzm_);

                        return hzzzzzzzzn_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? hzzzzzzzze_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, hzzzzzzzzd_());
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?[] hzzzzzzzzf_ = [
                    hzzzzzzzze_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzg_((CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? DiagnosisCheck)
                {
                    Claim jzzzzzzzzl_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] jzzzzzzzzm_ = [
                        jzzzzzzzzl_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzn_(Claim ClaimforDiagnosis)
                    {
                        List<Claim.ItemComponent> jzzzzzzzzr_ = ClaimforDiagnosis?.Item;
                        Claim jzzzzzzzzs_()
                        {
                            if (ClaimforDiagnosis is null)
                            {
                                return default;
                            }
                            else
                            {
                                Claim[] jzzzzzzzzz_ = [
                                    ClaimforDiagnosis,
                                ];
                                bool? kzzzzzzzza_(Claim RightClaim)
                                {
                                    List<Claim.DiagnosisComponent> kzzzzzzzzd_ = RightClaim?.Diagnosis;
                                    bool? kzzzzzzzze_(Claim.DiagnosisComponent RightDiagnosis)
                                    {
                                        PositiveInt kzzzzzzzzh_ = RightDiagnosis?.SequenceElement;
                                        Integer kzzzzzzzzi_ = context.Operators.Convert<Integer>(kzzzzzzzzh_);
                                        int? kzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, kzzzzzzzzi_);
                                        bool? kzzzzzzzzk_ = context.Operators.Equal(kzzzzzzzzj_, 1);
                                        DataType kzzzzzzzzl_ = RightDiagnosis?.Diagnosis;
                                        IEnumerable<Coding> kzzzzzzzzm_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(kzzzzzzzzl_, "coding");
                                        bool? kzzzzzzzzn_(Coding DiagnosisCode)
                                        {
                                            Code kzzzzzzzzr_ = DiagnosisCode?.CodeElement;
                                            string kzzzzzzzzs_ = kzzzzzzzzr_?.Value;
                                            IEnumerable<string> kzzzzzzzzt_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                            bool? kzzzzzzzzu_ = context.Operators.In<string>(kzzzzzzzzs_, kzzzzzzzzt_);

                                            return kzzzzzzzzu_;
                                        };
                                        IEnumerable<Coding> kzzzzzzzzo_ = context.Operators.Where<Coding>(kzzzzzzzzm_, kzzzzzzzzn_);
                                        bool? kzzzzzzzzp_ = context.Operators.Exists<Coding>(kzzzzzzzzo_);
                                        bool? kzzzzzzzzq_ = context.Operators.And(kzzzzzzzzk_, kzzzzzzzzp_);

                                        return kzzzzzzzzq_;
                                    };
                                    IEnumerable<Claim.DiagnosisComponent> kzzzzzzzzf_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)kzzzzzzzzd_, kzzzzzzzze_);
                                    bool? kzzzzzzzzg_ = context.Operators.Exists<Claim.DiagnosisComponent>(kzzzzzzzzf_);

                                    return kzzzzzzzzg_;
                                };
                                IEnumerable<Claim> kzzzzzzzzb_ = context.Operators.Where<Claim>((IEnumerable<Claim>)jzzzzzzzzz_, kzzzzzzzza_);
                                Claim kzzzzzzzzc_ = context.Operators.SingletonFrom<Claim>(kzzzzzzzzb_);

                                return kzzzzzzzzc_;
                            }
                        };
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? jzzzzzzzzt_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)jzzzzzzzzr_, jzzzzzzzzs_());
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] jzzzzzzzzu_ = [
                            jzzzzzzzzt_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzv_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? kzzzzzzzzv_()
                            {
                                bool kzzzzzzzzw_()
                                {
                                    bool? kzzzzzzzzx_ = context.Operators.Not((bool?)(LineItemDefinition is null));
                                    Claim kzzzzzzzzy_ = LineItemDefinition?.LineItems;
                                    bool? kzzzzzzzzz_ = context.Operators.Not((bool?)(kzzzzzzzzy_ is null));
                                    bool? lzzzzzzzza_ = context.Operators.And(kzzzzzzzzx_, kzzzzzzzzz_);

                                    return lzzzzzzzza_ ?? false;
                                };
                                if (kzzzzzzzzw_())
                                {
                                    Claim lzzzzzzzzb_ = LineItemDefinition?.LineItems;
                                    List<Claim.ItemComponent> lzzzzzzzzd_ = lzzzzzzzzb_?.Item;
                                    CqlInterval<CqlDateTime> lzzzzzzzze_(Claim.ItemComponent NormalDate)
                                    {
                                        DataType lzzzzzzzzh_ = NormalDate?.Serviced;
                                        CqlInterval<CqlDateTime> lzzzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, lzzzzzzzzh_);

                                        return lzzzzzzzzi_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzf_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)lzzzzzzzzd_, lzzzzzzzze_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? lzzzzzzzzg_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, lzzzzzzzzb_, lzzzzzzzzf_);

                                    return lzzzzzzzzg_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                                }
                            };

                            return kzzzzzzzzv_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)jzzzzzzzzu_, jzzzzzzzzv_);
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzw_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzx_);

                        return jzzzzzzzzy_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzo_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)jzzzzzzzzm_, jzzzzzzzzn_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzo_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzp_);

                    return jzzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?>)hzzzzzzzzf_, hzzzzzzzzg_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(hzzzzzzzzh_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(hzzzzzzzzi_);

                return hzzzzzzzzj_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzzz_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(gzzzzzzzzx_, gzzzzzzzzy_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(gzzzzzzzzz_);
            bool? hzzzzzzzzb_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? lzzzzzzzzj_ = context.Operators.Not((bool?)(FinalList is null));

                return lzzzzzzzzj_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(hzzzzzzzza_, hzzzzzzzzb_);

            return hzzzzzzzzc_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> gzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)gzzzzzzzzq_, gzzzzzzzzr_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> gzzzzzzzzt_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(gzzzzzzzzs_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzzu_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(gzzzzzzzzt_);

        return gzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Medical Claims With Principal Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> lzzzzzzzzk_ = this.Professional_or_Institutional_Claims(context, claim);
        string lzzzzzzzzl_(CqlCode d)
        {
            string lzzzzzzzzu_ = d?.code;

            return lzzzzzzzzu_;
        };
        IEnumerable<string> lzzzzzzzzm_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, lzzzzzzzzl_);
        IEnumerable<string> lzzzzzzzzn_ = context.Operators.Distinct<string>(lzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? lzzzzzzzzo_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, lzzzzzzzzk_, lzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] lzzzzzzzzp_ = [
            lzzzzzzzzo_,
        ];
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzzq_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> lzzzzzzzzv_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> mzzzzzzzzc_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? mzzzzzzzzd_(Claim RightClaim)
                    {
                        List<Claim.DiagnosisComponent> mzzzzzzzzf_ = RightClaim?.Diagnosis;
                        bool? mzzzzzzzzg_(Claim.DiagnosisComponent RightDiagnosis)
                        {
                            PositiveInt mzzzzzzzzj_ = RightDiagnosis?.SequenceElement;
                            Integer mzzzzzzzzk_ = context.Operators.Convert<Integer>(mzzzzzzzzj_);
                            int? mzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, mzzzzzzzzk_);
                            bool? mzzzzzzzzm_ = context.Operators.Equal(mzzzzzzzzl_, 1);
                            DataType mzzzzzzzzn_ = RightDiagnosis?.Diagnosis;
                            IEnumerable<Coding> mzzzzzzzzo_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(mzzzzzzzzn_, "coding");
                            bool? mzzzzzzzzp_(Coding DiagnosisCode)
                            {
                                Code mzzzzzzzzt_ = DiagnosisCode?.CodeElement;
                                string mzzzzzzzzu_ = mzzzzzzzzt_?.Value;
                                IEnumerable<string> mzzzzzzzzv_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                                bool? mzzzzzzzzw_ = context.Operators.In<string>(mzzzzzzzzu_, mzzzzzzzzv_);

                                return mzzzzzzzzw_;
                            };
                            IEnumerable<Coding> mzzzzzzzzq_ = context.Operators.Where<Coding>(mzzzzzzzzo_, mzzzzzzzzp_);
                            bool? mzzzzzzzzr_ = context.Operators.Exists<Coding>(mzzzzzzzzq_);
                            bool? mzzzzzzzzs_ = context.Operators.And(mzzzzzzzzm_, mzzzzzzzzr_);

                            return mzzzzzzzzs_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> mzzzzzzzzh_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)mzzzzzzzzf_, mzzzzzzzzg_);
                        bool? mzzzzzzzzi_ = context.Operators.Exists<Claim.DiagnosisComponent>(mzzzzzzzzh_);

                        return mzzzzzzzzi_;
                    };
                    IEnumerable<Claim> mzzzzzzzze_ = context.Operators.Where<Claim>(mzzzzzzzzc_, mzzzzzzzzd_);

                    return mzzzzzzzze_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)? lzzzzzzzzw_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, lzzzzzzzzv_());
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)?[] lzzzzzzzzx_ = [
                lzzzzzzzzw_,
            ];
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzzy_((CqlTupleMetadata, IEnumerable<Claim> LineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> mzzzzzzzzx_ = LineItemDefinition?.LineItems;
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzy_(Claim ClaimWithDiagnosis)
                {
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzzd_()
                    {
                        if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
                        {
                            IEnumerable<Claim> nzzzzzzzze_ = LineItemDefinition?.LineItems;
                            bool? nzzzzzzzzg_(Claim @this)
                            {
                                List<Claim.ItemComponent> nzzzzzzzzp_ = @this?.Item;
                                bool? nzzzzzzzzq_ = context.Operators.Not((bool?)(nzzzzzzzzp_ is null));

                                return nzzzzzzzzq_;
                            };
                            IEnumerable<Claim> nzzzzzzzzh_ = context.Operators.Where<Claim>(nzzzzzzzze_, nzzzzzzzzg_);
                            List<Claim.ItemComponent> nzzzzzzzzi_(Claim @this)
                            {
                                List<Claim.ItemComponent> nzzzzzzzzr_ = @this?.Item;

                                return nzzzzzzzzr_;
                            };
                            IEnumerable<List<Claim.ItemComponent>> nzzzzzzzzj_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(nzzzzzzzzh_, nzzzzzzzzi_);
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzk_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)nzzzzzzzzj_);
                            CqlInterval<CqlDateTime> nzzzzzzzzl_(Claim.ItemComponent NormalDate)
                            {
                                DataType nzzzzzzzzs_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> nzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, nzzzzzzzzs_);

                                return nzzzzzzzzt_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzm_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(nzzzzzzzzk_, nzzzzzzzzl_);
                            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzm_);
                            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzzo_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, nzzzzzzzze_, nzzzzzzzzn_);

                            return nzzzzzzzzo_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return nzzzzzzzzd_();
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzz_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzx_, mzzzzzzzzy_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzz_);
                bool? nzzzzzzzzb_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? nzzzzzzzzu_ = context.Operators.Not((bool?)(FinalList is null));

                    return nzzzzzzzzu_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzza_, nzzzzzzzzb_);

                return nzzzzzzzzc_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> lzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?>)lzzzzzzzzx_, lzzzzzzzzy_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> mzzzzzzzza_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(lzzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzb_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(mzzzzzzzza_);

            return mzzzzzzzzb_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> lzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)lzzzzzzzzp_, lzzzzzzzzq_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> lzzzzzzzzs_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(lzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzzt_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(lzzzzzzzzs_);

        return lzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Get All Professional and Institutional Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> nzzzzzzzzv_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
        IEnumerable<Claim> nzzzzzzzzw_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? nzzzzzzzzx_ = (CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE, nzzzzzzzzv_, nzzzzzzzzw_);

        return nzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Get All Paid Claim Reponses")]
    public IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? nzzzzzzzzy_(ClaimResponse ResponseItem)
        {
            Code<ClaimProcessingCodes> ozzzzzzzzg_ = ResponseItem?.OutcomeElement;
            string ozzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzg_);
            string[] ozzzzzzzzi_ = [
                "complete",
                "partial",
            ];
            bool? ozzzzzzzzj_ = context.Operators.In<string>(ozzzzzzzzh_, ozzzzzzzzi_ as IEnumerable<string>);

            return ozzzzzzzzj_;
        };
        IEnumerable<ClaimResponse> nzzzzzzzzz_ = context.Operators.Where<ClaimResponse>(claimResponse, nzzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ozzzzzzzza_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, nzzzzzzzzz_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?[] ozzzzzzzzb_ = [
            ozzzzzzzza_,
        ];
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzzc_((CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ClaimResponse)
        {
            IEnumerable<ClaimResponse> ozzzzzzzzk_ = ClaimResponse?.PaidResponse;
            (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? ozzzzzzzzl_(ClaimResponse ClmResp)
            {
                ResourceReference ozzzzzzzzo_ = ClmResp?.Request;
                FhirString ozzzzzzzzp_ = ozzzzzzzzo_?.ReferenceElement;
                string ozzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzzp_);
                string ozzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ozzzzzzzzq_);
                List<ClaimResponse.ItemComponent> ozzzzzzzzs_ = ClmResp?.Item;
                bool? ozzzzzzzzt_(ClaimResponse.ItemComponent ResponseItem)
                {
                    List<ClaimResponse.AdjudicationComponent> ozzzzzzzzw_ = ResponseItem?.Adjudication;
                    bool? ozzzzzzzzx_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept pzzzzzzzzs_ = @this?.Category;
                        bool? pzzzzzzzzt_ = context.Operators.Not((bool?)(pzzzzzzzzs_ is null));

                        return pzzzzzzzzt_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> ozzzzzzzzy_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)ozzzzzzzzw_, ozzzzzzzzx_);
                    CodeableConcept ozzzzzzzzz_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept pzzzzzzzzu_ = @this?.Category;

                        return pzzzzzzzzu_;
                    };
                    IEnumerable<CodeableConcept> pzzzzzzzza_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(ozzzzzzzzy_, ozzzzzzzzz_);
                    bool? pzzzzzzzzb_(CodeableConcept @this)
                    {
                        List<Coding> pzzzzzzzzv_ = @this?.Coding;
                        bool? pzzzzzzzzw_ = context.Operators.Not((bool?)(pzzzzzzzzv_ is null));

                        return pzzzzzzzzw_;
                    };
                    IEnumerable<CodeableConcept> pzzzzzzzzc_ = context.Operators.Where<CodeableConcept>(pzzzzzzzza_, pzzzzzzzzb_);
                    List<Coding> pzzzzzzzzd_(CodeableConcept @this)
                    {
                        List<Coding> pzzzzzzzzx_ = @this?.Coding;

                        return pzzzzzzzzx_;
                    };
                    IEnumerable<List<Coding>> pzzzzzzzze_ = context.Operators.Select<CodeableConcept, List<Coding>>(pzzzzzzzzc_, pzzzzzzzzd_);
                    IEnumerable<Coding> pzzzzzzzzf_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)pzzzzzzzze_);
                    bool? pzzzzzzzzg_(Coding CategoryItem)
                    {
                        Code pzzzzzzzzy_ = CategoryItem?.CodeElement;
                        string pzzzzzzzzz_ = pzzzzzzzzy_?.Value;
                        bool? qzzzzzzzza_ = context.Operators.Equal(pzzzzzzzzz_, "benefit");

                        return qzzzzzzzza_;
                    };
                    IEnumerable<Coding> pzzzzzzzzh_ = context.Operators.Where<Coding>(pzzzzzzzzf_, pzzzzzzzzg_);
                    bool? pzzzzzzzzi_ = context.Operators.Exists<Coding>(pzzzzzzzzh_);
                    bool? pzzzzzzzzk_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money qzzzzzzzzb_ = @this?.Amount;
                        bool? qzzzzzzzzc_ = context.Operators.Not((bool?)(qzzzzzzzzb_ is null));

                        return qzzzzzzzzc_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> pzzzzzzzzl_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)ozzzzzzzzw_, pzzzzzzzzk_);
                    Money pzzzzzzzzm_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money qzzzzzzzzd_ = @this?.Amount;

                        return qzzzzzzzzd_;
                    };
                    IEnumerable<Money> pzzzzzzzzn_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(pzzzzzzzzl_, pzzzzzzzzm_);
                    bool? pzzzzzzzzo_(Money DollarAmount)
                    {
                        FhirDecimal qzzzzzzzze_ = DollarAmount?.ValueElement;
                        decimal? qzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, qzzzzzzzze_);
                        decimal? qzzzzzzzzg_ = context.Operators.ConvertIntegerToDecimal(0);
                        bool? qzzzzzzzzh_ = context.Operators.Greater(qzzzzzzzzf_, qzzzzzzzzg_);

                        return qzzzzzzzzh_;
                    };
                    IEnumerable<Money> pzzzzzzzzp_ = context.Operators.Where<Money>(pzzzzzzzzn_, pzzzzzzzzo_);
                    bool? pzzzzzzzzq_ = context.Operators.Exists<Money>(pzzzzzzzzp_);
                    bool? pzzzzzzzzr_ = context.Operators.And(pzzzzzzzzi_, pzzzzzzzzq_);

                    return pzzzzzzzzr_;
                };
                IEnumerable<ClaimResponse.ItemComponent> ozzzzzzzzu_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)ozzzzzzzzs_, ozzzzzzzzt_);
                (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? ozzzzzzzzv_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, ozzzzzzzzr_, ozzzzzzzzu_);

                return ozzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzzm_ = context.Operators.Select<ClaimResponse, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ozzzzzzzzk_, ozzzzzzzzl_);
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ozzzzzzzzm_);

            return ozzzzzzzzn_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> ozzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?>)ozzzzzzzzb_, ozzzzzzzzc_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> ozzzzzzzze_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(ozzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzzf_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(ozzzzzzzze_);

        return ozzzzzzzzf_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? qzzzzzzzzi_(Claim AllClaims)
        {
            List<Claim.ItemComponent> qzzzzzzzzn_ = AllClaims?.Item;
            bool? qzzzzzzzzo_(Claim.ItemComponent @this)
            {
                CodeableConcept rzzzzzzzzq_ = @this?.ProductOrService;
                bool? rzzzzzzzzr_ = context.Operators.Not((bool?)(rzzzzzzzzq_ is null));

                return rzzzzzzzzr_;
            };
            IEnumerable<Claim.ItemComponent> qzzzzzzzzp_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)qzzzzzzzzn_, qzzzzzzzzo_);
            CodeableConcept qzzzzzzzzq_(Claim.ItemComponent @this)
            {
                CodeableConcept rzzzzzzzzs_ = @this?.ProductOrService;

                return rzzzzzzzzs_;
            };
            IEnumerable<CodeableConcept> qzzzzzzzzr_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(qzzzzzzzzp_, qzzzzzzzzq_);
            bool? qzzzzzzzzs_(CodeableConcept @this)
            {
                List<Coding> rzzzzzzzzt_ = @this?.Coding;
                bool? rzzzzzzzzu_ = context.Operators.Not((bool?)(rzzzzzzzzt_ is null));

                return rzzzzzzzzu_;
            };
            IEnumerable<CodeableConcept> qzzzzzzzzt_ = context.Operators.Where<CodeableConcept>(qzzzzzzzzr_, qzzzzzzzzs_);
            List<Coding> qzzzzzzzzu_(CodeableConcept @this)
            {
                List<Coding> rzzzzzzzzv_ = @this?.Coding;

                return rzzzzzzzzv_;
            };
            IEnumerable<List<Coding>> qzzzzzzzzv_ = context.Operators.Select<CodeableConcept, List<Coding>>(qzzzzzzzzt_, qzzzzzzzzu_);
            IEnumerable<Coding> qzzzzzzzzw_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)qzzzzzzzzv_);
            bool? qzzzzzzzzx_(Coding ProductOrServiceCode)
            {
                CqlCode rzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? rzzzzzzzzx_ = context.Operators.In<CqlCode>(rzzzzzzzzw_, ProductOrServiceValueSet);

                return rzzzzzzzzx_;
            };
            IEnumerable<Coding> qzzzzzzzzy_ = context.Operators.Where<Coding>(qzzzzzzzzw_, qzzzzzzzzx_);
            bool? qzzzzzzzzz_ = context.Operators.Exists<Coding>(qzzzzzzzzy_);
            List<Claim.DiagnosisComponent> rzzzzzzzza_ = AllClaims?.Diagnosis;
            bool? rzzzzzzzzb_(Claim.DiagnosisComponent @this)
            {
                DataType rzzzzzzzzy_ = @this?.Diagnosis;
                bool? rzzzzzzzzz_ = context.Operators.Not((bool?)(rzzzzzzzzy_ is null));

                return rzzzzzzzzz_;
            };
            IEnumerable<Claim.DiagnosisComponent> rzzzzzzzzc_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)rzzzzzzzza_, rzzzzzzzzb_);
            object rzzzzzzzzd_(Claim.DiagnosisComponent @this)
            {
                DataType szzzzzzzza_ = @this?.Diagnosis;

                return szzzzzzzza_;
            };
            IEnumerable<object> rzzzzzzzze_ = context.Operators.Select<Claim.DiagnosisComponent, object>(rzzzzzzzzc_, rzzzzzzzzd_);
            bool? rzzzzzzzzf_(object @this)
            {
                object szzzzzzzzb_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? szzzzzzzzc_ = context.Operators.Not((bool?)(szzzzzzzzb_ is null));

                return szzzzzzzzc_;
            };
            IEnumerable<object> rzzzzzzzzg_ = context.Operators.Where<object>(rzzzzzzzze_, rzzzzzzzzf_);
            object rzzzzzzzzh_(object @this)
            {
                object szzzzzzzzd_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return szzzzzzzzd_;
            };
            IEnumerable<object> rzzzzzzzzi_ = context.Operators.Select<object, object>(rzzzzzzzzg_, rzzzzzzzzh_);
            IEnumerable<object> rzzzzzzzzj_ = context.Operators.FlattenLateBoundList(rzzzzzzzzi_);
            Coding rzzzzzzzzk_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> rzzzzzzzzl_ = context.Operators.Select<object, Coding>(rzzzzzzzzj_, rzzzzzzzzk_);
            bool? rzzzzzzzzm_(Coding DiagnosisCode)
            {
                CqlCode szzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? szzzzzzzzf_ = context.Operators.In<CqlCode>(szzzzzzzze_, DiagnosisValueSet);

                return szzzzzzzzf_;
            };
            IEnumerable<Coding> rzzzzzzzzn_ = context.Operators.Where<Coding>(rzzzzzzzzl_, rzzzzzzzzm_);
            bool? rzzzzzzzzo_ = context.Operators.Exists<Coding>(rzzzzzzzzn_);
            bool? rzzzzzzzzp_ = context.Operators.And(qzzzzzzzzz_, rzzzzzzzzo_);

            return rzzzzzzzzp_;
        };
        IEnumerable<Claim> qzzzzzzzzj_ = context.Operators.Where<Claim>(claim, qzzzzzzzzi_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? qzzzzzzzzk_(Claim ProcedureClaims)
        {
            Id szzzzzzzzg_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> szzzzzzzzh_ = ProcedureClaims?.Item;
            bool? szzzzzzzzi_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept szzzzzzzzl_ = ResponseItem?.ProductOrService;
                List<Coding> szzzzzzzzm_ = szzzzzzzzl_?.Coding;
                bool? szzzzzzzzn_(Coding ProductOrServiceCode)
                {
                    CqlCode szzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? szzzzzzzzr_ = context.Operators.In<CqlCode>(szzzzzzzzq_, ProductOrServiceValueSet);

                    return szzzzzzzzr_;
                };
                IEnumerable<Coding> szzzzzzzzo_ = context.Operators.Where<Coding>((IEnumerable<Coding>)szzzzzzzzm_, szzzzzzzzn_);
                bool? szzzzzzzzp_ = context.Operators.Exists<Coding>(szzzzzzzzo_);

                return szzzzzzzzp_;
            };
            IEnumerable<Claim.ItemComponent> szzzzzzzzj_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)szzzzzzzzh_, szzzzzzzzi_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? szzzzzzzzk_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, szzzzzzzzg_, szzzzzzzzj_);

            return szzzzzzzzk_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> qzzzzzzzzl_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(qzzzzzzzzj_, qzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> qzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(qzzzzzzzzl_);

        return qzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services and Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> szzzzzzzzs_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> szzzzzzzzt_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? szzzzzzzzu_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, szzzzzzzzs_, szzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] szzzzzzzzv_ = [
            szzzzzzzzu_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzw_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> tzzzzzzzza_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? tzzzzzzzzb_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> tzzzzzzzzk_ = medClaim?.LineItems;
                bool? tzzzzzzzzl_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> tzzzzzzzzo_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> tzzzzzzzzp_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> tzzzzzzzzs_ = pClaim?.LineItems;
                        bool? tzzzzzzzzt_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id tzzzzzzzzx_()
                            {
                                bool uzzzzzzzzl_()
                                {
                                    Claim uzzzzzzzzm_ = medClaim?.ClaimofInterest;
                                    bool uzzzzzzzzn_ = uzzzzzzzzm_ is Resource;

                                    return uzzzzzzzzn_;
                                };
                                if (uzzzzzzzzl_())
                                {
                                    Claim uzzzzzzzzo_ = medClaim?.ClaimofInterest;

                                    return (uzzzzzzzzo_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string tzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzx_());
                            ClaimResponse tzzzzzzzzz_ = pClaim?.Response;
                            ResourceReference uzzzzzzzza_ = tzzzzzzzzz_?.Request;
                            FhirString uzzzzzzzzb_ = uzzzzzzzza_?.ReferenceElement;
                            string uzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, uzzzzzzzzb_);
                            string uzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, uzzzzzzzzc_);
                            bool? uzzzzzzzze_ = context.Operators.Equal(tzzzzzzzzy_, uzzzzzzzzd_);
                            PositiveInt uzzzzzzzzf_ = medClaimLineItem?.SequenceElement;
                            Integer uzzzzzzzzg_ = context.Operators.Convert<Integer>(uzzzzzzzzf_);
                            PositiveInt uzzzzzzzzh_ = pClaimLineItem?.ItemSequenceElement;
                            Integer uzzzzzzzzi_ = context.Operators.Convert<Integer>(uzzzzzzzzh_);
                            bool? uzzzzzzzzj_ = context.Operators.Equal(uzzzzzzzzg_, uzzzzzzzzi_);
                            bool? uzzzzzzzzk_ = context.Operators.And(uzzzzzzzze_, uzzzzzzzzj_);

                            return uzzzzzzzzk_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> tzzzzzzzzu_ = context.Operators.Where<ClaimResponse.ItemComponent>(tzzzzzzzzs_, tzzzzzzzzt_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? tzzzzzzzzv_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> tzzzzzzzzw_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(tzzzzzzzzu_, tzzzzzzzzv_);

                        return tzzzzzzzzw_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> tzzzzzzzzq_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(tzzzzzzzzo_, tzzzzzzzzp_);
                    bool? tzzzzzzzzr_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(tzzzzzzzzq_);

                    return tzzzzzzzzr_;
                };
                IEnumerable<Claim.ItemComponent> tzzzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>(tzzzzzzzzk_, tzzzzzzzzl_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? tzzzzzzzzn_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, tzzzzzzzzm_);

                return tzzzzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> tzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(tzzzzzzzza_, tzzzzzzzzb_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> tzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(tzzzzzzzzc_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? tzzzzzzzze_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, tzzzzzzzzd_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] tzzzzzzzzf_ = [
                tzzzzzzzze_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzzg_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzp_()
                {
                    bool uzzzzzzzzu_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> uzzzzzzzzv_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? uzzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> vzzzzzzzzc_ = @this?.ClaimItem;
                            bool? vzzzzzzzzd_ = context.Operators.Not((bool?)(vzzzzzzzzc_ is null));

                            return vzzzzzzzzd_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> uzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(uzzzzzzzzv_, uzzzzzzzzw_);
                        IEnumerable<Claim.ItemComponent> uzzzzzzzzy_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> vzzzzzzzze_ = @this?.ClaimItem;

                            return vzzzzzzzze_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> uzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(uzzzzzzzzx_, uzzzzzzzzy_);
                        IEnumerable<Claim.ItemComponent> vzzzzzzzza_ = context.Operators.Flatten<Claim.ItemComponent>(uzzzzzzzzz_);
                        bool? vzzzzzzzzb_ = context.Operators.Exists<Claim.ItemComponent>(vzzzzzzzza_);

                        return vzzzzzzzzb_ ?? false;
                    };
                    if (uzzzzzzzzu_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzf_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? vzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? vzzzzzzzzu_ = @this?.PaidClaim;
                            bool? vzzzzzzzzv_ = context.Operators.Not((bool?)(vzzzzzzzzu_ is null));

                            return vzzzzzzzzv_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(vzzzzzzzzf_, vzzzzzzzzg_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? vzzzzzzzzi_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? vzzzzzzzzw_ = @this?.PaidClaim;

                            return vzzzzzzzzw_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> vzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(vzzzzzzzzh_, vzzzzzzzzi_);
                        bool? vzzzzzzzzl_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> vzzzzzzzzx_ = @this?.ClaimItem;
                            bool? vzzzzzzzzy_ = context.Operators.Not((bool?)(vzzzzzzzzx_ is null));

                            return vzzzzzzzzy_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(vzzzzzzzzf_, vzzzzzzzzl_);
                        IEnumerable<Claim.ItemComponent> vzzzzzzzzn_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> vzzzzzzzzz_ = @this?.ClaimItem;

                            return vzzzzzzzzz_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> vzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(vzzzzzzzzm_, vzzzzzzzzn_);
                        IEnumerable<Claim.ItemComponent> vzzzzzzzzp_ = context.Operators.Flatten<Claim.ItemComponent>(vzzzzzzzzo_);
                        CqlInterval<CqlDateTime> vzzzzzzzzq_(Claim.ItemComponent PaidItem)
                        {
                            DataType wzzzzzzzza_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> wzzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzza_);

                            return wzzzzzzzzb_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzr_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(vzzzzzzzzp_, vzzzzzzzzq_);
                        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzzzzzzzr_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzzt_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, vzzzzzzzzj_, vzzzzzzzzs_);

                        return vzzzzzzzzt_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] uzzzzzzzzq_ = [
                    uzzzzzzzzp_(),
                ];
                bool? uzzzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? wzzzzzzzzc_ = context.Operators.Not((bool?)(FinalList is null));

                    return wzzzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)uzzzzzzzzq_, uzzzzzzzzr_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(uzzzzzzzzs_);

                return uzzzzzzzzt_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> tzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)tzzzzzzzzf_, tzzzzzzzzg_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> tzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(tzzzzzzzzh_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(tzzzzzzzzi_);

            return tzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)szzzzzzzzv_, szzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzzy_);

        return szzzzzzzzz_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Service and Condition")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? wzzzzzzzzd_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] wzzzzzzzze_ = [
            wzzzzzzzzd_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzf_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzn_()
            {
                bool wzzzzzzzzo_()
                {
                    IEnumerable<ClaimResponse> wzzzzzzzzp_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> wzzzzzzzzq_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? wzzzzzzzzr_ = context.Operators.And((bool?)(wzzzzzzzzp_ is null), (bool?)(wzzzzzzzzq_ is null));

                    return wzzzzzzzzr_ ?? false;
                };
                if (wzzzzzzzzo_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> wzzzzzzzzs_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> wzzzzzzzzt_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzu_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, wzzzzzzzzs_, wzzzzzzzzt_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return wzzzzzzzzu_;
                }
            };

            return wzzzzzzzzn_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)wzzzzzzzze_, wzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] wzzzzzzzzj_ = [
            wzzzzzzzzi_,
        ];
        bool? wzzzzzzzzk_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
        {
            bool? wzzzzzzzzv_ = context.Operators.Not((bool?)(FinalList is null));

            return wzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)wzzzzzzzzj_, wzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzzl_);

        return wzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? wzzzzzzzzw_(Claim AllClaims)
        {
            List<Claim.ItemComponent> xzzzzzzzzb_ = AllClaims?.Item;
            bool? xzzzzzzzzc_(Claim.ItemComponent @this)
            {
                CodeableConcept yzzzzzzzze_ = @this?.ProductOrService;
                bool? yzzzzzzzzf_ = context.Operators.Not((bool?)(yzzzzzzzze_ is null));

                return yzzzzzzzzf_;
            };
            IEnumerable<Claim.ItemComponent> xzzzzzzzzd_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)xzzzzzzzzb_, xzzzzzzzzc_);
            CodeableConcept xzzzzzzzze_(Claim.ItemComponent @this)
            {
                CodeableConcept yzzzzzzzzg_ = @this?.ProductOrService;

                return yzzzzzzzzg_;
            };
            IEnumerable<CodeableConcept> xzzzzzzzzf_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(xzzzzzzzzd_, xzzzzzzzze_);
            bool? xzzzzzzzzg_(CodeableConcept @this)
            {
                List<Coding> yzzzzzzzzh_ = @this?.Coding;
                bool? yzzzzzzzzi_ = context.Operators.Not((bool?)(yzzzzzzzzh_ is null));

                return yzzzzzzzzi_;
            };
            IEnumerable<CodeableConcept> xzzzzzzzzh_ = context.Operators.Where<CodeableConcept>(xzzzzzzzzf_, xzzzzzzzzg_);
            List<Coding> xzzzzzzzzi_(CodeableConcept @this)
            {
                List<Coding> yzzzzzzzzj_ = @this?.Coding;

                return yzzzzzzzzj_;
            };
            IEnumerable<List<Coding>> xzzzzzzzzj_ = context.Operators.Select<CodeableConcept, List<Coding>>(xzzzzzzzzh_, xzzzzzzzzi_);
            IEnumerable<Coding> xzzzzzzzzk_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)xzzzzzzzzj_);
            bool? xzzzzzzzzl_(Coding ProductOrServiceCode)
            {
                CqlCode yzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? yzzzzzzzzl_ = context.Operators.In<CqlCode>(yzzzzzzzzk_, ProductOrServiceValueSet);

                return yzzzzzzzzl_;
            };
            IEnumerable<Coding> xzzzzzzzzm_ = context.Operators.Where<Coding>(xzzzzzzzzk_, xzzzzzzzzl_);
            bool? xzzzzzzzzn_ = context.Operators.Exists<Coding>(xzzzzzzzzm_);
            List<Claim.DiagnosisComponent> xzzzzzzzzo_ = AllClaims?.Diagnosis;
            bool? xzzzzzzzzp_(Claim.DiagnosisComponent @this)
            {
                DataType yzzzzzzzzm_ = @this?.Diagnosis;
                bool? yzzzzzzzzn_ = context.Operators.Not((bool?)(yzzzzzzzzm_ is null));

                return yzzzzzzzzn_;
            };
            IEnumerable<Claim.DiagnosisComponent> xzzzzzzzzq_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)xzzzzzzzzo_, xzzzzzzzzp_);
            object xzzzzzzzzr_(Claim.DiagnosisComponent @this)
            {
                DataType yzzzzzzzzo_ = @this?.Diagnosis;

                return yzzzzzzzzo_;
            };
            IEnumerable<object> xzzzzzzzzs_ = context.Operators.Select<Claim.DiagnosisComponent, object>(xzzzzzzzzq_, xzzzzzzzzr_);
            bool? xzzzzzzzzt_(object @this)
            {
                object yzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? yzzzzzzzzq_ = context.Operators.Not((bool?)(yzzzzzzzzp_ is null));

                return yzzzzzzzzq_;
            };
            IEnumerable<object> xzzzzzzzzu_ = context.Operators.Where<object>(xzzzzzzzzs_, xzzzzzzzzt_);
            object xzzzzzzzzv_(object @this)
            {
                object yzzzzzzzzr_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return yzzzzzzzzr_;
            };
            IEnumerable<object> xzzzzzzzzw_ = context.Operators.Select<object, object>(xzzzzzzzzu_, xzzzzzzzzv_);
            IEnumerable<object> xzzzzzzzzx_ = context.Operators.FlattenLateBoundList(xzzzzzzzzw_);
            Coding xzzzzzzzzy_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> xzzzzzzzzz_ = context.Operators.Select<object, Coding>(xzzzzzzzzx_, xzzzzzzzzy_);
            bool? yzzzzzzzza_(Coding DiagnosisCode)
            {
                CqlCode yzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? yzzzzzzzzt_ = context.Operators.In<CqlCode>(yzzzzzzzzs_, DiagnosisValueSet);

                return yzzzzzzzzt_;
            };
            IEnumerable<Coding> yzzzzzzzzb_ = context.Operators.Where<Coding>(xzzzzzzzzz_, yzzzzzzzza_);
            bool? yzzzzzzzzc_ = context.Operators.Exists<Coding>(yzzzzzzzzb_);
            bool? yzzzzzzzzd_ = context.Operators.Or(xzzzzzzzzn_, yzzzzzzzzc_);

            return yzzzzzzzzd_;
        };
        IEnumerable<Claim> wzzzzzzzzx_ = context.Operators.Where<Claim>(claim, wzzzzzzzzw_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? wzzzzzzzzy_(Claim ProcedureClaims)
        {
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? yzzzzzzzzu_()
            {
                bool yzzzzzzzzv_()
                {
                    List<Claim.ItemComponent> yzzzzzzzzw_ = ProcedureClaims?.Item;
                    bool? yzzzzzzzzx_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept zzzzzzzzza_ = ResponseItem?.ProductOrService;
                        List<Coding> zzzzzzzzzb_ = zzzzzzzzza_?.Coding;
                        bool? zzzzzzzzzc_(Coding ProductOrServiceCode)
                        {
                            CqlCode zzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? zzzzzzzzzg_ = context.Operators.In<CqlCode>(zzzzzzzzzf_, ProductOrServiceValueSet);

                            return zzzzzzzzzg_;
                        };
                        IEnumerable<Coding> zzzzzzzzzd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)zzzzzzzzzb_, zzzzzzzzzc_);
                        bool? zzzzzzzzze_ = context.Operators.Exists<Coding>(zzzzzzzzzd_);

                        return zzzzzzzzze_;
                    };
                    IEnumerable<Claim.ItemComponent> yzzzzzzzzy_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)yzzzzzzzzw_, yzzzzzzzzx_);
                    bool? yzzzzzzzzz_ = context.Operators.Exists<Claim.ItemComponent>(yzzzzzzzzy_);

                    return yzzzzzzzzz_ ?? false;
                };
                if (yzzzzzzzzv_())
                {
                    Id zzzzzzzzzh_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> zzzzzzzzzi_ = ProcedureClaims?.Item;
                    bool? zzzzzzzzzj_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept zzzzzzzzzm_ = ResponseItem?.ProductOrService;
                        List<Coding> zzzzzzzzzn_ = zzzzzzzzzm_?.Coding;
                        bool? zzzzzzzzzo_(Coding ProductOrServiceCode)
                        {
                            CqlCode zzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? zzzzzzzzzs_ = context.Operators.In<CqlCode>(zzzzzzzzzr_, ProductOrServiceValueSet);

                            return zzzzzzzzzs_;
                        };
                        IEnumerable<Coding> zzzzzzzzzp_ = context.Operators.Where<Coding>((IEnumerable<Coding>)zzzzzzzzzn_, zzzzzzzzzo_);
                        bool? zzzzzzzzzq_ = context.Operators.Exists<Coding>(zzzzzzzzzp_);

                        return zzzzzzzzzq_;
                    };
                    IEnumerable<Claim.ItemComponent> zzzzzzzzzk_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)zzzzzzzzzi_, zzzzzzzzzj_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? zzzzzzzzzl_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, zzzzzzzzzh_, zzzzzzzzzk_);

                    return zzzzzzzzzl_;
                }
                else
                {
                    Id zzzzzzzzzt_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> zzzzzzzzzu_ = ProcedureClaims?.Item;
                    bool? zzzzzzzzzv_(Claim.ItemComponent ResponseItem)
                    {
                        PositiveInt zzzzzzzzzy_ = ResponseItem?.SequenceElement;
                        Integer zzzzzzzzzz_ = context.Operators.Convert<Integer>(zzzzzzzzzy_);
                        int? azzzzzzzzza_ = zzzzzzzzzz_?.Value;
                        bool? azzzzzzzzzb_ = context.Operators.Equal(azzzzzzzzza_, 1);

                        return azzzzzzzzzb_;
                    };
                    IEnumerable<Claim.ItemComponent> zzzzzzzzzw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)zzzzzzzzzu_, zzzzzzzzzv_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? zzzzzzzzzx_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, zzzzzzzzzt_, zzzzzzzzzw_);

                    return zzzzzzzzzx_;
                }
            };

            return yzzzzzzzzu_();
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> wzzzzzzzzz_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(wzzzzzzzzx_, wzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> xzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(wzzzzzzzzz_);

        return xzzzzzzzza_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> azzzzzzzzzc_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> azzzzzzzzzd_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? azzzzzzzzze_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, azzzzzzzzzc_, azzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] azzzzzzzzzf_ = [
            azzzzzzzzze_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzzg_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> azzzzzzzzzk_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? azzzzzzzzzl_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> azzzzzzzzzu_ = medClaim?.LineItems;
                bool? azzzzzzzzzv_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> azzzzzzzzzy_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> azzzzzzzzzz_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> bzzzzzzzzzc_ = pClaim?.LineItems;
                        bool? bzzzzzzzzzd_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id bzzzzzzzzzh_()
                            {
                                bool bzzzzzzzzzv_()
                                {
                                    Claim bzzzzzzzzzw_ = medClaim?.ClaimofInterest;
                                    bool bzzzzzzzzzx_ = bzzzzzzzzzw_ is Resource;

                                    return bzzzzzzzzzx_;
                                };
                                if (bzzzzzzzzzv_())
                                {
                                    Claim bzzzzzzzzzy_ = medClaim?.ClaimofInterest;

                                    return (bzzzzzzzzzy_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string bzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzh_());
                            ClaimResponse bzzzzzzzzzj_ = pClaim?.Response;
                            ResourceReference bzzzzzzzzzk_ = bzzzzzzzzzj_?.Request;
                            FhirString bzzzzzzzzzl_ = bzzzzzzzzzk_?.ReferenceElement;
                            string bzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzl_);
                            string bzzzzzzzzzn_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, bzzzzzzzzzm_);
                            bool? bzzzzzzzzzo_ = context.Operators.Equal(bzzzzzzzzzi_, bzzzzzzzzzn_);
                            PositiveInt bzzzzzzzzzp_ = medClaimLineItem?.SequenceElement;
                            Integer bzzzzzzzzzq_ = context.Operators.Convert<Integer>(bzzzzzzzzzp_);
                            PositiveInt bzzzzzzzzzr_ = pClaimLineItem?.ItemSequenceElement;
                            Integer bzzzzzzzzzs_ = context.Operators.Convert<Integer>(bzzzzzzzzzr_);
                            bool? bzzzzzzzzzt_ = context.Operators.Equal(bzzzzzzzzzq_, bzzzzzzzzzs_);
                            bool? bzzzzzzzzzu_ = context.Operators.And(bzzzzzzzzzo_, bzzzzzzzzzt_);

                            return bzzzzzzzzzu_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> bzzzzzzzzze_ = context.Operators.Where<ClaimResponse.ItemComponent>(bzzzzzzzzzc_, bzzzzzzzzzd_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? bzzzzzzzzzf_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> bzzzzzzzzzg_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(bzzzzzzzzze_, bzzzzzzzzzf_);

                        return bzzzzzzzzzg_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> bzzzzzzzzza_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(azzzzzzzzzy_, azzzzzzzzzz_);
                    bool? bzzzzzzzzzb_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(bzzzzzzzzza_);

                    return bzzzzzzzzzb_;
                };
                IEnumerable<Claim.ItemComponent> azzzzzzzzzw_ = context.Operators.Where<Claim.ItemComponent>(azzzzzzzzzu_, azzzzzzzzzv_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? azzzzzzzzzx_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, azzzzzzzzzw_);

                return azzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> azzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(azzzzzzzzzk_, azzzzzzzzzl_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> azzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(azzzzzzzzzm_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? azzzzzzzzzo_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, azzzzzzzzzn_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] azzzzzzzzzp_ = [
                azzzzzzzzzo_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzzq_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzz_()
                {
                    bool czzzzzzzzze_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzf_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? czzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> czzzzzzzzzm_ = @this?.ClaimItem;
                            bool? czzzzzzzzzn_ = context.Operators.Not((bool?)(czzzzzzzzzm_ is null));

                            return czzzzzzzzzn_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(czzzzzzzzzf_, czzzzzzzzzg_);
                        IEnumerable<Claim.ItemComponent> czzzzzzzzzi_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> czzzzzzzzzo_ = @this?.ClaimItem;

                            return czzzzzzzzzo_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> czzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(czzzzzzzzzh_, czzzzzzzzzi_);
                        IEnumerable<Claim.ItemComponent> czzzzzzzzzk_ = context.Operators.Flatten<Claim.ItemComponent>(czzzzzzzzzj_);
                        bool? czzzzzzzzzl_ = context.Operators.Exists<Claim.ItemComponent>(czzzzzzzzzk_);

                        return czzzzzzzzzl_ ?? false;
                    };
                    if (czzzzzzzzze_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzp_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? czzzzzzzzzq_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? dzzzzzzzzze_ = @this?.PaidClaim;
                            bool? dzzzzzzzzzf_ = context.Operators.Not((bool?)(dzzzzzzzzze_ is null));

                            return dzzzzzzzzzf_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzr_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(czzzzzzzzzp_, czzzzzzzzzq_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? czzzzzzzzzs_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? dzzzzzzzzzg_ = @this?.PaidClaim;

                            return dzzzzzzzzzg_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> czzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(czzzzzzzzzr_, czzzzzzzzzs_);
                        bool? czzzzzzzzzv_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> dzzzzzzzzzh_ = @this?.ClaimItem;
                            bool? dzzzzzzzzzi_ = context.Operators.Not((bool?)(dzzzzzzzzzh_ is null));

                            return dzzzzzzzzzi_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(czzzzzzzzzp_, czzzzzzzzzv_);
                        IEnumerable<Claim.ItemComponent> czzzzzzzzzx_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> dzzzzzzzzzj_ = @this?.ClaimItem;

                            return dzzzzzzzzzj_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> czzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(czzzzzzzzzw_, czzzzzzzzzx_);
                        IEnumerable<Claim.ItemComponent> czzzzzzzzzz_ = context.Operators.Flatten<Claim.ItemComponent>(czzzzzzzzzy_);
                        CqlInterval<CqlDateTime> dzzzzzzzzza_(Claim.ItemComponent PaidItem)
                        {
                            DataType dzzzzzzzzzk_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> dzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dzzzzzzzzzk_);

                            return dzzzzzzzzzl_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzb_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(czzzzzzzzzz_, dzzzzzzzzza_);
                        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzc_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzzzzzzzzb_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzd_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, czzzzzzzzzt_, dzzzzzzzzzc_);

                        return dzzzzzzzzzd_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] czzzzzzzzza_ = [
                    bzzzzzzzzzz_(),
                ];
                bool? czzzzzzzzzb_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? dzzzzzzzzzm_ = context.Operators.Not((bool?)(FinalList is null));

                    return dzzzzzzzzzm_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)czzzzzzzzza_, czzzzzzzzzb_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzzc_);

                return czzzzzzzzzd_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)azzzzzzzzzp_, azzzzzzzzzq_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzzr_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzzs_);

            return azzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)azzzzzzzzzf_, azzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzzi_);

        return azzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? dzzzzzzzzzn_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] dzzzzzzzzzo_ = [
            dzzzzzzzzzn_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzt_()
            {
                bool dzzzzzzzzzu_()
                {
                    IEnumerable<ClaimResponse> dzzzzzzzzzv_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> dzzzzzzzzzw_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? dzzzzzzzzzx_ = context.Operators.And((bool?)(dzzzzzzzzzv_ is null), (bool?)(dzzzzzzzzzw_ is null));

                    return dzzzzzzzzzx_ ?? false;
                };
                if (dzzzzzzzzzu_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> dzzzzzzzzzy_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> dzzzzzzzzzz_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzza_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, dzzzzzzzzzy_, dzzzzzzzzzz_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return ezzzzzzzzza_;
                }
            };

            return dzzzzzzzzzt_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)dzzzzzzzzzo_, dzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzr_);

        return dzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure Only")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        bool? ezzzzzzzzzb_(Claim AllClaims)
        {
            List<Claim.ItemComponent> ezzzzzzzzzg_ = AllClaims?.Item;
            bool? ezzzzzzzzzh_(Claim.ItemComponent @this)
            {
                CodeableConcept ezzzzzzzzzt_ = @this?.ProductOrService;
                bool? ezzzzzzzzzu_ = context.Operators.Not((bool?)(ezzzzzzzzzt_ is null));

                return ezzzzzzzzzu_;
            };
            IEnumerable<Claim.ItemComponent> ezzzzzzzzzi_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ezzzzzzzzzg_, ezzzzzzzzzh_);
            CodeableConcept ezzzzzzzzzj_(Claim.ItemComponent @this)
            {
                CodeableConcept ezzzzzzzzzv_ = @this?.ProductOrService;

                return ezzzzzzzzzv_;
            };
            IEnumerable<CodeableConcept> ezzzzzzzzzk_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ezzzzzzzzzi_, ezzzzzzzzzj_);
            bool? ezzzzzzzzzl_(CodeableConcept @this)
            {
                List<Coding> ezzzzzzzzzw_ = @this?.Coding;
                bool? ezzzzzzzzzx_ = context.Operators.Not((bool?)(ezzzzzzzzzw_ is null));

                return ezzzzzzzzzx_;
            };
            IEnumerable<CodeableConcept> ezzzzzzzzzm_ = context.Operators.Where<CodeableConcept>(ezzzzzzzzzk_, ezzzzzzzzzl_);
            List<Coding> ezzzzzzzzzn_(CodeableConcept @this)
            {
                List<Coding> ezzzzzzzzzy_ = @this?.Coding;

                return ezzzzzzzzzy_;
            };
            IEnumerable<List<Coding>> ezzzzzzzzzo_ = context.Operators.Select<CodeableConcept, List<Coding>>(ezzzzzzzzzm_, ezzzzzzzzzn_);
            IEnumerable<Coding> ezzzzzzzzzp_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)ezzzzzzzzzo_);
            bool? ezzzzzzzzzq_(Coding ProductOrServiceCode)
            {
                CqlCode ezzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? fzzzzzzzzza_ = context.Operators.In<CqlCode>(ezzzzzzzzzz_, ProductOrServiceValueSet);

                return fzzzzzzzzza_;
            };
            IEnumerable<Coding> ezzzzzzzzzr_ = context.Operators.Where<Coding>(ezzzzzzzzzp_, ezzzzzzzzzq_);
            bool? ezzzzzzzzzs_ = context.Operators.Exists<Coding>(ezzzzzzzzzr_);

            return ezzzzzzzzzs_;
        };
        IEnumerable<Claim> ezzzzzzzzzc_ = context.Operators.Where<Claim>(claim, ezzzzzzzzzb_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ezzzzzzzzzd_(Claim AllClaims)
        {
            Id fzzzzzzzzzb_ = AllClaims?.IdElement;
            List<Claim.ItemComponent> fzzzzzzzzzc_ = AllClaims?.Item;
            bool? fzzzzzzzzzd_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept fzzzzzzzzzg_ = ResponseItem?.ProductOrService;
                List<Coding> fzzzzzzzzzh_ = fzzzzzzzzzg_?.Coding;
                bool? fzzzzzzzzzi_(Coding ProductOrServiceCode)
                {
                    CqlCode fzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? fzzzzzzzzzm_ = context.Operators.In<CqlCode>(fzzzzzzzzzl_, ProductOrServiceValueSet);

                    return fzzzzzzzzzm_;
                };
                IEnumerable<Coding> fzzzzzzzzzj_ = context.Operators.Where<Coding>((IEnumerable<Coding>)fzzzzzzzzzh_, fzzzzzzzzzi_);
                bool? fzzzzzzzzzk_ = context.Operators.Exists<Coding>(fzzzzzzzzzj_);

                return fzzzzzzzzzk_;
            };
            IEnumerable<Claim.ItemComponent> fzzzzzzzzze_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)fzzzzzzzzzc_, fzzzzzzzzzd_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? fzzzzzzzzzf_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, fzzzzzzzzzb_, fzzzzzzzzze_);

            return fzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ezzzzzzzzze_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(ezzzzzzzzzc_, ezzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ezzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(ezzzzzzzzze_);

        return ezzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> fzzzzzzzzzn_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> fzzzzzzzzzo_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? fzzzzzzzzzp_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, fzzzzzzzzzn_, fzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] fzzzzzzzzzq_ = [
            fzzzzzzzzzp_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> fzzzzzzzzzv_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? fzzzzzzzzzw_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> gzzzzzzzzzf_ = medClaim?.LineItems;
                bool? gzzzzzzzzzg_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> gzzzzzzzzzj_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> gzzzzzzzzzk_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> gzzzzzzzzzn_ = pClaim?.LineItems;
                        bool? gzzzzzzzzzo_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id gzzzzzzzzzs_()
                            {
                                bool hzzzzzzzzzg_()
                                {
                                    Claim hzzzzzzzzzh_ = medClaim?.ClaimofInterest;
                                    bool hzzzzzzzzzi_ = hzzzzzzzzzh_ is Resource;

                                    return hzzzzzzzzzi_;
                                };
                                if (hzzzzzzzzzg_())
                                {
                                    Claim hzzzzzzzzzj_ = medClaim?.ClaimofInterest;

                                    return (hzzzzzzzzzj_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string gzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzs_());
                            ClaimResponse gzzzzzzzzzu_ = pClaim?.Response;
                            ResourceReference gzzzzzzzzzv_ = gzzzzzzzzzu_?.Request;
                            FhirString gzzzzzzzzzw_ = gzzzzzzzzzv_?.ReferenceElement;
                            string gzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzw_);
                            string gzzzzzzzzzy_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, gzzzzzzzzzx_);
                            bool? gzzzzzzzzzz_ = context.Operators.Equal(gzzzzzzzzzt_, gzzzzzzzzzy_);
                            PositiveInt hzzzzzzzzza_ = medClaimLineItem?.SequenceElement;
                            Integer hzzzzzzzzzb_ = context.Operators.Convert<Integer>(hzzzzzzzzza_);
                            PositiveInt hzzzzzzzzzc_ = pClaimLineItem?.ItemSequenceElement;
                            Integer hzzzzzzzzzd_ = context.Operators.Convert<Integer>(hzzzzzzzzzc_);
                            bool? hzzzzzzzzze_ = context.Operators.Equal(hzzzzzzzzzb_, hzzzzzzzzzd_);
                            bool? hzzzzzzzzzf_ = context.Operators.And(gzzzzzzzzzz_, hzzzzzzzzze_);

                            return hzzzzzzzzzf_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> gzzzzzzzzzp_ = context.Operators.Where<ClaimResponse.ItemComponent>(gzzzzzzzzzn_, gzzzzzzzzzo_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? gzzzzzzzzzq_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> gzzzzzzzzzr_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(gzzzzzzzzzp_, gzzzzzzzzzq_);

                        return gzzzzzzzzzr_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> gzzzzzzzzzl_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(gzzzzzzzzzj_, gzzzzzzzzzk_);
                    bool? gzzzzzzzzzm_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(gzzzzzzzzzl_);

                    return gzzzzzzzzzm_;
                };
                IEnumerable<Claim.ItemComponent> gzzzzzzzzzh_ = context.Operators.Where<Claim.ItemComponent>(gzzzzzzzzzf_, gzzzzzzzzzg_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? gzzzzzzzzzi_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, gzzzzzzzzzh_);

                return gzzzzzzzzzi_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> fzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(fzzzzzzzzzv_, fzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> fzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(fzzzzzzzzzx_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? fzzzzzzzzzz_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, fzzzzzzzzzy_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] gzzzzzzzzza_ = [
                fzzzzzzzzzz_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzzzb_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzzk_()
                {
                    bool hzzzzzzzzzp_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> hzzzzzzzzzq_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? hzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzzx_ = @this?.ClaimItem;
                            bool? hzzzzzzzzzy_ = context.Operators.Not((bool?)(hzzzzzzzzzx_ is null));

                            return hzzzzzzzzzy_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> hzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(hzzzzzzzzzq_, hzzzzzzzzzr_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzzt_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzzz_ = @this?.ClaimItem;

                            return hzzzzzzzzzz_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> hzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(hzzzzzzzzzs_, hzzzzzzzzzt_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzzv_ = context.Operators.Flatten<Claim.ItemComponent>(hzzzzzzzzzu_);
                        bool? hzzzzzzzzzw_ = context.Operators.Exists<Claim.ItemComponent>(hzzzzzzzzzv_);

                        return hzzzzzzzzzw_ ?? false;
                    };
                    if (hzzzzzzzzzp_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> izzzzzzzzza_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? izzzzzzzzzb_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? izzzzzzzzzp_ = @this?.PaidClaim;
                            bool? izzzzzzzzzq_ = context.Operators.Not((bool?)(izzzzzzzzzp_ is null));

                            return izzzzzzzzzq_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> izzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(izzzzzzzzza_, izzzzzzzzzb_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? izzzzzzzzzd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? izzzzzzzzzr_ = @this?.PaidClaim;

                            return izzzzzzzzzr_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> izzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(izzzzzzzzzc_, izzzzzzzzzd_);
                        bool? izzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> izzzzzzzzzs_ = @this?.ClaimItem;
                            bool? izzzzzzzzzt_ = context.Operators.Not((bool?)(izzzzzzzzzs_ is null));

                            return izzzzzzzzzt_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> izzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(izzzzzzzzza_, izzzzzzzzzg_);
                        IEnumerable<Claim.ItemComponent> izzzzzzzzzi_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> izzzzzzzzzu_ = @this?.ClaimItem;

                            return izzzzzzzzzu_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> izzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(izzzzzzzzzh_, izzzzzzzzzi_);
                        IEnumerable<Claim.ItemComponent> izzzzzzzzzk_ = context.Operators.Flatten<Claim.ItemComponent>(izzzzzzzzzj_);
                        CqlInterval<CqlDateTime> izzzzzzzzzl_(Claim.ItemComponent PaidItem)
                        {
                            DataType izzzzzzzzzv_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> izzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzv_);

                            return izzzzzzzzzw_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzm_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(izzzzzzzzzk_, izzzzzzzzzl_);
                        IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(izzzzzzzzzm_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzzzzo_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, izzzzzzzzze_, izzzzzzzzzn_);

                        return izzzzzzzzzo_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] hzzzzzzzzzl_ = [
                    hzzzzzzzzzk_(),
                ];
                bool? hzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? izzzzzzzzzx_ = context.Operators.Not((bool?)(FinalList is null));

                    return izzzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)hzzzzzzzzzl_, hzzzzzzzzzm_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(hzzzzzzzzzn_);

                return hzzzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)gzzzzzzzzza_, gzzzzzzzzzb_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(gzzzzzzzzzc_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(gzzzzzzzzzd_);

            return gzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)fzzzzzzzzzq_, fzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzzzt_);

        return fzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? izzzzzzzzzy_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] izzzzzzzzzz_ = [
            izzzzzzzzzy_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzza_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzze_()
            {
                bool jzzzzzzzzzf_()
                {
                    IEnumerable<ClaimResponse> jzzzzzzzzzg_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> jzzzzzzzzzh_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? jzzzzzzzzzi_ = context.Operators.And((bool?)(jzzzzzzzzzg_ is null), (bool?)(jzzzzzzzzzh_ is null));

                    return jzzzzzzzzzi_ ?? false;
                };
                if (jzzzzzzzzzf_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> jzzzzzzzzzj_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> jzzzzzzzzzk_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzzl_ = this.Get_Corresponding_Claim_for_Services_Only(context, jzzzzzzzzzj_, jzzzzzzzzzk_, ProductOrServiceValueSet);

                    return jzzzzzzzzzl_;
                }
            };

            return jzzzzzzzzze_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)izzzzzzzzzz_, jzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzzc_);

        return jzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Get All Pharmacy Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> jzzzzzzzzzm_ = this.Pharmacy_Claims_Response(context, claimResponse);
        IEnumerable<Claim> jzzzzzzzzzn_ = this.Pharmacy_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? jzzzzzzzzzo_ = (CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV, jzzzzzzzzzm_, jzzzzzzzzzn_);

        return jzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzzp_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> jzzzzzzzzzq_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? jzzzzzzzzzr_ = (CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF, jzzzzzzzzzp_, jzzzzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[] jzzzzzzzzzs_ = [
            jzzzzzzzzzr_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? jzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> jzzzzzzzzzx_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? jzzzzzzzzzy_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> kzzzzzzzzzh_ = medClaim?.LineItem;
                bool? kzzzzzzzzzi_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> kzzzzzzzzzl_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> kzzzzzzzzzm_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> kzzzzzzzzzp_ = pClaim?.LineItems;
                        bool? kzzzzzzzzzq_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id kzzzzzzzzzu_()
                            {
                                bool lzzzzzzzzzi_()
                                {
                                    Claim lzzzzzzzzzj_ = medClaim?.Claim;
                                    bool lzzzzzzzzzk_ = lzzzzzzzzzj_ is Resource;

                                    return lzzzzzzzzzk_;
                                };
                                if (lzzzzzzzzzi_())
                                {
                                    Claim lzzzzzzzzzl_ = medClaim?.Claim;

                                    return (lzzzzzzzzzl_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string kzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzu_());
                            ClaimResponse kzzzzzzzzzw_ = pClaim?.Response;
                            ResourceReference kzzzzzzzzzx_ = kzzzzzzzzzw_?.Request;
                            FhirString kzzzzzzzzzy_ = kzzzzzzzzzx_?.ReferenceElement;
                            string kzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzy_);
                            string lzzzzzzzzza_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, kzzzzzzzzzz_);
                            bool? lzzzzzzzzzb_ = context.Operators.Equal(kzzzzzzzzzv_, lzzzzzzzzza_);
                            PositiveInt lzzzzzzzzzc_ = medClaimLineItem?.SequenceElement;
                            Integer lzzzzzzzzzd_ = context.Operators.Convert<Integer>(lzzzzzzzzzc_);
                            PositiveInt lzzzzzzzzze_ = pClaimLineItem?.ItemSequenceElement;
                            Integer lzzzzzzzzzf_ = context.Operators.Convert<Integer>(lzzzzzzzzze_);
                            bool? lzzzzzzzzzg_ = context.Operators.Equal(lzzzzzzzzzd_, lzzzzzzzzzf_);
                            bool? lzzzzzzzzzh_ = context.Operators.And(lzzzzzzzzzb_, lzzzzzzzzzg_);

                            return lzzzzzzzzzh_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> kzzzzzzzzzr_ = context.Operators.Where<ClaimResponse.ItemComponent>(kzzzzzzzzzp_, kzzzzzzzzzq_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? kzzzzzzzzzs_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> kzzzzzzzzzt_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(kzzzzzzzzzr_, kzzzzzzzzzs_);

                        return kzzzzzzzzzt_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> kzzzzzzzzzn_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(kzzzzzzzzzl_, kzzzzzzzzzm_);
                    bool? kzzzzzzzzzo_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(kzzzzzzzzzn_);

                    return kzzzzzzzzzo_;
                };
                IEnumerable<Claim.ItemComponent> kzzzzzzzzzj_ = context.Operators.Where<Claim.ItemComponent>(kzzzzzzzzzh_, kzzzzzzzzzi_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? kzzzzzzzzzk_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, kzzzzzzzzzj_);

                return kzzzzzzzzzk_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> jzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(jzzzzzzzzzx_, jzzzzzzzzzy_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> kzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(jzzzzzzzzzz_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? kzzzzzzzzzb_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, kzzzzzzzzza_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] kzzzzzzzzzc_ = [
                kzzzzzzzzzb_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? kzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? lzzzzzzzzzm_()
                {
                    bool lzzzzzzzzzr_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzs_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? lzzzzzzzzzt_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> lzzzzzzzzzz_ = @this?.ClaimItem;
                            bool? mzzzzzzzzza_ = context.Operators.Not((bool?)(lzzzzzzzzzz_ is null));

                            return mzzzzzzzzza_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(lzzzzzzzzzs_, lzzzzzzzzzt_);
                        IEnumerable<Claim.ItemComponent> lzzzzzzzzzv_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> mzzzzzzzzzb_ = @this?.ClaimItem;

                            return mzzzzzzzzzb_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> lzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(lzzzzzzzzzu_, lzzzzzzzzzv_);
                        IEnumerable<Claim.ItemComponent> lzzzzzzzzzx_ = context.Operators.Flatten<Claim.ItemComponent>(lzzzzzzzzzw_);
                        bool? lzzzzzzzzzy_ = context.Operators.Exists<Claim.ItemComponent>(lzzzzzzzzzx_);

                        return lzzzzzzzzzy_ ?? false;
                    };
                    if (lzzzzzzzzzr_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> mzzzzzzzzzc_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? mzzzzzzzzzd_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? nzzzzzzzzza_ = @this?.PaidClaim;
                            bool? nzzzzzzzzzb_ = context.Operators.Not((bool?)(nzzzzzzzzza_ is null));

                            return nzzzzzzzzzb_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> mzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(mzzzzzzzzzc_, mzzzzzzzzzd_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? mzzzzzzzzzf_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? nzzzzzzzzzc_ = @this?.PaidClaim;

                            return nzzzzzzzzzc_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> mzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(mzzzzzzzzze_, mzzzzzzzzzf_);
                        bool? mzzzzzzzzzi_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzd_ = @this?.ClaimItem;
                            bool? nzzzzzzzzze_ = context.Operators.Not((bool?)(nzzzzzzzzzd_ is null));

                            return nzzzzzzzzze_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> mzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(mzzzzzzzzzc_, mzzzzzzzzzi_);
                        IEnumerable<Claim.ItemComponent> mzzzzzzzzzk_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzf_ = @this?.ClaimItem;

                            return nzzzzzzzzzf_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> mzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(mzzzzzzzzzj_, mzzzzzzzzzk_);
                        IEnumerable<Claim.ItemComponent> mzzzzzzzzzm_ = context.Operators.Flatten<Claim.ItemComponent>(mzzzzzzzzzl_);
                        CqlInterval<CqlDateTime> mzzzzzzzzzn_(Claim.ItemComponent PaidItem)
                        {
                            DataType nzzzzzzzzzg_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> nzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, nzzzzzzzzzg_);

                            return nzzzzzzzzzh_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzo_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(mzzzzzzzzzm_, mzzzzzzzzzn_);
                        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(mzzzzzzzzzo_);
                        bool? mzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzi_ = @this?.ClaimItem;
                            bool? nzzzzzzzzzj_ = context.Operators.Not((bool?)(nzzzzzzzzzi_ is null));

                            return nzzzzzzzzzj_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> mzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(mzzzzzzzzzc_, mzzzzzzzzzr_);
                        IEnumerable<Claim.ItemComponent> mzzzzzzzzzt_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzk_ = @this?.ClaimItem;

                            return nzzzzzzzzzk_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> mzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(mzzzzzzzzzs_, mzzzzzzzzzt_);
                        IEnumerable<Claim.ItemComponent> mzzzzzzzzzv_ = context.Operators.Flatten<Claim.ItemComponent>(mzzzzzzzzzu_);
                        CqlInterval<CqlDate> mzzzzzzzzzw_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDate> nzzzzzzzzzl_()
                            {
                                bool nzzzzzzzzzm_()
                                {
                                    Quantity nzzzzzzzzzn_ = i?.Quantity;
                                    bool? nzzzzzzzzzo_ = context.Operators.Not((bool?)(nzzzzzzzzzn_ is null));

                                    return nzzzzzzzzzo_ ?? false;
                                };
                                if (nzzzzzzzzzm_())
                                {
                                    DataType nzzzzzzzzzp_ = i?.Serviced;
                                    CqlInterval<CqlDateTime> nzzzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, nzzzzzzzzzp_);
                                    CqlDateTime nzzzzzzzzzr_ = context.Operators.Start(nzzzzzzzzzq_);
                                    CqlDate nzzzzzzzzzs_ = context.Operators.ConvertDateTimeToDate(nzzzzzzzzzr_);
                                    CqlInterval<CqlDateTime> nzzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, nzzzzzzzzzp_);
                                    CqlDateTime nzzzzzzzzzv_ = context.Operators.Start(nzzzzzzzzzu_);
                                    Quantity nzzzzzzzzzw_ = i?.Quantity;
                                    FhirDecimal nzzzzzzzzzx_ = nzzzzzzzzzw_?.ValueElement;
                                    decimal? nzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, nzzzzzzzzzx_);
                                    CqlDateTime nzzzzzzzzzz_ = context.Operators.Add(nzzzzzzzzzv_, new CqlQuantity(nzzzzzzzzzy_, "day"));
                                    CqlQuantity ozzzzzzzzza_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime ozzzzzzzzzb_ = context.Operators.Subtract(nzzzzzzzzzz_, ozzzzzzzzza_);
                                    CqlDate ozzzzzzzzzc_ = context.Operators.ConvertDateTimeToDate(ozzzzzzzzzb_);
                                    CqlInterval<CqlDate> ozzzzzzzzzd_ = context.Operators.Interval(nzzzzzzzzzs_, ozzzzzzzzzc_, true, true);

                                    return ozzzzzzzzzd_;
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDate>;
                                }
                            };

                            return nzzzzzzzzzl_();
                        };
                        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzx_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(mzzzzzzzzzv_, mzzzzzzzzzw_);
                        IEnumerable<CqlInterval<CqlDate>> mzzzzzzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDate>>(mzzzzzzzzzx_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? mzzzzzzzzzz_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, mzzzzzzzzzg_, mzzzzzzzzzp_, mzzzzzzzzzy_);

                        return mzzzzzzzzzz_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] lzzzzzzzzzn_ = [
                    lzzzzzzzzzm_(),
                ];
                bool? lzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList)
                {
                    bool? ozzzzzzzzze_ = context.Operators.Not((bool?)(FinalList is null));

                    return ozzzzzzzzze_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> lzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)lzzzzzzzzzn_, lzzzzzzzzzo_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? lzzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(lzzzzzzzzzp_);

                return lzzzzzzzzzq_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> kzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)kzzzzzzzzzc_, kzzzzzzzzzd_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> kzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(kzzzzzzzzze_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? kzzzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(kzzzzzzzzzf_);

            return kzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> jzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)jzzzzzzzzzs_, jzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> jzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(jzzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? jzzzzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(jzzzzzzzzzv_);

        return jzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? ozzzzzzzzzf_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] ozzzzzzzzzg_ = [
            ozzzzzzzzzf_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ozzzzzzzzzh_((CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ozzzzzzzzzl_()
            {
                bool ozzzzzzzzzm_()
                {
                    IEnumerable<ClaimResponse> ozzzzzzzzzn_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> ozzzzzzzzzo_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    bool? ozzzzzzzzzp_ = context.Operators.And((bool?)(ozzzzzzzzzn_ is null), (bool?)(ozzzzzzzzzo_ is null));

                    return ozzzzzzzzzp_ ?? false;
                };
                if (ozzzzzzzzzm_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> ozzzzzzzzzq_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> ozzzzzzzzzr_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ozzzzzzzzzs_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, ozzzzzzzzzq_, ozzzzzzzzzr_, ProductOrServiceValueSet);

                    return ozzzzzzzzzs_;
                }
            };

            return ozzzzzzzzzl_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ozzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)ozzzzzzzzzg_, ozzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ozzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ozzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ozzzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ozzzzzzzzzj_);

        return ozzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Get Claim With Corresponding Claim Response")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? ozzzzzzzzzt_(Claim Claim)
        {
            bool? ozzzzzzzzzw_(ClaimResponse CR)
            {
                Id pzzzzzzzzzb_ = Claim?.IdElement;
                string pzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzb_);
                ResourceReference pzzzzzzzzzd_ = CR?.Request;
                FhirString pzzzzzzzzze_ = pzzzzzzzzzd_?.ReferenceElement;
                string pzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzze_);
                string pzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, pzzzzzzzzzf_);
                bool? pzzzzzzzzzh_ = context.Operators.Equal(pzzzzzzzzzc_, pzzzzzzzzzg_);

                return pzzzzzzzzzh_;
            };
            IEnumerable<ClaimResponse> ozzzzzzzzzx_ = context.Operators.Where<ClaimResponse>(claimResponse, ozzzzzzzzzw_);
            bool? ozzzzzzzzzy_(Claim C)
            {
                Id pzzzzzzzzzi_ = Claim?.IdElement;
                string pzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzi_);
                bool? pzzzzzzzzzk_(ClaimResponse CR)
                {
                    Id pzzzzzzzzzy_ = Claim?.IdElement;
                    string pzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzy_);
                    ResourceReference qzzzzzzzzza_ = CR?.Request;
                    FhirString qzzzzzzzzzb_ = qzzzzzzzzza_?.ReferenceElement;
                    string qzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzzb_);
                    string qzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, qzzzzzzzzzc_);
                    bool? qzzzzzzzzze_ = context.Operators.Equal(pzzzzzzzzzz_, qzzzzzzzzzd_);

                    return qzzzzzzzzze_;
                };
                IEnumerable<ClaimResponse> pzzzzzzzzzl_ = context.Operators.Where<ClaimResponse>(claimResponse, pzzzzzzzzzk_);
                bool? pzzzzzzzzzm_(ClaimResponse @this)
                {
                    ResourceReference qzzzzzzzzzf_ = @this?.Request;
                    bool? qzzzzzzzzzg_ = context.Operators.Not((bool?)(qzzzzzzzzzf_ is null));

                    return qzzzzzzzzzg_;
                };
                IEnumerable<ClaimResponse> pzzzzzzzzzn_ = context.Operators.Where<ClaimResponse>(pzzzzzzzzzl_, pzzzzzzzzzm_);
                ResourceReference pzzzzzzzzzo_(ClaimResponse @this)
                {
                    ResourceReference qzzzzzzzzzh_ = @this?.Request;

                    return qzzzzzzzzzh_;
                };
                IEnumerable<ResourceReference> pzzzzzzzzzp_ = context.Operators.Select<ClaimResponse, ResourceReference>(pzzzzzzzzzn_, pzzzzzzzzzo_);
                bool? pzzzzzzzzzq_(ResourceReference @this)
                {
                    FhirString qzzzzzzzzzi_ = @this?.ReferenceElement;
                    bool? qzzzzzzzzzj_ = context.Operators.Not((bool?)(qzzzzzzzzzi_ is null));

                    return qzzzzzzzzzj_;
                };
                IEnumerable<ResourceReference> pzzzzzzzzzr_ = context.Operators.Where<ResourceReference>(pzzzzzzzzzp_, pzzzzzzzzzq_);
                FhirString pzzzzzzzzzs_(ResourceReference @this)
                {
                    FhirString qzzzzzzzzzk_ = @this?.ReferenceElement;

                    return qzzzzzzzzzk_;
                };
                IEnumerable<FhirString> pzzzzzzzzzt_ = context.Operators.Select<ResourceReference, FhirString>(pzzzzzzzzzr_, pzzzzzzzzzs_);
                FhirString pzzzzzzzzzu_ = context.Operators.SingletonFrom<FhirString>(pzzzzzzzzzt_);
                string pzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzu_);
                string pzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, pzzzzzzzzzv_);
                bool? pzzzzzzzzzx_ = context.Operators.Equal(pzzzzzzzzzj_, pzzzzzzzzzw_);

                return pzzzzzzzzzx_;
            };
            IEnumerable<Claim> ozzzzzzzzzz_ = context.Operators.Where<Claim>(claim, ozzzzzzzzzy_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? pzzzzzzzzza_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, ozzzzzzzzzx_, ozzzzzzzzzz_);

            return pzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> ozzzzzzzzzu_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, ozzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> ozzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(ozzzzzzzzzu_);

        return ozzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim> claim)
    {
        IEnumerable<Claim> qzzzzzzzzzl_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? qzzzzzzzzzm_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, qzzzzzzzzzl_, default, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] qzzzzzzzzzn_ = [
            qzzzzzzzzzm_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? qzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithInpatientStay)
        {
            IEnumerable<Claim> qzzzzzzzzzs_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> rzzzzzzzzza_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? rzzzzzzzzzb_(Claim c)
                    {
                        List<Claim.ItemComponent> rzzzzzzzzzd_ = c?.Item;
                        bool? rzzzzzzzzze_(Claim.ItemComponent i)
                        {
                            CodeableConcept rzzzzzzzzzh_ = i?.Revenue;
                            CqlConcept rzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzzzzzzzzzh_);
                            CqlCode[] rzzzzzzzzzj_ = rzzzzzzzzzi_?.codes;
                            bool? rzzzzzzzzzk_(CqlCode rev)
                            {
                                string rzzzzzzzzzn_ = rev?.code;
                                CqlValueSet rzzzzzzzzzo_ = this.Inpatient_Stay(context);
                                bool? rzzzzzzzzzp_ = context.Operators.StringInValueSet(rzzzzzzzzzn_, rzzzzzzzzzo_);

                                return rzzzzzzzzzp_;
                            };
                            IEnumerable<CqlCode> rzzzzzzzzzl_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)rzzzzzzzzzj_, rzzzzzzzzzk_);
                            bool? rzzzzzzzzzm_ = context.Operators.Exists<CqlCode>(rzzzzzzzzzl_);

                            return rzzzzzzzzzm_;
                        };
                        IEnumerable<Claim.ItemComponent> rzzzzzzzzzf_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)rzzzzzzzzzd_, rzzzzzzzzze_);
                        bool? rzzzzzzzzzg_ = context.Operators.Exists<Claim.ItemComponent>(rzzzzzzzzzf_);

                        return rzzzzzzzzzg_;
                    };
                    IEnumerable<Claim> rzzzzzzzzzc_ = context.Operators.Where<Claim>(rzzzzzzzzza_, rzzzzzzzzzb_);

                    return rzzzzzzzzzc_;
                }
            };
            IEnumerable<Claim> qzzzzzzzzzt_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> rzzzzzzzzzq_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? rzzzzzzzzzr_(Claim c)
                    {
                        List<Claim.ItemComponent> rzzzzzzzzzt_ = c?.Item;
                        bool? rzzzzzzzzzu_(Claim.ItemComponent i)
                        {
                            CodeableConcept szzzzzzzzzd_ = i?.Revenue;
                            CqlConcept szzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, szzzzzzzzzd_);
                            CqlCode[] szzzzzzzzzf_ = szzzzzzzzze_?.codes;
                            bool? szzzzzzzzzg_(CqlCode rev)
                            {
                                string szzzzzzzzzj_ = rev?.code;
                                CqlValueSet szzzzzzzzzk_ = this.Nonacute_Inpatient_Stay(context);
                                bool? szzzzzzzzzl_ = context.Operators.StringInValueSet(szzzzzzzzzj_, szzzzzzzzzk_);

                                return szzzzzzzzzl_;
                            };
                            IEnumerable<CqlCode> szzzzzzzzzh_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)szzzzzzzzzf_, szzzzzzzzzg_);
                            bool? szzzzzzzzzi_ = context.Operators.Exists<CqlCode>(szzzzzzzzzh_);

                            return szzzzzzzzzi_;
                        };
                        IEnumerable<Claim.ItemComponent> rzzzzzzzzzv_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)rzzzzzzzzzt_, rzzzzzzzzzu_);
                        bool? rzzzzzzzzzw_ = context.Operators.Exists<Claim.ItemComponent>(rzzzzzzzzzv_);
                        CodeableConcept rzzzzzzzzzx_ = c?.SubType;
                        List<Coding> rzzzzzzzzzy_ = rzzzzzzzzzx_?.Coding;
                        bool? rzzzzzzzzzz_(Coding tob)
                        {
                            Code szzzzzzzzzm_ = tob?.CodeElement;
                            string szzzzzzzzzn_ = szzzzzzzzzm_?.Value;
                            CqlValueSet szzzzzzzzzo_ = this.Nonacute_Inpatient_Stay(context);
                            bool? szzzzzzzzzp_ = context.Operators.StringInValueSet(szzzzzzzzzn_, szzzzzzzzzo_);

                            return szzzzzzzzzp_;
                        };
                        IEnumerable<Coding> szzzzzzzzza_ = context.Operators.Where<Coding>((IEnumerable<Coding>)rzzzzzzzzzy_, rzzzzzzzzzz_);
                        bool? szzzzzzzzzb_ = context.Operators.Exists<Coding>(szzzzzzzzza_);
                        bool? szzzzzzzzzc_ = context.Operators.Or(rzzzzzzzzzw_, szzzzzzzzzb_);

                        return szzzzzzzzzc_;
                    };
                    IEnumerable<Claim> rzzzzzzzzzs_ = context.Operators.Where<Claim>(rzzzzzzzzzq_, rzzzzzzzzzr_);

                    return rzzzzzzzzzs_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? qzzzzzzzzzu_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, qzzzzzzzzzs_(), qzzzzzzzzzt_());
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] qzzzzzzzzzv_ = [
                qzzzzzzzzzu_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? qzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> szzzzzzzzzq_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> szzzzzzzzzr_ = LineItemDefinition?.NonacuteInpatientLineItems;
                IEnumerable<Claim> szzzzzzzzzs_(Claim nonAcuteInpatientStay)
                {
                    IEnumerable<Claim> tzzzzzzzzza_ = LineItemDefinition?.InpatientStayLineItems;
                    bool? tzzzzzzzzzb_(Claim inpatientStay)
                    {
                        Id tzzzzzzzzzf_ = nonAcuteInpatientStay?.IdElement;
                        Id tzzzzzzzzzg_ = inpatientStay?.IdElement;
                        bool? tzzzzzzzzzh_ = context.Operators.Equal(tzzzzzzzzzf_, tzzzzzzzzzg_);

                        return tzzzzzzzzzh_;
                    };
                    IEnumerable<Claim> tzzzzzzzzzc_ = context.Operators.Where<Claim>(tzzzzzzzzza_, tzzzzzzzzzb_);
                    Claim tzzzzzzzzzd_(Claim inpatientStay) =>
                        nonAcuteInpatientStay;
                    IEnumerable<Claim> tzzzzzzzzze_ = context.Operators.Select<Claim, Claim>(tzzzzzzzzzc_, tzzzzzzzzzd_);

                    return tzzzzzzzzze_;
                };
                IEnumerable<Claim> szzzzzzzzzt_ = context.Operators.SelectMany<Claim, Claim>(szzzzzzzzzr_, szzzzzzzzzs_);
                IEnumerable<Claim> szzzzzzzzzw_(Claim inpatientStay)
                {
                    IEnumerable<Claim> tzzzzzzzzzi_ = LineItemDefinition?.NonacuteInpatientLineItems;
                    bool? tzzzzzzzzzj_(Claim nonAcuteInpatientStay)
                    {
                        Id tzzzzzzzzzn_ = inpatientStay?.IdElement;
                        Id tzzzzzzzzzo_ = nonAcuteInpatientStay?.IdElement;
                        bool? tzzzzzzzzzp_ = context.Operators.Equal(tzzzzzzzzzn_, tzzzzzzzzzo_);

                        return tzzzzzzzzzp_;
                    };
                    IEnumerable<Claim> tzzzzzzzzzk_ = context.Operators.Where<Claim>(tzzzzzzzzzi_, tzzzzzzzzzj_);
                    Claim tzzzzzzzzzl_(Claim nonAcuteInpatientStay) =>
                        inpatientStay;
                    IEnumerable<Claim> tzzzzzzzzzm_ = context.Operators.Select<Claim, Claim>(tzzzzzzzzzk_, tzzzzzzzzzl_);

                    return tzzzzzzzzzm_;
                };
                IEnumerable<Claim> szzzzzzzzzx_ = context.Operators.SelectMany<Claim, Claim>(szzzzzzzzzq_, szzzzzzzzzw_);
                IEnumerable<Claim> szzzzzzzzzy_ = context.Operators.Except<Claim>(szzzzzzzzzq_, szzzzzzzzzx_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? szzzzzzzzzz_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, szzzzzzzzzq_, szzzzzzzzzt_, szzzzzzzzzy_);

                return szzzzzzzzzz_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> qzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)qzzzzzzzzzv_, qzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> qzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(qzzzzzzzzzx_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? qzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(qzzzzzzzzzy_);

            return qzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> qzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)qzzzzzzzzzn_, qzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> qzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(qzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? qzzzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(qzzzzzzzzzq_);

        return qzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Get Prescriber NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? tzzzzzzzzzq_(Claim C)
        {
            List<Claim.CareTeamComponent> tzzzzzzzzzz_ = C?.CareTeam;
            bool? uzzzzzzzzza_(Claim.CareTeamComponent ct)
            {
                PositiveInt uzzzzzzzzzq_ = ct?.SequenceElement;
                Integer uzzzzzzzzzr_ = context.Operators.Convert<Integer>(uzzzzzzzzzq_);
                int? uzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, uzzzzzzzzzr_);
                bool? uzzzzzzzzzt_ = context.Operators.Equal(uzzzzzzzzzs_, 1);

                return uzzzzzzzzzt_;
            };
            IEnumerable<Claim.CareTeamComponent> uzzzzzzzzzb_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)tzzzzzzzzzz_, uzzzzzzzzza_);
            bool? uzzzzzzzzzc_(Claim.CareTeamComponent @this)
            {
                ResourceReference uzzzzzzzzzu_ = @this?.Provider;
                bool? uzzzzzzzzzv_ = context.Operators.Not((bool?)(uzzzzzzzzzu_ is null));

                return uzzzzzzzzzv_;
            };
            IEnumerable<Claim.CareTeamComponent> uzzzzzzzzzd_ = context.Operators.Where<Claim.CareTeamComponent>(uzzzzzzzzzb_, uzzzzzzzzzc_);
            ResourceReference uzzzzzzzzze_(Claim.CareTeamComponent @this)
            {
                ResourceReference uzzzzzzzzzw_ = @this?.Provider;

                return uzzzzzzzzzw_;
            };
            IEnumerable<ResourceReference> uzzzzzzzzzf_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(uzzzzzzzzzd_, uzzzzzzzzze_);
            bool? uzzzzzzzzzh_(Claim.CareTeamComponent ct)
            {
                PositiveInt uzzzzzzzzzx_ = ct?.SequenceElement;
                Integer uzzzzzzzzzy_ = context.Operators.Convert<Integer>(uzzzzzzzzzx_);
                int? uzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, uzzzzzzzzzy_);
                bool? vzzzzzzzzza_ = context.Operators.Equal(uzzzzzzzzzz_, 1);

                return vzzzzzzzzza_;
            };
            IEnumerable<Claim.CareTeamComponent> uzzzzzzzzzi_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)tzzzzzzzzzz_, uzzzzzzzzzh_);
            bool? uzzzzzzzzzj_(Claim.CareTeamComponent @this)
            {
                ResourceReference vzzzzzzzzzb_ = @this?.Provider;
                bool? vzzzzzzzzzc_ = context.Operators.Not((bool?)(vzzzzzzzzzb_ is null));

                return vzzzzzzzzzc_;
            };
            IEnumerable<Claim.CareTeamComponent> uzzzzzzzzzk_ = context.Operators.Where<Claim.CareTeamComponent>(uzzzzzzzzzi_, uzzzzzzzzzj_);
            ResourceReference uzzzzzzzzzl_(Claim.CareTeamComponent @this)
            {
                ResourceReference vzzzzzzzzzd_ = @this?.Provider;

                return vzzzzzzzzzd_;
            };
            IEnumerable<ResourceReference> uzzzzzzzzzm_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(uzzzzzzzzzk_, uzzzzzzzzzl_);
            string uzzzzzzzzzn_(ResourceReference p)
            {
                FhirString vzzzzzzzzze_ = p?.ReferenceElement;
                FhirString[] vzzzzzzzzzf_ = [
                    vzzzzzzzzze_,
                ];
                string vzzzzzzzzzg_(FhirString r)
                {
                    string vzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string vzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, vzzzzzzzzzj_);

                    return vzzzzzzzzzk_;
                };
                IEnumerable<string> vzzzzzzzzzh_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)vzzzzzzzzzf_, vzzzzzzzzzg_);
                string vzzzzzzzzzi_ = context.Operators.SingletonFrom<string>(vzzzzzzzzzh_);

                return vzzzzzzzzzi_;
            };
            IEnumerable<string> uzzzzzzzzzo_ = context.Operators.Select<ResourceReference, string>(uzzzzzzzzzm_, uzzzzzzzzzn_);
            (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? uzzzzzzzzzp_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, uzzzzzzzzzf_, uzzzzzzzzzo_);

            return uzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> tzzzzzzzzzr_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, tzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> tzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(tzzzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? tzzzzzzzzzt_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, tzzzzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?[] tzzzzzzzzzu_ = [
            tzzzzzzzzzt_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? tzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ClaimProperties)
        {
            IEnumerable<Practitioner> vzzzzzzzzzl_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));
            bool? vzzzzzzzzzm_(Practitioner p)
            {
                Id vzzzzzzzzzu_ = p?.IdElement;
                string vzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzu_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> vzzzzzzzzzw_ = ClaimProperties?.CareTeams;
                bool? vzzzzzzzzzx_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> wzzzzzzzzzd_ = @this?.CareTeamsProviderID;
                    bool? wzzzzzzzzze_ = context.Operators.Not((bool?)(wzzzzzzzzzd_ is null));

                    return wzzzzzzzzze_;
                };
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> vzzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(vzzzzzzzzzw_, vzzzzzzzzzx_);
                IEnumerable<string> vzzzzzzzzzz_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> wzzzzzzzzzf_ = @this?.CareTeamsProviderID;

                    return wzzzzzzzzzf_;
                };
                IEnumerable<IEnumerable<string>> wzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(vzzzzzzzzzy_, vzzzzzzzzzz_);
                IEnumerable<string> wzzzzzzzzzb_ = context.Operators.Flatten<string>(wzzzzzzzzza_);
                bool? wzzzzzzzzzc_ = context.Operators.In<string>(vzzzzzzzzzv_, wzzzzzzzzzb_);

                return wzzzzzzzzzc_;
            };
            IEnumerable<Practitioner> vzzzzzzzzzn_ = context.Operators.Where<Practitioner>(vzzzzzzzzzl_, vzzzzzzzzzm_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? vzzzzzzzzzo_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, vzzzzzzzzzn_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?[] vzzzzzzzzzp_ = [
                vzzzzzzzzzo_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? vzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? PractitionerMatch)
            {
                IEnumerable<Practitioner> wzzzzzzzzzg_ = PractitionerMatch?.Practitioners;
                bool? wzzzzzzzzzh_(Practitioner P)
                {
                    bool? wzzzzzzzzzr_ = context.Operators.Not((bool?)(P is null));

                    return wzzzzzzzzzr_;
                };
                IEnumerable<Practitioner> wzzzzzzzzzi_ = context.Operators.Where<Practitioner>(wzzzzzzzzzg_, wzzzzzzzzzh_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? wzzzzzzzzzj_(Practitioner P)
                {
                    List<Identifier> wzzzzzzzzzs_ = P?.Identifier;
                    bool? wzzzzzzzzzt_(Identifier l)
                    {
                        FhirUri xzzzzzzzzze_ = l?.SystemElement;
                        string xzzzzzzzzzf_ = xzzzzzzzzze_?.Value;
                        bool? xzzzzzzzzzg_ = context.Operators.Equal(xzzzzzzzzzf_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept xzzzzzzzzzh_ = l?.Type;
                        CqlConcept xzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzzzzzzzh_);
                        CqlCode xzzzzzzzzzj_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept xzzzzzzzzzk_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzj_);
                        bool? xzzzzzzzzzl_ = context.Operators.Equivalent(xzzzzzzzzzi_, xzzzzzzzzzk_);
                        bool? xzzzzzzzzzm_ = context.Operators.And(xzzzzzzzzzg_, xzzzzzzzzzl_);
                        FhirString xzzzzzzzzzn_ = l?.ValueElement;
                        string xzzzzzzzzzo_ = xzzzzzzzzzn_?.Value;
                        bool? xzzzzzzzzzp_ = context.Operators.Not((bool?)(xzzzzzzzzzo_ is null));
                        bool? xzzzzzzzzzq_ = context.Operators.And(xzzzzzzzzzm_, xzzzzzzzzzp_);

                        return xzzzzzzzzzq_;
                    };
                    IEnumerable<Identifier> wzzzzzzzzzu_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)wzzzzzzzzzs_, wzzzzzzzzzt_);
                    FhirString wzzzzzzzzzv_(Identifier l)
                    {
                        FhirString xzzzzzzzzzr_ = l?.ValueElement;

                        return xzzzzzzzzzr_;
                    };
                    IEnumerable<FhirString> wzzzzzzzzzw_ = context.Operators.Select<Identifier, FhirString>(wzzzzzzzzzu_, wzzzzzzzzzv_);
                    IEnumerable<FhirString> wzzzzzzzzzx_ = context.Operators.Distinct<FhirString>(wzzzzzzzzzw_);
                    bool? wzzzzzzzzzz_(Identifier l)
                    {
                        FhirUri xzzzzzzzzzs_ = l?.SystemElement;
                        string xzzzzzzzzzt_ = xzzzzzzzzzs_?.Value;
                        bool? xzzzzzzzzzu_ = context.Operators.Equal(xzzzzzzzzzt_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept xzzzzzzzzzv_ = l?.Type;
                        CqlConcept xzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzzzzzzzv_);
                        CqlCode xzzzzzzzzzx_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept xzzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(xzzzzzzzzzx_);
                        bool? xzzzzzzzzzz_ = context.Operators.Equivalent(xzzzzzzzzzw_, xzzzzzzzzzy_);
                        bool? yzzzzzzzzza_ = context.Operators.And(xzzzzzzzzzu_, xzzzzzzzzzz_);
                        FhirString yzzzzzzzzzb_ = l?.ValueElement;
                        string yzzzzzzzzzc_ = yzzzzzzzzzb_?.Value;
                        bool? yzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzza_, (bool?)(yzzzzzzzzzc_ is null));

                        return yzzzzzzzzzd_;
                    };
                    IEnumerable<Identifier> xzzzzzzzzza_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)wzzzzzzzzzs_, wzzzzzzzzzz_);
                    Identifier xzzzzzzzzzb_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> xzzzzzzzzzc_ = context.Operators.Select<Identifier, Identifier>(xzzzzzzzzza_, xzzzzzzzzzb_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? xzzzzzzzzzd_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, wzzzzzzzzzx_, xzzzzzzzzzc_);

                    return xzzzzzzzzzd_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> wzzzzzzzzzk_ = context.Operators.Select<Practitioner, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(wzzzzzzzzzi_, wzzzzzzzzzj_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? wzzzzzzzzzl_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, wzzzzzzzzzk_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] wzzzzzzzzzm_ = [
                    wzzzzzzzzzl_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? wzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? yzzzzzzzzze_()
                    {
                        bool yzzzzzzzzzg_()
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> yzzzzzzzzzh_ = ClaimProperties?.CareTeams;
                            bool? yzzzzzzzzzi_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim yzzzzzzzzzn_ = @this?.SingleCareTeam;
                                bool? yzzzzzzzzzo_ = context.Operators.Not((bool?)(yzzzzzzzzzn_ is null));

                                return yzzzzzzzzzo_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> yzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(yzzzzzzzzzh_, yzzzzzzzzzi_);
                            Claim yzzzzzzzzzk_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim yzzzzzzzzzp_ = @this?.SingleCareTeam;

                                return yzzzzzzzzzp_;
                            };
                            IEnumerable<Claim> yzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(yzzzzzzzzzj_, yzzzzzzzzzk_);
                            bool? yzzzzzzzzzm_ = context.Operators.Exists<Claim>(yzzzzzzzzzl_);

                            return yzzzzzzzzzm_ ?? false;
                        };
                        if (yzzzzzzzzzg_())
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> yzzzzzzzzzq_ = ClaimProperties?.CareTeams;
                            bool? yzzzzzzzzzr_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim zzzzzzzzzzn_ = @this?.SingleCareTeam;
                                bool? zzzzzzzzzzo_ = context.Operators.Not((bool?)(zzzzzzzzzzn_ is null));

                                return zzzzzzzzzzo_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> yzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(yzzzzzzzzzq_, yzzzzzzzzzr_);
                            Claim yzzzzzzzzzt_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim zzzzzzzzzzp_ = @this?.SingleCareTeam;

                                return zzzzzzzzzzp_;
                            };
                            IEnumerable<Claim> yzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(yzzzzzzzzzs_, yzzzzzzzzzt_);
                            bool? yzzzzzzzzzv_(Claim X)
                            {
                                List<Claim.CareTeamComponent> zzzzzzzzzzq_ = X?.CareTeam;

                                return (bool?)(((IEnumerable<Claim.CareTeamComponent>)zzzzzzzzzzq_) is null);
                            };
                            IEnumerable<Claim> yzzzzzzzzzw_ = context.Operators.Where<Claim>(yzzzzzzzzzu_, yzzzzzzzzzv_);
                            int? yzzzzzzzzzx_ = context.Operators.Count<Claim>(yzzzzzzzzzw_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> yzzzzzzzzzy_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> yzzzzzzzzzz_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> zzzzzzzzzzr_ = X?.AllIdentifiers;

                                return zzzzzzzzzzr_;
                            };
                            IEnumerable<IEnumerable<FhirString>> zzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(yzzzzzzzzzy_, yzzzzzzzzzz_);
                            IEnumerable<FhirString> zzzzzzzzzzb_ = context.Operators.Flatten<FhirString>(zzzzzzzzzza_);
                            FhirString zzzzzzzzzzc_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> zzzzzzzzzzd_ = context.Operators.Select<FhirString, FhirString>(zzzzzzzzzzb_, zzzzzzzzzzc_);
                            IEnumerable<FhirString> zzzzzzzzzze_ = context.Operators.Distinct<FhirString>(zzzzzzzzzzd_);
                            int? zzzzzzzzzzf_ = context.Operators.Count<FhirString>(zzzzzzzzzze_);
                            int? zzzzzzzzzzg_ = context.Operators.Add(yzzzzzzzzzx_, zzzzzzzzzzf_);
                            IEnumerable<Identifier> zzzzzzzzzzi_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> zzzzzzzzzzs_ = X?.NullIdentifiers;

                                return zzzzzzzzzzs_;
                            };
                            IEnumerable<IEnumerable<Identifier>> zzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(yzzzzzzzzzy_, zzzzzzzzzzi_);
                            IEnumerable<Identifier> zzzzzzzzzzk_ = context.Operators.Flatten<Identifier>(zzzzzzzzzzj_);
                            int? zzzzzzzzzzl_ = context.Operators.Count<Identifier>(zzzzzzzzzzk_);
                            int? zzzzzzzzzzm_ = context.Operators.Add(zzzzzzzzzzg_, zzzzzzzzzzl_);

                            return zzzzzzzzzzm_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? yzzzzzzzzzf_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, yzzzzzzzzze_());

                    return yzzzzzzzzzf_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> wzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)wzzzzzzzzzm_, wzzzzzzzzzn_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> wzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(wzzzzzzzzzo_);
                (CqlTupleMetadata, int? IdentifierCount)? wzzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(wzzzzzzzzzp_);

                return wzzzzzzzzzq_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> vzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?>)vzzzzzzzzzp_, vzzzzzzzzzq_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> vzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(vzzzzzzzzzr_);
            (CqlTupleMetadata, int? IdentifierCount)? vzzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(vzzzzzzzzzs_);

            return vzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> tzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?>)tzzzzzzzzzu_, tzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> tzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(tzzzzzzzzzw_);
        (CqlTupleMetadata, int? IdentifierCount)? tzzzzzzzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(tzzzzzzzzzx_);

        return tzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Get Pharmacy NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? zzzzzzzzzzt_(Claim C)
        {
            List<Claim.ItemComponent> azzzzzzzzzzc_ = C?.Item;
            bool? azzzzzzzzzze_(Claim.ItemComponent i)
            {
                PositiveInt azzzzzzzzzzw_ = i?.SequenceElement;
                Integer azzzzzzzzzzx_ = context.Operators.Convert<Integer>(azzzzzzzzzzw_);
                int? azzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, azzzzzzzzzzx_);
                bool? azzzzzzzzzzz_ = context.Operators.Equal(azzzzzzzzzzy_, 1);

                return azzzzzzzzzzz_;
            };
            IEnumerable<Claim.ItemComponent> azzzzzzzzzzf_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)azzzzzzzzzzc_, azzzzzzzzzze_);
            bool? azzzzzzzzzzg_(Claim.ItemComponent @this)
            {
                DataType bzzzzzzzzzza_ = @this?.Location;
                bool? bzzzzzzzzzzb_ = context.Operators.Not((bool?)(bzzzzzzzzzza_ is null));

                return bzzzzzzzzzzb_;
            };
            IEnumerable<Claim.ItemComponent> azzzzzzzzzzh_ = context.Operators.Where<Claim.ItemComponent>(azzzzzzzzzzf_, azzzzzzzzzzg_);
            object azzzzzzzzzzi_(Claim.ItemComponent @this)
            {
                DataType bzzzzzzzzzzc_ = @this?.Location;

                return bzzzzzzzzzzc_;
            };
            IEnumerable<object> azzzzzzzzzzj_ = context.Operators.Select<Claim.ItemComponent, object>(azzzzzzzzzzh_, azzzzzzzzzzi_);
            ResourceReference azzzzzzzzzzk_(object l) =>
                l as ResourceReference;
            IEnumerable<ResourceReference> azzzzzzzzzzl_ = context.Operators.Select<object, ResourceReference>(azzzzzzzzzzj_, azzzzzzzzzzk_);
            bool? azzzzzzzzzzn_(Claim.ItemComponent i)
            {
                PositiveInt bzzzzzzzzzzd_ = i?.SequenceElement;
                Integer bzzzzzzzzzze_ = context.Operators.Convert<Integer>(bzzzzzzzzzzd_);
                int? bzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, bzzzzzzzzzze_);
                bool? bzzzzzzzzzzg_ = context.Operators.Equal(bzzzzzzzzzzf_, 1);

                return bzzzzzzzzzzg_;
            };
            IEnumerable<Claim.ItemComponent> azzzzzzzzzzo_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)azzzzzzzzzzc_, azzzzzzzzzzn_);
            bool? azzzzzzzzzzp_(Claim.ItemComponent @this)
            {
                DataType bzzzzzzzzzzh_ = @this?.Location;
                bool? bzzzzzzzzzzi_ = context.Operators.Not((bool?)(bzzzzzzzzzzh_ is null));

                return bzzzzzzzzzzi_;
            };
            IEnumerable<Claim.ItemComponent> azzzzzzzzzzq_ = context.Operators.Where<Claim.ItemComponent>(azzzzzzzzzzo_, azzzzzzzzzzp_);
            object azzzzzzzzzzr_(Claim.ItemComponent @this)
            {
                DataType bzzzzzzzzzzj_ = @this?.Location;

                return bzzzzzzzzzzj_;
            };
            IEnumerable<object> azzzzzzzzzzs_ = context.Operators.Select<Claim.ItemComponent, object>(azzzzzzzzzzq_, azzzzzzzzzzr_);
            string azzzzzzzzzzt_(object l)
            {
                FhirString bzzzzzzzzzzk_ = (l as ResourceReference)?.ReferenceElement;
                FhirString[] bzzzzzzzzzzl_ = [
                    bzzzzzzzzzzk_,
                ];
                string bzzzzzzzzzzm_(FhirString r)
                {
                    string bzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string bzzzzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, bzzzzzzzzzzp_);

                    return bzzzzzzzzzzq_;
                };
                IEnumerable<string> bzzzzzzzzzzn_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)bzzzzzzzzzzl_, bzzzzzzzzzzm_);
                string bzzzzzzzzzzo_ = context.Operators.SingletonFrom<string>(bzzzzzzzzzzn_);

                return bzzzzzzzzzzo_;
            };
            IEnumerable<string> azzzzzzzzzzu_ = context.Operators.Select<object, string>(azzzzzzzzzzs_, azzzzzzzzzzt_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? azzzzzzzzzzv_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent>)azzzzzzzzzzc_, azzzzzzzzzzl_, azzzzzzzzzzu_);

            return azzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> zzzzzzzzzzu_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, zzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> zzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(zzzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? zzzzzzzzzzw_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, zzzzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?[] zzzzzzzzzzx_ = [
            zzzzzzzzzzw_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? zzzzzzzzzzy_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? ClaimProperties)
        {
            IEnumerable<Location> bzzzzzzzzzzr_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
            bool? bzzzzzzzzzzs_(Location l)
            {
                Id czzzzzzzzzza_ = l?.IdElement;
                string czzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzza_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> czzzzzzzzzzc_ = ClaimProperties?.ItemsLocationReferences;
                bool? czzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> czzzzzzzzzzj_ = @this?.ItemLocationID;
                    bool? czzzzzzzzzzk_ = context.Operators.Not((bool?)(czzzzzzzzzzj_ is null));

                    return czzzzzzzzzzk_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> czzzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(czzzzzzzzzzc_, czzzzzzzzzzd_);
                IEnumerable<string> czzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> czzzzzzzzzzl_ = @this?.ItemLocationID;

                    return czzzzzzzzzzl_;
                };
                IEnumerable<IEnumerable<string>> czzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(czzzzzzzzzze_, czzzzzzzzzzf_);
                IEnumerable<string> czzzzzzzzzzh_ = context.Operators.Flatten<string>(czzzzzzzzzzg_);
                bool? czzzzzzzzzzi_ = context.Operators.In<string>(czzzzzzzzzzb_, czzzzzzzzzzh_);

                return czzzzzzzzzzi_;
            };
            IEnumerable<Location> bzzzzzzzzzzt_ = context.Operators.Where<Location>(bzzzzzzzzzzr_, bzzzzzzzzzzs_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? bzzzzzzzzzzu_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, bzzzzzzzzzzt_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?[] bzzzzzzzzzzv_ = [
                bzzzzzzzzzzu_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? bzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? GetLocation)
            {
                IEnumerable<Location> czzzzzzzzzzm_ = GetLocation?.CorrespondingLocations;
                bool? czzzzzzzzzzn_(Location C)
                {
                    bool? czzzzzzzzzzx_ = context.Operators.Not((bool?)(C is null));

                    return czzzzzzzzzzx_;
                };
                IEnumerable<Location> czzzzzzzzzzo_ = context.Operators.Where<Location>(czzzzzzzzzzm_, czzzzzzzzzzn_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? czzzzzzzzzzp_(Location C)
                {
                    List<Identifier> czzzzzzzzzzy_ = C?.Identifier;
                    bool? czzzzzzzzzzz_(Identifier l)
                    {
                        FhirUri dzzzzzzzzzzk_ = l?.SystemElement;
                        string dzzzzzzzzzzl_ = dzzzzzzzzzzk_?.Value;
                        bool? dzzzzzzzzzzm_ = context.Operators.Equal(dzzzzzzzzzzl_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept dzzzzzzzzzzn_ = l?.Type;
                        CqlConcept dzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, dzzzzzzzzzzn_);
                        CqlCode dzzzzzzzzzzp_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept dzzzzzzzzzzq_ = context.Operators.ConvertCodeToConcept(dzzzzzzzzzzp_);
                        bool? dzzzzzzzzzzr_ = context.Operators.Equivalent(dzzzzzzzzzzo_, dzzzzzzzzzzq_);
                        bool? dzzzzzzzzzzs_ = context.Operators.And(dzzzzzzzzzzm_, dzzzzzzzzzzr_);
                        FhirString dzzzzzzzzzzt_ = l?.ValueElement;
                        string dzzzzzzzzzzu_ = dzzzzzzzzzzt_?.Value;
                        bool? dzzzzzzzzzzv_ = context.Operators.Not((bool?)(dzzzzzzzzzzu_ is null));
                        bool? dzzzzzzzzzzw_ = context.Operators.And(dzzzzzzzzzzs_, dzzzzzzzzzzv_);

                        return dzzzzzzzzzzw_;
                    };
                    IEnumerable<Identifier> dzzzzzzzzzza_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)czzzzzzzzzzy_, czzzzzzzzzzz_);
                    FhirString dzzzzzzzzzzb_(Identifier l)
                    {
                        FhirString dzzzzzzzzzzx_ = l?.ValueElement;

                        return dzzzzzzzzzzx_;
                    };
                    IEnumerable<FhirString> dzzzzzzzzzzc_ = context.Operators.Select<Identifier, FhirString>(dzzzzzzzzzza_, dzzzzzzzzzzb_);
                    IEnumerable<FhirString> dzzzzzzzzzzd_ = context.Operators.Distinct<FhirString>(dzzzzzzzzzzc_);
                    bool? dzzzzzzzzzzf_(Identifier l)
                    {
                        FhirUri dzzzzzzzzzzy_ = l?.SystemElement;
                        string dzzzzzzzzzzz_ = dzzzzzzzzzzy_?.Value;
                        bool? ezzzzzzzzzza_ = context.Operators.Equal(dzzzzzzzzzzz_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept ezzzzzzzzzzb_ = l?.Type;
                        CqlConcept ezzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ezzzzzzzzzzb_);
                        CqlCode ezzzzzzzzzzd_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept ezzzzzzzzzze_ = context.Operators.ConvertCodeToConcept(ezzzzzzzzzzd_);
                        bool? ezzzzzzzzzzf_ = context.Operators.Equivalent(ezzzzzzzzzzc_, ezzzzzzzzzze_);
                        bool? ezzzzzzzzzzg_ = context.Operators.And(ezzzzzzzzzza_, ezzzzzzzzzzf_);
                        FhirString ezzzzzzzzzzh_ = l?.ValueElement;
                        string ezzzzzzzzzzi_ = ezzzzzzzzzzh_?.Value;
                        bool? ezzzzzzzzzzj_ = context.Operators.And(ezzzzzzzzzzg_, (bool?)(ezzzzzzzzzzi_ is null));

                        return ezzzzzzzzzzj_;
                    };
                    IEnumerable<Identifier> dzzzzzzzzzzg_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)czzzzzzzzzzy_, dzzzzzzzzzzf_);
                    Identifier dzzzzzzzzzzh_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> dzzzzzzzzzzi_ = context.Operators.Select<Identifier, Identifier>(dzzzzzzzzzzg_, dzzzzzzzzzzh_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? dzzzzzzzzzzj_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, dzzzzzzzzzzd_, dzzzzzzzzzzi_);

                    return dzzzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> czzzzzzzzzzq_ = context.Operators.Select<Location, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(czzzzzzzzzzo_, czzzzzzzzzzp_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? czzzzzzzzzzr_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, czzzzzzzzzzq_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] czzzzzzzzzzs_ = [
                    czzzzzzzzzzr_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? czzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? ezzzzzzzzzzk_()
                    {
                        bool ezzzzzzzzzzm_()
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ezzzzzzzzzzn_ = ClaimProperties?.ItemsLocationReferences;
                            bool? ezzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> ezzzzzzzzzzu_ = @this?.SingleItem;
                                bool? ezzzzzzzzzzv_ = context.Operators.Not((bool?)(ezzzzzzzzzzu_ is null));

                                return ezzzzzzzzzzv_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ezzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(ezzzzzzzzzzn_, ezzzzzzzzzzo_);
                            IEnumerable<Claim.ItemComponent> ezzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> ezzzzzzzzzzw_ = @this?.SingleItem;

                                return ezzzzzzzzzzw_;
                            };
                            IEnumerable<IEnumerable<Claim.ItemComponent>> ezzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(ezzzzzzzzzzp_, ezzzzzzzzzzq_);
                            IEnumerable<Claim.ItemComponent> ezzzzzzzzzzs_ = context.Operators.Flatten<Claim.ItemComponent>(ezzzzzzzzzzr_);
                            bool? ezzzzzzzzzzt_ = context.Operators.Exists<Claim.ItemComponent>(ezzzzzzzzzzs_);

                            return ezzzzzzzzzzt_ ?? false;
                        };
                        if (ezzzzzzzzzzm_())
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ezzzzzzzzzzx_ = ClaimProperties?.ItemsLocationReferences;
                            bool? ezzzzzzzzzzy_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> fzzzzzzzzzzv_ = @this?.ItemLocation;
                                bool? fzzzzzzzzzzw_ = context.Operators.Not((bool?)(fzzzzzzzzzzv_ is null));

                                return fzzzzzzzzzzw_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ezzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(ezzzzzzzzzzx_, ezzzzzzzzzzy_);
                            IEnumerable<ResourceReference> fzzzzzzzzzza_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> fzzzzzzzzzzx_ = @this?.ItemLocation;

                                return fzzzzzzzzzzx_;
                            };
                            IEnumerable<IEnumerable<ResourceReference>> fzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(ezzzzzzzzzzz_, fzzzzzzzzzza_);
                            IEnumerable<ResourceReference> fzzzzzzzzzzc_ = context.Operators.Flatten<ResourceReference>(fzzzzzzzzzzb_);
                            bool? fzzzzzzzzzzd_(ResourceReference X)
                            {
                                FhirString fzzzzzzzzzzy_ = X?.ReferenceElement;
                                string fzzzzzzzzzzz_ = fzzzzzzzzzzy_?.Value;

                                return (bool?)(fzzzzzzzzzzz_ is null);
                            };
                            IEnumerable<ResourceReference> fzzzzzzzzzze_ = context.Operators.Where<ResourceReference>(fzzzzzzzzzzc_, fzzzzzzzzzzd_);
                            int? fzzzzzzzzzzf_ = context.Operators.Count<ResourceReference>(fzzzzzzzzzze_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> fzzzzzzzzzzg_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> fzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> gzzzzzzzzzza_ = X?.AllIdentifiers;

                                return gzzzzzzzzzza_;
                            };
                            IEnumerable<IEnumerable<FhirString>> fzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(fzzzzzzzzzzg_, fzzzzzzzzzzh_);
                            IEnumerable<FhirString> fzzzzzzzzzzj_ = context.Operators.Flatten<FhirString>(fzzzzzzzzzzi_);
                            FhirString fzzzzzzzzzzk_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> fzzzzzzzzzzl_ = context.Operators.Select<FhirString, FhirString>(fzzzzzzzzzzj_, fzzzzzzzzzzk_);
                            IEnumerable<FhirString> fzzzzzzzzzzm_ = context.Operators.Distinct<FhirString>(fzzzzzzzzzzl_);
                            int? fzzzzzzzzzzn_ = context.Operators.Count<FhirString>(fzzzzzzzzzzm_);
                            int? fzzzzzzzzzzo_ = context.Operators.Add(fzzzzzzzzzzf_, fzzzzzzzzzzn_);
                            IEnumerable<Identifier> fzzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> gzzzzzzzzzzb_ = X?.NullIdentifiers;

                                return gzzzzzzzzzzb_;
                            };
                            IEnumerable<IEnumerable<Identifier>> fzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(fzzzzzzzzzzg_, fzzzzzzzzzzq_);
                            IEnumerable<Identifier> fzzzzzzzzzzs_ = context.Operators.Flatten<Identifier>(fzzzzzzzzzzr_);
                            int? fzzzzzzzzzzt_ = context.Operators.Count<Identifier>(fzzzzzzzzzzs_);
                            int? fzzzzzzzzzzu_ = context.Operators.Add(fzzzzzzzzzzo_, fzzzzzzzzzzt_);

                            return fzzzzzzzzzzu_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? ezzzzzzzzzzl_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, ezzzzzzzzzzk_());

                    return ezzzzzzzzzzl_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> czzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)czzzzzzzzzzs_, czzzzzzzzzzt_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> czzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(czzzzzzzzzzu_);
                (CqlTupleMetadata, int? IdentifierCount)? czzzzzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(czzzzzzzzzzv_);

                return czzzzzzzzzzw_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?>)bzzzzzzzzzzv_, bzzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> bzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(bzzzzzzzzzzx_);
            (CqlTupleMetadata, int? IdentifierCount)? bzzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(bzzzzzzzzzzy_);

            return bzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> zzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?>)zzzzzzzzzzx_, zzzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> azzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(zzzzzzzzzzz_);
        (CqlTupleMetadata, int? IdentifierCount)? azzzzzzzzzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(azzzzzzzzzza_);

        return azzzzzzzzzzb_;
    }


    #endregion Expressions

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
