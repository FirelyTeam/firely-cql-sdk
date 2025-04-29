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
        IEnumerable<Patient> ozzf_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient ozzg_ = context.Operators.SingletonFrom<Patient>(ozzf_);

        return ozzg_;
    }


    [CqlExpressionDefinition("Normalize Onset")]
    public CqlInterval<CqlDateTime> Normalize_Onset(CqlContext context, object onset)
    {
        CqlInterval<CqlDateTime> ozzh_()
        {
            if (onset is FhirDateTime)
            {
                CqlDateTime ozzi_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, onset as FhirDateTime);
                CqlInterval<CqlDateTime> ozzk_ = context.Operators.Interval(ozzi_, ozzi_, true, true);

                return ozzk_;
            }
            else if (onset is Period)
            {
                FhirDateTime ozzl_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
                CqlDateTime ozzm_ = context.Operators.Convert<CqlDateTime>(ozzl_);
                FhirDateTime ozzn_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
                CqlDateTime ozzo_ = context.Operators.Convert<CqlDateTime>(ozzn_);
                CqlInterval<CqlDateTime> ozzp_ = context.Operators.Interval(ozzm_, ozzo_, true, true);

                return ozzp_;
            }
            else if (onset is FhirString)
            {
                CqlInterval<CqlDateTime> ozzq_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return ozzq_;
            }
            else
            {
                CqlInterval<CqlDate> ozzr_()
                {
                    if (onset is Age)
                    {
                        Patient pzzc_ = this.Patient(context);
                        Date pzzd_ = pzzc_?.BirthDateElement;
                        CqlDate pzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzzd_);
                        CqlQuantity pzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate pzzg_ = context.Operators.Add(pzze_, pzzf_);
                        Date pzzi_ = pzzc_?.BirthDateElement;
                        CqlDate pzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzzi_);
                        CqlDate pzzl_ = context.Operators.Add(pzzj_, pzzf_);
                        CqlQuantity pzzm_ = context.Operators.Quantity(1m, "year");
                        CqlDate pzzn_ = context.Operators.Add(pzzl_, pzzm_);
                        CqlInterval<CqlDate> pzzo_ = context.Operators.Interval(pzzg_, pzzn_, true, false);

                        return pzzo_;
                    }
                    else if (onset is Range)
                    {
                        Patient pzzp_ = this.Patient(context);
                        Date pzzq_ = pzzp_?.BirthDateElement;
                        CqlDate pzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzzq_);
                        Quantity pzzs_ = (onset as Range)?.Low;
                        CqlQuantity pzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzzs_);
                        CqlDate pzzu_ = context.Operators.Add(pzzr_, pzzt_);
                        Date pzzw_ = pzzp_?.BirthDateElement;
                        CqlDate pzzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzzw_);
                        Quantity pzzy_ = (onset as Range)?.High;
                        CqlQuantity pzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzzy_);
                        CqlDate qzza_ = context.Operators.Add(pzzx_, pzzz_);
                        CqlQuantity qzzb_ = context.Operators.Quantity(1m, "year");
                        CqlDate qzzc_ = context.Operators.Add(qzza_, qzzb_);
                        CqlInterval<CqlDate> qzzd_ = context.Operators.Interval(pzzu_, qzzc_, true, false);

                        return qzzd_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate ozzs_ = (ozzr_())?.low;
                CqlDateTime ozzt_ = context.Operators.ConvertDateToDateTime(ozzs_);
                CqlInterval<CqlDate> ozzu_()
                {
                    if (onset is Age)
                    {
                        Patient qzze_ = this.Patient(context);
                        Date qzzf_ = qzze_?.BirthDateElement;
                        CqlDate qzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzf_);
                        CqlQuantity qzzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate qzzi_ = context.Operators.Add(qzzg_, qzzh_);
                        Date qzzk_ = qzze_?.BirthDateElement;
                        CqlDate qzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzk_);
                        CqlDate qzzn_ = context.Operators.Add(qzzl_, qzzh_);
                        CqlQuantity qzzo_ = context.Operators.Quantity(1m, "year");
                        CqlDate qzzp_ = context.Operators.Add(qzzn_, qzzo_);
                        CqlInterval<CqlDate> qzzq_ = context.Operators.Interval(qzzi_, qzzp_, true, false);

                        return qzzq_;
                    }
                    else if (onset is Range)
                    {
                        Patient qzzr_ = this.Patient(context);
                        Date qzzs_ = qzzr_?.BirthDateElement;
                        CqlDate qzzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzs_);
                        Quantity qzzu_ = (onset as Range)?.Low;
                        CqlQuantity qzzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzu_);
                        CqlDate qzzw_ = context.Operators.Add(qzzt_, qzzv_);
                        Date qzzy_ = qzzr_?.BirthDateElement;
                        CqlDate qzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzy_);
                        Quantity rzza_ = (onset as Range)?.High;
                        CqlQuantity rzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzza_);
                        CqlDate rzzc_ = context.Operators.Add(qzzz_, rzzb_);
                        CqlQuantity rzzd_ = context.Operators.Quantity(1m, "year");
                        CqlDate rzze_ = context.Operators.Add(rzzc_, rzzd_);
                        CqlInterval<CqlDate> rzzf_ = context.Operators.Interval(qzzw_, rzze_, true, false);

                        return rzzf_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate ozzv_ = (ozzu_())?.high;
                CqlDateTime ozzw_ = context.Operators.ConvertDateToDateTime(ozzv_);
                CqlInterval<CqlDate> ozzx_()
                {
                    if (onset is Age)
                    {
                        Patient rzzg_ = this.Patient(context);
                        Date rzzh_ = rzzg_?.BirthDateElement;
                        CqlDate rzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzh_);
                        CqlQuantity rzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate rzzk_ = context.Operators.Add(rzzi_, rzzj_);
                        Date rzzm_ = rzzg_?.BirthDateElement;
                        CqlDate rzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzm_);
                        CqlDate rzzp_ = context.Operators.Add(rzzn_, rzzj_);
                        CqlQuantity rzzq_ = context.Operators.Quantity(1m, "year");
                        CqlDate rzzr_ = context.Operators.Add(rzzp_, rzzq_);
                        CqlInterval<CqlDate> rzzs_ = context.Operators.Interval(rzzk_, rzzr_, true, false);

                        return rzzs_;
                    }
                    else if (onset is Range)
                    {
                        Patient rzzt_ = this.Patient(context);
                        Date rzzu_ = rzzt_?.BirthDateElement;
                        CqlDate rzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzu_);
                        Quantity rzzw_ = (onset as Range)?.Low;
                        CqlQuantity rzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzzw_);
                        CqlDate rzzy_ = context.Operators.Add(rzzv_, rzzx_);
                        Date szza_ = rzzt_?.BirthDateElement;
                        CqlDate szzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szza_);
                        Quantity szzc_ = (onset as Range)?.High;
                        CqlQuantity szzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, szzc_);
                        CqlDate szze_ = context.Operators.Add(szzb_, szzd_);
                        CqlQuantity szzf_ = context.Operators.Quantity(1m, "year");
                        CqlDate szzg_ = context.Operators.Add(szze_, szzf_);
                        CqlInterval<CqlDate> szzh_ = context.Operators.Interval(rzzy_, szzg_, true, false);

                        return szzh_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? ozzy_ = (ozzx_())?.lowClosed;
                CqlInterval<CqlDate> ozzz_()
                {
                    if (onset is Age)
                    {
                        Patient szzi_ = this.Patient(context);
                        Date szzj_ = szzi_?.BirthDateElement;
                        CqlDate szzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzj_);
                        CqlQuantity szzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate szzm_ = context.Operators.Add(szzk_, szzl_);
                        Date szzo_ = szzi_?.BirthDateElement;
                        CqlDate szzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzo_);
                        CqlDate szzr_ = context.Operators.Add(szzp_, szzl_);
                        CqlQuantity szzs_ = context.Operators.Quantity(1m, "year");
                        CqlDate szzt_ = context.Operators.Add(szzr_, szzs_);
                        CqlInterval<CqlDate> szzu_ = context.Operators.Interval(szzm_, szzt_, true, false);

                        return szzu_;
                    }
                    else if (onset is Range)
                    {
                        Patient szzv_ = this.Patient(context);
                        Date szzw_ = szzv_?.BirthDateElement;
                        CqlDate szzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzw_);
                        Quantity szzy_ = (onset as Range)?.Low;
                        CqlQuantity szzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, szzy_);
                        CqlDate tzza_ = context.Operators.Add(szzx_, szzz_);
                        Date tzzc_ = szzv_?.BirthDateElement;
                        CqlDate tzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzc_);
                        Quantity tzze_ = (onset as Range)?.High;
                        CqlQuantity tzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, tzze_);
                        CqlDate tzzg_ = context.Operators.Add(tzzd_, tzzf_);
                        CqlQuantity tzzh_ = context.Operators.Quantity(1m, "year");
                        CqlDate tzzi_ = context.Operators.Add(tzzg_, tzzh_);
                        CqlInterval<CqlDate> tzzj_ = context.Operators.Interval(tzza_, tzzi_, true, false);

                        return tzzj_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? pzza_ = (ozzz_())?.highClosed;
                CqlInterval<CqlDateTime> pzzb_ = context.Operators.Interval(ozzt_, ozzw_, ozzy_, pzza_);

                return pzzb_;
            }
        };

        return ozzh_();
    }


    [CqlExpressionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {
        CqlInterval<CqlDateTime> tzzk_()
        {
            if (abatement is FhirDateTime)
            {
                CqlDateTime tzzl_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, abatement as FhirDateTime);
                CqlInterval<CqlDateTime> tzzn_ = context.Operators.Interval(tzzl_, tzzl_, true, true);

                return tzzn_;
            }
            else if (abatement is Period)
            {
                FhirDateTime tzzo_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
                CqlDateTime tzzp_ = context.Operators.Convert<CqlDateTime>(tzzo_);
                FhirDateTime tzzq_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
                CqlDateTime tzzr_ = context.Operators.Convert<CqlDateTime>(tzzq_);
                CqlInterval<CqlDateTime> tzzs_ = context.Operators.Interval(tzzp_, tzzr_, true, true);

                return tzzs_;
            }
            else if (abatement is FhirString)
            {
                CqlInterval<CqlDateTime> tzzt_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return tzzt_;
            }
            else
            {
                CqlInterval<CqlDate> tzzu_()
                {
                    if (abatement is Age)
                    {
                        Patient uzzf_ = this.Patient(context);
                        Date uzzg_ = uzzf_?.BirthDateElement;
                        CqlDate uzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzg_);
                        CqlQuantity uzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate uzzj_ = context.Operators.Add(uzzh_, uzzi_);
                        Date uzzl_ = uzzf_?.BirthDateElement;
                        CqlDate uzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzl_);
                        CqlDate uzzo_ = context.Operators.Add(uzzm_, uzzi_);
                        CqlQuantity uzzp_ = context.Operators.Quantity(1m, "year");
                        CqlDate uzzq_ = context.Operators.Add(uzzo_, uzzp_);
                        CqlInterval<CqlDate> uzzr_ = context.Operators.Interval(uzzj_, uzzq_, true, false);

                        return uzzr_;
                    }
                    else if (abatement is Range)
                    {
                        Patient uzzs_ = this.Patient(context);
                        Date uzzt_ = uzzs_?.BirthDateElement;
                        CqlDate uzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzt_);
                        Quantity uzzv_ = (abatement as Range)?.Low;
                        CqlQuantity uzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzv_);
                        CqlDate uzzx_ = context.Operators.Add(uzzu_, uzzw_);
                        Date uzzz_ = uzzs_?.BirthDateElement;
                        CqlDate vzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzz_);
                        Quantity vzzb_ = (abatement as Range)?.High;
                        CqlQuantity vzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzb_);
                        CqlDate vzzd_ = context.Operators.Add(vzza_, vzzc_);
                        CqlQuantity vzze_ = context.Operators.Quantity(1m, "year");
                        CqlDate vzzf_ = context.Operators.Add(vzzd_, vzze_);
                        CqlInterval<CqlDate> vzzg_ = context.Operators.Interval(uzzx_, vzzf_, true, false);

                        return vzzg_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate tzzv_ = (tzzu_())?.low;
                CqlDateTime tzzw_ = context.Operators.ConvertDateToDateTime(tzzv_);
                CqlInterval<CqlDate> tzzx_()
                {
                    if (abatement is Age)
                    {
                        Patient vzzh_ = this.Patient(context);
                        Date vzzi_ = vzzh_?.BirthDateElement;
                        CqlDate vzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzi_);
                        CqlQuantity vzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate vzzl_ = context.Operators.Add(vzzj_, vzzk_);
                        Date vzzn_ = vzzh_?.BirthDateElement;
                        CqlDate vzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzn_);
                        CqlDate vzzq_ = context.Operators.Add(vzzo_, vzzk_);
                        CqlQuantity vzzr_ = context.Operators.Quantity(1m, "year");
                        CqlDate vzzs_ = context.Operators.Add(vzzq_, vzzr_);
                        CqlInterval<CqlDate> vzzt_ = context.Operators.Interval(vzzl_, vzzs_, true, false);

                        return vzzt_;
                    }
                    else if (abatement is Range)
                    {
                        Patient vzzu_ = this.Patient(context);
                        Date vzzv_ = vzzu_?.BirthDateElement;
                        CqlDate vzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzv_);
                        Quantity vzzx_ = (abatement as Range)?.Low;
                        CqlQuantity vzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzx_);
                        CqlDate vzzz_ = context.Operators.Add(vzzw_, vzzy_);
                        Date wzzb_ = vzzu_?.BirthDateElement;
                        CqlDate wzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzb_);
                        Quantity wzzd_ = (abatement as Range)?.High;
                        CqlQuantity wzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, wzzd_);
                        CqlDate wzzf_ = context.Operators.Add(wzzc_, wzze_);
                        CqlQuantity wzzg_ = context.Operators.Quantity(1m, "year");
                        CqlDate wzzh_ = context.Operators.Add(wzzf_, wzzg_);
                        CqlInterval<CqlDate> wzzi_ = context.Operators.Interval(vzzz_, wzzh_, true, false);

                        return wzzi_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate tzzy_ = (tzzx_())?.high;
                CqlDateTime tzzz_ = context.Operators.ConvertDateToDateTime(tzzy_);
                CqlInterval<CqlDate> uzza_()
                {
                    if (abatement is Age)
                    {
                        Patient wzzj_ = this.Patient(context);
                        Date wzzk_ = wzzj_?.BirthDateElement;
                        CqlDate wzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzk_);
                        CqlQuantity wzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate wzzn_ = context.Operators.Add(wzzl_, wzzm_);
                        Date wzzp_ = wzzj_?.BirthDateElement;
                        CqlDate wzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzp_);
                        CqlDate wzzs_ = context.Operators.Add(wzzq_, wzzm_);
                        CqlQuantity wzzt_ = context.Operators.Quantity(1m, "year");
                        CqlDate wzzu_ = context.Operators.Add(wzzs_, wzzt_);
                        CqlInterval<CqlDate> wzzv_ = context.Operators.Interval(wzzn_, wzzu_, true, false);

                        return wzzv_;
                    }
                    else if (abatement is Range)
                    {
                        Patient wzzw_ = this.Patient(context);
                        Date wzzx_ = wzzw_?.BirthDateElement;
                        CqlDate wzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzx_);
                        Quantity wzzz_ = (abatement as Range)?.Low;
                        CqlQuantity xzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, wzzz_);
                        CqlDate xzzb_ = context.Operators.Add(wzzy_, xzza_);
                        Date xzzd_ = wzzw_?.BirthDateElement;
                        CqlDate xzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzd_);
                        Quantity xzzf_ = (abatement as Range)?.High;
                        CqlQuantity xzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzf_);
                        CqlDate xzzh_ = context.Operators.Add(xzze_, xzzg_);
                        CqlQuantity xzzi_ = context.Operators.Quantity(1m, "year");
                        CqlDate xzzj_ = context.Operators.Add(xzzh_, xzzi_);
                        CqlInterval<CqlDate> xzzk_ = context.Operators.Interval(xzzb_, xzzj_, true, false);

                        return xzzk_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? uzzb_ = (uzza_())?.lowClosed;
                CqlInterval<CqlDate> uzzc_()
                {
                    if (abatement is Age)
                    {
                        Patient xzzl_ = this.Patient(context);
                        Date xzzm_ = xzzl_?.BirthDateElement;
                        CqlDate xzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzm_);
                        CqlQuantity xzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate xzzp_ = context.Operators.Add(xzzn_, xzzo_);
                        Date xzzr_ = xzzl_?.BirthDateElement;
                        CqlDate xzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzr_);
                        CqlDate xzzu_ = context.Operators.Add(xzzs_, xzzo_);
                        CqlQuantity xzzv_ = context.Operators.Quantity(1m, "year");
                        CqlDate xzzw_ = context.Operators.Add(xzzu_, xzzv_);
                        CqlInterval<CqlDate> xzzx_ = context.Operators.Interval(xzzp_, xzzw_, true, false);

                        return xzzx_;
                    }
                    else if (abatement is Range)
                    {
                        Patient xzzy_ = this.Patient(context);
                        Date xzzz_ = xzzy_?.BirthDateElement;
                        CqlDate yzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzz_);
                        Quantity yzzb_ = (abatement as Range)?.Low;
                        CqlQuantity yzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzb_);
                        CqlDate yzzd_ = context.Operators.Add(yzza_, yzzc_);
                        Date yzzf_ = xzzy_?.BirthDateElement;
                        CqlDate yzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzf_);
                        Quantity yzzh_ = (abatement as Range)?.High;
                        CqlQuantity yzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, yzzh_);
                        CqlDate yzzj_ = context.Operators.Add(yzzg_, yzzi_);
                        CqlQuantity yzzk_ = context.Operators.Quantity(1m, "year");
                        CqlDate yzzl_ = context.Operators.Add(yzzj_, yzzk_);
                        CqlInterval<CqlDate> yzzm_ = context.Operators.Interval(yzzd_, yzzl_, true, false);

                        return yzzm_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? uzzd_ = (uzzc_())?.highClosed;
                CqlInterval<CqlDateTime> uzze_ = context.Operators.Interval(tzzw_, tzzz_, uzzb_, uzzd_);

                return uzze_;
            }
        };

        return tzzk_();
    }


    [CqlExpressionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        DataType yzzn_ = condition?.Onset;
        CqlInterval<CqlDateTime> yzzo_ = this.Normalize_Onset(context, yzzn_);
        CqlDateTime yzzp_ = context.Operators.Start(yzzo_);
        DataType yzzq_ = condition?.Abatement;
        CqlInterval<CqlDateTime> yzzr_ = this.Normalize_Abatement(context, yzzq_);
        CqlDateTime yzzs_ = context.Operators.End(yzzr_);
        CqlInterval<CqlDateTime> yzzt_ = context.Operators.Interval(yzzp_, yzzs_, true, true);

        return yzzt_;
    }


    [CqlExpressionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> yzzu_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime yzzv_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> yzzx_ = context.Operators.Interval(yzzv_, yzzv_, true, true);

                return yzzx_;
            }
            else if (choice is Date)
            {
                CqlDate yzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
                CqlDateTime yzzz_ = context.Operators.ConvertDateToDateTime(yzzy_);
                CqlDateTime zzzb_ = context.Operators.ConvertDateToDateTime(yzzy_);
                CqlInterval<CqlDateTime> zzzc_ = context.Operators.Interval(yzzz_, zzzb_, true, true);

                return zzzc_;
            }
            else if (choice is Period)
            {
                FhirDateTime zzzd_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
                CqlDateTime zzze_ = context.Operators.Convert<CqlDateTime>(zzzd_);
                FhirDateTime zzzf_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
                CqlDateTime zzzg_ = context.Operators.Convert<CqlDateTime>(zzzf_);
                CqlInterval<CqlDateTime> zzzh_ = context.Operators.Interval(zzze_, zzzg_, true, true);

                return zzzh_;
            }
            else if (choice is Instant)
            {
                CqlDateTime zzzi_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> zzzk_ = context.Operators.Interval(zzzi_, zzzi_, true, true);

                return zzzk_;
            }
            else if (choice is Age)
            {
                Patient zzzl_ = this.Patient(context);
                Date zzzm_ = zzzl_?.BirthDateElement;
                CqlDate zzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzm_);
                CqlQuantity zzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate zzzp_ = context.Operators.Add(zzzn_, zzzo_);
                Date zzzr_ = zzzl_?.BirthDateElement;
                CqlDate zzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzr_);
                CqlDate zzzu_ = context.Operators.Add(zzzs_, zzzo_);
                CqlQuantity zzzv_ = context.Operators.Quantity(1m, "year");
                CqlDate zzzw_ = context.Operators.Add(zzzu_, zzzv_);
                CqlInterval<CqlDate> zzzx_ = context.Operators.Interval(zzzp_, zzzw_, true, false);
                CqlDate zzzy_ = zzzx_?.low;
                CqlDateTime zzzz_ = context.Operators.ConvertDateToDateTime(zzzy_);
                Date azzzb_ = zzzl_?.BirthDateElement;
                CqlDate azzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzb_);
                CqlDate azzze_ = context.Operators.Add(azzzc_, zzzo_);
                Date azzzg_ = zzzl_?.BirthDateElement;
                CqlDate azzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzg_);
                CqlDate azzzj_ = context.Operators.Add(azzzh_, zzzo_);
                CqlDate azzzl_ = context.Operators.Add(azzzj_, zzzv_);
                CqlInterval<CqlDate> azzzm_ = context.Operators.Interval(azzze_, azzzl_, true, false);
                CqlDate azzzn_ = azzzm_?.high;
                CqlDateTime azzzo_ = context.Operators.ConvertDateToDateTime(azzzn_);
                Date azzzq_ = zzzl_?.BirthDateElement;
                CqlDate azzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzq_);
                CqlDate azzzt_ = context.Operators.Add(azzzr_, zzzo_);
                Date azzzv_ = zzzl_?.BirthDateElement;
                CqlDate azzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzv_);
                CqlDate azzzy_ = context.Operators.Add(azzzw_, zzzo_);
                CqlDate bzzza_ = context.Operators.Add(azzzy_, zzzv_);
                CqlInterval<CqlDate> bzzzb_ = context.Operators.Interval(azzzt_, bzzza_, true, false);
                bool? bzzzc_ = bzzzb_?.lowClosed;
                Date bzzze_ = zzzl_?.BirthDateElement;
                CqlDate bzzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzze_);
                CqlDate bzzzh_ = context.Operators.Add(bzzzf_, zzzo_);
                Date bzzzj_ = zzzl_?.BirthDateElement;
                CqlDate bzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzj_);
                CqlDate bzzzm_ = context.Operators.Add(bzzzk_, zzzo_);
                CqlDate bzzzo_ = context.Operators.Add(bzzzm_, zzzv_);
                CqlInterval<CqlDate> bzzzp_ = context.Operators.Interval(bzzzh_, bzzzo_, true, false);
                bool? bzzzq_ = bzzzp_?.highClosed;
                CqlInterval<CqlDateTime> bzzzr_ = context.Operators.Interval(zzzz_, azzzo_, bzzzc_, bzzzq_);

                return bzzzr_;
            }
            else if (choice is Range)
            {
                Patient bzzzs_ = this.Patient(context);
                Date bzzzt_ = bzzzs_?.BirthDateElement;
                CqlDate bzzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzt_);
                Quantity bzzzv_ = (choice as Range)?.Low;
                CqlQuantity bzzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzv_);
                CqlDate bzzzx_ = context.Operators.Add(bzzzu_, bzzzw_);
                Date bzzzz_ = bzzzs_?.BirthDateElement;
                CqlDate czzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzz_);
                Quantity czzzb_ = (choice as Range)?.High;
                CqlQuantity czzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzb_);
                CqlDate czzzd_ = context.Operators.Add(czzza_, czzzc_);
                CqlQuantity czzze_ = context.Operators.Quantity(1m, "year");
                CqlDate czzzf_ = context.Operators.Add(czzzd_, czzze_);
                CqlInterval<CqlDate> czzzg_ = context.Operators.Interval(bzzzx_, czzzf_, true, false);
                CqlDate czzzh_ = czzzg_?.low;
                CqlDateTime czzzi_ = context.Operators.ConvertDateToDateTime(czzzh_);
                Date czzzk_ = bzzzs_?.BirthDateElement;
                CqlDate czzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzzk_);
                CqlQuantity czzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzv_);
                CqlDate czzzo_ = context.Operators.Add(czzzl_, czzzn_);
                Date czzzq_ = bzzzs_?.BirthDateElement;
                CqlDate czzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzzq_);
                CqlQuantity czzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzb_);
                CqlDate czzzu_ = context.Operators.Add(czzzr_, czzzt_);
                CqlDate czzzw_ = context.Operators.Add(czzzu_, czzze_);
                CqlInterval<CqlDate> czzzx_ = context.Operators.Interval(czzzo_, czzzw_, true, false);
                CqlDate czzzy_ = czzzx_?.high;
                CqlDateTime czzzz_ = context.Operators.ConvertDateToDateTime(czzzy_);
                Date dzzzb_ = bzzzs_?.BirthDateElement;
                CqlDate dzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzzb_);
                CqlQuantity dzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzv_);
                CqlDate dzzzf_ = context.Operators.Add(dzzzc_, dzzze_);
                Date dzzzh_ = bzzzs_?.BirthDateElement;
                CqlDate dzzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzzh_);
                CqlQuantity dzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzb_);
                CqlDate dzzzl_ = context.Operators.Add(dzzzi_, dzzzk_);
                CqlDate dzzzn_ = context.Operators.Add(dzzzl_, czzze_);
                CqlInterval<CqlDate> dzzzo_ = context.Operators.Interval(dzzzf_, dzzzn_, true, false);
                bool? dzzzp_ = dzzzo_?.lowClosed;
                Date dzzzr_ = bzzzs_?.BirthDateElement;
                CqlDate dzzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzzr_);
                CqlQuantity dzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzv_);
                CqlDate dzzzv_ = context.Operators.Add(dzzzs_, dzzzu_);
                Date dzzzx_ = bzzzs_?.BirthDateElement;
                CqlDate dzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, dzzzx_);
                CqlQuantity ezzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzb_);
                CqlDate ezzzb_ = context.Operators.Add(dzzzy_, ezzza_);
                CqlDate ezzzd_ = context.Operators.Add(ezzzb_, czzze_);
                CqlInterval<CqlDate> ezzze_ = context.Operators.Interval(dzzzv_, ezzzd_, true, false);
                bool? ezzzf_ = ezzze_?.highClosed;
                CqlInterval<CqlDateTime> ezzzg_ = context.Operators.Interval(czzzi_, czzzz_, dzzzp_, ezzzf_);

                return ezzzg_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> ezzzh_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return ezzzh_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> ezzzi_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return ezzzi_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return yzzu_();
    }


    [CqlExpressionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        string ezzzj_()
        {
            bool ezzzk_()
            {
                int? ezzzl_ = context.Operators.PositionOf("/", uri);
                bool? ezzzm_ = context.Operators.Greater(ezzzl_, 0);

                return ezzzm_ ?? false;
            };
            if (ezzzk_())
            {
                IEnumerable<string> ezzzn_ = context.Operators.Split(uri, "/");
                string ezzzo_ = context.Operators.Last<string>(ezzzn_);

                return ezzzo_;
            }
            else
            {
                return uri;
            }
        };

        return ezzzj_();
    }


    [CqlExpressionDefinition("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) =>
        VSet;


    [CqlExpressionDefinition("First Dates per 31 Day Periods")]
    public (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
    {
        CqlDate ezzzp_(CqlDate d) =>
            d;
        IEnumerable<CqlDate> ezzzq_ = context.Operators.Select<CqlDate, CqlDate>(DateList, ezzzp_);
        IEnumerable<CqlDate> ezzzr_ = context.Operators.Distinct<CqlDate>(ezzzq_);
        IEnumerable<CqlDate> ezzzs_ = context.Operators.ListSort<CqlDate>(ezzzr_, System.ComponentModel.ListSortDirection.Ascending);
        bool? ezzzt_(CqlDate X)
        {
            bool? fzzzb_ = context.Operators.Not((bool?)(X is null));

            return fzzzb_;
        };
        IEnumerable<CqlDate> ezzzu_ = context.Operators.Where<CqlDate>(ezzzs_, ezzzt_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? ezzzv_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, ezzzu_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] ezzzw_ = [
            ezzzv_,
        ];
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ezzzx_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates)
        {
            IEnumerable<CqlDate> fzzzc_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? fzzzd_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, fzzzc_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] fzzze_ = [
                fzzzd_,
            ];
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzf_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList)
            {
                IEnumerable<CqlDate> fzzzj_ = AnchorList?.SortedList;
                int? fzzzk_ = AnchorList?.AnchorIndex;
                CqlDate fzzzl_ = context.Operators.Indexer<CqlDate>(fzzzj_, fzzzk_);
                bool? fzzzm_(CqlDate X)
                {
                    IEnumerable<CqlDate> fzzzw_ = AnchorList?.SortedList;
                    int? fzzzx_ = AnchorList?.AnchorIndex;
                    CqlDate fzzzy_ = context.Operators.Indexer<CqlDate>(fzzzw_, fzzzx_);
                    CqlQuantity fzzzz_ = context.Operators.Quantity(1m, "day");
                    CqlDate gzzza_ = context.Operators.Add(fzzzy_ as CqlDate, fzzzz_);
                    CqlDate gzzzd_ = context.Operators.Indexer<CqlDate>(fzzzw_, fzzzx_);
                    CqlQuantity gzzze_ = context.Operators.Quantity(30m, "days");
                    CqlDate gzzzf_ = context.Operators.Add(gzzzd_ as CqlDate, gzzze_);
                    CqlInterval<CqlDate> gzzzg_ = context.Operators.Interval(gzzza_, gzzzf_, true, true);
                    bool? gzzzh_ = context.Operators.In<CqlDate>(X, gzzzg_, default);
                    bool? gzzzi_ = context.Operators.Not(gzzzh_);

                    return gzzzi_;
                };
                IEnumerable<CqlDate> fzzzn_ = context.Operators.Where<CqlDate>(DateList, fzzzm_);
                int? fzzzp_ = context.Operators.Add(fzzzk_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, fzzzl_ as CqlDate, fzzzn_, fzzzp_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fzzzr_ = [
                    fzzzq_,
                ];
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzs_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList)
                {
                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzj_()
                    {
                        bool gzzzk_()
                        {
                            IEnumerable<CqlDate> gzzzl_ = FirstList?.NewList;
                            int? gzzzm_ = FirstList?.IndexofNewDate;
                            CqlDate gzzzn_ = context.Operators.Indexer<CqlDate>(gzzzl_, gzzzm_);

                            return gzzzn_ is null;
                        };
                        if (gzzzk_())
                        {
                            return FirstList;
                        }
                        else
                        {
                            IEnumerable<CqlDate> gzzzo_ = FirstList?.NewList;
                            int? gzzzp_ = FirstList?.IndexofNewDate;
                            CqlDate gzzzq_ = context.Operators.Indexer<CqlDate>(gzzzo_, gzzzp_);
                            bool? gzzzs_(CqlDate X)
                            {
                                IEnumerable<CqlDate> hzzzc_ = FirstList?.NewList;
                                int? hzzzd_ = FirstList?.IndexofNewDate;
                                CqlDate hzzze_ = context.Operators.Indexer<CqlDate>(hzzzc_, hzzzd_);
                                CqlQuantity hzzzf_ = context.Operators.Quantity(1m, "day");
                                CqlDate hzzzg_ = context.Operators.Add(hzzze_ as CqlDate, hzzzf_);
                                CqlDate hzzzj_ = context.Operators.Indexer<CqlDate>(hzzzc_, hzzzd_);
                                CqlQuantity hzzzk_ = context.Operators.Quantity(30m, "days");
                                CqlDate hzzzl_ = context.Operators.Add(hzzzj_ as CqlDate, hzzzk_);
                                CqlInterval<CqlDate> hzzzm_ = context.Operators.Interval(hzzzg_, hzzzl_, true, true);
                                bool? hzzzn_ = context.Operators.In<CqlDate>(X, hzzzm_, default);
                                bool? hzzzo_ = context.Operators.Not(hzzzn_);

                                return hzzzo_;
                            };
                            IEnumerable<CqlDate> gzzzt_ = context.Operators.Where<CqlDate>(gzzzo_, gzzzs_);
                            int? gzzzv_ = context.Operators.Add(gzzzp_, 1);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzw_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, gzzzq_ as CqlDate, gzzzt_, gzzzv_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gzzzx_ = [
                                gzzzw_,
                            ];
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzy_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList)
                            {
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzp_()
                                {
                                    bool hzzzq_()
                                    {
                                        IEnumerable<CqlDate> hzzzr_ = SecondList?.NewList;
                                        int? hzzzs_ = SecondList?.IndexofNewDate;
                                        CqlDate hzzzt_ = context.Operators.Indexer<CqlDate>(hzzzr_, hzzzs_);

                                        return hzzzt_ is null;
                                    };
                                    if (hzzzq_())
                                    {
                                        return SecondList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> hzzzu_ = SecondList?.NewList;
                                        int? hzzzv_ = SecondList?.IndexofNewDate;
                                        CqlDate hzzzw_ = context.Operators.Indexer<CqlDate>(hzzzu_, hzzzv_);
                                        bool? hzzzy_(CqlDate X)
                                        {
                                            IEnumerable<CqlDate> izzzi_ = SecondList?.NewList;
                                            int? izzzj_ = SecondList?.IndexofNewDate;
                                            CqlDate izzzk_ = context.Operators.Indexer<CqlDate>(izzzi_, izzzj_);
                                            CqlQuantity izzzl_ = context.Operators.Quantity(1m, "day");
                                            CqlDate izzzm_ = context.Operators.Add(izzzk_ as CqlDate, izzzl_);
                                            CqlDate izzzp_ = context.Operators.Indexer<CqlDate>(izzzi_, izzzj_);
                                            CqlQuantity izzzq_ = context.Operators.Quantity(30m, "days");
                                            CqlDate izzzr_ = context.Operators.Add(izzzp_ as CqlDate, izzzq_);
                                            CqlInterval<CqlDate> izzzs_ = context.Operators.Interval(izzzm_, izzzr_, true, true);
                                            bool? izzzt_ = context.Operators.In<CqlDate>(X, izzzs_, default);
                                            bool? izzzu_ = context.Operators.Not(izzzt_);

                                            return izzzu_;
                                        };
                                        IEnumerable<CqlDate> hzzzz_ = context.Operators.Where<CqlDate>(hzzzu_, hzzzy_);
                                        int? izzzb_ = context.Operators.Add(hzzzv_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzc_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hzzzw_ as CqlDate, hzzzz_, izzzb_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] izzzd_ = [
                                            izzzc_,
                                        ];
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzze_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList)
                                        {
                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzv_()
                                            {
                                                bool izzzw_()
                                                {
                                                    IEnumerable<CqlDate> izzzx_ = ThirdList?.NewList;
                                                    int? izzzy_ = ThirdList?.IndexofNewDate;
                                                    CqlDate izzzz_ = context.Operators.Indexer<CqlDate>(izzzx_, izzzy_);

                                                    return izzzz_ is null;
                                                };
                                                if (izzzw_())
                                                {
                                                    return ThirdList;
                                                }
                                                else
                                                {
                                                    IEnumerable<CqlDate> jzzza_ = ThirdList?.NewList;
                                                    int? jzzzb_ = ThirdList?.IndexofNewDate;
                                                    CqlDate jzzzc_ = context.Operators.Indexer<CqlDate>(jzzza_, jzzzb_);
                                                    bool? jzzze_(CqlDate X)
                                                    {
                                                        IEnumerable<CqlDate> jzzzo_ = ThirdList?.NewList;
                                                        int? jzzzp_ = ThirdList?.IndexofNewDate;
                                                        CqlDate jzzzq_ = context.Operators.Indexer<CqlDate>(jzzzo_, jzzzp_);
                                                        CqlQuantity jzzzr_ = context.Operators.Quantity(1m, "day");
                                                        CqlDate jzzzs_ = context.Operators.Add(jzzzq_ as CqlDate, jzzzr_);
                                                        CqlDate jzzzv_ = context.Operators.Indexer<CqlDate>(jzzzo_, jzzzp_);
                                                        CqlQuantity jzzzw_ = context.Operators.Quantity(30m, "days");
                                                        CqlDate jzzzx_ = context.Operators.Add(jzzzv_ as CqlDate, jzzzw_);
                                                        CqlInterval<CqlDate> jzzzy_ = context.Operators.Interval(jzzzs_, jzzzx_, true, true);
                                                        bool? jzzzz_ = context.Operators.In<CqlDate>(X, jzzzy_, default);
                                                        bool? kzzza_ = context.Operators.Not(jzzzz_);

                                                        return kzzza_;
                                                    };
                                                    IEnumerable<CqlDate> jzzzf_ = context.Operators.Where<CqlDate>(jzzza_, jzzze_);
                                                    int? jzzzh_ = context.Operators.Add(jzzzb_, 1);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzi_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, jzzzc_ as CqlDate, jzzzf_, jzzzh_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] jzzzj_ = [
                                                        jzzzi_,
                                                    ];
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzk_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList)
                                                    {
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzb_()
                                                        {
                                                            bool kzzzc_()
                                                            {
                                                                IEnumerable<CqlDate> kzzzd_ = FourthList?.NewList;
                                                                int? kzzze_ = FourthList?.IndexofNewDate;
                                                                CqlDate kzzzf_ = context.Operators.Indexer<CqlDate>(kzzzd_, kzzze_);

                                                                return kzzzf_ is null;
                                                            };
                                                            if (kzzzc_())
                                                            {
                                                                return FourthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> kzzzg_ = FourthList?.NewList;
                                                                int? kzzzh_ = FourthList?.IndexofNewDate;
                                                                CqlDate kzzzi_ = context.Operators.Indexer<CqlDate>(kzzzg_, kzzzh_);
                                                                bool? kzzzk_(CqlDate X)
                                                                {
                                                                    IEnumerable<CqlDate> kzzzu_ = FourthList?.NewList;
                                                                    int? kzzzv_ = FourthList?.IndexofNewDate;
                                                                    CqlDate kzzzw_ = context.Operators.Indexer<CqlDate>(kzzzu_, kzzzv_);
                                                                    CqlQuantity kzzzx_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate kzzzy_ = context.Operators.Add(kzzzw_ as CqlDate, kzzzx_);
                                                                    CqlDate lzzzb_ = context.Operators.Indexer<CqlDate>(kzzzu_, kzzzv_);
                                                                    CqlQuantity lzzzc_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate lzzzd_ = context.Operators.Add(lzzzb_ as CqlDate, lzzzc_);
                                                                    CqlInterval<CqlDate> lzzze_ = context.Operators.Interval(kzzzy_, lzzzd_, true, true);
                                                                    bool? lzzzf_ = context.Operators.In<CqlDate>(X, lzzze_, default);
                                                                    bool? lzzzg_ = context.Operators.Not(lzzzf_);

                                                                    return lzzzg_;
                                                                };
                                                                IEnumerable<CqlDate> kzzzl_ = context.Operators.Where<CqlDate>(kzzzg_, kzzzk_);
                                                                int? kzzzn_ = context.Operators.Add(kzzzh_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzo_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, kzzzi_ as CqlDate, kzzzl_, kzzzn_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] kzzzp_ = [
                                                                    kzzzo_,
                                                                ];
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzq_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList)
                                                                {
                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzh_()
                                                                    {
                                                                        bool lzzzi_()
                                                                        {
                                                                            IEnumerable<CqlDate> lzzzj_ = FifthList?.NewList;
                                                                            int? lzzzk_ = FifthList?.IndexofNewDate;
                                                                            CqlDate lzzzl_ = context.Operators.Indexer<CqlDate>(lzzzj_, lzzzk_);

                                                                            return lzzzl_ is null;
                                                                        };
                                                                        if (lzzzi_())
                                                                        {
                                                                            return FifthList;
                                                                        }
                                                                        else
                                                                        {
                                                                            IEnumerable<CqlDate> lzzzm_ = FifthList?.NewList;
                                                                            int? lzzzn_ = FifthList?.IndexofNewDate;
                                                                            CqlDate lzzzo_ = context.Operators.Indexer<CqlDate>(lzzzm_, lzzzn_);
                                                                            bool? lzzzq_(CqlDate X)
                                                                            {
                                                                                IEnumerable<CqlDate> mzzza_ = FifthList?.NewList;
                                                                                int? mzzzb_ = FifthList?.IndexofNewDate;
                                                                                CqlDate mzzzc_ = context.Operators.Indexer<CqlDate>(mzzza_, mzzzb_);
                                                                                CqlQuantity mzzzd_ = context.Operators.Quantity(1m, "day");
                                                                                CqlDate mzzze_ = context.Operators.Add(mzzzc_ as CqlDate, mzzzd_);
                                                                                CqlDate mzzzh_ = context.Operators.Indexer<CqlDate>(mzzza_, mzzzb_);
                                                                                CqlQuantity mzzzi_ = context.Operators.Quantity(30m, "days");
                                                                                CqlDate mzzzj_ = context.Operators.Add(mzzzh_ as CqlDate, mzzzi_);
                                                                                CqlInterval<CqlDate> mzzzk_ = context.Operators.Interval(mzzze_, mzzzj_, true, true);
                                                                                bool? mzzzl_ = context.Operators.In<CqlDate>(X, mzzzk_, default);
                                                                                bool? mzzzm_ = context.Operators.Not(mzzzl_);

                                                                                return mzzzm_;
                                                                            };
                                                                            IEnumerable<CqlDate> lzzzr_ = context.Operators.Where<CqlDate>(lzzzm_, lzzzq_);
                                                                            int? lzzzt_ = context.Operators.Add(lzzzn_, 1);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, lzzzo_ as CqlDate, lzzzr_, lzzzt_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] lzzzv_ = [
                                                                                lzzzu_,
                                                                            ];
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzw_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList)
                                                                            {
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzn_()
                                                                                {
                                                                                    bool mzzzo_()
                                                                                    {
                                                                                        IEnumerable<CqlDate> mzzzp_ = SixthList?.NewList;
                                                                                        int? mzzzq_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate mzzzr_ = context.Operators.Indexer<CqlDate>(mzzzp_, mzzzq_);

                                                                                        return mzzzr_ is null;
                                                                                    };
                                                                                    if (mzzzo_())
                                                                                    {
                                                                                        return SixthList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> mzzzs_ = SixthList?.NewList;
                                                                                        int? mzzzt_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate mzzzu_ = context.Operators.Indexer<CqlDate>(mzzzs_, mzzzt_);
                                                                                        bool? mzzzw_(CqlDate X)
                                                                                        {
                                                                                            IEnumerable<CqlDate> nzzzg_ = SixthList?.NewList;
                                                                                            int? nzzzh_ = SixthList?.IndexofNewDate;
                                                                                            CqlDate nzzzi_ = context.Operators.Indexer<CqlDate>(nzzzg_, nzzzh_);
                                                                                            CqlQuantity nzzzj_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate nzzzk_ = context.Operators.Add(nzzzi_ as CqlDate, nzzzj_);
                                                                                            CqlDate nzzzn_ = context.Operators.Indexer<CqlDate>(nzzzg_, nzzzh_);
                                                                                            CqlQuantity nzzzo_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate nzzzp_ = context.Operators.Add(nzzzn_ as CqlDate, nzzzo_);
                                                                                            CqlInterval<CqlDate> nzzzq_ = context.Operators.Interval(nzzzk_, nzzzp_, true, true);
                                                                                            bool? nzzzr_ = context.Operators.In<CqlDate>(X, nzzzq_, default);
                                                                                            bool? nzzzs_ = context.Operators.Not(nzzzr_);

                                                                                            return nzzzs_;
                                                                                        };
                                                                                        IEnumerable<CqlDate> mzzzx_ = context.Operators.Where<CqlDate>(mzzzs_, mzzzw_);
                                                                                        int? mzzzz_ = context.Operators.Add(mzzzt_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzza_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, mzzzu_ as CqlDate, mzzzx_, mzzzz_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] nzzzb_ = [
                                                                                            nzzza_,
                                                                                        ];
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzc_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList)
                                                                                        {
                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzt_()
                                                                                            {
                                                                                                bool nzzzu_()
                                                                                                {
                                                                                                    IEnumerable<CqlDate> nzzzv_ = SeventhList?.NewList;
                                                                                                    int? nzzzw_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate nzzzx_ = context.Operators.Indexer<CqlDate>(nzzzv_, nzzzw_);

                                                                                                    return nzzzx_ is null;
                                                                                                };
                                                                                                if (nzzzu_())
                                                                                                {
                                                                                                    return SeventhList;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    IEnumerable<CqlDate> nzzzy_ = SeventhList?.NewList;
                                                                                                    int? nzzzz_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate ozzza_ = context.Operators.Indexer<CqlDate>(nzzzy_, nzzzz_);
                                                                                                    bool? ozzzc_(CqlDate X)
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> ozzzm_ = SeventhList?.NewList;
                                                                                                        int? ozzzn_ = SeventhList?.IndexofNewDate;
                                                                                                        CqlDate ozzzo_ = context.Operators.Indexer<CqlDate>(ozzzm_, ozzzn_);
                                                                                                        CqlQuantity ozzzp_ = context.Operators.Quantity(1m, "day");
                                                                                                        CqlDate ozzzq_ = context.Operators.Add(ozzzo_ as CqlDate, ozzzp_);
                                                                                                        CqlDate ozzzt_ = context.Operators.Indexer<CqlDate>(ozzzm_, ozzzn_);
                                                                                                        CqlQuantity ozzzu_ = context.Operators.Quantity(30m, "days");
                                                                                                        CqlDate ozzzv_ = context.Operators.Add(ozzzt_ as CqlDate, ozzzu_);
                                                                                                        CqlInterval<CqlDate> ozzzw_ = context.Operators.Interval(ozzzq_, ozzzv_, true, true);
                                                                                                        bool? ozzzx_ = context.Operators.In<CqlDate>(X, ozzzw_, default);
                                                                                                        bool? ozzzy_ = context.Operators.Not(ozzzx_);

                                                                                                        return ozzzy_;
                                                                                                    };
                                                                                                    IEnumerable<CqlDate> ozzzd_ = context.Operators.Where<CqlDate>(nzzzy_, ozzzc_);
                                                                                                    int? ozzzf_ = context.Operators.Add(nzzzz_, 1);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzg_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ozzza_ as CqlDate, ozzzd_, ozzzf_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ozzzh_ = [
                                                                                                        ozzzg_,
                                                                                                    ];
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzi_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList)
                                                                                                    {
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzz_()
                                                                                                        {
                                                                                                            bool pzzza_()
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> pzzzb_ = EighthList?.NewList;
                                                                                                                int? pzzzc_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate pzzzd_ = context.Operators.Indexer<CqlDate>(pzzzb_, pzzzc_);

                                                                                                                return pzzzd_ is null;
                                                                                                            };
                                                                                                            if (pzzza_())
                                                                                                            {
                                                                                                                return EighthList;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> pzzze_ = EighthList?.NewList;
                                                                                                                int? pzzzf_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate pzzzg_ = context.Operators.Indexer<CqlDate>(pzzze_, pzzzf_);
                                                                                                                bool? pzzzi_(CqlDate X)
                                                                                                                {
                                                                                                                    IEnumerable<CqlDate> pzzzs_ = EighthList?.NewList;
                                                                                                                    int? pzzzt_ = EighthList?.IndexofNewDate;
                                                                                                                    CqlDate pzzzu_ = context.Operators.Indexer<CqlDate>(pzzzs_, pzzzt_);
                                                                                                                    CqlQuantity pzzzv_ = context.Operators.Quantity(1m, "day");
                                                                                                                    CqlDate pzzzw_ = context.Operators.Add(pzzzu_ as CqlDate, pzzzv_);
                                                                                                                    CqlDate pzzzz_ = context.Operators.Indexer<CqlDate>(pzzzs_, pzzzt_);
                                                                                                                    CqlQuantity qzzza_ = context.Operators.Quantity(30m, "days");
                                                                                                                    CqlDate qzzzb_ = context.Operators.Add(pzzzz_ as CqlDate, qzzza_);
                                                                                                                    CqlInterval<CqlDate> qzzzc_ = context.Operators.Interval(pzzzw_, qzzzb_, true, true);
                                                                                                                    bool? qzzzd_ = context.Operators.In<CqlDate>(X, qzzzc_, default);
                                                                                                                    bool? qzzze_ = context.Operators.Not(qzzzd_);

                                                                                                                    return qzzze_;
                                                                                                                };
                                                                                                                IEnumerable<CqlDate> pzzzj_ = context.Operators.Where<CqlDate>(pzzze_, pzzzi_);
                                                                                                                int? pzzzl_ = context.Operators.Add(pzzzf_, 1);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzm_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, pzzzg_ as CqlDate, pzzzj_, pzzzl_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] pzzzn_ = [
                                                                                                                    pzzzm_,
                                                                                                                ];
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzo_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList)
                                                                                                                {
                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzf_()
                                                                                                                    {
                                                                                                                        bool qzzzg_()
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> qzzzh_ = NinethList?.NewList;
                                                                                                                            int? qzzzi_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate qzzzj_ = context.Operators.Indexer<CqlDate>(qzzzh_, qzzzi_);

                                                                                                                            return qzzzj_ is null;
                                                                                                                        };
                                                                                                                        if (qzzzg_())
                                                                                                                        {
                                                                                                                            return NinethList;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> qzzzk_ = NinethList?.NewList;
                                                                                                                            int? qzzzl_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate qzzzm_ = context.Operators.Indexer<CqlDate>(qzzzk_, qzzzl_);
                                                                                                                            bool? qzzzo_(CqlDate X)
                                                                                                                            {
                                                                                                                                IEnumerable<CqlDate> qzzzy_ = NinethList?.NewList;
                                                                                                                                int? qzzzz_ = NinethList?.IndexofNewDate;
                                                                                                                                CqlDate rzzza_ = context.Operators.Indexer<CqlDate>(qzzzy_, qzzzz_);
                                                                                                                                CqlQuantity rzzzb_ = context.Operators.Quantity(1m, "day");
                                                                                                                                CqlDate rzzzc_ = context.Operators.Add(rzzza_ as CqlDate, rzzzb_);
                                                                                                                                CqlDate rzzzf_ = context.Operators.Indexer<CqlDate>(qzzzy_, qzzzz_);
                                                                                                                                CqlQuantity rzzzg_ = context.Operators.Quantity(30m, "days");
                                                                                                                                CqlDate rzzzh_ = context.Operators.Add(rzzzf_ as CqlDate, rzzzg_);
                                                                                                                                CqlInterval<CqlDate> rzzzi_ = context.Operators.Interval(rzzzc_, rzzzh_, true, true);
                                                                                                                                bool? rzzzj_ = context.Operators.In<CqlDate>(X, rzzzi_, default);
                                                                                                                                bool? rzzzk_ = context.Operators.Not(rzzzj_);

                                                                                                                                return rzzzk_;
                                                                                                                            };
                                                                                                                            IEnumerable<CqlDate> qzzzp_ = context.Operators.Where<CqlDate>(qzzzk_, qzzzo_);
                                                                                                                            int? qzzzr_ = context.Operators.Add(qzzzl_, 1);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzs_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, qzzzm_ as CqlDate, qzzzp_, qzzzr_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] qzzzt_ = [
                                                                                                                                qzzzs_,
                                                                                                                            ];
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzu_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList)
                                                                                                                            {
                                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzl_()
                                                                                                                                {
                                                                                                                                    bool rzzzm_()
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> rzzzn_ = TenthList?.NewList;
                                                                                                                                        int? rzzzo_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate rzzzp_ = context.Operators.Indexer<CqlDate>(rzzzn_, rzzzo_);

                                                                                                                                        return rzzzp_ is null;
                                                                                                                                    };
                                                                                                                                    if (rzzzm_())
                                                                                                                                    {
                                                                                                                                        return TenthList;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> rzzzq_ = TenthList?.NewList;
                                                                                                                                        int? rzzzr_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate rzzzs_ = context.Operators.Indexer<CqlDate>(rzzzq_, rzzzr_);
                                                                                                                                        bool? rzzzu_(CqlDate X)
                                                                                                                                        {
                                                                                                                                            IEnumerable<CqlDate> szzze_ = TenthList?.NewList;
                                                                                                                                            int? szzzf_ = TenthList?.IndexofNewDate;
                                                                                                                                            CqlDate szzzg_ = context.Operators.Indexer<CqlDate>(szzze_, szzzf_);
                                                                                                                                            CqlQuantity szzzh_ = context.Operators.Quantity(1m, "day");
                                                                                                                                            CqlDate szzzi_ = context.Operators.Add(szzzg_ as CqlDate, szzzh_);
                                                                                                                                            CqlDate szzzl_ = context.Operators.Indexer<CqlDate>(szzze_, szzzf_);
                                                                                                                                            CqlQuantity szzzm_ = context.Operators.Quantity(30m, "days");
                                                                                                                                            CqlDate szzzn_ = context.Operators.Add(szzzl_ as CqlDate, szzzm_);
                                                                                                                                            CqlInterval<CqlDate> szzzo_ = context.Operators.Interval(szzzi_, szzzn_, true, true);
                                                                                                                                            bool? szzzp_ = context.Operators.In<CqlDate>(X, szzzo_, default);
                                                                                                                                            bool? szzzq_ = context.Operators.Not(szzzp_);

                                                                                                                                            return szzzq_;
                                                                                                                                        };
                                                                                                                                        IEnumerable<CqlDate> rzzzv_ = context.Operators.Where<CqlDate>(rzzzq_, rzzzu_);
                                                                                                                                        int? rzzzx_ = context.Operators.Add(rzzzr_, 1);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, rzzzs_ as CqlDate, rzzzv_, rzzzx_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] rzzzz_ = [
                                                                                                                                            rzzzy_,
                                                                                                                                        ];
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzza_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList)
                                                                                                                                        {
                                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzzr_()
                                                                                                                                            {
                                                                                                                                                bool szzzs_()
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> szzzt_ = EleventhList?.NewList;
                                                                                                                                                    int? szzzu_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate szzzv_ = context.Operators.Indexer<CqlDate>(szzzt_, szzzu_);

                                                                                                                                                    return szzzv_ is null;
                                                                                                                                                };
                                                                                                                                                if (szzzs_())
                                                                                                                                                {
                                                                                                                                                    return EleventhList;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> szzzw_ = EleventhList?.NewList;
                                                                                                                                                    int? szzzx_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate szzzy_ = context.Operators.Indexer<CqlDate>(szzzw_, szzzx_);
                                                                                                                                                    bool? tzzza_(CqlDate X)
                                                                                                                                                    {
                                                                                                                                                        IEnumerable<CqlDate> tzzzf_ = EleventhList?.NewList;
                                                                                                                                                        int? tzzzg_ = EleventhList?.IndexofNewDate;
                                                                                                                                                        CqlDate tzzzh_ = context.Operators.Indexer<CqlDate>(tzzzf_, tzzzg_);
                                                                                                                                                        CqlQuantity tzzzi_ = context.Operators.Quantity(1m, "day");
                                                                                                                                                        CqlDate tzzzj_ = context.Operators.Add(tzzzh_ as CqlDate, tzzzi_);
                                                                                                                                                        CqlDate tzzzm_ = context.Operators.Indexer<CqlDate>(tzzzf_, tzzzg_);
                                                                                                                                                        CqlQuantity tzzzn_ = context.Operators.Quantity(30m, "days");
                                                                                                                                                        CqlDate tzzzo_ = context.Operators.Add(tzzzm_ as CqlDate, tzzzn_);
                                                                                                                                                        CqlInterval<CqlDate> tzzzp_ = context.Operators.Interval(tzzzj_, tzzzo_, true, true);
                                                                                                                                                        bool? tzzzq_ = context.Operators.In<CqlDate>(X, tzzzp_, default);
                                                                                                                                                        bool? tzzzr_ = context.Operators.Not(tzzzq_);

                                                                                                                                                        return tzzzr_;
                                                                                                                                                    };
                                                                                                                                                    IEnumerable<CqlDate> tzzzb_ = context.Operators.Where<CqlDate>(szzzw_, tzzza_);
                                                                                                                                                    int? tzzzd_ = context.Operators.Add(szzzx_, 1);
                                                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzze_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, szzzy_ as CqlDate, tzzzb_, tzzzd_);

                                                                                                                                                    return tzzze_;
                                                                                                                                                }
                                                                                                                                            };

                                                                                                                                            return szzzr_();
                                                                                                                                        };
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> szzzb_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)rzzzz_, szzza_);
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> szzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(szzzb_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(szzzc_);

                                                                                                                                        return szzzd_;
                                                                                                                                    }
                                                                                                                                };

                                                                                                                                return rzzzl_();
                                                                                                                            };
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzzv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)qzzzt_, qzzzu_);
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzzv_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzzw_);

                                                                                                                            return qzzzx_;
                                                                                                                        }
                                                                                                                    };

                                                                                                                    return qzzzf_();
                                                                                                                };
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)pzzzn_, pzzzo_);
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzzp_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzzq_);

                                                                                                                return pzzzr_;
                                                                                                            }
                                                                                                        };

                                                                                                        return ozzzz_();
                                                                                                    };
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ozzzh_, ozzzi_);
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzj_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzk_);

                                                                                                    return ozzzl_;
                                                                                                }
                                                                                            };

                                                                                            return nzzzt_();
                                                                                        };
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> nzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)nzzzb_, nzzzc_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> nzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(nzzzd_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(nzzze_);

                                                                                        return nzzzf_;
                                                                                    }
                                                                                };

                                                                                return mzzzn_();
                                                                            };
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lzzzx_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)lzzzv_, lzzzw_);
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lzzzx_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lzzzy_);

                                                                            return lzzzz_;
                                                                        }
                                                                    };

                                                                    return lzzzh_();
                                                                };
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kzzzr_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)kzzzp_, kzzzq_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kzzzr_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kzzzs_);

                                                                return kzzzt_;
                                                            }
                                                        };

                                                        return kzzzb_();
                                                    };
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jzzzl_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)jzzzj_, jzzzk_);
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jzzzl_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jzzzm_);

                                                    return jzzzn_;
                                                }
                                            };

                                            return izzzv_();
                                        };
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> izzzf_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)izzzd_, izzze_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> izzzg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(izzzf_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(izzzg_);

                                        return izzzh_;
                                    }
                                };

                                return hzzzp_();
                            };
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gzzzx_, gzzzy_);
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hzzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gzzzz_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hzzza_);

                            return hzzzb_;
                        }
                    };

                    return gzzzj_();
                };
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fzzzr_, fzzzs_);
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fzzzt_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fzzzu_);

                return fzzzv_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fzzzg_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)fzzze_, fzzzf_);
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fzzzh_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fzzzg_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzi_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fzzzh_);

            return fzzzi_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ezzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?>)ezzzw_, ezzzx_);
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ezzzz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ezzzy_);
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ezzzz_);

        return fzzza_;
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
