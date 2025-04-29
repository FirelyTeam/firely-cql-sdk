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
        IEnumerable<Patient> szzzzx_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/StructureDefinition/Patient"));
        Patient szzzzy_ = context.Operators.SingletonFrom<Patient>(szzzzx_);

        return szzzzy_;
    }


    [CqlExpressionDefinition("Normalize Onset")]
    public CqlInterval<CqlDateTime> Normalize_Onset(CqlContext context, object onset)
    {
        CqlInterval<CqlDateTime> szzzzz_()
        {
            if (onset is FhirDateTime)
            {
                CqlDateTime tzzzza_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, onset as FhirDateTime);
                CqlInterval<CqlDateTime> tzzzzc_ = context.Operators.Interval(tzzzza_, tzzzza_, true, true);

                return tzzzzc_;
            }
            else if (onset is Period)
            {
                FhirDateTime tzzzzd_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "start");
                CqlDateTime tzzzze_ = context.Operators.Convert<CqlDateTime>(tzzzzd_);
                FhirDateTime tzzzzf_ = context.Operators.LateBoundProperty<FhirDateTime>(onset, "end");
                CqlDateTime tzzzzg_ = context.Operators.Convert<CqlDateTime>(tzzzzf_);
                CqlInterval<CqlDateTime> tzzzzh_ = context.Operators.Interval(tzzzze_, tzzzzg_, true, true);

                return tzzzzh_;
            }
            else if (onset is FhirString)
            {
                CqlInterval<CqlDateTime> tzzzzi_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return tzzzzi_;
            }
            else
            {
                CqlInterval<CqlDate> tzzzzj_()
                {
                    if (onset is Age)
                    {
                        Patient tzzzzu_ = this.Patient(context);
                        Date tzzzzv_ = tzzzzu_?.BirthDateElement;
                        CqlDate tzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, tzzzzv_);
                        CqlQuantity tzzzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate tzzzzy_ = context.Operators.Add(tzzzzw_, tzzzzx_);
                        Date uzzzza_ = tzzzzu_?.BirthDateElement;
                        CqlDate uzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzzza_);
                        CqlDate uzzzzd_ = context.Operators.Add(uzzzzb_, tzzzzx_);
                        CqlQuantity uzzzze_ = context.Operators.Quantity(1m, "year");
                        CqlDate uzzzzf_ = context.Operators.Add(uzzzzd_, uzzzze_);
                        CqlInterval<CqlDate> uzzzzg_ = context.Operators.Interval(tzzzzy_, uzzzzf_, true, false);

                        return uzzzzg_;
                    }
                    else if (onset is Range)
                    {
                        Patient uzzzzh_ = this.Patient(context);
                        Date uzzzzi_ = uzzzzh_?.BirthDateElement;
                        CqlDate uzzzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzzzi_);
                        Quantity uzzzzk_ = (onset as Range)?.Low;
                        CqlQuantity uzzzzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzzzk_);
                        CqlDate uzzzzm_ = context.Operators.Add(uzzzzj_, uzzzzl_);
                        Date uzzzzo_ = uzzzzh_?.BirthDateElement;
                        CqlDate uzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzzzo_);
                        Quantity uzzzzq_ = (onset as Range)?.High;
                        CqlQuantity uzzzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, uzzzzq_);
                        CqlDate uzzzzs_ = context.Operators.Add(uzzzzp_, uzzzzr_);
                        CqlQuantity uzzzzt_ = context.Operators.Quantity(1m, "year");
                        CqlDate uzzzzu_ = context.Operators.Add(uzzzzs_, uzzzzt_);
                        CqlInterval<CqlDate> uzzzzv_ = context.Operators.Interval(uzzzzm_, uzzzzu_, true, false);

                        return uzzzzv_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate tzzzzk_ = (tzzzzj_())?.low;
                CqlDateTime tzzzzl_ = context.Operators.ConvertDateToDateTime(tzzzzk_);
                CqlInterval<CqlDate> tzzzzm_()
                {
                    if (onset is Age)
                    {
                        Patient uzzzzw_ = this.Patient(context);
                        Date uzzzzx_ = uzzzzw_?.BirthDateElement;
                        CqlDate uzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, uzzzzx_);
                        CqlQuantity uzzzzz_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate vzzzza_ = context.Operators.Add(uzzzzy_, uzzzzz_);
                        Date vzzzzc_ = uzzzzw_?.BirthDateElement;
                        CqlDate vzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzzzc_);
                        CqlDate vzzzzf_ = context.Operators.Add(vzzzzd_, uzzzzz_);
                        CqlQuantity vzzzzg_ = context.Operators.Quantity(1m, "year");
                        CqlDate vzzzzh_ = context.Operators.Add(vzzzzf_, vzzzzg_);
                        CqlInterval<CqlDate> vzzzzi_ = context.Operators.Interval(vzzzza_, vzzzzh_, true, false);

                        return vzzzzi_;
                    }
                    else if (onset is Range)
                    {
                        Patient vzzzzj_ = this.Patient(context);
                        Date vzzzzk_ = vzzzzj_?.BirthDateElement;
                        CqlDate vzzzzl_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzzzk_);
                        Quantity vzzzzm_ = (onset as Range)?.Low;
                        CqlQuantity vzzzzn_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzzzm_);
                        CqlDate vzzzzo_ = context.Operators.Add(vzzzzl_, vzzzzn_);
                        Date vzzzzq_ = vzzzzj_?.BirthDateElement;
                        CqlDate vzzzzr_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzzzq_);
                        Quantity vzzzzs_ = (onset as Range)?.High;
                        CqlQuantity vzzzzt_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, vzzzzs_);
                        CqlDate vzzzzu_ = context.Operators.Add(vzzzzr_, vzzzzt_);
                        CqlQuantity vzzzzv_ = context.Operators.Quantity(1m, "year");
                        CqlDate vzzzzw_ = context.Operators.Add(vzzzzu_, vzzzzv_);
                        CqlInterval<CqlDate> vzzzzx_ = context.Operators.Interval(vzzzzo_, vzzzzw_, true, false);

                        return vzzzzx_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate tzzzzn_ = (tzzzzm_())?.high;
                CqlDateTime tzzzzo_ = context.Operators.ConvertDateToDateTime(tzzzzn_);
                CqlInterval<CqlDate> tzzzzp_()
                {
                    if (onset is Age)
                    {
                        Patient vzzzzy_ = this.Patient(context);
                        Date vzzzzz_ = vzzzzy_?.BirthDateElement;
                        CqlDate wzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, vzzzzz_);
                        CqlQuantity wzzzzb_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate wzzzzc_ = context.Operators.Add(wzzzza_, wzzzzb_);
                        Date wzzzze_ = vzzzzy_?.BirthDateElement;
                        CqlDate wzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzzze_);
                        CqlDate wzzzzh_ = context.Operators.Add(wzzzzf_, wzzzzb_);
                        CqlQuantity wzzzzi_ = context.Operators.Quantity(1m, "year");
                        CqlDate wzzzzj_ = context.Operators.Add(wzzzzh_, wzzzzi_);
                        CqlInterval<CqlDate> wzzzzk_ = context.Operators.Interval(wzzzzc_, wzzzzj_, true, false);

                        return wzzzzk_;
                    }
                    else if (onset is Range)
                    {
                        Patient wzzzzl_ = this.Patient(context);
                        Date wzzzzm_ = wzzzzl_?.BirthDateElement;
                        CqlDate wzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzzzm_);
                        Quantity wzzzzo_ = (onset as Range)?.Low;
                        CqlQuantity wzzzzp_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, wzzzzo_);
                        CqlDate wzzzzq_ = context.Operators.Add(wzzzzn_, wzzzzp_);
                        Date wzzzzs_ = wzzzzl_?.BirthDateElement;
                        CqlDate wzzzzt_ = FHIRHelpers_4_0_001.Instance.ToDate(context, wzzzzs_);
                        Quantity wzzzzu_ = (onset as Range)?.High;
                        CqlQuantity wzzzzv_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, wzzzzu_);
                        CqlDate wzzzzw_ = context.Operators.Add(wzzzzt_, wzzzzv_);
                        CqlQuantity wzzzzx_ = context.Operators.Quantity(1m, "year");
                        CqlDate wzzzzy_ = context.Operators.Add(wzzzzw_, wzzzzx_);
                        CqlInterval<CqlDate> wzzzzz_ = context.Operators.Interval(wzzzzq_, wzzzzy_, true, false);

                        return wzzzzz_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? tzzzzq_ = (tzzzzp_())?.lowClosed;
                CqlInterval<CqlDate> tzzzzr_()
                {
                    if (onset is Age)
                    {
                        Patient xzzzza_ = this.Patient(context);
                        Date xzzzzb_ = xzzzza_?.BirthDateElement;
                        CqlDate xzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzzzb_);
                        CqlQuantity xzzzzd_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, onset as Age);
                        CqlDate xzzzze_ = context.Operators.Add(xzzzzc_, xzzzzd_);
                        Date xzzzzg_ = xzzzza_?.BirthDateElement;
                        CqlDate xzzzzh_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzzzg_);
                        CqlDate xzzzzj_ = context.Operators.Add(xzzzzh_, xzzzzd_);
                        CqlQuantity xzzzzk_ = context.Operators.Quantity(1m, "year");
                        CqlDate xzzzzl_ = context.Operators.Add(xzzzzj_, xzzzzk_);
                        CqlInterval<CqlDate> xzzzzm_ = context.Operators.Interval(xzzzze_, xzzzzl_, true, false);

                        return xzzzzm_;
                    }
                    else if (onset is Range)
                    {
                        Patient xzzzzn_ = this.Patient(context);
                        Date xzzzzo_ = xzzzzn_?.BirthDateElement;
                        CqlDate xzzzzp_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzzzo_);
                        Quantity xzzzzq_ = (onset as Range)?.Low;
                        CqlQuantity xzzzzr_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzzzq_);
                        CqlDate xzzzzs_ = context.Operators.Add(xzzzzp_, xzzzzr_);
                        Date xzzzzu_ = xzzzzn_?.BirthDateElement;
                        CqlDate xzzzzv_ = FHIRHelpers_4_0_001.Instance.ToDate(context, xzzzzu_);
                        Quantity xzzzzw_ = (onset as Range)?.High;
                        CqlQuantity xzzzzx_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, xzzzzw_);
                        CqlDate xzzzzy_ = context.Operators.Add(xzzzzv_, xzzzzx_);
                        CqlQuantity xzzzzz_ = context.Operators.Quantity(1m, "year");
                        CqlDate yzzzza_ = context.Operators.Add(xzzzzy_, xzzzzz_);
                        CqlInterval<CqlDate> yzzzzb_ = context.Operators.Interval(xzzzzs_, yzzzza_, true, false);

                        return yzzzzb_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? tzzzzs_ = (tzzzzr_())?.highClosed;
                CqlInterval<CqlDateTime> tzzzzt_ = context.Operators.Interval(tzzzzl_, tzzzzo_, tzzzzq_, tzzzzs_);

                return tzzzzt_;
            }
        };

        return szzzzz_();
    }


    [CqlExpressionDefinition("Normalize Abatement")]
    public CqlInterval<CqlDateTime> Normalize_Abatement(CqlContext context, object abatement)
    {
        CqlInterval<CqlDateTime> yzzzzc_()
        {
            if (abatement is FhirDateTime)
            {
                CqlDateTime yzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, abatement as FhirDateTime);
                CqlInterval<CqlDateTime> yzzzzf_ = context.Operators.Interval(yzzzzd_, yzzzzd_, true, true);

                return yzzzzf_;
            }
            else if (abatement is Period)
            {
                FhirDateTime yzzzzg_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "start");
                CqlDateTime yzzzzh_ = context.Operators.Convert<CqlDateTime>(yzzzzg_);
                FhirDateTime yzzzzi_ = context.Operators.LateBoundProperty<FhirDateTime>(abatement, "end");
                CqlDateTime yzzzzj_ = context.Operators.Convert<CqlDateTime>(yzzzzi_);
                CqlInterval<CqlDateTime> yzzzzk_ = context.Operators.Interval(yzzzzh_, yzzzzj_, true, true);

                return yzzzzk_;
            }
            else if (abatement is FhirString)
            {
                CqlInterval<CqlDateTime> yzzzzl_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return yzzzzl_;
            }
            else
            {
                CqlInterval<CqlDate> yzzzzm_()
                {
                    if (abatement is Age)
                    {
                        Patient yzzzzx_ = this.Patient(context);
                        Date yzzzzy_ = yzzzzx_?.BirthDateElement;
                        CqlDate yzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, yzzzzy_);
                        CqlQuantity zzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate zzzzzb_ = context.Operators.Add(yzzzzz_, zzzzza_);
                        Date zzzzzd_ = yzzzzx_?.BirthDateElement;
                        CqlDate zzzzze_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzd_);
                        CqlDate zzzzzg_ = context.Operators.Add(zzzzze_, zzzzza_);
                        CqlQuantity zzzzzh_ = context.Operators.Quantity(1m, "year");
                        CqlDate zzzzzi_ = context.Operators.Add(zzzzzg_, zzzzzh_);
                        CqlInterval<CqlDate> zzzzzj_ = context.Operators.Interval(zzzzzb_, zzzzzi_, true, false);

                        return zzzzzj_;
                    }
                    else if (abatement is Range)
                    {
                        Patient zzzzzk_ = this.Patient(context);
                        Date zzzzzl_ = zzzzzk_?.BirthDateElement;
                        CqlDate zzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzl_);
                        Quantity zzzzzn_ = (abatement as Range)?.Low;
                        CqlQuantity zzzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzn_);
                        CqlDate zzzzzp_ = context.Operators.Add(zzzzzm_, zzzzzo_);
                        Date zzzzzr_ = zzzzzk_?.BirthDateElement;
                        CqlDate zzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, zzzzzr_);
                        Quantity zzzzzt_ = (abatement as Range)?.High;
                        CqlQuantity zzzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, zzzzzt_);
                        CqlDate zzzzzv_ = context.Operators.Add(zzzzzs_, zzzzzu_);
                        CqlQuantity zzzzzw_ = context.Operators.Quantity(1m, "year");
                        CqlDate zzzzzx_ = context.Operators.Add(zzzzzv_, zzzzzw_);
                        CqlInterval<CqlDate> zzzzzy_ = context.Operators.Interval(zzzzzp_, zzzzzx_, true, false);

                        return zzzzzy_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate yzzzzn_ = (yzzzzm_())?.low;
                CqlDateTime yzzzzo_ = context.Operators.ConvertDateToDateTime(yzzzzn_);
                CqlInterval<CqlDate> yzzzzp_()
                {
                    if (abatement is Age)
                    {
                        Patient zzzzzz_ = this.Patient(context);
                        Date azzzzza_ = zzzzzz_?.BirthDateElement;
                        CqlDate azzzzzb_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzza_);
                        CqlQuantity azzzzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate azzzzzd_ = context.Operators.Add(azzzzzb_, azzzzzc_);
                        Date azzzzzf_ = zzzzzz_?.BirthDateElement;
                        CqlDate azzzzzg_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzf_);
                        CqlDate azzzzzi_ = context.Operators.Add(azzzzzg_, azzzzzc_);
                        CqlQuantity azzzzzj_ = context.Operators.Quantity(1m, "year");
                        CqlDate azzzzzk_ = context.Operators.Add(azzzzzi_, azzzzzj_);
                        CqlInterval<CqlDate> azzzzzl_ = context.Operators.Interval(azzzzzd_, azzzzzk_, true, false);

                        return azzzzzl_;
                    }
                    else if (abatement is Range)
                    {
                        Patient azzzzzm_ = this.Patient(context);
                        Date azzzzzn_ = azzzzzm_?.BirthDateElement;
                        CqlDate azzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzn_);
                        Quantity azzzzzp_ = (abatement as Range)?.Low;
                        CqlQuantity azzzzzq_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzzzzp_);
                        CqlDate azzzzzr_ = context.Operators.Add(azzzzzo_, azzzzzq_);
                        Date azzzzzt_ = azzzzzm_?.BirthDateElement;
                        CqlDate azzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, azzzzzt_);
                        Quantity azzzzzv_ = (abatement as Range)?.High;
                        CqlQuantity azzzzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, azzzzzv_);
                        CqlDate azzzzzx_ = context.Operators.Add(azzzzzu_, azzzzzw_);
                        CqlQuantity azzzzzy_ = context.Operators.Quantity(1m, "year");
                        CqlDate azzzzzz_ = context.Operators.Add(azzzzzx_, azzzzzy_);
                        CqlInterval<CqlDate> bzzzzza_ = context.Operators.Interval(azzzzzr_, azzzzzz_, true, false);

                        return bzzzzza_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                CqlDate yzzzzq_ = (yzzzzp_())?.high;
                CqlDateTime yzzzzr_ = context.Operators.ConvertDateToDateTime(yzzzzq_);
                CqlInterval<CqlDate> yzzzzs_()
                {
                    if (abatement is Age)
                    {
                        Patient bzzzzzb_ = this.Patient(context);
                        Date bzzzzzc_ = bzzzzzb_?.BirthDateElement;
                        CqlDate bzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzc_);
                        CqlQuantity bzzzzze_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate bzzzzzf_ = context.Operators.Add(bzzzzzd_, bzzzzze_);
                        Date bzzzzzh_ = bzzzzzb_?.BirthDateElement;
                        CqlDate bzzzzzi_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzh_);
                        CqlDate bzzzzzk_ = context.Operators.Add(bzzzzzi_, bzzzzze_);
                        CqlQuantity bzzzzzl_ = context.Operators.Quantity(1m, "year");
                        CqlDate bzzzzzm_ = context.Operators.Add(bzzzzzk_, bzzzzzl_);
                        CqlInterval<CqlDate> bzzzzzn_ = context.Operators.Interval(bzzzzzf_, bzzzzzm_, true, false);

                        return bzzzzzn_;
                    }
                    else if (abatement is Range)
                    {
                        Patient bzzzzzo_ = this.Patient(context);
                        Date bzzzzzp_ = bzzzzzo_?.BirthDateElement;
                        CqlDate bzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzp_);
                        Quantity bzzzzzr_ = (abatement as Range)?.Low;
                        CqlQuantity bzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzzzr_);
                        CqlDate bzzzzzt_ = context.Operators.Add(bzzzzzq_, bzzzzzs_);
                        Date bzzzzzv_ = bzzzzzo_?.BirthDateElement;
                        CqlDate bzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToDate(context, bzzzzzv_);
                        Quantity bzzzzzx_ = (abatement as Range)?.High;
                        CqlQuantity bzzzzzy_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, bzzzzzx_);
                        CqlDate bzzzzzz_ = context.Operators.Add(bzzzzzw_, bzzzzzy_);
                        CqlQuantity czzzzza_ = context.Operators.Quantity(1m, "year");
                        CqlDate czzzzzb_ = context.Operators.Add(bzzzzzz_, czzzzza_);
                        CqlInterval<CqlDate> czzzzzc_ = context.Operators.Interval(bzzzzzt_, czzzzzb_, true, false);

                        return czzzzzc_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? yzzzzt_ = (yzzzzs_())?.lowClosed;
                CqlInterval<CqlDate> yzzzzu_()
                {
                    if (abatement is Age)
                    {
                        Patient czzzzzd_ = this.Patient(context);
                        Date czzzzze_ = czzzzzd_?.BirthDateElement;
                        CqlDate czzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzzzze_);
                        CqlQuantity czzzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, abatement as Age);
                        CqlDate czzzzzh_ = context.Operators.Add(czzzzzf_, czzzzzg_);
                        Date czzzzzj_ = czzzzzd_?.BirthDateElement;
                        CqlDate czzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzzzzj_);
                        CqlDate czzzzzm_ = context.Operators.Add(czzzzzk_, czzzzzg_);
                        CqlQuantity czzzzzn_ = context.Operators.Quantity(1m, "year");
                        CqlDate czzzzzo_ = context.Operators.Add(czzzzzm_, czzzzzn_);
                        CqlInterval<CqlDate> czzzzzp_ = context.Operators.Interval(czzzzzh_, czzzzzo_, true, false);

                        return czzzzzp_;
                    }
                    else if (abatement is Range)
                    {
                        Patient czzzzzq_ = this.Patient(context);
                        Date czzzzzr_ = czzzzzq_?.BirthDateElement;
                        CqlDate czzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzzzzr_);
                        Quantity czzzzzt_ = (abatement as Range)?.Low;
                        CqlQuantity czzzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzzzt_);
                        CqlDate czzzzzv_ = context.Operators.Add(czzzzzs_, czzzzzu_);
                        Date czzzzzx_ = czzzzzq_?.BirthDateElement;
                        CqlDate czzzzzy_ = FHIRHelpers_4_0_001.Instance.ToDate(context, czzzzzx_);
                        Quantity czzzzzz_ = (abatement as Range)?.High;
                        CqlQuantity dzzzzza_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, czzzzzz_);
                        CqlDate dzzzzzb_ = context.Operators.Add(czzzzzy_, dzzzzza_);
                        CqlQuantity dzzzzzc_ = context.Operators.Quantity(1m, "year");
                        CqlDate dzzzzzd_ = context.Operators.Add(dzzzzzb_, dzzzzzc_);
                        CqlInterval<CqlDate> dzzzzze_ = context.Operators.Interval(czzzzzv_, dzzzzzd_, true, false);

                        return dzzzzze_;
                    }
                    else
                    {
                        return null as CqlInterval<CqlDate>;
                    }
                };
                bool? yzzzzv_ = (yzzzzu_())?.highClosed;
                CqlInterval<CqlDateTime> yzzzzw_ = context.Operators.Interval(yzzzzo_, yzzzzr_, yzzzzt_, yzzzzv_);

                return yzzzzw_;
            }
        };

        return yzzzzc_();
    }


    [CqlExpressionDefinition("Prevalence Period")]
    public CqlInterval<CqlDateTime> Prevalence_Period(CqlContext context, Condition condition)
    {
        DataType dzzzzzf_ = condition?.Onset;
        CqlInterval<CqlDateTime> dzzzzzg_ = this.Normalize_Onset(context, dzzzzzf_);
        CqlDateTime dzzzzzh_ = context.Operators.Start(dzzzzzg_);
        DataType dzzzzzi_ = condition?.Abatement;
        CqlInterval<CqlDateTime> dzzzzzj_ = this.Normalize_Abatement(context, dzzzzzi_);
        CqlDateTime dzzzzzk_ = context.Operators.End(dzzzzzj_);
        CqlInterval<CqlDateTime> dzzzzzl_ = context.Operators.Interval(dzzzzzh_, dzzzzzk_, true, true);

        return dzzzzzl_;
    }


    [CqlExpressionDefinition("Normalize Interval")]
    public CqlInterval<CqlDateTime> Normalize_Interval(CqlContext context, object choice)
    {
        CqlInterval<CqlDateTime> dzzzzzm_()
        {
            if (choice is FhirDateTime)
            {
                CqlDateTime dzzzzzn_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as FhirDateTime);
                CqlInterval<CqlDateTime> dzzzzzp_ = context.Operators.Interval(dzzzzzn_, dzzzzzn_, true, true);

                return dzzzzzp_;
            }
            else if (choice is Date)
            {
                CqlDate dzzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, choice as Date);
                CqlDateTime dzzzzzr_ = context.Operators.ConvertDateToDateTime(dzzzzzq_);
                CqlDateTime dzzzzzt_ = context.Operators.ConvertDateToDateTime(dzzzzzq_);
                CqlInterval<CqlDateTime> dzzzzzu_ = context.Operators.Interval(dzzzzzr_, dzzzzzt_, true, true);

                return dzzzzzu_;
            }
            else if (choice is Period)
            {
                FhirDateTime dzzzzzv_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "start");
                CqlDateTime dzzzzzw_ = context.Operators.Convert<CqlDateTime>(dzzzzzv_);
                FhirDateTime dzzzzzx_ = context.Operators.LateBoundProperty<FhirDateTime>(choice, "end");
                CqlDateTime dzzzzzy_ = context.Operators.Convert<CqlDateTime>(dzzzzzx_);
                CqlInterval<CqlDateTime> dzzzzzz_ = context.Operators.Interval(dzzzzzw_, dzzzzzy_, true, true);

                return dzzzzzz_;
            }
            else if (choice is Instant)
            {
                CqlDateTime ezzzzza_ = FHIRHelpers_4_0_001.Instance.ToDateTime(context, choice as Instant);
                CqlInterval<CqlDateTime> ezzzzzc_ = context.Operators.Interval(ezzzzza_, ezzzzza_, true, true);

                return ezzzzzc_;
            }
            else if (choice is Age)
            {
                Patient ezzzzzd_ = this.Patient(context);
                Date ezzzzze_ = ezzzzzd_?.BirthDateElement;
                CqlDate ezzzzzf_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezzzzze_);
                CqlQuantity ezzzzzg_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, choice as Age);
                CqlDate ezzzzzh_ = context.Operators.Add(ezzzzzf_, ezzzzzg_);
                Date ezzzzzj_ = ezzzzzd_?.BirthDateElement;
                CqlDate ezzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezzzzzj_);
                CqlDate ezzzzzm_ = context.Operators.Add(ezzzzzk_, ezzzzzg_);
                CqlQuantity ezzzzzn_ = context.Operators.Quantity(1m, "year");
                CqlDate ezzzzzo_ = context.Operators.Add(ezzzzzm_, ezzzzzn_);
                CqlInterval<CqlDate> ezzzzzp_ = context.Operators.Interval(ezzzzzh_, ezzzzzo_, true, false);
                CqlDate ezzzzzq_ = ezzzzzp_?.low;
                CqlDateTime ezzzzzr_ = context.Operators.ConvertDateToDateTime(ezzzzzq_);
                Date ezzzzzt_ = ezzzzzd_?.BirthDateElement;
                CqlDate ezzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezzzzzt_);
                CqlDate ezzzzzw_ = context.Operators.Add(ezzzzzu_, ezzzzzg_);
                Date ezzzzzy_ = ezzzzzd_?.BirthDateElement;
                CqlDate ezzzzzz_ = FHIRHelpers_4_0_001.Instance.ToDate(context, ezzzzzy_);
                CqlDate fzzzzzb_ = context.Operators.Add(ezzzzzz_, ezzzzzg_);
                CqlDate fzzzzzd_ = context.Operators.Add(fzzzzzb_, ezzzzzn_);
                CqlInterval<CqlDate> fzzzzze_ = context.Operators.Interval(ezzzzzw_, fzzzzzd_, true, false);
                CqlDate fzzzzzf_ = fzzzzze_?.high;
                CqlDateTime fzzzzzg_ = context.Operators.ConvertDateToDateTime(fzzzzzf_);
                Date fzzzzzi_ = ezzzzzd_?.BirthDateElement;
                CqlDate fzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzzzzi_);
                CqlDate fzzzzzl_ = context.Operators.Add(fzzzzzj_, ezzzzzg_);
                Date fzzzzzn_ = ezzzzzd_?.BirthDateElement;
                CqlDate fzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzzzzn_);
                CqlDate fzzzzzq_ = context.Operators.Add(fzzzzzo_, ezzzzzg_);
                CqlDate fzzzzzs_ = context.Operators.Add(fzzzzzq_, ezzzzzn_);
                CqlInterval<CqlDate> fzzzzzt_ = context.Operators.Interval(fzzzzzl_, fzzzzzs_, true, false);
                bool? fzzzzzu_ = fzzzzzt_?.lowClosed;
                Date fzzzzzw_ = ezzzzzd_?.BirthDateElement;
                CqlDate fzzzzzx_ = FHIRHelpers_4_0_001.Instance.ToDate(context, fzzzzzw_);
                CqlDate fzzzzzz_ = context.Operators.Add(fzzzzzx_, ezzzzzg_);
                Date gzzzzzb_ = ezzzzzd_?.BirthDateElement;
                CqlDate gzzzzzc_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzzzzb_);
                CqlDate gzzzzze_ = context.Operators.Add(gzzzzzc_, ezzzzzg_);
                CqlDate gzzzzzg_ = context.Operators.Add(gzzzzze_, ezzzzzn_);
                CqlInterval<CqlDate> gzzzzzh_ = context.Operators.Interval(fzzzzzz_, gzzzzzg_, true, false);
                bool? gzzzzzi_ = gzzzzzh_?.highClosed;
                CqlInterval<CqlDateTime> gzzzzzj_ = context.Operators.Interval(ezzzzzr_, fzzzzzg_, fzzzzzu_, gzzzzzi_);

                return gzzzzzj_;
            }
            else if (choice is Range)
            {
                Patient gzzzzzk_ = this.Patient(context);
                Date gzzzzzl_ = gzzzzzk_?.BirthDateElement;
                CqlDate gzzzzzm_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzzzzl_);
                Quantity gzzzzzn_ = (choice as Range)?.Low;
                CqlQuantity gzzzzzo_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzn_);
                CqlDate gzzzzzp_ = context.Operators.Add(gzzzzzm_, gzzzzzo_);
                Date gzzzzzr_ = gzzzzzk_?.BirthDateElement;
                CqlDate gzzzzzs_ = FHIRHelpers_4_0_001.Instance.ToDate(context, gzzzzzr_);
                Quantity gzzzzzt_ = (choice as Range)?.High;
                CqlQuantity gzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzt_);
                CqlDate gzzzzzv_ = context.Operators.Add(gzzzzzs_, gzzzzzu_);
                CqlQuantity gzzzzzw_ = context.Operators.Quantity(1m, "year");
                CqlDate gzzzzzx_ = context.Operators.Add(gzzzzzv_, gzzzzzw_);
                CqlInterval<CqlDate> gzzzzzy_ = context.Operators.Interval(gzzzzzp_, gzzzzzx_, true, false);
                CqlDate gzzzzzz_ = gzzzzzy_?.low;
                CqlDateTime hzzzzza_ = context.Operators.ConvertDateToDateTime(gzzzzzz_);
                Date hzzzzzc_ = gzzzzzk_?.BirthDateElement;
                CqlDate hzzzzzd_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzc_);
                CqlQuantity hzzzzzf_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzn_);
                CqlDate hzzzzzg_ = context.Operators.Add(hzzzzzd_, hzzzzzf_);
                Date hzzzzzi_ = gzzzzzk_?.BirthDateElement;
                CqlDate hzzzzzj_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzi_);
                CqlQuantity hzzzzzl_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzt_);
                CqlDate hzzzzzm_ = context.Operators.Add(hzzzzzj_, hzzzzzl_);
                CqlDate hzzzzzo_ = context.Operators.Add(hzzzzzm_, gzzzzzw_);
                CqlInterval<CqlDate> hzzzzzp_ = context.Operators.Interval(hzzzzzg_, hzzzzzo_, true, false);
                CqlDate hzzzzzq_ = hzzzzzp_?.high;
                CqlDateTime hzzzzzr_ = context.Operators.ConvertDateToDateTime(hzzzzzq_);
                Date hzzzzzt_ = gzzzzzk_?.BirthDateElement;
                CqlDate hzzzzzu_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzt_);
                CqlQuantity hzzzzzw_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzn_);
                CqlDate hzzzzzx_ = context.Operators.Add(hzzzzzu_, hzzzzzw_);
                Date hzzzzzz_ = gzzzzzk_?.BirthDateElement;
                CqlDate izzzzza_ = FHIRHelpers_4_0_001.Instance.ToDate(context, hzzzzzz_);
                CqlQuantity izzzzzc_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzt_);
                CqlDate izzzzzd_ = context.Operators.Add(izzzzza_, izzzzzc_);
                CqlDate izzzzzf_ = context.Operators.Add(izzzzzd_, gzzzzzw_);
                CqlInterval<CqlDate> izzzzzg_ = context.Operators.Interval(hzzzzzx_, izzzzzf_, true, false);
                bool? izzzzzh_ = izzzzzg_?.lowClosed;
                Date izzzzzj_ = gzzzzzk_?.BirthDateElement;
                CqlDate izzzzzk_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izzzzzj_);
                CqlQuantity izzzzzm_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzn_);
                CqlDate izzzzzn_ = context.Operators.Add(izzzzzk_, izzzzzm_);
                Date izzzzzp_ = gzzzzzk_?.BirthDateElement;
                CqlDate izzzzzq_ = FHIRHelpers_4_0_001.Instance.ToDate(context, izzzzzp_);
                CqlQuantity izzzzzs_ = FHIRHelpers_4_0_001.Instance.ToQuantity(context, gzzzzzt_);
                CqlDate izzzzzt_ = context.Operators.Add(izzzzzq_, izzzzzs_);
                CqlDate izzzzzv_ = context.Operators.Add(izzzzzt_, gzzzzzw_);
                CqlInterval<CqlDate> izzzzzw_ = context.Operators.Interval(izzzzzn_, izzzzzv_, true, false);
                bool? izzzzzx_ = izzzzzw_?.highClosed;
                CqlInterval<CqlDateTime> izzzzzy_ = context.Operators.Interval(hzzzzza_, hzzzzzr_, izzzzzh_, izzzzzx_);

                return izzzzzy_;
            }
            else if (choice is Timing)
            {
                CqlInterval<CqlDateTime> izzzzzz_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute a single interval from a Timing type");

                return izzzzzz_;
            }
            else if (choice is FhirString)
            {
                CqlInterval<CqlDateTime> jzzzzza_ = context.Operators.Message<CqlInterval<CqlDateTime>>(null as CqlInterval<CqlDateTime>, "1", "Error", "Cannot compute an interval from a String value");

                return jzzzzza_;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return dzzzzzm_();
    }


    [CqlExpressionDefinition("GetId")]
    public string GetId(CqlContext context, string uri)
    {
        string jzzzzzb_()
        {
            bool jzzzzzc_()
            {
                int? jzzzzzd_ = context.Operators.PositionOf("/", uri);
                bool? jzzzzze_ = context.Operators.Greater(jzzzzzd_, 0);

                return jzzzzze_ ?? false;
            };
            if (jzzzzzc_())
            {
                IEnumerable<string> jzzzzzf_ = context.Operators.Split(uri, "/");
                string jzzzzzg_ = context.Operators.Last<string>(jzzzzzf_);

                return jzzzzzg_;
            }
            else
            {
                return uri;
            }
        };

        return jzzzzzb_();
    }


    [CqlExpressionDefinition("VS Cast Function")]
    public IEnumerable<CqlCode> VS_Cast_Function(CqlContext context, IEnumerable<CqlCode> VSet) =>
        VSet;


    [CqlExpressionDefinition("First Dates per 31 Day Periods")]
    public (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? First_Dates_per_31_Day_Periods(CqlContext context, IEnumerable<CqlDate> DateList)
    {
        CqlDate jzzzzzh_(CqlDate d) =>
            d;
        IEnumerable<CqlDate> jzzzzzi_ = context.Operators.Select<CqlDate, CqlDate>(DateList, jzzzzzh_);
        IEnumerable<CqlDate> jzzzzzj_ = context.Operators.Distinct<CqlDate>(jzzzzzi_);
        IEnumerable<CqlDate> jzzzzzk_ = context.Operators.ListSort<CqlDate>(jzzzzzj_, System.ComponentModel.ListSortDirection.Ascending);
        bool? jzzzzzl_(CqlDate X)
        {
            bool? jzzzzzt_ = context.Operators.Not((bool?)(X is null));

            return jzzzzzt_;
        };
        IEnumerable<CqlDate> jzzzzzm_ = context.Operators.Where<CqlDate>(jzzzzzk_, jzzzzzl_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? jzzzzzn_ = (CqlTupleMetadata_CfANiScMYDdVZFgRERKJQEVca, jzzzzzm_);
        (CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?[] jzzzzzo_ = [
            jzzzzzn_,
        ];
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzzzp_((CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)? SortedDates)
        {
            IEnumerable<CqlDate> jzzzzzu_ = SortedDates?.SortedDates;
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? jzzzzzv_ = (CqlTupleMetadata_BDeBMdFeZaVSehBSFYjTFdYYD, jzzzzzu_, 0);
            (CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?[] jzzzzzw_ = [
                jzzzzzv_,
            ];
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzzzx_((CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)? AnchorList)
            {
                IEnumerable<CqlDate> kzzzzzb_ = AnchorList?.SortedList;
                int? kzzzzzc_ = AnchorList?.AnchorIndex;
                CqlDate kzzzzzd_ = context.Operators.Indexer<CqlDate>(kzzzzzb_, kzzzzzc_);
                bool? kzzzzze_(CqlDate X)
                {
                    IEnumerable<CqlDate> kzzzzzo_ = AnchorList?.SortedList;
                    int? kzzzzzp_ = AnchorList?.AnchorIndex;
                    CqlDate kzzzzzq_ = context.Operators.Indexer<CqlDate>(kzzzzzo_, kzzzzzp_);
                    CqlQuantity kzzzzzr_ = context.Operators.Quantity(1m, "day");
                    CqlDate kzzzzzs_ = context.Operators.Add(kzzzzzq_ as CqlDate, kzzzzzr_);
                    CqlDate kzzzzzv_ = context.Operators.Indexer<CqlDate>(kzzzzzo_, kzzzzzp_);
                    CqlQuantity kzzzzzw_ = context.Operators.Quantity(30m, "days");
                    CqlDate kzzzzzx_ = context.Operators.Add(kzzzzzv_ as CqlDate, kzzzzzw_);
                    CqlInterval<CqlDate> kzzzzzy_ = context.Operators.Interval(kzzzzzs_, kzzzzzx_, true, true);
                    bool? kzzzzzz_ = context.Operators.In<CqlDate>(X, kzzzzzy_, default);
                    bool? lzzzzza_ = context.Operators.Not(kzzzzzz_);

                    return lzzzzza_;
                };
                IEnumerable<CqlDate> kzzzzzf_ = context.Operators.Where<CqlDate>(DateList, kzzzzze_);
                int? kzzzzzh_ = context.Operators.Add(kzzzzzc_, 1);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzzzi_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, kzzzzzd_ as CqlDate, kzzzzzf_, kzzzzzh_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] kzzzzzj_ = [
                    kzzzzzi_,
                ];
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzzzk_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FirstList)
                {
                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzzzb_()
                    {
                        bool lzzzzzc_()
                        {
                            IEnumerable<CqlDate> lzzzzzd_ = FirstList?.NewList;
                            int? lzzzzze_ = FirstList?.IndexofNewDate;
                            CqlDate lzzzzzf_ = context.Operators.Indexer<CqlDate>(lzzzzzd_, lzzzzze_);

                            return lzzzzzf_ is null;
                        };
                        if (lzzzzzc_())
                        {
                            return FirstList;
                        }
                        else
                        {
                            IEnumerable<CqlDate> lzzzzzg_ = FirstList?.NewList;
                            int? lzzzzzh_ = FirstList?.IndexofNewDate;
                            CqlDate lzzzzzi_ = context.Operators.Indexer<CqlDate>(lzzzzzg_, lzzzzzh_);
                            bool? lzzzzzk_(CqlDate X)
                            {
                                IEnumerable<CqlDate> lzzzzzu_ = FirstList?.NewList;
                                int? lzzzzzv_ = FirstList?.IndexofNewDate;
                                CqlDate lzzzzzw_ = context.Operators.Indexer<CqlDate>(lzzzzzu_, lzzzzzv_);
                                CqlQuantity lzzzzzx_ = context.Operators.Quantity(1m, "day");
                                CqlDate lzzzzzy_ = context.Operators.Add(lzzzzzw_ as CqlDate, lzzzzzx_);
                                CqlDate mzzzzzb_ = context.Operators.Indexer<CqlDate>(lzzzzzu_, lzzzzzv_);
                                CqlQuantity mzzzzzc_ = context.Operators.Quantity(30m, "days");
                                CqlDate mzzzzzd_ = context.Operators.Add(mzzzzzb_ as CqlDate, mzzzzzc_);
                                CqlInterval<CqlDate> mzzzzze_ = context.Operators.Interval(lzzzzzy_, mzzzzzd_, true, true);
                                bool? mzzzzzf_ = context.Operators.In<CqlDate>(X, mzzzzze_, default);
                                bool? mzzzzzg_ = context.Operators.Not(mzzzzzf_);

                                return mzzzzzg_;
                            };
                            IEnumerable<CqlDate> lzzzzzl_ = context.Operators.Where<CqlDate>(lzzzzzg_, lzzzzzk_);
                            int? lzzzzzn_ = context.Operators.Add(lzzzzzh_, 1);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzzzo_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, lzzzzzi_ as CqlDate, lzzzzzl_, lzzzzzn_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] lzzzzzp_ = [
                                lzzzzzo_,
                            ];
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzzzq_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SecondList)
                            {
                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzzzh_()
                                {
                                    bool mzzzzzi_()
                                    {
                                        IEnumerable<CqlDate> mzzzzzj_ = SecondList?.NewList;
                                        int? mzzzzzk_ = SecondList?.IndexofNewDate;
                                        CqlDate mzzzzzl_ = context.Operators.Indexer<CqlDate>(mzzzzzj_, mzzzzzk_);

                                        return mzzzzzl_ is null;
                                    };
                                    if (mzzzzzi_())
                                    {
                                        return SecondList;
                                    }
                                    else
                                    {
                                        IEnumerable<CqlDate> mzzzzzm_ = SecondList?.NewList;
                                        int? mzzzzzn_ = SecondList?.IndexofNewDate;
                                        CqlDate mzzzzzo_ = context.Operators.Indexer<CqlDate>(mzzzzzm_, mzzzzzn_);
                                        bool? mzzzzzq_(CqlDate X)
                                        {
                                            IEnumerable<CqlDate> nzzzzza_ = SecondList?.NewList;
                                            int? nzzzzzb_ = SecondList?.IndexofNewDate;
                                            CqlDate nzzzzzc_ = context.Operators.Indexer<CqlDate>(nzzzzza_, nzzzzzb_);
                                            CqlQuantity nzzzzzd_ = context.Operators.Quantity(1m, "day");
                                            CqlDate nzzzzze_ = context.Operators.Add(nzzzzzc_ as CqlDate, nzzzzzd_);
                                            CqlDate nzzzzzh_ = context.Operators.Indexer<CqlDate>(nzzzzza_, nzzzzzb_);
                                            CqlQuantity nzzzzzi_ = context.Operators.Quantity(30m, "days");
                                            CqlDate nzzzzzj_ = context.Operators.Add(nzzzzzh_ as CqlDate, nzzzzzi_);
                                            CqlInterval<CqlDate> nzzzzzk_ = context.Operators.Interval(nzzzzze_, nzzzzzj_, true, true);
                                            bool? nzzzzzl_ = context.Operators.In<CqlDate>(X, nzzzzzk_, default);
                                            bool? nzzzzzm_ = context.Operators.Not(nzzzzzl_);

                                            return nzzzzzm_;
                                        };
                                        IEnumerable<CqlDate> mzzzzzr_ = context.Operators.Where<CqlDate>(mzzzzzm_, mzzzzzq_);
                                        int? mzzzzzt_ = context.Operators.Add(mzzzzzn_, 1);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzzzu_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, mzzzzzo_ as CqlDate, mzzzzzr_, mzzzzzt_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] mzzzzzv_ = [
                                            mzzzzzu_,
                                        ];
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzzzw_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ThirdList)
                                        {
                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? nzzzzzn_()
                                            {
                                                bool nzzzzzo_()
                                                {
                                                    IEnumerable<CqlDate> nzzzzzp_ = ThirdList?.NewList;
                                                    int? nzzzzzq_ = ThirdList?.IndexofNewDate;
                                                    CqlDate nzzzzzr_ = context.Operators.Indexer<CqlDate>(nzzzzzp_, nzzzzzq_);

                                                    return nzzzzzr_ is null;
                                                };
                                                if (nzzzzzo_())
                                                {
                                                    return ThirdList;
                                                }
                                                else
                                                {
                                                    IEnumerable<CqlDate> nzzzzzs_ = ThirdList?.NewList;
                                                    int? nzzzzzt_ = ThirdList?.IndexofNewDate;
                                                    CqlDate nzzzzzu_ = context.Operators.Indexer<CqlDate>(nzzzzzs_, nzzzzzt_);
                                                    bool? nzzzzzw_(CqlDate X)
                                                    {
                                                        IEnumerable<CqlDate> ozzzzzg_ = ThirdList?.NewList;
                                                        int? ozzzzzh_ = ThirdList?.IndexofNewDate;
                                                        CqlDate ozzzzzi_ = context.Operators.Indexer<CqlDate>(ozzzzzg_, ozzzzzh_);
                                                        CqlQuantity ozzzzzj_ = context.Operators.Quantity(1m, "day");
                                                        CqlDate ozzzzzk_ = context.Operators.Add(ozzzzzi_ as CqlDate, ozzzzzj_);
                                                        CqlDate ozzzzzn_ = context.Operators.Indexer<CqlDate>(ozzzzzg_, ozzzzzh_);
                                                        CqlQuantity ozzzzzo_ = context.Operators.Quantity(30m, "days");
                                                        CqlDate ozzzzzp_ = context.Operators.Add(ozzzzzn_ as CqlDate, ozzzzzo_);
                                                        CqlInterval<CqlDate> ozzzzzq_ = context.Operators.Interval(ozzzzzk_, ozzzzzp_, true, true);
                                                        bool? ozzzzzr_ = context.Operators.In<CqlDate>(X, ozzzzzq_, default);
                                                        bool? ozzzzzs_ = context.Operators.Not(ozzzzzr_);

                                                        return ozzzzzs_;
                                                    };
                                                    IEnumerable<CqlDate> nzzzzzx_ = context.Operators.Where<CqlDate>(nzzzzzs_, nzzzzzw_);
                                                    int? nzzzzzz_ = context.Operators.Add(nzzzzzt_, 1);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzza_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, nzzzzzu_ as CqlDate, nzzzzzx_, nzzzzzz_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] ozzzzzb_ = [
                                                        ozzzzza_,
                                                    ];
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzc_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FourthList)
                                                    {
                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzt_()
                                                        {
                                                            bool ozzzzzu_()
                                                            {
                                                                IEnumerable<CqlDate> ozzzzzv_ = FourthList?.NewList;
                                                                int? ozzzzzw_ = FourthList?.IndexofNewDate;
                                                                CqlDate ozzzzzx_ = context.Operators.Indexer<CqlDate>(ozzzzzv_, ozzzzzw_);

                                                                return ozzzzzx_ is null;
                                                            };
                                                            if (ozzzzzu_())
                                                            {
                                                                return FourthList;
                                                            }
                                                            else
                                                            {
                                                                IEnumerable<CqlDate> ozzzzzy_ = FourthList?.NewList;
                                                                int? ozzzzzz_ = FourthList?.IndexofNewDate;
                                                                CqlDate pzzzzza_ = context.Operators.Indexer<CqlDate>(ozzzzzy_, ozzzzzz_);
                                                                bool? pzzzzzc_(CqlDate X)
                                                                {
                                                                    IEnumerable<CqlDate> pzzzzzm_ = FourthList?.NewList;
                                                                    int? pzzzzzn_ = FourthList?.IndexofNewDate;
                                                                    CqlDate pzzzzzo_ = context.Operators.Indexer<CqlDate>(pzzzzzm_, pzzzzzn_);
                                                                    CqlQuantity pzzzzzp_ = context.Operators.Quantity(1m, "day");
                                                                    CqlDate pzzzzzq_ = context.Operators.Add(pzzzzzo_ as CqlDate, pzzzzzp_);
                                                                    CqlDate pzzzzzt_ = context.Operators.Indexer<CqlDate>(pzzzzzm_, pzzzzzn_);
                                                                    CqlQuantity pzzzzzu_ = context.Operators.Quantity(30m, "days");
                                                                    CqlDate pzzzzzv_ = context.Operators.Add(pzzzzzt_ as CqlDate, pzzzzzu_);
                                                                    CqlInterval<CqlDate> pzzzzzw_ = context.Operators.Interval(pzzzzzq_, pzzzzzv_, true, true);
                                                                    bool? pzzzzzx_ = context.Operators.In<CqlDate>(X, pzzzzzw_, default);
                                                                    bool? pzzzzzy_ = context.Operators.Not(pzzzzzx_);

                                                                    return pzzzzzy_;
                                                                };
                                                                IEnumerable<CqlDate> pzzzzzd_ = context.Operators.Where<CqlDate>(ozzzzzy_, pzzzzzc_);
                                                                int? pzzzzzf_ = context.Operators.Add(ozzzzzz_, 1);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzg_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, pzzzzza_ as CqlDate, pzzzzzd_, pzzzzzf_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] pzzzzzh_ = [
                                                                    pzzzzzg_,
                                                                ];
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzi_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? FifthList)
                                                                {
                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzz_()
                                                                    {
                                                                        bool qzzzzza_()
                                                                        {
                                                                            IEnumerable<CqlDate> qzzzzzb_ = FifthList?.NewList;
                                                                            int? qzzzzzc_ = FifthList?.IndexofNewDate;
                                                                            CqlDate qzzzzzd_ = context.Operators.Indexer<CqlDate>(qzzzzzb_, qzzzzzc_);

                                                                            return qzzzzzd_ is null;
                                                                        };
                                                                        if (qzzzzza_())
                                                                        {
                                                                            return FifthList;
                                                                        }
                                                                        else
                                                                        {
                                                                            IEnumerable<CqlDate> qzzzzze_ = FifthList?.NewList;
                                                                            int? qzzzzzf_ = FifthList?.IndexofNewDate;
                                                                            CqlDate qzzzzzg_ = context.Operators.Indexer<CqlDate>(qzzzzze_, qzzzzzf_);
                                                                            bool? qzzzzzi_(CqlDate X)
                                                                            {
                                                                                IEnumerable<CqlDate> qzzzzzs_ = FifthList?.NewList;
                                                                                int? qzzzzzt_ = FifthList?.IndexofNewDate;
                                                                                CqlDate qzzzzzu_ = context.Operators.Indexer<CqlDate>(qzzzzzs_, qzzzzzt_);
                                                                                CqlQuantity qzzzzzv_ = context.Operators.Quantity(1m, "day");
                                                                                CqlDate qzzzzzw_ = context.Operators.Add(qzzzzzu_ as CqlDate, qzzzzzv_);
                                                                                CqlDate qzzzzzz_ = context.Operators.Indexer<CqlDate>(qzzzzzs_, qzzzzzt_);
                                                                                CqlQuantity rzzzzza_ = context.Operators.Quantity(30m, "days");
                                                                                CqlDate rzzzzzb_ = context.Operators.Add(qzzzzzz_ as CqlDate, rzzzzza_);
                                                                                CqlInterval<CqlDate> rzzzzzc_ = context.Operators.Interval(qzzzzzw_, rzzzzzb_, true, true);
                                                                                bool? rzzzzzd_ = context.Operators.In<CqlDate>(X, rzzzzzc_, default);
                                                                                bool? rzzzzze_ = context.Operators.Not(rzzzzzd_);

                                                                                return rzzzzze_;
                                                                            };
                                                                            IEnumerable<CqlDate> qzzzzzj_ = context.Operators.Where<CqlDate>(qzzzzze_, qzzzzzi_);
                                                                            int? qzzzzzl_ = context.Operators.Add(qzzzzzf_, 1);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzzm_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, qzzzzzg_ as CqlDate, qzzzzzj_, qzzzzzl_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] qzzzzzn_ = [
                                                                                qzzzzzm_,
                                                                            ];
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzzo_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SixthList)
                                                                            {
                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzzf_()
                                                                                {
                                                                                    bool rzzzzzg_()
                                                                                    {
                                                                                        IEnumerable<CqlDate> rzzzzzh_ = SixthList?.NewList;
                                                                                        int? rzzzzzi_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate rzzzzzj_ = context.Operators.Indexer<CqlDate>(rzzzzzh_, rzzzzzi_);

                                                                                        return rzzzzzj_ is null;
                                                                                    };
                                                                                    if (rzzzzzg_())
                                                                                    {
                                                                                        return SixthList;
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        IEnumerable<CqlDate> rzzzzzk_ = SixthList?.NewList;
                                                                                        int? rzzzzzl_ = SixthList?.IndexofNewDate;
                                                                                        CqlDate rzzzzzm_ = context.Operators.Indexer<CqlDate>(rzzzzzk_, rzzzzzl_);
                                                                                        bool? rzzzzzo_(CqlDate X)
                                                                                        {
                                                                                            IEnumerable<CqlDate> rzzzzzy_ = SixthList?.NewList;
                                                                                            int? rzzzzzz_ = SixthList?.IndexofNewDate;
                                                                                            CqlDate szzzzza_ = context.Operators.Indexer<CqlDate>(rzzzzzy_, rzzzzzz_);
                                                                                            CqlQuantity szzzzzb_ = context.Operators.Quantity(1m, "day");
                                                                                            CqlDate szzzzzc_ = context.Operators.Add(szzzzza_ as CqlDate, szzzzzb_);
                                                                                            CqlDate szzzzzf_ = context.Operators.Indexer<CqlDate>(rzzzzzy_, rzzzzzz_);
                                                                                            CqlQuantity szzzzzg_ = context.Operators.Quantity(30m, "days");
                                                                                            CqlDate szzzzzh_ = context.Operators.Add(szzzzzf_ as CqlDate, szzzzzg_);
                                                                                            CqlInterval<CqlDate> szzzzzi_ = context.Operators.Interval(szzzzzc_, szzzzzh_, true, true);
                                                                                            bool? szzzzzj_ = context.Operators.In<CqlDate>(X, szzzzzi_, default);
                                                                                            bool? szzzzzk_ = context.Operators.Not(szzzzzj_);

                                                                                            return szzzzzk_;
                                                                                        };
                                                                                        IEnumerable<CqlDate> rzzzzzp_ = context.Operators.Where<CqlDate>(rzzzzzk_, rzzzzzo_);
                                                                                        int? rzzzzzr_ = context.Operators.Add(rzzzzzl_, 1);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzzs_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, rzzzzzm_ as CqlDate, rzzzzzp_, rzzzzzr_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] rzzzzzt_ = [
                                                                                            rzzzzzs_,
                                                                                        ];
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzzu_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? SeventhList)
                                                                                        {
                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzzzzl_()
                                                                                            {
                                                                                                bool szzzzzm_()
                                                                                                {
                                                                                                    IEnumerable<CqlDate> szzzzzn_ = SeventhList?.NewList;
                                                                                                    int? szzzzzo_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate szzzzzp_ = context.Operators.Indexer<CqlDate>(szzzzzn_, szzzzzo_);

                                                                                                    return szzzzzp_ is null;
                                                                                                };
                                                                                                if (szzzzzm_())
                                                                                                {
                                                                                                    return SeventhList;
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    IEnumerable<CqlDate> szzzzzq_ = SeventhList?.NewList;
                                                                                                    int? szzzzzr_ = SeventhList?.IndexofNewDate;
                                                                                                    CqlDate szzzzzs_ = context.Operators.Indexer<CqlDate>(szzzzzq_, szzzzzr_);
                                                                                                    bool? szzzzzu_(CqlDate X)
                                                                                                    {
                                                                                                        IEnumerable<CqlDate> tzzzzze_ = SeventhList?.NewList;
                                                                                                        int? tzzzzzf_ = SeventhList?.IndexofNewDate;
                                                                                                        CqlDate tzzzzzg_ = context.Operators.Indexer<CqlDate>(tzzzzze_, tzzzzzf_);
                                                                                                        CqlQuantity tzzzzzh_ = context.Operators.Quantity(1m, "day");
                                                                                                        CqlDate tzzzzzi_ = context.Operators.Add(tzzzzzg_ as CqlDate, tzzzzzh_);
                                                                                                        CqlDate tzzzzzl_ = context.Operators.Indexer<CqlDate>(tzzzzze_, tzzzzzf_);
                                                                                                        CqlQuantity tzzzzzm_ = context.Operators.Quantity(30m, "days");
                                                                                                        CqlDate tzzzzzn_ = context.Operators.Add(tzzzzzl_ as CqlDate, tzzzzzm_);
                                                                                                        CqlInterval<CqlDate> tzzzzzo_ = context.Operators.Interval(tzzzzzi_, tzzzzzn_, true, true);
                                                                                                        bool? tzzzzzp_ = context.Operators.In<CqlDate>(X, tzzzzzo_, default);
                                                                                                        bool? tzzzzzq_ = context.Operators.Not(tzzzzzp_);

                                                                                                        return tzzzzzq_;
                                                                                                    };
                                                                                                    IEnumerable<CqlDate> szzzzzv_ = context.Operators.Where<CqlDate>(szzzzzq_, szzzzzu_);
                                                                                                    int? szzzzzx_ = context.Operators.Add(szzzzzr_, 1);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? szzzzzy_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, szzzzzs_ as CqlDate, szzzzzv_, szzzzzx_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] szzzzzz_ = [
                                                                                                        szzzzzy_,
                                                                                                    ];
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzzzza_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EighthList)
                                                                                                    {
                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzzzzr_()
                                                                                                        {
                                                                                                            bool tzzzzzs_()
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> tzzzzzt_ = EighthList?.NewList;
                                                                                                                int? tzzzzzu_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate tzzzzzv_ = context.Operators.Indexer<CqlDate>(tzzzzzt_, tzzzzzu_);

                                                                                                                return tzzzzzv_ is null;
                                                                                                            };
                                                                                                            if (tzzzzzs_())
                                                                                                            {
                                                                                                                return EighthList;
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                IEnumerable<CqlDate> tzzzzzw_ = EighthList?.NewList;
                                                                                                                int? tzzzzzx_ = EighthList?.IndexofNewDate;
                                                                                                                CqlDate tzzzzzy_ = context.Operators.Indexer<CqlDate>(tzzzzzw_, tzzzzzx_);
                                                                                                                bool? uzzzzza_(CqlDate X)
                                                                                                                {
                                                                                                                    IEnumerable<CqlDate> uzzzzzk_ = EighthList?.NewList;
                                                                                                                    int? uzzzzzl_ = EighthList?.IndexofNewDate;
                                                                                                                    CqlDate uzzzzzm_ = context.Operators.Indexer<CqlDate>(uzzzzzk_, uzzzzzl_);
                                                                                                                    CqlQuantity uzzzzzn_ = context.Operators.Quantity(1m, "day");
                                                                                                                    CqlDate uzzzzzo_ = context.Operators.Add(uzzzzzm_ as CqlDate, uzzzzzn_);
                                                                                                                    CqlDate uzzzzzr_ = context.Operators.Indexer<CqlDate>(uzzzzzk_, uzzzzzl_);
                                                                                                                    CqlQuantity uzzzzzs_ = context.Operators.Quantity(30m, "days");
                                                                                                                    CqlDate uzzzzzt_ = context.Operators.Add(uzzzzzr_ as CqlDate, uzzzzzs_);
                                                                                                                    CqlInterval<CqlDate> uzzzzzu_ = context.Operators.Interval(uzzzzzo_, uzzzzzt_, true, true);
                                                                                                                    bool? uzzzzzv_ = context.Operators.In<CqlDate>(X, uzzzzzu_, default);
                                                                                                                    bool? uzzzzzw_ = context.Operators.Not(uzzzzzv_);

                                                                                                                    return uzzzzzw_;
                                                                                                                };
                                                                                                                IEnumerable<CqlDate> uzzzzzb_ = context.Operators.Where<CqlDate>(tzzzzzw_, uzzzzza_);
                                                                                                                int? uzzzzzd_ = context.Operators.Add(tzzzzzx_, 1);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzzzze_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, tzzzzzy_ as CqlDate, uzzzzzb_, uzzzzzd_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] uzzzzzf_ = [
                                                                                                                    uzzzzze_,
                                                                                                                ];
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzzzzg_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? NinethList)
                                                                                                                {
                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzzzzx_()
                                                                                                                    {
                                                                                                                        bool uzzzzzy_()
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> uzzzzzz_ = NinethList?.NewList;
                                                                                                                            int? vzzzzza_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate vzzzzzb_ = context.Operators.Indexer<CqlDate>(uzzzzzz_, vzzzzza_);

                                                                                                                            return vzzzzzb_ is null;
                                                                                                                        };
                                                                                                                        if (uzzzzzy_())
                                                                                                                        {
                                                                                                                            return NinethList;
                                                                                                                        }
                                                                                                                        else
                                                                                                                        {
                                                                                                                            IEnumerable<CqlDate> vzzzzzc_ = NinethList?.NewList;
                                                                                                                            int? vzzzzzd_ = NinethList?.IndexofNewDate;
                                                                                                                            CqlDate vzzzzze_ = context.Operators.Indexer<CqlDate>(vzzzzzc_, vzzzzzd_);
                                                                                                                            bool? vzzzzzg_(CqlDate X)
                                                                                                                            {
                                                                                                                                IEnumerable<CqlDate> vzzzzzq_ = NinethList?.NewList;
                                                                                                                                int? vzzzzzr_ = NinethList?.IndexofNewDate;
                                                                                                                                CqlDate vzzzzzs_ = context.Operators.Indexer<CqlDate>(vzzzzzq_, vzzzzzr_);
                                                                                                                                CqlQuantity vzzzzzt_ = context.Operators.Quantity(1m, "day");
                                                                                                                                CqlDate vzzzzzu_ = context.Operators.Add(vzzzzzs_ as CqlDate, vzzzzzt_);
                                                                                                                                CqlDate vzzzzzx_ = context.Operators.Indexer<CqlDate>(vzzzzzq_, vzzzzzr_);
                                                                                                                                CqlQuantity vzzzzzy_ = context.Operators.Quantity(30m, "days");
                                                                                                                                CqlDate vzzzzzz_ = context.Operators.Add(vzzzzzx_ as CqlDate, vzzzzzy_);
                                                                                                                                CqlInterval<CqlDate> wzzzzza_ = context.Operators.Interval(vzzzzzu_, vzzzzzz_, true, true);
                                                                                                                                bool? wzzzzzb_ = context.Operators.In<CqlDate>(X, wzzzzza_, default);
                                                                                                                                bool? wzzzzzc_ = context.Operators.Not(wzzzzzb_);

                                                                                                                                return wzzzzzc_;
                                                                                                                            };
                                                                                                                            IEnumerable<CqlDate> vzzzzzh_ = context.Operators.Where<CqlDate>(vzzzzzc_, vzzzzzg_);
                                                                                                                            int? vzzzzzj_ = context.Operators.Add(vzzzzzd_, 1);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? vzzzzzk_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, vzzzzze_ as CqlDate, vzzzzzh_, vzzzzzj_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] vzzzzzl_ = [
                                                                                                                                vzzzzzk_,
                                                                                                                            ];
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? vzzzzzm_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? TenthList)
                                                                                                                            {
                                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzzzzd_()
                                                                                                                                {
                                                                                                                                    bool wzzzzze_()
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> wzzzzzf_ = TenthList?.NewList;
                                                                                                                                        int? wzzzzzg_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate wzzzzzh_ = context.Operators.Indexer<CqlDate>(wzzzzzf_, wzzzzzg_);

                                                                                                                                        return wzzzzzh_ is null;
                                                                                                                                    };
                                                                                                                                    if (wzzzzze_())
                                                                                                                                    {
                                                                                                                                        return TenthList;
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                    {
                                                                                                                                        IEnumerable<CqlDate> wzzzzzi_ = TenthList?.NewList;
                                                                                                                                        int? wzzzzzj_ = TenthList?.IndexofNewDate;
                                                                                                                                        CqlDate wzzzzzk_ = context.Operators.Indexer<CqlDate>(wzzzzzi_, wzzzzzj_);
                                                                                                                                        bool? wzzzzzm_(CqlDate X)
                                                                                                                                        {
                                                                                                                                            IEnumerable<CqlDate> wzzzzzw_ = TenthList?.NewList;
                                                                                                                                            int? wzzzzzx_ = TenthList?.IndexofNewDate;
                                                                                                                                            CqlDate wzzzzzy_ = context.Operators.Indexer<CqlDate>(wzzzzzw_, wzzzzzx_);
                                                                                                                                            CqlQuantity wzzzzzz_ = context.Operators.Quantity(1m, "day");
                                                                                                                                            CqlDate xzzzzza_ = context.Operators.Add(wzzzzzy_ as CqlDate, wzzzzzz_);
                                                                                                                                            CqlDate xzzzzzd_ = context.Operators.Indexer<CqlDate>(wzzzzzw_, wzzzzzx_);
                                                                                                                                            CqlQuantity xzzzzze_ = context.Operators.Quantity(30m, "days");
                                                                                                                                            CqlDate xzzzzzf_ = context.Operators.Add(xzzzzzd_ as CqlDate, xzzzzze_);
                                                                                                                                            CqlInterval<CqlDate> xzzzzzg_ = context.Operators.Interval(xzzzzza_, xzzzzzf_, true, true);
                                                                                                                                            bool? xzzzzzh_ = context.Operators.In<CqlDate>(X, xzzzzzg_, default);
                                                                                                                                            bool? xzzzzzi_ = context.Operators.Not(xzzzzzh_);

                                                                                                                                            return xzzzzzi_;
                                                                                                                                        };
                                                                                                                                        IEnumerable<CqlDate> wzzzzzn_ = context.Operators.Where<CqlDate>(wzzzzzi_, wzzzzzm_);
                                                                                                                                        int? wzzzzzp_ = context.Operators.Add(wzzzzzj_, 1);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzzzzq_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, wzzzzzk_ as CqlDate, wzzzzzn_, wzzzzzp_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?[] wzzzzzr_ = [
                                                                                                                                            wzzzzzq_,
                                                                                                                                        ];
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzzzzs_((CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? EleventhList)
                                                                                                                                        {
                                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzzzzj_()
                                                                                                                                            {
                                                                                                                                                bool xzzzzzk_()
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> xzzzzzl_ = EleventhList?.NewList;
                                                                                                                                                    int? xzzzzzm_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate xzzzzzn_ = context.Operators.Indexer<CqlDate>(xzzzzzl_, xzzzzzm_);

                                                                                                                                                    return xzzzzzn_ is null;
                                                                                                                                                };
                                                                                                                                                if (xzzzzzk_())
                                                                                                                                                {
                                                                                                                                                    return EleventhList;
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                {
                                                                                                                                                    IEnumerable<CqlDate> xzzzzzo_ = EleventhList?.NewList;
                                                                                                                                                    int? xzzzzzp_ = EleventhList?.IndexofNewDate;
                                                                                                                                                    CqlDate xzzzzzq_ = context.Operators.Indexer<CqlDate>(xzzzzzo_, xzzzzzp_);
                                                                                                                                                    bool? xzzzzzs_(CqlDate X)
                                                                                                                                                    {
                                                                                                                                                        IEnumerable<CqlDate> xzzzzzx_ = EleventhList?.NewList;
                                                                                                                                                        int? xzzzzzy_ = EleventhList?.IndexofNewDate;
                                                                                                                                                        CqlDate xzzzzzz_ = context.Operators.Indexer<CqlDate>(xzzzzzx_, xzzzzzy_);
                                                                                                                                                        CqlQuantity yzzzzza_ = context.Operators.Quantity(1m, "day");
                                                                                                                                                        CqlDate yzzzzzb_ = context.Operators.Add(xzzzzzz_ as CqlDate, yzzzzza_);
                                                                                                                                                        CqlDate yzzzzze_ = context.Operators.Indexer<CqlDate>(xzzzzzx_, xzzzzzy_);
                                                                                                                                                        CqlQuantity yzzzzzf_ = context.Operators.Quantity(30m, "days");
                                                                                                                                                        CqlDate yzzzzzg_ = context.Operators.Add(yzzzzze_ as CqlDate, yzzzzzf_);
                                                                                                                                                        CqlInterval<CqlDate> yzzzzzh_ = context.Operators.Interval(yzzzzzb_, yzzzzzg_, true, true);
                                                                                                                                                        bool? yzzzzzi_ = context.Operators.In<CqlDate>(X, yzzzzzh_, default);
                                                                                                                                                        bool? yzzzzzj_ = context.Operators.Not(yzzzzzi_);

                                                                                                                                                        return yzzzzzj_;
                                                                                                                                                    };
                                                                                                                                                    IEnumerable<CqlDate> xzzzzzt_ = context.Operators.Where<CqlDate>(xzzzzzo_, xzzzzzs_);
                                                                                                                                                    int? xzzzzzv_ = context.Operators.Add(xzzzzzp_, 1);
                                                                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? xzzzzzw_ = (CqlTupleMetadata_EbRdcKZaDRhaFPaOQUGVhPhBc, xzzzzzq_ as CqlDate, xzzzzzt_, xzzzzzv_);

                                                                                                                                                    return xzzzzzw_;
                                                                                                                                                }
                                                                                                                                            };

                                                                                                                                            return xzzzzzj_();
                                                                                                                                        };
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> wzzzzzt_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)wzzzzzr_, wzzzzzs_);
                                                                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> wzzzzzu_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(wzzzzzt_);
                                                                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? wzzzzzv_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(wzzzzzu_);

                                                                                                                                        return wzzzzzv_;
                                                                                                                                    }
                                                                                                                                };

                                                                                                                                return wzzzzzd_();
                                                                                                                            };
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> vzzzzzn_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)vzzzzzl_, vzzzzzm_);
                                                                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> vzzzzzo_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(vzzzzzn_);
                                                                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? vzzzzzp_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(vzzzzzo_);

                                                                                                                            return vzzzzzp_;
                                                                                                                        }
                                                                                                                    };

                                                                                                                    return uzzzzzx_();
                                                                                                                };
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> uzzzzzh_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)uzzzzzf_, uzzzzzg_);
                                                                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> uzzzzzi_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(uzzzzzh_);
                                                                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? uzzzzzj_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(uzzzzzi_);

                                                                                                                return uzzzzzj_;
                                                                                                            }
                                                                                                        };

                                                                                                        return tzzzzzr_();
                                                                                                    };
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> tzzzzzb_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)szzzzzz_, tzzzzza_);
                                                                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> tzzzzzc_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(tzzzzzb_);
                                                                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? tzzzzzd_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(tzzzzzc_);

                                                                                                    return tzzzzzd_;
                                                                                                }
                                                                                            };

                                                                                            return szzzzzl_();
                                                                                        };
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> rzzzzzv_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)rzzzzzt_, rzzzzzu_);
                                                                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> rzzzzzw_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(rzzzzzv_);
                                                                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? rzzzzzx_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(rzzzzzw_);

                                                                                        return rzzzzzx_;
                                                                                    }
                                                                                };

                                                                                return rzzzzzf_();
                                                                            };
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzzzzp_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)qzzzzzn_, qzzzzzo_);
                                                                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> qzzzzzq_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzzzzp_);
                                                                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? qzzzzzr_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(qzzzzzq_);

                                                                            return qzzzzzr_;
                                                                        }
                                                                    };

                                                                    return pzzzzzz_();
                                                                };
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzzzzj_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)pzzzzzh_, pzzzzzi_);
                                                                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> pzzzzzk_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzzzzj_);
                                                                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? pzzzzzl_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(pzzzzzk_);

                                                                return pzzzzzl_;
                                                            }
                                                        };

                                                        return ozzzzzt_();
                                                    };
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzzzd_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)ozzzzzb_, ozzzzzc_);
                                                    IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> ozzzzze_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzzzd_);
                                                    (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? ozzzzzf_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(ozzzzze_);

                                                    return ozzzzzf_;
                                                }
                                            };

                                            return nzzzzzn_();
                                        };
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> mzzzzzx_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)mzzzzzv_, mzzzzzw_);
                                        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> mzzzzzy_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(mzzzzzx_);
                                        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? mzzzzzz_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(mzzzzzy_);

                                        return mzzzzzz_;
                                    }
                                };

                                return mzzzzzh_();
                            };
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lzzzzzr_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)lzzzzzp_, lzzzzzq_);
                            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> lzzzzzs_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lzzzzzr_);
                            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? lzzzzzt_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(lzzzzzs_);

                            return lzzzzzt_;
                        }
                    };

                    return lzzzzzb_();
                };
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kzzzzzl_ = context.Operators.Select<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>)kzzzzzj_, kzzzzzk_);
                IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> kzzzzzm_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kzzzzzl_);
                (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzzzn_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(kzzzzzm_);

                return kzzzzzn_;
            };
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jzzzzzy_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedList, int? AnchorIndex)?>)jzzzzzw_, jzzzzzx_);
            IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jzzzzzz_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jzzzzzy_);
            (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? kzzzzza_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jzzzzzz_);

            return kzzzzza_;
        };
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jzzzzzq_ = context.Operators.Select<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?, (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>((IEnumerable<(CqlTupleMetadata, IEnumerable<CqlDate> SortedDates)?>)jzzzzzo_, jzzzzzp_);
        IEnumerable<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?> jzzzzzr_ = context.Operators.Distinct<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jzzzzzq_);
        (CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)? jzzzzzs_ = context.Operators.SingletonFrom<(CqlTupleMetadata, CqlDate NextDate, IEnumerable<CqlDate> NewList, int? IndexofNewDate)?>(jzzzzzr_);

        return jzzzzzs_;
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
