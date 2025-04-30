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
        IEnumerable<Patient> jzzz_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient kzza_ = context.Operators.SingletonFrom<Patient>(jzzz_);

        return kzza_;
    }


    [CqlExpressionDefinition("Normalize Onset")]
    public CqlInterval<CqlDateTime> Normalize_Onset(CqlContext context, object onset)
    {
        CqlInterval<CqlDateTime> kzzb_()
        {
            if (onset is FhirDateTime)
            {
                CqlDateTime kzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, onset as FhirDateTime);
                CqlInterval<CqlDateTime> kzze_ = context.Operators.Interval(kzzc_, kzzc_, true, true);

                return kzze_;
            }
            else if (onset is Period)
            {
                FhirDateTime kzzf_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
                CqlDateTime kzzg_ = context.Operators.Convert<CqlDateTime>(kzzf_);
                FhirDateTime kzzh_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
                CqlDateTime kzzi_ = context.Operators.Convert<CqlDateTime>(kzzh_);
                CqlInterval<CqlDateTime> kzzj_ = context.Operators.Interval(kzzg_, kzzi_, true, true);

                return kzzj_;
            }
            else if (onset is FhirString)
            {
                CqlInterval<CqlDateTime> kzzk_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return kzzk_;
            }
            else
            {
                CqlInterval<CqlDate> kzzl_()
                {
                    if (onset is Age)
                    {
                        Patient kzzw_ = this.Patient(context);
                        Date kzzx_ = kzzw_?.BirthDateElement;
                        CqlDate kzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, kzzx_);
                        CqlQuantity kzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate lzza_ = context.Operators.Add(kzzy_, kzzz_);
                        Date lzzc_ = kzzw_?.BirthDateElement;
                        CqlDate lzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzc_);
                        CqlDate lzzf_ = context.Operators.Add(lzzd_, kzzz_);
                        CqlQuantity lzzg_ = context.Operators.Quantity(1m, "year");
                        CqlDate lzzh_ = context.Operators.Add(lzzf_, lzzg_);
                        CqlInterval<CqlDate> lzzi_ = context.Operators.Interval(lzza_, lzzh_, true, false);

                        return lzzi_;
                    }
                    else if (onset is Range)
                    {
                        Patient lzzj_ = this.Patient(context);
                        Date lzzk_ = lzzj_?.BirthDateElement;
                        CqlDate lzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzk_);
                        Quantity lzzm_ = (onset as Range)?.Low;
                        CqlQuantity lzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzm_);
                        CqlDate lzzo_ = context.Operators.Add(lzzl_, lzzn_);
                        Date lzzq_ = lzzj_?.BirthDateElement;
                        CqlDate lzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzq_);
                        Quantity lzzs_ = (onset as Range)?.High;
                        CqlQuantity lzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, lzzs_);
                        CqlDate lzzu_ = context.Operators.Add(lzzr_, lzzt_);
                        CqlQuantity lzzv_ = context.Operators.Quantity(1m, "year");
                        CqlDate lzzw_ = context.Operators.Add(lzzu_, lzzv_);
                        CqlInterval<CqlDate> lzzx_ = context.Operators.Interval(lzzo_, lzzw_, true, false);

                        return lzzx_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate kzzm_ = (kzzl_())?.low;
                CqlDateTime kzzn_ = context.Operators.ConvertDateToDateTime(kzzm_);
                CqlInterval<CqlDate> kzzo_()
                {
                    if (onset is Age)
                    {
                        Patient lzzy_ = this.Patient(context);
                        Date lzzz_ = lzzy_?.BirthDateElement;
                        CqlDate mzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, lzzz_);
                        CqlQuantity mzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate mzzc_ = context.Operators.Add(mzza_, mzzb_);
                        Date mzze_ = lzzy_?.BirthDateElement;
                        CqlDate mzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzze_);
                        CqlDate mzzh_ = context.Operators.Add(mzzf_, mzzb_);
                        CqlQuantity mzzi_ = context.Operators.Quantity(1m, "year");
                        CqlDate mzzj_ = context.Operators.Add(mzzh_, mzzi_);
                        CqlInterval<CqlDate> mzzk_ = context.Operators.Interval(mzzc_, mzzj_, true, false);

                        return mzzk_;
                    }
                    else if (onset is Range)
                    {
                        Patient mzzl_ = this.Patient(context);
                        Date mzzm_ = mzzl_?.BirthDateElement;
                        CqlDate mzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzzm_);
                        Quantity mzzo_ = (onset as Range)?.Low;
                        CqlQuantity mzzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzo_);
                        CqlDate mzzq_ = context.Operators.Add(mzzn_, mzzp_);
                        Date mzzs_ = mzzl_?.BirthDateElement;
                        CqlDate mzzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, mzzs_);
                        Quantity mzzu_ = (onset as Range)?.High;
                        CqlQuantity mzzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, mzzu_);
                        CqlDate mzzw_ = context.Operators.Add(mzzt_, mzzv_);
                        CqlQuantity mzzx_ = context.Operators.Quantity(1m, "year");
                        CqlDate mzzy_ = context.Operators.Add(mzzw_, mzzx_);
                        CqlInterval<CqlDate> mzzz_ = context.Operators.Interval(mzzq_, mzzy_, true, false);

                        return mzzz_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate kzzp_ = (kzzo_())?.high;
                CqlDateTime kzzq_ = context.Operators.ConvertDateToDateTime(kzzp_);
                CqlInterval<CqlDate> kzzr_()
                {
                    if (onset is Age)
                    {
                        Patient nzza_ = this.Patient(context);
                        Date nzzb_ = nzza_?.BirthDateElement;
                        CqlDate nzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzb_);
                        CqlQuantity nzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate nzze_ = context.Operators.Add(nzzc_, nzzd_);
                        Date nzzg_ = nzza_?.BirthDateElement;
                        CqlDate nzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzg_);
                        CqlDate nzzj_ = context.Operators.Add(nzzh_, nzzd_);
                        CqlQuantity nzzk_ = context.Operators.Quantity(1m, "year");
                        CqlDate nzzl_ = context.Operators.Add(nzzj_, nzzk_);
                        CqlInterval<CqlDate> nzzm_ = context.Operators.Interval(nzze_, nzzl_, true, false);

                        return nzzm_;
                    }
                    else if (onset is Range)
                    {
                        Patient nzzn_ = this.Patient(context);
                        Date nzzo_ = nzzn_?.BirthDateElement;
                        CqlDate nzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzo_);
                        Quantity nzzq_ = (onset as Range)?.Low;
                        CqlQuantity nzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzzq_);
                        CqlDate nzzs_ = context.Operators.Add(nzzp_, nzzr_);
                        Date nzzu_ = nzzn_?.BirthDateElement;
                        CqlDate nzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzu_);
                        Quantity nzzw_ = (onset as Range)?.High;
                        CqlQuantity nzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzzw_);
                        CqlDate nzzy_ = context.Operators.Add(nzzv_, nzzx_);
                        CqlQuantity nzzz_ = context.Operators.Quantity(1m, "year");
                        CqlDate ozza_ = context.Operators.Add(nzzy_, nzzz_);
                        CqlInterval<CqlDate> ozzb_ = context.Operators.Interval(nzzs_, ozza_, true, false);

                        return ozzb_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? kzzs_ = (kzzr_())?.lowClosed;
                CqlInterval<CqlDate> kzzt_()
                {
                    if (onset is Age)
                    {
                        Patient ozzc_ = this.Patient(context);
                        Date ozzd_ = ozzc_?.BirthDateElement;
                        CqlDate ozze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzd_);
                        CqlQuantity ozzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate ozzg_ = context.Operators.Add(ozze_, ozzf_);
                        Date ozzi_ = ozzc_?.BirthDateElement;
                        CqlDate ozzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzi_);
                        CqlDate ozzl_ = context.Operators.Add(ozzj_, ozzf_);
                        CqlQuantity ozzm_ = context.Operators.Quantity(1m, "year");
                        CqlDate ozzn_ = context.Operators.Add(ozzl_, ozzm_);
                        CqlInterval<CqlDate> ozzo_ = context.Operators.Interval(ozzg_, ozzn_, true, false);

                        return ozzo_;
                    }
                    else if (onset is Range)
                    {
                        Patient ozzp_ = this.Patient(context);
                        Date ozzq_ = ozzp_?.BirthDateElement;
                        CqlDate ozzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzq_);
                        Quantity ozzs_ = (onset as Range)?.Low;
                        CqlQuantity ozzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ozzs_);
                        CqlDate ozzu_ = context.Operators.Add(ozzr_, ozzt_);
                        Date ozzw_ = ozzp_?.BirthDateElement;
                        CqlDate ozzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzw_);
                        Quantity ozzy_ = (onset as Range)?.High;
                        CqlQuantity ozzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ozzy_);
                        CqlDate pzza_ = context.Operators.Add(ozzx_, ozzz_);
                        CqlQuantity pzzb_ = context.Operators.Quantity(1m, "year");
                        CqlDate pzzc_ = context.Operators.Add(pzza_, pzzb_);
                        CqlInterval<CqlDate> pzzd_ = context.Operators.Interval(ozzu_, pzzc_, true, false);

                        return pzzd_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? kzzu_ = (kzzt_())?.highClosed;
                CqlInterval<CqlDateTime> kzzv_ = context.Operators.Interval(kzzn_, kzzq_, kzzs_, kzzu_);

                return kzzv_;
            }
        };

        return kzzb_();
    }


    [CqlExpressionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {
        CqlInterval<CqlDateTime> pzze_()
        {
            if (abatement is FhirDateTime)
            {
                CqlDateTime pzzf_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, abatement as FhirDateTime);
                CqlInterval<CqlDateTime> pzzh_ = context.Operators.Interval(pzzf_, pzzf_, true, true);

                return pzzh_;
            }
            else if (abatement is Period)
            {
                FhirDateTime pzzi_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
                CqlDateTime pzzj_ = context.Operators.Convert<CqlDateTime>(pzzi_);
                FhirDateTime pzzk_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
                CqlDateTime pzzl_ = context.Operators.Convert<CqlDateTime>(pzzk_);
                CqlInterval<CqlDateTime> pzzm_ = context.Operators.Interval(pzzj_, pzzl_, true, true);

                return pzzm_;
            }
            else if (abatement is FhirString)
            {
                CqlInterval<CqlDateTime> pzzn_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return pzzn_;
            }
            else
            {
                CqlInterval<CqlDate> pzzo_()
                {
                    if (abatement is Age)
                    {
                        Patient pzzz_ = this.Patient(context);
                        Date qzza_ = pzzz_?.BirthDateElement;
                        CqlDate qzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzza_);
                        CqlQuantity qzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate qzzd_ = context.Operators.Add(qzzb_, qzzc_);
                        Date qzzf_ = pzzz_?.BirthDateElement;
                        CqlDate qzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzf_);
                        CqlDate qzzi_ = context.Operators.Add(qzzg_, qzzc_);
                        CqlQuantity qzzj_ = context.Operators.Quantity(1m, "year");
                        CqlDate qzzk_ = context.Operators.Add(qzzi_, qzzj_);
                        CqlInterval<CqlDate> qzzl_ = context.Operators.Interval(qzzd_, qzzk_, true, false);

                        return qzzl_;
                    }
                    else if (abatement is Range)
                    {
                        Patient qzzm_ = this.Patient(context);
                        Date qzzn_ = qzzm_?.BirthDateElement;
                        CqlDate qzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzn_);
                        Quantity qzzp_ = (abatement as Range)?.Low;
                        CqlQuantity qzzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzp_);
                        CqlDate qzzr_ = context.Operators.Add(qzzo_, qzzq_);
                        Date qzzt_ = qzzm_?.BirthDateElement;
                        CqlDate qzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzt_);
                        Quantity qzzv_ = (abatement as Range)?.High;
                        CqlQuantity qzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzv_);
                        CqlDate qzzx_ = context.Operators.Add(qzzu_, qzzw_);
                        CqlQuantity qzzy_ = context.Operators.Quantity(1m, "year");
                        CqlDate qzzz_ = context.Operators.Add(qzzx_, qzzy_);
                        CqlInterval<CqlDate> rzza_ = context.Operators.Interval(qzzr_, qzzz_, true, false);

                        return rzza_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate pzzp_ = (pzzo_())?.low;
                CqlDateTime pzzq_ = context.Operators.ConvertDateToDateTime(pzzp_);
                CqlInterval<CqlDate> pzzr_()
                {
                    if (abatement is Age)
                    {
                        Patient rzzb_ = this.Patient(context);
                        Date rzzc_ = rzzb_?.BirthDateElement;
                        CqlDate rzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzc_);
                        CqlQuantity rzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate rzzf_ = context.Operators.Add(rzzd_, rzze_);
                        Date rzzh_ = rzzb_?.BirthDateElement;
                        CqlDate rzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzh_);
                        CqlDate rzzk_ = context.Operators.Add(rzzi_, rzze_);
                        CqlQuantity rzzl_ = context.Operators.Quantity(1m, "year");
                        CqlDate rzzm_ = context.Operators.Add(rzzk_, rzzl_);
                        CqlInterval<CqlDate> rzzn_ = context.Operators.Interval(rzzf_, rzzm_, true, false);

                        return rzzn_;
                    }
                    else if (abatement is Range)
                    {
                        Patient rzzo_ = this.Patient(context);
                        Date rzzp_ = rzzo_?.BirthDateElement;
                        CqlDate rzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzp_);
                        Quantity rzzr_ = (abatement as Range)?.Low;
                        CqlQuantity rzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzzr_);
                        CqlDate rzzt_ = context.Operators.Add(rzzq_, rzzs_);
                        Date rzzv_ = rzzo_?.BirthDateElement;
                        CqlDate rzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzv_);
                        Quantity rzzx_ = (abatement as Range)?.High;
                        CqlQuantity rzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzzx_);
                        CqlDate rzzz_ = context.Operators.Add(rzzw_, rzzy_);
                        CqlQuantity szza_ = context.Operators.Quantity(1m, "year");
                        CqlDate szzb_ = context.Operators.Add(rzzz_, szza_);
                        CqlInterval<CqlDate> szzc_ = context.Operators.Interval(rzzt_, szzb_, true, false);

                        return szzc_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate pzzs_ = (pzzr_())?.high;
                CqlDateTime pzzt_ = context.Operators.ConvertDateToDateTime(pzzs_);
                CqlInterval<CqlDate> pzzu_()
                {
                    if (abatement is Age)
                    {
                        Patient szzd_ = this.Patient(context);
                        Date szze_ = szzd_?.BirthDateElement;
                        CqlDate szzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szze_);
                        CqlQuantity szzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate szzh_ = context.Operators.Add(szzf_, szzg_);
                        Date szzj_ = szzd_?.BirthDateElement;
                        CqlDate szzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzj_);
                        CqlDate szzm_ = context.Operators.Add(szzk_, szzg_);
                        CqlQuantity szzn_ = context.Operators.Quantity(1m, "year");
                        CqlDate szzo_ = context.Operators.Add(szzm_, szzn_);
                        CqlInterval<CqlDate> szzp_ = context.Operators.Interval(szzh_, szzo_, true, false);

                        return szzp_;
                    }
                    else if (abatement is Range)
                    {
                        Patient szzq_ = this.Patient(context);
                        Date szzr_ = szzq_?.BirthDateElement;
                        CqlDate szzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzr_);
                        Quantity szzt_ = (abatement as Range)?.Low;
                        CqlQuantity szzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, szzt_);
                        CqlDate szzv_ = context.Operators.Add(szzs_, szzu_);
                        Date szzx_ = szzq_?.BirthDateElement;
                        CqlDate szzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzx_);
                        Quantity szzz_ = (abatement as Range)?.High;
                        CqlQuantity tzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, szzz_);
                        CqlDate tzzb_ = context.Operators.Add(szzy_, tzza_);
                        CqlQuantity tzzc_ = context.Operators.Quantity(1m, "year");
                        CqlDate tzzd_ = context.Operators.Add(tzzb_, tzzc_);
                        CqlInterval<CqlDate> tzze_ = context.Operators.Interval(szzv_, tzzd_, true, false);

                        return tzze_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? pzzv_ = (pzzu_())?.lowClosed;
                CqlInterval<CqlDate> pzzw_()
                {
                    if (abatement is Age)
                    {
                        Patient tzzf_ = this.Patient(context);
                        Date tzzg_ = tzzf_?.BirthDateElement;
                        CqlDate tzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzg_);
                        CqlQuantity tzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate tzzj_ = context.Operators.Add(tzzh_, tzzi_);
                        Date tzzl_ = tzzf_?.BirthDateElement;
                        CqlDate tzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzl_);
                        CqlDate tzzo_ = context.Operators.Add(tzzm_, tzzi_);
                        CqlQuantity tzzp_ = context.Operators.Quantity(1m, "year");
                        CqlDate tzzq_ = context.Operators.Add(tzzo_, tzzp_);
                        CqlInterval<CqlDate> tzzr_ = context.Operators.Interval(tzzj_, tzzq_, true, false);

                        return tzzr_;
                    }
                    else if (abatement is Range)
                    {
                        Patient tzzs_ = this.Patient(context);
                        Date tzzt_ = tzzs_?.BirthDateElement;
                        CqlDate tzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzt_);
                        Quantity tzzv_ = (abatement as Range)?.Low;
                        CqlQuantity tzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, tzzv_);
                        CqlDate tzzx_ = context.Operators.Add(tzzu_, tzzw_);
                        Date tzzz_ = tzzs_?.BirthDateElement;
                        CqlDate uzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzz_);
                        Quantity uzzb_ = (abatement as Range)?.High;
                        CqlQuantity uzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzb_);
                        CqlDate uzzd_ = context.Operators.Add(uzza_, uzzc_);
                        CqlQuantity uzze_ = context.Operators.Quantity(1m, "year");
                        CqlDate uzzf_ = context.Operators.Add(uzzd_, uzze_);
                        CqlInterval<CqlDate> uzzg_ = context.Operators.Interval(tzzx_, uzzf_, true, false);

                        return uzzg_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? pzzx_ = (pzzw_())?.highClosed;
                CqlInterval<CqlDateTime> pzzy_ = context.Operators.Interval(pzzq_, pzzt_, pzzv_, pzzx_);

                return pzzy_;
            }
        };

        return pzze_();
    }


    [CqlExpressionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        DataType uzzh_ = condition?.Onset;
        CqlInterval<CqlDateTime> uzzi_ = this.Normalize_Onset(context, uzzh_);
        CqlDateTime uzzj_ = context.Operators.Start(uzzi_);
        DataType uzzk_ = condition?.Abatement;
        CqlInterval<CqlDateTime> uzzl_ = this.Normalize_Abatement(context, uzzk_);
        CqlDateTime uzzm_ = context.Operators.End(uzzl_);
        CqlInterval<CqlDateTime> uzzn_ = context.Operators.Interval(uzzj_, uzzm_, true, true);

        return uzzn_;
    }


    [CqlExpressionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> uzzo_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime uzzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> uzzr_ = context.Operators.Interval(uzzp_, uzzp_, true, true);

                return uzzr_;
            }
            else if (choice is Date)
            {
                CqlDate uzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
                CqlDateTime uzzt_ = context.Operators.ConvertDateToDateTime(uzzs_);
                CqlDateTime uzzv_ = context.Operators.ConvertDateToDateTime(uzzs_);
                CqlInterval<CqlDateTime> uzzw_ = context.Operators.Interval(uzzt_, uzzv_, true, true);

                return uzzw_;
            }
            else if (choice is Period)
            {
                FhirDateTime uzzx_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
                CqlDateTime uzzy_ = context.Operators.Convert<CqlDateTime>(uzzx_);
                FhirDateTime uzzz_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
                CqlDateTime vzza_ = context.Operators.Convert<CqlDateTime>(uzzz_);
                CqlInterval<CqlDateTime> vzzb_ = context.Operators.Interval(uzzy_, vzza_, true, true);

                return vzzb_;
            }
            else if (choice is Instant)
            {
                CqlDateTime vzzc_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> vzze_ = context.Operators.Interval(vzzc_, vzzc_, true, true);

                return vzze_;
            }
            else if (choice is Age)
            {
                Patient vzzf_ = this.Patient(context);
                Date vzzg_ = vzzf_?.BirthDateElement;
                CqlDate vzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzg_);
                CqlQuantity vzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate vzzj_ = context.Operators.Add(vzzh_, vzzi_);
                Date vzzl_ = vzzf_?.BirthDateElement;
                CqlDate vzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzl_);
                CqlDate vzzo_ = context.Operators.Add(vzzm_, vzzi_);
                CqlQuantity vzzp_ = context.Operators.Quantity(1m, "year");
                CqlDate vzzq_ = context.Operators.Add(vzzo_, vzzp_);
                CqlInterval<CqlDate> vzzr_ = context.Operators.Interval(vzzj_, vzzq_, true, false);
                CqlDate vzzs_ = vzzr_?.low;
                CqlDateTime vzzt_ = context.Operators.ConvertDateToDateTime(vzzs_);
                Date vzzv_ = vzzf_?.BirthDateElement;
                CqlDate vzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzv_);
                CqlDate vzzy_ = context.Operators.Add(vzzw_, vzzi_);
                Date wzza_ = vzzf_?.BirthDateElement;
                CqlDate wzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzza_);
                CqlDate wzzd_ = context.Operators.Add(wzzb_, vzzi_);
                CqlDate wzzf_ = context.Operators.Add(wzzd_, vzzp_);
                CqlInterval<CqlDate> wzzg_ = context.Operators.Interval(vzzy_, wzzf_, true, false);
                CqlDate wzzh_ = wzzg_?.high;
                CqlDateTime wzzi_ = context.Operators.ConvertDateToDateTime(wzzh_);
                Date wzzk_ = vzzf_?.BirthDateElement;
                CqlDate wzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzk_);
                CqlDate wzzn_ = context.Operators.Add(wzzl_, vzzi_);
                Date wzzp_ = vzzf_?.BirthDateElement;
                CqlDate wzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzp_);
                CqlDate wzzs_ = context.Operators.Add(wzzq_, vzzi_);
                CqlDate wzzu_ = context.Operators.Add(wzzs_, vzzp_);
                CqlInterval<CqlDate> wzzv_ = context.Operators.Interval(wzzn_, wzzu_, true, false);
                bool? wzzw_ = wzzv_?.lowClosed;
                Date wzzy_ = vzzf_?.BirthDateElement;
                CqlDate wzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzy_);
                CqlDate xzzb_ = context.Operators.Add(wzzz_, vzzi_);
                Date xzzd_ = vzzf_?.BirthDateElement;
                CqlDate xzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzd_);
                CqlDate xzzg_ = context.Operators.Add(xzze_, vzzi_);
                CqlDate xzzi_ = context.Operators.Add(xzzg_, vzzp_);
                CqlInterval<CqlDate> xzzj_ = context.Operators.Interval(xzzb_, xzzi_, true, false);
                bool? xzzk_ = xzzj_?.highClosed;
                CqlInterval<CqlDateTime> xzzl_ = context.Operators.Interval(vzzt_, wzzi_, wzzw_, xzzk_);

                return xzzl_;
            }
            else if (choice is Range)
            {
                Patient xzzm_ = this.Patient(context);
                Date xzzn_ = xzzm_?.BirthDateElement;
                CqlDate xzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzn_);
                Quantity xzzp_ = (choice as Range)?.Low;
                CqlQuantity xzzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzp_);
                CqlDate xzzr_ = context.Operators.Add(xzzo_, xzzq_);
                Date xzzt_ = xzzm_?.BirthDateElement;
                CqlDate xzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzt_);
                Quantity xzzv_ = (choice as Range)?.High;
                CqlQuantity xzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzv_);
                CqlDate xzzx_ = context.Operators.Add(xzzu_, xzzw_);
                CqlQuantity xzzy_ = context.Operators.Quantity(1m, "year");
                CqlDate xzzz_ = context.Operators.Add(xzzx_, xzzy_);
                CqlInterval<CqlDate> yzza_ = context.Operators.Interval(xzzr_, xzzz_, true, false);
                CqlDate yzzb_ = yzza_?.low;
                CqlDateTime yzzc_ = context.Operators.ConvertDateToDateTime(yzzb_);
                Date yzze_ = xzzm_?.BirthDateElement;
                CqlDate yzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzze_);
                CqlQuantity yzzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzp_);
                CqlDate yzzi_ = context.Operators.Add(yzzf_, yzzh_);
                Date yzzk_ = xzzm_?.BirthDateElement;
                CqlDate yzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzk_);
                CqlQuantity yzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzv_);
                CqlDate yzzo_ = context.Operators.Add(yzzl_, yzzn_);
                CqlDate yzzq_ = context.Operators.Add(yzzo_, xzzy_);
                CqlInterval<CqlDate> yzzr_ = context.Operators.Interval(yzzi_, yzzq_, true, false);
                CqlDate yzzs_ = yzzr_?.high;
                CqlDateTime yzzt_ = context.Operators.ConvertDateToDateTime(yzzs_);
                Date yzzv_ = xzzm_?.BirthDateElement;
                CqlDate yzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzv_);
                CqlQuantity yzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzp_);
                CqlDate yzzz_ = context.Operators.Add(yzzw_, yzzy_);
                Date zzzb_ = xzzm_?.BirthDateElement;
                CqlDate zzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzb_);
                CqlQuantity zzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzv_);
                CqlDate zzzf_ = context.Operators.Add(zzzc_, zzze_);
                CqlDate zzzh_ = context.Operators.Add(zzzf_, xzzy_);
                CqlInterval<CqlDate> zzzi_ = context.Operators.Interval(yzzz_, zzzh_, true, false);
                bool? zzzj_ = zzzi_?.lowClosed;
                Date zzzl_ = xzzm_?.BirthDateElement;
                CqlDate zzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzl_);
                CqlQuantity zzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzp_);
                CqlDate zzzp_ = context.Operators.Add(zzzm_, zzzo_);
                Date zzzr_ = xzzm_?.BirthDateElement;
                CqlDate zzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzr_);
                CqlQuantity zzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzv_);
                CqlDate zzzv_ = context.Operators.Add(zzzs_, zzzu_);
                CqlDate zzzx_ = context.Operators.Add(zzzv_, xzzy_);
                CqlInterval<CqlDate> zzzy_ = context.Operators.Interval(zzzp_, zzzx_, true, false);
                bool? zzzz_ = zzzy_?.highClosed;
                CqlInterval<CqlDateTime> azzza_ = context.Operators.Interval(yzzc_, yzzt_, zzzj_, zzzz_);

                return azzza_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> azzzb_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return azzzb_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> azzzc_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return azzzc_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return uzzo_();
    }


    [CqlExpressionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        string azzzd_()
        {
            bool azzze_()
            {
                int? azzzf_ = context.Operators.PositionOf("/", uri);
                bool? azzzg_ = context.Operators.Greater(azzzf_, 0);

                return azzzg_ ?? false;
            };
            if (azzze_())
            {
                IEnumerable<string> azzzh_ = context.Operators.Split(uri, "/");
                string azzzi_ = context.Operators.Last<string>(azzzh_);

                return azzzi_;
            }
            else
            {
                return uri;
            }
        };

        return azzzd_();
    }


    [CqlExpressionDefinition("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) =>
        VSet;


    [CqlExpressionDefinition("First Dates per 31 Day Periods")]
    public (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
    {
        CqlDate azzzj_(CqlDate d) =>
            d;
        IEnumerable<CqlDate> azzzk_ = context.Operators.Select<CqlDate, CqlDate>(DateList, azzzj_);
        IEnumerable<CqlDate> azzzl_ = context.Operators.Distinct<CqlDate>(azzzk_);
        IEnumerable<CqlDate> azzzm_ = context.Operators.ListSort<CqlDate>(azzzl_, System.ComponentModel.ListSortDirection.Ascending);
        bool? azzzn_(CqlDate X)
        {
            bool? azzzv_ = context.Operators.Not((bool?)(X is null));

            return azzzv_;
        };
        IEnumerable<CqlDate> azzzo_ = context.Operators.Where<CqlDate>(azzzm_, azzzn_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? azzzp_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, azzzo_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] azzzq_ = [
            azzzp_,
        ];
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzzr_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates)
        {
            IEnumerable<CqlDate> azzzw_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? azzzx_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, azzzw_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] azzzy_ = [
                azzzx_,
            ];
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzzz_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList)
            {
                IEnumerable<CqlDate> bzzzd_ = AnchorList?.SortedList;
                int? bzzze_ = AnchorList?.AnchorIndex;
                CqlDate bzzzf_ = context.Operators.Indexer<CqlDate>(bzzzd_, bzzze_);
                bool? bzzzg_(CqlDate X)
                {
                    IEnumerable<CqlDate> bzzzq_ = AnchorList?.SortedList;
                    int? bzzzr_ = AnchorList?.AnchorIndex;
                    CqlDate bzzzs_ = context.Operators.Indexer<CqlDate>(bzzzq_, bzzzr_);
                    CqlQuantity bzzzt_ = context.Operators.Quantity(1m, "day");
                    CqlDate bzzzu_ = context.Operators.Add(bzzzs_ as CqlDate, bzzzt_);
                    CqlDate bzzzx_ = context.Operators.Indexer<CqlDate>(bzzzq_, bzzzr_);
                    CqlQuantity bzzzy_ = context.Operators.Quantity(30m, "days");
                    CqlDate bzzzz_ = context.Operators.Add(bzzzx_ as CqlDate, bzzzy_);
                    CqlInterval<CqlDate> czzza_ = context.Operators.Interval(bzzzu_, bzzzz_, true, true);
                    bool? czzzb_ = context.Operators.In<CqlDate>(X, czzza_, default);
                    bool? czzzc_ = context.Operators.Not(czzzb_);

                    return czzzc_;
                };
                IEnumerable<CqlDate> bzzzh_ = context.Operators.Where<CqlDate>(DateList, bzzzg_);
                int? bzzzj_ = context.Operators.Add(bzzze_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzk_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, bzzzf_ as CqlDate, bzzzh_, bzzzj_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] bzzzl_ = [
                    bzzzk_,
                ];
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzm_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList)
                {
                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzd_()
                    {
                        bool czzze_()
                        {
                            IEnumerable<CqlDate> czzzf_ = FirstList?.NewList;
                            int? czzzg_ = FirstList?.IndexofNewDate;
                            CqlDate czzzh_ = context.Operators.Indexer<CqlDate>(czzzf_, czzzg_);

                            return czzzh_ is null;
                        };
                        if (czzze_())
                        {
                            return FirstList;
                        }
                        else
                        {
                            IEnumerable<CqlDate> czzzi_ = FirstList?.NewList;
                            int? czzzj_ = FirstList?.IndexofNewDate;
                            CqlDate czzzk_ = context.Operators.Indexer<CqlDate>(czzzi_, czzzj_);
                            bool? czzzm_(CqlDate X)
                            {
                                IEnumerable<CqlDate> czzzw_ = FirstList?.NewList;
                                int? czzzx_ = FirstList?.IndexofNewDate;
                                CqlDate czzzy_ = context.Operators.Indexer<CqlDate>(czzzw_, czzzx_);
                                CqlQuantity czzzz_ = context.Operators.Quantity(1m, "day");
                                CqlDate dzzza_ = context.Operators.Add(czzzy_ as CqlDate, czzzz_);
                                CqlDate dzzzd_ = context.Operators.Indexer<CqlDate>(czzzw_, czzzx_);
                                CqlQuantity dzzze_ = context.Operators.Quantity(30m, "days");
                                CqlDate dzzzf_ = context.Operators.Add(dzzzd_ as CqlDate, dzzze_);
                                CqlInterval<CqlDate> dzzzg_ = context.Operators.Interval(dzzza_, dzzzf_, true, true);
                                bool? dzzzh_ = context.Operators.In<CqlDate>(X, dzzzg_, default);
                                bool? dzzzi_ = context.Operators.Not(dzzzh_);

                                return dzzzi_;
                            };
                            IEnumerable<CqlDate> czzzn_ = context.Operators.Where<CqlDate>(czzzi_, czzzm_);
                            int? czzzp_ = context.Operators.Add(czzzj_, 1);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, czzzk_ as CqlDate, czzzn_, czzzp_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] czzzr_ = [
                                czzzq_,
                            ];
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzs_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList)
                            {
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzj_()
                                {
                                    bool dzzzk_()
                                    {
                                        IEnumerable<CqlDate> dzzzl_ = SecondList?.NewList;
                                        int? dzzzm_ = SecondList?.IndexofNewDate;
                                        CqlDate dzzzn_ = context.Operators.Indexer<CqlDate>(dzzzl_, dzzzm_);

                                        return dzzzn_ is null;
                                    };
                                    if (dzzzk_())
                                    {
                                        return SecondList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> dzzzo_ = SecondList?.NewList;
                                        int? dzzzp_ = SecondList?.IndexofNewDate;
                                        CqlDate dzzzq_ = context.Operators.Indexer<CqlDate>(dzzzo_, dzzzp_);
                                        bool? dzzzs_(CqlDate X)
                                        {
                                            IEnumerable<CqlDate> ezzzc_ = SecondList?.NewList;
                                            int? ezzzd_ = SecondList?.IndexofNewDate;
                                            CqlDate ezzze_ = context.Operators.Indexer<CqlDate>(ezzzc_, ezzzd_);
                                            CqlQuantity ezzzf_ = context.Operators.Quantity(1m, "day");
                                            CqlDate ezzzg_ = context.Operators.Add(ezzze_ as CqlDate, ezzzf_);
                                            CqlDate ezzzj_ = context.Operators.Indexer<CqlDate>(ezzzc_, ezzzd_);
                                            CqlQuantity ezzzk_ = context.Operators.Quantity(30m, "days");
                                            CqlDate ezzzl_ = context.Operators.Add(ezzzj_ as CqlDate, ezzzk_);
                                            CqlInterval<CqlDate> ezzzm_ = context.Operators.Interval(ezzzg_, ezzzl_, true, true);
                                            bool? ezzzn_ = context.Operators.In<CqlDate>(X, ezzzm_, default);
                                            bool? ezzzo_ = context.Operators.Not(ezzzn_);

                                            return ezzzo_;
                                        };
                                        IEnumerable<CqlDate> dzzzt_ = context.Operators.Where<CqlDate>(dzzzo_, dzzzs_);
                                        int? dzzzv_ = context.Operators.Add(dzzzp_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzw_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, dzzzq_ as CqlDate, dzzzt_, dzzzv_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] dzzzx_ = [
                                            dzzzw_,
                                        ];
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzy_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList)
                                        {
                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ezzzp_()
                                            {
                                                bool ezzzq_()
                                                {
                                                    IEnumerable<CqlDate> ezzzr_ = ThirdList?.NewList;
                                                    int? ezzzs_ = ThirdList?.IndexofNewDate;
                                                    CqlDate ezzzt_ = context.Operators.Indexer<CqlDate>(ezzzr_, ezzzs_);

                                                    return ezzzt_ is null;
                                                };
                                                if (ezzzq_())
                                                {
                                                    return ThirdList;
                                                }
                                                else
                                                {
                                                    IEnumerable<CqlDate> ezzzu_ = ThirdList?.NewList;
                                                    int? ezzzv_ = ThirdList?.IndexofNewDate;
                                                    CqlDate ezzzw_ = context.Operators.Indexer<CqlDate>(ezzzu_, ezzzv_);
                                                    bool? ezzzy_(CqlDate X)
                                                    {
                                                        IEnumerable<CqlDate> fzzzi_ = ThirdList?.NewList;
                                                        int? fzzzj_ = ThirdList?.IndexofNewDate;
                                                        CqlDate fzzzk_ = context.Operators.Indexer<CqlDate>(fzzzi_, fzzzj_);
                                                        CqlQuantity fzzzl_ = context.Operators.Quantity(1m, "day");
                                                        CqlDate fzzzm_ = context.Operators.Add(fzzzk_ as CqlDate, fzzzl_);
                                                        CqlDate fzzzp_ = context.Operators.Indexer<CqlDate>(fzzzi_, fzzzj_);
                                                        CqlQuantity fzzzq_ = context.Operators.Quantity(30m, "days");
                                                        CqlDate fzzzr_ = context.Operators.Add(fzzzp_ as CqlDate, fzzzq_);
                                                        CqlInterval<CqlDate> fzzzs_ = context.Operators.Interval(fzzzm_, fzzzr_, true, true);
                                                        bool? fzzzt_ = context.Operators.In<CqlDate>(X, fzzzs_, default);
                                                        bool? fzzzu_ = context.Operators.Not(fzzzt_);

                                                        return fzzzu_;
                                                    };
                                                    IEnumerable<CqlDate> ezzzz_ = context.Operators.Where<CqlDate>(ezzzu_, ezzzy_);
                                                    int? fzzzb_ = context.Operators.Add(ezzzv_, 1);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzc_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ezzzw_ as CqlDate, ezzzz_, fzzzb_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fzzzd_ = [
                                                        fzzzc_,
                                                    ];
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzze_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList)
                                                    {
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzv_()
                                                        {
                                                            bool fzzzw_()
                                                            {
                                                                IEnumerable<CqlDate> fzzzx_ = FourthList?.NewList;
                                                                int? fzzzy_ = FourthList?.IndexofNewDate;
                                                                CqlDate fzzzz_ = context.Operators.Indexer<CqlDate>(fzzzx_, fzzzy_);

                                                                return fzzzz_ is null;
                                                            };
                                                            if (fzzzw_())
                                                            {
                                                                return FourthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> gzzza_ = FourthList?.NewList;
                                                                int? gzzzb_ = FourthList?.IndexofNewDate;
                                                                CqlDate gzzzc_ = context.Operators.Indexer<CqlDate>(gzzza_, gzzzb_);
                                                                bool? gzzze_(CqlDate X)
                                                                {
                                                                    IEnumerable<CqlDate> gzzzo_ = FourthList?.NewList;
                                                                    int? gzzzp_ = FourthList?.IndexofNewDate;
                                                                    CqlDate gzzzq_ = context.Operators.Indexer<CqlDate>(gzzzo_, gzzzp_);
                                                                    CqlQuantity gzzzr_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate gzzzs_ = context.Operators.Add(gzzzq_ as CqlDate, gzzzr_);
                                                                    CqlDate gzzzv_ = context.Operators.Indexer<CqlDate>(gzzzo_, gzzzp_);
                                                                    CqlQuantity gzzzw_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate gzzzx_ = context.Operators.Add(gzzzv_ as CqlDate, gzzzw_);
                                                                    CqlInterval<CqlDate> gzzzy_ = context.Operators.Interval(gzzzs_, gzzzx_, true, true);
                                                                    bool? gzzzz_ = context.Operators.In<CqlDate>(X, gzzzy_, default);
                                                                    bool? hzzza_ = context.Operators.Not(gzzzz_);

                                                                    return hzzza_;
                                                                };
                                                                IEnumerable<CqlDate> gzzzf_ = context.Operators.Where<CqlDate>(gzzza_, gzzze_);
                                                                int? gzzzh_ = context.Operators.Add(gzzzb_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzi_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, gzzzc_ as CqlDate, gzzzf_, gzzzh_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gzzzj_ = [
                                                                    gzzzi_,
                                                                ];
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzk_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList)
                                                                {
                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzb_()
                                                                    {
                                                                        bool hzzzc_()
                                                                        {
                                                                            IEnumerable<CqlDate> hzzzd_ = FifthList?.NewList;
                                                                            int? hzzze_ = FifthList?.IndexofNewDate;
                                                                            CqlDate hzzzf_ = context.Operators.Indexer<CqlDate>(hzzzd_, hzzze_);

                                                                            return hzzzf_ is null;
                                                                        };
                                                                        if (hzzzc_())
                                                                        {
                                                                            return FifthList;
                                                                        }
                                                                        else
                                                                        {
                                                                            IEnumerable<CqlDate> hzzzg_ = FifthList?.NewList;
                                                                            int? hzzzh_ = FifthList?.IndexofNewDate;
                                                                            CqlDate hzzzi_ = context.Operators.Indexer<CqlDate>(hzzzg_, hzzzh_);
                                                                            bool? hzzzk_(CqlDate X)
                                                                            {
                                                                                IEnumerable<CqlDate> hzzzu_ = FifthList?.NewList;
                                                                                int? hzzzv_ = FifthList?.IndexofNewDate;
                                                                                CqlDate hzzzw_ = context.Operators.Indexer<CqlDate>(hzzzu_, hzzzv_);
                                                                                CqlQuantity hzzzx_ = context.Operators.Quantity(1m, "day");
                                                                                CqlDate hzzzy_ = context.Operators.Add(hzzzw_ as CqlDate, hzzzx_);
                                                                                CqlDate izzzb_ = context.Operators.Indexer<CqlDate>(hzzzu_, hzzzv_);
                                                                                CqlQuantity izzzc_ = context.Operators.Quantity(30m, "days");
                                                                                CqlDate izzzd_ = context.Operators.Add(izzzb_ as CqlDate, izzzc_);
                                                                                CqlInterval<CqlDate> izzze_ = context.Operators.Interval(hzzzy_, izzzd_, true, true);
                                                                                bool? izzzf_ = context.Operators.In<CqlDate>(X, izzze_, default);
                                                                                bool? izzzg_ = context.Operators.Not(izzzf_);

                                                                                return izzzg_;
                                                                            };
                                                                            IEnumerable<CqlDate> hzzzl_ = context.Operators.Where<CqlDate>(hzzzg_, hzzzk_);
                                                                            int? hzzzn_ = context.Operators.Add(hzzzh_, 1);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzo_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hzzzi_ as CqlDate, hzzzl_, hzzzn_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hzzzp_ = [
                                                                                hzzzo_,
                                                                            ];
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzq_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList)
                                                                            {
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzh_()
                                                                                {
                                                                                    bool izzzi_()
                                                                                    {
                                                                                        IEnumerable<CqlDate> izzzj_ = SixthList?.NewList;
                                                                                        int? izzzk_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate izzzl_ = context.Operators.Indexer<CqlDate>(izzzj_, izzzk_);

                                                                                        return izzzl_ is null;
                                                                                    };
                                                                                    if (izzzi_())
                                                                                    {
                                                                                        return SixthList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> izzzm_ = SixthList?.NewList;
                                                                                        int? izzzn_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate izzzo_ = context.Operators.Indexer<CqlDate>(izzzm_, izzzn_);
                                                                                        bool? izzzq_(CqlDate X)
                                                                                        {
                                                                                            IEnumerable<CqlDate> jzzza_ = SixthList?.NewList;
                                                                                            int? jzzzb_ = SixthList?.IndexofNewDate;
                                                                                            CqlDate jzzzc_ = context.Operators.Indexer<CqlDate>(jzzza_, jzzzb_);
                                                                                            CqlQuantity jzzzd_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate jzzze_ = context.Operators.Add(jzzzc_ as CqlDate, jzzzd_);
                                                                                            CqlDate jzzzh_ = context.Operators.Indexer<CqlDate>(jzzza_, jzzzb_);
                                                                                            CqlQuantity jzzzi_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate jzzzj_ = context.Operators.Add(jzzzh_ as CqlDate, jzzzi_);
                                                                                            CqlInterval<CqlDate> jzzzk_ = context.Operators.Interval(jzzze_, jzzzj_, true, true);
                                                                                            bool? jzzzl_ = context.Operators.In<CqlDate>(X, jzzzk_, default);
                                                                                            bool? jzzzm_ = context.Operators.Not(jzzzl_);

                                                                                            return jzzzm_;
                                                                                        };
                                                                                        IEnumerable<CqlDate> izzzr_ = context.Operators.Where<CqlDate>(izzzm_, izzzq_);
                                                                                        int? izzzt_ = context.Operators.Add(izzzn_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, izzzo_ as CqlDate, izzzr_, izzzt_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] izzzv_ = [
                                                                                            izzzu_,
                                                                                        ];
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzw_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList)
                                                                                        {
                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzn_()
                                                                                            {
                                                                                                bool jzzzo_()
                                                                                                {
                                                                                                    IEnumerable<CqlDate> jzzzp_ = SeventhList?.NewList;
                                                                                                    int? jzzzq_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate jzzzr_ = context.Operators.Indexer<CqlDate>(jzzzp_, jzzzq_);

                                                                                                    return jzzzr_ is null;
                                                                                                };
                                                                                                if (jzzzo_())
                                                                                                {
                                                                                                    return SeventhList;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    IEnumerable<CqlDate> jzzzs_ = SeventhList?.NewList;
                                                                                                    int? jzzzt_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate jzzzu_ = context.Operators.Indexer<CqlDate>(jzzzs_, jzzzt_);
                                                                                                    bool? jzzzw_(CqlDate X)
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> kzzzg_ = SeventhList?.NewList;
                                                                                                        int? kzzzh_ = SeventhList?.IndexofNewDate;
                                                                                                        CqlDate kzzzi_ = context.Operators.Indexer<CqlDate>(kzzzg_, kzzzh_);
                                                                                                        CqlQuantity kzzzj_ = context.Operators.Quantity(1m, "day");
                                                                                                        CqlDate kzzzk_ = context.Operators.Add(kzzzi_ as CqlDate, kzzzj_);
                                                                                                        CqlDate kzzzn_ = context.Operators.Indexer<CqlDate>(kzzzg_, kzzzh_);
                                                                                                        CqlQuantity kzzzo_ = context.Operators.Quantity(30m, "days");
                                                                                                        CqlDate kzzzp_ = context.Operators.Add(kzzzn_ as CqlDate, kzzzo_);
                                                                                                        CqlInterval<CqlDate> kzzzq_ = context.Operators.Interval(kzzzk_, kzzzp_, true, true);
                                                                                                        bool? kzzzr_ = context.Operators.In<CqlDate>(X, kzzzq_, default);
                                                                                                        bool? kzzzs_ = context.Operators.Not(kzzzr_);

                                                                                                        return kzzzs_;
                                                                                                    };
                                                                                                    IEnumerable<CqlDate> jzzzx_ = context.Operators.Where<CqlDate>(jzzzs_, jzzzw_);
                                                                                                    int? jzzzz_ = context.Operators.Add(jzzzt_, 1);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzza_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, jzzzu_ as CqlDate, jzzzx_, jzzzz_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] kzzzb_ = [
                                                                                                        kzzza_,
                                                                                                    ];
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzc_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList)
                                                                                                    {
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzt_()
                                                                                                        {
                                                                                                            bool kzzzu_()
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> kzzzv_ = EighthList?.NewList;
                                                                                                                int? kzzzw_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate kzzzx_ = context.Operators.Indexer<CqlDate>(kzzzv_, kzzzw_);

                                                                                                                return kzzzx_ is null;
                                                                                                            };
                                                                                                            if (kzzzu_())
                                                                                                            {
                                                                                                                return EighthList;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> kzzzy_ = EighthList?.NewList;
                                                                                                                int? kzzzz_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate lzzza_ = context.Operators.Indexer<CqlDate>(kzzzy_, kzzzz_);
                                                                                                                bool? lzzzc_(CqlDate X)
                                                                                                                {
                                                                                                                    IEnumerable<CqlDate> lzzzm_ = EighthList?.NewList;
                                                                                                                    int? lzzzn_ = EighthList?.IndexofNewDate;
                                                                                                                    CqlDate lzzzo_ = context.Operators.Indexer<CqlDate>(lzzzm_, lzzzn_);
                                                                                                                    CqlQuantity lzzzp_ = context.Operators.Quantity(1m, "day");
                                                                                                                    CqlDate lzzzq_ = context.Operators.Add(lzzzo_ as CqlDate, lzzzp_);
                                                                                                                    CqlDate lzzzt_ = context.Operators.Indexer<CqlDate>(lzzzm_, lzzzn_);
                                                                                                                    CqlQuantity lzzzu_ = context.Operators.Quantity(30m, "days");
                                                                                                                    CqlDate lzzzv_ = context.Operators.Add(lzzzt_ as CqlDate, lzzzu_);
                                                                                                                    CqlInterval<CqlDate> lzzzw_ = context.Operators.Interval(lzzzq_, lzzzv_, true, true);
                                                                                                                    bool? lzzzx_ = context.Operators.In<CqlDate>(X, lzzzw_, default);
                                                                                                                    bool? lzzzy_ = context.Operators.Not(lzzzx_);

                                                                                                                    return lzzzy_;
                                                                                                                };
                                                                                                                IEnumerable<CqlDate> lzzzd_ = context.Operators.Where<CqlDate>(kzzzy_, lzzzc_);
                                                                                                                int? lzzzf_ = context.Operators.Add(kzzzz_, 1);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzg_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, lzzza_ as CqlDate, lzzzd_, lzzzf_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] lzzzh_ = [
                                                                                                                    lzzzg_,
                                                                                                                ];
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzi_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList)
                                                                                                                {
                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzz_()
                                                                                                                    {
                                                                                                                        bool mzzza_()
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> mzzzb_ = NinethList?.NewList;
                                                                                                                            int? mzzzc_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate mzzzd_ = context.Operators.Indexer<CqlDate>(mzzzb_, mzzzc_);

                                                                                                                            return mzzzd_ is null;
                                                                                                                        };
                                                                                                                        if (mzzza_())
                                                                                                                        {
                                                                                                                            return NinethList;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> mzzze_ = NinethList?.NewList;
                                                                                                                            int? mzzzf_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate mzzzg_ = context.Operators.Indexer<CqlDate>(mzzze_, mzzzf_);
                                                                                                                            bool? mzzzi_(CqlDate X)
                                                                                                                            {
                                                                                                                                IEnumerable<CqlDate> mzzzs_ = NinethList?.NewList;
                                                                                                                                int? mzzzt_ = NinethList?.IndexofNewDate;
                                                                                                                                CqlDate mzzzu_ = context.Operators.Indexer<CqlDate>(mzzzs_, mzzzt_);
                                                                                                                                CqlQuantity mzzzv_ = context.Operators.Quantity(1m, "day");
                                                                                                                                CqlDate mzzzw_ = context.Operators.Add(mzzzu_ as CqlDate, mzzzv_);
                                                                                                                                CqlDate mzzzz_ = context.Operators.Indexer<CqlDate>(mzzzs_, mzzzt_);
                                                                                                                                CqlQuantity nzzza_ = context.Operators.Quantity(30m, "days");
                                                                                                                                CqlDate nzzzb_ = context.Operators.Add(mzzzz_ as CqlDate, nzzza_);
                                                                                                                                CqlInterval<CqlDate> nzzzc_ = context.Operators.Interval(mzzzw_, nzzzb_, true, true);
                                                                                                                                bool? nzzzd_ = context.Operators.In<CqlDate>(X, nzzzc_, default);
                                                                                                                                bool? nzzze_ = context.Operators.Not(nzzzd_);

                                                                                                                                return nzzze_;
                                                                                                                            };
                                                                                                                            IEnumerable<CqlDate> mzzzj_ = context.Operators.Where<CqlDate>(mzzze_, mzzzi_);
                                                                                                                            int? mzzzl_ = context.Operators.Add(mzzzf_, 1);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzm_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, mzzzg_ as CqlDate, mzzzj_, mzzzl_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] mzzzn_ = [
                                                                                                                                mzzzm_,
                                                                                                                            ];
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzo_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList)
                                                                                                                            {
                                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzf_()
                                                                                                                                {
                                                                                                                                    bool nzzzg_()
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> nzzzh_ = TenthList?.NewList;
                                                                                                                                        int? nzzzi_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate nzzzj_ = context.Operators.Indexer<CqlDate>(nzzzh_, nzzzi_);

                                                                                                                                        return nzzzj_ is null;
                                                                                                                                    };
                                                                                                                                    if (nzzzg_())
                                                                                                                                    {
                                                                                                                                        return TenthList;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> nzzzk_ = TenthList?.NewList;
                                                                                                                                        int? nzzzl_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate nzzzm_ = context.Operators.Indexer<CqlDate>(nzzzk_, nzzzl_);
                                                                                                                                        bool? nzzzo_(CqlDate X)
                                                                                                                                        {
                                                                                                                                            IEnumerable<CqlDate> nzzzy_ = TenthList?.NewList;
                                                                                                                                            int? nzzzz_ = TenthList?.IndexofNewDate;
                                                                                                                                            CqlDate ozzza_ = context.Operators.Indexer<CqlDate>(nzzzy_, nzzzz_);
                                                                                                                                            CqlQuantity ozzzb_ = context.Operators.Quantity(1m, "day");
                                                                                                                                            CqlDate ozzzc_ = context.Operators.Add(ozzza_ as CqlDate, ozzzb_);
                                                                                                                                            CqlDate ozzzf_ = context.Operators.Indexer<CqlDate>(nzzzy_, nzzzz_);
                                                                                                                                            CqlQuantity ozzzg_ = context.Operators.Quantity(30m, "days");
                                                                                                                                            CqlDate ozzzh_ = context.Operators.Add(ozzzf_ as CqlDate, ozzzg_);
                                                                                                                                            CqlInterval<CqlDate> ozzzi_ = context.Operators.Interval(ozzzc_, ozzzh_, true, true);
                                                                                                                                            bool? ozzzj_ = context.Operators.In<CqlDate>(X, ozzzi_, default);
                                                                                                                                            bool? ozzzk_ = context.Operators.Not(ozzzj_);

                                                                                                                                            return ozzzk_;
                                                                                                                                        };
                                                                                                                                        IEnumerable<CqlDate> nzzzp_ = context.Operators.Where<CqlDate>(nzzzk_, nzzzo_);
                                                                                                                                        int? nzzzr_ = context.Operators.Add(nzzzl_, 1);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzs_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, nzzzm_ as CqlDate, nzzzp_, nzzzr_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] nzzzt_ = [
                                                                                                                                            nzzzs_,
                                                                                                                                        ];
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzu_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList)
                                                                                                                                        {
                                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzl_()
                                                                                                                                            {
                                                                                                                                                bool ozzzm_()
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> ozzzn_ = EleventhList?.NewList;
                                                                                                                                                    int? ozzzo_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate ozzzp_ = context.Operators.Indexer<CqlDate>(ozzzn_, ozzzo_);

                                                                                                                                                    return ozzzp_ is null;
                                                                                                                                                };
                                                                                                                                                if (ozzzm_())
                                                                                                                                                {
                                                                                                                                                    return EleventhList;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> ozzzq_ = EleventhList?.NewList;
                                                                                                                                                    int? ozzzr_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate ozzzs_ = context.Operators.Indexer<CqlDate>(ozzzq_, ozzzr_);
                                                                                                                                                    bool? ozzzu_(CqlDate X)
                                                                                                                                                    {
                                                                                                                                                        IEnumerable<CqlDate> ozzzz_ = EleventhList?.NewList;
                                                                                                                                                        int? pzzza_ = EleventhList?.IndexofNewDate;
                                                                                                                                                        CqlDate pzzzb_ = context.Operators.Indexer<CqlDate>(ozzzz_, pzzza_);
                                                                                                                                                        CqlQuantity pzzzc_ = context.Operators.Quantity(1m, "day");
                                                                                                                                                        CqlDate pzzzd_ = context.Operators.Add(pzzzb_ as CqlDate, pzzzc_);
                                                                                                                                                        CqlDate pzzzg_ = context.Operators.Indexer<CqlDate>(ozzzz_, pzzza_);
                                                                                                                                                        CqlQuantity pzzzh_ = context.Operators.Quantity(30m, "days");
                                                                                                                                                        CqlDate pzzzi_ = context.Operators.Add(pzzzg_ as CqlDate, pzzzh_);
                                                                                                                                                        CqlInterval<CqlDate> pzzzj_ = context.Operators.Interval(pzzzd_, pzzzi_, true, true);
                                                                                                                                                        bool? pzzzk_ = context.Operators.In<CqlDate>(X, pzzzj_, default);
                                                                                                                                                        bool? pzzzl_ = context.Operators.Not(pzzzk_);

                                                                                                                                                        return pzzzl_;
                                                                                                                                                    };
                                                                                                                                                    IEnumerable<CqlDate> ozzzv_ = context.Operators.Where<CqlDate>(ozzzq_, ozzzu_);
                                                                                                                                                    int? ozzzx_ = context.Operators.Add(ozzzr_, 1);
                                                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ozzzs_ as CqlDate, ozzzv_, ozzzx_);

                                                                                                                                                    return ozzzy_;
                                                                                                                                                }
                                                                                                                                            };

                                                                                                                                            return ozzzl_();
                                                                                                                                        };
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> nzzzv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)nzzzt_, nzzzu_);
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> nzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(nzzzv_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(nzzzw_);

                                                                                                                                        return nzzzx_;
                                                                                                                                    }
                                                                                                                                };

                                                                                                                                return nzzzf_();
                                                                                                                            };
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> mzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)mzzzn_, mzzzo_);
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> mzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(mzzzp_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(mzzzq_);

                                                                                                                            return mzzzr_;
                                                                                                                        }
                                                                                                                    };

                                                                                                                    return lzzzz_();
                                                                                                                };
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)lzzzh_, lzzzi_);
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lzzzj_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lzzzk_);

                                                                                                                return lzzzl_;
                                                                                                            }
                                                                                                        };

                                                                                                        return kzzzt_();
                                                                                                    };
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)kzzzb_, kzzzc_);
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kzzzd_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kzzze_);

                                                                                                    return kzzzf_;
                                                                                                }
                                                                                            };

                                                                                            return jzzzn_();
                                                                                        };
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> izzzx_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)izzzv_, izzzw_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> izzzy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(izzzx_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(izzzy_);

                                                                                        return izzzz_;
                                                                                    }
                                                                                };

                                                                                return izzzh_();
                                                                            };
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hzzzr_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hzzzp_, hzzzq_);
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hzzzr_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hzzzs_);

                                                                            return hzzzt_;
                                                                        }
                                                                    };

                                                                    return hzzzb_();
                                                                };
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gzzzl_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gzzzj_, gzzzk_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gzzzl_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gzzzm_);

                                                                return gzzzn_;
                                                            }
                                                        };

                                                        return fzzzv_();
                                                    };
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fzzzf_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fzzzd_, fzzze_);
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fzzzf_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fzzzg_);

                                                    return fzzzh_;
                                                }
                                            };

                                            return ezzzp_();
                                        };
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)dzzzx_, dzzzy_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ezzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dzzzz_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ezzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ezzza_);

                                        return ezzzb_;
                                    }
                                };

                                return dzzzj_();
                            };
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> czzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)czzzr_, czzzs_);
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> czzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(czzzt_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? czzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(czzzu_);

                            return czzzv_;
                        }
                    };

                    return czzzd_();
                };
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bzzzn_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)bzzzl_, bzzzm_);
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bzzzn_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bzzzo_);

                return bzzzp_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bzzza_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)azzzy_, azzzz_);
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> bzzzb_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bzzza_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? bzzzc_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(bzzzb_);

            return bzzzc_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> azzzs_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?>)azzzq_, azzzr_);
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> azzzt_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(azzzs_);
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? azzzu_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(azzzt_);

        return azzzu_;
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
