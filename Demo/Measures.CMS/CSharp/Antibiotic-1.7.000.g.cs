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
[CqlLibrary("Antibiotic", "1.7.000")]
public partial class Antibiotic_1_7_000 : ILibrary, ISingleton<Antibiotic_1_7_000>
{
    private Antibiotic_1_7_000() {}

    public static Antibiotic_1_7_000 Instance { get; } = new();

    #region ILibrary Implementation

    public string Name => "Antibiotic";
    public string Version => "1.7.000";
    public ILibrary[] Dependencies => [FHIRHelpers_4_4_000.Instance, QICoreCommon_2_1_000.Instance, CumulativeMedicationDuration_4_1_000.Instance];

    #endregion ILibrary Implementation

    #region Parameters

    [CqlParameterDefinition("Measurement Period")]
    public CqlInterval<CqlDateTime> Measurement_Period(CqlContext context)
    {
        object wzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.ResolveParameter("Antibiotic-1.7.000", "Measurement Period", null);

        return (CqlInterval<CqlDateTime>)wzzzzzzzzzzzzzzzzzzzzzzzzc_;
    }


    #endregion Parameters

    #region Expressions

    [CqlExpressionDefinition("Patient")]
    public Patient Patient(CqlContext context)
    {
        IEnumerable<Patient> wzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Retrieve<Patient>(new RetrieveParameters(default, default, default, "http://hl7.org/fhir/us/qicore/StructureDefinition/qicore-patient"));
        Patient wzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.SingletonFrom<Patient>(wzzzzzzzzzzzzzzzzzzzzzzzzd_);

        return wzzzzzzzzzzzzzzzzzzzzzzzze_;
    }


    [CqlExpressionDefinition("Has Comorbid Condition History")]
    public IEnumerable<Encounter> Has_Comorbid_Condition_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> comorbidConditions)
    {
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter eDate)
        {
            bool? wzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition comcondition)
            {
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, comcondition);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzp_);
                Period wzzzzzzzzzzzzzzzzzzzzzzzzr_ = eDate?.Period;
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzs_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzt_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzs_ as object);
                CqlDateTime wzzzzzzzzzzzzzzzzzzzzzzzzu_ = context.Operators.Start(wzzzzzzzzzzzzzzzzzzzzzzzzt_);
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.DateFrom(wzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity wzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(1m, "year");
                CqlDate wzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Subtract(wzzzzzzzzzzzzzzzzzzzzzzzzv_, wzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> wzzzzzzzzzzzzzzzzzzzzzzzzz_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzza_ = QICoreCommon_2_1_000.Instance.toInterval(context, wzzzzzzzzzzzzzzzzzzzzzzzzz_ as object);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzza_);
                CqlDate xzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.DateFrom(xzzzzzzzzzzzzzzzzzzzzzzzzb_);
                CqlInterval<CqlDate> xzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Interval(wzzzzzzzzzzzzzzzzzzzzzzzzx_, xzzzzzzzzzzzzzzzzzzzzzzzzc_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.In<CqlDate>(wzzzzzzzzzzzzzzzzzzzzzzzzq_, xzzzzzzzzzzzzzzzzzzzzzzzzd_, default);

                return xzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Condition> wzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(comorbidConditions, wzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Encounter wzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition comcondition) =>
                eDate;
            IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Condition, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzl_, wzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return wzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, wzzzzzzzzzzzzzzzzzzzzzzzzf_);
        Encounter wzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzg_, wzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> wzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<Encounter>(wzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return wzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Competing Diagnosis History")]
    public IEnumerable<Encounter> Has_Competing_Diagnosis_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<Condition> competingConditions)
    {
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter eDate)
        {
            bool? xzzzzzzzzzzzzzzzzzzzzzzzzk_(Condition competcondition)
            {
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.prevalenceInterval(context, competcondition);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzo_);
                Period xzzzzzzzzzzzzzzzzzzzzzzzzq_ = eDate?.Period;
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzr_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzv_ = context.Operators.Start(xzzzzzzzzzzzzzzzzzzzzzzzzu_);
                CqlQuantity xzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Quantity(3m, "days");
                CqlDateTime xzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.Add(xzzzzzzzzzzzzzzzzzzzzzzzzv_, xzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlInterval<CqlDateTime> xzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Interval(xzzzzzzzzzzzzzzzzzzzzzzzzs_, xzzzzzzzzzzzzzzzzzzzzzzzzx_, true, true);
                bool? xzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.In<CqlDateTime>(xzzzzzzzzzzzzzzzzzzzzzzzzp_, xzzzzzzzzzzzzzzzzzzzzzzzzy_, "day");
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzb_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, xzzzzzzzzzzzzzzzzzzzzzzzzq_);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzc_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzb_);
                bool? yzzzzzzzzzzzzzzzzzzzzzzzzd_ = context.Operators.Not((bool?)(yzzzzzzzzzzzzzzzzzzzzzzzzc_ is null));
                bool? yzzzzzzzzzzzzzzzzzzzzzzzze_ = context.Operators.And(xzzzzzzzzzzzzzzzzzzzzzzzzz_, yzzzzzzzzzzzzzzzzzzzzzzzzd_);

                return yzzzzzzzzzzzzzzzzzzzzzzzze_;
            };
            IEnumerable<Condition> xzzzzzzzzzzzzzzzzzzzzzzzzl_ = context.Operators.Where<Condition>(competingConditions, xzzzzzzzzzzzzzzzzzzzzzzzzk_);
            Encounter xzzzzzzzzzzzzzzzzzzzzzzzzm_(Condition competcondition) =>
                eDate;
            IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzn_ = context.Operators.Select<Condition, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzl_, xzzzzzzzzzzzzzzzzzzzzzzzzm_);

            return xzzzzzzzzzzzzzzzzzzzzzzzzn_;
        };
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, xzzzzzzzzzzzzzzzzzzzzzzzzf_);
        Encounter xzzzzzzzzzzzzzzzzzzzzzzzzh_(Encounter eDate) =>
            eDate;
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Select<Encounter, Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzg_, xzzzzzzzzzzzzzzzzzzzzzzzzh_);
        IEnumerable<Encounter> xzzzzzzzzzzzzzzzzzzzzzzzzj_ = context.Operators.Distinct<Encounter>(xzzzzzzzzzzzzzzzzzzzzzzzzi_);

        return xzzzzzzzzzzzzzzzzzzzzzzzzj_;
    }


    [CqlExpressionDefinition("Has Antibiotic Medication History")]
    public IEnumerable<Encounter> Has_Antibiotic_Medication_History(CqlContext context, IEnumerable<Encounter> episodeDate, IEnumerable<MedicationRequest> antibioticMedications)
    {
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzf_(Encounter DateOfEpisode)
        {
            bool? yzzzzzzzzzzzzzzzzzzzzzzzzh_(MedicationRequest ActiveMedication)
            {
                CqlInterval<CqlDate> yzzzzzzzzzzzzzzzzzzzzzzzzl_ = CumulativeMedicationDuration_4_1_000.Instance.medicationRequestPeriod(context, ActiveMedication);
                Period yzzzzzzzzzzzzzzzzzzzzzzzzm_ = DateOfEpisode?.Period;
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzn_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzo_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzn_ as object);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzp_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzo_);
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzq_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzp_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzr_ = context.Operators.Quantity(30m, "days");
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzs_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzq_, yzzzzzzzzzzzzzzzzzzzzzzzzr_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzu_ = FHIRHelpers_4_4_000.Instance.ToInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzm_);
                CqlInterval<CqlDateTime> yzzzzzzzzzzzzzzzzzzzzzzzzv_ = QICoreCommon_2_1_000.Instance.toInterval(context, yzzzzzzzzzzzzzzzzzzzzzzzzu_ as object);
                CqlDateTime yzzzzzzzzzzzzzzzzzzzzzzzzw_ = context.Operators.Start(yzzzzzzzzzzzzzzzzzzzzzzzzv_);
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzx_ = context.Operators.DateFrom(yzzzzzzzzzzzzzzzzzzzzzzzzw_);
                CqlQuantity yzzzzzzzzzzzzzzzzzzzzzzzzy_ = context.Operators.Quantity(1m, "day");
                CqlDate yzzzzzzzzzzzzzzzzzzzzzzzzz_ = context.Operators.Subtract(yzzzzzzzzzzzzzzzzzzzzzzzzx_, yzzzzzzzzzzzzzzzzzzzzzzzzy_);
                CqlInterval<CqlDate> zzzzzzzzzzzzzzzzzzzzzzzzza_ = context.Operators.Interval(yzzzzzzzzzzzzzzzzzzzzzzzzs_, yzzzzzzzzzzzzzzzzzzzzzzzzz_, true, true);
                bool? zzzzzzzzzzzzzzzzzzzzzzzzzb_ = context.Operators.Overlaps(yzzzzzzzzzzzzzzzzzzzzzzzzl_, zzzzzzzzzzzzzzzzzzzzzzzzza_, "day");

                return zzzzzzzzzzzzzzzzzzzzzzzzzb_;
            };
            IEnumerable<MedicationRequest> yzzzzzzzzzzzzzzzzzzzzzzzzi_ = context.Operators.Where<MedicationRequest>(antibioticMedications, yzzzzzzzzzzzzzzzzzzzzzzzzh_);
            Encounter yzzzzzzzzzzzzzzzzzzzzzzzzj_(MedicationRequest ActiveMedication) =>
                DateOfEpisode;
            IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzk_ = context.Operators.Select<MedicationRequest, Encounter>(yzzzzzzzzzzzzzzzzzzzzzzzzi_, yzzzzzzzzzzzzzzzzzzzzzzzzj_);

            return yzzzzzzzzzzzzzzzzzzzzzzzzk_;
        };
        IEnumerable<Encounter> yzzzzzzzzzzzzzzzzzzzzzzzzg_ = context.Operators.SelectMany<Encounter, Encounter>(episodeDate, yzzzzzzzzzzzzzzzzzzzzzzzzf_);

        return yzzzzzzzzzzzzzzzzzzzzzzzzg_;
    }


    #endregion Expressions

}
