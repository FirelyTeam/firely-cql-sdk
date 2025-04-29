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
[CqlLibrary("NCQAFHIRBase", "1.0.0")]
public partial class NCQAFHIRBase_1_0_0 : ILibrary, ISingleton<NCQAFHIRBase_1_0_0>
{
    private NCQAFHIRBase_1_0_0() {}

    public static NCQAFHIRBase_1_0_0 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "NCQAFHIRBase";
    public string Version => "1.0.0";
    public ILibrary[] Dependencies => [FHIRHelpers_4_0_001.Instance];

    #endregion ILibrary Implementation

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> xzzzzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient xzzzzg_ = context.Operators.SingletonFrom<Patient>(xzzzzf_);

        return xzzzzg_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Normalize_Onset(CqlContext context, object onset)
    {
        CqlInterval<CqlDateTime> xzzzzh_()
        {
            if (onset is FhirDateTime)
            {
                CqlDateTime xzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, onset as FhirDateTime);
                CqlInterval<CqlDateTime> xzzzzk_ = context.Operators.Interval(xzzzzi_, xzzzzi_, true, true);

                return xzzzzk_;
            }
            else if (onset is Period)
            {
                FhirDateTime xzzzzl_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
                CqlDateTime xzzzzm_ = context.Operators.Convert<CqlDateTime>(xzzzzl_);
                FhirDateTime xzzzzn_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
                CqlDateTime xzzzzo_ = context.Operators.Convert<CqlDateTime>(xzzzzn_);
                CqlInterval<CqlDateTime> xzzzzp_ = context.Operators.Interval(xzzzzm_, xzzzzo_, true, true);

                return xzzzzp_;
            }
            else if (onset is FhirString)
            {
                CqlInterval<CqlDateTime> xzzzzq_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return xzzzzq_;
            }
            else
            {
                CqlInterval<CqlDate> xzzzzr_()
                {
                    if (onset is Age)
                    {
                        Patient yzzzzc_ = this.Patient(context);
                        Date yzzzzd_ = yzzzzc_?.BirthDateElement;
                        CqlDate yzzzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzd_);
                        CqlQuantity yzzzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate yzzzzg_ = context.Operators.Add(yzzzze_, yzzzzf_);
                        Date yzzzzi_ = yzzzzc_?.BirthDateElement;
                        CqlDate yzzzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzi_);
                        CqlDate yzzzzl_ = context.Operators.Add(yzzzzj_, yzzzzf_);
                        CqlQuantity yzzzzm_ = context.Operators.Quantity(1m, "year");
                        CqlDate yzzzzn_ = context.Operators.Add(yzzzzl_, yzzzzm_);
                        CqlInterval<CqlDate> yzzzzo_ = context.Operators.Interval(yzzzzg_, yzzzzn_, true, false);

                        return yzzzzo_;
                    }
                    else if (onset is Range)
                    {
                        Patient yzzzzp_ = this.Patient(context);
                        Date yzzzzq_ = yzzzzp_?.BirthDateElement;
                        CqlDate yzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzq_);
                        Quantity yzzzzs_ = (onset as Range)?.Low;
                        CqlQuantity yzzzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzzzs_);
                        CqlDate yzzzzu_ = context.Operators.Add(yzzzzr_, yzzzzt_);
                        Date yzzzzw_ = yzzzzp_?.BirthDateElement;
                        CqlDate yzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzw_);
                        Quantity yzzzzy_ = (onset as Range)?.High;
                        CqlQuantity yzzzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzzzy_);
                        CqlDate zzzzza_ = context.Operators.Add(yzzzzx_, yzzzzz_);
                        CqlQuantity zzzzzb_ = context.Operators.Quantity(1m, "year");
                        CqlDate zzzzzc_ = context.Operators.Add(zzzzza_, zzzzzb_);
                        CqlInterval<CqlDate> zzzzzd_ = context.Operators.Interval(yzzzzu_, zzzzzc_, true, false);

                        return zzzzzd_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate xzzzzs_ = (xzzzzr_())?.low;
                CqlDateTime xzzzzt_ = context.Operators.ConvertDateToDateTime(xzzzzs_);
                CqlInterval<CqlDate> xzzzzu_()
                {
                    if (onset is Age)
                    {
                        Patient zzzzze_ = this.Patient(context);
                        Date zzzzzf_ = zzzzze_?.BirthDateElement;
                        CqlDate zzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzf_);
                        CqlQuantity zzzzzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate zzzzzi_ = context.Operators.Add(zzzzzg_, zzzzzh_);
                        Date zzzzzk_ = zzzzze_?.BirthDateElement;
                        CqlDate zzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzk_);
                        CqlDate zzzzzn_ = context.Operators.Add(zzzzzl_, zzzzzh_);
                        CqlQuantity zzzzzo_ = context.Operators.Quantity(1m, "year");
                        CqlDate zzzzzp_ = context.Operators.Add(zzzzzn_, zzzzzo_);
                        CqlInterval<CqlDate> zzzzzq_ = context.Operators.Interval(zzzzzi_, zzzzzp_, true, false);

                        return zzzzzq_;
                    }
                    else if (onset is Range)
                    {
                        Patient zzzzzr_ = this.Patient(context);
                        Date zzzzzs_ = zzzzzr_?.BirthDateElement;
                        CqlDate zzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzs_);
                        Quantity zzzzzu_ = (onset as Range)?.Low;
                        CqlQuantity zzzzzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzu_);
                        CqlDate zzzzzw_ = context.Operators.Add(zzzzzt_, zzzzzv_);
                        Date zzzzzy_ = zzzzzr_?.BirthDateElement;
                        CqlDate zzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzy_);
                        Quantity azzzzza_ = (onset as Range)?.High;
                        CqlQuantity azzzzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzzzza_);
                        CqlDate azzzzzc_ = context.Operators.Add(zzzzzz_, azzzzzb_);
                        CqlQuantity azzzzzd_ = context.Operators.Quantity(1m, "year");
                        CqlDate azzzzze_ = context.Operators.Add(azzzzzc_, azzzzzd_);
                        CqlInterval<CqlDate> azzzzzf_ = context.Operators.Interval(zzzzzw_, azzzzze_, true, false);

                        return azzzzzf_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate xzzzzv_ = (xzzzzu_())?.high;
                CqlDateTime xzzzzw_ = context.Operators.ConvertDateToDateTime(xzzzzv_);
                CqlInterval<CqlDate> xzzzzx_()
                {
                    if (onset is Age)
                    {
                        Patient azzzzzg_ = this.Patient(context);
                        Date azzzzzh_ = azzzzzg_?.BirthDateElement;
                        CqlDate azzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzh_);
                        CqlQuantity azzzzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate azzzzzk_ = context.Operators.Add(azzzzzi_, azzzzzj_);
                        Date azzzzzm_ = azzzzzg_?.BirthDateElement;
                        CqlDate azzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzm_);
                        CqlDate azzzzzp_ = context.Operators.Add(azzzzzn_, azzzzzj_);
                        CqlQuantity azzzzzq_ = context.Operators.Quantity(1m, "year");
                        CqlDate azzzzzr_ = context.Operators.Add(azzzzzp_, azzzzzq_);
                        CqlInterval<CqlDate> azzzzzs_ = context.Operators.Interval(azzzzzk_, azzzzzr_, true, false);

                        return azzzzzs_;
                    }
                    else if (onset is Range)
                    {
                        Patient azzzzzt_ = this.Patient(context);
                        Date azzzzzu_ = azzzzzt_?.BirthDateElement;
                        CqlDate azzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzu_);
                        Quantity azzzzzw_ = (onset as Range)?.Low;
                        CqlQuantity azzzzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzzzzw_);
                        CqlDate azzzzzy_ = context.Operators.Add(azzzzzv_, azzzzzx_);
                        Date bzzzzza_ = azzzzzt_?.BirthDateElement;
                        CqlDate bzzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzza_);
                        Quantity bzzzzzc_ = (onset as Range)?.High;
                        CqlQuantity bzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzzzc_);
                        CqlDate bzzzzze_ = context.Operators.Add(bzzzzzb_, bzzzzzd_);
                        CqlQuantity bzzzzzf_ = context.Operators.Quantity(1m, "year");
                        CqlDate bzzzzzg_ = context.Operators.Add(bzzzzze_, bzzzzzf_);
                        CqlInterval<CqlDate> bzzzzzh_ = context.Operators.Interval(azzzzzy_, bzzzzzg_, true, false);

                        return bzzzzzh_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? xzzzzy_ = (xzzzzx_())?.lowClosed;
                CqlInterval<CqlDate> xzzzzz_()
                {
                    if (onset is Age)
                    {
                        Patient bzzzzzi_ = this.Patient(context);
                        Date bzzzzzj_ = bzzzzzi_?.BirthDateElement;
                        CqlDate bzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzj_);
                        CqlQuantity bzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate bzzzzzm_ = context.Operators.Add(bzzzzzk_, bzzzzzl_);
                        Date bzzzzzo_ = bzzzzzi_?.BirthDateElement;
                        CqlDate bzzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzo_);
                        CqlDate bzzzzzr_ = context.Operators.Add(bzzzzzp_, bzzzzzl_);
                        CqlQuantity bzzzzzs_ = context.Operators.Quantity(1m, "year");
                        CqlDate bzzzzzt_ = context.Operators.Add(bzzzzzr_, bzzzzzs_);
                        CqlInterval<CqlDate> bzzzzzu_ = context.Operators.Interval(bzzzzzm_, bzzzzzt_, true, false);

                        return bzzzzzu_;
                    }
                    else if (onset is Range)
                    {
                        Patient bzzzzzv_ = this.Patient(context);
                        Date bzzzzzw_ = bzzzzzv_?.BirthDateElement;
                        CqlDate bzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzw_);
                        Quantity bzzzzzy_ = (onset as Range)?.Low;
                        CqlQuantity bzzzzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzzzy_);
                        CqlDate czzzzza_ = context.Operators.Add(bzzzzzx_, bzzzzzz_);
                        Date czzzzzc_ = bzzzzzv_?.BirthDateElement;
                        CqlDate czzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzzzzc_);
                        Quantity czzzzze_ = (onset as Range)?.High;
                        CqlQuantity czzzzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzzze_);
                        CqlDate czzzzzg_ = context.Operators.Add(czzzzzd_, czzzzzf_);
                        CqlQuantity czzzzzh_ = context.Operators.Quantity(1m, "year");
                        CqlDate czzzzzi_ = context.Operators.Add(czzzzzg_, czzzzzh_);
                        CqlInterval<CqlDate> czzzzzj_ = context.Operators.Interval(czzzzza_, czzzzzi_, true, false);

                        return czzzzzj_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? yzzzza_ = (xzzzzz_())?.highClosed;
                CqlInterval<CqlDateTime> yzzzzb_ = context.Operators.Interval(xzzzzt_, xzzzzw_, xzzzzy_, yzzzza_);

                return yzzzzb_;
            }
        };

        return xzzzzh_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {
        CqlInterval<CqlDateTime> czzzzzk_()
        {
            if (abatement is FhirDateTime)
            {
                CqlDateTime czzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, abatement as FhirDateTime);
                CqlInterval<CqlDateTime> czzzzzn_ = context.Operators.Interval(czzzzzl_, czzzzzl_, true, true);

                return czzzzzn_;
            }
            else if (abatement is Period)
            {
                FhirDateTime czzzzzo_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
                CqlDateTime czzzzzp_ = context.Operators.Convert<CqlDateTime>(czzzzzo_);
                FhirDateTime czzzzzq_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
                CqlDateTime czzzzzr_ = context.Operators.Convert<CqlDateTime>(czzzzzq_);
                CqlInterval<CqlDateTime> czzzzzs_ = context.Operators.Interval(czzzzzp_, czzzzzr_, true, true);

                return czzzzzs_;
            }
            else if (abatement is FhirString)
            {
                CqlInterval<CqlDateTime> czzzzzt_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return czzzzzt_;
            }
            else
            {
                CqlInterval<CqlDate> czzzzzu_()
                {
                    if (abatement is Age)
                    {
                        Patient dzzzzzf_ = this.Patient(context);
                        Date dzzzzzg_ = dzzzzzf_?.BirthDateElement;
                        CqlDate dzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzzzzg_);
                        CqlQuantity dzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate dzzzzzj_ = context.Operators.Add(dzzzzzh_, dzzzzzi_);
                        Date dzzzzzl_ = dzzzzzf_?.BirthDateElement;
                        CqlDate dzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzzzzl_);
                        CqlDate dzzzzzo_ = context.Operators.Add(dzzzzzm_, dzzzzzi_);
                        CqlQuantity dzzzzzp_ = context.Operators.Quantity(1m, "year");
                        CqlDate dzzzzzq_ = context.Operators.Add(dzzzzzo_, dzzzzzp_);
                        CqlInterval<CqlDate> dzzzzzr_ = context.Operators.Interval(dzzzzzj_, dzzzzzq_, true, false);

                        return dzzzzzr_;
                    }
                    else if (abatement is Range)
                    {
                        Patient dzzzzzs_ = this.Patient(context);
                        Date dzzzzzt_ = dzzzzzs_?.BirthDateElement;
                        CqlDate dzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzzzzt_);
                        Quantity dzzzzzv_ = (abatement as Range)?.Low;
                        CqlQuantity dzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dzzzzzv_);
                        CqlDate dzzzzzx_ = context.Operators.Add(dzzzzzu_, dzzzzzw_);
                        Date dzzzzzz_ = dzzzzzs_?.BirthDateElement;
                        CqlDate ezzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzzzzz_);
                        Quantity ezzzzzb_ = (abatement as Range)?.High;
                        CqlQuantity ezzzzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezzzzzb_);
                        CqlDate ezzzzzd_ = context.Operators.Add(ezzzzza_, ezzzzzc_);
                        CqlQuantity ezzzzze_ = context.Operators.Quantity(1m, "year");
                        CqlDate ezzzzzf_ = context.Operators.Add(ezzzzzd_, ezzzzze_);
                        CqlInterval<CqlDate> ezzzzzg_ = context.Operators.Interval(dzzzzzx_, ezzzzzf_, true, false);

                        return ezzzzzg_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate czzzzzv_ = (czzzzzu_())?.low;
                CqlDateTime czzzzzw_ = context.Operators.ConvertDateToDateTime(czzzzzv_);
                CqlInterval<CqlDate> czzzzzx_()
                {
                    if (abatement is Age)
                    {
                        Patient ezzzzzh_ = this.Patient(context);
                        Date ezzzzzi_ = ezzzzzh_?.BirthDateElement;
                        CqlDate ezzzzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezzzzzi_);
                        CqlQuantity ezzzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate ezzzzzl_ = context.Operators.Add(ezzzzzj_, ezzzzzk_);
                        Date ezzzzzn_ = ezzzzzh_?.BirthDateElement;
                        CqlDate ezzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezzzzzn_);
                        CqlDate ezzzzzq_ = context.Operators.Add(ezzzzzo_, ezzzzzk_);
                        CqlQuantity ezzzzzr_ = context.Operators.Quantity(1m, "year");
                        CqlDate ezzzzzs_ = context.Operators.Add(ezzzzzq_, ezzzzzr_);
                        CqlInterval<CqlDate> ezzzzzt_ = context.Operators.Interval(ezzzzzl_, ezzzzzs_, true, false);

                        return ezzzzzt_;
                    }
                    else if (abatement is Range)
                    {
                        Patient ezzzzzu_ = this.Patient(context);
                        Date ezzzzzv_ = ezzzzzu_?.BirthDateElement;
                        CqlDate ezzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezzzzzv_);
                        Quantity ezzzzzx_ = (abatement as Range)?.Low;
                        CqlQuantity ezzzzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ezzzzzx_);
                        CqlDate ezzzzzz_ = context.Operators.Add(ezzzzzw_, ezzzzzy_);
                        Date fzzzzzb_ = ezzzzzu_?.BirthDateElement;
                        CqlDate fzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzzzzb_);
                        Quantity fzzzzzd_ = (abatement as Range)?.High;
                        CqlQuantity fzzzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, fzzzzzd_);
                        CqlDate fzzzzzf_ = context.Operators.Add(fzzzzzc_, fzzzzze_);
                        CqlQuantity fzzzzzg_ = context.Operators.Quantity(1m, "year");
                        CqlDate fzzzzzh_ = context.Operators.Add(fzzzzzf_, fzzzzzg_);
                        CqlInterval<CqlDate> fzzzzzi_ = context.Operators.Interval(ezzzzzz_, fzzzzzh_, true, false);

                        return fzzzzzi_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate czzzzzy_ = (czzzzzx_())?.high;
                CqlDateTime czzzzzz_ = context.Operators.ConvertDateToDateTime(czzzzzy_);
                CqlInterval<CqlDate> dzzzzza_()
                {
                    if (abatement is Age)
                    {
                        Patient fzzzzzj_ = this.Patient(context);
                        Date fzzzzzk_ = fzzzzzj_?.BirthDateElement;
                        CqlDate fzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzzzzk_);
                        CqlQuantity fzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate fzzzzzn_ = context.Operators.Add(fzzzzzl_, fzzzzzm_);
                        Date fzzzzzp_ = fzzzzzj_?.BirthDateElement;
                        CqlDate fzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzzzzp_);
                        CqlDate fzzzzzs_ = context.Operators.Add(fzzzzzq_, fzzzzzm_);
                        CqlQuantity fzzzzzt_ = context.Operators.Quantity(1m, "year");
                        CqlDate fzzzzzu_ = context.Operators.Add(fzzzzzs_, fzzzzzt_);
                        CqlInterval<CqlDate> fzzzzzv_ = context.Operators.Interval(fzzzzzn_, fzzzzzu_, true, false);

                        return fzzzzzv_;
                    }
                    else if (abatement is Range)
                    {
                        Patient fzzzzzw_ = this.Patient(context);
                        Date fzzzzzx_ = fzzzzzw_?.BirthDateElement;
                        CqlDate fzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzzzzx_);
                        Quantity fzzzzzz_ = (abatement as Range)?.Low;
                        CqlQuantity gzzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, fzzzzzz_);
                        CqlDate gzzzzzb_ = context.Operators.Add(fzzzzzy_, gzzzzza_);
                        Date gzzzzzd_ = fzzzzzw_?.BirthDateElement;
                        CqlDate gzzzzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzzzzd_);
                        Quantity gzzzzzf_ = (abatement as Range)?.High;
                        CqlQuantity gzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzf_);
                        CqlDate gzzzzzh_ = context.Operators.Add(gzzzzze_, gzzzzzg_);
                        CqlQuantity gzzzzzi_ = context.Operators.Quantity(1m, "year");
                        CqlDate gzzzzzj_ = context.Operators.Add(gzzzzzh_, gzzzzzi_);
                        CqlInterval<CqlDate> gzzzzzk_ = context.Operators.Interval(gzzzzzb_, gzzzzzj_, true, false);

                        return gzzzzzk_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? dzzzzzb_ = (dzzzzza_())?.lowClosed;
                CqlInterval<CqlDate> dzzzzzc_()
                {
                    if (abatement is Age)
                    {
                        Patient gzzzzzl_ = this.Patient(context);
                        Date gzzzzzm_ = gzzzzzl_?.BirthDateElement;
                        CqlDate gzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzzzzm_);
                        CqlQuantity gzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate gzzzzzp_ = context.Operators.Add(gzzzzzn_, gzzzzzo_);
                        Date gzzzzzr_ = gzzzzzl_?.BirthDateElement;
                        CqlDate gzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzzzzr_);
                        CqlDate gzzzzzu_ = context.Operators.Add(gzzzzzs_, gzzzzzo_);
                        CqlQuantity gzzzzzv_ = context.Operators.Quantity(1m, "year");
                        CqlDate gzzzzzw_ = context.Operators.Add(gzzzzzu_, gzzzzzv_);
                        CqlInterval<CqlDate> gzzzzzx_ = context.Operators.Interval(gzzzzzp_, gzzzzzw_, true, false);

                        return gzzzzzx_;
                    }
                    else if (abatement is Range)
                    {
                        Patient gzzzzzy_ = this.Patient(context);
                        Date gzzzzzz_ = gzzzzzy_?.BirthDateElement;
                        CqlDate hzzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzzzzz_);
                        Quantity hzzzzzb_ = (abatement as Range)?.Low;
                        CqlQuantity hzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, hzzzzzb_);
                        CqlDate hzzzzzd_ = context.Operators.Add(hzzzzza_, hzzzzzc_);
                        Date hzzzzzf_ = gzzzzzy_?.BirthDateElement;
                        CqlDate hzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzf_);
                        Quantity hzzzzzh_ = (abatement as Range)?.High;
                        CqlQuantity hzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, hzzzzzh_);
                        CqlDate hzzzzzj_ = context.Operators.Add(hzzzzzg_, hzzzzzi_);
                        CqlQuantity hzzzzzk_ = context.Operators.Quantity(1m, "year");
                        CqlDate hzzzzzl_ = context.Operators.Add(hzzzzzj_, hzzzzzk_);
                        CqlInterval<CqlDate> hzzzzzm_ = context.Operators.Interval(hzzzzzd_, hzzzzzl_, true, false);

                        return hzzzzzm_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? dzzzzzd_ = (dzzzzzc_())?.highClosed;
                CqlInterval<CqlDateTime> dzzzzze_ = context.Operators.Interval(czzzzzw_, czzzzzz_, dzzzzzb_, dzzzzzd_);

                return dzzzzze_;
            }
        };

        return czzzzzk_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        DataType hzzzzzn_ = condition?.Onset;
        CqlInterval<CqlDateTime> hzzzzzo_ = this.Normalize_Onset(context, hzzzzzn_);
        CqlDateTime hzzzzzp_ = context.Operators.Start(hzzzzzo_);
        DataType hzzzzzq_ = condition?.Abatement;
        CqlInterval<CqlDateTime> hzzzzzr_ = this.Normalize_Abatement(context, hzzzzzq_);
        CqlDateTime hzzzzzs_ = context.Operators.End(hzzzzzr_);
        CqlInterval<CqlDateTime> hzzzzzt_ = context.Operators.Interval(hzzzzzp_, hzzzzzs_, true, true);

        return hzzzzzt_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> hzzzzzu_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime hzzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> hzzzzzx_ = context.Operators.Interval(hzzzzzv_, hzzzzzv_, true, true);

                return hzzzzzx_;
            }
            else if (choice is Date)
            {
                CqlDate hzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
                CqlDateTime hzzzzzz_ = context.Operators.ConvertDateToDateTime(hzzzzzy_);
                CqlDateTime izzzzzb_ = context.Operators.ConvertDateToDateTime(hzzzzzy_);
                CqlInterval<CqlDateTime> izzzzzc_ = context.Operators.Interval(hzzzzzz_, izzzzzb_, true, true);

                return izzzzzc_;
            }
            else if (choice is Period)
            {
                FhirDateTime izzzzzd_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
                CqlDateTime izzzzze_ = context.Operators.Convert<CqlDateTime>(izzzzzd_);
                FhirDateTime izzzzzf_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
                CqlDateTime izzzzzg_ = context.Operators.Convert<CqlDateTime>(izzzzzf_);
                CqlInterval<CqlDateTime> izzzzzh_ = context.Operators.Interval(izzzzze_, izzzzzg_, true, true);

                return izzzzzh_;
            }
            else if (choice is Instant)
            {
                CqlDateTime izzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> izzzzzk_ = context.Operators.Interval(izzzzzi_, izzzzzi_, true, true);

                return izzzzzk_;
            }
            else if (choice is Age)
            {
                Patient izzzzzl_ = this.Patient(context);
                Date izzzzzm_ = izzzzzl_?.BirthDateElement;
                CqlDate izzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izzzzzm_);
                CqlQuantity izzzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate izzzzzp_ = context.Operators.Add(izzzzzn_, izzzzzo_);
                Date izzzzzr_ = izzzzzl_?.BirthDateElement;
                CqlDate izzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izzzzzr_);
                CqlDate izzzzzu_ = context.Operators.Add(izzzzzs_, izzzzzo_);
                CqlQuantity izzzzzv_ = context.Operators.Quantity(1m, "year");
                CqlDate izzzzzw_ = context.Operators.Add(izzzzzu_, izzzzzv_);
                CqlInterval<CqlDate> izzzzzx_ = context.Operators.Interval(izzzzzp_, izzzzzw_, true, false);
                CqlDate izzzzzy_ = izzzzzx_?.low;
                CqlDateTime izzzzzz_ = context.Operators.ConvertDateToDateTime(izzzzzy_);
                Date jzzzzzb_ = izzzzzl_?.BirthDateElement;
                CqlDate jzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzb_);
                CqlDate jzzzzze_ = context.Operators.Add(jzzzzzc_, izzzzzo_);
                Date jzzzzzg_ = izzzzzl_?.BirthDateElement;
                CqlDate jzzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzg_);
                CqlDate jzzzzzj_ = context.Operators.Add(jzzzzzh_, izzzzzo_);
                CqlDate jzzzzzl_ = context.Operators.Add(jzzzzzj_, izzzzzv_);
                CqlInterval<CqlDate> jzzzzzm_ = context.Operators.Interval(jzzzzze_, jzzzzzl_, true, false);
                CqlDate jzzzzzn_ = jzzzzzm_?.high;
                CqlDateTime jzzzzzo_ = context.Operators.ConvertDateToDateTime(jzzzzzn_);
                Date jzzzzzq_ = izzzzzl_?.BirthDateElement;
                CqlDate jzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzq_);
                CqlDate jzzzzzt_ = context.Operators.Add(jzzzzzr_, izzzzzo_);
                Date jzzzzzv_ = izzzzzl_?.BirthDateElement;
                CqlDate jzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, jzzzzzv_);
                CqlDate jzzzzzy_ = context.Operators.Add(jzzzzzw_, izzzzzo_);
                CqlDate kzzzzza_ = context.Operators.Add(jzzzzzy_, izzzzzv_);
                CqlInterval<CqlDate> kzzzzzb_ = context.Operators.Interval(jzzzzzt_, kzzzzza_, true, false);
                bool? kzzzzzc_ = kzzzzzb_?.lowClosed;
                Date kzzzzze_ = izzzzzl_?.BirthDateElement;
                CqlDate kzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzzzze_);
                CqlDate kzzzzzh_ = context.Operators.Add(kzzzzzf_, izzzzzo_);
                Date kzzzzzj_ = izzzzzl_?.BirthDateElement;
                CqlDate kzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzzzzj_);
                CqlDate kzzzzzm_ = context.Operators.Add(kzzzzzk_, izzzzzo_);
                CqlDate kzzzzzo_ = context.Operators.Add(kzzzzzm_, izzzzzv_);
                CqlInterval<CqlDate> kzzzzzp_ = context.Operators.Interval(kzzzzzh_, kzzzzzo_, true, false);
                bool? kzzzzzq_ = kzzzzzp_?.highClosed;
                CqlInterval<CqlDateTime> kzzzzzr_ = context.Operators.Interval(izzzzzz_, jzzzzzo_, kzzzzzc_, kzzzzzq_);

                return kzzzzzr_;
            }
            else if (choice is Range)
            {
                Patient kzzzzzs_ = this.Patient(context);
                Date kzzzzzt_ = kzzzzzs_?.BirthDateElement;
                CqlDate kzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzzzzt_);
                Quantity kzzzzzv_ = (choice as Range)?.Low;
                CqlQuantity kzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzzzzzv_);
                CqlDate kzzzzzx_ = context.Operators.Add(kzzzzzu_, kzzzzzw_);
                Date kzzzzzz_ = kzzzzzs_?.BirthDateElement;
                CqlDate lzzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzzzzz_);
                Quantity lzzzzzb_ = (choice as Range)?.High;
                CqlQuantity lzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzzzzb_);
                CqlDate lzzzzzd_ = context.Operators.Add(lzzzzza_, lzzzzzc_);
                CqlQuantity lzzzzze_ = context.Operators.Quantity(1m, "year");
                CqlDate lzzzzzf_ = context.Operators.Add(lzzzzzd_, lzzzzze_);
                CqlInterval<CqlDate> lzzzzzg_ = context.Operators.Interval(kzzzzzx_, lzzzzzf_, true, false);
                CqlDate lzzzzzh_ = lzzzzzg_?.low;
                CqlDateTime lzzzzzi_ = context.Operators.ConvertDateToDateTime(lzzzzzh_);
                Date lzzzzzk_ = kzzzzzs_?.BirthDateElement;
                CqlDate lzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzzzzk_);
                CqlQuantity lzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzzzzzv_);
                CqlDate lzzzzzo_ = context.Operators.Add(lzzzzzl_, lzzzzzn_);
                Date lzzzzzq_ = kzzzzzs_?.BirthDateElement;
                CqlDate lzzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzzzzq_);
                CqlQuantity lzzzzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzzzzb_);
                CqlDate lzzzzzu_ = context.Operators.Add(lzzzzzr_, lzzzzzt_);
                CqlDate lzzzzzw_ = context.Operators.Add(lzzzzzu_, lzzzzze_);
                CqlInterval<CqlDate> lzzzzzx_ = context.Operators.Interval(lzzzzzo_, lzzzzzw_, true, false);
                CqlDate lzzzzzy_ = lzzzzzx_?.high;
                CqlDateTime lzzzzzz_ = context.Operators.ConvertDateToDateTime(lzzzzzy_);
                Date mzzzzzb_ = kzzzzzs_?.BirthDateElement;
                CqlDate mzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzzzzzb_);
                CqlQuantity mzzzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzzzzzv_);
                CqlDate mzzzzzf_ = context.Operators.Add(mzzzzzc_, mzzzzze_);
                Date mzzzzzh_ = kzzzzzs_?.BirthDateElement;
                CqlDate mzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzzzzzh_);
                CqlQuantity mzzzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzzzzb_);
                CqlDate mzzzzzl_ = context.Operators.Add(mzzzzzi_, mzzzzzk_);
                CqlDate mzzzzzn_ = context.Operators.Add(mzzzzzl_, lzzzzze_);
                CqlInterval<CqlDate> mzzzzzo_ = context.Operators.Interval(mzzzzzf_, mzzzzzn_, true, false);
                bool? mzzzzzp_ = mzzzzzo_?.lowClosed;
                Date mzzzzzr_ = kzzzzzs_?.BirthDateElement;
                CqlDate mzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzzzzzr_);
                CqlQuantity mzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, kzzzzzv_);
                CqlDate mzzzzzv_ = context.Operators.Add(mzzzzzs_, mzzzzzu_);
                Date mzzzzzx_ = kzzzzzs_?.BirthDateElement;
                CqlDate mzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzzzzzx_);
                CqlQuantity nzzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzzzzb_);
                CqlDate nzzzzzb_ = context.Operators.Add(mzzzzzy_, nzzzzza_);
                CqlDate nzzzzzd_ = context.Operators.Add(nzzzzzb_, lzzzzze_);
                CqlInterval<CqlDate> nzzzzze_ = context.Operators.Interval(mzzzzzv_, nzzzzzd_, true, false);
                bool? nzzzzzf_ = nzzzzze_?.highClosed;
                CqlInterval<CqlDateTime> nzzzzzg_ = context.Operators.Interval(lzzzzzi_, lzzzzzz_, mzzzzzp_, nzzzzzf_);

                return nzzzzzg_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> nzzzzzh_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return nzzzzzh_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> nzzzzzi_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return nzzzzzi_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return hzzzzzu_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public string GetId(CqlContext context, string uri)
    {
        string nzzzzzj_()
        {
            bool nzzzzzk_()
            {
                int? nzzzzzl_ = context.Operators.PositionOf("/", uri);
                bool? nzzzzzm_ = context.Operators.Greater(nzzzzzl_, 0);

                return nzzzzzm_ ?? false;
            };
            if (nzzzzzk_())
            {
                IEnumerable<string> nzzzzzn_ = context.Operators.Split(uri, "/");
                string nzzzzzo_ = context.Operators.Last<string>(nzzzzzn_);

                return nzzzzzo_;
            }
            else
            {
                return uri;
            }
        };

        return nzzzzzj_();
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) =>
        VSet;


    // NOT A DEFINITION CqlExpressionDefinition//
    public (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
    {
        CqlDate nzzzzzp_(CqlDate d) =>
            d;
        IEnumerable<CqlDate> nzzzzzq_ = context.Operators.Select<CqlDate, CqlDate>(DateList, nzzzzzp_);
        IEnumerable<CqlDate> nzzzzzr_ = context.Operators.Distinct<CqlDate>(nzzzzzq_);
        IEnumerable<CqlDate> nzzzzzs_ = context.Operators.ListSort<CqlDate>(nzzzzzr_, System.ComponentModel.ListSortDirection.Ascending);
        bool? nzzzzzt_(CqlDate X)
        {
            bool? ozzzzzb_ = context.Operators.Not((bool?)(X is null));

            return ozzzzzb_;
        };
        IEnumerable<CqlDate> nzzzzzu_ = context.Operators.Where<CqlDate>(nzzzzzs_, nzzzzzt_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? nzzzzzv_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, nzzzzzu_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] nzzzzzw_ = [
            nzzzzzv_,
        ];
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzzzx_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates)
        {
            IEnumerable<CqlDate> ozzzzzc_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? ozzzzzd_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, ozzzzzc_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] ozzzzze_ = [
                ozzzzzd_,
            ];
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzf_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList)
            {
                IEnumerable<CqlDate> ozzzzzj_ = AnchorList?.SortedList;
                int? ozzzzzk_ = AnchorList?.AnchorIndex;
                CqlDate ozzzzzl_ = context.Operators.Indexer<CqlDate>(ozzzzzj_, ozzzzzk_);
                bool? ozzzzzm_(CqlDate X)
                {
                    IEnumerable<CqlDate> ozzzzzw_ = AnchorList?.SortedList;
                    int? ozzzzzx_ = AnchorList?.AnchorIndex;
                    CqlDate ozzzzzy_ = context.Operators.Indexer<CqlDate>(ozzzzzw_, ozzzzzx_);
                    CqlQuantity ozzzzzz_ = context.Operators.Quantity(1m, "day");
                    CqlDate pzzzzza_ = context.Operators.Add(ozzzzzy_ as CqlDate, ozzzzzz_);
                    CqlDate pzzzzzd_ = context.Operators.Indexer<CqlDate>(ozzzzzw_, ozzzzzx_);
                    CqlQuantity pzzzzze_ = context.Operators.Quantity(30m, "days");
                    CqlDate pzzzzzf_ = context.Operators.Add(pzzzzzd_ as CqlDate, pzzzzze_);
                    CqlInterval<CqlDate> pzzzzzg_ = context.Operators.Interval(pzzzzza_, pzzzzzf_, true, true);
                    bool? pzzzzzh_ = context.Operators.In<CqlDate>(X, pzzzzzg_, default);
                    bool? pzzzzzi_ = context.Operators.Not(pzzzzzh_);

                    return pzzzzzi_;
                };
                IEnumerable<CqlDate> ozzzzzn_ = context.Operators.Where<CqlDate>(DateList, ozzzzzm_);
                int? ozzzzzp_ = context.Operators.Add(ozzzzzk_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ozzzzzl_ as CqlDate, ozzzzzn_, ozzzzzp_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ozzzzzr_ = [
                    ozzzzzq_,
                ];
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzs_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList)
                {
                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzj_()
                    {
                        bool pzzzzzk_()
                        {
                            IEnumerable<CqlDate> pzzzzzl_ = FirstList?.NewList;
                            int? pzzzzzm_ = FirstList?.IndexofNewDate;
                            CqlDate pzzzzzn_ = context.Operators.Indexer<CqlDate>(pzzzzzl_, pzzzzzm_);

                            return pzzzzzn_ is null;
                        };
                        if (pzzzzzk_())
                        {
                            return FirstList;
                        }
                        else
                        {
                            IEnumerable<CqlDate> pzzzzzo_ = FirstList?.NewList;
                            int? pzzzzzp_ = FirstList?.IndexofNewDate;
                            CqlDate pzzzzzq_ = context.Operators.Indexer<CqlDate>(pzzzzzo_, pzzzzzp_);
                            bool? pzzzzzs_(CqlDate X)
                            {
                                IEnumerable<CqlDate> qzzzzzc_ = FirstList?.NewList;
                                int? qzzzzzd_ = FirstList?.IndexofNewDate;
                                CqlDate qzzzzze_ = context.Operators.Indexer<CqlDate>(qzzzzzc_, qzzzzzd_);
                                CqlQuantity qzzzzzf_ = context.Operators.Quantity(1m, "day");
                                CqlDate qzzzzzg_ = context.Operators.Add(qzzzzze_ as CqlDate, qzzzzzf_);
                                CqlDate qzzzzzj_ = context.Operators.Indexer<CqlDate>(qzzzzzc_, qzzzzzd_);
                                CqlQuantity qzzzzzk_ = context.Operators.Quantity(30m, "days");
                                CqlDate qzzzzzl_ = context.Operators.Add(qzzzzzj_ as CqlDate, qzzzzzk_);
                                CqlInterval<CqlDate> qzzzzzm_ = context.Operators.Interval(qzzzzzg_, qzzzzzl_, true, true);
                                bool? qzzzzzn_ = context.Operators.In<CqlDate>(X, qzzzzzm_, default);
                                bool? qzzzzzo_ = context.Operators.Not(qzzzzzn_);

                                return qzzzzzo_;
                            };
                            IEnumerable<CqlDate> pzzzzzt_ = context.Operators.Where<CqlDate>(pzzzzzo_, pzzzzzs_);
                            int? pzzzzzv_ = context.Operators.Add(pzzzzzp_, 1);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzw_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, pzzzzzq_ as CqlDate, pzzzzzt_, pzzzzzv_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] pzzzzzx_ = [
                                pzzzzzw_,
                            ];
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzy_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList)
                            {
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzzp_()
                                {
                                    bool qzzzzzq_()
                                    {
                                        IEnumerable<CqlDate> qzzzzzr_ = SecondList?.NewList;
                                        int? qzzzzzs_ = SecondList?.IndexofNewDate;
                                        CqlDate qzzzzzt_ = context.Operators.Indexer<CqlDate>(qzzzzzr_, qzzzzzs_);

                                        return qzzzzzt_ is null;
                                    };
                                    if (qzzzzzq_())
                                    {
                                        return SecondList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> qzzzzzu_ = SecondList?.NewList;
                                        int? qzzzzzv_ = SecondList?.IndexofNewDate;
                                        CqlDate qzzzzzw_ = context.Operators.Indexer<CqlDate>(qzzzzzu_, qzzzzzv_);
                                        bool? qzzzzzy_(CqlDate X)
                                        {
                                            IEnumerable<CqlDate> rzzzzzi_ = SecondList?.NewList;
                                            int? rzzzzzj_ = SecondList?.IndexofNewDate;
                                            CqlDate rzzzzzk_ = context.Operators.Indexer<CqlDate>(rzzzzzi_, rzzzzzj_);
                                            CqlQuantity rzzzzzl_ = context.Operators.Quantity(1m, "day");
                                            CqlDate rzzzzzm_ = context.Operators.Add(rzzzzzk_ as CqlDate, rzzzzzl_);
                                            CqlDate rzzzzzp_ = context.Operators.Indexer<CqlDate>(rzzzzzi_, rzzzzzj_);
                                            CqlQuantity rzzzzzq_ = context.Operators.Quantity(30m, "days");
                                            CqlDate rzzzzzr_ = context.Operators.Add(rzzzzzp_ as CqlDate, rzzzzzq_);
                                            CqlInterval<CqlDate> rzzzzzs_ = context.Operators.Interval(rzzzzzm_, rzzzzzr_, true, true);
                                            bool? rzzzzzt_ = context.Operators.In<CqlDate>(X, rzzzzzs_, default);
                                            bool? rzzzzzu_ = context.Operators.Not(rzzzzzt_);

                                            return rzzzzzu_;
                                        };
                                        IEnumerable<CqlDate> qzzzzzz_ = context.Operators.Where<CqlDate>(qzzzzzu_, qzzzzzy_);
                                        int? rzzzzzb_ = context.Operators.Add(qzzzzzv_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzzc_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, qzzzzzw_ as CqlDate, qzzzzzz_, rzzzzzb_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] rzzzzzd_ = [
                                            rzzzzzc_,
                                        ];
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzze_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList)
                                        {
                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzzv_()
                                            {
                                                bool rzzzzzw_()
                                                {
                                                    IEnumerable<CqlDate> rzzzzzx_ = ThirdList?.NewList;
                                                    int? rzzzzzy_ = ThirdList?.IndexofNewDate;
                                                    CqlDate rzzzzzz_ = context.Operators.Indexer<CqlDate>(rzzzzzx_, rzzzzzy_);

                                                    return rzzzzzz_ is null;
                                                };
                                                if (rzzzzzw_())
                                                {
                                                    return ThirdList;
                                                }
                                                else
                                                {
                                                    IEnumerable<CqlDate> szzzzza_ = ThirdList?.NewList;
                                                    int? szzzzzb_ = ThirdList?.IndexofNewDate;
                                                    CqlDate szzzzzc_ = context.Operators.Indexer<CqlDate>(szzzzza_, szzzzzb_);
                                                    bool? szzzzze_(CqlDate X)
                                                    {
                                                        IEnumerable<CqlDate> szzzzzo_ = ThirdList?.NewList;
                                                        int? szzzzzp_ = ThirdList?.IndexofNewDate;
                                                        CqlDate szzzzzq_ = context.Operators.Indexer<CqlDate>(szzzzzo_, szzzzzp_);
                                                        CqlQuantity szzzzzr_ = context.Operators.Quantity(1m, "day");
                                                        CqlDate szzzzzs_ = context.Operators.Add(szzzzzq_ as CqlDate, szzzzzr_);
                                                        CqlDate szzzzzv_ = context.Operators.Indexer<CqlDate>(szzzzzo_, szzzzzp_);
                                                        CqlQuantity szzzzzw_ = context.Operators.Quantity(30m, "days");
                                                        CqlDate szzzzzx_ = context.Operators.Add(szzzzzv_ as CqlDate, szzzzzw_);
                                                        CqlInterval<CqlDate> szzzzzy_ = context.Operators.Interval(szzzzzs_, szzzzzx_, true, true);
                                                        bool? szzzzzz_ = context.Operators.In<CqlDate>(X, szzzzzy_, default);
                                                        bool? tzzzzza_ = context.Operators.Not(szzzzzz_);

                                                        return tzzzzza_;
                                                    };
                                                    IEnumerable<CqlDate> szzzzzf_ = context.Operators.Where<CqlDate>(szzzzza_, szzzzze_);
                                                    int? szzzzzh_ = context.Operators.Add(szzzzzb_, 1);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzzzzi_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, szzzzzc_ as CqlDate, szzzzzf_, szzzzzh_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] szzzzzj_ = [
                                                        szzzzzi_,
                                                    ];
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzzzzk_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList)
                                                    {
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzzzzb_()
                                                        {
                                                            bool tzzzzzc_()
                                                            {
                                                                IEnumerable<CqlDate> tzzzzzd_ = FourthList?.NewList;
                                                                int? tzzzzze_ = FourthList?.IndexofNewDate;
                                                                CqlDate tzzzzzf_ = context.Operators.Indexer<CqlDate>(tzzzzzd_, tzzzzze_);

                                                                return tzzzzzf_ is null;
                                                            };
                                                            if (tzzzzzc_())
                                                            {
                                                                return FourthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> tzzzzzg_ = FourthList?.NewList;
                                                                int? tzzzzzh_ = FourthList?.IndexofNewDate;
                                                                CqlDate tzzzzzi_ = context.Operators.Indexer<CqlDate>(tzzzzzg_, tzzzzzh_);
                                                                bool? tzzzzzk_(CqlDate X)
                                                                {
                                                                    IEnumerable<CqlDate> tzzzzzu_ = FourthList?.NewList;
                                                                    int? tzzzzzv_ = FourthList?.IndexofNewDate;
                                                                    CqlDate tzzzzzw_ = context.Operators.Indexer<CqlDate>(tzzzzzu_, tzzzzzv_);
                                                                    CqlQuantity tzzzzzx_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate tzzzzzy_ = context.Operators.Add(tzzzzzw_ as CqlDate, tzzzzzx_);
                                                                    CqlDate uzzzzzb_ = context.Operators.Indexer<CqlDate>(tzzzzzu_, tzzzzzv_);
                                                                    CqlQuantity uzzzzzc_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate uzzzzzd_ = context.Operators.Add(uzzzzzb_ as CqlDate, uzzzzzc_);
                                                                    CqlInterval<CqlDate> uzzzzze_ = context.Operators.Interval(tzzzzzy_, uzzzzzd_, true, true);
                                                                    bool? uzzzzzf_ = context.Operators.In<CqlDate>(X, uzzzzze_, default);
                                                                    bool? uzzzzzg_ = context.Operators.Not(uzzzzzf_);

                                                                    return uzzzzzg_;
                                                                };
                                                                IEnumerable<CqlDate> tzzzzzl_ = context.Operators.Where<CqlDate>(tzzzzzg_, tzzzzzk_);
                                                                int? tzzzzzn_ = context.Operators.Add(tzzzzzh_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzzzzo_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, tzzzzzi_ as CqlDate, tzzzzzl_, tzzzzzn_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] tzzzzzp_ = [
                                                                    tzzzzzo_,
                                                                ];
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzzzzq_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList)
                                                                {
                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzzzzh_()
                                                                    {
                                                                        bool uzzzzzi_()
                                                                        {
                                                                            IEnumerable<CqlDate> uzzzzzj_ = FifthList?.NewList;
                                                                            int? uzzzzzk_ = FifthList?.IndexofNewDate;
                                                                            CqlDate uzzzzzl_ = context.Operators.Indexer<CqlDate>(uzzzzzj_, uzzzzzk_);

                                                                            return uzzzzzl_ is null;
                                                                        };
                                                                        if (uzzzzzi_())
                                                                        {
                                                                            return FifthList;
                                                                        }
                                                                        else
                                                                        {
                                                                            IEnumerable<CqlDate> uzzzzzm_ = FifthList?.NewList;
                                                                            int? uzzzzzn_ = FifthList?.IndexofNewDate;
                                                                            CqlDate uzzzzzo_ = context.Operators.Indexer<CqlDate>(uzzzzzm_, uzzzzzn_);
                                                                            bool? uzzzzzq_(CqlDate X)
                                                                            {
                                                                                IEnumerable<CqlDate> vzzzzza_ = FifthList?.NewList;
                                                                                int? vzzzzzb_ = FifthList?.IndexofNewDate;
                                                                                CqlDate vzzzzzc_ = context.Operators.Indexer<CqlDate>(vzzzzza_, vzzzzzb_);
                                                                                CqlQuantity vzzzzzd_ = context.Operators.Quantity(1m, "day");
                                                                                CqlDate vzzzzze_ = context.Operators.Add(vzzzzzc_ as CqlDate, vzzzzzd_);
                                                                                CqlDate vzzzzzh_ = context.Operators.Indexer<CqlDate>(vzzzzza_, vzzzzzb_);
                                                                                CqlQuantity vzzzzzi_ = context.Operators.Quantity(30m, "days");
                                                                                CqlDate vzzzzzj_ = context.Operators.Add(vzzzzzh_ as CqlDate, vzzzzzi_);
                                                                                CqlInterval<CqlDate> vzzzzzk_ = context.Operators.Interval(vzzzzze_, vzzzzzj_, true, true);
                                                                                bool? vzzzzzl_ = context.Operators.In<CqlDate>(X, vzzzzzk_, default);
                                                                                bool? vzzzzzm_ = context.Operators.Not(vzzzzzl_);

                                                                                return vzzzzzm_;
                                                                            };
                                                                            IEnumerable<CqlDate> uzzzzzr_ = context.Operators.Where<CqlDate>(uzzzzzm_, uzzzzzq_);
                                                                            int? uzzzzzt_ = context.Operators.Add(uzzzzzn_, 1);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzzzzu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, uzzzzzo_ as CqlDate, uzzzzzr_, uzzzzzt_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] uzzzzzv_ = [
                                                                                uzzzzzu_,
                                                                            ];
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzzzzw_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList)
                                                                            {
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? vzzzzzn_()
                                                                                {
                                                                                    bool vzzzzzo_()
                                                                                    {
                                                                                        IEnumerable<CqlDate> vzzzzzp_ = SixthList?.NewList;
                                                                                        int? vzzzzzq_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate vzzzzzr_ = context.Operators.Indexer<CqlDate>(vzzzzzp_, vzzzzzq_);

                                                                                        return vzzzzzr_ is null;
                                                                                    };
                                                                                    if (vzzzzzo_())
                                                                                    {
                                                                                        return SixthList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> vzzzzzs_ = SixthList?.NewList;
                                                                                        int? vzzzzzt_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate vzzzzzu_ = context.Operators.Indexer<CqlDate>(vzzzzzs_, vzzzzzt_);
                                                                                        bool? vzzzzzw_(CqlDate X)
                                                                                        {
                                                                                            IEnumerable<CqlDate> wzzzzzg_ = SixthList?.NewList;
                                                                                            int? wzzzzzh_ = SixthList?.IndexofNewDate;
                                                                                            CqlDate wzzzzzi_ = context.Operators.Indexer<CqlDate>(wzzzzzg_, wzzzzzh_);
                                                                                            CqlQuantity wzzzzzj_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate wzzzzzk_ = context.Operators.Add(wzzzzzi_ as CqlDate, wzzzzzj_);
                                                                                            CqlDate wzzzzzn_ = context.Operators.Indexer<CqlDate>(wzzzzzg_, wzzzzzh_);
                                                                                            CqlQuantity wzzzzzo_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate wzzzzzp_ = context.Operators.Add(wzzzzzn_ as CqlDate, wzzzzzo_);
                                                                                            CqlInterval<CqlDate> wzzzzzq_ = context.Operators.Interval(wzzzzzk_, wzzzzzp_, true, true);
                                                                                            bool? wzzzzzr_ = context.Operators.In<CqlDate>(X, wzzzzzq_, default);
                                                                                            bool? wzzzzzs_ = context.Operators.Not(wzzzzzr_);

                                                                                            return wzzzzzs_;
                                                                                        };
                                                                                        IEnumerable<CqlDate> vzzzzzx_ = context.Operators.Where<CqlDate>(vzzzzzs_, vzzzzzw_);
                                                                                        int? vzzzzzz_ = context.Operators.Add(vzzzzzt_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzzzza_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, vzzzzzu_ as CqlDate, vzzzzzx_, vzzzzzz_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] wzzzzzb_ = [
                                                                                            wzzzzza_,
                                                                                        ];
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzzzzc_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList)
                                                                                        {
                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzzzzt_()
                                                                                            {
                                                                                                bool wzzzzzu_()
                                                                                                {
                                                                                                    IEnumerable<CqlDate> wzzzzzv_ = SeventhList?.NewList;
                                                                                                    int? wzzzzzw_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate wzzzzzx_ = context.Operators.Indexer<CqlDate>(wzzzzzv_, wzzzzzw_);

                                                                                                    return wzzzzzx_ is null;
                                                                                                };
                                                                                                if (wzzzzzu_())
                                                                                                {
                                                                                                    return SeventhList;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    IEnumerable<CqlDate> wzzzzzy_ = SeventhList?.NewList;
                                                                                                    int? wzzzzzz_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate xzzzzza_ = context.Operators.Indexer<CqlDate>(wzzzzzy_, wzzzzzz_);
                                                                                                    bool? xzzzzzc_(CqlDate X)
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> xzzzzzm_ = SeventhList?.NewList;
                                                                                                        int? xzzzzzn_ = SeventhList?.IndexofNewDate;
                                                                                                        CqlDate xzzzzzo_ = context.Operators.Indexer<CqlDate>(xzzzzzm_, xzzzzzn_);
                                                                                                        CqlQuantity xzzzzzp_ = context.Operators.Quantity(1m, "day");
                                                                                                        CqlDate xzzzzzq_ = context.Operators.Add(xzzzzzo_ as CqlDate, xzzzzzp_);
                                                                                                        CqlDate xzzzzzt_ = context.Operators.Indexer<CqlDate>(xzzzzzm_, xzzzzzn_);
                                                                                                        CqlQuantity xzzzzzu_ = context.Operators.Quantity(30m, "days");
                                                                                                        CqlDate xzzzzzv_ = context.Operators.Add(xzzzzzt_ as CqlDate, xzzzzzu_);
                                                                                                        CqlInterval<CqlDate> xzzzzzw_ = context.Operators.Interval(xzzzzzq_, xzzzzzv_, true, true);
                                                                                                        bool? xzzzzzx_ = context.Operators.In<CqlDate>(X, xzzzzzw_, default);
                                                                                                        bool? xzzzzzy_ = context.Operators.Not(xzzzzzx_);

                                                                                                        return xzzzzzy_;
                                                                                                    };
                                                                                                    IEnumerable<CqlDate> xzzzzzd_ = context.Operators.Where<CqlDate>(wzzzzzy_, xzzzzzc_);
                                                                                                    int? xzzzzzf_ = context.Operators.Add(wzzzzzz_, 1);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzzzzg_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, xzzzzza_ as CqlDate, xzzzzzd_, xzzzzzf_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] xzzzzzh_ = [
                                                                                                        xzzzzzg_,
                                                                                                    ];
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzzzzi_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList)
                                                                                                    {
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzzzzz_()
                                                                                                        {
                                                                                                            bool yzzzzza_()
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> yzzzzzb_ = EighthList?.NewList;
                                                                                                                int? yzzzzzc_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate yzzzzzd_ = context.Operators.Indexer<CqlDate>(yzzzzzb_, yzzzzzc_);

                                                                                                                return yzzzzzd_ is null;
                                                                                                            };
                                                                                                            if (yzzzzza_())
                                                                                                            {
                                                                                                                return EighthList;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> yzzzzze_ = EighthList?.NewList;
                                                                                                                int? yzzzzzf_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate yzzzzzg_ = context.Operators.Indexer<CqlDate>(yzzzzze_, yzzzzzf_);
                                                                                                                bool? yzzzzzi_(CqlDate X)
                                                                                                                {
                                                                                                                    IEnumerable<CqlDate> yzzzzzs_ = EighthList?.NewList;
                                                                                                                    int? yzzzzzt_ = EighthList?.IndexofNewDate;
                                                                                                                    CqlDate yzzzzzu_ = context.Operators.Indexer<CqlDate>(yzzzzzs_, yzzzzzt_);
                                                                                                                    CqlQuantity yzzzzzv_ = context.Operators.Quantity(1m, "day");
                                                                                                                    CqlDate yzzzzzw_ = context.Operators.Add(yzzzzzu_ as CqlDate, yzzzzzv_);
                                                                                                                    CqlDate yzzzzzz_ = context.Operators.Indexer<CqlDate>(yzzzzzs_, yzzzzzt_);
                                                                                                                    CqlQuantity zzzzzza_ = context.Operators.Quantity(30m, "days");
                                                                                                                    CqlDate zzzzzzb_ = context.Operators.Add(yzzzzzz_ as CqlDate, zzzzzza_);
                                                                                                                    CqlInterval<CqlDate> zzzzzzc_ = context.Operators.Interval(yzzzzzw_, zzzzzzb_, true, true);
                                                                                                                    bool? zzzzzzd_ = context.Operators.In<CqlDate>(X, zzzzzzc_, default);
                                                                                                                    bool? zzzzzze_ = context.Operators.Not(zzzzzzd_);

                                                                                                                    return zzzzzze_;
                                                                                                                };
                                                                                                                IEnumerable<CqlDate> yzzzzzj_ = context.Operators.Where<CqlDate>(yzzzzze_, yzzzzzi_);
                                                                                                                int? yzzzzzl_ = context.Operators.Add(yzzzzzf_, 1);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? yzzzzzm_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, yzzzzzg_ as CqlDate, yzzzzzj_, yzzzzzl_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] yzzzzzn_ = [
                                                                                                                    yzzzzzm_,
                                                                                                                ];
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? yzzzzzo_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList)
                                                                                                                {
                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? zzzzzzf_()
                                                                                                                    {
                                                                                                                        bool zzzzzzg_()
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> zzzzzzh_ = NinethList?.NewList;
                                                                                                                            int? zzzzzzi_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate zzzzzzj_ = context.Operators.Indexer<CqlDate>(zzzzzzh_, zzzzzzi_);

                                                                                                                            return zzzzzzj_ is null;
                                                                                                                        };
                                                                                                                        if (zzzzzzg_())
                                                                                                                        {
                                                                                                                            return NinethList;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> zzzzzzk_ = NinethList?.NewList;
                                                                                                                            int? zzzzzzl_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate zzzzzzm_ = context.Operators.Indexer<CqlDate>(zzzzzzk_, zzzzzzl_);
                                                                                                                            bool? zzzzzzo_(CqlDate X)
                                                                                                                            {
                                                                                                                                IEnumerable<CqlDate> zzzzzzy_ = NinethList?.NewList;
                                                                                                                                int? zzzzzzz_ = NinethList?.IndexofNewDate;
                                                                                                                                CqlDate azzzzzza_ = context.Operators.Indexer<CqlDate>(zzzzzzy_, zzzzzzz_);
                                                                                                                                CqlQuantity azzzzzzb_ = context.Operators.Quantity(1m, "day");
                                                                                                                                CqlDate azzzzzzc_ = context.Operators.Add(azzzzzza_ as CqlDate, azzzzzzb_);
                                                                                                                                CqlDate azzzzzzf_ = context.Operators.Indexer<CqlDate>(zzzzzzy_, zzzzzzz_);
                                                                                                                                CqlQuantity azzzzzzg_ = context.Operators.Quantity(30m, "days");
                                                                                                                                CqlDate azzzzzzh_ = context.Operators.Add(azzzzzzf_ as CqlDate, azzzzzzg_);
                                                                                                                                CqlInterval<CqlDate> azzzzzzi_ = context.Operators.Interval(azzzzzzc_, azzzzzzh_, true, true);
                                                                                                                                bool? azzzzzzj_ = context.Operators.In<CqlDate>(X, azzzzzzi_, default);
                                                                                                                                bool? azzzzzzk_ = context.Operators.Not(azzzzzzj_);

                                                                                                                                return azzzzzzk_;
                                                                                                                            };
                                                                                                                            IEnumerable<CqlDate> zzzzzzp_ = context.Operators.Where<CqlDate>(zzzzzzk_, zzzzzzo_);
                                                                                                                            int? zzzzzzr_ = context.Operators.Add(zzzzzzl_, 1);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? zzzzzzs_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, zzzzzzm_ as CqlDate, zzzzzzp_, zzzzzzr_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] zzzzzzt_ = [
                                                                                                                                zzzzzzs_,
                                                                                                                            ];
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? zzzzzzu_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList)
                                                                                                                            {
                                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzzzzzl_()
                                                                                                                                {
                                                                                                                                    bool azzzzzzm_()
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> azzzzzzn_ = TenthList?.NewList;
                                                                                                                                        int? azzzzzzo_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate azzzzzzp_ = context.Operators.Indexer<CqlDate>(azzzzzzn_, azzzzzzo_);

                                                                                                                                        return azzzzzzp_ is null;
                                                                                                                                    };
                                                                                                                                    if (azzzzzzm_())
                                                                                                                                    {
                                                                                                                                        return TenthList;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> azzzzzzq_ = TenthList?.NewList;
                                                                                                                                        int? azzzzzzr_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate azzzzzzs_ = context.Operators.Indexer<CqlDate>(azzzzzzq_, azzzzzzr_);
                                                                                                                                        bool? azzzzzzu_(CqlDate X)
                                                                                                                                        {
                                                                                                                                            IEnumerable<CqlDate> bzzzzzze_ = TenthList?.NewList;
                                                                                                                                            int? bzzzzzzf_ = TenthList?.IndexofNewDate;
                                                                                                                                            CqlDate bzzzzzzg_ = context.Operators.Indexer<CqlDate>(bzzzzzze_, bzzzzzzf_);
                                                                                                                                            CqlQuantity bzzzzzzh_ = context.Operators.Quantity(1m, "day");
                                                                                                                                            CqlDate bzzzzzzi_ = context.Operators.Add(bzzzzzzg_ as CqlDate, bzzzzzzh_);
                                                                                                                                            CqlDate bzzzzzzl_ = context.Operators.Indexer<CqlDate>(bzzzzzze_, bzzzzzzf_);
                                                                                                                                            CqlQuantity bzzzzzzm_ = context.Operators.Quantity(30m, "days");
                                                                                                                                            CqlDate bzzzzzzn_ = context.Operators.Add(bzzzzzzl_ as CqlDate, bzzzzzzm_);
                                                                                                                                            CqlInterval<CqlDate> bzzzzzzo_ = context.Operators.Interval(bzzzzzzi_, bzzzzzzn_, true, true);
                                                                                                                                            bool? bzzzzzzp_ = context.Operators.In<CqlDate>(X, bzzzzzzo_, default);
                                                                                                                                            bool? bzzzzzzq_ = context.Operators.Not(bzzzzzzp_);

                                                                                                                                            return bzzzzzzq_;
                                                                                                                                        };
                                                                                                                                        IEnumerable<CqlDate> azzzzzzv_ = context.Operators.Where<CqlDate>(azzzzzzq_, azzzzzzu_);
                                                                                                                                        int? azzzzzzx_ = context.Operators.Add(azzzzzzr_, 1);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzzzzzy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, azzzzzzs_ as CqlDate, azzzzzzv_, azzzzzzx_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] azzzzzzz_ = [
                                                                                                                                            azzzzzzy_,
                                                                                                                                        ];
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzzzza_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList)
                                                                                                                                        {
                                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzzzzr_()
                                                                                                                                            {
                                                                                                                                                bool bzzzzzzs_()
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> bzzzzzzt_ = EleventhList?.NewList;
                                                                                                                                                    int? bzzzzzzu_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate bzzzzzzv_ = context.Operators.Indexer<CqlDate>(bzzzzzzt_, bzzzzzzu_);

                                                                                                                                                    return bzzzzzzv_ is null;
                                                                                                                                                };
                                                                                                                                                if (bzzzzzzs_())
                                                                                                                                                {
                                                                                                                                                    return EleventhList;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> bzzzzzzw_ = EleventhList?.NewList;
                                                                                                                                                    int? bzzzzzzx_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate bzzzzzzy_ = context.Operators.Indexer<CqlDate>(bzzzzzzw_, bzzzzzzx_);
                                                                                                                                                    bool? czzzzzza_(CqlDate X)
                                                                                                                                                    {
                                                                                                                                                        IEnumerable<CqlDate> czzzzzzf_ = EleventhList?.NewList;
                                                                                                                                                        int? czzzzzzg_ = EleventhList?.IndexofNewDate;
                                                                                                                                                        CqlDate czzzzzzh_ = context.Operators.Indexer<CqlDate>(czzzzzzf_, czzzzzzg_);
                                                                                                                                                        CqlQuantity czzzzzzi_ = context.Operators.Quantity(1m, "day");
                                                                                                                                                        CqlDate czzzzzzj_ = context.Operators.Add(czzzzzzh_ as CqlDate, czzzzzzi_);
                                                                                                                                                        CqlDate czzzzzzm_ = context.Operators.Indexer<CqlDate>(czzzzzzf_, czzzzzzg_);
                                                                                                                                                        CqlQuantity czzzzzzn_ = context.Operators.Quantity(30m, "days");
                                                                                                                                                        CqlDate czzzzzzo_ = context.Operators.Add(czzzzzzm_ as CqlDate, czzzzzzn_);
                                                                                                                                                        CqlInterval<CqlDate> czzzzzzp_ = context.Operators.Interval(czzzzzzj_, czzzzzzo_, true, true);
                                                                                                                                                        bool? czzzzzzq_ = context.Operators.In<CqlDate>(X, czzzzzzp_, default);
                                                                                                                                                        bool? czzzzzzr_ = context.Operators.Not(czzzzzzq_);

                                                                                                                                                        return czzzzzzr_;
                                                                                                                                                    };
                                                                                                                                                    IEnumerable<CqlDate> czzzzzzb_ = context.Operators.Where<CqlDate>(bzzzzzzw_, czzzzzza_);
                                                                                                                                                    int? czzzzzzd_ = context.Operators.Add(bzzzzzzx_, 1);
                                                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzzzze_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bzzzzzzy_ as CqlDate, czzzzzzb_, czzzzzzd_);

                                                                                                                                                    return czzzzzze_;
                                                                                                                                                }
                                                                                                                                            };

                                                                                                                                            return bzzzzzzr_();
                                                                                                                                        };
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bzzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)azzzzzzz_, bzzzzzza_);
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bzzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bzzzzzzb_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bzzzzzzc_);

                                                                                                                                        return bzzzzzzd_;
                                                                                                                                    }
                                                                                                                                };

                                                                                                                                return azzzzzzl_();
                                                                                                                            };
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> zzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)zzzzzzt_, zzzzzzu_);
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> zzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(zzzzzzv_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? zzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(zzzzzzw_);

                                                                                                                            return zzzzzzx_;
                                                                                                                        }
                                                                                                                    };

                                                                                                                    return zzzzzzf_();
                                                                                                                };
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> yzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)yzzzzzn_, yzzzzzo_);
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> yzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(yzzzzzp_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? yzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(yzzzzzq_);

                                                                                                                return yzzzzzr_;
                                                                                                            }
                                                                                                        };

                                                                                                        return xzzzzzz_();
                                                                                                    };
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> xzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)xzzzzzh_, xzzzzzi_);
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> xzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(xzzzzzj_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzzzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(xzzzzzk_);

                                                                                                    return xzzzzzl_;
                                                                                                }
                                                                                            };

                                                                                            return wzzzzzt_();
                                                                                        };
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> wzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)wzzzzzb_, wzzzzzc_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> wzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(wzzzzzd_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(wzzzzze_);

                                                                                        return wzzzzzf_;
                                                                                    }
                                                                                };

                                                                                return vzzzzzn_();
                                                                            };
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> uzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)uzzzzzv_, uzzzzzw_);
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> uzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(uzzzzzx_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(uzzzzzy_);

                                                                            return uzzzzzz_;
                                                                        }
                                                                    };

                                                                    return uzzzzzh_();
                                                                };
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> tzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)tzzzzzp_, tzzzzzq_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> tzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(tzzzzzr_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(tzzzzzs_);

                                                                return tzzzzzt_;
                                                            }
                                                        };

                                                        return tzzzzzb_();
                                                    };
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> szzzzzl_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)szzzzzj_, szzzzzk_);
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> szzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(szzzzzl_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(szzzzzm_);

                                                    return szzzzzn_;
                                                }
                                            };

                                            return rzzzzzv_();
                                        };
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> rzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)rzzzzzd_, rzzzzze_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> rzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(rzzzzzf_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(rzzzzzg_);

                                        return rzzzzzh_;
                                    }
                                };

                                return qzzzzzp_();
                            };
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)pzzzzzx_, pzzzzzy_);
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzzzzz_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzzzza_);

                            return qzzzzzb_;
                        }
                    };

                    return pzzzzzj_();
                };
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ozzzzzr_, ozzzzzs_);
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzzzt_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzzzu_);

                return ozzzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)ozzzzze_, ozzzzzf_);
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzzzg_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzzzh_);

            return ozzzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> nzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?>)nzzzzzw_, nzzzzzx_);
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> nzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(nzzzzzy_);
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(nzzzzzz_);

        return ozzzzza_;
    }


    #endregion Expressions

    #region CqlTupleMetadata Properties

    private static CqlTupleMetadata CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD = new(
        [typeof(IEnumerable<CqlDate>), typeof(int?)],
        ["SortedList", "AnchorIndex"]);

    private static CqlTupleMetadata CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca = new(
        [typeof(IEnumerable<CqlDate>)],
        ["SortedDates"]);

    private static CqlTupleMetadata CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc = new(
        [typeof(CqlDate), typeof(IEnumerable<CqlDate>), typeof(int?)],
        ["NextDate", "NewList", "IndexofNewDate"]);

    #endregion CqlTupleMetadata Properties

}
