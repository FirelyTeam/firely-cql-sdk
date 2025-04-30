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
      new CqlCodeSystem("http://snomed.info/sct", null, [
          _Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_]);

    #endregion CodeSystems

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        CqlDateTime bzzzzzzzzzzzzzzzzzzn_ = context.Operators.DateTime(2025, 1, 1, 0, 0, 0, 0, 0.0m);
        CqlDateTime bzzzzzzzzzzzzzzzzzzo_ = context.Operators.DateTime(2025, 12, 31, 23, 59, 59, 999, 0.0m);
        CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzp_ = context.Operators.Interval(bzzzzzzzzzzzzzzzzzzn_, bzzzzzzzzzzzzzzzzzzo_, true, true);
        object bzzzzzzzzzzzzzzzzzzq_ = context.ResolveParameter("BoneDensityProstateCancerAndrogenDeprivationTherapyFHIR-1.4.000", "Measurement Period", bzzzzzzzzzzzzzzzzzzp_);

        return (CqlInterval<CqlDateTime>)bzzzzzzzzzzzzzzzzzzq_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> bzzzzzzzzzzzzzzzzzzr_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient bzzzzzzzzzzzzzzzzzzs_ = context.Operators.SingletonFrom<Patient>(bzzzzzzzzzzzzzzzzzzr_);

        return bzzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Has Qualifying Encounter")]
    public bool? Has_Qualifying_Encounter(CqlContext context)
    {
        CqlValueSet bzzzzzzzzzzzzzzzzzzt_ = this.Office_Visit(context);
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzu_ = context.Operators.Retrieve<Encounter>(new RetrieveParameters(default, bzzzzzzzzzzzzzzzzzzt_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-encounter"));
        bool? bzzzzzzzzzzzzzzzzzzv_(Encounter OfficeVisit)
        {
            CqlInterval<CqlDateTime> bzzzzzzzzzzzzzzzzzzy_ = this.Measurement_Period(context);
            Period bzzzzzzzzzzzzzzzzzzz_ = OfficeVisit?.Period;
            CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzza_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, bzzzzzzzzzzzzzzzzzzz_);
            bool? czzzzzzzzzzzzzzzzzzb_ = context.Operators.IntervalIncludesInterval<CqlDateTime>(bzzzzzzzzzzzzzzzzzzy_, czzzzzzzzzzzzzzzzzza_, default);
            Code<Encounter.EncounterStatus> czzzzzzzzzzzzzzzzzzc_ = OfficeVisit?.StatusElement;
            Encounter.EncounterStatus? czzzzzzzzzzzzzzzzzzd_ = czzzzzzzzzzzzzzzzzzc_?.Value;
            Code<Encounter.EncounterStatus> czzzzzzzzzzzzzzzzzze_ = context.Operators.Convert<Code<Encounter.EncounterStatus>>(czzzzzzzzzzzzzzzzzzd_);
            bool? czzzzzzzzzzzzzzzzzzf_ = context.Operators.Equal(czzzzzzzzzzzzzzzzzze_, "finished");
            bool? czzzzzzzzzzzzzzzzzzg_ = context.Operators.And(czzzzzzzzzzzzzzzzzzb_, czzzzzzzzzzzzzzzzzzf_);

            return czzzzzzzzzzzzzzzzzzg_;
        };
        IEnumerable<Encounter> bzzzzzzzzzzzzzzzzzzw_ = context.Operators.Where<Encounter>(bzzzzzzzzzzzzzzzzzzu_, bzzzzzzzzzzzzzzzzzzv_);
        bool? bzzzzzzzzzzzzzzzzzzx_ = context.Operators.Exists<Encounter>(bzzzzzzzzzzzzzzzzzzw_);

        return bzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("NormalizeInterval")]
    public CqlInterval<CqlDateTime> NormalizeInterval(CqlContext context, CqlDateTime pointInTime, CqlInterval<CqlDateTime> dateTimeInterval)
    {
        CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzh_()
        {
            if ((context.Operators.Not((bool?)(pointInTime is null))) ?? false)
            {
                CqlInterval<CqlDateTime> czzzzzzzzzzzzzzzzzzi_ = context.Operators.Interval(pointInTime, pointInTime, true, true);

                return czzzzzzzzzzzzzzzzzzi_;
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

        return czzzzzzzzzzzzzzzzzzh_();
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Active Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(CqlContext context)
    {
        CqlValueSet czzzzzzzzzzzzzzzzzzj_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzk_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzm_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, czzzzzzzzzzzzzzzzzzj_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzn_ = context.Operators.Union<MedicationRequest>(czzzzzzzzzzzzzzzzzzk_, czzzzzzzzzzzzzzzzzzm_);
        bool? czzzzzzzzzzzzzzzzzzo_(MedicationRequest ADTActive)
        {
            Code<MedicationRequest.MedicationrequestStatus> czzzzzzzzzzzzzzzzzzt_ = ADTActive?.StatusElement;
            MedicationRequest.MedicationrequestStatus? czzzzzzzzzzzzzzzzzzu_ = czzzzzzzzzzzzzzzzzzt_?.Value;
            string czzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzu_);
            string[] czzzzzzzzzzzzzzzzzzw_ = [
                "active",
                "completed",
            ];
            bool? czzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(czzzzzzzzzzzzzzzzzzv_, czzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> czzzzzzzzzzzzzzzzzzy_ = ADTActive?.IntentElement;
            MedicationRequest.MedicationRequestIntent? czzzzzzzzzzzzzzzzzzz_ = czzzzzzzzzzzzzzzzzzy_?.Value;
            string dzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(czzzzzzzzzzzzzzzzzzz_);
            string[] dzzzzzzzzzzzzzzzzzzb_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? dzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(dzzzzzzzzzzzzzzzzzza_, dzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);
            bool? dzzzzzzzzzzzzzzzzzzd_ = context.Operators.And(czzzzzzzzzzzzzzzzzzx_, dzzzzzzzzzzzzzzzzzzc_);

            return dzzzzzzzzzzzzzzzzzzd_;
        };
        IEnumerable<MedicationRequest> czzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<MedicationRequest>(czzzzzzzzzzzzzzzzzzn_, czzzzzzzzzzzzzzzzzzo_);
        CqlDateTime czzzzzzzzzzzzzzzzzzq_(MedicationRequest ADTActive)
        {
            List<Dosage> dzzzzzzzzzzzzzzzzzze_ = ADTActive?.DosageInstruction;
            bool? dzzzzzzzzzzzzzzzzzzf_(Dosage @this)
            {
                Timing ezzzzzzzzzzzzzzzzzzk_ = @this?.Timing;
                bool? ezzzzzzzzzzzzzzzzzzl_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzk_ is null));

                return ezzzzzzzzzzzzzzzzzzl_;
            };
            IEnumerable<Dosage> dzzzzzzzzzzzzzzzzzzg_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzf_);
            Timing dzzzzzzzzzzzzzzzzzzh_(Dosage @this)
            {
                Timing ezzzzzzzzzzzzzzzzzzm_ = @this?.Timing;

                return ezzzzzzzzzzzzzzzzzzm_;
            };
            IEnumerable<Timing> dzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Dosage, Timing>(dzzzzzzzzzzzzzzzzzzg_, dzzzzzzzzzzzzzzzzzzh_);
            CqlDateTime dzzzzzzzzzzzzzzzzzzj_(Timing dosageTiming)
            {
                List<FhirDateTime> ezzzzzzzzzzzzzzzzzzn_ = dosageTiming?.EventElement;
                IEnumerable<CqlDateTime> ezzzzzzzzzzzzzzzzzzo_ = context.Operators.LateBoundProperty<IEnumerable<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzn_, "value");
                IEnumerable<CqlDateTime> ezzzzzzzzzzzzzzzzzzp_ = context.Operators.ListSort<CqlDateTime>(ezzzzzzzzzzzzzzzzzzo_, System.ComponentModel.ListSortDirection.Ascending);
                CqlDateTime ezzzzzzzzzzzzzzzzzzq_ = context.Operators.First<CqlDateTime>(ezzzzzzzzzzzzzzzzzzp_);

                return ezzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<CqlDateTime> dzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<Timing, CqlDateTime>(dzzzzzzzzzzzzzzzzzzi_, dzzzzzzzzzzzzzzzzzzj_);
            IEnumerable<CqlDateTime> dzzzzzzzzzzzzzzzzzzl_ = context.Operators.Distinct<CqlDateTime>(dzzzzzzzzzzzzzzzzzzk_);
            IEnumerable<CqlDateTime> dzzzzzzzzzzzzzzzzzzm_ = context.Operators.ListSort<CqlDateTime>(dzzzzzzzzzzzzzzzzzzl_, System.ComponentModel.ListSortDirection.Ascending);
            CqlDateTime dzzzzzzzzzzzzzzzzzzn_ = context.Operators.First<CqlDateTime>(dzzzzzzzzzzzzzzzzzzm_);
            bool? dzzzzzzzzzzzzzzzzzzp_(Dosage @this)
            {
                Timing ezzzzzzzzzzzzzzzzzzr_ = @this?.Timing;
                bool? ezzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzr_ is null));

                return ezzzzzzzzzzzzzzzzzzs_;
            };
            IEnumerable<Dosage> dzzzzzzzzzzzzzzzzzzq_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)dzzzzzzzzzzzzzzzzzze_, dzzzzzzzzzzzzzzzzzzp_);
            Timing dzzzzzzzzzzzzzzzzzzr_(Dosage @this)
            {
                Timing ezzzzzzzzzzzzzzzzzzt_ = @this?.Timing;

                return ezzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<Timing> dzzzzzzzzzzzzzzzzzzs_ = context.Operators.Select<Dosage, Timing>(dzzzzzzzzzzzzzzzzzzq_, dzzzzzzzzzzzzzzzzzzr_);
            bool? dzzzzzzzzzzzzzzzzzzt_(Timing @this)
            {
                Timing.RepeatComponent ezzzzzzzzzzzzzzzzzzu_ = @this?.Repeat;
                bool? ezzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzu_ is null));

                return ezzzzzzzzzzzzzzzzzzv_;
            };
            IEnumerable<Timing> dzzzzzzzzzzzzzzzzzzu_ = context.Operators.Where<Timing>(dzzzzzzzzzzzzzzzzzzs_, dzzzzzzzzzzzzzzzzzzt_);
            Timing.RepeatComponent dzzzzzzzzzzzzzzzzzzv_(Timing @this)
            {
                Timing.RepeatComponent ezzzzzzzzzzzzzzzzzzw_ = @this?.Repeat;

                return ezzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<Timing.RepeatComponent> dzzzzzzzzzzzzzzzzzzw_ = context.Operators.Select<Timing, Timing.RepeatComponent>(dzzzzzzzzzzzzzzzzzzu_, dzzzzzzzzzzzzzzzzzzv_);
            bool? dzzzzzzzzzzzzzzzzzzx_(Timing.RepeatComponent @this)
            {
                DataType ezzzzzzzzzzzzzzzzzzx_ = @this?.Bounds;
                object ezzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToValue(context, ezzzzzzzzzzzzzzzzzzx_);
                bool? ezzzzzzzzzzzzzzzzzzz_ = context.Operators.Not((bool?)(ezzzzzzzzzzzzzzzzzzy_ is null));

                return ezzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Timing.RepeatComponent> dzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Timing.RepeatComponent>(dzzzzzzzzzzzzzzzzzzw_, dzzzzzzzzzzzzzzzzzzx_);
            object dzzzzzzzzzzzzzzzzzzz_(Timing.RepeatComponent @this)
            {
                DataType fzzzzzzzzzzzzzzzzzza_ = @this?.Bounds;
                object fzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToValue(context, fzzzzzzzzzzzzzzzzzza_);

                return fzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<object> ezzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Timing.RepeatComponent, object>(dzzzzzzzzzzzzzzzzzzy_, dzzzzzzzzzzzzzzzzzzz_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzb_(object DoseTime)
            {
                CqlInterval<CqlDateTime> fzzzzzzzzzzzzzzzzzzc_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return fzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzc_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzza_, ezzzzzzzzzzzzzzzzzzb_);
            IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzd_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzc_);
            IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzze_ = context.Operators.Collapse(ezzzzzzzzzzzzzzzzzzd_, default);
            object ezzzzzzzzzzzzzzzzzzf_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime fzzzzzzzzzzzzzzzzzzd_ = context.Operators.Start(@this);

                return fzzzzzzzzzzzzzzzzzzd_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> ezzzzzzzzzzzzzzzzzzg_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzze_, ezzzzzzzzzzzzzzzzzzf_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzh_ = context.Operators.First<CqlInterval<CqlDateTime>>(ezzzzzzzzzzzzzzzzzzg_);
            CqlInterval<CqlDateTime> ezzzzzzzzzzzzzzzzzzi_ = this.NormalizeInterval(context, dzzzzzzzzzzzzzzzzzzn_, ezzzzzzzzzzzzzzzzzzh_);
            CqlDateTime ezzzzzzzzzzzzzzzzzzj_ = QICoreCommon_2_1_000.Instance.earliest(context, ezzzzzzzzzzzzzzzzzzi_ as object);

            return ezzzzzzzzzzzzzzzzzzj_;
        };
        IEnumerable<CqlDateTime> czzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<MedicationRequest, CqlDateTime>(czzzzzzzzzzzzzzzzzzp_, czzzzzzzzzzzzzzzzzzq_);
        IEnumerable<CqlDateTime> czzzzzzzzzzzzzzzzzzs_ = context.Operators.Distinct<CqlDateTime>(czzzzzzzzzzzzzzzzzzr_);

        return czzzzzzzzzzzzzzzzzzs_;
    }


    [CqlExpressionDefinition("Androgen Deprivation Therapy for Urology Care Medication Order Start Dates")]
    public IEnumerable<CqlDateTime> Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(CqlContext context)
    {
        CqlValueSet fzzzzzzzzzzzzzzzzzze_ = this.Androgen_deprivation_therapy_for_Urology_Care(context);
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzf_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzh_ = context.Operators.Retrieve<MedicationRequest>(new RetrieveParameters(default, fzzzzzzzzzzzzzzzzzze_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-medicationrequest"));
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzi_ = context.Operators.Union<MedicationRequest>(fzzzzzzzzzzzzzzzzzzf_, fzzzzzzzzzzzzzzzzzzh_);
        bool? fzzzzzzzzzzzzzzzzzzj_(MedicationRequest ADTOrder)
        {
            Code<MedicationRequest.MedicationrequestStatus> fzzzzzzzzzzzzzzzzzzo_ = ADTOrder?.StatusElement;
            MedicationRequest.MedicationrequestStatus? fzzzzzzzzzzzzzzzzzzp_ = fzzzzzzzzzzzzzzzzzzo_?.Value;
            string fzzzzzzzzzzzzzzzzzzq_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzp_);
            string[] fzzzzzzzzzzzzzzzzzzr_ = [
                "active",
                "completed",
            ];
            bool? fzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzq_, fzzzzzzzzzzzzzzzzzzr_ as IEnumerable<string>);
            Code<MedicationRequest.MedicationRequestIntent> fzzzzzzzzzzzzzzzzzzt_ = ADTOrder?.IntentElement;
            MedicationRequest.MedicationRequestIntent? fzzzzzzzzzzzzzzzzzzu_ = fzzzzzzzzzzzzzzzzzzt_?.Value;
            string fzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<string>(fzzzzzzzzzzzzzzzzzzu_);
            string[] fzzzzzzzzzzzzzzzzzzw_ = [
                "order",
                "original-order",
                "reflex-order",
                "filler-order",
                "instance-order",
            ];
            bool? fzzzzzzzzzzzzzzzzzzx_ = context.Operators.In<string>(fzzzzzzzzzzzzzzzzzzv_, fzzzzzzzzzzzzzzzzzzw_ as IEnumerable<string>);
            bool? fzzzzzzzzzzzzzzzzzzy_ = context.Operators.And(fzzzzzzzzzzzzzzzzzzs_, fzzzzzzzzzzzzzzzzzzx_);

            return fzzzzzzzzzzzzzzzzzzy_;
        };
        IEnumerable<MedicationRequest> fzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<MedicationRequest>(fzzzzzzzzzzzzzzzzzzi_, fzzzzzzzzzzzzzzzzzzj_);
        CqlDateTime fzzzzzzzzzzzzzzzzzzl_(MedicationRequest ADTOrder)
        {
            FhirDateTime fzzzzzzzzzzzzzzzzzzz_ = ADTOrder?.AuthoredOnElement;
            CqlDateTime gzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<CqlDateTime>(fzzzzzzzzzzzzzzzzzzz_);
            List<Dosage> gzzzzzzzzzzzzzzzzzzb_ = ADTOrder?.DosageInstruction;
            bool? gzzzzzzzzzzzzzzzzzzc_(Dosage @this)
            {
                Timing gzzzzzzzzzzzzzzzzzzx_ = @this?.Timing;
                bool? gzzzzzzzzzzzzzzzzzzy_ = context.Operators.Not((bool?)(gzzzzzzzzzzzzzzzzzzx_ is null));

                return gzzzzzzzzzzzzzzzzzzy_;
            };
            IEnumerable<Dosage> gzzzzzzzzzzzzzzzzzzd_ = context.Operators.Where<Dosage>((IEnumerable<Dosage>)gzzzzzzzzzzzzzzzzzzb_, gzzzzzzzzzzzzzzzzzzc_);
            Timing gzzzzzzzzzzzzzzzzzze_(Dosage @this)
            {
                Timing gzzzzzzzzzzzzzzzzzzz_ = @this?.Timing;

                return gzzzzzzzzzzzzzzzzzzz_;
            };
            IEnumerable<Timing> gzzzzzzzzzzzzzzzzzzf_ = context.Operators.Select<Dosage, Timing>(gzzzzzzzzzzzzzzzzzzd_, gzzzzzzzzzzzzzzzzzze_);
            bool? gzzzzzzzzzzzzzzzzzzg_(Timing @this)
            {
                Timing.RepeatComponent hzzzzzzzzzzzzzzzzzza_ = @this?.Repeat;
                bool? hzzzzzzzzzzzzzzzzzzb_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzza_ is null));

                return hzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Timing> gzzzzzzzzzzzzzzzzzzh_ = context.Operators.Where<Timing>(gzzzzzzzzzzzzzzzzzzf_, gzzzzzzzzzzzzzzzzzzg_);
            Timing.RepeatComponent gzzzzzzzzzzzzzzzzzzi_(Timing @this)
            {
                Timing.RepeatComponent hzzzzzzzzzzzzzzzzzzc_ = @this?.Repeat;

                return hzzzzzzzzzzzzzzzzzzc_;
            };
            IEnumerable<Timing.RepeatComponent> gzzzzzzzzzzzzzzzzzzj_ = context.Operators.Select<Timing, Timing.RepeatComponent>(gzzzzzzzzzzzzzzzzzzh_, gzzzzzzzzzzzzzzzzzzi_);
            bool? gzzzzzzzzzzzzzzzzzzk_(Timing.RepeatComponent @this)
            {
                DataType hzzzzzzzzzzzzzzzzzzd_ = @this?.Bounds;
                object hzzzzzzzzzzzzzzzzzze_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzd_);
                bool? hzzzzzzzzzzzzzzzzzzf_ = context.Operators.Not((bool?)(hzzzzzzzzzzzzzzzzzze_ is null));

                return hzzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<Timing.RepeatComponent> gzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Timing.RepeatComponent>(gzzzzzzzzzzzzzzzzzzj_, gzzzzzzzzzzzzzzzzzzk_);
            object gzzzzzzzzzzzzzzzzzzm_(Timing.RepeatComponent @this)
            {
                DataType hzzzzzzzzzzzzzzzzzzg_ = @this?.Bounds;
                object hzzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, hzzzzzzzzzzzzzzzzzzg_);

                return hzzzzzzzzzzzzzzzzzzh_;
            };
            IEnumerable<object> gzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Timing.RepeatComponent, object>(gzzzzzzzzzzzzzzzzzzl_, gzzzzzzzzzzzzzzzzzzm_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzo_(object DoseTime)
            {
                CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, DoseTime);

                return hzzzzzzzzzzzzzzzzzzi_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<object, CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzn_, gzzzzzzzzzzzzzzzzzzo_);
            IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzq_ = context.Operators.Distinct<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzp_);
            IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzr_ = context.Operators.Collapse(gzzzzzzzzzzzzzzzzzzq_, default);
            object gzzzzzzzzzzzzzzzzzzs_(CqlInterval<CqlDateTime> @this)
            {
                CqlDateTime hzzzzzzzzzzzzzzzzzzj_ = context.Operators.Start(@this);

                return hzzzzzzzzzzzzzzzzzzj_;
            };
            IEnumerable<CqlInterval<CqlDateTime>> gzzzzzzzzzzzzzzzzzzt_ = context.Operators.SortBy<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzr_, gzzzzzzzzzzzzzzzzzzs_, System.ComponentModel.ListSortDirection.Ascending);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzu_ = context.Operators.First<CqlInterval<CqlDateTime>>(gzzzzzzzzzzzzzzzzzzt_);
            CqlInterval<CqlDateTime> gzzzzzzzzzzzzzzzzzzv_ = this.NormalizeInterval(context, gzzzzzzzzzzzzzzzzzza_, gzzzzzzzzzzzzzzzzzzu_);
            CqlDateTime gzzzzzzzzzzzzzzzzzzw_ = QICoreCommon_2_1_000.Instance.earliest(context, gzzzzzzzzzzzzzzzzzzv_ as object);

            return gzzzzzzzzzzzzzzzzzzw_;
        };
        IEnumerable<CqlDateTime> fzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<MedicationRequest, CqlDateTime>(fzzzzzzzzzzzzzzzzzzk_, fzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<CqlDateTime> fzzzzzzzzzzzzzzzzzzn_ = context.Operators.Distinct<CqlDateTime>(fzzzzzzzzzzzzzzzzzzm_);

        return fzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("Prostate Cancer Diagnosis")]
    public IEnumerable<Condition> Prostate_Cancer_Diagnosis(CqlContext context)
    {
        CqlValueSet hzzzzzzzzzzzzzzzzzzk_ = this.Prostate_Cancer(context);
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<Condition>(new RetrieveParameters(default, hzzzzzzzzzzzzzzzzzzk_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-condition"));
        bool? hzzzzzzzzzzzzzzzzzzm_(Condition ProstateCancer)
        {
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
            CqlInterval<CqlDateTime> hzzzzzzzzzzzzzzzzzzp_ = this.Measurement_Period(context);
            bool? hzzzzzzzzzzzzzzzzzzq_ = context.Operators.Overlaps(hzzzzzzzzzzzzzzzzzzo_, hzzzzzzzzzzzzzzzzzzp_, default);
            CodeableConcept hzzzzzzzzzzzzzzzzzzr_ = ProstateCancer?.ClinicalStatus;
            CqlConcept hzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzr_);
            CqlCode hzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.active(context);
            CqlConcept hzzzzzzzzzzzzzzzzzzu_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzzt_);
            bool? hzzzzzzzzzzzzzzzzzzv_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzzzzzs_, hzzzzzzzzzzzzzzzzzzu_);
            bool? hzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzq_, hzzzzzzzzzzzzzzzzzzv_);
            CodeableConcept hzzzzzzzzzzzzzzzzzzx_ = ProstateCancer?.VerificationStatus;
            CqlConcept hzzzzzzzzzzzzzzzzzzy_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, hzzzzzzzzzzzzzzzzzzx_);
            CqlCode hzzzzzzzzzzzzzzzzzzz_ = QICoreCommon_2_1_000.Instance.confirmed(context);
            CqlConcept izzzzzzzzzzzzzzzzzza_ = context.Operators.ConvertCodeToConcept(hzzzzzzzzzzzzzzzzzzz_);
            bool? izzzzzzzzzzzzzzzzzzb_ = context.Operators.Equivalent(hzzzzzzzzzzzzzzzzzzy_, izzzzzzzzzzzzzzzzzza_);
            bool? izzzzzzzzzzzzzzzzzzc_ = context.Operators.And(hzzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzb_);

            return izzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Condition> hzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<Condition>(hzzzzzzzzzzzzzzzzzzl_, hzzzzzzzzzzzzzzzzzzm_);

        return hzzzzzzzzzzzzzzzzzzn_;
    }


    [CqlExpressionDefinition("First ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public CqlDateTime First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context)
    {
        IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzzzzd_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Active_Start_Dates(context);
        IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzzzze_ = this.Androgen_Deprivation_Therapy_for_Urology_Care_Medication_Order_Start_Dates(context);
        IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzzzzf_ = context.Operators.Union<CqlDateTime>(izzzzzzzzzzzzzzzzzzd_, izzzzzzzzzzzzzzzzzze_);
        IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzzzzg_(CqlDateTime ADTDateTime)
        {
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzk_ = this.Prostate_Cancer_Diagnosis(context);
            bool? izzzzzzzzzzzzzzzzzzl_(Condition ProstateCancer)
            {
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzp_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, ProstateCancer);
                bool? izzzzzzzzzzzzzzzzzzq_ = context.Operators.In<CqlDateTime>(ADTDateTime, izzzzzzzzzzzzzzzzzzp_, "day");
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzr_ = this.Measurement_Period(context);
                CqlDateTime izzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzr_);
                CqlQuantity izzzzzzzzzzzzzzzzzzt_ = context.Operators.Quantity(3m, "months");
                CqlDateTime izzzzzzzzzzzzzzzzzzu_ = context.Operators.Subtract(izzzzzzzzzzzzzzzzzzs_, izzzzzzzzzzzzzzzzzzt_);
                CqlDateTime izzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(izzzzzzzzzzzzzzzzzzr_);
                CqlQuantity izzzzzzzzzzzzzzzzzzx_ = context.Operators.Quantity(9m, "months");
                CqlDateTime izzzzzzzzzzzzzzzzzzy_ = context.Operators.Add(izzzzzzzzzzzzzzzzzzw_, izzzzzzzzzzzzzzzzzzx_);
                CqlInterval<CqlDateTime> izzzzzzzzzzzzzzzzzzz_ = context.Operators.Interval(izzzzzzzzzzzzzzzzzzu_, izzzzzzzzzzzzzzzzzzy_, true, true);
                bool? jzzzzzzzzzzzzzzzzzza_ = context.Operators.In<CqlDateTime>(ADTDateTime, izzzzzzzzzzzzzzzzzzz_, "day");
                bool? jzzzzzzzzzzzzzzzzzzb_ = context.Operators.And(izzzzzzzzzzzzzzzzzzq_, jzzzzzzzzzzzzzzzzzza_);

                return jzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<Condition> izzzzzzzzzzzzzzzzzzm_ = context.Operators.Where<Condition>(izzzzzzzzzzzzzzzzzzk_, izzzzzzzzzzzzzzzzzzl_);
            CqlDateTime izzzzzzzzzzzzzzzzzzn_(Condition ProstateCancer) =>
                ADTDateTime;
            IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzzzzo_ = context.Operators.Select<Condition, CqlDateTime>(izzzzzzzzzzzzzzzzzzm_, izzzzzzzzzzzzzzzzzzn_);

            return izzzzzzzzzzzzzzzzzzo_;
        };
        IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzzzzh_ = context.Operators.SelectMany<CqlDateTime, CqlDateTime>(izzzzzzzzzzzzzzzzzzf_, izzzzzzzzzzzzzzzzzzg_);
        IEnumerable<CqlDateTime> izzzzzzzzzzzzzzzzzzi_ = context.Operators.ListSort<CqlDateTime>(izzzzzzzzzzzzzzzzzzh_, System.ComponentModel.ListSortDirection.Ascending);
        CqlDateTime izzzzzzzzzzzzzzzzzzj_ = context.Operators.First<CqlDateTime>(izzzzzzzzzzzzzzzzzzi_);

        return izzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Order for 12 Months of ADT in 3 Months Before to 9 Months After Start of Measurement Period")]
    public IEnumerable<ServiceRequest> Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(CqlContext context)
    {
        CqlCode jzzzzzzzzzzzzzzzzzzc_ = this.Injection_of_leuprolide_acetate_for_twelve_month_period__regime_therapy_(context);
        IEnumerable<CqlCode> jzzzzzzzzzzzzzzzzzzd_ = context.Operators.ToList<CqlCode>(jzzzzzzzzzzzzzzzzzzc_);
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzze_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, default, jzzzzzzzzzzzzzzzzzzd_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzf_(ServiceRequest OrderTwelveMonthADT)
        {
            CqlDateTime jzzzzzzzzzzzzzzzzzzh_ = this.First_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            CqlDateTime[] jzzzzzzzzzzzzzzzzzzi_ = [
                jzzzzzzzzzzzzzzzzzzh_,
            ];
            bool? jzzzzzzzzzzzzzzzzzzj_(CqlDateTime FirstADTMP)
            {
                FhirDateTime jzzzzzzzzzzzzzzzzzzn_ = OrderTwelveMonthADT?.AuthoredOnElement;
                CqlDateTime jzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzn_);
                bool? jzzzzzzzzzzzzzzzzzzp_ = context.Operators.SameOrAfter(jzzzzzzzzzzzzzzzzzzo_, FirstADTMP, "day");
                CqlDateTime jzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(jzzzzzzzzzzzzzzzzzzn_);
                CqlInterval<CqlDateTime> jzzzzzzzzzzzzzzzzzzs_ = this.Measurement_Period(context);
                CqlDateTime jzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzu_ = context.Operators.Quantity(3m, "months");
                CqlDateTime jzzzzzzzzzzzzzzzzzzv_ = context.Operators.Subtract(jzzzzzzzzzzzzzzzzzzt_, jzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime jzzzzzzzzzzzzzzzzzzx_ = context.Operators.Start(jzzzzzzzzzzzzzzzzzzs_);
                CqlQuantity jzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(9m, "months");
                CqlDateTime jzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(jzzzzzzzzzzzzzzzzzzx_, jzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> kzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(jzzzzzzzzzzzzzzzzzzv_, jzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? kzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(jzzzzzzzzzzzzzzzzzzr_, kzzzzzzzzzzzzzzzzzza_, "day");
                bool? kzzzzzzzzzzzzzzzzzzc_ = context.Operators.And(jzzzzzzzzzzzzzzzzzzp_, kzzzzzzzzzzzzzzzzzzb_);
                Code<RequestStatus> kzzzzzzzzzzzzzzzzzzd_ = OrderTwelveMonthADT?.StatusElement;
                RequestStatus? kzzzzzzzzzzzzzzzzzze_ = kzzzzzzzzzzzzzzzzzzd_?.Value;
                Code<RequestStatus> kzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<Code<RequestStatus>>(kzzzzzzzzzzzzzzzzzze_);
                string kzzzzzzzzzzzzzzzzzzg_ = context.Operators.Convert<string>(kzzzzzzzzzzzzzzzzzzf_);
                string[] kzzzzzzzzzzzzzzzzzzh_ = [
                    "active",
                    "completed",
                ];
                bool? kzzzzzzzzzzzzzzzzzzi_ = context.Operators.In<string>(kzzzzzzzzzzzzzzzzzzg_, kzzzzzzzzzzzzzzzzzzh_ as IEnumerable<string>);
                bool? kzzzzzzzzzzzzzzzzzzj_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzc_, kzzzzzzzzzzzzzzzzzzi_);
                Code<RequestIntent> kzzzzzzzzzzzzzzzzzzk_ = OrderTwelveMonthADT?.IntentElement;
                RequestIntent? kzzzzzzzzzzzzzzzzzzl_ = kzzzzzzzzzzzzzzzzzzk_?.Value;
                Code<RequestIntent> kzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<Code<RequestIntent>>(kzzzzzzzzzzzzzzzzzzl_);
                bool? kzzzzzzzzzzzzzzzzzzn_ = context.Operators.Equal(kzzzzzzzzzzzzzzzzzzm_, "order");
                bool? kzzzzzzzzzzzzzzzzzzo_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzj_, kzzzzzzzzzzzzzzzzzzn_);
                FhirBoolean kzzzzzzzzzzzzzzzzzzp_ = OrderTwelveMonthADT?.DoNotPerformElement;
                bool? kzzzzzzzzzzzzzzzzzzq_ = kzzzzzzzzzzzzzzzzzzp_?.Value;
                bool? kzzzzzzzzzzzzzzzzzzr_ = context.Operators.IsTrue(kzzzzzzzzzzzzzzzzzzq_);
                bool? kzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not(kzzzzzzzzzzzzzzzzzzr_);
                bool? kzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzo_, kzzzzzzzzzzzzzzzzzzs_);

                return kzzzzzzzzzzzzzzzzzzt_;
            };
            IEnumerable<CqlDateTime> jzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<CqlDateTime>((IEnumerable<CqlDateTime>)jzzzzzzzzzzzzzzzzzzi_, jzzzzzzzzzzzzzzzzzzj_);
            ServiceRequest jzzzzzzzzzzzzzzzzzzl_(CqlDateTime FirstADTMP) =>
                OrderTwelveMonthADT;
            IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzm_ = context.Operators.Select<CqlDateTime, ServiceRequest>(jzzzzzzzzzzzzzzzzzzk_, jzzzzzzzzzzzzzzzzzzl_);

            return jzzzzzzzzzzzzzzzzzzm_;
        };
        IEnumerable<ServiceRequest> jzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(jzzzzzzzzzzzzzzzzzze_, jzzzzzzzzzzzzzzzzzzf_);

        return jzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("Initial Population")]
    public bool? Initial_Population(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzu_ = this.Has_Qualifying_Encounter(context);
        IEnumerable<ServiceRequest> kzzzzzzzzzzzzzzzzzzv_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
        bool? kzzzzzzzzzzzzzzzzzzw_ = context.Operators.Exists<ServiceRequest>(kzzzzzzzzzzzzzzzzzzv_);
        bool? kzzzzzzzzzzzzzzzzzzx_ = context.Operators.And(kzzzzzzzzzzzzzzzzzzu_, kzzzzzzzzzzzzzzzzzzw_);

        return kzzzzzzzzzzzzzzzzzzx_;
    }


    [CqlExpressionDefinition("Denominator")]
    public bool? Denominator(CqlContext context)
    {
        bool? kzzzzzzzzzzzzzzzzzzy_ = this.Initial_Population(context);

        return kzzzzzzzzzzzzzzzzzzy_;
    }


    [CqlExpressionDefinition("Has Baseline DEXA Scan Two Years Prior to the Start of or Less than Three Months After the Start of ADT")]
    public bool? Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(CqlContext context)
    {
        CqlValueSet kzzzzzzzzzzzzzzzzzzz_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzza_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicerequest"));
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzb_(ServiceRequest DEXAOrdered)
        {
            IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzn_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? lzzzzzzzzzzzzzzzzzzo_(ServiceRequest OrderTwelveMonthsADT)
            {
                FhirDateTime lzzzzzzzzzzzzzzzzzzs_ = DEXAOrdered?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzs_);
                FhirDateTime lzzzzzzzzzzzzzzzzzzu_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime lzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime lzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity lzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(3m, "months");
                CqlDateTime lzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(lzzzzzzzzzzzzzzzzzzx_, lzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(lzzzzzzzzzzzzzzzzzzv_, lzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? mzzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(lzzzzzzzzzzzzzzzzzzt_, mzzzzzzzzzzzzzzzzzza_, "day");
                CqlDateTime mzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzu_);
                bool? mzzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzd_ is null));
                bool? mzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzb_, mzzzzzzzzzzzzzzzzzze_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzs_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzj_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity mzzzzzzzzzzzzzzzzzzk_ = context.Operators.Quantity(2m, "years");
                CqlDateTime mzzzzzzzzzzzzzzzzzzl_ = context.Operators.Subtract(mzzzzzzzzzzzzzzzzzzj_, mzzzzzzzzzzzzzzzzzzk_);
                CqlDateTime mzzzzzzzzzzzzzzzzzzn_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> mzzzzzzzzzzzzzzzzzzo_ = context.Operators.Interval(mzzzzzzzzzzzzzzzzzzl_, mzzzzzzzzzzzzzzzzzzn_, true, false);
                bool? mzzzzzzzzzzzzzzzzzzp_ = context.Operators.In<CqlDateTime>(mzzzzzzzzzzzzzzzzzzh_, mzzzzzzzzzzzzzzzzzzo_, "day");
                CqlDateTime mzzzzzzzzzzzzzzzzzzr_ = context.Operators.Convert<CqlDateTime>(lzzzzzzzzzzzzzzzzzzu_);
                bool? mzzzzzzzzzzzzzzzzzzs_ = context.Operators.Not((bool?)(mzzzzzzzzzzzzzzzzzzr_ is null));
                bool? mzzzzzzzzzzzzzzzzzzt_ = context.Operators.And(mzzzzzzzzzzzzzzzzzzp_, mzzzzzzzzzzzzzzzzzzs_);
                bool? mzzzzzzzzzzzzzzzzzzu_ = context.Operators.Or(mzzzzzzzzzzzzzzzzzzf_, mzzzzzzzzzzzzzzzzzzt_);

                return mzzzzzzzzzzzzzzzzzzu_;
            };
            IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzp_ = context.Operators.Where<ServiceRequest>(lzzzzzzzzzzzzzzzzzzn_, lzzzzzzzzzzzzzzzzzzo_);
            ServiceRequest lzzzzzzzzzzzzzzzzzzq_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXAOrdered;
            IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzr_ = context.Operators.Select<ServiceRequest, ServiceRequest>(lzzzzzzzzzzzzzzzzzzp_, lzzzzzzzzzzzzzzzzzzq_);

            return lzzzzzzzzzzzzzzzzzzr_;
        };
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(lzzzzzzzzzzzzzzzzzza_, lzzzzzzzzzzzzzzzzzzb_);
        bool? lzzzzzzzzzzzzzzzzzzd_(ServiceRequest DEXAOrdered)
        {
            Code<RequestStatus> mzzzzzzzzzzzzzzzzzzv_ = DEXAOrdered?.StatusElement;
            RequestStatus? mzzzzzzzzzzzzzzzzzzw_ = mzzzzzzzzzzzzzzzzzzv_?.Value;
            Code<RequestStatus> mzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<Code<RequestStatus>>(mzzzzzzzzzzzzzzzzzzw_);
            string mzzzzzzzzzzzzzzzzzzy_ = context.Operators.Convert<string>(mzzzzzzzzzzzzzzzzzzx_);
            string[] mzzzzzzzzzzzzzzzzzzz_ = [
                "active",
                "completed",
            ];
            bool? nzzzzzzzzzzzzzzzzzza_ = context.Operators.In<string>(mzzzzzzzzzzzzzzzzzzy_, mzzzzzzzzzzzzzzzzzzz_ as IEnumerable<string>);
            Code<RequestIntent> nzzzzzzzzzzzzzzzzzzb_ = DEXAOrdered?.IntentElement;
            RequestIntent? nzzzzzzzzzzzzzzzzzzc_ = nzzzzzzzzzzzzzzzzzzb_?.Value;
            Code<RequestIntent> nzzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<Code<RequestIntent>>(nzzzzzzzzzzzzzzzzzzc_);
            bool? nzzzzzzzzzzzzzzzzzze_ = context.Operators.Equal(nzzzzzzzzzzzzzzzzzzd_, "order");
            bool? nzzzzzzzzzzzzzzzzzzf_ = context.Operators.And(nzzzzzzzzzzzzzzzzzza_, nzzzzzzzzzzzzzzzzzze_);
            FhirBoolean nzzzzzzzzzzzzzzzzzzg_ = DEXAOrdered?.DoNotPerformElement;
            bool? nzzzzzzzzzzzzzzzzzzh_ = nzzzzzzzzzzzzzzzzzzg_?.Value;
            bool? nzzzzzzzzzzzzzzzzzzi_ = context.Operators.IsTrue(nzzzzzzzzzzzzzzzzzzh_);
            bool? nzzzzzzzzzzzzzzzzzzj_ = context.Operators.Not(nzzzzzzzzzzzzzzzzzzi_);
            bool? nzzzzzzzzzzzzzzzzzzk_ = context.Operators.And(nzzzzzzzzzzzzzzzzzzf_, nzzzzzzzzzzzzzzzzzzj_);

            return nzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<ServiceRequest> lzzzzzzzzzzzzzzzzzze_ = context.Operators.Where<ServiceRequest>(lzzzzzzzzzzzzzzzzzzc_, lzzzzzzzzzzzzzzzzzzd_);
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzg_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, kzzzzzzzzzzzzzzzzzzz_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observation"));
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzh_(Observation DEXAPerformed)
        {
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzl_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? nzzzzzzzzzzzzzzzzzzm_(ServiceRequest OrderTwelveMonthsADT)
            {
                DataType nzzzzzzzzzzzzzzzzzzq_ = DEXAPerformed?.Effective;
                object nzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> nzzzzzzzzzzzzzzzzzzs_ = QICoreCommon_2_1_000.Instance.toInterval(context, nzzzzzzzzzzzzzzzzzzr_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzt_ = context.Operators.Start(nzzzzzzzzzzzzzzzzzzs_);
                FhirDateTime nzzzzzzzzzzzzzzzzzzu_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime nzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzu_);
                CqlDateTime nzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity nzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(3m, "months");
                CqlDateTime nzzzzzzzzzzzzzzzzzzz_ = context.Operators.Add(nzzzzzzzzzzzzzzzzzzx_, nzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(nzzzzzzzzzzzzzzzzzzv_, nzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? ozzzzzzzzzzzzzzzzzzb_ = context.Operators.In<CqlDateTime>(nzzzzzzzzzzzzzzzzzzt_, ozzzzzzzzzzzzzzzzzza_, "day");
                CqlDateTime ozzzzzzzzzzzzzzzzzzd_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzu_);
                bool? ozzzzzzzzzzzzzzzzzze_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzd_ is null));
                bool? ozzzzzzzzzzzzzzzzzzf_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzb_, ozzzzzzzzzzzzzzzzzze_);
                object ozzzzzzzzzzzzzzzzzzh_ = FHIRHelpers_4_4_000.Instance.ToValue(context, nzzzzzzzzzzzzzzzzzzq_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzi_ = QICoreCommon_2_1_000.Instance.toInterval(context, ozzzzzzzzzzzzzzzzzzh_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzj_ = context.Operators.End(ozzzzzzzzzzzzzzzzzzi_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzl_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity ozzzzzzzzzzzzzzzzzzm_ = context.Operators.Quantity(2m, "years");
                CqlDateTime ozzzzzzzzzzzzzzzzzzn_ = context.Operators.Subtract(ozzzzzzzzzzzzzzzzzzl_, ozzzzzzzzzzzzzzzzzzm_);
                CqlDateTime ozzzzzzzzzzzzzzzzzzp_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzu_);
                CqlInterval<CqlDateTime> ozzzzzzzzzzzzzzzzzzq_ = context.Operators.Interval(ozzzzzzzzzzzzzzzzzzn_, ozzzzzzzzzzzzzzzzzzp_, true, false);
                bool? ozzzzzzzzzzzzzzzzzzr_ = context.Operators.In<CqlDateTime>(ozzzzzzzzzzzzzzzzzzj_, ozzzzzzzzzzzzzzzzzzq_, "day");
                CqlDateTime ozzzzzzzzzzzzzzzzzzt_ = context.Operators.Convert<CqlDateTime>(nzzzzzzzzzzzzzzzzzzu_);
                bool? ozzzzzzzzzzzzzzzzzzu_ = context.Operators.Not((bool?)(ozzzzzzzzzzzzzzzzzzt_ is null));
                bool? ozzzzzzzzzzzzzzzzzzv_ = context.Operators.And(ozzzzzzzzzzzzzzzzzzr_, ozzzzzzzzzzzzzzzzzzu_);
                bool? ozzzzzzzzzzzzzzzzzzw_ = context.Operators.Or(ozzzzzzzzzzzzzzzzzzf_, ozzzzzzzzzzzzzzzzzzv_);

                return ozzzzzzzzzzzzzzzzzzw_;
            };
            IEnumerable<ServiceRequest> nzzzzzzzzzzzzzzzzzzn_ = context.Operators.Where<ServiceRequest>(nzzzzzzzzzzzzzzzzzzl_, nzzzzzzzzzzzzzzzzzzm_);
            Observation nzzzzzzzzzzzzzzzzzzo_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXAPerformed;
            IEnumerable<Observation> nzzzzzzzzzzzzzzzzzzp_ = context.Operators.Select<ServiceRequest, Observation>(nzzzzzzzzzzzzzzzzzzn_, nzzzzzzzzzzzzzzzzzzo_);

            return nzzzzzzzzzzzzzzzzzzp_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzi_ = context.Operators.SelectMany<Observation, Observation>(lzzzzzzzzzzzzzzzzzzg_, lzzzzzzzzzzzzzzzzzzh_);
        bool? lzzzzzzzzzzzzzzzzzzj_(Observation DEXAPerformed)
        {
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzx_ = DEXAPerformed?.StatusElement;
            ObservationStatus? ozzzzzzzzzzzzzzzzzzy_ = ozzzzzzzzzzzzzzzzzzx_?.Value;
            Code<ObservationStatus> ozzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<Code<ObservationStatus>>(ozzzzzzzzzzzzzzzzzzy_);
            string pzzzzzzzzzzzzzzzzzza_ = context.Operators.Convert<string>(ozzzzzzzzzzzzzzzzzzz_);
            string[] pzzzzzzzzzzzzzzzzzzb_ = [
                "final",
                "amended",
                "corrected",
            ];
            bool? pzzzzzzzzzzzzzzzzzzc_ = context.Operators.In<string>(pzzzzzzzzzzzzzzzzzza_, pzzzzzzzzzzzzzzzzzzb_ as IEnumerable<string>);

            return pzzzzzzzzzzzzzzzzzzc_;
        };
        IEnumerable<Observation> lzzzzzzzzzzzzzzzzzzk_ = context.Operators.Where<Observation>(lzzzzzzzzzzzzzzzzzzi_, lzzzzzzzzzzzzzzzzzzj_);
        IEnumerable<object> lzzzzzzzzzzzzzzzzzzl_ = context.Operators.Union<object>(lzzzzzzzzzzzzzzzzzze_ as IEnumerable<object>, lzzzzzzzzzzzzzzzzzzk_ as IEnumerable<object>);
        bool? lzzzzzzzzzzzzzzzzzzm_ = context.Operators.Exists<object>(lzzzzzzzzzzzzzzzzzzl_);

        return lzzzzzzzzzzzzzzzzzzm_;
    }


    [CqlExpressionDefinition("Numerator")]
    public bool? Numerator(CqlContext context)
    {
        bool? pzzzzzzzzzzzzzzzzzzd_ = this.Has_Baseline_DEXA_Scan_Two_Years_Prior_to_the_Start_of_or_Less_than_Three_Months_After_the_Start_of_ADT(context);

        return pzzzzzzzzzzzzzzzzzzd_;
    }


    [CqlExpressionDefinition("Denominator Exception")]
    [CqlTag("commentedOut", "\"No Bone Density Scan Ordered Due to Patient Refusal\" ) ")]
    [CqlTag("commmentedOutReason", "Negation issue related to https://github.com/cqframework/cql-execution/issues/296, which is tied to https://oncprojectracking.healthit.gov/support/browse/BONNIEMAT-1455. Due to this being the only logic in population, created a 'false' placeholder")]
    public bool? Denominator_Exception(CqlContext context) =>
        false;


    [CqlExpressionDefinition("SDE Ethnicity")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Ethnicity(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzze_ = SupplementalDataElements_3_5_000.Instance.SDE_Ethnicity(context);

        return pzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("SDE Payer")]
    public IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> SDE_Payer(CqlContext context)
    {
        IEnumerable<(CqlTupleMetadata, CqlConcept code, CqlInterval<CqlDateTime> period)?> pzzzzzzzzzzzzzzzzzzf_ = SupplementalDataElements_3_5_000.Instance.SDE_Payer(context);

        return pzzzzzzzzzzzzzzzzzzf_;
    }


    [CqlExpressionDefinition("SDE Race")]
    public (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? SDE_Race(CqlContext context)
    {
        (CqlTupleMetadata, IEnumerable<CqlCode> codes, string display)? pzzzzzzzzzzzzzzzzzzg_ = SupplementalDataElements_3_5_000.Instance.SDE_Race(context);

        return pzzzzzzzzzzzzzzzzzzg_;
    }


    [CqlExpressionDefinition("SDE Sex")]
    public CqlCode SDE_Sex(CqlContext context)
    {
        CqlCode pzzzzzzzzzzzzzzzzzzh_ = SupplementalDataElements_3_5_000.Instance.SDE_Sex(context);

        return pzzzzzzzzzzzzzzzzzzh_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Ordered Due to Patient Refusal")]
    public IEnumerable<ServiceRequest> No_Bone_Density_Scan_Ordered_Due_to_Patient_Refusal(CqlContext context)
    {
        CqlValueSet pzzzzzzzzzzzzzzzzzzi_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzj_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzl_ = context.Operators.Retrieve<ServiceRequest>(new RetrieveParameters(default, pzzzzzzzzzzzzzzzzzzi_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-servicenotrequested"));
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzm_ = context.Operators.Union<ServiceRequest>(pzzzzzzzzzzzzzzzzzzj_, pzzzzzzzzzzzzzzzzzzl_);
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzn_(ServiceRequest DEXANotOrdered)
        {
            IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzp_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? pzzzzzzzzzzzzzzzzzzq_(ServiceRequest OrderTwelveMonthsADT)
            {
                FhirDateTime pzzzzzzzzzzzzzzzzzzu_ = DEXANotOrdered?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzv_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzu_);
                FhirDateTime pzzzzzzzzzzzzzzzzzzw_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime pzzzzzzzzzzzzzzzzzzx_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzw_);
                CqlDateTime pzzzzzzzzzzzzzzzzzzz_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity qzzzzzzzzzzzzzzzzzza_ = context.Operators.Quantity(3m, "months");
                CqlDateTime qzzzzzzzzzzzzzzzzzzb_ = context.Operators.Add(pzzzzzzzzzzzzzzzzzzz_, qzzzzzzzzzzzzzzzzzza_);
                CqlInterval<CqlDateTime> qzzzzzzzzzzzzzzzzzzc_ = context.Operators.Interval(pzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzb_, true, true);
                bool? qzzzzzzzzzzzzzzzzzzd_ = context.Operators.In<CqlDateTime>(pzzzzzzzzzzzzzzzzzzv_, qzzzzzzzzzzzzzzzzzzc_, "day");
                CqlDateTime qzzzzzzzzzzzzzzzzzzf_ = context.Operators.Convert<CqlDateTime>(pzzzzzzzzzzzzzzzzzzw_);
                bool? qzzzzzzzzzzzzzzzzzzg_ = context.Operators.Not((bool?)(qzzzzzzzzzzzzzzzzzzf_ is null));
                bool? qzzzzzzzzzzzzzzzzzzh_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzd_, qzzzzzzzzzzzzzzzzzzg_);
                bool? qzzzzzzzzzzzzzzzzzzi_(Extension @this)
                {
                    string qzzzzzzzzzzzzzzzzzzr_ = @this?.Url;
                    FhirString qzzzzzzzzzzzzzzzzzzs_ = context.Operators.Convert<FhirString>(qzzzzzzzzzzzzzzzzzzr_);
                    string qzzzzzzzzzzzzzzzzzzt_ = FHIRHelpers_4_4_000.Instance.ToString(context, qzzzzzzzzzzzzzzzzzzs_);
                    bool? qzzzzzzzzzzzzzzzzzzu_ = context.Operators.Equal(qzzzzzzzzzzzzzzzzzzt_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-doNotPerformReason");

                    return qzzzzzzzzzzzzzzzzzzu_;
                };
                IEnumerable<Extension> qzzzzzzzzzzzzzzzzzzj_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotOrdered is DomainResource
                        ? (DEXANotOrdered as DomainResource).Extension
                        : default), qzzzzzzzzzzzzzzzzzzi_);
                object qzzzzzzzzzzzzzzzzzzk_(Extension @this)
                {
                    DataType qzzzzzzzzzzzzzzzzzzv_ = @this?.Value;

                    return qzzzzzzzzzzzzzzzzzzv_;
                };
                IEnumerable<object> qzzzzzzzzzzzzzzzzzzl_ = context.Operators.Select<Extension, object>(qzzzzzzzzzzzzzzzzzzj_, qzzzzzzzzzzzzzzzzzzk_);
                object qzzzzzzzzzzzzzzzzzzm_ = context.Operators.SingletonFrom<object>(qzzzzzzzzzzzzzzzzzzl_);
                CqlConcept qzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, qzzzzzzzzzzzzzzzzzzm_ as CodeableConcept);
                CqlValueSet qzzzzzzzzzzzzzzzzzzo_ = this.Patient_Declined(context);
                bool? qzzzzzzzzzzzzzzzzzzp_ = context.Operators.ConceptInValueSet(qzzzzzzzzzzzzzzzzzzn_, qzzzzzzzzzzzzzzzzzzo_);
                bool? qzzzzzzzzzzzzzzzzzzq_ = context.Operators.And(qzzzzzzzzzzzzzzzzzzh_, qzzzzzzzzzzzzzzzzzzp_);

                return qzzzzzzzzzzzzzzzzzzq_;
            };
            IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzr_ = context.Operators.Where<ServiceRequest>(pzzzzzzzzzzzzzzzzzzp_, pzzzzzzzzzzzzzzzzzzq_);
            ServiceRequest pzzzzzzzzzzzzzzzzzzs_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXANotOrdered;
            IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzt_ = context.Operators.Select<ServiceRequest, ServiceRequest>(pzzzzzzzzzzzzzzzzzzr_, pzzzzzzzzzzzzzzzzzzs_);

            return pzzzzzzzzzzzzzzzzzzt_;
        };
        IEnumerable<ServiceRequest> pzzzzzzzzzzzzzzzzzzo_ = context.Operators.SelectMany<ServiceRequest, ServiceRequest>(pzzzzzzzzzzzzzzzzzzm_, pzzzzzzzzzzzzzzzzzzn_);

        return pzzzzzzzzzzzzzzzzzzo_;
    }


    [CqlExpressionDefinition("No Bone Density Scan Performed Due to Patient Refusal")]
    public IEnumerable<Observation> No_Bone_Density_Scan_Performed_Due_to_Patient_Refusal(CqlContext context)
    {
        CqlValueSet qzzzzzzzzzzzzzzzzzzw_ = this.DEXA_Dual_Energy_Xray_Absorptiometry__Bone_Density_for_Urology_Care(context);
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzx_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> qzzzzzzzzzzzzzzzzzzz_ = context.Operators.Retrieve<Observation>(new RetrieveParameters(default, qzzzzzzzzzzzzzzzzzzw_, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-observationnotdone"));
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzza_ = context.Operators.Union<Observation>(qzzzzzzzzzzzzzzzzzzx_, qzzzzzzzzzzzzzzzzzzz_);
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzb_(Observation DEXANotPerformed)
        {
            IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzd_ = this.Order_for_12_Months_of_ADT_in_3_Months_Before_to_9_Months_After_Start_of_Measurement_Period(context);
            bool? rzzzzzzzzzzzzzzzzzze_(ServiceRequest OrderTwelveMonthsADT)
            {
                Instant rzzzzzzzzzzzzzzzzzzi_ = DEXANotPerformed?.IssuedElement;
                DateTimeOffset? rzzzzzzzzzzzzzzzzzzj_ = rzzzzzzzzzzzzzzzzzzi_?.Value;
                CqlDateTime rzzzzzzzzzzzzzzzzzzk_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzj_);
                FhirDateTime rzzzzzzzzzzzzzzzzzzl_ = OrderTwelveMonthsADT?.AuthoredOnElement;
                CqlDateTime rzzzzzzzzzzzzzzzzzzm_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzl_);
                CqlDateTime rzzzzzzzzzzzzzzzzzzo_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzl_);
                CqlQuantity rzzzzzzzzzzzzzzzzzzp_ = context.Operators.Quantity(3m, "months");
                CqlDateTime rzzzzzzzzzzzzzzzzzzq_ = context.Operators.Add(rzzzzzzzzzzzzzzzzzzo_, rzzzzzzzzzzzzzzzzzzp_);
                CqlInterval<CqlDateTime> rzzzzzzzzzzzzzzzzzzr_ = context.Operators.Interval(rzzzzzzzzzzzzzzzzzzm_, rzzzzzzzzzzzzzzzzzzq_, true, true);
                bool? rzzzzzzzzzzzzzzzzzzs_ = context.Operators.In<CqlDateTime>(rzzzzzzzzzzzzzzzzzzk_, rzzzzzzzzzzzzzzzzzzr_, "day");
                CqlDateTime rzzzzzzzzzzzzzzzzzzu_ = context.Operators.Convert<CqlDateTime>(rzzzzzzzzzzzzzzzzzzl_);
                bool? rzzzzzzzzzzzzzzzzzzv_ = context.Operators.Not((bool?)(rzzzzzzzzzzzzzzzzzzu_ is null));
                bool? rzzzzzzzzzzzzzzzzzzw_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzs_, rzzzzzzzzzzzzzzzzzzv_);
                bool? rzzzzzzzzzzzzzzzzzzx_(Extension @this)
                {
                    string szzzzzzzzzzzzzzzzzzg_ = @this?.Url;
                    FhirString szzzzzzzzzzzzzzzzzzh_ = context.Operators.Convert<FhirString>(szzzzzzzzzzzzzzzzzzg_);
                    string szzzzzzzzzzzzzzzzzzi_ = FHIRHelpers_4_4_000.Instance.ToString(context, szzzzzzzzzzzzzzzzzzh_);
                    bool? szzzzzzzzzzzzzzzzzzj_ = context.Operators.Equal(szzzzzzzzzzzzzzzzzzi_, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-notDoneReason");

                    return szzzzzzzzzzzzzzzzzzj_;
                };
                IEnumerable<Extension> rzzzzzzzzzzzzzzzzzzy_ = context.Operators.Where<Extension>((IEnumerable<Extension>)(DEXANotPerformed is DomainResource
                        ? (DEXANotPerformed as DomainResource).Extension
                        : default), rzzzzzzzzzzzzzzzzzzx_);
                object rzzzzzzzzzzzzzzzzzzz_(Extension @this)
                {
                    DataType szzzzzzzzzzzzzzzzzzk_ = @this?.Value;

                    return szzzzzzzzzzzzzzzzzzk_;
                };
                IEnumerable<object> szzzzzzzzzzzzzzzzzza_ = context.Operators.Select<Extension, object>(rzzzzzzzzzzzzzzzzzzy_, rzzzzzzzzzzzzzzzzzzz_);
                object szzzzzzzzzzzzzzzzzzb_ = context.Operators.SingletonFrom<object>(szzzzzzzzzzzzzzzzzza_);
                CqlConcept szzzzzzzzzzzzzzzzzzc_ = FHIRHelpers_4_4_000.Instance.ToConcept(context, szzzzzzzzzzzzzzzzzzb_ as CodeableConcept);
                CqlValueSet szzzzzzzzzzzzzzzzzzd_ = this.Patient_Declined(context);
                bool? szzzzzzzzzzzzzzzzzze_ = context.Operators.ConceptInValueSet(szzzzzzzzzzzzzzzzzzc_, szzzzzzzzzzzzzzzzzzd_);
                bool? szzzzzzzzzzzzzzzzzzf_ = context.Operators.And(rzzzzzzzzzzzzzzzzzzw_, szzzzzzzzzzzzzzzzzze_);

                return szzzzzzzzzzzzzzzzzzf_;
            };
            IEnumerable<ServiceRequest> rzzzzzzzzzzzzzzzzzzf_ = context.Operators.Where<ServiceRequest>(rzzzzzzzzzzzzzzzzzzd_, rzzzzzzzzzzzzzzzzzze_);
            Observation rzzzzzzzzzzzzzzzzzzg_(ServiceRequest OrderTwelveMonthsADT) =>
                DEXANotPerformed;
            IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzh_ = context.Operators.Select<ServiceRequest, Observation>(rzzzzzzzzzzzzzzzzzzf_, rzzzzzzzzzzzzzzzzzzg_);

            return rzzzzzzzzzzzzzzzzzzh_;
        };
        IEnumerable<Observation> rzzzzzzzzzzzzzzzzzzc_ = context.Operators.SelectMany<Observation, Observation>(rzzzzzzzzzzzzzzzzzza_, rzzzzzzzzzzzzzzzzzzb_);

        return rzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Expressions

}
