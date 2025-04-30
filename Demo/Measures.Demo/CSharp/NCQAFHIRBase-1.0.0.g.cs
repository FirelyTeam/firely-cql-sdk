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

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> yzv_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient yzw_ = context.Operators.SingletonFrom<Patient>(yzv_);

        return yzw_;
    }


    [CqlExpressionDefinition("Normalize Onset")]
    public CqlInterval<CqlDateTime> Normalize_Onset(CqlContext context, object onset)
    {
        CqlInterval<CqlDateTime> yzx_()
        {
            if (onset is FhirDateTime)
            {
                CqlDateTime yzy_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, onset as FhirDateTime);
                CqlInterval<CqlDateTime> zza_ = context.Operators.Interval(yzy_, yzy_, true, true);

                return zza_;
            }
            else if (onset is Period)
            {
                FhirDateTime zzb_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
                CqlDateTime zzc_ = context.Operators.Convert<CqlDateTime>(zzb_);
                FhirDateTime zzd_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
                CqlDateTime zze_ = context.Operators.Convert<CqlDateTime>(zzd_);
                CqlInterval<CqlDateTime> zzf_ = context.Operators.Interval(zzc_, zze_, true, true);

                return zzf_;
            }
            else if (onset is FhirString)
            {
                CqlInterval<CqlDateTime> zzg_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return zzg_;
            }
            else
            {
                CqlInterval<CqlDate> zzh_()
                {
                    if (onset is Age)
                    {
                        Patient zzs_ = this.Patient(context);
                        Date zzt_ = zzs_?.BirthDateElement;
                        CqlDate zzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzt_);
                        CqlQuantity zzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate zzw_ = context.Operators.Add(zzu_, zzv_);
                        Date zzy_ = zzs_?.BirthDateElement;
                        CqlDate zzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzy_);
                        CqlDate azzb_ = context.Operators.Add(zzz_, zzv_);
                        CqlQuantity azzc_ = context.Operators.Quantity(1m, "year");
                        CqlDate azzd_ = context.Operators.Add(azzb_, azzc_);
                        CqlInterval<CqlDate> azze_ = context.Operators.Interval(zzw_, azzd_, true, false);

                        return azze_;
                    }
                    else if (onset is Range)
                    {
                        Patient azzf_ = this.Patient(context);
                        Date azzg_ = azzf_?.BirthDateElement;
                        CqlDate azzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzg_);
                        Quantity azzi_ = (onset as Range)?.Low;
                        CqlQuantity azzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzi_);
                        CqlDate azzk_ = context.Operators.Add(azzh_, azzj_);
                        Date azzm_ = azzf_?.BirthDateElement;
                        CqlDate azzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzm_);
                        Quantity azzo_ = (onset as Range)?.High;
                        CqlQuantity azzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzo_);
                        CqlDate azzq_ = context.Operators.Add(azzn_, azzp_);
                        CqlQuantity azzr_ = context.Operators.Quantity(1m, "year");
                        CqlDate azzs_ = context.Operators.Add(azzq_, azzr_);
                        CqlInterval<CqlDate> azzt_ = context.Operators.Interval(azzk_, azzs_, true, false);

                        return azzt_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate zzi_ = (zzh_())?.low;
                CqlDateTime zzj_ = context.Operators.ConvertDateToDateTime(zzi_);
                CqlInterval<CqlDate> zzk_()
                {
                    if (onset is Age)
                    {
                        Patient azzu_ = this.Patient(context);
                        Date azzv_ = azzu_?.BirthDateElement;
                        CqlDate azzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzv_);
                        CqlQuantity azzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate azzy_ = context.Operators.Add(azzw_, azzx_);
                        Date bzza_ = azzu_?.BirthDateElement;
                        CqlDate bzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzza_);
                        CqlDate bzzd_ = context.Operators.Add(bzzb_, azzx_);
                        CqlQuantity bzze_ = context.Operators.Quantity(1m, "year");
                        CqlDate bzzf_ = context.Operators.Add(bzzd_, bzze_);
                        CqlInterval<CqlDate> bzzg_ = context.Operators.Interval(azzy_, bzzf_, true, false);

                        return bzzg_;
                    }
                    else if (onset is Range)
                    {
                        Patient bzzh_ = this.Patient(context);
                        Date bzzi_ = bzzh_?.BirthDateElement;
                        CqlDate bzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzi_);
                        Quantity bzzk_ = (onset as Range)?.Low;
                        CqlQuantity bzzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzk_);
                        CqlDate bzzm_ = context.Operators.Add(bzzj_, bzzl_);
                        Date bzzo_ = bzzh_?.BirthDateElement;
                        CqlDate bzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzo_);
                        Quantity bzzq_ = (onset as Range)?.High;
                        CqlQuantity bzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzq_);
                        CqlDate bzzs_ = context.Operators.Add(bzzp_, bzzr_);
                        CqlQuantity bzzt_ = context.Operators.Quantity(1m, "year");
                        CqlDate bzzu_ = context.Operators.Add(bzzs_, bzzt_);
                        CqlInterval<CqlDate> bzzv_ = context.Operators.Interval(bzzm_, bzzu_, true, false);

                        return bzzv_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate zzl_ = (zzk_())?.high;
                CqlDateTime zzm_ = context.Operators.ConvertDateToDateTime(zzl_);
                CqlInterval<CqlDate> zzn_()
                {
                    if (onset is Age)
                    {
                        Patient bzzw_ = this.Patient(context);
                        Date bzzx_ = bzzw_?.BirthDateElement;
                        CqlDate bzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzx_);
                        CqlQuantity bzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate czza_ = context.Operators.Add(bzzy_, bzzz_);
                        Date czzc_ = bzzw_?.BirthDateElement;
                        CqlDate czzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzc_);
                        CqlDate czzf_ = context.Operators.Add(czzd_, bzzz_);
                        CqlQuantity czzg_ = context.Operators.Quantity(1m, "year");
                        CqlDate czzh_ = context.Operators.Add(czzf_, czzg_);
                        CqlInterval<CqlDate> czzi_ = context.Operators.Interval(czza_, czzh_, true, false);

                        return czzi_;
                    }
                    else if (onset is Range)
                    {
                        Patient czzj_ = this.Patient(context);
                        Date czzk_ = czzj_?.BirthDateElement;
                        CqlDate czzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzk_);
                        Quantity czzm_ = (onset as Range)?.Low;
                        CqlQuantity czzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzm_);
                        CqlDate czzo_ = context.Operators.Add(czzl_, czzn_);
                        Date czzq_ = czzj_?.BirthDateElement;
                        CqlDate czzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzq_);
                        Quantity czzs_ = (onset as Range)?.High;
                        CqlQuantity czzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzs_);
                        CqlDate czzu_ = context.Operators.Add(czzr_, czzt_);
                        CqlQuantity czzv_ = context.Operators.Quantity(1m, "year");
                        CqlDate czzw_ = context.Operators.Add(czzu_, czzv_);
                        CqlInterval<CqlDate> czzx_ = context.Operators.Interval(czzo_, czzw_, true, false);

                        return czzx_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? zzo_ = (zzn_())?.lowClosed;
                CqlInterval<CqlDate> zzp_()
                {
                    if (onset is Age)
                    {
                        Patient czzy_ = this.Patient(context);
                        Date czzz_ = czzy_?.BirthDateElement;
                        CqlDate dzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzz_);
                        CqlQuantity dzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate dzzc_ = context.Operators.Add(dzza_, dzzb_);
                        Date dzze_ = czzy_?.BirthDateElement;
                        CqlDate dzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzze_);
                        CqlDate dzzh_ = context.Operators.Add(dzzf_, dzzb_);
                        CqlQuantity dzzi_ = context.Operators.Quantity(1m, "year");
                        CqlDate dzzj_ = context.Operators.Add(dzzh_, dzzi_);
                        CqlInterval<CqlDate> dzzk_ = context.Operators.Interval(dzzc_, dzzj_, true, false);

                        return dzzk_;
                    }
                    else if (onset is Range)
                    {
                        Patient dzzl_ = this.Patient(context);
                        Date dzzm_ = dzzl_?.BirthDateElement;
                        CqlDate dzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzm_);
                        Quantity dzzo_ = (onset as Range)?.Low;
                        CqlQuantity dzzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dzzo_);
                        CqlDate dzzq_ = context.Operators.Add(dzzn_, dzzp_);
                        Date dzzs_ = dzzl_?.BirthDateElement;
                        CqlDate dzzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzs_);
                        Quantity dzzu_ = (onset as Range)?.High;
                        CqlQuantity dzzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, dzzu_);
                        CqlDate dzzw_ = context.Operators.Add(dzzt_, dzzv_);
                        CqlQuantity dzzx_ = context.Operators.Quantity(1m, "year");
                        CqlDate dzzy_ = context.Operators.Add(dzzw_, dzzx_);
                        CqlInterval<CqlDate> dzzz_ = context.Operators.Interval(dzzq_, dzzy_, true, false);

                        return dzzz_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? zzq_ = (zzp_())?.highClosed;
                CqlInterval<CqlDateTime> zzr_ = context.Operators.Interval(zzj_, zzm_, zzo_, zzq_);

                return zzr_;
            }
        };

        return yzx_();
    }


    [CqlExpressionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {
        CqlInterval<CqlDateTime> ezza_()
        {
            if (abatement is FhirDateTime)
            {
                CqlDateTime ezzb_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, abatement as FhirDateTime);
                CqlInterval<CqlDateTime> ezzd_ = context.Operators.Interval(ezzb_, ezzb_, true, true);

                return ezzd_;
            }
            else if (abatement is Period)
            {
                FhirDateTime ezze_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
                CqlDateTime ezzf_ = context.Operators.Convert<CqlDateTime>(ezze_);
                FhirDateTime ezzg_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
                CqlDateTime ezzh_ = context.Operators.Convert<CqlDateTime>(ezzg_);
                CqlInterval<CqlDateTime> ezzi_ = context.Operators.Interval(ezzf_, ezzh_, true, true);

                return ezzi_;
            }
            else if (abatement is FhirString)
            {
                CqlInterval<CqlDateTime> ezzj_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return ezzj_;
            }
            else
            {
                CqlInterval<CqlDate> ezzk_()
                {
                    if (abatement is Age)
                    {
                        Patient ezzv_ = this.Patient(context);
                        Date ezzw_ = ezzv_?.BirthDateElement;
                        CqlDate ezzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezzw_);
                        CqlQuantity ezzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate ezzz_ = context.Operators.Add(ezzx_, ezzy_);
                        Date fzzb_ = ezzv_?.BirthDateElement;
                        CqlDate fzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzb_);
                        CqlDate fzze_ = context.Operators.Add(fzzc_, ezzy_);
                        CqlQuantity fzzf_ = context.Operators.Quantity(1m, "year");
                        CqlDate fzzg_ = context.Operators.Add(fzze_, fzzf_);
                        CqlInterval<CqlDate> fzzh_ = context.Operators.Interval(ezzz_, fzzg_, true, false);

                        return fzzh_;
                    }
                    else if (abatement is Range)
                    {
                        Patient fzzi_ = this.Patient(context);
                        Date fzzj_ = fzzi_?.BirthDateElement;
                        CqlDate fzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzj_);
                        Quantity fzzl_ = (abatement as Range)?.Low;
                        CqlQuantity fzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, fzzl_);
                        CqlDate fzzn_ = context.Operators.Add(fzzk_, fzzm_);
                        Date fzzp_ = fzzi_?.BirthDateElement;
                        CqlDate fzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzp_);
                        Quantity fzzr_ = (abatement as Range)?.High;
                        CqlQuantity fzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, fzzr_);
                        CqlDate fzzt_ = context.Operators.Add(fzzq_, fzzs_);
                        CqlQuantity fzzu_ = context.Operators.Quantity(1m, "year");
                        CqlDate fzzv_ = context.Operators.Add(fzzt_, fzzu_);
                        CqlInterval<CqlDate> fzzw_ = context.Operators.Interval(fzzn_, fzzv_, true, false);

                        return fzzw_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate ezzl_ = (ezzk_())?.low;
                CqlDateTime ezzm_ = context.Operators.ConvertDateToDateTime(ezzl_);
                CqlInterval<CqlDate> ezzn_()
                {
                    if (abatement is Age)
                    {
                        Patient fzzx_ = this.Patient(context);
                        Date fzzy_ = fzzx_?.BirthDateElement;
                        CqlDate fzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzy_);
                        CqlQuantity gzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate gzzb_ = context.Operators.Add(fzzz_, gzza_);
                        Date gzzd_ = fzzx_?.BirthDateElement;
                        CqlDate gzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzd_);
                        CqlDate gzzg_ = context.Operators.Add(gzze_, gzza_);
                        CqlQuantity gzzh_ = context.Operators.Quantity(1m, "year");
                        CqlDate gzzi_ = context.Operators.Add(gzzg_, gzzh_);
                        CqlInterval<CqlDate> gzzj_ = context.Operators.Interval(gzzb_, gzzi_, true, false);

                        return gzzj_;
                    }
                    else if (abatement is Range)
                    {
                        Patient gzzk_ = this.Patient(context);
                        Date gzzl_ = gzzk_?.BirthDateElement;
                        CqlDate gzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzl_);
                        Quantity gzzn_ = (abatement as Range)?.Low;
                        CqlQuantity gzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzn_);
                        CqlDate gzzp_ = context.Operators.Add(gzzm_, gzzo_);
                        Date gzzr_ = gzzk_?.BirthDateElement;
                        CqlDate gzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzr_);
                        Quantity gzzt_ = (abatement as Range)?.High;
                        CqlQuantity gzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzt_);
                        CqlDate gzzv_ = context.Operators.Add(gzzs_, gzzu_);
                        CqlQuantity gzzw_ = context.Operators.Quantity(1m, "year");
                        CqlDate gzzx_ = context.Operators.Add(gzzv_, gzzw_);
                        CqlInterval<CqlDate> gzzy_ = context.Operators.Interval(gzzp_, gzzx_, true, false);

                        return gzzy_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate ezzo_ = (ezzn_())?.high;
                CqlDateTime ezzp_ = context.Operators.ConvertDateToDateTime(ezzo_);
                CqlInterval<CqlDate> ezzq_()
                {
                    if (abatement is Age)
                    {
                        Patient gzzz_ = this.Patient(context);
                        Date hzza_ = gzzz_?.BirthDateElement;
                        CqlDate hzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzza_);
                        CqlQuantity hzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate hzzd_ = context.Operators.Add(hzzb_, hzzc_);
                        Date hzzf_ = gzzz_?.BirthDateElement;
                        CqlDate hzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzf_);
                        CqlDate hzzi_ = context.Operators.Add(hzzg_, hzzc_);
                        CqlQuantity hzzj_ = context.Operators.Quantity(1m, "year");
                        CqlDate hzzk_ = context.Operators.Add(hzzi_, hzzj_);
                        CqlInterval<CqlDate> hzzl_ = context.Operators.Interval(hzzd_, hzzk_, true, false);

                        return hzzl_;
                    }
                    else if (abatement is Range)
                    {
                        Patient hzzm_ = this.Patient(context);
                        Date hzzn_ = hzzm_?.BirthDateElement;
                        CqlDate hzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzn_);
                        Quantity hzzp_ = (abatement as Range)?.Low;
                        CqlQuantity hzzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, hzzp_);
                        CqlDate hzzr_ = context.Operators.Add(hzzo_, hzzq_);
                        Date hzzt_ = hzzm_?.BirthDateElement;
                        CqlDate hzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzt_);
                        Quantity hzzv_ = (abatement as Range)?.High;
                        CqlQuantity hzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, hzzv_);
                        CqlDate hzzx_ = context.Operators.Add(hzzu_, hzzw_);
                        CqlQuantity hzzy_ = context.Operators.Quantity(1m, "year");
                        CqlDate hzzz_ = context.Operators.Add(hzzx_, hzzy_);
                        CqlInterval<CqlDate> izza_ = context.Operators.Interval(hzzr_, hzzz_, true, false);

                        return izza_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? ezzr_ = (ezzq_())?.lowClosed;
                CqlInterval<CqlDate> ezzs_()
                {
                    if (abatement is Age)
                    {
                        Patient izzb_ = this.Patient(context);
                        Date izzc_ = izzb_?.BirthDateElement;
                        CqlDate izzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izzc_);
                        CqlQuantity izze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate izzf_ = context.Operators.Add(izzd_, izze_);
                        Date izzh_ = izzb_?.BirthDateElement;
                        CqlDate izzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izzh_);
                        CqlDate izzk_ = context.Operators.Add(izzi_, izze_);
                        CqlQuantity izzl_ = context.Operators.Quantity(1m, "year");
                        CqlDate izzm_ = context.Operators.Add(izzk_, izzl_);
                        CqlInterval<CqlDate> izzn_ = context.Operators.Interval(izzf_, izzm_, true, false);

                        return izzn_;
                    }
                    else if (abatement is Range)
                    {
                        Patient izzo_ = this.Patient(context);
                        Date izzp_ = izzo_?.BirthDateElement;
                        CqlDate izzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izzp_);
                        Quantity izzr_ = (abatement as Range)?.Low;
                        CqlQuantity izzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzr_);
                        CqlDate izzt_ = context.Operators.Add(izzq_, izzs_);
                        Date izzv_ = izzo_?.BirthDateElement;
                        CqlDate izzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izzv_);
                        Quantity izzx_ = (abatement as Range)?.High;
                        CqlQuantity izzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, izzx_);
                        CqlDate izzz_ = context.Operators.Add(izzw_, izzy_);
                        CqlQuantity jzza_ = context.Operators.Quantity(1m, "year");
                        CqlDate jzzb_ = context.Operators.Add(izzz_, jzza_);
                        CqlInterval<CqlDate> jzzc_ = context.Operators.Interval(izzt_, jzzb_, true, false);

                        return jzzc_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? ezzt_ = (ezzs_())?.highClosed;
                CqlInterval<CqlDateTime> ezzu_ = context.Operators.Interval(ezzm_, ezzp_, ezzr_, ezzt_);

                return ezzu_;
            }
        };

        return ezza_();
    }


    [CqlExpressionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        DataType jzzd_ = condition?.Onset;
        CqlInterval<CqlDateTime> jzze_ = this.Normalize_Onset(context, jzzd_);
        CqlDateTime jzzf_ = context.Operators.Start(jzze_);
        DataType jzzg_ = condition?.Abatement;
        CqlInterval<CqlDateTime> jzzh_ = this.Normalize_Abatement(context, jzzg_);
        CqlDateTime jzzi_ = context.Operators.End(jzzh_);
        CqlInterval<CqlDateTime> jzzj_ = context.Operators.Interval(jzzf_, jzzi_, true, true);

        return jzzj_;
    }


    [CqlExpressionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> jzzk_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime jzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> jzzn_ = context.Operators.Interval(jzzl_, jzzl_, true, true);

                return jzzn_;
            }
            else if (choice is Date)
            {
                CqlDate jzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
                CqlDateTime jzzp_ = context.Operators.ConvertDateToDateTime(jzzo_);
                CqlDateTime jzzr_ = context.Operators.ConvertDateToDateTime(jzzo_);
                CqlInterval<CqlDateTime> jzzs_ = context.Operators.Interval(jzzp_, jzzr_, true, true);

                return jzzs_;
            }
            else if (choice is Period)
            {
                FhirDateTime jzzt_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
                CqlDateTime jzzu_ = context.Operators.Convert<CqlDateTime>(jzzt_);
                FhirDateTime jzzv_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
                CqlDateTime jzzw_ = context.Operators.Convert<CqlDateTime>(jzzv_);
                CqlInterval<CqlDateTime> jzzx_ = context.Operators.Interval(jzzu_, jzzw_, true, true);

                return jzzx_;
            }
            else if (choice is Instant)
            {
                CqlDateTime jzzy_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> kzza_ = context.Operators.Interval(jzzy_, jzzy_, true, true);

                return kzza_;
            }
            else if (choice is Age)
            {
                Patient kzzb_ = this.Patient(context);
                Date kzzc_ = kzzb_?.BirthDateElement;
                CqlDate kzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzc_);
                CqlQuantity kzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate kzzf_ = context.Operators.Add(kzzd_, kzze_);
                Date kzzh_ = kzzb_?.BirthDateElement;
                CqlDate kzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzh_);
                CqlDate kzzk_ = context.Operators.Add(kzzi_, kzze_);
                CqlQuantity kzzl_ = context.Operators.Quantity(1m, "year");
                CqlDate kzzm_ = context.Operators.Add(kzzk_, kzzl_);
                CqlInterval<CqlDate> kzzn_ = context.Operators.Interval(kzzf_, kzzm_, true, false);
                CqlDate kzzo_ = kzzn_?.low;
                CqlDateTime kzzp_ = context.Operators.ConvertDateToDateTime(kzzo_);
                Date kzzr_ = kzzb_?.BirthDateElement;
                CqlDate kzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzr_);
                CqlDate kzzu_ = context.Operators.Add(kzzs_, kzze_);
                Date kzzw_ = kzzb_?.BirthDateElement;
                CqlDate kzzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzw_);
                CqlDate kzzz_ = context.Operators.Add(kzzx_, kzze_);
                CqlDate lzzb_ = context.Operators.Add(kzzz_, kzzl_);
                CqlInterval<CqlDate> lzzc_ = context.Operators.Interval(kzzu_, lzzb_, true, false);
                CqlDate lzzd_ = lzzc_?.high;
                CqlDateTime lzze_ = context.Operators.ConvertDateToDateTime(lzzd_);
                Date lzzg_ = kzzb_?.BirthDateElement;
                CqlDate lzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzg_);
                CqlDate lzzj_ = context.Operators.Add(lzzh_, kzze_);
                Date lzzl_ = kzzb_?.BirthDateElement;
                CqlDate lzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzl_);
                CqlDate lzzo_ = context.Operators.Add(lzzm_, kzze_);
                CqlDate lzzq_ = context.Operators.Add(lzzo_, kzzl_);
                CqlInterval<CqlDate> lzzr_ = context.Operators.Interval(lzzj_, lzzq_, true, false);
                bool? lzzs_ = lzzr_?.lowClosed;
                Date lzzu_ = kzzb_?.BirthDateElement;
                CqlDate lzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzu_);
                CqlDate lzzx_ = context.Operators.Add(lzzv_, kzze_);
                Date lzzz_ = kzzb_?.BirthDateElement;
                CqlDate mzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzz_);
                CqlDate mzzc_ = context.Operators.Add(mzza_, kzze_);
                CqlDate mzze_ = context.Operators.Add(mzzc_, kzzl_);
                CqlInterval<CqlDate> mzzf_ = context.Operators.Interval(lzzx_, mzze_, true, false);
                bool? mzzg_ = mzzf_?.highClosed;
                CqlInterval<CqlDateTime> mzzh_ = context.Operators.Interval(kzzp_, lzze_, lzzs_, mzzg_);

                return mzzh_;
            }
            else if (choice is Range)
            {
                Patient mzzi_ = this.Patient(context);
                Date mzzj_ = mzzi_?.BirthDateElement;
                CqlDate mzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzzj_);
                Quantity mzzl_ = (choice as Range)?.Low;
                CqlQuantity mzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzl_);
                CqlDate mzzn_ = context.Operators.Add(mzzk_, mzzm_);
                Date mzzp_ = mzzi_?.BirthDateElement;
                CqlDate mzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzzp_);
                Quantity mzzr_ = (choice as Range)?.High;
                CqlQuantity mzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzr_);
                CqlDate mzzt_ = context.Operators.Add(mzzq_, mzzs_);
                CqlQuantity mzzu_ = context.Operators.Quantity(1m, "year");
                CqlDate mzzv_ = context.Operators.Add(mzzt_, mzzu_);
                CqlInterval<CqlDate> mzzw_ = context.Operators.Interval(mzzn_, mzzv_, true, false);
                CqlDate mzzx_ = mzzw_?.low;
                CqlDateTime mzzy_ = context.Operators.ConvertDateToDateTime(mzzx_);
                Date nzza_ = mzzi_?.BirthDateElement;
                CqlDate nzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzza_);
                CqlQuantity nzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzl_);
                CqlDate nzze_ = context.Operators.Add(nzzb_, nzzd_);
                Date nzzg_ = mzzi_?.BirthDateElement;
                CqlDate nzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzg_);
                CqlQuantity nzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzr_);
                CqlDate nzzk_ = context.Operators.Add(nzzh_, nzzj_);
                CqlDate nzzm_ = context.Operators.Add(nzzk_, mzzu_);
                CqlInterval<CqlDate> nzzn_ = context.Operators.Interval(nzze_, nzzm_, true, false);
                CqlDate nzzo_ = nzzn_?.high;
                CqlDateTime nzzp_ = context.Operators.ConvertDateToDateTime(nzzo_);
                Date nzzr_ = mzzi_?.BirthDateElement;
                CqlDate nzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzr_);
                CqlQuantity nzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzl_);
                CqlDate nzzv_ = context.Operators.Add(nzzs_, nzzu_);
                Date nzzx_ = mzzi_?.BirthDateElement;
                CqlDate nzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzx_);
                CqlQuantity ozza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzr_);
                CqlDate ozzb_ = context.Operators.Add(nzzy_, ozza_);
                CqlDate ozzd_ = context.Operators.Add(ozzb_, mzzu_);
                CqlInterval<CqlDate> ozze_ = context.Operators.Interval(nzzv_, ozzd_, true, false);
                bool? ozzf_ = ozze_?.lowClosed;
                Date ozzh_ = mzzi_?.BirthDateElement;
                CqlDate ozzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzh_);
                CqlQuantity ozzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzl_);
                CqlDate ozzl_ = context.Operators.Add(ozzi_, ozzk_);
                Date ozzn_ = mzzi_?.BirthDateElement;
                CqlDate ozzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzn_);
                CqlQuantity ozzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzr_);
                CqlDate ozzr_ = context.Operators.Add(ozzo_, ozzq_);
                CqlDate ozzt_ = context.Operators.Add(ozzr_, mzzu_);
                CqlInterval<CqlDate> ozzu_ = context.Operators.Interval(ozzl_, ozzt_, true, false);
                bool? ozzv_ = ozzu_?.highClosed;
                CqlInterval<CqlDateTime> ozzw_ = context.Operators.Interval(mzzy_, nzzp_, ozzf_, ozzv_);

                return ozzw_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> ozzx_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return ozzx_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> ozzy_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return ozzy_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return jzzk_();
    }


    [CqlExpressionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        string ozzz_()
        {
            bool pzza_()
            {
                int? pzzb_ = context.Operators.PositionOf("/", uri);
                bool? pzzc_ = context.Operators.Greater(pzzb_, 0);

                return pzzc_ ?? false;
            };
            if (pzza_())
            {
                IEnumerable<string> pzzd_ = context.Operators.Split(uri, "/");
                string pzze_ = context.Operators.Last<string>(pzzd_);

                return pzze_;
            }
            else
            {
                return uri;
            }
        };

        return ozzz_();
    }


    [CqlExpressionDefinition("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) =>
        VSet;


    [CqlExpressionDefinition("First Dates per 31 Day Periods")]
    public (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
    {
        CqlDate pzzf_(CqlDate d) =>
            d;
        IEnumerable<CqlDate> pzzg_ = context.Operators.Select<CqlDate, CqlDate>(DateList, pzzf_);
        IEnumerable<CqlDate> pzzh_ = context.Operators.Distinct<CqlDate>(pzzg_);
        IEnumerable<CqlDate> pzzi_ = context.Operators.ListSort<CqlDate>(pzzh_, System.ComponentModel.ListSortDirection.Ascending);
        bool? pzzj_(CqlDate X)
        {
            bool? pzzr_ = context.Operators.Not((bool?)(X is null));

            return pzzr_;
        };
        IEnumerable<CqlDate> pzzk_ = context.Operators.Where<CqlDate>(pzzi_, pzzj_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? pzzl_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, pzzk_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] pzzm_ = [
            pzzl_,
        ];
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzn_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates)
        {
            IEnumerable<CqlDate> pzzs_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? pzzt_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, pzzs_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] pzzu_ = [
                pzzt_,
            ];
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzv_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList)
            {
                IEnumerable<CqlDate> pzzz_ = AnchorList?.SortedList;
                int? qzza_ = AnchorList?.AnchorIndex;
                CqlDate qzzb_ = context.Operators.Indexer<CqlDate>(pzzz_, qzza_);
                bool? qzzc_(CqlDate X)
                {
                    IEnumerable<CqlDate> qzzm_ = AnchorList?.SortedList;
                    int? qzzn_ = AnchorList?.AnchorIndex;
                    CqlDate qzzo_ = context.Operators.Indexer<CqlDate>(qzzm_, qzzn_);
                    CqlQuantity qzzp_ = context.Operators.Quantity(1m, "day");
                    CqlDate qzzq_ = context.Operators.Add(qzzo_ as CqlDate, qzzp_);
                    CqlDate qzzt_ = context.Operators.Indexer<CqlDate>(qzzm_, qzzn_);
                    CqlQuantity qzzu_ = context.Operators.Quantity(30m, "days");
                    CqlDate qzzv_ = context.Operators.Add(qzzt_ as CqlDate, qzzu_);
                    CqlInterval<CqlDate> qzzw_ = context.Operators.Interval(qzzq_, qzzv_, true, true);
                    bool? qzzx_ = context.Operators.In<CqlDate>(X, qzzw_, default);
                    bool? qzzy_ = context.Operators.Not(qzzx_);

                    return qzzy_;
                };
                IEnumerable<CqlDate> qzzd_ = context.Operators.Where<CqlDate>(DateList, qzzc_);
                int? qzzf_ = context.Operators.Add(qzza_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzg_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, qzzb_ as CqlDate, qzzd_, qzzf_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] qzzh_ = [
                    qzzg_,
                ];
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzi_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList)
                {
                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzz_()
                    {
                        bool rzza_()
                        {
                            IEnumerable<CqlDate> rzzb_ = FirstList?.NewList;
                            int? rzzc_ = FirstList?.IndexofNewDate;
                            CqlDate rzzd_ = context.Operators.Indexer<CqlDate>(rzzb_, rzzc_);

                            return rzzd_ is null;
                        };
                        if (rzza_())
                        {
                            return FirstList;
                        }
                        else
                        {
                            IEnumerable<CqlDate> rzze_ = FirstList?.NewList;
                            int? rzzf_ = FirstList?.IndexofNewDate;
                            CqlDate rzzg_ = context.Operators.Indexer<CqlDate>(rzze_, rzzf_);
                            bool? rzzi_(CqlDate X)
                            {
                                IEnumerable<CqlDate> rzzs_ = FirstList?.NewList;
                                int? rzzt_ = FirstList?.IndexofNewDate;
                                CqlDate rzzu_ = context.Operators.Indexer<CqlDate>(rzzs_, rzzt_);
                                CqlQuantity rzzv_ = context.Operators.Quantity(1m, "day");
                                CqlDate rzzw_ = context.Operators.Add(rzzu_ as CqlDate, rzzv_);
                                CqlDate rzzz_ = context.Operators.Indexer<CqlDate>(rzzs_, rzzt_);
                                CqlQuantity szza_ = context.Operators.Quantity(30m, "days");
                                CqlDate szzb_ = context.Operators.Add(rzzz_ as CqlDate, szza_);
                                CqlInterval<CqlDate> szzc_ = context.Operators.Interval(rzzw_, szzb_, true, true);
                                bool? szzd_ = context.Operators.In<CqlDate>(X, szzc_, default);
                                bool? szze_ = context.Operators.Not(szzd_);

                                return szze_;
                            };
                            IEnumerable<CqlDate> rzzj_ = context.Operators.Where<CqlDate>(rzze_, rzzi_);
                            int? rzzl_ = context.Operators.Add(rzzf_, 1);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzm_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, rzzg_ as CqlDate, rzzj_, rzzl_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] rzzn_ = [
                                rzzm_,
                            ];
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzo_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList)
                            {
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzf_()
                                {
                                    bool szzg_()
                                    {
                                        IEnumerable<CqlDate> szzh_ = SecondList?.NewList;
                                        int? szzi_ = SecondList?.IndexofNewDate;
                                        CqlDate szzj_ = context.Operators.Indexer<CqlDate>(szzh_, szzi_);

                                        return szzj_ is null;
                                    };
                                    if (szzg_())
                                    {
                                        return SecondList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> szzk_ = SecondList?.NewList;
                                        int? szzl_ = SecondList?.IndexofNewDate;
                                        CqlDate szzm_ = context.Operators.Indexer<CqlDate>(szzk_, szzl_);
                                        bool? szzo_(CqlDate X)
                                        {
                                            IEnumerable<CqlDate> szzy_ = SecondList?.NewList;
                                            int? szzz_ = SecondList?.IndexofNewDate;
                                            CqlDate tzza_ = context.Operators.Indexer<CqlDate>(szzy_, szzz_);
                                            CqlQuantity tzzb_ = context.Operators.Quantity(1m, "day");
                                            CqlDate tzzc_ = context.Operators.Add(tzza_ as CqlDate, tzzb_);
                                            CqlDate tzzf_ = context.Operators.Indexer<CqlDate>(szzy_, szzz_);
                                            CqlQuantity tzzg_ = context.Operators.Quantity(30m, "days");
                                            CqlDate tzzh_ = context.Operators.Add(tzzf_ as CqlDate, tzzg_);
                                            CqlInterval<CqlDate> tzzi_ = context.Operators.Interval(tzzc_, tzzh_, true, true);
                                            bool? tzzj_ = context.Operators.In<CqlDate>(X, tzzi_, default);
                                            bool? tzzk_ = context.Operators.Not(tzzj_);

                                            return tzzk_;
                                        };
                                        IEnumerable<CqlDate> szzp_ = context.Operators.Where<CqlDate>(szzk_, szzo_);
                                        int? szzr_ = context.Operators.Add(szzl_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzs_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, szzm_ as CqlDate, szzp_, szzr_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] szzt_ = [
                                            szzs_,
                                        ];
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzu_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList)
                                        {
                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzl_()
                                            {
                                                bool tzzm_()
                                                {
                                                    IEnumerable<CqlDate> tzzn_ = ThirdList?.NewList;
                                                    int? tzzo_ = ThirdList?.IndexofNewDate;
                                                    CqlDate tzzp_ = context.Operators.Indexer<CqlDate>(tzzn_, tzzo_);

                                                    return tzzp_ is null;
                                                };
                                                if (tzzm_())
                                                {
                                                    return ThirdList;
                                                }
                                                else
                                                {
                                                    IEnumerable<CqlDate> tzzq_ = ThirdList?.NewList;
                                                    int? tzzr_ = ThirdList?.IndexofNewDate;
                                                    CqlDate tzzs_ = context.Operators.Indexer<CqlDate>(tzzq_, tzzr_);
                                                    bool? tzzu_(CqlDate X)
                                                    {
                                                        IEnumerable<CqlDate> uzze_ = ThirdList?.NewList;
                                                        int? uzzf_ = ThirdList?.IndexofNewDate;
                                                        CqlDate uzzg_ = context.Operators.Indexer<CqlDate>(uzze_, uzzf_);
                                                        CqlQuantity uzzh_ = context.Operators.Quantity(1m, "day");
                                                        CqlDate uzzi_ = context.Operators.Add(uzzg_ as CqlDate, uzzh_);
                                                        CqlDate uzzl_ = context.Operators.Indexer<CqlDate>(uzze_, uzzf_);
                                                        CqlQuantity uzzm_ = context.Operators.Quantity(30m, "days");
                                                        CqlDate uzzn_ = context.Operators.Add(uzzl_ as CqlDate, uzzm_);
                                                        CqlInterval<CqlDate> uzzo_ = context.Operators.Interval(uzzi_, uzzn_, true, true);
                                                        bool? uzzp_ = context.Operators.In<CqlDate>(X, uzzo_, default);
                                                        bool? uzzq_ = context.Operators.Not(uzzp_);

                                                        return uzzq_;
                                                    };
                                                    IEnumerable<CqlDate> tzzv_ = context.Operators.Where<CqlDate>(tzzq_, tzzu_);
                                                    int? tzzx_ = context.Operators.Add(tzzr_, 1);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, tzzs_ as CqlDate, tzzv_, tzzx_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] tzzz_ = [
                                                        tzzy_,
                                                    ];
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzza_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList)
                                                    {
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzr_()
                                                        {
                                                            bool uzzs_()
                                                            {
                                                                IEnumerable<CqlDate> uzzt_ = FourthList?.NewList;
                                                                int? uzzu_ = FourthList?.IndexofNewDate;
                                                                CqlDate uzzv_ = context.Operators.Indexer<CqlDate>(uzzt_, uzzu_);

                                                                return uzzv_ is null;
                                                            };
                                                            if (uzzs_())
                                                            {
                                                                return FourthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> uzzw_ = FourthList?.NewList;
                                                                int? uzzx_ = FourthList?.IndexofNewDate;
                                                                CqlDate uzzy_ = context.Operators.Indexer<CqlDate>(uzzw_, uzzx_);
                                                                bool? vzza_(CqlDate X)
                                                                {
                                                                    IEnumerable<CqlDate> vzzk_ = FourthList?.NewList;
                                                                    int? vzzl_ = FourthList?.IndexofNewDate;
                                                                    CqlDate vzzm_ = context.Operators.Indexer<CqlDate>(vzzk_, vzzl_);
                                                                    CqlQuantity vzzn_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate vzzo_ = context.Operators.Add(vzzm_ as CqlDate, vzzn_);
                                                                    CqlDate vzzr_ = context.Operators.Indexer<CqlDate>(vzzk_, vzzl_);
                                                                    CqlQuantity vzzs_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate vzzt_ = context.Operators.Add(vzzr_ as CqlDate, vzzs_);
                                                                    CqlInterval<CqlDate> vzzu_ = context.Operators.Interval(vzzo_, vzzt_, true, true);
                                                                    bool? vzzv_ = context.Operators.In<CqlDate>(X, vzzu_, default);
                                                                    bool? vzzw_ = context.Operators.Not(vzzv_);

                                                                    return vzzw_;
                                                                };
                                                                IEnumerable<CqlDate> vzzb_ = context.Operators.Where<CqlDate>(uzzw_, vzza_);
                                                                int? vzzd_ = context.Operators.Add(uzzx_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? vzze_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, uzzy_ as CqlDate, vzzb_, vzzd_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] vzzf_ = [
                                                                    vzze_,
                                                                ];
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? vzzg_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList)
                                                                {
                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? vzzx_()
                                                                    {
                                                                        bool vzzy_()
                                                                        {
                                                                            IEnumerable<CqlDate> vzzz_ = FifthList?.NewList;
                                                                            int? wzza_ = FifthList?.IndexofNewDate;
                                                                            CqlDate wzzb_ = context.Operators.Indexer<CqlDate>(vzzz_, wzza_);

                                                                            return wzzb_ is null;
                                                                        };
                                                                        if (vzzy_())
                                                                        {
                                                                            return FifthList;
                                                                        }
                                                                        else
                                                                        {
                                                                            IEnumerable<CqlDate> wzzc_ = FifthList?.NewList;
                                                                            int? wzzd_ = FifthList?.IndexofNewDate;
                                                                            CqlDate wzze_ = context.Operators.Indexer<CqlDate>(wzzc_, wzzd_);
                                                                            bool? wzzg_(CqlDate X)
                                                                            {
                                                                                IEnumerable<CqlDate> wzzq_ = FifthList?.NewList;
                                                                                int? wzzr_ = FifthList?.IndexofNewDate;
                                                                                CqlDate wzzs_ = context.Operators.Indexer<CqlDate>(wzzq_, wzzr_);
                                                                                CqlQuantity wzzt_ = context.Operators.Quantity(1m, "day");
                                                                                CqlDate wzzu_ = context.Operators.Add(wzzs_ as CqlDate, wzzt_);
                                                                                CqlDate wzzx_ = context.Operators.Indexer<CqlDate>(wzzq_, wzzr_);
                                                                                CqlQuantity wzzy_ = context.Operators.Quantity(30m, "days");
                                                                                CqlDate wzzz_ = context.Operators.Add(wzzx_ as CqlDate, wzzy_);
                                                                                CqlInterval<CqlDate> xzza_ = context.Operators.Interval(wzzu_, wzzz_, true, true);
                                                                                bool? xzzb_ = context.Operators.In<CqlDate>(X, xzza_, default);
                                                                                bool? xzzc_ = context.Operators.Not(xzzb_);

                                                                                return xzzc_;
                                                                            };
                                                                            IEnumerable<CqlDate> wzzh_ = context.Operators.Where<CqlDate>(wzzc_, wzzg_);
                                                                            int? wzzj_ = context.Operators.Add(wzzd_, 1);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzk_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, wzze_ as CqlDate, wzzh_, wzzj_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] wzzl_ = [
                                                                                wzzk_,
                                                                            ];
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzm_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList)
                                                                            {
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzd_()
                                                                                {
                                                                                    bool xzze_()
                                                                                    {
                                                                                        IEnumerable<CqlDate> xzzf_ = SixthList?.NewList;
                                                                                        int? xzzg_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate xzzh_ = context.Operators.Indexer<CqlDate>(xzzf_, xzzg_);

                                                                                        return xzzh_ is null;
                                                                                    };
                                                                                    if (xzze_())
                                                                                    {
                                                                                        return SixthList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> xzzi_ = SixthList?.NewList;
                                                                                        int? xzzj_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate xzzk_ = context.Operators.Indexer<CqlDate>(xzzi_, xzzj_);
                                                                                        bool? xzzm_(CqlDate X)
                                                                                        {
                                                                                            IEnumerable<CqlDate> xzzw_ = SixthList?.NewList;
                                                                                            int? xzzx_ = SixthList?.IndexofNewDate;
                                                                                            CqlDate xzzy_ = context.Operators.Indexer<CqlDate>(xzzw_, xzzx_);
                                                                                            CqlQuantity xzzz_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate yzza_ = context.Operators.Add(xzzy_ as CqlDate, xzzz_);
                                                                                            CqlDate yzzd_ = context.Operators.Indexer<CqlDate>(xzzw_, xzzx_);
                                                                                            CqlQuantity yzze_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate yzzf_ = context.Operators.Add(yzzd_ as CqlDate, yzze_);
                                                                                            CqlInterval<CqlDate> yzzg_ = context.Operators.Interval(yzza_, yzzf_, true, true);
                                                                                            bool? yzzh_ = context.Operators.In<CqlDate>(X, yzzg_, default);
                                                                                            bool? yzzi_ = context.Operators.Not(yzzh_);

                                                                                            return yzzi_;
                                                                                        };
                                                                                        IEnumerable<CqlDate> xzzn_ = context.Operators.Where<CqlDate>(xzzi_, xzzm_);
                                                                                        int? xzzp_ = context.Operators.Add(xzzj_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, xzzk_ as CqlDate, xzzn_, xzzp_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] xzzr_ = [
                                                                                            xzzq_,
                                                                                        ];
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzs_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList)
                                                                                        {
                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? yzzj_()
                                                                                            {
                                                                                                bool yzzk_()
                                                                                                {
                                                                                                    IEnumerable<CqlDate> yzzl_ = SeventhList?.NewList;
                                                                                                    int? yzzm_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate yzzn_ = context.Operators.Indexer<CqlDate>(yzzl_, yzzm_);

                                                                                                    return yzzn_ is null;
                                                                                                };
                                                                                                if (yzzk_())
                                                                                                {
                                                                                                    return SeventhList;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    IEnumerable<CqlDate> yzzo_ = SeventhList?.NewList;
                                                                                                    int? yzzp_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate yzzq_ = context.Operators.Indexer<CqlDate>(yzzo_, yzzp_);
                                                                                                    bool? yzzs_(CqlDate X)
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> zzzc_ = SeventhList?.NewList;
                                                                                                        int? zzzd_ = SeventhList?.IndexofNewDate;
                                                                                                        CqlDate zzze_ = context.Operators.Indexer<CqlDate>(zzzc_, zzzd_);
                                                                                                        CqlQuantity zzzf_ = context.Operators.Quantity(1m, "day");
                                                                                                        CqlDate zzzg_ = context.Operators.Add(zzze_ as CqlDate, zzzf_);
                                                                                                        CqlDate zzzj_ = context.Operators.Indexer<CqlDate>(zzzc_, zzzd_);
                                                                                                        CqlQuantity zzzk_ = context.Operators.Quantity(30m, "days");
                                                                                                        CqlDate zzzl_ = context.Operators.Add(zzzj_ as CqlDate, zzzk_);
                                                                                                        CqlInterval<CqlDate> zzzm_ = context.Operators.Interval(zzzg_, zzzl_, true, true);
                                                                                                        bool? zzzn_ = context.Operators.In<CqlDate>(X, zzzm_, default);
                                                                                                        bool? zzzo_ = context.Operators.Not(zzzn_);

                                                                                                        return zzzo_;
                                                                                                    };
                                                                                                    IEnumerable<CqlDate> yzzt_ = context.Operators.Where<CqlDate>(yzzo_, yzzs_);
                                                                                                    int? yzzv_ = context.Operators.Add(yzzp_, 1);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? yzzw_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, yzzq_ as CqlDate, yzzt_, yzzv_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] yzzx_ = [
                                                                                                        yzzw_,
                                                                                                    ];
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? yzzy_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList)
                                                                                                    {
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? zzzp_()
                                                                                                        {
                                                                                                            bool zzzq_()
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> zzzr_ = EighthList?.NewList;
                                                                                                                int? zzzs_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate zzzt_ = context.Operators.Indexer<CqlDate>(zzzr_, zzzs_);

                                                                                                                return zzzt_ is null;
                                                                                                            };
                                                                                                            if (zzzq_())
                                                                                                            {
                                                                                                                return EighthList;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> zzzu_ = EighthList?.NewList;
                                                                                                                int? zzzv_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate zzzw_ = context.Operators.Indexer<CqlDate>(zzzu_, zzzv_);
                                                                                                                bool? zzzy_(CqlDate X)
                                                                                                                {
                                                                                                                    IEnumerable<CqlDate> azzzi_ = EighthList?.NewList;
                                                                                                                    int? azzzj_ = EighthList?.IndexofNewDate;
                                                                                                                    CqlDate azzzk_ = context.Operators.Indexer<CqlDate>(azzzi_, azzzj_);
                                                                                                                    CqlQuantity azzzl_ = context.Operators.Quantity(1m, "day");
                                                                                                                    CqlDate azzzm_ = context.Operators.Add(azzzk_ as CqlDate, azzzl_);
                                                                                                                    CqlDate azzzp_ = context.Operators.Indexer<CqlDate>(azzzi_, azzzj_);
                                                                                                                    CqlQuantity azzzq_ = context.Operators.Quantity(30m, "days");
                                                                                                                    CqlDate azzzr_ = context.Operators.Add(azzzp_ as CqlDate, azzzq_);
                                                                                                                    CqlInterval<CqlDate> azzzs_ = context.Operators.Interval(azzzm_, azzzr_, true, true);
                                                                                                                    bool? azzzt_ = context.Operators.In<CqlDate>(X, azzzs_, default);
                                                                                                                    bool? azzzu_ = context.Operators.Not(azzzt_);

                                                                                                                    return azzzu_;
                                                                                                                };
                                                                                                                IEnumerable<CqlDate> zzzz_ = context.Operators.Where<CqlDate>(zzzu_, zzzy_);
                                                                                                                int? azzzb_ = context.Operators.Add(zzzv_, 1);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzzc_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, zzzw_ as CqlDate, zzzz_, azzzb_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] azzzd_ = [
                                                                                                                    azzzc_,
                                                                                                                ];
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzze_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList)
                                                                                                                {
                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzzv_()
                                                                                                                    {
                                                                                                                        bool azzzw_()
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> azzzx_ = NinethList?.NewList;
                                                                                                                            int? azzzy_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate azzzz_ = context.Operators.Indexer<CqlDate>(azzzx_, azzzy_);

                                                                                                                            return azzzz_ is null;
                                                                                                                        };
                                                                                                                        if (azzzw_())
                                                                                                                        {
                                                                                                                            return NinethList;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> bzzza_ = NinethList?.NewList;
                                                                                                                            int? bzzzb_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate bzzzc_ = context.Operators.Indexer<CqlDate>(bzzza_, bzzzb_);
                                                                                                                            bool? bzzze_(CqlDate X)
                                                                                                                            {
                                                                                                                                IEnumerable<CqlDate> bzzzo_ = NinethList?.NewList;
                                                                                                                                int? bzzzp_ = NinethList?.IndexofNewDate;
                                                                                                                                CqlDate bzzzq_ = context.Operators.Indexer<CqlDate>(bzzzo_, bzzzp_);
                                                                                                                                CqlQuantity bzzzr_ = context.Operators.Quantity(1m, "day");
                                                                                                                                CqlDate bzzzs_ = context.Operators.Add(bzzzq_ as CqlDate, bzzzr_);
                                                                                                                                CqlDate bzzzv_ = context.Operators.Indexer<CqlDate>(bzzzo_, bzzzp_);
                                                                                                                                CqlQuantity bzzzw_ = context.Operators.Quantity(30m, "days");
                                                                                                                                CqlDate bzzzx_ = context.Operators.Add(bzzzv_ as CqlDate, bzzzw_);
                                                                                                                                CqlInterval<CqlDate> bzzzy_ = context.Operators.Interval(bzzzs_, bzzzx_, true, true);
                                                                                                                                bool? bzzzz_ = context.Operators.In<CqlDate>(X, bzzzy_, default);
                                                                                                                                bool? czzza_ = context.Operators.Not(bzzzz_);

                                                                                                                                return czzza_;
                                                                                                                            };
                                                                                                                            IEnumerable<CqlDate> bzzzf_ = context.Operators.Where<CqlDate>(bzzza_, bzzze_);
                                                                                                                            int? bzzzh_ = context.Operators.Add(bzzzb_, 1);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzi_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bzzzc_ as CqlDate, bzzzf_, bzzzh_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] bzzzj_ = [
                                                                                                                                bzzzi_,
                                                                                                                            ];
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzk_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList)
                                                                                                                            {
                                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzb_()
                                                                                                                                {
                                                                                                                                    bool czzzc_()
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> czzzd_ = TenthList?.NewList;
                                                                                                                                        int? czzze_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate czzzf_ = context.Operators.Indexer<CqlDate>(czzzd_, czzze_);

                                                                                                                                        return czzzf_ is null;
                                                                                                                                    };
                                                                                                                                    if (czzzc_())
                                                                                                                                    {
                                                                                                                                        return TenthList;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> czzzg_ = TenthList?.NewList;
                                                                                                                                        int? czzzh_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate czzzi_ = context.Operators.Indexer<CqlDate>(czzzg_, czzzh_);
                                                                                                                                        bool? czzzk_(CqlDate X)
                                                                                                                                        {
                                                                                                                                            IEnumerable<CqlDate> czzzu_ = TenthList?.NewList;
                                                                                                                                            int? czzzv_ = TenthList?.IndexofNewDate;
                                                                                                                                            CqlDate czzzw_ = context.Operators.Indexer<CqlDate>(czzzu_, czzzv_);
                                                                                                                                            CqlQuantity czzzx_ = context.Operators.Quantity(1m, "day");
                                                                                                                                            CqlDate czzzy_ = context.Operators.Add(czzzw_ as CqlDate, czzzx_);
                                                                                                                                            CqlDate dzzzb_ = context.Operators.Indexer<CqlDate>(czzzu_, czzzv_);
                                                                                                                                            CqlQuantity dzzzc_ = context.Operators.Quantity(30m, "days");
                                                                                                                                            CqlDate dzzzd_ = context.Operators.Add(dzzzb_ as CqlDate, dzzzc_);
                                                                                                                                            CqlInterval<CqlDate> dzzze_ = context.Operators.Interval(czzzy_, dzzzd_, true, true);
                                                                                                                                            bool? dzzzf_ = context.Operators.In<CqlDate>(X, dzzze_, default);
                                                                                                                                            bool? dzzzg_ = context.Operators.Not(dzzzf_);

                                                                                                                                            return dzzzg_;
                                                                                                                                        };
                                                                                                                                        IEnumerable<CqlDate> czzzl_ = context.Operators.Where<CqlDate>(czzzg_, czzzk_);
                                                                                                                                        int? czzzn_ = context.Operators.Add(czzzh_, 1);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzo_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, czzzi_ as CqlDate, czzzl_, czzzn_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] czzzp_ = [
                                                                                                                                            czzzo_,
                                                                                                                                        ];
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzq_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList)
                                                                                                                                        {
                                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzh_()
                                                                                                                                            {
                                                                                                                                                bool dzzzi_()
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> dzzzj_ = EleventhList?.NewList;
                                                                                                                                                    int? dzzzk_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate dzzzl_ = context.Operators.Indexer<CqlDate>(dzzzj_, dzzzk_);

                                                                                                                                                    return dzzzl_ is null;
                                                                                                                                                };
                                                                                                                                                if (dzzzi_())
                                                                                                                                                {
                                                                                                                                                    return EleventhList;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> dzzzm_ = EleventhList?.NewList;
                                                                                                                                                    int? dzzzn_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate dzzzo_ = context.Operators.Indexer<CqlDate>(dzzzm_, dzzzn_);
                                                                                                                                                    bool? dzzzq_(CqlDate X)
                                                                                                                                                    {
                                                                                                                                                        IEnumerable<CqlDate> dzzzv_ = EleventhList?.NewList;
                                                                                                                                                        int? dzzzw_ = EleventhList?.IndexofNewDate;
                                                                                                                                                        CqlDate dzzzx_ = context.Operators.Indexer<CqlDate>(dzzzv_, dzzzw_);
                                                                                                                                                        CqlQuantity dzzzy_ = context.Operators.Quantity(1m, "day");
                                                                                                                                                        CqlDate dzzzz_ = context.Operators.Add(dzzzx_ as CqlDate, dzzzy_);
                                                                                                                                                        CqlDate ezzzc_ = context.Operators.Indexer<CqlDate>(dzzzv_, dzzzw_);
                                                                                                                                                        CqlQuantity ezzzd_ = context.Operators.Quantity(30m, "days");
                                                                                                                                                        CqlDate ezzze_ = context.Operators.Add(ezzzc_ as CqlDate, ezzzd_);
                                                                                                                                                        CqlInterval<CqlDate> ezzzf_ = context.Operators.Interval(dzzzz_, ezzze_, true, true);
                                                                                                                                                        bool? ezzzg_ = context.Operators.In<CqlDate>(X, ezzzf_, default);
                                                                                                                                                        bool? ezzzh_ = context.Operators.Not(ezzzg_);

                                                                                                                                                        return ezzzh_;
                                                                                                                                                    };
                                                                                                                                                    IEnumerable<CqlDate> dzzzr_ = context.Operators.Where<CqlDate>(dzzzm_, dzzzq_);
                                                                                                                                                    int? dzzzt_ = context.Operators.Add(dzzzn_, 1);
                                                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, dzzzo_ as CqlDate, dzzzr_, dzzzt_);

                                                                                                                                                    return dzzzu_;
                                                                                                                                                }
                                                                                                                                            };

                                                                                                                                            return dzzzh_();
                                                                                                                                        };
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> czzzr_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)czzzp_, czzzq_);
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> czzzs_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(czzzr_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(czzzs_);

                                                                                                                                        return czzzt_;
                                                                                                                                    }
                                                                                                                                };

                                                                                                                                return czzzb_();
                                                                                                                            };
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bzzzl_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)bzzzj_, bzzzk_);
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bzzzl_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bzzzm_);

                                                                                                                            return bzzzn_;
                                                                                                                        }
                                                                                                                    };

                                                                                                                    return azzzv_();
                                                                                                                };
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> azzzf_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)azzzd_, azzze_);
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> azzzg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(azzzf_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(azzzg_);

                                                                                                                return azzzh_;
                                                                                                            }
                                                                                                        };

                                                                                                        return zzzp_();
                                                                                                    };
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> yzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)yzzx_, yzzy_);
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> zzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(yzzz_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? zzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(zzza_);

                                                                                                    return zzzb_;
                                                                                                }
                                                                                            };

                                                                                            return yzzj_();
                                                                                        };
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> xzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)xzzr_, xzzs_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> xzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(xzzt_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(xzzu_);

                                                                                        return xzzv_;
                                                                                    }
                                                                                };

                                                                                return xzzd_();
                                                                            };
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> wzzn_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)wzzl_, wzzm_);
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> wzzo_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(wzzn_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(wzzo_);

                                                                            return wzzp_;
                                                                        }
                                                                    };

                                                                    return vzzx_();
                                                                };
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> vzzh_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)vzzf_, vzzg_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> vzzi_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(vzzh_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? vzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(vzzi_);

                                                                return vzzj_;
                                                            }
                                                        };

                                                        return uzzr_();
                                                    };
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> uzzb_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)tzzz_, uzza_);
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> uzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(uzzb_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(uzzc_);

                                                    return uzzd_;
                                                }
                                            };

                                            return tzzl_();
                                        };
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> szzv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)szzt_, szzu_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> szzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(szzv_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(szzw_);

                                        return szzx_;
                                    }
                                };

                                return szzf_();
                            };
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> rzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)rzzn_, rzzo_);
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> rzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(rzzp_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(rzzq_);

                            return rzzr_;
                        }
                    };

                    return qzzz_();
                };
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)qzzh_, qzzi_);
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzj_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzk_);

                return qzzl_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzw_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)pzzu_, pzzv_);
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzx_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzw_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzy_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzx_);

            return pzzy_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzo_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?>)pzzm_, pzzn_);
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzp_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzo_);
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzq_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzp_);

        return pzzq_;
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
