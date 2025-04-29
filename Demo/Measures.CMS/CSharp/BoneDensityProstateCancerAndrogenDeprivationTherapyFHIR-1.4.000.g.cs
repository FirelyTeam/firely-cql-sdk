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
[CqlLibrary("BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR", "1.4.000")]
public partial class BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR_1_4_000 : ILibrary, ISingleton<BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR_1_4_000>
{
    private BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR_1_4_000() {}

    public static BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR_1_4_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR";
    public string Version => "1.4.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, SupplementalDataElements_3_5_000.Instance, QICoreCommon_2_1_000.Instance];

    #endregion ILibrary Implementation

    #region ValueSets

    #region ValueSet: Androgen deprivation therapy for Urology Care
    [CqlValueSetDefinition(
        definitionName: "Androgen deprivation therapy for Urology Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.48",
        valueSetVersion: null)]
    public CqlValueSet Androgen_deprivation_therapy_for_Urology_Care(CqlContext context) => _Androgen_deprivation_therapy_for_Urology_Care;

    private static readonly CqlValueSet _Androgen_deprivation_therapy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.48", null);
    #endregion

    #region ValueSet: DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care
    [CqlValueSetDefinition(
        definitionName: "DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.38",
        valueSetVersion: null)]
    public CqlValueSet DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(CqlContext context) => _DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care;

    private static readonly CqlValueSet _DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.38", null);
    #endregion

    #region ValueSet: Office Visit
    [CqlValueSetDefinition(
        definitionName: "Office Visit",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001",
        valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext context) => _Office_Visit;

    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);
    #endregion

    #region ValueSet: Patient Declined
    [CqlValueSetDefinition(
        definitionName: "Patient Declined",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582",
        valueSetVersion: null)]
    public CqlValueSet Patient_Declined(CqlContext context) => _Patient_Declined;

    private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);
    #endregion

    #region ValueSet: Prostate Cancer
    [CqlValueSetDefinition(
        definitionName: "Prostate Cancer",
        valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319",
        valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer(CqlContext context) => _Prostate_Cancer;

    private static readonly CqlValueSet _Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);
    #endregion

    #endregion ValueSets

    #region Codes

    #region Code: Injection of leuprolide acetate for twelve month period (regime/therapy)
    [CqlCodeDefinition(
        definitionName: "Injection of leuprolide acetate for twelve month period (regime/therapy)",
        codeId: "456381000124102",
        codeSystem: "http://snomed.info/sct")]
    public CqlCode Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(CqlContext context) => _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_;

    private static readonly CqlCode _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_ = new CqlCode("456381000124102", "http://snomed.info/sct", default, default);
    #endregion

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition(
        definitionName: "SNOMEDCT")]
    public CqlCode[] SNOMEDCT(CqlContext context)
    {
        CqlCode[] hzzzzzzzzzzzz_ = [
            new CqlCode("456381000124102", "http://snomed.info/sct", default, default),
        ];

        return hzzzzzzzzzzzz_;
    }


    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition(
        definitionName: "Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime izzzzzzzzzzza_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime izzzzzzzzzzzb_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> izzzzzzzzzzzc_ = context.Operators.Interval(izzzzzzzzzzza_, izzzzzzzzzzzb_, true, true);
        object izzzzzzzzzzzd_ = context.ResolveParameter("BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR-1.4.000", "Measurement Period", izzzzzzzzzzzc_);

        return (CqlInterval<CqlDateTime>)izzzzzzzzzzzd_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition(
        definitionName: "Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> izzzzzzzzzzze_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient izzzzzzzzzzzf_ = context.Operators.SingletonFrom<Patient>(izzzzzzzzzzze_);

        return izzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzg_ = this.Office_Visit(context);
        IEnumerable<Encounter> izzzzzzzzzzzh_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, izzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? izzzzzzzzzzzi_(Encounter OfficeVisit)
        {
            CqlInterval<CqlDateTime> izzzzzzzzzzzl_ = this.Measurement_Period(context);
            Period izzzzzzzzzzzm_ = OfficeVisit?.Period;
            CqlInterval<CqlDateTime> izzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, izzzzzzzzzzzm_);
            bool? izzzzzzzzzzzo_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(izzzzzzzzzzzl_, izzzzzzzzzzzn_, default);
            Code<Encounter.EncounterStatus> izzzzzzzzzzzp_ = OfficeVisit?.StatusElement;
            Encounter.EncounterStatus? izzzzzzzzzzzq_ = izzzzzzzzzzzp_?.Value;
            Code<Encounter.EncounterStatus> izzzzzzzzzzzr_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(izzzzzzzzzzzq_);
            bool? izzzzzzzzzzzs_ = context.Operators.Equal(izzzzzzzzzzzr_, "finished");
            bool? izzzzzzzzzzzt_ = context.Operators.And(izzzzzzzzzzzo_, izzzzzzzzzzzs_);

            return izzzzzzzzzzzt_;
        };
        IEnumerable<Encounter> izzzzzzzzzzzj_ = context.Operators.Where<Encounter>(izzzzzzzzzzzh_, izzzzzzzzzzzi_);
        bool? izzzzzzzzzzzk_ = context.Operators.Exists<Encounter>(izzzzzzzzzzzj_);

        return izzzzzzzzzzzk_;
    }


    // NOT A DEFINITION CqlExpressionDefinition//
    public CqlInterval<CqlDateTime> NormalizeInterval(CqlContext context, CqlDateTime pointInTime, CqlInterval<CqlDateTime> dateTimeInterval)
    {
        CqlInterval<CqlDateTime> izzzzzzzzzzzu_()
        {
            if ((context.Operators.Not((bool?)(pointInTime is null))) ?? false)
            {
                CqlInterval<CqlDateTime> izzzzzzzzzzzv_ = context.Operators.Interval(pointInTime, pointInTime, true, true);

                return izzzzzzzzzzzv_;
            }
            else if ((context.Operators.Not((bool?)(dateTimeInterval is null))) ?? false)
            {
                return dateTimeInterval;
            }
            else
            {
                return null as CqlInterval<CqlDateTime>;
            }
        };

        return izzzzzzzzzzzu_();
    }


    [CqlExpressionDefinition(
        definitionName: "Androgen Deprivation Therapy for Urology Care Medication Active Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(CqlContext context)
    {
        CqlValueSet izzzzzzzzzzzw_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> izzzzzzzzzzzx_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> izzzzzzzzzzzz_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, izzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> jzzzzzzzzzzza_ = context.Operators.Union<MedicationRequest>(izzzzzzzzzzzx_, izzzzzzzzzzzz_);
        bool? jzzzzzzzzzzzb_(MedicationRequest ADTActive)
        {
            Code<MedicationRequest.MedicationrequestStatus> jzzzzzzzzzzzg_ = ADTActive?.StatusElement;
            MedicationRequest.MedicationrequestStatus? jzzzzzzzzzzzh_ = jzzzzzzzzzzzg_?.Value;
            string jzzzzzzzzzzzi_ = context.Operators.Convert<string>(jzzzzzzzzzzzh_);
            string[] jzzzzzzzzzzzj_ = [
                "active",
                "completed",
            ];
            bool? jzzzzzzzzzzzk_ = context.Operators.In<string>(jzzzzzzzzzzzi_, jzzzzzzzzzzzj_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> jzzzzzzzzzzzl_ = ADTActive?.IntentElement;
            MedicationRequest.MedicationRequestIntent? jzzzzzzzzzzzm_ = jzzzzzzzzzzzl_?.Value;
            string jzzzzzzzzzzzn_ = context.Operators.Convert<string>(jzzzzzzzzzzzm_);
            string[] jzzzzzzzzzzzo_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? jzzzzzzzzzzzp_ = context.Operators.In<string>(jzzzzzzzzzzzn_, jzzzzzzzzzzzo_ as IEnumerable<string>);
            bool? jzzzzzzzzzzzq_ = context.Operators.And(jzzzzzzzzzzzk_, jzzzzzzzzzzzp_);

            return jzzzzzzzzzzzq_;
        };
        IEnumerable<MedicationRequest> jzzzzzzzzzzzc_ = context.Operators.Where<MedicationRequest>(jzzzzzzzzzzza_, jzzzzzzzzzzzb_);
        CqlDateTime jzzzzzzzzzzzd_(MedicationRequest ADTActive)
        {
            List<Dosage> jzzzzzzzzzzzr_ = ADTActive?.DosageInstruction;
            bool? jzzzzzzzzzzzs_(Dosage @this)
            {
                Timing kzzzzzzzzzzzx_ = @this?.Timing;
                bool? kzzzzzzzzzzzy_ = context.Operators.Not((bool?)(kzzzzzzzzzzzx_ is null));

                return kzzzzzzzzzzzy_;
            };
            IEnumerable<Dosage> jzzzzzzzzzzzt_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzr_, jzzzzzzzzzzzs_);
            Timing jzzzzzzzzzzzu_(Dosage @this)
            {
                Timing kzzzzzzzzzzzz_ = @this?.Timing;

                return kzzzzzzzzzzzz_;
            };
            IEnumerable<Timing> jzzzzzzzzzzzv_ = context.Operators.Select<Dosage, Timing>(jzzzzzzzzzzzt_, jzzzzzzzzzzzu_);
            CqlDateTime jzzzzzzzzzzzw_(Timing dosageTiming)
            {
                List<FhirDateTime> lzzzzzzzzzzza_ = dosageTiming?.EventElement;
                IEnumerable<CqlDateTime> lzzzzzzzzzzzb_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(lzzzzzzzzzzza_, "value");
                IEnumerable<CqlDateTime> lzzzzzzzzzzzc_ = context.Operators.ListSort<CqlDateTime>(lzzzzzzzzzzzb_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime lzzzzzzzzzzzd_ = context.Operators.First<CqlDateTime>(lzzzzzzzzzzzc_);

                return lzzzzzzzzzzzd_;
            };
            IEnumerable<CqlDateTime> jzzzzzzzzzzzx_ = context.Operators.Select<Timing, CqlDateTime>(jzzzzzzzzzzzv_, jzzzzzzzzzzzw_);
            IEnumerable<CqlDateTime> jzzzzzzzzzzzy_ = context.Operators.Distinct<CqlDateTime>(jzzzzzzzzzzzx_);
            IEnumerable<CqlDateTime> jzzzzzzzzzzzz_ = context.Operators.ListSort<CqlDateTime>(jzzzzzzzzzzzy_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime kzzzzzzzzzzza_ = context.Operators.First<CqlDateTime>(jzzzzzzzzzzzz_);
            bool? kzzzzzzzzzzzc_(Dosage @this)
            {
                Timing lzzzzzzzzzzze_ = @this?.Timing;
                bool? lzzzzzzzzzzzf_ = context.Operators.Not((bool?)(lzzzzzzzzzzze_ is null));

                return lzzzzzzzzzzzf_;
            };
            IEnumerable<Dosage> kzzzzzzzzzzzd_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)jzzzzzzzzzzzr_, kzzzzzzzzzzzc_);
            Timing kzzzzzzzzzzze_(Dosage @this)
            {
                Timing lzzzzzzzzzzzg_ = @this?.Timing;

                return lzzzzzzzzzzzg_;
            };
            IEnumerable<Timing> kzzzzzzzzzzzf_ = context.Operators.Select<Dosage, Timing>(kzzzzzzzzzzzd_, kzzzzzzzzzzze_);
            bool? kzzzzzzzzzzzg_(Timing @this)
            {
                Timing.RepeatComponent lzzzzzzzzzzzh_ = @this?.Repeat;
                bool? lzzzzzzzzzzzi_ = context.Operators.Not((bool?)(lzzzzzzzzzzzh_ is null));

                return lzzzzzzzzzzzi_;
            };
            IEnumerable<Timing> kzzzzzzzzzzzh_ = context.Operators.Where<Timing>(kzzzzzzzzzzzf_, kzzzzzzzzzzzg_);
            Timing.RepeatComponent kzzzzzzzzzzzi_(Timing @this)
            {
                Timing.RepeatComponent lzzzzzzzzzzzj_ = @this?.Repeat;

                return lzzzzzzzzzzzj_;
            };
            IEnumerable<Timing.RepeatComponent> kzzzzzzzzzzzj_ = context.Operators.Select<Timing, Timing.RepeatComponent>(kzzzzzzzzzzzh_, kzzzzzzzzzzzi_);
            bool? kzzzzzzzzzzzk_(Timing.RepeatComponent @this)
            {
                DataType lzzzzzzzzzzzk_ = @this?.Bounds;
                object lzzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzk_);
                bool? lzzzzzzzzzzzm_ = context.Operators.Not((bool?)(lzzzzzzzzzzzl_ is null));

                return lzzzzzzzzzzzm_;
            };
            IEnumerable<Timing.RepeatComponent> kzzzzzzzzzzzl_ = context.Operators.Where<Timing.RepeatComponent>(kzzzzzzzzzzzj_, kzzzzzzzzzzzk_);
            object kzzzzzzzzzzzm_(Timing.RepeatComponent @this)
            {
                DataType lzzzzzzzzzzzn_ = @this?.Bounds;
                object lzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, lzzzzzzzzzzzn_);

                return lzzzzzzzzzzzo_;
            };
            IEnumerable<object> kzzzzzzzzzzzn_ = context.Operators.Select<Timing.RepeatComponent, object>(kzzzzzzzzzzzl_, kzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzo_(object DoseTime)
            {
                CqlInterval<CqlDateTime> lzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return lzzzzzzzzzzzp_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzp_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(kzzzzzzzzzzzn_, kzzzzzzzzzzzo_);
            IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzp_);
            IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzr_ = context.Operators.Collapse(kzzzzzzzzzzzq_, default);
            object kzzzzzzzzzzzs_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime lzzzzzzzzzzzq_ = context.Operators.Start(@this);

                return lzzzzzzzzzzzq_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> kzzzzzzzzzzzt_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzr_, kzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzu_ = context.Operators.First<CqlInterval<CqlDateTime>>(kzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> kzzzzzzzzzzzv_ = this.NormalizeInterval(context, kzzzzzzzzzzza_, kzzzzzzzzzzzu_);
            CqlDateTime kzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, kzzzzzzzzzzzv_ as object);

            return kzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDateTime> jzzzzzzzzzzze_ = context.Operators.Select<MedicationRequest, CqlDateTime>(jzzzzzzzzzzzc_, jzzzzzzzzzzzd_);
        IEnumerable<CqlDateTime> jzzzzzzzzzzzf_ = context.Operators.Distinct<CqlDateTime>(jzzzzzzzzzzze_);

        return jzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition(
        definitionName: "Androgen Deprivation Therapy for Urology Care Medication Order Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(CqlContext context)
    {
        CqlValueSet lzzzzzzzzzzzr_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> lzzzzzzzzzzzs_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzu_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, lzzzzzzzzzzzr_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> lzzzzzzzzzzzv_ = context.Operators.Union<MedicationRequest>(lzzzzzzzzzzzs_, lzzzzzzzzzzzu_);
        bool? lzzzzzzzzzzzw_(MedicationRequest ADTOrder)
        {
            Code<MedicationRequest.MedicationrequestStatus> mzzzzzzzzzzzb_ = ADTOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? mzzzzzzzzzzzc_ = mzzzzzzzzzzzb_?.Value;
            string mzzzzzzzzzzzd_ = context.Operators.Convert<string>(mzzzzzzzzzzzc_);
            string[] mzzzzzzzzzzze_ = [
                "active",
                "completed",
            ];
            bool? mzzzzzzzzzzzf_ = context.Operators.In<string>(mzzzzzzzzzzzd_, mzzzzzzzzzzze_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> mzzzzzzzzzzzg_ = ADTOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? mzzzzzzzzzzzh_ = mzzzzzzzzzzzg_?.Value;
            string mzzzzzzzzzzzi_ = context.Operators.Convert<string>(mzzzzzzzzzzzh_);
            string[] mzzzzzzzzzzzj_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? mzzzzzzzzzzzk_ = context.Operators.In<string>(mzzzzzzzzzzzi_, mzzzzzzzzzzzj_ as IEnumerable<string>);
            bool? mzzzzzzzzzzzl_ = context.Operators.And(mzzzzzzzzzzzf_, mzzzzzzzzzzzk_);

            return mzzzzzzzzzzzl_;
        };
        IEnumerable<MedicationRequest> lzzzzzzzzzzzx_ = context.Operators.Where<MedicationRequest>(lzzzzzzzzzzzv_, lzzzzzzzzzzzw_);
        CqlDateTime lzzzzzzzzzzzy_(MedicationRequest ADTOrder)
        {
            FhirDateTime mzzzzzzzzzzzm_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime mzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(mzzzzzzzzzzzm_);
            List<Dosage> mzzzzzzzzzzzo_ = ADTOrder?.DosageInstruction;
            bool? mzzzzzzzzzzzp_(Dosage @this)
            {
                Timing nzzzzzzzzzzzk_ = @this?.Timing;
                bool? nzzzzzzzzzzzl_ = context.Operators.Not((bool?)(nzzzzzzzzzzzk_ is null));

                return nzzzzzzzzzzzl_;
            };
            IEnumerable<Dosage> mzzzzzzzzzzzq_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)mzzzzzzzzzzzo_, mzzzzzzzzzzzp_);
            Timing mzzzzzzzzzzzr_(Dosage @this)
            {
                Timing nzzzzzzzzzzzm_ = @this?.Timing;

                return nzzzzzzzzzzzm_;
            };
            IEnumerable<Timing> mzzzzzzzzzzzs_ = context.Operators.Select<Dosage, Timing>(mzzzzzzzzzzzq_, mzzzzzzzzzzzr_);
            bool? mzzzzzzzzzzzt_(Timing @this)
            {
                Timing.RepeatComponent nzzzzzzzzzzzn_ = @this?.Repeat;
                bool? nzzzzzzzzzzzo_ = context.Operators.Not((bool?)(nzzzzzzzzzzzn_ is null));

                return nzzzzzzzzzzzo_;
            };
            IEnumerable<Timing> mzzzzzzzzzzzu_ = context.Operators.Where<Timing>(mzzzzzzzzzzzs_, mzzzzzzzzzzzt_);
            Timing.RepeatComponent mzzzzzzzzzzzv_(Timing @this)
            {
                Timing.RepeatComponent nzzzzzzzzzzzp_ = @this?.Repeat;

                return nzzzzzzzzzzzp_;
            };
            IEnumerable<Timing.RepeatComponent> mzzzzzzzzzzzw_ = context.Operators.Select<Timing, Timing.RepeatComponent>(mzzzzzzzzzzzu_, mzzzzzzzzzzzv_);
            bool? mzzzzzzzzzzzx_(Timing.RepeatComponent @this)
            {
                DataType nzzzzzzzzzzzq_ = @this?.Bounds;
                object nzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzq_);
                bool? nzzzzzzzzzzzs_ = context.Operators.Not((bool?)(nzzzzzzzzzzzr_ is null));

                return nzzzzzzzzzzzs_;
            };
            IEnumerable<Timing.RepeatComponent> mzzzzzzzzzzzy_ = context.Operators.Where<Timing.RepeatComponent>(mzzzzzzzzzzzw_, mzzzzzzzzzzzx_);
            object mzzzzzzzzzzzz_(Timing.RepeatComponent @this)
            {
                DataType nzzzzzzzzzzzt_ = @this?.Bounds;
                object nzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzt_);

                return nzzzzzzzzzzzu_;
            };
            IEnumerable<object> nzzzzzzzzzzza_ = context.Operators.Select<Timing.RepeatComponent, object>(mzzzzzzzzzzzy_, mzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzb_(object DoseTime)
            {
                CqlInterval<CqlDateTime> nzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return nzzzzzzzzzzzv_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzc_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(nzzzzzzzzzzza_, nzzzzzzzzzzzb_);
            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzc_);
            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzze_ = context.Operators.Collapse(nzzzzzzzzzzzd_, default);
            object nzzzzzzzzzzzf_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime nzzzzzzzzzzzw_ = context.Operators.Start(@this);

                return nzzzzzzzzzzzw_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> nzzzzzzzzzzzg_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(nzzzzzzzzzzze_, nzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzh_ = context.Operators.First<CqlInterval<CqlDateTime>>(nzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> nzzzzzzzzzzzi_ = this.NormalizeInterval(context, mzzzzzzzzzzzn_, nzzzzzzzzzzzh_);
            CqlDateTime nzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, nzzzzzzzzzzzi_ as object);

            return nzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDateTime> lzzzzzzzzzzzz_ = context.Operators.Select<MedicationRequest, CqlDateTime>(lzzzzzzzzzzzx_, lzzzzzzzzzzzy_);
        IEnumerable<CqlDateTime> mzzzzzzzzzzza_ = context.Operators.Distinct<CqlDateTime>(lzzzzzzzzzzzz_);

        return mzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet nzzzzzzzzzzzx_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> nzzzzzzzzzzzy_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, nzzzzzzzzzzzx_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? nzzzzzzzzzzzz_(Condition ProstateCancer)
        {
            CqlInterval<CqlDateTime> ozzzzzzzzzzzb_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> ozzzzzzzzzzzc_ = this.Measurement_Period(context);
            bool? ozzzzzzzzzzzd_ = context.Operators.Overlaps(ozzzzzzzzzzzb_, ozzzzzzzzzzzc_, default);
            CodeableConcept ozzzzzzzzzzze_ = ProstateCancer?.ClinicalStatus;
            CqlConcept ozzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzze_);
            CqlCode ozzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.active(context);
            CqlConcept ozzzzzzzzzzzh_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzg_);
            bool? ozzzzzzzzzzzi_ = context.Operators.Equivalent(ozzzzzzzzzzzf_, ozzzzzzzzzzzh_);
            bool? ozzzzzzzzzzzj_ = context.Operators.And(ozzzzzzzzzzzd_, ozzzzzzzzzzzi_);
            CodeableConcept ozzzzzzzzzzzk_ = ProstateCancer?.VerificationStatus;
            CqlConcept ozzzzzzzzzzzl_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, ozzzzzzzzzzzk_);
            CqlCode ozzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.confirmed(context);
            CqlConcept ozzzzzzzzzzzn_ = context.Operators.ConvertCodeToConcept(ozzzzzzzzzzzm_);
            bool? ozzzzzzzzzzzo_ = context.Operators.Equivalent(ozzzzzzzzzzzl_, ozzzzzzzzzzzn_);
            bool? ozzzzzzzzzzzp_ = context.Operators.And(ozzzzzzzzzzzj_, ozzzzzzzzzzzo_);

            return ozzzzzzzzzzzp_;
        };
        IEnumerable<Condition> ozzzzzzzzzzza_ = context.Operators.Where<Condition>(nzzzzzzzzzzzy_, nzzzzzzzzzzzz_);

        return ozzzzzzzzzzza_;
    }


    [CqlExpressionDefinition(
        definitionName: "First ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public CqlDateTime First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context)
    {
        IEnumerable<CqlDateTime> ozzzzzzzzzzzq_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(context);
        IEnumerable<CqlDateTime> ozzzzzzzzzzzr_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(context);
        IEnumerable<CqlDateTime> ozzzzzzzzzzzs_ = context.Operators.Union<CqlDateTime>(ozzzzzzzzzzzq_, ozzzzzzzzzzzr_);
        IEnumerable<CqlDateTime> ozzzzzzzzzzzt_(CqlDateTime ADTDateTime)
        {
            IEnumerable<Condition> ozzzzzzzzzzzx_ = this.Prostate_Cancer_Diagnosis(context);
            bool? ozzzzzzzzzzzy_(Condition ProstateCancer)
            {
                CqlInterval<CqlDateTime> pzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
                bool? pzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(ADTDateTime, pzzzzzzzzzzzc_, "day");
                CqlInterval<CqlDateTime> pzzzzzzzzzzze_ = this.Measurement_Period(context);
                CqlDateTime pzzzzzzzzzzzf_ = context.Operators.Start(pzzzzzzzzzzze_);
                CqlQuantity pzzzzzzzzzzzg_ = context.Operators.Quantity(3m, "months");
                CqlDateTime pzzzzzzzzzzzh_ = context.Operators.Subtract(pzzzzzzzzzzzf_, pzzzzzzzzzzzg_);
                CqlDateTime pzzzzzzzzzzzj_ = context.Operators.Start(pzzzzzzzzzzze_);
                CqlQuantity pzzzzzzzzzzzk_ = context.Operators.Quantity(9m, "months");
                CqlDateTime pzzzzzzzzzzzl_ = context.Operators.Add(pzzzzzzzzzzzj_, pzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> pzzzzzzzzzzzm_ = context.Operators.Interval(pzzzzzzzzzzzh_, pzzzzzzzzzzzl_, true, true);
                bool? pzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(ADTDateTime, pzzzzzzzzzzzm_, "day");
                bool? pzzzzzzzzzzzo_ = context.Operators.And(pzzzzzzzzzzzd_, pzzzzzzzzzzzn_);

                return pzzzzzzzzzzzo_;
            };
            IEnumerable<Condition> ozzzzzzzzzzzz_ = context.Operators.Where<Condition>(ozzzzzzzzzzzx_, ozzzzzzzzzzzy_);
            CqlDateTime pzzzzzzzzzzza_(Condition ProstateCancer) =>
                ADTDateTime;
            IEnumerable<CqlDateTime> pzzzzzzzzzzzb_ = context.Operators.Select<Condition, CqlDateTime>(ozzzzzzzzzzzz_, pzzzzzzzzzzza_);

            return pzzzzzzzzzzzb_;
        };
        IEnumerable<CqlDateTime> ozzzzzzzzzzzu_ = context.Operators.SelectMany<CqlDateTime, CqlDateTime>(ozzzzzzzzzzzs_, ozzzzzzzzzzzt_);
        IEnumerable<CqlDateTime> ozzzzzzzzzzzv_ = context.Operators.ListSort<CqlDateTime>(ozzzzzzzzzzzu_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime ozzzzzzzzzzzw_ = context.Operators.First<CqlDateTime>(ozzzzzzzzzzzv_);

        return ozzzzzzzzzzzw_;
    }


    [CqlExpressionDefinition(
        definitionName: "Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public IEnumerable<ServiceRequest> Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzp_ = this.Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(context);
        IEnumerable<CqlCode> pzzzzzzzzzzzq_ = context.Operators.ToList<CqlCode>(pzzzzzzzzzzzp_);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzr_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, pzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzs_(ServiceRequest OrderTwelveMonthADT)
        {
            CqlDateTime pzzzzzzzzzzzu_ = this.First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            CqlDateTime[] pzzzzzzzzzzzv_ = [
                pzzzzzzzzzzzu_,
            ];
            bool? pzzzzzzzzzzzw_(CqlDateTime FirstADTMP)
            {
                FhirDateTime qzzzzzzzzzzza_ = OrderTwelveMonthADT?.AuthoredOnElement;
                CqlDateTime qzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzza_);
                bool? qzzzzzzzzzzzc_ = context.Operators.SameOrAfter(qzzzzzzzzzzzb_, FirstADTMP, "day");
                CqlDateTime qzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(qzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzf_ = this.Measurement_Period(context);
                CqlDateTime qzzzzzzzzzzzg_ = context.Operators.Start(qzzzzzzzzzzzf_);
                CqlQuantity qzzzzzzzzzzzh_ = context.Operators.Quantity(3m, "months");
                CqlDateTime qzzzzzzzzzzzi_ = context.Operators.Subtract(qzzzzzzzzzzzg_, qzzzzzzzzzzzh_);
                CqlDateTime qzzzzzzzzzzzk_ = context.Operators.Start(qzzzzzzzzzzzf_);
                CqlQuantity qzzzzzzzzzzzl_ = context.Operators.Quantity(9m, "months");
                CqlDateTime qzzzzzzzzzzzm_ = context.Operators.Add(qzzzzzzzzzzzk_, qzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzn_ = context.Operators.Interval(qzzzzzzzzzzzi_, qzzzzzzzzzzzm_, true, true);
                bool? qzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(qzzzzzzzzzzze_, qzzzzzzzzzzzn_, "day");
                bool? qzzzzzzzzzzzp_ = context.Operators.And(qzzzzzzzzzzzc_, qzzzzzzzzzzzo_);
                Code<RequestStatus> qzzzzzzzzzzzq_ = OrderTwelveMonthADT?.StatusElement;
                RequestStatus? qzzzzzzzzzzzr_ = qzzzzzzzzzzzq_?.Value;
                Code<RequestStatus> qzzzzzzzzzzzs_ = context.Operators.Convert<Code<RequestStatus>>(qzzzzzzzzzzzr_);
                string qzzzzzzzzzzzt_ = context.Operators.Convert<string>(qzzzzzzzzzzzs_);
                string[] qzzzzzzzzzzzu_ = [
                    "active",
                    "completed",
                ];
                bool? qzzzzzzzzzzzv_ = context.Operators.In<string>(qzzzzzzzzzzzt_, qzzzzzzzzzzzu_ as IEnumerable<string>);
                bool? qzzzzzzzzzzzw_ = context.Operators.And(qzzzzzzzzzzzp_, qzzzzzzzzzzzv_);
                Code<RequestIntent> qzzzzzzzzzzzx_ = OrderTwelveMonthADT?.IntentElement;
                RequestIntent? qzzzzzzzzzzzy_ = qzzzzzzzzzzzx_?.Value;
                Code<RequestIntent> qzzzzzzzzzzzz_ = context.Operators.Convert<Code<RequestIntent>>(qzzzzzzzzzzzy_);
                bool? rzzzzzzzzzzza_ = context.Operators.Equal(qzzzzzzzzzzzz_, "order");
                bool? rzzzzzzzzzzzb_ = context.Operators.And(qzzzzzzzzzzzw_, rzzzzzzzzzzza_);
                FhirBoolean rzzzzzzzzzzzc_ = OrderTwelveMonthADT?.DoNotPerformElement;
                bool? rzzzzzzzzzzzd_ = rzzzzzzzzzzzc_?.Value;
                bool? rzzzzzzzzzzze_ = context.Operators.IsTrue(rzzzzzzzzzzzd_);
                bool? rzzzzzzzzzzzf_ = context.Operators.Not(rzzzzzzzzzzze_);
                bool? rzzzzzzzzzzzg_ = context.Operators.And(rzzzzzzzzzzzb_, rzzzzzzzzzzzf_);

                return rzzzzzzzzzzzg_;
            };
            IEnumerable<CqlDateTime> pzzzzzzzzzzzx_ = context.Operators.Where<CqlDateTime>((IEnumerable<CqlDateTime>)pzzzzzzzzzzzv_, pzzzzzzzzzzzw_);
            ServiceRequest pzzzzzzzzzzzy_(CqlDateTime FirstADTMP) =>
                OrderTwelveMonthADT;
            IEnumerable<ServiceRequest> pzzzzzzzzzzzz_ = context.Operators.Select<CqlDateTime, ServiceRequest>(pzzzzzzzzzzzx_, pzzzzzzzzzzzy_);

            return pzzzzzzzzzzzz_;
        };
        IEnumerable<ServiceRequest> pzzzzzzzzzzzt_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(pzzzzzzzzzzzr_, pzzzzzzzzzzzs_);

        return pzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? rzzzzzzzzzzzh_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<ServiceRequest> rzzzzzzzzzzzi_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
        bool? rzzzzzzzzzzzj_ = context.Operators.Exists<ServiceRequest>(rzzzzzzzzzzzi_);
        bool? rzzzzzzzzzzzk_ = context.Operators.And(rzzzzzzzzzzzh_, rzzzzzzzzzzzj_);

        return rzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? rzzzzzzzzzzzl_ = this.Initial_Population(context);

        return rzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition(
        definitionName: "Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT")]
    public bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(CqlContext context)
    {
        CqlValueSet rzzzzzzzzzzzm_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> rzzzzzzzzzzzn_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, rzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> rzzzzzzzzzzzo_(ServiceRequest DEXAOrdered)
        {
            IEnumerable<ServiceRequest> szzzzzzzzzzza_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? szzzzzzzzzzzb_(ServiceRequest OrderTwelveMonthsADT)
            {
                FhirDateTime szzzzzzzzzzzf_ = DEXAOrdered?.AuthoredOnElement;
                CqlDateTime szzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzf_);
                FhirDateTime szzzzzzzzzzzh_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime szzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzh_);
                CqlDateTime szzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzh_);
                CqlQuantity szzzzzzzzzzzl_ = context.Operators.Quantity(3m, "months");
                CqlDateTime szzzzzzzzzzzm_ = context.Operators.Add(szzzzzzzzzzzk_, szzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> szzzzzzzzzzzn_ = context.Operators.Interval(szzzzzzzzzzzi_, szzzzzzzzzzzm_, true, true);
                bool? szzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzg_, szzzzzzzzzzzn_, "day");
                CqlDateTime szzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzh_);
                bool? szzzzzzzzzzzr_ = context.Operators.Not((bool?)(szzzzzzzzzzzq_ is null));
                bool? szzzzzzzzzzzs_ = context.Operators.And(szzzzzzzzzzzo_, szzzzzzzzzzzr_);
                CqlDateTime szzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzf_);
                CqlDateTime szzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzh_);
                CqlQuantity szzzzzzzzzzzx_ = context.Operators.Quantity(2m, "years");
                CqlDateTime szzzzzzzzzzzy_ = context.Operators.Subtract(szzzzzzzzzzzw_, szzzzzzzzzzzx_);
                CqlDateTime tzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> tzzzzzzzzzzzb_ = context.Operators.Interval(szzzzzzzzzzzy_, tzzzzzzzzzzza_, true, false);
                bool? tzzzzzzzzzzzc_ = context.Operators.In<CqlDateTime>(szzzzzzzzzzzu_, tzzzzzzzzzzzb_, "day");
                CqlDateTime tzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(szzzzzzzzzzzh_);
                bool? tzzzzzzzzzzzf_ = context.Operators.Not((bool?)(tzzzzzzzzzzze_ is null));
                bool? tzzzzzzzzzzzg_ = context.Operators.And(tzzzzzzzzzzzc_, tzzzzzzzzzzzf_);
                bool? tzzzzzzzzzzzh_ = context.Operators.Or(szzzzzzzzzzzs_, tzzzzzzzzzzzg_);

                return tzzzzzzzzzzzh_;
            };
            IEnumerable<ServiceRequest> szzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(szzzzzzzzzzza_, szzzzzzzzzzzb_);
            ServiceRequest szzzzzzzzzzzd_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXAOrdered;
            IEnumerable<ServiceRequest> szzzzzzzzzzze_ = context.Operators.Select<ServiceRequest, ServiceRequest>(szzzzzzzzzzzc_, szzzzzzzzzzzd_);

            return szzzzzzzzzzze_;
        };
        IEnumerable<ServiceRequest> rzzzzzzzzzzzp_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(rzzzzzzzzzzzn_, rzzzzzzzzzzzo_);
        bool? rzzzzzzzzzzzq_(ServiceRequest DEXAOrdered)
        {
            Code<RequestStatus> tzzzzzzzzzzzi_ = DEXAOrdered?.StatusElement;
            RequestStatus? tzzzzzzzzzzzj_ = tzzzzzzzzzzzi_?.Value;
            Code<RequestStatus> tzzzzzzzzzzzk_ = context.Operators.Convert<Code<RequestStatus>>(tzzzzzzzzzzzj_);
            string tzzzzzzzzzzzl_ = context.Operators.Convert<string>(tzzzzzzzzzzzk_);
            string[] tzzzzzzzzzzzm_ = [
                "active",
                "completed",
            ];
            bool? tzzzzzzzzzzzn_ = context.Operators.In<string>(tzzzzzzzzzzzl_, tzzzzzzzzzzzm_ as IEnumerable<string>);
            Code<RequestIntent> tzzzzzzzzzzzo_ = DEXAOrdered?.IntentElement;
            RequestIntent? tzzzzzzzzzzzp_ = tzzzzzzzzzzzo_?.Value;
            Code<RequestIntent> tzzzzzzzzzzzq_ = context.Operators.Convert<Code<RequestIntent>>(tzzzzzzzzzzzp_);
            bool? tzzzzzzzzzzzr_ = context.Operators.Equal(tzzzzzzzzzzzq_, "order");
            bool? tzzzzzzzzzzzs_ = context.Operators.And(tzzzzzzzzzzzn_, tzzzzzzzzzzzr_);
            FhirBoolean tzzzzzzzzzzzt_ = DEXAOrdered?.DoNotPerformElement;
            bool? tzzzzzzzzzzzu_ = tzzzzzzzzzzzt_?.Value;
            bool? tzzzzzzzzzzzv_ = context.Operators.IsTrue(tzzzzzzzzzzzu_);
            bool? tzzzzzzzzzzzw_ = context.Operators.Not(tzzzzzzzzzzzv_);
            bool? tzzzzzzzzzzzx_ = context.Operators.And(tzzzzzzzzzzzs_, tzzzzzzzzzzzw_);

            return tzzzzzzzzzzzx_;
        };
        IEnumerable<ServiceRequest> rzzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(rzzzzzzzzzzzp_, rzzzzzzzzzzzq_);
        IEnumerable<Observation> rzzzzzzzzzzzt_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, rzzzzzzzzzzzm_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> rzzzzzzzzzzzu_(Observation DEXAPerformed)
        {
            IEnumerable<ServiceRequest> tzzzzzzzzzzzy_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? tzzzzzzzzzzzz_(ServiceRequest OrderTwelveMonthsADT)
            {
                DataType uzzzzzzzzzzzd_ = DEXAPerformed?.Effective;
                object uzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzze_);
                CqlDateTime uzzzzzzzzzzzg_ = context.Operators.Start(uzzzzzzzzzzzf_);
                FhirDateTime uzzzzzzzzzzzh_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime uzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzh_);
                CqlDateTime uzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzh_);
                CqlQuantity uzzzzzzzzzzzl_ = context.Operators.Quantity(3m, "months");
                CqlDateTime uzzzzzzzzzzzm_ = context.Operators.Add(uzzzzzzzzzzzk_, uzzzzzzzzzzzl_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzn_ = context.Operators.Interval(uzzzzzzzzzzzi_, uzzzzzzzzzzzm_, true, true);
                bool? uzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzg_, uzzzzzzzzzzzn_, "day");
                CqlDateTime uzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzh_);
                bool? uzzzzzzzzzzzr_ = context.Operators.Not((bool?)(uzzzzzzzzzzzq_ is null));
                bool? uzzzzzzzzzzzs_ = context.Operators.And(uzzzzzzzzzzzo_, uzzzzzzzzzzzr_);
                object uzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToValue(context, uzzzzzzzzzzzd_);
                CqlInterval<CqlDateTime> uzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, uzzzzzzzzzzzu_);
                CqlDateTime uzzzzzzzzzzzw_ = context.Operators.End(uzzzzzzzzzzzv_);
                CqlDateTime uzzzzzzzzzzzy_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzh_);
                CqlQuantity uzzzzzzzzzzzz_ = context.Operators.Quantity(2m, "years");
                CqlDateTime vzzzzzzzzzzza_ = context.Operators.Subtract(uzzzzzzzzzzzy_, uzzzzzzzzzzzz_);
                CqlDateTime vzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzh_);
                CqlInterval<CqlDateTime> vzzzzzzzzzzzd_ = context.Operators.Interval(vzzzzzzzzzzza_, vzzzzzzzzzzzc_, true, false);
                bool? vzzzzzzzzzzze_ = context.Operators.In<CqlDateTime>(uzzzzzzzzzzzw_, vzzzzzzzzzzzd_, "day");
                CqlDateTime vzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(uzzzzzzzzzzzh_);
                bool? vzzzzzzzzzzzh_ = context.Operators.Not((bool?)(vzzzzzzzzzzzg_ is null));
                bool? vzzzzzzzzzzzi_ = context.Operators.And(vzzzzzzzzzzze_, vzzzzzzzzzzzh_);
                bool? vzzzzzzzzzzzj_ = context.Operators.Or(uzzzzzzzzzzzs_, vzzzzzzzzzzzi_);

                return vzzzzzzzzzzzj_;
            };
            IEnumerable<ServiceRequest> uzzzzzzzzzzza_ = context.Operators.Where<ServiceRequest>(tzzzzzzzzzzzy_, tzzzzzzzzzzzz_);
            Observation uzzzzzzzzzzzb_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXAPerformed;
            IEnumerable<Observation> uzzzzzzzzzzzc_ = context.Operators.Select<ServiceRequest, Observation>(uzzzzzzzzzzza_, uzzzzzzzzzzzb_);

            return uzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzv_ = context.Operators.SelectMany<Observation, Observation>(rzzzzzzzzzzzt_, rzzzzzzzzzzzu_);
        bool? rzzzzzzzzzzzw_(Observation DEXAPerformed)
        {
            Code<ObservationStatus> vzzzzzzzzzzzk_ = DEXAPerformed?.StatusElement;
            ObservationStatus? vzzzzzzzzzzzl_ = vzzzzzzzzzzzk_?.Value;
            Code<ObservationStatus> vzzzzzzzzzzzm_ = context.Operators.Convert<Code<ObservationStatus>>(vzzzzzzzzzzzl_);
            string vzzzzzzzzzzzn_ = context.Operators.Convert<string>(vzzzzzzzzzzzm_);
            string[] vzzzzzzzzzzzo_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? vzzzzzzzzzzzp_ = context.Operators.In<string>(vzzzzzzzzzzzn_, vzzzzzzzzzzzo_ as IEnumerable<string>);

            return vzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzx_ = context.Operators.Where<Observation>(rzzzzzzzzzzzv_, rzzzzzzzzzzzw_);
        IEnumerable<object> rzzzzzzzzzzzy_ = context.Operators.Union<object>(rzzzzzzzzzzzr_ as IEnumerable<object>, rzzzzzzzzzzzx_ as IEnumerable<object>);
        bool? rzzzzzzzzzzzz_ = context.Operators.Exists<object>(rzzzzzzzzzzzy_);

        return rzzzzzzzzzzzz_;
    }


    [CqlExpressionDefinition(
        definitionName: "Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? vzzzzzzzzzzzq_ = this.Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(context);

        return vzzzzzzzzzzzq_;
    }


    [CqlExpressionDefinition(
        definitionName: "Denominator Exception")]
    [CqlTag("commentedOut", "\"No Bone Density Scan Ordered Due to Patient Refusal\" ) ")]
    [CqlTag("commmentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in population, created a 'false' placeholder")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition(
        definitionName: "SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzr_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return vzzzzzzzzzzzr_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> vzzzzzzzzzzzs_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return vzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? vzzzzzzzzzzzt_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return vzzzzzzzzzzzt_;
    }


    [CqlExpressionDefinition(
        definitionName: "SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode vzzzzzzzzzzzu_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return vzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition(
        definitionName: "No Bone Density Scan Ordered Due to Patient Refusal")]
    public IEnumerable<ServiceRequest> No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzv_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> vzzzzzzzzzzzw_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzy_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, vzzzzzzzzzzzv_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> vzzzzzzzzzzzz_ = context.Operators.Union<ServiceRequest>(vzzzzzzzzzzzw_, vzzzzzzzzzzzy_);
        IEnumerable<ServiceRequest> wzzzzzzzzzzza_(ServiceRequest DEXANotOrdered)
        {
            IEnumerable<ServiceRequest> wzzzzzzzzzzzc_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? wzzzzzzzzzzzd_(ServiceRequest OrderTwelveMonthsADT)
            {
                FhirDateTime wzzzzzzzzzzzh_ = DEXANotOrdered?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzh_);
                FhirDateTime wzzzzzzzzzzzj_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime wzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzj_);
                CqlDateTime wzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzj_);
                CqlQuantity wzzzzzzzzzzzn_ = context.Operators.Quantity(3m, "months");
                CqlDateTime wzzzzzzzzzzzo_ = context.Operators.Add(wzzzzzzzzzzzm_, wzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzp_ = context.Operators.Interval(wzzzzzzzzzzzk_, wzzzzzzzzzzzo_, true, true);
                bool? wzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(wzzzzzzzzzzzi_, wzzzzzzzzzzzp_, "day");
                CqlDateTime wzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(wzzzzzzzzzzzj_);
                bool? wzzzzzzzzzzzt_ = context.Operators.Not((bool?)(wzzzzzzzzzzzs_ is null));
                bool? wzzzzzzzzzzzu_ = context.Operators.And(wzzzzzzzzzzzq_, wzzzzzzzzzzzt_);
                bool? wzzzzzzzzzzzv_(Extension @this)
                {
                    string xzzzzzzzzzzze_ = @this?.Url;
                    FhirString xzzzzzzzzzzzf_ = context.Operators.Convert<FhirString>(xzzzzzzzzzzze_);
                    string xzzzzzzzzzzzg_ = FHIRHelpers_4_4_000.Instance.ToString(context, xzzzzzzzzzzzf_);
                    bool? xzzzzzzzzzzzh_ = context.Operators.Equal(xzzzzzzzzzzzg_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return xzzzzzzzzzzzh_;
                };
                IEnumerable<Extension> wzzzzzzzzzzzw_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                        ? (DEXANotOrdered as DomainResource).Extension
                        : default), wzzzzzzzzzzzv_);
                object wzzzzzzzzzzzx_(Extension @this)
                {
                    DataType xzzzzzzzzzzzi_ = @this?.Value;

                    return xzzzzzzzzzzzi_;
                };
                IEnumerable<object> wzzzzzzzzzzzy_ = context.Operators.Select<Extension, object>(wzzzzzzzzzzzw_, wzzzzzzzzzzzx_);
                object wzzzzzzzzzzzz_ = context.Operators.SingletonFrom<object>(wzzzzzzzzzzzy_);
                CqlConcept xzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, wzzzzzzzzzzzz_ as CodeableConcept);
                CqlValueSet xzzzzzzzzzzzb_ = this.Patient_Declined(context);
                bool? xzzzzzzzzzzzc_ = context.Operators.ConceptInValueSet(xzzzzzzzzzzza_, xzzzzzzzzzzzb_);
                bool? xzzzzzzzzzzzd_ = context.Operators.And(wzzzzzzzzzzzu_, xzzzzzzzzzzzc_);

                return xzzzzzzzzzzzd_;
            };
            IEnumerable<ServiceRequest> wzzzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(wzzzzzzzzzzzc_, wzzzzzzzzzzzd_);
            ServiceRequest wzzzzzzzzzzzf_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXANotOrdered;
            IEnumerable<ServiceRequest> wzzzzzzzzzzzg_ = context.Operators.Select<ServiceRequest, ServiceRequest>(wzzzzzzzzzzze_, wzzzzzzzzzzzf_);

            return wzzzzzzzzzzzg_;
        };
        IEnumerable<ServiceRequest> wzzzzzzzzzzzb_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(vzzzzzzzzzzzz_, wzzzzzzzzzzza_);

        return wzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition(
        definitionName: "No Bone Density Scan Performed Due to Patient Refusal")]
    public IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(CqlContext context)
    {
        CqlValueSet xzzzzzzzzzzzj_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<Observation> xzzzzzzzzzzzk_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> xzzzzzzzzzzzm_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, xzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> xzzzzzzzzzzzn_ = context.Operators.Union<Observation>(xzzzzzzzzzzzk_, xzzzzzzzzzzzm_);
        IEnumerable<Observation> xzzzzzzzzzzzo_(Observation DEXANotPerformed)
        {
            IEnumerable<ServiceRequest> xzzzzzzzzzzzq_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? xzzzzzzzzzzzr_(ServiceRequest OrderTwelveMonthsADT)
            {
                Instant xzzzzzzzzzzzv_ = DEXANotPerformed?.IssuedElement;
                DateTimeOffset? xzzzzzzzzzzzw_ = xzzzzzzzzzzzv_?.Value;
                CqlDateTime xzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzw_);
                FhirDateTime xzzzzzzzzzzzy_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime xzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzy_);
                CqlDateTime yzzzzzzzzzzzb_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzy_);
                CqlQuantity yzzzzzzzzzzzc_ = context.Operators.Quantity(3m, "months");
                CqlDateTime yzzzzzzzzzzzd_ = context.Operators.Add(yzzzzzzzzzzzb_, yzzzzzzzzzzzc_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzze_ = context.Operators.Interval(xzzzzzzzzzzzz_, yzzzzzzzzzzzd_, true, true);
                bool? yzzzzzzzzzzzf_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzx_, yzzzzzzzzzzze_, "day");
                CqlDateTime yzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(xzzzzzzzzzzzy_);
                bool? yzzzzzzzzzzzi_ = context.Operators.Not((bool?)(yzzzzzzzzzzzh_ is null));
                bool? yzzzzzzzzzzzj_ = context.Operators.And(yzzzzzzzzzzzf_, yzzzzzzzzzzzi_);
                bool? yzzzzzzzzzzzk_(Extension @this)
                {
                    string yzzzzzzzzzzzt_ = @this?.Url;
                    FhirString yzzzzzzzzzzzu_ = context.Operators.Convert<FhirString>(yzzzzzzzzzzzt_);
                    string yzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToString(context, yzzzzzzzzzzzu_);
                    bool? yzzzzzzzzzzzw_ = context.Operators.Equal(yzzzzzzzzzzzv_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return yzzzzzzzzzzzw_;
                };
                IEnumerable<Extension> yzzzzzzzzzzzl_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                        ? (DEXANotPerformed as DomainResource).Extension
                        : default), yzzzzzzzzzzzk_);
                object yzzzzzzzzzzzm_(Extension @this)
                {
                    DataType yzzzzzzzzzzzx_ = @this?.Value;

                    return yzzzzzzzzzzzx_;
                };
                IEnumerable<object> yzzzzzzzzzzzn_ = context.Operators.Select<Extension, object>(yzzzzzzzzzzzl_, yzzzzzzzzzzzm_);
                object yzzzzzzzzzzzo_ = context.Operators.SingletonFrom<object>(yzzzzzzzzzzzn_);
                CqlConcept yzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, yzzzzzzzzzzzo_ as CodeableConcept);
                CqlValueSet yzzzzzzzzzzzq_ = this.Patient_Declined(context);
                bool? yzzzzzzzzzzzr_ = context.Operators.ConceptInValueSet(yzzzzzzzzzzzp_, yzzzzzzzzzzzq_);
                bool? yzzzzzzzzzzzs_ = context.Operators.And(yzzzzzzzzzzzj_, yzzzzzzzzzzzr_);

                return yzzzzzzzzzzzs_;
            };
            IEnumerable<ServiceRequest> xzzzzzzzzzzzs_ = context.Operators.Where<ServiceRequest>(xzzzzzzzzzzzq_, xzzzzzzzzzzzr_);
            Observation xzzzzzzzzzzzt_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXANotPerformed;
            IEnumerable<Observation> xzzzzzzzzzzzu_ = context.Operators.Select<ServiceRequest, Observation>(xzzzzzzzzzzzs_, xzzzzzzzzzzzt_);

            return xzzzzzzzzzzzu_;
        };
        IEnumerable<Observation> xzzzzzzzzzzzp_ = context.Operators.SelectMany<Observation, Observation>(xzzzzzzzzzzzn_, xzzzzzzzzzzzo_);

        return xzzzzzzzzzzzp_;
    }


    #endregion Expressions

}
