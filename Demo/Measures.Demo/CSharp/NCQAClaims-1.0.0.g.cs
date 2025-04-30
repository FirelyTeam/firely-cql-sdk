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
        bool? gzzzzzzzr_(Claim MedicalClaim)
        {
            CodeableConcept gzzzzzzzt_ = MedicalClaim?.Type;
            CqlConcept gzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzt_);
            CqlCode[] gzzzzzzzv_ = gzzzzzzzu_?.codes;
            CqlCode gzzzzzzzw_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? gzzzzzzzx_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)gzzzzzzzv_, gzzzzzzzw_);
            CqlConcept gzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzt_);
            CqlCode[] hzzzzzzza_ = gzzzzzzzz_?.codes;
            CqlCode hzzzzzzzb_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? hzzzzzzzc_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)hzzzzzzza_, hzzzzzzzb_);
            bool? hzzzzzzzd_ = context.Operators.Or(gzzzzzzzx_, hzzzzzzzc_);

            return hzzzzzzzd_;
        };
        IEnumerable<Claim> gzzzzzzzs_ = context.Operators.Where<Claim>(claim, gzzzzzzzr_);

        return gzzzzzzzs_;
    }


    [CqlExpressionDefinition("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? hzzzzzzze_(Claim PharmacyClaim)
        {
            CodeableConcept hzzzzzzzg_ = PharmacyClaim?.Type;
            CqlConcept hzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, hzzzzzzzg_);
            CqlCode[] hzzzzzzzi_ = hzzzzzzzh_?.codes;
            CqlCode hzzzzzzzj_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? hzzzzzzzk_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)hzzzzzzzi_, hzzzzzzzj_);

            return hzzzzzzzk_;
        };
        IEnumerable<Claim> hzzzzzzzf_ = context.Operators.Where<Claim>(claim, hzzzzzzze_);

        return hzzzzzzzf_;
    }


    [CqlExpressionDefinition("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? hzzzzzzzl_(ClaimResponse MedicalResponse)
        {
            CodeableConcept hzzzzzzzn_ = MedicalResponse?.Type;
            CqlConcept hzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, hzzzzzzzn_);
            CqlCode[] hzzzzzzzp_ = hzzzzzzzo_?.codes;
            CqlCode hzzzzzzzq_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? hzzzzzzzr_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)hzzzzzzzp_, hzzzzzzzq_);
            CqlConcept hzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, hzzzzzzzn_);
            CqlCode[] hzzzzzzzu_ = hzzzzzzzt_?.codes;
            CqlCode hzzzzzzzv_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? hzzzzzzzw_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)hzzzzzzzu_, hzzzzzzzv_);
            bool? hzzzzzzzx_ = context.Operators.Or(hzzzzzzzr_, hzzzzzzzw_);

            return hzzzzzzzx_;
        };
        IEnumerable<ClaimResponse> hzzzzzzzm_ = context.Operators.Where<ClaimResponse>(claimResponse, hzzzzzzzl_);

        return hzzzzzzzm_;
    }


    [CqlExpressionDefinition("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? hzzzzzzzy_(ClaimResponse PharmacyResponse)
        {
            CodeableConcept izzzzzzza_ = PharmacyResponse?.Type;
            CqlConcept izzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, izzzzzzza_);
            CqlCode[] izzzzzzzc_ = izzzzzzzb_?.codes;
            CqlCode izzzzzzzd_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? izzzzzzze_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)izzzzzzzc_, izzzzzzzd_);

            return izzzzzzze_;
        };
        IEnumerable<ClaimResponse> hzzzzzzzz_ = context.Operators.Where<ClaimResponse>(claimResponse, hzzzzzzzy_);

        return hzzzzzzzz_;
    }


    [CqlExpressionDefinition("Medical Claims With Procedure and POS")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> izzzzzzzf_ = this.Professional_or_Institutional_Claims(context, claim);
        string izzzzzzzg_(CqlCode p)
        {
            string izzzzzzzs_ = p?.code;

            return izzzzzzzs_;
        };
        IEnumerable<string> izzzzzzzh_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, izzzzzzzg_);
        IEnumerable<string> izzzzzzzi_ = context.Operators.Distinct<string>(izzzzzzzh_);
        string izzzzzzzj_(CqlCode pos)
        {
            string izzzzzzzt_ = pos?.code;

            return izzzzzzzt_;
        };
        IEnumerable<string> izzzzzzzk_ = context.Operators.Select<CqlCode, string>(posCodes, izzzzzzzj_);
        IEnumerable<string> izzzzzzzl_ = context.Operators.Distinct<string>(izzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? izzzzzzzm_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, izzzzzzzf_, izzzzzzzi_, izzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] izzzzzzzn_ = [
            izzzzzzzm_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode)
        {
            IEnumerable<Claim> izzzzzzzu_ = ClaimWithPosCode?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzzv_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> jzzzzzzza_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> jzzzzzzzh_ = ClaimofInterest?.Item;
                        bool? jzzzzzzzi_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept jzzzzzzzk_ = ItemOnLine?.ProductOrService;
                            CqlConcept jzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, jzzzzzzzk_);
                            CqlCode[] jzzzzzzzm_ = jzzzzzzzl_?.codes;
                            bool? jzzzzzzzn_(CqlCode LineCode)
                            {
                                string jzzzzzzzx_ = LineCode?.code;
                                IEnumerable<string> jzzzzzzzy_ = ClaimWithPosCode?.ProceduresAsStrings;
                                bool? jzzzzzzzz_ = context.Operators.In<string>(jzzzzzzzx_, jzzzzzzzy_);

                                return jzzzzzzzz_;
                            };
                            IEnumerable<CqlCode> jzzzzzzzo_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)jzzzzzzzm_, jzzzzzzzn_);
                            bool? jzzzzzzzp_ = context.Operators.Exists<CqlCode>(jzzzzzzzo_);
                            DataType jzzzzzzzq_ = ItemOnLine?.Location;
                            CqlConcept jzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, jzzzzzzzq_ as CodeableConcept);
                            CqlCode[] jzzzzzzzs_ = jzzzzzzzr_?.codes;
                            bool? jzzzzzzzt_(CqlCode PosCode)
                            {
                                string kzzzzzzza_ = PosCode?.code;
                                IEnumerable<string> kzzzzzzzb_ = ClaimWithPosCode?.POSAsString;
                                bool? kzzzzzzzc_ = context.Operators.In<string>(kzzzzzzza_, kzzzzzzzb_);

                                return kzzzzzzzc_;
                            };
                            IEnumerable<CqlCode> jzzzzzzzu_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)jzzzzzzzs_, jzzzzzzzt_);
                            bool? jzzzzzzzv_ = context.Operators.Exists<CqlCode>(jzzzzzzzu_);
                            bool? jzzzzzzzw_ = context.Operators.And(jzzzzzzzp_, jzzzzzzzv_);

                            return jzzzzzzzw_;
                        };
                        IEnumerable<Claim.ItemComponent> jzzzzzzzj_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)jzzzzzzzh_, jzzzzzzzi_);

                        return jzzzzzzzj_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? jzzzzzzzb_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, jzzzzzzza_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] jzzzzzzzc_ = [
                    jzzzzzzzb_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzd_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? kzzzzzzzd_()
                    {
                        bool kzzzzzzze_()
                        {
                            IEnumerable<Claim.ItemComponent> kzzzzzzzf_ = LineItemDefinition?.LineItems;
                            bool? kzzzzzzzg_ = context.Operators.Exists<Claim.ItemComponent>(kzzzzzzzf_);

                            return kzzzzzzzg_ ?? false;
                        };
                        if (kzzzzzzze_())
                        {
                            Claim kzzzzzzzh_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> kzzzzzzzi_ = LineItemDefinition?.LineItems;
                            bool? kzzzzzzzj_(Claim.ItemComponent @this)
                            {
                                DataType kzzzzzzzr_ = @this?.Serviced;
                                bool? kzzzzzzzs_ = context.Operators.Not((bool?)(kzzzzzzzr_ is null));

                                return kzzzzzzzs_;
                            };
                            IEnumerable<Claim.ItemComponent> kzzzzzzzk_ = context.Operators.Where<Claim.ItemComponent>(kzzzzzzzi_, kzzzzzzzj_);
                            object kzzzzzzzl_(Claim.ItemComponent @this)
                            {
                                DataType kzzzzzzzt_ = @this?.Serviced;

                                return kzzzzzzzt_;
                            };
                            IEnumerable<object> kzzzzzzzm_ = context.Operators.Select<Claim.ItemComponent, object>(kzzzzzzzk_, kzzzzzzzl_);
                            CqlInterval<CqlDateTime> kzzzzzzzn_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> kzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return kzzzzzzzu_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzo_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(kzzzzzzzm_, kzzzzzzzn_);
                            IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzp_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(kzzzzzzzo_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? kzzzzzzzq_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, kzzzzzzzh_, kzzzzzzzp_);

                            return kzzzzzzzq_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return kzzzzzzzd_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)jzzzzzzzc_, jzzzzzzzd_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzze_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzf_);

                return jzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzzw_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzzu_, izzzzzzzv_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzzw_);
            bool? izzzzzzzy_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? kzzzzzzzv_ = context.Operators.Not((bool?)(FinalList is null));

                return kzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzzx_, izzzzzzzy_);

            return izzzzzzzz_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> izzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)izzzzzzzn_, izzzzzzzo_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> izzzzzzzq_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(izzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzzr_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(izzzzzzzq_);

        return izzzzzzzr_;
    }


    [CqlExpressionDefinition("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> kzzzzzzzw_ = this.Professional_or_Institutional_Claims(context, claim);
        string kzzzzzzzx_(CqlCode p)
        {
            string lzzzzzzzg_ = p?.code;

            return lzzzzzzzg_;
        };
        IEnumerable<string> kzzzzzzzy_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, kzzzzzzzx_);
        IEnumerable<string> kzzzzzzzz_ = context.Operators.Distinct<string>(kzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? lzzzzzzza_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, kzzzzzzzw_, kzzzzzzzz_, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] lzzzzzzzb_ = [
            lzzzzzzza_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzc_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithProcedure)
        {
            IEnumerable<Claim> lzzzzzzzh_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? lzzzzzzzi_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> lzzzzzzzn_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> lzzzzzzzu_ = ClaimofInterest?.Item;
                        bool? lzzzzzzzv_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept lzzzzzzzx_ = ItemOnLine?.ProductOrService;
                            CqlConcept lzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzx_);
                            CqlCode[] lzzzzzzzz_ = lzzzzzzzy_?.codes;
                            bool? mzzzzzzza_(CqlCode LineCode)
                            {
                                string mzzzzzzzt_ = LineCode?.code;
                                IEnumerable<string> mzzzzzzzu_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? mzzzzzzzv_ = context.Operators.In<string>(mzzzzzzzt_, mzzzzzzzu_);

                                return mzzzzzzzv_;
                            };
                            IEnumerable<CqlCode> mzzzzzzzb_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)lzzzzzzzz_, mzzzzzzza_);
                            bool? mzzzzzzzc_ = context.Operators.Exists<CqlCode>(mzzzzzzzb_);
                            List<Claim.ProcedureComponent> mzzzzzzzd_ = ClaimofInterest?.Procedure;
                            bool? mzzzzzzze_(Claim.ProcedureComponent @this)
                            {
                                DataType mzzzzzzzw_ = @this?.Procedure;
                                bool? mzzzzzzzx_ = context.Operators.Not((bool?)(mzzzzzzzw_ is null));

                                return mzzzzzzzx_;
                            };
                            IEnumerable<Claim.ProcedureComponent> mzzzzzzzf_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)mzzzzzzzd_, mzzzzzzze_);
                            object mzzzzzzzg_(Claim.ProcedureComponent @this)
                            {
                                DataType mzzzzzzzy_ = @this?.Procedure;

                                return mzzzzzzzy_;
                            };
                            IEnumerable<object> mzzzzzzzh_ = context.Operators.Select<Claim.ProcedureComponent, object>(mzzzzzzzf_, mzzzzzzzg_);
                            bool? mzzzzzzzi_(object @this)
                            {
                                object mzzzzzzzz_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? nzzzzzzza_ = context.Operators.Not((bool?)(mzzzzzzzz_ is null));

                                return nzzzzzzza_;
                            };
                            IEnumerable<object> mzzzzzzzj_ = context.Operators.Where<object>(mzzzzzzzh_, mzzzzzzzi_);
                            object mzzzzzzzk_(object @this)
                            {
                                object nzzzzzzzb_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return nzzzzzzzb_;
                            };
                            IEnumerable<object> mzzzzzzzl_ = context.Operators.Select<object, object>(mzzzzzzzj_, mzzzzzzzk_);
                            IEnumerable<object> mzzzzzzzm_ = context.Operators.FlattenLateBoundList(mzzzzzzzl_);
                            Coding mzzzzzzzn_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> mzzzzzzzo_ = context.Operators.Select<object, Coding>(mzzzzzzzm_, mzzzzzzzn_);
                            bool? mzzzzzzzp_(Coding HeaderCode)
                            {
                                Code nzzzzzzzc_ = HeaderCode?.CodeElement;
                                string nzzzzzzzd_ = nzzzzzzzc_?.Value;
                                IEnumerable<string> nzzzzzzze_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? nzzzzzzzf_ = context.Operators.In<string>(nzzzzzzzd_, nzzzzzzze_);

                                return nzzzzzzzf_;
                            };
                            IEnumerable<Coding> mzzzzzzzq_ = context.Operators.Where<Coding>(mzzzzzzzo_, mzzzzzzzp_);
                            bool? mzzzzzzzr_ = context.Operators.Exists<Coding>(mzzzzzzzq_);
                            bool? mzzzzzzzs_ = context.Operators.Or(mzzzzzzzc_, mzzzzzzzr_);

                            return mzzzzzzzs_;
                        };
                        IEnumerable<Claim.ItemComponent> lzzzzzzzw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)lzzzzzzzu_, lzzzzzzzv_);

                        return lzzzzzzzw_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? lzzzzzzzo_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, lzzzzzzzn_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] lzzzzzzzp_ = [
                    lzzzzzzzo_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? lzzzzzzzq_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzg_()
                    {
                        bool nzzzzzzzh_()
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzi_ = LineItemDefinition?.LineItems;
                            bool? nzzzzzzzj_ = context.Operators.Exists<Claim.ItemComponent>(nzzzzzzzi_);

                            return nzzzzzzzj_ ?? false;
                        };
                        if (nzzzzzzzh_())
                        {
                            Claim nzzzzzzzk_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> nzzzzzzzl_ = LineItemDefinition?.LineItems;
                            bool? nzzzzzzzm_(Claim.ItemComponent @this)
                            {
                                DataType nzzzzzzzu_ = @this?.Serviced;
                                bool? nzzzzzzzv_ = context.Operators.Not((bool?)(nzzzzzzzu_ is null));

                                return nzzzzzzzv_;
                            };
                            IEnumerable<Claim.ItemComponent> nzzzzzzzn_ = context.Operators.Where<Claim.ItemComponent>(nzzzzzzzl_, nzzzzzzzm_);
                            object nzzzzzzzo_(Claim.ItemComponent @this)
                            {
                                DataType nzzzzzzzw_ = @this?.Serviced;

                                return nzzzzzzzw_;
                            };
                            IEnumerable<object> nzzzzzzzp_ = context.Operators.Select<Claim.ItemComponent, object>(nzzzzzzzn_, nzzzzzzzo_);
                            CqlInterval<CqlDateTime> nzzzzzzzq_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> nzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return nzzzzzzzx_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzr_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(nzzzzzzzp_, nzzzzzzzq_);
                            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzr_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzt_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, nzzzzzzzk_, nzzzzzzzs_);

                            return nzzzzzzzt_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return nzzzzzzzg_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)lzzzzzzzp_, lzzzzzzzq_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(lzzzzzzzr_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? lzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(lzzzzzzzs_);

                return lzzzzzzzt_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzj_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(lzzzzzzzh_, lzzzzzzzi_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(lzzzzzzzj_);
            bool? lzzzzzzzl_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? nzzzzzzzy_ = context.Operators.Not((bool?)(FinalList is null));

                return nzzzzzzzy_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(lzzzzzzzk_, lzzzzzzzl_);

            return lzzzzzzzm_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> lzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)lzzzzzzzb_, lzzzzzzzc_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> lzzzzzzze_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(lzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzf_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(lzzzzzzze_);

        return lzzzzzzzf_;
    }


    [CqlExpressionDefinition("Medical Claims With Diagnosis")]
    public (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> nzzzzzzzz_ = this.Professional_or_Institutional_Claims(context, claim);
        string ozzzzzzza_(CqlCode d)
        {
            string ozzzzzzzj_ = d?.code;

            return ozzzzzzzj_;
        };
        IEnumerable<string> ozzzzzzzb_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, ozzzzzzza_);
        IEnumerable<string> ozzzzzzzc_ = context.Operators.Distinct<string>(ozzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ozzzzzzzd_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, nzzzzzzzz_, ozzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] ozzzzzzze_ = [
            ozzzzzzzd_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzf_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> ozzzzzzzk_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> ozzzzzzzr_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? ozzzzzzzs_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> ozzzzzzzu_ = DiagnosisLine?.Diagnosis;
                        bool? ozzzzzzzv_(Claim.DiagnosisComponent @this)
                        {
                            DataType pzzzzzzzj_ = @this?.Diagnosis;
                            bool? pzzzzzzzk_ = context.Operators.Not((bool?)(pzzzzzzzj_ is null));

                            return pzzzzzzzk_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> ozzzzzzzw_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)ozzzzzzzu_, ozzzzzzzv_);
                        object ozzzzzzzx_(Claim.DiagnosisComponent @this)
                        {
                            DataType pzzzzzzzl_ = @this?.Diagnosis;

                            return pzzzzzzzl_;
                        };
                        IEnumerable<object> ozzzzzzzy_ = context.Operators.Select<Claim.DiagnosisComponent, object>(ozzzzzzzw_, ozzzzzzzx_);
                        bool? ozzzzzzzz_(object @this)
                        {
                            object pzzzzzzzm_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? pzzzzzzzn_ = context.Operators.Not((bool?)(pzzzzzzzm_ is null));

                            return pzzzzzzzn_;
                        };
                        IEnumerable<object> pzzzzzzza_ = context.Operators.Where<object>(ozzzzzzzy_, ozzzzzzzz_);
                        object pzzzzzzzb_(object @this)
                        {
                            object pzzzzzzzo_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return pzzzzzzzo_;
                        };
                        IEnumerable<object> pzzzzzzzc_ = context.Operators.Select<object, object>(pzzzzzzza_, pzzzzzzzb_);
                        IEnumerable<object> pzzzzzzzd_ = context.Operators.FlattenLateBoundList(pzzzzzzzc_);
                        Coding pzzzzzzze_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> pzzzzzzzf_ = context.Operators.Select<object, Coding>(pzzzzzzzd_, pzzzzzzze_);
                        bool? pzzzzzzzg_(Coding HeaderCode)
                        {
                            Code pzzzzzzzp_ = HeaderCode?.CodeElement;
                            string pzzzzzzzq_ = pzzzzzzzp_?.Value;
                            IEnumerable<string> pzzzzzzzr_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? pzzzzzzzs_ = context.Operators.In<string>(pzzzzzzzq_, pzzzzzzzr_);

                            return pzzzzzzzs_;
                        };
                        IEnumerable<Coding> pzzzzzzzh_ = context.Operators.Where<Coding>(pzzzzzzzf_, pzzzzzzzg_);
                        bool? pzzzzzzzi_ = context.Operators.Exists<Coding>(pzzzzzzzh_);

                        return pzzzzzzzi_;
                    };
                    IEnumerable<Claim> ozzzzzzzt_ = context.Operators.Where<Claim>(ozzzzzzzr_, ozzzzzzzs_);

                    return ozzzzzzzt_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ozzzzzzzl_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, ozzzzzzzk_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] ozzzzzzzm_ = [
                ozzzzzzzl_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzn_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? HeaderDefinition)
            {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzt_()
                {
                    bool pzzzzzzzy_()
                    {
                        IEnumerable<Claim> pzzzzzzzz_ = HeaderDefinition?.DiagnosisItems;
                        bool? qzzzzzzza_ = context.Operators.Exists<Claim>(pzzzzzzzz_);

                        return qzzzzzzza_ ?? false;
                    };
                    if (pzzzzzzzy_())
                    {
                        IEnumerable<Claim> qzzzzzzzb_ = HeaderDefinition?.DiagnosisItems;
                        bool? qzzzzzzzd_(Claim @this)
                        {
                            List<Claim.ItemComponent> qzzzzzzzm_ = @this?.Item;
                            bool? qzzzzzzzn_ = context.Operators.Not((bool?)(qzzzzzzzm_ is null));

                            return qzzzzzzzn_;
                        };
                        IEnumerable<Claim> qzzzzzzze_ = context.Operators.Where<Claim>(qzzzzzzzb_, qzzzzzzzd_);
                        List<Claim.ItemComponent> qzzzzzzzf_(Claim @this)
                        {
                            List<Claim.ItemComponent> qzzzzzzzo_ = @this?.Item;

                            return qzzzzzzzo_;
                        };
                        IEnumerable<List<Claim.ItemComponent>> qzzzzzzzg_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(qzzzzzzze_, qzzzzzzzf_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzh_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)qzzzzzzzg_);
                        CqlInterval<CqlDateTime> qzzzzzzzi_(Claim.ItemComponent NormalDate)
                        {
                            DataType qzzzzzzzp_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> qzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, qzzzzzzzp_);

                            return qzzzzzzzq_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzj_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(qzzzzzzzh_, qzzzzzzzi_);
                        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzzzzzj_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzl_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, qzzzzzzzb_, qzzzzzzzk_);

                        return qzzzzzzzl_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] pzzzzzzzu_ = [
                    pzzzzzzzt_(),
                ];
                bool? pzzzzzzzv_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? qzzzzzzzr_ = context.Operators.Not((bool?)(FinalList is null));

                    return qzzzzzzzr_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)pzzzzzzzu_, pzzzzzzzv_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzzw_);

                return pzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)ozzzzzzzm_, ozzzzzzzn_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzo_);
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzp_);

            return ozzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)ozzzzzzze_, ozzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzh_);

        return ozzzzzzzi_;
    }


    [CqlExpressionDefinition("Pharmacy Claim With Medication")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        IEnumerable<Claim> qzzzzzzzs_ = this.Pharmacy_Claims(context, claim);
        string qzzzzzzzt_(CqlCode p)
        {
            string rzzzzzzzb_ = p?.code;

            return rzzzzzzzb_;
        };
        IEnumerable<string> qzzzzzzzu_ = context.Operators.Select<CqlCode, string>(MedicationCodes, qzzzzzzzt_);
        IEnumerable<string> qzzzzzzzv_ = context.Operators.Distinct<string>(qzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? qzzzzzzzw_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, qzzzzzzzs_, qzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] qzzzzzzzx_ = [
            qzzzzzzzw_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> qzzzzzzzy_((CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication)
        {
            IEnumerable<Claim> rzzzzzzzc_ = ClaimWithMedication?.PharmacyClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? rzzzzzzzd_(Claim Pharmacy)
            {
                List<Claim.ItemComponent> rzzzzzzzh_ = Pharmacy?.Item;
                bool? rzzzzzzzi_(Claim.ItemComponent ItemOnLine)
                {
                    CodeableConcept rzzzzzzzp_ = ItemOnLine?.ProductOrService;
                    CqlConcept rzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzzzzzzzp_);
                    CqlCode[] rzzzzzzzr_ = rzzzzzzzq_?.codes;
                    bool? rzzzzzzzs_(CqlCode LineCode)
                    {
                        string rzzzzzzzv_ = LineCode?.code;
                        IEnumerable<string> rzzzzzzzw_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? rzzzzzzzx_ = context.Operators.In<string>(rzzzzzzzv_, rzzzzzzzw_);

                        return rzzzzzzzx_;
                    };
                    IEnumerable<CqlCode> rzzzzzzzt_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)rzzzzzzzr_, rzzzzzzzs_);
                    bool? rzzzzzzzu_ = context.Operators.Exists<CqlCode>(rzzzzzzzt_);

                    return rzzzzzzzu_;
                };
                IEnumerable<Claim.ItemComponent> rzzzzzzzj_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)rzzzzzzzh_, rzzzzzzzi_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? rzzzzzzzk_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, rzzzzzzzj_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] rzzzzzzzl_ = [
                    rzzzzzzzk_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? rzzzzzzzm_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    Claim rzzzzzzzy_ = LineItemDefinition?.Claim;
                    Claim[] rzzzzzzzz_ = [
                        rzzzzzzzy_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? szzzzzzza_(Claim ClaimLines)
                    {
                        List<Claim.ItemComponent> szzzzzzzd_ = ClaimLines?.Item;
                        bool? szzzzzzze_(Claim.ItemComponent i)
                        {
                            CodeableConcept szzzzzzzn_ = i?.ProductOrService;
                            CqlConcept szzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, szzzzzzzn_);
                            CqlCode[] szzzzzzzp_ = szzzzzzzo_?.codes;
                            bool? szzzzzzzq_(CqlCode LineCode)
                            {
                                string szzzzzzzt_ = LineCode?.code;
                                IEnumerable<string> szzzzzzzu_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? szzzzzzzv_ = context.Operators.In<string>(szzzzzzzt_, szzzzzzzu_);

                                return szzzzzzzv_;
                            };
                            IEnumerable<CqlCode> szzzzzzzr_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)szzzzzzzp_, szzzzzzzq_);
                            bool? szzzzzzzs_ = context.Operators.Exists<CqlCode>(szzzzzzzr_);

                            return szzzzzzzs_;
                        };
                        IEnumerable<Claim.ItemComponent> szzzzzzzf_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)szzzzzzzd_, szzzzzzze_);
                        (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? szzzzzzzg_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDateTime> szzzzzzzw_()
                            {
                                bool szzzzzzzy_()
                                {
                                    Quantity szzzzzzzz_ = i?.Quantity;
                                    bool? tzzzzzzza_ = context.Operators.Not((bool?)(szzzzzzzz_ is null));

                                    return tzzzzzzza_ ?? false;
                                };
                                if (szzzzzzzy_())
                                {
                                    CqlInterval<CqlDateTime> tzzzzzzzb_()
                                    {
                                        bool tzzzzzzzc_()
                                        {
                                            DataType tzzzzzzzd_ = i?.Serviced;
                                            bool tzzzzzzze_ = tzzzzzzzd_ is Period;

                                            return tzzzzzzze_;
                                        };
                                        if (tzzzzzzzc_())
                                        {
                                            DataType tzzzzzzzf_ = i?.Serviced;
                                            CqlInterval<CqlDateTime> tzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzf_);
                                            CqlDateTime tzzzzzzzh_ = context.Operators.Start(tzzzzzzzg_);
                                            CqlInterval<CqlDateTime> tzzzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzf_);
                                            CqlDateTime tzzzzzzzk_ = context.Operators.Start(tzzzzzzzj_);
                                            Quantity tzzzzzzzl_ = i?.Quantity;
                                            FhirDecimal tzzzzzzzm_ = tzzzzzzzl_?.ValueElement;
                                            decimal? tzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, tzzzzzzzm_);
                                            CqlDateTime tzzzzzzzo_ = context.Operators.Add(tzzzzzzzk_, new CqlQuantity(tzzzzzzzn_, "day"));
                                            CqlQuantity tzzzzzzzp_ = context.Operators.Quantity(1m, "day");
                                            CqlDateTime tzzzzzzzq_ = context.Operators.Subtract(tzzzzzzzo_, tzzzzzzzp_);
                                            CqlInterval<CqlDateTime> tzzzzzzzr_ = context.Operators.Interval(tzzzzzzzh_, tzzzzzzzq_, true, true);

                                            return tzzzzzzzr_;
                                        }
                                        else
                                        {
                                            DataType tzzzzzzzs_ = i?.Serviced;
                                            CqlDate tzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzzzzs_ as Date);
                                            CqlDate tzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzzzzs_ as Date);
                                            Quantity tzzzzzzzw_ = i?.Quantity;
                                            FhirDecimal tzzzzzzzx_ = tzzzzzzzw_?.ValueElement;
                                            decimal? tzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, tzzzzzzzx_);
                                            CqlDate tzzzzzzzz_ = context.Operators.Add(tzzzzzzzv_, new CqlQuantity(tzzzzzzzy_, "day"));
                                            CqlQuantity uzzzzzzza_ = context.Operators.Quantity(1m, "day");
                                            CqlDate uzzzzzzzb_ = context.Operators.Subtract(tzzzzzzzz_, uzzzzzzza_);
                                            CqlInterval<CqlDate> uzzzzzzzc_ = context.Operators.Interval(tzzzzzzzt_, uzzzzzzzb_, true, true);
                                            CqlDate uzzzzzzzd_ = uzzzzzzzc_?.low;
                                            CqlDateTime uzzzzzzze_ = context.Operators.ConvertDateToDateTime(uzzzzzzzd_);
                                            CqlDate uzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzzzzs_ as Date);
                                            CqlDate uzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzzzzs_ as Date);
                                            FhirDecimal uzzzzzzzk_ = tzzzzzzzw_?.ValueElement;
                                            decimal? uzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, uzzzzzzzk_);
                                            CqlDate uzzzzzzzm_ = context.Operators.Add(uzzzzzzzi_, new CqlQuantity(uzzzzzzzl_, "day"));
                                            CqlDate uzzzzzzzo_ = context.Operators.Subtract(uzzzzzzzm_, uzzzzzzza_);
                                            CqlInterval<CqlDate> uzzzzzzzp_ = context.Operators.Interval(uzzzzzzzg_, uzzzzzzzo_, true, true);
                                            CqlDate uzzzzzzzq_ = uzzzzzzzp_?.high;
                                            CqlDateTime uzzzzzzzr_ = context.Operators.ConvertDateToDateTime(uzzzzzzzq_);
                                            CqlDate uzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzzzzs_ as Date);
                                            CqlDate uzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzzzzs_ as Date);
                                            FhirDecimal uzzzzzzzx_ = tzzzzzzzw_?.ValueElement;
                                            decimal? uzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, uzzzzzzzx_);
                                            CqlDate uzzzzzzzz_ = context.Operators.Add(uzzzzzzzv_, new CqlQuantity(uzzzzzzzy_, "day"));
                                            CqlDate vzzzzzzzb_ = context.Operators.Subtract(uzzzzzzzz_, uzzzzzzza_);
                                            CqlInterval<CqlDate> vzzzzzzzc_ = context.Operators.Interval(uzzzzzzzt_, vzzzzzzzb_, true, true);
                                            bool? vzzzzzzzd_ = vzzzzzzzc_?.lowClosed;
                                            CqlDate vzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzzzzs_ as Date);
                                            CqlDate vzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzzzzs_ as Date);
                                            FhirDecimal vzzzzzzzj_ = tzzzzzzzw_?.ValueElement;
                                            decimal? vzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, vzzzzzzzj_);
                                            CqlDate vzzzzzzzl_ = context.Operators.Add(vzzzzzzzh_, new CqlQuantity(vzzzzzzzk_, "day"));
                                            CqlDate vzzzzzzzn_ = context.Operators.Subtract(vzzzzzzzl_, uzzzzzzza_);
                                            CqlInterval<CqlDate> vzzzzzzzo_ = context.Operators.Interval(vzzzzzzzf_, vzzzzzzzn_, true, true);
                                            bool? vzzzzzzzp_ = vzzzzzzzo_?.highClosed;
                                            CqlInterval<CqlDateTime> vzzzzzzzq_ = context.Operators.Interval(uzzzzzzze_, uzzzzzzzr_, vzzzzzzzd_, vzzzzzzzp_);

                                            return vzzzzzzzq_;
                                        }
                                    };

                                    return tzzzzzzzb_();
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDateTime>;
                                }
                            };
                            (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? szzzzzzzx_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, szzzzzzzw_());

                            return szzzzzzzx_;
                        };
                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> szzzzzzzh_ = context.Operators.Select<Claim.ItemComponent, (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>(szzzzzzzf_, szzzzzzzg_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? szzzzzzzi_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, szzzzzzzh_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?[] szzzzzzzj_ = [
                            szzzzzzzi_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? szzzzzzzk_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? ItemCalculation)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? vzzzzzzzr_()
                            {
                                bool vzzzzzzzs_()
                                {
                                    IEnumerable<Claim.ItemComponent> vzzzzzzzt_ = LineItemDefinition?.LineItems;
                                    bool? vzzzzzzzu_ = context.Operators.Exists<Claim.ItemComponent>(vzzzzzzzt_);

                                    return vzzzzzzzu_ ?? false;
                                };
                                if (vzzzzzzzs_())
                                {
                                    Claim vzzzzzzzv_ = LineItemDefinition?.Claim;
                                    IEnumerable<Claim.ItemComponent> vzzzzzzzw_ = LineItemDefinition?.LineItems;
                                    bool? vzzzzzzzy_(Claim.ItemComponent @this)
                                    {
                                        DataType wzzzzzzzj_ = @this?.Serviced;
                                        bool? wzzzzzzzk_ = context.Operators.Not((bool?)(wzzzzzzzj_ is null));

                                        return wzzzzzzzk_;
                                    };
                                    IEnumerable<Claim.ItemComponent> vzzzzzzzz_ = context.Operators.Where<Claim.ItemComponent>(vzzzzzzzw_, vzzzzzzzy_);
                                    object wzzzzzzza_(Claim.ItemComponent @this)
                                    {
                                        DataType wzzzzzzzl_ = @this?.Serviced;

                                        return wzzzzzzzl_;
                                    };
                                    IEnumerable<object> wzzzzzzzb_ = context.Operators.Select<Claim.ItemComponent, object>(vzzzzzzzz_, wzzzzzzza_);
                                    CqlInterval<CqlDateTime> wzzzzzzzc_(object NormalDate)
                                    {
                                        CqlInterval<CqlDateTime> wzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                        return wzzzzzzzm_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzd_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(wzzzzzzzb_, wzzzzzzzc_);
                                    IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzze_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(wzzzzzzzd_);
                                    IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> wzzzzzzzf_ = ItemCalculation?.CoveredDays;
                                    CqlInterval<CqlDateTime> wzzzzzzzg_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d)
                                    {
                                        CqlInterval<CqlDateTime> wzzzzzzzn_ = d?.DaysSupplyInterval;

                                        return wzzzzzzzn_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(wzzzzzzzf_, wzzzzzzzg_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? wzzzzzzzi_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, vzzzzzzzv_, vzzzzzzzw_, wzzzzzzze_, wzzzzzzzh_);

                                    return wzzzzzzzi_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
                                }
                            };

                            return vzzzzzzzr_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> szzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?>)szzzzzzzj_, szzzzzzzk_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? szzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(szzzzzzzl_);

                        return szzzzzzzm_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> szzzzzzzb_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)rzzzzzzzz_, szzzzzzza_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? szzzzzzzc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(szzzzzzzb_);

                    return szzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> rzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)rzzzzzzzl_, rzzzzzzzm_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? rzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(rzzzzzzzn_);

                return rzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> rzzzzzzze_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(rzzzzzzzc_, rzzzzzzzd_);
            bool? rzzzzzzzf_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList)
            {
                bool? wzzzzzzzo_ = context.Operators.Not((bool?)(FinalList is null));

                return wzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> rzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(rzzzzzzze_, rzzzzzzzf_);

            return rzzzzzzzg_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> qzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)qzzzzzzzx_, qzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> rzzzzzzza_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(qzzzzzzzz_);

        return rzzzzzzza_;
    }


    [CqlExpressionDefinition("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> wzzzzzzzp_ = this.Professional_or_Institutional_Claims(context, claim);
        string wzzzzzzzq_(CqlCode d)
        {
            string xzzzzzzzc_ = d?.code;

            return xzzzzzzzc_;
        };
        IEnumerable<string> wzzzzzzzr_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, wzzzzzzzq_);
        IEnumerable<string> wzzzzzzzs_ = context.Operators.Distinct<string>(wzzzzzzzr_);
        string wzzzzzzzt_(CqlCode p)
        {
            string xzzzzzzzd_ = p?.code;

            return xzzzzzzzd_;
        };
        IEnumerable<string> wzzzzzzzu_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, wzzzzzzzt_);
        IEnumerable<string> wzzzzzzzv_ = context.Operators.Distinct<string>(wzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? wzzzzzzzw_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, wzzzzzzzp_, wzzzzzzzs_, wzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] wzzzzzzzx_ = [
            wzzzzzzzw_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzy_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> xzzzzzzze_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> xzzzzzzzl_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? xzzzzzzzm_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> xzzzzzzzo_ = DiagnosisLine?.Diagnosis;
                        bool? xzzzzzzzp_(Claim.DiagnosisComponent @this)
                        {
                            DataType yzzzzzzzd_ = @this?.Diagnosis;
                            bool? yzzzzzzze_ = context.Operators.Not((bool?)(yzzzzzzzd_ is null));

                            return yzzzzzzze_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> xzzzzzzzq_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)xzzzzzzzo_, xzzzzzzzp_);
                        object xzzzzzzzr_(Claim.DiagnosisComponent @this)
                        {
                            DataType yzzzzzzzf_ = @this?.Diagnosis;

                            return yzzzzzzzf_;
                        };
                        IEnumerable<object> xzzzzzzzs_ = context.Operators.Select<Claim.DiagnosisComponent, object>(xzzzzzzzq_, xzzzzzzzr_);
                        bool? xzzzzzzzt_(object @this)
                        {
                            object yzzzzzzzg_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? yzzzzzzzh_ = context.Operators.Not((bool?)(yzzzzzzzg_ is null));

                            return yzzzzzzzh_;
                        };
                        IEnumerable<object> xzzzzzzzu_ = context.Operators.Where<object>(xzzzzzzzs_, xzzzzzzzt_);
                        object xzzzzzzzv_(object @this)
                        {
                            object yzzzzzzzi_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return yzzzzzzzi_;
                        };
                        IEnumerable<object> xzzzzzzzw_ = context.Operators.Select<object, object>(xzzzzzzzu_, xzzzzzzzv_);
                        IEnumerable<object> xzzzzzzzx_ = context.Operators.FlattenLateBoundList(xzzzzzzzw_);
                        Coding xzzzzzzzy_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> xzzzzzzzz_ = context.Operators.Select<object, Coding>(xzzzzzzzx_, xzzzzzzzy_);
                        bool? yzzzzzzza_(Coding HeaderCode)
                        {
                            Code yzzzzzzzj_ = HeaderCode?.CodeElement;
                            string yzzzzzzzk_ = yzzzzzzzj_?.Value;
                            IEnumerable<string> yzzzzzzzl_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? yzzzzzzzm_ = context.Operators.In<string>(yzzzzzzzk_, yzzzzzzzl_);

                            return yzzzzzzzm_;
                        };
                        IEnumerable<Coding> yzzzzzzzb_ = context.Operators.Where<Coding>(xzzzzzzzz_, yzzzzzzza_);
                        bool? yzzzzzzzc_ = context.Operators.Exists<Coding>(yzzzzzzzb_);

                        return yzzzzzzzc_;
                    };
                    IEnumerable<Claim> xzzzzzzzn_ = context.Operators.Where<Claim>(xzzzzzzzl_, xzzzzzzzm_);

                    return xzzzzzzzn_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? xzzzzzzzf_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, xzzzzzzze_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] xzzzzzzzg_ = [
                xzzzzzzzf_,
            ];
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzzh_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ClaimWithProcedure)
            {
                IEnumerable<Claim> yzzzzzzzn_ = ClaimWithProcedure?.DiagnosisItems;
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzo_(Claim ClaimofInterest)
                {
                    Claim yzzzzzzzt_()
                    {
                        if (ClaimofInterest is null)
                        {
                            return default;
                        }
                        else
                        {
                            Claim[] zzzzzzzza_ = [
                                ClaimofInterest,
                            ];
                            bool? zzzzzzzzb_(Claim ItemOnLine)
                            {
                                List<Claim.ProcedureComponent> zzzzzzzze_ = ItemOnLine?.Procedure;
                                bool? zzzzzzzzf_(Claim.ProcedureComponent @this)
                                {
                                    DataType azzzzzzzzh_ = @this?.Procedure;
                                    bool? azzzzzzzzi_ = context.Operators.Not((bool?)(azzzzzzzzh_ is null));

                                    return azzzzzzzzi_;
                                };
                                IEnumerable<Claim.ProcedureComponent> zzzzzzzzg_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)zzzzzzzze_, zzzzzzzzf_);
                                object zzzzzzzzh_(Claim.ProcedureComponent @this)
                                {
                                    DataType azzzzzzzzj_ = @this?.Procedure;

                                    return azzzzzzzzj_;
                                };
                                IEnumerable<object> zzzzzzzzi_ = context.Operators.Select<Claim.ProcedureComponent, object>(zzzzzzzzg_, zzzzzzzzh_);
                                bool? zzzzzzzzj_(object @this)
                                {
                                    object azzzzzzzzk_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                    bool? azzzzzzzzl_ = context.Operators.Not((bool?)(azzzzzzzzk_ is null));

                                    return azzzzzzzzl_;
                                };
                                IEnumerable<object> zzzzzzzzk_ = context.Operators.Where<object>(zzzzzzzzi_, zzzzzzzzj_);
                                object zzzzzzzzl_(object @this)
                                {
                                    object azzzzzzzzm_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                    return azzzzzzzzm_;
                                };
                                IEnumerable<object> zzzzzzzzm_ = context.Operators.Select<object, object>(zzzzzzzzk_, zzzzzzzzl_);
                                IEnumerable<object> zzzzzzzzn_ = context.Operators.FlattenLateBoundList(zzzzzzzzm_);
                                Coding zzzzzzzzo_(object @object) =>
                                    (Coding)@object;
                                IEnumerable<Coding> zzzzzzzzp_ = context.Operators.Select<object, Coding>(zzzzzzzzn_, zzzzzzzzo_);
                                bool? zzzzzzzzq_(Coding ProcedureHeaderCode)
                                {
                                    Code azzzzzzzzn_ = ProcedureHeaderCode?.CodeElement;
                                    string azzzzzzzzo_ = azzzzzzzzn_?.Value;
                                    IEnumerable<string> azzzzzzzzp_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? azzzzzzzzq_ = context.Operators.In<string>(azzzzzzzzo_, azzzzzzzzp_);

                                    return azzzzzzzzq_;
                                };
                                IEnumerable<Coding> zzzzzzzzr_ = context.Operators.Where<Coding>(zzzzzzzzp_, zzzzzzzzq_);
                                bool? zzzzzzzzs_ = context.Operators.Exists<Coding>(zzzzzzzzr_);
                                List<Claim.ItemComponent> zzzzzzzzt_ = ItemOnLine?.Item;
                                bool? zzzzzzzzu_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept azzzzzzzzr_ = @this?.ProductOrService;
                                    bool? azzzzzzzzs_ = context.Operators.Not((bool?)(azzzzzzzzr_ is null));

                                    return azzzzzzzzs_;
                                };
                                IEnumerable<Claim.ItemComponent> zzzzzzzzv_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)zzzzzzzzt_, zzzzzzzzu_);
                                CodeableConcept zzzzzzzzw_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept azzzzzzzzt_ = @this?.ProductOrService;

                                    return azzzzzzzzt_;
                                };
                                IEnumerable<CodeableConcept> zzzzzzzzx_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(zzzzzzzzv_, zzzzzzzzw_);
                                bool? zzzzzzzzy_(CodeableConcept @this)
                                {
                                    List<Coding> azzzzzzzzu_ = @this?.Coding;
                                    bool? azzzzzzzzv_ = context.Operators.Not((bool?)(azzzzzzzzu_ is null));

                                    return azzzzzzzzv_;
                                };
                                IEnumerable<CodeableConcept> zzzzzzzzz_ = context.Operators.Where<CodeableConcept>(zzzzzzzzx_, zzzzzzzzy_);
                                List<Coding> azzzzzzzza_(CodeableConcept @this)
                                {
                                    List<Coding> azzzzzzzzw_ = @this?.Coding;

                                    return azzzzzzzzw_;
                                };
                                IEnumerable<List<Coding>> azzzzzzzzb_ = context.Operators.Select<CodeableConcept, List<Coding>>(zzzzzzzzz_, azzzzzzzza_);
                                IEnumerable<Coding> azzzzzzzzc_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)azzzzzzzzb_);
                                bool? azzzzzzzzd_(Coding LineCode)
                                {
                                    Code azzzzzzzzx_ = LineCode?.CodeElement;
                                    string azzzzzzzzy_ = azzzzzzzzx_?.Value;
                                    IEnumerable<string> azzzzzzzzz_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? bzzzzzzzza_ = context.Operators.In<string>(azzzzzzzzy_, azzzzzzzzz_);

                                    return bzzzzzzzza_;
                                };
                                IEnumerable<Coding> azzzzzzzze_ = context.Operators.Where<Coding>(azzzzzzzzc_, azzzzzzzzd_);
                                bool? azzzzzzzzf_ = context.Operators.Exists<Coding>(azzzzzzzze_);
                                bool? azzzzzzzzg_ = context.Operators.Or(zzzzzzzzs_, azzzzzzzzf_);

                                return azzzzzzzzg_;
                            };
                            IEnumerable<Claim> zzzzzzzzc_ = context.Operators.Where<Claim>((IEnumerable<Claim>)zzzzzzzza_, zzzzzzzzb_);
                            Claim zzzzzzzzd_ = context.Operators.SingletonFrom<Claim>(zzzzzzzzc_);

                            return zzzzzzzzd_;
                        }
                    };
                    (CqlTupleMetadata, Claim ProcedureItems)? yzzzzzzzu_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, yzzzzzzzt_());
                    (CqlTupleMetadata, Claim ProcedureItems)?[] yzzzzzzzv_ = [
                        yzzzzzzzu_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzw_((CqlTupleMetadata, Claim ProcedureItems)? HeaderDefinition)
                    {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzb_()
                        {
                            bool bzzzzzzzzc_()
                            {
                                Claim bzzzzzzzzd_ = HeaderDefinition?.ProcedureItems;
                                bool? bzzzzzzzze_ = context.Operators.Not((bool?)(bzzzzzzzzd_ is null));

                                return bzzzzzzzze_ ?? false;
                            };
                            if (bzzzzzzzzc_())
                            {
                                Claim bzzzzzzzzf_ = HeaderDefinition?.ProcedureItems;
                                List<Claim.ItemComponent> bzzzzzzzzh_ = bzzzzzzzzf_?.Item;
                                CqlInterval<CqlDateTime> bzzzzzzzzi_(Claim.ItemComponent NormalDate)
                                {
                                    DataType bzzzzzzzzm_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> bzzzzzzzzn_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, bzzzzzzzzm_);

                                    return bzzzzzzzzn_;
                                };
                                IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzj_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)bzzzzzzzzh_, bzzzzzzzzi_);
                                IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzk_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bzzzzzzzzj_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzl_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, bzzzzzzzzf_, bzzzzzzzzk_);

                                return bzzzzzzzzl_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        };

                        return bzzzzzzzzb_();
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim ProcedureItems)?>)yzzzzzzzv_, yzzzzzzzw_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzx_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzy_);

                    return yzzzzzzzz_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzp_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzn_, yzzzzzzzo_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzp_);
                bool? yzzzzzzzr_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? bzzzzzzzzo_ = context.Operators.Not((bool?)(FinalList is null));

                    return bzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzq_, yzzzzzzzr_);

                return yzzzzzzzs_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> xzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)xzzzzzzzg_, xzzzzzzzh_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> xzzzzzzzj_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(xzzzzzzzi_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzzk_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(xzzzzzzzj_);

            return xzzzzzzzk_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)wzzzzzzzx_, wzzzzzzzy_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> xzzzzzzza_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzzb_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(xzzzzzzza_);

        return xzzzzzzzb_;
    }


    [CqlExpressionDefinition("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> bzzzzzzzzp_ = this.Professional_or_Institutional_Claims(context, claim);
        string bzzzzzzzzq_(CqlCode d)
        {
            string czzzzzzzzc_ = d?.code;

            return czzzzzzzzc_;
        };
        IEnumerable<string> bzzzzzzzzr_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, bzzzzzzzzq_);
        IEnumerable<string> bzzzzzzzzs_ = context.Operators.Distinct<string>(bzzzzzzzzr_);
        string bzzzzzzzzt_(CqlCode p)
        {
            string czzzzzzzzd_ = p?.code;

            return czzzzzzzzd_;
        };
        IEnumerable<string> bzzzzzzzzu_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, bzzzzzzzzt_);
        IEnumerable<string> bzzzzzzzzv_ = context.Operators.Distinct<string>(bzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? bzzzzzzzzw_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, bzzzzzzzzp_, bzzzzzzzzs_, bzzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] bzzzzzzzzx_ = [
            bzzzzzzzzw_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzy_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure)
        {
            IEnumerable<Claim> czzzzzzzze_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzf_(Claim ClaimofInterest)
            {
                Claim czzzzzzzzk_()
                {
                    if (ClaimofInterest is null)
                    {
                        return default;
                    }
                    else
                    {
                        Claim[] czzzzzzzzr_ = [
                            ClaimofInterest,
                        ];
                        bool? czzzzzzzzs_(Claim ItemOnLine)
                        {
                            List<Claim.ItemComponent> czzzzzzzzv_ = ItemOnLine?.Item;
                            bool? czzzzzzzzw_(Claim.ItemComponent @this)
                            {
                                CodeableConcept dzzzzzzzzy_ = @this?.ProductOrService;
                                bool? dzzzzzzzzz_ = context.Operators.Not((bool?)(dzzzzzzzzy_ is null));

                                return dzzzzzzzzz_;
                            };
                            IEnumerable<Claim.ItemComponent> czzzzzzzzx_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)czzzzzzzzv_, czzzzzzzzw_);
                            CodeableConcept czzzzzzzzy_(Claim.ItemComponent @this)
                            {
                                CodeableConcept ezzzzzzzza_ = @this?.ProductOrService;

                                return ezzzzzzzza_;
                            };
                            IEnumerable<CodeableConcept> czzzzzzzzz_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(czzzzzzzzx_, czzzzzzzzy_);
                            bool? dzzzzzzzza_(CodeableConcept @this)
                            {
                                List<Coding> ezzzzzzzzb_ = @this?.Coding;
                                bool? ezzzzzzzzc_ = context.Operators.Not((bool?)(ezzzzzzzzb_ is null));

                                return ezzzzzzzzc_;
                            };
                            IEnumerable<CodeableConcept> dzzzzzzzzb_ = context.Operators.Where<CodeableConcept>(czzzzzzzzz_, dzzzzzzzza_);
                            List<Coding> dzzzzzzzzc_(CodeableConcept @this)
                            {
                                List<Coding> ezzzzzzzzd_ = @this?.Coding;

                                return ezzzzzzzzd_;
                            };
                            IEnumerable<List<Coding>> dzzzzzzzzd_ = context.Operators.Select<CodeableConcept, List<Coding>>(dzzzzzzzzb_, dzzzzzzzzc_);
                            IEnumerable<Coding> dzzzzzzzze_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)dzzzzzzzzd_);
                            bool? dzzzzzzzzf_(Coding LineCode)
                            {
                                Code ezzzzzzzze_ = LineCode?.CodeElement;
                                string ezzzzzzzzf_ = ezzzzzzzze_?.Value;
                                IEnumerable<string> ezzzzzzzzg_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? ezzzzzzzzh_ = context.Operators.In<string>(ezzzzzzzzf_, ezzzzzzzzg_);

                                return ezzzzzzzzh_;
                            };
                            IEnumerable<Coding> dzzzzzzzzg_ = context.Operators.Where<Coding>(dzzzzzzzze_, dzzzzzzzzf_);
                            bool? dzzzzzzzzh_ = context.Operators.Exists<Coding>(dzzzzzzzzg_);
                            List<Claim.ProcedureComponent> dzzzzzzzzi_ = ItemOnLine?.Procedure;
                            bool? dzzzzzzzzj_(Claim.ProcedureComponent @this)
                            {
                                DataType ezzzzzzzzi_ = @this?.Procedure;
                                bool? ezzzzzzzzj_ = context.Operators.Not((bool?)(ezzzzzzzzi_ is null));

                                return ezzzzzzzzj_;
                            };
                            IEnumerable<Claim.ProcedureComponent> dzzzzzzzzk_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)dzzzzzzzzi_, dzzzzzzzzj_);
                            object dzzzzzzzzl_(Claim.ProcedureComponent @this)
                            {
                                DataType ezzzzzzzzk_ = @this?.Procedure;

                                return ezzzzzzzzk_;
                            };
                            IEnumerable<object> dzzzzzzzzm_ = context.Operators.Select<Claim.ProcedureComponent, object>(dzzzzzzzzk_, dzzzzzzzzl_);
                            bool? dzzzzzzzzn_(object @this)
                            {
                                object ezzzzzzzzl_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? ezzzzzzzzm_ = context.Operators.Not((bool?)(ezzzzzzzzl_ is null));

                                return ezzzzzzzzm_;
                            };
                            IEnumerable<object> dzzzzzzzzo_ = context.Operators.Where<object>(dzzzzzzzzm_, dzzzzzzzzn_);
                            object dzzzzzzzzp_(object @this)
                            {
                                object ezzzzzzzzn_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return ezzzzzzzzn_;
                            };
                            IEnumerable<object> dzzzzzzzzq_ = context.Operators.Select<object, object>(dzzzzzzzzo_, dzzzzzzzzp_);
                            IEnumerable<object> dzzzzzzzzr_ = context.Operators.FlattenLateBoundList(dzzzzzzzzq_);
                            Coding dzzzzzzzzs_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> dzzzzzzzzt_ = context.Operators.Select<object, Coding>(dzzzzzzzzr_, dzzzzzzzzs_);
                            bool? dzzzzzzzzu_(Coding HeaderCode)
                            {
                                Code ezzzzzzzzo_ = HeaderCode?.CodeElement;
                                string ezzzzzzzzp_ = ezzzzzzzzo_?.Value;
                                IEnumerable<string> ezzzzzzzzq_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? ezzzzzzzzr_ = context.Operators.In<string>(ezzzzzzzzp_, ezzzzzzzzq_);

                                return ezzzzzzzzr_;
                            };
                            IEnumerable<Coding> dzzzzzzzzv_ = context.Operators.Where<Coding>(dzzzzzzzzt_, dzzzzzzzzu_);
                            bool? dzzzzzzzzw_ = context.Operators.Exists<Coding>(dzzzzzzzzv_);
                            bool? dzzzzzzzzx_ = context.Operators.Or(dzzzzzzzzh_, dzzzzzzzzw_);

                            return dzzzzzzzzx_;
                        };
                        IEnumerable<Claim> czzzzzzzzt_ = context.Operators.Where<Claim>((IEnumerable<Claim>)czzzzzzzzr_, czzzzzzzzs_);
                        Claim czzzzzzzzu_ = context.Operators.SingletonFrom<Claim>(czzzzzzzzt_);

                        return czzzzzzzzu_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? czzzzzzzzl_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, czzzzzzzzk_());
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?[] czzzzzzzzm_ = [
                    czzzzzzzzl_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzn_((CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? DiagnosisCheck)
                {
                    Claim ezzzzzzzzs_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] ezzzzzzzzt_ = [
                        ezzzzzzzzs_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzu_(Claim ClaimforDiagnosis)
                    {
                        List<Claim.ItemComponent> ezzzzzzzzy_ = ClaimforDiagnosis?.Item;
                        Claim ezzzzzzzzz_()
                        {
                            if (ClaimforDiagnosis is null)
                            {
                                return default;
                            }
                            else
                            {
                                Claim[] fzzzzzzzzg_ = [
                                    ClaimforDiagnosis,
                                ];
                                bool? fzzzzzzzzh_(Claim RightClaim)
                                {
                                    List<Claim.DiagnosisComponent> fzzzzzzzzk_ = RightClaim?.Diagnosis;
                                    bool? fzzzzzzzzl_(Claim.DiagnosisComponent RightDiagnosis)
                                    {
                                        PositiveInt fzzzzzzzzo_ = RightDiagnosis?.SequenceElement;
                                        Integer fzzzzzzzzp_ = context.Operators.Convert<Integer>(fzzzzzzzzo_);
                                        int? fzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, fzzzzzzzzp_);
                                        bool? fzzzzzzzzr_ = context.Operators.Equal(fzzzzzzzzq_, 1);
                                        DataType fzzzzzzzzs_ = RightDiagnosis?.Diagnosis;
                                        IEnumerable<Coding> fzzzzzzzzt_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(fzzzzzzzzs_, "coding");
                                        bool? fzzzzzzzzu_(Coding DiagnosisCode)
                                        {
                                            Code fzzzzzzzzy_ = DiagnosisCode?.CodeElement;
                                            string fzzzzzzzzz_ = fzzzzzzzzy_?.Value;
                                            IEnumerable<string> gzzzzzzzza_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                            bool? gzzzzzzzzb_ = context.Operators.In<string>(fzzzzzzzzz_, gzzzzzzzza_);

                                            return gzzzzzzzzb_;
                                        };
                                        IEnumerable<Coding> fzzzzzzzzv_ = context.Operators.Where<Coding>(fzzzzzzzzt_, fzzzzzzzzu_);
                                        bool? fzzzzzzzzw_ = context.Operators.Exists<Coding>(fzzzzzzzzv_);
                                        bool? fzzzzzzzzx_ = context.Operators.And(fzzzzzzzzr_, fzzzzzzzzw_);

                                        return fzzzzzzzzx_;
                                    };
                                    IEnumerable<Claim.DiagnosisComponent> fzzzzzzzzm_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)fzzzzzzzzk_, fzzzzzzzzl_);
                                    bool? fzzzzzzzzn_ = context.Operators.Exists<Claim.DiagnosisComponent>(fzzzzzzzzm_);

                                    return fzzzzzzzzn_;
                                };
                                IEnumerable<Claim> fzzzzzzzzi_ = context.Operators.Where<Claim>((IEnumerable<Claim>)fzzzzzzzzg_, fzzzzzzzzh_);
                                Claim fzzzzzzzzj_ = context.Operators.SingletonFrom<Claim>(fzzzzzzzzi_);

                                return fzzzzzzzzj_;
                            }
                        };
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? fzzzzzzzza_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)ezzzzzzzzy_, ezzzzzzzzz_());
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] fzzzzzzzzb_ = [
                            fzzzzzzzza_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzc_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzzc_()
                            {
                                bool gzzzzzzzzd_()
                                {
                                    bool? gzzzzzzzze_ = context.Operators.Not((bool?)(LineItemDefinition is null));
                                    Claim gzzzzzzzzf_ = LineItemDefinition?.LineItems;
                                    bool? gzzzzzzzzg_ = context.Operators.Not((bool?)(gzzzzzzzzf_ is null));
                                    bool? gzzzzzzzzh_ = context.Operators.And(gzzzzzzzze_, gzzzzzzzzg_);

                                    return gzzzzzzzzh_ ?? false;
                                };
                                if (gzzzzzzzzd_())
                                {
                                    Claim gzzzzzzzzi_ = LineItemDefinition?.LineItems;
                                    List<Claim.ItemComponent> gzzzzzzzzk_ = gzzzzzzzzi_?.Item;
                                    CqlInterval<CqlDateTime> gzzzzzzzzl_(Claim.ItemComponent NormalDate)
                                    {
                                        DataType gzzzzzzzzo_ = NormalDate?.Serviced;
                                        CqlInterval<CqlDateTime> gzzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzo_);

                                        return gzzzzzzzzp_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzm_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)gzzzzzzzzk_, gzzzzzzzzl_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzzn_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, gzzzzzzzzi_, gzzzzzzzzm_);

                                    return gzzzzzzzzn_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                                }
                            };

                            return gzzzzzzzzc_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)fzzzzzzzzb_, fzzzzzzzzc_);
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzzd_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzze_);

                        return fzzzzzzzzf_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ezzzzzzzzv_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)ezzzzzzzzt_, ezzzzzzzzu_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ezzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ezzzzzzzzv_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ezzzzzzzzw_);

                    return ezzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?>)czzzzzzzzm_, czzzzzzzzn_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzo_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzp_);

                return czzzzzzzzq_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzg_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzze_, czzzzzzzzf_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzg_);
            bool? czzzzzzzzi_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? gzzzzzzzzq_ = context.Operators.Not((bool?)(FinalList is null));

                return gzzzzzzzzq_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzh_, czzzzzzzzi_);

            return czzzzzzzzj_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> bzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)bzzzzzzzzx_, bzzzzzzzzy_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> czzzzzzzza_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(bzzzzzzzzz_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzb_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(czzzzzzzza_);

        return czzzzzzzzb_;
    }


    [CqlExpressionDefinition("Medical Claims With Principal Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> gzzzzzzzzr_ = this.Professional_or_Institutional_Claims(context, claim);
        string gzzzzzzzzs_(CqlCode d)
        {
            string hzzzzzzzzb_ = d?.code;

            return hzzzzzzzzb_;
        };
        IEnumerable<string> gzzzzzzzzt_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, gzzzzzzzzs_);
        IEnumerable<string> gzzzzzzzzu_ = context.Operators.Distinct<string>(gzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? gzzzzzzzzv_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, gzzzzzzzzr_, gzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] gzzzzzzzzw_ = [
            gzzzzzzzzv_,
        ];
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzzx_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> hzzzzzzzzc_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> hzzzzzzzzj_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? hzzzzzzzzk_(Claim RightClaim)
                    {
                        List<Claim.DiagnosisComponent> hzzzzzzzzm_ = RightClaim?.Diagnosis;
                        bool? hzzzzzzzzn_(Claim.DiagnosisComponent RightDiagnosis)
                        {
                            PositiveInt hzzzzzzzzq_ = RightDiagnosis?.SequenceElement;
                            Integer hzzzzzzzzr_ = context.Operators.Convert<Integer>(hzzzzzzzzq_);
                            int? hzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, hzzzzzzzzr_);
                            bool? hzzzzzzzzt_ = context.Operators.Equal(hzzzzzzzzs_, 1);
                            DataType hzzzzzzzzu_ = RightDiagnosis?.Diagnosis;
                            IEnumerable<Coding> hzzzzzzzzv_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(hzzzzzzzzu_, "coding");
                            bool? hzzzzzzzzw_(Coding DiagnosisCode)
                            {
                                Code izzzzzzzza_ = DiagnosisCode?.CodeElement;
                                string izzzzzzzzb_ = izzzzzzzza_?.Value;
                                IEnumerable<string> izzzzzzzzc_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                                bool? izzzzzzzzd_ = context.Operators.In<string>(izzzzzzzzb_, izzzzzzzzc_);

                                return izzzzzzzzd_;
                            };
                            IEnumerable<Coding> hzzzzzzzzx_ = context.Operators.Where<Coding>(hzzzzzzzzv_, hzzzzzzzzw_);
                            bool? hzzzzzzzzy_ = context.Operators.Exists<Coding>(hzzzzzzzzx_);
                            bool? hzzzzzzzzz_ = context.Operators.And(hzzzzzzzzt_, hzzzzzzzzy_);

                            return hzzzzzzzzz_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> hzzzzzzzzo_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)hzzzzzzzzm_, hzzzzzzzzn_);
                        bool? hzzzzzzzzp_ = context.Operators.Exists<Claim.DiagnosisComponent>(hzzzzzzzzo_);

                        return hzzzzzzzzp_;
                    };
                    IEnumerable<Claim> hzzzzzzzzl_ = context.Operators.Where<Claim>(hzzzzzzzzj_, hzzzzzzzzk_);

                    return hzzzzzzzzl_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)? hzzzzzzzzd_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, hzzzzzzzzc_());
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)?[] hzzzzzzzze_ = [
                hzzzzzzzzd_,
            ];
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzzf_((CqlTupleMetadata, IEnumerable<Claim> LineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> izzzzzzzze_ = LineItemDefinition?.LineItems;
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzzzf_(Claim ClaimWithDiagnosis)
                {
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzzzk_()
                    {
                        if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
                        {
                            IEnumerable<Claim> izzzzzzzzl_ = LineItemDefinition?.LineItems;
                            bool? izzzzzzzzn_(Claim @this)
                            {
                                List<Claim.ItemComponent> izzzzzzzzw_ = @this?.Item;
                                bool? izzzzzzzzx_ = context.Operators.Not((bool?)(izzzzzzzzw_ is null));

                                return izzzzzzzzx_;
                            };
                            IEnumerable<Claim> izzzzzzzzo_ = context.Operators.Where<Claim>(izzzzzzzzl_, izzzzzzzzn_);
                            List<Claim.ItemComponent> izzzzzzzzp_(Claim @this)
                            {
                                List<Claim.ItemComponent> izzzzzzzzy_ = @this?.Item;

                                return izzzzzzzzy_;
                            };
                            IEnumerable<List<Claim.ItemComponent>> izzzzzzzzq_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(izzzzzzzzo_, izzzzzzzzp_);
                            IEnumerable<Claim.ItemComponent> izzzzzzzzr_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)izzzzzzzzq_);
                            CqlInterval<CqlDateTime> izzzzzzzzs_(Claim.ItemComponent NormalDate)
                            {
                                DataType izzzzzzzzz_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> jzzzzzzzza_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzz_);

                                return jzzzzzzzza_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzt_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(izzzzzzzzr_, izzzzzzzzs_);
                            IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(izzzzzzzzt_);
                            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzzzv_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, izzzzzzzzl_, izzzzzzzzu_);

                            return izzzzzzzzv_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return izzzzzzzzk_();
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzzzg_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzzze_, izzzzzzzzf_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzzzg_);
                bool? izzzzzzzzi_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? jzzzzzzzzb_ = context.Operators.Not((bool?)(FinalList is null));

                    return jzzzzzzzzb_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzzzh_, izzzzzzzzi_);

                return izzzzzzzzj_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> hzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?>)hzzzzzzzze_, hzzzzzzzzf_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> hzzzzzzzzh_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(hzzzzzzzzg_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzzi_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(hzzzzzzzzh_);

            return hzzzzzzzzi_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> gzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)gzzzzzzzzw_, gzzzzzzzzx_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> gzzzzzzzzz_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(gzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzza_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(gzzzzzzzzz_);

        return hzzzzzzzza_;
    }


    [CqlExpressionDefinition("Get All Professional and Institutional Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> jzzzzzzzzc_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
        IEnumerable<Claim> jzzzzzzzzd_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? jzzzzzzzze_ = (CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE, jzzzzzzzzc_, jzzzzzzzzd_);

        return jzzzzzzzze_;
    }


    [CqlExpressionDefinition("Get All Paid Claim Reponses")]
    public IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? jzzzzzzzzf_(ClaimResponse ResponseItem)
        {
            Code<ClaimProcessingCodes> jzzzzzzzzn_ = ResponseItem?.OutcomeElement;
            string jzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzn_);
            string[] jzzzzzzzzp_ = [
                "complete",
                "partial",
            ];
            bool? jzzzzzzzzq_ = context.Operators.In<string>(jzzzzzzzzo_, jzzzzzzzzp_ as IEnumerable<string>);

            return jzzzzzzzzq_;
        };
        IEnumerable<ClaimResponse> jzzzzzzzzg_ = context.Operators.Where<ClaimResponse>(claimResponse, jzzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? jzzzzzzzzh_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, jzzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?[] jzzzzzzzzi_ = [
            jzzzzzzzzh_,
        ];
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzj_((CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ClaimResponse)
        {
            IEnumerable<ClaimResponse> jzzzzzzzzr_ = ClaimResponse?.PaidResponse;
            (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? jzzzzzzzzs_(ClaimResponse ClmResp)
            {
                ResourceReference jzzzzzzzzv_ = ClmResp?.Request;
                FhirString jzzzzzzzzw_ = jzzzzzzzzv_?.ReferenceElement;
                string jzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzw_);
                string jzzzzzzzzy_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, jzzzzzzzzx_);
                List<ClaimResponse.ItemComponent> jzzzzzzzzz_ = ClmResp?.Item;
                bool? kzzzzzzzza_(ClaimResponse.ItemComponent ResponseItem)
                {
                    List<ClaimResponse.AdjudicationComponent> kzzzzzzzzd_ = ResponseItem?.Adjudication;
                    bool? kzzzzzzzze_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept kzzzzzzzzz_ = @this?.Category;
                        bool? lzzzzzzzza_ = context.Operators.Not((bool?)(kzzzzzzzzz_ is null));

                        return lzzzzzzzza_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> kzzzzzzzzf_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)kzzzzzzzzd_, kzzzzzzzze_);
                    CodeableConcept kzzzzzzzzg_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept lzzzzzzzzb_ = @this?.Category;

                        return lzzzzzzzzb_;
                    };
                    IEnumerable<CodeableConcept> kzzzzzzzzh_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(kzzzzzzzzf_, kzzzzzzzzg_);
                    bool? kzzzzzzzzi_(CodeableConcept @this)
                    {
                        List<Coding> lzzzzzzzzc_ = @this?.Coding;
                        bool? lzzzzzzzzd_ = context.Operators.Not((bool?)(lzzzzzzzzc_ is null));

                        return lzzzzzzzzd_;
                    };
                    IEnumerable<CodeableConcept> kzzzzzzzzj_ = context.Operators.Where<CodeableConcept>(kzzzzzzzzh_, kzzzzzzzzi_);
                    List<Coding> kzzzzzzzzk_(CodeableConcept @this)
                    {
                        List<Coding> lzzzzzzzze_ = @this?.Coding;

                        return lzzzzzzzze_;
                    };
                    IEnumerable<List<Coding>> kzzzzzzzzl_ = context.Operators.Select<CodeableConcept, List<Coding>>(kzzzzzzzzj_, kzzzzzzzzk_);
                    IEnumerable<Coding> kzzzzzzzzm_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)kzzzzzzzzl_);
                    bool? kzzzzzzzzn_(Coding CategoryItem)
                    {
                        Code lzzzzzzzzf_ = CategoryItem?.CodeElement;
                        string lzzzzzzzzg_ = lzzzzzzzzf_?.Value;
                        bool? lzzzzzzzzh_ = context.Operators.Equal(lzzzzzzzzg_, "benefit");

                        return lzzzzzzzzh_;
                    };
                    IEnumerable<Coding> kzzzzzzzzo_ = context.Operators.Where<Coding>(kzzzzzzzzm_, kzzzzzzzzn_);
                    bool? kzzzzzzzzp_ = context.Operators.Exists<Coding>(kzzzzzzzzo_);
                    bool? kzzzzzzzzr_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money lzzzzzzzzi_ = @this?.Amount;
                        bool? lzzzzzzzzj_ = context.Operators.Not((bool?)(lzzzzzzzzi_ is null));

                        return lzzzzzzzzj_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> kzzzzzzzzs_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)kzzzzzzzzd_, kzzzzzzzzr_);
                    Money kzzzzzzzzt_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money lzzzzzzzzk_ = @this?.Amount;

                        return lzzzzzzzzk_;
                    };
                    IEnumerable<Money> kzzzzzzzzu_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(kzzzzzzzzs_, kzzzzzzzzt_);
                    bool? kzzzzzzzzv_(Money DollarAmount)
                    {
                        FhirDecimal lzzzzzzzzl_ = DollarAmount?.ValueElement;
                        decimal? lzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, lzzzzzzzzl_);
                        decimal? lzzzzzzzzn_ = context.Operators.ConvertIntegerToDecimal(0);
                        bool? lzzzzzzzzo_ = context.Operators.Greater(lzzzzzzzzm_, lzzzzzzzzn_);

                        return lzzzzzzzzo_;
                    };
                    IEnumerable<Money> kzzzzzzzzw_ = context.Operators.Where<Money>(kzzzzzzzzu_, kzzzzzzzzv_);
                    bool? kzzzzzzzzx_ = context.Operators.Exists<Money>(kzzzzzzzzw_);
                    bool? kzzzzzzzzy_ = context.Operators.And(kzzzzzzzzp_, kzzzzzzzzx_);

                    return kzzzzzzzzy_;
                };
                IEnumerable<ClaimResponse.ItemComponent> kzzzzzzzzb_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)jzzzzzzzzz_, kzzzzzzzza_);
                (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? kzzzzzzzzc_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, jzzzzzzzzy_, kzzzzzzzzb_);

                return kzzzzzzzzc_;
            };
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzt_ = context.Operators.Select<ClaimResponse, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(jzzzzzzzzr_, jzzzzzzzzs_);
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(jzzzzzzzzt_);

            return jzzzzzzzzu_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> jzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?>)jzzzzzzzzi_, jzzzzzzzzj_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> jzzzzzzzzl_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(jzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzm_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(jzzzzzzzzl_);

        return jzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? lzzzzzzzzp_(Claim AllClaims)
        {
            List<Claim.ItemComponent> lzzzzzzzzu_ = AllClaims?.Item;
            bool? lzzzzzzzzv_(Claim.ItemComponent @this)
            {
                CodeableConcept mzzzzzzzzx_ = @this?.ProductOrService;
                bool? mzzzzzzzzy_ = context.Operators.Not((bool?)(mzzzzzzzzx_ is null));

                return mzzzzzzzzy_;
            };
            IEnumerable<Claim.ItemComponent> lzzzzzzzzw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)lzzzzzzzzu_, lzzzzzzzzv_);
            CodeableConcept lzzzzzzzzx_(Claim.ItemComponent @this)
            {
                CodeableConcept mzzzzzzzzz_ = @this?.ProductOrService;

                return mzzzzzzzzz_;
            };
            IEnumerable<CodeableConcept> lzzzzzzzzy_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(lzzzzzzzzw_, lzzzzzzzzx_);
            bool? lzzzzzzzzz_(CodeableConcept @this)
            {
                List<Coding> nzzzzzzzza_ = @this?.Coding;
                bool? nzzzzzzzzb_ = context.Operators.Not((bool?)(nzzzzzzzza_ is null));

                return nzzzzzzzzb_;
            };
            IEnumerable<CodeableConcept> mzzzzzzzza_ = context.Operators.Where<CodeableConcept>(lzzzzzzzzy_, lzzzzzzzzz_);
            List<Coding> mzzzzzzzzb_(CodeableConcept @this)
            {
                List<Coding> nzzzzzzzzc_ = @this?.Coding;

                return nzzzzzzzzc_;
            };
            IEnumerable<List<Coding>> mzzzzzzzzc_ = context.Operators.Select<CodeableConcept, List<Coding>>(mzzzzzzzza_, mzzzzzzzzb_);
            IEnumerable<Coding> mzzzzzzzzd_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)mzzzzzzzzc_);
            bool? mzzzzzzzze_(Coding ProductOrServiceCode)
            {
                CqlCode nzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? nzzzzzzzze_ = context.Operators.In<CqlCode>(nzzzzzzzzd_, ProductOrServiceValueSet);

                return nzzzzzzzze_;
            };
            IEnumerable<Coding> mzzzzzzzzf_ = context.Operators.Where<Coding>(mzzzzzzzzd_, mzzzzzzzze_);
            bool? mzzzzzzzzg_ = context.Operators.Exists<Coding>(mzzzzzzzzf_);
            List<Claim.DiagnosisComponent> mzzzzzzzzh_ = AllClaims?.Diagnosis;
            bool? mzzzzzzzzi_(Claim.DiagnosisComponent @this)
            {
                DataType nzzzzzzzzf_ = @this?.Diagnosis;
                bool? nzzzzzzzzg_ = context.Operators.Not((bool?)(nzzzzzzzzf_ is null));

                return nzzzzzzzzg_;
            };
            IEnumerable<Claim.DiagnosisComponent> mzzzzzzzzj_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)mzzzzzzzzh_, mzzzzzzzzi_);
            object mzzzzzzzzk_(Claim.DiagnosisComponent @this)
            {
                DataType nzzzzzzzzh_ = @this?.Diagnosis;

                return nzzzzzzzzh_;
            };
            IEnumerable<object> mzzzzzzzzl_ = context.Operators.Select<Claim.DiagnosisComponent, object>(mzzzzzzzzj_, mzzzzzzzzk_);
            bool? mzzzzzzzzm_(object @this)
            {
                object nzzzzzzzzi_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? nzzzzzzzzj_ = context.Operators.Not((bool?)(nzzzzzzzzi_ is null));

                return nzzzzzzzzj_;
            };
            IEnumerable<object> mzzzzzzzzn_ = context.Operators.Where<object>(mzzzzzzzzl_, mzzzzzzzzm_);
            object mzzzzzzzzo_(object @this)
            {
                object nzzzzzzzzk_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return nzzzzzzzzk_;
            };
            IEnumerable<object> mzzzzzzzzp_ = context.Operators.Select<object, object>(mzzzzzzzzn_, mzzzzzzzzo_);
            IEnumerable<object> mzzzzzzzzq_ = context.Operators.FlattenLateBoundList(mzzzzzzzzp_);
            Coding mzzzzzzzzr_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> mzzzzzzzzs_ = context.Operators.Select<object, Coding>(mzzzzzzzzq_, mzzzzzzzzr_);
            bool? mzzzzzzzzt_(Coding DiagnosisCode)
            {
                CqlCode nzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? nzzzzzzzzm_ = context.Operators.In<CqlCode>(nzzzzzzzzl_, DiagnosisValueSet);

                return nzzzzzzzzm_;
            };
            IEnumerable<Coding> mzzzzzzzzu_ = context.Operators.Where<Coding>(mzzzzzzzzs_, mzzzzzzzzt_);
            bool? mzzzzzzzzv_ = context.Operators.Exists<Coding>(mzzzzzzzzu_);
            bool? mzzzzzzzzw_ = context.Operators.And(mzzzzzzzzg_, mzzzzzzzzv_);

            return mzzzzzzzzw_;
        };
        IEnumerable<Claim> lzzzzzzzzq_ = context.Operators.Where<Claim>(claim, lzzzzzzzzp_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? lzzzzzzzzr_(Claim ProcedureClaims)
        {
            Id nzzzzzzzzn_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> nzzzzzzzzo_ = ProcedureClaims?.Item;
            bool? nzzzzzzzzp_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept nzzzzzzzzs_ = ResponseItem?.ProductOrService;
                List<Coding> nzzzzzzzzt_ = nzzzzzzzzs_?.Coding;
                bool? nzzzzzzzzu_(Coding ProductOrServiceCode)
                {
                    CqlCode nzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? nzzzzzzzzy_ = context.Operators.In<CqlCode>(nzzzzzzzzx_, ProductOrServiceValueSet);

                    return nzzzzzzzzy_;
                };
                IEnumerable<Coding> nzzzzzzzzv_ = context.Operators.Where<Coding>((IEnumerable<Coding>)nzzzzzzzzt_, nzzzzzzzzu_);
                bool? nzzzzzzzzw_ = context.Operators.Exists<Coding>(nzzzzzzzzv_);

                return nzzzzzzzzw_;
            };
            IEnumerable<Claim.ItemComponent> nzzzzzzzzq_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)nzzzzzzzzo_, nzzzzzzzzp_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? nzzzzzzzzr_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, nzzzzzzzzn_, nzzzzzzzzq_);

            return nzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> lzzzzzzzzs_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(lzzzzzzzzq_, lzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> lzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(lzzzzzzzzs_);

        return lzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services and Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> nzzzzzzzzz_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ozzzzzzzza_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ozzzzzzzzb_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, nzzzzzzzzz_, ozzzzzzzza_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] ozzzzzzzzc_ = [
            ozzzzzzzzb_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzd_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ozzzzzzzzh_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? ozzzzzzzzi_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> ozzzzzzzzr_ = medClaim?.LineItems;
                bool? ozzzzzzzzs_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzzv_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzzw_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> ozzzzzzzzz_ = pClaim?.LineItems;
                        bool? pzzzzzzzza_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id pzzzzzzzze_()
                            {
                                bool pzzzzzzzzs_()
                                {
                                    Claim pzzzzzzzzt_ = medClaim?.ClaimofInterest;
                                    bool pzzzzzzzzu_ = pzzzzzzzzt_ is Resource;

                                    return pzzzzzzzzu_;
                                };
                                if (pzzzzzzzzs_())
                                {
                                    Claim pzzzzzzzzv_ = medClaim?.ClaimofInterest;

                                    return (pzzzzzzzzv_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string pzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzze_());
                            ClaimResponse pzzzzzzzzg_ = pClaim?.Response;
                            ResourceReference pzzzzzzzzh_ = pzzzzzzzzg_?.Request;
                            FhirString pzzzzzzzzi_ = pzzzzzzzzh_?.ReferenceElement;
                            string pzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzi_);
                            string pzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, pzzzzzzzzj_);
                            bool? pzzzzzzzzl_ = context.Operators.Equal(pzzzzzzzzf_, pzzzzzzzzk_);
                            PositiveInt pzzzzzzzzm_ = medClaimLineItem?.SequenceElement;
                            Integer pzzzzzzzzn_ = context.Operators.Convert<Integer>(pzzzzzzzzm_);
                            PositiveInt pzzzzzzzzo_ = pClaimLineItem?.ItemSequenceElement;
                            Integer pzzzzzzzzp_ = context.Operators.Convert<Integer>(pzzzzzzzzo_);
                            bool? pzzzzzzzzq_ = context.Operators.Equal(pzzzzzzzzn_, pzzzzzzzzp_);
                            bool? pzzzzzzzzr_ = context.Operators.And(pzzzzzzzzl_, pzzzzzzzzq_);

                            return pzzzzzzzzr_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> pzzzzzzzzb_ = context.Operators.Where<ClaimResponse.ItemComponent>(ozzzzzzzzz_, pzzzzzzzza_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pzzzzzzzzc_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> pzzzzzzzzd_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(pzzzzzzzzb_, pzzzzzzzzc_);

                        return pzzzzzzzzd_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzzx_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ozzzzzzzzv_, ozzzzzzzzw_);
                    bool? ozzzzzzzzy_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ozzzzzzzzx_);

                    return ozzzzzzzzy_;
                };
                IEnumerable<Claim.ItemComponent> ozzzzzzzzt_ = context.Operators.Where<Claim.ItemComponent>(ozzzzzzzzr_, ozzzzzzzzs_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? ozzzzzzzzu_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, ozzzzzzzzt_);

                return ozzzzzzzzu_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ozzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ozzzzzzzzh_, ozzzzzzzzi_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ozzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ozzzzzzzzj_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ozzzzzzzzl_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, ozzzzzzzzk_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] ozzzzzzzzm_ = [
                ozzzzzzzzl_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzn_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzzw_()
                {
                    bool qzzzzzzzzb_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzc_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? qzzzzzzzzd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> qzzzzzzzzj_ = @this?.ClaimItem;
                            bool? qzzzzzzzzk_ = context.Operators.Not((bool?)(qzzzzzzzzj_ is null));

                            return qzzzzzzzzk_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzze_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(qzzzzzzzzc_, qzzzzzzzzd_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzzf_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> qzzzzzzzzl_ = @this?.ClaimItem;

                            return qzzzzzzzzl_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> qzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(qzzzzzzzze_, qzzzzzzzzf_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzzh_ = context.Operators.Flatten<Claim.ItemComponent>(qzzzzzzzzg_);
                        bool? qzzzzzzzzi_ = context.Operators.Exists<Claim.ItemComponent>(qzzzzzzzzh_);

                        return qzzzzzzzzi_ ?? false;
                    };
                    if (qzzzzzzzzb_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzm_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? qzzzzzzzzn_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? rzzzzzzzzb_ = @this?.PaidClaim;
                            bool? rzzzzzzzzc_ = context.Operators.Not((bool?)(rzzzzzzzzb_ is null));

                            return rzzzzzzzzc_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(qzzzzzzzzm_, qzzzzzzzzn_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? qzzzzzzzzp_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? rzzzzzzzzd_ = @this?.PaidClaim;

                            return rzzzzzzzzd_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> qzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(qzzzzzzzzo_, qzzzzzzzzp_);
                        bool? qzzzzzzzzs_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> rzzzzzzzze_ = @this?.ClaimItem;
                            bool? rzzzzzzzzf_ = context.Operators.Not((bool?)(rzzzzzzzze_ is null));

                            return rzzzzzzzzf_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(qzzzzzzzzm_, qzzzzzzzzs_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzzu_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> rzzzzzzzzg_ = @this?.ClaimItem;

                            return rzzzzzzzzg_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> qzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(qzzzzzzzzt_, qzzzzzzzzu_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzzw_ = context.Operators.Flatten<Claim.ItemComponent>(qzzzzzzzzv_);
                        CqlInterval<CqlDateTime> qzzzzzzzzx_(Claim.ItemComponent PaidItem)
                        {
                            DataType rzzzzzzzzh_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> rzzzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, rzzzzzzzzh_);

                            return rzzzzzzzzi_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzy_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(qzzzzzzzzw_, qzzzzzzzzx_);
                        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzz_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzzzzzzy_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzza_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, qzzzzzzzzq_, qzzzzzzzzz_);

                        return rzzzzzzzza_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] pzzzzzzzzx_ = [
                    pzzzzzzzzw_(),
                ];
                bool? pzzzzzzzzy_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? rzzzzzzzzj_ = context.Operators.Not((bool?)(FinalList is null));

                    return rzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)pzzzzzzzzx_, pzzzzzzzzy_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzzzz_);

                return qzzzzzzzza_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)ozzzzzzzzm_, ozzzzzzzzn_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzo_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzp_);

            return ozzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)ozzzzzzzzc_, ozzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzf_);

        return ozzzzzzzzg_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Service and Condition")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? rzzzzzzzzk_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] rzzzzzzzzl_ = [
            rzzzzzzzzk_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzm_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzu_()
            {
                bool rzzzzzzzzv_()
                {
                    IEnumerable<ClaimResponse> rzzzzzzzzw_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> rzzzzzzzzx_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? rzzzzzzzzy_ = context.Operators.And((bool?)(rzzzzzzzzw_ is null), (bool?)(rzzzzzzzzx_ is null));

                    return rzzzzzzzzy_ ?? false;
                };
                if (rzzzzzzzzv_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> rzzzzzzzzz_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> szzzzzzzza_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzb_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, rzzzzzzzzz_, szzzzzzzza_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return szzzzzzzzb_;
                }
            };

            return rzzzzzzzzu_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)rzzzzzzzzl_, rzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] rzzzzzzzzq_ = [
            rzzzzzzzzp_,
        ];
        bool? rzzzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
        {
            bool? szzzzzzzzc_ = context.Operators.Not((bool?)(FinalList is null));

            return szzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)rzzzzzzzzq_, rzzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzs_);

        return rzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? szzzzzzzzd_(Claim AllClaims)
        {
            List<Claim.ItemComponent> szzzzzzzzi_ = AllClaims?.Item;
            bool? szzzzzzzzj_(Claim.ItemComponent @this)
            {
                CodeableConcept tzzzzzzzzl_ = @this?.ProductOrService;
                bool? tzzzzzzzzm_ = context.Operators.Not((bool?)(tzzzzzzzzl_ is null));

                return tzzzzzzzzm_;
            };
            IEnumerable<Claim.ItemComponent> szzzzzzzzk_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)szzzzzzzzi_, szzzzzzzzj_);
            CodeableConcept szzzzzzzzl_(Claim.ItemComponent @this)
            {
                CodeableConcept tzzzzzzzzn_ = @this?.ProductOrService;

                return tzzzzzzzzn_;
            };
            IEnumerable<CodeableConcept> szzzzzzzzm_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(szzzzzzzzk_, szzzzzzzzl_);
            bool? szzzzzzzzn_(CodeableConcept @this)
            {
                List<Coding> tzzzzzzzzo_ = @this?.Coding;
                bool? tzzzzzzzzp_ = context.Operators.Not((bool?)(tzzzzzzzzo_ is null));

                return tzzzzzzzzp_;
            };
            IEnumerable<CodeableConcept> szzzzzzzzo_ = context.Operators.Where<CodeableConcept>(szzzzzzzzm_, szzzzzzzzn_);
            List<Coding> szzzzzzzzp_(CodeableConcept @this)
            {
                List<Coding> tzzzzzzzzq_ = @this?.Coding;

                return tzzzzzzzzq_;
            };
            IEnumerable<List<Coding>> szzzzzzzzq_ = context.Operators.Select<CodeableConcept, List<Coding>>(szzzzzzzzo_, szzzzzzzzp_);
            IEnumerable<Coding> szzzzzzzzr_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)szzzzzzzzq_);
            bool? szzzzzzzzs_(Coding ProductOrServiceCode)
            {
                CqlCode tzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? tzzzzzzzzs_ = context.Operators.In<CqlCode>(tzzzzzzzzr_, ProductOrServiceValueSet);

                return tzzzzzzzzs_;
            };
            IEnumerable<Coding> szzzzzzzzt_ = context.Operators.Where<Coding>(szzzzzzzzr_, szzzzzzzzs_);
            bool? szzzzzzzzu_ = context.Operators.Exists<Coding>(szzzzzzzzt_);
            List<Claim.DiagnosisComponent> szzzzzzzzv_ = AllClaims?.Diagnosis;
            bool? szzzzzzzzw_(Claim.DiagnosisComponent @this)
            {
                DataType tzzzzzzzzt_ = @this?.Diagnosis;
                bool? tzzzzzzzzu_ = context.Operators.Not((bool?)(tzzzzzzzzt_ is null));

                return tzzzzzzzzu_;
            };
            IEnumerable<Claim.DiagnosisComponent> szzzzzzzzx_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)szzzzzzzzv_, szzzzzzzzw_);
            object szzzzzzzzy_(Claim.DiagnosisComponent @this)
            {
                DataType tzzzzzzzzv_ = @this?.Diagnosis;

                return tzzzzzzzzv_;
            };
            IEnumerable<object> szzzzzzzzz_ = context.Operators.Select<Claim.DiagnosisComponent, object>(szzzzzzzzx_, szzzzzzzzy_);
            bool? tzzzzzzzza_(object @this)
            {
                object tzzzzzzzzw_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? tzzzzzzzzx_ = context.Operators.Not((bool?)(tzzzzzzzzw_ is null));

                return tzzzzzzzzx_;
            };
            IEnumerable<object> tzzzzzzzzb_ = context.Operators.Where<object>(szzzzzzzzz_, tzzzzzzzza_);
            object tzzzzzzzzc_(object @this)
            {
                object tzzzzzzzzy_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return tzzzzzzzzy_;
            };
            IEnumerable<object> tzzzzzzzzd_ = context.Operators.Select<object, object>(tzzzzzzzzb_, tzzzzzzzzc_);
            IEnumerable<object> tzzzzzzzze_ = context.Operators.FlattenLateBoundList(tzzzzzzzzd_);
            Coding tzzzzzzzzf_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> tzzzzzzzzg_ = context.Operators.Select<object, Coding>(tzzzzzzzze_, tzzzzzzzzf_);
            bool? tzzzzzzzzh_(Coding DiagnosisCode)
            {
                CqlCode tzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? uzzzzzzzza_ = context.Operators.In<CqlCode>(tzzzzzzzzz_, DiagnosisValueSet);

                return uzzzzzzzza_;
            };
            IEnumerable<Coding> tzzzzzzzzi_ = context.Operators.Where<Coding>(tzzzzzzzzg_, tzzzzzzzzh_);
            bool? tzzzzzzzzj_ = context.Operators.Exists<Coding>(tzzzzzzzzi_);
            bool? tzzzzzzzzk_ = context.Operators.Or(szzzzzzzzu_, tzzzzzzzzj_);

            return tzzzzzzzzk_;
        };
        IEnumerable<Claim> szzzzzzzze_ = context.Operators.Where<Claim>(claim, szzzzzzzzd_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? szzzzzzzzf_(Claim ProcedureClaims)
        {
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? uzzzzzzzzb_()
            {
                bool uzzzzzzzzc_()
                {
                    List<Claim.ItemComponent> uzzzzzzzzd_ = ProcedureClaims?.Item;
                    bool? uzzzzzzzze_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept uzzzzzzzzh_ = ResponseItem?.ProductOrService;
                        List<Coding> uzzzzzzzzi_ = uzzzzzzzzh_?.Coding;
                        bool? uzzzzzzzzj_(Coding ProductOrServiceCode)
                        {
                            CqlCode uzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? uzzzzzzzzn_ = context.Operators.In<CqlCode>(uzzzzzzzzm_, ProductOrServiceValueSet);

                            return uzzzzzzzzn_;
                        };
                        IEnumerable<Coding> uzzzzzzzzk_ = context.Operators.Where<Coding>((IEnumerable<Coding>)uzzzzzzzzi_, uzzzzzzzzj_);
                        bool? uzzzzzzzzl_ = context.Operators.Exists<Coding>(uzzzzzzzzk_);

                        return uzzzzzzzzl_;
                    };
                    IEnumerable<Claim.ItemComponent> uzzzzzzzzf_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)uzzzzzzzzd_, uzzzzzzzze_);
                    bool? uzzzzzzzzg_ = context.Operators.Exists<Claim.ItemComponent>(uzzzzzzzzf_);

                    return uzzzzzzzzg_ ?? false;
                };
                if (uzzzzzzzzc_())
                {
                    Id uzzzzzzzzo_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> uzzzzzzzzp_ = ProcedureClaims?.Item;
                    bool? uzzzzzzzzq_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept uzzzzzzzzt_ = ResponseItem?.ProductOrService;
                        List<Coding> uzzzzzzzzu_ = uzzzzzzzzt_?.Coding;
                        bool? uzzzzzzzzv_(Coding ProductOrServiceCode)
                        {
                            CqlCode uzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? uzzzzzzzzz_ = context.Operators.In<CqlCode>(uzzzzzzzzy_, ProductOrServiceValueSet);

                            return uzzzzzzzzz_;
                        };
                        IEnumerable<Coding> uzzzzzzzzw_ = context.Operators.Where<Coding>((IEnumerable<Coding>)uzzzzzzzzu_, uzzzzzzzzv_);
                        bool? uzzzzzzzzx_ = context.Operators.Exists<Coding>(uzzzzzzzzw_);

                        return uzzzzzzzzx_;
                    };
                    IEnumerable<Claim.ItemComponent> uzzzzzzzzr_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)uzzzzzzzzp_, uzzzzzzzzq_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? uzzzzzzzzs_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, uzzzzzzzzo_, uzzzzzzzzr_);

                    return uzzzzzzzzs_;
                }
                else
                {
                    Id vzzzzzzzza_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> vzzzzzzzzb_ = ProcedureClaims?.Item;
                    bool? vzzzzzzzzc_(Claim.ItemComponent ResponseItem)
                    {
                        PositiveInt vzzzzzzzzf_ = ResponseItem?.SequenceElement;
                        Integer vzzzzzzzzg_ = context.Operators.Convert<Integer>(vzzzzzzzzf_);
                        int? vzzzzzzzzh_ = vzzzzzzzzg_?.Value;
                        bool? vzzzzzzzzi_ = context.Operators.Equal(vzzzzzzzzh_, 1);

                        return vzzzzzzzzi_;
                    };
                    IEnumerable<Claim.ItemComponent> vzzzzzzzzd_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)vzzzzzzzzb_, vzzzzzzzzc_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? vzzzzzzzze_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, vzzzzzzzza_, vzzzzzzzzd_);

                    return vzzzzzzzze_;
                }
            };

            return uzzzzzzzzb_();
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> szzzzzzzzg_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(szzzzzzzze_, szzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> szzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(szzzzzzzzg_);

        return szzzzzzzzh_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzzj_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> vzzzzzzzzk_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? vzzzzzzzzl_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, vzzzzzzzzj_, vzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] vzzzzzzzzm_ = [
            vzzzzzzzzl_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzzn_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> vzzzzzzzzr_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? vzzzzzzzzs_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> wzzzzzzzzb_ = medClaim?.LineItems;
                bool? wzzzzzzzzc_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> wzzzzzzzzf_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> wzzzzzzzzg_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> wzzzzzzzzj_ = pClaim?.LineItems;
                        bool? wzzzzzzzzk_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id wzzzzzzzzo_()
                            {
                                bool xzzzzzzzzc_()
                                {
                                    Claim xzzzzzzzzd_ = medClaim?.ClaimofInterest;
                                    bool xzzzzzzzze_ = xzzzzzzzzd_ is Resource;

                                    return xzzzzzzzze_;
                                };
                                if (xzzzzzzzzc_())
                                {
                                    Claim xzzzzzzzzf_ = medClaim?.ClaimofInterest;

                                    return (xzzzzzzzzf_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string wzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzo_());
                            ClaimResponse wzzzzzzzzq_ = pClaim?.Response;
                            ResourceReference wzzzzzzzzr_ = wzzzzzzzzq_?.Request;
                            FhirString wzzzzzzzzs_ = wzzzzzzzzr_?.ReferenceElement;
                            string wzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzs_);
                            string wzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, wzzzzzzzzt_);
                            bool? wzzzzzzzzv_ = context.Operators.Equal(wzzzzzzzzp_, wzzzzzzzzu_);
                            PositiveInt wzzzzzzzzw_ = medClaimLineItem?.SequenceElement;
                            Integer wzzzzzzzzx_ = context.Operators.Convert<Integer>(wzzzzzzzzw_);
                            PositiveInt wzzzzzzzzy_ = pClaimLineItem?.ItemSequenceElement;
                            Integer wzzzzzzzzz_ = context.Operators.Convert<Integer>(wzzzzzzzzy_);
                            bool? xzzzzzzzza_ = context.Operators.Equal(wzzzzzzzzx_, wzzzzzzzzz_);
                            bool? xzzzzzzzzb_ = context.Operators.And(wzzzzzzzzv_, xzzzzzzzza_);

                            return xzzzzzzzzb_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> wzzzzzzzzl_ = context.Operators.Where<ClaimResponse.ItemComponent>(wzzzzzzzzj_, wzzzzzzzzk_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? wzzzzzzzzm_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> wzzzzzzzzn_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(wzzzzzzzzl_, wzzzzzzzzm_);

                        return wzzzzzzzzn_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> wzzzzzzzzh_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(wzzzzzzzzf_, wzzzzzzzzg_);
                    bool? wzzzzzzzzi_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(wzzzzzzzzh_);

                    return wzzzzzzzzi_;
                };
                IEnumerable<Claim.ItemComponent> wzzzzzzzzd_ = context.Operators.Where<Claim.ItemComponent>(wzzzzzzzzb_, wzzzzzzzzc_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? wzzzzzzzze_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, wzzzzzzzzd_);

                return wzzzzzzzze_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(vzzzzzzzzr_, vzzzzzzzzs_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(vzzzzzzzzt_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? vzzzzzzzzv_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, vzzzzzzzzu_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] vzzzzzzzzw_ = [
                vzzzzzzzzv_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzzx_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? xzzzzzzzzg_()
                {
                    bool xzzzzzzzzl_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> xzzzzzzzzm_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? xzzzzzzzzn_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzzt_ = @this?.ClaimItem;
                            bool? xzzzzzzzzu_ = context.Operators.Not((bool?)(xzzzzzzzzt_ is null));

                            return xzzzzzzzzu_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> xzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(xzzzzzzzzm_, xzzzzzzzzn_);
                        IEnumerable<Claim.ItemComponent> xzzzzzzzzp_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzzv_ = @this?.ClaimItem;

                            return xzzzzzzzzv_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> xzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(xzzzzzzzzo_, xzzzzzzzzp_);
                        IEnumerable<Claim.ItemComponent> xzzzzzzzzr_ = context.Operators.Flatten<Claim.ItemComponent>(xzzzzzzzzq_);
                        bool? xzzzzzzzzs_ = context.Operators.Exists<Claim.ItemComponent>(xzzzzzzzzr_);

                        return xzzzzzzzzs_ ?? false;
                    };
                    if (xzzzzzzzzl_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> xzzzzzzzzw_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? xzzzzzzzzx_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? yzzzzzzzzl_ = @this?.PaidClaim;
                            bool? yzzzzzzzzm_ = context.Operators.Not((bool?)(yzzzzzzzzl_ is null));

                            return yzzzzzzzzm_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> xzzzzzzzzy_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(xzzzzzzzzw_, xzzzzzzzzx_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? xzzzzzzzzz_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? yzzzzzzzzn_ = @this?.PaidClaim;

                            return yzzzzzzzzn_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> yzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(xzzzzzzzzy_, xzzzzzzzzz_);
                        bool? yzzzzzzzzc_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> yzzzzzzzzo_ = @this?.ClaimItem;
                            bool? yzzzzzzzzp_ = context.Operators.Not((bool?)(yzzzzzzzzo_ is null));

                            return yzzzzzzzzp_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> yzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(xzzzzzzzzw_, yzzzzzzzzc_);
                        IEnumerable<Claim.ItemComponent> yzzzzzzzze_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> yzzzzzzzzq_ = @this?.ClaimItem;

                            return yzzzzzzzzq_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> yzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(yzzzzzzzzd_, yzzzzzzzze_);
                        IEnumerable<Claim.ItemComponent> yzzzzzzzzg_ = context.Operators.Flatten<Claim.ItemComponent>(yzzzzzzzzf_);
                        CqlInterval<CqlDateTime> yzzzzzzzzh_(Claim.ItemComponent PaidItem)
                        {
                            DataType yzzzzzzzzr_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> yzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, yzzzzzzzzr_);

                            return yzzzzzzzzs_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzi_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(yzzzzzzzzg_, yzzzzzzzzh_);
                        IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzi_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzk_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, yzzzzzzzza_, yzzzzzzzzj_);

                        return yzzzzzzzzk_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] xzzzzzzzzh_ = [
                    xzzzzzzzzg_(),
                ];
                bool? xzzzzzzzzi_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? yzzzzzzzzt_ = context.Operators.Not((bool?)(FinalList is null));

                    return yzzzzzzzzt_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)xzzzzzzzzh_, xzzzzzzzzi_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? xzzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(xzzzzzzzzj_);

                return xzzzzzzzzk_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> vzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)vzzzzzzzzw_, vzzzzzzzzx_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> vzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzzy_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzzz_);

            return wzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> vzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)vzzzzzzzzm_, vzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> vzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzzp_);

        return vzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? yzzzzzzzzu_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] yzzzzzzzzv_ = [
            yzzzzzzzzu_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzw_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? zzzzzzzzza_()
            {
                bool zzzzzzzzzb_()
                {
                    IEnumerable<ClaimResponse> zzzzzzzzzc_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> zzzzzzzzzd_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? zzzzzzzzze_ = context.Operators.And((bool?)(zzzzzzzzzc_ is null), (bool?)(zzzzzzzzzd_ is null));

                    return zzzzzzzzze_ ?? false;
                };
                if (zzzzzzzzzb_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> zzzzzzzzzf_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> zzzzzzzzzg_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? zzzzzzzzzh_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, zzzzzzzzzf_, zzzzzzzzzg_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return zzzzzzzzzh_;
                }
            };

            return zzzzzzzzza_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)yzzzzzzzzv_, yzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzzy_);

        return yzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure Only")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        bool? zzzzzzzzzi_(Claim AllClaims)
        {
            List<Claim.ItemComponent> zzzzzzzzzn_ = AllClaims?.Item;
            bool? zzzzzzzzzo_(Claim.ItemComponent @this)
            {
                CodeableConcept azzzzzzzzza_ = @this?.ProductOrService;
                bool? azzzzzzzzzb_ = context.Operators.Not((bool?)(azzzzzzzzza_ is null));

                return azzzzzzzzzb_;
            };
            IEnumerable<Claim.ItemComponent> zzzzzzzzzp_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)zzzzzzzzzn_, zzzzzzzzzo_);
            CodeableConcept zzzzzzzzzq_(Claim.ItemComponent @this)
            {
                CodeableConcept azzzzzzzzzc_ = @this?.ProductOrService;

                return azzzzzzzzzc_;
            };
            IEnumerable<CodeableConcept> zzzzzzzzzr_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(zzzzzzzzzp_, zzzzzzzzzq_);
            bool? zzzzzzzzzs_(CodeableConcept @this)
            {
                List<Coding> azzzzzzzzzd_ = @this?.Coding;
                bool? azzzzzzzzze_ = context.Operators.Not((bool?)(azzzzzzzzzd_ is null));

                return azzzzzzzzze_;
            };
            IEnumerable<CodeableConcept> zzzzzzzzzt_ = context.Operators.Where<CodeableConcept>(zzzzzzzzzr_, zzzzzzzzzs_);
            List<Coding> zzzzzzzzzu_(CodeableConcept @this)
            {
                List<Coding> azzzzzzzzzf_ = @this?.Coding;

                return azzzzzzzzzf_;
            };
            IEnumerable<List<Coding>> zzzzzzzzzv_ = context.Operators.Select<CodeableConcept, List<Coding>>(zzzzzzzzzt_, zzzzzzzzzu_);
            IEnumerable<Coding> zzzzzzzzzw_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)zzzzzzzzzv_);
            bool? zzzzzzzzzx_(Coding ProductOrServiceCode)
            {
                CqlCode azzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? azzzzzzzzzh_ = context.Operators.In<CqlCode>(azzzzzzzzzg_, ProductOrServiceValueSet);

                return azzzzzzzzzh_;
            };
            IEnumerable<Coding> zzzzzzzzzy_ = context.Operators.Where<Coding>(zzzzzzzzzw_, zzzzzzzzzx_);
            bool? zzzzzzzzzz_ = context.Operators.Exists<Coding>(zzzzzzzzzy_);

            return zzzzzzzzzz_;
        };
        IEnumerable<Claim> zzzzzzzzzj_ = context.Operators.Where<Claim>(claim, zzzzzzzzzi_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? zzzzzzzzzk_(Claim AllClaims)
        {
            Id azzzzzzzzzi_ = AllClaims?.IdElement;
            List<Claim.ItemComponent> azzzzzzzzzj_ = AllClaims?.Item;
            bool? azzzzzzzzzk_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept azzzzzzzzzn_ = ResponseItem?.ProductOrService;
                List<Coding> azzzzzzzzzo_ = azzzzzzzzzn_?.Coding;
                bool? azzzzzzzzzp_(Coding ProductOrServiceCode)
                {
                    CqlCode azzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? azzzzzzzzzt_ = context.Operators.In<CqlCode>(azzzzzzzzzs_, ProductOrServiceValueSet);

                    return azzzzzzzzzt_;
                };
                IEnumerable<Coding> azzzzzzzzzq_ = context.Operators.Where<Coding>((IEnumerable<Coding>)azzzzzzzzzo_, azzzzzzzzzp_);
                bool? azzzzzzzzzr_ = context.Operators.Exists<Coding>(azzzzzzzzzq_);

                return azzzzzzzzzr_;
            };
            IEnumerable<Claim.ItemComponent> azzzzzzzzzl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)azzzzzzzzzj_, azzzzzzzzzk_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? azzzzzzzzzm_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, azzzzzzzzzi_, azzzzzzzzzl_);

            return azzzzzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> zzzzzzzzzl_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(zzzzzzzzzj_, zzzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> zzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(zzzzzzzzzl_);

        return zzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> azzzzzzzzzu_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> azzzzzzzzzv_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? azzzzzzzzzw_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, azzzzzzzzzu_, azzzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] azzzzzzzzzx_ = [
            azzzzzzzzzw_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzzy_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bzzzzzzzzzc_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? bzzzzzzzzzd_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> bzzzzzzzzzm_ = medClaim?.LineItems;
                bool? bzzzzzzzzzn_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> bzzzzzzzzzq_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> bzzzzzzzzzr_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> bzzzzzzzzzu_ = pClaim?.LineItems;
                        bool? bzzzzzzzzzv_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id bzzzzzzzzzz_()
                            {
                                bool czzzzzzzzzn_()
                                {
                                    Claim czzzzzzzzzo_ = medClaim?.ClaimofInterest;
                                    bool czzzzzzzzzp_ = czzzzzzzzzo_ is Resource;

                                    return czzzzzzzzzp_;
                                };
                                if (czzzzzzzzzn_())
                                {
                                    Claim czzzzzzzzzq_ = medClaim?.ClaimofInterest;

                                    return (czzzzzzzzzq_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string czzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzzz_());
                            ClaimResponse czzzzzzzzzb_ = pClaim?.Response;
                            ResourceReference czzzzzzzzzc_ = czzzzzzzzzb_?.Request;
                            FhirString czzzzzzzzzd_ = czzzzzzzzzc_?.ReferenceElement;
                            string czzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzd_);
                            string czzzzzzzzzf_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, czzzzzzzzze_);
                            bool? czzzzzzzzzg_ = context.Operators.Equal(czzzzzzzzza_, czzzzzzzzzf_);
                            PositiveInt czzzzzzzzzh_ = medClaimLineItem?.SequenceElement;
                            Integer czzzzzzzzzi_ = context.Operators.Convert<Integer>(czzzzzzzzzh_);
                            PositiveInt czzzzzzzzzj_ = pClaimLineItem?.ItemSequenceElement;
                            Integer czzzzzzzzzk_ = context.Operators.Convert<Integer>(czzzzzzzzzj_);
                            bool? czzzzzzzzzl_ = context.Operators.Equal(czzzzzzzzzi_, czzzzzzzzzk_);
                            bool? czzzzzzzzzm_ = context.Operators.And(czzzzzzzzzg_, czzzzzzzzzl_);

                            return czzzzzzzzzm_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> bzzzzzzzzzw_ = context.Operators.Where<ClaimResponse.ItemComponent>(bzzzzzzzzzu_, bzzzzzzzzzv_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? bzzzzzzzzzx_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> bzzzzzzzzzy_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(bzzzzzzzzzw_, bzzzzzzzzzx_);

                        return bzzzzzzzzzy_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> bzzzzzzzzzs_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(bzzzzzzzzzq_, bzzzzzzzzzr_);
                    bool? bzzzzzzzzzt_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(bzzzzzzzzzs_);

                    return bzzzzzzzzzt_;
                };
                IEnumerable<Claim.ItemComponent> bzzzzzzzzzo_ = context.Operators.Where<Claim.ItemComponent>(bzzzzzzzzzm_, bzzzzzzzzzn_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? bzzzzzzzzzp_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, bzzzzzzzzzo_);

                return bzzzzzzzzzp_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bzzzzzzzzzc_, bzzzzzzzzzd_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> bzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bzzzzzzzzze_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? bzzzzzzzzzg_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, bzzzzzzzzzf_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] bzzzzzzzzzh_ = [
                bzzzzzzzzzg_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzi_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzzr_()
                {
                    bool czzzzzzzzzw_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzx_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? czzzzzzzzzy_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> dzzzzzzzzze_ = @this?.ClaimItem;
                            bool? dzzzzzzzzzf_ = context.Operators.Not((bool?)(dzzzzzzzzze_ is null));

                            return dzzzzzzzzzf_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(czzzzzzzzzx_, czzzzzzzzzy_);
                        IEnumerable<Claim.ItemComponent> dzzzzzzzzza_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> dzzzzzzzzzg_ = @this?.ClaimItem;

                            return dzzzzzzzzzg_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> dzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(czzzzzzzzzz_, dzzzzzzzzza_);
                        IEnumerable<Claim.ItemComponent> dzzzzzzzzzc_ = context.Operators.Flatten<Claim.ItemComponent>(dzzzzzzzzzb_);
                        bool? dzzzzzzzzzd_ = context.Operators.Exists<Claim.ItemComponent>(dzzzzzzzzzc_);

                        return dzzzzzzzzzd_ ?? false;
                    };
                    if (czzzzzzzzzw_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> dzzzzzzzzzh_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? dzzzzzzzzzi_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? dzzzzzzzzzw_ = @this?.PaidClaim;
                            bool? dzzzzzzzzzx_ = context.Operators.Not((bool?)(dzzzzzzzzzw_ is null));

                            return dzzzzzzzzzx_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> dzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(dzzzzzzzzzh_, dzzzzzzzzzi_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? dzzzzzzzzzk_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? dzzzzzzzzzy_ = @this?.PaidClaim;

                            return dzzzzzzzzzy_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> dzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(dzzzzzzzzzj_, dzzzzzzzzzk_);
                        bool? dzzzzzzzzzn_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> dzzzzzzzzzz_ = @this?.ClaimItem;
                            bool? ezzzzzzzzza_ = context.Operators.Not((bool?)(dzzzzzzzzzz_ is null));

                            return ezzzzzzzzza_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> dzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(dzzzzzzzzzh_, dzzzzzzzzzn_);
                        IEnumerable<Claim.ItemComponent> dzzzzzzzzzp_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ezzzzzzzzzb_ = @this?.ClaimItem;

                            return ezzzzzzzzzb_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> dzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(dzzzzzzzzzo_, dzzzzzzzzzp_);
                        IEnumerable<Claim.ItemComponent> dzzzzzzzzzr_ = context.Operators.Flatten<Claim.ItemComponent>(dzzzzzzzzzq_);
                        CqlInterval<CqlDateTime> dzzzzzzzzzs_(Claim.ItemComponent PaidItem)
                        {
                            DataType ezzzzzzzzzc_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> ezzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ezzzzzzzzzc_);

                            return ezzzzzzzzzd_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzt_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(dzzzzzzzzzr_, dzzzzzzzzzs_);
                        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzu_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzzzzzzzzt_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzv_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, dzzzzzzzzzl_, dzzzzzzzzzu_);

                        return dzzzzzzzzzv_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] czzzzzzzzzs_ = [
                    czzzzzzzzzr_(),
                ];
                bool? czzzzzzzzzt_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? ezzzzzzzzze_ = context.Operators.Not((bool?)(FinalList is null));

                    return ezzzzzzzzze_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)czzzzzzzzzs_, czzzzzzzzzt_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzzu_);

                return czzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)bzzzzzzzzzh_, bzzzzzzzzzi_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzzj_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzzk_);

            return bzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)azzzzzzzzzx_, azzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzzz_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzza_);

        return bzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? ezzzzzzzzzf_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] ezzzzzzzzzg_ = [
            ezzzzzzzzzf_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzzh_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzzl_()
            {
                bool ezzzzzzzzzm_()
                {
                    IEnumerable<ClaimResponse> ezzzzzzzzzn_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> ezzzzzzzzzo_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? ezzzzzzzzzp_ = context.Operators.And((bool?)(ezzzzzzzzzn_ is null), (bool?)(ezzzzzzzzzo_ is null));

                    return ezzzzzzzzzp_ ?? false;
                };
                if (ezzzzzzzzzm_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> ezzzzzzzzzq_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> ezzzzzzzzzr_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzzs_ = this.Get_Corresponding_Claim_for_Services_Only(context, ezzzzzzzzzq_, ezzzzzzzzzr_, ProductOrServiceValueSet);

                    return ezzzzzzzzzs_;
                }
            };

            return ezzzzzzzzzl_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ezzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)ezzzzzzzzzg_, ezzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ezzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ezzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ezzzzzzzzzj_);

        return ezzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Get All Pharmacy Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> ezzzzzzzzzt_ = this.Pharmacy_Claims_Response(context, claimResponse);
        IEnumerable<Claim> ezzzzzzzzzu_ = this.Pharmacy_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? ezzzzzzzzzv_ = (CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV, ezzzzzzzzzt_, ezzzzzzzzzu_);

        return ezzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ezzzzzzzzzw_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ezzzzzzzzzx_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ezzzzzzzzzy_ = (CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF, ezzzzzzzzzw_, ezzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[] ezzzzzzzzzz_ = [
            ezzzzzzzzzy_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? fzzzzzzzzza_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> fzzzzzzzzze_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? fzzzzzzzzzf_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> fzzzzzzzzzo_ = medClaim?.LineItem;
                bool? fzzzzzzzzzp_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> fzzzzzzzzzs_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> fzzzzzzzzzt_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> fzzzzzzzzzw_ = pClaim?.LineItems;
                        bool? fzzzzzzzzzx_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id gzzzzzzzzzb_()
                            {
                                bool gzzzzzzzzzp_()
                                {
                                    Claim gzzzzzzzzzq_ = medClaim?.Claim;
                                    bool gzzzzzzzzzr_ = gzzzzzzzzzq_ is Resource;

                                    return gzzzzzzzzzr_;
                                };
                                if (gzzzzzzzzzp_())
                                {
                                    Claim gzzzzzzzzzs_ = medClaim?.Claim;

                                    return (gzzzzzzzzzs_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string gzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzb_());
                            ClaimResponse gzzzzzzzzzd_ = pClaim?.Response;
                            ResourceReference gzzzzzzzzze_ = gzzzzzzzzzd_?.Request;
                            FhirString gzzzzzzzzzf_ = gzzzzzzzzze_?.ReferenceElement;
                            string gzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzf_);
                            string gzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, gzzzzzzzzzg_);
                            bool? gzzzzzzzzzi_ = context.Operators.Equal(gzzzzzzzzzc_, gzzzzzzzzzh_);
                            PositiveInt gzzzzzzzzzj_ = medClaimLineItem?.SequenceElement;
                            Integer gzzzzzzzzzk_ = context.Operators.Convert<Integer>(gzzzzzzzzzj_);
                            PositiveInt gzzzzzzzzzl_ = pClaimLineItem?.ItemSequenceElement;
                            Integer gzzzzzzzzzm_ = context.Operators.Convert<Integer>(gzzzzzzzzzl_);
                            bool? gzzzzzzzzzn_ = context.Operators.Equal(gzzzzzzzzzk_, gzzzzzzzzzm_);
                            bool? gzzzzzzzzzo_ = context.Operators.And(gzzzzzzzzzi_, gzzzzzzzzzn_);

                            return gzzzzzzzzzo_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> fzzzzzzzzzy_ = context.Operators.Where<ClaimResponse.ItemComponent>(fzzzzzzzzzw_, fzzzzzzzzzx_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? fzzzzzzzzzz_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> gzzzzzzzzza_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(fzzzzzzzzzy_, fzzzzzzzzzz_);

                        return gzzzzzzzzza_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> fzzzzzzzzzu_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(fzzzzzzzzzs_, fzzzzzzzzzt_);
                    bool? fzzzzzzzzzv_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(fzzzzzzzzzu_);

                    return fzzzzzzzzzv_;
                };
                IEnumerable<Claim.ItemComponent> fzzzzzzzzzq_ = context.Operators.Where<Claim.ItemComponent>(fzzzzzzzzzo_, fzzzzzzzzzp_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? fzzzzzzzzzr_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, fzzzzzzzzzq_);

                return fzzzzzzzzzr_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> fzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(fzzzzzzzzze_, fzzzzzzzzzf_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> fzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(fzzzzzzzzzg_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? fzzzzzzzzzi_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, fzzzzzzzzzh_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] fzzzzzzzzzj_ = [
                fzzzzzzzzzi_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? fzzzzzzzzzk_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? gzzzzzzzzzt_()
                {
                    bool gzzzzzzzzzy_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> gzzzzzzzzzz_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? hzzzzzzzzza_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzzg_ = @this?.ClaimItem;
                            bool? hzzzzzzzzzh_ = context.Operators.Not((bool?)(hzzzzzzzzzg_ is null));

                            return hzzzzzzzzzh_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> hzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(gzzzzzzzzzz_, hzzzzzzzzza_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzzc_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzzi_ = @this?.ClaimItem;

                            return hzzzzzzzzzi_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> hzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(hzzzzzzzzzb_, hzzzzzzzzzc_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzze_ = context.Operators.Flatten<Claim.ItemComponent>(hzzzzzzzzzd_);
                        bool? hzzzzzzzzzf_ = context.Operators.Exists<Claim.ItemComponent>(hzzzzzzzzze_);

                        return hzzzzzzzzzf_ ?? false;
                    };
                    if (gzzzzzzzzzy_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> hzzzzzzzzzj_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? hzzzzzzzzzk_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? izzzzzzzzzh_ = @this?.PaidClaim;
                            bool? izzzzzzzzzi_ = context.Operators.Not((bool?)(izzzzzzzzzh_ is null));

                            return izzzzzzzzzi_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> hzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(hzzzzzzzzzj_, hzzzzzzzzzk_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? hzzzzzzzzzm_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? izzzzzzzzzj_ = @this?.PaidClaim;

                            return izzzzzzzzzj_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> hzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(hzzzzzzzzzl_, hzzzzzzzzzm_);
                        bool? hzzzzzzzzzp_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> izzzzzzzzzk_ = @this?.ClaimItem;
                            bool? izzzzzzzzzl_ = context.Operators.Not((bool?)(izzzzzzzzzk_ is null));

                            return izzzzzzzzzl_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> hzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(hzzzzzzzzzj_, hzzzzzzzzzp_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> izzzzzzzzzm_ = @this?.ClaimItem;

                            return izzzzzzzzzm_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> hzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(hzzzzzzzzzq_, hzzzzzzzzzr_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzzt_ = context.Operators.Flatten<Claim.ItemComponent>(hzzzzzzzzzs_);
                        CqlInterval<CqlDateTime> hzzzzzzzzzu_(Claim.ItemComponent PaidItem)
                        {
                            DataType izzzzzzzzzn_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> izzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzn_);

                            return izzzzzzzzzo_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzv_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(hzzzzzzzzzt_, hzzzzzzzzzu_);
                        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(hzzzzzzzzzv_);
                        bool? hzzzzzzzzzy_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> izzzzzzzzzp_ = @this?.ClaimItem;
                            bool? izzzzzzzzzq_ = context.Operators.Not((bool?)(izzzzzzzzzp_ is null));

                            return izzzzzzzzzq_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> hzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(hzzzzzzzzzj_, hzzzzzzzzzy_);
                        IEnumerable<Claim.ItemComponent> izzzzzzzzza_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> izzzzzzzzzr_ = @this?.ClaimItem;

                            return izzzzzzzzzr_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> izzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(hzzzzzzzzzz_, izzzzzzzzza_);
                        IEnumerable<Claim.ItemComponent> izzzzzzzzzc_ = context.Operators.Flatten<Claim.ItemComponent>(izzzzzzzzzb_);
                        CqlInterval<CqlDate> izzzzzzzzzd_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDate> izzzzzzzzzs_()
                            {
                                bool izzzzzzzzzt_()
                                {
                                    Quantity izzzzzzzzzu_ = i?.Quantity;
                                    bool? izzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzu_ is null));

                                    return izzzzzzzzzv_ ?? false;
                                };
                                if (izzzzzzzzzt_())
                                {
                                    DataType izzzzzzzzzw_ = i?.Serviced;
                                    CqlInterval<CqlDateTime> izzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzw_);
                                    CqlDateTime izzzzzzzzzy_ = context.Operators.Start(izzzzzzzzzx_);
                                    CqlDate izzzzzzzzzz_ = context.Operators.ConvertDateTimeToDate(izzzzzzzzzy_);
                                    CqlInterval<CqlDateTime> jzzzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzw_);
                                    CqlDateTime jzzzzzzzzzc_ = context.Operators.Start(jzzzzzzzzzb_);
                                    Quantity jzzzzzzzzzd_ = i?.Quantity;
                                    FhirDecimal jzzzzzzzzze_ = jzzzzzzzzzd_?.ValueElement;
                                    decimal? jzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, jzzzzzzzzze_);
                                    CqlDateTime jzzzzzzzzzg_ = context.Operators.Add(jzzzzzzzzzc_, new CqlQuantity(jzzzzzzzzzf_, "day"));
                                    CqlQuantity jzzzzzzzzzh_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime jzzzzzzzzzi_ = context.Operators.Subtract(jzzzzzzzzzg_, jzzzzzzzzzh_);
                                    CqlDate jzzzzzzzzzj_ = context.Operators.ConvertDateTimeToDate(jzzzzzzzzzi_);
                                    CqlInterval<CqlDate> jzzzzzzzzzk_ = context.Operators.Interval(izzzzzzzzzz_, jzzzzzzzzzj_, true, true);

                                    return jzzzzzzzzzk_;
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDate>;
                                }
                            };

                            return izzzzzzzzzs_();
                        };
                        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzze_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(izzzzzzzzzc_, izzzzzzzzzd_);
                        IEnumerable<CqlInterval<CqlDate>> izzzzzzzzzf_ = context.Operators.Distinct<CqlInterval<CqlDate>>(izzzzzzzzze_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? izzzzzzzzzg_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, hzzzzzzzzzn_, hzzzzzzzzzw_, izzzzzzzzzf_);

                        return izzzzzzzzzg_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] gzzzzzzzzzu_ = [
                    gzzzzzzzzzt_(),
                ];
                bool? gzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList)
                {
                    bool? jzzzzzzzzzl_ = context.Operators.Not((bool?)(FinalList is null));

                    return jzzzzzzzzzl_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> gzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)gzzzzzzzzzu_, gzzzzzzzzzv_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? gzzzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(gzzzzzzzzzw_);

                return gzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> fzzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)fzzzzzzzzzj_, fzzzzzzzzzk_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> fzzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(fzzzzzzzzzl_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? fzzzzzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(fzzzzzzzzzm_);

            return fzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> fzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)ezzzzzzzzzz_, fzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> fzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(fzzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? fzzzzzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(fzzzzzzzzzc_);

        return fzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? jzzzzzzzzzm_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] jzzzzzzzzzn_ = [
            jzzzzzzzzzm_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? jzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? jzzzzzzzzzs_()
            {
                bool jzzzzzzzzzt_()
                {
                    IEnumerable<ClaimResponse> jzzzzzzzzzu_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> jzzzzzzzzzv_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    bool? jzzzzzzzzzw_ = context.Operators.And((bool?)(jzzzzzzzzzu_ is null), (bool?)(jzzzzzzzzzv_ is null));

                    return jzzzzzzzzzw_ ?? false;
                };
                if (jzzzzzzzzzt_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> jzzzzzzzzzx_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> jzzzzzzzzzy_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? jzzzzzzzzzz_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, jzzzzzzzzzx_, jzzzzzzzzzy_, ProductOrServiceValueSet);

                    return jzzzzzzzzzz_;
                }
            };

            return jzzzzzzzzzs_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> jzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)jzzzzzzzzzn_, jzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> jzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(jzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? jzzzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(jzzzzzzzzzq_);

        return jzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Get Claim With Corresponding Claim Response")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? kzzzzzzzzza_(Claim Claim)
        {
            bool? kzzzzzzzzzd_(ClaimResponse CR)
            {
                Id kzzzzzzzzzi_ = Claim?.IdElement;
                string kzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzi_);
                ResourceReference kzzzzzzzzzk_ = CR?.Request;
                FhirString kzzzzzzzzzl_ = kzzzzzzzzzk_?.ReferenceElement;
                string kzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzl_);
                string kzzzzzzzzzn_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, kzzzzzzzzzm_);
                bool? kzzzzzzzzzo_ = context.Operators.Equal(kzzzzzzzzzj_, kzzzzzzzzzn_);

                return kzzzzzzzzzo_;
            };
            IEnumerable<ClaimResponse> kzzzzzzzzze_ = context.Operators.Where<ClaimResponse>(claimResponse, kzzzzzzzzzd_);
            bool? kzzzzzzzzzf_(Claim C)
            {
                Id kzzzzzzzzzp_ = Claim?.IdElement;
                string kzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzp_);
                bool? kzzzzzzzzzr_(ClaimResponse CR)
                {
                    Id lzzzzzzzzzf_ = Claim?.IdElement;
                    string lzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzf_);
                    ResourceReference lzzzzzzzzzh_ = CR?.Request;
                    FhirString lzzzzzzzzzi_ = lzzzzzzzzzh_?.ReferenceElement;
                    string lzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzi_);
                    string lzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, lzzzzzzzzzj_);
                    bool? lzzzzzzzzzl_ = context.Operators.Equal(lzzzzzzzzzg_, lzzzzzzzzzk_);

                    return lzzzzzzzzzl_;
                };
                IEnumerable<ClaimResponse> kzzzzzzzzzs_ = context.Operators.Where<ClaimResponse>(claimResponse, kzzzzzzzzzr_);
                bool? kzzzzzzzzzt_(ClaimResponse @this)
                {
                    ResourceReference lzzzzzzzzzm_ = @this?.Request;
                    bool? lzzzzzzzzzn_ = context.Operators.Not((bool?)(lzzzzzzzzzm_ is null));

                    return lzzzzzzzzzn_;
                };
                IEnumerable<ClaimResponse> kzzzzzzzzzu_ = context.Operators.Where<ClaimResponse>(kzzzzzzzzzs_, kzzzzzzzzzt_);
                ResourceReference kzzzzzzzzzv_(ClaimResponse @this)
                {
                    ResourceReference lzzzzzzzzzo_ = @this?.Request;

                    return lzzzzzzzzzo_;
                };
                IEnumerable<ResourceReference> kzzzzzzzzzw_ = context.Operators.Select<ClaimResponse, ResourceReference>(kzzzzzzzzzu_, kzzzzzzzzzv_);
                bool? kzzzzzzzzzx_(ResourceReference @this)
                {
                    FhirString lzzzzzzzzzp_ = @this?.ReferenceElement;
                    bool? lzzzzzzzzzq_ = context.Operators.Not((bool?)(lzzzzzzzzzp_ is null));

                    return lzzzzzzzzzq_;
                };
                IEnumerable<ResourceReference> kzzzzzzzzzy_ = context.Operators.Where<ResourceReference>(kzzzzzzzzzw_, kzzzzzzzzzx_);
                FhirString kzzzzzzzzzz_(ResourceReference @this)
                {
                    FhirString lzzzzzzzzzr_ = @this?.ReferenceElement;

                    return lzzzzzzzzzr_;
                };
                IEnumerable<FhirString> lzzzzzzzzza_ = context.Operators.Select<ResourceReference, FhirString>(kzzzzzzzzzy_, kzzzzzzzzzz_);
                FhirString lzzzzzzzzzb_ = context.Operators.SingletonFrom<FhirString>(lzzzzzzzzza_);
                string lzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzb_);
                string lzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, lzzzzzzzzzc_);
                bool? lzzzzzzzzze_ = context.Operators.Equal(kzzzzzzzzzq_, lzzzzzzzzzd_);

                return lzzzzzzzzze_;
            };
            IEnumerable<Claim> kzzzzzzzzzg_ = context.Operators.Where<Claim>(claim, kzzzzzzzzzf_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? kzzzzzzzzzh_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, kzzzzzzzzze_, kzzzzzzzzzg_);

            return kzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> kzzzzzzzzzb_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, kzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> kzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(kzzzzzzzzzb_);

        return kzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim> claim)
    {
        IEnumerable<Claim> lzzzzzzzzzs_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? lzzzzzzzzzt_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, lzzzzzzzzzs_, default, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] lzzzzzzzzzu_ = [
            lzzzzzzzzzt_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? lzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithInpatientStay)
        {
            IEnumerable<Claim> lzzzzzzzzzz_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> mzzzzzzzzzh_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? mzzzzzzzzzi_(Claim c)
                    {
                        List<Claim.ItemComponent> mzzzzzzzzzk_ = c?.Item;
                        bool? mzzzzzzzzzl_(Claim.ItemComponent i)
                        {
                            CodeableConcept mzzzzzzzzzo_ = i?.Revenue;
                            CqlConcept mzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzzo_);
                            CqlCode[] mzzzzzzzzzq_ = mzzzzzzzzzp_?.codes;
                            bool? mzzzzzzzzzr_(CqlCode rev)
                            {
                                string mzzzzzzzzzu_ = rev?.code;
                                CqlValueSet mzzzzzzzzzv_ = this.Inpatient_Stay(context);
                                bool? mzzzzzzzzzw_ = context.Operators.StringInValueSet(mzzzzzzzzzu_, mzzzzzzzzzv_);

                                return mzzzzzzzzzw_;
                            };
                            IEnumerable<CqlCode> mzzzzzzzzzs_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)mzzzzzzzzzq_, mzzzzzzzzzr_);
                            bool? mzzzzzzzzzt_ = context.Operators.Exists<CqlCode>(mzzzzzzzzzs_);

                            return mzzzzzzzzzt_;
                        };
                        IEnumerable<Claim.ItemComponent> mzzzzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)mzzzzzzzzzk_, mzzzzzzzzzl_);
                        bool? mzzzzzzzzzn_ = context.Operators.Exists<Claim.ItemComponent>(mzzzzzzzzzm_);

                        return mzzzzzzzzzn_;
                    };
                    IEnumerable<Claim> mzzzzzzzzzj_ = context.Operators.Where<Claim>(mzzzzzzzzzh_, mzzzzzzzzzi_);

                    return mzzzzzzzzzj_;
                }
            };
            IEnumerable<Claim> mzzzzzzzzza_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> mzzzzzzzzzx_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? mzzzzzzzzzy_(Claim c)
                    {
                        List<Claim.ItemComponent> nzzzzzzzzza_ = c?.Item;
                        bool? nzzzzzzzzzb_(Claim.ItemComponent i)
                        {
                            CodeableConcept nzzzzzzzzzk_ = i?.Revenue;
                            CqlConcept nzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, nzzzzzzzzzk_);
                            CqlCode[] nzzzzzzzzzm_ = nzzzzzzzzzl_?.codes;
                            bool? nzzzzzzzzzn_(CqlCode rev)
                            {
                                string nzzzzzzzzzq_ = rev?.code;
                                CqlValueSet nzzzzzzzzzr_ = this.Nonacute_Inpatient_Stay(context);
                                bool? nzzzzzzzzzs_ = context.Operators.StringInValueSet(nzzzzzzzzzq_, nzzzzzzzzzr_);

                                return nzzzzzzzzzs_;
                            };
                            IEnumerable<CqlCode> nzzzzzzzzzo_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)nzzzzzzzzzm_, nzzzzzzzzzn_);
                            bool? nzzzzzzzzzp_ = context.Operators.Exists<CqlCode>(nzzzzzzzzzo_);

                            return nzzzzzzzzzp_;
                        };
                        IEnumerable<Claim.ItemComponent> nzzzzzzzzzc_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)nzzzzzzzzza_, nzzzzzzzzzb_);
                        bool? nzzzzzzzzzd_ = context.Operators.Exists<Claim.ItemComponent>(nzzzzzzzzzc_);
                        CodeableConcept nzzzzzzzzze_ = c?.SubType;
                        List<Coding> nzzzzzzzzzf_ = nzzzzzzzzze_?.Coding;
                        bool? nzzzzzzzzzg_(Coding tob)
                        {
                            Code nzzzzzzzzzt_ = tob?.CodeElement;
                            string nzzzzzzzzzu_ = nzzzzzzzzzt_?.Value;
                            CqlValueSet nzzzzzzzzzv_ = this.Nonacute_Inpatient_Stay(context);
                            bool? nzzzzzzzzzw_ = context.Operators.StringInValueSet(nzzzzzzzzzu_, nzzzzzzzzzv_);

                            return nzzzzzzzzzw_;
                        };
                        IEnumerable<Coding> nzzzzzzzzzh_ = context.Operators.Where<Coding>((IEnumerable<Coding>)nzzzzzzzzzf_, nzzzzzzzzzg_);
                        bool? nzzzzzzzzzi_ = context.Operators.Exists<Coding>(nzzzzzzzzzh_);
                        bool? nzzzzzzzzzj_ = context.Operators.Or(nzzzzzzzzzd_, nzzzzzzzzzi_);

                        return nzzzzzzzzzj_;
                    };
                    IEnumerable<Claim> mzzzzzzzzzz_ = context.Operators.Where<Claim>(mzzzzzzzzzx_, mzzzzzzzzzy_);

                    return mzzzzzzzzzz_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? mzzzzzzzzzb_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, lzzzzzzzzzz_(), mzzzzzzzzza_());
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] mzzzzzzzzzc_ = [
                mzzzzzzzzzb_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? mzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> nzzzzzzzzzx_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> nzzzzzzzzzy_ = LineItemDefinition?.NonacuteInpatientLineItems;
                IEnumerable<Claim> nzzzzzzzzzz_(Claim nonAcuteInpatientStay)
                {
                    IEnumerable<Claim> ozzzzzzzzzh_ = LineItemDefinition?.InpatientStayLineItems;
                    bool? ozzzzzzzzzi_(Claim inpatientStay)
                    {
                        Id ozzzzzzzzzm_ = nonAcuteInpatientStay?.IdElement;
                        Id ozzzzzzzzzn_ = inpatientStay?.IdElement;
                        bool? ozzzzzzzzzo_ = context.Operators.Equal(ozzzzzzzzzm_, ozzzzzzzzzn_);

                        return ozzzzzzzzzo_;
                    };
                    IEnumerable<Claim> ozzzzzzzzzj_ = context.Operators.Where<Claim>(ozzzzzzzzzh_, ozzzzzzzzzi_);
                    Claim ozzzzzzzzzk_(Claim inpatientStay) =>
                        nonAcuteInpatientStay;
                    IEnumerable<Claim> ozzzzzzzzzl_ = context.Operators.Select<Claim, Claim>(ozzzzzzzzzj_, ozzzzzzzzzk_);

                    return ozzzzzzzzzl_;
                };
                IEnumerable<Claim> ozzzzzzzzza_ = context.Operators.SelectMany<Claim, Claim>(nzzzzzzzzzy_, nzzzzzzzzzz_);
                IEnumerable<Claim> ozzzzzzzzzd_(Claim inpatientStay)
                {
                    IEnumerable<Claim> ozzzzzzzzzp_ = LineItemDefinition?.NonacuteInpatientLineItems;
                    bool? ozzzzzzzzzq_(Claim nonAcuteInpatientStay)
                    {
                        Id ozzzzzzzzzu_ = inpatientStay?.IdElement;
                        Id ozzzzzzzzzv_ = nonAcuteInpatientStay?.IdElement;
                        bool? ozzzzzzzzzw_ = context.Operators.Equal(ozzzzzzzzzu_, ozzzzzzzzzv_);

                        return ozzzzzzzzzw_;
                    };
                    IEnumerable<Claim> ozzzzzzzzzr_ = context.Operators.Where<Claim>(ozzzzzzzzzp_, ozzzzzzzzzq_);
                    Claim ozzzzzzzzzs_(Claim nonAcuteInpatientStay) =>
                        inpatientStay;
                    IEnumerable<Claim> ozzzzzzzzzt_ = context.Operators.Select<Claim, Claim>(ozzzzzzzzzr_, ozzzzzzzzzs_);

                    return ozzzzzzzzzt_;
                };
                IEnumerable<Claim> ozzzzzzzzze_ = context.Operators.SelectMany<Claim, Claim>(nzzzzzzzzzx_, ozzzzzzzzzd_);
                IEnumerable<Claim> ozzzzzzzzzf_ = context.Operators.Except<Claim>(nzzzzzzzzzx_, ozzzzzzzzze_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? ozzzzzzzzzg_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, nzzzzzzzzzx_, ozzzzzzzzza_, ozzzzzzzzzf_);

                return ozzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> mzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)mzzzzzzzzzc_, mzzzzzzzzzd_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> mzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(mzzzzzzzzze_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? mzzzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(mzzzzzzzzzf_);

            return mzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> lzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)lzzzzzzzzzu_, lzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> lzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(lzzzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? lzzzzzzzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(lzzzzzzzzzx_);

        return lzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Get Prescriber NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? ozzzzzzzzzx_(Claim C)
        {
            List<Claim.CareTeamComponent> pzzzzzzzzzg_ = C?.CareTeam;
            bool? pzzzzzzzzzh_(Claim.CareTeamComponent ct)
            {
                PositiveInt pzzzzzzzzzx_ = ct?.SequenceElement;
                Integer pzzzzzzzzzy_ = context.Operators.Convert<Integer>(pzzzzzzzzzx_);
                int? pzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, pzzzzzzzzzy_);
                bool? qzzzzzzzzza_ = context.Operators.Equal(pzzzzzzzzzz_, 1);

                return qzzzzzzzzza_;
            };
            IEnumerable<Claim.CareTeamComponent> pzzzzzzzzzi_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)pzzzzzzzzzg_, pzzzzzzzzzh_);
            bool? pzzzzzzzzzj_(Claim.CareTeamComponent @this)
            {
                ResourceReference qzzzzzzzzzb_ = @this?.Provider;
                bool? qzzzzzzzzzc_ = context.Operators.Not((bool?)(qzzzzzzzzzb_ is null));

                return qzzzzzzzzzc_;
            };
            IEnumerable<Claim.CareTeamComponent> pzzzzzzzzzk_ = context.Operators.Where<Claim.CareTeamComponent>(pzzzzzzzzzi_, pzzzzzzzzzj_);
            ResourceReference pzzzzzzzzzl_(Claim.CareTeamComponent @this)
            {
                ResourceReference qzzzzzzzzzd_ = @this?.Provider;

                return qzzzzzzzzzd_;
            };
            IEnumerable<ResourceReference> pzzzzzzzzzm_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(pzzzzzzzzzk_, pzzzzzzzzzl_);
            bool? pzzzzzzzzzo_(Claim.CareTeamComponent ct)
            {
                PositiveInt qzzzzzzzzze_ = ct?.SequenceElement;
                Integer qzzzzzzzzzf_ = context.Operators.Convert<Integer>(qzzzzzzzzze_);
                int? qzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, qzzzzzzzzzf_);
                bool? qzzzzzzzzzh_ = context.Operators.Equal(qzzzzzzzzzg_, 1);

                return qzzzzzzzzzh_;
            };
            IEnumerable<Claim.CareTeamComponent> pzzzzzzzzzp_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)pzzzzzzzzzg_, pzzzzzzzzzo_);
            bool? pzzzzzzzzzq_(Claim.CareTeamComponent @this)
            {
                ResourceReference qzzzzzzzzzi_ = @this?.Provider;
                bool? qzzzzzzzzzj_ = context.Operators.Not((bool?)(qzzzzzzzzzi_ is null));

                return qzzzzzzzzzj_;
            };
            IEnumerable<Claim.CareTeamComponent> pzzzzzzzzzr_ = context.Operators.Where<Claim.CareTeamComponent>(pzzzzzzzzzp_, pzzzzzzzzzq_);
            ResourceReference pzzzzzzzzzs_(Claim.CareTeamComponent @this)
            {
                ResourceReference qzzzzzzzzzk_ = @this?.Provider;

                return qzzzzzzzzzk_;
            };
            IEnumerable<ResourceReference> pzzzzzzzzzt_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(pzzzzzzzzzr_, pzzzzzzzzzs_);
            string pzzzzzzzzzu_(ResourceReference p)
            {
                FhirString qzzzzzzzzzl_ = p?.ReferenceElement;
                FhirString[] qzzzzzzzzzm_ = [
                    qzzzzzzzzzl_,
                ];
                string qzzzzzzzzzn_(FhirString r)
                {
                    string qzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string qzzzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, qzzzzzzzzzq_);

                    return qzzzzzzzzzr_;
                };
                IEnumerable<string> qzzzzzzzzzo_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)qzzzzzzzzzm_, qzzzzzzzzzn_);
                string qzzzzzzzzzp_ = context.Operators.SingletonFrom<string>(qzzzzzzzzzo_);

                return qzzzzzzzzzp_;
            };
            IEnumerable<string> pzzzzzzzzzv_ = context.Operators.Select<ResourceReference, string>(pzzzzzzzzzt_, pzzzzzzzzzu_);
            (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? pzzzzzzzzzw_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, pzzzzzzzzzm_, pzzzzzzzzzv_);

            return pzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ozzzzzzzzzy_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, ozzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ozzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(ozzzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? pzzzzzzzzza_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, ozzzzzzzzzz_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?[] pzzzzzzzzzb_ = [
            pzzzzzzzzza_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? pzzzzzzzzzc_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ClaimProperties)
        {
            IEnumerable<Practitioner> qzzzzzzzzzs_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));
            bool? qzzzzzzzzzt_(Practitioner p)
            {
                Id rzzzzzzzzzb_ = p?.IdElement;
                string rzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzb_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> rzzzzzzzzzd_ = ClaimProperties?.CareTeams;
                bool? rzzzzzzzzze_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> rzzzzzzzzzk_ = @this?.CareTeamsProviderID;
                    bool? rzzzzzzzzzl_ = context.Operators.Not((bool?)(rzzzzzzzzzk_ is null));

                    return rzzzzzzzzzl_;
                };
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> rzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(rzzzzzzzzzd_, rzzzzzzzzze_);
                IEnumerable<string> rzzzzzzzzzg_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> rzzzzzzzzzm_ = @this?.CareTeamsProviderID;

                    return rzzzzzzzzzm_;
                };
                IEnumerable<IEnumerable<string>> rzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(rzzzzzzzzzf_, rzzzzzzzzzg_);
                IEnumerable<string> rzzzzzzzzzi_ = context.Operators.Flatten<string>(rzzzzzzzzzh_);
                bool? rzzzzzzzzzj_ = context.Operators.In<string>(rzzzzzzzzzc_, rzzzzzzzzzi_);

                return rzzzzzzzzzj_;
            };
            IEnumerable<Practitioner> qzzzzzzzzzu_ = context.Operators.Where<Practitioner>(qzzzzzzzzzs_, qzzzzzzzzzt_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? qzzzzzzzzzv_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, qzzzzzzzzzu_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?[] qzzzzzzzzzw_ = [
                qzzzzzzzzzv_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? qzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? PractitionerMatch)
            {
                IEnumerable<Practitioner> rzzzzzzzzzn_ = PractitionerMatch?.Practitioners;
                bool? rzzzzzzzzzo_(Practitioner P)
                {
                    bool? rzzzzzzzzzy_ = context.Operators.Not((bool?)(P is null));

                    return rzzzzzzzzzy_;
                };
                IEnumerable<Practitioner> rzzzzzzzzzp_ = context.Operators.Where<Practitioner>(rzzzzzzzzzn_, rzzzzzzzzzo_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? rzzzzzzzzzq_(Practitioner P)
                {
                    List<Identifier> rzzzzzzzzzz_ = P?.Identifier;
                    bool? szzzzzzzzza_(Identifier l)
                    {
                        FhirUri szzzzzzzzzl_ = l?.SystemElement;
                        string szzzzzzzzzm_ = szzzzzzzzzl_?.Value;
                        bool? szzzzzzzzzn_ = context.Operators.Equal(szzzzzzzzzm_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept szzzzzzzzzo_ = l?.Type;
                        CqlConcept szzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, szzzzzzzzzo_);
                        CqlCode szzzzzzzzzq_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept szzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(szzzzzzzzzq_);
                        bool? szzzzzzzzzs_ = context.Operators.Equivalent(szzzzzzzzzp_, szzzzzzzzzr_);
                        bool? szzzzzzzzzt_ = context.Operators.And(szzzzzzzzzn_, szzzzzzzzzs_);
                        FhirString szzzzzzzzzu_ = l?.ValueElement;
                        string szzzzzzzzzv_ = szzzzzzzzzu_?.Value;
                        bool? szzzzzzzzzw_ = context.Operators.Not((bool?)(szzzzzzzzzv_ is null));
                        bool? szzzzzzzzzx_ = context.Operators.And(szzzzzzzzzt_, szzzzzzzzzw_);

                        return szzzzzzzzzx_;
                    };
                    IEnumerable<Identifier> szzzzzzzzzb_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)rzzzzzzzzzz_, szzzzzzzzza_);
                    FhirString szzzzzzzzzc_(Identifier l)
                    {
                        FhirString szzzzzzzzzy_ = l?.ValueElement;

                        return szzzzzzzzzy_;
                    };
                    IEnumerable<FhirString> szzzzzzzzzd_ = context.Operators.Select<Identifier, FhirString>(szzzzzzzzzb_, szzzzzzzzzc_);
                    IEnumerable<FhirString> szzzzzzzzze_ = context.Operators.Distinct<FhirString>(szzzzzzzzzd_);
                    bool? szzzzzzzzzg_(Identifier l)
                    {
                        FhirUri szzzzzzzzzz_ = l?.SystemElement;
                        string tzzzzzzzzza_ = szzzzzzzzzz_?.Value;
                        bool? tzzzzzzzzzb_ = context.Operators.Equal(tzzzzzzzzza_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept tzzzzzzzzzc_ = l?.Type;
                        CqlConcept tzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, tzzzzzzzzzc_);
                        CqlCode tzzzzzzzzze_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept tzzzzzzzzzf_ = context.Operators.ConvertCodeToConcept(tzzzzzzzzze_);
                        bool? tzzzzzzzzzg_ = context.Operators.Equivalent(tzzzzzzzzzd_, tzzzzzzzzzf_);
                        bool? tzzzzzzzzzh_ = context.Operators.And(tzzzzzzzzzb_, tzzzzzzzzzg_);
                        FhirString tzzzzzzzzzi_ = l?.ValueElement;
                        string tzzzzzzzzzj_ = tzzzzzzzzzi_?.Value;
                        bool? tzzzzzzzzzk_ = context.Operators.And(tzzzzzzzzzh_, (bool?)(tzzzzzzzzzj_ is null));

                        return tzzzzzzzzzk_;
                    };
                    IEnumerable<Identifier> szzzzzzzzzh_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)rzzzzzzzzzz_, szzzzzzzzzg_);
                    Identifier szzzzzzzzzi_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> szzzzzzzzzj_ = context.Operators.Select<Identifier, Identifier>(szzzzzzzzzh_, szzzzzzzzzi_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? szzzzzzzzzk_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, szzzzzzzzze_, szzzzzzzzzj_);

                    return szzzzzzzzzk_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> rzzzzzzzzzr_ = context.Operators.Select<Practitioner, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(rzzzzzzzzzp_, rzzzzzzzzzq_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? rzzzzzzzzzs_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, rzzzzzzzzzr_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] rzzzzzzzzzt_ = [
                    rzzzzzzzzzs_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? rzzzzzzzzzu_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? tzzzzzzzzzl_()
                    {
                        bool tzzzzzzzzzn_()
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> tzzzzzzzzzo_ = ClaimProperties?.CareTeams;
                            bool? tzzzzzzzzzp_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim tzzzzzzzzzu_ = @this?.SingleCareTeam;
                                bool? tzzzzzzzzzv_ = context.Operators.Not((bool?)(tzzzzzzzzzu_ is null));

                                return tzzzzzzzzzv_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> tzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(tzzzzzzzzzo_, tzzzzzzzzzp_);
                            Claim tzzzzzzzzzr_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim tzzzzzzzzzw_ = @this?.SingleCareTeam;

                                return tzzzzzzzzzw_;
                            };
                            IEnumerable<Claim> tzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(tzzzzzzzzzq_, tzzzzzzzzzr_);
                            bool? tzzzzzzzzzt_ = context.Operators.Exists<Claim>(tzzzzzzzzzs_);

                            return tzzzzzzzzzt_ ?? false;
                        };
                        if (tzzzzzzzzzn_())
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> tzzzzzzzzzx_ = ClaimProperties?.CareTeams;
                            bool? tzzzzzzzzzy_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim uzzzzzzzzzu_ = @this?.SingleCareTeam;
                                bool? uzzzzzzzzzv_ = context.Operators.Not((bool?)(uzzzzzzzzzu_ is null));

                                return uzzzzzzzzzv_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> tzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(tzzzzzzzzzx_, tzzzzzzzzzy_);
                            Claim uzzzzzzzzza_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim uzzzzzzzzzw_ = @this?.SingleCareTeam;

                                return uzzzzzzzzzw_;
                            };
                            IEnumerable<Claim> uzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(tzzzzzzzzzz_, uzzzzzzzzza_);
                            bool? uzzzzzzzzzc_(Claim X)
                            {
                                List<Claim.CareTeamComponent> uzzzzzzzzzx_ = X?.CareTeam;

                                return (bool?)(((IEnumerable<Claim.CareTeamComponent>)uzzzzzzzzzx_) is null);
                            };
                            IEnumerable<Claim> uzzzzzzzzzd_ = context.Operators.Where<Claim>(uzzzzzzzzzb_, uzzzzzzzzzc_);
                            int? uzzzzzzzzze_ = context.Operators.Count<Claim>(uzzzzzzzzzd_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> uzzzzzzzzzf_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> uzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> uzzzzzzzzzy_ = X?.AllIdentifiers;

                                return uzzzzzzzzzy_;
                            };
                            IEnumerable<IEnumerable<FhirString>> uzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(uzzzzzzzzzf_, uzzzzzzzzzg_);
                            IEnumerable<FhirString> uzzzzzzzzzi_ = context.Operators.Flatten<FhirString>(uzzzzzzzzzh_);
                            FhirString uzzzzzzzzzj_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> uzzzzzzzzzk_ = context.Operators.Select<FhirString, FhirString>(uzzzzzzzzzi_, uzzzzzzzzzj_);
                            IEnumerable<FhirString> uzzzzzzzzzl_ = context.Operators.Distinct<FhirString>(uzzzzzzzzzk_);
                            int? uzzzzzzzzzm_ = context.Operators.Count<FhirString>(uzzzzzzzzzl_);
                            int? uzzzzzzzzzn_ = context.Operators.Add(uzzzzzzzzze_, uzzzzzzzzzm_);
                            IEnumerable<Identifier> uzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> uzzzzzzzzzz_ = X?.NullIdentifiers;

                                return uzzzzzzzzzz_;
                            };
                            IEnumerable<IEnumerable<Identifier>> uzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(uzzzzzzzzzf_, uzzzzzzzzzp_);
                            IEnumerable<Identifier> uzzzzzzzzzr_ = context.Operators.Flatten<Identifier>(uzzzzzzzzzq_);
                            int? uzzzzzzzzzs_ = context.Operators.Count<Identifier>(uzzzzzzzzzr_);
                            int? uzzzzzzzzzt_ = context.Operators.Add(uzzzzzzzzzn_, uzzzzzzzzzs_);

                            return uzzzzzzzzzt_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? tzzzzzzzzzm_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, tzzzzzzzzzl_());

                    return tzzzzzzzzzm_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> rzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)rzzzzzzzzzt_, rzzzzzzzzzu_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> rzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(rzzzzzzzzzv_);
                (CqlTupleMetadata, int? IdentifierCount)? rzzzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(rzzzzzzzzzw_);

                return rzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> qzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?>)qzzzzzzzzzw_, qzzzzzzzzzx_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> qzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(qzzzzzzzzzy_);
            (CqlTupleMetadata, int? IdentifierCount)? rzzzzzzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(qzzzzzzzzzz_);

            return rzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> pzzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?>)pzzzzzzzzzb_, pzzzzzzzzzc_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> pzzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(pzzzzzzzzzd_);
        (CqlTupleMetadata, int? IdentifierCount)? pzzzzzzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(pzzzzzzzzze_);

        return pzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("Get Pharmacy NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? vzzzzzzzzza_(Claim C)
        {
            List<Claim.ItemComponent> vzzzzzzzzzj_ = C?.Item;
            bool? vzzzzzzzzzl_(Claim.ItemComponent i)
            {
                PositiveInt wzzzzzzzzzd_ = i?.SequenceElement;
                Integer wzzzzzzzzze_ = context.Operators.Convert<Integer>(wzzzzzzzzzd_);
                int? wzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, wzzzzzzzzze_);
                bool? wzzzzzzzzzg_ = context.Operators.Equal(wzzzzzzzzzf_, 1);

                return wzzzzzzzzzg_;
            };
            IEnumerable<Claim.ItemComponent> vzzzzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)vzzzzzzzzzj_, vzzzzzzzzzl_);
            bool? vzzzzzzzzzn_(Claim.ItemComponent @this)
            {
                DataType wzzzzzzzzzh_ = @this?.Location;
                bool? wzzzzzzzzzi_ = context.Operators.Not((bool?)(wzzzzzzzzzh_ is null));

                return wzzzzzzzzzi_;
            };
            IEnumerable<Claim.ItemComponent> vzzzzzzzzzo_ = context.Operators.Where<Claim.ItemComponent>(vzzzzzzzzzm_, vzzzzzzzzzn_);
            object vzzzzzzzzzp_(Claim.ItemComponent @this)
            {
                DataType wzzzzzzzzzj_ = @this?.Location;

                return wzzzzzzzzzj_;
            };
            IEnumerable<object> vzzzzzzzzzq_ = context.Operators.Select<Claim.ItemComponent, object>(vzzzzzzzzzo_, vzzzzzzzzzp_);
            ResourceReference vzzzzzzzzzr_(object l) =>
                l as ResourceReference;
            IEnumerable<ResourceReference> vzzzzzzzzzs_ = context.Operators.Select<object, ResourceReference>(vzzzzzzzzzq_, vzzzzzzzzzr_);
            bool? vzzzzzzzzzu_(Claim.ItemComponent i)
            {
                PositiveInt wzzzzzzzzzk_ = i?.SequenceElement;
                Integer wzzzzzzzzzl_ = context.Operators.Convert<Integer>(wzzzzzzzzzk_);
                int? wzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, wzzzzzzzzzl_);
                bool? wzzzzzzzzzn_ = context.Operators.Equal(wzzzzzzzzzm_, 1);

                return wzzzzzzzzzn_;
            };
            IEnumerable<Claim.ItemComponent> vzzzzzzzzzv_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)vzzzzzzzzzj_, vzzzzzzzzzu_);
            bool? vzzzzzzzzzw_(Claim.ItemComponent @this)
            {
                DataType wzzzzzzzzzo_ = @this?.Location;
                bool? wzzzzzzzzzp_ = context.Operators.Not((bool?)(wzzzzzzzzzo_ is null));

                return wzzzzzzzzzp_;
            };
            IEnumerable<Claim.ItemComponent> vzzzzzzzzzx_ = context.Operators.Where<Claim.ItemComponent>(vzzzzzzzzzv_, vzzzzzzzzzw_);
            object vzzzzzzzzzy_(Claim.ItemComponent @this)
            {
                DataType wzzzzzzzzzq_ = @this?.Location;

                return wzzzzzzzzzq_;
            };
            IEnumerable<object> vzzzzzzzzzz_ = context.Operators.Select<Claim.ItemComponent, object>(vzzzzzzzzzx_, vzzzzzzzzzy_);
            string wzzzzzzzzza_(object l)
            {
                FhirString wzzzzzzzzzr_ = (l as ResourceReference)?.ReferenceElement;
                FhirString[] wzzzzzzzzzs_ = [
                    wzzzzzzzzzr_,
                ];
                string wzzzzzzzzzt_(FhirString r)
                {
                    string wzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string wzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, wzzzzzzzzzw_);

                    return wzzzzzzzzzx_;
                };
                IEnumerable<string> wzzzzzzzzzu_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)wzzzzzzzzzs_, wzzzzzzzzzt_);
                string wzzzzzzzzzv_ = context.Operators.SingletonFrom<string>(wzzzzzzzzzu_);

                return wzzzzzzzzzv_;
            };
            IEnumerable<string> wzzzzzzzzzb_ = context.Operators.Select<object, string>(vzzzzzzzzzz_, wzzzzzzzzza_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? wzzzzzzzzzc_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent>)vzzzzzzzzzj_, vzzzzzzzzzs_, wzzzzzzzzzb_);

            return wzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> vzzzzzzzzzb_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, vzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> vzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(vzzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? vzzzzzzzzzd_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, vzzzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?[] vzzzzzzzzze_ = [
            vzzzzzzzzzd_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? vzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? ClaimProperties)
        {
            IEnumerable<Location> wzzzzzzzzzy_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
            bool? wzzzzzzzzzz_(Location l)
            {
                Id xzzzzzzzzzh_ = l?.IdElement;
                string xzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzh_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> xzzzzzzzzzj_ = ClaimProperties?.ItemsLocationReferences;
                bool? xzzzzzzzzzk_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> xzzzzzzzzzq_ = @this?.ItemLocationID;
                    bool? xzzzzzzzzzr_ = context.Operators.Not((bool?)(xzzzzzzzzzq_ is null));

                    return xzzzzzzzzzr_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> xzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(xzzzzzzzzzj_, xzzzzzzzzzk_);
                IEnumerable<string> xzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> xzzzzzzzzzs_ = @this?.ItemLocationID;

                    return xzzzzzzzzzs_;
                };
                IEnumerable<IEnumerable<string>> xzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(xzzzzzzzzzl_, xzzzzzzzzzm_);
                IEnumerable<string> xzzzzzzzzzo_ = context.Operators.Flatten<string>(xzzzzzzzzzn_);
                bool? xzzzzzzzzzp_ = context.Operators.In<string>(xzzzzzzzzzi_, xzzzzzzzzzo_);

                return xzzzzzzzzzp_;
            };
            IEnumerable<Location> xzzzzzzzzza_ = context.Operators.Where<Location>(wzzzzzzzzzy_, wzzzzzzzzzz_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? xzzzzzzzzzb_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, xzzzzzzzzza_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?[] xzzzzzzzzzc_ = [
                xzzzzzzzzzb_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? xzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? GetLocation)
            {
                IEnumerable<Location> xzzzzzzzzzt_ = GetLocation?.CorrespondingLocations;
                bool? xzzzzzzzzzu_(Location C)
                {
                    bool? yzzzzzzzzze_ = context.Operators.Not((bool?)(C is null));

                    return yzzzzzzzzze_;
                };
                IEnumerable<Location> xzzzzzzzzzv_ = context.Operators.Where<Location>(xzzzzzzzzzt_, xzzzzzzzzzu_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? xzzzzzzzzzw_(Location C)
                {
                    List<Identifier> yzzzzzzzzzf_ = C?.Identifier;
                    bool? yzzzzzzzzzg_(Identifier l)
                    {
                        FhirUri yzzzzzzzzzr_ = l?.SystemElement;
                        string yzzzzzzzzzs_ = yzzzzzzzzzr_?.Value;
                        bool? yzzzzzzzzzt_ = context.Operators.Equal(yzzzzzzzzzs_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept yzzzzzzzzzu_ = l?.Type;
                        CqlConcept yzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzzu_);
                        CqlCode yzzzzzzzzzw_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept yzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzzw_);
                        bool? yzzzzzzzzzy_ = context.Operators.Equivalent(yzzzzzzzzzv_, yzzzzzzzzzx_);
                        bool? yzzzzzzzzzz_ = context.Operators.And(yzzzzzzzzzt_, yzzzzzzzzzy_);
                        FhirString zzzzzzzzzza_ = l?.ValueElement;
                        string zzzzzzzzzzb_ = zzzzzzzzzza_?.Value;
                        bool? zzzzzzzzzzc_ = context.Operators.Not((bool?)(zzzzzzzzzzb_ is null));
                        bool? zzzzzzzzzzd_ = context.Operators.And(yzzzzzzzzzz_, zzzzzzzzzzc_);

                        return zzzzzzzzzzd_;
                    };
                    IEnumerable<Identifier> yzzzzzzzzzh_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)yzzzzzzzzzf_, yzzzzzzzzzg_);
                    FhirString yzzzzzzzzzi_(Identifier l)
                    {
                        FhirString zzzzzzzzzze_ = l?.ValueElement;

                        return zzzzzzzzzze_;
                    };
                    IEnumerable<FhirString> yzzzzzzzzzj_ = context.Operators.Select<Identifier, FhirString>(yzzzzzzzzzh_, yzzzzzzzzzi_);
                    IEnumerable<FhirString> yzzzzzzzzzk_ = context.Operators.Distinct<FhirString>(yzzzzzzzzzj_);
                    bool? yzzzzzzzzzm_(Identifier l)
                    {
                        FhirUri zzzzzzzzzzf_ = l?.SystemElement;
                        string zzzzzzzzzzg_ = zzzzzzzzzzf_?.Value;
                        bool? zzzzzzzzzzh_ = context.Operators.Equal(zzzzzzzzzzg_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept zzzzzzzzzzi_ = l?.Type;
                        CqlConcept zzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, zzzzzzzzzzi_);
                        CqlCode zzzzzzzzzzk_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept zzzzzzzzzzl_ = context.Operators.ConvertCodeToConcept(zzzzzzzzzzk_);
                        bool? zzzzzzzzzzm_ = context.Operators.Equivalent(zzzzzzzzzzj_, zzzzzzzzzzl_);
                        bool? zzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzh_, zzzzzzzzzzm_);
                        FhirString zzzzzzzzzzo_ = l?.ValueElement;
                        string zzzzzzzzzzp_ = zzzzzzzzzzo_?.Value;
                        bool? zzzzzzzzzzq_ = context.Operators.And(zzzzzzzzzzn_, (bool?)(zzzzzzzzzzp_ is null));

                        return zzzzzzzzzzq_;
                    };
                    IEnumerable<Identifier> yzzzzzzzzzn_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)yzzzzzzzzzf_, yzzzzzzzzzm_);
                    Identifier yzzzzzzzzzo_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> yzzzzzzzzzp_ = context.Operators.Select<Identifier, Identifier>(yzzzzzzzzzn_, yzzzzzzzzzo_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? yzzzzzzzzzq_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, yzzzzzzzzzk_, yzzzzzzzzzp_);

                    return yzzzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> xzzzzzzzzzx_ = context.Operators.Select<Location, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(xzzzzzzzzzv_, xzzzzzzzzzw_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? xzzzzzzzzzy_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, xzzzzzzzzzx_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] xzzzzzzzzzz_ = [
                    xzzzzzzzzzy_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? yzzzzzzzzza_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? zzzzzzzzzzr_()
                    {
                        bool zzzzzzzzzzt_()
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> zzzzzzzzzzu_ = ClaimProperties?.ItemsLocationReferences;
                            bool? zzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> azzzzzzzzzzb_ = @this?.SingleItem;
                                bool? azzzzzzzzzzc_ = context.Operators.Not((bool?)(azzzzzzzzzzb_ is null));

                                return azzzzzzzzzzc_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> zzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(zzzzzzzzzzu_, zzzzzzzzzzv_);
                            IEnumerable<Claim.ItemComponent> zzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> azzzzzzzzzzd_ = @this?.SingleItem;

                                return azzzzzzzzzzd_;
                            };
                            IEnumerable<IEnumerable<Claim.ItemComponent>> zzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(zzzzzzzzzzw_, zzzzzzzzzzx_);
                            IEnumerable<Claim.ItemComponent> zzzzzzzzzzz_ = context.Operators.Flatten<Claim.ItemComponent>(zzzzzzzzzzy_);
                            bool? azzzzzzzzzza_ = context.Operators.Exists<Claim.ItemComponent>(zzzzzzzzzzz_);

                            return azzzzzzzzzza_ ?? false;
                        };
                        if (zzzzzzzzzzt_())
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> azzzzzzzzzze_ = ClaimProperties?.ItemsLocationReferences;
                            bool? azzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> bzzzzzzzzzzc_ = @this?.ItemLocation;
                                bool? bzzzzzzzzzzd_ = context.Operators.Not((bool?)(bzzzzzzzzzzc_ is null));

                                return bzzzzzzzzzzd_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> azzzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(azzzzzzzzzze_, azzzzzzzzzzf_);
                            IEnumerable<ResourceReference> azzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> bzzzzzzzzzze_ = @this?.ItemLocation;

                                return bzzzzzzzzzze_;
                            };
                            IEnumerable<IEnumerable<ResourceReference>> azzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(azzzzzzzzzzg_, azzzzzzzzzzh_);
                            IEnumerable<ResourceReference> azzzzzzzzzzj_ = context.Operators.Flatten<ResourceReference>(azzzzzzzzzzi_);
                            bool? azzzzzzzzzzk_(ResourceReference X)
                            {
                                FhirString bzzzzzzzzzzf_ = X?.ReferenceElement;
                                string bzzzzzzzzzzg_ = bzzzzzzzzzzf_?.Value;

                                return (bool?)(bzzzzzzzzzzg_ is null);
                            };
                            IEnumerable<ResourceReference> azzzzzzzzzzl_ = context.Operators.Where<ResourceReference>(azzzzzzzzzzj_, azzzzzzzzzzk_);
                            int? azzzzzzzzzzm_ = context.Operators.Count<ResourceReference>(azzzzzzzzzzl_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> azzzzzzzzzzn_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> azzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> bzzzzzzzzzzh_ = X?.AllIdentifiers;

                                return bzzzzzzzzzzh_;
                            };
                            IEnumerable<IEnumerable<FhirString>> azzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(azzzzzzzzzzn_, azzzzzzzzzzo_);
                            IEnumerable<FhirString> azzzzzzzzzzq_ = context.Operators.Flatten<FhirString>(azzzzzzzzzzp_);
                            FhirString azzzzzzzzzzr_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> azzzzzzzzzzs_ = context.Operators.Select<FhirString, FhirString>(azzzzzzzzzzq_, azzzzzzzzzzr_);
                            IEnumerable<FhirString> azzzzzzzzzzt_ = context.Operators.Distinct<FhirString>(azzzzzzzzzzs_);
                            int? azzzzzzzzzzu_ = context.Operators.Count<FhirString>(azzzzzzzzzzt_);
                            int? azzzzzzzzzzv_ = context.Operators.Add(azzzzzzzzzzm_, azzzzzzzzzzu_);
                            IEnumerable<Identifier> azzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> bzzzzzzzzzzi_ = X?.NullIdentifiers;

                                return bzzzzzzzzzzi_;
                            };
                            IEnumerable<IEnumerable<Identifier>> azzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(azzzzzzzzzzn_, azzzzzzzzzzx_);
                            IEnumerable<Identifier> azzzzzzzzzzz_ = context.Operators.Flatten<Identifier>(azzzzzzzzzzy_);
                            int? bzzzzzzzzzza_ = context.Operators.Count<Identifier>(azzzzzzzzzzz_);
                            int? bzzzzzzzzzzb_ = context.Operators.Add(azzzzzzzzzzv_, bzzzzzzzzzza_);

                            return bzzzzzzzzzzb_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? zzzzzzzzzzs_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, zzzzzzzzzzr_());

                    return zzzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> yzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)xzzzzzzzzzz_, yzzzzzzzzza_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> yzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(yzzzzzzzzzb_);
                (CqlTupleMetadata, int? IdentifierCount)? yzzzzzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(yzzzzzzzzzc_);

                return yzzzzzzzzzd_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> xzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?>)xzzzzzzzzzc_, xzzzzzzzzzd_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> xzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(xzzzzzzzzze_);
            (CqlTupleMetadata, int? IdentifierCount)? xzzzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(xzzzzzzzzzf_);

            return xzzzzzzzzzg_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> vzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?>)vzzzzzzzzze_, vzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> vzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(vzzzzzzzzzg_);
        (CqlTupleMetadata, int? IdentifierCount)? vzzzzzzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(vzzzzzzzzzh_);

        return vzzzzzzzzzi_;
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
