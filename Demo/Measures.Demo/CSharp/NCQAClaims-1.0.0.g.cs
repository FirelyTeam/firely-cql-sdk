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
        bool? wzzzzzzzzza_(Claim MedicalClaim)
        {
            CodeableConcept wzzzzzzzzzc_ = MedicalClaim?.Type;
            CqlConcept wzzzzzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, wzzzzzzzzzc_);
            CqlCode[] wzzzzzzzzze_ = wzzzzzzzzzd_?.codes;
            CqlCode wzzzzzzzzzf_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? wzzzzzzzzzg_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)wzzzzzzzzze_, wzzzzzzzzzf_);
            CqlConcept wzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, wzzzzzzzzzc_);
            CqlCode[] wzzzzzzzzzj_ = wzzzzzzzzzi_?.codes;
            CqlCode wzzzzzzzzzk_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? wzzzzzzzzzl_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)wzzzzzzzzzj_, wzzzzzzzzzk_);
            bool? wzzzzzzzzzm_ = context.Operators.Or(wzzzzzzzzzg_, wzzzzzzzzzl_);

            return wzzzzzzzzzm_;
        };
        IEnumerable<Claim> wzzzzzzzzzb_ = context.Operators.Where<Claim>(claim, wzzzzzzzzza_);

        return wzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("Pharmacy Claims")]
    public IEnumerable<Claim> Pharmacy_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        bool? wzzzzzzzzzn_(Claim PharmacyClaim)
        {
            CodeableConcept wzzzzzzzzzp_ = PharmacyClaim?.Type;
            CqlConcept wzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, wzzzzzzzzzp_);
            CqlCode[] wzzzzzzzzzr_ = wzzzzzzzzzq_?.codes;
            CqlCode wzzzzzzzzzs_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? wzzzzzzzzzt_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)wzzzzzzzzzr_, wzzzzzzzzzs_);

            return wzzzzzzzzzt_;
        };
        IEnumerable<Claim> wzzzzzzzzzo_ = context.Operators.Where<Claim>(claim, wzzzzzzzzzn_);

        return wzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Professional or Institutional Claims Response")]
    public IEnumerable<ClaimResponse> Professional_or_Institutional_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? wzzzzzzzzzu_(ClaimResponse MedicalResponse)
        {
            CodeableConcept wzzzzzzzzzw_ = MedicalResponse?.Type;
            CqlConcept wzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, wzzzzzzzzzw_);
            CqlCode[] wzzzzzzzzzy_ = wzzzzzzzzzx_?.codes;
            CqlCode wzzzzzzzzzz_ = NCQATerminology_1_0_0.Instance.Professional(context);
            bool? xzzzzzzzzza_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)wzzzzzzzzzy_, wzzzzzzzzzz_);
            CqlConcept xzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, wzzzzzzzzzw_);
            CqlCode[] xzzzzzzzzzd_ = xzzzzzzzzzc_?.codes;
            CqlCode xzzzzzzzzze_ = NCQATerminology_1_0_0.Instance.Institutional(context);
            bool? xzzzzzzzzzf_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)xzzzzzzzzzd_, xzzzzzzzzze_);
            bool? xzzzzzzzzzg_ = context.Operators.Or(xzzzzzzzzza_, xzzzzzzzzzf_);

            return xzzzzzzzzzg_;
        };
        IEnumerable<ClaimResponse> wzzzzzzzzzv_ = context.Operators.Where<ClaimResponse>(claimResponse, wzzzzzzzzzu_);

        return wzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Pharmacy Claims Response")]
    public IEnumerable<ClaimResponse> Pharmacy_Claims_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? xzzzzzzzzzh_(ClaimResponse PharmacyResponse)
        {
            CodeableConcept xzzzzzzzzzj_ = PharmacyResponse?.Type;
            CqlConcept xzzzzzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, xzzzzzzzzzj_);
            CqlCode[] xzzzzzzzzzl_ = xzzzzzzzzzk_?.codes;
            CqlCode xzzzzzzzzzm_ = NCQATerminology_1_0_0.Instance.Pharmacy(context);
            bool? xzzzzzzzzzn_ = context.Operators.Contains<CqlCode>((IEnumerable<CqlCode>)xzzzzzzzzzl_, xzzzzzzzzzm_);

            return xzzzzzzzzzn_;
        };
        IEnumerable<ClaimResponse> xzzzzzzzzzi_ = context.Operators.Where<ClaimResponse>(claimResponse, xzzzzzzzzzh_);

        return xzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Medical Claims With Procedure and POS")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_and_POS(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> posCodes, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> xzzzzzzzzzo_ = this.Professional_or_Institutional_Claims(context, claim);
        string xzzzzzzzzzp_(CqlCode p)
        {
            string yzzzzzzzzzb_ = p?.code;

            return yzzzzzzzzzb_;
        };
        IEnumerable<string> xzzzzzzzzzq_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, xzzzzzzzzzp_);
        IEnumerable<string> xzzzzzzzzzr_ = context.Operators.Distinct<string>(xzzzzzzzzzq_);
        string xzzzzzzzzzs_(CqlCode pos)
        {
            string yzzzzzzzzzc_ = pos?.code;

            return yzzzzzzzzzc_;
        };
        IEnumerable<string> xzzzzzzzzzt_ = context.Operators.Select<CqlCode, string>(posCodes, xzzzzzzzzzs_);
        IEnumerable<string> xzzzzzzzzzu_ = context.Operators.Distinct<string>(xzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? xzzzzzzzzzv_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, xzzzzzzzzzo_, xzzzzzzzzzr_, xzzzzzzzzzu_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] xzzzzzzzzzw_ = [
            xzzzzzzzzzv_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithPosCode)
        {
            IEnumerable<Claim> yzzzzzzzzzd_ = ClaimWithPosCode?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzze_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> yzzzzzzzzzj_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> yzzzzzzzzzq_ = ClaimofInterest?.Item;
                        bool? yzzzzzzzzzr_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept yzzzzzzzzzt_ = ItemOnLine?.ProductOrService;
                            CqlConcept yzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzzt_);
                            CqlCode[] yzzzzzzzzzv_ = yzzzzzzzzzu_?.codes;
                            bool? yzzzzzzzzzw_(CqlCode LineCode)
                            {
                                string zzzzzzzzzzg_ = LineCode?.code;
                                IEnumerable<string> zzzzzzzzzzh_ = ClaimWithPosCode?.ProceduresAsStrings;
                                bool? zzzzzzzzzzi_ = context.Operators.In<string>(zzzzzzzzzzg_, zzzzzzzzzzh_);

                                return zzzzzzzzzzi_;
                            };
                            IEnumerable<CqlCode> yzzzzzzzzzx_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)yzzzzzzzzzv_, yzzzzzzzzzw_);
                            bool? yzzzzzzzzzy_ = context.Operators.Exists<CqlCode>(yzzzzzzzzzx_);
                            DataType yzzzzzzzzzz_ = ItemOnLine?.Location;
                            CqlConcept zzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, yzzzzzzzzzz_ as CodeableConcept);
                            CqlCode[] zzzzzzzzzzb_ = zzzzzzzzzza_?.codes;
                            bool? zzzzzzzzzzc_(CqlCode PosCode)
                            {
                                string zzzzzzzzzzj_ = PosCode?.code;
                                IEnumerable<string> zzzzzzzzzzk_ = ClaimWithPosCode?.POSAsString;
                                bool? zzzzzzzzzzl_ = context.Operators.In<string>(zzzzzzzzzzj_, zzzzzzzzzzk_);

                                return zzzzzzzzzzl_;
                            };
                            IEnumerable<CqlCode> zzzzzzzzzzd_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)zzzzzzzzzzb_, zzzzzzzzzzc_);
                            bool? zzzzzzzzzze_ = context.Operators.Exists<CqlCode>(zzzzzzzzzzd_);
                            bool? zzzzzzzzzzf_ = context.Operators.And(yzzzzzzzzzy_, zzzzzzzzzze_);

                            return zzzzzzzzzzf_;
                        };
                        IEnumerable<Claim.ItemComponent> yzzzzzzzzzs_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)yzzzzzzzzzq_, yzzzzzzzzzr_);

                        return yzzzzzzzzzs_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? yzzzzzzzzzk_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, yzzzzzzzzzj_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] yzzzzzzzzzl_ = [
                    yzzzzzzzzzk_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzzm_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? zzzzzzzzzzm_()
                    {
                        bool zzzzzzzzzzn_()
                        {
                            IEnumerable<Claim.ItemComponent> zzzzzzzzzzo_ = LineItemDefinition?.LineItems;
                            bool? zzzzzzzzzzp_ = context.Operators.Exists<Claim.ItemComponent>(zzzzzzzzzzo_);

                            return zzzzzzzzzzp_ ?? false;
                        };
                        if (zzzzzzzzzzn_())
                        {
                            Claim zzzzzzzzzzq_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> zzzzzzzzzzr_ = LineItemDefinition?.LineItems;
                            bool? zzzzzzzzzzs_(Claim.ItemComponent @this)
                            {
                                DataType azzzzzzzzzza_ = @this?.Serviced;
                                bool? azzzzzzzzzzb_ = context.Operators.Not((bool?)(azzzzzzzzzza_ is null));

                                return azzzzzzzzzzb_;
                            };
                            IEnumerable<Claim.ItemComponent> zzzzzzzzzzt_ = context.Operators.Where<Claim.ItemComponent>(zzzzzzzzzzr_, zzzzzzzzzzs_);
                            object zzzzzzzzzzu_(Claim.ItemComponent @this)
                            {
                                DataType azzzzzzzzzzc_ = @this?.Serviced;

                                return azzzzzzzzzzc_;
                            };
                            IEnumerable<object> zzzzzzzzzzv_ = context.Operators.Select<Claim.ItemComponent, object>(zzzzzzzzzzt_, zzzzzzzzzzu_);
                            CqlInterval<CqlDateTime> zzzzzzzzzzw_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> azzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return azzzzzzzzzzd_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> zzzzzzzzzzx_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(zzzzzzzzzzv_, zzzzzzzzzzw_);
                            IEnumerable<CqlInterval<CqlDateTime>> zzzzzzzzzzy_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(zzzzzzzzzzx_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? zzzzzzzzzzz_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, zzzzzzzzzzq_, zzzzzzzzzzy_);

                            return zzzzzzzzzzz_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return zzzzzzzzzzm_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)yzzzzzzzzzl_, yzzzzzzzzzm_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzzzn_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzzzo_);

                return yzzzzzzzzzp_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzzf_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzzzd_, yzzzzzzzzze_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzzzf_);
            bool? yzzzzzzzzzh_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? azzzzzzzzzze_ = context.Operators.Not((bool?)(FinalList is null));

                return azzzzzzzzzze_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(yzzzzzzzzzg_, yzzzzzzzzzh_);

            return yzzzzzzzzzi_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> xzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)xzzzzzzzzzw_, xzzzzzzzzzx_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> xzzzzzzzzzz_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(xzzzzzzzzzy_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> yzzzzzzzzza_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(xzzzzzzzzzz_);

        return yzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Medical Claims With Procedure in Header or on Line Item")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Procedure_in_Header_or_on_Line_Item(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> azzzzzzzzzzf_ = this.Professional_or_Institutional_Claims(context, claim);
        string azzzzzzzzzzg_(CqlCode p)
        {
            string azzzzzzzzzzp_ = p?.code;

            return azzzzzzzzzzp_;
        };
        IEnumerable<string> azzzzzzzzzzh_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, azzzzzzzzzzg_);
        IEnumerable<string> azzzzzzzzzzi_ = context.Operators.Distinct<string>(azzzzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? azzzzzzzzzzj_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, azzzzzzzzzzf_, azzzzzzzzzzi_, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] azzzzzzzzzzk_ = [
            azzzzzzzzzzj_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzzl_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithProcedure)
        {
            IEnumerable<Claim> azzzzzzzzzzq_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzzzr_(Claim ClaimofInterest)
            {
                IEnumerable<Claim.ItemComponent> azzzzzzzzzzw_()
                {
                    if (ClaimofInterest is null)
                    {
                        return null as IEnumerable<Claim.ItemComponent>;
                    }
                    else
                    {
                        List<Claim.ItemComponent> bzzzzzzzzzzd_ = ClaimofInterest?.Item;
                        bool? bzzzzzzzzzze_(Claim.ItemComponent ItemOnLine)
                        {
                            CodeableConcept bzzzzzzzzzzg_ = ItemOnLine?.ProductOrService;
                            CqlConcept bzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bzzzzzzzzzzg_);
                            CqlCode[] bzzzzzzzzzzi_ = bzzzzzzzzzzh_?.codes;
                            bool? bzzzzzzzzzzj_(CqlCode LineCode)
                            {
                                string czzzzzzzzzzc_ = LineCode?.code;
                                IEnumerable<string> czzzzzzzzzzd_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? czzzzzzzzzze_ = context.Operators.In<string>(czzzzzzzzzzc_, czzzzzzzzzzd_);

                                return czzzzzzzzzze_;
                            };
                            IEnumerable<CqlCode> bzzzzzzzzzzk_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)bzzzzzzzzzzi_, bzzzzzzzzzzj_);
                            bool? bzzzzzzzzzzl_ = context.Operators.Exists<CqlCode>(bzzzzzzzzzzk_);
                            List<Claim.ProcedureComponent> bzzzzzzzzzzm_ = ClaimofInterest?.Procedure;
                            bool? bzzzzzzzzzzn_(Claim.ProcedureComponent @this)
                            {
                                DataType czzzzzzzzzzf_ = @this?.Procedure;
                                bool? czzzzzzzzzzg_ = context.Operators.Not((bool?)(czzzzzzzzzzf_ is null));

                                return czzzzzzzzzzg_;
                            };
                            IEnumerable<Claim.ProcedureComponent> bzzzzzzzzzzo_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)bzzzzzzzzzzm_, bzzzzzzzzzzn_);
                            object bzzzzzzzzzzp_(Claim.ProcedureComponent @this)
                            {
                                DataType czzzzzzzzzzh_ = @this?.Procedure;

                                return czzzzzzzzzzh_;
                            };
                            IEnumerable<object> bzzzzzzzzzzq_ = context.Operators.Select<Claim.ProcedureComponent, object>(bzzzzzzzzzzo_, bzzzzzzzzzzp_);
                            bool? bzzzzzzzzzzr_(object @this)
                            {
                                object czzzzzzzzzzi_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? czzzzzzzzzzj_ = context.Operators.Not((bool?)(czzzzzzzzzzi_ is null));

                                return czzzzzzzzzzj_;
                            };
                            IEnumerable<object> bzzzzzzzzzzs_ = context.Operators.Where<object>(bzzzzzzzzzzq_, bzzzzzzzzzzr_);
                            object bzzzzzzzzzzt_(object @this)
                            {
                                object czzzzzzzzzzk_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return czzzzzzzzzzk_;
                            };
                            IEnumerable<object> bzzzzzzzzzzu_ = context.Operators.Select<object, object>(bzzzzzzzzzzs_, bzzzzzzzzzzt_);
                            IEnumerable<object> bzzzzzzzzzzv_ = context.Operators.FlattenLateBoundList(bzzzzzzzzzzu_);
                            Coding bzzzzzzzzzzw_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> bzzzzzzzzzzx_ = context.Operators.Select<object, Coding>(bzzzzzzzzzzv_, bzzzzzzzzzzw_);
                            bool? bzzzzzzzzzzy_(Coding HeaderCode)
                            {
                                Code czzzzzzzzzzl_ = HeaderCode?.CodeElement;
                                string czzzzzzzzzzm_ = czzzzzzzzzzl_?.Value;
                                IEnumerable<string> czzzzzzzzzzn_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? czzzzzzzzzzo_ = context.Operators.In<string>(czzzzzzzzzzm_, czzzzzzzzzzn_);

                                return czzzzzzzzzzo_;
                            };
                            IEnumerable<Coding> bzzzzzzzzzzz_ = context.Operators.Where<Coding>(bzzzzzzzzzzx_, bzzzzzzzzzzy_);
                            bool? czzzzzzzzzza_ = context.Operators.Exists<Coding>(bzzzzzzzzzzz_);
                            bool? czzzzzzzzzzb_ = context.Operators.Or(bzzzzzzzzzzl_, czzzzzzzzzza_);

                            return czzzzzzzzzzb_;
                        };
                        IEnumerable<Claim.ItemComponent> bzzzzzzzzzzf_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bzzzzzzzzzzd_, bzzzzzzzzzze_);

                        return bzzzzzzzzzzf_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? azzzzzzzzzzx_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, ClaimofInterest, azzzzzzzzzzw_());
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] azzzzzzzzzzy_ = [
                    azzzzzzzzzzx_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? azzzzzzzzzzz_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? czzzzzzzzzzp_()
                    {
                        bool czzzzzzzzzzq_()
                        {
                            IEnumerable<Claim.ItemComponent> czzzzzzzzzzr_ = LineItemDefinition?.LineItems;
                            bool? czzzzzzzzzzs_ = context.Operators.Exists<Claim.ItemComponent>(czzzzzzzzzzr_);

                            return czzzzzzzzzzs_ ?? false;
                        };
                        if (czzzzzzzzzzq_())
                        {
                            Claim czzzzzzzzzzt_ = LineItemDefinition?.Claim;
                            IEnumerable<Claim.ItemComponent> czzzzzzzzzzu_ = LineItemDefinition?.LineItems;
                            bool? czzzzzzzzzzv_(Claim.ItemComponent @this)
                            {
                                DataType dzzzzzzzzzzd_ = @this?.Serviced;
                                bool? dzzzzzzzzzze_ = context.Operators.Not((bool?)(dzzzzzzzzzzd_ is null));

                                return dzzzzzzzzzze_;
                            };
                            IEnumerable<Claim.ItemComponent> czzzzzzzzzzw_ = context.Operators.Where<Claim.ItemComponent>(czzzzzzzzzzu_, czzzzzzzzzzv_);
                            object czzzzzzzzzzx_(Claim.ItemComponent @this)
                            {
                                DataType dzzzzzzzzzzf_ = @this?.Serviced;

                                return dzzzzzzzzzzf_;
                            };
                            IEnumerable<object> czzzzzzzzzzy_ = context.Operators.Select<Claim.ItemComponent, object>(czzzzzzzzzzw_, czzzzzzzzzzx_);
                            CqlInterval<CqlDateTime> czzzzzzzzzzz_(object NormalDate)
                            {
                                CqlInterval<CqlDateTime> dzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                return dzzzzzzzzzzg_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzza_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(czzzzzzzzzzy_, czzzzzzzzzzz_);
                            IEnumerable<CqlInterval<CqlDateTime>> dzzzzzzzzzzb_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(dzzzzzzzzzza_);
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzc_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, czzzzzzzzzzt_, dzzzzzzzzzzb_);

                            return dzzzzzzzzzzc_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return czzzzzzzzzzp_();
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzzza_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)azzzzzzzzzzy_, azzzzzzzzzzz_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> bzzzzzzzzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzzza_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? bzzzzzzzzzzc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(bzzzzzzzzzzb_);

                return bzzzzzzzzzzc_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzzs_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzzzq_, azzzzzzzzzzr_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzzzs_);
            bool? azzzzzzzzzzu_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? dzzzzzzzzzzh_ = context.Operators.Not((bool?)(FinalList is null));

                return dzzzzzzzzzzh_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzzv_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(azzzzzzzzzzt_, azzzzzzzzzzu_);

            return azzzzzzzzzzv_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> azzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)azzzzzzzzzzk_, azzzzzzzzzzl_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> azzzzzzzzzzn_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(azzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> azzzzzzzzzzo_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(azzzzzzzzzzn_);

        return azzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Medical Claims With Diagnosis")]
    public (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Medical_Claims_With_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> dzzzzzzzzzzi_ = this.Professional_or_Institutional_Claims(context, claim);
        string dzzzzzzzzzzj_(CqlCode d)
        {
            string dzzzzzzzzzzs_ = d?.code;

            return dzzzzzzzzzzs_;
        };
        IEnumerable<string> dzzzzzzzzzzk_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, dzzzzzzzzzzj_);
        IEnumerable<string> dzzzzzzzzzzl_ = context.Operators.Distinct<string>(dzzzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? dzzzzzzzzzzm_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, dzzzzzzzzzzi_, dzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] dzzzzzzzzzzn_ = [
            dzzzzzzzzzzm_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> dzzzzzzzzzzt_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> ezzzzzzzzzza_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? ezzzzzzzzzzb_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> ezzzzzzzzzzd_ = DiagnosisLine?.Diagnosis;
                        bool? ezzzzzzzzzze_(Claim.DiagnosisComponent @this)
                        {
                            DataType ezzzzzzzzzzs_ = @this?.Diagnosis;
                            bool? ezzzzzzzzzzt_ = context.Operators.Not((bool?)(ezzzzzzzzzzs_ is null));

                            return ezzzzzzzzzzt_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> ezzzzzzzzzzf_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)ezzzzzzzzzzd_, ezzzzzzzzzze_);
                        object ezzzzzzzzzzg_(Claim.DiagnosisComponent @this)
                        {
                            DataType ezzzzzzzzzzu_ = @this?.Diagnosis;

                            return ezzzzzzzzzzu_;
                        };
                        IEnumerable<object> ezzzzzzzzzzh_ = context.Operators.Select<Claim.DiagnosisComponent, object>(ezzzzzzzzzzf_, ezzzzzzzzzzg_);
                        bool? ezzzzzzzzzzi_(object @this)
                        {
                            object ezzzzzzzzzzv_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? ezzzzzzzzzzw_ = context.Operators.Not((bool?)(ezzzzzzzzzzv_ is null));

                            return ezzzzzzzzzzw_;
                        };
                        IEnumerable<object> ezzzzzzzzzzj_ = context.Operators.Where<object>(ezzzzzzzzzzh_, ezzzzzzzzzzi_);
                        object ezzzzzzzzzzk_(object @this)
                        {
                            object ezzzzzzzzzzx_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return ezzzzzzzzzzx_;
                        };
                        IEnumerable<object> ezzzzzzzzzzl_ = context.Operators.Select<object, object>(ezzzzzzzzzzj_, ezzzzzzzzzzk_);
                        IEnumerable<object> ezzzzzzzzzzm_ = context.Operators.FlattenLateBoundList(ezzzzzzzzzzl_);
                        Coding ezzzzzzzzzzn_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> ezzzzzzzzzzo_ = context.Operators.Select<object, Coding>(ezzzzzzzzzzm_, ezzzzzzzzzzn_);
                        bool? ezzzzzzzzzzp_(Coding HeaderCode)
                        {
                            Code ezzzzzzzzzzy_ = HeaderCode?.CodeElement;
                            string ezzzzzzzzzzz_ = ezzzzzzzzzzy_?.Value;
                            IEnumerable<string> fzzzzzzzzzza_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? fzzzzzzzzzzb_ = context.Operators.In<string>(ezzzzzzzzzzz_, fzzzzzzzzzza_);

                            return fzzzzzzzzzzb_;
                        };
                        IEnumerable<Coding> ezzzzzzzzzzq_ = context.Operators.Where<Coding>(ezzzzzzzzzzo_, ezzzzzzzzzzp_);
                        bool? ezzzzzzzzzzr_ = context.Operators.Exists<Coding>(ezzzzzzzzzzq_);

                        return ezzzzzzzzzzr_;
                    };
                    IEnumerable<Claim> ezzzzzzzzzzc_ = context.Operators.Where<Claim>(ezzzzzzzzzza_, ezzzzzzzzzzb_);

                    return ezzzzzzzzzzc_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? dzzzzzzzzzzu_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, dzzzzzzzzzzt_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] dzzzzzzzzzzv_ = [
                dzzzzzzzzzzu_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? HeaderDefinition)
            {
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzc_()
                {
                    bool fzzzzzzzzzzh_()
                    {
                        IEnumerable<Claim> fzzzzzzzzzzi_ = HeaderDefinition?.DiagnosisItems;
                        bool? fzzzzzzzzzzj_ = context.Operators.Exists<Claim>(fzzzzzzzzzzi_);

                        return fzzzzzzzzzzj_ ?? false;
                    };
                    if (fzzzzzzzzzzh_())
                    {
                        IEnumerable<Claim> fzzzzzzzzzzk_ = HeaderDefinition?.DiagnosisItems;
                        bool? fzzzzzzzzzzm_(Claim @this)
                        {
                            List<Claim.ItemComponent> fzzzzzzzzzzv_ = @this?.Item;
                            bool? fzzzzzzzzzzw_ = context.Operators.Not((bool?)(fzzzzzzzzzzv_ is null));

                            return fzzzzzzzzzzw_;
                        };
                        IEnumerable<Claim> fzzzzzzzzzzn_ = context.Operators.Where<Claim>(fzzzzzzzzzzk_, fzzzzzzzzzzm_);
                        List<Claim.ItemComponent> fzzzzzzzzzzo_(Claim @this)
                        {
                            List<Claim.ItemComponent> fzzzzzzzzzzx_ = @this?.Item;

                            return fzzzzzzzzzzx_;
                        };
                        IEnumerable<List<Claim.ItemComponent>> fzzzzzzzzzzp_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(fzzzzzzzzzzn_, fzzzzzzzzzzo_);
                        IEnumerable<Claim.ItemComponent> fzzzzzzzzzzq_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)fzzzzzzzzzzp_);
                        CqlInterval<CqlDateTime> fzzzzzzzzzzr_(Claim.ItemComponent NormalDate)
                        {
                            DataType fzzzzzzzzzzy_ = NormalDate?.Serviced;
                            CqlInterval<CqlDateTime> fzzzzzzzzzzz_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, fzzzzzzzzzzy_);

                            return fzzzzzzzzzzz_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzs_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(fzzzzzzzzzzq_, fzzzzzzzzzzr_);
                        IEnumerable<CqlInterval<CqlDateTime>> fzzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(fzzzzzzzzzzs_);
                        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzu_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, fzzzzzzzzzzk_, fzzzzzzzzzzt_);

                        return fzzzzzzzzzzu_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] fzzzzzzzzzzd_ = [
                    fzzzzzzzzzzc_(),
                ];
                bool? fzzzzzzzzzze_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? gzzzzzzzzzza_ = context.Operators.Not((bool?)(FinalList is null));

                    return gzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)fzzzzzzzzzzd_, fzzzzzzzzzze_);
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzzzzf_);

                return fzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)dzzzzzzzzzzv_, dzzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzx_);
            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzy_);

            return dzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)dzzzzzzzzzzn_, dzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzq_);

        return dzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition("Pharmacy Claim With Medication")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> Pharmacy_Claim_With_Medication(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> MedicationCodes)
    {
        IEnumerable<Claim> gzzzzzzzzzzb_ = this.Pharmacy_Claims(context, claim);
        string gzzzzzzzzzzc_(CqlCode p)
        {
            string gzzzzzzzzzzk_ = p?.code;

            return gzzzzzzzzzzk_;
        };
        IEnumerable<string> gzzzzzzzzzzd_ = context.Operators.Select<CqlCode, string>(MedicationCodes, gzzzzzzzzzzc_);
        IEnumerable<string> gzzzzzzzzzze_ = context.Operators.Distinct<string>(gzzzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? gzzzzzzzzzzf_ = (CqlTupleMetadata_CZJDcULSYFOUeGSUcDccghjMK, gzzzzzzzzzzb_, gzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?[] gzzzzzzzzzzg_ = [
            gzzzzzzzzzzf_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> gzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)? ClaimWithMedication)
        {
            IEnumerable<Claim> gzzzzzzzzzzl_ = ClaimWithMedication?.PharmacyClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? gzzzzzzzzzzm_(Claim Pharmacy)
            {
                List<Claim.ItemComponent> gzzzzzzzzzzq_ = Pharmacy?.Item;
                bool? gzzzzzzzzzzr_(Claim.ItemComponent ItemOnLine)
                {
                    CodeableConcept gzzzzzzzzzzy_ = ItemOnLine?.ProductOrService;
                    CqlConcept gzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, gzzzzzzzzzzy_);
                    CqlCode[] hzzzzzzzzzza_ = gzzzzzzzzzzz_?.codes;
                    bool? hzzzzzzzzzzb_(CqlCode LineCode)
                    {
                        string hzzzzzzzzzze_ = LineCode?.code;
                        IEnumerable<string> hzzzzzzzzzzf_ = ClaimWithMedication?.MedicationsAsStrings;
                        bool? hzzzzzzzzzzg_ = context.Operators.In<string>(hzzzzzzzzzze_, hzzzzzzzzzzf_);

                        return hzzzzzzzzzzg_;
                    };
                    IEnumerable<CqlCode> hzzzzzzzzzzc_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)hzzzzzzzzzza_, hzzzzzzzzzzb_);
                    bool? hzzzzzzzzzzd_ = context.Operators.Exists<CqlCode>(hzzzzzzzzzzc_);

                    return hzzzzzzzzzzd_;
                };
                IEnumerable<Claim.ItemComponent> gzzzzzzzzzzs_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)gzzzzzzzzzzq_, gzzzzzzzzzzr_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? gzzzzzzzzzzt_ = (CqlTupleMetadata_HSdidNdfHCNCFSUTgBiYLcgXP, Pharmacy, gzzzzzzzzzzs_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?[] gzzzzzzzzzzu_ = [
                    gzzzzzzzzzzt_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? gzzzzzzzzzzv_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)? LineItemDefinition)
                {
                    Claim hzzzzzzzzzzh_ = LineItemDefinition?.Claim;
                    Claim[] hzzzzzzzzzzi_ = [
                        hzzzzzzzzzzh_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? hzzzzzzzzzzj_(Claim ClaimLines)
                    {
                        List<Claim.ItemComponent> hzzzzzzzzzzm_ = ClaimLines?.Item;
                        bool? hzzzzzzzzzzn_(Claim.ItemComponent i)
                        {
                            CodeableConcept hzzzzzzzzzzw_ = i?.ProductOrService;
                            CqlConcept hzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, hzzzzzzzzzzw_);
                            CqlCode[] hzzzzzzzzzzy_ = hzzzzzzzzzzx_?.codes;
                            bool? hzzzzzzzzzzz_(CqlCode LineCode)
                            {
                                string izzzzzzzzzzc_ = LineCode?.code;
                                IEnumerable<string> izzzzzzzzzzd_ = ClaimWithMedication?.MedicationsAsStrings;
                                bool? izzzzzzzzzze_ = context.Operators.In<string>(izzzzzzzzzzc_, izzzzzzzzzzd_);

                                return izzzzzzzzzze_;
                            };
                            IEnumerable<CqlCode> izzzzzzzzzza_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)hzzzzzzzzzzy_, hzzzzzzzzzzz_);
                            bool? izzzzzzzzzzb_ = context.Operators.Exists<CqlCode>(izzzzzzzzzza_);

                            return izzzzzzzzzzb_;
                        };
                        IEnumerable<Claim.ItemComponent> hzzzzzzzzzzo_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)hzzzzzzzzzzm_, hzzzzzzzzzzn_);
                        (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? hzzzzzzzzzzp_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDateTime> izzzzzzzzzzf_()
                            {
                                bool izzzzzzzzzzh_()
                                {
                                    Quantity izzzzzzzzzzi_ = i?.Quantity;
                                    bool? izzzzzzzzzzj_ = context.Operators.Not((bool?)(izzzzzzzzzzi_ is null));

                                    return izzzzzzzzzzj_ ?? false;
                                };
                                if (izzzzzzzzzzh_())
                                {
                                    CqlInterval<CqlDateTime> izzzzzzzzzzk_()
                                    {
                                        bool izzzzzzzzzzl_()
                                        {
                                            DataType izzzzzzzzzzm_ = i?.Serviced;
                                            bool izzzzzzzzzzn_ = izzzzzzzzzzm_ is Period;

                                            return izzzzzzzzzzn_;
                                        };
                                        if (izzzzzzzzzzl_())
                                        {
                                            DataType izzzzzzzzzzo_ = i?.Serviced;
                                            CqlInterval<CqlDateTime> izzzzzzzzzzp_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzzo_);
                                            CqlDateTime izzzzzzzzzzq_ = context.Operators.Start(izzzzzzzzzzp_);
                                            CqlInterval<CqlDateTime> izzzzzzzzzzs_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, izzzzzzzzzzo_);
                                            CqlDateTime izzzzzzzzzzt_ = context.Operators.Start(izzzzzzzzzzs_);
                                            Quantity izzzzzzzzzzu_ = i?.Quantity;
                                            FhirDecimal izzzzzzzzzzv_ = izzzzzzzzzzu_?.ValueElement;
                                            decimal? izzzzzzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, izzzzzzzzzzv_);
                                            CqlDateTime izzzzzzzzzzx_ = context.Operators.Add(izzzzzzzzzzt_, new CqlQuantity(izzzzzzzzzzw_, "day"));
                                            CqlQuantity izzzzzzzzzzy_ = context.Operators.Quantity(1m, "day");
                                            CqlDateTime izzzzzzzzzzz_ = context.Operators.Subtract(izzzzzzzzzzx_, izzzzzzzzzzy_);
                                            CqlInterval<CqlDateTime> jzzzzzzzzzza_ = context.Operators.Interval(izzzzzzzzzzq_, izzzzzzzzzzz_, true, true);

                                            return jzzzzzzzzzza_;
                                        }
                                        else
                                        {
                                            DataType jzzzzzzzzzzb_ = i?.Serviced;
                                            CqlDate jzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzzzzzzb_ as Date);
                                            CqlDate jzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzzzzzzb_ as Date);
                                            Quantity jzzzzzzzzzzf_ = i?.Quantity;
                                            FhirDecimal jzzzzzzzzzzg_ = jzzzzzzzzzzf_?.ValueElement;
                                            decimal? jzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, jzzzzzzzzzzg_);
                                            CqlDate jzzzzzzzzzzi_ = context.Operators.Add(jzzzzzzzzzze_, new CqlQuantity(jzzzzzzzzzzh_, "day"));
                                            CqlQuantity jzzzzzzzzzzj_ = context.Operators.Quantity(1m, "day");
                                            CqlDate jzzzzzzzzzzk_ = context.Operators.Subtract(jzzzzzzzzzzi_, jzzzzzzzzzzj_);
                                            CqlInterval<CqlDate> jzzzzzzzzzzl_ = context.Operators.Interval(jzzzzzzzzzzc_, jzzzzzzzzzzk_, true, true);
                                            CqlDate jzzzzzzzzzzm_ = jzzzzzzzzzzl_?.low;
                                            CqlDateTime jzzzzzzzzzzn_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzm_);
                                            CqlDate jzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzzzzzzb_ as Date);
                                            CqlDate jzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzzzzzzb_ as Date);
                                            FhirDecimal jzzzzzzzzzzt_ = jzzzzzzzzzzf_?.ValueElement;
                                            decimal? jzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, jzzzzzzzzzzt_);
                                            CqlDate jzzzzzzzzzzv_ = context.Operators.Add(jzzzzzzzzzzr_, new CqlQuantity(jzzzzzzzzzzu_, "day"));
                                            CqlDate jzzzzzzzzzzx_ = context.Operators.Subtract(jzzzzzzzzzzv_, jzzzzzzzzzzj_);
                                            CqlInterval<CqlDate> jzzzzzzzzzzy_ = context.Operators.Interval(jzzzzzzzzzzp_, jzzzzzzzzzzx_, true, true);
                                            CqlDate jzzzzzzzzzzz_ = jzzzzzzzzzzy_?.high;
                                            CqlDateTime kzzzzzzzzzza_ = context.Operators.ConvertDateToDateTime(jzzzzzzzzzzz_);
                                            CqlDate kzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzzzzzzb_ as Date);
                                            CqlDate kzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzzzzzzb_ as Date);
                                            FhirDecimal kzzzzzzzzzzg_ = jzzzzzzzzzzf_?.ValueElement;
                                            decimal? kzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, kzzzzzzzzzzg_);
                                            CqlDate kzzzzzzzzzzi_ = context.Operators.Add(kzzzzzzzzzze_, new CqlQuantity(kzzzzzzzzzzh_, "day"));
                                            CqlDate kzzzzzzzzzzk_ = context.Operators.Subtract(kzzzzzzzzzzi_, jzzzzzzzzzzj_);
                                            CqlInterval<CqlDate> kzzzzzzzzzzl_ = context.Operators.Interval(kzzzzzzzzzzc_, kzzzzzzzzzzk_, true, true);
                                            bool? kzzzzzzzzzzm_ = kzzzzzzzzzzl_?.lowClosed;
                                            CqlDate kzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzzzzzzb_ as Date);
                                            CqlDate kzzzzzzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzzzzzzb_ as Date);
                                            FhirDecimal kzzzzzzzzzzs_ = jzzzzzzzzzzf_?.ValueElement;
                                            decimal? kzzzzzzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, kzzzzzzzzzzs_);
                                            CqlDate kzzzzzzzzzzu_ = context.Operators.Add(kzzzzzzzzzzq_, new CqlQuantity(kzzzzzzzzzzt_, "day"));
                                            CqlDate kzzzzzzzzzzw_ = context.Operators.Subtract(kzzzzzzzzzzu_, jzzzzzzzzzzj_);
                                            CqlInterval<CqlDate> kzzzzzzzzzzx_ = context.Operators.Interval(kzzzzzzzzzzo_, kzzzzzzzzzzw_, true, true);
                                            bool? kzzzzzzzzzzy_ = kzzzzzzzzzzx_?.highClosed;
                                            CqlInterval<CqlDateTime> kzzzzzzzzzzz_ = context.Operators.Interval(jzzzzzzzzzzn_, kzzzzzzzzzza_, kzzzzzzzzzzm_, kzzzzzzzzzzy_);

                                            return kzzzzzzzzzzz_;
                                        }
                                    };

                                    return izzzzzzzzzzk_();
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDateTime>;
                                }
                            };
                            (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? izzzzzzzzzzg_ = (CqlTupleMetadata_HDUYFgZGRCJCdTeEcMSVCMQNN, izzzzzzzzzzf_());

                            return izzzzzzzzzzg_;
                        };
                        IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> hzzzzzzzzzzq_ = context.Operators.Select<Claim.ItemComponent, (CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?>(hzzzzzzzzzzo_, hzzzzzzzzzzp_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? hzzzzzzzzzzr_ = (CqlTupleMetadata_fQfNOLePNSNdOZROKRAfMQPE, hzzzzzzzzzzq_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?[] hzzzzzzzzzzs_ = [
                            hzzzzzzzzzzr_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? hzzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)? ItemCalculation)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? lzzzzzzzzzza_()
                            {
                                bool lzzzzzzzzzzb_()
                                {
                                    IEnumerable<Claim.ItemComponent> lzzzzzzzzzzc_ = LineItemDefinition?.LineItems;
                                    bool? lzzzzzzzzzzd_ = context.Operators.Exists<Claim.ItemComponent>(lzzzzzzzzzzc_);

                                    return lzzzzzzzzzzd_ ?? false;
                                };
                                if (lzzzzzzzzzzb_())
                                {
                                    Claim lzzzzzzzzzze_ = LineItemDefinition?.Claim;
                                    IEnumerable<Claim.ItemComponent> lzzzzzzzzzzf_ = LineItemDefinition?.LineItems;
                                    bool? lzzzzzzzzzzh_(Claim.ItemComponent @this)
                                    {
                                        DataType lzzzzzzzzzzs_ = @this?.Serviced;
                                        bool? lzzzzzzzzzzt_ = context.Operators.Not((bool?)(lzzzzzzzzzzs_ is null));

                                        return lzzzzzzzzzzt_;
                                    };
                                    IEnumerable<Claim.ItemComponent> lzzzzzzzzzzi_ = context.Operators.Where<Claim.ItemComponent>(lzzzzzzzzzzf_, lzzzzzzzzzzh_);
                                    object lzzzzzzzzzzj_(Claim.ItemComponent @this)
                                    {
                                        DataType lzzzzzzzzzzu_ = @this?.Serviced;

                                        return lzzzzzzzzzzu_;
                                    };
                                    IEnumerable<object> lzzzzzzzzzzk_ = context.Operators.Select<Claim.ItemComponent, object>(lzzzzzzzzzzi_, lzzzzzzzzzzj_);
                                    CqlInterval<CqlDateTime> lzzzzzzzzzzl_(object NormalDate)
                                    {
                                        CqlInterval<CqlDateTime> lzzzzzzzzzzv_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, NormalDate);

                                        return lzzzzzzzzzzv_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzm_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(lzzzzzzzzzzk_, lzzzzzzzzzzl_);
                                    IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(lzzzzzzzzzzm_);
                                    IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> lzzzzzzzzzzo_ = ItemCalculation?.CoveredDays;
                                    CqlInterval<CqlDateTime> lzzzzzzzzzzp_((CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)? d)
                                    {
                                        CqlInterval<CqlDateTime> lzzzzzzzzzzw_ = d?.DaysSupplyInterval;

                                        return lzzzzzzzzzzw_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> lzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?, CqlInterval<CqlDateTime>>(lzzzzzzzzzzo_, lzzzzzzzzzzp_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? lzzzzzzzzzzr_ = (CqlTupleMetadata_FCdHTREUGBEaiYVQNNGRPZFjf, lzzzzzzzzzze_, lzzzzzzzzzzf_, lzzzzzzzzzzn_, lzzzzzzzzzzq_);

                                    return lzzzzzzzzzzr_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?;
                                }
                            };

                            return lzzzzzzzzzza_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> hzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, CqlInterval<CqlDateTime> DaysSupplyInterval)?> CoveredDays)?>)hzzzzzzzzzzs_, hzzzzzzzzzzt_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? hzzzzzzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(hzzzzzzzzzzu_);

                        return hzzzzzzzzzzv_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> hzzzzzzzzzzk_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<Claim>)hzzzzzzzzzzi_, hzzzzzzzzzzj_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? hzzzzzzzzzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(hzzzzzzzzzzk_);

                    return hzzzzzzzzzzl_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> gzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItems)?>)gzzzzzzzzzzu_, gzzzzzzzzzzv_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? gzzzzzzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(gzzzzzzzzzzw_);

                return gzzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> gzzzzzzzzzzn_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(gzzzzzzzzzzl_, gzzzzzzzzzzm_);
            bool? gzzzzzzzzzzo_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? FinalList)
            {
                bool? lzzzzzzzzzzx_ = context.Operators.Not((bool?)(FinalList is null));

                return lzzzzzzzzzzx_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> gzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(gzzzzzzzzzzn_, gzzzzzzzzzzo_);

            return gzzzzzzzzzzp_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>> gzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> PharmacyClaim, IEnumerable<string> MedicationsAsStrings)?>)gzzzzzzzzzzg_, gzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> gzzzzzzzzzzj_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>>(gzzzzzzzzzzi_);

        return gzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Medical Claims With Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> lzzzzzzzzzzy_ = this.Professional_or_Institutional_Claims(context, claim);
        string lzzzzzzzzzzz_(CqlCode d)
        {
            string mzzzzzzzzzzl_ = d?.code;

            return mzzzzzzzzzzl_;
        };
        IEnumerable<string> mzzzzzzzzzza_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, lzzzzzzzzzzz_);
        IEnumerable<string> mzzzzzzzzzzb_ = context.Operators.Distinct<string>(mzzzzzzzzzza_);
        string mzzzzzzzzzzc_(CqlCode p)
        {
            string mzzzzzzzzzzm_ = p?.code;

            return mzzzzzzzzzzm_;
        };
        IEnumerable<string> mzzzzzzzzzzd_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, mzzzzzzzzzzc_);
        IEnumerable<string> mzzzzzzzzzze_ = context.Operators.Distinct<string>(mzzzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? mzzzzzzzzzzf_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, lzzzzzzzzzzy_, mzzzzzzzzzzb_, mzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] mzzzzzzzzzzg_ = [
            mzzzzzzzzzzf_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> mzzzzzzzzzzn_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> mzzzzzzzzzzu_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? mzzzzzzzzzzv_(Claim DiagnosisLine)
                    {
                        List<Claim.DiagnosisComponent> mzzzzzzzzzzx_ = DiagnosisLine?.Diagnosis;
                        bool? mzzzzzzzzzzy_(Claim.DiagnosisComponent @this)
                        {
                            DataType nzzzzzzzzzzm_ = @this?.Diagnosis;
                            bool? nzzzzzzzzzzn_ = context.Operators.Not((bool?)(nzzzzzzzzzzm_ is null));

                            return nzzzzzzzzzzn_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> mzzzzzzzzzzz_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)mzzzzzzzzzzx_, mzzzzzzzzzzy_);
                        object nzzzzzzzzzza_(Claim.DiagnosisComponent @this)
                        {
                            DataType nzzzzzzzzzzo_ = @this?.Diagnosis;

                            return nzzzzzzzzzzo_;
                        };
                        IEnumerable<object> nzzzzzzzzzzb_ = context.Operators.Select<Claim.DiagnosisComponent, object>(mzzzzzzzzzzz_, nzzzzzzzzzza_);
                        bool? nzzzzzzzzzzc_(object @this)
                        {
                            object nzzzzzzzzzzp_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                            bool? nzzzzzzzzzzq_ = context.Operators.Not((bool?)(nzzzzzzzzzzp_ is null));

                            return nzzzzzzzzzzq_;
                        };
                        IEnumerable<object> nzzzzzzzzzzd_ = context.Operators.Where<object>(nzzzzzzzzzzb_, nzzzzzzzzzzc_);
                        object nzzzzzzzzzze_(object @this)
                        {
                            object nzzzzzzzzzzr_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                            return nzzzzzzzzzzr_;
                        };
                        IEnumerable<object> nzzzzzzzzzzf_ = context.Operators.Select<object, object>(nzzzzzzzzzzd_, nzzzzzzzzzze_);
                        IEnumerable<object> nzzzzzzzzzzg_ = context.Operators.FlattenLateBoundList(nzzzzzzzzzzf_);
                        Coding nzzzzzzzzzzh_(object @object) =>
                            (Coding)@object;
                        IEnumerable<Coding> nzzzzzzzzzzi_ = context.Operators.Select<object, Coding>(nzzzzzzzzzzg_, nzzzzzzzzzzh_);
                        bool? nzzzzzzzzzzj_(Coding HeaderCode)
                        {
                            Code nzzzzzzzzzzs_ = HeaderCode?.CodeElement;
                            string nzzzzzzzzzzt_ = nzzzzzzzzzzs_?.Value;
                            IEnumerable<string> nzzzzzzzzzzu_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                            bool? nzzzzzzzzzzv_ = context.Operators.In<string>(nzzzzzzzzzzt_, nzzzzzzzzzzu_);

                            return nzzzzzzzzzzv_;
                        };
                        IEnumerable<Coding> nzzzzzzzzzzk_ = context.Operators.Where<Coding>(nzzzzzzzzzzi_, nzzzzzzzzzzj_);
                        bool? nzzzzzzzzzzl_ = context.Operators.Exists<Coding>(nzzzzzzzzzzk_);

                        return nzzzzzzzzzzl_;
                    };
                    IEnumerable<Claim> mzzzzzzzzzzw_ = context.Operators.Where<Claim>(mzzzzzzzzzzu_, mzzzzzzzzzzv_);

                    return mzzzzzzzzzzw_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? mzzzzzzzzzzo_ = (CqlTupleMetadata_GDVcejYEWXWNHUIODacaMaBhV, mzzzzzzzzzzn_());
            (CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?[] mzzzzzzzzzzp_ = [
                mzzzzzzzzzzo_,
            ];
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)? ClaimWithProcedure)
            {
                IEnumerable<Claim> nzzzzzzzzzzw_ = ClaimWithProcedure?.DiagnosisItems;
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzzzzx_(Claim ClaimofInterest)
                {
                    Claim ozzzzzzzzzzc_()
                    {
                        if (ClaimofInterest is null)
                        {
                            return default;
                        }
                        else
                        {
                            Claim[] ozzzzzzzzzzj_ = [
                                ClaimofInterest,
                            ];
                            bool? ozzzzzzzzzzk_(Claim ItemOnLine)
                            {
                                List<Claim.ProcedureComponent> ozzzzzzzzzzn_ = ItemOnLine?.Procedure;
                                bool? ozzzzzzzzzzo_(Claim.ProcedureComponent @this)
                                {
                                    DataType pzzzzzzzzzzq_ = @this?.Procedure;
                                    bool? pzzzzzzzzzzr_ = context.Operators.Not((bool?)(pzzzzzzzzzzq_ is null));

                                    return pzzzzzzzzzzr_;
                                };
                                IEnumerable<Claim.ProcedureComponent> ozzzzzzzzzzp_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)ozzzzzzzzzzn_, ozzzzzzzzzzo_);
                                object ozzzzzzzzzzq_(Claim.ProcedureComponent @this)
                                {
                                    DataType pzzzzzzzzzzs_ = @this?.Procedure;

                                    return pzzzzzzzzzzs_;
                                };
                                IEnumerable<object> ozzzzzzzzzzr_ = context.Operators.Select<Claim.ProcedureComponent, object>(ozzzzzzzzzzp_, ozzzzzzzzzzq_);
                                bool? ozzzzzzzzzzs_(object @this)
                                {
                                    object pzzzzzzzzzzt_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                    bool? pzzzzzzzzzzu_ = context.Operators.Not((bool?)(pzzzzzzzzzzt_ is null));

                                    return pzzzzzzzzzzu_;
                                };
                                IEnumerable<object> ozzzzzzzzzzt_ = context.Operators.Where<object>(ozzzzzzzzzzr_, ozzzzzzzzzzs_);
                                object ozzzzzzzzzzu_(object @this)
                                {
                                    object pzzzzzzzzzzv_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                    return pzzzzzzzzzzv_;
                                };
                                IEnumerable<object> ozzzzzzzzzzv_ = context.Operators.Select<object, object>(ozzzzzzzzzzt_, ozzzzzzzzzzu_);
                                IEnumerable<object> ozzzzzzzzzzw_ = context.Operators.FlattenLateBoundList(ozzzzzzzzzzv_);
                                Coding ozzzzzzzzzzx_(object @object) =>
                                    (Coding)@object;
                                IEnumerable<Coding> ozzzzzzzzzzy_ = context.Operators.Select<object, Coding>(ozzzzzzzzzzw_, ozzzzzzzzzzx_);
                                bool? ozzzzzzzzzzz_(Coding ProcedureHeaderCode)
                                {
                                    Code pzzzzzzzzzzw_ = ProcedureHeaderCode?.CodeElement;
                                    string pzzzzzzzzzzx_ = pzzzzzzzzzzw_?.Value;
                                    IEnumerable<string> pzzzzzzzzzzy_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? pzzzzzzzzzzz_ = context.Operators.In<string>(pzzzzzzzzzzx_, pzzzzzzzzzzy_);

                                    return pzzzzzzzzzzz_;
                                };
                                IEnumerable<Coding> pzzzzzzzzzza_ = context.Operators.Where<Coding>(ozzzzzzzzzzy_, ozzzzzzzzzzz_);
                                bool? pzzzzzzzzzzb_ = context.Operators.Exists<Coding>(pzzzzzzzzzza_);
                                List<Claim.ItemComponent> pzzzzzzzzzzc_ = ItemOnLine?.Item;
                                bool? pzzzzzzzzzzd_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept qzzzzzzzzzza_ = @this?.ProductOrService;
                                    bool? qzzzzzzzzzzb_ = context.Operators.Not((bool?)(qzzzzzzzzzza_ is null));

                                    return qzzzzzzzzzzb_;
                                };
                                IEnumerable<Claim.ItemComponent> pzzzzzzzzzze_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)pzzzzzzzzzzc_, pzzzzzzzzzzd_);
                                CodeableConcept pzzzzzzzzzzf_(Claim.ItemComponent @this)
                                {
                                    CodeableConcept qzzzzzzzzzzc_ = @this?.ProductOrService;

                                    return qzzzzzzzzzzc_;
                                };
                                IEnumerable<CodeableConcept> pzzzzzzzzzzg_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(pzzzzzzzzzze_, pzzzzzzzzzzf_);
                                bool? pzzzzzzzzzzh_(CodeableConcept @this)
                                {
                                    List<Coding> qzzzzzzzzzzd_ = @this?.Coding;
                                    bool? qzzzzzzzzzze_ = context.Operators.Not((bool?)(qzzzzzzzzzzd_ is null));

                                    return qzzzzzzzzzze_;
                                };
                                IEnumerable<CodeableConcept> pzzzzzzzzzzi_ = context.Operators.Where<CodeableConcept>(pzzzzzzzzzzg_, pzzzzzzzzzzh_);
                                List<Coding> pzzzzzzzzzzj_(CodeableConcept @this)
                                {
                                    List<Coding> qzzzzzzzzzzf_ = @this?.Coding;

                                    return qzzzzzzzzzzf_;
                                };
                                IEnumerable<List<Coding>> pzzzzzzzzzzk_ = context.Operators.Select<CodeableConcept, List<Coding>>(pzzzzzzzzzzi_, pzzzzzzzzzzj_);
                                IEnumerable<Coding> pzzzzzzzzzzl_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)pzzzzzzzzzzk_);
                                bool? pzzzzzzzzzzm_(Coding LineCode)
                                {
                                    Code qzzzzzzzzzzg_ = LineCode?.CodeElement;
                                    string qzzzzzzzzzzh_ = qzzzzzzzzzzg_?.Value;
                                    IEnumerable<string> qzzzzzzzzzzi_ = ClaimWithDiagnosis?.ProceduresAsStrings;
                                    bool? qzzzzzzzzzzj_ = context.Operators.In<string>(qzzzzzzzzzzh_, qzzzzzzzzzzi_);

                                    return qzzzzzzzzzzj_;
                                };
                                IEnumerable<Coding> pzzzzzzzzzzn_ = context.Operators.Where<Coding>(pzzzzzzzzzzl_, pzzzzzzzzzzm_);
                                bool? pzzzzzzzzzzo_ = context.Operators.Exists<Coding>(pzzzzzzzzzzn_);
                                bool? pzzzzzzzzzzp_ = context.Operators.Or(pzzzzzzzzzzb_, pzzzzzzzzzzo_);

                                return pzzzzzzzzzzp_;
                            };
                            IEnumerable<Claim> ozzzzzzzzzzl_ = context.Operators.Where<Claim>((IEnumerable<Claim>)ozzzzzzzzzzj_, ozzzzzzzzzzk_);
                            Claim ozzzzzzzzzzm_ = context.Operators.SingletonFrom<Claim>(ozzzzzzzzzzl_);

                            return ozzzzzzzzzzm_;
                        }
                    };
                    (CqlTupleMetadata, Claim ProcedureItems)? ozzzzzzzzzzd_ = (CqlTupleMetadata_CXESjjTOQIGKICAEMDgcfPdJG, ozzzzzzzzzzc_());
                    (CqlTupleMetadata, Claim ProcedureItems)?[] ozzzzzzzzzze_ = [
                        ozzzzzzzzzzd_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzf_((CqlTupleMetadata, Claim ProcedureItems)? HeaderDefinition)
                    {
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzk_()
                        {
                            bool qzzzzzzzzzzl_()
                            {
                                Claim qzzzzzzzzzzm_ = HeaderDefinition?.ProcedureItems;
                                bool? qzzzzzzzzzzn_ = context.Operators.Not((bool?)(qzzzzzzzzzzm_ is null));

                                return qzzzzzzzzzzn_ ?? false;
                            };
                            if (qzzzzzzzzzzl_())
                            {
                                Claim qzzzzzzzzzzo_ = HeaderDefinition?.ProcedureItems;
                                List<Claim.ItemComponent> qzzzzzzzzzzq_ = qzzzzzzzzzzo_?.Item;
                                CqlInterval<CqlDateTime> qzzzzzzzzzzr_(Claim.ItemComponent NormalDate)
                                {
                                    DataType qzzzzzzzzzzv_ = NormalDate?.Serviced;
                                    CqlInterval<CqlDateTime> qzzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, qzzzzzzzzzzv_);

                                    return qzzzzzzzzzzw_;
                                };
                                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzs_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)qzzzzzzzzzzq_, qzzzzzzzzzzr_);
                                IEnumerable<CqlInterval<CqlDateTime>> qzzzzzzzzzzt_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(qzzzzzzzzzzs_);
                                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzu_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, qzzzzzzzzzzo_, qzzzzzzzzzzt_);

                                return qzzzzzzzzzzu_;
                            }
                            else
                            {
                                return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                            }
                        };

                        return qzzzzzzzzzzk_();
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim ProcedureItems)?>)ozzzzzzzzzze_, ozzzzzzzzzzf_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzzzg_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzzzh_);

                    return ozzzzzzzzzzi_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzzzzy_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzzzzw_, nzzzzzzzzzzx_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> nzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzzzzy_);
                bool? ozzzzzzzzzza_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? qzzzzzzzzzzx_ = context.Operators.Not((bool?)(FinalList is null));

                    return qzzzzzzzzzzx_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(nzzzzzzzzzzz_, ozzzzzzzzzza_);

                return ozzzzzzzzzzb_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> mzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> DiagnosisItems)?>)mzzzzzzzzzzp_, mzzzzzzzzzzq_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> mzzzzzzzzzzs_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(mzzzzzzzzzzr_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzt_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(mzzzzzzzzzzs_);

            return mzzzzzzzzzzt_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> mzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)mzzzzzzzzzzg_, mzzzzzzzzzzh_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> mzzzzzzzzzzj_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(mzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzk_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(mzzzzzzzzzzj_);

        return mzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Medical Claims With Principal Diagnosis and Procedure")]
    public IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis_and_Procedure(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<Claim> qzzzzzzzzzzy_ = this.Professional_or_Institutional_Claims(context, claim);
        string qzzzzzzzzzzz_(CqlCode d)
        {
            string rzzzzzzzzzzl_ = d?.code;

            return rzzzzzzzzzzl_;
        };
        IEnumerable<string> rzzzzzzzzzza_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, qzzzzzzzzzzz_);
        IEnumerable<string> rzzzzzzzzzzb_ = context.Operators.Distinct<string>(rzzzzzzzzzza_);
        string rzzzzzzzzzzc_(CqlCode p)
        {
            string rzzzzzzzzzzm_ = p?.code;

            return rzzzzzzzzzzm_;
        };
        IEnumerable<string> rzzzzzzzzzzd_ = context.Operators.Select<CqlCode, string>(ProductOrServiceValueSet, rzzzzzzzzzzc_);
        IEnumerable<string> rzzzzzzzzzze_ = context.Operators.Distinct<string>(rzzzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? rzzzzzzzzzzf_ = (CqlTupleMetadata_GQFgMiKhOZgECFTScigSABdXb, qzzzzzzzzzzy_, rzzzzzzzzzzb_, rzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?[] rzzzzzzzzzzg_ = [
            rzzzzzzzzzzf_,
        ];
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)? ClaimWithProcedure)
        {
            IEnumerable<Claim> rzzzzzzzzzzn_ = ClaimWithProcedure?.MedicalClaim;
            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzzzo_(Claim ClaimofInterest)
            {
                Claim rzzzzzzzzzzt_()
                {
                    if (ClaimofInterest is null)
                    {
                        return default;
                    }
                    else
                    {
                        Claim[] szzzzzzzzzza_ = [
                            ClaimofInterest,
                        ];
                        bool? szzzzzzzzzzb_(Claim ItemOnLine)
                        {
                            List<Claim.ItemComponent> szzzzzzzzzze_ = ItemOnLine?.Item;
                            bool? szzzzzzzzzzf_(Claim.ItemComponent @this)
                            {
                                CodeableConcept tzzzzzzzzzzh_ = @this?.ProductOrService;
                                bool? tzzzzzzzzzzi_ = context.Operators.Not((bool?)(tzzzzzzzzzzh_ is null));

                                return tzzzzzzzzzzi_;
                            };
                            IEnumerable<Claim.ItemComponent> szzzzzzzzzzg_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)szzzzzzzzzze_, szzzzzzzzzzf_);
                            CodeableConcept szzzzzzzzzzh_(Claim.ItemComponent @this)
                            {
                                CodeableConcept tzzzzzzzzzzj_ = @this?.ProductOrService;

                                return tzzzzzzzzzzj_;
                            };
                            IEnumerable<CodeableConcept> szzzzzzzzzzi_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(szzzzzzzzzzg_, szzzzzzzzzzh_);
                            bool? szzzzzzzzzzj_(CodeableConcept @this)
                            {
                                List<Coding> tzzzzzzzzzzk_ = @this?.Coding;
                                bool? tzzzzzzzzzzl_ = context.Operators.Not((bool?)(tzzzzzzzzzzk_ is null));

                                return tzzzzzzzzzzl_;
                            };
                            IEnumerable<CodeableConcept> szzzzzzzzzzk_ = context.Operators.Where<CodeableConcept>(szzzzzzzzzzi_, szzzzzzzzzzj_);
                            List<Coding> szzzzzzzzzzl_(CodeableConcept @this)
                            {
                                List<Coding> tzzzzzzzzzzm_ = @this?.Coding;

                                return tzzzzzzzzzzm_;
                            };
                            IEnumerable<List<Coding>> szzzzzzzzzzm_ = context.Operators.Select<CodeableConcept, List<Coding>>(szzzzzzzzzzk_, szzzzzzzzzzl_);
                            IEnumerable<Coding> szzzzzzzzzzn_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)szzzzzzzzzzm_);
                            bool? szzzzzzzzzzo_(Coding LineCode)
                            {
                                Code tzzzzzzzzzzn_ = LineCode?.CodeElement;
                                string tzzzzzzzzzzo_ = tzzzzzzzzzzn_?.Value;
                                IEnumerable<string> tzzzzzzzzzzp_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? tzzzzzzzzzzq_ = context.Operators.In<string>(tzzzzzzzzzzo_, tzzzzzzzzzzp_);

                                return tzzzzzzzzzzq_;
                            };
                            IEnumerable<Coding> szzzzzzzzzzp_ = context.Operators.Where<Coding>(szzzzzzzzzzn_, szzzzzzzzzzo_);
                            bool? szzzzzzzzzzq_ = context.Operators.Exists<Coding>(szzzzzzzzzzp_);
                            List<Claim.ProcedureComponent> szzzzzzzzzzr_ = ItemOnLine?.Procedure;
                            bool? szzzzzzzzzzs_(Claim.ProcedureComponent @this)
                            {
                                DataType tzzzzzzzzzzr_ = @this?.Procedure;
                                bool? tzzzzzzzzzzs_ = context.Operators.Not((bool?)(tzzzzzzzzzzr_ is null));

                                return tzzzzzzzzzzs_;
                            };
                            IEnumerable<Claim.ProcedureComponent> szzzzzzzzzzt_ = context.Operators.Where<Claim.ProcedureComponent>((IEnumerable<Claim.ProcedureComponent>)szzzzzzzzzzr_, szzzzzzzzzzs_);
                            object szzzzzzzzzzu_(Claim.ProcedureComponent @this)
                            {
                                DataType tzzzzzzzzzzt_ = @this?.Procedure;

                                return tzzzzzzzzzzt_;
                            };
                            IEnumerable<object> szzzzzzzzzzv_ = context.Operators.Select<Claim.ProcedureComponent, object>(szzzzzzzzzzt_, szzzzzzzzzzu_);
                            bool? szzzzzzzzzzw_(object @this)
                            {
                                object tzzzzzzzzzzu_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                                bool? tzzzzzzzzzzv_ = context.Operators.Not((bool?)(tzzzzzzzzzzu_ is null));

                                return tzzzzzzzzzzv_;
                            };
                            IEnumerable<object> szzzzzzzzzzx_ = context.Operators.Where<object>(szzzzzzzzzzv_, szzzzzzzzzzw_);
                            object szzzzzzzzzzy_(object @this)
                            {
                                object tzzzzzzzzzzw_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                                return tzzzzzzzzzzw_;
                            };
                            IEnumerable<object> szzzzzzzzzzz_ = context.Operators.Select<object, object>(szzzzzzzzzzx_, szzzzzzzzzzy_);
                            IEnumerable<object> tzzzzzzzzzza_ = context.Operators.FlattenLateBoundList(szzzzzzzzzzz_);
                            Coding tzzzzzzzzzzb_(object @object) =>
                                (Coding)@object;
                            IEnumerable<Coding> tzzzzzzzzzzc_ = context.Operators.Select<object, Coding>(tzzzzzzzzzza_, tzzzzzzzzzzb_);
                            bool? tzzzzzzzzzzd_(Coding HeaderCode)
                            {
                                Code tzzzzzzzzzzx_ = HeaderCode?.CodeElement;
                                string tzzzzzzzzzzy_ = tzzzzzzzzzzx_?.Value;
                                IEnumerable<string> tzzzzzzzzzzz_ = ClaimWithProcedure?.ProceduresAsStrings;
                                bool? uzzzzzzzzzza_ = context.Operators.In<string>(tzzzzzzzzzzy_, tzzzzzzzzzzz_);

                                return uzzzzzzzzzza_;
                            };
                            IEnumerable<Coding> tzzzzzzzzzze_ = context.Operators.Where<Coding>(tzzzzzzzzzzc_, tzzzzzzzzzzd_);
                            bool? tzzzzzzzzzzf_ = context.Operators.Exists<Coding>(tzzzzzzzzzze_);
                            bool? tzzzzzzzzzzg_ = context.Operators.Or(szzzzzzzzzzq_, tzzzzzzzzzzf_);

                            return tzzzzzzzzzzg_;
                        };
                        IEnumerable<Claim> szzzzzzzzzzc_ = context.Operators.Where<Claim>((IEnumerable<Claim>)szzzzzzzzzza_, szzzzzzzzzzb_);
                        Claim szzzzzzzzzzd_ = context.Operators.SingletonFrom<Claim>(szzzzzzzzzzc_);

                        return szzzzzzzzzzd_;
                    }
                };
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? rzzzzzzzzzzu_ = (CqlTupleMetadata_FYaKYiIDIQCIRBfhZCGRDYQLX, ClaimofInterest, rzzzzzzzzzzt_());
                (CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?[] rzzzzzzzzzzv_ = [
                    rzzzzzzzzzzu_,
                ];
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzzzw_((CqlTupleMetadata, Claim Claim, Claim ProcedureItems)? DiagnosisCheck)
                {
                    Claim uzzzzzzzzzzb_ = DiagnosisCheck?.ProcedureItems;
                    Claim[] uzzzzzzzzzzc_ = [
                        uzzzzzzzzzzb_,
                    ];
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzzzd_(Claim ClaimforDiagnosis)
                    {
                        List<Claim.ItemComponent> uzzzzzzzzzzh_ = ClaimforDiagnosis?.Item;
                        Claim uzzzzzzzzzzi_()
                        {
                            if (ClaimforDiagnosis is null)
                            {
                                return default;
                            }
                            else
                            {
                                Claim[] uzzzzzzzzzzp_ = [
                                    ClaimforDiagnosis,
                                ];
                                bool? uzzzzzzzzzzq_(Claim RightClaim)
                                {
                                    List<Claim.DiagnosisComponent> uzzzzzzzzzzt_ = RightClaim?.Diagnosis;
                                    bool? uzzzzzzzzzzu_(Claim.DiagnosisComponent RightDiagnosis)
                                    {
                                        PositiveInt uzzzzzzzzzzx_ = RightDiagnosis?.SequenceElement;
                                        Integer uzzzzzzzzzzy_ = context.Operators.Convert<Integer>(uzzzzzzzzzzx_);
                                        int? uzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, uzzzzzzzzzzy_);
                                        bool? vzzzzzzzzzza_ = context.Operators.Equal(uzzzzzzzzzzz_, 1);
                                        DataType vzzzzzzzzzzb_ = RightDiagnosis?.Diagnosis;
                                        IEnumerable<Coding> vzzzzzzzzzzc_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(vzzzzzzzzzzb_, "coding");
                                        bool? vzzzzzzzzzzd_(Coding DiagnosisCode)
                                        {
                                            Code vzzzzzzzzzzh_ = DiagnosisCode?.CodeElement;
                                            string vzzzzzzzzzzi_ = vzzzzzzzzzzh_?.Value;
                                            IEnumerable<string> vzzzzzzzzzzj_ = ClaimWithProcedure?.DiagnosesAsStrings;
                                            bool? vzzzzzzzzzzk_ = context.Operators.In<string>(vzzzzzzzzzzi_, vzzzzzzzzzzj_);

                                            return vzzzzzzzzzzk_;
                                        };
                                        IEnumerable<Coding> vzzzzzzzzzze_ = context.Operators.Where<Coding>(vzzzzzzzzzzc_, vzzzzzzzzzzd_);
                                        bool? vzzzzzzzzzzf_ = context.Operators.Exists<Coding>(vzzzzzzzzzze_);
                                        bool? vzzzzzzzzzzg_ = context.Operators.And(vzzzzzzzzzza_, vzzzzzzzzzzf_);

                                        return vzzzzzzzzzzg_;
                                    };
                                    IEnumerable<Claim.DiagnosisComponent> uzzzzzzzzzzv_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)uzzzzzzzzzzt_, uzzzzzzzzzzu_);
                                    bool? uzzzzzzzzzzw_ = context.Operators.Exists<Claim.DiagnosisComponent>(uzzzzzzzzzzv_);

                                    return uzzzzzzzzzzw_;
                                };
                                IEnumerable<Claim> uzzzzzzzzzzr_ = context.Operators.Where<Claim>((IEnumerable<Claim>)uzzzzzzzzzzp_, uzzzzzzzzzzq_);
                                Claim uzzzzzzzzzzs_ = context.Operators.SingletonFrom<Claim>(uzzzzzzzzzzr_);

                                return uzzzzzzzzzzs_;
                            }
                        };
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? uzzzzzzzzzzj_ = (CqlTupleMetadata_iYTJVNYRMBhJCKDIUSKFMUHe, (IEnumerable<Claim.ItemComponent>)uzzzzzzzzzzh_, uzzzzzzzzzzi_());
                        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?[] uzzzzzzzzzzk_ = [
                            uzzzzzzzzzzj_,
                        ];
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzzzl_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)? LineItemDefinition)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzzzzl_()
                            {
                                bool vzzzzzzzzzzm_()
                                {
                                    bool? vzzzzzzzzzzn_ = context.Operators.Not((bool?)(LineItemDefinition is null));
                                    Claim vzzzzzzzzzzo_ = LineItemDefinition?.LineItems;
                                    bool? vzzzzzzzzzzp_ = context.Operators.Not((bool?)(vzzzzzzzzzzo_ is null));
                                    bool? vzzzzzzzzzzq_ = context.Operators.And(vzzzzzzzzzzn_, vzzzzzzzzzzp_);

                                    return vzzzzzzzzzzq_ ?? false;
                                };
                                if (vzzzzzzzzzzm_())
                                {
                                    Claim vzzzzzzzzzzr_ = LineItemDefinition?.LineItems;
                                    List<Claim.ItemComponent> vzzzzzzzzzzt_ = vzzzzzzzzzzr_?.Item;
                                    CqlInterval<CqlDateTime> vzzzzzzzzzzu_(Claim.ItemComponent NormalDate)
                                    {
                                        DataType vzzzzzzzzzzx_ = NormalDate?.Serviced;
                                        CqlInterval<CqlDateTime> vzzzzzzzzzzy_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, vzzzzzzzzzzx_);

                                        return vzzzzzzzzzzy_;
                                    };
                                    IEnumerable<CqlInterval<CqlDateTime>> vzzzzzzzzzzv_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>((IEnumerable<Claim.ItemComponent>)vzzzzzzzzzzt_, vzzzzzzzzzzu_);
                                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? vzzzzzzzzzzw_ = (CqlTupleMetadata_GDUUTAIXZafehWFjcGfNKBcTd, vzzzzzzzzzzr_, vzzzzzzzzzzv_);

                                    return vzzzzzzzzzzw_;
                                }
                                else
                                {
                                    return null as (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                                }
                            };

                            return vzzzzzzzzzzl_();
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> Procedure, Claim LineItems)?>)uzzzzzzzzzzk_, uzzzzzzzzzzl_);
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(uzzzzzzzzzzm_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(uzzzzzzzzzzn_);

                        return uzzzzzzzzzzo_;
                    };
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzzze_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<Claim>)uzzzzzzzzzzc_, uzzzzzzzzzzd_);
                    IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> uzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(uzzzzzzzzzze_);
                    (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(uzzzzzzzzzzf_);

                    return uzzzzzzzzzzg_;
                };
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, Claim Claim, Claim ProcedureItems)?>)rzzzzzzzzzzv_, rzzzzzzzzzzw_);
                IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzzzx_);
                (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? rzzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzzzy_);

                return rzzzzzzzzzzz_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzzzp_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzzzn_, rzzzzzzzzzzo_);
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzzzp_);
            bool? rzzzzzzzzzzr_((CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
            {
                bool? vzzzzzzzzzzz_ = context.Operators.Not((bool?)(FinalList is null));

                return vzzzzzzzzzzz_;
            };
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(rzzzzzzzzzzq_, rzzzzzzzzzzr_);

            return rzzzzzzzzzzs_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> rzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings, IEnumerable<string> ProceduresAsStrings)?>)rzzzzzzzzzzg_, rzzzzzzzzzzh_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> rzzzzzzzzzzj_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(rzzzzzzzzzzi_);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> rzzzzzzzzzzk_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(rzzzzzzzzzzj_);

        return rzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Medical Claims With Principal Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> Medical_Claims_With_Principal_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<Claim> wzzzzzzzzzza_ = this.Professional_or_Institutional_Claims(context, claim);
        string wzzzzzzzzzzb_(CqlCode d)
        {
            string wzzzzzzzzzzk_ = d?.code;

            return wzzzzzzzzzzk_;
        };
        IEnumerable<string> wzzzzzzzzzzc_ = context.Operators.Select<CqlCode, string>(DiagnosisValueSet, wzzzzzzzzzzb_);
        IEnumerable<string> wzzzzzzzzzzd_ = context.Operators.Distinct<string>(wzzzzzzzzzzc_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? wzzzzzzzzzze_ = (CqlTupleMetadata_GKQGAFOMQbCPRXAANKASUIHMf, wzzzzzzzzzza_, wzzzzzzzzzzd_);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?[] wzzzzzzzzzzf_ = [
            wzzzzzzzzzze_,
        ];
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)? ClaimWithDiagnosis)
        {
            IEnumerable<Claim> wzzzzzzzzzzl_()
            {
                if (ClaimWithDiagnosis?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> wzzzzzzzzzzs_ = ClaimWithDiagnosis?.MedicalClaim;
                    bool? wzzzzzzzzzzt_(Claim RightClaim)
                    {
                        List<Claim.DiagnosisComponent> wzzzzzzzzzzv_ = RightClaim?.Diagnosis;
                        bool? wzzzzzzzzzzw_(Claim.DiagnosisComponent RightDiagnosis)
                        {
                            PositiveInt wzzzzzzzzzzz_ = RightDiagnosis?.SequenceElement;
                            Integer xzzzzzzzzzza_ = context.Operators.Convert<Integer>(wzzzzzzzzzzz_);
                            int? xzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, xzzzzzzzzzza_);
                            bool? xzzzzzzzzzzc_ = context.Operators.Equal(xzzzzzzzzzzb_, 1);
                            DataType xzzzzzzzzzzd_ = RightDiagnosis?.Diagnosis;
                            IEnumerable<Coding> xzzzzzzzzzze_ = context.Operators.LateBoundProperty<IEnumerable<Coding>>(xzzzzzzzzzzd_, "coding");
                            bool? xzzzzzzzzzzf_(Coding DiagnosisCode)
                            {
                                Code xzzzzzzzzzzj_ = DiagnosisCode?.CodeElement;
                                string xzzzzzzzzzzk_ = xzzzzzzzzzzj_?.Value;
                                IEnumerable<string> xzzzzzzzzzzl_ = ClaimWithDiagnosis?.DiagnosesAsStrings;
                                bool? xzzzzzzzzzzm_ = context.Operators.In<string>(xzzzzzzzzzzk_, xzzzzzzzzzzl_);

                                return xzzzzzzzzzzm_;
                            };
                            IEnumerable<Coding> xzzzzzzzzzzg_ = context.Operators.Where<Coding>(xzzzzzzzzzze_, xzzzzzzzzzzf_);
                            bool? xzzzzzzzzzzh_ = context.Operators.Exists<Coding>(xzzzzzzzzzzg_);
                            bool? xzzzzzzzzzzi_ = context.Operators.And(xzzzzzzzzzzc_, xzzzzzzzzzzh_);

                            return xzzzzzzzzzzi_;
                        };
                        IEnumerable<Claim.DiagnosisComponent> wzzzzzzzzzzx_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)wzzzzzzzzzzv_, wzzzzzzzzzzw_);
                        bool? wzzzzzzzzzzy_ = context.Operators.Exists<Claim.DiagnosisComponent>(wzzzzzzzzzzx_);

                        return wzzzzzzzzzzy_;
                    };
                    IEnumerable<Claim> wzzzzzzzzzzu_ = context.Operators.Where<Claim>(wzzzzzzzzzzs_, wzzzzzzzzzzt_);

                    return wzzzzzzzzzzu_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)? wzzzzzzzzzzm_ = (CqlTupleMetadata_DBEDLLOihLKGPWLHVWXRKfGdL, wzzzzzzzzzzl_());
            (CqlTupleMetadata, IEnumerable<Claim> LineItems)?[] wzzzzzzzzzzn_ = [
                wzzzzzzzzzzm_,
            ];
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim> LineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> xzzzzzzzzzzn_ = LineItemDefinition?.LineItems;
                (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? xzzzzzzzzzzo_(Claim ClaimWithDiagnosis)
                {
                    (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? xzzzzzzzzzzt_()
                    {
                        if ((context.Operators.Not((bool?)(ClaimWithDiagnosis is null))) ?? false)
                        {
                            IEnumerable<Claim> xzzzzzzzzzzu_ = LineItemDefinition?.LineItems;
                            bool? xzzzzzzzzzzw_(Claim @this)
                            {
                                List<Claim.ItemComponent> yzzzzzzzzzzf_ = @this?.Item;
                                bool? yzzzzzzzzzzg_ = context.Operators.Not((bool?)(yzzzzzzzzzzf_ is null));

                                return yzzzzzzzzzzg_;
                            };
                            IEnumerable<Claim> xzzzzzzzzzzx_ = context.Operators.Where<Claim>(xzzzzzzzzzzu_, xzzzzzzzzzzw_);
                            List<Claim.ItemComponent> xzzzzzzzzzzy_(Claim @this)
                            {
                                List<Claim.ItemComponent> yzzzzzzzzzzh_ = @this?.Item;

                                return yzzzzzzzzzzh_;
                            };
                            IEnumerable<List<Claim.ItemComponent>> xzzzzzzzzzzz_ = context.Operators.Select<Claim, List<Claim.ItemComponent>>(xzzzzzzzzzzx_, xzzzzzzzzzzy_);
                            IEnumerable<Claim.ItemComponent> yzzzzzzzzzza_ = context.Operators.Flatten<Claim.ItemComponent>((IEnumerable<IEnumerable<Claim.ItemComponent>>)xzzzzzzzzzzz_);
                            CqlInterval<CqlDateTime> yzzzzzzzzzzb_(Claim.ItemComponent NormalDate)
                            {
                                DataType yzzzzzzzzzzi_ = NormalDate?.Serviced;
                                CqlInterval<CqlDateTime> yzzzzzzzzzzj_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, yzzzzzzzzzzi_);

                                return yzzzzzzzzzzj_;
                            };
                            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzc_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(yzzzzzzzzzza_, yzzzzzzzzzzb_);
                            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(yzzzzzzzzzzc_);
                            (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? yzzzzzzzzzze_ = (CqlTupleMetadata_CWDDWHRXGADEbdaKXCdKbgEfg, xzzzzzzzzzzu_, yzzzzzzzzzzd_);

                            return yzzzzzzzzzze_;
                        }
                        else
                        {
                            return null as (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                        }
                    };

                    return xzzzzzzzzzzt_();
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzzzzzp_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(xzzzzzzzzzzn_, xzzzzzzzzzzo_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(xzzzzzzzzzzp_);
                bool? xzzzzzzzzzzr_((CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? yzzzzzzzzzzk_ = context.Operators.Not((bool?)(FinalList is null));

                    return yzzzzzzzzzzk_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> xzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(xzzzzzzzzzzq_, xzzzzzzzzzzr_);

                return xzzzzzzzzzzs_;
            };
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> LineItems)?>)wzzzzzzzzzzn_, wzzzzzzzzzzo_);
            IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzzzzzq_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzzzzzp_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzr_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzzzzzq_);

            return wzzzzzzzzzzr_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> DiagnosesAsStrings)?>)wzzzzzzzzzzf_, wzzzzzzzzzzg_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>> wzzzzzzzzzzi_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> wzzzzzzzzzzj_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> Claim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>>(wzzzzzzzzzzi_);

        return wzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Get All Professional and Institutional Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> yzzzzzzzzzzl_ = this.Professional_or_Institutional_Claims_Response(context, claimResponse);
        IEnumerable<Claim> yzzzzzzzzzzm_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? yzzzzzzzzzzn_ = (CqlTupleMetadata_ESGibVhJBKTGTjRhHBeNDHASE, yzzzzzzzzzzl_, yzzzzzzzzzzm_);

        return yzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Get All Paid Claim Reponses")]
    public IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> Get_All_Paid_Claim_Reponses(CqlContext context, IEnumerable<ClaimResponse> claimResponse)
    {
        bool? yzzzzzzzzzzo_(ClaimResponse ResponseItem)
        {
            Code<ClaimProcessingCodes> yzzzzzzzzzzw_ = ResponseItem?.OutcomeElement;
            string yzzzzzzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToString(context, yzzzzzzzzzzw_);
            string[] yzzzzzzzzzzy_ = [
                "complete",
                "partial",
            ];
            bool? yzzzzzzzzzzz_ = context.Operators.In<string>(yzzzzzzzzzzx_, yzzzzzzzzzzy_ as IEnumerable<string>);

            return yzzzzzzzzzzz_;
        };
        IEnumerable<ClaimResponse> yzzzzzzzzzzp_ = context.Operators.Where<ClaimResponse>(claimResponse, yzzzzzzzzzzo_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? yzzzzzzzzzzq_ = (CqlTupleMetadata_DbDPVOODdCjASWRZfBTBPUJKR, yzzzzzzzzzzp_);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?[] yzzzzzzzzzzr_ = [
            yzzzzzzzzzzq_,
        ];
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> yzzzzzzzzzzs_((CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)? ClaimResponse)
        {
            IEnumerable<ClaimResponse> zzzzzzzzzzza_ = ClaimResponse?.PaidResponse;
            (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? zzzzzzzzzzzb_(ClaimResponse ClmResp)
            {
                ResourceReference zzzzzzzzzzze_ = ClmResp?.Request;
                FhirString zzzzzzzzzzzf_ = zzzzzzzzzzze_?.ReferenceElement;
                string zzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzf_);
                string zzzzzzzzzzzh_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, zzzzzzzzzzzg_);
                List<ClaimResponse.ItemComponent> zzzzzzzzzzzi_ = ClmResp?.Item;
                bool? zzzzzzzzzzzj_(ClaimResponse.ItemComponent ResponseItem)
                {
                    List<ClaimResponse.AdjudicationComponent> zzzzzzzzzzzm_ = ResponseItem?.Adjudication;
                    bool? zzzzzzzzzzzn_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept azzzzzzzzzzzi_ = @this?.Category;
                        bool? azzzzzzzzzzzj_ = context.Operators.Not((bool?)(azzzzzzzzzzzi_ is null));

                        return azzzzzzzzzzzj_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> zzzzzzzzzzzo_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)zzzzzzzzzzzm_, zzzzzzzzzzzn_);
                    CodeableConcept zzzzzzzzzzzp_(ClaimResponse.AdjudicationComponent @this)
                    {
                        CodeableConcept azzzzzzzzzzzk_ = @this?.Category;

                        return azzzzzzzzzzzk_;
                    };
                    IEnumerable<CodeableConcept> zzzzzzzzzzzq_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, CodeableConcept>(zzzzzzzzzzzo_, zzzzzzzzzzzp_);
                    bool? zzzzzzzzzzzr_(CodeableConcept @this)
                    {
                        List<Coding> azzzzzzzzzzzl_ = @this?.Coding;
                        bool? azzzzzzzzzzzm_ = context.Operators.Not((bool?)(azzzzzzzzzzzl_ is null));

                        return azzzzzzzzzzzm_;
                    };
                    IEnumerable<CodeableConcept> zzzzzzzzzzzs_ = context.Operators.Where<CodeableConcept>(zzzzzzzzzzzq_, zzzzzzzzzzzr_);
                    List<Coding> zzzzzzzzzzzt_(CodeableConcept @this)
                    {
                        List<Coding> azzzzzzzzzzzn_ = @this?.Coding;

                        return azzzzzzzzzzzn_;
                    };
                    IEnumerable<List<Coding>> zzzzzzzzzzzu_ = context.Operators.Select<CodeableConcept, List<Coding>>(zzzzzzzzzzzs_, zzzzzzzzzzzt_);
                    IEnumerable<Coding> zzzzzzzzzzzv_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)zzzzzzzzzzzu_);
                    bool? zzzzzzzzzzzw_(Coding CategoryItem)
                    {
                        Code azzzzzzzzzzzo_ = CategoryItem?.CodeElement;
                        string azzzzzzzzzzzp_ = azzzzzzzzzzzo_?.Value;
                        bool? azzzzzzzzzzzq_ = context.Operators.Equal(azzzzzzzzzzzp_, "benefit");

                        return azzzzzzzzzzzq_;
                    };
                    IEnumerable<Coding> zzzzzzzzzzzx_ = context.Operators.Where<Coding>(zzzzzzzzzzzv_, zzzzzzzzzzzw_);
                    bool? zzzzzzzzzzzy_ = context.Operators.Exists<Coding>(zzzzzzzzzzzx_);
                    bool? azzzzzzzzzzza_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money azzzzzzzzzzzr_ = @this?.Amount;
                        bool? azzzzzzzzzzzs_ = context.Operators.Not((bool?)(azzzzzzzzzzzr_ is null));

                        return azzzzzzzzzzzs_;
                    };
                    IEnumerable<ClaimResponse.AdjudicationComponent> azzzzzzzzzzzb_ = context.Operators.Where<ClaimResponse.AdjudicationComponent>((IEnumerable<ClaimResponse.AdjudicationComponent>)zzzzzzzzzzzm_, azzzzzzzzzzza_);
                    Money azzzzzzzzzzzc_(ClaimResponse.AdjudicationComponent @this)
                    {
                        Money azzzzzzzzzzzt_ = @this?.Amount;

                        return azzzzzzzzzzzt_;
                    };
                    IEnumerable<Money> azzzzzzzzzzzd_ = context.Operators.Select<ClaimResponse.AdjudicationComponent, Money>(azzzzzzzzzzzb_, azzzzzzzzzzzc_);
                    bool? azzzzzzzzzzze_(Money DollarAmount)
                    {
                        FhirDecimal azzzzzzzzzzzu_ = DollarAmount?.ValueElement;
                        decimal? azzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, azzzzzzzzzzzu_);
                        decimal? azzzzzzzzzzzw_ = context.Operators.ConvertIntegerToDecimal(0);
                        bool? azzzzzzzzzzzx_ = context.Operators.Greater(azzzzzzzzzzzv_, azzzzzzzzzzzw_);

                        return azzzzzzzzzzzx_;
                    };
                    IEnumerable<Money> azzzzzzzzzzzf_ = context.Operators.Where<Money>(azzzzzzzzzzzd_, azzzzzzzzzzze_);
                    bool? azzzzzzzzzzzg_ = context.Operators.Exists<Money>(azzzzzzzzzzzf_);
                    bool? azzzzzzzzzzzh_ = context.Operators.And(zzzzzzzzzzzy_, azzzzzzzzzzzg_);

                    return azzzzzzzzzzzh_;
                };
                IEnumerable<ClaimResponse.ItemComponent> zzzzzzzzzzzk_ = context.Operators.Where<ClaimResponse.ItemComponent>((IEnumerable<ClaimResponse.ItemComponent>)zzzzzzzzzzzi_, zzzzzzzzzzzj_);
                (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? zzzzzzzzzzzl_ = (CqlTupleMetadata_FfbRdLZNBbFHejZXDegUDAhjO, ClmResp, zzzzzzzzzzzh_, zzzzzzzzzzzk_);

                return zzzzzzzzzzzl_;
            };
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> zzzzzzzzzzzc_ = context.Operators.Select<ClaimResponse, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(zzzzzzzzzzza_, zzzzzzzzzzzb_);
            IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> zzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(zzzzzzzzzzzc_);

            return zzzzzzzzzzzd_;
        };
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> yzzzzzzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PaidResponse)?>)yzzzzzzzzzzr_, yzzzzzzzzzzs_);
        IEnumerable<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>> yzzzzzzzzzzu_ = context.Operators.Distinct<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(yzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> yzzzzzzzzzzv_ = context.Operators.SingletonFrom<IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>>(yzzzzzzzzzzu_);

        return yzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure and Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_and_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? azzzzzzzzzzzy_(Claim AllClaims)
        {
            List<Claim.ItemComponent> bzzzzzzzzzzzd_ = AllClaims?.Item;
            bool? bzzzzzzzzzzze_(Claim.ItemComponent @this)
            {
                CodeableConcept czzzzzzzzzzzg_ = @this?.ProductOrService;
                bool? czzzzzzzzzzzh_ = context.Operators.Not((bool?)(czzzzzzzzzzzg_ is null));

                return czzzzzzzzzzzh_;
            };
            IEnumerable<Claim.ItemComponent> bzzzzzzzzzzzf_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bzzzzzzzzzzzd_, bzzzzzzzzzzze_);
            CodeableConcept bzzzzzzzzzzzg_(Claim.ItemComponent @this)
            {
                CodeableConcept czzzzzzzzzzzi_ = @this?.ProductOrService;

                return czzzzzzzzzzzi_;
            };
            IEnumerable<CodeableConcept> bzzzzzzzzzzzh_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(bzzzzzzzzzzzf_, bzzzzzzzzzzzg_);
            bool? bzzzzzzzzzzzi_(CodeableConcept @this)
            {
                List<Coding> czzzzzzzzzzzj_ = @this?.Coding;
                bool? czzzzzzzzzzzk_ = context.Operators.Not((bool?)(czzzzzzzzzzzj_ is null));

                return czzzzzzzzzzzk_;
            };
            IEnumerable<CodeableConcept> bzzzzzzzzzzzj_ = context.Operators.Where<CodeableConcept>(bzzzzzzzzzzzh_, bzzzzzzzzzzzi_);
            List<Coding> bzzzzzzzzzzzk_(CodeableConcept @this)
            {
                List<Coding> czzzzzzzzzzzl_ = @this?.Coding;

                return czzzzzzzzzzzl_;
            };
            IEnumerable<List<Coding>> bzzzzzzzzzzzl_ = context.Operators.Select<CodeableConcept, List<Coding>>(bzzzzzzzzzzzj_, bzzzzzzzzzzzk_);
            IEnumerable<Coding> bzzzzzzzzzzzm_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)bzzzzzzzzzzzl_);
            bool? bzzzzzzzzzzzn_(Coding ProductOrServiceCode)
            {
                CqlCode czzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? czzzzzzzzzzzn_ = context.Operators.In<CqlCode>(czzzzzzzzzzzm_, ProductOrServiceValueSet);

                return czzzzzzzzzzzn_;
            };
            IEnumerable<Coding> bzzzzzzzzzzzo_ = context.Operators.Where<Coding>(bzzzzzzzzzzzm_, bzzzzzzzzzzzn_);
            bool? bzzzzzzzzzzzp_ = context.Operators.Exists<Coding>(bzzzzzzzzzzzo_);
            List<Claim.DiagnosisComponent> bzzzzzzzzzzzq_ = AllClaims?.Diagnosis;
            bool? bzzzzzzzzzzzr_(Claim.DiagnosisComponent @this)
            {
                DataType czzzzzzzzzzzo_ = @this?.Diagnosis;
                bool? czzzzzzzzzzzp_ = context.Operators.Not((bool?)(czzzzzzzzzzzo_ is null));

                return czzzzzzzzzzzp_;
            };
            IEnumerable<Claim.DiagnosisComponent> bzzzzzzzzzzzs_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)bzzzzzzzzzzzq_, bzzzzzzzzzzzr_);
            object bzzzzzzzzzzzt_(Claim.DiagnosisComponent @this)
            {
                DataType czzzzzzzzzzzq_ = @this?.Diagnosis;

                return czzzzzzzzzzzq_;
            };
            IEnumerable<object> bzzzzzzzzzzzu_ = context.Operators.Select<Claim.DiagnosisComponent, object>(bzzzzzzzzzzzs_, bzzzzzzzzzzzt_);
            bool? bzzzzzzzzzzzv_(object @this)
            {
                object czzzzzzzzzzzr_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? czzzzzzzzzzzs_ = context.Operators.Not((bool?)(czzzzzzzzzzzr_ is null));

                return czzzzzzzzzzzs_;
            };
            IEnumerable<object> bzzzzzzzzzzzw_ = context.Operators.Where<object>(bzzzzzzzzzzzu_, bzzzzzzzzzzzv_);
            object bzzzzzzzzzzzx_(object @this)
            {
                object czzzzzzzzzzzt_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return czzzzzzzzzzzt_;
            };
            IEnumerable<object> bzzzzzzzzzzzy_ = context.Operators.Select<object, object>(bzzzzzzzzzzzw_, bzzzzzzzzzzzx_);
            IEnumerable<object> bzzzzzzzzzzzz_ = context.Operators.FlattenLateBoundList(bzzzzzzzzzzzy_);
            Coding czzzzzzzzzzza_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> czzzzzzzzzzzb_ = context.Operators.Select<object, Coding>(bzzzzzzzzzzzz_, czzzzzzzzzzza_);
            bool? czzzzzzzzzzzc_(Coding DiagnosisCode)
            {
                CqlCode czzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? czzzzzzzzzzzv_ = context.Operators.In<CqlCode>(czzzzzzzzzzzu_, DiagnosisValueSet);

                return czzzzzzzzzzzv_;
            };
            IEnumerable<Coding> czzzzzzzzzzzd_ = context.Operators.Where<Coding>(czzzzzzzzzzzb_, czzzzzzzzzzzc_);
            bool? czzzzzzzzzzze_ = context.Operators.Exists<Coding>(czzzzzzzzzzzd_);
            bool? czzzzzzzzzzzf_ = context.Operators.And(bzzzzzzzzzzzp_, czzzzzzzzzzze_);

            return czzzzzzzzzzzf_;
        };
        IEnumerable<Claim> azzzzzzzzzzzz_ = context.Operators.Where<Claim>(claim, azzzzzzzzzzzy_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? bzzzzzzzzzzza_(Claim ProcedureClaims)
        {
            Id czzzzzzzzzzzw_ = ProcedureClaims?.IdElement;
            List<Claim.ItemComponent> czzzzzzzzzzzx_ = ProcedureClaims?.Item;
            bool? czzzzzzzzzzzy_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept dzzzzzzzzzzzb_ = ResponseItem?.ProductOrService;
                List<Coding> dzzzzzzzzzzzc_ = dzzzzzzzzzzzb_?.Coding;
                bool? dzzzzzzzzzzzd_(Coding ProductOrServiceCode)
                {
                    CqlCode dzzzzzzzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? dzzzzzzzzzzzh_ = context.Operators.In<CqlCode>(dzzzzzzzzzzzg_, ProductOrServiceValueSet);

                    return dzzzzzzzzzzzh_;
                };
                IEnumerable<Coding> dzzzzzzzzzzze_ = context.Operators.Where<Coding>((IEnumerable<Coding>)dzzzzzzzzzzzc_, dzzzzzzzzzzzd_);
                bool? dzzzzzzzzzzzf_ = context.Operators.Exists<Coding>(dzzzzzzzzzzze_);

                return dzzzzzzzzzzzf_;
            };
            IEnumerable<Claim.ItemComponent> czzzzzzzzzzzz_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)czzzzzzzzzzzx_, czzzzzzzzzzzy_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? dzzzzzzzzzzza_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, czzzzzzzzzzzw_, czzzzzzzzzzzz_);

            return dzzzzzzzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bzzzzzzzzzzzb_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(azzzzzzzzzzzz_, bzzzzzzzzzzza_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> bzzzzzzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(bzzzzzzzzzzzb_);

        return bzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services and Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_and_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> dzzzzzzzzzzzi_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> dzzzzzzzzzzzj_ = this.Get_All_Claims_With_Procedure_and_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? dzzzzzzzzzzzk_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, dzzzzzzzzzzzi_, dzzzzzzzzzzzj_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] dzzzzzzzzzzzl_ = [
            dzzzzzzzzzzzk_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> dzzzzzzzzzzzq_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? dzzzzzzzzzzzr_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> ezzzzzzzzzzza_ = medClaim?.LineItems;
                bool? ezzzzzzzzzzzb_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ezzzzzzzzzzze_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ezzzzzzzzzzzf_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> ezzzzzzzzzzzi_ = pClaim?.LineItems;
                        bool? ezzzzzzzzzzzj_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id ezzzzzzzzzzzn_()
                            {
                                bool fzzzzzzzzzzzb_()
                                {
                                    Claim fzzzzzzzzzzzc_ = medClaim?.ClaimofInterest;
                                    bool fzzzzzzzzzzzd_ = fzzzzzzzzzzzc_ is Resource;

                                    return fzzzzzzzzzzzd_;
                                };
                                if (fzzzzzzzzzzzb_())
                                {
                                    Claim fzzzzzzzzzzze_ = medClaim?.ClaimofInterest;

                                    return (fzzzzzzzzzzze_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string ezzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzn_());
                            ClaimResponse ezzzzzzzzzzzp_ = pClaim?.Response;
                            ResourceReference ezzzzzzzzzzzq_ = ezzzzzzzzzzzp_?.Request;
                            FhirString ezzzzzzzzzzzr_ = ezzzzzzzzzzzq_?.ReferenceElement;
                            string ezzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, ezzzzzzzzzzzr_);
                            string ezzzzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, ezzzzzzzzzzzs_);
                            bool? ezzzzzzzzzzzu_ = context.Operators.Equal(ezzzzzzzzzzzo_, ezzzzzzzzzzzt_);
                            PositiveInt ezzzzzzzzzzzv_ = medClaimLineItem?.SequenceElement;
                            Integer ezzzzzzzzzzzw_ = context.Operators.Convert<Integer>(ezzzzzzzzzzzv_);
                            PositiveInt ezzzzzzzzzzzx_ = pClaimLineItem?.ItemSequenceElement;
                            Integer ezzzzzzzzzzzy_ = context.Operators.Convert<Integer>(ezzzzzzzzzzzx_);
                            bool? ezzzzzzzzzzzz_ = context.Operators.Equal(ezzzzzzzzzzzw_, ezzzzzzzzzzzy_);
                            bool? fzzzzzzzzzzza_ = context.Operators.And(ezzzzzzzzzzzu_, ezzzzzzzzzzzz_);

                            return fzzzzzzzzzzza_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> ezzzzzzzzzzzk_ = context.Operators.Where<ClaimResponse.ItemComponent>(ezzzzzzzzzzzi_, ezzzzzzzzzzzj_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? ezzzzzzzzzzzl_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ezzzzzzzzzzzm_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ezzzzzzzzzzzk_, ezzzzzzzzzzzl_);

                        return ezzzzzzzzzzzm_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> ezzzzzzzzzzzg_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ezzzzzzzzzzze_, ezzzzzzzzzzzf_);
                    bool? ezzzzzzzzzzzh_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(ezzzzzzzzzzzg_);

                    return ezzzzzzzzzzzh_;
                };
                IEnumerable<Claim.ItemComponent> ezzzzzzzzzzzc_ = context.Operators.Where<Claim.ItemComponent>(ezzzzzzzzzzza_, ezzzzzzzzzzzb_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? ezzzzzzzzzzzd_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, ezzzzzzzzzzzc_);

                return ezzzzzzzzzzzd_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> dzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(dzzzzzzzzzzzq_, dzzzzzzzzzzzr_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> dzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(dzzzzzzzzzzzs_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? dzzzzzzzzzzzu_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, dzzzzzzzzzzzt_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] dzzzzzzzzzzzv_ = [
                dzzzzzzzzzzzu_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzzf_()
                {
                    bool fzzzzzzzzzzzk_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> fzzzzzzzzzzzl_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? fzzzzzzzzzzzm_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> fzzzzzzzzzzzs_ = @this?.ClaimItem;
                            bool? fzzzzzzzzzzzt_ = context.Operators.Not((bool?)(fzzzzzzzzzzzs_ is null));

                            return fzzzzzzzzzzzt_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> fzzzzzzzzzzzn_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(fzzzzzzzzzzzl_, fzzzzzzzzzzzm_);
                        IEnumerable<Claim.ItemComponent> fzzzzzzzzzzzo_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> fzzzzzzzzzzzu_ = @this?.ClaimItem;

                            return fzzzzzzzzzzzu_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> fzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(fzzzzzzzzzzzn_, fzzzzzzzzzzzo_);
                        IEnumerable<Claim.ItemComponent> fzzzzzzzzzzzq_ = context.Operators.Flatten<Claim.ItemComponent>(fzzzzzzzzzzzp_);
                        bool? fzzzzzzzzzzzr_ = context.Operators.Exists<Claim.ItemComponent>(fzzzzzzzzzzzq_);

                        return fzzzzzzzzzzzr_ ?? false;
                    };
                    if (fzzzzzzzzzzzk_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> fzzzzzzzzzzzv_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? fzzzzzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? gzzzzzzzzzzzk_ = @this?.PaidClaim;
                            bool? gzzzzzzzzzzzl_ = context.Operators.Not((bool?)(gzzzzzzzzzzzk_ is null));

                            return gzzzzzzzzzzzl_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> fzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(fzzzzzzzzzzzv_, fzzzzzzzzzzzw_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? fzzzzzzzzzzzy_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? gzzzzzzzzzzzm_ = @this?.PaidClaim;

                            return gzzzzzzzzzzzm_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> fzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(fzzzzzzzzzzzx_, fzzzzzzzzzzzy_);
                        bool? gzzzzzzzzzzzb_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> gzzzzzzzzzzzn_ = @this?.ClaimItem;
                            bool? gzzzzzzzzzzzo_ = context.Operators.Not((bool?)(gzzzzzzzzzzzn_ is null));

                            return gzzzzzzzzzzzo_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> gzzzzzzzzzzzc_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(fzzzzzzzzzzzv_, gzzzzzzzzzzzb_);
                        IEnumerable<Claim.ItemComponent> gzzzzzzzzzzzd_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> gzzzzzzzzzzzp_ = @this?.ClaimItem;

                            return gzzzzzzzzzzzp_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> gzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(gzzzzzzzzzzzc_, gzzzzzzzzzzzd_);
                        IEnumerable<Claim.ItemComponent> gzzzzzzzzzzzf_ = context.Operators.Flatten<Claim.ItemComponent>(gzzzzzzzzzzze_);
                        CqlInterval<CqlDateTime> gzzzzzzzzzzzg_(Claim.ItemComponent PaidItem)
                        {
                            DataType gzzzzzzzzzzzq_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> gzzzzzzzzzzzr_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, gzzzzzzzzzzzq_);

                            return gzzzzzzzzzzzr_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzh_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(gzzzzzzzzzzzf_, gzzzzzzzzzzzg_);
                        IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzi_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzh_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzzzzzj_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, fzzzzzzzzzzzz_, gzzzzzzzzzzzi_);

                        return gzzzzzzzzzzzj_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] fzzzzzzzzzzzg_ = [
                    fzzzzzzzzzzzf_(),
                ];
                bool? fzzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? gzzzzzzzzzzzs_ = context.Operators.Not((bool?)(FinalList is null));

                    return gzzzzzzzzzzzs_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> fzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)fzzzzzzzzzzzg_, fzzzzzzzzzzzh_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? fzzzzzzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(fzzzzzzzzzzzi_);

                return fzzzzzzzzzzzj_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)dzzzzzzzzzzzv_, dzzzzzzzzzzzw_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzzx_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzzy_);

            return dzzzzzzzzzzzz_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)dzzzzzzzzzzzl_, dzzzzzzzzzzzm_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> dzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzzn_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? dzzzzzzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(dzzzzzzzzzzzo_);

        return dzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Service and Condition")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Service_and_Condition(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? gzzzzzzzzzzzt_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] gzzzzzzzzzzzu_ = [
            gzzzzzzzzzzzt_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzzzzd_()
            {
                bool hzzzzzzzzzzze_()
                {
                    IEnumerable<ClaimResponse> hzzzzzzzzzzzf_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> hzzzzzzzzzzzg_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? hzzzzzzzzzzzh_ = context.Operators.And((bool?)(hzzzzzzzzzzzf_ is null), (bool?)(hzzzzzzzzzzzg_ is null));

                    return hzzzzzzzzzzzh_ ?? false;
                };
                if (hzzzzzzzzzzze_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> hzzzzzzzzzzzi_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> hzzzzzzzzzzzj_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzzzzk_ = this.Get_Corresponding_Claim_for_Services_and_Conditions(context, hzzzzzzzzzzzi_, hzzzzzzzzzzzj_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return hzzzzzzzzzzzk_;
                }
            };

            return hzzzzzzzzzzzd_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)gzzzzzzzzzzzu_, gzzzzzzzzzzzv_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> gzzzzzzzzzzzx_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(gzzzzzzzzzzzw_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? gzzzzzzzzzzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(gzzzzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] gzzzzzzzzzzzz_ = [
            gzzzzzzzzzzzy_,
        ];
        bool? hzzzzzzzzzzza_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
        {
            bool? hzzzzzzzzzzzl_ = context.Operators.Not((bool?)(FinalList is null));

            return hzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> hzzzzzzzzzzzb_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)gzzzzzzzzzzzz_, hzzzzzzzzzzza_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? hzzzzzzzzzzzc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(hzzzzzzzzzzzb_);

        return hzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure or Diagnosis")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_or_Diagnosis(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        bool? hzzzzzzzzzzzm_(Claim AllClaims)
        {
            List<Claim.ItemComponent> hzzzzzzzzzzzr_ = AllClaims?.Item;
            bool? hzzzzzzzzzzzs_(Claim.ItemComponent @this)
            {
                CodeableConcept izzzzzzzzzzzu_ = @this?.ProductOrService;
                bool? izzzzzzzzzzzv_ = context.Operators.Not((bool?)(izzzzzzzzzzzu_ is null));

                return izzzzzzzzzzzv_;
            };
            IEnumerable<Claim.ItemComponent> hzzzzzzzzzzzt_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)hzzzzzzzzzzzr_, hzzzzzzzzzzzs_);
            CodeableConcept hzzzzzzzzzzzu_(Claim.ItemComponent @this)
            {
                CodeableConcept izzzzzzzzzzzw_ = @this?.ProductOrService;

                return izzzzzzzzzzzw_;
            };
            IEnumerable<CodeableConcept> hzzzzzzzzzzzv_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(hzzzzzzzzzzzt_, hzzzzzzzzzzzu_);
            bool? hzzzzzzzzzzzw_(CodeableConcept @this)
            {
                List<Coding> izzzzzzzzzzzx_ = @this?.Coding;
                bool? izzzzzzzzzzzy_ = context.Operators.Not((bool?)(izzzzzzzzzzzx_ is null));

                return izzzzzzzzzzzy_;
            };
            IEnumerable<CodeableConcept> hzzzzzzzzzzzx_ = context.Operators.Where<CodeableConcept>(hzzzzzzzzzzzv_, hzzzzzzzzzzzw_);
            List<Coding> hzzzzzzzzzzzy_(CodeableConcept @this)
            {
                List<Coding> izzzzzzzzzzzz_ = @this?.Coding;

                return izzzzzzzzzzzz_;
            };
            IEnumerable<List<Coding>> hzzzzzzzzzzzz_ = context.Operators.Select<CodeableConcept, List<Coding>>(hzzzzzzzzzzzx_, hzzzzzzzzzzzy_);
            IEnumerable<Coding> izzzzzzzzzzza_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)hzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzb_(Coding ProductOrServiceCode)
            {
                CqlCode jzzzzzzzzzzza_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? jzzzzzzzzzzzb_ = context.Operators.In<CqlCode>(jzzzzzzzzzzza_, ProductOrServiceValueSet);

                return jzzzzzzzzzzzb_;
            };
            IEnumerable<Coding> izzzzzzzzzzzc_ = context.Operators.Where<Coding>(izzzzzzzzzzza_, izzzzzzzzzzzb_);
            bool? izzzzzzzzzzzd_ = context.Operators.Exists<Coding>(izzzzzzzzzzzc_);
            List<Claim.DiagnosisComponent> izzzzzzzzzzze_ = AllClaims?.Diagnosis;
            bool? izzzzzzzzzzzf_(Claim.DiagnosisComponent @this)
            {
                DataType jzzzzzzzzzzzc_ = @this?.Diagnosis;
                bool? jzzzzzzzzzzzd_ = context.Operators.Not((bool?)(jzzzzzzzzzzzc_ is null));

                return jzzzzzzzzzzzd_;
            };
            IEnumerable<Claim.DiagnosisComponent> izzzzzzzzzzzg_ = context.Operators.Where<Claim.DiagnosisComponent>((IEnumerable<Claim.DiagnosisComponent>)izzzzzzzzzzze_, izzzzzzzzzzzf_);
            object izzzzzzzzzzzh_(Claim.DiagnosisComponent @this)
            {
                DataType jzzzzzzzzzzze_ = @this?.Diagnosis;

                return jzzzzzzzzzzze_;
            };
            IEnumerable<object> izzzzzzzzzzzi_ = context.Operators.Select<Claim.DiagnosisComponent, object>(izzzzzzzzzzzg_, izzzzzzzzzzzh_);
            bool? izzzzzzzzzzzj_(object @this)
            {
                object jzzzzzzzzzzzf_ = context.Operators.LateBoundProperty<object>(@this, "coding");
                bool? jzzzzzzzzzzzg_ = context.Operators.Not((bool?)(jzzzzzzzzzzzf_ is null));

                return jzzzzzzzzzzzg_;
            };
            IEnumerable<object> izzzzzzzzzzzk_ = context.Operators.Where<object>(izzzzzzzzzzzi_, izzzzzzzzzzzj_);
            object izzzzzzzzzzzl_(object @this)
            {
                object jzzzzzzzzzzzh_ = context.Operators.LateBoundProperty<object>(@this, "coding");

                return jzzzzzzzzzzzh_;
            };
            IEnumerable<object> izzzzzzzzzzzm_ = context.Operators.Select<object, object>(izzzzzzzzzzzk_, izzzzzzzzzzzl_);
            IEnumerable<object> izzzzzzzzzzzn_ = context.Operators.FlattenLateBoundList(izzzzzzzzzzzm_);
            Coding izzzzzzzzzzzo_(object @object) =>
                (Coding)@object;
            IEnumerable<Coding> izzzzzzzzzzzp_ = context.Operators.Select<object, Coding>(izzzzzzzzzzzn_, izzzzzzzzzzzo_);
            bool? izzzzzzzzzzzq_(Coding DiagnosisCode)
            {
                CqlCode jzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToCode(context, DiagnosisCode);
                bool? jzzzzzzzzzzzj_ = context.Operators.In<CqlCode>(jzzzzzzzzzzzi_, DiagnosisValueSet);

                return jzzzzzzzzzzzj_;
            };
            IEnumerable<Coding> izzzzzzzzzzzr_ = context.Operators.Where<Coding>(izzzzzzzzzzzp_, izzzzzzzzzzzq_);
            bool? izzzzzzzzzzzs_ = context.Operators.Exists<Coding>(izzzzzzzzzzzr_);
            bool? izzzzzzzzzzzt_ = context.Operators.Or(izzzzzzzzzzzd_, izzzzzzzzzzzs_);

            return izzzzzzzzzzzt_;
        };
        IEnumerable<Claim> hzzzzzzzzzzzn_ = context.Operators.Where<Claim>(claim, hzzzzzzzzzzzm_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? hzzzzzzzzzzzo_(Claim ProcedureClaims)
        {
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? jzzzzzzzzzzzk_()
            {
                bool jzzzzzzzzzzzl_()
                {
                    List<Claim.ItemComponent> jzzzzzzzzzzzm_ = ProcedureClaims?.Item;
                    bool? jzzzzzzzzzzzn_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept jzzzzzzzzzzzq_ = ResponseItem?.ProductOrService;
                        List<Coding> jzzzzzzzzzzzr_ = jzzzzzzzzzzzq_?.Coding;
                        bool? jzzzzzzzzzzzs_(Coding ProductOrServiceCode)
                        {
                            CqlCode jzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? jzzzzzzzzzzzw_ = context.Operators.In<CqlCode>(jzzzzzzzzzzzv_, ProductOrServiceValueSet);

                            return jzzzzzzzzzzzw_;
                        };
                        IEnumerable<Coding> jzzzzzzzzzzzt_ = context.Operators.Where<Coding>((IEnumerable<Coding>)jzzzzzzzzzzzr_, jzzzzzzzzzzzs_);
                        bool? jzzzzzzzzzzzu_ = context.Operators.Exists<Coding>(jzzzzzzzzzzzt_);

                        return jzzzzzzzzzzzu_;
                    };
                    IEnumerable<Claim.ItemComponent> jzzzzzzzzzzzo_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)jzzzzzzzzzzzm_, jzzzzzzzzzzzn_);
                    bool? jzzzzzzzzzzzp_ = context.Operators.Exists<Claim.ItemComponent>(jzzzzzzzzzzzo_);

                    return jzzzzzzzzzzzp_ ?? false;
                };
                if (jzzzzzzzzzzzl_())
                {
                    Id jzzzzzzzzzzzx_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> jzzzzzzzzzzzy_ = ProcedureClaims?.Item;
                    bool? jzzzzzzzzzzzz_(Claim.ItemComponent ResponseItem)
                    {
                        CodeableConcept kzzzzzzzzzzzc_ = ResponseItem?.ProductOrService;
                        List<Coding> kzzzzzzzzzzzd_ = kzzzzzzzzzzzc_?.Coding;
                        bool? kzzzzzzzzzzze_(Coding ProductOrServiceCode)
                        {
                            CqlCode kzzzzzzzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                            bool? kzzzzzzzzzzzi_ = context.Operators.In<CqlCode>(kzzzzzzzzzzzh_, ProductOrServiceValueSet);

                            return kzzzzzzzzzzzi_;
                        };
                        IEnumerable<Coding> kzzzzzzzzzzzf_ = context.Operators.Where<Coding>((IEnumerable<Coding>)kzzzzzzzzzzzd_, kzzzzzzzzzzze_);
                        bool? kzzzzzzzzzzzg_ = context.Operators.Exists<Coding>(kzzzzzzzzzzzf_);

                        return kzzzzzzzzzzzg_;
                    };
                    IEnumerable<Claim.ItemComponent> kzzzzzzzzzzza_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)jzzzzzzzzzzzy_, jzzzzzzzzzzzz_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? kzzzzzzzzzzzb_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, jzzzzzzzzzzzx_, kzzzzzzzzzzza_);

                    return kzzzzzzzzzzzb_;
                }
                else
                {
                    Id kzzzzzzzzzzzj_ = ProcedureClaims?.IdElement;
                    List<Claim.ItemComponent> kzzzzzzzzzzzk_ = ProcedureClaims?.Item;
                    bool? kzzzzzzzzzzzl_(Claim.ItemComponent ResponseItem)
                    {
                        PositiveInt kzzzzzzzzzzzo_ = ResponseItem?.SequenceElement;
                        Integer kzzzzzzzzzzzp_ = context.Operators.Convert<Integer>(kzzzzzzzzzzzo_);
                        int? kzzzzzzzzzzzq_ = kzzzzzzzzzzzp_?.Value;
                        bool? kzzzzzzzzzzzr_ = context.Operators.Equal(kzzzzzzzzzzzq_, 1);

                        return kzzzzzzzzzzzr_;
                    };
                    IEnumerable<Claim.ItemComponent> kzzzzzzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)kzzzzzzzzzzzk_, kzzzzzzzzzzzl_);
                    (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? kzzzzzzzzzzzn_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, ProcedureClaims, kzzzzzzzzzzzj_, kzzzzzzzzzzzm_);

                    return kzzzzzzzzzzzn_;
                }
            };

            return jzzzzzzzzzzzk_();
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> hzzzzzzzzzzzp_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(hzzzzzzzzzzzn_, hzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> hzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(hzzzzzzzzzzzp_);

        return hzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> kzzzzzzzzzzzs_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> kzzzzzzzzzzzt_ = this.Get_All_Claims_With_Procedure_or_Diagnosis(context, claim, ProductOrServiceValueSet, DiagnosisValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? kzzzzzzzzzzzu_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, kzzzzzzzzzzzs_, kzzzzzzzzzzzt_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] kzzzzzzzzzzzv_ = [
            kzzzzzzzzzzzu_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? kzzzzzzzzzzzw_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> lzzzzzzzzzzza_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? lzzzzzzzzzzzb_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzk_ = medClaim?.LineItems;
                bool? lzzzzzzzzzzzl_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> lzzzzzzzzzzzo_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> lzzzzzzzzzzzp_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> lzzzzzzzzzzzs_ = pClaim?.LineItems;
                        bool? lzzzzzzzzzzzt_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id lzzzzzzzzzzzx_()
                            {
                                bool mzzzzzzzzzzzl_()
                                {
                                    Claim mzzzzzzzzzzzm_ = medClaim?.ClaimofInterest;
                                    bool mzzzzzzzzzzzn_ = mzzzzzzzzzzzm_ is Resource;

                                    return mzzzzzzzzzzzn_;
                                };
                                if (mzzzzzzzzzzzl_())
                                {
                                    Claim mzzzzzzzzzzzo_ = medClaim?.ClaimofInterest;

                                    return (mzzzzzzzzzzzo_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string lzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToString(context, lzzzzzzzzzzzx_());
                            ClaimResponse lzzzzzzzzzzzz_ = pClaim?.Response;
                            ResourceReference mzzzzzzzzzzza_ = lzzzzzzzzzzzz_?.Request;
                            FhirString mzzzzzzzzzzzb_ = mzzzzzzzzzzza_?.ReferenceElement;
                            string mzzzzzzzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzb_);
                            string mzzzzzzzzzzzd_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, mzzzzzzzzzzzc_);
                            bool? mzzzzzzzzzzze_ = context.Operators.Equal(lzzzzzzzzzzzy_, mzzzzzzzzzzzd_);
                            PositiveInt mzzzzzzzzzzzf_ = medClaimLineItem?.SequenceElement;
                            Integer mzzzzzzzzzzzg_ = context.Operators.Convert<Integer>(mzzzzzzzzzzzf_);
                            PositiveInt mzzzzzzzzzzzh_ = pClaimLineItem?.ItemSequenceElement;
                            Integer mzzzzzzzzzzzi_ = context.Operators.Convert<Integer>(mzzzzzzzzzzzh_);
                            bool? mzzzzzzzzzzzj_ = context.Operators.Equal(mzzzzzzzzzzzg_, mzzzzzzzzzzzi_);
                            bool? mzzzzzzzzzzzk_ = context.Operators.And(mzzzzzzzzzzze_, mzzzzzzzzzzzj_);

                            return mzzzzzzzzzzzk_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> lzzzzzzzzzzzu_ = context.Operators.Where<ClaimResponse.ItemComponent>(lzzzzzzzzzzzs_, lzzzzzzzzzzzt_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? lzzzzzzzzzzzv_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> lzzzzzzzzzzzw_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(lzzzzzzzzzzzu_, lzzzzzzzzzzzv_);

                        return lzzzzzzzzzzzw_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> lzzzzzzzzzzzq_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(lzzzzzzzzzzzo_, lzzzzzzzzzzzp_);
                    bool? lzzzzzzzzzzzr_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(lzzzzzzzzzzzq_);

                    return lzzzzzzzzzzzr_;
                };
                IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzm_ = context.Operators.Where<Claim.ItemComponent>(lzzzzzzzzzzzk_, lzzzzzzzzzzzl_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? lzzzzzzzzzzzn_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, lzzzzzzzzzzzm_);

                return lzzzzzzzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(lzzzzzzzzzzza_, lzzzzzzzzzzzb_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> lzzzzzzzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(lzzzzzzzzzzzc_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? lzzzzzzzzzzze_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, lzzzzzzzzzzzd_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] lzzzzzzzzzzzf_ = [
                lzzzzzzzzzzze_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? lzzzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzp_()
                {
                    bool mzzzzzzzzzzzu_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> mzzzzzzzzzzzv_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? mzzzzzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzc_ = @this?.ClaimItem;
                            bool? nzzzzzzzzzzzd_ = context.Operators.Not((bool?)(nzzzzzzzzzzzc_ is null));

                            return nzzzzzzzzzzzd_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> mzzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(mzzzzzzzzzzzv_, mzzzzzzzzzzzw_);
                        IEnumerable<Claim.ItemComponent> mzzzzzzzzzzzy_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzzze_ = @this?.ClaimItem;

                            return nzzzzzzzzzzze_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> mzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(mzzzzzzzzzzzx_, mzzzzzzzzzzzy_);
                        IEnumerable<Claim.ItemComponent> nzzzzzzzzzzza_ = context.Operators.Flatten<Claim.ItemComponent>(mzzzzzzzzzzzz_);
                        bool? nzzzzzzzzzzzb_ = context.Operators.Exists<Claim.ItemComponent>(nzzzzzzzzzzza_);

                        return nzzzzzzzzzzzb_ ?? false;
                    };
                    if (mzzzzzzzzzzzu_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> nzzzzzzzzzzzf_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? nzzzzzzzzzzzg_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? nzzzzzzzzzzzu_ = @this?.PaidClaim;
                            bool? nzzzzzzzzzzzv_ = context.Operators.Not((bool?)(nzzzzzzzzzzzu_ is null));

                            return nzzzzzzzzzzzv_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> nzzzzzzzzzzzh_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(nzzzzzzzzzzzf_, nzzzzzzzzzzzg_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? nzzzzzzzzzzzi_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? nzzzzzzzzzzzw_ = @this?.PaidClaim;

                            return nzzzzzzzzzzzw_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> nzzzzzzzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(nzzzzzzzzzzzh_, nzzzzzzzzzzzi_);
                        bool? nzzzzzzzzzzzl_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzx_ = @this?.ClaimItem;
                            bool? nzzzzzzzzzzzy_ = context.Operators.Not((bool?)(nzzzzzzzzzzzx_ is null));

                            return nzzzzzzzzzzzy_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> nzzzzzzzzzzzm_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(nzzzzzzzzzzzf_, nzzzzzzzzzzzl_);
                        IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzn_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzz_ = @this?.ClaimItem;

                            return nzzzzzzzzzzzz_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> nzzzzzzzzzzzo_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(nzzzzzzzzzzzm_, nzzzzzzzzzzzn_);
                        IEnumerable<Claim.ItemComponent> nzzzzzzzzzzzp_ = context.Operators.Flatten<Claim.ItemComponent>(nzzzzzzzzzzzo_);
                        CqlInterval<CqlDateTime> nzzzzzzzzzzzq_(Claim.ItemComponent PaidItem)
                        {
                            DataType ozzzzzzzzzzza_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> ozzzzzzzzzzzb_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, ozzzzzzzzzzza_);

                            return ozzzzzzzzzzzb_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzr_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(nzzzzzzzzzzzp_, nzzzzzzzzzzzq_);
                        IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzs_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzr_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? nzzzzzzzzzzzt_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, nzzzzzzzzzzzj_, nzzzzzzzzzzzs_);

                        return nzzzzzzzzzzzt_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] mzzzzzzzzzzzq_ = [
                    mzzzzzzzzzzzp_(),
                ];
                bool? mzzzzzzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? ozzzzzzzzzzzc_ = context.Operators.Not((bool?)(FinalList is null));

                    return ozzzzzzzzzzzc_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> mzzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)mzzzzzzzzzzzq_, mzzzzzzzzzzzr_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? mzzzzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(mzzzzzzzzzzzs_);

                return mzzzzzzzzzzzt_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)lzzzzzzzzzzzf_, lzzzzzzzzzzzg_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> lzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(lzzzzzzzzzzzh_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? lzzzzzzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(lzzzzzzzzzzzi_);

            return lzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)kzzzzzzzzzzzv_, kzzzzzzzzzzzw_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> kzzzzzzzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(kzzzzzzzzzzzx_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? kzzzzzzzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(kzzzzzzzzzzzy_);

        return kzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Services or Conditions")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_or_Conditions(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet, IEnumerable<CqlCode> DiagnosisValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? ozzzzzzzzzzzd_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] ozzzzzzzzzzze_ = [
            ozzzzzzzzzzzd_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzzf_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzzj_()
            {
                bool ozzzzzzzzzzzk_()
                {
                    IEnumerable<ClaimResponse> ozzzzzzzzzzzl_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> ozzzzzzzzzzzm_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? ozzzzzzzzzzzn_ = context.Operators.And((bool?)(ozzzzzzzzzzzl_ is null), (bool?)(ozzzzzzzzzzzm_ is null));

                    return ozzzzzzzzzzzn_ ?? false;
                };
                if (ozzzzzzzzzzzk_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> ozzzzzzzzzzzo_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> ozzzzzzzzzzzp_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzzq_ = this.Get_Corresponding_Claim_for_Services_or_Conditions(context, ozzzzzzzzzzzo_, ozzzzzzzzzzzp_, ProductOrServiceValueSet, DiagnosisValueSet);

                    return ozzzzzzzzzzzq_;
                }
            };

            return ozzzzzzzzzzzj_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)ozzzzzzzzzzze_, ozzzzzzzzzzzf_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> ozzzzzzzzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? ozzzzzzzzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(ozzzzzzzzzzzh_);

        return ozzzzzzzzzzzi_;
    }


    [CqlExpressionDefinition("Get All Claims With Procedure Only")]
    public IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> Get_All_Claims_With_Procedure_Only(CqlContext context, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        bool? ozzzzzzzzzzzr_(Claim AllClaims)
        {
            List<Claim.ItemComponent> ozzzzzzzzzzzw_ = AllClaims?.Item;
            bool? ozzzzzzzzzzzx_(Claim.ItemComponent @this)
            {
                CodeableConcept pzzzzzzzzzzzj_ = @this?.ProductOrService;
                bool? pzzzzzzzzzzzk_ = context.Operators.Not((bool?)(pzzzzzzzzzzzj_ is null));

                return pzzzzzzzzzzzk_;
            };
            IEnumerable<Claim.ItemComponent> ozzzzzzzzzzzy_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)ozzzzzzzzzzzw_, ozzzzzzzzzzzx_);
            CodeableConcept ozzzzzzzzzzzz_(Claim.ItemComponent @this)
            {
                CodeableConcept pzzzzzzzzzzzl_ = @this?.ProductOrService;

                return pzzzzzzzzzzzl_;
            };
            IEnumerable<CodeableConcept> pzzzzzzzzzzza_ = context.Operators.Select<Claim.ItemComponent, CodeableConcept>(ozzzzzzzzzzzy_, ozzzzzzzzzzzz_);
            bool? pzzzzzzzzzzzb_(CodeableConcept @this)
            {
                List<Coding> pzzzzzzzzzzzm_ = @this?.Coding;
                bool? pzzzzzzzzzzzn_ = context.Operators.Not((bool?)(pzzzzzzzzzzzm_ is null));

                return pzzzzzzzzzzzn_;
            };
            IEnumerable<CodeableConcept> pzzzzzzzzzzzc_ = context.Operators.Where<CodeableConcept>(pzzzzzzzzzzza_, pzzzzzzzzzzzb_);
            List<Coding> pzzzzzzzzzzzd_(CodeableConcept @this)
            {
                List<Coding> pzzzzzzzzzzzo_ = @this?.Coding;

                return pzzzzzzzzzzzo_;
            };
            IEnumerable<List<Coding>> pzzzzzzzzzzze_ = context.Operators.Select<CodeableConcept, List<Coding>>(pzzzzzzzzzzzc_, pzzzzzzzzzzzd_);
            IEnumerable<Coding> pzzzzzzzzzzzf_ = context.Operators.Flatten<Coding>((IEnumerable<IEnumerable<Coding>>)pzzzzzzzzzzze_);
            bool? pzzzzzzzzzzzg_(Coding ProductOrServiceCode)
            {
                CqlCode pzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                bool? pzzzzzzzzzzzq_ = context.Operators.In<CqlCode>(pzzzzzzzzzzzp_, ProductOrServiceValueSet);

                return pzzzzzzzzzzzq_;
            };
            IEnumerable<Coding> pzzzzzzzzzzzh_ = context.Operators.Where<Coding>(pzzzzzzzzzzzf_, pzzzzzzzzzzzg_);
            bool? pzzzzzzzzzzzi_ = context.Operators.Exists<Coding>(pzzzzzzzzzzzh_);

            return pzzzzzzzzzzzi_;
        };
        IEnumerable<Claim> ozzzzzzzzzzzs_ = context.Operators.Where<Claim>(claim, ozzzzzzzzzzzr_);
        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? ozzzzzzzzzzzt_(Claim AllClaims)
        {
            Id pzzzzzzzzzzzr_ = AllClaims?.IdElement;
            List<Claim.ItemComponent> pzzzzzzzzzzzs_ = AllClaims?.Item;
            bool? pzzzzzzzzzzzt_(Claim.ItemComponent ResponseItem)
            {
                CodeableConcept pzzzzzzzzzzzw_ = ResponseItem?.ProductOrService;
                List<Coding> pzzzzzzzzzzzx_ = pzzzzzzzzzzzw_?.Coding;
                bool? pzzzzzzzzzzzy_(Coding ProductOrServiceCode)
                {
                    CqlCode qzzzzzzzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToCode(context, ProductOrServiceCode);
                    bool? qzzzzzzzzzzzc_ = context.Operators.In<CqlCode>(qzzzzzzzzzzzb_, ProductOrServiceValueSet);

                    return qzzzzzzzzzzzc_;
                };
                IEnumerable<Coding> pzzzzzzzzzzzz_ = context.Operators.Where<Coding>((IEnumerable<Coding>)pzzzzzzzzzzzx_, pzzzzzzzzzzzy_);
                bool? qzzzzzzzzzzza_ = context.Operators.Exists<Coding>(pzzzzzzzzzzzz_);

                return qzzzzzzzzzzza_;
            };
            IEnumerable<Claim.ItemComponent> pzzzzzzzzzzzu_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)pzzzzzzzzzzzs_, pzzzzzzzzzzzt_);
            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? pzzzzzzzzzzzv_ = (CqlTupleMetadata_GUCaFdHVHVNcfKfMNEFbbNGUi, AllClaims, pzzzzzzzzzzzr_, pzzzzzzzzzzzu_);

            return pzzzzzzzzzzzv_;
        };
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ozzzzzzzzzzzu_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(ozzzzzzzzzzzs_, ozzzzzzzzzzzt_);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> ozzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(ozzzzzzzzzzzu_);

        return ozzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Corresponding_Claim_for_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> qzzzzzzzzzzzd_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> qzzzzzzzzzzze_ = this.Get_All_Claims_With_Procedure_Only(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? qzzzzzzzzzzzf_ = (CqlTupleMetadata_DiTbeIhUdTbFXAOeUfBeANOcV, qzzzzzzzzzzzd_, qzzzzzzzzzzze_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?[] qzzzzzzzzzzzg_ = [
            qzzzzzzzzzzzf_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzzh_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> qzzzzzzzzzzzl_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? qzzzzzzzzzzzm_((CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> qzzzzzzzzzzzv_ = medClaim?.LineItems;
                bool? qzzzzzzzzzzzw_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> qzzzzzzzzzzzz_ = ClaimAndResponse?.PaidMedicalClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> rzzzzzzzzzzza_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> rzzzzzzzzzzzd_ = pClaim?.LineItems;
                        bool? rzzzzzzzzzzze_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id rzzzzzzzzzzzi_()
                            {
                                bool rzzzzzzzzzzzw_()
                                {
                                    Claim rzzzzzzzzzzzx_ = medClaim?.ClaimofInterest;
                                    bool rzzzzzzzzzzzy_ = rzzzzzzzzzzzx_ is Resource;

                                    return rzzzzzzzzzzzy_;
                                };
                                if (rzzzzzzzzzzzw_())
                                {
                                    Claim rzzzzzzzzzzzz_ = medClaim?.ClaimofInterest;

                                    return (rzzzzzzzzzzzz_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string rzzzzzzzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzi_());
                            ClaimResponse rzzzzzzzzzzzk_ = pClaim?.Response;
                            ResourceReference rzzzzzzzzzzzl_ = rzzzzzzzzzzzk_?.Request;
                            FhirString rzzzzzzzzzzzm_ = rzzzzzzzzzzzl_?.ReferenceElement;
                            string rzzzzzzzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToString(context, rzzzzzzzzzzzm_);
                            string rzzzzzzzzzzzo_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, rzzzzzzzzzzzn_);
                            bool? rzzzzzzzzzzzp_ = context.Operators.Equal(rzzzzzzzzzzzj_, rzzzzzzzzzzzo_);
                            PositiveInt rzzzzzzzzzzzq_ = medClaimLineItem?.SequenceElement;
                            Integer rzzzzzzzzzzzr_ = context.Operators.Convert<Integer>(rzzzzzzzzzzzq_);
                            PositiveInt rzzzzzzzzzzzs_ = pClaimLineItem?.ItemSequenceElement;
                            Integer rzzzzzzzzzzzt_ = context.Operators.Convert<Integer>(rzzzzzzzzzzzs_);
                            bool? rzzzzzzzzzzzu_ = context.Operators.Equal(rzzzzzzzzzzzr_, rzzzzzzzzzzzt_);
                            bool? rzzzzzzzzzzzv_ = context.Operators.And(rzzzzzzzzzzzp_, rzzzzzzzzzzzu_);

                            return rzzzzzzzzzzzv_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> rzzzzzzzzzzzf_ = context.Operators.Where<ClaimResponse.ItemComponent>(rzzzzzzzzzzzd_, rzzzzzzzzzzze_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? rzzzzzzzzzzzg_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> rzzzzzzzzzzzh_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(rzzzzzzzzzzzf_, rzzzzzzzzzzzg_);

                        return rzzzzzzzzzzzh_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> rzzzzzzzzzzzb_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(qzzzzzzzzzzzz_, rzzzzzzzzzzza_);
                    bool? rzzzzzzzzzzzc_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(rzzzzzzzzzzzb_);

                    return rzzzzzzzzzzzc_;
                };
                IEnumerable<Claim.ItemComponent> qzzzzzzzzzzzx_ = context.Operators.Where<Claim.ItemComponent>(qzzzzzzzzzzzv_, qzzzzzzzzzzzw_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? qzzzzzzzzzzzy_ = (CqlTupleMetadata_HANAFPgdEHHITIiaCbHRMCNfZ, medClaim, qzzzzzzzzzzzx_);

                return qzzzzzzzzzzzy_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(qzzzzzzzzzzzl_, qzzzzzzzzzzzm_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> qzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(qzzzzzzzzzzzn_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? qzzzzzzzzzzzp_ = (CqlTupleMetadata_GUibhjYMgjAQISFDJORUOccJC, qzzzzzzzzzzzo_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] qzzzzzzzzzzzq_ = [
                qzzzzzzzzzzzp_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzzr_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzza_()
                {
                    bool szzzzzzzzzzzf_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> szzzzzzzzzzzg_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? szzzzzzzzzzzh_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> szzzzzzzzzzzn_ = @this?.ClaimItem;
                            bool? szzzzzzzzzzzo_ = context.Operators.Not((bool?)(szzzzzzzzzzzn_ is null));

                            return szzzzzzzzzzzo_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> szzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(szzzzzzzzzzzg_, szzzzzzzzzzzh_);
                        IEnumerable<Claim.ItemComponent> szzzzzzzzzzzj_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> szzzzzzzzzzzp_ = @this?.ClaimItem;

                            return szzzzzzzzzzzp_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> szzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(szzzzzzzzzzzi_, szzzzzzzzzzzj_);
                        IEnumerable<Claim.ItemComponent> szzzzzzzzzzzl_ = context.Operators.Flatten<Claim.ItemComponent>(szzzzzzzzzzzk_);
                        bool? szzzzzzzzzzzm_ = context.Operators.Exists<Claim.ItemComponent>(szzzzzzzzzzzl_);

                        return szzzzzzzzzzzm_ ?? false;
                    };
                    if (szzzzzzzzzzzf_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> szzzzzzzzzzzq_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? szzzzzzzzzzzr_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? tzzzzzzzzzzzf_ = @this?.PaidClaim;
                            bool? tzzzzzzzzzzzg_ = context.Operators.Not((bool?)(tzzzzzzzzzzzf_ is null));

                            return tzzzzzzzzzzzg_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> szzzzzzzzzzzs_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(szzzzzzzzzzzq_, szzzzzzzzzzzr_);
                        (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? szzzzzzzzzzzt_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? tzzzzzzzzzzzh_ = @this?.PaidClaim;

                            return tzzzzzzzzzzzh_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> szzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?>(szzzzzzzzzzzs_, szzzzzzzzzzzt_);
                        bool? szzzzzzzzzzzw_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> tzzzzzzzzzzzi_ = @this?.ClaimItem;
                            bool? tzzzzzzzzzzzj_ = context.Operators.Not((bool?)(tzzzzzzzzzzzi_ is null));

                            return tzzzzzzzzzzzj_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> szzzzzzzzzzzx_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(szzzzzzzzzzzq_, szzzzzzzzzzzw_);
                        IEnumerable<Claim.ItemComponent> szzzzzzzzzzzy_((CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> tzzzzzzzzzzzk_ = @this?.ClaimItem;

                            return tzzzzzzzzzzzk_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> szzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(szzzzzzzzzzzx_, szzzzzzzzzzzy_);
                        IEnumerable<Claim.ItemComponent> tzzzzzzzzzzza_ = context.Operators.Flatten<Claim.ItemComponent>(szzzzzzzzzzzz_);
                        CqlInterval<CqlDateTime> tzzzzzzzzzzzb_(Claim.ItemComponent PaidItem)
                        {
                            DataType tzzzzzzzzzzzl_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> tzzzzzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, tzzzzzzzzzzzl_);

                            return tzzzzzzzzzzzm_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzc_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(tzzzzzzzzzzza_, tzzzzzzzzzzzb_);
                        IEnumerable<CqlInterval<CqlDateTime>> tzzzzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(tzzzzzzzzzzzc_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzzzzze_ = (CqlTupleMetadata_FCOUVKRRWVHcKiBDUdGgLciKR, szzzzzzzzzzzu_, tzzzzzzzzzzzd_);

                        return tzzzzzzzzzzze_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?[] szzzzzzzzzzzb_ = [
                    szzzzzzzzzzza_(),
                ];
                bool? szzzzzzzzzzzc_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? FinalList)
                {
                    bool? tzzzzzzzzzzzn_ = context.Operators.Not((bool?)(FinalList is null));

                    return tzzzzzzzzzzzn_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> szzzzzzzzzzzd_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>)szzzzzzzzzzzb_, szzzzzzzzzzzc_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? szzzzzzzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(szzzzzzzzzzzd_);

                return szzzzzzzzzzze_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzzzzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)qzzzzzzzzzzzq_, qzzzzzzzzzzzr_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzzzzzt_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzzzzzs_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzzu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzzzzzt_);

            return qzzzzzzzzzzzu_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzzzzzi_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidMedicalClaimResponse, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> MedicalClaim)?>)qzzzzzzzzzzzg_, qzzzzzzzzzzzh_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> qzzzzzzzzzzzj_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? qzzzzzzzzzzzk_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(qzzzzzzzzzzzj_);

        return qzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Provided Services Only")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? Get_Paid_Claims_for_Provided_Services_Only(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? tzzzzzzzzzzzo_ = this.Get_All_Professional_and_Institutional_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?[] tzzzzzzzzzzzp_ = [
            tzzzzzzzzzzzo_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)? MedicalClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzzzzzu_()
            {
                bool tzzzzzzzzzzzv_()
                {
                    IEnumerable<ClaimResponse> tzzzzzzzzzzzw_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> tzzzzzzzzzzzx_ = MedicalClaimAndResponse?.MedicalClaim;
                    bool? tzzzzzzzzzzzy_ = context.Operators.And((bool?)(tzzzzzzzzzzzw_ is null), (bool?)(tzzzzzzzzzzzx_ is null));

                    return tzzzzzzzzzzzy_ ?? false;
                };
                if (tzzzzzzzzzzzv_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> tzzzzzzzzzzzz_ = MedicalClaimAndResponse?.MedicalClaimResponse;
                    IEnumerable<Claim> uzzzzzzzzzzza_ = MedicalClaimAndResponse?.MedicalClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? uzzzzzzzzzzzb_ = this.Get_Corresponding_Claim_for_Services_Only(context, tzzzzzzzzzzzz_, uzzzzzzzzzzza_, ProductOrServiceValueSet);

                    return uzzzzzzzzzzzb_;
                }
            };

            return tzzzzzzzzzzzu_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> tzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> MedicalClaimResponse, IEnumerable<Claim> MedicalClaim)?>)tzzzzzzzzzzzp_, tzzzzzzzzzzzq_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?> tzzzzzzzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(tzzzzzzzzzzzr_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)? tzzzzzzzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim ClaimofInterest, Id ClaimID, IEnumerable<Claim.ItemComponent> LineItems)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod)?>(tzzzzzzzzzzzs_);

        return tzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition("Get All Pharmacy Claims and Claim Responses")]
    public (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? Get_All_Pharmacy_Claims_and_Claim_Responses(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        IEnumerable<ClaimResponse> uzzzzzzzzzzzc_ = this.Pharmacy_Claims_Response(context, claimResponse);
        IEnumerable<Claim> uzzzzzzzzzzzd_ = this.Pharmacy_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? uzzzzzzzzzzze_ = (CqlTupleMetadata_EgMIjgYNSTYejjeaeeSfTCGLV, uzzzzzzzzzzzc_, uzzzzzzzzzzzd_);

        return uzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Get Corresponding Claim for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Corresponding_Claim_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> uzzzzzzzzzzzf_ = this.Get_All_Paid_Claim_Reponses(context, claimResponse);
        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> uzzzzzzzzzzzg_ = this.Pharmacy_Claim_With_Medication(context, claim, ProductOrServiceValueSet);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? uzzzzzzzzzzzh_ = (CqlTupleMetadata_EhcebFbUeFgabTLNPALjRJQCF, uzzzzzzzzzzzf_, uzzzzzzzzzzzg_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?[] uzzzzzzzzzzzi_ = [
            uzzzzzzzzzzzh_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? uzzzzzzzzzzzj_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)? ClaimAndResponse)
        {
            IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> uzzzzzzzzzzzn_ = ClaimAndResponse?.MedicalClaim;
            (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? uzzzzzzzzzzzo_((CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? medClaim)
            {
                IEnumerable<Claim.ItemComponent> uzzzzzzzzzzzx_ = medClaim?.LineItem;
                bool? uzzzzzzzzzzzy_(Claim.ItemComponent medClaimLineItem)
                {
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzzzzzb_ = ClaimAndResponse?.PaidPharmacyClaimResponse;
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzzzzzc_((CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? pClaim)
                    {
                        IEnumerable<ClaimResponse.ItemComponent> vzzzzzzzzzzzf_ = pClaim?.LineItems;
                        bool? vzzzzzzzzzzzg_(ClaimResponse.ItemComponent pClaimLineItem)
                        {
                            Id vzzzzzzzzzzzk_()
                            {
                                bool vzzzzzzzzzzzy_()
                                {
                                    Claim vzzzzzzzzzzzz_ = medClaim?.Claim;
                                    bool wzzzzzzzzzzza_ = vzzzzzzzzzzzz_ is Resource;

                                    return wzzzzzzzzzzza_;
                                };
                                if (vzzzzzzzzzzzy_())
                                {
                                    Claim wzzzzzzzzzzzb_ = medClaim?.Claim;

                                    return (wzzzzzzzzzzzb_ as Resource).IdElement;
                                }
                                else
                                {
                                    return default;
                                }
                            };
                            string vzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzk_());
                            ClaimResponse vzzzzzzzzzzzm_ = pClaim?.Response;
                            ResourceReference vzzzzzzzzzzzn_ = vzzzzzzzzzzzm_?.Request;
                            FhirString vzzzzzzzzzzzo_ = vzzzzzzzzzzzn_?.ReferenceElement;
                            string vzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, vzzzzzzzzzzzo_);
                            string vzzzzzzzzzzzq_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, vzzzzzzzzzzzp_);
                            bool? vzzzzzzzzzzzr_ = context.Operators.Equal(vzzzzzzzzzzzl_, vzzzzzzzzzzzq_);
                            PositiveInt vzzzzzzzzzzzs_ = medClaimLineItem?.SequenceElement;
                            Integer vzzzzzzzzzzzt_ = context.Operators.Convert<Integer>(vzzzzzzzzzzzs_);
                            PositiveInt vzzzzzzzzzzzu_ = pClaimLineItem?.ItemSequenceElement;
                            Integer vzzzzzzzzzzzv_ = context.Operators.Convert<Integer>(vzzzzzzzzzzzu_);
                            bool? vzzzzzzzzzzzw_ = context.Operators.Equal(vzzzzzzzzzzzt_, vzzzzzzzzzzzv_);
                            bool? vzzzzzzzzzzzx_ = context.Operators.And(vzzzzzzzzzzzr_, vzzzzzzzzzzzw_);

                            return vzzzzzzzzzzzx_;
                        };
                        IEnumerable<ClaimResponse.ItemComponent> vzzzzzzzzzzzh_ = context.Operators.Where<ClaimResponse.ItemComponent>(vzzzzzzzzzzzf_, vzzzzzzzzzzzg_);
                        (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)? vzzzzzzzzzzzi_(ClaimResponse.ItemComponent pClaimLineItem) =>
                            pClaim;
                        IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzzzzzj_ = context.Operators.Select<ClaimResponse.ItemComponent, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(vzzzzzzzzzzzh_, vzzzzzzzzzzzi_);

                        return vzzzzzzzzzzzj_;
                    };
                    IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> vzzzzzzzzzzzd_ = context.Operators.SelectMany<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?, (CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(vzzzzzzzzzzzb_, vzzzzzzzzzzzc_);
                    bool? vzzzzzzzzzzze_ = context.Operators.Exists<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?>(vzzzzzzzzzzzd_);

                    return vzzzzzzzzzzze_;
                };
                IEnumerable<Claim.ItemComponent> uzzzzzzzzzzzz_ = context.Operators.Where<Claim.ItemComponent>(uzzzzzzzzzzzx_, uzzzzzzzzzzzy_);
                (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? vzzzzzzzzzzza_ = (CqlTupleMetadata_BiVTcKEZOfgFCDEReGAXJRAUK, medClaim, uzzzzzzzzzzzz_);

                return vzzzzzzzzzzza_;
            };
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> uzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?, (CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(uzzzzzzzzzzzn_, uzzzzzzzzzzzo_);
            IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> uzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(uzzzzzzzzzzzp_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? uzzzzzzzzzzzr_ = (CqlTupleMetadata_EMbbXAAHNDcXYSgLIhAhQCWON, uzzzzzzzzzzzq_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?[] uzzzzzzzzzzzs_ = [
                uzzzzzzzzzzzr_,
            ];
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? uzzzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)? ClaimWithPaidResponse)
            {
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? wzzzzzzzzzzzc_()
                {
                    bool wzzzzzzzzzzzh_()
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> wzzzzzzzzzzzi_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? wzzzzzzzzzzzj_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzp_ = @this?.ClaimItem;
                            bool? wzzzzzzzzzzzq_ = context.Operators.Not((bool?)(wzzzzzzzzzzzp_ is null));

                            return wzzzzzzzzzzzq_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> wzzzzzzzzzzzk_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(wzzzzzzzzzzzi_, wzzzzzzzzzzzj_);
                        IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzl_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzr_ = @this?.ClaimItem;

                            return wzzzzzzzzzzzr_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> wzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(wzzzzzzzzzzzk_, wzzzzzzzzzzzl_);
                        IEnumerable<Claim.ItemComponent> wzzzzzzzzzzzn_ = context.Operators.Flatten<Claim.ItemComponent>(wzzzzzzzzzzzm_);
                        bool? wzzzzzzzzzzzo_ = context.Operators.Exists<Claim.ItemComponent>(wzzzzzzzzzzzn_);

                        return wzzzzzzzzzzzo_ ?? false;
                    };
                    if (wzzzzzzzzzzzh_())
                    {
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> wzzzzzzzzzzzs_ = ClaimWithPaidResponse?.AggregateClaim;
                        bool? wzzzzzzzzzzzt_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? xzzzzzzzzzzzq_ = @this?.PaidClaim;
                            bool? xzzzzzzzzzzzr_ = context.Operators.Not((bool?)(xzzzzzzzzzzzq_ is null));

                            return xzzzzzzzzzzzr_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> wzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(wzzzzzzzzzzzs_, wzzzzzzzzzzzt_);
                        (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? wzzzzzzzzzzzv_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? xzzzzzzzzzzzs_ = @this?.PaidClaim;

                            return xzzzzzzzzzzzs_;
                        };
                        IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> wzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?>(wzzzzzzzzzzzu_, wzzzzzzzzzzzv_);
                        bool? wzzzzzzzzzzzy_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzzzzzt_ = @this?.ClaimItem;
                            bool? xzzzzzzzzzzzu_ = context.Operators.Not((bool?)(xzzzzzzzzzzzt_ is null));

                            return xzzzzzzzzzzzu_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> wzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(wzzzzzzzzzzzs_, wzzzzzzzzzzzy_);
                        IEnumerable<Claim.ItemComponent> xzzzzzzzzzzza_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzzzzzv_ = @this?.ClaimItem;

                            return xzzzzzzzzzzzv_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> xzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(wzzzzzzzzzzzz_, xzzzzzzzzzzza_);
                        IEnumerable<Claim.ItemComponent> xzzzzzzzzzzzc_ = context.Operators.Flatten<Claim.ItemComponent>(xzzzzzzzzzzzb_);
                        CqlInterval<CqlDateTime> xzzzzzzzzzzzd_(Claim.ItemComponent PaidItem)
                        {
                            DataType xzzzzzzzzzzzw_ = PaidItem?.Serviced;
                            CqlInterval<CqlDateTime> xzzzzzzzzzzzx_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, xzzzzzzzzzzzw_);

                            return xzzzzzzzzzzzx_;
                        };
                        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzze_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDateTime>>(xzzzzzzzzzzzc_, xzzzzzzzzzzzd_);
                        IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzf_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xzzzzzzzzzzze_);
                        bool? xzzzzzzzzzzzh_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> xzzzzzzzzzzzy_ = @this?.ClaimItem;
                            bool? xzzzzzzzzzzzz_ = context.Operators.Not((bool?)(xzzzzzzzzzzzy_ is null));

                            return xzzzzzzzzzzzz_;
                        };
                        IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> xzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?>(wzzzzzzzzzzzs_, xzzzzzzzzzzzh_);
                        IEnumerable<Claim.ItemComponent> xzzzzzzzzzzzj_((CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)? @this)
                        {
                            IEnumerable<Claim.ItemComponent> yzzzzzzzzzzza_ = @this?.ClaimItem;

                            return yzzzzzzzzzzza_;
                        };
                        IEnumerable<IEnumerable<Claim.ItemComponent>> xzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?, IEnumerable<Claim.ItemComponent>>(xzzzzzzzzzzzi_, xzzzzzzzzzzzj_);
                        IEnumerable<Claim.ItemComponent> xzzzzzzzzzzzl_ = context.Operators.Flatten<Claim.ItemComponent>(xzzzzzzzzzzzk_);
                        CqlInterval<CqlDate> xzzzzzzzzzzzm_(Claim.ItemComponent i)
                        {
                            CqlInterval<CqlDate> yzzzzzzzzzzzb_()
                            {
                                bool yzzzzzzzzzzzc_()
                                {
                                    Quantity yzzzzzzzzzzzd_ = i?.Quantity;
                                    bool? yzzzzzzzzzzze_ = context.Operators.Not((bool?)(yzzzzzzzzzzzd_ is null));

                                    return yzzzzzzzzzzze_ ?? false;
                                };
                                if (yzzzzzzzzzzzc_())
                                {
                                    DataType yzzzzzzzzzzzf_ = i?.Serviced;
                                    CqlInterval<CqlDateTime> yzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, yzzzzzzzzzzzf_);
                                    CqlDateTime yzzzzzzzzzzzh_ = context.Operators.Start(yzzzzzzzzzzzg_);
                                    CqlDate yzzzzzzzzzzzi_ = context.Operators.ConvertDateTimeToDate(yzzzzzzzzzzzh_);
                                    CqlInterval<CqlDateTime> yzzzzzzzzzzzk_ = NCQAFHIRBase_1_0_0.Instance.Normalize_Interval(context, yzzzzzzzzzzzf_);
                                    CqlDateTime yzzzzzzzzzzzl_ = context.Operators.Start(yzzzzzzzzzzzk_);
                                    Quantity yzzzzzzzzzzzm_ = i?.Quantity;
                                    FhirDecimal yzzzzzzzzzzzn_ = yzzzzzzzzzzzm_?.ValueElement;
                                    decimal? yzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDecimal(context, yzzzzzzzzzzzn_);
                                    CqlDateTime yzzzzzzzzzzzp_ = context.Operators.Add(yzzzzzzzzzzzl_, new CqlQuantity(yzzzzzzzzzzzo_, "day"));
                                    CqlQuantity yzzzzzzzzzzzq_ = context.Operators.Quantity(1m, "day");
                                    CqlDateTime yzzzzzzzzzzzr_ = context.Operators.Subtract(yzzzzzzzzzzzp_, yzzzzzzzzzzzq_);
                                    CqlDate yzzzzzzzzzzzs_ = context.Operators.ConvertDateTimeToDate(yzzzzzzzzzzzr_);
                                    CqlInterval<CqlDate> yzzzzzzzzzzzt_ = context.Operators.Interval(yzzzzzzzzzzzi_, yzzzzzzzzzzzs_, true, true);

                                    return yzzzzzzzzzzzt_;
                                }
                                else
                                {
                                    return null as CqlInterval<CqlDate>;
                                }
                            };

                            return yzzzzzzzzzzzb_();
                        };
                        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzzzzn_ = context.Operators.Select<Claim.ItemComponent, CqlInterval<CqlDate>>(xzzzzzzzzzzzl_, xzzzzzzzzzzzm_);
                        IEnumerable<CqlInterval<CqlDate>> xzzzzzzzzzzzo_ = context.Operators.Distinct<CqlInterval<CqlDate>>(xzzzzzzzzzzzn_);
                        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? xzzzzzzzzzzzp_ = (CqlTupleMetadata_DXGMEVDRBZgHMANCfXfEUYMNW, wzzzzzzzzzzzw_, xzzzzzzzzzzzf_, xzzzzzzzzzzzo_);

                        return xzzzzzzzzzzzp_;
                    }
                    else
                    {
                        return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                    }
                };
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?[] wzzzzzzzzzzzd_ = [
                    wzzzzzzzzzzzc_(),
                ];
                bool? wzzzzzzzzzzze_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? FinalList)
                {
                    bool? yzzzzzzzzzzzu_ = context.Operators.Not((bool?)(FinalList is null));

                    return yzzzzzzzzzzzu_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> wzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>)wzzzzzzzzzzzd_, wzzzzzzzzzzze_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? wzzzzzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(wzzzzzzzzzzzf_);

                return wzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> uzzzzzzzzzzzu_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, (CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)? PaidClaim, IEnumerable<Claim.ItemComponent> ClaimItem)?> AggregateClaim)?>)uzzzzzzzzzzzs_, uzzzzzzzzzzzt_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> uzzzzzzzzzzzv_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(uzzzzzzzzzzzu_);
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? uzzzzzzzzzzzw_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(uzzzzzzzzzzzv_);

            return uzzzzzzzzzzzw_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> uzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, ClaimResponse Response, string ResponseID, IEnumerable<ClaimResponse.ItemComponent> LineItems)?> PaidPharmacyClaimResponse, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> MedicalClaim)?>)uzzzzzzzzzzzi_, uzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> uzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(uzzzzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? uzzzzzzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(uzzzzzzzzzzzl_);

        return uzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Get Paid Claims for Pharmacy Services")]
    public (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? Get_Paid_Claims_for_Pharmacy_Services(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim, IEnumerable<CqlCode> ProductOrServiceValueSet)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? yzzzzzzzzzzzv_ = this.Get_All_Pharmacy_Claims_and_Claim_Responses(context, claimResponse, claim);
        (CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?[] yzzzzzzzzzzzw_ = [
            yzzzzzzzzzzzv_,
        ];
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? yzzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)? PharmacyClaimAndResponse)
        {
            (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? zzzzzzzzzzzzb_()
            {
                bool zzzzzzzzzzzzc_()
                {
                    IEnumerable<ClaimResponse> zzzzzzzzzzzzd_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> zzzzzzzzzzzze_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    bool? zzzzzzzzzzzzf_ = context.Operators.And((bool?)(zzzzzzzzzzzzd_ is null), (bool?)(zzzzzzzzzzzze_ is null));

                    return zzzzzzzzzzzzf_ ?? false;
                };
                if (zzzzzzzzzzzzc_())
                {
                    return null as (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?;
                }
                else
                {
                    IEnumerable<ClaimResponse> zzzzzzzzzzzzg_ = PharmacyClaimAndResponse?.PharmacyClaimResponse;
                    IEnumerable<Claim> zzzzzzzzzzzzh_ = PharmacyClaimAndResponse?.PharmacyClaim;
                    (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? zzzzzzzzzzzzi_ = this.Get_Corresponding_Claim_for_Pharmacy_Services(context, zzzzzzzzzzzzg_, zzzzzzzzzzzzh_, ProductOrServiceValueSet);

                    return zzzzzzzzzzzzi_;
                }
            };

            return zzzzzzzzzzzzb_();
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> yzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?, (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> PharmacyClaimResponse, IEnumerable<Claim> PharmacyClaim)?>)yzzzzzzzzzzzw_, yzzzzzzzzzzzx_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?> yzzzzzzzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(yzzzzzzzzzzzy_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)? zzzzzzzzzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim Claim, IEnumerable<Claim.ItemComponent> LineItem, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDateTime>> CoveredDays)?> originalClaim, IEnumerable<CqlInterval<CqlDateTime>> ServicePeriod, IEnumerable<CqlInterval<CqlDate>> CoveredDays)?>(yzzzzzzzzzzzz_);

        return zzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Get Claim With Corresponding Claim Response")]
    public IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> Get_Claim_With_Corresponding_Claim_Response(CqlContext context, IEnumerable<ClaimResponse> claimResponse, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? zzzzzzzzzzzzj_(Claim Claim)
        {
            bool? zzzzzzzzzzzzm_(ClaimResponse CR)
            {
                Id zzzzzzzzzzzzr_ = Claim?.IdElement;
                string zzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzr_);
                ResourceReference zzzzzzzzzzzzt_ = CR?.Request;
                FhirString zzzzzzzzzzzzu_ = zzzzzzzzzzzzt_?.ReferenceElement;
                string zzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzu_);
                string zzzzzzzzzzzzw_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, zzzzzzzzzzzzv_);
                bool? zzzzzzzzzzzzx_ = context.Operators.Equal(zzzzzzzzzzzzs_, zzzzzzzzzzzzw_);

                return zzzzzzzzzzzzx_;
            };
            IEnumerable<ClaimResponse> zzzzzzzzzzzzn_ = context.Operators.Where<ClaimResponse>(claimResponse, zzzzzzzzzzzzm_);
            bool? zzzzzzzzzzzzo_(Claim C)
            {
                Id zzzzzzzzzzzzy_ = Claim?.IdElement;
                string zzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, zzzzzzzzzzzzy_);
                bool? azzzzzzzzzzzza_(ClaimResponse CR)
                {
                    Id azzzzzzzzzzzzo_ = Claim?.IdElement;
                    string azzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzo_);
                    ResourceReference azzzzzzzzzzzzq_ = CR?.Request;
                    FhirString azzzzzzzzzzzzr_ = azzzzzzzzzzzzq_?.ReferenceElement;
                    string azzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzr_);
                    string azzzzzzzzzzzzt_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, azzzzzzzzzzzzs_);
                    bool? azzzzzzzzzzzzu_ = context.Operators.Equal(azzzzzzzzzzzzp_, azzzzzzzzzzzzt_);

                    return azzzzzzzzzzzzu_;
                };
                IEnumerable<ClaimResponse> azzzzzzzzzzzzb_ = context.Operators.Where<ClaimResponse>(claimResponse, azzzzzzzzzzzza_);
                bool? azzzzzzzzzzzzc_(ClaimResponse @this)
                {
                    ResourceReference azzzzzzzzzzzzv_ = @this?.Request;
                    bool? azzzzzzzzzzzzw_ = context.Operators.Not((bool?)(azzzzzzzzzzzzv_ is null));

                    return azzzzzzzzzzzzw_;
                };
                IEnumerable<ClaimResponse> azzzzzzzzzzzzd_ = context.Operators.Where<ClaimResponse>(azzzzzzzzzzzzb_, azzzzzzzzzzzzc_);
                ResourceReference azzzzzzzzzzzze_(ClaimResponse @this)
                {
                    ResourceReference azzzzzzzzzzzzx_ = @this?.Request;

                    return azzzzzzzzzzzzx_;
                };
                IEnumerable<ResourceReference> azzzzzzzzzzzzf_ = context.Operators.Select<ClaimResponse, ResourceReference>(azzzzzzzzzzzzd_, azzzzzzzzzzzze_);
                bool? azzzzzzzzzzzzg_(ResourceReference @this)
                {
                    FhirString azzzzzzzzzzzzy_ = @this?.ReferenceElement;
                    bool? azzzzzzzzzzzzz_ = context.Operators.Not((bool?)(azzzzzzzzzzzzy_ is null));

                    return azzzzzzzzzzzzz_;
                };
                IEnumerable<ResourceReference> azzzzzzzzzzzzh_ = context.Operators.Where<ResourceReference>(azzzzzzzzzzzzf_, azzzzzzzzzzzzg_);
                FhirString azzzzzzzzzzzzi_(ResourceReference @this)
                {
                    FhirString bzzzzzzzzzzzza_ = @this?.ReferenceElement;

                    return bzzzzzzzzzzzza_;
                };
                IEnumerable<FhirString> azzzzzzzzzzzzj_ = context.Operators.Select<ResourceReference, FhirString>(azzzzzzzzzzzzh_, azzzzzzzzzzzzi_);
                FhirString azzzzzzzzzzzzk_ = context.Operators.SingletonFrom<FhirString>(azzzzzzzzzzzzj_);
                string azzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, azzzzzzzzzzzzk_);
                string azzzzzzzzzzzzm_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, azzzzzzzzzzzzl_);
                bool? azzzzzzzzzzzzn_ = context.Operators.Equal(zzzzzzzzzzzzz_, azzzzzzzzzzzzm_);

                return azzzzzzzzzzzzn_;
            };
            IEnumerable<Claim> zzzzzzzzzzzzp_ = context.Operators.Where<Claim>(claim, zzzzzzzzzzzzo_);
            (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)? zzzzzzzzzzzzq_ = (CqlTupleMetadata_CZThYJbgajVLdhIZdgZiXBFQK, zzzzzzzzzzzzn_, zzzzzzzzzzzzp_);

            return zzzzzzzzzzzzq_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> zzzzzzzzzzzzk_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(claim, zzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?> zzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<ClaimResponse> ClaimResponse, IEnumerable<Claim> OriginalClaim)?>(zzzzzzzzzzzzk_);

        return zzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("Medical Claims With Nonacute or Acute Inpatient Discharge")]
    public (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? Medical_Claims_With_Nonacute_or_Acute_Inpatient_Discharge(CqlContext context, IEnumerable<Claim> claim)
    {
        IEnumerable<Claim> bzzzzzzzzzzzzb_ = this.Professional_or_Institutional_Claims(context, claim);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? bzzzzzzzzzzzzc_ = (CqlTupleMetadata_GIgcTXSQJbIXPiNgNbAIdOBXi, bzzzzzzzzzzzzb_, default, default);
        (CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?[] bzzzzzzzzzzzzd_ = [
            bzzzzzzzzzzzzc_,
        ];
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bzzzzzzzzzzzze_((CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)? ClaimWithInpatientStay)
        {
            IEnumerable<Claim> bzzzzzzzzzzzzi_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> bzzzzzzzzzzzzq_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? bzzzzzzzzzzzzr_(Claim c)
                    {
                        List<Claim.ItemComponent> bzzzzzzzzzzzzt_ = c?.Item;
                        bool? bzzzzzzzzzzzzu_(Claim.ItemComponent i)
                        {
                            CodeableConcept bzzzzzzzzzzzzx_ = i?.Revenue;
                            CqlConcept bzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, bzzzzzzzzzzzzx_);
                            CqlCode[] bzzzzzzzzzzzzz_ = bzzzzzzzzzzzzy_?.codes;
                            bool? czzzzzzzzzzzza_(CqlCode rev)
                            {
                                string czzzzzzzzzzzzd_ = rev?.code;
                                CqlValueSet czzzzzzzzzzzze_ = this.Inpatient_Stay(context);
                                bool? czzzzzzzzzzzzf_ = context.Operators.StringInValueSet(czzzzzzzzzzzzd_, czzzzzzzzzzzze_);

                                return czzzzzzzzzzzzf_;
                            };
                            IEnumerable<CqlCode> czzzzzzzzzzzzb_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)bzzzzzzzzzzzzz_, czzzzzzzzzzzza_);
                            bool? czzzzzzzzzzzzc_ = context.Operators.Exists<CqlCode>(czzzzzzzzzzzzb_);

                            return czzzzzzzzzzzzc_;
                        };
                        IEnumerable<Claim.ItemComponent> bzzzzzzzzzzzzv_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)bzzzzzzzzzzzzt_, bzzzzzzzzzzzzu_);
                        bool? bzzzzzzzzzzzzw_ = context.Operators.Exists<Claim.ItemComponent>(bzzzzzzzzzzzzv_);

                        return bzzzzzzzzzzzzw_;
                    };
                    IEnumerable<Claim> bzzzzzzzzzzzzs_ = context.Operators.Where<Claim>(bzzzzzzzzzzzzq_, bzzzzzzzzzzzzr_);

                    return bzzzzzzzzzzzzs_;
                }
            };
            IEnumerable<Claim> bzzzzzzzzzzzzj_()
            {
                if (ClaimWithInpatientStay?.MedicalClaim is null)
                {
                    return null as IEnumerable<Claim>;
                }
                else
                {
                    IEnumerable<Claim> czzzzzzzzzzzzg_ = ClaimWithInpatientStay?.MedicalClaim;
                    bool? czzzzzzzzzzzzh_(Claim c)
                    {
                        List<Claim.ItemComponent> czzzzzzzzzzzzj_ = c?.Item;
                        bool? czzzzzzzzzzzzk_(Claim.ItemComponent i)
                        {
                            CodeableConcept czzzzzzzzzzzzt_ = i?.Revenue;
                            CqlConcept czzzzzzzzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, czzzzzzzzzzzzt_);
                            CqlCode[] czzzzzzzzzzzzv_ = czzzzzzzzzzzzu_?.codes;
                            bool? czzzzzzzzzzzzw_(CqlCode rev)
                            {
                                string czzzzzzzzzzzzz_ = rev?.code;
                                CqlValueSet dzzzzzzzzzzzza_ = this.Nonacute_Inpatient_Stay(context);
                                bool? dzzzzzzzzzzzzb_ = context.Operators.StringInValueSet(czzzzzzzzzzzzz_, dzzzzzzzzzzzza_);

                                return dzzzzzzzzzzzzb_;
                            };
                            IEnumerable<CqlCode> czzzzzzzzzzzzx_ = context.Operators.Where<CqlCode>((IEnumerable<CqlCode>)czzzzzzzzzzzzv_, czzzzzzzzzzzzw_);
                            bool? czzzzzzzzzzzzy_ = context.Operators.Exists<CqlCode>(czzzzzzzzzzzzx_);

                            return czzzzzzzzzzzzy_;
                        };
                        IEnumerable<Claim.ItemComponent> czzzzzzzzzzzzl_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)czzzzzzzzzzzzj_, czzzzzzzzzzzzk_);
                        bool? czzzzzzzzzzzzm_ = context.Operators.Exists<Claim.ItemComponent>(czzzzzzzzzzzzl_);
                        CodeableConcept czzzzzzzzzzzzn_ = c?.SubType;
                        List<Coding> czzzzzzzzzzzzo_ = czzzzzzzzzzzzn_?.Coding;
                        bool? czzzzzzzzzzzzp_(Coding tob)
                        {
                            Code dzzzzzzzzzzzzc_ = tob?.CodeElement;
                            string dzzzzzzzzzzzzd_ = dzzzzzzzzzzzzc_?.Value;
                            CqlValueSet dzzzzzzzzzzzze_ = this.Nonacute_Inpatient_Stay(context);
                            bool? dzzzzzzzzzzzzf_ = context.Operators.StringInValueSet(dzzzzzzzzzzzzd_, dzzzzzzzzzzzze_);

                            return dzzzzzzzzzzzzf_;
                        };
                        IEnumerable<Coding> czzzzzzzzzzzzq_ = context.Operators.Where<Coding>((IEnumerable<Coding>)czzzzzzzzzzzzo_, czzzzzzzzzzzzp_);
                        bool? czzzzzzzzzzzzr_ = context.Operators.Exists<Coding>(czzzzzzzzzzzzq_);
                        bool? czzzzzzzzzzzzs_ = context.Operators.Or(czzzzzzzzzzzzm_, czzzzzzzzzzzzr_);

                        return czzzzzzzzzzzzs_;
                    };
                    IEnumerable<Claim> czzzzzzzzzzzzi_ = context.Operators.Where<Claim>(czzzzzzzzzzzzg_, czzzzzzzzzzzzh_);

                    return czzzzzzzzzzzzi_;
                }
            };
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? bzzzzzzzzzzzzk_ = (CqlTupleMetadata_GFUjSKcYaHagAZIhSUhffHjHP, bzzzzzzzzzzzzi_(), bzzzzzzzzzzzzj_());
            (CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?[] bzzzzzzzzzzzzl_ = [
                bzzzzzzzzzzzzk_,
            ];
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bzzzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)? LineItemDefinition)
            {
                IEnumerable<Claim> dzzzzzzzzzzzzg_ = LineItemDefinition?.InpatientStayLineItems;
                IEnumerable<Claim> dzzzzzzzzzzzzh_ = LineItemDefinition?.NonacuteInpatientLineItems;
                IEnumerable<Claim> dzzzzzzzzzzzzi_(Claim nonAcuteInpatientStay)
                {
                    IEnumerable<Claim> dzzzzzzzzzzzzq_ = LineItemDefinition?.InpatientStayLineItems;
                    bool? dzzzzzzzzzzzzr_(Claim inpatientStay)
                    {
                        Id dzzzzzzzzzzzzv_ = nonAcuteInpatientStay?.IdElement;
                        Id dzzzzzzzzzzzzw_ = inpatientStay?.IdElement;
                        bool? dzzzzzzzzzzzzx_ = context.Operators.Equal(dzzzzzzzzzzzzv_, dzzzzzzzzzzzzw_);

                        return dzzzzzzzzzzzzx_;
                    };
                    IEnumerable<Claim> dzzzzzzzzzzzzs_ = context.Operators.Where<Claim>(dzzzzzzzzzzzzq_, dzzzzzzzzzzzzr_);
                    Claim dzzzzzzzzzzzzt_(Claim inpatientStay) =>
                        nonAcuteInpatientStay;
                    IEnumerable<Claim> dzzzzzzzzzzzzu_ = context.Operators.Select<Claim, Claim>(dzzzzzzzzzzzzs_, dzzzzzzzzzzzzt_);

                    return dzzzzzzzzzzzzu_;
                };
                IEnumerable<Claim> dzzzzzzzzzzzzj_ = context.Operators.SelectMany<Claim, Claim>(dzzzzzzzzzzzzh_, dzzzzzzzzzzzzi_);
                IEnumerable<Claim> dzzzzzzzzzzzzm_(Claim inpatientStay)
                {
                    IEnumerable<Claim> dzzzzzzzzzzzzy_ = LineItemDefinition?.NonacuteInpatientLineItems;
                    bool? dzzzzzzzzzzzzz_(Claim nonAcuteInpatientStay)
                    {
                        Id ezzzzzzzzzzzzd_ = inpatientStay?.IdElement;
                        Id ezzzzzzzzzzzze_ = nonAcuteInpatientStay?.IdElement;
                        bool? ezzzzzzzzzzzzf_ = context.Operators.Equal(ezzzzzzzzzzzzd_, ezzzzzzzzzzzze_);

                        return ezzzzzzzzzzzzf_;
                    };
                    IEnumerable<Claim> ezzzzzzzzzzzza_ = context.Operators.Where<Claim>(dzzzzzzzzzzzzy_, dzzzzzzzzzzzzz_);
                    Claim ezzzzzzzzzzzzb_(Claim nonAcuteInpatientStay) =>
                        inpatientStay;
                    IEnumerable<Claim> ezzzzzzzzzzzzc_ = context.Operators.Select<Claim, Claim>(ezzzzzzzzzzzza_, ezzzzzzzzzzzzb_);

                    return ezzzzzzzzzzzzc_;
                };
                IEnumerable<Claim> dzzzzzzzzzzzzn_ = context.Operators.SelectMany<Claim, Claim>(dzzzzzzzzzzzzg_, dzzzzzzzzzzzzm_);
                IEnumerable<Claim> dzzzzzzzzzzzzo_ = context.Operators.Except<Claim>(dzzzzzzzzzzzzg_, dzzzzzzzzzzzzn_);
                (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? dzzzzzzzzzzzzp_ = (CqlTupleMetadata_DBGUUNgWTQDYFIeOfMhQJAYTB, dzzzzzzzzzzzzg_, dzzzzzzzzzzzzj_, dzzzzzzzzzzzzo_);

                return dzzzzzzzzzzzzp_;
            };
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> bzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientStayLineItems, IEnumerable<Claim> NonacuteInpatientLineItems)?>)bzzzzzzzzzzzzl_, bzzzzzzzzzzzzm_);
            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> bzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(bzzzzzzzzzzzzn_);
            (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(bzzzzzzzzzzzzo_);

            return bzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> bzzzzzzzzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?, (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> MedicalClaim, IEnumerable<string> ProceduresAsStrings, IEnumerable<string> POSAsString)?>)bzzzzzzzzzzzzd_, bzzzzzzzzzzzze_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?> bzzzzzzzzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(bzzzzzzzzzzzzf_);
        (CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)? bzzzzzzzzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, IEnumerable<Claim> InpatientDischarge, IEnumerable<Claim> NonacuteInpatientDischarge, IEnumerable<Claim> AcuteInpatientDischarge)?>(bzzzzzzzzzzzzg_);

        return bzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("Get Prescriber NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Prescriber_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? ezzzzzzzzzzzzg_(Claim C)
        {
            List<Claim.CareTeamComponent> ezzzzzzzzzzzzp_ = C?.CareTeam;
            bool? ezzzzzzzzzzzzq_(Claim.CareTeamComponent ct)
            {
                PositiveInt fzzzzzzzzzzzzg_ = ct?.SequenceElement;
                Integer fzzzzzzzzzzzzh_ = context.Operators.Convert<Integer>(fzzzzzzzzzzzzg_);
                int? fzzzzzzzzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, fzzzzzzzzzzzzh_);
                bool? fzzzzzzzzzzzzj_ = context.Operators.Equal(fzzzzzzzzzzzzi_, 1);

                return fzzzzzzzzzzzzj_;
            };
            IEnumerable<Claim.CareTeamComponent> ezzzzzzzzzzzzr_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)ezzzzzzzzzzzzp_, ezzzzzzzzzzzzq_);
            bool? ezzzzzzzzzzzzs_(Claim.CareTeamComponent @this)
            {
                ResourceReference fzzzzzzzzzzzzk_ = @this?.Provider;
                bool? fzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzk_ is null));

                return fzzzzzzzzzzzzl_;
            };
            IEnumerable<Claim.CareTeamComponent> ezzzzzzzzzzzzt_ = context.Operators.Where<Claim.CareTeamComponent>(ezzzzzzzzzzzzr_, ezzzzzzzzzzzzs_);
            ResourceReference ezzzzzzzzzzzzu_(Claim.CareTeamComponent @this)
            {
                ResourceReference fzzzzzzzzzzzzm_ = @this?.Provider;

                return fzzzzzzzzzzzzm_;
            };
            IEnumerable<ResourceReference> ezzzzzzzzzzzzv_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(ezzzzzzzzzzzzt_, ezzzzzzzzzzzzu_);
            bool? ezzzzzzzzzzzzx_(Claim.CareTeamComponent ct)
            {
                PositiveInt fzzzzzzzzzzzzn_ = ct?.SequenceElement;
                Integer fzzzzzzzzzzzzo_ = context.Operators.Convert<Integer>(fzzzzzzzzzzzzn_);
                int? fzzzzzzzzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, fzzzzzzzzzzzzo_);
                bool? fzzzzzzzzzzzzq_ = context.Operators.Equal(fzzzzzzzzzzzzp_, 1);

                return fzzzzzzzzzzzzq_;
            };
            IEnumerable<Claim.CareTeamComponent> ezzzzzzzzzzzzy_ = context.Operators.Where<Claim.CareTeamComponent>((IEnumerable<Claim.CareTeamComponent>)ezzzzzzzzzzzzp_, ezzzzzzzzzzzzx_);
            bool? ezzzzzzzzzzzzz_(Claim.CareTeamComponent @this)
            {
                ResourceReference fzzzzzzzzzzzzr_ = @this?.Provider;
                bool? fzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(fzzzzzzzzzzzzr_ is null));

                return fzzzzzzzzzzzzs_;
            };
            IEnumerable<Claim.CareTeamComponent> fzzzzzzzzzzzza_ = context.Operators.Where<Claim.CareTeamComponent>(ezzzzzzzzzzzzy_, ezzzzzzzzzzzzz_);
            ResourceReference fzzzzzzzzzzzzb_(Claim.CareTeamComponent @this)
            {
                ResourceReference fzzzzzzzzzzzzt_ = @this?.Provider;

                return fzzzzzzzzzzzzt_;
            };
            IEnumerable<ResourceReference> fzzzzzzzzzzzzc_ = context.Operators.Select<Claim.CareTeamComponent, ResourceReference>(fzzzzzzzzzzzza_, fzzzzzzzzzzzzb_);
            string fzzzzzzzzzzzzd_(ResourceReference p)
            {
                FhirString fzzzzzzzzzzzzu_ = p?.ReferenceElement;
                FhirString[] fzzzzzzzzzzzzv_ = [
                    fzzzzzzzzzzzzu_,
                ];
                string fzzzzzzzzzzzzw_(FhirString r)
                {
                    string fzzzzzzzzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string gzzzzzzzzzzzza_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, fzzzzzzzzzzzzz_);

                    return gzzzzzzzzzzzza_;
                };
                IEnumerable<string> fzzzzzzzzzzzzx_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)fzzzzzzzzzzzzv_, fzzzzzzzzzzzzw_);
                string fzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<string>(fzzzzzzzzzzzzx_);

                return fzzzzzzzzzzzzy_;
            };
            IEnumerable<string> fzzzzzzzzzzzze_ = context.Operators.Select<ResourceReference, string>(fzzzzzzzzzzzzc_, fzzzzzzzzzzzzd_);
            (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? fzzzzzzzzzzzzf_ = (CqlTupleMetadata_BWiFKXdFieUciRMVTUCdIFCVO, C, ezzzzzzzzzzzzv_, fzzzzzzzzzzzze_);

            return fzzzzzzzzzzzzf_;
        };
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ezzzzzzzzzzzzh_ = context.Operators.Select<Claim, (CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(claim, ezzzzzzzzzzzzg_);
        IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> ezzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(ezzzzzzzzzzzzh_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ezzzzzzzzzzzzj_ = (CqlTupleMetadata_HFNJUcNhcbGBLBgHAJMMSPfQH, ezzzzzzzzzzzzi_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?[] ezzzzzzzzzzzzk_ = [
            ezzzzzzzzzzzzj_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? ezzzzzzzzzzzzl_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)? ClaimProperties)
        {
            IEnumerable<Practitioner> gzzzzzzzzzzzzb_ = context.Operators.Retrieve<Practitioner>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Practitioner"));
            bool? gzzzzzzzzzzzzc_(Practitioner p)
            {
                Id gzzzzzzzzzzzzk_ = p?.IdElement;
                string gzzzzzzzzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToString(context, gzzzzzzzzzzzzk_);
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> gzzzzzzzzzzzzm_ = ClaimProperties?.CareTeams;
                bool? gzzzzzzzzzzzzn_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> gzzzzzzzzzzzzt_ = @this?.CareTeamsProviderID;
                    bool? gzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzt_ is null));

                    return gzzzzzzzzzzzzu_;
                };
                IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> gzzzzzzzzzzzzo_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(gzzzzzzzzzzzzm_, gzzzzzzzzzzzzn_);
                IEnumerable<string> gzzzzzzzzzzzzp_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                {
                    IEnumerable<string> gzzzzzzzzzzzzv_ = @this?.CareTeamsProviderID;

                    return gzzzzzzzzzzzzv_;
                };
                IEnumerable<IEnumerable<string>> gzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, IEnumerable<string>>(gzzzzzzzzzzzzo_, gzzzzzzzzzzzzp_);
                IEnumerable<string> gzzzzzzzzzzzzr_ = context.Operators.Flatten<string>(gzzzzzzzzzzzzq_);
                bool? gzzzzzzzzzzzzs_ = context.Operators.In<string>(gzzzzzzzzzzzzl_, gzzzzzzzzzzzzr_);

                return gzzzzzzzzzzzzs_;
            };
            IEnumerable<Practitioner> gzzzzzzzzzzzzd_ = context.Operators.Where<Practitioner>(gzzzzzzzzzzzzb_, gzzzzzzzzzzzzc_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? gzzzzzzzzzzzze_ = (CqlTupleMetadata_FPVdJEEOUKFVhQPTfKhShUNO, gzzzzzzzzzzzzd_);
            (CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?[] gzzzzzzzzzzzzf_ = [
                gzzzzzzzzzzzze_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? gzzzzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)? PractitionerMatch)
            {
                IEnumerable<Practitioner> gzzzzzzzzzzzzw_ = PractitionerMatch?.Practitioners;
                bool? gzzzzzzzzzzzzx_(Practitioner P)
                {
                    bool? hzzzzzzzzzzzzh_ = context.Operators.Not((bool?)(P is null));

                    return hzzzzzzzzzzzzh_;
                };
                IEnumerable<Practitioner> gzzzzzzzzzzzzy_ = context.Operators.Where<Practitioner>(gzzzzzzzzzzzzw_, gzzzzzzzzzzzzx_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? gzzzzzzzzzzzzz_(Practitioner P)
                {
                    List<Identifier> hzzzzzzzzzzzzi_ = P?.Identifier;
                    bool? hzzzzzzzzzzzzj_(Identifier l)
                    {
                        FhirUri hzzzzzzzzzzzzu_ = l?.SystemElement;
                        string hzzzzzzzzzzzzv_ = hzzzzzzzzzzzzu_?.Value;
                        bool? hzzzzzzzzzzzzw_ = context.Operators.Equal(hzzzzzzzzzzzzv_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept hzzzzzzzzzzzzx_ = l?.Type;
                        CqlConcept hzzzzzzzzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, hzzzzzzzzzzzzx_);
                        CqlCode hzzzzzzzzzzzzz_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept izzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzz_);
                        bool? izzzzzzzzzzzzb_ = context.Operators.Equivalent(hzzzzzzzzzzzzy_, izzzzzzzzzzzza_);
                        bool? izzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzw_, izzzzzzzzzzzzb_);
                        FhirString izzzzzzzzzzzzd_ = l?.ValueElement;
                        string izzzzzzzzzzzze_ = izzzzzzzzzzzzd_?.Value;
                        bool? izzzzzzzzzzzzf_ = context.Operators.Not((bool?)(izzzzzzzzzzzze_ is null));
                        bool? izzzzzzzzzzzzg_ = context.Operators.And(izzzzzzzzzzzzc_, izzzzzzzzzzzzf_);

                        return izzzzzzzzzzzzg_;
                    };
                    IEnumerable<Identifier> hzzzzzzzzzzzzk_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)hzzzzzzzzzzzzi_, hzzzzzzzzzzzzj_);
                    FhirString hzzzzzzzzzzzzl_(Identifier l)
                    {
                        FhirString izzzzzzzzzzzzh_ = l?.ValueElement;

                        return izzzzzzzzzzzzh_;
                    };
                    IEnumerable<FhirString> hzzzzzzzzzzzzm_ = context.Operators.Select<Identifier, FhirString>(hzzzzzzzzzzzzk_, hzzzzzzzzzzzzl_);
                    IEnumerable<FhirString> hzzzzzzzzzzzzn_ = context.Operators.Distinct<FhirString>(hzzzzzzzzzzzzm_);
                    bool? hzzzzzzzzzzzzp_(Identifier l)
                    {
                        FhirUri izzzzzzzzzzzzi_ = l?.SystemElement;
                        string izzzzzzzzzzzzj_ = izzzzzzzzzzzzi_?.Value;
                        bool? izzzzzzzzzzzzk_ = context.Operators.Equal(izzzzzzzzzzzzj_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept izzzzzzzzzzzzl_ = l?.Type;
                        CqlConcept izzzzzzzzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, izzzzzzzzzzzzl_);
                        CqlCode izzzzzzzzzzzzn_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept izzzzzzzzzzzzo_ = context.Operators.ConvertCodeToConcept(izzzzzzzzzzzzn_);
                        bool? izzzzzzzzzzzzp_ = context.Operators.Equivalent(izzzzzzzzzzzzm_, izzzzzzzzzzzzo_);
                        bool? izzzzzzzzzzzzq_ = context.Operators.And(izzzzzzzzzzzzk_, izzzzzzzzzzzzp_);
                        FhirString izzzzzzzzzzzzr_ = l?.ValueElement;
                        string izzzzzzzzzzzzs_ = izzzzzzzzzzzzr_?.Value;
                        bool? izzzzzzzzzzzzt_ = context.Operators.And(izzzzzzzzzzzzq_, (bool?)(izzzzzzzzzzzzs_ is null));

                        return izzzzzzzzzzzzt_;
                    };
                    IEnumerable<Identifier> hzzzzzzzzzzzzq_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)hzzzzzzzzzzzzi_, hzzzzzzzzzzzzp_);
                    Identifier hzzzzzzzzzzzzr_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> hzzzzzzzzzzzzs_ = context.Operators.Select<Identifier, Identifier>(hzzzzzzzzzzzzq_, hzzzzzzzzzzzzr_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? hzzzzzzzzzzzzt_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, hzzzzzzzzzzzzn_, hzzzzzzzzzzzzs_);

                    return hzzzzzzzzzzzzt_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> hzzzzzzzzzzzza_ = context.Operators.Select<Practitioner, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(gzzzzzzzzzzzzy_, gzzzzzzzzzzzzz_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? hzzzzzzzzzzzzb_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, hzzzzzzzzzzzza_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] hzzzzzzzzzzzzc_ = [
                    hzzzzzzzzzzzzb_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? hzzzzzzzzzzzzd_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? izzzzzzzzzzzzu_()
                    {
                        bool izzzzzzzzzzzzw_()
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> izzzzzzzzzzzzx_ = ClaimProperties?.CareTeams;
                            bool? izzzzzzzzzzzzy_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim jzzzzzzzzzzzzd_ = @this?.SingleCareTeam;
                                bool? jzzzzzzzzzzzze_ = context.Operators.Not((bool?)(jzzzzzzzzzzzzd_ is null));

                                return jzzzzzzzzzzzze_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> izzzzzzzzzzzzz_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(izzzzzzzzzzzzx_, izzzzzzzzzzzzy_);
                            Claim jzzzzzzzzzzzza_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim jzzzzzzzzzzzzf_ = @this?.SingleCareTeam;

                                return jzzzzzzzzzzzzf_;
                            };
                            IEnumerable<Claim> jzzzzzzzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(izzzzzzzzzzzzz_, jzzzzzzzzzzzza_);
                            bool? jzzzzzzzzzzzzc_ = context.Operators.Exists<Claim>(jzzzzzzzzzzzzb_);

                            return jzzzzzzzzzzzzc_ ?? false;
                        };
                        if (izzzzzzzzzzzzw_())
                        {
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> jzzzzzzzzzzzzg_ = ClaimProperties?.CareTeams;
                            bool? jzzzzzzzzzzzzh_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim kzzzzzzzzzzzzd_ = @this?.SingleCareTeam;
                                bool? kzzzzzzzzzzzze_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzd_ is null));

                                return kzzzzzzzzzzzze_;
                            };
                            IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> jzzzzzzzzzzzzi_ = context.Operators.Where<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?>(jzzzzzzzzzzzzg_, jzzzzzzzzzzzzh_);
                            Claim jzzzzzzzzzzzzj_((CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)? @this)
                            {
                                Claim kzzzzzzzzzzzzf_ = @this?.SingleCareTeam;

                                return kzzzzzzzzzzzzf_;
                            };
                            IEnumerable<Claim> jzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?, Claim>(jzzzzzzzzzzzzi_, jzzzzzzzzzzzzj_);
                            bool? jzzzzzzzzzzzzl_(Claim X)
                            {
                                List<Claim.CareTeamComponent> kzzzzzzzzzzzzg_ = X?.CareTeam;

                                return (bool?)(((IEnumerable<Claim.CareTeamComponent>)kzzzzzzzzzzzzg_) is null);
                            };
                            IEnumerable<Claim> jzzzzzzzzzzzzm_ = context.Operators.Where<Claim>(jzzzzzzzzzzzzk_, jzzzzzzzzzzzzl_);
                            int? jzzzzzzzzzzzzn_ = context.Operators.Count<Claim>(jzzzzzzzzzzzzm_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> jzzzzzzzzzzzzo_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> jzzzzzzzzzzzzp_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> kzzzzzzzzzzzzh_ = X?.AllIdentifiers;

                                return kzzzzzzzzzzzzh_;
                            };
                            IEnumerable<IEnumerable<FhirString>> jzzzzzzzzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(jzzzzzzzzzzzzo_, jzzzzzzzzzzzzp_);
                            IEnumerable<FhirString> jzzzzzzzzzzzzr_ = context.Operators.Flatten<FhirString>(jzzzzzzzzzzzzq_);
                            FhirString jzzzzzzzzzzzzs_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> jzzzzzzzzzzzzt_ = context.Operators.Select<FhirString, FhirString>(jzzzzzzzzzzzzr_, jzzzzzzzzzzzzs_);
                            IEnumerable<FhirString> jzzzzzzzzzzzzu_ = context.Operators.Distinct<FhirString>(jzzzzzzzzzzzzt_);
                            int? jzzzzzzzzzzzzv_ = context.Operators.Count<FhirString>(jzzzzzzzzzzzzu_);
                            int? jzzzzzzzzzzzzw_ = context.Operators.Add(jzzzzzzzzzzzzn_, jzzzzzzzzzzzzv_);
                            IEnumerable<Identifier> jzzzzzzzzzzzzy_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> kzzzzzzzzzzzzi_ = X?.NullIdentifiers;

                                return kzzzzzzzzzzzzi_;
                            };
                            IEnumerable<IEnumerable<Identifier>> jzzzzzzzzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(jzzzzzzzzzzzzo_, jzzzzzzzzzzzzy_);
                            IEnumerable<Identifier> kzzzzzzzzzzzza_ = context.Operators.Flatten<Identifier>(jzzzzzzzzzzzzz_);
                            int? kzzzzzzzzzzzzb_ = context.Operators.Count<Identifier>(kzzzzzzzzzzzza_);
                            int? kzzzzzzzzzzzzc_ = context.Operators.Add(jzzzzzzzzzzzzw_, kzzzzzzzzzzzzb_);

                            return kzzzzzzzzzzzzc_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? izzzzzzzzzzzzv_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, izzzzzzzzzzzzu_());

                    return izzzzzzzzzzzzv_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> hzzzzzzzzzzzze_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)hzzzzzzzzzzzzc_, hzzzzzzzzzzzzd_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> hzzzzzzzzzzzzf_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(hzzzzzzzzzzzze_);
                (CqlTupleMetadata, int? IdentifierCount)? hzzzzzzzzzzzzg_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(hzzzzzzzzzzzzf_);

                return hzzzzzzzzzzzzg_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> gzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Practitioner> Practitioners)?>)gzzzzzzzzzzzzf_, gzzzzzzzzzzzzg_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> gzzzzzzzzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(gzzzzzzzzzzzzh_);
            (CqlTupleMetadata, int? IdentifierCount)? gzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(gzzzzzzzzzzzzi_);

            return gzzzzzzzzzzzzj_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> ezzzzzzzzzzzzm_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, Claim SingleCareTeam, IEnumerable<ResourceReference> CareTeamsProvider, IEnumerable<string> CareTeamsProviderID)?> CareTeams)?>)ezzzzzzzzzzzzk_, ezzzzzzzzzzzzl_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> ezzzzzzzzzzzzn_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(ezzzzzzzzzzzzm_);
        (CqlTupleMetadata, int? IdentifierCount)? ezzzzzzzzzzzzo_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(ezzzzzzzzzzzzn_);

        return ezzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("Get Pharmacy NPI from Claims")]
    public (CqlTupleMetadata, int? IdentifierCount)? Get_Pharmacy_NPI_from_Claims(CqlContext context, IEnumerable<Claim> claim)
    {
        (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? kzzzzzzzzzzzzj_(Claim C)
        {
            List<Claim.ItemComponent> kzzzzzzzzzzzzs_ = C?.Item;
            bool? kzzzzzzzzzzzzu_(Claim.ItemComponent i)
            {
                PositiveInt lzzzzzzzzzzzzm_ = i?.SequenceElement;
                Integer lzzzzzzzzzzzzn_ = context.Operators.Convert<Integer>(lzzzzzzzzzzzzm_);
                int? lzzzzzzzzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, lzzzzzzzzzzzzn_);
                bool? lzzzzzzzzzzzzp_ = context.Operators.Equal(lzzzzzzzzzzzzo_, 1);

                return lzzzzzzzzzzzzp_;
            };
            IEnumerable<Claim.ItemComponent> kzzzzzzzzzzzzv_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)kzzzzzzzzzzzzs_, kzzzzzzzzzzzzu_);
            bool? kzzzzzzzzzzzzw_(Claim.ItemComponent @this)
            {
                DataType lzzzzzzzzzzzzq_ = @this?.Location;
                bool? lzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzq_ is null));

                return lzzzzzzzzzzzzr_;
            };
            IEnumerable<Claim.ItemComponent> kzzzzzzzzzzzzx_ = context.Operators.Where<Claim.ItemComponent>(kzzzzzzzzzzzzv_, kzzzzzzzzzzzzw_);
            object kzzzzzzzzzzzzy_(Claim.ItemComponent @this)
            {
                DataType lzzzzzzzzzzzzs_ = @this?.Location;

                return lzzzzzzzzzzzzs_;
            };
            IEnumerable<object> kzzzzzzzzzzzzz_ = context.Operators.Select<Claim.ItemComponent, object>(kzzzzzzzzzzzzx_, kzzzzzzzzzzzzy_);
            ResourceReference lzzzzzzzzzzzza_(object l) =>
                l as ResourceReference;
            IEnumerable<ResourceReference> lzzzzzzzzzzzzb_ = context.Operators.Select<object, ResourceReference>(kzzzzzzzzzzzzz_, lzzzzzzzzzzzza_);
            bool? lzzzzzzzzzzzzd_(Claim.ItemComponent i)
            {
                PositiveInt lzzzzzzzzzzzzt_ = i?.SequenceElement;
                Integer lzzzzzzzzzzzzu_ = context.Operators.Convert<Integer>(lzzzzzzzzzzzzt_);
                int? lzzzzzzzzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToInteger(context, lzzzzzzzzzzzzu_);
                bool? lzzzzzzzzzzzzw_ = context.Operators.Equal(lzzzzzzzzzzzzv_, 1);

                return lzzzzzzzzzzzzw_;
            };
            IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzze_ = context.Operators.Where<Claim.ItemComponent>((IEnumerable<Claim.ItemComponent>)kzzzzzzzzzzzzs_, lzzzzzzzzzzzzd_);
            bool? lzzzzzzzzzzzzf_(Claim.ItemComponent @this)
            {
                DataType lzzzzzzzzzzzzx_ = @this?.Location;
                bool? lzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzx_ is null));

                return lzzzzzzzzzzzzy_;
            };
            IEnumerable<Claim.ItemComponent> lzzzzzzzzzzzzg_ = context.Operators.Where<Claim.ItemComponent>(lzzzzzzzzzzzze_, lzzzzzzzzzzzzf_);
            object lzzzzzzzzzzzzh_(Claim.ItemComponent @this)
            {
                DataType lzzzzzzzzzzzzz_ = @this?.Location;

                return lzzzzzzzzzzzzz_;
            };
            IEnumerable<object> lzzzzzzzzzzzzi_ = context.Operators.Select<Claim.ItemComponent, object>(lzzzzzzzzzzzzg_, lzzzzzzzzzzzzh_);
            string lzzzzzzzzzzzzj_(object l)
            {
                FhirString mzzzzzzzzzzzza_ = (l as ResourceReference)?.ReferenceElement;
                FhirString[] mzzzzzzzzzzzzb_ = [
                    mzzzzzzzzzzzza_,
                ];
                string mzzzzzzzzzzzzc_(FhirString r)
                {
                    string mzzzzzzzzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToString(context, r);
                    string mzzzzzzzzzzzzg_ = NCQAFHIRBase_1_0_0.Instance.GetId(context, mzzzzzzzzzzzzf_);

                    return mzzzzzzzzzzzzg_;
                };
                IEnumerable<string> mzzzzzzzzzzzzd_ = context.Operators.Select<FhirString, string>((IEnumerable<FhirString>)mzzzzzzzzzzzzb_, mzzzzzzzzzzzzc_);
                string mzzzzzzzzzzzze_ = context.Operators.SingletonFrom<string>(mzzzzzzzzzzzzd_);

                return mzzzzzzzzzzzze_;
            };
            IEnumerable<string> lzzzzzzzzzzzzk_ = context.Operators.Select<object, string>(lzzzzzzzzzzzzi_, lzzzzzzzzzzzzj_);
            (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? lzzzzzzzzzzzzl_ = (CqlTupleMetadata_gFQSaDQdhfIVgTfEbUhWdbBB, (IEnumerable<Claim.ItemComponent>)kzzzzzzzzzzzzs_, lzzzzzzzzzzzzb_, lzzzzzzzzzzzzk_);

            return lzzzzzzzzzzzzl_;
        };
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> kzzzzzzzzzzzzk_ = context.Operators.Select<Claim, (CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(claim, kzzzzzzzzzzzzj_);
        IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> kzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(kzzzzzzzzzzzzk_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? kzzzzzzzzzzzzm_ = (CqlTupleMetadata_ESTVjUCCVhLEXJGPZBeEcQDHX, kzzzzzzzzzzzzl_);
        (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?[] kzzzzzzzzzzzzn_ = [
            kzzzzzzzzzzzzm_,
        ];
        (CqlTupleMetadata, int? IdentifierCount)? kzzzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)? ClaimProperties)
        {
            IEnumerable<Location> mzzzzzzzzzzzzh_ = context.Operators.Retrieve<Location>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Location"));
            bool? mzzzzzzzzzzzzi_(Location l)
            {
                Id mzzzzzzzzzzzzq_ = l?.IdElement;
                string mzzzzzzzzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToString(context, mzzzzzzzzzzzzq_);
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> mzzzzzzzzzzzzs_ = ClaimProperties?.ItemsLocationReferences;
                bool? mzzzzzzzzzzzzt_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> mzzzzzzzzzzzzz_ = @this?.ItemLocationID;
                    bool? nzzzzzzzzzzzza_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzz_ is null));

                    return nzzzzzzzzzzzza_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> mzzzzzzzzzzzzu_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(mzzzzzzzzzzzzs_, mzzzzzzzzzzzzt_);
                IEnumerable<string> mzzzzzzzzzzzzv_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                {
                    IEnumerable<string> nzzzzzzzzzzzzb_ = @this?.ItemLocationID;

                    return nzzzzzzzzzzzzb_;
                };
                IEnumerable<IEnumerable<string>> mzzzzzzzzzzzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<string>>(mzzzzzzzzzzzzu_, mzzzzzzzzzzzzv_);
                IEnumerable<string> mzzzzzzzzzzzzx_ = context.Operators.Flatten<string>(mzzzzzzzzzzzzw_);
                bool? mzzzzzzzzzzzzy_ = context.Operators.In<string>(mzzzzzzzzzzzzr_, mzzzzzzzzzzzzx_);

                return mzzzzzzzzzzzzy_;
            };
            IEnumerable<Location> mzzzzzzzzzzzzj_ = context.Operators.Where<Location>(mzzzzzzzzzzzzh_, mzzzzzzzzzzzzi_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? mzzzzzzzzzzzzk_ = (CqlTupleMetadata_GWYcfjEGjPEdPbTNdfROfTUAf, mzzzzzzzzzzzzj_);
            (CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?[] mzzzzzzzzzzzzl_ = [
                mzzzzzzzzzzzzk_,
            ];
            (CqlTupleMetadata, int? IdentifierCount)? mzzzzzzzzzzzzm_((CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)? GetLocation)
            {
                IEnumerable<Location> nzzzzzzzzzzzzc_ = GetLocation?.CorrespondingLocations;
                bool? nzzzzzzzzzzzzd_(Location C)
                {
                    bool? nzzzzzzzzzzzzn_ = context.Operators.Not((bool?)(C is null));

                    return nzzzzzzzzzzzzn_;
                };
                IEnumerable<Location> nzzzzzzzzzzzze_ = context.Operators.Where<Location>(nzzzzzzzzzzzzc_, nzzzzzzzzzzzzd_);
                (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? nzzzzzzzzzzzzf_(Location C)
                {
                    List<Identifier> nzzzzzzzzzzzzo_ = C?.Identifier;
                    bool? nzzzzzzzzzzzzp_(Identifier l)
                    {
                        FhirUri ozzzzzzzzzzzza_ = l?.SystemElement;
                        string ozzzzzzzzzzzzb_ = ozzzzzzzzzzzza_?.Value;
                        bool? ozzzzzzzzzzzzc_ = context.Operators.Equal(ozzzzzzzzzzzzb_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept ozzzzzzzzzzzzd_ = l?.Type;
                        CqlConcept ozzzzzzzzzzzze_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ozzzzzzzzzzzzd_);
                        CqlCode ozzzzzzzzzzzzf_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept ozzzzzzzzzzzzg_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzf_);
                        bool? ozzzzzzzzzzzzh_ = context.Operators.Equivalent(ozzzzzzzzzzzze_, ozzzzzzzzzzzzg_);
                        bool? ozzzzzzzzzzzzi_ = context.Operators.And(ozzzzzzzzzzzzc_, ozzzzzzzzzzzzh_);
                        FhirString ozzzzzzzzzzzzj_ = l?.ValueElement;
                        string ozzzzzzzzzzzzk_ = ozzzzzzzzzzzzj_?.Value;
                        bool? ozzzzzzzzzzzzl_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzk_ is null));
                        bool? ozzzzzzzzzzzzm_ = context.Operators.And(ozzzzzzzzzzzzi_, ozzzzzzzzzzzzl_);

                        return ozzzzzzzzzzzzm_;
                    };
                    IEnumerable<Identifier> nzzzzzzzzzzzzq_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)nzzzzzzzzzzzzo_, nzzzzzzzzzzzzp_);
                    FhirString nzzzzzzzzzzzzr_(Identifier l)
                    {
                        FhirString ozzzzzzzzzzzzn_ = l?.ValueElement;

                        return ozzzzzzzzzzzzn_;
                    };
                    IEnumerable<FhirString> nzzzzzzzzzzzzs_ = context.Operators.Select<Identifier, FhirString>(nzzzzzzzzzzzzq_, nzzzzzzzzzzzzr_);
                    IEnumerable<FhirString> nzzzzzzzzzzzzt_ = context.Operators.Distinct<FhirString>(nzzzzzzzzzzzzs_);
                    bool? nzzzzzzzzzzzzv_(Identifier l)
                    {
                        FhirUri ozzzzzzzzzzzzo_ = l?.SystemElement;
                        string ozzzzzzzzzzzzp_ = ozzzzzzzzzzzzo_?.Value;
                        bool? ozzzzzzzzzzzzq_ = context.Operators.Equal(ozzzzzzzzzzzzp_, "http://hl7.org/fhir/sid/us-npi");
                        CodeableConcept ozzzzzzzzzzzzr_ = l?.Type;
                        CqlConcept ozzzzzzzzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToConcept(context, ozzzzzzzzzzzzr_);
                        CqlCode ozzzzzzzzzzzzt_ = NCQATerminology_1_0_0.Instance.Provider_number(context);
                        CqlConcept ozzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzzt_);
                        bool? ozzzzzzzzzzzzv_ = context.Operators.Equivalent(ozzzzzzzzzzzzs_, ozzzzzzzzzzzzu_);
                        bool? ozzzzzzzzzzzzw_ = context.Operators.And(ozzzzzzzzzzzzq_, ozzzzzzzzzzzzv_);
                        FhirString ozzzzzzzzzzzzx_ = l?.ValueElement;
                        string ozzzzzzzzzzzzy_ = ozzzzzzzzzzzzx_?.Value;
                        bool? ozzzzzzzzzzzzz_ = context.Operators.And(ozzzzzzzzzzzzw_, (bool?)(ozzzzzzzzzzzzy_ is null));

                        return ozzzzzzzzzzzzz_;
                    };
                    IEnumerable<Identifier> nzzzzzzzzzzzzw_ = context.Operators.Where<Identifier>((IEnumerable<Identifier>)nzzzzzzzzzzzzo_, nzzzzzzzzzzzzv_);
                    Identifier nzzzzzzzzzzzzx_(Identifier l) =>
                        l;
                    IEnumerable<Identifier> nzzzzzzzzzzzzy_ = context.Operators.Select<Identifier, Identifier>(nzzzzzzzzzzzzw_, nzzzzzzzzzzzzx_);
                    (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? nzzzzzzzzzzzzz_ = (CqlTupleMetadata_EheHUARRFfQdCcHKeSEhfYZMj, nzzzzzzzzzzzzt_, nzzzzzzzzzzzzy_);

                    return nzzzzzzzzzzzzz_;
                };
                IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> nzzzzzzzzzzzzg_ = context.Operators.Select<Location, (CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?>(nzzzzzzzzzzzze_, nzzzzzzzzzzzzf_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? nzzzzzzzzzzzzh_ = (CqlTupleMetadata_EZUSISLPSZWTXahaQjXaSAJBE, nzzzzzzzzzzzzg_);
                (CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?[] nzzzzzzzzzzzzi_ = [
                    nzzzzzzzzzzzzh_,
                ];
                (CqlTupleMetadata, int? IdentifierCount)? nzzzzzzzzzzzzj_((CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)? GetIdentifiers)
                {
                    int? pzzzzzzzzzzzza_()
                    {
                        bool pzzzzzzzzzzzzc_()
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> pzzzzzzzzzzzzd_ = ClaimProperties?.ItemsLocationReferences;
                            bool? pzzzzzzzzzzzze_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> pzzzzzzzzzzzzk_ = @this?.SingleItem;
                                bool? pzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(pzzzzzzzzzzzzk_ is null));

                                return pzzzzzzzzzzzzl_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> pzzzzzzzzzzzzf_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(pzzzzzzzzzzzzd_, pzzzzzzzzzzzze_);
                            IEnumerable<Claim.ItemComponent> pzzzzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<Claim.ItemComponent> pzzzzzzzzzzzzm_ = @this?.SingleItem;

                                return pzzzzzzzzzzzzm_;
                            };
                            IEnumerable<IEnumerable<Claim.ItemComponent>> pzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<Claim.ItemComponent>>(pzzzzzzzzzzzzf_, pzzzzzzzzzzzzg_);
                            IEnumerable<Claim.ItemComponent> pzzzzzzzzzzzzi_ = context.Operators.Flatten<Claim.ItemComponent>(pzzzzzzzzzzzzh_);
                            bool? pzzzzzzzzzzzzj_ = context.Operators.Exists<Claim.ItemComponent>(pzzzzzzzzzzzzi_);

                            return pzzzzzzzzzzzzj_ ?? false;
                        };
                        if (pzzzzzzzzzzzzc_())
                        {
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> pzzzzzzzzzzzzn_ = ClaimProperties?.ItemsLocationReferences;
                            bool? pzzzzzzzzzzzzo_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> qzzzzzzzzzzzzl_ = @this?.ItemLocation;
                                bool? qzzzzzzzzzzzzm_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzl_ is null));

                                return qzzzzzzzzzzzzm_;
                            };
                            IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> pzzzzzzzzzzzzp_ = context.Operators.Where<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?>(pzzzzzzzzzzzzn_, pzzzzzzzzzzzzo_);
                            IEnumerable<ResourceReference> pzzzzzzzzzzzzq_((CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)? @this)
                            {
                                IEnumerable<ResourceReference> qzzzzzzzzzzzzn_ = @this?.ItemLocation;

                                return qzzzzzzzzzzzzn_;
                            };
                            IEnumerable<IEnumerable<ResourceReference>> pzzzzzzzzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?, IEnumerable<ResourceReference>>(pzzzzzzzzzzzzp_, pzzzzzzzzzzzzq_);
                            IEnumerable<ResourceReference> pzzzzzzzzzzzzs_ = context.Operators.Flatten<ResourceReference>(pzzzzzzzzzzzzr_);
                            bool? pzzzzzzzzzzzzt_(ResourceReference X)
                            {
                                FhirString qzzzzzzzzzzzzo_ = X?.ReferenceElement;
                                string qzzzzzzzzzzzzp_ = qzzzzzzzzzzzzo_?.Value;

                                return (bool?)(qzzzzzzzzzzzzp_ is null);
                            };
                            IEnumerable<ResourceReference> pzzzzzzzzzzzzu_ = context.Operators.Where<ResourceReference>(pzzzzzzzzzzzzs_, pzzzzzzzzzzzzt_);
                            int? pzzzzzzzzzzzzv_ = context.Operators.Count<ResourceReference>(pzzzzzzzzzzzzu_);
                            IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> pzzzzzzzzzzzzw_ = GetIdentifiers?.IdentifierTuple;
                            IEnumerable<FhirString> pzzzzzzzzzzzzx_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<FhirString> qzzzzzzzzzzzzq_ = X?.AllIdentifiers;

                                return qzzzzzzzzzzzzq_;
                            };
                            IEnumerable<IEnumerable<FhirString>> pzzzzzzzzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<FhirString>>(pzzzzzzzzzzzzw_, pzzzzzzzzzzzzx_);
                            IEnumerable<FhirString> pzzzzzzzzzzzzz_ = context.Operators.Flatten<FhirString>(pzzzzzzzzzzzzy_);
                            FhirString qzzzzzzzzzzzza_(FhirString X) =>
                                X;
                            IEnumerable<FhirString> qzzzzzzzzzzzzb_ = context.Operators.Select<FhirString, FhirString>(pzzzzzzzzzzzzz_, qzzzzzzzzzzzza_);
                            IEnumerable<FhirString> qzzzzzzzzzzzzc_ = context.Operators.Distinct<FhirString>(qzzzzzzzzzzzzb_);
                            int? qzzzzzzzzzzzzd_ = context.Operators.Count<FhirString>(qzzzzzzzzzzzzc_);
                            int? qzzzzzzzzzzzze_ = context.Operators.Add(pzzzzzzzzzzzzv_, qzzzzzzzzzzzzd_);
                            IEnumerable<Identifier> qzzzzzzzzzzzzg_((CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)? X)
                            {
                                IEnumerable<Identifier> qzzzzzzzzzzzzr_ = X?.NullIdentifiers;

                                return qzzzzzzzzzzzzr_;
                            };
                            IEnumerable<IEnumerable<Identifier>> qzzzzzzzzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?, IEnumerable<Identifier>>(pzzzzzzzzzzzzw_, qzzzzzzzzzzzzg_);
                            IEnumerable<Identifier> qzzzzzzzzzzzzi_ = context.Operators.Flatten<Identifier>(qzzzzzzzzzzzzh_);
                            int? qzzzzzzzzzzzzj_ = context.Operators.Count<Identifier>(qzzzzzzzzzzzzi_);
                            int? qzzzzzzzzzzzzk_ = context.Operators.Add(qzzzzzzzzzzzze_, qzzzzzzzzzzzzj_);

                            return qzzzzzzzzzzzzk_;
                        }
                        else
                        {
                            return 0;
                        }
                    };
                    (CqlTupleMetadata, int? IdentifierCount)? pzzzzzzzzzzzzb_ = (CqlTupleMetadata_FBUdWLSDMgYFFiVXYhKEiUNQS, pzzzzzzzzzzzza_());

                    return pzzzzzzzzzzzzb_;
                };
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> nzzzzzzzzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<FhirString> AllIdentifiers, IEnumerable<Identifier> NullIdentifiers)?> IdentifierTuple)?>)nzzzzzzzzzzzzi_, nzzzzzzzzzzzzj_);
                IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> nzzzzzzzzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(nzzzzzzzzzzzzk_);
                (CqlTupleMetadata, int? IdentifierCount)? nzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(nzzzzzzzzzzzzl_);

                return nzzzzzzzzzzzzm_;
            };
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> mzzzzzzzzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<Location> CorrespondingLocations)?>)mzzzzzzzzzzzzl_, mzzzzzzzzzzzzm_);
            IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> mzzzzzzzzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(mzzzzzzzzzzzzn_);
            (CqlTupleMetadata, int? IdentifierCount)? mzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(mzzzzzzzzzzzzo_);

            return mzzzzzzzzzzzzp_;
        };
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> kzzzzzzzzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?, (CqlTupleMetadata, int? IdentifierCount)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<(CqlTupleMetadata, IEnumerable<Claim.ItemComponent> SingleItem, IEnumerable<ResourceReference> ItemLocation, IEnumerable<string> ItemLocationID)?> ItemsLocationReferences)?>)kzzzzzzzzzzzzn_, kzzzzzzzzzzzzo_);
        IEnumerable<(CqlTupleMetadata, int? IdentifierCount)?> kzzzzzzzzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, int? IdentifierCount)?>(kzzzzzzzzzzzzp_);
        (CqlTupleMetadata, int? IdentifierCount)? kzzzzzzzzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, int? IdentifierCount)?>(kzzzzzzzzzzzzq_);

        return kzzzzzzzzzzzzr_;
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
