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
        bool? uzzzzzzzzzzi_(Claim MedicalClaim)
        {
            CodeableConcept uzzzzzzzzzzk_ = MedicalClaim?.Type;
            CqlConcept uzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, uzzzzzzzzzzk_);
            CqlCode[] uzzzzzzzzzzm_ = uzzzzzzzzzzl_?.codes;
            CqlCode uzzzzzzzzzzn_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? uzzzzzzzzzzo_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)uzzzzzzzzzzm_, uzzzzzzzzzzn_);
            CqlConcept uzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, uzzzzzzzzzzk_);
            CqlCode[] uzzzzzzzzzzr_ = uzzzzzzzzzzq_?.codes;
            CqlCode uzzzzzzzzzzs_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? uzzzzzzzzzzt_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)uzzzzzzzzzzr_, uzzzzzzzzzzs_);
            bool? uzzzzzzzzzzu_ = context.Operators.Or(uzzzzzzzzzzo_, uzzzzzzzzzzt_);

            return uzzzzzzzzzzu_;
        };
        IEnumerable<Claim> uzzzzzzzzzzj_ = context.Operators.Where<Claim>(claim, uzzzzzzzzzzi_);

        return uzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? uzzzzzzzzzzv_(Claim PharmacyClaim)
        {
            CodeableConcept uzzzzzzzzzzx_ = PharmacyClaim?.Type;
            CqlConcept uzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, uzzzzzzzzzzx_);
            CqlCode[] uzzzzzzzzzzz_ = uzzzzzzzzzzy_?.codes;
            CqlCode vzzzzzzzzzza_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? vzzzzzzzzzzb_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)uzzzzzzzzzzz_, vzzzzzzzzzza_);

            return vzzzzzzzzzzb_;
        };
        IEnumerable<Claim> uzzzzzzzzzzw_ = context.Operators.Where<Claim>(claim, uzzzzzzzzzzv_);

        return uzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? vzzzzzzzzzzc_(ClaimResponse MedicalResponse)
        {
            CodeableConcept vzzzzzzzzzze_ = MedicalResponse?.Type;
            CqlConcept vzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzzzzzzze_);
            CqlCode[] vzzzzzzzzzzg_ = vzzzzzzzzzzf_?.codes;
            CqlCode vzzzzzzzzzzh_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? vzzzzzzzzzzi_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)vzzzzzzzzzzg_, vzzzzzzzzzzh_);
            CqlConcept vzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzzzzzzze_);
            CqlCode[] vzzzzzzzzzzl_ = vzzzzzzzzzzk_?.codes;
            CqlCode vzzzzzzzzzzm_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? vzzzzzzzzzzn_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)vzzzzzzzzzzl_, vzzzzzzzzzzm_);
            bool? vzzzzzzzzzzo_ = context.Operators.Or(vzzzzzzzzzzi_, vzzzzzzzzzzn_);

            return vzzzzzzzzzzo_;
        };
        IEnumerable<ClaimResponse> vzzzzzzzzzzd_ = context.Operators.Where<ClaimResponse>(claimResponse, vzzzzzzzzzzc_);

        return vzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? vzzzzzzzzzzp_(ClaimResponse PharmacyResponse)
        {
            CodeableConcept vzzzzzzzzzzr_ = PharmacyResponse?.Type;
            CqlConcept vzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, vzzzzzzzzzzr_);
            CqlCode[] vzzzzzzzzzzt_ = vzzzzzzzzzzs_?.codes;
            CqlCode vzzzzzzzzzzu_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? vzzzzzzzzzzv_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)vzzzzzzzzzzt_, vzzzzzzzzzzu_);

            return vzzzzzzzzzzv_;
        };
        IEnumerable<ClaimResponse> vzzzzzzzzzzq_ = context.Operators.Where<ClaimResponse>(claimResponse, vzzzzzzzzzzp_);

        return vzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Medical Claims With Procedure and POS")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> vzzzzzzzzzzw_ = this.Professional_or_Institutional_Claims(context, claim);
        string vzzzzzzzzzzx_(CqlCode p)
        {
            string wzzzzzzzzzzj_ = p?.code;

            return wzzzzzzzzzzj_;
        };
        IEnumerable<string> vzzzzzzzzzzy_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, vzzzzzzzzzzx_);
        IEnumerable<string> vzzzzzzzzzzz_ = context.Operators.Distinct<string>(vzzzzzzzzzzy_);
        string wzzzzzzzzzza_(CqlCode pos)
        {
            string wzzzzzzzzzzk_ = pos?.code;

            return wzzzzzzzzzzk_;
        };
        IEnumerable<string> wzzzzzzzzzzb_ = context.Operators.Select<CqlCode, string>(posCodes, wzzzzzzzzzza_);
        IEnumerable<string> wzzzzzzzzzzc_ = context.Operators.Distinct<string>(wzzzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? wzzzzzzzzzzd_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, vzzzzzzzzzzw_, vzzzzzzzzzzz_, wzzzzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] wzzzzzzzzzze_ = [
            wzzzzzzzzzzd_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode)
        {
            IEnumerable<Claim> wzzzzzzzzzzl_ = ClaimWithPosCode?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzzzm_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> wzzzzzzzzzzr_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> wzzzzzzzzzzy_ = ClaimofInterest?.Item;
                        bool? wzzzzzzzzzzz_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept xzzzzzzzzzzb_ = ItemOnLine?.ProductOrService;
                            CqlConcept xzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzzzzzzzzb_);
                            CqlCode[] xzzzzzzzzzzd_ = xzzzzzzzzzzc_?.codes;
                            bool? xzzzzzzzzzze_(CqlCode LineCode)
                            {
                                string xzzzzzzzzzzo_ = LineCode?.code;
                                IEnumerable<string> xzzzzzzzzzzp_ = ClaimWithPosCode?.ProceduresAsStrings;
                                bool? xzzzzzzzzzzq_ = context.Operators.In<string>(xzzzzzzzzzzo_, xzzzzzzzzzzp_);

                                return xzzzzzzzzzzq_;
                            };
                            IEnumerable<CqlCode> xzzzzzzzzzzf_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)xzzzzzzzzzzd_, xzzzzzzzzzze_);
                            bool? xzzzzzzzzzzg_ = context.Operators.Exists<CqlCode>(xzzzzzzzzzzf_);
                            DataType xzzzzzzzzzzh_ = ItemOnLine?.Location;
                            CqlConcept xzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzzzzzzzzh_ as CodeableConcept);
                            CqlCode[] xzzzzzzzzzzj_ = xzzzzzzzzzzi_?.codes;
                            bool? xzzzzzzzzzzk_(CqlCode PosCode)
                            {
                                string xzzzzzzzzzzr_ = PosCode?.code;
                                IEnumerable<string> xzzzzzzzzzzs_ = ClaimWithPosCode?.POSAsString;
                                bool? xzzzzzzzzzzt_ = context.Operators.In<string>(xzzzzzzzzzzr_, xzzzzzzzzzzs_);

                                return xzzzzzzzzzzt_;
                            };
                            IEnumerable<CqlCode> xzzzzzzzzzzl_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)xzzzzzzzzzzj_, xzzzzzzzzzzk_);
                            bool? xzzzzzzzzzzm_ = context.Operators.Exists<CqlCode>(xzzzzzzzzzzl_);
                            bool? xzzzzzzzzzzn_ = context.Operators.And(xzzzzzzzzzzg_, xzzzzzzzzzzm_);

                            return xzzzzzzzzzzn_;
                        };
                        IEnumerable<Claim.ItemComponent> xzzzzzzzzzza_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)wzzzzzzzzzzy_, wzzzzzzzzzzz_);

                        return xzzzzzzzzzza_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? wzzzzzzzzzzs_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, wzzzzzzzzzzr_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] wzzzzzzzzzzt_ = [
                    wzzzzzzzzzzs_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzzzu_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? xzzzzzzzzzzu_()
                    {
                        bool xzzzzzzzzzzv_()
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzzzzw_ = LineItemDefinition?.LineItems;
                            bool? xzzzzzzzzzzx_ = context.Operators.Exists<Claim.ItemComponent>(xzzzzzzzzzzw_);

                            return xzzzzzzzzzzx_ ?? false;
                        };
                        if (xzzzzzzzzzzv_())
                        {
                            Claim xzzzzzzzzzzy_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> xzzzzzzzzzzz_ = LineItemDefinition?.LineItems;
                            bool? yzzzzzzzzzza_(Claim.ItemComponent @this)
                            {
                                DataType yzzzzzzzzzzi_ = @this?.Serviced;
                                bool? yzzzzzzzzzzj_ = context.Operators.Not((bool?)(yzzzzzzzzzzi_ is null));

                                return yzzzzzzzzzzj_;
                            };
                            IEnumerable<Claim.ItemComponent> yzzzzzzzzzzb_ = context.Operators.Where<Claim.ItemComponent>(xzzzzzzzzzzz_, yzzzzzzzzzza_);
                            object yzzzzzzzzzzc_(Claim.ItemComponent @this)
                            {
                                DataType yzzzzzzzzzzk_ = @this?.Serviced;

                                return yzzzzzzzzzzk_;
                            };
                            IEnumerable<object> yzzzzzzzzzzd_ = context.Operators.Select<Claim.ItemComponent, object>(yzzzzzzzzzzb_, yzzzzzzzzzzc_);
                            CqlInterval<CqlDateTime> yzzzzzzzzzze_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> yzzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return yzzzzzzzzzzl_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzf_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(yzzzzzzzzzzd_, yzzzzzzzzzze_);
                            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzg_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzzzf_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzzzh_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, xzzzzzzzzzzy_, yzzzzzzzzzzg_);

                            return yzzzzzzzzzzh_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return xzzzzzzzzzzu_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)wzzzzzzzzzzt_, wzzzzzzzzzzu_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzzzzv_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzzzzw_);

                return wzzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzn_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzzzzl_, wzzzzzzzzzzm_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzzzzn_);
            bool? wzzzzzzzzzzp_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? yzzzzzzzzzzm_ = context.Operators.Not((bool?)(FinalList is null));

                return yzzzzzzzzzzm_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(wzzzzzzzzzzo_, wzzzzzzzzzzp_);

            return wzzzzzzzzzzq_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)wzzzzzzzzzze_, wzzzzzzzzzzf_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzzzzzh_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzi_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzzzzzh_);

        return wzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> yzzzzzzzzzzn_ = this.Professional_or_Institutional_Claims(context, claim);
        string yzzzzzzzzzzo_(CqlCode p)
        {
            string yzzzzzzzzzzx_ = p?.code;

            return yzzzzzzzzzzx_;
        };
        IEnumerable<string> yzzzzzzzzzzp_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, yzzzzzzzzzzo_);
        IEnumerable<string> yzzzzzzzzzzq_ = context.Operators.Distinct<string>(yzzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? yzzzzzzzzzzr_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, yzzzzzzzzzzn_, yzzzzzzzzzzq_, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] yzzzzzzzzzzs_ = [
            yzzzzzzzzzzr_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithProcedure)
        {
            IEnumerable<Claim> yzzzzzzzzzzy_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzzzz_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> zzzzzzzzzzze_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> zzzzzzzzzzzl_ = ClaimofInterest?.Item;
                        bool? zzzzzzzzzzzm_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept zzzzzzzzzzzo_ = ItemOnLine?.ProductOrService;
                            CqlConcept zzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, zzzzzzzzzzzo_);
                            CqlCode[] zzzzzzzzzzzq_ = zzzzzzzzzzzp_?.codes;
                            bool? zzzzzzzzzzzr_(CqlCode LineCode)
                            {
                                string azzzzzzzzzzzk_ = LineCode?.code;
                                IEnumerable<string> azzzzzzzzzzzl_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? azzzzzzzzzzzm_ = context.Operators.In<string>(azzzzzzzzzzzk_, azzzzzzzzzzzl_);

                                return azzzzzzzzzzzm_;
                            };
                            IEnumerable<CqlCode> zzzzzzzzzzzs_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)zzzzzzzzzzzq_, zzzzzzzzzzzr_);
                            bool? zzzzzzzzzzzt_ = context.Operators.Exists<CqlCode>(zzzzzzzzzzzs_);
                            List<Claim.ProcedureComponent> zzzzzzzzzzzu_ = ClaimofInterest?.Procedure;
                            bool? zzzzzzzzzzzv_(Claim.ProcedureComponent @this)
                            {
                                DataType azzzzzzzzzzzn_ = @this?.Procedure;
                                bool? azzzzzzzzzzzo_ = context.Operators.Not((bool?)(azzzzzzzzzzzn_ is null));

                                return azzzzzzzzzzzo_;
                            };
                            IEnumerable<Claim.ProcedureComponent> zzzzzzzzzzzw_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)zzzzzzzzzzzu_, zzzzzzzzzzzv_);
                            object zzzzzzzzzzzx_(Claim.ProcedureComponent @this)
                            {
                                DataType azzzzzzzzzzzp_ = @this?.Procedure;

                                return azzzzzzzzzzzp_;
                            };
                            IEnumerable<object> zzzzzzzzzzzy_ = context.Operators.Select<Claim.ProcedureComponent, object>(zzzzzzzzzzzw_, zzzzzzzzzzzx_);
                            bool? zzzzzzzzzzzz_(object @this)
                            {
                                object azzzzzzzzzzzq_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? azzzzzzzzzzzr_ = context.Operators.Not((bool?)(azzzzzzzzzzzq_ is null));

                                return azzzzzzzzzzzr_;
                            };
                            IEnumerable<object> azzzzzzzzzzza_ = context.Operators.Where<object>(zzzzzzzzzzzy_, zzzzzzzzzzzz_);
                            object azzzzzzzzzzzb_(object @this)
                            {
                                object azzzzzzzzzzzs_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return azzzzzzzzzzzs_;
                            };
                            IEnumerable<object> azzzzzzzzzzzc_ = context.Operators.Select<object, object>(azzzzzzzzzzza_, azzzzzzzzzzzb_);
                            IEnumerable<object> azzzzzzzzzzzd_ = context.Operators.FlattenLateBoundList(azzzzzzzzzzzc_);
                            Coding azzzzzzzzzzze_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> azzzzzzzzzzzf_ = context.Operators.Select<object, Coding>(azzzzzzzzzzzd_, azzzzzzzzzzze_);
                            bool? azzzzzzzzzzzg_(Coding HeaderCode)
                            {
                                Code azzzzzzzzzzzt_ = HeaderCode?.CodeElement;
                                string azzzzzzzzzzzu_ = azzzzzzzzzzzt_?.Value;
                                IEnumerable<string> azzzzzzzzzzzv_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? azzzzzzzzzzzw_ = context.Operators.In<string>(azzzzzzzzzzzu_, azzzzzzzzzzzv_);

                                return azzzzzzzzzzzw_;
                            };
                            IEnumerable<Coding> azzzzzzzzzzzh_ = context.Operators.Where<Coding>(azzzzzzzzzzzf_, azzzzzzzzzzzg_);
                            bool? azzzzzzzzzzzi_ = context.Operators.Exists<Coding>(azzzzzzzzzzzh_);
                            bool? azzzzzzzzzzzj_ = context.Operators.Or(zzzzzzzzzzzt_, azzzzzzzzzzzi_);

                            return azzzzzzzzzzzj_;
                        };
                        IEnumerable<Claim.ItemComponent> zzzzzzzzzzzn_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)zzzzzzzzzzzl_, zzzzzzzzzzzm_);

                        return zzzzzzzzzzzn_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? zzzzzzzzzzzf_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, zzzzzzzzzzze_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] zzzzzzzzzzzg_ = [
                    zzzzzzzzzzzf_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? zzzzzzzzzzzh_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzzzzx_()
                    {
                        bool azzzzzzzzzzzy_()
                        {
                            IEnumerable<Claim.ItemComponent> azzzzzzzzzzzz_ = LineItemDefinition?.LineItems;
                            bool? bzzzzzzzzzzza_ = context.Operators.Exists<Claim.ItemComponent>(azzzzzzzzzzzz_);

                            return bzzzzzzzzzzza_ ?? false;
                        };
                        if (azzzzzzzzzzzy_())
                        {
                            Claim bzzzzzzzzzzzb_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> bzzzzzzzzzzzc_ = LineItemDefinition?.LineItems;
                            bool? bzzzzzzzzzzzd_(Claim.ItemComponent @this)
                            {
                                DataType bzzzzzzzzzzzl_ = @this?.Serviced;
                                bool? bzzzzzzzzzzzm_ = context.Operators.Not((bool?)(bzzzzzzzzzzzl_ is null));

                                return bzzzzzzzzzzzm_;
                            };
                            IEnumerable<Claim.ItemComponent> bzzzzzzzzzzze_ = context.Operators.Where<Claim.ItemComponent>(bzzzzzzzzzzzc_, bzzzzzzzzzzzd_);
                            object bzzzzzzzzzzzf_(Claim.ItemComponent @this)
                            {
                                DataType bzzzzzzzzzzzn_ = @this?.Serviced;

                                return bzzzzzzzzzzzn_;
                            };
                            IEnumerable<object> bzzzzzzzzzzzg_ = context.Operators.Select<Claim.ItemComponent, object>(bzzzzzzzzzzze_, bzzzzzzzzzzzf_);
                            CqlInterval<CqlDateTime> bzzzzzzzzzzzh_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> bzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return bzzzzzzzzzzzo_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzi_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(bzzzzzzzzzzzg_, bzzzzzzzzzzzh_);
                            IEnumerable<CqlInterval<CqlDateTime>> bzzzzzzzzzzzj_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(bzzzzzzzzzzzi_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzzzk_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, bzzzzzzzzzzzb_, bzzzzzzzzzzzj_);

                            return bzzzzzzzzzzzk_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return azzzzzzzzzzzx_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> zzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)zzzzzzzzzzzg_, zzzzzzzzzzzh_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> zzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(zzzzzzzzzzzi_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? zzzzzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(zzzzzzzzzzzj_);

                return zzzzzzzzzzzk_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> zzzzzzzzzzza_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzzzzy_, yzzzzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> zzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(zzzzzzzzzzza_);
            bool? zzzzzzzzzzzc_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? bzzzzzzzzzzzp_ = context.Operators.Not((bool?)(FinalList is null));

                return bzzzzzzzzzzzp_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> zzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(zzzzzzzzzzzb_, zzzzzzzzzzzc_);

            return zzzzzzzzzzzd_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> yzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)yzzzzzzzzzzs_, yzzzzzzzzzzt_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> yzzzzzzzzzzv_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(yzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzzzw_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(yzzzzzzzzzzv_);

        return yzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Medical Claims With Diagnosis")]
    public (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> bzzzzzzzzzzzq_ = this.Professional_or_Institutional_Claims(context, claim);
        string bzzzzzzzzzzzr_(CqlCode d)
        {
            string czzzzzzzzzzza_ = d?.code;

            return czzzzzzzzzzza_;
        };
        IEnumerable<string> bzzzzzzzzzzzs_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, bzzzzzzzzzzzr_);
        IEnumerable<string> bzzzzzzzzzzzt_ = context.Operators.Distinct<string>(bzzzzzzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? bzzzzzzzzzzzu_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, bzzzzzzzzzzzq_, bzzzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] bzzzzzzzzzzzv_ = [
            bzzzzzzzzzzzu_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> czzzzzzzzzzzb_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> czzzzzzzzzzzi_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? czzzzzzzzzzzj_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> czzzzzzzzzzzl_ = DiagnosisLine?.Diagnosis;
                        bool? czzzzzzzzzzzm_(Claim.DiagnosisComponent @this)
                        {
                            DataType dzzzzzzzzzzza_ = @this?.Diagnosis;
                            bool? dzzzzzzzzzzzb_ = context.Operators.Not((bool?)(dzzzzzzzzzzza_ is null));

                            return dzzzzzzzzzzzb_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> czzzzzzzzzzzn_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)czzzzzzzzzzzl_, czzzzzzzzzzzm_);
                        object czzzzzzzzzzzo_(Claim.DiagnosisComponent @this)
                        {
                            DataType dzzzzzzzzzzzc_ = @this?.Diagnosis;

                            return dzzzzzzzzzzzc_;
                        };
                        IEnumerable<object> czzzzzzzzzzzp_ = context.Operators.Select<Claim.DiagnosisComponent, object>(czzzzzzzzzzzn_, czzzzzzzzzzzo_);
                        bool? czzzzzzzzzzzq_(object @this)
                        {
                            object dzzzzzzzzzzzd_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? dzzzzzzzzzzze_ = context.Operators.Not((bool?)(dzzzzzzzzzzzd_ is null));

                            return dzzzzzzzzzzze_;
                        };
                        IEnumerable<object> czzzzzzzzzzzr_ = context.Operators.Where<object>(czzzzzzzzzzzp_, czzzzzzzzzzzq_);
                        object czzzzzzzzzzzs_(object @this)
                        {
                            object dzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return dzzzzzzzzzzzf_;
                        };
                        IEnumerable<object> czzzzzzzzzzzt_ = context.Operators.Select<object, object>(czzzzzzzzzzzr_, czzzzzzzzzzzs_);
                        IEnumerable<object> czzzzzzzzzzzu_ = context.Operators.FlattenLateBoundList(czzzzzzzzzzzt_);
                        Coding czzzzzzzzzzzv_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> czzzzzzzzzzzw_ = context.Operators.Select<object, Coding>(czzzzzzzzzzzu_, czzzzzzzzzzzv_);
                        bool? czzzzzzzzzzzx_(Coding HeaderCode)
                        {
                            Code dzzzzzzzzzzzg_ = HeaderCode?.CodeElement;
                            string dzzzzzzzzzzzh_ = dzzzzzzzzzzzg_?.Value;
                            IEnumerable<string> dzzzzzzzzzzzi_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? dzzzzzzzzzzzj_ = context.Operators.In<string>(dzzzzzzzzzzzh_, dzzzzzzzzzzzi_);

                            return dzzzzzzzzzzzj_;
                        };
                        IEnumerable<Coding> czzzzzzzzzzzy_ = context.Operators.Where<Coding>(czzzzzzzzzzzw_, czzzzzzzzzzzx_);
                        bool? czzzzzzzzzzzz_ = context.Operators.Exists<Coding>(czzzzzzzzzzzy_);

                        return czzzzzzzzzzzz_;
                    };
                    IEnumerable<Claim> czzzzzzzzzzzk_ = context.Operators.Where<Claim>(czzzzzzzzzzzi_, czzzzzzzzzzzj_);

                    return czzzzzzzzzzzk_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? czzzzzzzzzzzc_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, czzzzzzzzzzzb_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] czzzzzzzzzzzd_ = [
                czzzzzzzzzzzc_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzzzze_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? HeaderDefinition)
            {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzzk_()
                {
                    bool dzzzzzzzzzzzp_()
                    {
                        IEnumerable<Claim> dzzzzzzzzzzzq_ = HeaderDefinition?.DiagnosisItems;
                        bool? dzzzzzzzzzzzr_ = context.Operators.Exists<Claim>(dzzzzzzzzzzzq_);

                        return dzzzzzzzzzzzr_ ?? false;
                    };
                    if (dzzzzzzzzzzzp_())
                    {
                        IEnumerable<Claim> dzzzzzzzzzzzs_ = HeaderDefinition?.DiagnosisItems;
                        bool? dzzzzzzzzzzzu_(Claim @this)
                        {
                            List<Claim.ItemComponent> ezzzzzzzzzzzd_ = @this?.Item;
                            bool? ezzzzzzzzzzze_ = context.Operators.Not((bool?)(ezzzzzzzzzzzd_ is null));

                            return ezzzzzzzzzzze_;
                        };
                        IEnumerable<Claim> dzzzzzzzzzzzv_ = context.Operators.Where<Claim>(dzzzzzzzzzzzs_, dzzzzzzzzzzzu_);
                        List<Claim.ItemComponent> dzzzzzzzzzzzw_(Claim @this)
                        {
                            List<Claim.ItemComponent> ezzzzzzzzzzzf_ = @this?.Item;

                            return ezzzzzzzzzzzf_;
                        };
                        IEnumerable<List<Claim.ItemComponent>> dzzzzzzzzzzzx_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(dzzzzzzzzzzzv_, dzzzzzzzzzzzw_);
                        IEnumerable<Claim.ItemComponent> dzzzzzzzzzzzy_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)dzzzzzzzzzzzx_);
                        CqlInterval<CqlDateTime> dzzzzzzzzzzzz_(Claim.ItemComponent NormalDate)
                        {
                            DataType ezzzzzzzzzzzg_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> ezzzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ezzzzzzzzzzzg_);

                            return ezzzzzzzzzzzh_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzza_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(dzzzzzzzzzzzy_, dzzzzzzzzzzzz_);
                        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzzzzza_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzzzzc_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, dzzzzzzzzzzzs_, ezzzzzzzzzzzb_);

                        return ezzzzzzzzzzzc_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] dzzzzzzzzzzzl_ = [
                    dzzzzzzzzzzzk_(),
                ];
                bool? dzzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? ezzzzzzzzzzzi_ = context.Operators.Not((bool?)(FinalList is null));

                    return ezzzzzzzzzzzi_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)dzzzzzzzzzzzl_, dzzzzzzzzzzzm_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzzn_);

                return dzzzzzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)czzzzzzzzzzzd_, czzzzzzzzzzze_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzzzzf_);
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzzzzg_);

            return czzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)bzzzzzzzzzzzv_, bzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzzzzy_);

        return bzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Pharmacy Claim With Medication")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        IEnumerable<Claim> ezzzzzzzzzzzj_ = this.Pharmacy_Claims(context, claim);
        string ezzzzzzzzzzzk_(CqlCode p)
        {
            string ezzzzzzzzzzzs_ = p?.code;

            return ezzzzzzzzzzzs_;
        };
        IEnumerable<string> ezzzzzzzzzzzl_ = context.Operators.Select<CqlCode, string>(MedicationCodes, ezzzzzzzzzzzk_);
        IEnumerable<string> ezzzzzzzzzzzm_ = context.Operators.Distinct<string>(ezzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ezzzzzzzzzzzn_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, ezzzzzzzzzzzj_, ezzzzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] ezzzzzzzzzzzo_ = [
            ezzzzzzzzzzzn_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ezzzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication)
        {
            IEnumerable<Claim> ezzzzzzzzzzzt_ = ClaimWithMedication?.PharmacyClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? ezzzzzzzzzzzu_(Claim Pharmacy)
            {
                List<Claim.ItemComponent> ezzzzzzzzzzzy_ = Pharmacy?.Item;
                bool? ezzzzzzzzzzzz_(Claim.ItemComponent ItemOnLine)
                {
                    CodeableConcept fzzzzzzzzzzzg_ = ItemOnLine?.ProductOrService;
                    CqlConcept fzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, fzzzzzzzzzzzg_);
                    CqlCode[] fzzzzzzzzzzzi_ = fzzzzzzzzzzzh_?.codes;
                    bool? fzzzzzzzzzzzj_(CqlCode LineCode)
                    {
                        string fzzzzzzzzzzzm_ = LineCode?.code;
                        IEnumerable<string> fzzzzzzzzzzzn_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? fzzzzzzzzzzzo_ = context.Operators.In<string>(fzzzzzzzzzzzm_, fzzzzzzzzzzzn_);

                        return fzzzzzzzzzzzo_;
                    };
                    IEnumerable<CqlCode> fzzzzzzzzzzzk_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)fzzzzzzzzzzzi_, fzzzzzzzzzzzj_);
                    bool? fzzzzzzzzzzzl_ = context.Operators.Exists<CqlCode>(fzzzzzzzzzzzk_);

                    return fzzzzzzzzzzzl_;
                };
                IEnumerable<Claim.ItemComponent> fzzzzzzzzzzza_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ezzzzzzzzzzzy_, ezzzzzzzzzzzz_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? fzzzzzzzzzzzb_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, fzzzzzzzzzzza_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] fzzzzzzzzzzzc_ = [
                    fzzzzzzzzzzzb_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? fzzzzzzzzzzzd_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    Claim fzzzzzzzzzzzp_ = LineItemDefinition?.Claim;
                    Claim[] fzzzzzzzzzzzq_ = [
                        fzzzzzzzzzzzp_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? fzzzzzzzzzzzr_(Claim ClaimLines)
                    {
                        List<Claim.ItemComponent> fzzzzzzzzzzzu_ = ClaimLines?.Item;
                        bool? fzzzzzzzzzzzv_(Claim.ItemComponent i)
                        {
                            CodeableConcept gzzzzzzzzzzze_ = i?.ProductOrService;
                            CqlConcept gzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzzzzze_);
                            CqlCode[] gzzzzzzzzzzzg_ = gzzzzzzzzzzzf_?.codes;
                            bool? gzzzzzzzzzzzh_(CqlCode LineCode)
                            {
                                string gzzzzzzzzzzzk_ = LineCode?.code;
                                IEnumerable<string> gzzzzzzzzzzzl_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? gzzzzzzzzzzzm_ = context.Operators.In<string>(gzzzzzzzzzzzk_, gzzzzzzzzzzzl_);

                                return gzzzzzzzzzzzm_;
                            };
                            IEnumerable<CqlCode> gzzzzzzzzzzzi_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)gzzzzzzzzzzzg_, gzzzzzzzzzzzh_);
                            bool? gzzzzzzzzzzzj_ = context.Operators.Exists<CqlCode>(gzzzzzzzzzzzi_);

                            return gzzzzzzzzzzzj_;
                        };
                        IEnumerable<Claim.ItemComponent> fzzzzzzzzzzzw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)fzzzzzzzzzzzu_, fzzzzzzzzzzzv_);
                        (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? fzzzzzzzzzzzx_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDateTime> gzzzzzzzzzzzn_()
                            {
                                bool gzzzzzzzzzzzp_()
                                {
                                    Quantity gzzzzzzzzzzzq_ = i?.Quantity;
                                    bool? gzzzzzzzzzzzr_ = context.Operators.Not((bool?)(gzzzzzzzzzzzq_ is null));

                                    return gzzzzzzzzzzzr_ ?? false;
                                };
                                if (gzzzzzzzzzzzp_())
                                {
                                    CqlInterval<CqlDateTime> gzzzzzzzzzzzs_()
                                    {
                                        bool gzzzzzzzzzzzt_()
                                        {
                                            DataType gzzzzzzzzzzzu_ = i?.Serviced;
                                            bool gzzzzzzzzzzzv_ = gzzzzzzzzzzzu_ is Period;

                                            return gzzzzzzzzzzzv_;
                                        };
                                        if (gzzzzzzzzzzzt_())
                                        {
                                            DataType gzzzzzzzzzzzw_ = i?.Serviced;
                                            CqlInterval<CqlDateTime> gzzzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzzzzw_);
                                            CqlDateTime gzzzzzzzzzzzy_ = context.Operators.Start(gzzzzzzzzzzzx_);
                                            CqlInterval<CqlDateTime> hzzzzzzzzzzza_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzzzzw_);
                                            CqlDateTime hzzzzzzzzzzzb_ = context.Operators.Start(hzzzzzzzzzzza_);
                                            Quantity hzzzzzzzzzzzc_ = i?.Quantity;
                                            FhirDecimal hzzzzzzzzzzzd_ = hzzzzzzzzzzzc_?.ValueElement;
                                            decimal? hzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, hzzzzzzzzzzzd_);
                                            CqlDateTime hzzzzzzzzzzzf_ = context.Operators.Add(hzzzzzzzzzzzb_, new CqlQuantity(hzzzzzzzzzzze_, "day"));
                                            CqlQuantity hzzzzzzzzzzzg_ = context.Operators.Quantity(1m, "day");
                                            CqlDateTime hzzzzzzzzzzzh_ = context.Operators.Subtract(hzzzzzzzzzzzf_, hzzzzzzzzzzzg_);
                                            CqlInterval<CqlDateTime> hzzzzzzzzzzzi_ = context.Operators.Interval(gzzzzzzzzzzzy_, hzzzzzzzzzzzh_, true, true);

                                            return hzzzzzzzzzzzi_;
                                        }
                                        else
                                        {
                                            DataType hzzzzzzzzzzzj_ = i?.Serviced;
                                            CqlDate hzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzzzzzzzj_ as Date);
                                            CqlDate hzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzzzzzzzj_ as Date);
                                            Quantity hzzzzzzzzzzzn_ = i?.Quantity;
                                            FhirDecimal hzzzzzzzzzzzo_ = hzzzzzzzzzzzn_?.ValueElement;
                                            decimal? hzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, hzzzzzzzzzzzo_);
                                            CqlDate hzzzzzzzzzzzq_ = context.Operators.Add(hzzzzzzzzzzzm_, new CqlQuantity(hzzzzzzzzzzzp_, "day"));
                                            CqlQuantity hzzzzzzzzzzzr_ = context.Operators.Quantity(1m, "day");
                                            CqlDate hzzzzzzzzzzzs_ = context.Operators.Subtract(hzzzzzzzzzzzq_, hzzzzzzzzzzzr_);
                                            CqlInterval<CqlDate> hzzzzzzzzzzzt_ = context.Operators.Interval(hzzzzzzzzzzzk_, hzzzzzzzzzzzs_, true, true);
                                            CqlDate hzzzzzzzzzzzu_ = hzzzzzzzzzzzt_?.low;
                                            CqlDateTime hzzzzzzzzzzzv_ = context.Operators.ConvertDateToDateTime(hzzzzzzzzzzzu_);
                                            CqlDate hzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzzzzzzzj_ as Date);
                                            CqlDate hzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzzzzzzzj_ as Date);
                                            FhirDecimal izzzzzzzzzzzb_ = hzzzzzzzzzzzn_?.ValueElement;
                                            decimal? izzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, izzzzzzzzzzzb_);
                                            CqlDate izzzzzzzzzzzd_ = context.Operators.Add(hzzzzzzzzzzzz_, new CqlQuantity(izzzzzzzzzzzc_, "day"));
                                            CqlDate izzzzzzzzzzzf_ = context.Operators.Subtract(izzzzzzzzzzzd_, hzzzzzzzzzzzr_);
                                            CqlInterval<CqlDate> izzzzzzzzzzzg_ = context.Operators.Interval(hzzzzzzzzzzzx_, izzzzzzzzzzzf_, true, true);
                                            CqlDate izzzzzzzzzzzh_ = izzzzzzzzzzzg_?.high;
                                            CqlDateTime izzzzzzzzzzzi_ = context.Operators.ConvertDateToDateTime(izzzzzzzzzzzh_);
                                            CqlDate izzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzzzzzzzj_ as Date);
                                            CqlDate izzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzzzzzzzj_ as Date);
                                            FhirDecimal izzzzzzzzzzzo_ = hzzzzzzzzzzzn_?.ValueElement;
                                            decimal? izzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, izzzzzzzzzzzo_);
                                            CqlDate izzzzzzzzzzzq_ = context.Operators.Add(izzzzzzzzzzzm_, new CqlQuantity(izzzzzzzzzzzp_, "day"));
                                            CqlDate izzzzzzzzzzzs_ = context.Operators.Subtract(izzzzzzzzzzzq_, hzzzzzzzzzzzr_);
                                            CqlInterval<CqlDate> izzzzzzzzzzzt_ = context.Operators.Interval(izzzzzzzzzzzk_, izzzzzzzzzzzs_, true, true);
                                            bool? izzzzzzzzzzzu_ = izzzzzzzzzzzt_?.lowClosed;
                                            CqlDate izzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzzzzzzzj_ as Date);
                                            CqlDate izzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzzzzzzzj_ as Date);
                                            FhirDecimal jzzzzzzzzzzza_ = hzzzzzzzzzzzn_?.ValueElement;
                                            decimal? jzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, jzzzzzzzzzzza_);
                                            CqlDate jzzzzzzzzzzzc_ = context.Operators.Add(izzzzzzzzzzzy_, new CqlQuantity(jzzzzzzzzzzzb_, "day"));
                                            CqlDate jzzzzzzzzzzze_ = context.Operators.Subtract(jzzzzzzzzzzzc_, hzzzzzzzzzzzr_);
                                            CqlInterval<CqlDate> jzzzzzzzzzzzf_ = context.Operators.Interval(izzzzzzzzzzzw_, jzzzzzzzzzzze_, true, true);
                                            bool? jzzzzzzzzzzzg_ = jzzzzzzzzzzzf_?.highClosed;
                                            CqlInterval<CqlDateTime> jzzzzzzzzzzzh_ = context.Operators.Interval(hzzzzzzzzzzzv_, izzzzzzzzzzzi_, izzzzzzzzzzzu_, jzzzzzzzzzzzg_);

                                            return jzzzzzzzzzzzh_;
                                        }
                                    };

                                    return gzzzzzzzzzzzs_();
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDateTime>;
                                }
                            };
                            (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? gzzzzzzzzzzzo_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, gzzzzzzzzzzzn_());

                            return gzzzzzzzzzzzo_;
                        };
                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> fzzzzzzzzzzzy_ = context.Operators.Select<Claim.ItemComponent, (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>(fzzzzzzzzzzzw_, fzzzzzzzzzzzx_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? fzzzzzzzzzzzz_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, fzzzzzzzzzzzy_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?[] gzzzzzzzzzzza_ = [
                            fzzzzzzzzzzzz_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? gzzzzzzzzzzzb_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? ItemCalculation)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? jzzzzzzzzzzzi_()
                            {
                                bool jzzzzzzzzzzzj_()
                                {
                                    IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzk_ = LineItemDefinition?.LineItems;
                                    bool? jzzzzzzzzzzzl_ = context.Operators.Exists<Claim.ItemComponent>(jzzzzzzzzzzzk_);

                                    return jzzzzzzzzzzzl_ ?? false;
                                };
                                if (jzzzzzzzzzzzj_())
                                {
                                    Claim jzzzzzzzzzzzm_ = LineItemDefinition?.Claim;
                                    IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzn_ = LineItemDefinition?.LineItems;
                                    bool? jzzzzzzzzzzzp_(Claim.ItemComponent @this)
                                    {
                                        DataType kzzzzzzzzzzza_ = @this?.Serviced;
                                        bool? kzzzzzzzzzzzb_ = context.Operators.Not((bool?)(kzzzzzzzzzzza_ is null));

                                        return kzzzzzzzzzzzb_;
                                    };
                                    IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzq_ = context.Operators.Where<Claim.ItemComponent>(jzzzzzzzzzzzn_, jzzzzzzzzzzzp_);
                                    object jzzzzzzzzzzzr_(Claim.ItemComponent @this)
                                    {
                                        DataType kzzzzzzzzzzzc_ = @this?.Serviced;

                                        return kzzzzzzzzzzzc_;
                                    };
                                    IEnumerable<object> jzzzzzzzzzzzs_ = context.Operators.Select<Claim.ItemComponent, object>(jzzzzzzzzzzzq_, jzzzzzzzzzzzr_);
                                    CqlInterval<CqlDateTime> jzzzzzzzzzzzt_(object NormalDate)
                                    {
                                        CqlInterval<CqlDateTime> kzzzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                        return kzzzzzzzzzzzd_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzu_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(jzzzzzzzzzzzs_, jzzzzzzzzzzzt_);
                                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzv_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(jzzzzzzzzzzzu_);
                                    IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> jzzzzzzzzzzzw_ = ItemCalculation?.CoveredDays;
                                    CqlInterval<CqlDateTime> jzzzzzzzzzzzx_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d)
                                    {
                                        CqlInterval<CqlDateTime> kzzzzzzzzzzze_ = d?.DaysSupplyInterval;

                                        return kzzzzzzzzzzze_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> jzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(jzzzzzzzzzzzw_, jzzzzzzzzzzzx_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? jzzzzzzzzzzzz_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, jzzzzzzzzzzzm_, jzzzzzzzzzzzn_, jzzzzzzzzzzzv_, jzzzzzzzzzzzy_);

                                    return jzzzzzzzzzzzz_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
                                }
                            };

                            return jzzzzzzzzzzzi_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> gzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?>)gzzzzzzzzzzza_, gzzzzzzzzzzzb_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? gzzzzzzzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(gzzzzzzzzzzzc_);

                        return gzzzzzzzzzzzd_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> fzzzzzzzzzzzs_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)fzzzzzzzzzzzq_, fzzzzzzzzzzzr_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? fzzzzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(fzzzzzzzzzzzs_);

                    return fzzzzzzzzzzzt_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> fzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)fzzzzzzzzzzzc_, fzzzzzzzzzzzd_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? fzzzzzzzzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(fzzzzzzzzzzze_);

                return fzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ezzzzzzzzzzzv_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(ezzzzzzzzzzzt_, ezzzzzzzzzzzu_);
            bool? ezzzzzzzzzzzw_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList)
            {
                bool? kzzzzzzzzzzzf_ = context.Operators.Not((bool?)(FinalList is null));

                return kzzzzzzzzzzzf_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ezzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(ezzzzzzzzzzzv_, ezzzzzzzzzzzw_);

            return ezzzzzzzzzzzx_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> ezzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)ezzzzzzzzzzzo_, ezzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> ezzzzzzzzzzzr_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(ezzzzzzzzzzzq_);

        return ezzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> kzzzzzzzzzzzg_ = this.Professional_or_Institutional_Claims(context, claim);
        string kzzzzzzzzzzzh_(CqlCode d)
        {
            string kzzzzzzzzzzzt_ = d?.code;

            return kzzzzzzzzzzzt_;
        };
        IEnumerable<string> kzzzzzzzzzzzi_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, kzzzzzzzzzzzh_);
        IEnumerable<string> kzzzzzzzzzzzj_ = context.Operators.Distinct<string>(kzzzzzzzzzzzi_);
        string kzzzzzzzzzzzk_(CqlCode p)
        {
            string kzzzzzzzzzzzu_ = p?.code;

            return kzzzzzzzzzzzu_;
        };
        IEnumerable<string> kzzzzzzzzzzzl_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, kzzzzzzzzzzzk_);
        IEnumerable<string> kzzzzzzzzzzzm_ = context.Operators.Distinct<string>(kzzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? kzzzzzzzzzzzn_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, kzzzzzzzzzzzg_, kzzzzzzzzzzzj_, kzzzzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] kzzzzzzzzzzzo_ = [
            kzzzzzzzzzzzn_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> kzzzzzzzzzzzv_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> lzzzzzzzzzzzc_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? lzzzzzzzzzzzd_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> lzzzzzzzzzzzf_ = DiagnosisLine?.Diagnosis;
                        bool? lzzzzzzzzzzzg_(Claim.DiagnosisComponent @this)
                        {
                            DataType lzzzzzzzzzzzu_ = @this?.Diagnosis;
                            bool? lzzzzzzzzzzzv_ = context.Operators.Not((bool?)(lzzzzzzzzzzzu_ is null));

                            return lzzzzzzzzzzzv_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> lzzzzzzzzzzzh_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)lzzzzzzzzzzzf_, lzzzzzzzzzzzg_);
                        object lzzzzzzzzzzzi_(Claim.DiagnosisComponent @this)
                        {
                            DataType lzzzzzzzzzzzw_ = @this?.Diagnosis;

                            return lzzzzzzzzzzzw_;
                        };
                        IEnumerable<object> lzzzzzzzzzzzj_ = context.Operators.Select<Claim.DiagnosisComponent, object>(lzzzzzzzzzzzh_, lzzzzzzzzzzzi_);
                        bool? lzzzzzzzzzzzk_(object @this)
                        {
                            object lzzzzzzzzzzzx_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? lzzzzzzzzzzzy_ = context.Operators.Not((bool?)(lzzzzzzzzzzzx_ is null));

                            return lzzzzzzzzzzzy_;
                        };
                        IEnumerable<object> lzzzzzzzzzzzl_ = context.Operators.Where<object>(lzzzzzzzzzzzj_, lzzzzzzzzzzzk_);
                        object lzzzzzzzzzzzm_(object @this)
                        {
                            object lzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return lzzzzzzzzzzzz_;
                        };
                        IEnumerable<object> lzzzzzzzzzzzn_ = context.Operators.Select<object, object>(lzzzzzzzzzzzl_, lzzzzzzzzzzzm_);
                        IEnumerable<object> lzzzzzzzzzzzo_ = context.Operators.FlattenLateBoundList(lzzzzzzzzzzzn_);
                        Coding lzzzzzzzzzzzp_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> lzzzzzzzzzzzq_ = context.Operators.Select<object, Coding>(lzzzzzzzzzzzo_, lzzzzzzzzzzzp_);
                        bool? lzzzzzzzzzzzr_(Coding HeaderCode)
                        {
                            Code mzzzzzzzzzzza_ = HeaderCode?.CodeElement;
                            string mzzzzzzzzzzzb_ = mzzzzzzzzzzza_?.Value;
                            IEnumerable<string> mzzzzzzzzzzzc_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? mzzzzzzzzzzzd_ = context.Operators.In<string>(mzzzzzzzzzzzb_, mzzzzzzzzzzzc_);

                            return mzzzzzzzzzzzd_;
                        };
                        IEnumerable<Coding> lzzzzzzzzzzzs_ = context.Operators.Where<Coding>(lzzzzzzzzzzzq_, lzzzzzzzzzzzr_);
                        bool? lzzzzzzzzzzzt_ = context.Operators.Exists<Coding>(lzzzzzzzzzzzs_);

                        return lzzzzzzzzzzzt_;
                    };
                    IEnumerable<Claim> lzzzzzzzzzzze_ = context.Operators.Where<Claim>(lzzzzzzzzzzzc_, lzzzzzzzzzzzd_);

                    return lzzzzzzzzzzze_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? kzzzzzzzzzzzw_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, kzzzzzzzzzzzv_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] kzzzzzzzzzzzx_ = [
                kzzzzzzzzzzzw_,
            ];
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzzzzzzy_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ClaimWithProcedure)
            {
                IEnumerable<Claim> mzzzzzzzzzzze_ = ClaimWithProcedure?.DiagnosisItems;
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzf_(Claim ClaimofInterest)
                {
                    Claim mzzzzzzzzzzzk_()
                    {
                        if (ClaimofInterest is null)
                        {
                            return default;
                        }
                        else
                        {
                            Claim[] mzzzzzzzzzzzr_ = [
                                ClaimofInterest,
                            ];
                            bool? mzzzzzzzzzzzs_(Claim ItemOnLine)
                            {
                                List<Claim.ProcedureComponent> mzzzzzzzzzzzv_ = ItemOnLine?.Procedure;
                                bool? mzzzzzzzzzzzw_(Claim.ProcedureComponent @this)
                                {
                                    DataType nzzzzzzzzzzzy_ = @this?.Procedure;
                                    bool? nzzzzzzzzzzzz_ = context.Operators.Not((bool?)(nzzzzzzzzzzzy_ is null));

                                    return nzzzzzzzzzzzz_;
                                };
                                IEnumerable<Claim.ProcedureComponent> mzzzzzzzzzzzx_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)mzzzzzzzzzzzv_, mzzzzzzzzzzzw_);
                                object mzzzzzzzzzzzy_(Claim.ProcedureComponent @this)
                                {
                                    DataType ozzzzzzzzzzza_ = @this?.Procedure;

                                    return ozzzzzzzzzzza_;
                                };
                                IEnumerable<object> mzzzzzzzzzzzz_ = context.Operators.Select<Claim.ProcedureComponent, object>(mzzzzzzzzzzzx_, mzzzzzzzzzzzy_);
                                bool? nzzzzzzzzzzza_(object @this)
                                {
                                    object ozzzzzzzzzzzb_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                    bool? ozzzzzzzzzzzc_ = context.Operators.Not((bool?)(ozzzzzzzzzzzb_ is null));

                                    return ozzzzzzzzzzzc_;
                                };
                                IEnumerable<object> nzzzzzzzzzzzb_ = context.Operators.Where<object>(mzzzzzzzzzzzz_, nzzzzzzzzzzza_);
                                object nzzzzzzzzzzzc_(object @this)
                                {
                                    object ozzzzzzzzzzzd_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                    return ozzzzzzzzzzzd_;
                                };
                                IEnumerable<object> nzzzzzzzzzzzd_ = context.Operators.Select<object, object>(nzzzzzzzzzzzb_, nzzzzzzzzzzzc_);
                                IEnumerable<object> nzzzzzzzzzzze_ = context.Operators.FlattenLateBoundList(nzzzzzzzzzzzd_);
                                Coding nzzzzzzzzzzzf_(object @object) =>
                                    (Coding)@object;
                                IEnumerable<Coding> nzzzzzzzzzzzg_ = context.Operators.Select<object, Coding>(nzzzzzzzzzzze_, nzzzzzzzzzzzf_);
                                bool? nzzzzzzzzzzzh_(Coding ProcedureHeaderCode)
                                {
                                    Code ozzzzzzzzzzze_ = ProcedureHeaderCode?.CodeElement;
                                    string ozzzzzzzzzzzf_ = ozzzzzzzzzzze_?.Value;
                                    IEnumerable<string> ozzzzzzzzzzzg_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? ozzzzzzzzzzzh_ = context.Operators.In<string>(ozzzzzzzzzzzf_, ozzzzzzzzzzzg_);

                                    return ozzzzzzzzzzzh_;
                                };
                                IEnumerable<Coding> nzzzzzzzzzzzi_ = context.Operators.Where<Coding>(nzzzzzzzzzzzg_, nzzzzzzzzzzzh_);
                                bool? nzzzzzzzzzzzj_ = context.Operators.Exists<Coding>(nzzzzzzzzzzzi_);
                                List<Claim.ItemComponent> nzzzzzzzzzzzk_ = ItemOnLine?.Item;
                                bool? nzzzzzzzzzzzl_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept ozzzzzzzzzzzi_ = @this?.ProductOrService;
                                    bool? ozzzzzzzzzzzj_ = context.Operators.Not((bool?)(ozzzzzzzzzzzi_ is null));

                                    return ozzzzzzzzzzzj_;
                                };
                                IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)nzzzzzzzzzzzk_, nzzzzzzzzzzzl_);
                                CodeableConcept nzzzzzzzzzzzn_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept ozzzzzzzzzzzk_ = @this?.ProductOrService;

                                    return ozzzzzzzzzzzk_;
                                };
                                IEnumerable<CodeableConcept> nzzzzzzzzzzzo_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(nzzzzzzzzzzzm_, nzzzzzzzzzzzn_);
                                bool? nzzzzzzzzzzzp_(CodeableConcept @this)
                                {
                                    List<Coding> ozzzzzzzzzzzl_ = @this?.Coding;
                                    bool? ozzzzzzzzzzzm_ = context.Operators.Not((bool?)(ozzzzzzzzzzzl_ is null));

                                    return ozzzzzzzzzzzm_;
                                };
                                IEnumerable<CodeableConcept> nzzzzzzzzzzzq_ = context.Operators.Where<CodeableConcept>(nzzzzzzzzzzzo_, nzzzzzzzzzzzp_);
                                List<Coding> nzzzzzzzzzzzr_(CodeableConcept @this)
                                {
                                    List<Coding> ozzzzzzzzzzzn_ = @this?.Coding;

                                    return ozzzzzzzzzzzn_;
                                };
                                IEnumerable<List<Coding>> nzzzzzzzzzzzs_ = context.Operators.Select<CodeableConcept, List<Coding>>(nzzzzzzzzzzzq_, nzzzzzzzzzzzr_);
                                IEnumerable<Coding> nzzzzzzzzzzzt_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)nzzzzzzzzzzzs_);
                                bool? nzzzzzzzzzzzu_(Coding LineCode)
                                {
                                    Code ozzzzzzzzzzzo_ = LineCode?.CodeElement;
                                    string ozzzzzzzzzzzp_ = ozzzzzzzzzzzo_?.Value;
                                    IEnumerable<string> ozzzzzzzzzzzq_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? ozzzzzzzzzzzr_ = context.Operators.In<string>(ozzzzzzzzzzzp_, ozzzzzzzzzzzq_);

                                    return ozzzzzzzzzzzr_;
                                };
                                IEnumerable<Coding> nzzzzzzzzzzzv_ = context.Operators.Where<Coding>(nzzzzzzzzzzzt_, nzzzzzzzzzzzu_);
                                bool? nzzzzzzzzzzzw_ = context.Operators.Exists<Coding>(nzzzzzzzzzzzv_);
                                bool? nzzzzzzzzzzzx_ = context.Operators.Or(nzzzzzzzzzzzj_, nzzzzzzzzzzzw_);

                                return nzzzzzzzzzzzx_;
                            };
                            IEnumerable<Claim> mzzzzzzzzzzzt_ = context.Operators.Where<Claim>((IEnumerable<Claim>)mzzzzzzzzzzzr_, mzzzzzzzzzzzs_);
                            Claim mzzzzzzzzzzzu_ = context.Operators.SingletonFrom<Claim>(mzzzzzzzzzzzt_);

                            return mzzzzzzzzzzzu_;
                        }
                    };
                    (CqlTupleMetadata, Claim ProcedureItems)? mzzzzzzzzzzzl_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, mzzzzzzzzzzzk_());
                    (CqlTupleMetadata, Claim ProcedureItems)?[] mzzzzzzzzzzzm_ = [
                        mzzzzzzzzzzzl_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzn_((CqlTupleMetadata, Claim ProcedureItems)? HeaderDefinition)
                    {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzzs_()
                        {
                            bool ozzzzzzzzzzzt_()
                            {
                                Claim ozzzzzzzzzzzu_ = HeaderDefinition?.ProcedureItems;
                                bool? ozzzzzzzzzzzv_ = context.Operators.Not((bool?)(ozzzzzzzzzzzu_ is null));

                                return ozzzzzzzzzzzv_ ?? false;
                            };
                            if (ozzzzzzzzzzzt_())
                            {
                                Claim ozzzzzzzzzzzw_ = HeaderDefinition?.ProcedureItems;
                                List<Claim.ItemComponent> ozzzzzzzzzzzy_ = ozzzzzzzzzzzw_?.Item;
                                CqlInterval<CqlDateTime> ozzzzzzzzzzzz_(Claim.ItemComponent NormalDate)
                                {
                                    DataType pzzzzzzzzzzzd_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> pzzzzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, pzzzzzzzzzzzd_);

                                    return pzzzzzzzzzzze_;
                                };
                                IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzza_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)ozzzzzzzzzzzy_, ozzzzzzzzzzzz_);
                                IEnumerable<CqlInterval<CqlDateTime>> pzzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(pzzzzzzzzzzza_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzzzzzc_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, ozzzzzzzzzzzw_, pzzzzzzzzzzzb_);

                                return pzzzzzzzzzzzc_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        };

                        return ozzzzzzzzzzzs_();
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim ProcedureItems)?>)mzzzzzzzzzzzm_, mzzzzzzzzzzzn_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzzzzo_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzzzzp_);

                    return mzzzzzzzzzzzq_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzzg_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzzzze_, mzzzzzzzzzzzf_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzzzzg_);
                bool? mzzzzzzzzzzzi_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? pzzzzzzzzzzzf_ = context.Operators.Not((bool?)(FinalList is null));

                    return pzzzzzzzzzzzf_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzzzzh_, mzzzzzzzzzzzi_);

                return mzzzzzzzzzzzj_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> kzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)kzzzzzzzzzzzx_, kzzzzzzzzzzzy_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> lzzzzzzzzzzza_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(kzzzzzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzzzzzb_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(lzzzzzzzzzzza_);

            return lzzzzzzzzzzzb_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> kzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)kzzzzzzzzzzzo_, kzzzzzzzzzzzp_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> kzzzzzzzzzzzr_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(kzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzzzzzzs_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(kzzzzzzzzzzzr_);

        return kzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> pzzzzzzzzzzzg_ = this.Professional_or_Institutional_Claims(context, claim);
        string pzzzzzzzzzzzh_(CqlCode d)
        {
            string pzzzzzzzzzzzt_ = d?.code;

            return pzzzzzzzzzzzt_;
        };
        IEnumerable<string> pzzzzzzzzzzzi_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, pzzzzzzzzzzzh_);
        IEnumerable<string> pzzzzzzzzzzzj_ = context.Operators.Distinct<string>(pzzzzzzzzzzzi_);
        string pzzzzzzzzzzzk_(CqlCode p)
        {
            string pzzzzzzzzzzzu_ = p?.code;

            return pzzzzzzzzzzzu_;
        };
        IEnumerable<string> pzzzzzzzzzzzl_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, pzzzzzzzzzzzk_);
        IEnumerable<string> pzzzzzzzzzzzm_ = context.Operators.Distinct<string>(pzzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? pzzzzzzzzzzzn_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, pzzzzzzzzzzzg_, pzzzzzzzzzzzj_, pzzzzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] pzzzzzzzzzzzo_ = [
            pzzzzzzzzzzzn_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure)
        {
            IEnumerable<Claim> pzzzzzzzzzzzv_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzzzzzw_(Claim ClaimofInterest)
            {
                Claim qzzzzzzzzzzzb_()
                {
                    if (ClaimofInterest is null)
                    {
                        return default;
                    }
                    else
                    {
                        Claim[] qzzzzzzzzzzzi_ = [
                            ClaimofInterest,
                        ];
                        bool? qzzzzzzzzzzzj_(Claim ItemOnLine)
                        {
                            List<Claim.ItemComponent> qzzzzzzzzzzzm_ = ItemOnLine?.Item;
                            bool? qzzzzzzzzzzzn_(Claim.ItemComponent @this)
                            {
                                CodeableConcept rzzzzzzzzzzzp_ = @this?.ProductOrService;
                                bool? rzzzzzzzzzzzq_ = context.Operators.Not((bool?)(rzzzzzzzzzzzp_ is null));

                                return rzzzzzzzzzzzq_;
                            };
                            IEnumerable<Claim.ItemComponent> qzzzzzzzzzzzo_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)qzzzzzzzzzzzm_, qzzzzzzzzzzzn_);
                            CodeableConcept qzzzzzzzzzzzp_(Claim.ItemComponent @this)
                            {
                                CodeableConcept rzzzzzzzzzzzr_ = @this?.ProductOrService;

                                return rzzzzzzzzzzzr_;
                            };
                            IEnumerable<CodeableConcept> qzzzzzzzzzzzq_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(qzzzzzzzzzzzo_, qzzzzzzzzzzzp_);
                            bool? qzzzzzzzzzzzr_(CodeableConcept @this)
                            {
                                List<Coding> rzzzzzzzzzzzs_ = @this?.Coding;
                                bool? rzzzzzzzzzzzt_ = context.Operators.Not((bool?)(rzzzzzzzzzzzs_ is null));

                                return rzzzzzzzzzzzt_;
                            };
                            IEnumerable<CodeableConcept> qzzzzzzzzzzzs_ = context.Operators.Where<CodeableConcept>(qzzzzzzzzzzzq_, qzzzzzzzzzzzr_);
                            List<Coding> qzzzzzzzzzzzt_(CodeableConcept @this)
                            {
                                List<Coding> rzzzzzzzzzzzu_ = @this?.Coding;

                                return rzzzzzzzzzzzu_;
                            };
                            IEnumerable<List<Coding>> qzzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, List<Coding>>(qzzzzzzzzzzzs_, qzzzzzzzzzzzt_);
                            IEnumerable<Coding> qzzzzzzzzzzzv_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)qzzzzzzzzzzzu_);
                            bool? qzzzzzzzzzzzw_(Coding LineCode)
                            {
                                Code rzzzzzzzzzzzv_ = LineCode?.CodeElement;
                                string rzzzzzzzzzzzw_ = rzzzzzzzzzzzv_?.Value;
                                IEnumerable<string> rzzzzzzzzzzzx_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? rzzzzzzzzzzzy_ = context.Operators.In<string>(rzzzzzzzzzzzw_, rzzzzzzzzzzzx_);

                                return rzzzzzzzzzzzy_;
                            };
                            IEnumerable<Coding> qzzzzzzzzzzzx_ = context.Operators.Where<Coding>(qzzzzzzzzzzzv_, qzzzzzzzzzzzw_);
                            bool? qzzzzzzzzzzzy_ = context.Operators.Exists<Coding>(qzzzzzzzzzzzx_);
                            List<Claim.ProcedureComponent> qzzzzzzzzzzzz_ = ItemOnLine?.Procedure;
                            bool? rzzzzzzzzzzza_(Claim.ProcedureComponent @this)
                            {
                                DataType rzzzzzzzzzzzz_ = @this?.Procedure;
                                bool? szzzzzzzzzzza_ = context.Operators.Not((bool?)(rzzzzzzzzzzzz_ is null));

                                return szzzzzzzzzzza_;
                            };
                            IEnumerable<Claim.ProcedureComponent> rzzzzzzzzzzzb_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)qzzzzzzzzzzzz_, rzzzzzzzzzzza_);
                            object rzzzzzzzzzzzc_(Claim.ProcedureComponent @this)
                            {
                                DataType szzzzzzzzzzzb_ = @this?.Procedure;

                                return szzzzzzzzzzzb_;
                            };
                            IEnumerable<object> rzzzzzzzzzzzd_ = context.Operators.Select<Claim.ProcedureComponent, object>(rzzzzzzzzzzzb_, rzzzzzzzzzzzc_);
                            bool? rzzzzzzzzzzze_(object @this)
                            {
                                object szzzzzzzzzzzc_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? szzzzzzzzzzzd_ = context.Operators.Not((bool?)(szzzzzzzzzzzc_ is null));

                                return szzzzzzzzzzzd_;
                            };
                            IEnumerable<object> rzzzzzzzzzzzf_ = context.Operators.Where<object>(rzzzzzzzzzzzd_, rzzzzzzzzzzze_);
                            object rzzzzzzzzzzzg_(object @this)
                            {
                                object szzzzzzzzzzze_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return szzzzzzzzzzze_;
                            };
                            IEnumerable<object> rzzzzzzzzzzzh_ = context.Operators.Select<object, object>(rzzzzzzzzzzzf_, rzzzzzzzzzzzg_);
                            IEnumerable<object> rzzzzzzzzzzzi_ = context.Operators.FlattenLateBoundList(rzzzzzzzzzzzh_);
                            Coding rzzzzzzzzzzzj_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> rzzzzzzzzzzzk_ = context.Operators.Select<object, Coding>(rzzzzzzzzzzzi_, rzzzzzzzzzzzj_);
                            bool? rzzzzzzzzzzzl_(Coding HeaderCode)
                            {
                                Code szzzzzzzzzzzf_ = HeaderCode?.CodeElement;
                                string szzzzzzzzzzzg_ = szzzzzzzzzzzf_?.Value;
                                IEnumerable<string> szzzzzzzzzzzh_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? szzzzzzzzzzzi_ = context.Operators.In<string>(szzzzzzzzzzzg_, szzzzzzzzzzzh_);

                                return szzzzzzzzzzzi_;
                            };
                            IEnumerable<Coding> rzzzzzzzzzzzm_ = context.Operators.Where<Coding>(rzzzzzzzzzzzk_, rzzzzzzzzzzzl_);
                            bool? rzzzzzzzzzzzn_ = context.Operators.Exists<Coding>(rzzzzzzzzzzzm_);
                            bool? rzzzzzzzzzzzo_ = context.Operators.Or(qzzzzzzzzzzzy_, rzzzzzzzzzzzn_);

                            return rzzzzzzzzzzzo_;
                        };
                        IEnumerable<Claim> qzzzzzzzzzzzk_ = context.Operators.Where<Claim>((IEnumerable<Claim>)qzzzzzzzzzzzi_, qzzzzzzzzzzzj_);
                        Claim qzzzzzzzzzzzl_ = context.Operators.SingletonFrom<Claim>(qzzzzzzzzzzzk_);

                        return qzzzzzzzzzzzl_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? qzzzzzzzzzzzc_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, qzzzzzzzzzzzb_());
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?[] qzzzzzzzzzzzd_ = [
                    qzzzzzzzzzzzc_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzze_((CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? DiagnosisCheck)
                {
                    Claim szzzzzzzzzzzj_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] szzzzzzzzzzzk_ = [
                        szzzzzzzzzzzj_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzl_(Claim ClaimforDiagnosis)
                    {
                        List<Claim.ItemComponent> szzzzzzzzzzzp_ = ClaimforDiagnosis?.Item;
                        Claim szzzzzzzzzzzq_()
                        {
                            if (ClaimforDiagnosis is null)
                            {
                                return default;
                            }
                            else
                            {
                                Claim[] szzzzzzzzzzzx_ = [
                                    ClaimforDiagnosis,
                                ];
                                bool? szzzzzzzzzzzy_(Claim RightClaim)
                                {
                                    List<Claim.DiagnosisComponent> tzzzzzzzzzzzb_ = RightClaim?.Diagnosis;
                                    bool? tzzzzzzzzzzzc_(Claim.DiagnosisComponent RightDiagnosis)
                                    {
                                        PositiveInt tzzzzzzzzzzzf_ = RightDiagnosis?.SequenceElement;
                                        Integer tzzzzzzzzzzzg_ = context.Operators.Convert<Integer>(tzzzzzzzzzzzf_);
                                        int? tzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, tzzzzzzzzzzzg_);
                                        bool? tzzzzzzzzzzzi_ = context.Operators.Equal(tzzzzzzzzzzzh_, 1);
                                        DataType tzzzzzzzzzzzj_ = RightDiagnosis?.Diagnosis;
                                        IEnumerable<Coding> tzzzzzzzzzzzk_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(tzzzzzzzzzzzj_, "coding");
                                        bool? tzzzzzzzzzzzl_(Coding DiagnosisCode)
                                        {
                                            Code tzzzzzzzzzzzp_ = DiagnosisCode?.CodeElement;
                                            string tzzzzzzzzzzzq_ = tzzzzzzzzzzzp_?.Value;
                                            IEnumerable<string> tzzzzzzzzzzzr_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                            bool? tzzzzzzzzzzzs_ = context.Operators.In<string>(tzzzzzzzzzzzq_, tzzzzzzzzzzzr_);

                                            return tzzzzzzzzzzzs_;
                                        };
                                        IEnumerable<Coding> tzzzzzzzzzzzm_ = context.Operators.Where<Coding>(tzzzzzzzzzzzk_, tzzzzzzzzzzzl_);
                                        bool? tzzzzzzzzzzzn_ = context.Operators.Exists<Coding>(tzzzzzzzzzzzm_);
                                        bool? tzzzzzzzzzzzo_ = context.Operators.And(tzzzzzzzzzzzi_, tzzzzzzzzzzzn_);

                                        return tzzzzzzzzzzzo_;
                                    };
                                    IEnumerable<Claim.DiagnosisComponent> tzzzzzzzzzzzd_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)tzzzzzzzzzzzb_, tzzzzzzzzzzzc_);
                                    bool? tzzzzzzzzzzze_ = context.Operators.Exists<Claim.DiagnosisComponent>(tzzzzzzzzzzzd_);

                                    return tzzzzzzzzzzze_;
                                };
                                IEnumerable<Claim> szzzzzzzzzzzz_ = context.Operators.Where<Claim>((IEnumerable<Claim>)szzzzzzzzzzzx_, szzzzzzzzzzzy_);
                                Claim tzzzzzzzzzzza_ = context.Operators.SingletonFrom<Claim>(szzzzzzzzzzzz_);

                                return tzzzzzzzzzzza_;
                            }
                        };
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? szzzzzzzzzzzr_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)szzzzzzzzzzzp_, szzzzzzzzzzzq_());
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] szzzzzzzzzzzs_ = [
                            szzzzzzzzzzzr_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzzzzzt_()
                            {
                                bool tzzzzzzzzzzzu_()
                                {
                                    bool? tzzzzzzzzzzzv_ = context.Operators.Not((bool?)(LineItemDefinition is null));
                                    Claim tzzzzzzzzzzzw_ = LineItemDefinition?.LineItems;
                                    bool? tzzzzzzzzzzzx_ = context.Operators.Not((bool?)(tzzzzzzzzzzzw_ is null));
                                    bool? tzzzzzzzzzzzy_ = context.Operators.And(tzzzzzzzzzzzv_, tzzzzzzzzzzzx_);

                                    return tzzzzzzzzzzzy_ ?? false;
                                };
                                if (tzzzzzzzzzzzu_())
                                {
                                    Claim tzzzzzzzzzzzz_ = LineItemDefinition?.LineItems;
                                    List<Claim.ItemComponent> uzzzzzzzzzzzb_ = tzzzzzzzzzzzz_?.Item;
                                    CqlInterval<CqlDateTime> uzzzzzzzzzzzc_(Claim.ItemComponent NormalDate)
                                    {
                                        DataType uzzzzzzzzzzzf_ = NormalDate?.Serviced;
                                        CqlInterval<CqlDateTime> uzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, uzzzzzzzzzzzf_);

                                        return uzzzzzzzzzzzg_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> uzzzzzzzzzzzd_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)uzzzzzzzzzzzb_, uzzzzzzzzzzzc_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzzzze_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, tzzzzzzzzzzzz_, uzzzzzzzzzzzd_);

                                    return uzzzzzzzzzzze_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                                }
                            };

                            return tzzzzzzzzzzzt_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)szzzzzzzzzzzs_, szzzzzzzzzzzt_);
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzzzzzu_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzzzzzv_);

                        return szzzzzzzzzzzw_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzzzzzm_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)szzzzzzzzzzzk_, szzzzzzzzzzzl_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzzzzzm_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzzzzzn_);

                    return szzzzzzzzzzzo_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?>)qzzzzzzzzzzzd_, qzzzzzzzzzzze_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzzzzzf_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzzzzzg_);

                return qzzzzzzzzzzzh_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzzzzzx_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzzzzzzv_, pzzzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzzzzzzx_);
            bool? pzzzzzzzzzzzz_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? uzzzzzzzzzzzh_ = context.Operators.Not((bool?)(FinalList is null));

                return uzzzzzzzzzzzh_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzzzzzzy_, pzzzzzzzzzzzz_);

            return qzzzzzzzzzzza_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> pzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)pzzzzzzzzzzzo_, pzzzzzzzzzzzp_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> pzzzzzzzzzzzr_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(pzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzzzzzs_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(pzzzzzzzzzzzr_);

        return pzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Medical Claims With Principal Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> uzzzzzzzzzzzi_ = this.Professional_or_Institutional_Claims(context, claim);
        string uzzzzzzzzzzzj_(CqlCode d)
        {
            string uzzzzzzzzzzzs_ = d?.code;

            return uzzzzzzzzzzzs_;
        };
        IEnumerable<string> uzzzzzzzzzzzk_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, uzzzzzzzzzzzj_);
        IEnumerable<string> uzzzzzzzzzzzl_ = context.Operators.Distinct<string>(uzzzzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? uzzzzzzzzzzzm_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, uzzzzzzzzzzzi_, uzzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] uzzzzzzzzzzzn_ = [
            uzzzzzzzzzzzm_,
        ];
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> uzzzzzzzzzzzt_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> vzzzzzzzzzzza_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? vzzzzzzzzzzzb_(Claim RightClaim)
                    {
                        List<Claim.DiagnosisComponent> vzzzzzzzzzzzd_ = RightClaim?.Diagnosis;
                        bool? vzzzzzzzzzzze_(Claim.DiagnosisComponent RightDiagnosis)
                        {
                            PositiveInt vzzzzzzzzzzzh_ = RightDiagnosis?.SequenceElement;
                            Integer vzzzzzzzzzzzi_ = context.Operators.Convert<Integer>(vzzzzzzzzzzzh_);
                            int? vzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, vzzzzzzzzzzzi_);
                            bool? vzzzzzzzzzzzk_ = context.Operators.Equal(vzzzzzzzzzzzj_, 1);
                            DataType vzzzzzzzzzzzl_ = RightDiagnosis?.Diagnosis;
                            IEnumerable<Coding> vzzzzzzzzzzzm_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(vzzzzzzzzzzzl_, "coding");
                            bool? vzzzzzzzzzzzn_(Coding DiagnosisCode)
                            {
                                Code vzzzzzzzzzzzr_ = DiagnosisCode?.CodeElement;
                                string vzzzzzzzzzzzs_ = vzzzzzzzzzzzr_?.Value;
                                IEnumerable<string> vzzzzzzzzzzzt_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                                bool? vzzzzzzzzzzzu_ = context.Operators.In<string>(vzzzzzzzzzzzs_, vzzzzzzzzzzzt_);

                                return vzzzzzzzzzzzu_;
                            };
                            IEnumerable<Coding> vzzzzzzzzzzzo_ = context.Operators.Where<Coding>(vzzzzzzzzzzzm_, vzzzzzzzzzzzn_);
                            bool? vzzzzzzzzzzzp_ = context.Operators.Exists<Coding>(vzzzzzzzzzzzo_);
                            bool? vzzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzzk_, vzzzzzzzzzzzp_);

                            return vzzzzzzzzzzzq_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> vzzzzzzzzzzzf_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)vzzzzzzzzzzzd_, vzzzzzzzzzzze_);
                        bool? vzzzzzzzzzzzg_ = context.Operators.Exists<Claim.DiagnosisComponent>(vzzzzzzzzzzzf_);

                        return vzzzzzzzzzzzg_;
                    };
                    IEnumerable<Claim> vzzzzzzzzzzzc_ = context.Operators.Where<Claim>(vzzzzzzzzzzza_, vzzzzzzzzzzzb_);

                    return vzzzzzzzzzzzc_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)? uzzzzzzzzzzzu_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, uzzzzzzzzzzzt_());
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)?[] uzzzzzzzzzzzv_ = [
                uzzzzzzzzzzzu_,
            ];
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<Claim> LineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> vzzzzzzzzzzzv_ = LineItemDefinition?.LineItems;
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzzzzzw_(Claim ClaimWithDiagnosis)
                {
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzzzzb_()
                    {
                        if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
                        {
                            IEnumerable<Claim> wzzzzzzzzzzzc_ = LineItemDefinition?.LineItems;
                            bool? wzzzzzzzzzzze_(Claim @this)
                            {
                                List<Claim.ItemComponent> wzzzzzzzzzzzn_ = @this?.Item;
                                bool? wzzzzzzzzzzzo_ = context.Operators.Not((bool?)(wzzzzzzzzzzzn_ is null));

                                return wzzzzzzzzzzzo_;
                            };
                            IEnumerable<Claim> wzzzzzzzzzzzf_ = context.Operators.Where<Claim>(wzzzzzzzzzzzc_, wzzzzzzzzzzze_);
                            List<Claim.ItemComponent> wzzzzzzzzzzzg_(Claim @this)
                            {
                                List<Claim.ItemComponent> wzzzzzzzzzzzp_ = @this?.Item;

                                return wzzzzzzzzzzzp_;
                            };
                            IEnumerable<List<Claim.ItemComponent>> wzzzzzzzzzzzh_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(wzzzzzzzzzzzf_, wzzzzzzzzzzzg_);
                            IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzi_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)wzzzzzzzzzzzh_);
                            CqlInterval<CqlDateTime> wzzzzzzzzzzzj_(Claim.ItemComponent NormalDate)
                            {
                                DataType wzzzzzzzzzzzq_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> wzzzzzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzq_);

                                return wzzzzzzzzzzzr_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzk_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(wzzzzzzzzzzzi_, wzzzzzzzzzzzj_);
                            IEnumerable<CqlInterval<CqlDateTime>> wzzzzzzzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(wzzzzzzzzzzzk_);
                            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? wzzzzzzzzzzzm_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, wzzzzzzzzzzzc_, wzzzzzzzzzzzl_);

                            return wzzzzzzzzzzzm_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return wzzzzzzzzzzzb_();
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> vzzzzzzzzzzzx_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzzzzzv_, vzzzzzzzzzzzw_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> vzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzzzzzx_);
                bool? vzzzzzzzzzzzz_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? wzzzzzzzzzzzs_ = context.Operators.Not((bool?)(FinalList is null));

                    return wzzzzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(vzzzzzzzzzzzy_, vzzzzzzzzzzzz_);

                return wzzzzzzzzzzza_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> uzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?>)uzzzzzzzzzzzv_, uzzzzzzzzzzzw_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> uzzzzzzzzzzzy_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(uzzzzzzzzzzzx_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzzzzz_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(uzzzzzzzzzzzy_);

            return uzzzzzzzzzzzz_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> uzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)uzzzzzzzzzzzn_, uzzzzzzzzzzzo_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> uzzzzzzzzzzzq_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(uzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzzzzr_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(uzzzzzzzzzzzq_);

        return uzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Get All Professional and Institutional Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> wzzzzzzzzzzzt_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
        IEnumerable<Claim> wzzzzzzzzzzzu_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? wzzzzzzzzzzzv_ = (CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE, wzzzzzzzzzzzt_, wzzzzzzzzzzzu_);

        return wzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Get All Paid Claim Reponses")]
    public IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? wzzzzzzzzzzzw_(ClaimResponse ResponseItem)
        {
            Code<ClaimProcessingCodes> xzzzzzzzzzzze_ = ResponseItem?.OutcomeElement;
            string xzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzze_);
            string[] xzzzzzzzzzzzg_ = [
                "complete",
                "partial",
            ];
            bool? xzzzzzzzzzzzh_ = context.Operators.In<string>(xzzzzzzzzzzzf_, xzzzzzzzzzzzg_ as IEnumerable<string>);

            return xzzzzzzzzzzzh_;
        };
        IEnumerable<ClaimResponse> wzzzzzzzzzzzx_ = context.Operators.Where<ClaimResponse>(claimResponse, wzzzzzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? wzzzzzzzzzzzy_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, wzzzzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?[] wzzzzzzzzzzzz_ = [
            wzzzzzzzzzzzy_,
        ];
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> xzzzzzzzzzzza_((CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ClaimResponse)
        {
            IEnumerable<ClaimResponse> xzzzzzzzzzzzi_ = ClaimResponse?.PaidResponse;
            (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? xzzzzzzzzzzzj_(ClaimResponse ClmResp)
            {
                ResourceReference xzzzzzzzzzzzm_ = ClmResp?.Request;
                FhirString xzzzzzzzzzzzn_ = xzzzzzzzzzzzm_?.ReferenceElement;
                string xzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzn_);
                string xzzzzzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, xzzzzzzzzzzzo_);
                List<ClaimResponse.ItemComponent> xzzzzzzzzzzzq_ = ClmResp?.Item;
                bool? xzzzzzzzzzzzr_(ClaimResponse.ItemComponent ResponseItem)
                {
                    List<ClaimResponse.AdjudicationComponent> xzzzzzzzzzzzu_ = ResponseItem?.Adjudication;
                    bool? xzzzzzzzzzzzv_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept yzzzzzzzzzzzq_ = @this?.Category;
                        bool? yzzzzzzzzzzzr_ = context.Operators.Not((bool?)(yzzzzzzzzzzzq_ is null));

                        return yzzzzzzzzzzzr_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> xzzzzzzzzzzzw_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)xzzzzzzzzzzzu_, xzzzzzzzzzzzv_);
                    CodeableConcept xzzzzzzzzzzzx_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept yzzzzzzzzzzzs_ = @this?.Category;

                        return yzzzzzzzzzzzs_;
                    };
                    IEnumerable<CodeableConcept> xzzzzzzzzzzzy_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(xzzzzzzzzzzzw_, xzzzzzzzzzzzx_);
                    bool? xzzzzzzzzzzzz_(CodeableConcept @this)
                    {
                        List<Coding> yzzzzzzzzzzzt_ = @this?.Coding;
                        bool? yzzzzzzzzzzzu_ = context.Operators.Not((bool?)(yzzzzzzzzzzzt_ is null));

                        return yzzzzzzzzzzzu_;
                    };
                    IEnumerable<CodeableConcept> yzzzzzzzzzzza_ = context.Operators.Where<CodeableConcept>(xzzzzzzzzzzzy_, xzzzzzzzzzzzz_);
                    List<Coding> yzzzzzzzzzzzb_(CodeableConcept @this)
                    {
                        List<Coding> yzzzzzzzzzzzv_ = @this?.Coding;

                        return yzzzzzzzzzzzv_;
                    };
                    IEnumerable<List<Coding>> yzzzzzzzzzzzc_ = context.Operators.Select<CodeableConcept, List<Coding>>(yzzzzzzzzzzza_, yzzzzzzzzzzzb_);
                    IEnumerable<Coding> yzzzzzzzzzzzd_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)yzzzzzzzzzzzc_);
                    bool? yzzzzzzzzzzze_(Coding CategoryItem)
                    {
                        Code yzzzzzzzzzzzw_ = CategoryItem?.CodeElement;
                        string yzzzzzzzzzzzx_ = yzzzzzzzzzzzw_?.Value;
                        bool? yzzzzzzzzzzzy_ = context.Operators.Equal(yzzzzzzzzzzzx_, "benefit");

                        return yzzzzzzzzzzzy_;
                    };
                    IEnumerable<Coding> yzzzzzzzzzzzf_ = context.Operators.Where<Coding>(yzzzzzzzzzzzd_, yzzzzzzzzzzze_);
                    bool? yzzzzzzzzzzzg_ = context.Operators.Exists<Coding>(yzzzzzzzzzzzf_);
                    bool? yzzzzzzzzzzzi_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money yzzzzzzzzzzzz_ = @this?.Amount;
                        bool? zzzzzzzzzzzza_ = context.Operators.Not((bool?)(yzzzzzzzzzzzz_ is null));

                        return zzzzzzzzzzzza_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> yzzzzzzzzzzzj_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)xzzzzzzzzzzzu_, yzzzzzzzzzzzi_);
                    Money yzzzzzzzzzzzk_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money zzzzzzzzzzzzb_ = @this?.Amount;

                        return zzzzzzzzzzzzb_;
                    };
                    IEnumerable<Money> yzzzzzzzzzzzl_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(yzzzzzzzzzzzj_, yzzzzzzzzzzzk_);
                    bool? yzzzzzzzzzzzm_(Money DollarAmount)
                    {
                        FhirDecimal zzzzzzzzzzzzc_ = DollarAmount?.ValueElement;
                        decimal? zzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, zzzzzzzzzzzzc_);
                        decimal? zzzzzzzzzzzze_ = context.Operators.ConvertIntegerToDecimal(0);
                        bool? zzzzzzzzzzzzf_ = context.Operators.Greater(zzzzzzzzzzzzd_, zzzzzzzzzzzze_);

                        return zzzzzzzzzzzzf_;
                    };
                    IEnumerable<Money> yzzzzzzzzzzzn_ = context.Operators.Where<Money>(yzzzzzzzzzzzl_, yzzzzzzzzzzzm_);
                    bool? yzzzzzzzzzzzo_ = context.Operators.Exists<Money>(yzzzzzzzzzzzn_);
                    bool? yzzzzzzzzzzzp_ = context.Operators.And(yzzzzzzzzzzzg_, yzzzzzzzzzzzo_);

                    return yzzzzzzzzzzzp_;
                };
                IEnumerable<ClaimResponse.ItemComponent> xzzzzzzzzzzzs_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)xzzzzzzzzzzzq_, xzzzzzzzzzzzr_);
                (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? xzzzzzzzzzzzt_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, xzzzzzzzzzzzp_, xzzzzzzzzzzzs_);

                return xzzzzzzzzzzzt_;
            };
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> xzzzzzzzzzzzk_ = context.Operators.Select<ClaimResponse, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(xzzzzzzzzzzzi_, xzzzzzzzzzzzj_);
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> xzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(xzzzzzzzzzzzk_);

            return xzzzzzzzzzzzl_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> xzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?>)wzzzzzzzzzzzz_, xzzzzzzzzzzza_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> xzzzzzzzzzzzc_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(xzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> xzzzzzzzzzzzd_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(xzzzzzzzzzzzc_);

        return xzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? zzzzzzzzzzzzg_(Claim AllClaims)
        {
            List<Claim.ItemComponent> zzzzzzzzzzzzl_ = AllClaims?.Item;
            bool? zzzzzzzzzzzzm_(Claim.ItemComponent @this)
            {
                CodeableConcept azzzzzzzzzzzzo_ = @this?.ProductOrService;
                bool? azzzzzzzzzzzzp_ = context.Operators.Not((bool?)(azzzzzzzzzzzzo_ is null));

                return azzzzzzzzzzzzp_;
            };
            IEnumerable<Claim.ItemComponent> zzzzzzzzzzzzn_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)zzzzzzzzzzzzl_, zzzzzzzzzzzzm_);
            CodeableConcept zzzzzzzzzzzzo_(Claim.ItemComponent @this)
            {
                CodeableConcept azzzzzzzzzzzzq_ = @this?.ProductOrService;

                return azzzzzzzzzzzzq_;
            };
            IEnumerable<CodeableConcept> zzzzzzzzzzzzp_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(zzzzzzzzzzzzn_, zzzzzzzzzzzzo_);
            bool? zzzzzzzzzzzzq_(CodeableConcept @this)
            {
                List<Coding> azzzzzzzzzzzzr_ = @this?.Coding;
                bool? azzzzzzzzzzzzs_ = context.Operators.Not((bool?)(azzzzzzzzzzzzr_ is null));

                return azzzzzzzzzzzzs_;
            };
            IEnumerable<CodeableConcept> zzzzzzzzzzzzr_ = context.Operators.Where<CodeableConcept>(zzzzzzzzzzzzp_, zzzzzzzzzzzzq_);
            List<Coding> zzzzzzzzzzzzs_(CodeableConcept @this)
            {
                List<Coding> azzzzzzzzzzzzt_ = @this?.Coding;

                return azzzzzzzzzzzzt_;
            };
            IEnumerable<List<Coding>> zzzzzzzzzzzzt_ = context.Operators.Select<CodeableConcept, List<Coding>>(zzzzzzzzzzzzr_, zzzzzzzzzzzzs_);
            IEnumerable<Coding> zzzzzzzzzzzzu_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)zzzzzzzzzzzzt_);
            bool? zzzzzzzzzzzzv_(Coding ProductOrServiceCode)
            {
                CqlCode azzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? azzzzzzzzzzzzv_ = context.Operators.In<CqlCode>(azzzzzzzzzzzzu_, ProductOrServiceValueSet);

                return azzzzzzzzzzzzv_;
            };
            IEnumerable<Coding> zzzzzzzzzzzzw_ = context.Operators.Where<Coding>(zzzzzzzzzzzzu_, zzzzzzzzzzzzv_);
            bool? zzzzzzzzzzzzx_ = context.Operators.Exists<Coding>(zzzzzzzzzzzzw_);
            List<Claim.DiagnosisComponent> zzzzzzzzzzzzy_ = AllClaims?.Diagnosis;
            bool? zzzzzzzzzzzzz_(Claim.DiagnosisComponent @this)
            {
                DataType azzzzzzzzzzzzw_ = @this?.Diagnosis;
                bool? azzzzzzzzzzzzx_ = context.Operators.Not((bool?)(azzzzzzzzzzzzw_ is null));

                return azzzzzzzzzzzzx_;
            };
            IEnumerable<Claim.DiagnosisComponent> azzzzzzzzzzzza_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)zzzzzzzzzzzzy_, zzzzzzzzzzzzz_);
            object azzzzzzzzzzzzb_(Claim.DiagnosisComponent @this)
            {
                DataType azzzzzzzzzzzzy_ = @this?.Diagnosis;

                return azzzzzzzzzzzzy_;
            };
            IEnumerable<object> azzzzzzzzzzzzc_ = context.Operators.Select<Claim.DiagnosisComponent, object>(azzzzzzzzzzzza_, azzzzzzzzzzzzb_);
            bool? azzzzzzzzzzzzd_(object @this)
            {
                object azzzzzzzzzzzzz_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? bzzzzzzzzzzzza_ = context.Operators.Not((bool?)(azzzzzzzzzzzzz_ is null));

                return bzzzzzzzzzzzza_;
            };
            IEnumerable<object> azzzzzzzzzzzze_ = context.Operators.Where<object>(azzzzzzzzzzzzc_, azzzzzzzzzzzzd_);
            object azzzzzzzzzzzzf_(object @this)
            {
                object bzzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return bzzzzzzzzzzzzb_;
            };
            IEnumerable<object> azzzzzzzzzzzzg_ = context.Operators.Select<object, object>(azzzzzzzzzzzze_, azzzzzzzzzzzzf_);
            IEnumerable<object> azzzzzzzzzzzzh_ = context.Operators.FlattenLateBoundList(azzzzzzzzzzzzg_);
            Coding azzzzzzzzzzzzi_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> azzzzzzzzzzzzj_ = context.Operators.Select<object, Coding>(azzzzzzzzzzzzh_, azzzzzzzzzzzzi_);
            bool? azzzzzzzzzzzzk_(Coding DiagnosisCode)
            {
                CqlCode bzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? bzzzzzzzzzzzzd_ = context.Operators.In<CqlCode>(bzzzzzzzzzzzzc_, DiagnosisValueSet);

                return bzzzzzzzzzzzzd_;
            };
            IEnumerable<Coding> azzzzzzzzzzzzl_ = context.Operators.Where<Coding>(azzzzzzzzzzzzj_, azzzzzzzzzzzzk_);
            bool? azzzzzzzzzzzzm_ = context.Operators.Exists<Coding>(azzzzzzzzzzzzl_);
            bool? azzzzzzzzzzzzn_ = context.Operators.And(zzzzzzzzzzzzx_, azzzzzzzzzzzzm_);

            return azzzzzzzzzzzzn_;
        };
        IEnumerable<Claim> zzzzzzzzzzzzh_ = context.Operators.Where<Claim>(claim, zzzzzzzzzzzzg_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? zzzzzzzzzzzzi_(Claim ProcedureClaims)
        {
            Id bzzzzzzzzzzzze_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> bzzzzzzzzzzzzf_ = ProcedureClaims?.Item;
            bool? bzzzzzzzzzzzzg_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept bzzzzzzzzzzzzj_ = ResponseItem?.ProductOrService;
                List<Coding> bzzzzzzzzzzzzk_ = bzzzzzzzzzzzzj_?.Coding;
                bool? bzzzzzzzzzzzzl_(Coding ProductOrServiceCode)
                {
                    CqlCode bzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? bzzzzzzzzzzzzp_ = context.Operators.In<CqlCode>(bzzzzzzzzzzzzo_, ProductOrServiceValueSet);

                    return bzzzzzzzzzzzzp_;
                };
                IEnumerable<Coding> bzzzzzzzzzzzzm_ = context.Operators.Where<Coding>((IEnumerable<Coding>)bzzzzzzzzzzzzk_, bzzzzzzzzzzzzl_);
                bool? bzzzzzzzzzzzzn_ = context.Operators.Exists<Coding>(bzzzzzzzzzzzzm_);

                return bzzzzzzzzzzzzn_;
            };
            IEnumerable<Claim.ItemComponent> bzzzzzzzzzzzzh_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bzzzzzzzzzzzzf_, bzzzzzzzzzzzzg_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bzzzzzzzzzzzzi_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, bzzzzzzzzzzzze_, bzzzzzzzzzzzzh_);

            return bzzzzzzzzzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> zzzzzzzzzzzzj_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(zzzzzzzzzzzzh_, zzzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> zzzzzzzzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(zzzzzzzzzzzzj_);

        return zzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services and Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> bzzzzzzzzzzzzq_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bzzzzzzzzzzzzr_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? bzzzzzzzzzzzzs_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, bzzzzzzzzzzzzq_, bzzzzzzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] bzzzzzzzzzzzzt_ = [
            bzzzzzzzzzzzzs_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzzzzu_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bzzzzzzzzzzzzy_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? bzzzzzzzzzzzzz_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> czzzzzzzzzzzzi_ = medClaim?.LineItems;
                bool? czzzzzzzzzzzzj_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> czzzzzzzzzzzzm_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> czzzzzzzzzzzzn_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> czzzzzzzzzzzzq_ = pClaim?.LineItems;
                        bool? czzzzzzzzzzzzr_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id czzzzzzzzzzzzv_()
                            {
                                bool dzzzzzzzzzzzzj_()
                                {
                                    Claim dzzzzzzzzzzzzk_ = medClaim?.ClaimofInterest;
                                    bool dzzzzzzzzzzzzl_ = dzzzzzzzzzzzzk_ is Resource;

                                    return dzzzzzzzzzzzzl_;
                                };
                                if (dzzzzzzzzzzzzj_())
                                {
                                    Claim dzzzzzzzzzzzzm_ = medClaim?.ClaimofInterest;

                                    return (dzzzzzzzzzzzzm_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string czzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzv_());
                            ClaimResponse czzzzzzzzzzzzx_ = pClaim?.Response;
                            ResourceReference czzzzzzzzzzzzy_ = czzzzzzzzzzzzx_?.Request;
                            FhirString czzzzzzzzzzzzz_ = czzzzzzzzzzzzy_?.ReferenceElement;
                            string dzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, czzzzzzzzzzzzz_);
                            string dzzzzzzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, dzzzzzzzzzzzza_);
                            bool? dzzzzzzzzzzzzc_ = context.Operators.Equal(czzzzzzzzzzzzw_, dzzzzzzzzzzzzb_);
                            PositiveInt dzzzzzzzzzzzzd_ = medClaimLineItem?.SequenceElement;
                            Integer dzzzzzzzzzzzze_ = context.Operators.Convert<Integer>(dzzzzzzzzzzzzd_);
                            PositiveInt dzzzzzzzzzzzzf_ = pClaimLineItem?.ItemSequenceElement;
                            Integer dzzzzzzzzzzzzg_ = context.Operators.Convert<Integer>(dzzzzzzzzzzzzf_);
                            bool? dzzzzzzzzzzzzh_ = context.Operators.Equal(dzzzzzzzzzzzze_, dzzzzzzzzzzzzg_);
                            bool? dzzzzzzzzzzzzi_ = context.Operators.And(dzzzzzzzzzzzzc_, dzzzzzzzzzzzzh_);

                            return dzzzzzzzzzzzzi_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> czzzzzzzzzzzzs_ = context.Operators.Where<ClaimResponse.ItemComponent>(czzzzzzzzzzzzq_, czzzzzzzzzzzzr_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? czzzzzzzzzzzzt_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> czzzzzzzzzzzzu_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(czzzzzzzzzzzzs_, czzzzzzzzzzzzt_);

                        return czzzzzzzzzzzzu_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> czzzzzzzzzzzzo_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(czzzzzzzzzzzzm_, czzzzzzzzzzzzn_);
                    bool? czzzzzzzzzzzzp_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(czzzzzzzzzzzzo_);

                    return czzzzzzzzzzzzp_;
                };
                IEnumerable<Claim.ItemComponent> czzzzzzzzzzzzk_ = context.Operators.Where<Claim.ItemComponent>(czzzzzzzzzzzzi_, czzzzzzzzzzzzj_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? czzzzzzzzzzzzl_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, czzzzzzzzzzzzk_);

                return czzzzzzzzzzzzl_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(bzzzzzzzzzzzzy_, bzzzzzzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> czzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(czzzzzzzzzzzza_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? czzzzzzzzzzzzc_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, czzzzzzzzzzzzb_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] czzzzzzzzzzzzd_ = [
                czzzzzzzzzzzzc_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzzzzze_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzzzn_()
                {
                    bool dzzzzzzzzzzzzs_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> dzzzzzzzzzzzzt_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? dzzzzzzzzzzzzu_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ezzzzzzzzzzzza_ = @this?.ClaimItem;
                            bool? ezzzzzzzzzzzzb_ = context.Operators.Not((bool?)(ezzzzzzzzzzzza_ is null));

                            return ezzzzzzzzzzzzb_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> dzzzzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(dzzzzzzzzzzzzt_, dzzzzzzzzzzzzu_);
                        IEnumerable<Claim.ItemComponent> dzzzzzzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ezzzzzzzzzzzzc_ = @this?.ClaimItem;

                            return ezzzzzzzzzzzzc_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> dzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(dzzzzzzzzzzzzv_, dzzzzzzzzzzzzw_);
                        IEnumerable<Claim.ItemComponent> dzzzzzzzzzzzzy_ = context.Operators.Flatten<Claim.ItemComponent>(dzzzzzzzzzzzzx_);
                        bool? dzzzzzzzzzzzzz_ = context.Operators.Exists<Claim.ItemComponent>(dzzzzzzzzzzzzy_);

                        return dzzzzzzzzzzzzz_ ?? false;
                    };
                    if (dzzzzzzzzzzzzs_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ezzzzzzzzzzzzd_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? ezzzzzzzzzzzze_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ezzzzzzzzzzzzs_ = @this?.PaidClaim;
                            bool? ezzzzzzzzzzzzt_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzs_ is null));

                            return ezzzzzzzzzzzzt_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ezzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ezzzzzzzzzzzzd_, ezzzzzzzzzzzze_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ezzzzzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ezzzzzzzzzzzzu_ = @this?.PaidClaim;

                            return ezzzzzzzzzzzzu_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ezzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(ezzzzzzzzzzzzf_, ezzzzzzzzzzzzg_);
                        bool? ezzzzzzzzzzzzj_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ezzzzzzzzzzzzv_ = @this?.ClaimItem;
                            bool? ezzzzzzzzzzzzw_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzv_ is null));

                            return ezzzzzzzzzzzzw_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ezzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ezzzzzzzzzzzzd_, ezzzzzzzzzzzzj_);
                        IEnumerable<Claim.ItemComponent> ezzzzzzzzzzzzl_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> ezzzzzzzzzzzzx_ = @this?.ClaimItem;

                            return ezzzzzzzzzzzzx_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> ezzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(ezzzzzzzzzzzzk_, ezzzzzzzzzzzzl_);
                        IEnumerable<Claim.ItemComponent> ezzzzzzzzzzzzn_ = context.Operators.Flatten<Claim.ItemComponent>(ezzzzzzzzzzzzm_);
                        CqlInterval<CqlDateTime> ezzzzzzzzzzzzo_(Claim.ItemComponent PaidItem)
                        {
                            DataType ezzzzzzzzzzzzy_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> ezzzzzzzzzzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ezzzzzzzzzzzzy_);

                            return ezzzzzzzzzzzzz_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzp_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzn_, ezzzzzzzzzzzzo_);
                        IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzp_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ezzzzzzzzzzzzr_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, ezzzzzzzzzzzzh_, ezzzzzzzzzzzzq_);

                        return ezzzzzzzzzzzzr_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] dzzzzzzzzzzzzo_ = [
                    dzzzzzzzzzzzzn_(),
                ];
                bool? dzzzzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? fzzzzzzzzzzzza_ = context.Operators.Not((bool?)(FinalList is null));

                    return fzzzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)dzzzzzzzzzzzzo_, dzzzzzzzzzzzzp_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzzzq_);

                return dzzzzzzzzzzzzr_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)czzzzzzzzzzzzd_, czzzzzzzzzzzze_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> czzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzzzzzf_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(czzzzzzzzzzzzg_);

            return czzzzzzzzzzzzh_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)bzzzzzzzzzzzzt_, bzzzzzzzzzzzzu_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzzzzzv_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Service and Condition")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? fzzzzzzzzzzzzb_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] fzzzzzzzzzzzzc_ = [
            fzzzzzzzzzzzzb_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzzzl_()
            {
                bool fzzzzzzzzzzzzm_()
                {
                    IEnumerable<ClaimResponse> fzzzzzzzzzzzzn_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> fzzzzzzzzzzzzo_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? fzzzzzzzzzzzzp_ = context.Operators.And((bool?)(fzzzzzzzzzzzzn_ is null), (bool?)(fzzzzzzzzzzzzo_ is null));

                    return fzzzzzzzzzzzzp_ ?? false;
                };
                if (fzzzzzzzzzzzzm_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> fzzzzzzzzzzzzq_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> fzzzzzzzzzzzzr_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzzzs_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, fzzzzzzzzzzzzq_, fzzzzzzzzzzzzr_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return fzzzzzzzzzzzzs_;
                }
            };

            return fzzzzzzzzzzzzl_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)fzzzzzzzzzzzzc_, fzzzzzzzzzzzzd_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] fzzzzzzzzzzzzh_ = [
            fzzzzzzzzzzzzg_,
        ];
        bool? fzzzzzzzzzzzzi_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
        {
            bool? fzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(FinalList is null));

            return fzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzzzzzzj_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)fzzzzzzzzzzzzh_, fzzzzzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzzzzzzj_);

        return fzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? fzzzzzzzzzzzzu_(Claim AllClaims)
        {
            List<Claim.ItemComponent> fzzzzzzzzzzzzz_ = AllClaims?.Item;
            bool? gzzzzzzzzzzzza_(Claim.ItemComponent @this)
            {
                CodeableConcept hzzzzzzzzzzzzc_ = @this?.ProductOrService;
                bool? hzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzc_ is null));

                return hzzzzzzzzzzzzd_;
            };
            IEnumerable<Claim.ItemComponent> gzzzzzzzzzzzzb_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)fzzzzzzzzzzzzz_, gzzzzzzzzzzzza_);
            CodeableConcept gzzzzzzzzzzzzc_(Claim.ItemComponent @this)
            {
                CodeableConcept hzzzzzzzzzzzze_ = @this?.ProductOrService;

                return hzzzzzzzzzzzze_;
            };
            IEnumerable<CodeableConcept> gzzzzzzzzzzzzd_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(gzzzzzzzzzzzzb_, gzzzzzzzzzzzzc_);
            bool? gzzzzzzzzzzzze_(CodeableConcept @this)
            {
                List<Coding> hzzzzzzzzzzzzf_ = @this?.Coding;
                bool? hzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzf_ is null));

                return hzzzzzzzzzzzzg_;
            };
            IEnumerable<CodeableConcept> gzzzzzzzzzzzzf_ = context.Operators.Where<CodeableConcept>(gzzzzzzzzzzzzd_, gzzzzzzzzzzzze_);
            List<Coding> gzzzzzzzzzzzzg_(CodeableConcept @this)
            {
                List<Coding> hzzzzzzzzzzzzh_ = @this?.Coding;

                return hzzzzzzzzzzzzh_;
            };
            IEnumerable<List<Coding>> gzzzzzzzzzzzzh_ = context.Operators.Select<CodeableConcept, List<Coding>>(gzzzzzzzzzzzzf_, gzzzzzzzzzzzzg_);
            IEnumerable<Coding> gzzzzzzzzzzzzi_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)gzzzzzzzzzzzzh_);
            bool? gzzzzzzzzzzzzj_(Coding ProductOrServiceCode)
            {
                CqlCode hzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? hzzzzzzzzzzzzj_ = context.Operators.In<CqlCode>(hzzzzzzzzzzzzi_, ProductOrServiceValueSet);

                return hzzzzzzzzzzzzj_;
            };
            IEnumerable<Coding> gzzzzzzzzzzzzk_ = context.Operators.Where<Coding>(gzzzzzzzzzzzzi_, gzzzzzzzzzzzzj_);
            bool? gzzzzzzzzzzzzl_ = context.Operators.Exists<Coding>(gzzzzzzzzzzzzk_);
            List<Claim.DiagnosisComponent> gzzzzzzzzzzzzm_ = AllClaims?.Diagnosis;
            bool? gzzzzzzzzzzzzn_(Claim.DiagnosisComponent @this)
            {
                DataType hzzzzzzzzzzzzk_ = @this?.Diagnosis;
                bool? hzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzk_ is null));

                return hzzzzzzzzzzzzl_;
            };
            IEnumerable<Claim.DiagnosisComponent> gzzzzzzzzzzzzo_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)gzzzzzzzzzzzzm_, gzzzzzzzzzzzzn_);
            object gzzzzzzzzzzzzp_(Claim.DiagnosisComponent @this)
            {
                DataType hzzzzzzzzzzzzm_ = @this?.Diagnosis;

                return hzzzzzzzzzzzzm_;
            };
            IEnumerable<object> gzzzzzzzzzzzzq_ = context.Operators.Select<Claim.DiagnosisComponent, object>(gzzzzzzzzzzzzo_, gzzzzzzzzzzzzp_);
            bool? gzzzzzzzzzzzzr_(object @this)
            {
                object hzzzzzzzzzzzzn_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? hzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzn_ is null));

                return hzzzzzzzzzzzzo_;
            };
            IEnumerable<object> gzzzzzzzzzzzzs_ = context.Operators.Where<object>(gzzzzzzzzzzzzq_, gzzzzzzzzzzzzr_);
            object gzzzzzzzzzzzzt_(object @this)
            {
                object hzzzzzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return hzzzzzzzzzzzzp_;
            };
            IEnumerable<object> gzzzzzzzzzzzzu_ = context.Operators.Select<object, object>(gzzzzzzzzzzzzs_, gzzzzzzzzzzzzt_);
            IEnumerable<object> gzzzzzzzzzzzzv_ = context.Operators.FlattenLateBoundList(gzzzzzzzzzzzzu_);
            Coding gzzzzzzzzzzzzw_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> gzzzzzzzzzzzzx_ = context.Operators.Select<object, Coding>(gzzzzzzzzzzzzv_, gzzzzzzzzzzzzw_);
            bool? gzzzzzzzzzzzzy_(Coding DiagnosisCode)
            {
                CqlCode hzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? hzzzzzzzzzzzzr_ = context.Operators.In<CqlCode>(hzzzzzzzzzzzzq_, DiagnosisValueSet);

                return hzzzzzzzzzzzzr_;
            };
            IEnumerable<Coding> gzzzzzzzzzzzzz_ = context.Operators.Where<Coding>(gzzzzzzzzzzzzx_, gzzzzzzzzzzzzy_);
            bool? hzzzzzzzzzzzza_ = context.Operators.Exists<Coding>(gzzzzzzzzzzzzz_);
            bool? hzzzzzzzzzzzzb_ = context.Operators.Or(gzzzzzzzzzzzzl_, hzzzzzzzzzzzza_);

            return hzzzzzzzzzzzzb_;
        };
        IEnumerable<Claim> fzzzzzzzzzzzzv_ = context.Operators.Where<Claim>(claim, fzzzzzzzzzzzzu_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? fzzzzzzzzzzzzw_(Claim ProcedureClaims)
        {
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? hzzzzzzzzzzzzs_()
            {
                bool hzzzzzzzzzzzzt_()
                {
                    List<Claim.ItemComponent> hzzzzzzzzzzzzu_ = ProcedureClaims?.Item;
                    bool? hzzzzzzzzzzzzv_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept hzzzzzzzzzzzzy_ = ResponseItem?.ProductOrService;
                        List<Coding> hzzzzzzzzzzzzz_ = hzzzzzzzzzzzzy_?.Coding;
                        bool? izzzzzzzzzzzza_(Coding ProductOrServiceCode)
                        {
                            CqlCode izzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? izzzzzzzzzzzze_ = context.Operators.In<CqlCode>(izzzzzzzzzzzzd_, ProductOrServiceValueSet);

                            return izzzzzzzzzzzze_;
                        };
                        IEnumerable<Coding> izzzzzzzzzzzzb_ = context.Operators.Where<Coding>((IEnumerable<Coding>)hzzzzzzzzzzzzz_, izzzzzzzzzzzza_);
                        bool? izzzzzzzzzzzzc_ = context.Operators.Exists<Coding>(izzzzzzzzzzzzb_);

                        return izzzzzzzzzzzzc_;
                    };
                    IEnumerable<Claim.ItemComponent> hzzzzzzzzzzzzw_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)hzzzzzzzzzzzzu_, hzzzzzzzzzzzzv_);
                    bool? hzzzzzzzzzzzzx_ = context.Operators.Exists<Claim.ItemComponent>(hzzzzzzzzzzzzw_);

                    return hzzzzzzzzzzzzx_ ?? false;
                };
                if (hzzzzzzzzzzzzt_())
                {
                    Id izzzzzzzzzzzzf_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> izzzzzzzzzzzzg_ = ProcedureClaims?.Item;
                    bool? izzzzzzzzzzzzh_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept izzzzzzzzzzzzk_ = ResponseItem?.ProductOrService;
                        List<Coding> izzzzzzzzzzzzl_ = izzzzzzzzzzzzk_?.Coding;
                        bool? izzzzzzzzzzzzm_(Coding ProductOrServiceCode)
                        {
                            CqlCode izzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? izzzzzzzzzzzzq_ = context.Operators.In<CqlCode>(izzzzzzzzzzzzp_, ProductOrServiceValueSet);

                            return izzzzzzzzzzzzq_;
                        };
                        IEnumerable<Coding> izzzzzzzzzzzzn_ = context.Operators.Where<Coding>((IEnumerable<Coding>)izzzzzzzzzzzzl_, izzzzzzzzzzzzm_);
                        bool? izzzzzzzzzzzzo_ = context.Operators.Exists<Coding>(izzzzzzzzzzzzn_);

                        return izzzzzzzzzzzzo_;
                    };
                    IEnumerable<Claim.ItemComponent> izzzzzzzzzzzzi_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)izzzzzzzzzzzzg_, izzzzzzzzzzzzh_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? izzzzzzzzzzzzj_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, izzzzzzzzzzzzf_, izzzzzzzzzzzzi_);

                    return izzzzzzzzzzzzj_;
                }
                else
                {
                    Id izzzzzzzzzzzzr_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> izzzzzzzzzzzzs_ = ProcedureClaims?.Item;
                    bool? izzzzzzzzzzzzt_(Claim.ItemComponent ResponseItem)
                    {
                        PositiveInt izzzzzzzzzzzzw_ = ResponseItem?.SequenceElement;
                        Integer izzzzzzzzzzzzx_ = context.Operators.Convert<Integer>(izzzzzzzzzzzzw_);
                        int? izzzzzzzzzzzzy_ = izzzzzzzzzzzzx_?.Value;
                        bool? izzzzzzzzzzzzz_ = context.Operators.Equal(izzzzzzzzzzzzy_, 1);

                        return izzzzzzzzzzzzz_;
                    };
                    IEnumerable<Claim.ItemComponent> izzzzzzzzzzzzu_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)izzzzzzzzzzzzs_, izzzzzzzzzzzzt_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? izzzzzzzzzzzzv_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, izzzzzzzzzzzzr_, izzzzzzzzzzzzu_);

                    return izzzzzzzzzzzzv_;
                }
            };

            return hzzzzzzzzzzzzs_();
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> fzzzzzzzzzzzzx_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(fzzzzzzzzzzzzv_, fzzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> fzzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(fzzzzzzzzzzzzx_);

        return fzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzzzzza_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> jzzzzzzzzzzzzb_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? jzzzzzzzzzzzzc_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, jzzzzzzzzzzzza_, jzzzzzzzzzzzzb_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] jzzzzzzzzzzzzd_ = [
            jzzzzzzzzzzzzc_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzzzzze_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> jzzzzzzzzzzzzi_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? jzzzzzzzzzzzzj_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzzs_ = medClaim?.LineItems;
                bool? jzzzzzzzzzzzzt_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzzzzzw_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzzzzzx_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> kzzzzzzzzzzzza_ = pClaim?.LineItems;
                        bool? kzzzzzzzzzzzzb_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id kzzzzzzzzzzzzf_()
                            {
                                bool kzzzzzzzzzzzzt_()
                                {
                                    Claim kzzzzzzzzzzzzu_ = medClaim?.ClaimofInterest;
                                    bool kzzzzzzzzzzzzv_ = kzzzzzzzzzzzzu_ is Resource;

                                    return kzzzzzzzzzzzzv_;
                                };
                                if (kzzzzzzzzzzzzt_())
                                {
                                    Claim kzzzzzzzzzzzzw_ = medClaim?.ClaimofInterest;

                                    return (kzzzzzzzzzzzzw_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string kzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzf_());
                            ClaimResponse kzzzzzzzzzzzzh_ = pClaim?.Response;
                            ResourceReference kzzzzzzzzzzzzi_ = kzzzzzzzzzzzzh_?.Request;
                            FhirString kzzzzzzzzzzzzj_ = kzzzzzzzzzzzzi_?.ReferenceElement;
                            string kzzzzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzj_);
                            string kzzzzzzzzzzzzl_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, kzzzzzzzzzzzzk_);
                            bool? kzzzzzzzzzzzzm_ = context.Operators.Equal(kzzzzzzzzzzzzg_, kzzzzzzzzzzzzl_);
                            PositiveInt kzzzzzzzzzzzzn_ = medClaimLineItem?.SequenceElement;
                            Integer kzzzzzzzzzzzzo_ = context.Operators.Convert<Integer>(kzzzzzzzzzzzzn_);
                            PositiveInt kzzzzzzzzzzzzp_ = pClaimLineItem?.ItemSequenceElement;
                            Integer kzzzzzzzzzzzzq_ = context.Operators.Convert<Integer>(kzzzzzzzzzzzzp_);
                            bool? kzzzzzzzzzzzzr_ = context.Operators.Equal(kzzzzzzzzzzzzo_, kzzzzzzzzzzzzq_);
                            bool? kzzzzzzzzzzzzs_ = context.Operators.And(kzzzzzzzzzzzzm_, kzzzzzzzzzzzzr_);

                            return kzzzzzzzzzzzzs_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> kzzzzzzzzzzzzc_ = context.Operators.Where<ClaimResponse.ItemComponent>(kzzzzzzzzzzzza_, kzzzzzzzzzzzzb_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? kzzzzzzzzzzzzd_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> kzzzzzzzzzzzze_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(kzzzzzzzzzzzzc_, kzzzzzzzzzzzzd_);

                        return kzzzzzzzzzzzze_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> jzzzzzzzzzzzzy_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(jzzzzzzzzzzzzw_, jzzzzzzzzzzzzx_);
                    bool? jzzzzzzzzzzzzz_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(jzzzzzzzzzzzzy_);

                    return jzzzzzzzzzzzzz_;
                };
                IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzzu_ = context.Operators.Where<Claim.ItemComponent>(jzzzzzzzzzzzzs_, jzzzzzzzzzzzzt_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? jzzzzzzzzzzzzv_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, jzzzzzzzzzzzzu_);

                return jzzzzzzzzzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> jzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(jzzzzzzzzzzzzi_, jzzzzzzzzzzzzj_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> jzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(jzzzzzzzzzzzzk_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? jzzzzzzzzzzzzm_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, jzzzzzzzzzzzzl_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] jzzzzzzzzzzzzn_ = [
                jzzzzzzzzzzzzm_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? kzzzzzzzzzzzzx_()
                {
                    bool lzzzzzzzzzzzzc_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzzzzd_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? lzzzzzzzzzzzze_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzzk_ = @this?.ClaimItem;
                            bool? lzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzk_ is null));

                            return lzzzzzzzzzzzzl_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(lzzzzzzzzzzzzd_, lzzzzzzzzzzzze_);
                        IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzzm_ = @this?.ClaimItem;

                            return lzzzzzzzzzzzzm_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> lzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(lzzzzzzzzzzzzf_, lzzzzzzzzzzzzg_);
                        IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzzi_ = context.Operators.Flatten<Claim.ItemComponent>(lzzzzzzzzzzzzh_);
                        bool? lzzzzzzzzzzzzj_ = context.Operators.Exists<Claim.ItemComponent>(lzzzzzzzzzzzzi_);

                        return lzzzzzzzzzzzzj_ ?? false;
                    };
                    if (lzzzzzzzzzzzzc_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzzzzn_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? lzzzzzzzzzzzzo_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? mzzzzzzzzzzzzc_ = @this?.PaidClaim;
                            bool? mzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzc_ is null));

                            return mzzzzzzzzzzzzd_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(lzzzzzzzzzzzzn_, lzzzzzzzzzzzzo_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? lzzzzzzzzzzzzq_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? mzzzzzzzzzzzze_ = @this?.PaidClaim;

                            return mzzzzzzzzzzzze_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> lzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(lzzzzzzzzzzzzp_, lzzzzzzzzzzzzq_);
                        bool? lzzzzzzzzzzzzt_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> mzzzzzzzzzzzzf_ = @this?.ClaimItem;
                            bool? mzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzf_ is null));

                            return mzzzzzzzzzzzzg_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(lzzzzzzzzzzzzn_, lzzzzzzzzzzzzt_);
                        IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzzv_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> mzzzzzzzzzzzzh_ = @this?.ClaimItem;

                            return mzzzzzzzzzzzzh_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> lzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(lzzzzzzzzzzzzu_, lzzzzzzzzzzzzv_);
                        IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzzx_ = context.Operators.Flatten<Claim.ItemComponent>(lzzzzzzzzzzzzw_);
                        CqlInterval<CqlDateTime> lzzzzzzzzzzzzy_(Claim.ItemComponent PaidItem)
                        {
                            DataType mzzzzzzzzzzzzi_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> mzzzzzzzzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, mzzzzzzzzzzzzi_);

                            return mzzzzzzzzzzzzj_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzzzz_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzx_, lzzzzzzzzzzzzy_);
                        IEnumerable<CqlInterval<CqlDateTime>> mzzzzzzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzzzzzzzzz_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzzb_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, lzzzzzzzzzzzzr_, mzzzzzzzzzzzza_);

                        return mzzzzzzzzzzzzb_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] kzzzzzzzzzzzzy_ = [
                    kzzzzzzzzzzzzx_(),
                ];
                bool? kzzzzzzzzzzzzz_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? mzzzzzzzzzzzzk_ = context.Operators.Not((bool?)(FinalList is null));

                    return mzzzzzzzzzzzzk_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)kzzzzzzzzzzzzy_, kzzzzzzzzzzzzz_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? lzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(lzzzzzzzzzzzza_);

                return lzzzzzzzzzzzzb_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)jzzzzzzzzzzzzn_, jzzzzzzzzzzzzo_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzzzzzp_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzzzzzq_);

            return jzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)jzzzzzzzzzzzzd_, jzzzzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> jzzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? jzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(jzzzzzzzzzzzzg_);

        return jzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? mzzzzzzzzzzzzl_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] mzzzzzzzzzzzzm_ = [
            mzzzzzzzzzzzzl_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzzn_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzzr_()
            {
                bool mzzzzzzzzzzzzs_()
                {
                    IEnumerable<ClaimResponse> mzzzzzzzzzzzzt_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> mzzzzzzzzzzzzu_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? mzzzzzzzzzzzzv_ = context.Operators.And((bool?)(mzzzzzzzzzzzzt_ is null), (bool?)(mzzzzzzzzzzzzu_ is null));

                    return mzzzzzzzzzzzzv_ ?? false;
                };
                if (mzzzzzzzzzzzzs_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> mzzzzzzzzzzzzw_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> mzzzzzzzzzzzzx_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzzy_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, mzzzzzzzzzzzzw_, mzzzzzzzzzzzzx_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return mzzzzzzzzzzzzy_;
                }
            };

            return mzzzzzzzzzzzzr_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)mzzzzzzzzzzzzm_, mzzzzzzzzzzzzn_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzzzp_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzzzzzp_);

        return mzzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure Only")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        bool? mzzzzzzzzzzzzz_(Claim AllClaims)
        {
            List<Claim.ItemComponent> nzzzzzzzzzzzze_ = AllClaims?.Item;
            bool? nzzzzzzzzzzzzf_(Claim.ItemComponent @this)
            {
                CodeableConcept nzzzzzzzzzzzzr_ = @this?.ProductOrService;
                bool? nzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzr_ is null));

                return nzzzzzzzzzzzzs_;
            };
            IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzzg_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)nzzzzzzzzzzzze_, nzzzzzzzzzzzzf_);
            CodeableConcept nzzzzzzzzzzzzh_(Claim.ItemComponent @this)
            {
                CodeableConcept nzzzzzzzzzzzzt_ = @this?.ProductOrService;

                return nzzzzzzzzzzzzt_;
            };
            IEnumerable<CodeableConcept> nzzzzzzzzzzzzi_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(nzzzzzzzzzzzzg_, nzzzzzzzzzzzzh_);
            bool? nzzzzzzzzzzzzj_(CodeableConcept @this)
            {
                List<Coding> nzzzzzzzzzzzzu_ = @this?.Coding;
                bool? nzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzu_ is null));

                return nzzzzzzzzzzzzv_;
            };
            IEnumerable<CodeableConcept> nzzzzzzzzzzzzk_ = context.Operators.Where<CodeableConcept>(nzzzzzzzzzzzzi_, nzzzzzzzzzzzzj_);
            List<Coding> nzzzzzzzzzzzzl_(CodeableConcept @this)
            {
                List<Coding> nzzzzzzzzzzzzw_ = @this?.Coding;

                return nzzzzzzzzzzzzw_;
            };
            IEnumerable<List<Coding>> nzzzzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, List<Coding>>(nzzzzzzzzzzzzk_, nzzzzzzzzzzzzl_);
            IEnumerable<Coding> nzzzzzzzzzzzzn_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)nzzzzzzzzzzzzm_);
            bool? nzzzzzzzzzzzzo_(Coding ProductOrServiceCode)
            {
                CqlCode nzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? nzzzzzzzzzzzzy_ = context.Operators.In<CqlCode>(nzzzzzzzzzzzzx_, ProductOrServiceValueSet);

                return nzzzzzzzzzzzzy_;
            };
            IEnumerable<Coding> nzzzzzzzzzzzzp_ = context.Operators.Where<Coding>(nzzzzzzzzzzzzn_, nzzzzzzzzzzzzo_);
            bool? nzzzzzzzzzzzzq_ = context.Operators.Exists<Coding>(nzzzzzzzzzzzzp_);

            return nzzzzzzzzzzzzq_;
        };
        IEnumerable<Claim> nzzzzzzzzzzzza_ = context.Operators.Where<Claim>(claim, mzzzzzzzzzzzzz_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? nzzzzzzzzzzzzb_(Claim AllClaims)
        {
            Id nzzzzzzzzzzzzz_ = AllClaims?.IdElement;
            List<Claim.ItemComponent> ozzzzzzzzzzzza_ = AllClaims?.Item;
            bool? ozzzzzzzzzzzzb_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept ozzzzzzzzzzzze_ = ResponseItem?.ProductOrService;
                List<Coding> ozzzzzzzzzzzzf_ = ozzzzzzzzzzzze_?.Coding;
                bool? ozzzzzzzzzzzzg_(Coding ProductOrServiceCode)
                {
                    CqlCode ozzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? ozzzzzzzzzzzzk_ = context.Operators.In<CqlCode>(ozzzzzzzzzzzzj_, ProductOrServiceValueSet);

                    return ozzzzzzzzzzzzk_;
                };
                IEnumerable<Coding> ozzzzzzzzzzzzh_ = context.Operators.Where<Coding>((IEnumerable<Coding>)ozzzzzzzzzzzzf_, ozzzzzzzzzzzzg_);
                bool? ozzzzzzzzzzzzi_ = context.Operators.Exists<Coding>(ozzzzzzzzzzzzh_);

                return ozzzzzzzzzzzzi_;
            };
            IEnumerable<Claim.ItemComponent> ozzzzzzzzzzzzc_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ozzzzzzzzzzzza_, ozzzzzzzzzzzzb_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ozzzzzzzzzzzzd_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, nzzzzzzzzzzzzz_, ozzzzzzzzzzzzc_);

            return ozzzzzzzzzzzzd_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> nzzzzzzzzzzzzc_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(nzzzzzzzzzzzza_, nzzzzzzzzzzzzb_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> nzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(nzzzzzzzzzzzzc_);

        return nzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ozzzzzzzzzzzzl_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ozzzzzzzzzzzzm_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ozzzzzzzzzzzzn_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, ozzzzzzzzzzzzl_, ozzzzzzzzzzzzm_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] ozzzzzzzzzzzzo_ = [
            ozzzzzzzzzzzzn_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ozzzzzzzzzzzzt_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? ozzzzzzzzzzzzu_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> pzzzzzzzzzzzzd_ = medClaim?.LineItems;
                bool? pzzzzzzzzzzzze_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> pzzzzzzzzzzzzh_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> pzzzzzzzzzzzzi_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> pzzzzzzzzzzzzl_ = pClaim?.LineItems;
                        bool? pzzzzzzzzzzzzm_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id pzzzzzzzzzzzzq_()
                            {
                                bool qzzzzzzzzzzzze_()
                                {
                                    Claim qzzzzzzzzzzzzf_ = medClaim?.ClaimofInterest;
                                    bool qzzzzzzzzzzzzg_ = qzzzzzzzzzzzzf_ is Resource;

                                    return qzzzzzzzzzzzzg_;
                                };
                                if (qzzzzzzzzzzzze_())
                                {
                                    Claim qzzzzzzzzzzzzh_ = medClaim?.ClaimofInterest;

                                    return (qzzzzzzzzzzzzh_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string pzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzq_());
                            ClaimResponse pzzzzzzzzzzzzs_ = pClaim?.Response;
                            ResourceReference pzzzzzzzzzzzzt_ = pzzzzzzzzzzzzs_?.Request;
                            FhirString pzzzzzzzzzzzzu_ = pzzzzzzzzzzzzt_?.ReferenceElement;
                            string pzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, pzzzzzzzzzzzzu_);
                            string pzzzzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, pzzzzzzzzzzzzv_);
                            bool? pzzzzzzzzzzzzx_ = context.Operators.Equal(pzzzzzzzzzzzzr_, pzzzzzzzzzzzzw_);
                            PositiveInt pzzzzzzzzzzzzy_ = medClaimLineItem?.SequenceElement;
                            Integer pzzzzzzzzzzzzz_ = context.Operators.Convert<Integer>(pzzzzzzzzzzzzy_);
                            PositiveInt qzzzzzzzzzzzza_ = pClaimLineItem?.ItemSequenceElement;
                            Integer qzzzzzzzzzzzzb_ = context.Operators.Convert<Integer>(qzzzzzzzzzzzza_);
                            bool? qzzzzzzzzzzzzc_ = context.Operators.Equal(pzzzzzzzzzzzzz_, qzzzzzzzzzzzzb_);
                            bool? qzzzzzzzzzzzzd_ = context.Operators.And(pzzzzzzzzzzzzx_, qzzzzzzzzzzzzc_);

                            return qzzzzzzzzzzzzd_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> pzzzzzzzzzzzzn_ = context.Operators.Where<ClaimResponse.ItemComponent>(pzzzzzzzzzzzzl_, pzzzzzzzzzzzzm_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pzzzzzzzzzzzzo_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> pzzzzzzzzzzzzp_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(pzzzzzzzzzzzzn_, pzzzzzzzzzzzzo_);

                        return pzzzzzzzzzzzzp_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> pzzzzzzzzzzzzj_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(pzzzzzzzzzzzzh_, pzzzzzzzzzzzzi_);
                    bool? pzzzzzzzzzzzzk_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(pzzzzzzzzzzzzj_);

                    return pzzzzzzzzzzzzk_;
                };
                IEnumerable<Claim.ItemComponent> pzzzzzzzzzzzzf_ = context.Operators.Where<Claim.ItemComponent>(pzzzzzzzzzzzzd_, pzzzzzzzzzzzze_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? pzzzzzzzzzzzzg_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, pzzzzzzzzzzzzf_);

                return pzzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ozzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ozzzzzzzzzzzzt_, ozzzzzzzzzzzzu_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> ozzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(ozzzzzzzzzzzzv_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ozzzzzzzzzzzzx_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, ozzzzzzzzzzzzw_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] ozzzzzzzzzzzzy_ = [
                ozzzzzzzzzzzzx_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzzzz_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzzzi_()
                {
                    bool qzzzzzzzzzzzzn_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzzzzzo_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? qzzzzzzzzzzzzp_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> qzzzzzzzzzzzzv_ = @this?.ClaimItem;
                            bool? qzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzv_ is null));

                            return qzzzzzzzzzzzzw_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(qzzzzzzzzzzzzo_, qzzzzzzzzzzzzp_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> qzzzzzzzzzzzzx_ = @this?.ClaimItem;

                            return qzzzzzzzzzzzzx_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> qzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(qzzzzzzzzzzzzq_, qzzzzzzzzzzzzr_);
                        IEnumerable<Claim.ItemComponent> qzzzzzzzzzzzzt_ = context.Operators.Flatten<Claim.ItemComponent>(qzzzzzzzzzzzzs_);
                        bool? qzzzzzzzzzzzzu_ = context.Operators.Exists<Claim.ItemComponent>(qzzzzzzzzzzzzt_);

                        return qzzzzzzzzzzzzu_ ?? false;
                    };
                    if (qzzzzzzzzzzzzn_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzzzzzy_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? qzzzzzzzzzzzzz_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? rzzzzzzzzzzzzn_ = @this?.PaidClaim;
                            bool? rzzzzzzzzzzzzo_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzn_ is null));

                            return rzzzzzzzzzzzzo_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> rzzzzzzzzzzzza_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(qzzzzzzzzzzzzy_, qzzzzzzzzzzzzz_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? rzzzzzzzzzzzzb_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? rzzzzzzzzzzzzp_ = @this?.PaidClaim;

                            return rzzzzzzzzzzzzp_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> rzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(rzzzzzzzzzzzza_, rzzzzzzzzzzzzb_);
                        bool? rzzzzzzzzzzzze_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> rzzzzzzzzzzzzq_ = @this?.ClaimItem;
                            bool? rzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzq_ is null));

                            return rzzzzzzzzzzzzr_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> rzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(qzzzzzzzzzzzzy_, rzzzzzzzzzzzze_);
                        IEnumerable<Claim.ItemComponent> rzzzzzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> rzzzzzzzzzzzzs_ = @this?.ClaimItem;

                            return rzzzzzzzzzzzzs_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> rzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(rzzzzzzzzzzzzf_, rzzzzzzzzzzzzg_);
                        IEnumerable<Claim.ItemComponent> rzzzzzzzzzzzzi_ = context.Operators.Flatten<Claim.ItemComponent>(rzzzzzzzzzzzzh_);
                        CqlInterval<CqlDateTime> rzzzzzzzzzzzzj_(Claim.ItemComponent PaidItem)
                        {
                            DataType rzzzzzzzzzzzzt_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> rzzzzzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, rzzzzzzzzzzzzt_);

                            return rzzzzzzzzzzzzu_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzzzk_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(rzzzzzzzzzzzzi_, rzzzzzzzzzzzzj_);
                        IEnumerable<CqlInterval<CqlDateTime>> rzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(rzzzzzzzzzzzzk_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzzzzzm_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, rzzzzzzzzzzzzc_, rzzzzzzzzzzzzl_);

                        return rzzzzzzzzzzzzm_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] qzzzzzzzzzzzzj_ = [
                    qzzzzzzzzzzzzi_(),
                ];
                bool? qzzzzzzzzzzzzk_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? rzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(FinalList is null));

                    return rzzzzzzzzzzzzv_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzzzzzzl_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)qzzzzzzzzzzzzj_, qzzzzzzzzzzzzk_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzzzzzzl_);

                return qzzzzzzzzzzzzm_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)ozzzzzzzzzzzzy_, ozzzzzzzzzzzzz_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> pzzzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzzzzzzza_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? pzzzzzzzzzzzzc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(pzzzzzzzzzzzzb_);

            return pzzzzzzzzzzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)ozzzzzzzzzzzzo_, ozzzzzzzzzzzzp_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzzzs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzzzzzr_);

        return ozzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? rzzzzzzzzzzzzw_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] rzzzzzzzzzzzzx_ = [
            rzzzzzzzzzzzzw_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzzzzzy_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzzc_()
            {
                bool szzzzzzzzzzzzd_()
                {
                    IEnumerable<ClaimResponse> szzzzzzzzzzzze_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> szzzzzzzzzzzzf_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? szzzzzzzzzzzzg_ = context.Operators.And((bool?)(szzzzzzzzzzzze_ is null), (bool?)(szzzzzzzzzzzzf_ is null));

                    return szzzzzzzzzzzzg_ ?? false;
                };
                if (szzzzzzzzzzzzd_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> szzzzzzzzzzzzh_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> szzzzzzzzzzzzi_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzzj_ = this.Get_Corresponding_Claim_for_Services_Only(context, szzzzzzzzzzzzh_, szzzzzzzzzzzzi_, ProductOrServiceValueSet);

                    return szzzzzzzzzzzzj_;
                }
            };

            return szzzzzzzzzzzzc_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)rzzzzzzzzzzzzx_, rzzzzzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzzzzzz_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzzzzzza_);

        return szzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Get All Pharmacy Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> szzzzzzzzzzzzk_ = this.Pharmacy_Claims_Response(context, claimResponse);
        IEnumerable<Claim> szzzzzzzzzzzzl_ = this.Pharmacy_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? szzzzzzzzzzzzm_ = (CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV, szzzzzzzzzzzzk_, szzzzzzzzzzzzl_);

        return szzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> szzzzzzzzzzzzn_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> szzzzzzzzzzzzo_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? szzzzzzzzzzzzp_ = (CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF, szzzzzzzzzzzzn_, szzzzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[] szzzzzzzzzzzzq_ = [
            szzzzzzzzzzzzp_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? szzzzzzzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> szzzzzzzzzzzzv_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? szzzzzzzzzzzzw_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> tzzzzzzzzzzzzf_ = medClaim?.LineItem;
                bool? tzzzzzzzzzzzzg_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> tzzzzzzzzzzzzj_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> tzzzzzzzzzzzzk_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> tzzzzzzzzzzzzn_ = pClaim?.LineItems;
                        bool? tzzzzzzzzzzzzo_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id tzzzzzzzzzzzzs_()
                            {
                                bool uzzzzzzzzzzzzg_()
                                {
                                    Claim uzzzzzzzzzzzzh_ = medClaim?.Claim;
                                    bool uzzzzzzzzzzzzi_ = uzzzzzzzzzzzzh_ is Resource;

                                    return uzzzzzzzzzzzzi_;
                                };
                                if (uzzzzzzzzzzzzg_())
                                {
                                    Claim uzzzzzzzzzzzzj_ = medClaim?.Claim;

                                    return (uzzzzzzzzzzzzj_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string tzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzzs_());
                            ClaimResponse tzzzzzzzzzzzzu_ = pClaim?.Response;
                            ResourceReference tzzzzzzzzzzzzv_ = tzzzzzzzzzzzzu_?.Request;
                            FhirString tzzzzzzzzzzzzw_ = tzzzzzzzzzzzzv_?.ReferenceElement;
                            string tzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, tzzzzzzzzzzzzw_);
                            string tzzzzzzzzzzzzy_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, tzzzzzzzzzzzzx_);
                            bool? tzzzzzzzzzzzzz_ = context.Operators.Equal(tzzzzzzzzzzzzt_, tzzzzzzzzzzzzy_);
                            PositiveInt uzzzzzzzzzzzza_ = medClaimLineItem?.SequenceElement;
                            Integer uzzzzzzzzzzzzb_ = context.Operators.Convert<Integer>(uzzzzzzzzzzzza_);
                            PositiveInt uzzzzzzzzzzzzc_ = pClaimLineItem?.ItemSequenceElement;
                            Integer uzzzzzzzzzzzzd_ = context.Operators.Convert<Integer>(uzzzzzzzzzzzzc_);
                            bool? uzzzzzzzzzzzze_ = context.Operators.Equal(uzzzzzzzzzzzzb_, uzzzzzzzzzzzzd_);
                            bool? uzzzzzzzzzzzzf_ = context.Operators.And(tzzzzzzzzzzzzz_, uzzzzzzzzzzzze_);

                            return uzzzzzzzzzzzzf_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> tzzzzzzzzzzzzp_ = context.Operators.Where<ClaimResponse.ItemComponent>(tzzzzzzzzzzzzn_, tzzzzzzzzzzzzo_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? tzzzzzzzzzzzzq_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> tzzzzzzzzzzzzr_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(tzzzzzzzzzzzzp_, tzzzzzzzzzzzzq_);

                        return tzzzzzzzzzzzzr_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> tzzzzzzzzzzzzl_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(tzzzzzzzzzzzzj_, tzzzzzzzzzzzzk_);
                    bool? tzzzzzzzzzzzzm_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(tzzzzzzzzzzzzl_);

                    return tzzzzzzzzzzzzm_;
                };
                IEnumerable<Claim.ItemComponent> tzzzzzzzzzzzzh_ = context.Operators.Where<Claim.ItemComponent>(tzzzzzzzzzzzzf_, tzzzzzzzzzzzzg_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? tzzzzzzzzzzzzi_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, tzzzzzzzzzzzzh_);

                return tzzzzzzzzzzzzi_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> szzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(szzzzzzzzzzzzv_, szzzzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> szzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(szzzzzzzzzzzzx_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? szzzzzzzzzzzzz_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, szzzzzzzzzzzzy_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] tzzzzzzzzzzzza_ = [
                szzzzzzzzzzzzz_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? tzzzzzzzzzzzzb_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? uzzzzzzzzzzzzk_()
                {
                    bool uzzzzzzzzzzzzp_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> uzzzzzzzzzzzzq_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? uzzzzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> uzzzzzzzzzzzzx_ = @this?.ClaimItem;
                            bool? uzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(uzzzzzzzzzzzzx_ is null));

                            return uzzzzzzzzzzzzy_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> uzzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(uzzzzzzzzzzzzq_, uzzzzzzzzzzzzr_);
                        IEnumerable<Claim.ItemComponent> uzzzzzzzzzzzzt_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> uzzzzzzzzzzzzz_ = @this?.ClaimItem;

                            return uzzzzzzzzzzzzz_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> uzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(uzzzzzzzzzzzzs_, uzzzzzzzzzzzzt_);
                        IEnumerable<Claim.ItemComponent> uzzzzzzzzzzzzv_ = context.Operators.Flatten<Claim.ItemComponent>(uzzzzzzzzzzzzu_);
                        bool? uzzzzzzzzzzzzw_ = context.Operators.Exists<Claim.ItemComponent>(uzzzzzzzzzzzzv_);

                        return uzzzzzzzzzzzzw_ ?? false;
                    };
                    if (uzzzzzzzzzzzzp_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzzzzza_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? vzzzzzzzzzzzzb_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? vzzzzzzzzzzzzy_ = @this?.PaidClaim;
                            bool? vzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(vzzzzzzzzzzzzy_ is null));

                            return vzzzzzzzzzzzzz_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(vzzzzzzzzzzzza_, vzzzzzzzzzzzzb_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? vzzzzzzzzzzzzd_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? wzzzzzzzzzzzza_ = @this?.PaidClaim;

                            return wzzzzzzzzzzzza_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> vzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(vzzzzzzzzzzzzc_, vzzzzzzzzzzzzd_);
                        bool? vzzzzzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzzb_ = @this?.ClaimItem;
                            bool? wzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzb_ is null));

                            return wzzzzzzzzzzzzc_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(vzzzzzzzzzzzza_, vzzzzzzzzzzzzg_);
                        IEnumerable<Claim.ItemComponent> vzzzzzzzzzzzzi_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzzd_ = @this?.ClaimItem;

                            return wzzzzzzzzzzzzd_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> vzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(vzzzzzzzzzzzzh_, vzzzzzzzzzzzzi_);
                        IEnumerable<Claim.ItemComponent> vzzzzzzzzzzzzk_ = context.Operators.Flatten<Claim.ItemComponent>(vzzzzzzzzzzzzj_);
                        CqlInterval<CqlDateTime> vzzzzzzzzzzzzl_(Claim.ItemComponent PaidItem)
                        {
                            DataType wzzzzzzzzzzzze_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> wzzzzzzzzzzzzf_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzze_);

                            return wzzzzzzzzzzzzf_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzm_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzk_, vzzzzzzzzzzzzl_);
                        IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(vzzzzzzzzzzzzm_);
                        bool? vzzzzzzzzzzzzp_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzzg_ = @this?.ClaimItem;
                            bool? wzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzg_ is null));

                            return wzzzzzzzzzzzzh_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> vzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(vzzzzzzzzzzzza_, vzzzzzzzzzzzzp_);
                        IEnumerable<Claim.ItemComponent> vzzzzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzzi_ = @this?.ClaimItem;

                            return wzzzzzzzzzzzzi_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> vzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(vzzzzzzzzzzzzq_, vzzzzzzzzzzzzr_);
                        IEnumerable<Claim.ItemComponent> vzzzzzzzzzzzzt_ = context.Operators.Flatten<Claim.ItemComponent>(vzzzzzzzzzzzzs_);
                        CqlInterval<CqlDate> vzzzzzzzzzzzzu_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDate> wzzzzzzzzzzzzj_()
                            {
                                bool wzzzzzzzzzzzzk_()
                                {
                                    Quantity wzzzzzzzzzzzzl_ = i?.Quantity;
                                    bool? wzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(wzzzzzzzzzzzzl_ is null));

                                    return wzzzzzzzzzzzzm_ ?? false;
                                };
                                if (wzzzzzzzzzzzzk_())
                                {
                                    DataType wzzzzzzzzzzzzn_ = i?.Serviced;
                                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzzn_);
                                    CqlDateTime wzzzzzzzzzzzzp_ = context.Operators.Start(wzzzzzzzzzzzzo_);
                                    CqlDate wzzzzzzzzzzzzq_ = context.Operators.ConvertDateTimeToDate(wzzzzzzzzzzzzp_);
                                    CqlInterval<CqlDateTime> wzzzzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, wzzzzzzzzzzzzn_);
                                    CqlDateTime wzzzzzzzzzzzzt_ = context.Operators.Start(wzzzzzzzzzzzzs_);
                                    Quantity wzzzzzzzzzzzzu_ = i?.Quantity;
                                    FhirDecimal wzzzzzzzzzzzzv_ = wzzzzzzzzzzzzu_?.ValueElement;
                                    decimal? wzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, wzzzzzzzzzzzzv_);
                                    CqlDateTime wzzzzzzzzzzzzx_ = context.Operators.Add(wzzzzzzzzzzzzt_, new CqlQuantity(wzzzzzzzzzzzzw_, "day"));
                                    CqlQuantity wzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime wzzzzzzzzzzzzz_ = context.Operators.Subtract(wzzzzzzzzzzzzx_, wzzzzzzzzzzzzy_);
                                    CqlDate xzzzzzzzzzzzza_ = context.Operators.ConvertDateTimeToDate(wzzzzzzzzzzzzz_);
                                    CqlInterval<CqlDate> xzzzzzzzzzzzzb_ = context.Operators.Interval(wzzzzzzzzzzzzq_, xzzzzzzzzzzzza_, true, true);

                                    return xzzzzzzzzzzzzb_;
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDate>;
                                }
                            };

                            return wzzzzzzzzzzzzj_();
                        };
                        IEnumerable<CqlInterval<CqlDate>> vzzzzzzzzzzzzv_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(vzzzzzzzzzzzzt_, vzzzzzzzzzzzzu_);
                        IEnumerable<CqlInterval<CqlDate>> vzzzzzzzzzzzzw_ = context.Operators.Distinct<CqlInterval<CqlDate>>(vzzzzzzzzzzzzv_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? vzzzzzzzzzzzzx_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, vzzzzzzzzzzzze_, vzzzzzzzzzzzzn_, vzzzzzzzzzzzzw_);

                        return vzzzzzzzzzzzzx_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] uzzzzzzzzzzzzl_ = [
                    uzzzzzzzzzzzzk_(),
                ];
                bool? uzzzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList)
                {
                    bool? xzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(FinalList is null));

                    return xzzzzzzzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> uzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)uzzzzzzzzzzzzl_, uzzzzzzzzzzzzm_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? uzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(uzzzzzzzzzzzzn_);

                return uzzzzzzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> tzzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)tzzzzzzzzzzzza_, tzzzzzzzzzzzzb_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> tzzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(tzzzzzzzzzzzzc_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? tzzzzzzzzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(tzzzzzzzzzzzzd_);

            return tzzzzzzzzzzzze_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> szzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)szzzzzzzzzzzzq_, szzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> szzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(szzzzzzzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? szzzzzzzzzzzzu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(szzzzzzzzzzzzt_);

        return szzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? xzzzzzzzzzzzzd_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] xzzzzzzzzzzzze_ = [
            xzzzzzzzzzzzzd_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? xzzzzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? xzzzzzzzzzzzzj_()
            {
                bool xzzzzzzzzzzzzk_()
                {
                    IEnumerable<ClaimResponse> xzzzzzzzzzzzzl_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> xzzzzzzzzzzzzm_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    bool? xzzzzzzzzzzzzn_ = context.Operators.And((bool?)(xzzzzzzzzzzzzl_ is null), (bool?)(xzzzzzzzzzzzzm_ is null));

                    return xzzzzzzzzzzzzn_ ?? false;
                };
                if (xzzzzzzzzzzzzk_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> xzzzzzzzzzzzzo_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> xzzzzzzzzzzzzp_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? xzzzzzzzzzzzzq_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, xzzzzzzzzzzzzo_, xzzzzzzzzzzzzp_, ProductOrServiceValueSet);

                    return xzzzzzzzzzzzzq_;
                }
            };

            return xzzzzzzzzzzzzj_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> xzzzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)xzzzzzzzzzzzze_, xzzzzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> xzzzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(xzzzzzzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? xzzzzzzzzzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(xzzzzzzzzzzzzh_);

        return xzzzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Get Claim With Corresponding Claim Response")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? xzzzzzzzzzzzzr_(Claim Claim)
        {
            bool? xzzzzzzzzzzzzu_(ClaimResponse CR)
            {
                Id xzzzzzzzzzzzzz_ = Claim?.IdElement;
                string yzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, xzzzzzzzzzzzzz_);
                ResourceReference yzzzzzzzzzzzzb_ = CR?.Request;
                FhirString yzzzzzzzzzzzzc_ = yzzzzzzzzzzzzb_?.ReferenceElement;
                string yzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzc_);
                string yzzzzzzzzzzzze_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, yzzzzzzzzzzzzd_);
                bool? yzzzzzzzzzzzzf_ = context.Operators.Equal(yzzzzzzzzzzzza_, yzzzzzzzzzzzze_);

                return yzzzzzzzzzzzzf_;
            };
            IEnumerable<ClaimResponse> xzzzzzzzzzzzzv_ = context.Operators.Where<ClaimResponse>(claimResponse, xzzzzzzzzzzzzu_);
            bool? xzzzzzzzzzzzzw_(Claim C)
            {
                Id yzzzzzzzzzzzzg_ = Claim?.IdElement;
                string yzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzg_);
                bool? yzzzzzzzzzzzzi_(ClaimResponse CR)
                {
                    Id yzzzzzzzzzzzzw_ = Claim?.IdElement;
                    string yzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzw_);
                    ResourceReference yzzzzzzzzzzzzy_ = CR?.Request;
                    FhirString yzzzzzzzzzzzzz_ = yzzzzzzzzzzzzy_?.ReferenceElement;
                    string zzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzz_);
                    string zzzzzzzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, zzzzzzzzzzzzza_);
                    bool? zzzzzzzzzzzzzc_ = context.Operators.Equal(yzzzzzzzzzzzzx_, zzzzzzzzzzzzzb_);

                    return zzzzzzzzzzzzzc_;
                };
                IEnumerable<ClaimResponse> yzzzzzzzzzzzzj_ = context.Operators.Where<ClaimResponse>(claimResponse, yzzzzzzzzzzzzi_);
                bool? yzzzzzzzzzzzzk_(ClaimResponse @this)
                {
                    ResourceReference zzzzzzzzzzzzzd_ = @this?.Request;
                    bool? zzzzzzzzzzzzze_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzd_ is null));

                    return zzzzzzzzzzzzze_;
                };
                IEnumerable<ClaimResponse> yzzzzzzzzzzzzl_ = context.Operators.Where<ClaimResponse>(yzzzzzzzzzzzzj_, yzzzzzzzzzzzzk_);
                ResourceReference yzzzzzzzzzzzzm_(ClaimResponse @this)
                {
                    ResourceReference zzzzzzzzzzzzzf_ = @this?.Request;

                    return zzzzzzzzzzzzzf_;
                };
                IEnumerable<ResourceReference> yzzzzzzzzzzzzn_ = context.Operators.Select<ClaimResponse, ResourceReference>(yzzzzzzzzzzzzl_, yzzzzzzzzzzzzm_);
                bool? yzzzzzzzzzzzzo_(ResourceReference @this)
                {
                    FhirString zzzzzzzzzzzzzg_ = @this?.ReferenceElement;
                    bool? zzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(zzzzzzzzzzzzzg_ is null));

                    return zzzzzzzzzzzzzh_;
                };
                IEnumerable<ResourceReference> yzzzzzzzzzzzzp_ = context.Operators.Where<ResourceReference>(yzzzzzzzzzzzzn_, yzzzzzzzzzzzzo_);
                FhirString yzzzzzzzzzzzzq_(ResourceReference @this)
                {
                    FhirString zzzzzzzzzzzzzi_ = @this?.ReferenceElement;

                    return zzzzzzzzzzzzzi_;
                };
                IEnumerable<FhirString> yzzzzzzzzzzzzr_ = context.Operators.Select<ResourceReference, FhirString>(yzzzzzzzzzzzzp_, yzzzzzzzzzzzzq_);
                FhirString yzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<FhirString>(yzzzzzzzzzzzzr_);
                string yzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzzzs_);
                string yzzzzzzzzzzzzu_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, yzzzzzzzzzzzzt_);
                bool? yzzzzzzzzzzzzv_ = context.Operators.Equal(yzzzzzzzzzzzzh_, yzzzzzzzzzzzzu_);

                return yzzzzzzzzzzzzv_;
            };
            IEnumerable<Claim> xzzzzzzzzzzzzx_ = context.Operators.Where<Claim>(claim, xzzzzzzzzzzzzw_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? xzzzzzzzzzzzzy_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, xzzzzzzzzzzzzv_, xzzzzzzzzzzzzx_);

            return xzzzzzzzzzzzzy_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> xzzzzzzzzzzzzs_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, xzzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> xzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(xzzzzzzzzzzzzs_);

        return xzzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim> claim)
    {
        IEnumerable<Claim> zzzzzzzzzzzzzj_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? zzzzzzzzzzzzzk_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, zzzzzzzzzzzzzj_, default, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] zzzzzzzzzzzzzl_ = [
            zzzzzzzzzzzzzk_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? zzzzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithInpatientStay)
        {
            IEnumerable<Claim> zzzzzzzzzzzzzq_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> zzzzzzzzzzzzzy_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? zzzzzzzzzzzzzz_(Claim c)
                    {
                        List<Claim.ItemComponent> azzzzzzzzzzzzzb_ = c?.Item;
                        bool? azzzzzzzzzzzzzc_(Claim.ItemComponent i)
                        {
                            CodeableConcept azzzzzzzzzzzzzf_ = i?.Revenue;
                            CqlConcept azzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, azzzzzzzzzzzzzf_);
                            CqlCode[] azzzzzzzzzzzzzh_ = azzzzzzzzzzzzzg_?.codes;
                            bool? azzzzzzzzzzzzzi_(CqlCode rev)
                            {
                                string azzzzzzzzzzzzzl_ = rev?.code;
                                CqlValueSet azzzzzzzzzzzzzm_ = this.Inpatient_Stay(context);
                                bool? azzzzzzzzzzzzzn_ = context.Operators.StringInValueSet(azzzzzzzzzzzzzl_, azzzzzzzzzzzzzm_);

                                return azzzzzzzzzzzzzn_;
                            };
                            IEnumerable<CqlCode> azzzzzzzzzzzzzj_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)azzzzzzzzzzzzzh_, azzzzzzzzzzzzzi_);
                            bool? azzzzzzzzzzzzzk_ = context.Operators.Exists<CqlCode>(azzzzzzzzzzzzzj_);

                            return azzzzzzzzzzzzzk_;
                        };
                        IEnumerable<Claim.ItemComponent> azzzzzzzzzzzzzd_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)azzzzzzzzzzzzzb_, azzzzzzzzzzzzzc_);
                        bool? azzzzzzzzzzzzze_ = context.Operators.Exists<Claim.ItemComponent>(azzzzzzzzzzzzzd_);

                        return azzzzzzzzzzzzze_;
                    };
                    IEnumerable<Claim> azzzzzzzzzzzzza_ = context.Operators.Where<Claim>(zzzzzzzzzzzzzy_, zzzzzzzzzzzzzz_);

                    return azzzzzzzzzzzzza_;
                }
            };
            IEnumerable<Claim> zzzzzzzzzzzzzr_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> azzzzzzzzzzzzzo_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? azzzzzzzzzzzzzp_(Claim c)
                    {
                        List<Claim.ItemComponent> azzzzzzzzzzzzzr_ = c?.Item;
                        bool? azzzzzzzzzzzzzs_(Claim.ItemComponent i)
                        {
                            CodeableConcept bzzzzzzzzzzzzzb_ = i?.Revenue;
                            CqlConcept bzzzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bzzzzzzzzzzzzzb_);
                            CqlCode[] bzzzzzzzzzzzzzd_ = bzzzzzzzzzzzzzc_?.codes;
                            bool? bzzzzzzzzzzzzze_(CqlCode rev)
                            {
                                string bzzzzzzzzzzzzzh_ = rev?.code;
                                CqlValueSet bzzzzzzzzzzzzzi_ = this.Nonacute_Inpatient_Stay(context);
                                bool? bzzzzzzzzzzzzzj_ = context.Operators.StringInValueSet(bzzzzzzzzzzzzzh_, bzzzzzzzzzzzzzi_);

                                return bzzzzzzzzzzzzzj_;
                            };
                            IEnumerable<CqlCode> bzzzzzzzzzzzzzf_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)bzzzzzzzzzzzzzd_, bzzzzzzzzzzzzze_);
                            bool? bzzzzzzzzzzzzzg_ = context.Operators.Exists<CqlCode>(bzzzzzzzzzzzzzf_);

                            return bzzzzzzzzzzzzzg_;
                        };
                        IEnumerable<Claim.ItemComponent> azzzzzzzzzzzzzt_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)azzzzzzzzzzzzzr_, azzzzzzzzzzzzzs_);
                        bool? azzzzzzzzzzzzzu_ = context.Operators.Exists<Claim.ItemComponent>(azzzzzzzzzzzzzt_);
                        CodeableConcept azzzzzzzzzzzzzv_ = c?.SubType;
                        List<Coding> azzzzzzzzzzzzzw_ = azzzzzzzzzzzzzv_?.Coding;
                        bool? azzzzzzzzzzzzzx_(Coding tob)
                        {
                            Code bzzzzzzzzzzzzzk_ = tob?.CodeElement;
                            string bzzzzzzzzzzzzzl_ = bzzzzzzzzzzzzzk_?.Value;
                            CqlValueSet bzzzzzzzzzzzzzm_ = this.Nonacute_Inpatient_Stay(context);
                            bool? bzzzzzzzzzzzzzn_ = context.Operators.StringInValueSet(bzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzm_);

                            return bzzzzzzzzzzzzzn_;
                        };
                        IEnumerable<Coding> azzzzzzzzzzzzzy_ = context.Operators.Where<Coding>((IEnumerable<Coding>)azzzzzzzzzzzzzw_, azzzzzzzzzzzzzx_);
                        bool? azzzzzzzzzzzzzz_ = context.Operators.Exists<Coding>(azzzzzzzzzzzzzy_);
                        bool? bzzzzzzzzzzzzza_ = context.Operators.Or(azzzzzzzzzzzzzu_, azzzzzzzzzzzzzz_);

                        return bzzzzzzzzzzzzza_;
                    };
                    IEnumerable<Claim> azzzzzzzzzzzzzq_ = context.Operators.Where<Claim>(azzzzzzzzzzzzzo_, azzzzzzzzzzzzzp_);

                    return azzzzzzzzzzzzzq_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? zzzzzzzzzzzzzs_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, zzzzzzzzzzzzzq_(), zzzzzzzzzzzzzr_());
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] zzzzzzzzzzzzzt_ = [
                zzzzzzzzzzzzzs_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? zzzzzzzzzzzzzu_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> bzzzzzzzzzzzzzo_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> bzzzzzzzzzzzzzp_ = LineItemDefinition?.NonacuteInpatientLineItems;
                IEnumerable<Claim> bzzzzzzzzzzzzzq_(Claim nonAcuteInpatientStay)
                {
                    IEnumerable<Claim> bzzzzzzzzzzzzzy_ = LineItemDefinition?.InpatientStayLineItems;
                    bool? bzzzzzzzzzzzzzz_(Claim inpatientStay)
                    {
                        Id czzzzzzzzzzzzzd_ = nonAcuteInpatientStay?.IdElement;
                        Id czzzzzzzzzzzzze_ = inpatientStay?.IdElement;
                        bool? czzzzzzzzzzzzzf_ = context.Operators.Equal(czzzzzzzzzzzzzd_, czzzzzzzzzzzzze_);

                        return czzzzzzzzzzzzzf_;
                    };
                    IEnumerable<Claim> czzzzzzzzzzzzza_ = context.Operators.Where<Claim>(bzzzzzzzzzzzzzy_, bzzzzzzzzzzzzzz_);
                    Claim czzzzzzzzzzzzzb_(Claim inpatientStay) =>
                        nonAcuteInpatientStay;
                    IEnumerable<Claim> czzzzzzzzzzzzzc_ = context.Operators.Select<Claim, Claim>(czzzzzzzzzzzzza_, czzzzzzzzzzzzzb_);

                    return czzzzzzzzzzzzzc_;
                };
                IEnumerable<Claim> bzzzzzzzzzzzzzr_ = context.Operators.SelectMany<Claim, Claim>(bzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzq_);
                IEnumerable<Claim> bzzzzzzzzzzzzzu_(Claim inpatientStay)
                {
                    IEnumerable<Claim> czzzzzzzzzzzzzg_ = LineItemDefinition?.NonacuteInpatientLineItems;
                    bool? czzzzzzzzzzzzzh_(Claim nonAcuteInpatientStay)
                    {
                        Id czzzzzzzzzzzzzl_ = inpatientStay?.IdElement;
                        Id czzzzzzzzzzzzzm_ = nonAcuteInpatientStay?.IdElement;
                        bool? czzzzzzzzzzzzzn_ = context.Operators.Equal(czzzzzzzzzzzzzl_, czzzzzzzzzzzzzm_);

                        return czzzzzzzzzzzzzn_;
                    };
                    IEnumerable<Claim> czzzzzzzzzzzzzi_ = context.Operators.Where<Claim>(czzzzzzzzzzzzzg_, czzzzzzzzzzzzzh_);
                    Claim czzzzzzzzzzzzzj_(Claim nonAcuteInpatientStay) =>
                        inpatientStay;
                    IEnumerable<Claim> czzzzzzzzzzzzzk_ = context.Operators.Select<Claim, Claim>(czzzzzzzzzzzzzi_, czzzzzzzzzzzzzj_);

                    return czzzzzzzzzzzzzk_;
                };
                IEnumerable<Claim> bzzzzzzzzzzzzzv_ = context.Operators.SelectMany<Claim, Claim>(bzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzu_);
                IEnumerable<Claim> bzzzzzzzzzzzzzw_ = context.Operators.Except<Claim>(bzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzv_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bzzzzzzzzzzzzzx_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, bzzzzzzzzzzzzzo_, bzzzzzzzzzzzzzr_, bzzzzzzzzzzzzzw_);

                return bzzzzzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> zzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)zzzzzzzzzzzzzt_, zzzzzzzzzzzzzu_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> zzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(zzzzzzzzzzzzzv_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? zzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(zzzzzzzzzzzzzw_);

            return zzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> zzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)zzzzzzzzzzzzzl_, zzzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> zzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(zzzzzzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? zzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(zzzzzzzzzzzzzo_);

        return zzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Get Prescriber NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? czzzzzzzzzzzzzo_(Claim C)
        {
            List<Claim.CareTeamComponent> czzzzzzzzzzzzzx_ = C?.CareTeam;
            bool? czzzzzzzzzzzzzy_(Claim.CareTeamComponent ct)
            {
                PositiveInt dzzzzzzzzzzzzzo_ = ct?.SequenceElement;
                Integer dzzzzzzzzzzzzzp_ = context.Operators.Convert<Integer>(dzzzzzzzzzzzzzo_);
                int? dzzzzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, dzzzzzzzzzzzzzp_);
                bool? dzzzzzzzzzzzzzr_ = context.Operators.Equal(dzzzzzzzzzzzzzq_, 1);

                return dzzzzzzzzzzzzzr_;
            };
            IEnumerable<Claim.CareTeamComponent> czzzzzzzzzzzzzz_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)czzzzzzzzzzzzzx_, czzzzzzzzzzzzzy_);
            bool? dzzzzzzzzzzzzza_(Claim.CareTeamComponent @this)
            {
                ResourceReference dzzzzzzzzzzzzzs_ = @this?.Provider;
                bool? dzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzs_ is null));

                return dzzzzzzzzzzzzzt_;
            };
            IEnumerable<Claim.CareTeamComponent> dzzzzzzzzzzzzzb_ = context.Operators.Where<Claim.CareTeamComponent>(czzzzzzzzzzzzzz_, dzzzzzzzzzzzzza_);
            ResourceReference dzzzzzzzzzzzzzc_(Claim.CareTeamComponent @this)
            {
                ResourceReference dzzzzzzzzzzzzzu_ = @this?.Provider;

                return dzzzzzzzzzzzzzu_;
            };
            IEnumerable<ResourceReference> dzzzzzzzzzzzzzd_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(dzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzc_);
            bool? dzzzzzzzzzzzzzf_(Claim.CareTeamComponent ct)
            {
                PositiveInt dzzzzzzzzzzzzzv_ = ct?.SequenceElement;
                Integer dzzzzzzzzzzzzzw_ = context.Operators.Convert<Integer>(dzzzzzzzzzzzzzv_);
                int? dzzzzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, dzzzzzzzzzzzzzw_);
                bool? dzzzzzzzzzzzzzy_ = context.Operators.Equal(dzzzzzzzzzzzzzx_, 1);

                return dzzzzzzzzzzzzzy_;
            };
            IEnumerable<Claim.CareTeamComponent> dzzzzzzzzzzzzzg_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)czzzzzzzzzzzzzx_, dzzzzzzzzzzzzzf_);
            bool? dzzzzzzzzzzzzzh_(Claim.CareTeamComponent @this)
            {
                ResourceReference dzzzzzzzzzzzzzz_ = @this?.Provider;
                bool? ezzzzzzzzzzzzza_ = context.Operators.Not((bool?)(dzzzzzzzzzzzzzz_ is null));

                return ezzzzzzzzzzzzza_;
            };
            IEnumerable<Claim.CareTeamComponent> dzzzzzzzzzzzzzi_ = context.Operators.Where<Claim.CareTeamComponent>(dzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzh_);
            ResourceReference dzzzzzzzzzzzzzj_(Claim.CareTeamComponent @this)
            {
                ResourceReference ezzzzzzzzzzzzzb_ = @this?.Provider;

                return ezzzzzzzzzzzzzb_;
            };
            IEnumerable<ResourceReference> dzzzzzzzzzzzzzk_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(dzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzj_);
            string dzzzzzzzzzzzzzl_(ResourceReference p)
            {
                FhirString ezzzzzzzzzzzzzc_ = p?.ReferenceElement;
                FhirString[] ezzzzzzzzzzzzzd_ = [
                    ezzzzzzzzzzzzzc_,
                ];
                string ezzzzzzzzzzzzze_(FhirString r)
                {
                    string ezzzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string ezzzzzzzzzzzzzi_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ezzzzzzzzzzzzzh_);

                    return ezzzzzzzzzzzzzi_;
                };
                IEnumerable<string> ezzzzzzzzzzzzzf_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)ezzzzzzzzzzzzzd_, ezzzzzzzzzzzzze_);
                string ezzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<string>(ezzzzzzzzzzzzzf_);

                return ezzzzzzzzzzzzzg_;
            };
            IEnumerable<string> dzzzzzzzzzzzzzm_ = context.Operators.Select<ResourceReference, string>(dzzzzzzzzzzzzzk_, dzzzzzzzzzzzzzl_);
            (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? dzzzzzzzzzzzzzn_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, dzzzzzzzzzzzzzd_, dzzzzzzzzzzzzzm_);

            return dzzzzzzzzzzzzzn_;
        };
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> czzzzzzzzzzzzzp_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, czzzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> czzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(czzzzzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? czzzzzzzzzzzzzr_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, czzzzzzzzzzzzzq_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?[] czzzzzzzzzzzzzs_ = [
            czzzzzzzzzzzzzr_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? czzzzzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ClaimProperties)
        {
            IEnumerable<Practitioner> ezzzzzzzzzzzzzj_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));
            bool? ezzzzzzzzzzzzzk_(Practitioner p)
            {
                Id ezzzzzzzzzzzzzs_ = p?.IdElement;
                string ezzzzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzzzs_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ezzzzzzzzzzzzzu_ = ClaimProperties?.CareTeams;
                bool? ezzzzzzzzzzzzzv_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> fzzzzzzzzzzzzzb_ = @this?.CareTeamsProviderID;
                    bool? fzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzzb_ is null));

                    return fzzzzzzzzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ezzzzzzzzzzzzzw_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(ezzzzzzzzzzzzzu_, ezzzzzzzzzzzzzv_);
                IEnumerable<string> ezzzzzzzzzzzzzx_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> fzzzzzzzzzzzzzd_ = @this?.CareTeamsProviderID;

                    return fzzzzzzzzzzzzzd_;
                };
                IEnumerable<IEnumerable<string>> ezzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(ezzzzzzzzzzzzzw_, ezzzzzzzzzzzzzx_);
                IEnumerable<string> ezzzzzzzzzzzzzz_ = context.Operators.Flatten<string>(ezzzzzzzzzzzzzy_);
                bool? fzzzzzzzzzzzzza_ = context.Operators.In<string>(ezzzzzzzzzzzzzt_, ezzzzzzzzzzzzzz_);

                return fzzzzzzzzzzzzza_;
            };
            IEnumerable<Practitioner> ezzzzzzzzzzzzzl_ = context.Operators.Where<Practitioner>(ezzzzzzzzzzzzzj_, ezzzzzzzzzzzzzk_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? ezzzzzzzzzzzzzm_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, ezzzzzzzzzzzzzl_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?[] ezzzzzzzzzzzzzn_ = [
                ezzzzzzzzzzzzzm_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? ezzzzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? PractitionerMatch)
            {
                IEnumerable<Practitioner> fzzzzzzzzzzzzze_ = PractitionerMatch?.Practitioners;
                bool? fzzzzzzzzzzzzzf_(Practitioner P)
                {
                    bool? fzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(P is null));

                    return fzzzzzzzzzzzzzp_;
                };
                IEnumerable<Practitioner> fzzzzzzzzzzzzzg_ = context.Operators.Where<Practitioner>(fzzzzzzzzzzzzze_, fzzzzzzzzzzzzzf_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? fzzzzzzzzzzzzzh_(Practitioner P)
                {
                    List<Identifier> fzzzzzzzzzzzzzq_ = P?.Identifier;
                    bool? fzzzzzzzzzzzzzr_(Identifier l)
                    {
                        FhirUri gzzzzzzzzzzzzzc_ = l?.SystemElement;
                        string gzzzzzzzzzzzzzd_ = gzzzzzzzzzzzzzc_?.Value;
                        bool? gzzzzzzzzzzzzze_ = context.Operators.Equal(gzzzzzzzzzzzzzd_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept gzzzzzzzzzzzzzf_ = l?.Type;
                        CqlConcept gzzzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzzzzzzzf_);
                        CqlCode gzzzzzzzzzzzzzh_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept gzzzzzzzzzzzzzi_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzh_);
                        bool? gzzzzzzzzzzzzzj_ = context.Operators.Equivalent(gzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzi_);
                        bool? gzzzzzzzzzzzzzk_ = context.Operators.And(gzzzzzzzzzzzzze_, gzzzzzzzzzzzzzj_);
                        FhirString gzzzzzzzzzzzzzl_ = l?.ValueElement;
                        string gzzzzzzzzzzzzzm_ = gzzzzzzzzzzzzzl_?.Value;
                        bool? gzzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzm_ is null));
                        bool? gzzzzzzzzzzzzzo_ = context.Operators.And(gzzzzzzzzzzzzzk_, gzzzzzzzzzzzzzn_);

                        return gzzzzzzzzzzzzzo_;
                    };
                    IEnumerable<Identifier> fzzzzzzzzzzzzzs_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)fzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzr_);
                    FhirString fzzzzzzzzzzzzzt_(Identifier l)
                    {
                        FhirString gzzzzzzzzzzzzzp_ = l?.ValueElement;

                        return gzzzzzzzzzzzzzp_;
                    };
                    IEnumerable<FhirString> fzzzzzzzzzzzzzu_ = context.Operators.Select<Identifier, FhirString>(fzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzt_);
                    IEnumerable<FhirString> fzzzzzzzzzzzzzv_ = context.Operators.Distinct<FhirString>(fzzzzzzzzzzzzzu_);
                    bool? fzzzzzzzzzzzzzx_(Identifier l)
                    {
                        FhirUri gzzzzzzzzzzzzzq_ = l?.SystemElement;
                        string gzzzzzzzzzzzzzr_ = gzzzzzzzzzzzzzq_?.Value;
                        bool? gzzzzzzzzzzzzzs_ = context.Operators.Equal(gzzzzzzzzzzzzzr_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept gzzzzzzzzzzzzzt_ = l?.Type;
                        CqlConcept gzzzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzzzzzzzt_);
                        CqlCode gzzzzzzzzzzzzzv_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept gzzzzzzzzzzzzzw_ = context.Operators.ConvertCodeToConcept(gzzzzzzzzzzzzzv_);
                        bool? gzzzzzzzzzzzzzx_ = context.Operators.Equivalent(gzzzzzzzzzzzzzu_, gzzzzzzzzzzzzzw_);
                        bool? gzzzzzzzzzzzzzy_ = context.Operators.And(gzzzzzzzzzzzzzs_, gzzzzzzzzzzzzzx_);
                        FhirString gzzzzzzzzzzzzzz_ = l?.ValueElement;
                        string hzzzzzzzzzzzzza_ = gzzzzzzzzzzzzzz_?.Value;
                        bool? hzzzzzzzzzzzzzb_ = context.Operators.And(gzzzzzzzzzzzzzy_, (bool?)(hzzzzzzzzzzzzza_ is null));

                        return hzzzzzzzzzzzzzb_;
                    };
                    IEnumerable<Identifier> fzzzzzzzzzzzzzy_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)fzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzx_);
                    Identifier fzzzzzzzzzzzzzz_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> gzzzzzzzzzzzzza_ = context.Operators.Select<Identifier, Identifier>(fzzzzzzzzzzzzzy_, fzzzzzzzzzzzzzz_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? gzzzzzzzzzzzzzb_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, fzzzzzzzzzzzzzv_, gzzzzzzzzzzzzza_);

                    return gzzzzzzzzzzzzzb_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> fzzzzzzzzzzzzzi_ = context.Operators.Select<Practitioner, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(fzzzzzzzzzzzzzg_, fzzzzzzzzzzzzzh_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? fzzzzzzzzzzzzzj_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, fzzzzzzzzzzzzzi_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] fzzzzzzzzzzzzzk_ = [
                    fzzzzzzzzzzzzzj_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? fzzzzzzzzzzzzzl_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? hzzzzzzzzzzzzzc_()
                    {
                        bool hzzzzzzzzzzzzze_()
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> hzzzzzzzzzzzzzf_ = ClaimProperties?.CareTeams;
                            bool? hzzzzzzzzzzzzzg_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim hzzzzzzzzzzzzzl_ = @this?.SingleCareTeam;
                                bool? hzzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzl_ is null));

                                return hzzzzzzzzzzzzzm_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> hzzzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(hzzzzzzzzzzzzzf_, hzzzzzzzzzzzzzg_);
                            Claim hzzzzzzzzzzzzzi_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim hzzzzzzzzzzzzzn_ = @this?.SingleCareTeam;

                                return hzzzzzzzzzzzzzn_;
                            };
                            IEnumerable<Claim> hzzzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(hzzzzzzzzzzzzzh_, hzzzzzzzzzzzzzi_);
                            bool? hzzzzzzzzzzzzzk_ = context.Operators.Exists<Claim>(hzzzzzzzzzzzzzj_);

                            return hzzzzzzzzzzzzzk_ ?? false;
                        };
                        if (hzzzzzzzzzzzzze_())
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> hzzzzzzzzzzzzzo_ = ClaimProperties?.CareTeams;
                            bool? hzzzzzzzzzzzzzp_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim izzzzzzzzzzzzzl_ = @this?.SingleCareTeam;
                                bool? izzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzl_ is null));

                                return izzzzzzzzzzzzzm_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> hzzzzzzzzzzzzzq_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(hzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzp_);
                            Claim hzzzzzzzzzzzzzr_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim izzzzzzzzzzzzzn_ = @this?.SingleCareTeam;

                                return izzzzzzzzzzzzzn_;
                            };
                            IEnumerable<Claim> hzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(hzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzr_);
                            bool? hzzzzzzzzzzzzzt_(Claim X)
                            {
                                List<Claim.CareTeamComponent> izzzzzzzzzzzzzo_ = X?.CareTeam;

                                return (bool?)(((IEnumerable<Claim.CareTeamComponent>)izzzzzzzzzzzzzo_) is null);
                            };
                            IEnumerable<Claim> hzzzzzzzzzzzzzu_ = context.Operators.Where<Claim>(hzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzt_);
                            int? hzzzzzzzzzzzzzv_ = context.Operators.Count<Claim>(hzzzzzzzzzzzzzu_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> hzzzzzzzzzzzzzw_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> hzzzzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> izzzzzzzzzzzzzp_ = X?.AllIdentifiers;

                                return izzzzzzzzzzzzzp_;
                            };
                            IEnumerable<IEnumerable<FhirString>> hzzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(hzzzzzzzzzzzzzw_, hzzzzzzzzzzzzzx_);
                            IEnumerable<FhirString> hzzzzzzzzzzzzzz_ = context.Operators.Flatten<FhirString>(hzzzzzzzzzzzzzy_);
                            FhirString izzzzzzzzzzzzza_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> izzzzzzzzzzzzzb_ = context.Operators.Select<FhirString, FhirString>(hzzzzzzzzzzzzzz_, izzzzzzzzzzzzza_);
                            IEnumerable<FhirString> izzzzzzzzzzzzzc_ = context.Operators.Distinct<FhirString>(izzzzzzzzzzzzzb_);
                            int? izzzzzzzzzzzzzd_ = context.Operators.Count<FhirString>(izzzzzzzzzzzzzc_);
                            int? izzzzzzzzzzzzze_ = context.Operators.Add(hzzzzzzzzzzzzzv_, izzzzzzzzzzzzzd_);
                            IEnumerable<Identifier> izzzzzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> izzzzzzzzzzzzzq_ = X?.NullIdentifiers;

                                return izzzzzzzzzzzzzq_;
                            };
                            IEnumerable<IEnumerable<Identifier>> izzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(hzzzzzzzzzzzzzw_, izzzzzzzzzzzzzg_);
                            IEnumerable<Identifier> izzzzzzzzzzzzzi_ = context.Operators.Flatten<Identifier>(izzzzzzzzzzzzzh_);
                            int? izzzzzzzzzzzzzj_ = context.Operators.Count<Identifier>(izzzzzzzzzzzzzi_);
                            int? izzzzzzzzzzzzzk_ = context.Operators.Add(izzzzzzzzzzzzze_, izzzzzzzzzzzzzj_);

                            return izzzzzzzzzzzzzk_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? hzzzzzzzzzzzzzd_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, hzzzzzzzzzzzzzc_());

                    return hzzzzzzzzzzzzzd_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> fzzzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)fzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzl_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> fzzzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(fzzzzzzzzzzzzzm_);
                (CqlTupleMetadata, int? IdentifierCount)? fzzzzzzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(fzzzzzzzzzzzzzn_);

                return fzzzzzzzzzzzzzo_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> ezzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?>)ezzzzzzzzzzzzzn_, ezzzzzzzzzzzzzo_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> ezzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(ezzzzzzzzzzzzzp_);
            (CqlTupleMetadata, int? IdentifierCount)? ezzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(ezzzzzzzzzzzzzq_);

            return ezzzzzzzzzzzzzr_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> czzzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?>)czzzzzzzzzzzzzs_, czzzzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> czzzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(czzzzzzzzzzzzzu_);
        (CqlTupleMetadata, int? IdentifierCount)? czzzzzzzzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(czzzzzzzzzzzzzv_);

        return czzzzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition("Get Pharmacy NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? izzzzzzzzzzzzzr_(Claim C)
        {
            List<Claim.ItemComponent> jzzzzzzzzzzzzza_ = C?.Item;
            bool? jzzzzzzzzzzzzzc_(Claim.ItemComponent i)
            {
                PositiveInt jzzzzzzzzzzzzzu_ = i?.SequenceElement;
                Integer jzzzzzzzzzzzzzv_ = context.Operators.Convert<Integer>(jzzzzzzzzzzzzzu_);
                int? jzzzzzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, jzzzzzzzzzzzzzv_);
                bool? jzzzzzzzzzzzzzx_ = context.Operators.Equal(jzzzzzzzzzzzzzw_, 1);

                return jzzzzzzzzzzzzzx_;
            };
            IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzzzd_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)jzzzzzzzzzzzzza_, jzzzzzzzzzzzzzc_);
            bool? jzzzzzzzzzzzzze_(Claim.ItemComponent @this)
            {
                DataType jzzzzzzzzzzzzzy_ = @this?.Location;
                bool? jzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzzy_ is null));

                return jzzzzzzzzzzzzzz_;
            };
            IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzzzf_ = context.Operators.Where<Claim.ItemComponent>(jzzzzzzzzzzzzzd_, jzzzzzzzzzzzzze_);
            object jzzzzzzzzzzzzzg_(Claim.ItemComponent @this)
            {
                DataType kzzzzzzzzzzzzza_ = @this?.Location;

                return kzzzzzzzzzzzzza_;
            };
            IEnumerable<object> jzzzzzzzzzzzzzh_ = context.Operators.Select<Claim.ItemComponent, object>(jzzzzzzzzzzzzzf_, jzzzzzzzzzzzzzg_);
            ResourceReference jzzzzzzzzzzzzzi_(object l) =>
                l as ResourceReference;
            IEnumerable<ResourceReference> jzzzzzzzzzzzzzj_ = context.Operators.Select<object, ResourceReference>(jzzzzzzzzzzzzzh_, jzzzzzzzzzzzzzi_);
            bool? jzzzzzzzzzzzzzl_(Claim.ItemComponent i)
            {
                PositiveInt kzzzzzzzzzzzzzb_ = i?.SequenceElement;
                Integer kzzzzzzzzzzzzzc_ = context.Operators.Convert<Integer>(kzzzzzzzzzzzzzb_);
                int? kzzzzzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, kzzzzzzzzzzzzzc_);
                bool? kzzzzzzzzzzzzze_ = context.Operators.Equal(kzzzzzzzzzzzzzd_, 1);

                return kzzzzzzzzzzzzze_;
            };
            IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)jzzzzzzzzzzzzza_, jzzzzzzzzzzzzzl_);
            bool? jzzzzzzzzzzzzzn_(Claim.ItemComponent @this)
            {
                DataType kzzzzzzzzzzzzzf_ = @this?.Location;
                bool? kzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzf_ is null));

                return kzzzzzzzzzzzzzg_;
            };
            IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzzzo_ = context.Operators.Where<Claim.ItemComponent>(jzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzn_);
            object jzzzzzzzzzzzzzp_(Claim.ItemComponent @this)
            {
                DataType kzzzzzzzzzzzzzh_ = @this?.Location;

                return kzzzzzzzzzzzzzh_;
            };
            IEnumerable<object> jzzzzzzzzzzzzzq_ = context.Operators.Select<Claim.ItemComponent, object>(jzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzp_);
            string jzzzzzzzzzzzzzr_(object l)
            {
                FhirString kzzzzzzzzzzzzzi_ = (l as ResourceReference)?.ReferenceElement;
                FhirString[] kzzzzzzzzzzzzzj_ = [
                    kzzzzzzzzzzzzzi_,
                ];
                string kzzzzzzzzzzzzzk_(FhirString r)
                {
                    string kzzzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string kzzzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, kzzzzzzzzzzzzzn_);

                    return kzzzzzzzzzzzzzo_;
                };
                IEnumerable<string> kzzzzzzzzzzzzzl_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)kzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzk_);
                string kzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<string>(kzzzzzzzzzzzzzl_);

                return kzzzzzzzzzzzzzm_;
            };
            IEnumerable<string> jzzzzzzzzzzzzzs_ = context.Operators.Select<object, string>(jzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? jzzzzzzzzzzzzzt_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent>)jzzzzzzzzzzzzza_, jzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzs_);

            return jzzzzzzzzzzzzzt_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> izzzzzzzzzzzzzs_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, izzzzzzzzzzzzzr_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> izzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(izzzzzzzzzzzzzs_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? izzzzzzzzzzzzzu_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, izzzzzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?[] izzzzzzzzzzzzzv_ = [
            izzzzzzzzzzzzzu_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? izzzzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? ClaimProperties)
        {
            IEnumerable<Location> kzzzzzzzzzzzzzp_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
            bool? kzzzzzzzzzzzzzq_(Location l)
            {
                Id kzzzzzzzzzzzzzy_ = l?.IdElement;
                string kzzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, kzzzzzzzzzzzzzy_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> lzzzzzzzzzzzzza_ = ClaimProperties?.ItemsLocationReferences;
                bool? lzzzzzzzzzzzzzb_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> lzzzzzzzzzzzzzh_ = @this?.ItemLocationID;
                    bool? lzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzh_ is null));

                    return lzzzzzzzzzzzzzi_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> lzzzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(lzzzzzzzzzzzzza_, lzzzzzzzzzzzzzb_);
                IEnumerable<string> lzzzzzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> lzzzzzzzzzzzzzj_ = @this?.ItemLocationID;

                    return lzzzzzzzzzzzzzj_;
                };
                IEnumerable<IEnumerable<string>> lzzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(lzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzd_);
                IEnumerable<string> lzzzzzzzzzzzzzf_ = context.Operators.Flatten<string>(lzzzzzzzzzzzzze_);
                bool? lzzzzzzzzzzzzzg_ = context.Operators.In<string>(kzzzzzzzzzzzzzz_, lzzzzzzzzzzzzzf_);

                return lzzzzzzzzzzzzzg_;
            };
            IEnumerable<Location> kzzzzzzzzzzzzzr_ = context.Operators.Where<Location>(kzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzq_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? kzzzzzzzzzzzzzs_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, kzzzzzzzzzzzzzr_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?[] kzzzzzzzzzzzzzt_ = [
                kzzzzzzzzzzzzzs_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? kzzzzzzzzzzzzzu_((CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? GetLocation)
            {
                IEnumerable<Location> lzzzzzzzzzzzzzk_ = GetLocation?.CorrespondingLocations;
                bool? lzzzzzzzzzzzzzl_(Location C)
                {
                    bool? lzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(C is null));

                    return lzzzzzzzzzzzzzv_;
                };
                IEnumerable<Location> lzzzzzzzzzzzzzm_ = context.Operators.Where<Location>(lzzzzzzzzzzzzzk_, lzzzzzzzzzzzzzl_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? lzzzzzzzzzzzzzn_(Location C)
                {
                    List<Identifier> lzzzzzzzzzzzzzw_ = C?.Identifier;
                    bool? lzzzzzzzzzzzzzx_(Identifier l)
                    {
                        FhirUri mzzzzzzzzzzzzzi_ = l?.SystemElement;
                        string mzzzzzzzzzzzzzj_ = mzzzzzzzzzzzzzi_?.Value;
                        bool? mzzzzzzzzzzzzzk_ = context.Operators.Equal(mzzzzzzzzzzzzzj_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept mzzzzzzzzzzzzzl_ = l?.Type;
                        CqlConcept mzzzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzzzzzzl_);
                        CqlCode mzzzzzzzzzzzzzn_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept mzzzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(mzzzzzzzzzzzzzn_);
                        bool? mzzzzzzzzzzzzzp_ = context.Operators.Equivalent(mzzzzzzzzzzzzzm_, mzzzzzzzzzzzzzo_);
                        bool? mzzzzzzzzzzzzzq_ = context.Operators.And(mzzzzzzzzzzzzzk_, mzzzzzzzzzzzzzp_);
                        FhirString mzzzzzzzzzzzzzr_ = l?.ValueElement;
                        string mzzzzzzzzzzzzzs_ = mzzzzzzzzzzzzzr_?.Value;
                        bool? mzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzs_ is null));
                        bool? mzzzzzzzzzzzzzu_ = context.Operators.And(mzzzzzzzzzzzzzq_, mzzzzzzzzzzzzzt_);

                        return mzzzzzzzzzzzzzu_;
                    };
                    IEnumerable<Identifier> lzzzzzzzzzzzzzy_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)lzzzzzzzzzzzzzw_, lzzzzzzzzzzzzzx_);
                    FhirString lzzzzzzzzzzzzzz_(Identifier l)
                    {
                        FhirString mzzzzzzzzzzzzzv_ = l?.ValueElement;

                        return mzzzzzzzzzzzzzv_;
                    };
                    IEnumerable<FhirString> mzzzzzzzzzzzzza_ = context.Operators.Select<Identifier, FhirString>(lzzzzzzzzzzzzzy_, lzzzzzzzzzzzzzz_);
                    IEnumerable<FhirString> mzzzzzzzzzzzzzb_ = context.Operators.Distinct<FhirString>(mzzzzzzzzzzzzza_);
                    bool? mzzzzzzzzzzzzzd_(Identifier l)
                    {
                        FhirUri mzzzzzzzzzzzzzw_ = l?.SystemElement;
                        string mzzzzzzzzzzzzzx_ = mzzzzzzzzzzzzzw_?.Value;
                        bool? mzzzzzzzzzzzzzy_ = context.Operators.Equal(mzzzzzzzzzzzzzx_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept mzzzzzzzzzzzzzz_ = l?.Type;
                        CqlConcept nzzzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, mzzzzzzzzzzzzzz_);
                        CqlCode nzzzzzzzzzzzzzb_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept nzzzzzzzzzzzzzc_ = context.Operators.ConvertCodeToConcept(nzzzzzzzzzzzzzb_);
                        bool? nzzzzzzzzzzzzzd_ = context.Operators.Equivalent(nzzzzzzzzzzzzza_, nzzzzzzzzzzzzzc_);
                        bool? nzzzzzzzzzzzzze_ = context.Operators.And(mzzzzzzzzzzzzzy_, nzzzzzzzzzzzzzd_);
                        FhirString nzzzzzzzzzzzzzf_ = l?.ValueElement;
                        string nzzzzzzzzzzzzzg_ = nzzzzzzzzzzzzzf_?.Value;
                        bool? nzzzzzzzzzzzzzh_ = context.Operators.And(nzzzzzzzzzzzzze_, (bool?)(nzzzzzzzzzzzzzg_ is null));

                        return nzzzzzzzzzzzzzh_;
                    };
                    IEnumerable<Identifier> mzzzzzzzzzzzzze_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)lzzzzzzzzzzzzzw_, mzzzzzzzzzzzzzd_);
                    Identifier mzzzzzzzzzzzzzf_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> mzzzzzzzzzzzzzg_ = context.Operators.Select<Identifier, Identifier>(mzzzzzzzzzzzzze_, mzzzzzzzzzzzzzf_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? mzzzzzzzzzzzzzh_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, mzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzg_);

                    return mzzzzzzzzzzzzzh_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> lzzzzzzzzzzzzzo_ = context.Operators.Select<Location, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(lzzzzzzzzzzzzzm_, lzzzzzzzzzzzzzn_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? lzzzzzzzzzzzzzp_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, lzzzzzzzzzzzzzo_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] lzzzzzzzzzzzzzq_ = [
                    lzzzzzzzzzzzzzp_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? lzzzzzzzzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? nzzzzzzzzzzzzzi_()
                    {
                        bool nzzzzzzzzzzzzzk_()
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> nzzzzzzzzzzzzzl_ = ClaimProperties?.ItemsLocationReferences;
                            bool? nzzzzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzzzs_ = @this?.SingleItem;
                                bool? nzzzzzzzzzzzzzt_ = context.Operators.Not((bool?)(nzzzzzzzzzzzzzs_ is null));

                                return nzzzzzzzzzzzzzt_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> nzzzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(nzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzm_);
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzzzu_ = @this?.SingleItem;

                                return nzzzzzzzzzzzzzu_;
                            };
                            IEnumerable<IEnumerable<Claim.ItemComponent>> nzzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(nzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzo_);
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzzzq_ = context.Operators.Flatten<Claim.ItemComponent>(nzzzzzzzzzzzzzp_);
                            bool? nzzzzzzzzzzzzzr_ = context.Operators.Exists<Claim.ItemComponent>(nzzzzzzzzzzzzzq_);

                            return nzzzzzzzzzzzzzr_ ?? false;
                        };
                        if (nzzzzzzzzzzzzzk_())
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> nzzzzzzzzzzzzzv_ = ClaimProperties?.ItemsLocationReferences;
                            bool? nzzzzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> ozzzzzzzzzzzzzt_ = @this?.ItemLocation;
                                bool? ozzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzt_ is null));

                                return ozzzzzzzzzzzzzu_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> nzzzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(nzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzw_);
                            IEnumerable<ResourceReference> nzzzzzzzzzzzzzy_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> ozzzzzzzzzzzzzv_ = @this?.ItemLocation;

                                return ozzzzzzzzzzzzzv_;
                            };
                            IEnumerable<IEnumerable<ResourceReference>> nzzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(nzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzy_);
                            IEnumerable<ResourceReference> ozzzzzzzzzzzzza_ = context.Operators.Flatten<ResourceReference>(nzzzzzzzzzzzzzz_);
                            bool? ozzzzzzzzzzzzzb_(ResourceReference X)
                            {
                                FhirString ozzzzzzzzzzzzzw_ = X?.ReferenceElement;
                                string ozzzzzzzzzzzzzx_ = ozzzzzzzzzzzzzw_?.Value;

                                return (bool?)(ozzzzzzzzzzzzzx_ is null);
                            };
                            IEnumerable<ResourceReference> ozzzzzzzzzzzzzc_ = context.Operators.Where<ResourceReference>(ozzzzzzzzzzzzza_, ozzzzzzzzzzzzzb_);
                            int? ozzzzzzzzzzzzzd_ = context.Operators.Count<ResourceReference>(ozzzzzzzzzzzzzc_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> ozzzzzzzzzzzzze_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> ozzzzzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> ozzzzzzzzzzzzzy_ = X?.AllIdentifiers;

                                return ozzzzzzzzzzzzzy_;
                            };
                            IEnumerable<IEnumerable<FhirString>> ozzzzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(ozzzzzzzzzzzzze_, ozzzzzzzzzzzzzf_);
                            IEnumerable<FhirString> ozzzzzzzzzzzzzh_ = context.Operators.Flatten<FhirString>(ozzzzzzzzzzzzzg_);
                            FhirString ozzzzzzzzzzzzzi_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> ozzzzzzzzzzzzzj_ = context.Operators.Select<FhirString, FhirString>(ozzzzzzzzzzzzzh_, ozzzzzzzzzzzzzi_);
                            IEnumerable<FhirString> ozzzzzzzzzzzzzk_ = context.Operators.Distinct<FhirString>(ozzzzzzzzzzzzzj_);
                            int? ozzzzzzzzzzzzzl_ = context.Operators.Count<FhirString>(ozzzzzzzzzzzzzk_);
                            int? ozzzzzzzzzzzzzm_ = context.Operators.Add(ozzzzzzzzzzzzzd_, ozzzzzzzzzzzzzl_);
                            IEnumerable<Identifier> ozzzzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> ozzzzzzzzzzzzzz_ = X?.NullIdentifiers;

                                return ozzzzzzzzzzzzzz_;
                            };
                            IEnumerable<IEnumerable<Identifier>> ozzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(ozzzzzzzzzzzzze_, ozzzzzzzzzzzzzo_);
                            IEnumerable<Identifier> ozzzzzzzzzzzzzq_ = context.Operators.Flatten<Identifier>(ozzzzzzzzzzzzzp_);
                            int? ozzzzzzzzzzzzzr_ = context.Operators.Count<Identifier>(ozzzzzzzzzzzzzq_);
                            int? ozzzzzzzzzzzzzs_ = context.Operators.Add(ozzzzzzzzzzzzzm_, ozzzzzzzzzzzzzr_);

                            return ozzzzzzzzzzzzzs_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? nzzzzzzzzzzzzzj_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, nzzzzzzzzzzzzzi_());

                    return nzzzzzzzzzzzzzj_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> lzzzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)lzzzzzzzzzzzzzq_, lzzzzzzzzzzzzzr_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> lzzzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(lzzzzzzzzzzzzzs_);
                (CqlTupleMetadata, int? IdentifierCount)? lzzzzzzzzzzzzzu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(lzzzzzzzzzzzzzt_);

                return lzzzzzzzzzzzzzu_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> kzzzzzzzzzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?>)kzzzzzzzzzzzzzt_, kzzzzzzzzzzzzzu_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> kzzzzzzzzzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(kzzzzzzzzzzzzzv_);
            (CqlTupleMetadata, int? IdentifierCount)? kzzzzzzzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(kzzzzzzzzzzzzzw_);

            return kzzzzzzzzzzzzzx_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> izzzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?>)izzzzzzzzzzzzzv_, izzzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> izzzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(izzzzzzzzzzzzzx_);
        (CqlTupleMetadata, int? IdentifierCount)? izzzzzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(izzzzzzzzzzzzzy_);

        return izzzzzzzzzzzzzz_;
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
