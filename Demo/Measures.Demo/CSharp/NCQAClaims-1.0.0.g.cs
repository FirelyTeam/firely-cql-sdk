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

    #region ValueSet: Inpatient Stay
    [CqlValueSetDefinition(
        definitionName: "Inpatient Stay",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395",
        valueSetVersion: null)]
    public CqlValueSet Inpatient_Stay(CqlContext context) => _Inpatient_Stay;

    private static readonly CqlValueSet _Inpatient_Stay = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1395", null);
    #endregion

    #region ValueSet: Nonacute Inpatient Stay
    [CqlValueSetDefinition(
        definitionName: "Nonacute Inpatient Stay",
        valueSetId: "https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398",
        valueSetVersion: null)]
    public CqlValueSet Nonacute_Inpatient_Stay(CqlContext context) => _Nonacute_Inpatient_Stay;

    private static readonly CqlValueSet _Nonacute_Inpatient_Stay = new CqlValueSet("https://www.ncqa.org/fhir/valueset/2.16.840.1.113883.3.464.1004.1398", null);
    #endregion

    #endregion ValueSets

    #region Expressions

    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Claim> Professional_or_Institutional_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? fzzzzzzy_(Claim MedicalClaim)
        {
            CodeableConcept gzzzzzza_ = MedicalClaim?.Type;
            CqlConcept gzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzza_);
            CqlCode[] gzzzzzzc_ = gzzzzzzb_?.codes;
            CqlCode gzzzzzzd_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? gzzzzzze_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)gzzzzzzc_, gzzzzzzd_);
            CqlConcept gzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzza_);
            CqlCode[] gzzzzzzh_ = gzzzzzzg_?.codes;
            CqlCode gzzzzzzi_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? gzzzzzzj_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)gzzzzzzh_, gzzzzzzi_);
            bool? gzzzzzzk_ = context.Operators.Or(gzzzzzze_, gzzzzzzj_);

            return gzzzzzzk_;
        };
        IEnumerable<Claim> fzzzzzzz_ = context.Operators.Where<Claim>(claim, fzzzzzzy_);

        return fzzzzzzz_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<Claim> Pharmacy_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? gzzzzzzl_(Claim PharmacyClaim)
        {
            CodeableConcept gzzzzzzn_ = PharmacyClaim?.Type;
            CqlConcept gzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzn_);
            CqlCode[] gzzzzzzp_ = gzzzzzzo_?.codes;
            CqlCode gzzzzzzq_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? gzzzzzzr_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)gzzzzzzp_, gzzzzzzq_);

            return gzzzzzzr_;
        };
        IEnumerable<Claim> gzzzzzzm_ = context.Operators.Where<Claim>(claim, gzzzzzzl_);

        return gzzzzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? gzzzzzzs_(ClaimResponse MedicalResponse)
        {
            CodeableConcept gzzzzzzu_ = MedicalResponse?.Type;
            CqlConcept gzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzu_);
            CqlCode[] gzzzzzzw_ = gzzzzzzv_?.codes;
            CqlCode gzzzzzzx_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? gzzzzzzy_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)gzzzzzzw_, gzzzzzzx_);
            CqlConcept hzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzu_);
            CqlCode[] hzzzzzzb_ = hzzzzzza_?.codes;
            CqlCode hzzzzzzc_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? hzzzzzzd_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)hzzzzzzb_, hzzzzzzc_);
            bool? hzzzzzze_ = context.Operators.Or(gzzzzzzy_, hzzzzzzd_);

            return hzzzzzze_;
        };
        IEnumerable<ClaimResponse> gzzzzzzt_ = context.Operators.Where<ClaimResponse>(claimResponse, gzzzzzzs_);

        return gzzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? hzzzzzzf_(ClaimResponse PharmacyResponse)
        {
            CodeableConcept hzzzzzzh_ = PharmacyResponse?.Type;
            CqlConcept hzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, hzzzzzzh_);
            CqlCode[] hzzzzzzj_ = hzzzzzzi_?.codes;
            CqlCode hzzzzzzk_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? hzzzzzzl_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)hzzzzzzj_, hzzzzzzk_);

            return hzzzzzzl_;
        };
        IEnumerable<ClaimResponse> hzzzzzzg_ = context.Operators.Where<ClaimResponse>(claimResponse, hzzzzzzf_);

        return hzzzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> hzzzzzzm_ = this.Professional_or_Institutional_Claims(context, claim);
        string hzzzzzzn_(CqlCode p)
        {
            string hzzzzzzz_ = p?.code;

            return hzzzzzzz_;
        };
        IEnumerable<string> hzzzzzzo_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, hzzzzzzn_);
        IEnumerable<string> hzzzzzzp_ = context.Operators.Distinct<string>(hzzzzzzo_);
        string hzzzzzzq_(CqlCode pos)
        {
            string izzzzzza_ = pos?.code;

            return izzzzzza_;
        };
        IEnumerable<string> hzzzzzzr_ = context.Operators.Select<CqlCode, string>(posCodes, hzzzzzzq_);
        IEnumerable<string> hzzzzzzs_ = context.Operators.Distinct<string>(hzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? hzzzzzzt_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, hzzzzzzm_, hzzzzzzp_, hzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] hzzzzzzu_ = [
            hzzzzzzt_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzv_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode)
        {
            IEnumerable<Claim> izzzzzzb_ = ClaimWithPosCode?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzc_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> izzzzzzh_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> izzzzzzo_ = ClaimofInterest?.Item;
                        bool? izzzzzzp_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept izzzzzzr_ = ItemOnLine?.ProductOrService;
                            CqlConcept izzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, izzzzzzr_);
                            CqlCode[] izzzzzzt_ = izzzzzzs_?.codes;
                            bool? izzzzzzu_(CqlCode LineCode)
                            {
                                string jzzzzzze_ = LineCode?.code;
                                IEnumerable<string> jzzzzzzf_ = ClaimWithPosCode?.ProceduresAsStrings;
                                bool? jzzzzzzg_ = context.Operators.In<string>(jzzzzzze_, jzzzzzzf_);

                                return jzzzzzzg_;
                            };
                            IEnumerable<CqlCode> izzzzzzv_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)izzzzzzt_, izzzzzzu_);
                            bool? izzzzzzw_ = context.Operators.Exists<CqlCode>(izzzzzzv_);
                            DataType izzzzzzx_ = ItemOnLine?.Location;
                            CqlConcept izzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, izzzzzzx_ as CodeableConcept);
                            CqlCode[] izzzzzzz_ = izzzzzzy_?.codes;
                            bool? jzzzzzza_(CqlCode PosCode)
                            {
                                string jzzzzzzh_ = PosCode?.code;
                                IEnumerable<string> jzzzzzzi_ = ClaimWithPosCode?.POSAsString;
                                bool? jzzzzzzj_ = context.Operators.In<string>(jzzzzzzh_, jzzzzzzi_);

                                return jzzzzzzj_;
                            };
                            IEnumerable<CqlCode> jzzzzzzb_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)izzzzzzz_, jzzzzzza_);
                            bool? jzzzzzzc_ = context.Operators.Exists<CqlCode>(jzzzzzzb_);
                            bool? jzzzzzzd_ = context.Operators.And(izzzzzzw_, jzzzzzzc_);

                            return jzzzzzzd_;
                        };
                        IEnumerable<Claim.ItemComponent> izzzzzzq_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)izzzzzzo_, izzzzzzp_);

                        return izzzzzzq_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? izzzzzzi_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, izzzzzzh_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] izzzzzzj_ = [
                    izzzzzzi_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzk_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzk_()
                    {
                        bool jzzzzzzl_()
                        {
                            IEnumerable<Claim.ItemComponent> jzzzzzzm_ = LineItemDefinition?.LineItems;
                            bool? jzzzzzzn_ = context.Operators.Exists<Claim.ItemComponent>(jzzzzzzm_);

                            return jzzzzzzn_ ?? false;
                        };
                        if (jzzzzzzl_())
                        {
                            Claim jzzzzzzo_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> jzzzzzzp_ = LineItemDefinition?.LineItems;
                            bool? jzzzzzzq_(Claim.ItemComponent @this)
                            {
                                DataType jzzzzzzy_ = @this?.Serviced;
                                bool? jzzzzzzz_ = context.Operators.Not((bool?)(jzzzzzzy_ is null));

                                return jzzzzzzz_;
                            };
                            IEnumerable<Claim.ItemComponent> jzzzzzzr_ = context.Operators.Where<Claim.ItemComponent>(jzzzzzzp_, jzzzzzzq_);
                            object jzzzzzzs_(Claim.ItemComponent @this)
                            {
                                DataType kzzzzzza_ = @this?.Serviced;

                                return kzzzzzza_;
                            };
                            IEnumerable<object> jzzzzzzt_ = context.Operators.Select<Claim.ItemComponent, object>(jzzzzzzr_, jzzzzzzs_);
                            CqlInterval<CqlDateTime> jzzzzzzu_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> kzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return kzzzzzzb_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzv_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(jzzzzzzt_, jzzzzzzu_);
                            IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzzzzzv_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzx_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, jzzzzzzo_, jzzzzzzw_);

                            return jzzzzzzx_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return jzzzzzzk_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)izzzzzzj_, izzzzzzk_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzl_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzm_);

                return izzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzd_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzb_, izzzzzzc_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzzd_);
            bool? izzzzzzf_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? kzzzzzzc_ = context.Operators.Not((bool?)(FinalList is null));

                return kzzzzzzc_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> izzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(izzzzzze_, izzzzzzf_);

            return izzzzzzg_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> hzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)hzzzzzzu_, hzzzzzzv_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> hzzzzzzx_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(hzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzy_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(hzzzzzzx_);

        return hzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> kzzzzzzd_ = this.Professional_or_Institutional_Claims(context, claim);
        string kzzzzzze_(CqlCode p)
        {
            string kzzzzzzn_ = p?.code;

            return kzzzzzzn_;
        };
        IEnumerable<string> kzzzzzzf_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, kzzzzzze_);
        IEnumerable<string> kzzzzzzg_ = context.Operators.Distinct<string>(kzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? kzzzzzzh_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, kzzzzzzd_, kzzzzzzg_, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] kzzzzzzi_ = [
            kzzzzzzh_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzj_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithProcedure)
        {
            IEnumerable<Claim> kzzzzzzo_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? kzzzzzzp_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> kzzzzzzu_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> lzzzzzzb_ = ClaimofInterest?.Item;
                        bool? lzzzzzzc_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept lzzzzzze_ = ItemOnLine?.ProductOrService;
                            CqlConcept lzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzze_);
                            CqlCode[] lzzzzzzg_ = lzzzzzzf_?.codes;
                            bool? lzzzzzzh_(CqlCode LineCode)
                            {
                                string mzzzzzza_ = LineCode?.code;
                                IEnumerable<string> mzzzzzzb_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? mzzzzzzc_ = context.Operators.In<string>(mzzzzzza_, mzzzzzzb_);

                                return mzzzzzzc_;
                            };
                            IEnumerable<CqlCode> lzzzzzzi_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)lzzzzzzg_, lzzzzzzh_);
                            bool? lzzzzzzj_ = context.Operators.Exists<CqlCode>(lzzzzzzi_);
                            List<Claim.ProcedureComponent> lzzzzzzk_ = ClaimofInterest?.Procedure;
                            bool? lzzzzzzl_(Claim.ProcedureComponent @this)
                            {
                                DataType mzzzzzzd_ = @this?.Procedure;
                                bool? mzzzzzze_ = context.Operators.Not((bool?)(mzzzzzzd_ is null));

                                return mzzzzzze_;
                            };
                            IEnumerable<Claim.ProcedureComponent> lzzzzzzm_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)lzzzzzzk_, lzzzzzzl_);
                            object lzzzzzzn_(Claim.ProcedureComponent @this)
                            {
                                DataType mzzzzzzf_ = @this?.Procedure;

                                return mzzzzzzf_;
                            };
                            IEnumerable<object> lzzzzzzo_ = context.Operators.Select<Claim.ProcedureComponent, object>(lzzzzzzm_, lzzzzzzn_);
                            bool? lzzzzzzp_(object @this)
                            {
                                object mzzzzzzg_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? mzzzzzzh_ = context.Operators.Not((bool?)(mzzzzzzg_ is null));

                                return mzzzzzzh_;
                            };
                            IEnumerable<object> lzzzzzzq_ = context.Operators.Where<object>(lzzzzzzo_, lzzzzzzp_);
                            object lzzzzzzr_(object @this)
                            {
                                object mzzzzzzi_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return mzzzzzzi_;
                            };
                            IEnumerable<object> lzzzzzzs_ = context.Operators.Select<object, object>(lzzzzzzq_, lzzzzzzr_);
                            IEnumerable<object> lzzzzzzt_ = context.Operators.FlattenLateBoundList(lzzzzzzs_);
                            Coding lzzzzzzu_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> lzzzzzzv_ = context.Operators.Select<object, Coding>(lzzzzzzt_, lzzzzzzu_);
                            bool? lzzzzzzw_(Coding HeaderCode)
                            {
                                Code mzzzzzzj_ = HeaderCode?.CodeElement;
                                string mzzzzzzk_ = mzzzzzzj_?.Value;
                                IEnumerable<string> mzzzzzzl_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? mzzzzzzm_ = context.Operators.In<string>(mzzzzzzk_, mzzzzzzl_);

                                return mzzzzzzm_;
                            };
                            IEnumerable<Coding> lzzzzzzx_ = context.Operators.Where<Coding>(lzzzzzzv_, lzzzzzzw_);
                            bool? lzzzzzzy_ = context.Operators.Exists<Coding>(lzzzzzzx_);
                            bool? lzzzzzzz_ = context.Operators.Or(lzzzzzzj_, lzzzzzzy_);

                            return lzzzzzzz_;
                        };
                        IEnumerable<Claim.ItemComponent> lzzzzzzd_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)lzzzzzzb_, lzzzzzzc_);

                        return lzzzzzzd_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? kzzzzzzv_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, kzzzzzzu_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] kzzzzzzw_ = [
                    kzzzzzzv_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? kzzzzzzx_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzn_()
                    {
                        bool mzzzzzzo_()
                        {
                            IEnumerable<Claim.ItemComponent> mzzzzzzp_ = LineItemDefinition?.LineItems;
                            bool? mzzzzzzq_ = context.Operators.Exists<Claim.ItemComponent>(mzzzzzzp_);

                            return mzzzzzzq_ ?? false;
                        };
                        if (mzzzzzzo_())
                        {
                            Claim mzzzzzzr_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> mzzzzzzs_ = LineItemDefinition?.LineItems;
                            bool? mzzzzzzt_(Claim.ItemComponent @this)
                            {
                                DataType nzzzzzzb_ = @this?.Serviced;
                                bool? nzzzzzzc_ = context.Operators.Not((bool?)(nzzzzzzb_ is null));

                                return nzzzzzzc_;
                            };
                            IEnumerable<Claim.ItemComponent> mzzzzzzu_ = context.Operators.Where<Claim.ItemComponent>(mzzzzzzs_, mzzzzzzt_);
                            object mzzzzzzv_(Claim.ItemComponent @this)
                            {
                                DataType nzzzzzzd_ = @this?.Serviced;

                                return nzzzzzzd_;
                            };
                            IEnumerable<object> mzzzzzzw_ = context.Operators.Select<Claim.ItemComponent, object>(mzzzzzzu_, mzzzzzzv_);
                            CqlInterval<CqlDateTime> mzzzzzzx_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> nzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return nzzzzzze_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzy_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(mzzzzzzw_, mzzzzzzx_);
                            IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzz_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(mzzzzzzy_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzza_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, mzzzzzzr_, mzzzzzzz_);

                            return nzzzzzza_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return mzzzzzzn_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)kzzzzzzw_, kzzzzzzx_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(kzzzzzzy_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? lzzzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(kzzzzzzz_);

                return lzzzzzza_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzq_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(kzzzzzzo_, kzzzzzzp_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(kzzzzzzq_);
            bool? kzzzzzzs_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? nzzzzzzf_ = context.Operators.Not((bool?)(FinalList is null));

                return nzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzt_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(kzzzzzzr_, kzzzzzzs_);

            return kzzzzzzt_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> kzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)kzzzzzzi_, kzzzzzzj_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> kzzzzzzl_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(kzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzm_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(kzzzzzzl_);

        return kzzzzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> nzzzzzzg_ = this.Professional_or_Institutional_Claims(context, claim);
        string nzzzzzzh_(CqlCode d)
        {
            string nzzzzzzq_ = d?.code;

            return nzzzzzzq_;
        };
        IEnumerable<string> nzzzzzzi_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, nzzzzzzh_);
        IEnumerable<string> nzzzzzzj_ = context.Operators.Distinct<string>(nzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? nzzzzzzk_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, nzzzzzzg_, nzzzzzzj_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] nzzzzzzl_ = [
            nzzzzzzk_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzm_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> nzzzzzzr_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> nzzzzzzy_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? nzzzzzzz_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> ozzzzzzb_ = DiagnosisLine?.Diagnosis;
                        bool? ozzzzzzc_(Claim.DiagnosisComponent @this)
                        {
                            DataType ozzzzzzq_ = @this?.Diagnosis;
                            bool? ozzzzzzr_ = context.Operators.Not((bool?)(ozzzzzzq_ is null));

                            return ozzzzzzr_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> ozzzzzzd_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)ozzzzzzb_, ozzzzzzc_);
                        object ozzzzzze_(Claim.DiagnosisComponent @this)
                        {
                            DataType ozzzzzzs_ = @this?.Diagnosis;

                            return ozzzzzzs_;
                        };
                        IEnumerable<object> ozzzzzzf_ = context.Operators.Select<Claim.DiagnosisComponent, object>(ozzzzzzd_, ozzzzzze_);
                        bool? ozzzzzzg_(object @this)
                        {
                            object ozzzzzzt_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? ozzzzzzu_ = context.Operators.Not((bool?)(ozzzzzzt_ is null));

                            return ozzzzzzu_;
                        };
                        IEnumerable<object> ozzzzzzh_ = context.Operators.Where<object>(ozzzzzzf_, ozzzzzzg_);
                        object ozzzzzzi_(object @this)
                        {
                            object ozzzzzzv_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return ozzzzzzv_;
                        };
                        IEnumerable<object> ozzzzzzj_ = context.Operators.Select<object, object>(ozzzzzzh_, ozzzzzzi_);
                        IEnumerable<object> ozzzzzzk_ = context.Operators.FlattenLateBoundList(ozzzzzzj_);
                        Coding ozzzzzzl_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> ozzzzzzm_ = context.Operators.Select<object, Coding>(ozzzzzzk_, ozzzzzzl_);
                        bool? ozzzzzzn_(Coding HeaderCode)
                        {
                            Code ozzzzzzw_ = HeaderCode?.CodeElement;
                            string ozzzzzzx_ = ozzzzzzw_?.Value;
                            IEnumerable<string> ozzzzzzy_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? ozzzzzzz_ = context.Operators.In<string>(ozzzzzzx_, ozzzzzzy_);

                            return ozzzzzzz_;
                        };
                        IEnumerable<Coding> ozzzzzzo_ = context.Operators.Where<Coding>(ozzzzzzm_, ozzzzzzn_);
                        bool? ozzzzzzp_ = context.Operators.Exists<Coding>(ozzzzzzo_);

                        return ozzzzzzp_;
                    };
                    IEnumerable<Claim> ozzzzzza_ = context.Operators.Where<Claim>(nzzzzzzy_, nzzzzzzz_);

                    return ozzzzzza_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? nzzzzzzs_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, nzzzzzzr_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] nzzzzzzt_ = [
                nzzzzzzs_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzu_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? HeaderDefinition)
            {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzza_()
                {
                    bool pzzzzzzf_()
                    {
                        IEnumerable<Claim> pzzzzzzg_ = HeaderDefinition?.DiagnosisItems;
                        bool? pzzzzzzh_ = context.Operators.Exists<Claim>(pzzzzzzg_);

                        return pzzzzzzh_ ?? false;
                    };
                    if (pzzzzzzf_())
                    {
                        IEnumerable<Claim> pzzzzzzi_ = HeaderDefinition?.DiagnosisItems;
                        bool? pzzzzzzk_(Claim @this)
                        {
                            List<Claim.ItemComponent> pzzzzzzt_ = @this?.Item;
                            bool? pzzzzzzu_ = context.Operators.Not((bool?)(pzzzzzzt_ is null));

                            return pzzzzzzu_;
                        };
                        IEnumerable<Claim> pzzzzzzl_ = context.Operators.Where<Claim>(pzzzzzzi_, pzzzzzzk_);
                        List<Claim.ItemComponent> pzzzzzzm_(Claim @this)
                        {
                            List<Claim.ItemComponent> pzzzzzzv_ = @this?.Item;

                            return pzzzzzzv_;
                        };
                        IEnumerable<List<Claim.ItemComponent>> pzzzzzzn_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(pzzzzzzl_, pzzzzzzm_);
                        IEnumerable<Claim.ItemComponent> pzzzzzzo_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)pzzzzzzn_);
                        CqlInterval<CqlDateTime> pzzzzzzp_(Claim.ItemComponent NormalDate)
                        {
                            DataType pzzzzzzw_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> pzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, pzzzzzzw_);

                            return pzzzzzzx_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzq_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(pzzzzzzo_, pzzzzzzp_);
                        IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzq_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzs_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, pzzzzzzi_, pzzzzzzr_);

                        return pzzzzzzs_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] pzzzzzzb_ = [
                    pzzzzzza_(),
                ];
                bool? pzzzzzzc_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? pzzzzzzy_ = context.Operators.Not((bool?)(FinalList is null));

                    return pzzzzzzy_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)pzzzzzzb_, pzzzzzzc_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzd_);

                return pzzzzzze_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)nzzzzzzt_, nzzzzzzu_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzv_);
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzw_);

            return nzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)nzzzzzzl_, nzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzo_);

        return nzzzzzzp_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        IEnumerable<Claim> pzzzzzzz_ = this.Pharmacy_Claims(context, claim);
        string qzzzzzza_(CqlCode p)
        {
            string qzzzzzzi_ = p?.code;

            return qzzzzzzi_;
        };
        IEnumerable<string> qzzzzzzb_ = context.Operators.Select<CqlCode, string>(MedicationCodes, qzzzzzza_);
        IEnumerable<string> qzzzzzzc_ = context.Operators.Distinct<string>(qzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? qzzzzzzd_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, pzzzzzzz_, qzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] qzzzzzze_ = [
            qzzzzzzd_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> qzzzzzzf_((CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication)
        {
            IEnumerable<Claim> qzzzzzzj_ = ClaimWithMedication?.PharmacyClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? qzzzzzzk_(Claim Pharmacy)
            {
                List<Claim.ItemComponent> qzzzzzzo_ = Pharmacy?.Item;
                bool? qzzzzzzp_(Claim.ItemComponent ItemOnLine)
                {
                    CodeableConcept qzzzzzzw_ = ItemOnLine?.ProductOrService;
                    CqlConcept qzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, qzzzzzzw_);
                    CqlCode[] qzzzzzzy_ = qzzzzzzx_?.codes;
                    bool? qzzzzzzz_(CqlCode LineCode)
                    {
                        string rzzzzzzc_ = LineCode?.code;
                        IEnumerable<string> rzzzzzzd_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? rzzzzzze_ = context.Operators.In<string>(rzzzzzzc_, rzzzzzzd_);

                        return rzzzzzze_;
                    };
                    IEnumerable<CqlCode> rzzzzzza_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)qzzzzzzy_, qzzzzzzz_);
                    bool? rzzzzzzb_ = context.Operators.Exists<CqlCode>(rzzzzzza_);

                    return rzzzzzzb_;
                };
                IEnumerable<Claim.ItemComponent> qzzzzzzq_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)qzzzzzzo_, qzzzzzzp_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? qzzzzzzr_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, qzzzzzzq_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] qzzzzzzs_ = [
                    qzzzzzzr_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? qzzzzzzt_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    Claim rzzzzzzf_ = LineItemDefinition?.Claim;
                    Claim[] rzzzzzzg_ = [
                        rzzzzzzf_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? rzzzzzzh_(Claim ClaimLines)
                    {
                        List<Claim.ItemComponent> rzzzzzzk_ = ClaimLines?.Item;
                        bool? rzzzzzzl_(Claim.ItemComponent i)
                        {
                            CodeableConcept rzzzzzzu_ = i?.ProductOrService;
                            CqlConcept rzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzzzzzzu_);
                            CqlCode[] rzzzzzzw_ = rzzzzzzv_?.codes;
                            bool? rzzzzzzx_(CqlCode LineCode)
                            {
                                string szzzzzza_ = LineCode?.code;
                                IEnumerable<string> szzzzzzb_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? szzzzzzc_ = context.Operators.In<string>(szzzzzza_, szzzzzzb_);

                                return szzzzzzc_;
                            };
                            IEnumerable<CqlCode> rzzzzzzy_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)rzzzzzzw_, rzzzzzzx_);
                            bool? rzzzzzzz_ = context.Operators.Exists<CqlCode>(rzzzzzzy_);

                            return rzzzzzzz_;
                        };
                        IEnumerable<Claim.ItemComponent> rzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)rzzzzzzk_, rzzzzzzl_);
                        (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? rzzzzzzn_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDateTime> szzzzzzd_()
                            {
                                bool szzzzzzf_()
                                {
                                    Quantity szzzzzzg_ = i?.Quantity;
                                    bool? szzzzzzh_ = context.Operators.Not((bool?)(szzzzzzg_ is null));

                                    return szzzzzzh_ ?? false;
                                };
                                if (szzzzzzf_())
                                {
                                    CqlInterval<CqlDateTime> szzzzzzi_()
                                    {
                                        bool szzzzzzj_()
                                        {
                                            DataType szzzzzzk_ = i?.Serviced;
                                            bool szzzzzzl_ = szzzzzzk_ is Period;

                                            return szzzzzzl_;
                                        };
                                        if (szzzzzzj_())
                                        {
                                            DataType szzzzzzm_ = i?.Serviced;
                                            CqlInterval<CqlDateTime> szzzzzzn_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzzzzm_);
                                            CqlDateTime szzzzzzo_ = context.Operators.Start(szzzzzzn_);
                                            CqlInterval<CqlDateTime> szzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, szzzzzzm_);
                                            CqlDateTime szzzzzzr_ = context.Operators.Start(szzzzzzq_);
                                            Quantity szzzzzzs_ = i?.Quantity;
                                            FhirDecimal szzzzzzt_ = szzzzzzs_?.ValueElement;
                                            decimal? szzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, szzzzzzt_);
                                            CqlDateTime szzzzzzv_ = context.Operators.Add(szzzzzzr_, new CqlQuantity(szzzzzzu_, "day"));
                                            CqlQuantity szzzzzzw_ = context.Operators.Quantity(1m, "day");
                                            CqlDateTime szzzzzzx_ = context.Operators.Subtract(szzzzzzv_, szzzzzzw_);
                                            CqlInterval<CqlDateTime> szzzzzzy_ = context.Operators.Interval(szzzzzzo_, szzzzzzx_, true, true);

                                            return szzzzzzy_;
                                        }
                                        else
                                        {
                                            DataType szzzzzzz_ = i?.Serviced;
                                            CqlDate tzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzzzz_ as Date);
                                            CqlDate tzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzzzz_ as Date);
                                            Quantity tzzzzzzd_ = i?.Quantity;
                                            FhirDecimal tzzzzzze_ = tzzzzzzd_?.ValueElement;
                                            decimal? tzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, tzzzzzze_);
                                            CqlDate tzzzzzzg_ = context.Operators.Add(tzzzzzzc_, new CqlQuantity(tzzzzzzf_, "day"));
                                            CqlQuantity tzzzzzzh_ = context.Operators.Quantity(1m, "day");
                                            CqlDate tzzzzzzi_ = context.Operators.Subtract(tzzzzzzg_, tzzzzzzh_);
                                            CqlInterval<CqlDate> tzzzzzzj_ = context.Operators.Interval(tzzzzzza_, tzzzzzzi_, true, true);
                                            CqlDate tzzzzzzk_ = tzzzzzzj_?.low;
                                            CqlDateTime tzzzzzzl_ = context.Operators.ConvertDateToDateTime(tzzzzzzk_);
                                            CqlDate tzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzzzz_ as Date);
                                            CqlDate tzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzzzz_ as Date);
                                            FhirDecimal tzzzzzzr_ = tzzzzzzd_?.ValueElement;
                                            decimal? tzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, tzzzzzzr_);
                                            CqlDate tzzzzzzt_ = context.Operators.Add(tzzzzzzp_, new CqlQuantity(tzzzzzzs_, "day"));
                                            CqlDate tzzzzzzv_ = context.Operators.Subtract(tzzzzzzt_, tzzzzzzh_);
                                            CqlInterval<CqlDate> tzzzzzzw_ = context.Operators.Interval(tzzzzzzn_, tzzzzzzv_, true, true);
                                            CqlDate tzzzzzzx_ = tzzzzzzw_?.high;
                                            CqlDateTime tzzzzzzy_ = context.Operators.ConvertDateToDateTime(tzzzzzzx_);
                                            CqlDate uzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzzzz_ as Date);
                                            CqlDate uzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzzzz_ as Date);
                                            FhirDecimal uzzzzzze_ = tzzzzzzd_?.ValueElement;
                                            decimal? uzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, uzzzzzze_);
                                            CqlDate uzzzzzzg_ = context.Operators.Add(uzzzzzzc_, new CqlQuantity(uzzzzzzf_, "day"));
                                            CqlDate uzzzzzzi_ = context.Operators.Subtract(uzzzzzzg_, tzzzzzzh_);
                                            CqlInterval<CqlDate> uzzzzzzj_ = context.Operators.Interval(uzzzzzza_, uzzzzzzi_, true, true);
                                            bool? uzzzzzzk_ = uzzzzzzj_?.lowClosed;
                                            CqlDate uzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzzzz_ as Date);
                                            CqlDate uzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzzzz_ as Date);
                                            FhirDecimal uzzzzzzq_ = tzzzzzzd_?.ValueElement;
                                            decimal? uzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, uzzzzzzq_);
                                            CqlDate uzzzzzzs_ = context.Operators.Add(uzzzzzzo_, new CqlQuantity(uzzzzzzr_, "day"));
                                            CqlDate uzzzzzzu_ = context.Operators.Subtract(uzzzzzzs_, tzzzzzzh_);
                                            CqlInterval<CqlDate> uzzzzzzv_ = context.Operators.Interval(uzzzzzzm_, uzzzzzzu_, true, true);
                                            bool? uzzzzzzw_ = uzzzzzzv_?.highClosed;
                                            CqlInterval<CqlDateTime> uzzzzzzx_ = context.Operators.Interval(tzzzzzzl_, tzzzzzzy_, uzzzzzzk_, uzzzzzzw_);

                                            return uzzzzzzx_;
                                        }
                                    };

                                    return szzzzzzi_();
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDateTime>;
                                }
                            };
                            (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? szzzzzze_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, szzzzzzd_());

                            return szzzzzze_;
                        };
                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> rzzzzzzo_ = context.Operators.Select<Claim.ItemComponent, (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>(rzzzzzzm_, rzzzzzzn_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? rzzzzzzp_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, rzzzzzzo_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?[] rzzzzzzq_ = [
                            rzzzzzzp_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? rzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? ItemCalculation)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? uzzzzzzy_()
                            {
                                bool uzzzzzzz_()
                                {
                                    IEnumerable<Claim.ItemComponent> vzzzzzza_ = LineItemDefinition?.LineItems;
                                    bool? vzzzzzzb_ = context.Operators.Exists<Claim.ItemComponent>(vzzzzzza_);

                                    return vzzzzzzb_ ?? false;
                                };
                                if (uzzzzzzz_())
                                {
                                    Claim vzzzzzzc_ = LineItemDefinition?.Claim;
                                    IEnumerable<Claim.ItemComponent> vzzzzzzd_ = LineItemDefinition?.LineItems;
                                    bool? vzzzzzzf_(Claim.ItemComponent @this)
                                    {
                                        DataType vzzzzzzq_ = @this?.Serviced;
                                        bool? vzzzzzzr_ = context.Operators.Not((bool?)(vzzzzzzq_ is null));

                                        return vzzzzzzr_;
                                    };
                                    IEnumerable<Claim.ItemComponent> vzzzzzzg_ = context.Operators.Where<Claim.ItemComponent>(vzzzzzzd_, vzzzzzzf_);
                                    object vzzzzzzh_(Claim.ItemComponent @this)
                                    {
                                        DataType vzzzzzzs_ = @this?.Serviced;

                                        return vzzzzzzs_;
                                    };
                                    IEnumerable<object> vzzzzzzi_ = context.Operators.Select<Claim.ItemComponent, object>(vzzzzzzg_, vzzzzzzh_);
                                    CqlInterval<CqlDateTime> vzzzzzzj_(object NormalDate)
                                    {
                                        CqlInterval<CqlDateTime> vzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                        return vzzzzzzt_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzk_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(vzzzzzzi_, vzzzzzzj_);
                                    IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzzzzzk_);
                                    IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> vzzzzzzm_ = ItemCalculation?.CoveredDays;
                                    CqlInterval<CqlDateTime> vzzzzzzn_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d)
                                    {
                                        CqlInterval<CqlDateTime> vzzzzzzu_ = d?.DaysSupplyInterval;

                                        return vzzzzzzu_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(vzzzzzzm_, vzzzzzzn_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? vzzzzzzp_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, vzzzzzzc_, vzzzzzzd_, vzzzzzzl_, vzzzzzzo_);

                                    return vzzzzzzp_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
                                }
                            };

                            return uzzzzzzy_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> rzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?>)rzzzzzzq_, rzzzzzzr_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? rzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(rzzzzzzs_);

                        return rzzzzzzt_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> rzzzzzzi_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)rzzzzzzg_, rzzzzzzh_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? rzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(rzzzzzzi_);

                    return rzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> qzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)qzzzzzzs_, qzzzzzzt_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? qzzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(qzzzzzzu_);

                return qzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> qzzzzzzl_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(qzzzzzzj_, qzzzzzzk_);
            bool? qzzzzzzm_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList)
            {
                bool? vzzzzzzv_ = context.Operators.Not((bool?)(FinalList is null));

                return vzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> qzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(qzzzzzzl_, qzzzzzzm_);

            return qzzzzzzn_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> qzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)qzzzzzze_, qzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> qzzzzzzh_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(qzzzzzzg_);

        return qzzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> vzzzzzzw_ = this.Professional_or_Institutional_Claims(context, claim);
        string vzzzzzzx_(CqlCode d)
        {
            string wzzzzzzj_ = d?.code;

            return wzzzzzzj_;
        };
        IEnumerable<string> vzzzzzzy_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, vzzzzzzx_);
        IEnumerable<string> vzzzzzzz_ = context.Operators.Distinct<string>(vzzzzzzy_);
        string wzzzzzza_(CqlCode p)
        {
            string wzzzzzzk_ = p?.code;

            return wzzzzzzk_;
        };
        IEnumerable<string> wzzzzzzb_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, wzzzzzza_);
        IEnumerable<string> wzzzzzzc_ = context.Operators.Distinct<string>(wzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? wzzzzzzd_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, vzzzzzzw_, vzzzzzzz_, wzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] wzzzzzze_ = [
            wzzzzzzd_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzf_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> wzzzzzzl_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> wzzzzzzs_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? wzzzzzzt_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> wzzzzzzv_ = DiagnosisLine?.Diagnosis;
                        bool? wzzzzzzw_(Claim.DiagnosisComponent @this)
                        {
                            DataType xzzzzzzk_ = @this?.Diagnosis;
                            bool? xzzzzzzl_ = context.Operators.Not((bool?)(xzzzzzzk_ is null));

                            return xzzzzzzl_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> wzzzzzzx_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)wzzzzzzv_, wzzzzzzw_);
                        object wzzzzzzy_(Claim.DiagnosisComponent @this)
                        {
                            DataType xzzzzzzm_ = @this?.Diagnosis;

                            return xzzzzzzm_;
                        };
                        IEnumerable<object> wzzzzzzz_ = context.Operators.Select<Claim.DiagnosisComponent, object>(wzzzzzzx_, wzzzzzzy_);
                        bool? xzzzzzza_(object @this)
                        {
                            object xzzzzzzn_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? xzzzzzzo_ = context.Operators.Not((bool?)(xzzzzzzn_ is null));

                            return xzzzzzzo_;
                        };
                        IEnumerable<object> xzzzzzzb_ = context.Operators.Where<object>(wzzzzzzz_, xzzzzzza_);
                        object xzzzzzzc_(object @this)
                        {
                            object xzzzzzzp_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return xzzzzzzp_;
                        };
                        IEnumerable<object> xzzzzzzd_ = context.Operators.Select<object, object>(xzzzzzzb_, xzzzzzzc_);
                        IEnumerable<object> xzzzzzze_ = context.Operators.FlattenLateBoundList(xzzzzzzd_);
                        Coding xzzzzzzf_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> xzzzzzzg_ = context.Operators.Select<object, Coding>(xzzzzzze_, xzzzzzzf_);
                        bool? xzzzzzzh_(Coding HeaderCode)
                        {
                            Code xzzzzzzq_ = HeaderCode?.CodeElement;
                            string xzzzzzzr_ = xzzzzzzq_?.Value;
                            IEnumerable<string> xzzzzzzs_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? xzzzzzzt_ = context.Operators.In<string>(xzzzzzzr_, xzzzzzzs_);

                            return xzzzzzzt_;
                        };
                        IEnumerable<Coding> xzzzzzzi_ = context.Operators.Where<Coding>(xzzzzzzg_, xzzzzzzh_);
                        bool? xzzzzzzj_ = context.Operators.Exists<Coding>(xzzzzzzi_);

                        return xzzzzzzj_;
                    };
                    IEnumerable<Claim> wzzzzzzu_ = context.Operators.Where<Claim>(wzzzzzzs_, wzzzzzzt_);

                    return wzzzzzzu_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? wzzzzzzm_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, wzzzzzzl_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] wzzzzzzn_ = [
                wzzzzzzm_,
            ];
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ClaimWithProcedure)
            {
                IEnumerable<Claim> xzzzzzzu_ = ClaimWithProcedure?.DiagnosisItems;
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? xzzzzzzv_(Claim ClaimofInterest)
                {
                    Claim yzzzzzza_()
                    {
                        if (ClaimofInterest is null)
                        {
                            return default;
                        }
                        else
                        {
                            Claim[] yzzzzzzh_ = [
                                ClaimofInterest,
                            ];
                            bool? yzzzzzzi_(Claim ItemOnLine)
                            {
                                List<Claim.ProcedureComponent> yzzzzzzl_ = ItemOnLine?.Procedure;
                                bool? yzzzzzzm_(Claim.ProcedureComponent @this)
                                {
                                    DataType zzzzzzzo_ = @this?.Procedure;
                                    bool? zzzzzzzp_ = context.Operators.Not((bool?)(zzzzzzzo_ is null));

                                    return zzzzzzzp_;
                                };
                                IEnumerable<Claim.ProcedureComponent> yzzzzzzn_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)yzzzzzzl_, yzzzzzzm_);
                                object yzzzzzzo_(Claim.ProcedureComponent @this)
                                {
                                    DataType zzzzzzzq_ = @this?.Procedure;

                                    return zzzzzzzq_;
                                };
                                IEnumerable<object> yzzzzzzp_ = context.Operators.Select<Claim.ProcedureComponent, object>(yzzzzzzn_, yzzzzzzo_);
                                bool? yzzzzzzq_(object @this)
                                {
                                    object zzzzzzzr_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                    bool? zzzzzzzs_ = context.Operators.Not((bool?)(zzzzzzzr_ is null));

                                    return zzzzzzzs_;
                                };
                                IEnumerable<object> yzzzzzzr_ = context.Operators.Where<object>(yzzzzzzp_, yzzzzzzq_);
                                object yzzzzzzs_(object @this)
                                {
                                    object zzzzzzzt_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                    return zzzzzzzt_;
                                };
                                IEnumerable<object> yzzzzzzt_ = context.Operators.Select<object, object>(yzzzzzzr_, yzzzzzzs_);
                                IEnumerable<object> yzzzzzzu_ = context.Operators.FlattenLateBoundList(yzzzzzzt_);
                                Coding yzzzzzzv_(object @object) =>
                                    (Coding)@object;
                                IEnumerable<Coding> yzzzzzzw_ = context.Operators.Select<object, Coding>(yzzzzzzu_, yzzzzzzv_);
                                bool? yzzzzzzx_(Coding ProcedureHeaderCode)
                                {
                                    Code zzzzzzzu_ = ProcedureHeaderCode?.CodeElement;
                                    string zzzzzzzv_ = zzzzzzzu_?.Value;
                                    IEnumerable<string> zzzzzzzw_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? zzzzzzzx_ = context.Operators.In<string>(zzzzzzzv_, zzzzzzzw_);

                                    return zzzzzzzx_;
                                };
                                IEnumerable<Coding> yzzzzzzy_ = context.Operators.Where<Coding>(yzzzzzzw_, yzzzzzzx_);
                                bool? yzzzzzzz_ = context.Operators.Exists<Coding>(yzzzzzzy_);
                                List<Claim.ItemComponent> zzzzzzza_ = ItemOnLine?.Item;
                                bool? zzzzzzzb_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept zzzzzzzy_ = @this?.ProductOrService;
                                    bool? zzzzzzzz_ = context.Operators.Not((bool?)(zzzzzzzy_ is null));

                                    return zzzzzzzz_;
                                };
                                IEnumerable<Claim.ItemComponent> zzzzzzzc_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)zzzzzzza_, zzzzzzzb_);
                                CodeableConcept zzzzzzzd_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept azzzzzzza_ = @this?.ProductOrService;

                                    return azzzzzzza_;
                                };
                                IEnumerable<CodeableConcept> zzzzzzze_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(zzzzzzzc_, zzzzzzzd_);
                                bool? zzzzzzzf_(CodeableConcept @this)
                                {
                                    List<Coding> azzzzzzzb_ = @this?.Coding;
                                    bool? azzzzzzzc_ = context.Operators.Not((bool?)(azzzzzzzb_ is null));

                                    return azzzzzzzc_;
                                };
                                IEnumerable<CodeableConcept> zzzzzzzg_ = context.Operators.Where<CodeableConcept>(zzzzzzze_, zzzzzzzf_);
                                List<Coding> zzzzzzzh_(CodeableConcept @this)
                                {
                                    List<Coding> azzzzzzzd_ = @this?.Coding;

                                    return azzzzzzzd_;
                                };
                                IEnumerable<List<Coding>> zzzzzzzi_ = context.Operators.Select<CodeableConcept, List<Coding>>(zzzzzzzg_, zzzzzzzh_);
                                IEnumerable<Coding> zzzzzzzj_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)zzzzzzzi_);
                                bool? zzzzzzzk_(Coding LineCode)
                                {
                                    Code azzzzzzze_ = LineCode?.CodeElement;
                                    string azzzzzzzf_ = azzzzzzze_?.Value;
                                    IEnumerable<string> azzzzzzzg_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? azzzzzzzh_ = context.Operators.In<string>(azzzzzzzf_, azzzzzzzg_);

                                    return azzzzzzzh_;
                                };
                                IEnumerable<Coding> zzzzzzzl_ = context.Operators.Where<Coding>(zzzzzzzj_, zzzzzzzk_);
                                bool? zzzzzzzm_ = context.Operators.Exists<Coding>(zzzzzzzl_);
                                bool? zzzzzzzn_ = context.Operators.Or(yzzzzzzz_, zzzzzzzm_);

                                return zzzzzzzn_;
                            };
                            IEnumerable<Claim> yzzzzzzj_ = context.Operators.Where<Claim>((IEnumerable<Claim>)yzzzzzzh_, yzzzzzzi_);
                            Claim yzzzzzzk_ = context.Operators.SingletonFrom<Claim>(yzzzzzzj_);

                            return yzzzzzzk_;
                        }
                    };
                    (CqlTupleMetadata, Claim ProcedureItems)? yzzzzzzb_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, yzzzzzza_());
                    (CqlTupleMetadata, Claim ProcedureItems)?[] yzzzzzzc_ = [
                        yzzzzzzb_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzd_((CqlTupleMetadata, Claim ProcedureItems)? HeaderDefinition)
                    {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzi_()
                        {
                            bool azzzzzzzj_()
                            {
                                Claim azzzzzzzk_ = HeaderDefinition?.ProcedureItems;
                                bool? azzzzzzzl_ = context.Operators.Not((bool?)(azzzzzzzk_ is null));

                                return azzzzzzzl_ ?? false;
                            };
                            if (azzzzzzzj_())
                            {
                                Claim azzzzzzzm_ = HeaderDefinition?.ProcedureItems;
                                List<Claim.ItemComponent> azzzzzzzo_ = azzzzzzzm_?.Item;
                                CqlInterval<CqlDateTime> azzzzzzzp_(Claim.ItemComponent NormalDate)
                                {
                                    DataType azzzzzzzt_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> azzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, azzzzzzzt_);

                                    return azzzzzzzu_;
                                };
                                IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzq_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)azzzzzzzo_, azzzzzzzp_);
                                IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzr_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(azzzzzzzq_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzs_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, azzzzzzzm_, azzzzzzzr_);

                                return azzzzzzzs_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        };

                        return azzzzzzzi_();
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim ProcedureItems)?>)yzzzzzzc_, yzzzzzzd_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzze_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzf_);

                    return yzzzzzzg_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzw_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(xzzzzzzu_, xzzzzzzv_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(xzzzzzzw_);
                bool? xzzzzzzy_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? azzzzzzzv_ = context.Operators.Not((bool?)(FinalList is null));

                    return azzzzzzzv_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(xzzzzzzx_, xzzzzzzy_);

                return xzzzzzzz_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)wzzzzzzn_, wzzzzzzo_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzq_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzp_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzr_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzq_);

            return wzzzzzzr_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)wzzzzzze_, wzzzzzzf_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzh_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzi_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzh_);

        return wzzzzzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> azzzzzzzw_ = this.Professional_or_Institutional_Claims(context, claim);
        string azzzzzzzx_(CqlCode d)
        {
            string bzzzzzzzj_ = d?.code;

            return bzzzzzzzj_;
        };
        IEnumerable<string> azzzzzzzy_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, azzzzzzzx_);
        IEnumerable<string> azzzzzzzz_ = context.Operators.Distinct<string>(azzzzzzzy_);
        string bzzzzzzza_(CqlCode p)
        {
            string bzzzzzzzk_ = p?.code;

            return bzzzzzzzk_;
        };
        IEnumerable<string> bzzzzzzzb_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, bzzzzzzza_);
        IEnumerable<string> bzzzzzzzc_ = context.Operators.Distinct<string>(bzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? bzzzzzzzd_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, azzzzzzzw_, azzzzzzzz_, bzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] bzzzzzzze_ = [
            bzzzzzzzd_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzf_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure)
        {
            IEnumerable<Claim> bzzzzzzzl_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzm_(Claim ClaimofInterest)
            {
                Claim bzzzzzzzr_()
                {
                    if (ClaimofInterest is null)
                    {
                        return default;
                    }
                    else
                    {
                        Claim[] bzzzzzzzy_ = [
                            ClaimofInterest,
                        ];
                        bool? bzzzzzzzz_(Claim ItemOnLine)
                        {
                            List<Claim.ItemComponent> czzzzzzzc_ = ItemOnLine?.Item;
                            bool? czzzzzzzd_(Claim.ItemComponent @this)
                            {
                                CodeableConcept dzzzzzzzf_ = @this?.ProductOrService;
                                bool? dzzzzzzzg_ = context.Operators.Not((bool?)(dzzzzzzzf_ is null));

                                return dzzzzzzzg_;
                            };
                            IEnumerable<Claim.ItemComponent> czzzzzzze_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)czzzzzzzc_, czzzzzzzd_);
                            CodeableConcept czzzzzzzf_(Claim.ItemComponent @this)
                            {
                                CodeableConcept dzzzzzzzh_ = @this?.ProductOrService;

                                return dzzzzzzzh_;
                            };
                            IEnumerable<CodeableConcept> czzzzzzzg_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(czzzzzzze_, czzzzzzzf_);
                            bool? czzzzzzzh_(CodeableConcept @this)
                            {
                                List<Coding> dzzzzzzzi_ = @this?.Coding;
                                bool? dzzzzzzzj_ = context.Operators.Not((bool?)(dzzzzzzzi_ is null));

                                return dzzzzzzzj_;
                            };
                            IEnumerable<CodeableConcept> czzzzzzzi_ = context.Operators.Where<CodeableConcept>(czzzzzzzg_, czzzzzzzh_);
                            List<Coding> czzzzzzzj_(CodeableConcept @this)
                            {
                                List<Coding> dzzzzzzzk_ = @this?.Coding;

                                return dzzzzzzzk_;
                            };
                            IEnumerable<List<Coding>> czzzzzzzk_ = context.Operators.Select<CodeableConcept, List<Coding>>(czzzzzzzi_, czzzzzzzj_);
                            IEnumerable<Coding> czzzzzzzl_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)czzzzzzzk_);
                            bool? czzzzzzzm_(Coding LineCode)
                            {
                                Code dzzzzzzzl_ = LineCode?.CodeElement;
                                string dzzzzzzzm_ = dzzzzzzzl_?.Value;
                                IEnumerable<string> dzzzzzzzn_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? dzzzzzzzo_ = context.Operators.In<string>(dzzzzzzzm_, dzzzzzzzn_);

                                return dzzzzzzzo_;
                            };
                            IEnumerable<Coding> czzzzzzzn_ = context.Operators.Where<Coding>(czzzzzzzl_, czzzzzzzm_);
                            bool? czzzzzzzo_ = context.Operators.Exists<Coding>(czzzzzzzn_);
                            List<Claim.ProcedureComponent> czzzzzzzp_ = ItemOnLine?.Procedure;
                            bool? czzzzzzzq_(Claim.ProcedureComponent @this)
                            {
                                DataType dzzzzzzzp_ = @this?.Procedure;
                                bool? dzzzzzzzq_ = context.Operators.Not((bool?)(dzzzzzzzp_ is null));

                                return dzzzzzzzq_;
                            };
                            IEnumerable<Claim.ProcedureComponent> czzzzzzzr_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)czzzzzzzp_, czzzzzzzq_);
                            object czzzzzzzs_(Claim.ProcedureComponent @this)
                            {
                                DataType dzzzzzzzr_ = @this?.Procedure;

                                return dzzzzzzzr_;
                            };
                            IEnumerable<object> czzzzzzzt_ = context.Operators.Select<Claim.ProcedureComponent, object>(czzzzzzzr_, czzzzzzzs_);
                            bool? czzzzzzzu_(object @this)
                            {
                                object dzzzzzzzs_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? dzzzzzzzt_ = context.Operators.Not((bool?)(dzzzzzzzs_ is null));

                                return dzzzzzzzt_;
                            };
                            IEnumerable<object> czzzzzzzv_ = context.Operators.Where<object>(czzzzzzzt_, czzzzzzzu_);
                            object czzzzzzzw_(object @this)
                            {
                                object dzzzzzzzu_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return dzzzzzzzu_;
                            };
                            IEnumerable<object> czzzzzzzx_ = context.Operators.Select<object, object>(czzzzzzzv_, czzzzzzzw_);
                            IEnumerable<object> czzzzzzzy_ = context.Operators.FlattenLateBoundList(czzzzzzzx_);
                            Coding czzzzzzzz_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> dzzzzzzza_ = context.Operators.Select<object, Coding>(czzzzzzzy_, czzzzzzzz_);
                            bool? dzzzzzzzb_(Coding HeaderCode)
                            {
                                Code dzzzzzzzv_ = HeaderCode?.CodeElement;
                                string dzzzzzzzw_ = dzzzzzzzv_?.Value;
                                IEnumerable<string> dzzzzzzzx_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? dzzzzzzzy_ = context.Operators.In<string>(dzzzzzzzw_, dzzzzzzzx_);

                                return dzzzzzzzy_;
                            };
                            IEnumerable<Coding> dzzzzzzzc_ = context.Operators.Where<Coding>(dzzzzzzza_, dzzzzzzzb_);
                            bool? dzzzzzzzd_ = context.Operators.Exists<Coding>(dzzzzzzzc_);
                            bool? dzzzzzzze_ = context.Operators.Or(czzzzzzzo_, dzzzzzzzd_);

                            return dzzzzzzze_;
                        };
                        IEnumerable<Claim> czzzzzzza_ = context.Operators.Where<Claim>((IEnumerable<Claim>)bzzzzzzzy_, bzzzzzzzz_);
                        Claim czzzzzzzb_ = context.Operators.SingletonFrom<Claim>(czzzzzzza_);

                        return czzzzzzzb_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? bzzzzzzzs_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, bzzzzzzzr_());
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?[] bzzzzzzzt_ = [
                    bzzzzzzzs_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzu_((CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? DiagnosisCheck)
                {
                    Claim dzzzzzzzz_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] ezzzzzzza_ = [
                        dzzzzzzzz_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzb_(Claim ClaimforDiagnosis)
                    {
                        List<Claim.ItemComponent> ezzzzzzzf_ = ClaimforDiagnosis?.Item;
                        Claim ezzzzzzzg_()
                        {
                            if (ClaimforDiagnosis is null)
                            {
                                return default;
                            }
                            else
                            {
                                Claim[] ezzzzzzzn_ = [
                                    ClaimforDiagnosis,
                                ];
                                bool? ezzzzzzzo_(Claim RightClaim)
                                {
                                    List<Claim.DiagnosisComponent> ezzzzzzzr_ = RightClaim?.Diagnosis;
                                    bool? ezzzzzzzs_(Claim.DiagnosisComponent RightDiagnosis)
                                    {
                                        PositiveInt ezzzzzzzv_ = RightDiagnosis?.SequenceElement;
                                        Integer ezzzzzzzw_ = context.Operators.Convert<Integer>(ezzzzzzzv_);
                                        int? ezzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, ezzzzzzzw_);
                                        bool? ezzzzzzzy_ = context.Operators.Equal(ezzzzzzzx_, 1);
                                        DataType ezzzzzzzz_ = RightDiagnosis?.Diagnosis;
                                        IEnumerable<Coding> fzzzzzzza_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(ezzzzzzzz_, "coding");
                                        bool? fzzzzzzzb_(Coding DiagnosisCode)
                                        {
                                            Code fzzzzzzzf_ = DiagnosisCode?.CodeElement;
                                            string fzzzzzzzg_ = fzzzzzzzf_?.Value;
                                            IEnumerable<string> fzzzzzzzh_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                            bool? fzzzzzzzi_ = context.Operators.In<string>(fzzzzzzzg_, fzzzzzzzh_);

                                            return fzzzzzzzi_;
                                        };
                                        IEnumerable<Coding> fzzzzzzzc_ = context.Operators.Where<Coding>(fzzzzzzza_, fzzzzzzzb_);
                                        bool? fzzzzzzzd_ = context.Operators.Exists<Coding>(fzzzzzzzc_);
                                        bool? fzzzzzzze_ = context.Operators.And(ezzzzzzzy_, fzzzzzzzd_);

                                        return fzzzzzzze_;
                                    };
                                    IEnumerable<Claim.DiagnosisComponent> ezzzzzzzt_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)ezzzzzzzr_, ezzzzzzzs_);
                                    bool? ezzzzzzzu_ = context.Operators.Exists<Claim.DiagnosisComponent>(ezzzzzzzt_);

                                    return ezzzzzzzu_;
                                };
                                IEnumerable<Claim> ezzzzzzzp_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ezzzzzzzn_, ezzzzzzzo_);
                                Claim ezzzzzzzq_ = context.Operators.SingletonFrom<Claim>(ezzzzzzzp_);

                                return ezzzzzzzq_;
                            }
                        };
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? ezzzzzzzh_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)ezzzzzzzf_, ezzzzzzzg_());
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] ezzzzzzzi_ = [
                            ezzzzzzzh_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzj_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzj_()
                            {
                                bool fzzzzzzzk_()
                                {
                                    bool? fzzzzzzzl_ = context.Operators.Not((bool?)(LineItemDefinition is null));
                                    Claim fzzzzzzzm_ = LineItemDefinition?.LineItems;
                                    bool? fzzzzzzzn_ = context.Operators.Not((bool?)(fzzzzzzzm_ is null));
                                    bool? fzzzzzzzo_ = context.Operators.And(fzzzzzzzl_, fzzzzzzzn_);

                                    return fzzzzzzzo_ ?? false;
                                };
                                if (fzzzzzzzk_())
                                {
                                    Claim fzzzzzzzp_ = LineItemDefinition?.LineItems;
                                    List<Claim.ItemComponent> fzzzzzzzr_ = fzzzzzzzp_?.Item;
                                    CqlInterval<CqlDateTime> fzzzzzzzs_(Claim.ItemComponent NormalDate)
                                    {
                                        DataType fzzzzzzzv_ = NormalDate?.Serviced;
                                        CqlInterval<CqlDateTime> fzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, fzzzzzzzv_);

                                        return fzzzzzzzw_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzt_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)fzzzzzzzr_, fzzzzzzzs_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzu_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, fzzzzzzzp_, fzzzzzzzt_);

                                    return fzzzzzzzu_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                                }
                            };

                            return fzzzzzzzj_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ezzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)ezzzzzzzi_, ezzzzzzzj_);
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ezzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ezzzzzzzk_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ezzzzzzzl_);

                        return ezzzzzzzm_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ezzzzzzzc_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)ezzzzzzza_, ezzzzzzzb_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ezzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ezzzzzzzc_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ezzzzzzzd_);

                    return ezzzzzzze_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?>)bzzzzzzzt_, bzzzzzzzu_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzv_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzw_);

                return bzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzn_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzl_, bzzzzzzzm_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzn_);
            bool? bzzzzzzzp_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? fzzzzzzzx_ = context.Operators.Not((bool?)(FinalList is null));

                return fzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzo_, bzzzzzzzp_);

            return bzzzzzzzq_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> bzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)bzzzzzzze_, bzzzzzzzf_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> bzzzzzzzh_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(bzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzi_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(bzzzzzzzh_);

        return bzzzzzzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> fzzzzzzzy_ = this.Professional_or_Institutional_Claims(context, claim);
        string fzzzzzzzz_(CqlCode d)
        {
            string gzzzzzzzi_ = d?.code;

            return gzzzzzzzi_;
        };
        IEnumerable<string> gzzzzzzza_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, fzzzzzzzz_);
        IEnumerable<string> gzzzzzzzb_ = context.Operators.Distinct<string>(gzzzzzzza_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? gzzzzzzzc_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, fzzzzzzzy_, gzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] gzzzzzzzd_ = [
            gzzzzzzzc_,
        ];
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzze_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> gzzzzzzzj_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> gzzzzzzzq_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? gzzzzzzzr_(Claim RightClaim)
                    {
                        List<Claim.DiagnosisComponent> gzzzzzzzt_ = RightClaim?.Diagnosis;
                        bool? gzzzzzzzu_(Claim.DiagnosisComponent RightDiagnosis)
                        {
                            PositiveInt gzzzzzzzx_ = RightDiagnosis?.SequenceElement;
                            Integer gzzzzzzzy_ = context.Operators.Convert<Integer>(gzzzzzzzx_);
                            int? gzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, gzzzzzzzy_);
                            bool? hzzzzzzza_ = context.Operators.Equal(gzzzzzzzz_, 1);
                            DataType hzzzzzzzb_ = RightDiagnosis?.Diagnosis;
                            IEnumerable<Coding> hzzzzzzzc_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(hzzzzzzzb_, "coding");
                            bool? hzzzzzzzd_(Coding DiagnosisCode)
                            {
                                Code hzzzzzzzh_ = DiagnosisCode?.CodeElement;
                                string hzzzzzzzi_ = hzzzzzzzh_?.Value;
                                IEnumerable<string> hzzzzzzzj_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                                bool? hzzzzzzzk_ = context.Operators.In<string>(hzzzzzzzi_, hzzzzzzzj_);

                                return hzzzzzzzk_;
                            };
                            IEnumerable<Coding> hzzzzzzze_ = context.Operators.Where<Coding>(hzzzzzzzc_, hzzzzzzzd_);
                            bool? hzzzzzzzf_ = context.Operators.Exists<Coding>(hzzzzzzze_);
                            bool? hzzzzzzzg_ = context.Operators.And(hzzzzzzza_, hzzzzzzzf_);

                            return hzzzzzzzg_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> gzzzzzzzv_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)gzzzzzzzt_, gzzzzzzzu_);
                        bool? gzzzzzzzw_ = context.Operators.Exists<Claim.DiagnosisComponent>(gzzzzzzzv_);

                        return gzzzzzzzw_;
                    };
                    IEnumerable<Claim> gzzzzzzzs_ = context.Operators.Where<Claim>(gzzzzzzzq_, gzzzzzzzr_);

                    return gzzzzzzzs_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)? gzzzzzzzk_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, gzzzzzzzj_());
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)?[] gzzzzzzzl_ = [
                gzzzzzzzk_,
            ];
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzm_((CqlTupleMetadata, IEnumerable<Claim> LineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> hzzzzzzzl_ = LineItemDefinition?.LineItems;
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzm_(Claim ClaimWithDiagnosis)
                {
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzr_()
                    {
                        if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
                        {
                            IEnumerable<Claim> hzzzzzzzs_ = LineItemDefinition?.LineItems;
                            bool? hzzzzzzzu_(Claim @this)
                            {
                                List<Claim.ItemComponent> izzzzzzzd_ = @this?.Item;
                                bool? izzzzzzze_ = context.Operators.Not((bool?)(izzzzzzzd_ is null));

                                return izzzzzzze_;
                            };
                            IEnumerable<Claim> hzzzzzzzv_ = context.Operators.Where<Claim>(hzzzzzzzs_, hzzzzzzzu_);
                            List<Claim.ItemComponent> hzzzzzzzw_(Claim @this)
                            {
                                List<Claim.ItemComponent> izzzzzzzf_ = @this?.Item;

                                return izzzzzzzf_;
                            };
                            IEnumerable<List<Claim.ItemComponent>> hzzzzzzzx_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(hzzzzzzzv_, hzzzzzzzw_);
                            IEnumerable<Claim.ItemComponent> hzzzzzzzy_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)hzzzzzzzx_);
                            CqlInterval<CqlDateTime> hzzzzzzzz_(Claim.ItemComponent NormalDate)
                            {
                                DataType izzzzzzzg_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> izzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzg_);

                                return izzzzzzzh_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> izzzzzzza_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(hzzzzzzzy_, hzzzzzzzz_);
                            IEnumerable<CqlInterval<CqlDateTime>> izzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(izzzzzzza_);
                            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? izzzzzzzc_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, hzzzzzzzs_, izzzzzzzb_);

                            return izzzzzzzc_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return hzzzzzzzr_();
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzn_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(hzzzzzzzl_, hzzzzzzzm_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(hzzzzzzzn_);
                bool? hzzzzzzzp_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? izzzzzzzi_ = context.Operators.Not((bool?)(FinalList is null));

                    return izzzzzzzi_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(hzzzzzzzo_, hzzzzzzzp_);

                return hzzzzzzzq_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> gzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?>)gzzzzzzzl_, gzzzzzzzm_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> gzzzzzzzo_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(gzzzzzzzn_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzp_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(gzzzzzzzo_);

            return gzzzzzzzp_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> gzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)gzzzzzzzd_, gzzzzzzze_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> gzzzzzzzg_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(gzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzh_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(gzzzzzzzg_);

        return gzzzzzzzh_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> izzzzzzzj_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
        IEnumerable<Claim> izzzzzzzk_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? izzzzzzzl_ = (CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE, izzzzzzzj_, izzzzzzzk_);

        return izzzzzzzl_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? izzzzzzzm_(ClaimResponse ResponseItem)
        {
            Code<ClaimProcessingCodes> izzzzzzzu_ = ResponseItem?.OutcomeElement;
            string izzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, izzzzzzzu_);
            string[] izzzzzzzw_ = [
                "complete",
                "partial",
            ];
            bool? izzzzzzzx_ = context.Operators.In<string>(izzzzzzzv_, izzzzzzzw_ as IEnumerable<string>);

            return izzzzzzzx_;
        };
        IEnumerable<ClaimResponse> izzzzzzzn_ = context.Operators.Where<ClaimResponse>(claimResponse, izzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? izzzzzzzo_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, izzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?[] izzzzzzzp_ = [
            izzzzzzzo_,
        ];
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> izzzzzzzq_((CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ClaimResponse)
        {
            IEnumerable<ClaimResponse> izzzzzzzy_ = ClaimResponse?.PaidResponse;
            (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? izzzzzzzz_(ClaimResponse ClmResp)
            {
                ResourceReference jzzzzzzzc_ = ClmResp?.Request;
                FhirString jzzzzzzzd_ = jzzzzzzzc_?.ReferenceElement;
                string jzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzd_);
                string jzzzzzzzf_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, jzzzzzzze_);
                List<ClaimResponse.ItemComponent> jzzzzzzzg_ = ClmResp?.Item;
                bool? jzzzzzzzh_(ClaimResponse.ItemComponent ResponseItem)
                {
                    List<ClaimResponse.AdjudicationComponent> jzzzzzzzk_ = ResponseItem?.Adjudication;
                    bool? jzzzzzzzl_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept kzzzzzzzg_ = @this?.Category;
                        bool? kzzzzzzzh_ = context.Operators.Not((bool?)(kzzzzzzzg_ is null));

                        return kzzzzzzzh_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> jzzzzzzzm_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)jzzzzzzzk_, jzzzzzzzl_);
                    CodeableConcept jzzzzzzzn_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept kzzzzzzzi_ = @this?.Category;

                        return kzzzzzzzi_;
                    };
                    IEnumerable<CodeableConcept> jzzzzzzzo_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(jzzzzzzzm_, jzzzzzzzn_);
                    bool? jzzzzzzzp_(CodeableConcept @this)
                    {
                        List<Coding> kzzzzzzzj_ = @this?.Coding;
                        bool? kzzzzzzzk_ = context.Operators.Not((bool?)(kzzzzzzzj_ is null));

                        return kzzzzzzzk_;
                    };
                    IEnumerable<CodeableConcept> jzzzzzzzq_ = context.Operators.Where<CodeableConcept>(jzzzzzzzo_, jzzzzzzzp_);
                    List<Coding> jzzzzzzzr_(CodeableConcept @this)
                    {
                        List<Coding> kzzzzzzzl_ = @this?.Coding;

                        return kzzzzzzzl_;
                    };
                    IEnumerable<List<Coding>> jzzzzzzzs_ = context.Operators.Select<CodeableConcept, List<Coding>>(jzzzzzzzq_, jzzzzzzzr_);
                    IEnumerable<Coding> jzzzzzzzt_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)jzzzzzzzs_);
                    bool? jzzzzzzzu_(Coding CategoryItem)
                    {
                        Code kzzzzzzzm_ = CategoryItem?.CodeElement;
                        string kzzzzzzzn_ = kzzzzzzzm_?.Value;
                        bool? kzzzzzzzo_ = context.Operators.Equal(kzzzzzzzn_, "benefit");

                        return kzzzzzzzo_;
                    };
                    IEnumerable<Coding> jzzzzzzzv_ = context.Operators.Where<Coding>(jzzzzzzzt_, jzzzzzzzu_);
                    bool? jzzzzzzzw_ = context.Operators.Exists<Coding>(jzzzzzzzv_);
                    bool? jzzzzzzzy_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money kzzzzzzzp_ = @this?.Amount;
                        bool? kzzzzzzzq_ = context.Operators.Not((bool?)(kzzzzzzzp_ is null));

                        return kzzzzzzzq_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> jzzzzzzzz_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)jzzzzzzzk_, jzzzzzzzy_);
                    Money kzzzzzzza_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money kzzzzzzzr_ = @this?.Amount;

                        return kzzzzzzzr_;
                    };
                    IEnumerable<Money> kzzzzzzzb_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(jzzzzzzzz_, kzzzzzzza_);
                    bool? kzzzzzzzc_(Money DollarAmount)
                    {
                        FhirDecimal kzzzzzzzs_ = DollarAmount?.ValueElement;
                        decimal? kzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, kzzzzzzzs_);
                        decimal? kzzzzzzzu_ = context.Operators.ConvertIntegerToDecimal(0);
                        bool? kzzzzzzzv_ = context.Operators.Greater(kzzzzzzzt_, kzzzzzzzu_);

                        return kzzzzzzzv_;
                    };
                    IEnumerable<Money> kzzzzzzzd_ = context.Operators.Where<Money>(kzzzzzzzb_, kzzzzzzzc_);
                    bool? kzzzzzzze_ = context.Operators.Exists<Money>(kzzzzzzzd_);
                    bool? kzzzzzzzf_ = context.Operators.And(jzzzzzzzw_, kzzzzzzze_);

                    return kzzzzzzzf_;
                };
                IEnumerable<ClaimResponse.ItemComponent> jzzzzzzzi_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)jzzzzzzzg_, jzzzzzzzh_);
                (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? jzzzzzzzj_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, jzzzzzzzf_, jzzzzzzzi_);

                return jzzzzzzzj_;
            };
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzza_ = context.Operators.Select<ClaimResponse, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(izzzzzzzy_, izzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(jzzzzzzza_);

            return jzzzzzzzb_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> izzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?>)izzzzzzzp_, izzzzzzzq_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> izzzzzzzs_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(izzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> izzzzzzzt_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(izzzzzzzs_);

        return izzzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? kzzzzzzzw_(Claim AllClaims)
        {
            List<Claim.ItemComponent> lzzzzzzzb_ = AllClaims?.Item;
            bool? lzzzzzzzc_(Claim.ItemComponent @this)
            {
                CodeableConcept mzzzzzzze_ = @this?.ProductOrService;
                bool? mzzzzzzzf_ = context.Operators.Not((bool?)(mzzzzzzze_ is null));

                return mzzzzzzzf_;
            };
            IEnumerable<Claim.ItemComponent> lzzzzzzzd_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)lzzzzzzzb_, lzzzzzzzc_);
            CodeableConcept lzzzzzzze_(Claim.ItemComponent @this)
            {
                CodeableConcept mzzzzzzzg_ = @this?.ProductOrService;

                return mzzzzzzzg_;
            };
            IEnumerable<CodeableConcept> lzzzzzzzf_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(lzzzzzzzd_, lzzzzzzze_);
            bool? lzzzzzzzg_(CodeableConcept @this)
            {
                List<Coding> mzzzzzzzh_ = @this?.Coding;
                bool? mzzzzzzzi_ = context.Operators.Not((bool?)(mzzzzzzzh_ is null));

                return mzzzzzzzi_;
            };
            IEnumerable<CodeableConcept> lzzzzzzzh_ = context.Operators.Where<CodeableConcept>(lzzzzzzzf_, lzzzzzzzg_);
            List<Coding> lzzzzzzzi_(CodeableConcept @this)
            {
                List<Coding> mzzzzzzzj_ = @this?.Coding;

                return mzzzzzzzj_;
            };
            IEnumerable<List<Coding>> lzzzzzzzj_ = context.Operators.Select<CodeableConcept, List<Coding>>(lzzzzzzzh_, lzzzzzzzi_);
            IEnumerable<Coding> lzzzzzzzk_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)lzzzzzzzj_);
            bool? lzzzzzzzl_(Coding ProductOrServiceCode)
            {
                CqlCode mzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? mzzzzzzzl_ = context.Operators.In<CqlCode>(mzzzzzzzk_, ProductOrServiceValueSet);

                return mzzzzzzzl_;
            };
            IEnumerable<Coding> lzzzzzzzm_ = context.Operators.Where<Coding>(lzzzzzzzk_, lzzzzzzzl_);
            bool? lzzzzzzzn_ = context.Operators.Exists<Coding>(lzzzzzzzm_);
            List<Claim.DiagnosisComponent> lzzzzzzzo_ = AllClaims?.Diagnosis;
            bool? lzzzzzzzp_(Claim.DiagnosisComponent @this)
            {
                DataType mzzzzzzzm_ = @this?.Diagnosis;
                bool? mzzzzzzzn_ = context.Operators.Not((bool?)(mzzzzzzzm_ is null));

                return mzzzzzzzn_;
            };
            IEnumerable<Claim.DiagnosisComponent> lzzzzzzzq_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)lzzzzzzzo_, lzzzzzzzp_);
            object lzzzzzzzr_(Claim.DiagnosisComponent @this)
            {
                DataType mzzzzzzzo_ = @this?.Diagnosis;

                return mzzzzzzzo_;
            };
            IEnumerable<object> lzzzzzzzs_ = context.Operators.Select<Claim.DiagnosisComponent, object>(lzzzzzzzq_, lzzzzzzzr_);
            bool? lzzzzzzzt_(object @this)
            {
                object mzzzzzzzp_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? mzzzzzzzq_ = context.Operators.Not((bool?)(mzzzzzzzp_ is null));

                return mzzzzzzzq_;
            };
            IEnumerable<object> lzzzzzzzu_ = context.Operators.Where<object>(lzzzzzzzs_, lzzzzzzzt_);
            object lzzzzzzzv_(object @this)
            {
                object mzzzzzzzr_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return mzzzzzzzr_;
            };
            IEnumerable<object> lzzzzzzzw_ = context.Operators.Select<object, object>(lzzzzzzzu_, lzzzzzzzv_);
            IEnumerable<object> lzzzzzzzx_ = context.Operators.FlattenLateBoundList(lzzzzzzzw_);
            Coding lzzzzzzzy_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> lzzzzzzzz_ = context.Operators.Select<object, Coding>(lzzzzzzzx_, lzzzzzzzy_);
            bool? mzzzzzzza_(Coding DiagnosisCode)
            {
                CqlCode mzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? mzzzzzzzt_ = context.Operators.In<CqlCode>(mzzzzzzzs_, DiagnosisValueSet);

                return mzzzzzzzt_;
            };
            IEnumerable<Coding> mzzzzzzzb_ = context.Operators.Where<Coding>(lzzzzzzzz_, mzzzzzzza_);
            bool? mzzzzzzzc_ = context.Operators.Exists<Coding>(mzzzzzzzb_);
            bool? mzzzzzzzd_ = context.Operators.And(lzzzzzzzn_, mzzzzzzzc_);

            return mzzzzzzzd_;
        };
        IEnumerable<Claim> kzzzzzzzx_ = context.Operators.Where<Claim>(claim, kzzzzzzzw_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? kzzzzzzzy_(Claim ProcedureClaims)
        {
            Id mzzzzzzzu_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> mzzzzzzzv_ = ProcedureClaims?.Item;
            bool? mzzzzzzzw_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept mzzzzzzzz_ = ResponseItem?.ProductOrService;
                List<Coding> nzzzzzzza_ = mzzzzzzzz_?.Coding;
                bool? nzzzzzzzb_(Coding ProductOrServiceCode)
                {
                    CqlCode nzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? nzzzzzzzf_ = context.Operators.In<CqlCode>(nzzzzzzze_, ProductOrServiceValueSet);

                    return nzzzzzzzf_;
                };
                IEnumerable<Coding> nzzzzzzzc_ = context.Operators.Where<Coding>((IEnumerable<Coding>)nzzzzzzza_, nzzzzzzzb_);
                bool? nzzzzzzzd_ = context.Operators.Exists<Coding>(nzzzzzzzc_);

                return nzzzzzzzd_;
            };
            IEnumerable<Claim.ItemComponent> mzzzzzzzx_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)mzzzzzzzv_, mzzzzzzzw_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? mzzzzzzzy_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, mzzzzzzzu_, mzzzzzzzx_);

            return mzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> kzzzzzzzz_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(kzzzzzzzx_, kzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> lzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(kzzzzzzzz_);

        return lzzzzzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> nzzzzzzzg_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> nzzzzzzzh_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? nzzzzzzzi_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, nzzzzzzzg_, nzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] nzzzzzzzj_ = [
            nzzzzzzzi_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzk_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> nzzzzzzzo_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? nzzzzzzzp_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> nzzzzzzzy_ = medClaim?.LineItems;
                bool? nzzzzzzzz_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzc_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzd_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> ozzzzzzzg_ = pClaim?.LineItems;
                        bool? ozzzzzzzh_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id ozzzzzzzl_()
                            {
                                bool ozzzzzzzz_()
                                {
                                    Claim pzzzzzzza_ = medClaim?.ClaimofInterest;
                                    bool pzzzzzzzb_ = pzzzzzzza_ is Resource;

                                    return pzzzzzzzb_;
                                };
                                if (ozzzzzzzz_())
                                {
                                    Claim pzzzzzzzc_ = medClaim?.ClaimofInterest;

                                    return (pzzzzzzzc_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string ozzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzl_());
                            ClaimResponse ozzzzzzzn_ = pClaim?.Response;
                            ResourceReference ozzzzzzzo_ = ozzzzzzzn_?.Request;
                            FhirString ozzzzzzzp_ = ozzzzzzzo_?.ReferenceElement;
                            string ozzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, ozzzzzzzp_);
                            string ozzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ozzzzzzzq_);
                            bool? ozzzzzzzs_ = context.Operators.Equal(ozzzzzzzm_, ozzzzzzzr_);
                            PositiveInt ozzzzzzzt_ = medClaimLineItem?.SequenceElement;
                            Integer ozzzzzzzu_ = context.Operators.Convert<Integer>(ozzzzzzzt_);
                            PositiveInt ozzzzzzzv_ = pClaimLineItem?.ItemSequenceElement;
                            Integer ozzzzzzzw_ = context.Operators.Convert<Integer>(ozzzzzzzv_);
                            bool? ozzzzzzzx_ = context.Operators.Equal(ozzzzzzzu_, ozzzzzzzw_);
                            bool? ozzzzzzzy_ = context.Operators.And(ozzzzzzzs_, ozzzzzzzx_);

                            return ozzzzzzzy_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> ozzzzzzzi_ = context.Operators.Where<ClaimResponse.ItemComponent>(ozzzzzzzg_, ozzzzzzzh_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? ozzzzzzzj_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzk_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ozzzzzzzi_, ozzzzzzzj_);

                        return ozzzzzzzk_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzze_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ozzzzzzzc_, ozzzzzzzd_);
                    bool? ozzzzzzzf_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ozzzzzzze_);

                    return ozzzzzzzf_;
                };
                IEnumerable<Claim.ItemComponent> ozzzzzzza_ = context.Operators.Where<Claim.ItemComponent>(nzzzzzzzy_, nzzzzzzzz_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? ozzzzzzzb_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, ozzzzzzza_);

                return ozzzzzzzb_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> nzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(nzzzzzzzo_, nzzzzzzzp_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> nzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(nzzzzzzzq_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? nzzzzzzzs_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, nzzzzzzzr_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] nzzzzzzzt_ = [
                nzzzzzzzs_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzu_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzd_()
                {
                    bool pzzzzzzzi_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> pzzzzzzzj_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? pzzzzzzzk_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> pzzzzzzzq_ = @this?.ClaimItem;
                            bool? pzzzzzzzr_ = context.Operators.Not((bool?)(pzzzzzzzq_ is null));

                            return pzzzzzzzr_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> pzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(pzzzzzzzj_, pzzzzzzzk_);
                        IEnumerable<Claim.ItemComponent> pzzzzzzzm_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> pzzzzzzzs_ = @this?.ClaimItem;

                            return pzzzzzzzs_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> pzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(pzzzzzzzl_, pzzzzzzzm_);
                        IEnumerable<Claim.ItemComponent> pzzzzzzzo_ = context.Operators.Flatten<Claim.ItemComponent>(pzzzzzzzn_);
                        bool? pzzzzzzzp_ = context.Operators.Exists<Claim.ItemComponent>(pzzzzzzzo_);

                        return pzzzzzzzp_ ?? false;
                    };
                    if (pzzzzzzzi_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> pzzzzzzzt_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? pzzzzzzzu_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? qzzzzzzzi_ = @this?.PaidClaim;
                            bool? qzzzzzzzj_ = context.Operators.Not((bool?)(qzzzzzzzi_ is null));

                            return qzzzzzzzj_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> pzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(pzzzzzzzt_, pzzzzzzzu_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? pzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? qzzzzzzzk_ = @this?.PaidClaim;

                            return qzzzzzzzk_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> pzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(pzzzzzzzv_, pzzzzzzzw_);
                        bool? pzzzzzzzz_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> qzzzzzzzl_ = @this?.ClaimItem;
                            bool? qzzzzzzzm_ = context.Operators.Not((bool?)(qzzzzzzzl_ is null));

                            return qzzzzzzzm_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(pzzzzzzzt_, pzzzzzzzz_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzb_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> qzzzzzzzn_ = @this?.ClaimItem;

                            return qzzzzzzzn_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> qzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(qzzzzzzza_, qzzzzzzzb_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzd_ = context.Operators.Flatten<Claim.ItemComponent>(qzzzzzzzc_);
                        CqlInterval<CqlDateTime> qzzzzzzze_(Claim.ItemComponent PaidItem)
                        {
                            DataType qzzzzzzzo_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> qzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, qzzzzzzzo_);

                            return qzzzzzzzp_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzf_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(qzzzzzzzd_, qzzzzzzze_);
                        IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzzzzzf_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzh_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, pzzzzzzzx_, qzzzzzzzg_);

                        return qzzzzzzzh_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] pzzzzzzze_ = [
                    pzzzzzzzd_(),
                ];
                bool? pzzzzzzzf_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? qzzzzzzzq_ = context.Operators.Not((bool?)(FinalList is null));

                    return qzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)pzzzzzzze_, pzzzzzzzf_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzzg_);

                return pzzzzzzzh_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)nzzzzzzzt_, nzzzzzzzu_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzv_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzw_);

            return nzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)nzzzzzzzj_, nzzzzzzzk_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzm_);

        return nzzzzzzzn_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? qzzzzzzzr_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] qzzzzzzzs_ = [
            qzzzzzzzr_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzt_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzb_()
            {
                bool rzzzzzzzc_()
                {
                    IEnumerable<ClaimResponse> rzzzzzzzd_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> rzzzzzzze_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? rzzzzzzzf_ = context.Operators.And((bool?)(rzzzzzzzd_ is null), (bool?)(rzzzzzzze_ is null));

                    return rzzzzzzzf_ ?? false;
                };
                if (rzzzzzzzc_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> rzzzzzzzg_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> rzzzzzzzh_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzi_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, rzzzzzzzg_, rzzzzzzzh_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return rzzzzzzzi_;
                }
            };

            return rzzzzzzzb_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)qzzzzzzzs_, qzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] qzzzzzzzx_ = [
            qzzzzzzzw_,
        ];
        bool? qzzzzzzzy_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
        {
            bool? rzzzzzzzj_ = context.Operators.Not((bool?)(FinalList is null));

            return rzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)qzzzzzzzx_, qzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzz_);

        return rzzzzzzza_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? rzzzzzzzk_(Claim AllClaims)
        {
            List<Claim.ItemComponent> rzzzzzzzp_ = AllClaims?.Item;
            bool? rzzzzzzzq_(Claim.ItemComponent @this)
            {
                CodeableConcept szzzzzzzs_ = @this?.ProductOrService;
                bool? szzzzzzzt_ = context.Operators.Not((bool?)(szzzzzzzs_ is null));

                return szzzzzzzt_;
            };
            IEnumerable<Claim.ItemComponent> rzzzzzzzr_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)rzzzzzzzp_, rzzzzzzzq_);
            CodeableConcept rzzzzzzzs_(Claim.ItemComponent @this)
            {
                CodeableConcept szzzzzzzu_ = @this?.ProductOrService;

                return szzzzzzzu_;
            };
            IEnumerable<CodeableConcept> rzzzzzzzt_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(rzzzzzzzr_, rzzzzzzzs_);
            bool? rzzzzzzzu_(CodeableConcept @this)
            {
                List<Coding> szzzzzzzv_ = @this?.Coding;
                bool? szzzzzzzw_ = context.Operators.Not((bool?)(szzzzzzzv_ is null));

                return szzzzzzzw_;
            };
            IEnumerable<CodeableConcept> rzzzzzzzv_ = context.Operators.Where<CodeableConcept>(rzzzzzzzt_, rzzzzzzzu_);
            List<Coding> rzzzzzzzw_(CodeableConcept @this)
            {
                List<Coding> szzzzzzzx_ = @this?.Coding;

                return szzzzzzzx_;
            };
            IEnumerable<List<Coding>> rzzzzzzzx_ = context.Operators.Select<CodeableConcept, List<Coding>>(rzzzzzzzv_, rzzzzzzzw_);
            IEnumerable<Coding> rzzzzzzzy_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)rzzzzzzzx_);
            bool? rzzzzzzzz_(Coding ProductOrServiceCode)
            {
                CqlCode szzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? szzzzzzzz_ = context.Operators.In<CqlCode>(szzzzzzzy_, ProductOrServiceValueSet);

                return szzzzzzzz_;
            };
            IEnumerable<Coding> szzzzzzza_ = context.Operators.Where<Coding>(rzzzzzzzy_, rzzzzzzzz_);
            bool? szzzzzzzb_ = context.Operators.Exists<Coding>(szzzzzzza_);
            List<Claim.DiagnosisComponent> szzzzzzzc_ = AllClaims?.Diagnosis;
            bool? szzzzzzzd_(Claim.DiagnosisComponent @this)
            {
                DataType tzzzzzzza_ = @this?.Diagnosis;
                bool? tzzzzzzzb_ = context.Operators.Not((bool?)(tzzzzzzza_ is null));

                return tzzzzzzzb_;
            };
            IEnumerable<Claim.DiagnosisComponent> szzzzzzze_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)szzzzzzzc_, szzzzzzzd_);
            object szzzzzzzf_(Claim.DiagnosisComponent @this)
            {
                DataType tzzzzzzzc_ = @this?.Diagnosis;

                return tzzzzzzzc_;
            };
            IEnumerable<object> szzzzzzzg_ = context.Operators.Select<Claim.DiagnosisComponent, object>(szzzzzzze_, szzzzzzzf_);
            bool? szzzzzzzh_(object @this)
            {
                object tzzzzzzzd_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? tzzzzzzze_ = context.Operators.Not((bool?)(tzzzzzzzd_ is null));

                return tzzzzzzze_;
            };
            IEnumerable<object> szzzzzzzi_ = context.Operators.Where<object>(szzzzzzzg_, szzzzzzzh_);
            object szzzzzzzj_(object @this)
            {
                object tzzzzzzzf_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return tzzzzzzzf_;
            };
            IEnumerable<object> szzzzzzzk_ = context.Operators.Select<object, object>(szzzzzzzi_, szzzzzzzj_);
            IEnumerable<object> szzzzzzzl_ = context.Operators.FlattenLateBoundList(szzzzzzzk_);
            Coding szzzzzzzm_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> szzzzzzzn_ = context.Operators.Select<object, Coding>(szzzzzzzl_, szzzzzzzm_);
            bool? szzzzzzzo_(Coding DiagnosisCode)
            {
                CqlCode tzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? tzzzzzzzh_ = context.Operators.In<CqlCode>(tzzzzzzzg_, DiagnosisValueSet);

                return tzzzzzzzh_;
            };
            IEnumerable<Coding> szzzzzzzp_ = context.Operators.Where<Coding>(szzzzzzzn_, szzzzzzzo_);
            bool? szzzzzzzq_ = context.Operators.Exists<Coding>(szzzzzzzp_);
            bool? szzzzzzzr_ = context.Operators.Or(szzzzzzzb_, szzzzzzzq_);

            return szzzzzzzr_;
        };
        IEnumerable<Claim> rzzzzzzzl_ = context.Operators.Where<Claim>(claim, rzzzzzzzk_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? rzzzzzzzm_(Claim ProcedureClaims)
        {
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? tzzzzzzzi_()
            {
                bool tzzzzzzzj_()
                {
                    List<Claim.ItemComponent> tzzzzzzzk_ = ProcedureClaims?.Item;
                    bool? tzzzzzzzl_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept tzzzzzzzo_ = ResponseItem?.ProductOrService;
                        List<Coding> tzzzzzzzp_ = tzzzzzzzo_?.Coding;
                        bool? tzzzzzzzq_(Coding ProductOrServiceCode)
                        {
                            CqlCode tzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? tzzzzzzzu_ = context.Operators.In<CqlCode>(tzzzzzzzt_, ProductOrServiceValueSet);

                            return tzzzzzzzu_;
                        };
                        IEnumerable<Coding> tzzzzzzzr_ = context.Operators.Where<Coding>((IEnumerable<Coding>)tzzzzzzzp_, tzzzzzzzq_);
                        bool? tzzzzzzzs_ = context.Operators.Exists<Coding>(tzzzzzzzr_);

                        return tzzzzzzzs_;
                    };
                    IEnumerable<Claim.ItemComponent> tzzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)tzzzzzzzk_, tzzzzzzzl_);
                    bool? tzzzzzzzn_ = context.Operators.Exists<Claim.ItemComponent>(tzzzzzzzm_);

                    return tzzzzzzzn_ ?? false;
                };
                if (tzzzzzzzj_())
                {
                    Id tzzzzzzzv_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> tzzzzzzzw_ = ProcedureClaims?.Item;
                    bool? tzzzzzzzx_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept uzzzzzzza_ = ResponseItem?.ProductOrService;
                        List<Coding> uzzzzzzzb_ = uzzzzzzza_?.Coding;
                        bool? uzzzzzzzc_(Coding ProductOrServiceCode)
                        {
                            CqlCode uzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? uzzzzzzzg_ = context.Operators.In<CqlCode>(uzzzzzzzf_, ProductOrServiceValueSet);

                            return uzzzzzzzg_;
                        };
                        IEnumerable<Coding> uzzzzzzzd_ = context.Operators.Where<Coding>((IEnumerable<Coding>)uzzzzzzzb_, uzzzzzzzc_);
                        bool? uzzzzzzze_ = context.Operators.Exists<Coding>(uzzzzzzzd_);

                        return uzzzzzzze_;
                    };
                    IEnumerable<Claim.ItemComponent> tzzzzzzzy_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)tzzzzzzzw_, tzzzzzzzx_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? tzzzzzzzz_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, tzzzzzzzv_, tzzzzzzzy_);

                    return tzzzzzzzz_;
                }
                else
                {
                    Id uzzzzzzzh_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> uzzzzzzzi_ = ProcedureClaims?.Item;
                    bool? uzzzzzzzj_(Claim.ItemComponent ResponseItem)
                    {
                        PositiveInt uzzzzzzzm_ = ResponseItem?.SequenceElement;
                        Integer uzzzzzzzn_ = context.Operators.Convert<Integer>(uzzzzzzzm_);
                        int? uzzzzzzzo_ = uzzzzzzzn_?.Value;
                        bool? uzzzzzzzp_ = context.Operators.Equal(uzzzzzzzo_, 1);

                        return uzzzzzzzp_;
                    };
                    IEnumerable<Claim.ItemComponent> uzzzzzzzk_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)uzzzzzzzi_, uzzzzzzzj_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? uzzzzzzzl_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, uzzzzzzzh_, uzzzzzzzk_);

                    return uzzzzzzzl_;
                }
            };

            return tzzzzzzzi_();
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> rzzzzzzzn_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(rzzzzzzzl_, rzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> rzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(rzzzzzzzn_);

        return rzzzzzzzo_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> uzzzzzzzq_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> uzzzzzzzr_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? uzzzzzzzs_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, uzzzzzzzq_, uzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] uzzzzzzzt_ = [
            uzzzzzzzs_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzu_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> uzzzzzzzy_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? uzzzzzzzz_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> vzzzzzzzi_ = medClaim?.LineItems;
                bool? vzzzzzzzj_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzm_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzn_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> vzzzzzzzq_ = pClaim?.LineItems;
                        bool? vzzzzzzzr_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id vzzzzzzzv_()
                            {
                                bool wzzzzzzzj_()
                                {
                                    Claim wzzzzzzzk_ = medClaim?.ClaimofInterest;
                                    bool wzzzzzzzl_ = wzzzzzzzk_ is Resource;

                                    return wzzzzzzzl_;
                                };
                                if (wzzzzzzzj_())
                                {
                                    Claim wzzzzzzzm_ = medClaim?.ClaimofInterest;

                                    return (wzzzzzzzm_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string vzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzv_());
                            ClaimResponse vzzzzzzzx_ = pClaim?.Response;
                            ResourceReference vzzzzzzzy_ = vzzzzzzzx_?.Request;
                            FhirString vzzzzzzzz_ = vzzzzzzzy_?.ReferenceElement;
                            string wzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzz_);
                            string wzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, wzzzzzzza_);
                            bool? wzzzzzzzc_ = context.Operators.Equal(vzzzzzzzw_, wzzzzzzzb_);
                            PositiveInt wzzzzzzzd_ = medClaimLineItem?.SequenceElement;
                            Integer wzzzzzzze_ = context.Operators.Convert<Integer>(wzzzzzzzd_);
                            PositiveInt wzzzzzzzf_ = pClaimLineItem?.ItemSequenceElement;
                            Integer wzzzzzzzg_ = context.Operators.Convert<Integer>(wzzzzzzzf_);
                            bool? wzzzzzzzh_ = context.Operators.Equal(wzzzzzzze_, wzzzzzzzg_);
                            bool? wzzzzzzzi_ = context.Operators.And(wzzzzzzzc_, wzzzzzzzh_);

                            return wzzzzzzzi_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> vzzzzzzzs_ = context.Operators.Where<ClaimResponse.ItemComponent>(vzzzzzzzq_, vzzzzzzzr_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? vzzzzzzzt_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzu_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(vzzzzzzzs_, vzzzzzzzt_);

                        return vzzzzzzzu_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzo_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(vzzzzzzzm_, vzzzzzzzn_);
                    bool? vzzzzzzzp_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(vzzzzzzzo_);

                    return vzzzzzzzp_;
                };
                IEnumerable<Claim.ItemComponent> vzzzzzzzk_ = context.Operators.Where<Claim.ItemComponent>(vzzzzzzzi_, vzzzzzzzj_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? vzzzzzzzl_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, vzzzzzzzk_);

                return vzzzzzzzl_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(uzzzzzzzy_, uzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(vzzzzzzza_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? vzzzzzzzc_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, vzzzzzzzb_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] vzzzzzzzd_ = [
                vzzzzzzzc_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzze_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzn_()
                {
                    bool wzzzzzzzs_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> wzzzzzzzt_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? wzzzzzzzu_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzza_ = @this?.ClaimItem;
                            bool? xzzzzzzzb_ = context.Operators.Not((bool?)(xzzzzzzza_ is null));

                            return xzzzzzzzb_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> wzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(wzzzzzzzt_, wzzzzzzzu_);
                        IEnumerable<Claim.ItemComponent> wzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzc_ = @this?.ClaimItem;

                            return xzzzzzzzc_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> wzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(wzzzzzzzv_, wzzzzzzzw_);
                        IEnumerable<Claim.ItemComponent> wzzzzzzzy_ = context.Operators.Flatten<Claim.ItemComponent>(wzzzzzzzx_);
                        bool? wzzzzzzzz_ = context.Operators.Exists<Claim.ItemComponent>(wzzzzzzzy_);

                        return wzzzzzzzz_ ?? false;
                    };
                    if (wzzzzzzzs_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> xzzzzzzzd_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? xzzzzzzze_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? xzzzzzzzs_ = @this?.PaidClaim;
                            bool? xzzzzzzzt_ = context.Operators.Not((bool?)(xzzzzzzzs_ is null));

                            return xzzzzzzzt_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> xzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(xzzzzzzzd_, xzzzzzzze_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? xzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? xzzzzzzzu_ = @this?.PaidClaim;

                            return xzzzzzzzu_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> xzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(xzzzzzzzf_, xzzzzzzzg_);
                        bool? xzzzzzzzj_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzv_ = @this?.ClaimItem;
                            bool? xzzzzzzzw_ = context.Operators.Not((bool?)(xzzzzzzzv_ is null));

                            return xzzzzzzzw_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> xzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(xzzzzzzzd_, xzzzzzzzj_);
                        IEnumerable<Claim.ItemComponent> xzzzzzzzl_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzx_ = @this?.ClaimItem;

                            return xzzzzzzzx_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> xzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(xzzzzzzzk_, xzzzzzzzl_);
                        IEnumerable<Claim.ItemComponent> xzzzzzzzn_ = context.Operators.Flatten<Claim.ItemComponent>(xzzzzzzzm_);
                        CqlInterval<CqlDateTime> xzzzzzzzo_(Claim.ItemComponent PaidItem)
                        {
                            DataType xzzzzzzzy_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> xzzzzzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzy_);

                            return xzzzzzzzz_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzp_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(xzzzzzzzn_, xzzzzzzzo_);
                        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xzzzzzzzp_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? xzzzzzzzr_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, xzzzzzzzh_, xzzzzzzzq_);

                        return xzzzzzzzr_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] wzzzzzzzo_ = [
                    wzzzzzzzn_(),
                ];
                bool? wzzzzzzzp_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? yzzzzzzza_ = context.Operators.Not((bool?)(FinalList is null));

                    return yzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)wzzzzzzzo_, wzzzzzzzp_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzq_);

                return wzzzzzzzr_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> vzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)vzzzzzzzd_, vzzzzzzze_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> vzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzf_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzg_);

            return vzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)uzzzzzzzt_, uzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(uzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(uzzzzzzzw_);

        return uzzzzzzzx_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? yzzzzzzzb_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] yzzzzzzzc_ = [
            yzzzzzzzb_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzd_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzh_()
            {
                bool yzzzzzzzi_()
                {
                    IEnumerable<ClaimResponse> yzzzzzzzj_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> yzzzzzzzk_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? yzzzzzzzl_ = context.Operators.And((bool?)(yzzzzzzzj_ is null), (bool?)(yzzzzzzzk_ is null));

                    return yzzzzzzzl_ ?? false;
                };
                if (yzzzzzzzi_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> yzzzzzzzm_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> yzzzzzzzn_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzo_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, yzzzzzzzm_, yzzzzzzzn_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return yzzzzzzzo_;
                }
            };

            return yzzzzzzzh_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)yzzzzzzzc_, yzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzf_);

        return yzzzzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        bool? yzzzzzzzp_(Claim AllClaims)
        {
            List<Claim.ItemComponent> yzzzzzzzu_ = AllClaims?.Item;
            bool? yzzzzzzzv_(Claim.ItemComponent @this)
            {
                CodeableConcept zzzzzzzzh_ = @this?.ProductOrService;
                bool? zzzzzzzzi_ = context.Operators.Not((bool?)(zzzzzzzzh_ is null));

                return zzzzzzzzi_;
            };
            IEnumerable<Claim.ItemComponent> yzzzzzzzw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)yzzzzzzzu_, yzzzzzzzv_);
            CodeableConcept yzzzzzzzx_(Claim.ItemComponent @this)
            {
                CodeableConcept zzzzzzzzj_ = @this?.ProductOrService;

                return zzzzzzzzj_;
            };
            IEnumerable<CodeableConcept> yzzzzzzzy_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(yzzzzzzzw_, yzzzzzzzx_);
            bool? yzzzzzzzz_(CodeableConcept @this)
            {
                List<Coding> zzzzzzzzk_ = @this?.Coding;
                bool? zzzzzzzzl_ = context.Operators.Not((bool?)(zzzzzzzzk_ is null));

                return zzzzzzzzl_;
            };
            IEnumerable<CodeableConcept> zzzzzzzza_ = context.Operators.Where<CodeableConcept>(yzzzzzzzy_, yzzzzzzzz_);
            List<Coding> zzzzzzzzb_(CodeableConcept @this)
            {
                List<Coding> zzzzzzzzm_ = @this?.Coding;

                return zzzzzzzzm_;
            };
            IEnumerable<List<Coding>> zzzzzzzzc_ = context.Operators.Select<CodeableConcept, List<Coding>>(zzzzzzzza_, zzzzzzzzb_);
            IEnumerable<Coding> zzzzzzzzd_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)zzzzzzzzc_);
            bool? zzzzzzzze_(Coding ProductOrServiceCode)
            {
                CqlCode zzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? zzzzzzzzo_ = context.Operators.In<CqlCode>(zzzzzzzzn_, ProductOrServiceValueSet);

                return zzzzzzzzo_;
            };
            IEnumerable<Coding> zzzzzzzzf_ = context.Operators.Where<Coding>(zzzzzzzzd_, zzzzzzzze_);
            bool? zzzzzzzzg_ = context.Operators.Exists<Coding>(zzzzzzzzf_);

            return zzzzzzzzg_;
        };
        IEnumerable<Claim> yzzzzzzzq_ = context.Operators.Where<Claim>(claim, yzzzzzzzp_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? yzzzzzzzr_(Claim AllClaims)
        {
            Id zzzzzzzzp_ = AllClaims?.IdElement;
            List<Claim.ItemComponent> zzzzzzzzq_ = AllClaims?.Item;
            bool? zzzzzzzzr_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept zzzzzzzzu_ = ResponseItem?.ProductOrService;
                List<Coding> zzzzzzzzv_ = zzzzzzzzu_?.Coding;
                bool? zzzzzzzzw_(Coding ProductOrServiceCode)
                {
                    CqlCode zzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? azzzzzzzza_ = context.Operators.In<CqlCode>(zzzzzzzzz_, ProductOrServiceValueSet);

                    return azzzzzzzza_;
                };
                IEnumerable<Coding> zzzzzzzzx_ = context.Operators.Where<Coding>((IEnumerable<Coding>)zzzzzzzzv_, zzzzzzzzw_);
                bool? zzzzzzzzy_ = context.Operators.Exists<Coding>(zzzzzzzzx_);

                return zzzzzzzzy_;
            };
            IEnumerable<Claim.ItemComponent> zzzzzzzzs_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)zzzzzzzzq_, zzzzzzzzr_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? zzzzzzzzt_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, zzzzzzzzp_, zzzzzzzzs_);

            return zzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> yzzzzzzzs_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(yzzzzzzzq_, yzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> yzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(yzzzzzzzs_);

        return yzzzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> azzzzzzzzb_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> azzzzzzzzc_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? azzzzzzzzd_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, azzzzzzzzb_, azzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] azzzzzzzze_ = [
            azzzzzzzzd_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzf_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> azzzzzzzzj_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? azzzzzzzzk_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> azzzzzzzzt_ = medClaim?.LineItems;
                bool? azzzzzzzzu_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> azzzzzzzzx_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> azzzzzzzzy_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> bzzzzzzzzb_ = pClaim?.LineItems;
                        bool? bzzzzzzzzc_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id bzzzzzzzzg_()
                            {
                                bool bzzzzzzzzu_()
                                {
                                    Claim bzzzzzzzzv_ = medClaim?.ClaimofInterest;
                                    bool bzzzzzzzzw_ = bzzzzzzzzv_ is Resource;

                                    return bzzzzzzzzw_;
                                };
                                if (bzzzzzzzzu_())
                                {
                                    Claim bzzzzzzzzx_ = medClaim?.ClaimofInterest;

                                    return (bzzzzzzzzx_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string bzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzg_());
                            ClaimResponse bzzzzzzzzi_ = pClaim?.Response;
                            ResourceReference bzzzzzzzzj_ = bzzzzzzzzi_?.Request;
                            FhirString bzzzzzzzzk_ = bzzzzzzzzj_?.ReferenceElement;
                            string bzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, bzzzzzzzzk_);
                            string bzzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, bzzzzzzzzl_);
                            bool? bzzzzzzzzn_ = context.Operators.Equal(bzzzzzzzzh_, bzzzzzzzzm_);
                            PositiveInt bzzzzzzzzo_ = medClaimLineItem?.SequenceElement;
                            Integer bzzzzzzzzp_ = context.Operators.Convert<Integer>(bzzzzzzzzo_);
                            PositiveInt bzzzzzzzzq_ = pClaimLineItem?.ItemSequenceElement;
                            Integer bzzzzzzzzr_ = context.Operators.Convert<Integer>(bzzzzzzzzq_);
                            bool? bzzzzzzzzs_ = context.Operators.Equal(bzzzzzzzzp_, bzzzzzzzzr_);
                            bool? bzzzzzzzzt_ = context.Operators.And(bzzzzzzzzn_, bzzzzzzzzs_);

                            return bzzzzzzzzt_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> bzzzzzzzzd_ = context.Operators.Where<ClaimResponse.ItemComponent>(bzzzzzzzzb_, bzzzzzzzzc_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? bzzzzzzzze_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> bzzzzzzzzf_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(bzzzzzzzzd_, bzzzzzzzze_);

                        return bzzzzzzzzf_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> azzzzzzzzz_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(azzzzzzzzx_, azzzzzzzzy_);
                    bool? bzzzzzzzza_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(azzzzzzzzz_);

                    return bzzzzzzzza_;
                };
                IEnumerable<Claim.ItemComponent> azzzzzzzzv_ = context.Operators.Where<Claim.ItemComponent>(azzzzzzzzt_, azzzzzzzzu_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? azzzzzzzzw_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, azzzzzzzzv_);

                return azzzzzzzzw_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> azzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(azzzzzzzzj_, azzzzzzzzk_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> azzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(azzzzzzzzl_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? azzzzzzzzn_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, azzzzzzzzm_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] azzzzzzzzo_ = [
                azzzzzzzzn_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzp_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzy_()
                {
                    bool czzzzzzzzd_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzze_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? czzzzzzzzf_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> czzzzzzzzl_ = @this?.ClaimItem;
                            bool? czzzzzzzzm_ = context.Operators.Not((bool?)(czzzzzzzzl_ is null));

                            return czzzzzzzzm_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(czzzzzzzze_, czzzzzzzzf_);
                        IEnumerable<Claim.ItemComponent> czzzzzzzzh_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> czzzzzzzzn_ = @this?.ClaimItem;

                            return czzzzzzzzn_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> czzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(czzzzzzzzg_, czzzzzzzzh_);
                        IEnumerable<Claim.ItemComponent> czzzzzzzzj_ = context.Operators.Flatten<Claim.ItemComponent>(czzzzzzzzi_);
                        bool? czzzzzzzzk_ = context.Operators.Exists<Claim.ItemComponent>(czzzzzzzzj_);

                        return czzzzzzzzk_ ?? false;
                    };
                    if (czzzzzzzzd_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzo_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? czzzzzzzzp_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? dzzzzzzzzd_ = @this?.PaidClaim;
                            bool? dzzzzzzzze_ = context.Operators.Not((bool?)(dzzzzzzzzd_ is null));

                            return dzzzzzzzze_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(czzzzzzzzo_, czzzzzzzzp_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? czzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? dzzzzzzzzf_ = @this?.PaidClaim;

                            return dzzzzzzzzf_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> czzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(czzzzzzzzq_, czzzzzzzzr_);
                        bool? czzzzzzzzu_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> dzzzzzzzzg_ = @this?.ClaimItem;
                            bool? dzzzzzzzzh_ = context.Operators.Not((bool?)(dzzzzzzzzg_ is null));

                            return dzzzzzzzzh_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(czzzzzzzzo_, czzzzzzzzu_);
                        IEnumerable<Claim.ItemComponent> czzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> dzzzzzzzzi_ = @this?.ClaimItem;

                            return dzzzzzzzzi_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> czzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(czzzzzzzzv_, czzzzzzzzw_);
                        IEnumerable<Claim.ItemComponent> czzzzzzzzy_ = context.Operators.Flatten<Claim.ItemComponent>(czzzzzzzzx_);
                        CqlInterval<CqlDateTime> czzzzzzzzz_(Claim.ItemComponent PaidItem)
                        {
                            DataType dzzzzzzzzj_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> dzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, dzzzzzzzzj_);

                            return dzzzzzzzzk_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzza_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(czzzzzzzzy_, czzzzzzzzz_);
                        IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzzzzzzza_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzc_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, czzzzzzzzs_, dzzzzzzzzb_);

                        return dzzzzzzzzc_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] bzzzzzzzzz_ = [
                    bzzzzzzzzy_(),
                ];
                bool? czzzzzzzza_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? dzzzzzzzzl_ = context.Operators.Not((bool?)(FinalList is null));

                    return dzzzzzzzzl_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)bzzzzzzzzz_, czzzzzzzza_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzb_);

                return czzzzzzzzc_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)azzzzzzzzo_, azzzzzzzzp_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzq_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzr_);

            return azzzzzzzzs_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)azzzzzzzze_, azzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzh_);

        return azzzzzzzzi_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? dzzzzzzzzm_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] dzzzzzzzzn_ = [
            dzzzzzzzzm_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzo_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzs_()
            {
                bool dzzzzzzzzt_()
                {
                    IEnumerable<ClaimResponse> dzzzzzzzzu_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> dzzzzzzzzv_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? dzzzzzzzzw_ = context.Operators.And((bool?)(dzzzzzzzzu_ is null), (bool?)(dzzzzzzzzv_ is null));

                    return dzzzzzzzzw_ ?? false;
                };
                if (dzzzzzzzzt_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> dzzzzzzzzx_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> dzzzzzzzzy_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzz_ = this.Get_Corresponding_Claim_for_Services_Only(context, dzzzzzzzzx_, dzzzzzzzzy_, ProductOrServiceValueSet);

                    return dzzzzzzzzz_;
                }
            };

            return dzzzzzzzzs_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)dzzzzzzzzn_, dzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzq_);

        return dzzzzzzzzr_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> ezzzzzzzza_ = this.Pharmacy_Claims_Response(context, claimResponse);
        IEnumerable<Claim> ezzzzzzzzb_ = this.Pharmacy_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? ezzzzzzzzc_ = (CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV, ezzzzzzzza_, ezzzzzzzzb_);

        return ezzzzzzzzc_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ezzzzzzzzd_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ezzzzzzzze_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ezzzzzzzzf_ = (CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF, ezzzzzzzzd_, ezzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[] ezzzzzzzzg_ = [
            ezzzzzzzzf_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ezzzzzzzzh_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ezzzzzzzzl_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? ezzzzzzzzm_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> ezzzzzzzzv_ = medClaim?.LineItem;
                bool? ezzzzzzzzw_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ezzzzzzzzz_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> fzzzzzzzza_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> fzzzzzzzzd_ = pClaim?.LineItems;
                        bool? fzzzzzzzze_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id fzzzzzzzzi_()
                            {
                                bool fzzzzzzzzw_()
                                {
                                    Claim fzzzzzzzzx_ = medClaim?.Claim;
                                    bool fzzzzzzzzy_ = fzzzzzzzzx_ is Resource;

                                    return fzzzzzzzzy_;
                                };
                                if (fzzzzzzzzw_())
                                {
                                    Claim fzzzzzzzzz_ = medClaim?.Claim;

                                    return (fzzzzzzzzz_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string fzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzi_());
                            ClaimResponse fzzzzzzzzk_ = pClaim?.Response;
                            ResourceReference fzzzzzzzzl_ = fzzzzzzzzk_?.Request;
                            FhirString fzzzzzzzzm_ = fzzzzzzzzl_?.ReferenceElement;
                            string fzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, fzzzzzzzzm_);
                            string fzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, fzzzzzzzzn_);
                            bool? fzzzzzzzzp_ = context.Operators.Equal(fzzzzzzzzj_, fzzzzzzzzo_);
                            PositiveInt fzzzzzzzzq_ = medClaimLineItem?.SequenceElement;
                            Integer fzzzzzzzzr_ = context.Operators.Convert<Integer>(fzzzzzzzzq_);
                            PositiveInt fzzzzzzzzs_ = pClaimLineItem?.ItemSequenceElement;
                            Integer fzzzzzzzzt_ = context.Operators.Convert<Integer>(fzzzzzzzzs_);
                            bool? fzzzzzzzzu_ = context.Operators.Equal(fzzzzzzzzr_, fzzzzzzzzt_);
                            bool? fzzzzzzzzv_ = context.Operators.And(fzzzzzzzzp_, fzzzzzzzzu_);

                            return fzzzzzzzzv_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> fzzzzzzzzf_ = context.Operators.Where<ClaimResponse.ItemComponent>(fzzzzzzzzd_, fzzzzzzzze_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? fzzzzzzzzg_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> fzzzzzzzzh_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(fzzzzzzzzf_, fzzzzzzzzg_);

                        return fzzzzzzzzh_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> fzzzzzzzzb_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ezzzzzzzzz_, fzzzzzzzza_);
                    bool? fzzzzzzzzc_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(fzzzzzzzzb_);

                    return fzzzzzzzzc_;
                };
                IEnumerable<Claim.ItemComponent> ezzzzzzzzx_ = context.Operators.Where<Claim.ItemComponent>(ezzzzzzzzv_, ezzzzzzzzw_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? ezzzzzzzzy_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, ezzzzzzzzx_);

                return ezzzzzzzzy_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ezzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ezzzzzzzzl_, ezzzzzzzzm_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ezzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ezzzzzzzzn_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ezzzzzzzzp_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, ezzzzzzzzo_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] ezzzzzzzzq_ = [
                ezzzzzzzzp_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ezzzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? gzzzzzzzza_()
                {
                    bool gzzzzzzzzf_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> gzzzzzzzzg_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? gzzzzzzzzh_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> gzzzzzzzzn_ = @this?.ClaimItem;
                            bool? gzzzzzzzzo_ = context.Operators.Not((bool?)(gzzzzzzzzn_ is null));

                            return gzzzzzzzzo_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> gzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(gzzzzzzzzg_, gzzzzzzzzh_);
                        IEnumerable<Claim.ItemComponent> gzzzzzzzzj_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> gzzzzzzzzp_ = @this?.ClaimItem;

                            return gzzzzzzzzp_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> gzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(gzzzzzzzzi_, gzzzzzzzzj_);
                        IEnumerable<Claim.ItemComponent> gzzzzzzzzl_ = context.Operators.Flatten<Claim.ItemComponent>(gzzzzzzzzk_);
                        bool? gzzzzzzzzm_ = context.Operators.Exists<Claim.ItemComponent>(gzzzzzzzzl_);

                        return gzzzzzzzzm_ ?? false;
                    };
                    if (gzzzzzzzzf_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> gzzzzzzzzq_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? gzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? hzzzzzzzzo_ = @this?.PaidClaim;
                            bool? hzzzzzzzzp_ = context.Operators.Not((bool?)(hzzzzzzzzo_ is null));

                            return hzzzzzzzzp_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> gzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(gzzzzzzzzq_, gzzzzzzzzr_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? gzzzzzzzzt_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? hzzzzzzzzq_ = @this?.PaidClaim;

                            return hzzzzzzzzq_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> gzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(gzzzzzzzzs_, gzzzzzzzzt_);
                        bool? gzzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzr_ = @this?.ClaimItem;
                            bool? hzzzzzzzzs_ = context.Operators.Not((bool?)(hzzzzzzzzr_ is null));

                            return hzzzzzzzzs_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> gzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(gzzzzzzzzq_, gzzzzzzzzw_);
                        IEnumerable<Claim.ItemComponent> gzzzzzzzzy_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzt_ = @this?.ClaimItem;

                            return hzzzzzzzzt_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> gzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(gzzzzzzzzx_, gzzzzzzzzy_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzza_ = context.Operators.Flatten<Claim.ItemComponent>(gzzzzzzzzz_);
                        CqlInterval<CqlDateTime> hzzzzzzzzb_(Claim.ItemComponent PaidItem)
                        {
                            DataType hzzzzzzzzu_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> hzzzzzzzzv_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, hzzzzzzzzu_);

                            return hzzzzzzzzv_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzc_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(hzzzzzzzza_, hzzzzzzzzb_);
                        IEnumerable<CqlInterval<CqlDateTime>> hzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(hzzzzzzzzc_);
                        bool? hzzzzzzzzf_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzw_ = @this?.ClaimItem;
                            bool? hzzzzzzzzx_ = context.Operators.Not((bool?)(hzzzzzzzzw_ is null));

                            return hzzzzzzzzx_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> hzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(gzzzzzzzzq_, hzzzzzzzzf_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzh_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> hzzzzzzzzy_ = @this?.ClaimItem;

                            return hzzzzzzzzy_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> hzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(hzzzzzzzzg_, hzzzzzzzzh_);
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzj_ = context.Operators.Flatten<Claim.ItemComponent>(hzzzzzzzzi_);
                        CqlInterval<CqlDate> hzzzzzzzzk_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDate> hzzzzzzzzz_()
                            {
                                bool izzzzzzzza_()
                                {
                                    Quantity izzzzzzzzb_ = i?.Quantity;
                                    bool? izzzzzzzzc_ = context.Operators.Not((bool?)(izzzzzzzzb_ is null));

                                    return izzzzzzzzc_ ?? false;
                                };
                                if (izzzzzzzza_())
                                {
                                    DataType izzzzzzzzd_ = i?.Serviced;
                                    CqlInterval<CqlDateTime> izzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzd_);
                                    CqlDateTime izzzzzzzzf_ = context.Operators.Start(izzzzzzzze_);
                                    CqlDate izzzzzzzzg_ = context.Operators.ConvertDateTimeToDate(izzzzzzzzf_);
                                    CqlInterval<CqlDateTime> izzzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzd_);
                                    CqlDateTime izzzzzzzzj_ = context.Operators.Start(izzzzzzzzi_);
                                    Quantity izzzzzzzzk_ = i?.Quantity;
                                    FhirDecimal izzzzzzzzl_ = izzzzzzzzk_?.ValueElement;
                                    decimal? izzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, izzzzzzzzl_);
                                    CqlDateTime izzzzzzzzn_ = context.Operators.Add(izzzzzzzzj_, new CqlQuantity(izzzzzzzzm_, "day"));
                                    CqlQuantity izzzzzzzzo_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime izzzzzzzzp_ = context.Operators.Subtract(izzzzzzzzn_, izzzzzzzzo_);
                                    CqlDate izzzzzzzzq_ = context.Operators.ConvertDateTimeToDate(izzzzzzzzp_);
                                    CqlInterval<CqlDate> izzzzzzzzr_ = context.Operators.Interval(izzzzzzzzg_, izzzzzzzzq_, true, true);

                                    return izzzzzzzzr_;
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDate>;
                                }
                            };

                            return hzzzzzzzzz_();
                        };
                        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzl_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(hzzzzzzzzj_, hzzzzzzzzk_);
                        IEnumerable<CqlInterval<CqlDate>> hzzzzzzzzm_ = context.Operators.Distinct<CqlInterval<CqlDate>>(hzzzzzzzzl_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? hzzzzzzzzn_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, gzzzzzzzzu_, hzzzzzzzzd_, hzzzzzzzzm_);

                        return hzzzzzzzzn_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] gzzzzzzzzb_ = [
                    gzzzzzzzza_(),
                ];
                bool? gzzzzzzzzc_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList)
                {
                    bool? izzzzzzzzs_ = context.Operators.Not((bool?)(FinalList is null));

                    return izzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> gzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)gzzzzzzzzb_, gzzzzzzzzc_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? gzzzzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(gzzzzzzzzd_);

                return gzzzzzzzze_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ezzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)ezzzzzzzzq_, ezzzzzzzzr_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ezzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ezzzzzzzzs_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ezzzzzzzzu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ezzzzzzzzt_);

            return ezzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ezzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)ezzzzzzzzg_, ezzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> ezzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ezzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? ezzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(ezzzzzzzzj_);

        return ezzzzzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? izzzzzzzzt_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] izzzzzzzzu_ = [
            izzzzzzzzt_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? izzzzzzzzv_((CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? izzzzzzzzz_()
            {
                bool jzzzzzzzza_()
                {
                    IEnumerable<ClaimResponse> jzzzzzzzzb_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> jzzzzzzzzc_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    bool? jzzzzzzzzd_ = context.Operators.And((bool?)(jzzzzzzzzb_ is null), (bool?)(jzzzzzzzzc_ is null));

                    return jzzzzzzzzd_ ?? false;
                };
                if (jzzzzzzzza_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> jzzzzzzzze_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> jzzzzzzzzf_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? jzzzzzzzzg_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, jzzzzzzzze_, jzzzzzzzzf_, ProductOrServiceValueSet);

                    return jzzzzzzzzg_;
                }
            };

            return izzzzzzzzz_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> izzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)izzzzzzzzu_, izzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> izzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(izzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? izzzzzzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(izzzzzzzzx_);

        return izzzzzzzzy_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? jzzzzzzzzh_(Claim Claim)
        {
            bool? jzzzzzzzzk_(ClaimResponse CR)
            {
                Id jzzzzzzzzp_ = Claim?.IdElement;
                string jzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzp_);
                ResourceReference jzzzzzzzzr_ = CR?.Request;
                FhirString jzzzzzzzzs_ = jzzzzzzzzr_?.ReferenceElement;
                string jzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzs_);
                string jzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, jzzzzzzzzt_);
                bool? jzzzzzzzzv_ = context.Operators.Equal(jzzzzzzzzq_, jzzzzzzzzu_);

                return jzzzzzzzzv_;
            };
            IEnumerable<ClaimResponse> jzzzzzzzzl_ = context.Operators.Where<ClaimResponse>(claimResponse, jzzzzzzzzk_);
            bool? jzzzzzzzzm_(Claim C)
            {
                Id jzzzzzzzzw_ = Claim?.IdElement;
                string jzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, jzzzzzzzzw_);
                bool? jzzzzzzzzy_(ClaimResponse CR)
                {
                    Id kzzzzzzzzm_ = Claim?.IdElement;
                    string kzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzm_);
                    ResourceReference kzzzzzzzzo_ = CR?.Request;
                    FhirString kzzzzzzzzp_ = kzzzzzzzzo_?.ReferenceElement;
                    string kzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzp_);
                    string kzzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, kzzzzzzzzq_);
                    bool? kzzzzzzzzs_ = context.Operators.Equal(kzzzzzzzzn_, kzzzzzzzzr_);

                    return kzzzzzzzzs_;
                };
                IEnumerable<ClaimResponse> jzzzzzzzzz_ = context.Operators.Where<ClaimResponse>(claimResponse, jzzzzzzzzy_);
                bool? kzzzzzzzza_(ClaimResponse @this)
                {
                    ResourceReference kzzzzzzzzt_ = @this?.Request;
                    bool? kzzzzzzzzu_ = context.Operators.Not((bool?)(kzzzzzzzzt_ is null));

                    return kzzzzzzzzu_;
                };
                IEnumerable<ClaimResponse> kzzzzzzzzb_ = context.Operators.Where<ClaimResponse>(jzzzzzzzzz_, kzzzzzzzza_);
                ResourceReference kzzzzzzzzc_(ClaimResponse @this)
                {
                    ResourceReference kzzzzzzzzv_ = @this?.Request;

                    return kzzzzzzzzv_;
                };
                IEnumerable<ResourceReference> kzzzzzzzzd_ = context.Operators.Select<ClaimResponse, ResourceReference>(kzzzzzzzzb_, kzzzzzzzzc_);
                bool? kzzzzzzzze_(ResourceReference @this)
                {
                    FhirString kzzzzzzzzw_ = @this?.ReferenceElement;
                    bool? kzzzzzzzzx_ = context.Operators.Not((bool?)(kzzzzzzzzw_ is null));

                    return kzzzzzzzzx_;
                };
                IEnumerable<ResourceReference> kzzzzzzzzf_ = context.Operators.Where<ResourceReference>(kzzzzzzzzd_, kzzzzzzzze_);
                FhirString kzzzzzzzzg_(ResourceReference @this)
                {
                    FhirString kzzzzzzzzy_ = @this?.ReferenceElement;

                    return kzzzzzzzzy_;
                };
                IEnumerable<FhirString> kzzzzzzzzh_ = context.Operators.Select<ResourceReference, FhirString>(kzzzzzzzzf_, kzzzzzzzzg_);
                FhirString kzzzzzzzzi_ = context.Operators.SingletonFrom<FhirString>(kzzzzzzzzh_);
                string kzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzi_);
                string kzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, kzzzzzzzzj_);
                bool? kzzzzzzzzl_ = context.Operators.Equal(jzzzzzzzzx_, kzzzzzzzzk_);

                return kzzzzzzzzl_;
            };
            IEnumerable<Claim> jzzzzzzzzn_ = context.Operators.Where<Claim>(claim, jzzzzzzzzm_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? jzzzzzzzzo_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, jzzzzzzzzl_, jzzzzzzzzn_);

            return jzzzzzzzzo_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> jzzzzzzzzi_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, jzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> jzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(jzzzzzzzzi_);

        return jzzzzzzzzj_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim> claim)
    {
        IEnumerable<Claim> kzzzzzzzzz_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? lzzzzzzzza_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, kzzzzzzzzz_, default, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] lzzzzzzzzb_ = [
            lzzzzzzzza_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? lzzzzzzzzc_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithInpatientStay)
        {
            IEnumerable<Claim> lzzzzzzzzg_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> lzzzzzzzzo_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? lzzzzzzzzp_(Claim c)
                    {
                        List<Claim.ItemComponent> lzzzzzzzzr_ = c?.Item;
                        bool? lzzzzzzzzs_(Claim.ItemComponent i)
                        {
                            CodeableConcept lzzzzzzzzv_ = i?.Revenue;
                            CqlConcept lzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, lzzzzzzzzv_);
                            CqlCode[] lzzzzzzzzx_ = lzzzzzzzzw_?.codes;
                            bool? lzzzzzzzzy_(CqlCode rev)
                            {
                                string mzzzzzzzzb_ = rev?.code;
                                CqlValueSet mzzzzzzzzc_ = this.Inpatient_Stay(context);
                                bool? mzzzzzzzzd_ = context.Operators.StringInValueSet(mzzzzzzzzb_, mzzzzzzzzc_);

                                return mzzzzzzzzd_;
                            };
                            IEnumerable<CqlCode> lzzzzzzzzz_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)lzzzzzzzzx_, lzzzzzzzzy_);
                            bool? mzzzzzzzza_ = context.Operators.Exists<CqlCode>(lzzzzzzzzz_);

                            return mzzzzzzzza_;
                        };
                        IEnumerable<Claim.ItemComponent> lzzzzzzzzt_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)lzzzzzzzzr_, lzzzzzzzzs_);
                        bool? lzzzzzzzzu_ = context.Operators.Exists<Claim.ItemComponent>(lzzzzzzzzt_);

                        return lzzzzzzzzu_;
                    };
                    IEnumerable<Claim> lzzzzzzzzq_ = context.Operators.Where<Claim>(lzzzzzzzzo_, lzzzzzzzzp_);

                    return lzzzzzzzzq_;
                }
            };
            IEnumerable<Claim> lzzzzzzzzh_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> mzzzzzzzze_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? mzzzzzzzzf_(Claim c)
                    {
                        List<Claim.ItemComponent> mzzzzzzzzh_ = c?.Item;
                        bool? mzzzzzzzzi_(Claim.ItemComponent i)
                        {
                            CodeableConcept mzzzzzzzzr_ = i?.Revenue;
                            CqlConcept mzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzr_);
                            CqlCode[] mzzzzzzzzt_ = mzzzzzzzzs_?.codes;
                            bool? mzzzzzzzzu_(CqlCode rev)
                            {
                                string mzzzzzzzzx_ = rev?.code;
                                CqlValueSet mzzzzzzzzy_ = this.Nonacute_Inpatient_Stay(context);
                                bool? mzzzzzzzzz_ = context.Operators.StringInValueSet(mzzzzzzzzx_, mzzzzzzzzy_);

                                return mzzzzzzzzz_;
                            };
                            IEnumerable<CqlCode> mzzzzzzzzv_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)mzzzzzzzzt_, mzzzzzzzzu_);
                            bool? mzzzzzzzzw_ = context.Operators.Exists<CqlCode>(mzzzzzzzzv_);

                            return mzzzzzzzzw_;
                        };
                        IEnumerable<Claim.ItemComponent> mzzzzzzzzj_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)mzzzzzzzzh_, mzzzzzzzzi_);
                        bool? mzzzzzzzzk_ = context.Operators.Exists<Claim.ItemComponent>(mzzzzzzzzj_);
                        CodeableConcept mzzzzzzzzl_ = c?.SubType;
                        List<Coding> mzzzzzzzzm_ = mzzzzzzzzl_?.Coding;
                        bool? mzzzzzzzzn_(Coding tob)
                        {
                            Code nzzzzzzzza_ = tob?.CodeElement;
                            string nzzzzzzzzb_ = nzzzzzzzza_?.Value;
                            CqlValueSet nzzzzzzzzc_ = this.Nonacute_Inpatient_Stay(context);
                            bool? nzzzzzzzzd_ = context.Operators.StringInValueSet(nzzzzzzzzb_, nzzzzzzzzc_);

                            return nzzzzzzzzd_;
                        };
                        IEnumerable<Coding> mzzzzzzzzo_ = context.Operators.Where<Coding>((IEnumerable<Coding>)mzzzzzzzzm_, mzzzzzzzzn_);
                        bool? mzzzzzzzzp_ = context.Operators.Exists<Coding>(mzzzzzzzzo_);
                        bool? mzzzzzzzzq_ = context.Operators.Or(mzzzzzzzzk_, mzzzzzzzzp_);

                        return mzzzzzzzzq_;
                    };
                    IEnumerable<Claim> mzzzzzzzzg_ = context.Operators.Where<Claim>(mzzzzzzzze_, mzzzzzzzzf_);

                    return mzzzzzzzzg_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? lzzzzzzzzi_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, lzzzzzzzzg_(), lzzzzzzzzh_());
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] lzzzzzzzzj_ = [
                lzzzzzzzzi_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? lzzzzzzzzk_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> nzzzzzzzze_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> nzzzzzzzzf_ = LineItemDefinition?.NonacuteInpatientLineItems;
                IEnumerable<Claim> nzzzzzzzzg_(Claim nonAcuteInpatientStay)
                {
                    IEnumerable<Claim> nzzzzzzzzo_ = LineItemDefinition?.InpatientStayLineItems;
                    bool? nzzzzzzzzp_(Claim inpatientStay)
                    {
                        Id nzzzzzzzzt_ = nonAcuteInpatientStay?.IdElement;
                        Id nzzzzzzzzu_ = inpatientStay?.IdElement;
                        bool? nzzzzzzzzv_ = context.Operators.Equal(nzzzzzzzzt_, nzzzzzzzzu_);

                        return nzzzzzzzzv_;
                    };
                    IEnumerable<Claim> nzzzzzzzzq_ = context.Operators.Where<Claim>(nzzzzzzzzo_, nzzzzzzzzp_);
                    Claim nzzzzzzzzr_(Claim inpatientStay) =>
                        nonAcuteInpatientStay;
                    IEnumerable<Claim> nzzzzzzzzs_ = context.Operators.Select<Claim, Claim>(nzzzzzzzzq_, nzzzzzzzzr_);

                    return nzzzzzzzzs_;
                };
                IEnumerable<Claim> nzzzzzzzzh_ = context.Operators.SelectMany<Claim, Claim>(nzzzzzzzzf_, nzzzzzzzzg_);
                IEnumerable<Claim> nzzzzzzzzk_(Claim inpatientStay)
                {
                    IEnumerable<Claim> nzzzzzzzzw_ = LineItemDefinition?.NonacuteInpatientLineItems;
                    bool? nzzzzzzzzx_(Claim nonAcuteInpatientStay)
                    {
                        Id ozzzzzzzzb_ = inpatientStay?.IdElement;
                        Id ozzzzzzzzc_ = nonAcuteInpatientStay?.IdElement;
                        bool? ozzzzzzzzd_ = context.Operators.Equal(ozzzzzzzzb_, ozzzzzzzzc_);

                        return ozzzzzzzzd_;
                    };
                    IEnumerable<Claim> nzzzzzzzzy_ = context.Operators.Where<Claim>(nzzzzzzzzw_, nzzzzzzzzx_);
                    Claim nzzzzzzzzz_(Claim nonAcuteInpatientStay) =>
                        inpatientStay;
                    IEnumerable<Claim> ozzzzzzzza_ = context.Operators.Select<Claim, Claim>(nzzzzzzzzy_, nzzzzzzzzz_);

                    return ozzzzzzzza_;
                };
                IEnumerable<Claim> nzzzzzzzzl_ = context.Operators.SelectMany<Claim, Claim>(nzzzzzzzze_, nzzzzzzzzk_);
                IEnumerable<Claim> nzzzzzzzzm_ = context.Operators.Except<Claim>(nzzzzzzzze_, nzzzzzzzzl_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? nzzzzzzzzn_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, nzzzzzzzze_, nzzzzzzzzh_, nzzzzzzzzm_);

                return nzzzzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> lzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)lzzzzzzzzj_, lzzzzzzzzk_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> lzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(lzzzzzzzzl_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? lzzzzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(lzzzzzzzzm_);

            return lzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> lzzzzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)lzzzzzzzzb_, lzzzzzzzzc_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> lzzzzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(lzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? lzzzzzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(lzzzzzzzze_);

        return lzzzzzzzzf_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? ozzzzzzzze_(Claim C)
        {
            List<Claim.CareTeamComponent> ozzzzzzzzn_ = C?.CareTeam;
            bool? ozzzzzzzzo_(Claim.CareTeamComponent ct)
            {
                PositiveInt pzzzzzzzze_ = ct?.SequenceElement;
                Integer pzzzzzzzzf_ = context.Operators.Convert<Integer>(pzzzzzzzze_);
                int? pzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, pzzzzzzzzf_);
                bool? pzzzzzzzzh_ = context.Operators.Equal(pzzzzzzzzg_, 1);

                return pzzzzzzzzh_;
            };
            IEnumerable<Claim.CareTeamComponent> ozzzzzzzzp_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)ozzzzzzzzn_, ozzzzzzzzo_);
            bool? ozzzzzzzzq_(Claim.CareTeamComponent @this)
            {
                ResourceReference pzzzzzzzzi_ = @this?.Provider;
                bool? pzzzzzzzzj_ = context.Operators.Not((bool?)(pzzzzzzzzi_ is null));

                return pzzzzzzzzj_;
            };
            IEnumerable<Claim.CareTeamComponent> ozzzzzzzzr_ = context.Operators.Where<Claim.CareTeamComponent>(ozzzzzzzzp_, ozzzzzzzzq_);
            ResourceReference ozzzzzzzzs_(Claim.CareTeamComponent @this)
            {
                ResourceReference pzzzzzzzzk_ = @this?.Provider;

                return pzzzzzzzzk_;
            };
            IEnumerable<ResourceReference> ozzzzzzzzt_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(ozzzzzzzzr_, ozzzzzzzzs_);
            bool? ozzzzzzzzv_(Claim.CareTeamComponent ct)
            {
                PositiveInt pzzzzzzzzl_ = ct?.SequenceElement;
                Integer pzzzzzzzzm_ = context.Operators.Convert<Integer>(pzzzzzzzzl_);
                int? pzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, pzzzzzzzzm_);
                bool? pzzzzzzzzo_ = context.Operators.Equal(pzzzzzzzzn_, 1);

                return pzzzzzzzzo_;
            };
            IEnumerable<Claim.CareTeamComponent> ozzzzzzzzw_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)ozzzzzzzzn_, ozzzzzzzzv_);
            bool? ozzzzzzzzx_(Claim.CareTeamComponent @this)
            {
                ResourceReference pzzzzzzzzp_ = @this?.Provider;
                bool? pzzzzzzzzq_ = context.Operators.Not((bool?)(pzzzzzzzzp_ is null));

                return pzzzzzzzzq_;
            };
            IEnumerable<Claim.CareTeamComponent> ozzzzzzzzy_ = context.Operators.Where<Claim.CareTeamComponent>(ozzzzzzzzw_, ozzzzzzzzx_);
            ResourceReference ozzzzzzzzz_(Claim.CareTeamComponent @this)
            {
                ResourceReference pzzzzzzzzr_ = @this?.Provider;

                return pzzzzzzzzr_;
            };
            IEnumerable<ResourceReference> pzzzzzzzza_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(ozzzzzzzzy_, ozzzzzzzzz_);
            string pzzzzzzzzb_(ResourceReference p)
            {
                FhirString pzzzzzzzzs_ = p?.ReferenceElement;
                FhirString[] pzzzzzzzzt_ = [
                    pzzzzzzzzs_,
                ];
                string pzzzzzzzzu_(FhirString r)
                {
                    string pzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string pzzzzzzzzy_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, pzzzzzzzzx_);

                    return pzzzzzzzzy_;
                };
                IEnumerable<string> pzzzzzzzzv_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)pzzzzzzzzt_, pzzzzzzzzu_);
                string pzzzzzzzzw_ = context.Operators.SingletonFrom<string>(pzzzzzzzzv_);

                return pzzzzzzzzw_;
            };
            IEnumerable<string> pzzzzzzzzc_ = context.Operators.Select<ResourceReference, string>(pzzzzzzzza_, pzzzzzzzzb_);
            (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? pzzzzzzzzd_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, ozzzzzzzzt_, pzzzzzzzzc_);

            return pzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ozzzzzzzzf_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, ozzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ozzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(ozzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ozzzzzzzzh_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, ozzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?[] ozzzzzzzzi_ = [
            ozzzzzzzzh_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? ozzzzzzzzj_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ClaimProperties)
        {
            IEnumerable<Practitioner> pzzzzzzzzz_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));
            bool? qzzzzzzzza_(Practitioner p)
            {
                Id qzzzzzzzzi_ = p?.IdElement;
                string qzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, qzzzzzzzzi_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> qzzzzzzzzk_ = ClaimProperties?.CareTeams;
                bool? qzzzzzzzzl_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> qzzzzzzzzr_ = @this?.CareTeamsProviderID;
                    bool? qzzzzzzzzs_ = context.Operators.Not((bool?)(qzzzzzzzzr_ is null));

                    return qzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> qzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(qzzzzzzzzk_, qzzzzzzzzl_);
                IEnumerable<string> qzzzzzzzzn_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> qzzzzzzzzt_ = @this?.CareTeamsProviderID;

                    return qzzzzzzzzt_;
                };
                IEnumerable<IEnumerable<string>> qzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(qzzzzzzzzm_, qzzzzzzzzn_);
                IEnumerable<string> qzzzzzzzzp_ = context.Operators.Flatten<string>(qzzzzzzzzo_);
                bool? qzzzzzzzzq_ = context.Operators.In<string>(qzzzzzzzzj_, qzzzzzzzzp_);

                return qzzzzzzzzq_;
            };
            IEnumerable<Practitioner> qzzzzzzzzb_ = context.Operators.Where<Practitioner>(pzzzzzzzzz_, qzzzzzzzza_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? qzzzzzzzzc_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, qzzzzzzzzb_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?[] qzzzzzzzzd_ = [
                qzzzzzzzzc_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? qzzzzzzzze_((CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? PractitionerMatch)
            {
                IEnumerable<Practitioner> qzzzzzzzzu_ = PractitionerMatch?.Practitioners;
                bool? qzzzzzzzzv_(Practitioner P)
                {
                    bool? rzzzzzzzzf_ = context.Operators.Not((bool?)(P is null));

                    return rzzzzzzzzf_;
                };
                IEnumerable<Practitioner> qzzzzzzzzw_ = context.Operators.Where<Practitioner>(qzzzzzzzzu_, qzzzzzzzzv_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? qzzzzzzzzx_(Practitioner P)
                {
                    List<Identifier> rzzzzzzzzg_ = P?.Identifier;
                    bool? rzzzzzzzzh_(Identifier l)
                    {
                        FhirUri rzzzzzzzzs_ = l?.SystemElement;
                        string rzzzzzzzzt_ = rzzzzzzzzs_?.Value;
                        bool? rzzzzzzzzu_ = context.Operators.Equal(rzzzzzzzzt_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept rzzzzzzzzv_ = l?.Type;
                        CqlConcept rzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, rzzzzzzzzv_);
                        CqlCode rzzzzzzzzx_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept rzzzzzzzzy_ = context.Operators.ConvertCodeToConcept(rzzzzzzzzx_);
                        bool? rzzzzzzzzz_ = context.Operators.Equivalent(rzzzzzzzzw_, rzzzzzzzzy_);
                        bool? szzzzzzzza_ = context.Operators.And(rzzzzzzzzu_, rzzzzzzzzz_);
                        FhirString szzzzzzzzb_ = l?.ValueElement;
                        string szzzzzzzzc_ = szzzzzzzzb_?.Value;
                        bool? szzzzzzzzd_ = context.Operators.Not((bool?)(szzzzzzzzc_ is null));
                        bool? szzzzzzzze_ = context.Operators.And(szzzzzzzza_, szzzzzzzzd_);

                        return szzzzzzzze_;
                    };
                    IEnumerable<Identifier> rzzzzzzzzi_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)rzzzzzzzzg_, rzzzzzzzzh_);
                    FhirString rzzzzzzzzj_(Identifier l)
                    {
                        FhirString szzzzzzzzf_ = l?.ValueElement;

                        return szzzzzzzzf_;
                    };
                    IEnumerable<FhirString> rzzzzzzzzk_ = context.Operators.Select<Identifier, FhirString>(rzzzzzzzzi_, rzzzzzzzzj_);
                    IEnumerable<FhirString> rzzzzzzzzl_ = context.Operators.Distinct<FhirString>(rzzzzzzzzk_);
                    bool? rzzzzzzzzn_(Identifier l)
                    {
                        FhirUri szzzzzzzzg_ = l?.SystemElement;
                        string szzzzzzzzh_ = szzzzzzzzg_?.Value;
                        bool? szzzzzzzzi_ = context.Operators.Equal(szzzzzzzzh_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept szzzzzzzzj_ = l?.Type;
                        CqlConcept szzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, szzzzzzzzj_);
                        CqlCode szzzzzzzzl_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept szzzzzzzzm_ = context.Operators.ConvertCodeToConcept(szzzzzzzzl_);
                        bool? szzzzzzzzn_ = context.Operators.Equivalent(szzzzzzzzk_, szzzzzzzzm_);
                        bool? szzzzzzzzo_ = context.Operators.And(szzzzzzzzi_, szzzzzzzzn_);
                        FhirString szzzzzzzzp_ = l?.ValueElement;
                        string szzzzzzzzq_ = szzzzzzzzp_?.Value;
                        bool? szzzzzzzzr_ = context.Operators.And(szzzzzzzzo_, (bool?)(szzzzzzzzq_ is null));

                        return szzzzzzzzr_;
                    };
                    IEnumerable<Identifier> rzzzzzzzzo_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)rzzzzzzzzg_, rzzzzzzzzn_);
                    Identifier rzzzzzzzzp_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> rzzzzzzzzq_ = context.Operators.Select<Identifier, Identifier>(rzzzzzzzzo_, rzzzzzzzzp_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? rzzzzzzzzr_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, rzzzzzzzzl_, rzzzzzzzzq_);

                    return rzzzzzzzzr_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> qzzzzzzzzy_ = context.Operators.Select<Practitioner, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(qzzzzzzzzw_, qzzzzzzzzx_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? qzzzzzzzzz_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, qzzzzzzzzy_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] rzzzzzzzza_ = [
                    qzzzzzzzzz_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? rzzzzzzzzb_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? szzzzzzzzs_()
                    {
                        bool szzzzzzzzu_()
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> szzzzzzzzv_ = ClaimProperties?.CareTeams;
                            bool? szzzzzzzzw_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim tzzzzzzzzb_ = @this?.SingleCareTeam;
                                bool? tzzzzzzzzc_ = context.Operators.Not((bool?)(tzzzzzzzzb_ is null));

                                return tzzzzzzzzc_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> szzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(szzzzzzzzv_, szzzzzzzzw_);
                            Claim szzzzzzzzy_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim tzzzzzzzzd_ = @this?.SingleCareTeam;

                                return tzzzzzzzzd_;
                            };
                            IEnumerable<Claim> szzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(szzzzzzzzx_, szzzzzzzzy_);
                            bool? tzzzzzzzza_ = context.Operators.Exists<Claim>(szzzzzzzzz_);

                            return tzzzzzzzza_ ?? false;
                        };
                        if (szzzzzzzzu_())
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> tzzzzzzzze_ = ClaimProperties?.CareTeams;
                            bool? tzzzzzzzzf_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim uzzzzzzzzb_ = @this?.SingleCareTeam;
                                bool? uzzzzzzzzc_ = context.Operators.Not((bool?)(uzzzzzzzzb_ is null));

                                return uzzzzzzzzc_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> tzzzzzzzzg_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(tzzzzzzzze_, tzzzzzzzzf_);
                            Claim tzzzzzzzzh_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim uzzzzzzzzd_ = @this?.SingleCareTeam;

                                return uzzzzzzzzd_;
                            };
                            IEnumerable<Claim> tzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(tzzzzzzzzg_, tzzzzzzzzh_);
                            bool? tzzzzzzzzj_(Claim X)
                            {
                                List<Claim.CareTeamComponent> uzzzzzzzze_ = X?.CareTeam;

                                return (bool?)(((IEnumerable<Claim.CareTeamComponent>)uzzzzzzzze_) is null);
                            };
                            IEnumerable<Claim> tzzzzzzzzk_ = context.Operators.Where<Claim>(tzzzzzzzzi_, tzzzzzzzzj_);
                            int? tzzzzzzzzl_ = context.Operators.Count<Claim>(tzzzzzzzzk_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> tzzzzzzzzm_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> tzzzzzzzzn_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> uzzzzzzzzf_ = X?.AllIdentifiers;

                                return uzzzzzzzzf_;
                            };
                            IEnumerable<IEnumerable<FhirString>> tzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(tzzzzzzzzm_, tzzzzzzzzn_);
                            IEnumerable<FhirString> tzzzzzzzzp_ = context.Operators.Flatten<FhirString>(tzzzzzzzzo_);
                            FhirString tzzzzzzzzq_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> tzzzzzzzzr_ = context.Operators.Select<FhirString, FhirString>(tzzzzzzzzp_, tzzzzzzzzq_);
                            IEnumerable<FhirString> tzzzzzzzzs_ = context.Operators.Distinct<FhirString>(tzzzzzzzzr_);
                            int? tzzzzzzzzt_ = context.Operators.Count<FhirString>(tzzzzzzzzs_);
                            int? tzzzzzzzzu_ = context.Operators.Add(tzzzzzzzzl_, tzzzzzzzzt_);
                            IEnumerable<Identifier> tzzzzzzzzw_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> uzzzzzzzzg_ = X?.NullIdentifiers;

                                return uzzzzzzzzg_;
                            };
                            IEnumerable<IEnumerable<Identifier>> tzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(tzzzzzzzzm_, tzzzzzzzzw_);
                            IEnumerable<Identifier> tzzzzzzzzy_ = context.Operators.Flatten<Identifier>(tzzzzzzzzx_);
                            int? tzzzzzzzzz_ = context.Operators.Count<Identifier>(tzzzzzzzzy_);
                            int? uzzzzzzzza_ = context.Operators.Add(tzzzzzzzzu_, tzzzzzzzzz_);

                            return uzzzzzzzza_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? szzzzzzzzt_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, szzzzzzzzs_());

                    return szzzzzzzzt_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> rzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)rzzzzzzzza_, rzzzzzzzzb_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> rzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(rzzzzzzzzc_);
                (CqlTupleMetadata, int? IdentifierCount)? rzzzzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(rzzzzzzzzd_);

                return rzzzzzzzze_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> qzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?>)qzzzzzzzzd_, qzzzzzzzze_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> qzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(qzzzzzzzzf_);
            (CqlTupleMetadata, int? IdentifierCount)? qzzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(qzzzzzzzzg_);

            return qzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> ozzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?>)ozzzzzzzzi_, ozzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> ozzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(ozzzzzzzzk_);
        (CqlTupleMetadata, int? IdentifierCount)? ozzzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(ozzzzzzzzl_);

        return ozzzzzzzzm_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? uzzzzzzzzh_(Claim C)
        {
            List<Claim.ItemComponent> uzzzzzzzzq_ = C?.Item;
            bool? uzzzzzzzzs_(Claim.ItemComponent i)
            {
                PositiveInt vzzzzzzzzk_ = i?.SequenceElement;
                Integer vzzzzzzzzl_ = context.Operators.Convert<Integer>(vzzzzzzzzk_);
                int? vzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, vzzzzzzzzl_);
                bool? vzzzzzzzzn_ = context.Operators.Equal(vzzzzzzzzm_, 1);

                return vzzzzzzzzn_;
            };
            IEnumerable<Claim.ItemComponent> uzzzzzzzzt_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)uzzzzzzzzq_, uzzzzzzzzs_);
            bool? uzzzzzzzzu_(Claim.ItemComponent @this)
            {
                DataType vzzzzzzzzo_ = @this?.Location;
                bool? vzzzzzzzzp_ = context.Operators.Not((bool?)(vzzzzzzzzo_ is null));

                return vzzzzzzzzp_;
            };
            IEnumerable<Claim.ItemComponent> uzzzzzzzzv_ = context.Operators.Where<Claim.ItemComponent>(uzzzzzzzzt_, uzzzzzzzzu_);
            object uzzzzzzzzw_(Claim.ItemComponent @this)
            {
                DataType vzzzzzzzzq_ = @this?.Location;

                return vzzzzzzzzq_;
            };
            IEnumerable<object> uzzzzzzzzx_ = context.Operators.Select<Claim.ItemComponent, object>(uzzzzzzzzv_, uzzzzzzzzw_);
            ResourceReference uzzzzzzzzy_(object l) =>
                l as ResourceReference;
            IEnumerable<ResourceReference> uzzzzzzzzz_ = context.Operators.Select<object, ResourceReference>(uzzzzzzzzx_, uzzzzzzzzy_);
            bool? vzzzzzzzzb_(Claim.ItemComponent i)
            {
                PositiveInt vzzzzzzzzr_ = i?.SequenceElement;
                Integer vzzzzzzzzs_ = context.Operators.Convert<Integer>(vzzzzzzzzr_);
                int? vzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, vzzzzzzzzs_);
                bool? vzzzzzzzzu_ = context.Operators.Equal(vzzzzzzzzt_, 1);

                return vzzzzzzzzu_;
            };
            IEnumerable<Claim.ItemComponent> vzzzzzzzzc_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)uzzzzzzzzq_, vzzzzzzzzb_);
            bool? vzzzzzzzzd_(Claim.ItemComponent @this)
            {
                DataType vzzzzzzzzv_ = @this?.Location;
                bool? vzzzzzzzzw_ = context.Operators.Not((bool?)(vzzzzzzzzv_ is null));

                return vzzzzzzzzw_;
            };
            IEnumerable<Claim.ItemComponent> vzzzzzzzze_ = context.Operators.Where<Claim.ItemComponent>(vzzzzzzzzc_, vzzzzzzzzd_);
            object vzzzzzzzzf_(Claim.ItemComponent @this)
            {
                DataType vzzzzzzzzx_ = @this?.Location;

                return vzzzzzzzzx_;
            };
            IEnumerable<object> vzzzzzzzzg_ = context.Operators.Select<Claim.ItemComponent, object>(vzzzzzzzze_, vzzzzzzzzf_);
            string vzzzzzzzzh_(object l)
            {
                FhirString vzzzzzzzzy_ = (l as ResourceReference)?.ReferenceElement;
                FhirString[] vzzzzzzzzz_ = [
                    vzzzzzzzzy_,
                ];
                string wzzzzzzzza_(FhirString r)
                {
                    string wzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string wzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, wzzzzzzzzd_);

                    return wzzzzzzzze_;
                };
                IEnumerable<string> wzzzzzzzzb_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)vzzzzzzzzz_, wzzzzzzzza_);
                string wzzzzzzzzc_ = context.Operators.SingletonFrom<string>(wzzzzzzzzb_);

                return wzzzzzzzzc_;
            };
            IEnumerable<string> vzzzzzzzzi_ = context.Operators.Select<object, string>(vzzzzzzzzg_, vzzzzzzzzh_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? vzzzzzzzzj_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent>)uzzzzzzzzq_, uzzzzzzzzz_, vzzzzzzzzi_);

            return vzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> uzzzzzzzzi_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, uzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> uzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(uzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? uzzzzzzzzk_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, uzzzzzzzzj_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?[] uzzzzzzzzl_ = [
            uzzzzzzzzk_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? uzzzzzzzzm_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? ClaimProperties)
        {
            IEnumerable<Location> wzzzzzzzzf_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
            bool? wzzzzzzzzg_(Location l)
            {
                Id wzzzzzzzzo_ = l?.IdElement;
                string wzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, wzzzzzzzzo_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> wzzzzzzzzq_ = ClaimProperties?.ItemsLocationReferences;
                bool? wzzzzzzzzr_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> wzzzzzzzzx_ = @this?.ItemLocationID;
                    bool? wzzzzzzzzy_ = context.Operators.Not((bool?)(wzzzzzzzzx_ is null));

                    return wzzzzzzzzy_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> wzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(wzzzzzzzzq_, wzzzzzzzzr_);
                IEnumerable<string> wzzzzzzzzt_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> wzzzzzzzzz_ = @this?.ItemLocationID;

                    return wzzzzzzzzz_;
                };
                IEnumerable<IEnumerable<string>> wzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(wzzzzzzzzs_, wzzzzzzzzt_);
                IEnumerable<string> wzzzzzzzzv_ = context.Operators.Flatten<string>(wzzzzzzzzu_);
                bool? wzzzzzzzzw_ = context.Operators.In<string>(wzzzzzzzzp_, wzzzzzzzzv_);

                return wzzzzzzzzw_;
            };
            IEnumerable<Location> wzzzzzzzzh_ = context.Operators.Where<Location>(wzzzzzzzzf_, wzzzzzzzzg_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? wzzzzzzzzi_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, wzzzzzzzzh_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?[] wzzzzzzzzj_ = [
                wzzzzzzzzi_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? wzzzzzzzzk_((CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? GetLocation)
            {
                IEnumerable<Location> xzzzzzzzza_ = GetLocation?.CorrespondingLocations;
                bool? xzzzzzzzzb_(Location C)
                {
                    bool? xzzzzzzzzl_ = context.Operators.Not((bool?)(C is null));

                    return xzzzzzzzzl_;
                };
                IEnumerable<Location> xzzzzzzzzc_ = context.Operators.Where<Location>(xzzzzzzzza_, xzzzzzzzzb_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? xzzzzzzzzd_(Location C)
                {
                    List<Identifier> xzzzzzzzzm_ = C?.Identifier;
                    bool? xzzzzzzzzn_(Identifier l)
                    {
                        FhirUri xzzzzzzzzy_ = l?.SystemElement;
                        string xzzzzzzzzz_ = xzzzzzzzzy_?.Value;
                        bool? yzzzzzzzza_ = context.Operators.Equal(xzzzzzzzzz_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept yzzzzzzzzb_ = l?.Type;
                        CqlConcept yzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzb_);
                        CqlCode yzzzzzzzzd_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept yzzzzzzzze_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzd_);
                        bool? yzzzzzzzzf_ = context.Operators.Equivalent(yzzzzzzzzc_, yzzzzzzzze_);
                        bool? yzzzzzzzzg_ = context.Operators.And(yzzzzzzzza_, yzzzzzzzzf_);
                        FhirString yzzzzzzzzh_ = l?.ValueElement;
                        string yzzzzzzzzi_ = yzzzzzzzzh_?.Value;
                        bool? yzzzzzzzzj_ = context.Operators.Not((bool?)(yzzzzzzzzi_ is null));
                        bool? yzzzzzzzzk_ = context.Operators.And(yzzzzzzzzg_, yzzzzzzzzj_);

                        return yzzzzzzzzk_;
                    };
                    IEnumerable<Identifier> xzzzzzzzzo_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)xzzzzzzzzm_, xzzzzzzzzn_);
                    FhirString xzzzzzzzzp_(Identifier l)
                    {
                        FhirString yzzzzzzzzl_ = l?.ValueElement;

                        return yzzzzzzzzl_;
                    };
                    IEnumerable<FhirString> xzzzzzzzzq_ = context.Operators.Select<Identifier, FhirString>(xzzzzzzzzo_, xzzzzzzzzp_);
                    IEnumerable<FhirString> xzzzzzzzzr_ = context.Operators.Distinct<FhirString>(xzzzzzzzzq_);
                    bool? xzzzzzzzzt_(Identifier l)
                    {
                        FhirUri yzzzzzzzzm_ = l?.SystemElement;
                        string yzzzzzzzzn_ = yzzzzzzzzm_?.Value;
                        bool? yzzzzzzzzo_ = context.Operators.Equal(yzzzzzzzzn_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept yzzzzzzzzp_ = l?.Type;
                        CqlConcept yzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzp_);
                        CqlCode yzzzzzzzzr_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept yzzzzzzzzs_ = context.Operators.ConvertCodeToConcept(yzzzzzzzzr_);
                        bool? yzzzzzzzzt_ = context.Operators.Equivalent(yzzzzzzzzq_, yzzzzzzzzs_);
                        bool? yzzzzzzzzu_ = context.Operators.And(yzzzzzzzzo_, yzzzzzzzzt_);
                        FhirString yzzzzzzzzv_ = l?.ValueElement;
                        string yzzzzzzzzw_ = yzzzzzzzzv_?.Value;
                        bool? yzzzzzzzzx_ = context.Operators.And(yzzzzzzzzu_, (bool?)(yzzzzzzzzw_ is null));

                        return yzzzzzzzzx_;
                    };
                    IEnumerable<Identifier> xzzzzzzzzu_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)xzzzzzzzzm_, xzzzzzzzzt_);
                    Identifier xzzzzzzzzv_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> xzzzzzzzzw_ = context.Operators.Select<Identifier, Identifier>(xzzzzzzzzu_, xzzzzzzzzv_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? xzzzzzzzzx_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, xzzzzzzzzr_, xzzzzzzzzw_);

                    return xzzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> xzzzzzzzze_ = context.Operators.Select<Location, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(xzzzzzzzzc_, xzzzzzzzzd_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? xzzzzzzzzf_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, xzzzzzzzze_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] xzzzzzzzzg_ = [
                    xzzzzzzzzf_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? xzzzzzzzzh_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? yzzzzzzzzy_()
                    {
                        bool zzzzzzzzza_()
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> zzzzzzzzzb_ = ClaimProperties?.ItemsLocationReferences;
                            bool? zzzzzzzzzc_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> zzzzzzzzzi_ = @this?.SingleItem;
                                bool? zzzzzzzzzj_ = context.Operators.Not((bool?)(zzzzzzzzzi_ is null));

                                return zzzzzzzzzj_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> zzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(zzzzzzzzzb_, zzzzzzzzzc_);
                            IEnumerable<Claim.ItemComponent> zzzzzzzzze_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> zzzzzzzzzk_ = @this?.SingleItem;

                                return zzzzzzzzzk_;
                            };
                            IEnumerable<IEnumerable<Claim.ItemComponent>> zzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(zzzzzzzzzd_, zzzzzzzzze_);
                            IEnumerable<Claim.ItemComponent> zzzzzzzzzg_ = context.Operators.Flatten<Claim.ItemComponent>(zzzzzzzzzf_);
                            bool? zzzzzzzzzh_ = context.Operators.Exists<Claim.ItemComponent>(zzzzzzzzzg_);

                            return zzzzzzzzzh_ ?? false;
                        };
                        if (zzzzzzzzza_())
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> zzzzzzzzzl_ = ClaimProperties?.ItemsLocationReferences;
                            bool? zzzzzzzzzm_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> azzzzzzzzzj_ = @this?.ItemLocation;
                                bool? azzzzzzzzzk_ = context.Operators.Not((bool?)(azzzzzzzzzj_ is null));

                                return azzzzzzzzzk_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> zzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(zzzzzzzzzl_, zzzzzzzzzm_);
                            IEnumerable<ResourceReference> zzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> azzzzzzzzzl_ = @this?.ItemLocation;

                                return azzzzzzzzzl_;
                            };
                            IEnumerable<IEnumerable<ResourceReference>> zzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(zzzzzzzzzn_, zzzzzzzzzo_);
                            IEnumerable<ResourceReference> zzzzzzzzzq_ = context.Operators.Flatten<ResourceReference>(zzzzzzzzzp_);
                            bool? zzzzzzzzzr_(ResourceReference X)
                            {
                                FhirString azzzzzzzzzm_ = X?.ReferenceElement;
                                string azzzzzzzzzn_ = azzzzzzzzzm_?.Value;

                                return (bool?)(azzzzzzzzzn_ is null);
                            };
                            IEnumerable<ResourceReference> zzzzzzzzzs_ = context.Operators.Where<ResourceReference>(zzzzzzzzzq_, zzzzzzzzzr_);
                            int? zzzzzzzzzt_ = context.Operators.Count<ResourceReference>(zzzzzzzzzs_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> zzzzzzzzzu_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> zzzzzzzzzv_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> azzzzzzzzzo_ = X?.AllIdentifiers;

                                return azzzzzzzzzo_;
                            };
                            IEnumerable<IEnumerable<FhirString>> zzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(zzzzzzzzzu_, zzzzzzzzzv_);
                            IEnumerable<FhirString> zzzzzzzzzx_ = context.Operators.Flatten<FhirString>(zzzzzzzzzw_);
                            FhirString zzzzzzzzzy_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> zzzzzzzzzz_ = context.Operators.Select<FhirString, FhirString>(zzzzzzzzzx_, zzzzzzzzzy_);
                            IEnumerable<FhirString> azzzzzzzzza_ = context.Operators.Distinct<FhirString>(zzzzzzzzzz_);
                            int? azzzzzzzzzb_ = context.Operators.Count<FhirString>(azzzzzzzzza_);
                            int? azzzzzzzzzc_ = context.Operators.Add(zzzzzzzzzt_, azzzzzzzzzb_);
                            IEnumerable<Identifier> azzzzzzzzze_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> azzzzzzzzzp_ = X?.NullIdentifiers;

                                return azzzzzzzzzp_;
                            };
                            IEnumerable<IEnumerable<Identifier>> azzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(zzzzzzzzzu_, azzzzzzzzze_);
                            IEnumerable<Identifier> azzzzzzzzzg_ = context.Operators.Flatten<Identifier>(azzzzzzzzzf_);
                            int? azzzzzzzzzh_ = context.Operators.Count<Identifier>(azzzzzzzzzg_);
                            int? azzzzzzzzzi_ = context.Operators.Add(azzzzzzzzzc_, azzzzzzzzzh_);

                            return azzzzzzzzzi_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? yzzzzzzzzz_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, yzzzzzzzzy_());

                    return yzzzzzzzzz_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> xzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)xzzzzzzzzg_, xzzzzzzzzh_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> xzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(xzzzzzzzzi_);
                (CqlTupleMetadata, int? IdentifierCount)? xzzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(xzzzzzzzzj_);

                return xzzzzzzzzk_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> wzzzzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?>)wzzzzzzzzj_, wzzzzzzzzk_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> wzzzzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(wzzzzzzzzl_);
            (CqlTupleMetadata, int? IdentifierCount)? wzzzzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(wzzzzzzzzm_);

            return wzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> uzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?>)uzzzzzzzzl_, uzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> uzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(uzzzzzzzzn_);
        (CqlTupleMetadata, int? IdentifierCount)? uzzzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(uzzzzzzzzo_);

        return uzzzzzzzzp_;
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
