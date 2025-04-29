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
        IEnumerable<Patient> mzzzzj_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient mzzzzk_ = context.Operators.SingletonFrom<Patient>(mzzzzj_);

        return mzzzzk_;
    }


    [CqlExpressionDefinition("Normalize Onset")]
    public CqlInterval<CqlDateTime> Normalize_Onset(CqlContext context, object onset)
    {
        CqlInterval<CqlDateTime> mzzzzl_()
        {
            if (onset is FhirDateTime)
            {
                CqlDateTime mzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, onset as FhirDateTime);
                CqlInterval<CqlDateTime> mzzzzo_ = context.Operators.Interval(mzzzzm_, mzzzzm_, true, true);

                return mzzzzo_;
            }
            else if (onset is Period)
            {
                FhirDateTime mzzzzp_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
                CqlDateTime mzzzzq_ = context.Operators.Convert<CqlDateTime>(mzzzzp_);
                FhirDateTime mzzzzr_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
                CqlDateTime mzzzzs_ = context.Operators.Convert<CqlDateTime>(mzzzzr_);
                CqlInterval<CqlDateTime> mzzzzt_ = context.Operators.Interval(mzzzzq_, mzzzzs_, true, true);

                return mzzzzt_;
            }
            else if (onset is FhirString)
            {
                CqlInterval<CqlDateTime> mzzzzu_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return mzzzzu_;
            }
            else
            {
                CqlInterval<CqlDate> mzzzzv_()
                {
                    if (onset is Age)
                    {
                        Patient nzzzzg_ = this.Patient(context);
                        Date nzzzzh_ = nzzzzg_?.BirthDateElement;
                        CqlDate nzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzzzh_);
                        CqlQuantity nzzzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate nzzzzk_ = context.Operators.Add(nzzzzi_, nzzzzj_);
                        Date nzzzzm_ = nzzzzg_?.BirthDateElement;
                        CqlDate nzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzzzm_);
                        CqlDate nzzzzp_ = context.Operators.Add(nzzzzn_, nzzzzj_);
                        CqlQuantity nzzzzq_ = context.Operators.Quantity(1m, "year");
                        CqlDate nzzzzr_ = context.Operators.Add(nzzzzp_, nzzzzq_);
                        CqlInterval<CqlDate> nzzzzs_ = context.Operators.Interval(nzzzzk_, nzzzzr_, true, false);

                        return nzzzzs_;
                    }
                    else if (onset is Range)
                    {
                        Patient nzzzzt_ = this.Patient(context);
                        Date nzzzzu_ = nzzzzt_?.BirthDateElement;
                        CqlDate nzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, nzzzzu_);
                        Quantity nzzzzw_ = (onset as Range)?.Low;
                        CqlQuantity nzzzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, nzzzzw_);
                        CqlDate nzzzzy_ = context.Operators.Add(nzzzzv_, nzzzzx_);
                        Date ozzzza_ = nzzzzt_?.BirthDateElement;
                        CqlDate ozzzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzzza_);
                        Quantity ozzzzc_ = (onset as Range)?.High;
                        CqlQuantity ozzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ozzzzc_);
                        CqlDate ozzzze_ = context.Operators.Add(ozzzzb_, ozzzzd_);
                        CqlQuantity ozzzzf_ = context.Operators.Quantity(1m, "year");
                        CqlDate ozzzzg_ = context.Operators.Add(ozzzze_, ozzzzf_);
                        CqlInterval<CqlDate> ozzzzh_ = context.Operators.Interval(nzzzzy_, ozzzzg_, true, false);

                        return ozzzzh_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate mzzzzw_ = (mzzzzv_())?.low;
                CqlDateTime mzzzzx_ = context.Operators.ConvertDateToDateTime(mzzzzw_);
                CqlInterval<CqlDate> mzzzzy_()
                {
                    if (onset is Age)
                    {
                        Patient ozzzzi_ = this.Patient(context);
                        Date ozzzzj_ = ozzzzi_?.BirthDateElement;
                        CqlDate ozzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzzzj_);
                        CqlQuantity ozzzzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate ozzzzm_ = context.Operators.Add(ozzzzk_, ozzzzl_);
                        Date ozzzzo_ = ozzzzi_?.BirthDateElement;
                        CqlDate ozzzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzzzo_);
                        CqlDate ozzzzr_ = context.Operators.Add(ozzzzp_, ozzzzl_);
                        CqlQuantity ozzzzs_ = context.Operators.Quantity(1m, "year");
                        CqlDate ozzzzt_ = context.Operators.Add(ozzzzr_, ozzzzs_);
                        CqlInterval<CqlDate> ozzzzu_ = context.Operators.Interval(ozzzzm_, ozzzzt_, true, false);

                        return ozzzzu_;
                    }
                    else if (onset is Range)
                    {
                        Patient ozzzzv_ = this.Patient(context);
                        Date ozzzzw_ = ozzzzv_?.BirthDateElement;
                        CqlDate ozzzzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ozzzzw_);
                        Quantity ozzzzy_ = (onset as Range)?.Low;
                        CqlQuantity ozzzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, ozzzzy_);
                        CqlDate pzzzza_ = context.Operators.Add(ozzzzx_, ozzzzz_);
                        Date pzzzzc_ = ozzzzv_?.BirthDateElement;
                        CqlDate pzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzzzzc_);
                        Quantity pzzzze_ = (onset as Range)?.High;
                        CqlQuantity pzzzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, pzzzze_);
                        CqlDate pzzzzg_ = context.Operators.Add(pzzzzd_, pzzzzf_);
                        CqlQuantity pzzzzh_ = context.Operators.Quantity(1m, "year");
                        CqlDate pzzzzi_ = context.Operators.Add(pzzzzg_, pzzzzh_);
                        CqlInterval<CqlDate> pzzzzj_ = context.Operators.Interval(pzzzza_, pzzzzi_, true, false);

                        return pzzzzj_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate mzzzzz_ = (mzzzzy_())?.high;
                CqlDateTime nzzzza_ = context.Operators.ConvertDateToDateTime(mzzzzz_);
                CqlInterval<CqlDate> nzzzzb_()
                {
                    if (onset is Age)
                    {
                        Patient pzzzzk_ = this.Patient(context);
                        Date pzzzzl_ = pzzzzk_?.BirthDateElement;
                        CqlDate pzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzzzzl_);
                        CqlQuantity pzzzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate pzzzzo_ = context.Operators.Add(pzzzzm_, pzzzzn_);
                        Date pzzzzq_ = pzzzzk_?.BirthDateElement;
                        CqlDate pzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzzzzq_);
                        CqlDate pzzzzt_ = context.Operators.Add(pzzzzr_, pzzzzn_);
                        CqlQuantity pzzzzu_ = context.Operators.Quantity(1m, "year");
                        CqlDate pzzzzv_ = context.Operators.Add(pzzzzt_, pzzzzu_);
                        CqlInterval<CqlDate> pzzzzw_ = context.Operators.Interval(pzzzzo_, pzzzzv_, true, false);

                        return pzzzzw_;
                    }
                    else if (onset is Range)
                    {
                        Patient pzzzzx_ = this.Patient(context);
                        Date pzzzzy_ = pzzzzx_?.BirthDateElement;
                        CqlDate pzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, pzzzzy_);
                        Quantity qzzzza_ = (onset as Range)?.Low;
                        CqlQuantity qzzzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzzza_);
                        CqlDate qzzzzc_ = context.Operators.Add(pzzzzz_, qzzzzb_);
                        Date qzzzze_ = pzzzzx_?.BirthDateElement;
                        CqlDate qzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzzze_);
                        Quantity qzzzzg_ = (onset as Range)?.High;
                        CqlQuantity qzzzzh_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, qzzzzg_);
                        CqlDate qzzzzi_ = context.Operators.Add(qzzzzf_, qzzzzh_);
                        CqlQuantity qzzzzj_ = context.Operators.Quantity(1m, "year");
                        CqlDate qzzzzk_ = context.Operators.Add(qzzzzi_, qzzzzj_);
                        CqlInterval<CqlDate> qzzzzl_ = context.Operators.Interval(qzzzzc_, qzzzzk_, true, false);

                        return qzzzzl_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? nzzzzc_ = (nzzzzb_())?.lowClosed;
                CqlInterval<CqlDate> nzzzzd_()
                {
                    if (onset is Age)
                    {
                        Patient qzzzzm_ = this.Patient(context);
                        Date qzzzzn_ = qzzzzm_?.BirthDateElement;
                        CqlDate qzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzzzn_);
                        CqlQuantity qzzzzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate qzzzzq_ = context.Operators.Add(qzzzzo_, qzzzzp_);
                        Date qzzzzs_ = qzzzzm_?.BirthDateElement;
                        CqlDate qzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, qzzzzs_);
                        CqlDate qzzzzv_ = context.Operators.Add(qzzzzt_, qzzzzp_);
                        CqlQuantity qzzzzw_ = context.Operators.Quantity(1m, "year");
                        CqlDate qzzzzx_ = context.Operators.Add(qzzzzv_, qzzzzw_);
                        CqlInterval<CqlDate> qzzzzy_ = context.Operators.Interval(qzzzzq_, qzzzzx_, true, false);

                        return qzzzzy_;
                    }
                    else if (onset is Range)
                    {
                        Patient qzzzzz_ = this.Patient(context);
                        Date rzzzza_ = qzzzzz_?.BirthDateElement;
                        CqlDate rzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzzza_);
                        Quantity rzzzzc_ = (onset as Range)?.Low;
                        CqlQuantity rzzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzzzzc_);
                        CqlDate rzzzze_ = context.Operators.Add(rzzzzb_, rzzzzd_);
                        Date rzzzzg_ = qzzzzz_?.BirthDateElement;
                        CqlDate rzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, rzzzzg_);
                        Quantity rzzzzi_ = (onset as Range)?.High;
                        CqlQuantity rzzzzj_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, rzzzzi_);
                        CqlDate rzzzzk_ = context.Operators.Add(rzzzzh_, rzzzzj_);
                        CqlQuantity rzzzzl_ = context.Operators.Quantity(1m, "year");
                        CqlDate rzzzzm_ = context.Operators.Add(rzzzzk_, rzzzzl_);
                        CqlInterval<CqlDate> rzzzzn_ = context.Operators.Interval(rzzzze_, rzzzzm_, true, false);

                        return rzzzzn_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? nzzzze_ = (nzzzzd_())?.highClosed;
                CqlInterval<CqlDateTime> nzzzzf_ = context.Operators.Interval(mzzzzx_, nzzzza_, nzzzzc_, nzzzze_);

                return nzzzzf_;
            }
        };

        return mzzzzl_();
    }


    [CqlExpressionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {
        CqlInterval<CqlDateTime> rzzzzo_()
        {
            if (abatement is FhirDateTime)
            {
                CqlDateTime rzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, abatement as FhirDateTime);
                CqlInterval<CqlDateTime> rzzzzr_ = context.Operators.Interval(rzzzzp_, rzzzzp_, true, true);

                return rzzzzr_;
            }
            else if (abatement is Period)
            {
                FhirDateTime rzzzzs_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
                CqlDateTime rzzzzt_ = context.Operators.Convert<CqlDateTime>(rzzzzs_);
                FhirDateTime rzzzzu_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
                CqlDateTime rzzzzv_ = context.Operators.Convert<CqlDateTime>(rzzzzu_);
                CqlInterval<CqlDateTime> rzzzzw_ = context.Operators.Interval(rzzzzt_, rzzzzv_, true, true);

                return rzzzzw_;
            }
            else if (abatement is FhirString)
            {
                CqlInterval<CqlDateTime> rzzzzx_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return rzzzzx_;
            }
            else
            {
                CqlInterval<CqlDate> rzzzzy_()
                {
                    if (abatement is Age)
                    {
                        Patient szzzzj_ = this.Patient(context);
                        Date szzzzk_ = szzzzj_?.BirthDateElement;
                        CqlDate szzzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzk_);
                        CqlQuantity szzzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate szzzzn_ = context.Operators.Add(szzzzl_, szzzzm_);
                        Date szzzzp_ = szzzzj_?.BirthDateElement;
                        CqlDate szzzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzp_);
                        CqlDate szzzzs_ = context.Operators.Add(szzzzq_, szzzzm_);
                        CqlQuantity szzzzt_ = context.Operators.Quantity(1m, "year");
                        CqlDate szzzzu_ = context.Operators.Add(szzzzs_, szzzzt_);
                        CqlInterval<CqlDate> szzzzv_ = context.Operators.Interval(szzzzn_, szzzzu_, true, false);

                        return szzzzv_;
                    }
                    else if (abatement is Range)
                    {
                        Patient szzzzw_ = this.Patient(context);
                        Date szzzzx_ = szzzzw_?.BirthDateElement;
                        CqlDate szzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, szzzzx_);
                        Quantity szzzzz_ = (abatement as Range)?.Low;
                        CqlQuantity tzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, szzzzz_);
                        CqlDate tzzzzb_ = context.Operators.Add(szzzzy_, tzzzza_);
                        Date tzzzzd_ = szzzzw_?.BirthDateElement;
                        CqlDate tzzzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzd_);
                        Quantity tzzzzf_ = (abatement as Range)?.High;
                        CqlQuantity tzzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, tzzzzf_);
                        CqlDate tzzzzh_ = context.Operators.Add(tzzzze_, tzzzzg_);
                        CqlQuantity tzzzzi_ = context.Operators.Quantity(1m, "year");
                        CqlDate tzzzzj_ = context.Operators.Add(tzzzzh_, tzzzzi_);
                        CqlInterval<CqlDate> tzzzzk_ = context.Operators.Interval(tzzzzb_, tzzzzj_, true, false);

                        return tzzzzk_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate rzzzzz_ = (rzzzzy_())?.low;
                CqlDateTime szzzza_ = context.Operators.ConvertDateToDateTime(rzzzzz_);
                CqlInterval<CqlDate> szzzzb_()
                {
                    if (abatement is Age)
                    {
                        Patient tzzzzl_ = this.Patient(context);
                        Date tzzzzm_ = tzzzzl_?.BirthDateElement;
                        CqlDate tzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzm_);
                        CqlQuantity tzzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate tzzzzp_ = context.Operators.Add(tzzzzn_, tzzzzo_);
                        Date tzzzzr_ = tzzzzl_?.BirthDateElement;
                        CqlDate tzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzr_);
                        CqlDate tzzzzu_ = context.Operators.Add(tzzzzs_, tzzzzo_);
                        CqlQuantity tzzzzv_ = context.Operators.Quantity(1m, "year");
                        CqlDate tzzzzw_ = context.Operators.Add(tzzzzu_, tzzzzv_);
                        CqlInterval<CqlDate> tzzzzx_ = context.Operators.Interval(tzzzzp_, tzzzzw_, true, false);

                        return tzzzzx_;
                    }
                    else if (abatement is Range)
                    {
                        Patient tzzzzy_ = this.Patient(context);
                        Date tzzzzz_ = tzzzzy_?.BirthDateElement;
                        CqlDate uzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzz_);
                        Quantity uzzzzb_ = (abatement as Range)?.Low;
                        CqlQuantity uzzzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzzzb_);
                        CqlDate uzzzzd_ = context.Operators.Add(uzzzza_, uzzzzc_);
                        Date uzzzzf_ = tzzzzy_?.BirthDateElement;
                        CqlDate uzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzzzf_);
                        Quantity uzzzzh_ = (abatement as Range)?.High;
                        CqlQuantity uzzzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzzzh_);
                        CqlDate uzzzzj_ = context.Operators.Add(uzzzzg_, uzzzzi_);
                        CqlQuantity uzzzzk_ = context.Operators.Quantity(1m, "year");
                        CqlDate uzzzzl_ = context.Operators.Add(uzzzzj_, uzzzzk_);
                        CqlInterval<CqlDate> uzzzzm_ = context.Operators.Interval(uzzzzd_, uzzzzl_, true, false);

                        return uzzzzm_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate szzzzc_ = (szzzzb_())?.high;
                CqlDateTime szzzzd_ = context.Operators.ConvertDateToDateTime(szzzzc_);
                CqlInterval<CqlDate> szzzze_()
                {
                    if (abatement is Age)
                    {
                        Patient uzzzzn_ = this.Patient(context);
                        Date uzzzzo_ = uzzzzn_?.BirthDateElement;
                        CqlDate uzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzzzo_);
                        CqlQuantity uzzzzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate uzzzzr_ = context.Operators.Add(uzzzzp_, uzzzzq_);
                        Date uzzzzt_ = uzzzzn_?.BirthDateElement;
                        CqlDate uzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzzzt_);
                        CqlDate uzzzzw_ = context.Operators.Add(uzzzzu_, uzzzzq_);
                        CqlQuantity uzzzzx_ = context.Operators.Quantity(1m, "year");
                        CqlDate uzzzzy_ = context.Operators.Add(uzzzzw_, uzzzzx_);
                        CqlInterval<CqlDate> uzzzzz_ = context.Operators.Interval(uzzzzr_, uzzzzy_, true, false);

                        return uzzzzz_;
                    }
                    else if (abatement is Range)
                    {
                        Patient vzzzza_ = this.Patient(context);
                        Date vzzzzb_ = vzzzza_?.BirthDateElement;
                        CqlDate vzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzzzb_);
                        Quantity vzzzzd_ = (abatement as Range)?.Low;
                        CqlQuantity vzzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzzzd_);
                        CqlDate vzzzzf_ = context.Operators.Add(vzzzzc_, vzzzze_);
                        Date vzzzzh_ = vzzzza_?.BirthDateElement;
                        CqlDate vzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzzzh_);
                        Quantity vzzzzj_ = (abatement as Range)?.High;
                        CqlQuantity vzzzzk_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzzzj_);
                        CqlDate vzzzzl_ = context.Operators.Add(vzzzzi_, vzzzzk_);
                        CqlQuantity vzzzzm_ = context.Operators.Quantity(1m, "year");
                        CqlDate vzzzzn_ = context.Operators.Add(vzzzzl_, vzzzzm_);
                        CqlInterval<CqlDate> vzzzzo_ = context.Operators.Interval(vzzzzf_, vzzzzn_, true, false);

                        return vzzzzo_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? szzzzf_ = (szzzze_())?.lowClosed;
                CqlInterval<CqlDate> szzzzg_()
                {
                    if (abatement is Age)
                    {
                        Patient vzzzzp_ = this.Patient(context);
                        Date vzzzzq_ = vzzzzp_?.BirthDateElement;
                        CqlDate vzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzzzq_);
                        CqlQuantity vzzzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate vzzzzt_ = context.Operators.Add(vzzzzr_, vzzzzs_);
                        Date vzzzzv_ = vzzzzp_?.BirthDateElement;
                        CqlDate vzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzzzv_);
                        CqlDate vzzzzy_ = context.Operators.Add(vzzzzw_, vzzzzs_);
                        CqlQuantity vzzzzz_ = context.Operators.Quantity(1m, "year");
                        CqlDate wzzzza_ = context.Operators.Add(vzzzzy_, vzzzzz_);
                        CqlInterval<CqlDate> wzzzzb_ = context.Operators.Interval(vzzzzt_, wzzzza_, true, false);

                        return wzzzzb_;
                    }
                    else if (abatement is Range)
                    {
                        Patient wzzzzc_ = this.Patient(context);
                        Date wzzzzd_ = wzzzzc_?.BirthDateElement;
                        CqlDate wzzzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzzzd_);
                        Quantity wzzzzf_ = (abatement as Range)?.Low;
                        CqlQuantity wzzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, wzzzzf_);
                        CqlDate wzzzzh_ = context.Operators.Add(wzzzze_, wzzzzg_);
                        Date wzzzzj_ = wzzzzc_?.BirthDateElement;
                        CqlDate wzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzzzj_);
                        Quantity wzzzzl_ = (abatement as Range)?.High;
                        CqlQuantity wzzzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, wzzzzl_);
                        CqlDate wzzzzn_ = context.Operators.Add(wzzzzk_, wzzzzm_);
                        CqlQuantity wzzzzo_ = context.Operators.Quantity(1m, "year");
                        CqlDate wzzzzp_ = context.Operators.Add(wzzzzn_, wzzzzo_);
                        CqlInterval<CqlDate> wzzzzq_ = context.Operators.Interval(wzzzzh_, wzzzzp_, true, false);

                        return wzzzzq_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? szzzzh_ = (szzzzg_())?.highClosed;
                CqlInterval<CqlDateTime> szzzzi_ = context.Operators.Interval(szzzza_, szzzzd_, szzzzf_, szzzzh_);

                return szzzzi_;
            }
        };

        return rzzzzo_();
    }


    [CqlExpressionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        DataType wzzzzr_ = condition?.Onset;
        CqlInterval<CqlDateTime> wzzzzs_ = this.Normalize_Onset(context, wzzzzr_);
        CqlDateTime wzzzzt_ = context.Operators.Start(wzzzzs_);
        DataType wzzzzu_ = condition?.Abatement;
        CqlInterval<CqlDateTime> wzzzzv_ = this.Normalize_Abatement(context, wzzzzu_);
        CqlDateTime wzzzzw_ = context.Operators.End(wzzzzv_);
        CqlInterval<CqlDateTime> wzzzzx_ = context.Operators.Interval(wzzzzt_, wzzzzw_, true, true);

        return wzzzzx_;
    }


    [CqlExpressionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> wzzzzy_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime wzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> xzzzzb_ = context.Operators.Interval(wzzzzz_, wzzzzz_, true, true);

                return xzzzzb_;
            }
            else if (choice is Date)
            {
                CqlDate xzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
                CqlDateTime xzzzzd_ = context.Operators.ConvertDateToDateTime(xzzzzc_);
                CqlDateTime xzzzzf_ = context.Operators.ConvertDateToDateTime(xzzzzc_);
                CqlInterval<CqlDateTime> xzzzzg_ = context.Operators.Interval(xzzzzd_, xzzzzf_, true, true);

                return xzzzzg_;
            }
            else if (choice is Period)
            {
                FhirDateTime xzzzzh_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
                CqlDateTime xzzzzi_ = context.Operators.Convert<CqlDateTime>(xzzzzh_);
                FhirDateTime xzzzzj_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
                CqlDateTime xzzzzk_ = context.Operators.Convert<CqlDateTime>(xzzzzj_);
                CqlInterval<CqlDateTime> xzzzzl_ = context.Operators.Interval(xzzzzi_, xzzzzk_, true, true);

                return xzzzzl_;
            }
            else if (choice is Instant)
            {
                CqlDateTime xzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> xzzzzo_ = context.Operators.Interval(xzzzzm_, xzzzzm_, true, true);

                return xzzzzo_;
            }
            else if (choice is Age)
            {
                Patient xzzzzp_ = this.Patient(context);
                Date xzzzzq_ = xzzzzp_?.BirthDateElement;
                CqlDate xzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzzzq_);
                CqlQuantity xzzzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate xzzzzt_ = context.Operators.Add(xzzzzr_, xzzzzs_);
                Date xzzzzv_ = xzzzzp_?.BirthDateElement;
                CqlDate xzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzzzv_);
                CqlDate xzzzzy_ = context.Operators.Add(xzzzzw_, xzzzzs_);
                CqlQuantity xzzzzz_ = context.Operators.Quantity(1m, "year");
                CqlDate yzzzza_ = context.Operators.Add(xzzzzy_, xzzzzz_);
                CqlInterval<CqlDate> yzzzzb_ = context.Operators.Interval(xzzzzt_, yzzzza_, true, false);
                CqlDate yzzzzc_ = yzzzzb_?.low;
                CqlDateTime yzzzzd_ = context.Operators.ConvertDateToDateTime(yzzzzc_);
                Date yzzzzf_ = xzzzzp_?.BirthDateElement;
                CqlDate yzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzf_);
                CqlDate yzzzzi_ = context.Operators.Add(yzzzzg_, xzzzzs_);
                Date yzzzzk_ = xzzzzp_?.BirthDateElement;
                CqlDate yzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzk_);
                CqlDate yzzzzn_ = context.Operators.Add(yzzzzl_, xzzzzs_);
                CqlDate yzzzzp_ = context.Operators.Add(yzzzzn_, xzzzzz_);
                CqlInterval<CqlDate> yzzzzq_ = context.Operators.Interval(yzzzzi_, yzzzzp_, true, false);
                CqlDate yzzzzr_ = yzzzzq_?.high;
                CqlDateTime yzzzzs_ = context.Operators.ConvertDateToDateTime(yzzzzr_);
                Date yzzzzu_ = xzzzzp_?.BirthDateElement;
                CqlDate yzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzu_);
                CqlDate yzzzzx_ = context.Operators.Add(yzzzzv_, xzzzzs_);
                Date yzzzzz_ = xzzzzp_?.BirthDateElement;
                CqlDate zzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzz_);
                CqlDate zzzzzc_ = context.Operators.Add(zzzzza_, xzzzzs_);
                CqlDate zzzzze_ = context.Operators.Add(zzzzzc_, xzzzzz_);
                CqlInterval<CqlDate> zzzzzf_ = context.Operators.Interval(yzzzzx_, zzzzze_, true, false);
                bool? zzzzzg_ = zzzzzf_?.lowClosed;
                Date zzzzzi_ = xzzzzp_?.BirthDateElement;
                CqlDate zzzzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzi_);
                CqlDate zzzzzl_ = context.Operators.Add(zzzzzj_, xzzzzs_);
                Date zzzzzn_ = xzzzzp_?.BirthDateElement;
                CqlDate zzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzn_);
                CqlDate zzzzzq_ = context.Operators.Add(zzzzzo_, xzzzzs_);
                CqlDate zzzzzs_ = context.Operators.Add(zzzzzq_, xzzzzz_);
                CqlInterval<CqlDate> zzzzzt_ = context.Operators.Interval(zzzzzl_, zzzzzs_, true, false);
                bool? zzzzzu_ = zzzzzt_?.highClosed;
                CqlInterval<CqlDateTime> zzzzzv_ = context.Operators.Interval(yzzzzd_, yzzzzs_, zzzzzg_, zzzzzu_);

                return zzzzzv_;
            }
            else if (choice is Range)
            {
                Patient zzzzzw_ = this.Patient(context);
                Date zzzzzx_ = zzzzzw_?.BirthDateElement;
                CqlDate zzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzx_);
                Quantity zzzzzz_ = (choice as Range)?.Low;
                CqlQuantity azzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzz_);
                CqlDate azzzzzb_ = context.Operators.Add(zzzzzy_, azzzzza_);
                Date azzzzzd_ = zzzzzw_?.BirthDateElement;
                CqlDate azzzzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzd_);
                Quantity azzzzzf_ = (choice as Range)?.High;
                CqlQuantity azzzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzzzzf_);
                CqlDate azzzzzh_ = context.Operators.Add(azzzzze_, azzzzzg_);
                CqlQuantity azzzzzi_ = context.Operators.Quantity(1m, "year");
                CqlDate azzzzzj_ = context.Operators.Add(azzzzzh_, azzzzzi_);
                CqlInterval<CqlDate> azzzzzk_ = context.Operators.Interval(azzzzzb_, azzzzzj_, true, false);
                CqlDate azzzzzl_ = azzzzzk_?.low;
                CqlDateTime azzzzzm_ = context.Operators.ConvertDateToDateTime(azzzzzl_);
                Date azzzzzo_ = zzzzzw_?.BirthDateElement;
                CqlDate azzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzo_);
                CqlQuantity azzzzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzz_);
                CqlDate azzzzzs_ = context.Operators.Add(azzzzzp_, azzzzzr_);
                Date azzzzzu_ = zzzzzw_?.BirthDateElement;
                CqlDate azzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzu_);
                CqlQuantity azzzzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzzzzf_);
                CqlDate azzzzzy_ = context.Operators.Add(azzzzzv_, azzzzzx_);
                CqlDate bzzzzza_ = context.Operators.Add(azzzzzy_, azzzzzi_);
                CqlInterval<CqlDate> bzzzzzb_ = context.Operators.Interval(azzzzzs_, bzzzzza_, true, false);
                CqlDate bzzzzzc_ = bzzzzzb_?.high;
                CqlDateTime bzzzzzd_ = context.Operators.ConvertDateToDateTime(bzzzzzc_);
                Date bzzzzzf_ = zzzzzw_?.BirthDateElement;
                CqlDate bzzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzf_);
                CqlQuantity bzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzz_);
                CqlDate bzzzzzj_ = context.Operators.Add(bzzzzzg_, bzzzzzi_);
                Date bzzzzzl_ = zzzzzw_?.BirthDateElement;
                CqlDate bzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzl_);
                CqlQuantity bzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzzzzf_);
                CqlDate bzzzzzp_ = context.Operators.Add(bzzzzzm_, bzzzzzo_);
                CqlDate bzzzzzr_ = context.Operators.Add(bzzzzzp_, azzzzzi_);
                CqlInterval<CqlDate> bzzzzzs_ = context.Operators.Interval(bzzzzzj_, bzzzzzr_, true, false);
                bool? bzzzzzt_ = bzzzzzs_?.lowClosed;
                Date bzzzzzv_ = zzzzzw_?.BirthDateElement;
                CqlDate bzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzv_);
                CqlQuantity bzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzz_);
                CqlDate bzzzzzz_ = context.Operators.Add(bzzzzzw_, bzzzzzy_);
                Date czzzzzb_ = zzzzzw_?.BirthDateElement;
                CqlDate czzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzzzzb_);
                CqlQuantity czzzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzzzzf_);
                CqlDate czzzzzf_ = context.Operators.Add(czzzzzc_, czzzzze_);
                CqlDate czzzzzh_ = context.Operators.Add(czzzzzf_, azzzzzi_);
                CqlInterval<CqlDate> czzzzzi_ = context.Operators.Interval(bzzzzzz_, czzzzzh_, true, false);
                bool? czzzzzj_ = czzzzzi_?.highClosed;
                CqlInterval<CqlDateTime> czzzzzk_ = context.Operators.Interval(azzzzzm_, bzzzzzd_, bzzzzzt_, czzzzzj_);

                return czzzzzk_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> czzzzzl_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return czzzzzl_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> czzzzzm_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return czzzzzm_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return wzzzzy_();
    }


    [CqlExpressionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        string czzzzzn_()
        {
            bool czzzzzo_()
            {
                int? czzzzzp_ = context.Operators.PositionOf("/", uri);
                bool? czzzzzq_ = context.Operators.Greater(czzzzzp_, 0);

                return czzzzzq_ ?? false;
            };
            if (czzzzzo_())
            {
                IEnumerable<string> czzzzzr_ = context.Operators.Split(uri, "/");
                string czzzzzs_ = context.Operators.Last<string>(czzzzzr_);

                return czzzzzs_;
            }
            else
            {
                return uri;
            }
        };

        return czzzzzn_();
    }


    [CqlExpressionDefinition("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) =>
        VSet;


    [CqlExpressionDefinition("First Dates per 31 Day Periods")]
    public (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
    {
        CqlDate czzzzzt_(CqlDate d) =>
            d;
        IEnumerable<CqlDate> czzzzzu_ = context.Operators.Select<CqlDate, CqlDate>(DateList, czzzzzt_);
        IEnumerable<CqlDate> czzzzzv_ = context.Operators.Distinct<CqlDate>(czzzzzu_);
        IEnumerable<CqlDate> czzzzzw_ = context.Operators.ListSort<CqlDate>(czzzzzv_, System.ComponentModel.ListSortDirection.Ascending);
        bool? czzzzzx_(CqlDate X)
        {
            bool? dzzzzzf_ = context.Operators.Not((bool?)(X is null));

            return dzzzzzf_;
        };
        IEnumerable<CqlDate> czzzzzy_ = context.Operators.Where<CqlDate>(czzzzzw_, czzzzzx_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? czzzzzz_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, czzzzzy_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] dzzzzza_ = [
            czzzzzz_,
        ];
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzzzb_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates)
        {
            IEnumerable<CqlDate> dzzzzzg_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? dzzzzzh_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, dzzzzzg_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] dzzzzzi_ = [
                dzzzzzh_,
            ];
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzzzj_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList)
            {
                IEnumerable<CqlDate> dzzzzzn_ = AnchorList?.SortedList;
                int? dzzzzzo_ = AnchorList?.AnchorIndex;
                CqlDate dzzzzzp_ = context.Operators.Indexer<CqlDate>(dzzzzzn_, dzzzzzo_);
                bool? dzzzzzq_(CqlDate X)
                {
                    IEnumerable<CqlDate> ezzzzza_ = AnchorList?.SortedList;
                    int? ezzzzzb_ = AnchorList?.AnchorIndex;
                    CqlDate ezzzzzc_ = context.Operators.Indexer<CqlDate>(ezzzzza_, ezzzzzb_);
                    CqlQuantity ezzzzzd_ = context.Operators.Quantity(1m, "day");
                    CqlDate ezzzzze_ = context.Operators.Add(ezzzzzc_ as CqlDate, ezzzzzd_);
                    CqlDate ezzzzzh_ = context.Operators.Indexer<CqlDate>(ezzzzza_, ezzzzzb_);
                    CqlQuantity ezzzzzi_ = context.Operators.Quantity(30m, "days");
                    CqlDate ezzzzzj_ = context.Operators.Add(ezzzzzh_ as CqlDate, ezzzzzi_);
                    CqlInterval<CqlDate> ezzzzzk_ = context.Operators.Interval(ezzzzze_, ezzzzzj_, true, true);
                    bool? ezzzzzl_ = context.Operators.In<CqlDate>(X, ezzzzzk_, default);
                    bool? ezzzzzm_ = context.Operators.Not(ezzzzzl_);

                    return ezzzzzm_;
                };
                IEnumerable<CqlDate> dzzzzzr_ = context.Operators.Where<CqlDate>(DateList, dzzzzzq_);
                int? dzzzzzt_ = context.Operators.Add(dzzzzzo_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzzzu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, dzzzzzp_ as CqlDate, dzzzzzr_, dzzzzzt_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] dzzzzzv_ = [
                    dzzzzzu_,
                ];
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzzzw_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList)
                {
                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ezzzzzn_()
                    {
                        bool ezzzzzo_()
                        {
                            IEnumerable<CqlDate> ezzzzzp_ = FirstList?.NewList;
                            int? ezzzzzq_ = FirstList?.IndexofNewDate;
                            CqlDate ezzzzzr_ = context.Operators.Indexer<CqlDate>(ezzzzzp_, ezzzzzq_);

                            return ezzzzzr_ is null;
                        };
                        if (ezzzzzo_())
                        {
                            return FirstList;
                        }
                        else
                        {
                            IEnumerable<CqlDate> ezzzzzs_ = FirstList?.NewList;
                            int? ezzzzzt_ = FirstList?.IndexofNewDate;
                            CqlDate ezzzzzu_ = context.Operators.Indexer<CqlDate>(ezzzzzs_, ezzzzzt_);
                            bool? ezzzzzw_(CqlDate X)
                            {
                                IEnumerable<CqlDate> fzzzzzg_ = FirstList?.NewList;
                                int? fzzzzzh_ = FirstList?.IndexofNewDate;
                                CqlDate fzzzzzi_ = context.Operators.Indexer<CqlDate>(fzzzzzg_, fzzzzzh_);
                                CqlQuantity fzzzzzj_ = context.Operators.Quantity(1m, "day");
                                CqlDate fzzzzzk_ = context.Operators.Add(fzzzzzi_ as CqlDate, fzzzzzj_);
                                CqlDate fzzzzzn_ = context.Operators.Indexer<CqlDate>(fzzzzzg_, fzzzzzh_);
                                CqlQuantity fzzzzzo_ = context.Operators.Quantity(30m, "days");
                                CqlDate fzzzzzp_ = context.Operators.Add(fzzzzzn_ as CqlDate, fzzzzzo_);
                                CqlInterval<CqlDate> fzzzzzq_ = context.Operators.Interval(fzzzzzk_, fzzzzzp_, true, true);
                                bool? fzzzzzr_ = context.Operators.In<CqlDate>(X, fzzzzzq_, default);
                                bool? fzzzzzs_ = context.Operators.Not(fzzzzzr_);

                                return fzzzzzs_;
                            };
                            IEnumerable<CqlDate> ezzzzzx_ = context.Operators.Where<CqlDate>(ezzzzzs_, ezzzzzw_);
                            int? ezzzzzz_ = context.Operators.Add(ezzzzzt_, 1);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzzza_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ezzzzzu_ as CqlDate, ezzzzzx_, ezzzzzz_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] fzzzzzb_ = [
                                fzzzzza_,
                            ];
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzzzc_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList)
                            {
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzzzt_()
                                {
                                    bool fzzzzzu_()
                                    {
                                        IEnumerable<CqlDate> fzzzzzv_ = SecondList?.NewList;
                                        int? fzzzzzw_ = SecondList?.IndexofNewDate;
                                        CqlDate fzzzzzx_ = context.Operators.Indexer<CqlDate>(fzzzzzv_, fzzzzzw_);

                                        return fzzzzzx_ is null;
                                    };
                                    if (fzzzzzu_())
                                    {
                                        return SecondList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> fzzzzzy_ = SecondList?.NewList;
                                        int? fzzzzzz_ = SecondList?.IndexofNewDate;
                                        CqlDate gzzzzza_ = context.Operators.Indexer<CqlDate>(fzzzzzy_, fzzzzzz_);
                                        bool? gzzzzzc_(CqlDate X)
                                        {
                                            IEnumerable<CqlDate> gzzzzzm_ = SecondList?.NewList;
                                            int? gzzzzzn_ = SecondList?.IndexofNewDate;
                                            CqlDate gzzzzzo_ = context.Operators.Indexer<CqlDate>(gzzzzzm_, gzzzzzn_);
                                            CqlQuantity gzzzzzp_ = context.Operators.Quantity(1m, "day");
                                            CqlDate gzzzzzq_ = context.Operators.Add(gzzzzzo_ as CqlDate, gzzzzzp_);
                                            CqlDate gzzzzzt_ = context.Operators.Indexer<CqlDate>(gzzzzzm_, gzzzzzn_);
                                            CqlQuantity gzzzzzu_ = context.Operators.Quantity(30m, "days");
                                            CqlDate gzzzzzv_ = context.Operators.Add(gzzzzzt_ as CqlDate, gzzzzzu_);
                                            CqlInterval<CqlDate> gzzzzzw_ = context.Operators.Interval(gzzzzzq_, gzzzzzv_, true, true);
                                            bool? gzzzzzx_ = context.Operators.In<CqlDate>(X, gzzzzzw_, default);
                                            bool? gzzzzzy_ = context.Operators.Not(gzzzzzx_);

                                            return gzzzzzy_;
                                        };
                                        IEnumerable<CqlDate> gzzzzzd_ = context.Operators.Where<CqlDate>(fzzzzzy_, gzzzzzc_);
                                        int? gzzzzzf_ = context.Operators.Add(fzzzzzz_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzzzg_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, gzzzzza_ as CqlDate, gzzzzzd_, gzzzzzf_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] gzzzzzh_ = [
                                            gzzzzzg_,
                                        ];
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzzzi_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList)
                                        {
                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzzzz_()
                                            {
                                                bool hzzzzza_()
                                                {
                                                    IEnumerable<CqlDate> hzzzzzb_ = ThirdList?.NewList;
                                                    int? hzzzzzc_ = ThirdList?.IndexofNewDate;
                                                    CqlDate hzzzzzd_ = context.Operators.Indexer<CqlDate>(hzzzzzb_, hzzzzzc_);

                                                    return hzzzzzd_ is null;
                                                };
                                                if (hzzzzza_())
                                                {
                                                    return ThirdList;
                                                }
                                                else
                                                {
                                                    IEnumerable<CqlDate> hzzzzze_ = ThirdList?.NewList;
                                                    int? hzzzzzf_ = ThirdList?.IndexofNewDate;
                                                    CqlDate hzzzzzg_ = context.Operators.Indexer<CqlDate>(hzzzzze_, hzzzzzf_);
                                                    bool? hzzzzzi_(CqlDate X)
                                                    {
                                                        IEnumerable<CqlDate> hzzzzzs_ = ThirdList?.NewList;
                                                        int? hzzzzzt_ = ThirdList?.IndexofNewDate;
                                                        CqlDate hzzzzzu_ = context.Operators.Indexer<CqlDate>(hzzzzzs_, hzzzzzt_);
                                                        CqlQuantity hzzzzzv_ = context.Operators.Quantity(1m, "day");
                                                        CqlDate hzzzzzw_ = context.Operators.Add(hzzzzzu_ as CqlDate, hzzzzzv_);
                                                        CqlDate hzzzzzz_ = context.Operators.Indexer<CqlDate>(hzzzzzs_, hzzzzzt_);
                                                        CqlQuantity izzzzza_ = context.Operators.Quantity(30m, "days");
                                                        CqlDate izzzzzb_ = context.Operators.Add(hzzzzzz_ as CqlDate, izzzzza_);
                                                        CqlInterval<CqlDate> izzzzzc_ = context.Operators.Interval(hzzzzzw_, izzzzzb_, true, true);
                                                        bool? izzzzzd_ = context.Operators.In<CqlDate>(X, izzzzzc_, default);
                                                        bool? izzzzze_ = context.Operators.Not(izzzzzd_);

                                                        return izzzzze_;
                                                    };
                                                    IEnumerable<CqlDate> hzzzzzj_ = context.Operators.Where<CqlDate>(hzzzzze_, hzzzzzi_);
                                                    int? hzzzzzl_ = context.Operators.Add(hzzzzzf_, 1);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzzzm_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, hzzzzzg_ as CqlDate, hzzzzzj_, hzzzzzl_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] hzzzzzn_ = [
                                                        hzzzzzm_,
                                                    ];
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzzzo_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList)
                                                    {
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzzzf_()
                                                        {
                                                            bool izzzzzg_()
                                                            {
                                                                IEnumerable<CqlDate> izzzzzh_ = FourthList?.NewList;
                                                                int? izzzzzi_ = FourthList?.IndexofNewDate;
                                                                CqlDate izzzzzj_ = context.Operators.Indexer<CqlDate>(izzzzzh_, izzzzzi_);

                                                                return izzzzzj_ is null;
                                                            };
                                                            if (izzzzzg_())
                                                            {
                                                                return FourthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> izzzzzk_ = FourthList?.NewList;
                                                                int? izzzzzl_ = FourthList?.IndexofNewDate;
                                                                CqlDate izzzzzm_ = context.Operators.Indexer<CqlDate>(izzzzzk_, izzzzzl_);
                                                                bool? izzzzzo_(CqlDate X)
                                                                {
                                                                    IEnumerable<CqlDate> izzzzzy_ = FourthList?.NewList;
                                                                    int? izzzzzz_ = FourthList?.IndexofNewDate;
                                                                    CqlDate jzzzzza_ = context.Operators.Indexer<CqlDate>(izzzzzy_, izzzzzz_);
                                                                    CqlQuantity jzzzzzb_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate jzzzzzc_ = context.Operators.Add(jzzzzza_ as CqlDate, jzzzzzb_);
                                                                    CqlDate jzzzzzf_ = context.Operators.Indexer<CqlDate>(izzzzzy_, izzzzzz_);
                                                                    CqlQuantity jzzzzzg_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate jzzzzzh_ = context.Operators.Add(jzzzzzf_ as CqlDate, jzzzzzg_);
                                                                    CqlInterval<CqlDate> jzzzzzi_ = context.Operators.Interval(jzzzzzc_, jzzzzzh_, true, true);
                                                                    bool? jzzzzzj_ = context.Operators.In<CqlDate>(X, jzzzzzi_, default);
                                                                    bool? jzzzzzk_ = context.Operators.Not(jzzzzzj_);

                                                                    return jzzzzzk_;
                                                                };
                                                                IEnumerable<CqlDate> izzzzzp_ = context.Operators.Where<CqlDate>(izzzzzk_, izzzzzo_);
                                                                int? izzzzzr_ = context.Operators.Add(izzzzzl_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzzzs_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, izzzzzm_ as CqlDate, izzzzzp_, izzzzzr_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] izzzzzt_ = [
                                                                    izzzzzs_,
                                                                ];
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzzzu_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList)
                                                                {
                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzzzl_()
                                                                    {
                                                                        bool jzzzzzm_()
                                                                        {
                                                                            IEnumerable<CqlDate> jzzzzzn_ = FifthList?.NewList;
                                                                            int? jzzzzzo_ = FifthList?.IndexofNewDate;
                                                                            CqlDate jzzzzzp_ = context.Operators.Indexer<CqlDate>(jzzzzzn_, jzzzzzo_);

                                                                            return jzzzzzp_ is null;
                                                                        };
                                                                        if (jzzzzzm_())
                                                                        {
                                                                            return FifthList;
                                                                        }
                                                                        else
                                                                        {
                                                                            IEnumerable<CqlDate> jzzzzzq_ = FifthList?.NewList;
                                                                            int? jzzzzzr_ = FifthList?.IndexofNewDate;
                                                                            CqlDate jzzzzzs_ = context.Operators.Indexer<CqlDate>(jzzzzzq_, jzzzzzr_);
                                                                            bool? jzzzzzu_(CqlDate X)
                                                                            {
                                                                                IEnumerable<CqlDate> kzzzzze_ = FifthList?.NewList;
                                                                                int? kzzzzzf_ = FifthList?.IndexofNewDate;
                                                                                CqlDate kzzzzzg_ = context.Operators.Indexer<CqlDate>(kzzzzze_, kzzzzzf_);
                                                                                CqlQuantity kzzzzzh_ = context.Operators.Quantity(1m, "day");
                                                                                CqlDate kzzzzzi_ = context.Operators.Add(kzzzzzg_ as CqlDate, kzzzzzh_);
                                                                                CqlDate kzzzzzl_ = context.Operators.Indexer<CqlDate>(kzzzzze_, kzzzzzf_);
                                                                                CqlQuantity kzzzzzm_ = context.Operators.Quantity(30m, "days");
                                                                                CqlDate kzzzzzn_ = context.Operators.Add(kzzzzzl_ as CqlDate, kzzzzzm_);
                                                                                CqlInterval<CqlDate> kzzzzzo_ = context.Operators.Interval(kzzzzzi_, kzzzzzn_, true, true);
                                                                                bool? kzzzzzp_ = context.Operators.In<CqlDate>(X, kzzzzzo_, default);
                                                                                bool? kzzzzzq_ = context.Operators.Not(kzzzzzp_);

                                                                                return kzzzzzq_;
                                                                            };
                                                                            IEnumerable<CqlDate> jzzzzzv_ = context.Operators.Where<CqlDate>(jzzzzzq_, jzzzzzu_);
                                                                            int? jzzzzzx_ = context.Operators.Add(jzzzzzr_, 1);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzzzy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, jzzzzzs_ as CqlDate, jzzzzzv_, jzzzzzx_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] jzzzzzz_ = [
                                                                                jzzzzzy_,
                                                                            ];
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzzza_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList)
                                                                            {
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzzzr_()
                                                                                {
                                                                                    bool kzzzzzs_()
                                                                                    {
                                                                                        IEnumerable<CqlDate> kzzzzzt_ = SixthList?.NewList;
                                                                                        int? kzzzzzu_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate kzzzzzv_ = context.Operators.Indexer<CqlDate>(kzzzzzt_, kzzzzzu_);

                                                                                        return kzzzzzv_ is null;
                                                                                    };
                                                                                    if (kzzzzzs_())
                                                                                    {
                                                                                        return SixthList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> kzzzzzw_ = SixthList?.NewList;
                                                                                        int? kzzzzzx_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate kzzzzzy_ = context.Operators.Indexer<CqlDate>(kzzzzzw_, kzzzzzx_);
                                                                                        bool? lzzzzza_(CqlDate X)
                                                                                        {
                                                                                            IEnumerable<CqlDate> lzzzzzk_ = SixthList?.NewList;
                                                                                            int? lzzzzzl_ = SixthList?.IndexofNewDate;
                                                                                            CqlDate lzzzzzm_ = context.Operators.Indexer<CqlDate>(lzzzzzk_, lzzzzzl_);
                                                                                            CqlQuantity lzzzzzn_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate lzzzzzo_ = context.Operators.Add(lzzzzzm_ as CqlDate, lzzzzzn_);
                                                                                            CqlDate lzzzzzr_ = context.Operators.Indexer<CqlDate>(lzzzzzk_, lzzzzzl_);
                                                                                            CqlQuantity lzzzzzs_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate lzzzzzt_ = context.Operators.Add(lzzzzzr_ as CqlDate, lzzzzzs_);
                                                                                            CqlInterval<CqlDate> lzzzzzu_ = context.Operators.Interval(lzzzzzo_, lzzzzzt_, true, true);
                                                                                            bool? lzzzzzv_ = context.Operators.In<CqlDate>(X, lzzzzzu_, default);
                                                                                            bool? lzzzzzw_ = context.Operators.Not(lzzzzzv_);

                                                                                            return lzzzzzw_;
                                                                                        };
                                                                                        IEnumerable<CqlDate> lzzzzzb_ = context.Operators.Where<CqlDate>(kzzzzzw_, lzzzzza_);
                                                                                        int? lzzzzzd_ = context.Operators.Add(kzzzzzx_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzzze_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, kzzzzzy_ as CqlDate, lzzzzzb_, lzzzzzd_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] lzzzzzf_ = [
                                                                                            lzzzzze_,
                                                                                        ];
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzzzg_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList)
                                                                                        {
                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzzzx_()
                                                                                            {
                                                                                                bool lzzzzzy_()
                                                                                                {
                                                                                                    IEnumerable<CqlDate> lzzzzzz_ = SeventhList?.NewList;
                                                                                                    int? mzzzzza_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate mzzzzzb_ = context.Operators.Indexer<CqlDate>(lzzzzzz_, mzzzzza_);

                                                                                                    return mzzzzzb_ is null;
                                                                                                };
                                                                                                if (lzzzzzy_())
                                                                                                {
                                                                                                    return SeventhList;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    IEnumerable<CqlDate> mzzzzzc_ = SeventhList?.NewList;
                                                                                                    int? mzzzzzd_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate mzzzzze_ = context.Operators.Indexer<CqlDate>(mzzzzzc_, mzzzzzd_);
                                                                                                    bool? mzzzzzg_(CqlDate X)
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> mzzzzzq_ = SeventhList?.NewList;
                                                                                                        int? mzzzzzr_ = SeventhList?.IndexofNewDate;
                                                                                                        CqlDate mzzzzzs_ = context.Operators.Indexer<CqlDate>(mzzzzzq_, mzzzzzr_);
                                                                                                        CqlQuantity mzzzzzt_ = context.Operators.Quantity(1m, "day");
                                                                                                        CqlDate mzzzzzu_ = context.Operators.Add(mzzzzzs_ as CqlDate, mzzzzzt_);
                                                                                                        CqlDate mzzzzzx_ = context.Operators.Indexer<CqlDate>(mzzzzzq_, mzzzzzr_);
                                                                                                        CqlQuantity mzzzzzy_ = context.Operators.Quantity(30m, "days");
                                                                                                        CqlDate mzzzzzz_ = context.Operators.Add(mzzzzzx_ as CqlDate, mzzzzzy_);
                                                                                                        CqlInterval<CqlDate> nzzzzza_ = context.Operators.Interval(mzzzzzu_, mzzzzzz_, true, true);
                                                                                                        bool? nzzzzzb_ = context.Operators.In<CqlDate>(X, nzzzzza_, default);
                                                                                                        bool? nzzzzzc_ = context.Operators.Not(nzzzzzb_);

                                                                                                        return nzzzzzc_;
                                                                                                    };
                                                                                                    IEnumerable<CqlDate> mzzzzzh_ = context.Operators.Where<CqlDate>(mzzzzzc_, mzzzzzg_);
                                                                                                    int? mzzzzzj_ = context.Operators.Add(mzzzzzd_, 1);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzzzk_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, mzzzzze_ as CqlDate, mzzzzzh_, mzzzzzj_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] mzzzzzl_ = [
                                                                                                        mzzzzzk_,
                                                                                                    ];
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzzzm_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList)
                                                                                                    {
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzzzd_()
                                                                                                        {
                                                                                                            bool nzzzzze_()
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> nzzzzzf_ = EighthList?.NewList;
                                                                                                                int? nzzzzzg_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate nzzzzzh_ = context.Operators.Indexer<CqlDate>(nzzzzzf_, nzzzzzg_);

                                                                                                                return nzzzzzh_ is null;
                                                                                                            };
                                                                                                            if (nzzzzze_())
                                                                                                            {
                                                                                                                return EighthList;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> nzzzzzi_ = EighthList?.NewList;
                                                                                                                int? nzzzzzj_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate nzzzzzk_ = context.Operators.Indexer<CqlDate>(nzzzzzi_, nzzzzzj_);
                                                                                                                bool? nzzzzzm_(CqlDate X)
                                                                                                                {
                                                                                                                    IEnumerable<CqlDate> nzzzzzw_ = EighthList?.NewList;
                                                                                                                    int? nzzzzzx_ = EighthList?.IndexofNewDate;
                                                                                                                    CqlDate nzzzzzy_ = context.Operators.Indexer<CqlDate>(nzzzzzw_, nzzzzzx_);
                                                                                                                    CqlQuantity nzzzzzz_ = context.Operators.Quantity(1m, "day");
                                                                                                                    CqlDate ozzzzza_ = context.Operators.Add(nzzzzzy_ as CqlDate, nzzzzzz_);
                                                                                                                    CqlDate ozzzzzd_ = context.Operators.Indexer<CqlDate>(nzzzzzw_, nzzzzzx_);
                                                                                                                    CqlQuantity ozzzzze_ = context.Operators.Quantity(30m, "days");
                                                                                                                    CqlDate ozzzzzf_ = context.Operators.Add(ozzzzzd_ as CqlDate, ozzzzze_);
                                                                                                                    CqlInterval<CqlDate> ozzzzzg_ = context.Operators.Interval(ozzzzza_, ozzzzzf_, true, true);
                                                                                                                    bool? ozzzzzh_ = context.Operators.In<CqlDate>(X, ozzzzzg_, default);
                                                                                                                    bool? ozzzzzi_ = context.Operators.Not(ozzzzzh_);

                                                                                                                    return ozzzzzi_;
                                                                                                                };
                                                                                                                IEnumerable<CqlDate> nzzzzzn_ = context.Operators.Where<CqlDate>(nzzzzzi_, nzzzzzm_);
                                                                                                                int? nzzzzzp_ = context.Operators.Add(nzzzzzj_, 1);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzzzq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, nzzzzzk_ as CqlDate, nzzzzzn_, nzzzzzp_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] nzzzzzr_ = [
                                                                                                                    nzzzzzq_,
                                                                                                                ];
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzzzs_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList)
                                                                                                                {
                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzj_()
                                                                                                                    {
                                                                                                                        bool ozzzzzk_()
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> ozzzzzl_ = NinethList?.NewList;
                                                                                                                            int? ozzzzzm_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate ozzzzzn_ = context.Operators.Indexer<CqlDate>(ozzzzzl_, ozzzzzm_);

                                                                                                                            return ozzzzzn_ is null;
                                                                                                                        };
                                                                                                                        if (ozzzzzk_())
                                                                                                                        {
                                                                                                                            return NinethList;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> ozzzzzo_ = NinethList?.NewList;
                                                                                                                            int? ozzzzzp_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate ozzzzzq_ = context.Operators.Indexer<CqlDate>(ozzzzzo_, ozzzzzp_);
                                                                                                                            bool? ozzzzzs_(CqlDate X)
                                                                                                                            {
                                                                                                                                IEnumerable<CqlDate> pzzzzzc_ = NinethList?.NewList;
                                                                                                                                int? pzzzzzd_ = NinethList?.IndexofNewDate;
                                                                                                                                CqlDate pzzzzze_ = context.Operators.Indexer<CqlDate>(pzzzzzc_, pzzzzzd_);
                                                                                                                                CqlQuantity pzzzzzf_ = context.Operators.Quantity(1m, "day");
                                                                                                                                CqlDate pzzzzzg_ = context.Operators.Add(pzzzzze_ as CqlDate, pzzzzzf_);
                                                                                                                                CqlDate pzzzzzj_ = context.Operators.Indexer<CqlDate>(pzzzzzc_, pzzzzzd_);
                                                                                                                                CqlQuantity pzzzzzk_ = context.Operators.Quantity(30m, "days");
                                                                                                                                CqlDate pzzzzzl_ = context.Operators.Add(pzzzzzj_ as CqlDate, pzzzzzk_);
                                                                                                                                CqlInterval<CqlDate> pzzzzzm_ = context.Operators.Interval(pzzzzzg_, pzzzzzl_, true, true);
                                                                                                                                bool? pzzzzzn_ = context.Operators.In<CqlDate>(X, pzzzzzm_, default);
                                                                                                                                bool? pzzzzzo_ = context.Operators.Not(pzzzzzn_);

                                                                                                                                return pzzzzzo_;
                                                                                                                            };
                                                                                                                            IEnumerable<CqlDate> ozzzzzt_ = context.Operators.Where<CqlDate>(ozzzzzo_, ozzzzzs_);
                                                                                                                            int? ozzzzzv_ = context.Operators.Add(ozzzzzp_, 1);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzw_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, ozzzzzq_ as CqlDate, ozzzzzt_, ozzzzzv_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ozzzzzx_ = [
                                                                                                                                ozzzzzw_,
                                                                                                                            ];
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzy_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList)
                                                                                                                            {
                                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzp_()
                                                                                                                                {
                                                                                                                                    bool pzzzzzq_()
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> pzzzzzr_ = TenthList?.NewList;
                                                                                                                                        int? pzzzzzs_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate pzzzzzt_ = context.Operators.Indexer<CqlDate>(pzzzzzr_, pzzzzzs_);

                                                                                                                                        return pzzzzzt_ is null;
                                                                                                                                    };
                                                                                                                                    if (pzzzzzq_())
                                                                                                                                    {
                                                                                                                                        return TenthList;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> pzzzzzu_ = TenthList?.NewList;
                                                                                                                                        int? pzzzzzv_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate pzzzzzw_ = context.Operators.Indexer<CqlDate>(pzzzzzu_, pzzzzzv_);
                                                                                                                                        bool? pzzzzzy_(CqlDate X)
                                                                                                                                        {
                                                                                                                                            IEnumerable<CqlDate> qzzzzzi_ = TenthList?.NewList;
                                                                                                                                            int? qzzzzzj_ = TenthList?.IndexofNewDate;
                                                                                                                                            CqlDate qzzzzzk_ = context.Operators.Indexer<CqlDate>(qzzzzzi_, qzzzzzj_);
                                                                                                                                            CqlQuantity qzzzzzl_ = context.Operators.Quantity(1m, "day");
                                                                                                                                            CqlDate qzzzzzm_ = context.Operators.Add(qzzzzzk_ as CqlDate, qzzzzzl_);
                                                                                                                                            CqlDate qzzzzzp_ = context.Operators.Indexer<CqlDate>(qzzzzzi_, qzzzzzj_);
                                                                                                                                            CqlQuantity qzzzzzq_ = context.Operators.Quantity(30m, "days");
                                                                                                                                            CqlDate qzzzzzr_ = context.Operators.Add(qzzzzzp_ as CqlDate, qzzzzzq_);
                                                                                                                                            CqlInterval<CqlDate> qzzzzzs_ = context.Operators.Interval(qzzzzzm_, qzzzzzr_, true, true);
                                                                                                                                            bool? qzzzzzt_ = context.Operators.In<CqlDate>(X, qzzzzzs_, default);
                                                                                                                                            bool? qzzzzzu_ = context.Operators.Not(qzzzzzt_);

                                                                                                                                            return qzzzzzu_;
                                                                                                                                        };
                                                                                                                                        IEnumerable<CqlDate> pzzzzzz_ = context.Operators.Where<CqlDate>(pzzzzzu_, pzzzzzy_);
                                                                                                                                        int? qzzzzzb_ = context.Operators.Add(pzzzzzv_, 1);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzzc_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, pzzzzzw_ as CqlDate, pzzzzzz_, qzzzzzb_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] qzzzzzd_ = [
                                                                                                                                            qzzzzzc_,
                                                                                                                                        ];
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzze_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList)
                                                                                                                                        {
                                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzzv_()
                                                                                                                                            {
                                                                                                                                                bool qzzzzzw_()
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> qzzzzzx_ = EleventhList?.NewList;
                                                                                                                                                    int? qzzzzzy_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate qzzzzzz_ = context.Operators.Indexer<CqlDate>(qzzzzzx_, qzzzzzy_);

                                                                                                                                                    return qzzzzzz_ is null;
                                                                                                                                                };
                                                                                                                                                if (qzzzzzw_())
                                                                                                                                                {
                                                                                                                                                    return EleventhList;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> rzzzzza_ = EleventhList?.NewList;
                                                                                                                                                    int? rzzzzzb_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate rzzzzzc_ = context.Operators.Indexer<CqlDate>(rzzzzza_, rzzzzzb_);
                                                                                                                                                    bool? rzzzzze_(CqlDate X)
                                                                                                                                                    {
                                                                                                                                                        IEnumerable<CqlDate> rzzzzzj_ = EleventhList?.NewList;
                                                                                                                                                        int? rzzzzzk_ = EleventhList?.IndexofNewDate;
                                                                                                                                                        CqlDate rzzzzzl_ = context.Operators.Indexer<CqlDate>(rzzzzzj_, rzzzzzk_);
                                                                                                                                                        CqlQuantity rzzzzzm_ = context.Operators.Quantity(1m, "day");
                                                                                                                                                        CqlDate rzzzzzn_ = context.Operators.Add(rzzzzzl_ as CqlDate, rzzzzzm_);
                                                                                                                                                        CqlDate rzzzzzq_ = context.Operators.Indexer<CqlDate>(rzzzzzj_, rzzzzzk_);
                                                                                                                                                        CqlQuantity rzzzzzr_ = context.Operators.Quantity(30m, "days");
                                                                                                                                                        CqlDate rzzzzzs_ = context.Operators.Add(rzzzzzq_ as CqlDate, rzzzzzr_);
                                                                                                                                                        CqlInterval<CqlDate> rzzzzzt_ = context.Operators.Interval(rzzzzzn_, rzzzzzs_, true, true);
                                                                                                                                                        bool? rzzzzzu_ = context.Operators.In<CqlDate>(X, rzzzzzt_, default);
                                                                                                                                                        bool? rzzzzzv_ = context.Operators.Not(rzzzzzu_);

                                                                                                                                                        return rzzzzzv_;
                                                                                                                                                    };
                                                                                                                                                    IEnumerable<CqlDate> rzzzzzf_ = context.Operators.Where<CqlDate>(rzzzzza_, rzzzzze_);
                                                                                                                                                    int? rzzzzzh_ = context.Operators.Add(rzzzzzb_, 1);
                                                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzzi_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, rzzzzzc_ as CqlDate, rzzzzzf_, rzzzzzh_);

                                                                                                                                                    return rzzzzzi_;
                                                                                                                                                }
                                                                                                                                            };

                                                                                                                                            return qzzzzzv_();
                                                                                                                                        };
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzzzzf_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)qzzzzzd_, qzzzzze_);
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzzzzg_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzzzzf_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzzh_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzzzzg_);

                                                                                                                                        return qzzzzzh_;
                                                                                                                                    }
                                                                                                                                };

                                                                                                                                return pzzzzzp_();
                                                                                                                            };
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzzzz_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ozzzzzx_, ozzzzzy_);
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzzzza_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzzzz_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzb_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzzzza_);

                                                                                                                            return pzzzzzb_;
                                                                                                                        }
                                                                                                                    };

                                                                                                                    return ozzzzzj_();
                                                                                                                };
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> nzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)nzzzzzr_, nzzzzzs_);
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> nzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(nzzzzzt_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(nzzzzzu_);

                                                                                                                return nzzzzzv_;
                                                                                                            }
                                                                                                        };

                                                                                                        return nzzzzzd_();
                                                                                                    };
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> mzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)mzzzzzl_, mzzzzzm_);
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> mzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(mzzzzzn_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(mzzzzzo_);

                                                                                                    return mzzzzzp_;
                                                                                                }
                                                                                            };

                                                                                            return lzzzzzx_();
                                                                                        };
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)lzzzzzf_, lzzzzzg_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lzzzzzh_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lzzzzzi_);

                                                                                        return lzzzzzj_;
                                                                                    }
                                                                                };

                                                                                return kzzzzzr_();
                                                                            };
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)jzzzzzz_, kzzzzza_);
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kzzzzzb_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kzzzzzc_);

                                                                            return kzzzzzd_;
                                                                        }
                                                                    };

                                                                    return jzzzzzl_();
                                                                };
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> izzzzzv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)izzzzzt_, izzzzzu_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> izzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(izzzzzv_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? izzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(izzzzzw_);

                                                                return izzzzzx_;
                                                            }
                                                        };

                                                        return izzzzzf_();
                                                    };
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)hzzzzzn_, hzzzzzo_);
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> hzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hzzzzzp_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? hzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(hzzzzzq_);

                                                    return hzzzzzr_;
                                                }
                                            };

                                            return gzzzzzz_();
                                        };
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)gzzzzzh_, gzzzzzi_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> gzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gzzzzzj_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? gzzzzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(gzzzzzk_);

                                        return gzzzzzl_;
                                    }
                                };

                                return fzzzzzt_();
                            };
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fzzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)fzzzzzb_, fzzzzzc_);
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> fzzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fzzzzzd_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? fzzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(fzzzzze_);

                            return fzzzzzf_;
                        }
                    };

                    return ezzzzzn_();
                };
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)dzzzzzv_, dzzzzzw_);
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dzzzzzx_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dzzzzzy_);

                return dzzzzzz_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dzzzzzk_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)dzzzzzi_, dzzzzzj_);
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dzzzzzl_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dzzzzzk_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzzzm_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dzzzzzl_);

            return dzzzzzm_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dzzzzzc_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?>)dzzzzza_, dzzzzzb_);
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> dzzzzzd_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dzzzzzc_);
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? dzzzzze_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(dzzzzzd_);

        return dzzzzze_;
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
