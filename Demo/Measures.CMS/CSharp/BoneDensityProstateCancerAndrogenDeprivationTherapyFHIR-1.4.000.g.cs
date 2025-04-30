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

    [CqlValueSetDefinition("Androgen deprivation therapy for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.48", valueSetVersion: null)]
    public CqlValueSet Androgen_deprivation_therapy_for_Urology_Care(CqlContext _) => _Androgen_deprivation_therapy_for_Urology_Care;
    private static readonly CqlValueSet _Androgen_deprivation_therapy_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.48", null);

    [CqlValueSetDefinition("DEXA Dual Energy Xray Absorptiometry, Bone Density for Urology Care", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.38", valueSetVersion: null)]
    public CqlValueSet DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(CqlContext _) => _DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care;
    private static readonly CqlValueSet _DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113762.1.4.1151.38", null);

    [CqlValueSetDefinition("Office Visit", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", valueSetVersion: null)]
    public CqlValueSet Office_Visit(CqlContext _) => _Office_Visit;
    private static readonly CqlValueSet _Office_Visit = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.464.1003.101.12.1001", null);

    [CqlValueSetDefinition("Patient Declined", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", valueSetVersion: null)]
    public CqlValueSet Patient_Declined(CqlContext _) => _Patient_Declined;
    private static readonly CqlValueSet _Patient_Declined = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.1582", null);

    [CqlValueSetDefinition("Prostate Cancer", valueSetId: "http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", valueSetVersion: null)]
    public CqlValueSet Prostate_Cancer(CqlContext _) => _Prostate_Cancer;
    private static readonly CqlValueSet _Prostate_Cancer = new CqlValueSet("http://cts.nlm.nih.gov/fhir/ValueSet/2.16.840.1.113883.3.526.3.319", null);

    #endregion ValueSets

    #region Codes

    [CqlCodeDefinition("Injection of leuprolide acetate for twelve month period (regime/therapy)", codeId: "456381000124102", codeSystem: "http://snomed.info/sct")]
    public CqlCode Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(CqlContext _) => _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_;
    private static readonly CqlCode _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_ = new CqlCode("456381000124102", "http://snomed.info/sct");

    #endregion Codes

    #region CodeSystems

    [CqlCodeSystemDefinition("SNOMEDCT")]
    public CqlCodeSystem SNOMEDCT(CqlContext _) => _SNOMEDCT;
    private static readonly CqlCodeSystem _SNOMEDCT =
      new CqlCodeSystem("http://snomed.info/sct", null,
          _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime vzzzzzzzzzzzzzk_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime vzzzzzzzzzzzzzl_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> vzzzzzzzzzzzzzm_ = context.Operators.Interval(vzzzzzzzzzzzzzk_, vzzzzzzzzzzzzzl_, true, true);
        object vzzzzzzzzzzzzzn_ = context.ResolveParameter("BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR-1.4.000", "Measurement Period", vzzzzzzzzzzzzzm_);

        return (CqlInterval<CqlDateTime>)vzzzzzzzzzzzzzn_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> vzzzzzzzzzzzzzo_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient vzzzzzzzzzzzzzp_ = context.Operators.SingletonFrom<Patient>(vzzzzzzzzzzzzzo_);

        return vzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet vzzzzzzzzzzzzzq_ = this.Office_Visit(context);
        IEnumerable<Encounter> vzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, vzzzzzzzzzzzzzq_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? vzzzzzzzzzzzzzs_(Encounter OfficeVisit)
        {
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzv_ = this.Measurement_Period(context);
            Period vzzzzzzzzzzzzzw_ = OfficeVisit?.Period;
            CqlInterval<CqlDateTime> vzzzzzzzzzzzzzx_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, vzzzzzzzzzzzzzw_);
            bool? vzzzzzzzzzzzzzy_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(vzzzzzzzzzzzzzv_, vzzzzzzzzzzzzzx_, default);
            Code<Encounter.EncounterStatus> vzzzzzzzzzzzzzz_ = OfficeVisit?.StatusElement;
            Encounter.EncounterStatus? wzzzzzzzzzzzzza_ = vzzzzzzzzzzzzzz_?.Value;
            Code<Encounter.EncounterStatus> wzzzzzzzzzzzzzb_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(wzzzzzzzzzzzzza_);
            bool? wzzzzzzzzzzzzzc_ = context.Operators.Equal(wzzzzzzzzzzzzzb_, "finished");
            bool? wzzzzzzzzzzzzzd_ = context.Operators.And(vzzzzzzzzzzzzzy_, wzzzzzzzzzzzzzc_);

            return wzzzzzzzzzzzzzd_;
        };
        IEnumerable<Encounter> vzzzzzzzzzzzzzt_ = context.Operators.Where<Encounter>(vzzzzzzzzzzzzzr_, vzzzzzzzzzzzzzs_);
        bool? vzzzzzzzzzzzzzu_ = context.Operators.Exists<Encounter>(vzzzzzzzzzzzzzt_);

        return vzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("NormalizeInterval")]
    public CqlInterval<CqlDateTime> NormalizeInterval(CqlContext context, CqlDateTime pointInTime, CqlInterval<CqlDateTime> dateTimeInterval)
    {
        CqlInterval<CqlDateTime> wzzzzzzzzzzzzze_()
        {
            if ((context.Operators.Not((bool?)(pointInTime is null))) ?? false)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzf_ = context.Operators.Interval(pointInTime, pointInTime, true, true);

                return wzzzzzzzzzzzzzf_;
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

        return wzzzzzzzzzzzzze_();
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Active Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(CqlContext context)
    {
        CqlValueSet wzzzzzzzzzzzzzg_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzj_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, wzzzzzzzzzzzzzg_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzk_ = context.Operators.Union<MedicationRequest>(wzzzzzzzzzzzzzh_, wzzzzzzzzzzzzzj_);
        bool? wzzzzzzzzzzzzzl_(MedicationRequest ADTActive)
        {
            Code<MedicationRequest.MedicationrequestStatus> wzzzzzzzzzzzzzq_ = ADTActive?.StatusElement;
            MedicationRequest.MedicationrequestStatus? wzzzzzzzzzzzzzr_ = wzzzzzzzzzzzzzq_?.Value;
            string wzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzr_);
            string[] wzzzzzzzzzzzzzt_ = [
                "active",
                "completed",
            ];
            bool? wzzzzzzzzzzzzzu_ = context.Operators.In<string>(wzzzzzzzzzzzzzs_, wzzzzzzzzzzzzzt_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> wzzzzzzzzzzzzzv_ = ADTActive?.IntentElement;
            MedicationRequest.MedicationRequestIntent? wzzzzzzzzzzzzzw_ = wzzzzzzzzzzzzzv_?.Value;
            string wzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(wzzzzzzzzzzzzzw_);
            string[] wzzzzzzzzzzzzzy_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? wzzzzzzzzzzzzzz_ = context.Operators.In<string>(wzzzzzzzzzzzzzx_, wzzzzzzzzzzzzzy_ as IEnumerable<string>);
            bool? xzzzzzzzzzzzzza_ = context.Operators.And(wzzzzzzzzzzzzzu_, wzzzzzzzzzzzzzz_);

            return xzzzzzzzzzzzzza_;
        };
        IEnumerable<MedicationRequest> wzzzzzzzzzzzzzm_ = context.Operators.Where<MedicationRequest>(wzzzzzzzzzzzzzk_, wzzzzzzzzzzzzzl_);
        CqlDateTime wzzzzzzzzzzzzzn_(MedicationRequest ADTActive)
        {
            List<Dosage> xzzzzzzzzzzzzzb_ = ADTActive?.DosageInstruction;
            bool? xzzzzzzzzzzzzzc_(Dosage @this)
            {
                Timing yzzzzzzzzzzzzzh_ = @this?.Timing;
                bool? yzzzzzzzzzzzzzi_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzh_ is null));

                return yzzzzzzzzzzzzzi_;
            };
            IEnumerable<Dosage> xzzzzzzzzzzzzzd_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzc_);
            Timing xzzzzzzzzzzzzze_(Dosage @this)
            {
                Timing yzzzzzzzzzzzzzj_ = @this?.Timing;

                return yzzzzzzzzzzzzzj_;
            };
            IEnumerable<Timing> xzzzzzzzzzzzzzf_ = context.Operators.Select<Dosage, Timing>(xzzzzzzzzzzzzzd_, xzzzzzzzzzzzzze_);
            CqlDateTime xzzzzzzzzzzzzzg_(Timing dosageTiming)
            {
                List<FhirDateTime> yzzzzzzzzzzzzzk_ = dosageTiming?.EventElement;
                IEnumerable<CqlDateTime> yzzzzzzzzzzzzzl_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(yzzzzzzzzzzzzzk_, "value");
                IEnumerable<CqlDateTime> yzzzzzzzzzzzzzm_ = context.Operators.ListSort<CqlDateTime>(yzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime yzzzzzzzzzzzzzn_ = context.Operators.First<CqlDateTime>(yzzzzzzzzzzzzzm_);

                return yzzzzzzzzzzzzzn_;
            };
            IEnumerable<CqlDateTime> xzzzzzzzzzzzzzh_ = context.Operators.Select<Timing, CqlDateTime>(xzzzzzzzzzzzzzf_, xzzzzzzzzzzzzzg_);
            IEnumerable<CqlDateTime> xzzzzzzzzzzzzzi_ = context.Operators.Distinct<CqlDateTime>(xzzzzzzzzzzzzzh_);
            IEnumerable<CqlDateTime> xzzzzzzzzzzzzzj_ = context.Operators.ListSort<CqlDateTime>(xzzzzzzzzzzzzzi_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime xzzzzzzzzzzzzzk_ = context.Operators.First<CqlDateTime>(xzzzzzzzzzzzzzj_);
            bool? xzzzzzzzzzzzzzm_(Dosage @this)
            {
                Timing yzzzzzzzzzzzzzo_ = @this?.Timing;
                bool? yzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzo_ is null));

                return yzzzzzzzzzzzzzp_;
            };
            IEnumerable<Dosage> xzzzzzzzzzzzzzn_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)xzzzzzzzzzzzzzb_, xzzzzzzzzzzzzzm_);
            Timing xzzzzzzzzzzzzzo_(Dosage @this)
            {
                Timing yzzzzzzzzzzzzzq_ = @this?.Timing;

                return yzzzzzzzzzzzzzq_;
            };
            IEnumerable<Timing> xzzzzzzzzzzzzzp_ = context.Operators.Select<Dosage, Timing>(xzzzzzzzzzzzzzn_, xzzzzzzzzzzzzzo_);
            bool? xzzzzzzzzzzzzzq_(Timing @this)
            {
                Timing.RepeatComponent yzzzzzzzzzzzzzr_ = @this?.Repeat;
                bool? yzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzr_ is null));

                return yzzzzzzzzzzzzzs_;
            };
            IEnumerable<Timing> xzzzzzzzzzzzzzr_ = context.Operators.Where<Timing>(xzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzq_);
            Timing.RepeatComponent xzzzzzzzzzzzzzs_(Timing @this)
            {
                Timing.RepeatComponent yzzzzzzzzzzzzzt_ = @this?.Repeat;

                return yzzzzzzzzzzzzzt_;
            };
            IEnumerable<Timing.RepeatComponent> xzzzzzzzzzzzzzt_ = context.Operators.Select<Timing, Timing.RepeatComponent>(xzzzzzzzzzzzzzr_, xzzzzzzzzzzzzzs_);
            bool? xzzzzzzzzzzzzzu_(Timing.RepeatComponent @this)
            {
                DataType yzzzzzzzzzzzzzu_ = @this?.Bounds;
                object yzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzu_);
                bool? yzzzzzzzzzzzzzw_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzv_ is null));

                return yzzzzzzzzzzzzzw_;
            };
            IEnumerable<Timing.RepeatComponent> xzzzzzzzzzzzzzv_ = context.Operators.Where<Timing.RepeatComponent>(xzzzzzzzzzzzzzt_, xzzzzzzzzzzzzzu_);
            object xzzzzzzzzzzzzzw_(Timing.RepeatComponent @this)
            {
                DataType yzzzzzzzzzzzzzx_ = @this?.Bounds;
                object yzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, yzzzzzzzzzzzzzx_);

                return yzzzzzzzzzzzzzy_;
            };
            IEnumerable<object> xzzzzzzzzzzzzzx_ = context.Operators.Select<Timing.RepeatComponent, object>(xzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzw_);
            CqlInterval<CqlDateTime> xzzzzzzzzzzzzzy_(object DoseTime)
            {
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return yzzzzzzzzzzzzzz_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> xzzzzzzzzzzzzzz_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzy_);
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzza_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(xzzzzzzzzzzzzzz_);
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzb_ = context.Operators.Collapse(yzzzzzzzzzzzzza_, default);
            object yzzzzzzzzzzzzzc_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime zzzzzzzzzzzzzza_ = context.Operators.Start(@this);

                return zzzzzzzzzzzzzza_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> yzzzzzzzzzzzzzd_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzb_, yzzzzzzzzzzzzzc_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzze_ = context.Operators.First<CqlInterval<CqlDateTime>>(yzzzzzzzzzzzzzd_);
            CqlInterval<CqlDateTime> yzzzzzzzzzzzzzf_ = this.NormalizeInterval(context, xzzzzzzzzzzzzzk_, yzzzzzzzzzzzzze_);
            CqlDateTime yzzzzzzzzzzzzzg_ = QICoreCommon_2_1_000.Instance.earliest(context, yzzzzzzzzzzzzzf_ as object);

            return yzzzzzzzzzzzzzg_;
        };
        IEnumerable<CqlDateTime> wzzzzzzzzzzzzzo_ = context.Operators.Select<MedicationRequest, CqlDateTime>(wzzzzzzzzzzzzzm_, wzzzzzzzzzzzzzn_);
        IEnumerable<CqlDateTime> wzzzzzzzzzzzzzp_ = context.Operators.Distinct<CqlDateTime>(wzzzzzzzzzzzzzo_);

        return wzzzzzzzzzzzzzp_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Order Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(CqlContext context)
    {
        CqlValueSet zzzzzzzzzzzzzzb_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzc_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzze_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, zzzzzzzzzzzzzzb_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzf_ = context.Operators.Union<MedicationRequest>(zzzzzzzzzzzzzzc_, zzzzzzzzzzzzzze_);
        bool? zzzzzzzzzzzzzzg_(MedicationRequest ADTOrder)
        {
            Code<MedicationRequest.MedicationrequestStatus> zzzzzzzzzzzzzzl_ = ADTOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? zzzzzzzzzzzzzzm_ = zzzzzzzzzzzzzzl_?.Value;
            string zzzzzzzzzzzzzzn_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzm_);
            string[] zzzzzzzzzzzzzzo_ = [
                "active",
                "completed",
            ];
            bool? zzzzzzzzzzzzzzp_ = context.Operators.In<string>(zzzzzzzzzzzzzzn_, zzzzzzzzzzzzzzo_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> zzzzzzzzzzzzzzq_ = ADTOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? zzzzzzzzzzzzzzr_ = zzzzzzzzzzzzzzq_?.Value;
            string zzzzzzzzzzzzzzs_ = context.Operators.Convert<string>(zzzzzzzzzzzzzzr_);
            string[] zzzzzzzzzzzzzzt_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? zzzzzzzzzzzzzzu_ = context.Operators.In<string>(zzzzzzzzzzzzzzs_, zzzzzzzzzzzzzzt_ as IEnumerable<string>);
            bool? zzzzzzzzzzzzzzv_ = context.Operators.And(zzzzzzzzzzzzzzp_, zzzzzzzzzzzzzzu_);

            return zzzzzzzzzzzzzzv_;
        };
        IEnumerable<MedicationRequest> zzzzzzzzzzzzzzh_ = context.Operators.Where<MedicationRequest>(zzzzzzzzzzzzzzf_, zzzzzzzzzzzzzzg_);
        CqlDateTime zzzzzzzzzzzzzzi_(MedicationRequest ADTOrder)
        {
            FhirDateTime zzzzzzzzzzzzzzw_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime zzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(zzzzzzzzzzzzzzw_);
            List<Dosage> zzzzzzzzzzzzzzy_ = ADTOrder?.DosageInstruction;
            bool? zzzzzzzzzzzzzzz_(Dosage @this)
            {
                Timing azzzzzzzzzzzzzzu_ = @this?.Timing;
                bool? azzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzu_ is null));

                return azzzzzzzzzzzzzzv_;
            };
            IEnumerable<Dosage> azzzzzzzzzzzzzza_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)zzzzzzzzzzzzzzy_, zzzzzzzzzzzzzzz_);
            Timing azzzzzzzzzzzzzzb_(Dosage @this)
            {
                Timing azzzzzzzzzzzzzzw_ = @this?.Timing;

                return azzzzzzzzzzzzzzw_;
            };
            IEnumerable<Timing> azzzzzzzzzzzzzzc_ = context.Operators.Select<Dosage, Timing>(azzzzzzzzzzzzzza_, azzzzzzzzzzzzzzb_);
            bool? azzzzzzzzzzzzzzd_(Timing @this)
            {
                Timing.RepeatComponent azzzzzzzzzzzzzzx_ = @this?.Repeat;
                bool? azzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(azzzzzzzzzzzzzzx_ is null));

                return azzzzzzzzzzzzzzy_;
            };
            IEnumerable<Timing> azzzzzzzzzzzzzze_ = context.Operators.Where<Timing>(azzzzzzzzzzzzzzc_, azzzzzzzzzzzzzzd_);
            Timing.RepeatComponent azzzzzzzzzzzzzzf_(Timing @this)
            {
                Timing.RepeatComponent azzzzzzzzzzzzzzz_ = @this?.Repeat;

                return azzzzzzzzzzzzzzz_;
            };
            IEnumerable<Timing.RepeatComponent> azzzzzzzzzzzzzzg_ = context.Operators.Select<Timing, Timing.RepeatComponent>(azzzzzzzzzzzzzze_, azzzzzzzzzzzzzzf_);
            bool? azzzzzzzzzzzzzzh_(Timing.RepeatComponent @this)
            {
                DataType bzzzzzzzzzzzzzza_ = @this?.Bounds;
                object bzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzza_);
                bool? bzzzzzzzzzzzzzzc_ = context.Operators.Not((bool?)(bzzzzzzzzzzzzzzb_ is null));

                return bzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Timing.RepeatComponent> azzzzzzzzzzzzzzi_ = context.Operators.Where<Timing.RepeatComponent>(azzzzzzzzzzzzzzg_, azzzzzzzzzzzzzzh_);
            object azzzzzzzzzzzzzzj_(Timing.RepeatComponent @this)
            {
                DataType bzzzzzzzzzzzzzzd_ = @this?.Bounds;
                object bzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, bzzzzzzzzzzzzzzd_);

                return bzzzzzzzzzzzzzze_;
            };
            IEnumerable<object> azzzzzzzzzzzzzzk_ = context.Operators.Select<Timing.RepeatComponent, object>(azzzzzzzzzzzzzzi_, azzzzzzzzzzzzzzj_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzl_(object DoseTime)
            {
                CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return bzzzzzzzzzzzzzzf_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzzzzzm_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(azzzzzzzzzzzzzzk_, azzzzzzzzzzzzzzl_);
            IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(azzzzzzzzzzzzzzm_);
            IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzzzzzo_ = context.Operators.Collapse(azzzzzzzzzzzzzzn_, default);
            object azzzzzzzzzzzzzzp_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime bzzzzzzzzzzzzzzg_ = context.Operators.Start(@this);

                return bzzzzzzzzzzzzzzg_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> azzzzzzzzzzzzzzq_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(azzzzzzzzzzzzzzo_, azzzzzzzzzzzzzzp_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzr_ = context.Operators.First<CqlInterval<CqlDateTime>>(azzzzzzzzzzzzzzq_);
            CqlInterval<CqlDateTime> azzzzzzzzzzzzzzs_ = this.NormalizeInterval(context, zzzzzzzzzzzzzzx_, azzzzzzzzzzzzzzr_);
            CqlDateTime azzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.earliest(context, azzzzzzzzzzzzzzs_ as object);

            return azzzzzzzzzzzzzzt_;
        };
        IEnumerable<CqlDateTime> zzzzzzzzzzzzzzj_ = context.Operators.Select<MedicationRequest, CqlDateTime>(zzzzzzzzzzzzzzh_, zzzzzzzzzzzzzzi_);
        IEnumerable<CqlDateTime> zzzzzzzzzzzzzzk_ = context.Operators.Distinct<CqlDateTime>(zzzzzzzzzzzzzzj_);

        return zzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzh_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> bzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, bzzzzzzzzzzzzzzh_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? bzzzzzzzzzzzzzzj_(Condition ProstateCancer)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzl_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzm_ = this.Measurement_Period(context);
            bool? bzzzzzzzzzzzzzzn_ = context.Operators.Overlaps(bzzzzzzzzzzzzzzl_, bzzzzzzzzzzzzzzm_, default);
            CodeableConcept bzzzzzzzzzzzzzzo_ = ProstateCancer?.ClinicalStatus;
            CqlConcept bzzzzzzzzzzzzzzp_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzo_);
            CqlCode bzzzzzzzzzzzzzzq_ = QICoreCommon_2_1_000.Instance.active(context);
            CqlConcept bzzzzzzzzzzzzzzr_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzq_);
            bool? bzzzzzzzzzzzzzzs_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzp_, bzzzzzzzzzzzzzzr_);
            bool? bzzzzzzzzzzzzzzt_ = context.Operators.And(bzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzs_);
            CodeableConcept bzzzzzzzzzzzzzzu_ = ProstateCancer?.VerificationStatus;
            CqlConcept bzzzzzzzzzzzzzzv_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, bzzzzzzzzzzzzzzu_);
            CqlCode bzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.confirmed(context);
            CqlConcept bzzzzzzzzzzzzzzx_ = context.Operators.ConvertCodeToConcept(bzzzzzzzzzzzzzzw_);
            bool? bzzzzzzzzzzzzzzy_ = context.Operators.Equivalent(bzzzzzzzzzzzzzzv_, bzzzzzzzzzzzzzzx_);
            bool? bzzzzzzzzzzzzzzz_ = context.Operators.And(bzzzzzzzzzzzzzzt_, bzzzzzzzzzzzzzzy_);

            return bzzzzzzzzzzzzzzz_;
        };
        IEnumerable<Condition> bzzzzzzzzzzzzzzk_ = context.Operators.Where<Condition>(bzzzzzzzzzzzzzzi_, bzzzzzzzzzzzzzzj_);

        return bzzzzzzzzzzzzzzk_;
    }


    [CqlExpressionDefinition("First ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public CqlDateTime First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context)
    {
        IEnumerable<CqlDateTime> czzzzzzzzzzzzzza_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(context);
        IEnumerable<CqlDateTime> czzzzzzzzzzzzzzb_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(context);
        IEnumerable<CqlDateTime> czzzzzzzzzzzzzzc_ = context.Operators.Union<CqlDateTime>(czzzzzzzzzzzzzza_, czzzzzzzzzzzzzzb_);
        IEnumerable<CqlDateTime> czzzzzzzzzzzzzzd_(CqlDateTime ADTDateTime)
        {
            IEnumerable<Condition> czzzzzzzzzzzzzzh_ = this.Prostate_Cancer_Diagnosis(context);
            bool? czzzzzzzzzzzzzzi_(Condition ProstateCancer)
            {
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzm_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
                bool? czzzzzzzzzzzzzzn_ = context.Operators.In<CqlDateTime>(ADTDateTime, czzzzzzzzzzzzzzm_, "day");
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzo_ = this.Measurement_Period(context);
                CqlDateTime czzzzzzzzzzzzzzp_ = context.Operators.Start(czzzzzzzzzzzzzzo_);
                CqlQuantity czzzzzzzzzzzzzzq_ = context.Operators.Quantity(3m, "months");
                CqlDateTime czzzzzzzzzzzzzzr_ = context.Operators.Subtract(czzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzq_);
                CqlDateTime czzzzzzzzzzzzzzt_ = context.Operators.Start(czzzzzzzzzzzzzzo_);
                CqlQuantity czzzzzzzzzzzzzzu_ = context.Operators.Quantity(9m, "months");
                CqlDateTime czzzzzzzzzzzzzzv_ = context.Operators.Add(czzzzzzzzzzzzzzt_, czzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzw_ = context.Operators.Interval(czzzzzzzzzzzzzzr_, czzzzzzzzzzzzzzv_, true, true);
                bool? czzzzzzzzzzzzzzx_ = context.Operators.In<CqlDateTime>(ADTDateTime, czzzzzzzzzzzzzzw_, "day");
                bool? czzzzzzzzzzzzzzy_ = context.Operators.And(czzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzx_);

                return czzzzzzzzzzzzzzy_;
            };
            IEnumerable<Condition> czzzzzzzzzzzzzzj_ = context.Operators.Where<Condition>(czzzzzzzzzzzzzzh_, czzzzzzzzzzzzzzi_);
            CqlDateTime czzzzzzzzzzzzzzk_(Condition ProstateCancer) =>
                ADTDateTime;
            IEnumerable<CqlDateTime> czzzzzzzzzzzzzzl_ = context.Operators.Select<Condition, CqlDateTime>(czzzzzzzzzzzzzzj_, czzzzzzzzzzzzzzk_);

            return czzzzzzzzzzzzzzl_;
        };
        IEnumerable<CqlDateTime> czzzzzzzzzzzzzze_ = context.Operators.SelectMany<CqlDateTime, CqlDateTime>(czzzzzzzzzzzzzzc_, czzzzzzzzzzzzzzd_);
        IEnumerable<CqlDateTime> czzzzzzzzzzzzzzf_ = context.Operators.ListSort<CqlDateTime>(czzzzzzzzzzzzzze_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime czzzzzzzzzzzzzzg_ = context.Operators.First<CqlDateTime>(czzzzzzzzzzzzzzf_);

        return czzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public IEnumerable<ServiceRequest> Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context)
    {
        CqlCode czzzzzzzzzzzzzzz_ = this.Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(context);
        IEnumerable<CqlCode> dzzzzzzzzzzzzzza_ = context.Operators.ToList<CqlCode>(czzzzzzzzzzzzzzz_);
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzb_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, dzzzzzzzzzzzzzza_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzc_(ServiceRequest OrderTwelveMonthADT)
        {
            CqlDateTime dzzzzzzzzzzzzzze_ = this.First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            CqlDateTime[] dzzzzzzzzzzzzzzf_ = [
                dzzzzzzzzzzzzzze_,
            ];
            bool? dzzzzzzzzzzzzzzg_(CqlDateTime FirstADTMP)
            {
                FhirDateTime dzzzzzzzzzzzzzzk_ = OrderTwelveMonthADT?.AuthoredOnElement;
                CqlDateTime dzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzk_);
                bool? dzzzzzzzzzzzzzzm_ = context.Operators.SameOrAfter(dzzzzzzzzzzzzzzl_, FirstADTMP, "day");
                CqlDateTime dzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(dzzzzzzzzzzzzzzk_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
                CqlDateTime dzzzzzzzzzzzzzzq_ = context.Operators.Start(dzzzzzzzzzzzzzzp_);
                CqlQuantity dzzzzzzzzzzzzzzr_ = context.Operators.Quantity(3m, "months");
                CqlDateTime dzzzzzzzzzzzzzzs_ = context.Operators.Subtract(dzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzr_);
                CqlDateTime dzzzzzzzzzzzzzzu_ = context.Operators.Start(dzzzzzzzzzzzzzzp_);
                CqlQuantity dzzzzzzzzzzzzzzv_ = context.Operators.Quantity(9m, "months");
                CqlDateTime dzzzzzzzzzzzzzzw_ = context.Operators.Add(dzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> dzzzzzzzzzzzzzzx_ = context.Operators.Interval(dzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzw_, true, true);
                bool? dzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(dzzzzzzzzzzzzzzo_, dzzzzzzzzzzzzzzx_, "day");
                bool? dzzzzzzzzzzzzzzz_ = context.Operators.And(dzzzzzzzzzzzzzzm_, dzzzzzzzzzzzzzzy_);
                Code<RequestStatus> ezzzzzzzzzzzzzza_ = OrderTwelveMonthADT?.StatusElement;
                RequestStatus? ezzzzzzzzzzzzzzb_ = ezzzzzzzzzzzzzza_?.Value;
                Code<RequestStatus> ezzzzzzzzzzzzzzc_ = context.Operators.Convert<Code<RequestStatus>>(ezzzzzzzzzzzzzzb_);
                string ezzzzzzzzzzzzzzd_ = context.Operators.Convert<string>(ezzzzzzzzzzzzzzc_);
                string[] ezzzzzzzzzzzzzze_ = [
                    "active",
                    "completed",
                ];
                bool? ezzzzzzzzzzzzzzf_ = context.Operators.In<string>(ezzzzzzzzzzzzzzd_, ezzzzzzzzzzzzzze_ as IEnumerable<string>);
                bool? ezzzzzzzzzzzzzzg_ = context.Operators.And(dzzzzzzzzzzzzzzz_, ezzzzzzzzzzzzzzf_);
                Code<RequestIntent> ezzzzzzzzzzzzzzh_ = OrderTwelveMonthADT?.IntentElement;
                RequestIntent? ezzzzzzzzzzzzzzi_ = ezzzzzzzzzzzzzzh_?.Value;
                Code<RequestIntent> ezzzzzzzzzzzzzzj_ = context.Operators.Convert<Code<RequestIntent>>(ezzzzzzzzzzzzzzi_);
                bool? ezzzzzzzzzzzzzzk_ = context.Operators.Equal(ezzzzzzzzzzzzzzj_, "order");
                bool? ezzzzzzzzzzzzzzl_ = context.Operators.And(ezzzzzzzzzzzzzzg_, ezzzzzzzzzzzzzzk_);
                FhirBoolean ezzzzzzzzzzzzzzm_ = OrderTwelveMonthADT?.DoNotPerformElement;
                bool? ezzzzzzzzzzzzzzn_ = ezzzzzzzzzzzzzzm_?.Value;
                bool? ezzzzzzzzzzzzzzo_ = context.Operators.IsTrue(ezzzzzzzzzzzzzzn_);
                bool? ezzzzzzzzzzzzzzp_ = context.Operators.Not(ezzzzzzzzzzzzzzo_);
                bool? ezzzzzzzzzzzzzzq_ = context.Operators.And(ezzzzzzzzzzzzzzl_, ezzzzzzzzzzzzzzp_);

                return ezzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlDateTime> dzzzzzzzzzzzzzzh_ = context.Operators.Where<CqlDateTime>((IEnumerable<CqlDateTime>)dzzzzzzzzzzzzzzf_, dzzzzzzzzzzzzzzg_);
            ServiceRequest dzzzzzzzzzzzzzzi_(CqlDateTime FirstADTMP) =>
                OrderTwelveMonthADT;
            IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzj_ = context.Operators.Select<CqlDateTime, ServiceRequest>(dzzzzzzzzzzzzzzh_, dzzzzzzzzzzzzzzi_);

            return dzzzzzzzzzzzzzzj_;
        };
        IEnumerable<ServiceRequest> dzzzzzzzzzzzzzzd_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(dzzzzzzzzzzzzzzb_, dzzzzzzzzzzzzzzc_);

        return dzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzr_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzs_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
        bool? ezzzzzzzzzzzzzzt_ = context.Operators.Exists<ServiceRequest>(ezzzzzzzzzzzzzzs_);
        bool? ezzzzzzzzzzzzzzu_ = context.Operators.And(ezzzzzzzzzzzzzzr_, ezzzzzzzzzzzzzzt_);

        return ezzzzzzzzzzzzzzu_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? ezzzzzzzzzzzzzzv_ = this.Initial_Population(context);

        return ezzzzzzzzzzzzzzv_;
    }


    [CqlExpressionDefinition("Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT")]
    public bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(CqlContext context)
    {
        CqlValueSet ezzzzzzzzzzzzzzw_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzx_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, ezzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzy_(ServiceRequest DEXAOrdered)
        {
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzk_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? fzzzzzzzzzzzzzzl_(ServiceRequest OrderTwelveMonthsADT)
            {
                FhirDateTime fzzzzzzzzzzzzzzp_ = DEXAOrdered?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzp_);
                FhirDateTime fzzzzzzzzzzzzzzr_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime fzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzr_);
                CqlDateTime fzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzr_);
                CqlQuantity fzzzzzzzzzzzzzzv_ = context.Operators.Quantity(3m, "months");
                CqlDateTime fzzzzzzzzzzzzzzw_ = context.Operators.Add(fzzzzzzzzzzzzzzu_, fzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzx_ = context.Operators.Interval(fzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzw_, true, true);
                bool? fzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(fzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzx_, "day");
                CqlDateTime gzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzr_);
                bool? gzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzza_ is null));
                bool? gzzzzzzzzzzzzzzc_ = context.Operators.And(fzzzzzzzzzzzzzzy_, gzzzzzzzzzzzzzzb_);
                CqlDateTime gzzzzzzzzzzzzzze_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzp_);
                CqlDateTime gzzzzzzzzzzzzzzg_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzr_);
                CqlQuantity gzzzzzzzzzzzzzzh_ = context.Operators.Quantity(2m, "years");
                CqlDateTime gzzzzzzzzzzzzzzi_ = context.Operators.Subtract(gzzzzzzzzzzzzzzg_, gzzzzzzzzzzzzzzh_);
                CqlDateTime gzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzl_ = context.Operators.Interval(gzzzzzzzzzzzzzzi_, gzzzzzzzzzzzzzzk_, true, false);
                bool? gzzzzzzzzzzzzzzm_ = context.Operators.In<CqlDateTime>(gzzzzzzzzzzzzzze_, gzzzzzzzzzzzzzzl_, "day");
                CqlDateTime gzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzr_);
                bool? gzzzzzzzzzzzzzzp_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzo_ is null));
                bool? gzzzzzzzzzzzzzzq_ = context.Operators.And(gzzzzzzzzzzzzzzm_, gzzzzzzzzzzzzzzp_);
                bool? gzzzzzzzzzzzzzzr_ = context.Operators.Or(gzzzzzzzzzzzzzzc_, gzzzzzzzzzzzzzzq_);

                return gzzzzzzzzzzzzzzr_;
            };
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzm_ = context.Operators.Where<ServiceRequest>(fzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzl_);
            ServiceRequest fzzzzzzzzzzzzzzn_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXAOrdered;
            IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzo_ = context.Operators.Select<ServiceRequest, ServiceRequest>(fzzzzzzzzzzzzzzm_, fzzzzzzzzzzzzzzn_);

            return fzzzzzzzzzzzzzzo_;
        };
        IEnumerable<ServiceRequest> ezzzzzzzzzzzzzzz_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(ezzzzzzzzzzzzzzx_, ezzzzzzzzzzzzzzy_);
        bool? fzzzzzzzzzzzzzza_(ServiceRequest DEXAOrdered)
        {
            Code<RequestStatus> gzzzzzzzzzzzzzzs_ = DEXAOrdered?.StatusElement;
            RequestStatus? gzzzzzzzzzzzzzzt_ = gzzzzzzzzzzzzzzs_?.Value;
            Code<RequestStatus> gzzzzzzzzzzzzzzu_ = context.Operators.Convert<Code<RequestStatus>>(gzzzzzzzzzzzzzzt_);
            string gzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(gzzzzzzzzzzzzzzu_);
            string[] gzzzzzzzzzzzzzzw_ = [
                "active",
                "completed",
            ];
            bool? gzzzzzzzzzzzzzzx_ = context.Operators.In<string>(gzzzzzzzzzzzzzzv_, gzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            Code<RequestIntent> gzzzzzzzzzzzzzzy_ = DEXAOrdered?.IntentElement;
            RequestIntent? gzzzzzzzzzzzzzzz_ = gzzzzzzzzzzzzzzy_?.Value;
            Code<RequestIntent> hzzzzzzzzzzzzzza_ = context.Operators.Convert<Code<RequestIntent>>(gzzzzzzzzzzzzzzz_);
            bool? hzzzzzzzzzzzzzzb_ = context.Operators.Equal(hzzzzzzzzzzzzzza_, "order");
            bool? hzzzzzzzzzzzzzzc_ = context.Operators.And(gzzzzzzzzzzzzzzx_, hzzzzzzzzzzzzzzb_);
            FhirBoolean hzzzzzzzzzzzzzzd_ = DEXAOrdered?.DoNotPerformElement;
            bool? hzzzzzzzzzzzzzze_ = hzzzzzzzzzzzzzzd_?.Value;
            bool? hzzzzzzzzzzzzzzf_ = context.Operators.IsTrue(hzzzzzzzzzzzzzze_);
            bool? hzzzzzzzzzzzzzzg_ = context.Operators.Not(hzzzzzzzzzzzzzzf_);
            bool? hzzzzzzzzzzzzzzh_ = context.Operators.And(hzzzzzzzzzzzzzzc_, hzzzzzzzzzzzzzzg_);

            return hzzzzzzzzzzzzzzh_;
        };
        IEnumerable<ServiceRequest> fzzzzzzzzzzzzzzb_ = context.Operators.Where<ServiceRequest>(ezzzzzzzzzzzzzzz_, fzzzzzzzzzzzzzza_);
        IEnumerable<Observation> fzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, ezzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> fzzzzzzzzzzzzzze_(Observation DEXAPerformed)
        {
            IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzi_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzj_(ServiceRequest OrderTwelveMonthsADT)
            {
                DataType hzzzzzzzzzzzzzzn_ = DEXAPerformed?.Effective;
                object hzzzzzzzzzzzzzzo_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.toInterval(context, hzzzzzzzzzzzzzzo_);
                CqlDateTime hzzzzzzzzzzzzzzq_ = context.Operators.Start(hzzzzzzzzzzzzzzp_);
                FhirDateTime hzzzzzzzzzzzzzzr_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime hzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzr_);
                CqlDateTime hzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzr_);
                CqlQuantity hzzzzzzzzzzzzzzv_ = context.Operators.Quantity(3m, "months");
                CqlDateTime hzzzzzzzzzzzzzzw_ = context.Operators.Add(hzzzzzzzzzzzzzzu_, hzzzzzzzzzzzzzzv_);
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzx_ = context.Operators.Interval(hzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzw_, true, true);
                bool? hzzzzzzzzzzzzzzy_ = context.Operators.In<CqlDateTime>(hzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzx_, "day");
                CqlDateTime izzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzr_);
                bool? izzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzza_ is null));
                bool? izzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzb_);
                object izzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzf_ = QICoreCommon_2_1_000.Instance.toInterval(context, izzzzzzzzzzzzzze_);
                CqlDateTime izzzzzzzzzzzzzzg_ = context.Operators.End(izzzzzzzzzzzzzzf_);
                CqlDateTime izzzzzzzzzzzzzzi_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzr_);
                CqlQuantity izzzzzzzzzzzzzzj_ = context.Operators.Quantity(2m, "years");
                CqlDateTime izzzzzzzzzzzzzzk_ = context.Operators.Subtract(izzzzzzzzzzzzzzi_, izzzzzzzzzzzzzzj_);
                CqlDateTime izzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzn_ = context.Operators.Interval(izzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzm_, true, false);
                bool? izzzzzzzzzzzzzzo_ = context.Operators.In<CqlDateTime>(izzzzzzzzzzzzzzg_, izzzzzzzzzzzzzzn_, "day");
                CqlDateTime izzzzzzzzzzzzzzq_ = context.Operators.Convert<CqlDateTime>(hzzzzzzzzzzzzzzr_);
                bool? izzzzzzzzzzzzzzr_ = context.Operators.Not((bool?)(izzzzzzzzzzzzzzq_ is null));
                bool? izzzzzzzzzzzzzzs_ = context.Operators.And(izzzzzzzzzzzzzzo_, izzzzzzzzzzzzzzr_);
                bool? izzzzzzzzzzzzzzt_ = context.Operators.Or(izzzzzzzzzzzzzzc_, izzzzzzzzzzzzzzs_);

                return izzzzzzzzzzzzzzt_;
            };
            IEnumerable<ServiceRequest> hzzzzzzzzzzzzzzk_ = context.Operators.Where<ServiceRequest>(hzzzzzzzzzzzzzzi_, hzzzzzzzzzzzzzzj_);
            Observation hzzzzzzzzzzzzzzl_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXAPerformed;
            IEnumerable<Observation> hzzzzzzzzzzzzzzm_ = context.Operators.Select<ServiceRequest, Observation>(hzzzzzzzzzzzzzzk_, hzzzzzzzzzzzzzzl_);

            return hzzzzzzzzzzzzzzm_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzf_ = context.Operators.SelectMany<Observation, Observation>(fzzzzzzzzzzzzzzd_, fzzzzzzzzzzzzzze_);
        bool? fzzzzzzzzzzzzzzg_(Observation DEXAPerformed)
        {
            Code<ObservationStatus> izzzzzzzzzzzzzzu_ = DEXAPerformed?.StatusElement;
            ObservationStatus? izzzzzzzzzzzzzzv_ = izzzzzzzzzzzzzzu_?.Value;
            Code<ObservationStatus> izzzzzzzzzzzzzzw_ = context.Operators.Convert<Code<ObservationStatus>>(izzzzzzzzzzzzzzv_);
            string izzzzzzzzzzzzzzx_ = context.Operators.Convert<string>(izzzzzzzzzzzzzzw_);
            string[] izzzzzzzzzzzzzzy_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? izzzzzzzzzzzzzzz_ = context.Operators.In<string>(izzzzzzzzzzzzzzx_, izzzzzzzzzzzzzzy_ as IEnumerable<string>);

            return izzzzzzzzzzzzzzz_;
        };
        IEnumerable<Observation> fzzzzzzzzzzzzzzh_ = context.Operators.Where<Observation>(fzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzg_);
        IEnumerable<object> fzzzzzzzzzzzzzzi_ = context.Operators.Union<object>(fzzzzzzzzzzzzzzb_ as IEnumerable<object>, fzzzzzzzzzzzzzzh_ as IEnumerable<object>);
        bool? fzzzzzzzzzzzzzzj_ = context.Operators.Exists<object>(fzzzzzzzzzzzzzzi_);

        return fzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? jzzzzzzzzzzzzzza_ = this.Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(context);

        return jzzzzzzzzzzzzzza_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    [CqlTag("commentedOut", "\"No Bone Density Scan Ordered Due to Patient Refusal\" ) ")]
    [CqlTag("commmentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in population, created a 'false' placeholder")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzb_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return jzzzzzzzzzzzzzzb_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> jzzzzzzzzzzzzzzc_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return jzzzzzzzzzzzzzzc_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? jzzzzzzzzzzzzzzd_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return jzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return jzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Ordered Due to Patient Refusal")]
    public IEnumerable<ServiceRequest> No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(CqlContext context)
    {
        CqlValueSet jzzzzzzzzzzzzzzf_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzi_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, jzzzzzzzzzzzzzzf_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzj_ = context.Operators.Union<ServiceRequest>(jzzzzzzzzzzzzzzg_, jzzzzzzzzzzzzzzi_);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzk_(ServiceRequest DEXANotOrdered)
        {
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzm_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? jzzzzzzzzzzzzzzn_(ServiceRequest OrderTwelveMonthsADT)
            {
                FhirDateTime jzzzzzzzzzzzzzzr_ = DEXANotOrdered?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzs_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzr_);
                FhirDateTime jzzzzzzzzzzzzzzt_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzt_);
                CqlDateTime jzzzzzzzzzzzzzzw_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzt_);
                CqlQuantity jzzzzzzzzzzzzzzx_ = context.Operators.Quantity(3m, "months");
                CqlDateTime jzzzzzzzzzzzzzzy_ = context.Operators.Add(jzzzzzzzzzzzzzzw_, jzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzz_ = context.Operators.Interval(jzzzzzzzzzzzzzzu_, jzzzzzzzzzzzzzzy_, true, true);
                bool? kzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzs_, jzzzzzzzzzzzzzzz_, "day");
                CqlDateTime kzzzzzzzzzzzzzzc_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzt_);
                bool? kzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(kzzzzzzzzzzzzzzc_ is null));
                bool? kzzzzzzzzzzzzzze_ = context.Operators.And(kzzzzzzzzzzzzzza_, kzzzzzzzzzzzzzzd_);
                bool? kzzzzzzzzzzzzzzf_(Extension @this)
                {
                    string kzzzzzzzzzzzzzzo_ = @this?.Url;
                    FhirString kzzzzzzzzzzzzzzp_ = context.Operators.Convert<FhirString>(kzzzzzzzzzzzzzzo_);
                    string kzzzzzzzzzzzzzzq_ = FHIRHelpers_4_4_000.Instance.ToString(context, kzzzzzzzzzzzzzzp_);
                    bool? kzzzzzzzzzzzzzzr_ = context.Operators.Equal(kzzzzzzzzzzzzzzq_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return kzzzzzzzzzzzzzzr_;
                };
                IEnumerable<Extension> kzzzzzzzzzzzzzzg_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                        ? (DEXANotOrdered as DomainResource).Extension
                        : default), kzzzzzzzzzzzzzzf_);
                object kzzzzzzzzzzzzzzh_(Extension @this)
                {
                    DataType kzzzzzzzzzzzzzzs_ = @this?.Value;

                    return kzzzzzzzzzzzzzzs_;
                };
                IEnumerable<object> kzzzzzzzzzzzzzzi_ = context.Operators.Select<Extension, object>(kzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzh_);
                object kzzzzzzzzzzzzzzj_ = context.Operators.SingletonFrom<object>(kzzzzzzzzzzzzzzi_);
                CqlConcept kzzzzzzzzzzzzzzk_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, kzzzzzzzzzzzzzzj_ as CodeableConcept);
                CqlValueSet kzzzzzzzzzzzzzzl_ = this.Patient_Declined(context);
                bool? kzzzzzzzzzzzzzzm_ = context.Operators.ConceptInValueSet(kzzzzzzzzzzzzzzk_, kzzzzzzzzzzzzzzl_);
                bool? kzzzzzzzzzzzzzzn_ = context.Operators.And(kzzzzzzzzzzzzzze_, kzzzzzzzzzzzzzzm_);

                return kzzzzzzzzzzzzzzn_;
            };
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzo_ = context.Operators.Where<ServiceRequest>(jzzzzzzzzzzzzzzm_, jzzzzzzzzzzzzzzn_);
            ServiceRequest jzzzzzzzzzzzzzzp_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXANotOrdered;
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzq_ = context.Operators.Select<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzo_, jzzzzzzzzzzzzzzp_);

            return jzzzzzzzzzzzzzzq_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzl_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzj_, jzzzzzzzzzzzzzzk_);

        return jzzzzzzzzzzzzzzl_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Performed Due to Patient Refusal")]
    public IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzt_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<Observation> kzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzw_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> kzzzzzzzzzzzzzzx_ = context.Operators.Union<Observation>(kzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzw_);
        IEnumerable<Observation> kzzzzzzzzzzzzzzy_(Observation DEXANotPerformed)
        {
            IEnumerable<ServiceRequest> lzzzzzzzzzzzzzza_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzb_(ServiceRequest OrderTwelveMonthsADT)
            {
                Instant lzzzzzzzzzzzzzzf_ = DEXANotPerformed?.IssuedElement;
                DateTimeOffset? lzzzzzzzzzzzzzzg_ = lzzzzzzzzzzzzzzf_?.Value;
                CqlDateTime lzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzg_);
                FhirDateTime lzzzzzzzzzzzzzzi_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzi_);
                CqlDateTime lzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzi_);
                CqlQuantity lzzzzzzzzzzzzzzm_ = context.Operators.Quantity(3m, "months");
                CqlDateTime lzzzzzzzzzzzzzzn_ = context.Operators.Add(lzzzzzzzzzzzzzzl_, lzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> lzzzzzzzzzzzzzzo_ = context.Operators.Interval(lzzzzzzzzzzzzzzj_, lzzzzzzzzzzzzzzn_, true, true);
                bool? lzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzh_, lzzzzzzzzzzzzzzo_, "day");
                CqlDateTime lzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzi_);
                bool? lzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(lzzzzzzzzzzzzzzr_ is null));
                bool? lzzzzzzzzzzzzzzt_ = context.Operators.And(lzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzs_);
                bool? lzzzzzzzzzzzzzzu_(Extension @this)
                {
                    string mzzzzzzzzzzzzzzd_ = @this?.Url;
                    FhirString mzzzzzzzzzzzzzze_ = context.Operators.Convert<FhirString>(mzzzzzzzzzzzzzzd_);
                    string mzzzzzzzzzzzzzzf_ = FHIRHelpers_4_4_000.Instance.ToString(context, mzzzzzzzzzzzzzze_);
                    bool? mzzzzzzzzzzzzzzg_ = context.Operators.Equal(mzzzzzzzzzzzzzzf_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return mzzzzzzzzzzzzzzg_;
                };
                IEnumerable<Extension> lzzzzzzzzzzzzzzv_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                        ? (DEXANotPerformed as DomainResource).Extension
                        : default), lzzzzzzzzzzzzzzu_);
                object lzzzzzzzzzzzzzzw_(Extension @this)
                {
                    DataType mzzzzzzzzzzzzzzh_ = @this?.Value;

                    return mzzzzzzzzzzzzzzh_;
                };
                IEnumerable<object> lzzzzzzzzzzzzzzx_ = context.Operators.Select<Extension, object>(lzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzw_);
                object lzzzzzzzzzzzzzzy_ = context.Operators.SingletonFrom<object>(lzzzzzzzzzzzzzzx_);
                CqlConcept lzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, lzzzzzzzzzzzzzzy_ as CodeableConcept);
                CqlValueSet mzzzzzzzzzzzzzza_ = this.Patient_Declined(context);
                bool? mzzzzzzzzzzzzzzb_ = context.Operators.ConceptInValueSet(lzzzzzzzzzzzzzzz_, mzzzzzzzzzzzzzza_);
                bool? mzzzzzzzzzzzzzzc_ = context.Operators.And(lzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzb_);

                return mzzzzzzzzzzzzzzc_;
            };
            IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzc_ = context.Operators.Where<ServiceRequest>(lzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzb_);
            Observation lzzzzzzzzzzzzzzd_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXANotPerformed;
            IEnumerable<Observation> lzzzzzzzzzzzzzze_ = context.Operators.Select<ServiceRequest, Observation>(lzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzd_);

            return lzzzzzzzzzzzzzze_;
        };
        IEnumerable<Observation> kzzzzzzzzzzzzzzz_ = context.Operators.SelectMany<Observation, Observation>(kzzzzzzzzzzzzzzx_, kzzzzzzzzzzzzzzy_);

        return kzzzzzzzzzzzzzzz_;
    }


    #endregion Expressions

}
